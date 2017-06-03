/*
  UnsignedLongLongInteger.Relation.cs

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
        : IComparable, IComparable<UnsignedLongLongInteger>
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
        [CLSCompliant(false)]
        public static bool operator <(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) > 0);
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
        public static bool operator <(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) > 0);
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
        public static bool operator <(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.CompareTo(y) < 0);
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
        public static bool operator <(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.CompareTo(y) < 0);
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
        public static bool operator <(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.CompareTo(y._native_value) < 0);
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
        [CLSCompliant(false)]
        public static bool operator <=(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) >= 0);
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
        public static bool operator <=(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) >= 0);
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
        public static bool operator <=(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.CompareTo(y) <= 0);
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
        public static bool operator <=(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.CompareTo(y) <= 0);
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
        public static bool operator <=(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.CompareTo(y._native_value) <= 0);
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
        [CLSCompliant(false)]
        public static bool operator >(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) < 0);
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
        public static bool operator >(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) < 0);
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
        public static bool operator >(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.CompareTo(y) > 0);
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
        public static bool operator >(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.CompareTo(y) > 0);
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
        public static bool operator >(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.CompareTo(y._native_value) > 0);
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
        [CLSCompliant(false)]
        public static bool operator >=(uint x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) <= 0);
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
        public static bool operator >=(ulong x, UnsignedLongLongInteger y)
        {
            return (y._native_value.CompareTo(x) <= 0);
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
        public static bool operator >=(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.CompareTo(y) >= 0);
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
        public static bool operator >=(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.CompareTo(y) >= 0);
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
        public static bool operator >=(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.CompareTo(y._native_value) >= 0);
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
        [CLSCompliant(false)]
        public int CompareTo(uint o)
        {
            return (_native_value.CompareTo(o));
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
            return (_native_value.CompareTo(o));
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
        [CLSCompliant(false)]
        public static int Compare(UnsignedLongLongInteger x, uint y)
        {
            return (x._native_value.CompareTo(y));
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
        public static int Compare(UnsignedLongLongInteger x, ulong y)
        {
            return (x._native_value.CompareTo(y));
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
        public static int Compare(uint x, UnsignedLongLongInteger y)
        {
            return (-y._native_value.CompareTo(x));
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
        public static int Compare(ulong x, UnsignedLongLongInteger y)
        {
            return (-y._native_value.CompareTo(x));
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
        public static int Compare(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (x._native_value.CompareTo(y._native_value));
        }

        #endregion

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
            else if (o is UnsignedLongLongInteger)
                return (Compare(this, (UnsignedLongLongInteger)o));
            else
                throw (new ArgumentException("UnsignedLongLongIntegerオブジェクトと比較できないオブジェクトが与えられました。", "o"));
        }

        #endregion

        #region IComparable<UnsignedLongLongInteger> メンバ

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
    }
}