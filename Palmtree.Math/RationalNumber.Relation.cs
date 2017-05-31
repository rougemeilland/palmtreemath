/*
  RationalNumber.Relation.cs

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
        : IComparable<RationalNumber>, IComparable
    {
        #region 演算子

#if !CONCEAL_OPERATORS

        #region < のオーバーロード

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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <(long x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <(ulong x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <(RationalNumber x, long y)
        {
            return (Compare(x, y) < 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <(RationalNumber x, ulong y)
        {
            return (Compare(x, y) < 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) < 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) < 0);
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
        /// xがyより小さいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) < 0);
        }

        #endregion

        #region <= のオーバーロード

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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <=(long x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <=(ulong x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <=(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <=(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <=(RationalNumber x, long y)
        {
            return (Compare(x, y) <= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <=(RationalNumber x, ulong y)
        {
            return (Compare(x, y) <= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <=(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) <= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <=(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) <= 0);
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
        /// xがyより小さいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator <=(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) <= 0);
        }

        #endregion

        #region > のオーバーロード

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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >(long x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >(ulong x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >(RationalNumber x, long y)
        {
            return (Compare(x, y) > 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >(RationalNumber x, ulong y)
        {
            return (Compare(x, y) > 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) > 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) > 0);
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
        /// xがyより大きいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) > 0);
        }

        #endregion

        #region >= のオーバーロード

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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >=(long x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >=(ulong x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >=(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >=(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >=(RationalNumber x, long y)
        {
            return (Compare(x, y) >= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >=(RationalNumber x, ulong y)
        {
            return (Compare(x, y) >= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >=(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) >= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >=(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) >= 0);
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
        /// xがyより大きいまたは等しいならばtrue、そうではないのならfalseです。
        /// </returns>
        public static bool operator >=(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) >= 0);
        }

        #endregion

#endif

        #endregion

        #region パブリックメソッド

        #region CompareTo のオーバーロード

        /// <summary>
        /// オブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトがoより小さいならば負の数、オブジェクトがoと等しいならば0、オブジェクトがoより大きいならば正の数です。
        /// </returns>
        public int CompareTo(long o)
        {
            return (Compare(this, o));
        }

        /// <summary>
        /// オブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトがoより小さいならば負の数、オブジェクトがoと等しいならば0、オブジェクトがoより大きいならば正の数です。
        /// </returns>
        [CLSCompliant(false)]
        public int CompareTo(ulong o)
        {
            return (Compare(this, o));
        }

        /// <summary>
        /// オブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトがoより小さいならば負の数、オブジェクトがoと等しいならば0、オブジェクトがoより大きいならば正の数です。
        /// </returns>
        public int CompareTo(LongLongInteger o)
        {
            return (Compare(this, o));
        }

        /// <summary>
        /// オブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトがoより小さいならば負の数、オブジェクトがoと等しいならば0、オブジェクトがoより大きいならば正の数です。
        /// </returns>
        public int CompareTo(UnsignedLongLongInteger o)
        {
            return (Compare(this, o));
        }

        #endregion

        #region Compare のオーバーロード

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
        public static int Compare(long x, RationalNumber y)
        {
            return (-Compare(y, x));
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
        public static int Compare(ulong x, RationalNumber y)
        {
            return (-Compare(y, x));
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
        public static int Compare(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (-Compare(y, x));
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
        public static int Compare(LongLongInteger x, RationalNumber y)
        {
            return (-Compare(y, x));
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
        public static int Compare(RationalNumber x, long y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    if (y == 0)
                        return (0);
                    else if (y > 0)
                        return (-1);
                    else
                        return (1);
                case SignType.Positive:
                    if (y > 0)
                        return (x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply((ulong)y)));
                    else
                        return (1);
                default:
                    if (y >= 0)
                        return (-1);
                    else if (y == long.MinValue)
                        return (x._InternalDenominator.Multiply(_nagated_long_min_value).CompareTo(x._InternalNumerator.Abs()));
                    else
                        return (x._InternalDenominator.Multiply((ulong)-y).CompareTo(x._InternalNumerator.Abs()));
            }
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
        public static int Compare(RationalNumber x, ulong y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    return (y == 0 ? 0 : -1);
                case SignType.Positive:
                    return (y == 0 ? 1 : x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply(y)));
                default:
                    return (-1);
            }
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
        public static int Compare(RationalNumber x, UnsignedLongLongInteger y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    return (y.IsZero ? 0 : -1);
                case SignType.Positive:
                    return (y.IsZero ? 1 : x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply(y)));
                default:
                    return (-1);
            }
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
        public static int Compare(RationalNumber x, LongLongInteger y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    if (y.InternalSign == SignType.Zero)
                        return (0);
                    else if (y.InternalSign == SignType.Positive)
                        return (-1);
                    else
                        return (1);
                case SignType.Positive:
                    if (y.InternalSign == SignType.Positive)
                        return (x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply(y.Abs())));
                    else
                        return (1);
                default:
                    if (y.InternalSign != SignType.Negative)
                        return (-1);
                    else
                        return (x._InternalDenominator.Multiply(y.Abs()).CompareTo(x._InternalNumerator.Abs()));
            }
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
        public static int Compare(RationalNumber x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    return ((int)x._InternalNumerator.InternalSign);
                case SignType.Positive:
                    return (x._InternalNumerator.InternalSign == SignType.Positive ? x._InternalNumerator.Abs().Multiply(y._InternalDenominator).CompareTo(y._InternalNumerator.Abs().Multiply(x._InternalDenominator)) : -1);
                default:
                    return (x._InternalNumerator.InternalSign == SignType.Negative ? y._InternalNumerator.Abs().Multiply(x._InternalDenominator).CompareTo(x._InternalNumerator.Abs().Multiply(y._InternalDenominator)) : 1);
            }
        }

        #endregion

        #endregion

        #region IComparable<RationalNumber> メンバ

        /// <summary>
        /// オブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトがoより小さいならば負の数、オブジェクトがoと等しいならば0、オブジェクトがoより大きいならば正の数です。
        /// </returns>
        public int CompareTo(RationalNumber o)
        {
            return (RationalNumber.Compare(this, o));
        }

        #endregion

        #region IComparable メンバ

        /// <summary>
        /// オブジェクトの論理的な大小関係を求めます。
        /// </summary>
        /// <param name="o">
        /// 比較対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// オブジェクトがoより小さいならば負の数、オブジェクトがoと等しいならば0、オブジェクトがoより大きいならば正の数です。
        /// </returns>
        public int CompareTo(object o)
        {
            if (o == null)
                return (1);
            else if (o is ulong)
                return (Compare(this, (ulong)o));
            else if (o is long)
                return (Compare(this, (long)o));
            else if (o is UnsignedLongLongInteger)
                return (Compare(this, (UnsignedLongLongInteger)o));
            else if (o is LongLongInteger)
                return (Compare(this, (LongLongInteger)o));
            else if (o is RationalNumber)
                return (Compare(this, (RationalNumber)o));
            else
                throw (new ArgumentException("RationalNumberオブジェクトとRationalNumber以外のオブジェクトを比較しようとしました。", "o"));
        }

        #endregion
    }
}
