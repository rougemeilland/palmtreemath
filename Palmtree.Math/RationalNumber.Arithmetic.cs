/*
  RationalNumber.Arithmetic.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using Palmtree.Math.Round;

// 演算子のオーバーロードに関するガイドライン:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct RationalNumber
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
        public static RationalNumber operator +(RationalNumber x)
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
        public static RationalNumber operator -(RationalNumber x)
        {
            return (Negate(x));
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
        public static RationalNumber operator +(long x, RationalNumber y)
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
        public static RationalNumber operator +(ulong x, RationalNumber y)
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
        public static RationalNumber operator +(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator +(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator +(RationalNumber x, long y)
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
        public static RationalNumber operator +(RationalNumber x, ulong y)
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
        public static RationalNumber operator +(RationalNumber x, UnsignedLongLongInteger y)
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
        public static RationalNumber operator +(RationalNumber x, LongLongInteger y)
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
        public static RationalNumber operator +(RationalNumber x, RationalNumber y)
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
        public static RationalNumber operator -(long x, RationalNumber y)
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
        public static RationalNumber operator -(ulong x, RationalNumber y)
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
        public static RationalNumber operator -(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator -(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator -(RationalNumber x, long y)
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
        public static RationalNumber operator -(RationalNumber x, ulong y)
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
        public static RationalNumber operator -(RationalNumber x, UnsignedLongLongInteger y)
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
        public static RationalNumber operator -(RationalNumber x, LongLongInteger y)
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
        public static RationalNumber operator -(RationalNumber x, RationalNumber y)
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
        public static RationalNumber operator *(long x, RationalNumber y)
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
        public static RationalNumber operator *(ulong x, RationalNumber y)
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
        public static RationalNumber operator *(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator *(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator *(RationalNumber x, long y)
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
        public static RationalNumber operator *(RationalNumber x, ulong y)
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
        public static RationalNumber operator *(RationalNumber x, UnsignedLongLongInteger y)
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
        public static RationalNumber operator *(RationalNumber x, LongLongInteger y)
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
        public static RationalNumber operator *(RationalNumber x, RationalNumber y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        public static RationalNumber operator /(long x, RationalNumber y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber operator /(ulong x, RationalNumber y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        public static RationalNumber operator /(UnsignedLongLongInteger x, RationalNumber y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        public static RationalNumber operator /(LongLongInteger x, RationalNumber y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, long y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber operator /(RationalNumber x, ulong y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, UnsignedLongLongInteger y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, LongLongInteger y)
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
        /// xをyで除算した結果を表すオブジェクトです。
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, RationalNumber y)
        {
            if (y.Sign == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (y.Sign > 0)
                return (new RationalNumber(x._InternalNumerator * y._InternalDenominator, x._InternalDenominator * y._InternalNumerator.Abs()));
            else
                return (new RationalNumber(-x._InternalNumerator * y._InternalDenominator, x._InternalDenominator * y._InternalNumerator.Abs()));
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
        public RationalNumber Add(long x)
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
        public RationalNumber Add(ulong x)
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
        public RationalNumber Add(UnsignedLongLongInteger x)
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
        public RationalNumber Add(LongLongInteger x)
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
        public RationalNumber Add(RationalNumber x)
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
        public static RationalNumber Add(long x, RationalNumber y)
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
        public static RationalNumber Add(ulong x, RationalNumber y)
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
        public static RationalNumber Add(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Add(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Add(RationalNumber x, long y)
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
        public static RationalNumber Add(RationalNumber x, ulong y)
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
        public static RationalNumber Add(RationalNumber x, UnsignedLongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            UnsignedLongLongInteger n2 = x._InternalDenominator.Multiply(y);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Add(n2), d));
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
        public static RationalNumber Add(RationalNumber x, LongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            LongLongInteger n2 = x._InternalDenominator.Multiply(y);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Add(n2), d));
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
        public static RationalNumber Add(RationalNumber x, RationalNumber y)
        {
            LongLongInteger n1 = x._InternalNumerator.Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator.Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator.Multiply(y._InternalDenominator);
            return (new RationalNumber(n1.Add(n2), d));
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
        public RationalNumber Subtract(long x)
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
        public RationalNumber Subtract(ulong x)
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
        public RationalNumber Subtract(UnsignedLongLongInteger x)
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
        public RationalNumber Subtract(LongLongInteger x)
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
        public RationalNumber Subtract(RationalNumber x)
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
        public static RationalNumber Subtract(long x, RationalNumber y)
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
        public static RationalNumber Subtract(ulong x, RationalNumber y)
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
        public static RationalNumber Subtract(UnsignedLongLongInteger x, RationalNumber y)
        {
            LongLongInteger n1 = x.ToLongLongInteger().Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator;
            UnsignedLongLongInteger d = y._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(LongLongInteger x, RationalNumber y)
        {
            LongLongInteger n1 = x.Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator;
            UnsignedLongLongInteger d = y._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(RationalNumber x, long y)
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
        public static RationalNumber Subtract(RationalNumber x, ulong y)
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
        public static RationalNumber Subtract(RationalNumber x, UnsignedLongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            LongLongInteger n2 = y.ToLongLongInteger().Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(RationalNumber x, LongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            LongLongInteger n2 = y.Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(RationalNumber x, RationalNumber y)
        {
            LongLongInteger n1 = x._InternalNumerator.Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator.Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator.Multiply(y._InternalDenominator);
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public RationalNumber Multiply(long x)
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
        public RationalNumber Multiply(ulong x)
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
        public RationalNumber Multiply(UnsignedLongLongInteger x)
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
        public RationalNumber Multiply(LongLongInteger x)
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
        public RationalNumber Multiply(RationalNumber x)
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
        public static RationalNumber Multiply(long x, RationalNumber y)
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
        public static RationalNumber Multiply(ulong x, RationalNumber y)
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
        public static RationalNumber Multiply(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Multiply(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Multiply(RationalNumber x, long y)
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
        public static RationalNumber Multiply(RationalNumber x, ulong y)
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
        public static RationalNumber Multiply(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (new RationalNumber(x._InternalNumerator.Multiply(y), x._InternalDenominator));
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
        public static RationalNumber Multiply(RationalNumber x, LongLongInteger y)
        {
            return (new RationalNumber(x._InternalNumerator.Multiply(y), x._InternalDenominator));
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
        public static RationalNumber Multiply(RationalNumber x, RationalNumber y)
        {
            return (new RationalNumber(x._InternalNumerator.Multiply(y._InternalNumerator), x._InternalDenominator.Multiply(y._InternalDenominator)));
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
        public RationalNumber Divide(long x)
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
        public RationalNumber Divide(ulong x)
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
        public RationalNumber Divide(UnsignedLongLongInteger x)
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
        public RationalNumber Divide(LongLongInteger x)
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
        public RationalNumber Divide(RationalNumber x)
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
        public static RationalNumber Divide(long x, RationalNumber y)
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
        public static RationalNumber Divide(ulong x, RationalNumber y)
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
        public static RationalNumber Divide(UnsignedLongLongInteger x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    return (new RationalNumber(x.ToLongLongInteger().Multiply(y._InternalDenominator), y._InternalNumerator.Abs()));
                default:
                    return (new RationalNumber(x.ToLongLongInteger().Multiply(y._InternalDenominator).Negate(), y._InternalNumerator.Abs()));
            }
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
        public static RationalNumber Divide(LongLongInteger x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    return (new RationalNumber(x.Multiply(y._InternalDenominator), y._InternalNumerator.Abs()));
                default:
                    return (new RationalNumber(x.Multiply(y._InternalDenominator).Negate(), y._InternalNumerator.Abs()));
            }
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
        public static RationalNumber Divide(RationalNumber x, long y)
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
        public static RationalNumber Divide(RationalNumber x, ulong y)
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
        public static RationalNumber Divide(RationalNumber x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else
                return (new RationalNumber(x._InternalNumerator, x._InternalDenominator.Multiply(y)));
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
        public static RationalNumber Divide(RationalNumber x, LongLongInteger y)
        {
            switch (y.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    return (new RationalNumber(x._InternalNumerator, x._InternalDenominator.Multiply(y.Abs())));
                default:
                    return (new RationalNumber(x._InternalNumerator.Negate(), x._InternalDenominator.Multiply(y.Abs())));
            }
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
        public static RationalNumber Divide(RationalNumber x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    return (new RationalNumber(x._InternalNumerator.Multiply(y._InternalDenominator), x._InternalDenominator.Multiply(y._InternalNumerator.Abs())));
                default:
                    return (new RationalNumber(x._InternalNumerator.Multiply(y._InternalDenominator).Negate(), x._InternalDenominator.Multiply(y._InternalNumerator.Abs())));
            }
        }

        #endregion

        #region DivRem のオーバーロード

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(long x, out RationalNumber r)
        {
            return (DivRem(this, new LongLongInteger(x), out r));
        }

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(ulong x, out RationalNumber r)
        {
            return (DivRem(this, new UnsignedLongLongInteger(x), out r));
        }

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(UnsignedLongLongInteger x, out RationalNumber r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(LongLongInteger x, out RationalNumber r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// 与えられたオブジェクトとの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(RationalNumber x, out RationalNumber r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(long x, RationalNumber y, out RationalNumber r)
        {
            return (DivRem(new LongLongInteger(x), y, out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(ulong x, RationalNumber y, out RationalNumber r)
        {
            return (DivRem(new UnsignedLongLongInteger(x), y, out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(UnsignedLongLongInteger x, RationalNumber y, out RationalNumber r)
        {
            UnsignedLongLongInteger t;
            LongLongInteger q;
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(SignType.Positive, t, y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Subtract(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
                default:
                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(SignType.Negative, t, y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Add(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
            }
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(LongLongInteger x, RationalNumber y, out RationalNumber r)
        {
            LongLongInteger t;
            LongLongInteger q;
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(t.InternalSign, t.Abs(), y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Subtract(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
                default:

                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(t.InternalSign.Negate(), t.Abs(), y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Add(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
            }
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, long y, out RationalNumber r)
        {
            return (DivRem(x, new LongLongInteger(y), out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, ulong y, out RationalNumber r)
        {
            return (DivRem(x, new UnsignedLongLongInteger(y), out r));
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, UnsignedLongLongInteger y, out RationalNumber r)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else
            {
                UnsignedLongLongInteger t = x._InternalDenominator.Multiply(y);
                LongLongInteger q = FloorImp(x._InternalNumerator.InternalSign, x._InternalNumerator.Abs(), t);
                r = new RationalNumber(x._InternalNumerator.Subtract(q.Multiply(t)), x._InternalDenominator);
                return (q);
            }
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, LongLongInteger y, out RationalNumber r)
        {
            UnsignedLongLongInteger t;
            LongLongInteger q;
            switch (y.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    t = x._InternalDenominator.Multiply(y.Abs());
                    q = FloorImp(x._InternalNumerator.InternalSign, x._InternalNumerator.Abs(), t);
                    r = new RationalNumber(x._InternalNumerator.Subtract(q.Multiply(t)), x._InternalDenominator);
                    return (q);
                default:
                    t = x._InternalDenominator.Multiply(y.Abs());
                    q = FloorImp(x._InternalNumerator.InternalSign.Negate(), x._InternalNumerator.Abs(), t);
                    r = new RationalNumber(x._InternalNumerator.Add(q.Multiply(t)), x._InternalDenominator);
                    return (q);
            }
        }

        /// <summary>
        /// 二つのオブジェクトの商と剰余を計算します。
        /// 被除数がu、除数がvとした場合、商qと剰余rは以下の式で定義されます。
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, RationalNumber y, out RationalNumber r)
        {
            LongLongInteger t1;
            UnsignedLongLongInteger t2;
            LongLongInteger q;
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    t1 = x._InternalNumerator.Multiply(y._InternalDenominator);
                    t2 = x._InternalDenominator.Multiply(y._InternalNumerator.Abs());
                    q = FloorImp(t1.InternalSign, t1.Abs(), t2);
                    r = new RationalNumber(t1.Subtract(q.Multiply(t2)), x._InternalDenominator.Multiply(y._InternalDenominator));
                    return (q);
                default:
                    t1 = x._InternalNumerator.Multiply(y._InternalDenominator);
                    t2 = x._InternalDenominator.Multiply(y._InternalNumerator.Abs()); ;
                    q = FloorImp(t1.InternalSign.Negate(), t1.Abs(), t2);
                    r = new RationalNumber(t1.Add(q.Multiply(t2)), x._InternalDenominator.Multiply(y._InternalDenominator));
                    return (q);
            }
        }

        #endregion

        #region Negate のオーバーロード

        /// <summary>
        /// 符号が反転した値を計算します。
        /// </summary>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public RationalNumber Negate()
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
        public static RationalNumber Negate(RationalNumber x)
        {
            return (new RationalNumber(x._InternalNumerator.Negate(), x._InternalDenominator));
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
        public RationalNumber Power(long exp)
        {
            return (Power(this, new LongLongInteger(exp)));
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
        [CLSCompliant(false)]
        public RationalNumber Power(ulong exp)
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
        public RationalNumber Power(UnsignedLongLongInteger exp)
        {
            return (Power(this, exp));
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
        public RationalNumber Power(LongLongInteger exp)
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
        public static RationalNumber Power(RationalNumber x, long exp)
        {
            return (Power(x, new LongLongInteger(exp)));
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
        public static RationalNumber Power(RationalNumber x, ulong exp)
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
        public static RationalNumber Power(RationalNumber x, UnsignedLongLongInteger exp)
        {
            if (exp.IsZero)
                return (One);
            else if (x._InternalNumerator.InternalSign == SignType.Zero)
                return (Zero);
            else
                return (new RationalNumber(x._InternalNumerator.Power(exp), x._InternalDenominator.Power(exp)));
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
        public static RationalNumber Power(RationalNumber x, LongLongInteger exp)
        {
            switch (exp.InternalSign)
            {
                case SignType.Zero:
                    return (One);
                case SignType.Negative:
                    if (x._InternalNumerator.InternalSign == SignType.Zero)
                        throw (new DivideByZeroException("0による除算が行われようとしました。"));
                    else
                        return (Reciprocal(x._InternalDenominator.Power(exp.Abs()), x._InternalNumerator.Power(exp.Abs())));
                default:
                    if (x._InternalNumerator.InternalSign == SignType.Zero)
                        return (Zero);
                    else
                        return (new RationalNumber(x._InternalNumerator.Power(exp.Abs()), x._InternalDenominator.Power(exp.Abs())));
            }
        }

        #endregion

        #region Abs のオーバーロード

        /// <summary>
        /// 現在のオブジェクトの絶対値を計算します。
        /// </summary>
        /// <returns>
        /// 絶対値です。
        /// </returns>
        public RationalNumber Abs()
        {
            return (new RationalNumber(_InternalNumerator.Abs().ToLongLongInteger(), _InternalDenominator));
        }

        #endregion

        #region Floor のオーバーロード

        /// <summary>
        /// 現在のオブジェクトより小さい最大の整数を計算します。
        /// </summary>
        /// <returns>
        /// 現在のオブジェクトより小さい最大の整数です。
        /// </returns>
        public LongLongInteger Floor()
        {
            return (FloorImp(_InternalNumerator.InternalSign, _InternalNumerator.Abs(), _InternalDenominator));
        }

        #endregion

        #region Ceiling のオーバーロード

        /// <summary>
        /// 現在のオブジェクトより大きい最小の整数を計算します。
        /// </summary>
        /// <returns>
        /// 現在のオブジェクトより大きい最小の整数です。
        /// </returns>
        public LongLongInteger Ceiling()
        {
            UnsignedLongLongInteger r;
            UnsignedLongLongInteger q = UnsignedLongLongInteger.DivRem(_InternalNumerator.Abs(), _InternalDenominator, out r);
            if (r.IsZero)
                return (new LongLongInteger(_InternalNumerator.InternalSign, q));
            else
                return (_rounders.Round(RoundingMode.ROUND_CEILING, _InternalNumerator.InternalSign, _InternalDenominator, q, r));
        }

        #endregion

        #region Round のオーバーロード

        /// <summary>
        /// 現在のオブジェクトの値を丸めたオブジェクトを返します。
        /// </summary>
        /// <param name="mode">
        /// 丸める方法を示します。
        /// </param>
        /// <returns>
        /// 丸められたオブジェクトを返します。
        /// </returns>
        public LongLongInteger Round(RoundingMode mode)
        {
            UnsignedLongLongInteger r;
            UnsignedLongLongInteger q = UnsignedLongLongInteger.DivRem(_InternalNumerator.Abs(), _InternalDenominator, out r);
            if (r.IsZero)
                return (new LongLongInteger(_InternalNumerator.InternalSign, q));
            else
                return (_rounders.Round(mode, _InternalNumerator.InternalSign, _InternalDenominator, q, r));
        }

        #endregion

        #region Reciprocal のオーバーロード

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public RationalNumber Reciprocal()
        {
            return (Reciprocal(this));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public static RationalNumber Reciprocal(long x)
        {
            return (Reciprocal(new LongLongInteger(x)));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber Reciprocal(ulong x)
        {
            return (Reciprocal(new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public static RationalNumber Reciprocal(UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                throw (new DivideByZeroException("0の逆数は計算できません。"));
            else
                return (Reciprocal(SignType.Positive, x));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public static RationalNumber Reciprocal(LongLongInteger x)
        {
            if (x.InternalSign == SignType.Zero)
                throw (new DivideByZeroException("0の逆数は計算できません。"));
            else
                return (Reciprocal(x.InternalSign, x.Abs()));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public static RationalNumber Reciprocal(RationalNumber x)
        {
            UnsignedLongLongInteger denominator;
            LongLongInteger numerator = x.ToFraction(out denominator);
            if (numerator.IsZero) 
                throw (new DivideByZeroException("0の逆数は計算できません。"));
            else
                return (Reciprocal(numerator.InternalSign, denominator, numerator.Abs()));
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
        [CLSCompliant(false)]
        public RationalNumber Max(ulong x)
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
        public RationalNumber Max(long x)
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
        public RationalNumber Max(UnsignedLongLongInteger x)
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
        public RationalNumber Max(LongLongInteger x)
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
        public RationalNumber Max(RationalNumber x)
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
        [CLSCompliant(false)]
        public static RationalNumber Max(ulong x, RationalNumber y)
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
        public static RationalNumber Max(long x, RationalNumber y)
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
        public static RationalNumber Max(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Max(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Max(RationalNumber x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, RationalNumber y)
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
        [CLSCompliant(false)]
        public RationalNumber Min(ulong x)
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
        public RationalNumber Min(long x)
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
        public RationalNumber Min(UnsignedLongLongInteger x)
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
        public RationalNumber Min(LongLongInteger x)
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
        public RationalNumber Min(RationalNumber x)
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
        [CLSCompliant(false)]
        public static RationalNumber Min(ulong x, RationalNumber y)
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
        public static RationalNumber Min(long x, RationalNumber y)
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
        public static RationalNumber Min(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Min(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Min(RationalNumber x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, RationalNumber y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (y);
        }

        #endregion

        #endregion

        #region インターナルメソッド

        internal static RationalNumber Reciprocal(SignType sign, UnsignedLongLongInteger value)
        {
            return (Reciprocal(sign, UnsignedLongLongInteger.One, value));
        }

        internal static RationalNumber Reciprocal(UnsignedLongLongInteger denominator, LongLongInteger numerator)
        {
            return (Reciprocal(numerator.InternalSign, denominator, numerator.Abs()));
        }

        internal static RationalNumber Reciprocal(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger numerator)
        {
            return (new RationalNumber(new LongLongInteger(sign, denominator), numerator));
        }

        #endregion

        #region プライベートメソッド

        private static LongLongInteger FloorImp(SignType sign, UnsignedLongLongInteger numerator, UnsignedLongLongInteger denominator)
        {
            UnsignedLongLongInteger r;
            UnsignedLongLongInteger q = UnsignedLongLongInteger.DivRem(numerator, denominator, out r);
            if (r.IsZero)
                return (new LongLongInteger(sign, q));
            else
                return (_rounders.Round(RoundingMode.ROUND_FLOOR, sign, denominator, q, r));
        }

        #endregion
    }
}