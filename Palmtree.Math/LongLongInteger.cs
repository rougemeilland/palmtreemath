/*
  LongLongInteger.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Palmtree.Math
{
    /// <summary>
    /// 多倍長整数のクラスです。
    /// </summary>
    [Serializable]
    public partial struct LongLongInteger
        : ISerializable
    {
        #region パブリックフィールド

        /// <summary>
        /// 整数0を示すインスタンスです。
        /// </summary>
        public static readonly LongLongInteger Zero;

        /// <summary>
        /// 整数1を示すインスタンスです。
        /// </summary>
        public static readonly LongLongInteger One;

        /// <summary>
        /// 整数-1を示すインスタンスです。
        /// </summary>
        public static readonly LongLongInteger MinusOne;

        #endregion

        #region プライベートフィールド

        private static string _member_name = "Value";
        private const ulong _nagated_long_min_value = 9223372036854775808UL;
        private static FormatterCreator _formatter_creator;
        private SignType _sign;
        private UnsignedLongLongInteger _abs;
        private int _bit_length;
        private bool _is_power_of_two;

        #endregion

        #region コンストラクタ

        static LongLongInteger()
        {
            Zero = new LongLongInteger();
            One = new LongLongInteger(SignType.Positive, UnsignedLongLongInteger.One);
            MinusOne = new LongLongInteger(SignType.Negative, UnsignedLongLongInteger.One);
            _formatter_creator = new FormatterCreator();
#if DEBUG
            System.Diagnostics.Debug.Assert("-" + _nagated_long_min_value.ToString() == long.MinValue.ToString());
#endif
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public LongLongInteger(int value)
            : this((long)value)
        {
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public LongLongInteger(long value)
        {
            if (value > 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger((ulong)value);
            }
            else if (value == 0)
            {
                _sign = SignType.Zero;
                _abs = UnsignedLongLongInteger.Zero;
            }
            else if (value == long.MinValue)
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger(_nagated_long_min_value);
            }
            else
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger((ulong)-value);
            }
            _bit_length = GetBitLength(_sign, _abs);
            _is_power_of_two = GetIsPowerOfTwo(_sign, _abs);
            System.Diagnostics.Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        [CLSCompliant(false)]
        public LongLongInteger(uint value)
            : this((ulong)value)
        {
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        [CLSCompliant(false)]
        public LongLongInteger(ulong value)
        {
            if (value > 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger(value);
            }
            else
            {
                _sign = SignType.Zero;
                _abs = UnsignedLongLongInteger.Zero;
            }
            _bit_length = GetBitLength(_sign, _abs);
            _is_power_of_two = GetIsPowerOfTwo(_sign, _abs);
            System.Diagnostics.Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public LongLongInteger(UnsignedLongLongInteger value)
        {
            if (value.IsZero)
            {
                _sign = SignType.Zero;
                _abs = UnsignedLongLongInteger.Zero;
            }
            else
            {
                _sign = SignType.Positive;
                _abs = value;
            }
            _bit_length = GetBitLength(_sign, _abs);
            _is_power_of_two = GetIsPowerOfTwo(_sign, _abs);
            System.Diagnostics.Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public LongLongInteger(float value)
            : this((double)value)
        {
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public LongLongInteger(double value)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
                throw (new ArgumentException(@"LongLongIntegerで表現できない値が指定されました。", "value"));
            if (value >= 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger(value);
            }
            else
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger(-value);
            }
            if (_abs.IsZero)
                _sign = SignType.Zero;
            _bit_length = GetBitLength(_sign, _abs);
            _is_power_of_two = GetIsPowerOfTwo(_sign, _abs);
            System.Diagnostics.Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public LongLongInteger(decimal value)
        {
            if (value >= 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger(value);
            }
            else
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger(-value);
            }
            if (_abs.IsZero)
                _sign = SignType.Zero;
            _bit_length = GetBitLength(_sign, _abs);
            _is_power_of_two = GetIsPowerOfTwo(_sign, _abs);
            System.Diagnostics.Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        private LongLongInteger(SerializationInfo info, StreamingContext context)
        {
            string s = info.GetString(_member_name);
            if (!TryParseImp(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out _sign, out _abs))
                throw (new FormatException(string.Format("文字列'{0}'はLongLongIntegerの形式ではありません。", s)));
            _bit_length = GetBitLength(_sign, _abs);
            _is_power_of_two = GetIsPowerOfTwo(_sign, _abs);
            System.Diagnostics.Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        internal LongLongInteger(SignType sign, UnsignedLongLongInteger value)
        {
            _sign = value.IsZero ? SignType.Zero : sign;
            _abs = value;
            _bit_length = GetBitLength(_sign, _abs);
            _is_power_of_two = GetIsPowerOfTwo(_sign, _abs);
            System.Diagnostics.Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// 値が正なら正の整数、値が0ならば0、値が負ならば負の整数です。
        /// </summary>
        public int Sign
        {
            get
            {
                return ((int)_sign);
            }
        }

        /// <summary>
        /// 値が0ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsZero
        {
            get
            {
                return (_sign == SignType.Zero);
            }
        }

        /// <summary>
        /// 値が1ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsOne
        {
            get
            {
                return (_sign == SignType.Positive && _abs.IsOne);
            }
        }

        /// <summary>
        /// 値が-1ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsMinusOne
        {
            get
            {
                return (_sign == SignType.Negative && _abs.IsOne);
            }
        }

        /// <summary>
        /// 値が偶数ならばtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsEven
        {
            get
            {
                return (_abs.IsEven);
            }
        }

        #endregion

        #region インターナルメソッド

        internal long ToLong(Type target_type)
        {
            ulong value = _abs.ToULong(target_type);
            switch (_sign)
            {
                case SignType.Zero:
                    return (0L);
                case SignType.Positive:
                    if (value > long.MaxValue)
                        throw (CreateOverflowExceptionObject(target_type, this));
                    return ((long)value);
                default:
                    if (value == _nagated_long_min_value)
                        return (long.MinValue);
                    else if (value >= _nagated_long_min_value)
                        throw (CreateOverflowExceptionObject(target_type, this));
                    return (-(long)value);
            }
        }

        internal SignType InternalSign
        {
            get
            {
                return (_sign);
            }
        }

        #endregion

        #region プライベートメソッド

        private static int GetBitLength(SignType sign, UnsignedLongLongInteger abs)
        {
            if (sign == SignType.Positive)
                return (abs.BitLength);
            else if (sign == SignType.Zero)
                return (0);
            else
                return (abs.Decrement().BitLength);
        }

        private static bool GetIsPowerOfTwo(SignType sign, UnsignedLongLongInteger abs)
        {
            return (sign == SignType.Positive && abs.IsPowerOfTwo);
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
                return (Equals((ulong)o));
            else if (o is long)
                return (Equals((long)o));
            else if (o is UnsignedLongLongInteger)
                return (Equals((UnsignedLongLongInteger)o));
            else if (o is LongLongInteger)
                return (Equals((LongLongInteger)o));
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
            return (_sign.GetHashCode() ^ _abs.GetHashCode());
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