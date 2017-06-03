/*
  UnsignedLongLongInteger.Equality.cs

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
        : IEquatable<UnsignedLongLongInteger>
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
        [CLSCompliant(false)]
        public static bool operator ==(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.Equals(x));
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
        public static bool operator ==(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.Equals(x));
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
        public static bool operator ==(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.Equals(y));
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
        public static bool operator ==(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.Equals(y));
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
        public static bool operator ==(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.Equals(y._native_value));
        }

        #endregion

        #region != のオーバーロード

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
        public static bool operator !=(uint x, UnsignedLongLongInteger y)
        {
            return (!y._native_value.Equals(x));
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
        public static bool operator !=(ulong x, UnsignedLongLongInteger y)
        {
            return (!y._native_value.Equals(x));
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
        public static bool operator !=(UnsignedLongLongInteger x, uint y)
        {
            return (!x._native_value.Equals(y));
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
        public static bool operator !=(UnsignedLongLongInteger x, ulong y)
        {
            return (!x._native_value.Equals(y));
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
        public static bool operator !=(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (!x._native_value.Equals(y));
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
        [CLSCompliant(false)]
        public bool Equals(uint o)
        {
            return (_native_value.Equals(o));
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
            return (_native_value.Equals(o));
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
        public static bool Equals(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.Equals(x));
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
        public static bool Equals(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.Equals(x));
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
        public static bool Equals(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.Equals(y));
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
        public static bool Equals(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.Equals(y));
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
        public static bool Equals(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.Equals(y._native_value));
        }

        #endregion

        #endregion

        #region IEquatable<UnsignedLongLongInteger> メンバ

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
            return (UnsignedLongLongInteger.Equals(this, o));
        }

        #endregion
    }
}