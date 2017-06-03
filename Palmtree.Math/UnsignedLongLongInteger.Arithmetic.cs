/*
  UnsignedLongLongInteger.Arithmetic.cs

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

        #region 単項 + 演算子のオーバーロード

        /// <summary>
        /// オブジェクトをそのまま返します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xに等しいオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger operator +(UnsignedLongLongInteger x)
        {
            return (x);
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
        public static UnsignedLongLongInteger operator ++(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(1)));
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
        public static UnsignedLongLongInteger operator --(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(1)));
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator +(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Add(x)));
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
        public static UnsignedLongLongInteger operator +(ulong x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Add(x)));
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
        public static UnsignedLongLongInteger operator +(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(y)));
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
        public static UnsignedLongLongInteger operator +(UnsignedLongLongInteger x, ulong y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(y)));
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
        public static UnsignedLongLongInteger operator +(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(y._native_value)));
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
        [CLSCompliant(false)]
        public static uint operator -(uint x, UnsignedLongLongInteger y)
        {
            return (x.Subtract(y._native_value));
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
        public static ulong operator -(ulong x, UnsignedLongLongInteger y)
        {
            return (x.Subtract(y._native_value));
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
        public static UnsignedLongLongInteger operator -(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(y)));
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
        public static UnsignedLongLongInteger operator -(UnsignedLongLongInteger x, ulong y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(y)));
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
        public static UnsignedLongLongInteger operator -(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(y._native_value)));
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator *(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Multiply(x)));
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
        public static UnsignedLongLongInteger operator *(ulong x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Multiply(x)));
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
        public static UnsignedLongLongInteger operator *(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Multiply(y)));
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
        public static UnsignedLongLongInteger operator *(UnsignedLongLongInteger x, ulong y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Multiply(y)));
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
        public static UnsignedLongLongInteger operator *(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Multiply(y._native_value)));
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
        [CLSCompliant(false)]
        public static uint operator /(uint x, UnsignedLongLongInteger y)
        {
            uint r;
            return (x.DivRem(y._native_value, out r));
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
        public static ulong operator /(ulong x, UnsignedLongLongInteger y)
        {
            ulong r;
            return (x.DivRem(y._native_value, out r));
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
        public static UnsignedLongLongInteger operator /(UnsignedLongLongInteger x, uint y)
        {
            uint r;
            return (new UnsignedLongLongInteger(x._native_value.DivRem(y, out r)));
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
        public static UnsignedLongLongInteger operator /(UnsignedLongLongInteger x, ulong y)
        {
            ulong r;
            return (new UnsignedLongLongInteger(x._native_value.DivRem(y, out r)));
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
        public static UnsignedLongLongInteger operator /(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            NativeUnsignedInteger r;
            return (new UnsignedLongLongInteger(x._native_value.DivRem(y._native_value, out r)));
        }

        #endregion

        #region 二項 % 演算子のオーバーロード

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
        public static uint operator %(uint x, UnsignedLongLongInteger y)
        {
            uint r;
            y._native_value.DivRem(x, out r);
            return (r);
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
        public static ulong operator %(ulong x, UnsignedLongLongInteger y)
        {
            ulong r;
            y._native_value.DivRem(x, out r);
            return (r);
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
        public static uint operator %(UnsignedLongLongInteger x, uint y)
        {
            uint r;
            x._native_value.DivRem(y, out r);
            return (r);
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
        public static ulong operator %(UnsignedLongLongInteger x, ulong y)
        {
            ulong r;
            x._native_value.DivRem(y, out r);
            return (r);
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
        public static UnsignedLongLongInteger operator %(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            NativeUnsignedInteger r;
            x._native_value.DivRem(y._native_value, out r);
            return (new UnsignedLongLongInteger(r));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Add(uint x)
        {
            return (new UnsignedLongLongInteger(_native_value.Add(x)));
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
        public UnsignedLongLongInteger Add(ulong x)
        {
            return (new UnsignedLongLongInteger(_native_value.Add(x)));
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
        public UnsignedLongLongInteger Add(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(_native_value.Add(x._native_value)));
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
        public static UnsignedLongLongInteger Add(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Add(x)));
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
        public static UnsignedLongLongInteger Add(ulong x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Add(x)));
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
        public static UnsignedLongLongInteger Add(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(y)));
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
        public static UnsignedLongLongInteger Add(UnsignedLongLongInteger x, ulong y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(y)));
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
        public static UnsignedLongLongInteger Add(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(y._native_value)));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Subtract(uint x)
        {
            return (new UnsignedLongLongInteger(_native_value.Subtract(x)));
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
        public UnsignedLongLongInteger Subtract(ulong x)
        {
            return (new UnsignedLongLongInteger(_native_value.Subtract(x)));
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
        public UnsignedLongLongInteger Subtract(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(_native_value.Subtract(x._native_value)));
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
        public static uint Subtract(uint x, UnsignedLongLongInteger y)
        {
            return (x.Subtract(y._native_value));
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
        public static ulong Subtract(ulong x, UnsignedLongLongInteger y)
        {
            return (x.Subtract(y._native_value));
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
        public static UnsignedLongLongInteger Subtract(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(y)));
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
        public static UnsignedLongLongInteger Subtract(UnsignedLongLongInteger x, ulong y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(y)));
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
        public static UnsignedLongLongInteger Subtract(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(y._native_value)));
        }

        #endregion

        #region Increment のオーバーロード

        /// <summary>
        /// 整数をインクリメントします。
        /// </summary>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger Increment()
        {
            return (new UnsignedLongLongInteger(_native_value.Add(1)));
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
        public static UnsignedLongLongInteger Increment(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(x._native_value.Add(1)));
        }

        #endregion

        #region Decrement のオーバーロード

        /// <summary>
        /// 整数をデクリメントします。
        /// </summary>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger Decrement()
        {
            return (new UnsignedLongLongInteger(_native_value.Subtract(1)));
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
        public static UnsignedLongLongInteger Decrement(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(x._native_value.Subtract(1)));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Multiply(uint x)
        {
            return (new UnsignedLongLongInteger(_native_value.Multiply(x)));
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
        public UnsignedLongLongInteger Multiply(ulong x)
        {
            return (new UnsignedLongLongInteger(_native_value.Multiply(x)));
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
        public UnsignedLongLongInteger Multiply(UnsignedLongLongInteger x)
        {
            return (new UnsignedLongLongInteger(_native_value.Multiply(x._native_value)));
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
        public static UnsignedLongLongInteger Multiply(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Multiply(x)));
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
        public static UnsignedLongLongInteger Multiply(ulong x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.Multiply(x)));
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
        public static UnsignedLongLongInteger Multiply(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Multiply(y)));
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
        public static UnsignedLongLongInteger Multiply(UnsignedLongLongInteger x, ulong y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Multiply(y)));
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
        public static UnsignedLongLongInteger Multiply(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(x._native_value.Multiply(y._native_value)));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Divide(uint x)
        {
            uint r;
            return (new UnsignedLongLongInteger(_native_value.DivRem(x, out r)));
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
        public UnsignedLongLongInteger Divide(ulong x)
        {
            ulong r;
            return (new UnsignedLongLongInteger(_native_value.DivRem(x, out r)));
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
        public UnsignedLongLongInteger Divide(UnsignedLongLongInteger x)
        {
            NativeUnsignedInteger r;
            return (new UnsignedLongLongInteger(_native_value.DivRem(x._native_value, out r)));
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
        public static uint Divide(uint x, UnsignedLongLongInteger y)
        {
            uint r;
            return (x.DivRem(y._native_value, out r));
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
        public static ulong Divide(ulong x, UnsignedLongLongInteger y)
        {
            ulong r;
            return (x.DivRem(y._native_value, out r));
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
        public static UnsignedLongLongInteger Divide(UnsignedLongLongInteger x, ulong y)
        {
            ulong r;
            return (new UnsignedLongLongInteger(x._native_value.DivRem(y, out r)));
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
        public static UnsignedLongLongInteger Divide(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            NativeUnsignedInteger r;
            return (new UnsignedLongLongInteger(x._native_value.DivRem(y._native_value, out r)));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger DivideExactly(uint x)
        {
            uint r;
            var q = _native_value.DivRem(x, out r);
            if (r != 0)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (new UnsignedLongLongInteger(q));
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
        public UnsignedLongLongInteger DivideExactly(ulong x)
        {
            ulong r;
            var q = _native_value.DivRem(x, out r);
            if (r != 0)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (new UnsignedLongLongInteger(q));
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
        public UnsignedLongLongInteger DivideExactly(UnsignedLongLongInteger x)
        {
            NativeUnsignedInteger r;
            var q = _native_value.DivRem(x._native_value, out r);
            if (!r.IsZero)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (new UnsignedLongLongInteger(q));
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
        public static ulong DivideExactly(uint x, UnsignedLongLongInteger y)
        {
            uint r;
            var q = x.DivRem(y._native_value, out r);
            if (r != 0)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (q);
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
        public static ulong DivideExactly(ulong x, UnsignedLongLongInteger y)
        {
            ulong r;
            var q = x.DivRem(y._native_value, out r);
            if (r != 0)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (q);
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
        public static UnsignedLongLongInteger DivideExactly(UnsignedLongLongInteger x, uint y)
        {
            uint r;
            var q = x._native_value.DivRem(y, out r);
            if (r != 0)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (new UnsignedLongLongInteger(q));
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
        public static UnsignedLongLongInteger DivideExactly(UnsignedLongLongInteger x, ulong y)
        {
            ulong r;
            var q = x._native_value.DivRem(y, out r);
            if (r != 0)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (new UnsignedLongLongInteger(q));
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
        public static UnsignedLongLongInteger DivideExactly(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            NativeUnsignedInteger r;
            var q = x._native_value.DivRem(y._native_value, out r);
            if (!r.IsZero)
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
            return (new UnsignedLongLongInteger(q));
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
        [CLSCompliant(false)]
        public uint Mod(uint x)
        {
            uint r;
            _native_value.DivRem(x, out r);
            return (r);
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
        public ulong Mod(ulong x)
        {
            ulong r;
            _native_value.DivRem(x, out r);
            return (r);
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
        public UnsignedLongLongInteger Mod(UnsignedLongLongInteger x)
        {
            NativeUnsignedInteger r;
            _native_value.DivRem(x._native_value, out r);
            return (new UnsignedLongLongInteger(r));
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
        public static uint Mod(uint x, UnsignedLongLongInteger y)
        {
            uint r;
            x.DivRem(y._native_value, out r);
            return (r);
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
        public static ulong Mod(ulong x, UnsignedLongLongInteger y)
        {
            ulong r;
            x.DivRem(y._native_value, out r);
            return (r);
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
        public static uint Mod(UnsignedLongLongInteger x, uint y)
        {
            uint r;
            x._native_value.DivRem(y, out r);
            return (r);
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
        public static ulong Mod(UnsignedLongLongInteger x, ulong y)
        {
            ulong r;
            x._native_value.DivRem(y, out r);
            return (r);
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
        public static UnsignedLongLongInteger Mod(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            NativeUnsignedInteger r;
            x._native_value.DivRem(y._native_value, out r);
            return (new UnsignedLongLongInteger(r));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger DivRem(uint x, out uint r)
        {
            return (new UnsignedLongLongInteger(_native_value.DivRem(x, out r)));
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
        public UnsignedLongLongInteger DivRem(ulong x, out ulong r)
        {
            return (new UnsignedLongLongInteger(_native_value.DivRem(x, out r)));
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
        public UnsignedLongLongInteger DivRem(UnsignedLongLongInteger x, out UnsignedLongLongInteger r)
        {
            NativeUnsignedInteger r_imp;
            var q = _native_value.DivRem(x._native_value, out r_imp);
            r = new UnsignedLongLongInteger(r_imp);
            return (new UnsignedLongLongInteger(q));
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
        public static UnsignedLongLongInteger DivRem(UnsignedLongLongInteger x, uint y, out uint r)
        {
            return (new UnsignedLongLongInteger(x._native_value.DivRem(y, out r)));
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
        public static UnsignedLongLongInteger DivRem(UnsignedLongLongInteger x, ulong y, out ulong r)
        {
            return (new UnsignedLongLongInteger(x._native_value.DivRem(y, out r)));
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
        public static uint DivRem(uint x, UnsignedLongLongInteger y, out uint r)
        {
            return (x.DivRem(y._native_value, out r));
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
        public static ulong DivRem(ulong x, UnsignedLongLongInteger y, out ulong r)
        {
            return (x.DivRem(y._native_value, out r));
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
        public static UnsignedLongLongInteger DivRem(UnsignedLongLongInteger x, UnsignedLongLongInteger y, out UnsignedLongLongInteger r)
        {
            NativeUnsignedInteger r_imp;
            var q = x._native_value.DivRem(y._native_value, out r_imp);
            r = new UnsignedLongLongInteger(r_imp);
            return (new UnsignedLongLongInteger(q));
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
        public UnsignedLongLongInteger Power(uint exp)
        {
            return (new UnsignedLongLongInteger(_native_value.Power(exp)));
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
        public UnsignedLongLongInteger Power(ulong exp)
        {
            return (new UnsignedLongLongInteger(_native_value.Power(exp)));
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
        public UnsignedLongLongInteger Power(UnsignedLongLongInteger exp)
        {
            return (new UnsignedLongLongInteger(_native_value.Power(exp._native_value)));
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
        public static UnsignedLongLongInteger Power(uint x, UnsignedLongLongInteger exp)
        {
            return (new UnsignedLongLongInteger(x.Power(exp._native_value)));
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
        public static UnsignedLongLongInteger Power(ulong x, UnsignedLongLongInteger exp)
        {
            return (new UnsignedLongLongInteger(x.Power(exp._native_value)));
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
        public static UnsignedLongLongInteger Power(UnsignedLongLongInteger x, uint exp)
        {
            return (new UnsignedLongLongInteger(x._native_value.Power(exp)));
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
        public static UnsignedLongLongInteger Power(UnsignedLongLongInteger x, ulong exp)
        {
            return (new UnsignedLongLongInteger(x._native_value.Power(exp)));
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
        public static UnsignedLongLongInteger Power(UnsignedLongLongInteger x, UnsignedLongLongInteger exp)
        {
            return (new UnsignedLongLongInteger(x._native_value.Power(exp._native_value)));
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
        [CLSCompliant(false)]
        public UnsignedLongLongInteger GreatestCommonDivisor(uint x)
        {
            return (new UnsignedLongLongInteger(_native_value.GreatestCommonDivisor(x)));
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
            return (new UnsignedLongLongInteger(_native_value.GreatestCommonDivisor(x)));
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
            return (new UnsignedLongLongInteger(_native_value.GreatestCommonDivisor(x._native_value)));
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
        public static UnsignedLongLongInteger GreatestCommonDivisor(uint x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.GreatestCommonDivisor(x)));
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
        public static UnsignedLongLongInteger GreatestCommonDivisor(ulong x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(y._native_value.GreatestCommonDivisor(x)));
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
        public static UnsignedLongLongInteger GreatestCommonDivisor(UnsignedLongLongInteger x, uint y)
        {
            return (new UnsignedLongLongInteger(x._native_value.GreatestCommonDivisor(y)));
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
        public static UnsignedLongLongInteger GreatestCommonDivisor(UnsignedLongLongInteger x, ulong y)
        {
            return (new UnsignedLongLongInteger(x._native_value.GreatestCommonDivisor(y)));
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
        public static UnsignedLongLongInteger GreatestCommonDivisor(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (new UnsignedLongLongInteger(x._native_value.GreatestCommonDivisor(y._native_value)));
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
        public UnsignedLongLongInteger Max(uint x)
        {
            return (_native_value.CompareTo(x) >= 0 ? this : new UnsignedLongLongInteger(x));
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
            return (_native_value.CompareTo(x) >= 0 ? this : new UnsignedLongLongInteger(x));
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
            return (_native_value.CompareTo(x._native_value) >= 0 ? this : x);
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を行います。
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
        public static UnsignedLongLongInteger Max(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) >= 0 ? y : new UnsignedLongLongInteger(x));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を行います。
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
        public static UnsignedLongLongInteger Max(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) >= 0 ? y : new UnsignedLongLongInteger(x));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を行います。
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
        public static UnsignedLongLongInteger Max(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.CompareTo(y) >= 0 ? x : new UnsignedLongLongInteger(y));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を行います。
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
        public static UnsignedLongLongInteger Max(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.CompareTo(y) >= 0 ? x : new UnsignedLongLongInteger(y));
        }

        /// <summary>
        /// 二つのオブジェクトの最大値を行います。
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
        public static UnsignedLongLongInteger Max(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.CompareTo(y._native_value) >= 0 ? x : y);
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
        public uint Min(uint x)
        {
            return (_native_value.CompareTo(x) <= 0 ? _native_value.ToUInt32() : x);
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
        public ulong Min(ulong x)
        {
            return (_native_value.CompareTo(x) <= 0 ? _native_value.ToUInt64() : x);
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
        public UnsignedLongLongInteger Min(UnsignedLongLongInteger x)
        {
            return (_native_value.CompareTo(x._native_value) <= 0 ? this : x);
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を行います。
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
        public static uint Min(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) <= 0 ? y._native_value.ToUInt32() : x);
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を行います。
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
        public static ulong Min(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) <= 0 ? y._native_value.ToUInt64() : x);
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を行います。
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
        public static uint Min(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.CompareTo(y) <= 0 ? x._native_value.ToUInt32() : y);
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を行います。
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
        public static ulong Min(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.CompareTo(y) <= 0 ? x._native_value.ToUInt64() : y);
        }

        /// <summary>
        /// 二つのオブジェクトの最小値を行います。
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
        public static UnsignedLongLongInteger Min(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.CompareTo(y._native_value) <= 0 ? x : y);
        }

        #endregion

        #endregion
    }
}