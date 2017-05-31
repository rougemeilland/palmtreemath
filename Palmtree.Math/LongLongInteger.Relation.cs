/*
  LongLongInteger.Relation.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// 演算子のオーバーロードに関するガイドライン:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct LongLongInteger
        : IComparable, IComparable<LongLongInteger>
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
        public static bool operator <(long x, LongLongInteger y)
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
        public static bool operator <(ulong x, LongLongInteger y)
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
        public static bool operator <(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator <(LongLongInteger x, long y)
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
        public static bool operator <(LongLongInteger x, ulong y)
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
        public static bool operator <(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator <(LongLongInteger x, LongLongInteger y)
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
        public static bool operator <=(long x, LongLongInteger y)
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
        public static bool operator <=(ulong x, LongLongInteger y)
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
        public static bool operator <=(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator <=(LongLongInteger x, long y)
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
        public static bool operator <=(LongLongInteger x, ulong y)
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
        public static bool operator <=(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator <=(LongLongInteger x, LongLongInteger y)
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
        public static bool operator >(long x, LongLongInteger y)
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
        public static bool operator >(ulong x, LongLongInteger y)
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
        public static bool operator >(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator >(LongLongInteger x, long y)
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
        public static bool operator >(LongLongInteger x, ulong y)
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
        public static bool operator >(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator >(LongLongInteger x, LongLongInteger y)
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
        public static bool operator >=(long x, LongLongInteger y)
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
        public static bool operator >=(ulong x, LongLongInteger y)
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
        public static bool operator >=(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator >=(LongLongInteger x, long y)
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
        public static bool operator >=(LongLongInteger x, ulong y)
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
        public static bool operator >=(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator >=(LongLongInteger x, LongLongInteger y)
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
            return (Compare(this, new UnsignedLongLongInteger(o)));
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
        public static int Compare(long x, LongLongInteger y)
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
        public static int Compare(ulong x, LongLongInteger y)
        {
            return (-Compare(y, new UnsignedLongLongInteger(x)));
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
        public static int Compare(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static int Compare(LongLongInteger x, long y)
        {
            if (x._sign == SignType.Zero)
            {
                if (y > 0)
                    return (-1);
                else if (y == 0)
                    return (0);
                else
                    return (1);
            }
            else if (y == 0)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
            {
                if (y > 0)
                    return (UnsignedLongLongInteger.Compare(x._abs, (ulong)y));
                else
                    return (1);
            }
            else
            {
                if (y > 0)
                    return (-1);
                else if (y == long.MinValue)
                    return (UnsignedLongLongInteger.Compare(_nagated_long_min_value, x._abs));
                else
                    return (UnsignedLongLongInteger.Compare((ulong)-y, x._abs));
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
        public static int Compare(LongLongInteger x, ulong y)
        {
            if (x._sign == SignType.Zero)
                return (y == 0 ? 0 : -1);
            else if (y == 0)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
                return (UnsignedLongLongInteger.Compare(x._abs, y));
            else
                return (-1);
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
        public static int Compare(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y.IsZero ? 0 : -1);
            else if (y.IsZero)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
                return (UnsignedLongLongInteger.Compare(x._abs, y));
            else
                return (-1);
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
        public static int Compare(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (-(int)y._sign);
            else if (y._sign == SignType.Zero)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (UnsignedLongLongInteger.Compare(x._abs, y._abs));
                else
                    return (1);
            }
            else
            {
                if (y._sign == SignType.Positive)
                    return (-1);
                else
                    return (UnsignedLongLongInteger.Compare(y._abs, x._abs));
            }
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
            else if (o is long)
                return (Compare(this, (long)o));
            else if (o is UnsignedLongLongInteger)
                return (Compare(this, (UnsignedLongLongInteger)o));
            else if (o is LongLongInteger)
                return (Compare(this, (LongLongInteger)o));
            else
                throw (new ArgumentException("LongLongIntegerオブジェクトと比較できないオブジェクトが与えられました。", "o"));
        }

        #endregion

        #region IComparable<LongLongInteger> メンバ

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

        #endregion
    }
}
