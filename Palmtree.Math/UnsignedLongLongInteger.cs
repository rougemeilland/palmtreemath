/*
  UnsignedLongLongInteger.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using Palmtree.Math.Formatter;

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
        private NativeUnsignedInteger __internal_value;
        //private int? _bit_length_cache;
        //private bool? _is_power_of_two_cache;

        #endregion

        #region プライベートプロパティ

        /*
        private NativeUnsignedInteger _InternalValue
        {
            get
            {
                if (__internal_value == null)
                    __internal_value = NativeUnsignedInteger.Zero;
                return (__internal_value);
            }

            set
            {
                if (value == null)
                    throw (new ArgumentNullException());
                __internal_value = value;
            }
        }
        */

        #endregion

        #region コンストラクタ

        static UnsignedLongLongInteger()
        {
            Zero = new UnsignedLongLongInteger(NativeUnsignedInteger.Zero);
            One = new UnsignedLongLongInteger(NativeUnsignedInteger.One);
            Ten = new UnsignedLongLongInteger(new NativeUnsignedInteger(10));
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
                throw (new ArgumentException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
            __internal_value = new NativeUnsignedInteger((uint)value);
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
            __internal_value = new NativeUnsignedInteger(value);
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
            __internal_value = new NativeUnsignedInteger(value);
        }

        private UnsignedLongLongInteger(SerializationInfo info, StreamingContext context)
        {
            string s = info.GetString(_member_name);
            NativeUnsignedInteger result;
            if (!TryParseImp(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out result))
                throw (new FormatException(string.Format("文字列'{0}'はUnsignedLongLongIntegerの形式ではありません。", s)));
            __internal_value = result;
            //_bit_length_cache = null;
            //_is_power_of_two_cache = null;
        }

        internal UnsignedLongLongInteger(NativeUnsignedInteger value)
        {
            __internal_value = value;
        }

        #endregion

        #region パブリックメソッド

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// 値が0ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsZero
        {
            get
            {
                return (__internal_value.IsZero);
            }
        }

        /// <summary>
        /// 値が1ならtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsOne
        {
            get
            {
                return ((_InternalValue.Length == 1) && (_InternalValue[0] == 1));
            }
        }

        /// <summary>
        /// 値が偶数ならばtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsEven
        {
            get
            {
                if (_InternalValue.Length == 0)
                    return (true);
                Debug.Assert(_InternalValue.Length > 0);
                return ((_InternalValue[0] & 1) == 0);
            }
        }

        #endregion

        #region インターナルメソッド

        internal ushort[] GetInternalValue()
        {
            return (_InternalValue);
        }

        internal ulong ToULong(Type target_type)
        {
            ushort[] value = _InternalValue;
            if (value.Length > 4)
                throw (CreateOverflowExceptionObject(target_type, this));
            return (ToULong(value));
        }

        internal bool EqualsInternally(ArraySegment<ushort> data)
        {
            if (_InternalValue.Length != data.Count)
                return (false);
            for (int index = 0; index < data.Count; ++index)
            {
                if (_InternalValue[index] != data.Array[index + data.Offset])
                    return (false);
            }
            return (true);
        }

        #endregion

        #region プライベートメソッド

        private static ulong ToULong(ushort[] value)
        {
            if (value.Length == 0)
                return (0);
            ulong result = value[0];
            if (value.Length >= 2)
            {
                result += ((ulong)value[1] << 16);
                if (value.Length >= 3)
                {
                    result += ((ulong)value[2] << 32);
                    if (value.Length >= 4)
                        result += ((ulong)value[3] << 48);
                }
            }
            return (result);
        }

        private static ushort[] CreateInternalValue(ulong value)
        {
            Debug.Assert(value > ushort.MaxValue);
            if (value <= 0xffffffff)
                return (new ushort[] { (ushort)value, (ushort)(value >> 16) });
            else if (value <= 0xffffffffffff)
                return (new ushort[] { (ushort)value, (ushort)(value >> 16), (ushort)(value >> 32), });
            else
                return (new ushort[] { (ushort)value, (ushort)(value >> 16), (ushort)(value >> 32), (ushort)(value >> 48), });
        }

        private static ushort[] CreateInternalValue(ArraySegment<ushort> data)
        {
            ushort[] value = new ushort[data.Count];
            Array.Copy(data.Array, data.Offset, value, 0, data.Count);
            return (value);
        }

        private static ushort[] FromDoubleImp(double value)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
                throw (new ArgumentException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
            value = System.Math.Truncate(value);
            if (value < 0)
                throw (new ArgumentException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
            List<ushort> digits = new List<ushort>();
            value = System.Math.Round(value);
            while (value >= 1)
            {
                double t = System.Math.Floor(value / 0x10000U);
                if (double.IsInfinity(t) || double.IsNaN(t))
                    throw (new ArgumentException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
                double digit = value - t * 0x10000U;
                if (double.IsInfinity(digit) || double.IsNaN(digit))
                    throw (new ArgumentException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
                digits.Add((ushort)digit);
                value = t;
                if (double.IsInfinity(value) || double.IsNaN(value))
                    throw (new ArgumentException(@"UnsignedLongLongIntegerで表現できない値が指定されました。", "value"));
            }
            return (digits.ToArray());
        }

        private static ushort[] FromDecimalImp(decimal value)
        {
            int[] bits = decimal.GetBits(value);
            ushort[] mantissa;
            if (bits[2] == 0)
            {
                if (bits[1] == 0)
                {
                    if (bits[0] == 0)
                        mantissa = new ushort[0];
                    else
                    {
                        if ((bits[0] & 0xffff0000) == 0)
                            mantissa = new ushort[] { (ushort)bits[0] };
                        else
                            mantissa = new ushort[] { (ushort)bits[0], (ushort)(bits[0] >> 16) };
                    }
                }
                else
                {
                    if ((bits[1] & 0xffff0000) == 0)
                        mantissa = new ushort[] { (ushort)bits[0], (ushort)(bits[0] >> 16), (ushort)bits[1] };
                    else
                        mantissa = new ushort[] { (ushort)bits[0], (ushort)(bits[0] >> 16), (ushort)bits[1], (ushort)(bits[1] >> 16) };
                }
            }
            else
            {
                if ((bits[2] & 0xffff0000) == 0)
                    mantissa = new ushort[] { (ushort)bits[0], (ushort)(bits[0] >> 16), (ushort)bits[1], (ushort)(bits[1] >> 16), (ushort)bits[2] };
                else
                    mantissa = new ushort[] { (ushort)bits[0], (ushort)(bits[0] >> 16), (ushort)bits[1], (ushort)(bits[1] >> 16), (ushort)bits[2], (ushort)(bits[2] >> 16) };
            }
            if ((bits[3] & 0xffff) != 0)
                throw (new ArgumentException("与えられたdecimalオブジェクトの形式に誤りがあります。", "value"));
            int exponent = (bits[3] >> 16) & 0xff;
            if (exponent < 0 || exponent > 28)
                throw (new ArgumentException("与えられたdecimalオブジェクトの形式に誤りがあります。", "value"));
            if ((bits[3] & 0x7f000000) != 0)
                throw (new ArgumentException("与えられたdecimalオブジェクトの形式に誤りがあります。", "value"));
            bool negative = (bits[3] & 0x80000000) != 0;
            while (exponent >= 4 && mantissa.Length > 0)
            {
                ushort r;
                mantissa = _imp.DivideRem(mantissa, (ushort)10000, out r);
                exponent -= 4;
            }
            while (exponent >= 1 && mantissa.Length > 0)
            {
                ushort r;
                mantissa = _imp.DivideRem(mantissa, (ushort)10, out r);
                --exponent;
            }
            if (mantissa.Length == 0)
                negative = false;
            if (negative)
                throw (new ArgumentException(string.Format(@"与えられたdecimalオブジェクト'{0}'がUnsignedLongLongIntegerで表現できません。", value), "value"));
            return (mantissa);
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
                return (UnsignedLongLongInteger.Equals(this, (ulong)o));
            else if (o is UnsignedLongLongInteger)
                return (UnsignedLongLongInteger.Equals(this, (UnsignedLongLongInteger)o));
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
            uint hash_code = 0;
            for (int index = 0; index < _InternalValue.Length; ++index)
            {

                if ((index & 1) == 0)
                    hash_code |= _InternalValue[index];
                else
                    hash_code |= ((uint)_InternalValue[index] << 16);
            }
            return ((int)hash_code);
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
