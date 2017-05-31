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
        public static bool operator ==(ulong x, UnsignedLongLongInteger y)
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
        public static bool operator ==(UnsignedLongLongInteger x, ulong y)
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
        public static bool operator ==(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Equals(x, y));
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
        public static bool operator !=(ulong x, UnsignedLongLongInteger y)
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
        [CLSCompliant(false)]
        public static bool operator !=(UnsignedLongLongInteger x, ulong y)
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
        public static bool operator !=(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (!Equals(y, x));
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
        public bool Equals(ulong o)
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
        [CLSCompliant(false)]
        public static bool Equals(ulong x, UnsignedLongLongInteger y)
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
        public static bool Equals(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (y == 0);
            else if (y == 0)
                return (false);
            else if (y <= ushort.MaxValue)
                return (_imp.Equals(x._InternalValue, (ushort)y));
            else
                return (_imp.Equals(x._InternalValue, CreateInternalValue(y)));
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
            if (x._InternalValue.Length == 0)
                return (y._InternalValue.Length == 0);
            else if (y._InternalValue.Length == 0)
                return (false);
            else
                return (_imp.Equals(x._InternalValue, y._InternalValue));
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
