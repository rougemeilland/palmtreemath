/*
  RationalNumber.Equality.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// 演算子のオーバーロードに関するガイドライン:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct RationalNumber
        : IEquatable<RationalNumber>
    {
        #region 演算子
        
#if !CONCEAL_OPERATORS

        #region == のオーバーロード

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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator ==(long x, RationalNumber y)
        {
            return (Equals(y, x));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator ==(ulong x, RationalNumber y)
        {
            return (Equals(y, x));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator ==(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Equals(y, x));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator ==(LongLongInteger x, RationalNumber y)
        {
            return (Equals(y, x));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator ==(RationalNumber x, long y)
        {
            return (Equals(x, y));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator ==(RationalNumber x, ulong y)
        {
            return (Equals(x, y));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator ==(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Equals(x, y));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator ==(RationalNumber x, LongLongInteger y)
        {
            return (Equals(x, y));
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
        /// xとyが等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator ==(RationalNumber x, RationalNumber y)
        {
            return (Equals(x, y));
        }

        #endregion

        #region != のオーバーロード

        /// <summary>
        /// 二つのオブジェクトの大小関係を調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator !=(long x, RationalNumber y)
        {
            return (!Equals(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの大小関係を調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator !=(ulong x, RationalNumber y)
        {
            return (!Equals(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの大小関係を調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator !=(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (!Equals(y, x));
        }

        /// <summary>
        /// 二つのオブジェクトの大小関係を調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator !=(LongLongInteger x, RationalNumber y)
        {
            return (!Equals(y, x));
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
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator !=(RationalNumber x, long y)
        {
            return (!Equals(x, y));
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
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator !=(RationalNumber x, ulong y)
        {
            return (!Equals(x, y));
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
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator !=(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (!Equals(x, y));
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
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator !=(RationalNumber x, LongLongInteger y)
        {
            return (!Equals(x, y));
        }

        /// <summary>
        /// 二つのオブジェクトの大小関係を調べます。
        /// </summary>
        /// <param name="x">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <param name="y">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// xとyが等しくないならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator !=(RationalNumber x, RationalNumber y)
        {
            return (!Equals(x, y));
        }

        #endregion

#endif

        #endregion

        #region パブリックメソッド

        #region Equals のオーバーロード

        /// <summary>
        /// オブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public bool Equals(long o)
        {
            return (Equals(this, o));
        }

        /// <summary>
        /// オブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public bool Equals(ulong o)
        {
            return (Equals(this, o));
        }

        /// <summary>
        /// オブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public bool Equals(UnsignedLongLongInteger o)
        {
            return (Equals(this, o));
        }

        /// <summary>
        /// オブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public bool Equals(LongLongInteger o)
        {
            return (Equals(this, o));
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
        public static bool Equals(long x, RationalNumber y)
        {
            return (Equals(y, x));
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
        public static bool Equals(ulong x, RationalNumber y)
        {
            return (Equals(y, x));
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
        public static bool Equals(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Equals(y, x));
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
        public static bool Equals(LongLongInteger x, RationalNumber y)
        {
            return (Equals(y, x));
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
        public static bool Equals(RationalNumber x, long y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, ulong y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, LongLongInteger y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, RationalNumber y)
        {
            return (x._InternalDenominator.Equals(y._InternalDenominator) && x._InternalNumerator.Equals(y._InternalNumerator));
        }

        #endregion

        #endregion

        #region IEquatable<RationalNumber> メンバ

        /// <summary>
        /// オブジェクトが論理的に等しいかどうか調べます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトが論理的に等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public bool Equals(RationalNumber o)
        {
            return (RationalNumber.Equals(this, o));
        }

        #endregion
    }
}
