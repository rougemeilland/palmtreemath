/*
  RationalNumberExtensions.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math
{
    /// <summary>
    /// 組み込み型と<see cref="RationalNumber"/>型との演算を拡張するクラスです。
    /// </summary>
    public static class RationalNumberExtensions
    {
        #region Add のオーバーロード

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
        public static RationalNumber Add(this long x, RationalNumber y)
        {
            return (RationalNumber.Add(new LongLongInteger(x), y));
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
        public static RationalNumber Add(this ulong x, RationalNumber y)
        {
            return (RationalNumber.Add(new UnsignedLongLongInteger(x), y));
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
        public static RationalNumber Add(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Add(x, y));
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
        public static RationalNumber Add(this LongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Add(x, y));
        }

        #endregion

        #region Subtract のオーバーロード

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
        public static RationalNumber Subtract(this long x, RationalNumber y)
        {
            return (RationalNumber.Subtract(new LongLongInteger(x), y));
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
        public static RationalNumber Subtract(this ulong x, RationalNumber y)
        {
            return (RationalNumber.Subtract(new UnsignedLongLongInteger(x), y));
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
        public static RationalNumber Subtract(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Subtract(x, y));
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
        public static RationalNumber Subtract(this LongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Subtract(x, y));
        }

        #endregion

        #region Multiply のオーバーロード

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
        public static RationalNumber Multiply(this long x, RationalNumber y)
        {
            return (RationalNumber.Multiply(new LongLongInteger(x), y));
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
        public static RationalNumber Multiply(this ulong x, RationalNumber y)
        {
            return (RationalNumber.Multiply(new UnsignedLongLongInteger(x), y));
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
        public static RationalNumber Multiply(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Multiply(x, y));
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
        public static RationalNumber Multiply(this LongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Multiply(x, y));
        }

        #endregion

        #region Divide のオーバーロード

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
        public static RationalNumber Divide(this long x, RationalNumber y)
        {
            return (RationalNumber.Divide(new LongLongInteger(x), y));
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
        public static RationalNumber Divide(this ulong x, RationalNumber y)
        {
            return (RationalNumber.Divide(new UnsignedLongLongInteger(x), y));
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
        public static RationalNumber Divide(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Divide(x, y));
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
        public static RationalNumber Divide(this LongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Divide(x, y));
        }

        #endregion

        #region DivRem のオーバーロード

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
        public static LongLongInteger DivRem(this long x, RationalNumber y, out RationalNumber r)
        {
            return (RationalNumber.DivRem(new LongLongInteger(x), y, out r));
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
        public static LongLongInteger DivRem(this ulong x, RationalNumber y, out RationalNumber r)
        {
            return (RationalNumber.DivRem(new UnsignedLongLongInteger(x), y, out r));
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
        public static LongLongInteger DivRem(this UnsignedLongLongInteger x, RationalNumber y, out RationalNumber r)
        {
            return (RationalNumber.DivRem(x, y, out r));
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
        public static LongLongInteger DivRem(this LongLongInteger x, RationalNumber y, out RationalNumber r)
        {
            return (RationalNumber.DivRem(x, y, out r));
        }

        #endregion

        #region Reciprocal のオーバーロード

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="value">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public static RationalNumber Reciprocal(this long value)
        {
            return (RationalNumber.Reciprocal(value));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="value">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber Reciprocal(this ulong value)
        {
            return (RationalNumber.Reciprocal(value));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="value">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public static RationalNumber Reciprocal(this UnsignedLongLongInteger value)
        {
            return (RationalNumber.Reciprocal(value));
        }

        /// <summary>
        /// オブジェクトの逆数を計算します。
        /// </summary>
        /// <param name="value">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果の逆数です。
        /// </returns>
        public static RationalNumber Reciprocal(this LongLongInteger value)
        {
            return (RationalNumber.Reciprocal(value));
        }

        #endregion

        #region Max のオーバーロード

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
        public static RationalNumber Max(this ulong x, RationalNumber y)
        {
            return (RationalNumber.Max(y, x));
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
        public static RationalNumber Max(this long x, RationalNumber y)
        {
            return (RationalNumber.Max(y, x));
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
        public static RationalNumber Max(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Max(y, x));
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
        public static RationalNumber Max(this LongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Max(y, x));
        }

        #endregion

        #region Min のオーバーロード

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
        public static RationalNumber Min(this long x, RationalNumber y)
        {
            return (RationalNumber.Min(y, x));
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
        public static RationalNumber Min(this ulong x, RationalNumber y)
        {
            return (RationalNumber.Min(y, x));
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
        public static RationalNumber Min(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Min(y, x));
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
        public static RationalNumber Min(this LongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Min(y, x));
        }

        #endregion

        #region Equals のオーバーロード

        /// <summary>
        /// 二つのオブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool Equals(this long x, RationalNumber y)
        {
            return (RationalNumber.Equals(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool Equals(this ulong x, RationalNumber y)
        {
            return (RationalNumber.Equals(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool Equals(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Equals(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool Equals(this LongLongInteger x, RationalNumber y)
        {
            return (RationalNumber.Equals(y, x));
        }

        #endregion

        #region CompareTo のオーバーロード

        /// <summary>
        /// 二つのオブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="x">
        /// 比較するオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較するオブジェクトです。
        /// </param>
        /// <returns>
        /// xがyより小さいならば負の数、xがyと等しいならば0、xがyより大きいならば正の数です。
        /// </returns>
        public static int CompareTo(this long x, RationalNumber y)
        {
            return (-RationalNumber.Compare(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="x">
        /// 比較するオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較するオブジェクトです。
        /// </param>
        /// <returns>
        /// xがyより小さいならば負の数、xがyと等しいならば0、xがyより大きいならば正の数です。
        /// </returns>
        [CLSCompliant(false)]
        public static int CompareTo(this ulong x, RationalNumber y)
        {
            return (-RationalNumber.Compare(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="x">
        /// 比較するオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較するオブジェクトです。
        /// </param>
        /// <returns>
        /// xがyより小さいならば負の数、xがyと等しいならば0、xがyより大きいならば正の数です。
        /// </returns>
        public static int CompareTo(this UnsignedLongLongInteger x, RationalNumber y)
        {
            return (-RationalNumber.Compare(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="x">
        /// 比較するオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較するオブジェクトです。
        /// </param>
        /// <returns>
        /// xがyより小さいならば負の数、xがyと等しいならば0、xがyより大きいならば正の数です。
        /// </returns>
        public static int CompareTo(this LongLongInteger x, RationalNumber y)
        {
            return (-RationalNumber.Compare(y, x));
        }

        #endregion

        #region ToRationalNumber のオーバーロード

        /// <summary>
        /// <see cref="int"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static RationalNumber ToRationalNumber(this int value)
        {
            return (RationalNumber.FromInt64(value));
        }

        /// <summary>
        /// <see cref="long"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static RationalNumber ToRationalNumber(this long value)
        {
            return (RationalNumber.FromInt64(value));
        }

        /// <summary>
        /// <see cref="ulong"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber ToRationalNumber(this ulong value)
        {
            return (RationalNumber.FromUInt64(value));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static RationalNumber ToRationalNumber(this UnsignedLongLongInteger value)
        {
            return (RationalNumber.FromUnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static RationalNumber ToRationalNumber(this LongLongInteger value)
        {
            return (RationalNumber.FromLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="float"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static RationalNumber ToRationalNumber(this float value)
        {
            return (RationalNumber.FromSingle(value));
        }

        /// <summary>
        /// <see cref="double"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static RationalNumber ToRationalNumber(this double value)
        {
            return (RationalNumber.FromDouble(value));
        }

        /// <summary>
        /// <see cref="decimal"/>オブジェクトを<see cref="RationalNumber"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static RationalNumber ToRationalNumber(this decimal value)
        {
            return (RationalNumber.FromDecimal(value));
        }

        #endregion

    }
}
