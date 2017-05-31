/*
  LongLongInteger.Arithmetic.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// 演算子のオーバーロードに関するガイドライン:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct LongLongInteger
    {
        #region 演算子

#if !CONCEAL_OPERATORS

        #region 単項 + 演算子のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトをそのまま返します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xに等しいオブジェクトです。
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x)
        {
            return (x);
        }

        #endregion

        #region 単項 - 演算子のオーバーロード

        /// <summary>
        /// オブジェクトの符号反転を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xの符号反転の結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x)
        {
            return (Negate(x));
        }

        #endregion

        #region 単項 ++ 演算子のオーバーロード

        /// <summary>
        /// 整数をインクリメントします。
        /// </summary>
        /// <param name="x">
        /// 計算対象の整数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger operator ++(LongLongInteger x)
        {
            return (Increment(x));
        }

        #endregion

        #region 単項 -- 演算子のオーバーロード

        /// <summary>
        /// 整数をデクリメントします。
        /// </summary>
        /// <param name="x">
        /// 計算対象の整数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger operator --(LongLongInteger x)
        {
            return (Decrement(x));
        }

        #endregion

        #region 二項 + 演算子のオーバーロード

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator +(long x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator +(ulong x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator +(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x, long y)
        {
            return (Add(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator +(LongLongInteger x, ulong y)
        {
            return (Add(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Add(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x, LongLongInteger y)
        {
            return (Add(x, y));
        }

        #endregion

        #region 二項 - 演算子のオーバーロード

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator -(long x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator -(ulong x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator -(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x, long y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator -(LongLongInteger x, ulong y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        #endregion

        #region 二項 * 演算子のオーバーロード

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator *(long x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator *(ulong x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator *(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator *(LongLongInteger x, long y)
        {
            return (Multiply(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator *(LongLongInteger x, ulong y)
        {
            return (Multiply(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator *(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Multiply(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator *(LongLongInteger x, LongLongInteger y)
        {
            return (Multiply(x, y));
        }

        #endregion

        #region 二項 / 演算子のオーバーロード

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator /(long x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator /(ulong x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator /(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator /(LongLongInteger x, long y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator /(LongLongInteger x, ulong y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator /(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator /(LongLongInteger x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        #endregion

        #region 二項 % 演算子のオーバーロード

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator %(long x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator %(ulong x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger operator %(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator %(LongLongInteger x, long y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator %(LongLongInteger x, ulong y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator %(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger operator %(LongLongInteger x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        #endregion

#endif

        #endregion

        #region パブリックメソッド

        #region Add のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 加算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Add(long x)
        {
            return (Add(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 加算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Add(ulong x)
        {
            return (Add(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 加算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Add(UnsignedLongLongInteger x)
        {
            return (Add(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 加算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Add(LongLongInteger x)
        {
            return (Add(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Add(long x, LongLongInteger y)
        {
            return (Add(y, new LongLongInteger(x)));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Add(ulong x, LongLongInteger y)
        {
            return (Add(y, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Add(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Add(LongLongInteger x, long y)
        {
            return (Add(x, new LongLongInteger(y)));
        }


        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Add(LongLongInteger x, ulong y)
        {
            return (Add(x, new UnsignedLongLongInteger(y)));
        }


        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Add(LongLongInteger x, UnsignedLongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y.IsZero ? Zero : y.ToLongLongInteger());
                case SignType.Positive:
                    return (y.IsZero ? x : x._abs.Add(y).ToLongLongInteger());
                default:
                    return (y.IsZero ? x : Subtract(y, x._abs));
            }
        }

        /// <summary>
        /// 二つのオブジェクトの加算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを加算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Add(LongLongInteger x, LongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y);
                case SignType.Positive:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (x._abs.Add(y._abs).ToLongLongInteger());
                        default:
                            return (Subtract(x._abs, y._abs));
                    }
                default:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (Subtract(y._abs, x._abs));
                        default:
                            return (x._abs.Add(y._abs).Negate());
                    }
            }
        }

        #endregion

        #region Subtract のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 減算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Subtract(long x)
        {
            return (Subtract(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 減算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Subtract(ulong x)
        {
            return (Subtract(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 減算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Subtract(UnsignedLongLongInteger x)
        {
            return (Subtract(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 減算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Subtract(LongLongInteger x)
        {
            return (Subtract(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Subtract(long x, LongLongInteger y)
        {
            return (Subtract(new LongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Subtract(ulong x, LongLongInteger y)
        {
            return (Subtract(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Subtract(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (x.IsZero)
                return (y._sign == SignType.Zero ? Zero : new LongLongInteger(y._sign.Negate(), y._abs));
            else
            {
                switch (y._sign)
                {
                    case SignType.Zero:
                        return (x.ToLongLongInteger());
                    case SignType.Positive:
                        return (Subtract(x, y._abs));
                    default:
                        return (x.Add(y._abs).ToLongLongInteger());
                }
            }
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Subtract(LongLongInteger x, long y)
        {
            return (Subtract(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Subtract(LongLongInteger x, ulong y)
        {
            return (Subtract(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Subtract(LongLongInteger x, UnsignedLongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y.IsZero ? Zero : y.Negate());
                case SignType.Positive:
                    return (y.IsZero ? x : Subtract(x._abs, y));
                default:
                    return (y.IsZero ? x : x._abs.Add(y).Negate());
            }
        }

        /// <summary>
        /// 二つのオブジェクトの減算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xからyを減算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Subtract(LongLongInteger x, LongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y._sign == SignType.Zero ? Zero : new LongLongInteger(y._sign.Negate(), y._abs));
                case SignType.Positive:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (Subtract(x._abs, y._abs));
                        default:
                            return (x._abs.Add(y._abs).ToLongLongInteger());
                    }
                default:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (x._abs.Add(y._abs).Negate());
                        default:
                            return (Subtract(y._abs, x._abs));
                    }
            }
        }

        #endregion

        #region Increment のオーバーロード

        /// <summary>
        /// 整数をインクリメントします。
        /// </summary>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger Increment()
        {
            return (Increment(this));
        }

        /// <summary>
        /// 整数をインクリメントします。
        /// </summary>
        /// <param name="x">
        /// 計算対象の整数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger Increment(LongLongInteger x)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (One);
                case SignType.Positive:
                    return (x._abs.Increment().ToLongLongInteger());
                default:
                    return (x._abs.Decrement().Negate());
            }
        }

        #endregion

        #region Decrement のオーバーロード

        /// <summary>
        /// 整数をデクリメントします。
        /// </summary>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger Decrement()
        {
            return (Decrement(this));
        }

        /// <summary>
        /// 整数をデクリメントします。
        /// </summary>
        /// <param name="x">
        /// 計算対象の整数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger Decrement(LongLongInteger x)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (MinusOne);
                case SignType.Positive:
                    return (x._abs.Decrement().ToLongLongInteger());
                default:
                    return (x._abs.Increment().Negate());
            }
        }

        #endregion

        #region Multiply のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 乗算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Multiply(long x)
        {
            return (Multiply(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 乗算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Multiply(ulong x)
        {
            return (Multiply(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 乗算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Multiply(UnsignedLongLongInteger x)
        {
            return (Multiply(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 乗算した結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Multiply(LongLongInteger x)
        {
            return (Multiply(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Multiply(long x, LongLongInteger y)
        {
            return (Multiply(y, new LongLongInteger(x)));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Multiply(ulong x, LongLongInteger y)
        {
            return (Multiply(y, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Multiply(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Multiply(LongLongInteger x, long y)
        {
            return (Multiply(x, new LongLongInteger(y)));
        }


        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Multiply(LongLongInteger x, ulong y)
        {
            return (Multiply(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Multiply(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero || y.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Multiply(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyを乗算した結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Multiply(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero || x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Multiply(y._sign), x._abs.Multiply(y._abs)));
        }

        #endregion

        #region Divide のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Divide(long x)
        {
            return (Divide(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Divide(ulong x)
        {
            return (Divide(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Divide(UnsignedLongLongInteger x)
        {
            return (Divide(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Divide(LongLongInteger x)
        {
            return (Divide(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Divide(long x, LongLongInteger y)
        {
            return (Divide(new LongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Divide(ulong x, LongLongInteger y)
        {
            return (Divide(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Divide(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(y._sign, x.Divide(y._abs)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Divide(LongLongInteger x, long y)
        {
            return (Divide(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Divide(LongLongInteger x, ulong y)
        {
            return (Divide(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Divide(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Divide(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Divide(LongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Divide(y._sign), x._abs.Divide(y._abs)));
        }

        #endregion

        #region DivideExactly のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger DivideExactly(long x)
        {
            return (DivideExactly(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger DivideExactly(ulong x)
        {
            return (DivideExactly(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger DivideExactly(UnsignedLongLongInteger x)
        {
            return (DivideExactly(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger DivideExactly(LongLongInteger x)
        {
            return (DivideExactly(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivideExactly(long x, LongLongInteger y)
        {
            return (DivideExactly(new LongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivideExactly(ulong x, LongLongInteger y)
        {
            return (DivideExactly(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivideExactly(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(y._sign, x.DivideExactly(y._abs)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivideExactly(LongLongInteger x, long y)
        {
            return (DivideExactly(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivideExactly(LongLongInteger x, ulong y)
        {
            return (DivideExactly(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivideExactly(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.DivideExactly(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの除算を行います。
        /// 割り切れない場合には例外が発生します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivideExactly(LongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Divide(y._sign), x._abs.DivideExactly(y._abs)));
        }

        #endregion

        #region Mod のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Mod(long x)
        {
            return (Mod(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Mod(ulong x)
        {
            return (Mod(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Mod(UnsignedLongLongInteger x)
        {
            return (Mod(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Mod(LongLongInteger x)
        {
            return (Mod(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Mod(long x, LongLongInteger y)
        {
            return (Mod(new LongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Mod(ulong x, LongLongInteger y)
        {
            return (Mod(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Mod(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x.IsZero)
                return (UnsignedLongLongInteger.Zero);
            else
                return (x.Mod(y._abs));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Mod(LongLongInteger x, long y)
        {
            return (Mod(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Mod(LongLongInteger x, ulong y)
        {
            return (Mod(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Mod(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Mod(y)));
        }

        /// <summary>
        /// 二つのオブジェクトの剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <returns>
        /// 剰余を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Mod(LongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Mod(y._abs)));
        }

        #endregion

        #region DivRem のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger DivRem(long x, out LongLongInteger r)
        {
            return (DivRem(this, new LongLongInteger(x), out r));
        }

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger DivRem(ulong x, out LongLongInteger r)
        {
            return (DivRem(this, new UnsignedLongLongInteger(x), out r));
        }

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger DivRem(UnsignedLongLongInteger x, out LongLongInteger r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public LongLongInteger DivRem(LongLongInteger x, out LongLongInteger r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivRem(long x, LongLongInteger y, out LongLongInteger r)
        {
            return (DivRem(new LongLongInteger(x), y, out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivRem(ulong x, LongLongInteger y, out UnsignedLongLongInteger r)
        {
            return (DivRem(new UnsignedLongLongInteger(x), y, out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivRem(UnsignedLongLongInteger x, LongLongInteger y, out UnsignedLongLongInteger r)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x.IsZero)
            {
                r = UnsignedLongLongInteger.Zero;
                return (Zero);
            }
            else
                return (new LongLongInteger(y._sign, x.DivRem(y._abs, out r)));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivRem(LongLongInteger x, long y, out LongLongInteger r)
        {
            return (DivRem(x, new LongLongInteger(y), out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivRem(LongLongInteger x, ulong y, out LongLongInteger r)
        {
            return (DivRem(x, new UnsignedLongLongInteger(y), out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivRem(LongLongInteger x, UnsignedLongLongInteger y, out LongLongInteger r)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
            {
                r = Zero;
                return (Zero);
            }
            else
            {
                UnsignedLongLongInteger r_u;
                UnsignedLongLongInteger q_u = x._abs.DivRem(y, out r_u);
                r = new LongLongInteger(x._sign, r_u);
                return (new LongLongInteger(x._sign, q_u));
            }
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。(被除数)
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。(除数)
        /// </param>
        /// <param name="r">
        /// 剰余を表すオブジェクトです。
        /// </param>
        /// <returns>
        /// 商を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger DivRem(LongLongInteger x, LongLongInteger y, out LongLongInteger r)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._sign == SignType.Zero)
            {
                r = Zero;
                return (Zero);
            }
            else
            {
                UnsignedLongLongInteger r_u;
                UnsignedLongLongInteger q_u = x._abs.DivRem(y._abs, out r_u);
                r = new LongLongInteger(x._sign, r_u);
                return (new LongLongInteger(x._sign.Divide(y._sign), q_u));
            }
        }

        #endregion

        #region Negate のオーバーロード

        /// <summary>
        /// 現在のオブジェクトの符号が反転した値を計算します。
        /// </summary>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger Negate()
        {
            return (Negate(this));
        }

        /// <summary>
        /// 符号が反転した値を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger Negate(UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(SignType.Negative, x));
        }

        /// <summary>
        /// 符号が反転した値を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger Negate(LongLongInteger x)
        {
            if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Negate(), x._abs));
        }

        #endregion

        #region Power のオーバーロード

        /// <summary>
        /// オブジェクトのべき乗を計算します。
        /// </summary>
        /// <param name="exp">
        /// べき乗の指数です。
        /// </param>
        /// <returns>
        /// べき乗の計算結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Power(ulong exp)
        {
            return (Power(this, new UnsignedLongLongInteger(exp)));
        }

        /// <summary>
        /// オブジェクトのべき乗を計算します。
        /// </summary>
        /// <param name="exp">
        /// べき乗の指数です。
        /// </param>
        /// <returns>
        /// べき乗の計算結果を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Power(UnsignedLongLongInteger exp)
        {
            return (Power(this, exp));
        }

        /// <summary>
        /// オブジェクトのべき乗を計算します。
        /// </summary>
        /// <param name="x">
        /// べき乗の基数です。
        /// </param>
        /// <param name="exp">
        /// べき乗の指数です。
        /// </param>
        /// <returns>
        /// べき乗の計算結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Power(LongLongInteger x, ulong exp)
        {
            return (Power(x, new UnsignedLongLongInteger(exp)));
        }

        /// <summary>
        /// オブジェクトのべき乗を計算します。
        /// </summary>
        /// <param name="x">
        /// べき乗の基数です。
        /// </param>
        /// <param name="exp">
        /// べき乗の指数です。
        /// </param>
        /// <returns>
        /// べき乗の計算結果を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Power(LongLongInteger x, UnsignedLongLongInteger exp)
        {
            if (exp.IsZero)
                return (One);
            else if (exp.IsOne)
                return (x);
            else if (x._sign == SignType.Zero)
                return (Zero);
            else if (x._sign == SignType.Positive)
                return (x._abs.Power(exp).ToLongLongInteger());
            else if (exp.IsEven)
                return (x._abs.Power(exp).ToLongLongInteger());
            else
                return (x._abs.Power(exp).Negate());
        }

        #endregion

        #region Abs のオーバーロード

        /// <summary>
        /// 現在のオブジェクトの絶対値を計算します。
        /// </summary>
        /// <returns>
        /// 絶対値です。
        /// </returns>
        public UnsignedLongLongInteger Abs()
        {
            return (Abs(this));
        }

        /// <summary>
        /// 絶対値を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 絶対値です。
        /// </returns>
        public static UnsignedLongLongInteger Abs(LongLongInteger x)
        {
            return (x._abs);
        }

        #endregion

        #region GreatestCommonDivisor のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大公約数を表すオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger GreatestCommonDivisor(long x)
        {
            return (GreatestCommonDivisor(_abs, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大公約数を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger GreatestCommonDivisor(ulong x)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(_abs, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大公約数を表すオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger GreatestCommonDivisor(UnsignedLongLongInteger x)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(_abs, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大公約数を表すオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(_abs, x._abs));
        }

        /// <summary>
        /// 二つのオブジェクトの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyの最大公約数を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(long x, LongLongInteger y)
        {
            return (GreatestCommonDivisor(new LongLongInteger(x), y._abs));
        }

        /// <summary>
        /// 二つのオブジェクトの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyの最大公約数を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger GreatestCommonDivisor(ulong x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x, y._abs));
        }

        /// <summary>
        /// 二つのオブジェクトの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyの最大公約数を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x, y._abs));
        }

        /// <summary>
        /// 二つのオブジェクトの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyの最大公約数を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, long y)
        {
            return (GreatestCommonDivisor(x._abs, new LongLongInteger(y)));
        }


        /// <summary>
        /// 二つのオブジェクトの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyの最大公約数を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, ulong y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x._abs, y));
        }


        /// <summary>
        /// 二つのオブジェクトの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyの最大公約数を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x._abs, y));
        }


        /// <summary>
        /// 二つのオブジェクトの最大公約数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyの最大公約数を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x._abs, y._abs));
        }

        #endregion

        #region Max のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Max(long x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Max(ulong x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger Max(UnsignedLongLongInteger x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Max(LongLongInteger x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Max(long x, LongLongInteger y)
        {
            return (Max(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Max(ulong x, LongLongInteger y)
        {
            return (Max(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Max(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Max(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Max(LongLongInteger x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }


        /// <summary>
        /// 二つのオブジェクトの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Max(LongLongInteger x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x._abs);
            else
                return (new UnsignedLongLongInteger(y));
        }


        /// <summary>
        /// 二つのオブジェクトの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Max(LongLongInteger x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x._abs);
            else
                return (y);
        }


        /// <summary>
        /// 二つのオブジェクトの最大値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最大値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Max(LongLongInteger x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (y);
        }

        #endregion

        #region Min のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Min(long x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Min(ulong x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Min(UnsignedLongLongInteger x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// 与えられたオブジェクトとの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public LongLongInteger Min(LongLongInteger x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Min(long x, LongLongInteger y)
        {
            return (Min(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Min(ulong x, LongLongInteger y)
        {
            return (Min(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Min(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Min(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Min(LongLongInteger x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }


        /// <summary>
        /// 二つのオブジェクトの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Min(LongLongInteger x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Min(LongLongInteger x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }


        /// <summary>
        /// 二つのオブジェクトの最小値を求めます。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 最小値を表すオブジェクトです。
        /// </returns>
        public static LongLongInteger Min(LongLongInteger x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (y);
        }

        #endregion

        #endregion

        #region プライベートメソッド

        private static LongLongInteger Subtract(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            int cmp = x.CompareTo(y);
            if (cmp > 0)
                return (x.Subtract(y).ToLongLongInteger());
            else if (cmp == 0)
                return (Zero);
            else
                return (y.Subtract(x).Negate());
        }

        #endregion
    }
}
