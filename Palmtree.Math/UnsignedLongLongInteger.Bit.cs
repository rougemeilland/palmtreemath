/*
  UnsignedLongLongInteger.Bit.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using Palmtree.Math.Implements;

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
            return (new UnsignedLongLongInteger(x._native_value.LeftShift(n)));
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
            return (new UnsignedLongLongInteger(x._native_value.RightShift(n)));
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
        public static uint operator &(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.BitwiseAnd(x));
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
        public static ulong operator &(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.BitwiseAnd(x));
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
        public static uint operator &(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.BitwiseAnd(y));
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
            return (x._native_value.BitwiseAnd(y));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseAnd(y._native_value)));
        }

        #endregion

        #region | のオーバーロード

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
        public static UnsignedLongLongInteger operator |(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.BitwiseOr(x)));
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
        public static UnsignedLongLongInteger operator |(ulong x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.BitwiseOr(x)));
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
        public static UnsignedLongLongInteger operator |(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.BitwiseOr(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseOr(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseOr(y._native_value)));
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
        public static UnsignedLongLongInteger operator ^(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Xor(x)));
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
        public static UnsignedLongLongInteger operator ^(ulong x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Xor(x)));
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
        public static UnsignedLongLongInteger operator ^(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Xor(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.Xor(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.Xor(y._native_value)));
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
            return (new UnsignedLongLongInteger(_native_value.OnesComplement(n)));
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
            return (new UnsignedLongLongInteger(x._native_value.OnesComplement(n)));
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
            return (new UnsignedLongLongInteger(_native_value.Negate(n)));
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
            return (new UnsignedLongLongInteger(x._native_value.Negate(n)));
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
            return (new UnsignedLongLongInteger(_native_value.Truncate(n)));
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
            return (_native_value.TestBit(pos));
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
            return (new UnsignedLongLongInteger(_native_value.SetBit(pos)));
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
            return (new UnsignedLongLongInteger(_native_value.ClearBit(pos)));
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
        public UnsignedLongLongInteger Xor(uint x)
        {
            return (new UnsignedLongLongInteger(_native_value.Xor(x)));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Xor(ulong x)
        {
            return (new UnsignedLongLongInteger(_native_value.Xor(x)));
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
            return (new UnsignedLongLongInteger(_native_value.Xor(x._native_value)));
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
        public static UnsignedLongLongInteger Xor(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Xor(x)));
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
            return (new UnsignedLongLongInteger(y._native_value.Xor(x)));
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
        public static UnsignedLongLongInteger Xor(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Xor(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.Xor(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.Xor(y._native_value)));
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
        public uint BitwiseAnd(uint x)
        {
            return (_native_value.BitwiseAnd(x));
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
        [CLSCompliant(false)]
        public ulong BitwiseAnd(ulong x)
        {
            return (_native_value.BitwiseAnd(x));
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
            return (new UnsignedLongLongInteger(_native_value.BitwiseAnd(x._native_value)));
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
        public static uint BitwiseAnd(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.BitwiseAnd(x));
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
            return (y._native_value.BitwiseAnd(x));
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
        public static ulong BitwiseAnd(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.BitwiseAnd(y));
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
            return (x._native_value.BitwiseAnd(y));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseAnd(y._native_value)));
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
        public UnsignedLongLongInteger BitwiseOr(uint x)
        {
            return (new UnsignedLongLongInteger(_native_value.BitwiseOr(x)));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger BitwiseOr(ulong x)
        {
            return (new UnsignedLongLongInteger(_native_value.BitwiseOr(x)));
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
            return (new UnsignedLongLongInteger(_native_value.BitwiseOr(x._native_value)));
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
        public static UnsignedLongLongInteger BitwiseOr(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.BitwiseOr(x)));
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
            return (new UnsignedLongLongInteger(y._native_value.BitwiseOr(x)));
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
        public static UnsignedLongLongInteger BitwiseOr(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.BitwiseOr(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseOr(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseOr(y._native_value)));
        }

        #endregion

        #region BitwiseComplementAnd のオーバーロード

        /// <summary>
        /// 与えられた整数の否定との論理積(this &amp; ~x)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger BitwiseComplementAnd(uint x)
        {
            return (new UnsignedLongLongInteger(_native_value.BitwiseComplementAnd(x)));
        }

        /// <summary>
        /// 与えられた整数の否定との論理積(this &amp; ~x)を計算します。
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
            return (new UnsignedLongLongInteger(_native_value.BitwiseComplementAnd(x)));
        }

        /// <summary>
        /// 与えられた整数の否定との論理積(this &amp; ~x)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(_native_value.BitwiseComplementAnd(x._native_value)));
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
        public static UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.BitwiseComplementAnd(y)));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseComplementAnd(y)));
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
        public static uint BitwiseComplementAnd(uint x, UnsignedLongLongInteger y)
        {
            return (x.BitwiseComplementAnd(y._native_value));
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
            return (x.BitwiseComplementAnd(y._native_value));
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
            return (new UnsignedLongLongInteger(x._native_value.BitwiseComplementAnd(y._native_value)));
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
            return (new UnsignedLongLongInteger(_native_value.LeftShift(n)));
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
            return (new UnsignedLongLongInteger(x._native_value.LeftShift(n)));
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
            return (new UnsignedLongLongInteger(_native_value.RightShift(n)));
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
            return (new UnsignedLongLongInteger(x._native_value.RightShift(n)));
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
                return (_native_value.BitCount);
            }
        }

        /// <summary>
        /// オブジェクトが2のべき乗であるならばtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsPowerOfTwo
        {
            get
            {
                return (_native_value.IsPowerOfTwo);
            }
        }

        #endregion
    }
}