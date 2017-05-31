/*
  LongLongIntegerExtensions.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math
{
    /// <summary>
    /// 組み込み型と<see cref="LongLongInteger"/>型との演算を拡張するクラスです。
    /// </summary>
    public static class LongLongIntegerExtensions
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
        public static LongLongInteger Add(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Add(y, new LongLongInteger(x)));
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
        public static LongLongInteger Add(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Add(y, new UnsignedLongLongInteger(x)));
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
        public static LongLongInteger Add(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Add(y, x));
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
        public static LongLongInteger Subtract(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Subtract(new LongLongInteger(x), y));
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
        public static LongLongInteger Subtract(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Subtract(new UnsignedLongLongInteger(x), y));
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
        public static LongLongInteger Subtract(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Subtract(x, y));
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
        public static LongLongInteger Multiply(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Multiply(y, new LongLongInteger(x)));
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
        public static LongLongInteger Multiply(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Multiply(y, new UnsignedLongLongInteger(x)));
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
        public static LongLongInteger Multiply(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Multiply(y, x));
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
        public static LongLongInteger Divide(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Divide(new LongLongInteger(x), y));
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
        public static LongLongInteger Divide(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Divide(new UnsignedLongLongInteger(x), y));
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
        public static LongLongInteger Divide(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Divide(x, y));
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
        public static LongLongInteger DivideExactly(this long x, LongLongInteger y)
        {
            return (LongLongInteger.DivideExactly(new LongLongInteger(x), y));
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
        public static LongLongInteger DivideExactly(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.DivideExactly(new UnsignedLongLongInteger(x), y));
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
        public static LongLongInteger DivideExactly(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.DivideExactly(x, y));
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
        public static LongLongInteger Mod(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Mod(new LongLongInteger(x), y));
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
        public static UnsignedLongLongInteger Mod(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Mod(new UnsignedLongLongInteger(x), y));
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
        public static UnsignedLongLongInteger Mod(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Mod(x, y));
        }

        #endregion

        #region Negative のオーバーロード

        /// <summary>
        /// 符号が反転した値を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger Negate(this UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                return (LongLongInteger.Zero);
            else
                return (new LongLongInteger(SignType.Negative, x));
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
        public static LongLongInteger DivRem(this long x, LongLongInteger y, out LongLongInteger r)
        {
            return (LongLongInteger.DivRem(new LongLongInteger(x), y, out r));
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
        public static LongLongInteger DivRem(this ulong x, LongLongInteger y, out UnsignedLongLongInteger r)
        {
            return (LongLongInteger.DivRem(new UnsignedLongLongInteger(x), y, out r));
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
        public static LongLongInteger DivRem(this UnsignedLongLongInteger x, LongLongInteger y, out UnsignedLongLongInteger r)
        {
            return (LongLongInteger.DivRem(x, y, out r));
        }

        #endregion

        #region GreatestCommonDivisor のオーバーロード

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
        public static UnsignedLongLongInteger GreatestCommonDivisor(this long x, LongLongInteger y)
        {
            return (LongLongInteger.GreatestCommonDivisor(new LongLongInteger(x), y.Abs()));
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
        public static UnsignedLongLongInteger GreatestCommonDivisor(this ulong x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x, y.Abs()));
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
        public static UnsignedLongLongInteger GreatestCommonDivisor(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x, y.Abs()));
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
        public static LongLongInteger Max(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Max(y, x));
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
        public static UnsignedLongLongInteger Max(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Max(y, x));
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
        public static UnsignedLongLongInteger Max(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Max(y, x));
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
        public static LongLongInteger Min(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Min(y, x));
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
        public static LongLongInteger Min(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Min(y, x));
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
        public static LongLongInteger Min(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Min(y, x));
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
        public static LongLongInteger Xor(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Xor(new LongLongInteger(x), y));
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
        public static LongLongInteger Xor(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Xor(new UnsignedLongLongInteger(x), y));
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
        public static LongLongInteger Xor(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Xor(x, y));
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
        public static LongLongInteger BitwiseAnd(this long x, LongLongInteger y)
        {
            return (LongLongInteger.BitwiseAnd(new LongLongInteger(x), y));
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
        public static ulong BitwiseAnd(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.BitwiseAnd(y, x));
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
        public static UnsignedLongLongInteger BitwiseAnd(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.BitwiseAnd(y, x));
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
        public static LongLongInteger BitwiseOr(this long x, LongLongInteger y)
        {
            return (LongLongInteger.BitwiseOr(new LongLongInteger(x), y));
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
        public static LongLongInteger BitwiseOr(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.BitwiseOr(new UnsignedLongLongInteger(x), y));
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
        public static LongLongInteger BitwiseOr(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.BitwiseOr(x, y));
        }

        #endregion

        #region OnesComplement のオーバーロード

        /// <summary>
        /// 整数のビット毎の否定を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger OnesComplement(this UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                return (LongLongInteger.MinusOne);
            else
                return (new LongLongInteger(SignType.Negative, x.Increment()));
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
        public static bool Equals(this long x, LongLongInteger y)
        {
            return (LongLongInteger.Equals(y, x));
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
        public static bool Equals(this ulong x, LongLongInteger y)
        {
            return (LongLongInteger.Equals(y, x));
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
        public static bool Equals(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (LongLongInteger.Equals(y, x));
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
        public static int CompareTo(this long x, LongLongInteger y)
        {
            return (-LongLongInteger.Compare(y, x));
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
        public static int CompareTo(this ulong x, LongLongInteger y)
        {
            return (-LongLongInteger.Compare(y, x));
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
        public static int CompareTo(this UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (-LongLongInteger.Compare(y, x));
        }

        #endregion

        #region ToLongLongInteger のオーバーロード

        /// <summary>
        /// <see cref="sbyte"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger ToLongLongInteger(this sbyte value)
        {
            return (LongLongInteger.FromSByte(value));
        }

        /// <summary>
        /// <see cref="short"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this short value)
        {
            return (LongLongInteger.FromInt16(value));
        }

        /// <summary>
        /// <see cref="int"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this int value)
        {
            return (LongLongInteger.FromInt32(value));
        }

        /// <summary>
        /// <see cref="long"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this long value)
        {
            return (LongLongInteger.FromInt64(value));
        }

        /// <summary>
        /// <see cref="byte"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this byte value)
        {
            return (LongLongInteger.FromByte(value));
        }

        /// <summary>
        /// <see cref="ushort"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger ToLongLongInteger(this ushort value)
        {
            return (LongLongInteger.FromUInt16(value));
        }

        /// <summary>
        /// <see cref="uint"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger ToLongLongInteger(this uint value)
        {
            return (LongLongInteger.FromUInt32(value));
        }

        /// <summary>
        /// <see cref="ulong"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger ToLongLongInteger(this ulong value)
        {
            return (LongLongInteger.FromUInt64(value));
        }

        /// <summary>
        /// <see cref="float"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this float value)
        {
            return (LongLongInteger.FromSingle(value));
        }

        /// <summary>
        /// <see cref="double"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this double value)
        {
            return (LongLongInteger.FromDouble(value));
        }

        /// <summary>
        /// <see cref="decimal"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this decimal value)
        {
            return (LongLongInteger.FromDecimal(value));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを<see cref="LongLongInteger"/>型に変換します。
        /// </summary>
        /// <param name="value">
        /// 変換するオブジェクトです。
        /// </param>
        /// <returns>
        /// 変換されたオブジェクトです。
        /// </returns>
        public static LongLongInteger ToLongLongInteger(this UnsignedLongLongInteger value)
        {
            return (LongLongInteger.FromUnsignedLongLongInteger(value));
        }

        #endregion

    }
}
