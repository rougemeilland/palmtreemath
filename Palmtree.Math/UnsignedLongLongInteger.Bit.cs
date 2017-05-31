/*
  UnsignedLongLongInteger.Bit.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// 演算子のオーバーロードに関するガイドライン:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct UnsignedLongLongInteger
    {
        #region 演算子

#if !CONCEAL_OPERATORS

        #region << のオーバーロード

        /// <summary>
        /// 整数を左シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger operator <<(UnsignedLongLongInteger x, int n)
        {
            return (LeftShift(x, n));
        }

        #endregion

        #region >> のオーバーロード

        /// <summary>
        /// 整数を右シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger operator >>(UnsignedLongLongInteger x, int n)
        {
            return (RightShift(x, n));
        }

        #endregion

        #region & のオーバーロード

        /// <summary>
        /// 二つの整数のビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static ulong operator &(ulong x, UnsignedLongLongInteger y)
        {
            return (BitwiseAnd(y, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static ulong operator &(UnsignedLongLongInteger x, ulong y)
        {
            return (BitwiseAnd(x, y));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger operator &(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (BitwiseAnd(x, y));
        }

        #endregion

        #region || のオーバーロード

        /// <summary>
        /// 二つの整数のビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator |(ulong x, UnsignedLongLongInteger y)
        {
            return (BitwiseOr(y, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator |(UnsignedLongLongInteger x, ulong y)
        {
            return (BitwiseOr(x, y));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger operator |(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (BitwiseOr(x, y));
        }

        #endregion

        #region ^ のオーバーロード

        /// <summary>
        /// 二つの整数のビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator ^(ulong x, UnsignedLongLongInteger y)
        {
            return (Xor(y, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator ^(UnsignedLongLongInteger x, ulong y)
        {
            return (Xor(x, y));
        }

        /// <summary>
        /// 二つの整数のビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger operator ^(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Xor(x, y));
        }

        #endregion

#endif

        #endregion

        #region パブリックメソッド

        #region OnesComplement のオーバーロード

        /// <summary>
        /// ビット毎の否定を計算し、下位からnビット分のみ取り出します。
        /// これは (~this).Truncate(n) と等価です。
        /// </summary>
        /// <param name="n">
        /// 取り出すビットの数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger OnesComplement(int n)
        {
            return (OnesComplement(this, n));
        }

        /// <summary>
        /// 与えられたオブジェクトのビット毎の否定を計算し、下位からnビット分のみ取り出します。
        /// これは (~this).Truncate(n) と等価です。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="n">
        /// 取り出すビットの数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger OnesComplement(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("ビットの数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.OnesComplement(x._InternalValue, n)));
        }

        #endregion

        #region Negative のオーバーロード

        /// <summary>
        /// 符号が反転した値を計算し、下位からnビット分のみ取り出します。
        /// これは (-this).Truncate(n) と等価です。
        /// </summary>
        /// <param name="n">
        /// 取り出すビットの数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger Negate(int n)
        {
            return (Negate(this, n));
        }

        /// <summary>
        /// 与えられたオブジェクトの符号が反転した値を計算し、下位からnビット分のみ取り出します。
        /// これは (-this).Truncate(n) と等価です。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="n">
        /// 取り出すビットの数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Negate(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("ビットの数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (Zero);
            else if (x._InternalValue.Length == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.Negate(x._InternalValue, n)));
        }

        #endregion

        #region TruncateBit のオーバーロード

        /// <summary>
        /// 下位からnビット分を除いて全てのビットを0にした値を計算します。
        /// </summary>
        /// <param name="n">
        /// 保持するビットの数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger TruncateBit(int n)
        {
            if (n < 0)
                throw (new ArgumentException("ビットの数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (Zero);
            else if (_InternalValue.Length == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.Truncate(_InternalValue, n)));
        }

        #endregion

        #region TestBit のオーバーロード

        /// <summary>
        /// あるひとつのビットが1かどうかを調べます。
        /// これは (this &amp; (1 &lt;&lt; n)) != 0 と等価です。 
        /// </summary>
        /// <param name="pos">
        /// 調べるビットの位置です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public bool TestBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("ビットの位置は正または0でなくてはなりません。", "pos"));
            if (_InternalValue.Length == 0)
                return (false);
            else
                return (_imp.TestBit(_InternalValue, pos));
        }

        #endregion

        #region SetBit のオーバーロード

        /// <summary>
        /// あるひとつのビットをセットした値を計算します。
        /// </summary>
        /// <param name="pos">
        /// セットするビットの位置です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger SetBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("ビットの位置は正または0でなくてはなりません。", "pos"));
            if (_InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(_imp.LeftShift(new ushort[] { 1 }, pos)));
            else
                return (new UnsignedLongLongInteger(_imp.SetBit(_InternalValue, pos)));
        }

        #endregion

        #region ClearBit のオーバーロード

        /// <summary>
        /// あるひとつのビットをクリアした値を計算します。
        /// </summary>
        /// <param name="pos">
        /// クリアするビットの位置です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger ClearBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("ビットの位置は正または0でなくてはなりません。", "pos"));
            if (_InternalValue.Length == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.ClearBit(_InternalValue, pos)));
        }

        #endregion

        #region Xor のオーバーロード

        /// <summary>
        /// 与えられた整数とのビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Xor(ulong x)
        {
            return (Xor(this, x));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger Xor(UnsignedLongLongInteger x)
        {
            return (Xor(this, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Xor(ulong x, UnsignedLongLongInteger y)
        {
            return (Xor(y, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Xor(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(y));
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.Xor(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.Xor(x._InternalValue, CreateInternalValue(y))));
        }

        /// <summary>
        /// 二つの整数のビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Xor(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (y);
            else if (y._InternalValue.Length == 0)
                return (x);
            else
                return (new UnsignedLongLongInteger(_imp.Xor(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region BitwiseAnd のオーバーロード

        /// <summary>
        /// 与えられた整数とのビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public ulong BitwiseAnd(ulong x)
        {
            return (BitwiseAnd(this, x));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger BitwiseAnd(UnsignedLongLongInteger x)
        {
            return (BitwiseAnd(this, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static ulong BitwiseAnd(ulong x, UnsignedLongLongInteger y)
        {
            if (x == 0 || y._InternalValue.Length == 0)
                return (0);
            else if (x <= ushort.MaxValue || y._InternalValue.Length == 1)
                return (_imp.And((ushort)x, y._InternalValue[0]));
            else
                return (_imp.And(x, ToULong(y._InternalValue)));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static ulong BitwiseAnd(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0 || y == 0)
                return (0);
            else if (x._InternalValue.Length == 1 || y <= ushort.MaxValue)
                return (_imp.And(x._InternalValue[0], (ushort)y));
            else
                return (_imp.And(ToULong(x._InternalValue), y));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger BitwiseAnd(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0 || y._InternalValue.Length == 0)
                return (Zero);
            else if (x._InternalValue.Length == 1 || y._InternalValue.Length == 1)
                return (new UnsignedLongLongInteger(_imp.And(x._InternalValue[0], y._InternalValue[0])));
            else
                return (new UnsignedLongLongInteger(_imp.And(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region BitwiseOr のオーバーロード

        /// <summary>
        /// 与えられた整数とのビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger BitwiseOr(ulong x)
        {
            return (BitwiseOr(this, x));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger BitwiseOr(UnsignedLongLongInteger x)
        {
            return (BitwiseOr(this, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger BitwiseOr(ulong x, UnsignedLongLongInteger y)
        {
            return (BitwiseOr(y, x));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger BitwiseOr(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(y));
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.Or(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.Or(x._InternalValue, CreateInternalValue(y))));
        }

        /// <summary>
        /// 二つの整数のビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger BitwiseOr(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (y);
            else if (y._InternalValue.Length == 0)
                return (x);
            else
                return (new UnsignedLongLongInteger(_imp.Or(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region BitwiseComplementAnd のオーバーロード

        /// <summary>
        /// 与えられた整数の否定との論理積(x &amp; ~y)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger BitwiseComplementAnd(ulong x)
        {
            return (BitwiseComplementAnd(this, x));
        }

        /// <summary>
        /// 与えられた整数の否定との論理積(x &amp; ~y)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x)
        {
            return (BitwiseComplementAnd(this, x));
        }

        /// <summary>
        /// ある整数と、もうひとつの整数の否定の論理積(x &amp; ~y)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, CreateInternalValue(y))));
        }

        /// <summary>
        /// ある整数と、もうひとつの整数の否定の論理積(x &amp; ~y)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static ulong BitwiseComplementAnd(ulong x, UnsignedLongLongInteger y)
        {
            if (x == 0)
                return (0);
            else if (y._InternalValue.Length == 0)
                return (x);
            else if (x <= ushort.MaxValue)
                return (_imp.ComplementAnd((ushort)x, y._InternalValue[0]));
            else if (y._InternalValue.Length == 1)
                return (_imp.ComplementAnd(x, y._InternalValue[0]));
            else
                return (_imp.ComplementAnd(x, ToULong(y._InternalValue)));
        }

        /// <summary>
        /// ある整数と、もうひとつの整数の否定の論理積(x &amp; ~y)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y._InternalValue.Length == 0)
                return (x);
            else if (x._InternalValue.Length == 1)
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue[0], y._InternalValue[0])));
            else if (y._InternalValue.Length == 1)
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, y._InternalValue[0])));
            else
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region LeftShift のオーバーロード

        /// <summary>
        /// 整数を左シフトします。
        /// </summary>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger LeftShift(int n)
        {
            return (LeftShift(this, n));
        }

        /// <summary>
        /// 整数を左シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger LeftShift(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("シフト回数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (x);
            if (x._InternalValue.Length == 0)
                return (Zero);
            return (new UnsignedLongLongInteger(_imp.LeftShift(x._InternalValue, n)));
        }

        #endregion

        #region RightShift のオーバーロード

        /// <summary>
        /// 整数を右シフトします。
        /// </summary>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger RightShift(int n)
        {
            return (RightShift(this, n));
        }

        /// <summary>
        /// 整数を右シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger RightShift(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("シフト回数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (x);
            if (x._InternalValue.Length == 0)
                return (Zero);
            return (new UnsignedLongLongInteger(_imp.RightShift(x._InternalValue, n)));
        }

        #endregion

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// オブジェクトをビット配列として見た場合の配列の長さです。
        /// </summary>
        /// <remarks>
        /// このプロパティの値は以下の定義により求められます。
        /// this + 1 &lt;= (1 &lt;&lt; n) である最小のn
        /// </remarks>
        public int BitLength
        {
            get
            {
                if (!_bit_length_cache.HasValue)
                    _bit_length_cache = _InternalValue.Length == 0 ? 0 : _imp.GetBitLength(_InternalValue);
                return (_bit_length_cache.Value);
            }
        }

        /// <summary>
        /// オブジェクトが2のべき乗であるならばtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsPowerOfTwo
        {
            get
            {
                if (!_is_power_of_two_cache.HasValue)
                    _is_power_of_two_cache = _InternalValue.Length > 0 && _imp.GetIsPowerOfTwo(_InternalValue);
                return (_is_power_of_two_cache.Value);
            }
        }

        #endregion
    }
}
