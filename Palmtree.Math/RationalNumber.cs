/*
  RationalNumber.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using Palmtree.Math.Formatter;
using Palmtree.Math.Round;

namespace Palmtree.Math
{
    /// <summary>
    /// 加減乗除により精度が損なわれない数のクラスです。
    /// </summary>
    [Serializable]
    public partial struct RationalNumber
        : ISerializable
    {
        #region パブリックフィールド

        /// <summary>
        /// 0を示すインスタンスです。
        /// </summary>
        public static readonly RationalNumber Zero;

        /// <summary>
        /// 1を示すインスタンスです。
        /// </summary>
        public static readonly RationalNumber One;

        /// <summary>
        /// -1を示すインスタンスです。
        /// </summary>
        public static readonly RationalNumber MinusOne;

        #endregion

        #region プライベートフィールド

        private static string _member_name = "Value";
        private const ulong _nagated_long_min_value = 9223372036854775808UL;
        private static RationalNumberRounderCollection _rounders;
        private static IBaseNumberInfo _decimal_base_number_info;
        private static FormatterCreator _formatter_creator;
        private LongLongInteger? __InternalNumerator;
        private UnsignedLongLongInteger? __InternalDenominator;

        #endregion

        #region プライベートプロパティ

        private LongLongInteger _InternalNumerator
        {
            get
            {
                if (!__InternalNumerator.HasValue)
                    __InternalNumerator = LongLongInteger.Zero;
                return (__InternalNumerator.Value);
            }

            set
            {
                __InternalNumerator = value;
            }
        }

        private UnsignedLongLongInteger _InternalDenominator
        {
            get
            {
                if (!__InternalDenominator.HasValue)
                    __InternalDenominator = UnsignedLongLongInteger.One;
                return (__InternalDenominator.Value);
            }

            set
            {
                __InternalDenominator = value;
            }
        }

        #endregion

        #region コンストラクタ

        static RationalNumber()
        {
            Zero = new RationalNumber(LongLongInteger.Zero, UnsignedLongLongInteger.One);
            One = new RationalNumber(LongLongInteger.One, UnsignedLongLongInteger.One);
            MinusOne = new RationalNumber(LongLongInteger.MinusOne, UnsignedLongLongInteger.One);
            _rounders = new RationalNumberRounderCollection();
            _decimal_base_number_info = DecimalBaseNumberInfo.DefaultInstance;
            _formatter_creator = new FormatterCreator();
#if DEBUG
            Debug.Assert("-" + _nagated_long_min_value.ToString() == long.MinValue.ToString());
#endif
        }

#if false
        /// <summary>
        /// デフォルトコンストラクタです。
        /// </summary>
        public RationalNumber()
            : this(LongLongInteger.Zero, UnsignedLongLongInteger.One)
        {
        }
#endif

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数値です。
        /// </param>
        public RationalNumber(int value)
            : this((long)value)
        {
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数値です。
        /// </param>
        public RationalNumber(long value)
        {
            __InternalNumerator = new LongLongInteger(value);
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数値です。
        /// </param>
        [CLSCompliant(false)]
        public RationalNumber(uint value)
            : this((ulong)value)
        {
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数値です。
        /// </param>
        [CLSCompliant(false)]
        public RationalNumber(ulong value)
        {
            __InternalNumerator = new LongLongInteger(value);
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる分数値です。
        /// </param>
        public RationalNumber(UnsignedLongLongInteger value)
        {
            __InternalNumerator = value.ToLongLongInteger();
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる分数値です。
        /// </param>
        public RationalNumber(LongLongInteger value)
        {
            __InternalNumerator = value;
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる分数値です。
        /// </param>
        public RationalNumber(float value)
            : this((double)value)
        {
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる分数値です。
        /// </param>
        public RationalNumber(double value)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
                throw (new ArgumentException(@"LongLongIntegerで表現できない値が指定されました。", "value"));
            bool negative = false;
            if (value < 0)
            {
                negative = true;
                value = -value;
            }
            if (value == 0)
            {
                __InternalNumerator = LongLongInteger.Zero;
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else if (value >= (1L << 51))
            {
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else
            {
                int d = 0;
                double l = (double)(1UL << 21);
                double m = (double)(1UL << 32);
                while (value < l)
                {
                    value *= m;
                    d += 32;
                }
                l = (double)(1UL << 45);
                m = (double)(1UL << 8);
                while (value < l)
                {
                    value *= m;
                    d += 8;
                }
                l = (double)(1UL << 51);
                m = (double)(1UL << 2);
                while (value < l)
                {
                    value *= m;
                    d += 2;
                }
                l = (double)(1UL << 52);
                m = (double)(1UL << 1);
                while (value < l)
                {
                    value *= m;
                    d += 1;
                }
                Debug.Assert(value <= (1UL << 53) - 1);
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.One.LeftShift(d);
                Reduce();
            }
        }

        /// <summary>
        /// コンストラクタです。
        /// 指定された整数の値を持つインスタンスを作成します。
        /// </summary>
        /// <param name="value">
        /// 初期値となる分数値です。
        /// </param>
        public RationalNumber(decimal value)
        {
            bool negative = false;
            if (value < 0)
            {
                negative = true;
                value = -value;
            }
            if (value == 0)
            {
                __InternalNumerator = LongLongInteger.Zero;
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else if (value >= 10000000000000000000000000000m)
            {
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else
            {
                ulong d = 0;
                decimal l = 7922816251426m;
                decimal m = 10000000000000000m;
                while (value < l)
                {
                    value *= m;
                    d += 16;
                }
                l = 7922816251426433759354395m;
                m = 10000m;
                while (value < l)
                {
                    value *= m;
                    d += 4;
                }
                l = 7922816251426433759354395033m;
                m = 10m;
                while (value < l)
                {
                    value *= m;
                    d += 1;
                }
                Debug.Assert(value >= 7922816251426433759354395033m && value <= 79228162514264337593543950335m);
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.Power(UnsignedLongLongInteger.Ten, d);
                Reduce();
            }
        }

        private RationalNumber(SerializationInfo info, StreamingContext context)
        {
            string s = info.GetString(_member_name);
            LongLongInteger result_numerator;
            UnsignedLongLongInteger result_denominator;
            if (!TryParseImp(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out result_numerator, out result_denominator))
                throw (new FormatException(string.Format("文字列'{0}'はRationalNumberの形式ではありません。", s)));
            __InternalNumerator = result_numerator;
            __InternalDenominator = result_denominator;
            Reduce();
        }

        private RationalNumber(LongLongInteger numerator, UnsignedLongLongInteger denominator)
        {
            if (denominator.IsZero)
                throw (new ArgumentException("分母として0が与えられました。", "denominator"));
            __InternalNumerator = numerator;
            __InternalDenominator = denominator;
            Reduce();
        }

        #endregion

        #region パブリックメソッド

        /// <summary>
        /// オブジェクトを分数で表現した場合の分子と分母を取得します。
        /// 取得される分子と分母は既約です。
        /// </summary>
        /// <param name="denominator">
        /// オブジェクトを分数で表現した場合の分母要素の値です。
        /// </param>
        /// <returns>
        /// オブジェクトを分数で表現した場合の分子要素の値です。
        /// </returns>
        public LongLongInteger ToFraction(out UnsignedLongLongInteger denominator)
        {
            denominator = _InternalDenominator;
            return (_InternalNumerator);
        }

#if DEBUG

        /// <summary>
        /// テストデータから<see cref="RationalNumber"/>オブジェクトを生成します。
        /// </summary>
        /// <param name="data">
        /// テストデータです。
        /// </param>
        /// <returns>
        /// 生成された<see cref="RationalNumber"/>オブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber FromTestData(ushort[] data)
        {
            TestDataReader reader = new TestDataReader(data);
            ushort header = reader.GetUShortValue();
            SignType data_sign;
            if (header == 3)
                data_sign = SignType.Positive;
            else if (header == 4)
                data_sign = SignType.Negative;
            else
                throw (new ArgumentException("テストデータの形式に誤りがあります。", "data"));
            ArraySegment<ushort> data_numerator = reader.GetSegment();
            ArraySegment<ushort> data_denominator = reader.GetSegment();
            reader.AssertEndOfData();
            if (data_numerator.Count == 0)
                return (Zero);
            else
                return (new RationalNumber(new LongLongInteger(data_sign, new UnsignedLongLongInteger(data_numerator)), new UnsignedLongLongInteger(data_denominator)));
        }

        /// <summary>
        /// オブジェクトの内容を検査します。
        /// </summary>
        /// <param name="data">
        /// オブジェクトの内容を検査するための比較データです。
        /// </param>
        /// <returns>
        /// 検査に成功すればtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public bool EqualsInternally(ushort[] data)
        {
            TestDataReader reader = new TestDataReader(data);
            ushort header = reader.GetUShortValue();
            SignType data_sign;
            if (header == 3)
                data_sign = SignType.Positive;
            else if (header == 4)
                data_sign = SignType.Negative;
            else
                throw (new ArgumentException("テストデータの形式に誤りがあります。", "data"));
            ArraySegment<ushort> data_numerator = reader.GetSegment();
            ArraySegment<ushort> data_denominator = reader.GetSegment();
            reader.AssertEndOfData();
            if (data_numerator.Count == 0)
                data_sign = SignType.Zero;
            return (_InternalNumerator.EqualsInternally(data_sign, data_numerator) && _InternalDenominator.EqualsInternally(data_denominator));
        }

#endif

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// 値が正なら正の整数、値が0ならば0、値が負ならば負の整数です。
        /// </summary>
        public int Sign
        {
            get
            {
                return (_InternalNumerator.Sign);
            }
        }

        /// <summary>
        /// 値が0ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsZero
        {
            get
            {
                return (_InternalNumerator.IsZero);
            }
        }

        /// <summary>
        /// 値が1ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsOne
        {
            get
            {
                return (_InternalNumerator.IsOne && _InternalDenominator.IsOne);
            }
        }

        /// <summary>
        /// 値が-1ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsMinusOne
        {
            get
            {
                return (_InternalNumerator.IsMinusOne && _InternalDenominator.IsOne);
            }
        }

        #endregion

        #region プライベートメソッド

        private void Reduce()
        {
            UnsignedLongLongInteger gcd = _InternalNumerator.GreatestCommonDivisor(_InternalDenominator);
            if (!gcd.IsZero && !gcd.IsOne)
            {
                _InternalNumerator = _InternalNumerator.DivideExactly(gcd);
                _InternalDenominator = _InternalDenominator.DivideExactly(gcd);
            }
        }

        #endregion

        #region object から継承されたメンバ

        /// <summary>
        /// オブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public override bool Equals(object o)
        {
            if (o == null)
                return (false);
            else if (o is ulong)
                return (Equals(this, (ulong)o));
            else if (o is long)
                return (Equals(this, (long)o));
            else if (o is UnsignedLongLongInteger)
                return (Equals(this, (UnsignedLongLongInteger)o));
            else if (o is LongLongInteger)
                return (Equals(this, (LongLongInteger)o));
            else if (o is RationalNumber)
                return (Equals(this, (RationalNumber)o));
            else
                return (false);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを計算します。
        /// </summary>
        /// <returns>
        /// 計算結果のハッシュコードです。
        /// </returns>
        public override int GetHashCode()
        {
            return (_InternalNumerator.GetHashCode() ^ _InternalDenominator.GetHashCode());
        }

        /// <summary>
        /// オブジェクトを表現する文字列を作成します。
        /// </summary>
        /// <returns>
        /// オブジェクトを表現する文字列です。
        /// </returns>
        public override string ToString()
        {
            return (ToString("G", null));
        }

        #endregion

        #region ISerializable メンバ

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(_member_name, ToString("R", CultureInfo.InvariantCulture));
        }

        #endregion
    }
}
