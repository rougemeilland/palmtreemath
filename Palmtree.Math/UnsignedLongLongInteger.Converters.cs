/*
  UnsignedLongLongInteger.Converters.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// 演算子のオーバーロードに関するガイドライン:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx
// 変換演算子のガイドライン：
//   http://msdn.microsoft.com/ja-jp/library/ms229033(v=VS.100).aspx

using System.Collections.Generic;
using Palmtree.Math.Implements;

namespace Palmtree.Math
{
    partial struct UnsignedLongLongInteger
         : IConvertible
    {
        #region 演算子

#if !CONCEAL_OPERATORS

        /// <summary>
        /// <see cref="sbyte"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator UnsignedLongLongInteger(sbyte o)
        {
            return (FromSByte(o));
        }

        /// <summary>
        /// <see cref="short"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(short o)
        {
            return (FromInt16(o));
        }

        /// <summary>
        /// <see cref="int"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(int o)
        {
            return (FromInt32(o));
        }

        /// <summary>
        /// <see cref="long"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(long o)
        {
            return (FromInt64(o));
        }

#if !CONCEAL_IMPLICIT_OPERATORS


        /// <summary>
        /// <see cref="byte"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static implicit operator UnsignedLongLongInteger(byte o)
        {
            return (FromByte(o));
        }

        /// <summary>
        /// <see cref="ushort"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator UnsignedLongLongInteger(ushort o)
        {
            return (FromUInt16(o));
        }

        /// <summary>
        /// <see cref="uint"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator UnsignedLongLongInteger(uint o)
        {
            return (FromUInt32(o));
        }

        /// <summary>
        /// <see cref="ulong"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator UnsignedLongLongInteger(ulong o)
        {
            return (FromUInt64(o));
        }

#endif

        /// <summary>
        /// <see cref="float"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(float o)
        {
            return (FromSingle(o));
        }

        /// <summary>
        /// <see cref="double"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(double o)
        {
            return (FromDouble(o));
        }

        /// <summary>
        /// <see cref="decimal"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(decimal o)
        {
            return (FromDecimal(o));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="sbyte"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator sbyte(UnsignedLongLongInteger o)
        {
            return (o.ToSByte());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="short"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator short(UnsignedLongLongInteger o)
        {
            return (o.ToInt16());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="int"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator int(UnsignedLongLongInteger o)
        {
            return (o.ToInt32());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="long"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator long(UnsignedLongLongInteger o)
        {
            return (o.ToInt64());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="byte"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator byte(UnsignedLongLongInteger o)
        {
            return (o.ToByte());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="ushort"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ushort(UnsignedLongLongInteger o)
        {
            return (o.ToUInt16());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="uint"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator uint(UnsignedLongLongInteger o)
        {
            return (o.ToUInt32());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="ulong"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ulong(UnsignedLongLongInteger o)
        {
            return (o.ToUInt64());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="float"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator float(UnsignedLongLongInteger o)
        {
            return (o.ToSingle());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="double"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator double(UnsignedLongLongInteger o)
        {
            return (o.ToDouble());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="decimal"/>型に変換する演算子です。
        /// </summary>
        /// <param name="o">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static explicit operator decimal(UnsignedLongLongInteger o)
        {
            return (o.ToDecimal());
        }

#endif

        #endregion

        #region パブリックメソッド

        /// <summary>
        /// <see cref="sbyte"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromSByte(sbyte value)
        {
            try
            {
                return (new UnsignedLongLongInteger((long)value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="short"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger FromInt16(short value)
        {
            try
            {
                return (new UnsignedLongLongInteger((long)value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="int"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger FromInt32(int value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="long"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger FromInt64(long value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="byte"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger FromByte(byte value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="ushort"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromUInt16(ushort value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="uint"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromUInt32(uint value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="ulong"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromUInt64(ulong value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="float"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger FromSingle(float value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="double"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger FromDouble(double value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="decimal"/>オブジェクトを明示的に<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger FromDecimal(decimal value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="sbyte"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public sbyte ToSByte()
        {
            return ((sbyte)CastToUnsignedInteger(typeof(sbyte), (ulong)sbyte.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="short"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public short ToInt16()
        {
            return ((short)CastToUnsignedInteger(typeof(short), (ulong)short.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="int"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public int ToInt32()
        {
            return ((int)CastToUnsignedInteger(typeof(int), (ulong)int.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="long"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public long ToInt64()
        {
            return ((long)CastToUnsignedInteger(typeof(long), (ulong)long.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="byte"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public byte ToByte()
        {
            return ((byte)CastToUnsignedInteger(typeof(byte), (ulong)byte.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="ushort"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public ushort ToUInt16()
        {
            return ((ushort)CastToUnsignedInteger(typeof(ushort), (ulong)ushort.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="uint"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public uint ToUInt32()
        {
            return ((uint)CastToUnsignedInteger(typeof(uint), (ulong)uint.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="ulong"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public ulong ToUInt64()
        {
            return ((ulong)CastToUnsignedInteger(typeof(ulong), (ulong)ulong.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="float"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public float ToSingle()
        {
            try
            {
                var base_number = 0x80000000U; // UInt32で表現できる最も大きい2のべき乗の値
                return (ToFloatingPointNUmberImp(_native_value, base_number, 0F, value => value, (value, digit) =>
                {
                    var result = value * base_number + digit;
                    if (float.IsInfinity(result) || float.IsNaN(result))
                        throw new OverflowException();
                    return (result);
                }));
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(decimal), this, e));
            }
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="double"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public double ToDouble()
        {
            try
            {
                var base_number = 0x80000000U; // UInt32で表現できる最も大きい2のべき乗の値
                return (ToFloatingPointNUmberImp(_native_value, base_number, 0D, value => value, (value, digit) =>
                {
                    var result = value * base_number + digit;
                    if (double.IsInfinity(result) || double.IsNaN(result))
                        throw new OverflowException();
                    return (result);
                }));
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(decimal), this, e));
            }
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを明示的に<see cref="decimal"/>型に変換します。
        /// </summary>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public decimal ToDecimal()
        {
            try
            {
                var base_number = 1000000000U; // UInt32で表現できる最も大きい10のべき乗の値
                return (ToFloatingPointNUmberImp(_native_value, base_number, 0M, value => value, (value, digit) => value * base_number + digit));
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(decimal), this, e));
            }
        }

        #endregion

        #region プライベートメソッド

        private bool ToBoolean()
        {
            return (!_native_value.IsZero);
        }

        private char ToChar()
        {
            return ((char)CastToUnsignedInteger(typeof(char), (ulong)char.MaxValue));
        }

        private ulong CastToUnsignedInteger(Type target_type, ulong max_value)
        {
            ulong value = ToULong(target_type);
            if (value > (ulong)max_value)
                throw (CreateOverflowExceptionObject(target_type, this));
            return (value);
        }

        private static NativeUnsignedInteger FromFloatingPointNUmberImp<SOURCE_T>(SOURCE_T x, UInt32 base_number, Func<SOURCE_T, int> sign_getter, Func<SOURCE_T, Tuple<SOURCE_T, UInt32>> divrem_getter)
            where SOURCE_T : struct
        {
            var sign = sign_getter(x);
            if (sign < 0)
                throw (new ArgumentException());
            else if (sign == 0)
                return (NativeUnsignedInteger.Zero);
            else
            {
                var digits = new Stack<UInt32>();
                do
                {
                    var t = divrem_getter(x);
                    x = t.Item1;
                    digits.Push(t.Item2);
                }
                while (sign_getter(x) != 0);
                var value = new NativeUnsignedInteger(digits.Pop());
                while (digits.Count > 0)
                    value = value.Multiply(base_number).Add(digits.Pop());
                return (value);
            }
        }

        private static TARGET_T ToFloatingPointNUmberImp<TARGET_T>(NativeUnsignedInteger x, UInt32 base_number, TARGET_T zero_value, Func<UInt32, TARGET_T> initialize, Func<TARGET_T, UInt32, TARGET_T> progress)
            where TARGET_T : struct
        {
            if (x.IsZero)
                return (zero_value);
            var digits = new Stack<UInt32>();
            do
            {
                UInt32 r;
                x = x.DivRem(base_number, out r);
                digits.Push(r);
            }
            while (!x.IsZero);
            var value = initialize(digits.Pop());
            while (digits.Count > 0)
                value = progress(value, digits.Pop());
            return (value);
        }

        private static Exception CreateOverflowExceptionObject(Type target_type, object value)
        {
            return (new OverflowException(string.Format(@"{0} 型のオブジェクト'{1}'は、{2} 型では表現できない値です。", value.GetType().FullName, value.ToString(), target_type.FullName)));
        }

        private static Exception CreateOverflowExceptionObject(Type target_type, object value, Exception e)
        {
            return (new OverflowException(string.Format(@"{0} 型のオブジェクト'{1}'は、{2} 型では表現できない値です。", value.GetType().FullName, value.ToString(), target_type.FullName), e));
        }

        #endregion

        #region IConvertible メンバ

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return (ToBoolean());
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return (ToByte());
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            return (ToChar());
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw (new InvalidCastException("DateTime型に変換することはできません。"));
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return (ToDecimal());
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return (ToDouble());
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return (ToInt16());
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return (ToInt32());
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return (ToInt64());
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return (ToSByte());
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return (ToSingle());
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return (ToString(provider));
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return (ToUInt16());
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return (ToUInt32());
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return (ToUInt64());
        }

        TypeCode IConvertible.GetTypeCode()
        {
            return (TypeCode.Object);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(UnsignedLongLongInteger))
                return (this);
            else if (conversionType == typeof(LongLongInteger))
                return (new LongLongInteger(SignType.Positive, this));
            else if (conversionType == typeof(RationalNumber))
                return (new RationalNumber(this));
            else if (conversionType == typeof(bool))
                return (((IConvertible)this).ToBoolean(provider));
            else if (conversionType == typeof(byte))
                return (((IConvertible)this).ToByte(provider));
            else if (conversionType == typeof(char))
                return (((IConvertible)this).ToChar(provider));
            else if (conversionType == typeof(DateTime))
                return (((IConvertible)this).ToDateTime(provider));
            else if (conversionType == typeof(decimal))
                return (((IConvertible)this).ToDecimal(provider));
            else if (conversionType == typeof(double))
                return (((IConvertible)this).ToDouble(provider));
            else if (conversionType == typeof(short))
                return (((IConvertible)this).ToInt16(provider));
            else if (conversionType == typeof(int))
                return (((IConvertible)this).ToInt32(provider));
            else if (conversionType == typeof(long))
                return (((IConvertible)this).ToInt64(provider));
            else if (conversionType == typeof(sbyte))
                return (((IConvertible)this).ToSByte(provider));
            else if (conversionType == typeof(float))
                return (((IConvertible)this).ToSingle(provider));
            else if (conversionType == typeof(string))
                return (((IConvertible)this).ToString(provider));
            else if (conversionType == typeof(ushort))
                return (((IConvertible)this).ToUInt16(provider));
            else if (conversionType == typeof(uint))
                return (((IConvertible)this).ToUInt32(provider));
            else if (conversionType == typeof(ulong))
                return (((IConvertible)this).ToUInt64(provider));
            else
                throw (new InvalidCastException(conversionType.FullName + "型には変換できません。"));
        }

        #endregion
    }
}