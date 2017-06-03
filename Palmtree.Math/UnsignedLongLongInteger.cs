/*
  UnsignedLongLongInteger.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Globalization;
using System.Runtime.Serialization;
using Palmtree.Math.Formatter;
using Palmtree.Math.Implements;

namespace Palmtree.Math
{
    /// <summary>
    /// 多倍長整数のクラスです。
    /// </summary>
    [Serializable]
    public partial struct UnsignedLongLongInteger
        : ISerializable
    {
        #region パブリックフィールド

        /// <summary>
        /// 整数0を示すインスタンスです。
        /// </summary>
        public static readonly UnsignedLongLongInteger Zero;

        /// <summary>
        /// 整数1を示すインスタンスです。
        /// </summary>
        public static readonly UnsignedLongLongInteger One;

        /// <summary>
        /// 整数10を示すインスタンスです。
        /// </summary>
        public static readonly UnsignedLongLongInteger Ten;

        #endregion

        #region プライベートフィールド

        private static string _member_name = "Value";
        private static IBaseNumberInfo _decimal_base_number_info;
        private static IBaseNumberInfo _upper_case_hexadecimal_base_number_info;
        private static IBaseNumberInfo _lower_case_hexadecimal_base_number_info;
        private static FormatterCreator _formatter_creator;
        private NativeUnsignedInteger _native_value;

        #endregion

        #region コンストラクタ

        static UnsignedLongLongInteger()
        {
            Zero = new UnsignedLongLongInteger(NativeUnsignedInteger.Zero);
            One = new UnsignedLongLongInteger(NativeUnsignedInteger.One);
            Ten = new UnsignedLongLongInteger(10);
            _decimal_base_number_info = DecimalBaseNumberInfo.DefaultInstance;
            _upper_case_hexadecimal_base_number_info = HexaDecimalBaseNumberInfo.DefaultInstanceUsingUpperCaseDigit;
            _lower_case_hexadecimal_base_number_info = HexaDecimalBaseNumberInfo.DefaultInstanceUsingLowerCaseDigit;
            _formatter_creator = new FormatterCreator();
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public UnsignedLongLongInteger(int value)
        {
            if (value < 0)
                throw (new ArgumentOutOfRangeException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
            if (value == 0)
                _native_value = NativeUnsignedInteger.Zero;
            else
                _native_value = new NativeUnsignedInteger((uint)value);
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public UnsignedLongLongInteger(long value)
        {
            if (value < 0)
                throw (new ArgumentOutOfRangeException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
            if (value == 0)
                _native_value = NativeUnsignedInteger.Zero;
            else
                _native_value = new NativeUnsignedInteger((ulong)value);
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger(uint value)
        {
            if (value == 0)
                _native_value = NativeUnsignedInteger.Zero;
            else
                _native_value = new NativeUnsignedInteger(value);
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger(ulong value)
        {
            if (value == 0)
                _native_value = NativeUnsignedInteger.Zero;
            else
                _native_value = new NativeUnsignedInteger(value);
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public UnsignedLongLongInteger(float value)
            : this((double)value)
        {
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public UnsignedLongLongInteger(double value)
        {
            try
            {
                var base_number = 0x80000000U; // UInt32で表現できる最も大きい2のべき乗の値
                _native_value = FromFloatingPointNUmberImp(value, base_number, x => x.CompareTo(0D), x =>
                {
                    var q = System.Math.Floor(x / base_number);
                    var r = (UInt32)(x - q * base_number);
                    return (new Tuple<double, UInt32>(q, r));
                });
            }
            catch
            {
                throw (new ArgumentOutOfRangeException("value", value, @"UnsignedLongLongIntegerで表現できない値が指定されました。"));
            }
        }

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="value">
        /// 初期値となる整数です。
        /// </param>
        public UnsignedLongLongInteger(decimal value)
        {
            try
            {
                var base_number = 1000000000U; // UInt32で表現できる最も大きい10のべき乗の値
                _native_value = FromFloatingPointNUmberImp(value, base_number, x => x.CompareTo(0M), x =>
                {
                    var q = System.Math.Floor(x / base_number);
                    var r = (UInt32)(x - q * base_number);
                    return (new Tuple<decimal, UInt32>(q, r));
                });
            }
            catch
            {
                throw (new ArgumentOutOfRangeException("value", value, @"UnsignedLongLongIntegerで表現できない値が指定されました。"));
            }
        }

        private UnsignedLongLongInteger(SerializationInfo info, StreamingContext context)
        {
            string s = info.GetString(_member_name);
            NativeUnsignedInteger result;
            if (!TryParseImp(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out result))
                throw (new FormatException(string.Format("文字列'{0}'はUnsignedLongLongIntegerの形式ではありません。", s)));
            _native_value = result;
        }

        internal UnsignedLongLongInteger(NativeUnsignedInteger value)
        {
            _native_value = value;
        }

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// 値が0ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsZero
        {
            get
            {
                return (_native_value.IsZero);
            }
        }

        /// <summary>
        /// 値が1ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsOne
        {
            get
            {
                return (_native_value.IsOne);
            }
        }

        /// <summary>
        /// 値が偶数ならばtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsEven
        {
            get
            {
                return (_native_value.IsEven);
            }
        }

        #endregion

        #region インターナルメソッド

        internal NativeUnsignedInteger GetInternalValue()
        {
            return (_native_value);
        }

        internal ulong ToULong(Type target_type)
        {
            try
            {
                return (_native_value.ToUInt64());
            }
            catch
            {
                throw (CreateOverflowExceptionObject(target_type, this));
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
            else if (o is uint)
                return (Equals(this, (uint)o));
            else if (o is ulong)
                return (Equals(this, (ulong)o));
            else if (o is UnsignedLongLongInteger)
                return (Equals(this, (UnsignedLongLongInteger)o));
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
            return (_native_value.GetHashCode());
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