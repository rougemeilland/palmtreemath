/*
  UnsignedLongLongIntegerExtensions.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math
{
    /// <summary>
    /// 組み込み型と<see cref="UnsignedLongLongInteger"/>型との演算を拡張するクラスです。
    /// </summary>
    public static class UnsignedLongLongIntegerExtensions
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Add(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Add(y, x));
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Subtract(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Subtract(x, y));
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Multiply(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Multiply(y, x));
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
        [CLSCompliant(false)]
        public static ulong Divide(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Divide(x, y));
        }

        #endregion

        #region DivideExactly のオーバーロード

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
        public static ulong DivideExactly(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.DivideExactly(x, y));
        }

        #endregion

        #region Mod のオーバーロード

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
        public static ulong Mod(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Mod(x, y));
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
        [CLSCompliant(false)]
        public static ulong DivRem(this ulong x, UnsignedLongLongInteger y, out ulong r)
        {
            return (UnsignedLongLongInteger.DivRem(x, y, out r));
        }

        #endregion

        #region Power のオーバーロード

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
        public static UnsignedLongLongInteger Power(this ulong x, UnsignedLongLongInteger exp)
        {
            return (UnsignedLongLongInteger.Power(x, exp));
        }

        #endregion

        #region GreatestCommonDivisor のオーバーロード

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
        public static UnsignedLongLongInteger GreatestCommonDivisor(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(new UnsignedLongLongInteger(x), y));
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
        public static UnsignedLongLongInteger Max(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Max(y, x));
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
        [CLSCompliant(false)]
        public static ulong Min(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Min(y, x));
        }

        #endregion

        #region Xor のオーバーロード

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
        public static UnsignedLongLongInteger Xor(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Xor(x, y));
        }

        #endregion

        #region BitwiseAnd のオーバーロード

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
        public static ulong BitwiseAnd(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.BitwiseAnd(x, y));
        }

        #endregion

        #region BitwiseOr のオーバーロード

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
        public static UnsignedLongLongInteger BitwiseOr(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.BitwiseOr(x, y));
        }

        #endregion

        #region BitwiseComplementAnd のオーバーロード

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
        public static ulong BitwiseComplementAnd(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.BitwiseComplementAnd(x, y));
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
        [CLSCompliant(false)]
        public static bool Equals(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Equals(x, y));
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
        [CLSCompliant(false)]
        public static int CompareTo(this ulong x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.Compare(x, y));
        }

        #endregion

        #region ToUnsignedLongLongInteger のオーバーロード

        /// <summary>
        /// <see cref="sbyte"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this sbyte value)
        {
            return (UnsignedLongLongInteger.FromSByte(value));
        }

        /// <summary>
        /// <see cref="short"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this short value)
        {
            return (UnsignedLongLongInteger.FromInt16(value));
        }

        /// <summary>
        /// <see cref="int"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this int value)
        {
            return (UnsignedLongLongInteger.FromInt32(value));
        }

        /// <summary>
        /// <see cref="long"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this long value)
        {
            return (UnsignedLongLongInteger.FromInt64(value));
        }

        /// <summary>
        /// <see cref="byte"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this byte value)
        {
            return (UnsignedLongLongInteger.FromByte(value));
        }

        /// <summary>
        /// <see cref="ushort"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this ushort value)
        {
            return (UnsignedLongLongInteger.FromUInt16(value));
        }

        /// <summary>
        /// <see cref="uint"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this uint value)
        {
            return (UnsignedLongLongInteger.FromUInt32(value));
        }

        /// <summary>
        /// <see cref="ulong"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this ulong value)
        {
            return (UnsignedLongLongInteger.FromUInt64(value));
        }

        /// <summary>
        /// <see cref="float"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this float value)
        {
            return (UnsignedLongLongInteger.FromSingle(value));
        }

        /// <summary>
        /// <see cref="double"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this double value)
        {
            return (UnsignedLongLongInteger.FromDouble(value));
        }

        /// <summary>
        /// <see cref="decimal"/>オブジェクトを<see cref="UnsignedLongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger ToUnsignedLongLongInteger(this decimal value)
        {
            return (UnsignedLongLongInteger.FromDecimal(value));
        }

        #endregion
    }
}