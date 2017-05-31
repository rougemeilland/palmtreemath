/*
  UnsignedLongLongInteger.Arithmetic.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Diagnostics;

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
            return (Increment(x));
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
            return (Decrement(x));
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
        public static UnsignedLongLongInteger operator +(ulong x, UnsignedLongLongInteger y)
        {
            return (Add(y, x));
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
            return (Add(x, y));
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
            return (Add(x, y));
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
        public static UnsignedLongLongInteger operator -(ulong x, UnsignedLongLongInteger y)
        {
            return (Subtract(x, y));
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
            return (Subtract(x, y));
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
            return (Subtract(x, y));
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
        public static UnsignedLongLongInteger operator *(ulong x, UnsignedLongLongInteger y)
        {
            return (Multiply(y, x));
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
            return (Multiply(x, y));
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
            return (Multiply(x, y));
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
        public static ulong operator /(ulong x, UnsignedLongLongInteger y)
        {
            return (Divide(x, y));
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
            return (Divide(x, y));
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
            return (Divide(x, y));
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
        public static ulong operator %(ulong x, UnsignedLongLongInteger y)
        {
            return (Mod(x, y));
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
            return (Mod(x, y));
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
            return (Mod(x, y));
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
        public UnsignedLongLongInteger Add(ulong x)
        {
            return (Add(this, x));
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
            return (Add(this, x));
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
            return (Add(y, x));
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
            if (x._InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(y));
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.Add(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.Add(x._InternalValue, CreateInternalValue(y))));
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
            if (x._InternalValue.Length == 0)
                return (y);
            else if (y._InternalValue.Length == 0)
                return (x);
            else
                return (new UnsignedLongLongInteger(_imp.Add(x._InternalValue, y._InternalValue)));
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
        public UnsignedLongLongInteger Subtract(ulong x)
        {
            return (Subtract(this, x));
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
            return (Subtract(this, x));
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
        public static UnsignedLongLongInteger Subtract(ulong x, UnsignedLongLongInteger y)
        {
            if (x == 0)
            {
                if (y._InternalValue.Length != 0)
                    throw (new OverflowException(@"減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
                return (Zero);
            }
            else if (y._InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(x));
            else if (x <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.Subtract((ushort)x, y._InternalValue)));
            else
                return (new UnsignedLongLongInteger(_imp.Subtract(CreateInternalValue(x), y._InternalValue)));
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
            if (x._InternalValue.Length == 0)
            {
                if (y == 0)
                    return (Zero);
                else
                    throw (new OverflowException(@"減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
            }
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.Subtract(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.Subtract(x._InternalValue, CreateInternalValue(y))));
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
            if (x._InternalValue.Length == 0)
            {
                if (y._InternalValue.Length == 0)
                    return (Zero);
                else
                    throw (new OverflowException(@"減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
            }
            else if (y._InternalValue.Length == 0)
                return (x);
            else
                return (new UnsignedLongLongInteger(_imp.Subtract(x._InternalValue, y._InternalValue)));
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
            return (Increment(this));
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
            if (x._InternalValue.Length == 0)
                return (UnsignedLongLongInteger.One);
            else
                return (new UnsignedLongLongInteger(_imp.Increment(x._InternalValue)));
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
            return (Decrement(this));
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
            if (x._InternalValue.Length == 0)
                throw (new OverflowException(@"減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
            else
                return (new UnsignedLongLongInteger(_imp.Decrement(x._InternalValue)));
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
        public UnsignedLongLongInteger Multiply(ulong x)
        {
            return (Multiply(this, x));
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
            return (Multiply(this, x));
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
            return (Multiply(y, x));
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
            if (x._InternalValue.Length == 0 || y == 0)
                return (Zero);
            else if (x._InternalValue.Length == 1)
            {
                if (x._InternalValue[0] == 1)
                    return (new UnsignedLongLongInteger(y));
                else
                {
                    if (y == 1)
                        return (x);
                    else if (y <= ushort.MaxValue)
                        return (new UnsignedLongLongInteger(_imp.Multiply(x._InternalValue[0], (ushort)y)));
                    else
                        return (new UnsignedLongLongInteger(_imp.Multiply(CreateInternalValue(y), x._InternalValue[0])));
                }
            }
            else
            {
                if (y == 1)
                    return (x);
                else if (y <= ushort.MaxValue)
                    return (new UnsignedLongLongInteger(_imp.Multiply(x._InternalValue, (ushort)y)));
                else
                    return (new UnsignedLongLongInteger(_imp.Multiply(x._InternalValue, CreateInternalValue(y))));
            }
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
            if (x._InternalValue.Length == 0 || y._InternalValue.Length == 0)
                return (Zero);
            else if (x._InternalValue.Length == 1)
            {
                if (x._InternalValue[0] == 1)
                    return (y);
                else
                {
                    if (y._InternalValue.Length == 1)
                    {
                        if (y._InternalValue[0] == 1)
                            return (x);
                        else
                            return (new UnsignedLongLongInteger(_imp.Multiply(x._InternalValue[0], y._InternalValue[0])));
                    }
                    else
                        return (new UnsignedLongLongInteger(_imp.Multiply(y._InternalValue, x._InternalValue[0])));
                }
            }
            else
            {
                if (y._InternalValue.Length == 1)
                {
                    if (y._InternalValue[0] == 1)
                        return (x);
                    else
                        return (new UnsignedLongLongInteger(_imp.Multiply(x._InternalValue, y._InternalValue[0])));
                }
                else
                    return (new UnsignedLongLongInteger(_imp.Multiply(x._InternalValue, y._InternalValue)));
            }
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
        public UnsignedLongLongInteger Divide(ulong x)
        {
            return (Divide(this, x));
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
            return (Divide(this, x));
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x == 0)
                return (0);
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                    return (x);
                else
                {
                    ushort r;
                    return (_imp.DivideRem(x, y._InternalValue[0], out r));
                }
            }
            else if (y._InternalValue.Length <= 4)
            {
                ulong r;
                return (_imp.DivideRem(x, ToULong(y._InternalValue), out r));
            }
            else
                return (0);
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
            if (y == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y == 1)
                return (x);
            else if (y <= ushort.MaxValue)
            {
                ushort r;
                return (new UnsignedLongLongInteger(_imp.DivideRem(x._InternalValue, (ushort)y, out r)));
            }
            else
            {
                ushort[] r;
                return (new UnsignedLongLongInteger(_imp.DivideRem(x._InternalValue, CreateInternalValue(y), out r)));
            }
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                    return (x);
                else
                {
                    ushort r;
                    return (new UnsignedLongLongInteger(_imp.DivideRem(x._InternalValue, y._InternalValue[0], out r)));
                }
            }
            else
            {
                ushort[] r;
                return (new UnsignedLongLongInteger(_imp.DivideRem(x._InternalValue, y._InternalValue, out r)));
            }
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
        public UnsignedLongLongInteger DivideExactly(ulong x)
        {
            return (DivideExactly(this, x));
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
            return (DivideExactly(this, x));
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x == 0)
                return (0);
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                    return (x);
                else
                {
                    ushort r;
                    ulong q = _imp.DivideRem(x, y._InternalValue[0], out r);
                    if (r != 0)
                        throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
                    return (q);
                }
            }
            else if (y._InternalValue.Length <= 4)
            {
                ulong r;
                ulong q = _imp.DivideRem(x, ToULong(y._InternalValue), out r);
                if (r != 0)
                    throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
                return (q);
            }
            else
                throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
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
            if (y == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y == 1)
                return (x);
            else if (y <= ushort.MaxValue)
            {
                ushort r;
                ushort[] q = _imp.DivideRem(x._InternalValue, (ushort)y, out r);
                if (r != 0)
                    throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
                return (new UnsignedLongLongInteger(q));
            }
            else
            {
                ushort[] r;
                ushort[] q = _imp.DivideRem(x._InternalValue, CreateInternalValue(y), out r);
                if (r.Length != 0)
                    throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
                return (new UnsignedLongLongInteger(q));
            }
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                    return (x);
                else
                {
                    ushort r;
                    ushort[] q = _imp.DivideRem(x._InternalValue, y._InternalValue[0], out r);
                    if (r != 0)
                        throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
                    return (new UnsignedLongLongInteger(q));
                }
            }
            else
            {
                ushort[] r;
                ushort[] q = _imp.DivideRem(x._InternalValue, y._InternalValue, out r);
                if (r.Length != 0)
                    throw (new ArgumentException("被除数は除数の倍数でなければなりません。"));
                return (new UnsignedLongLongInteger(q));
            }
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
        public ulong Mod(ulong x)
        {
            return (Mod(this, x));
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
            return (Mod(this, x));
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x == 0)
                return (0);
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                    return (0);
                else
                {
                    ushort r;
                    _imp.DivideRem(x, y._InternalValue[0], out r);
                    return (r);
                }
            }
            else if (y._InternalValue.Length <= 4)
            {
                ulong r;
                _imp.DivideRem(x, ToULong(y._InternalValue), out r);
                return (r);
            }
            else
                return (x);
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
            if (y == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
                return (0);
            else if (y == 1)
                return (0);
            else if (y <= ushort.MaxValue)
            {
                ushort r;
                _imp.DivideRem(x._InternalValue, (ushort)y, out r);
                return (r);
            }
            else
            {
                ushort[] r;
                _imp.DivideRem(x._InternalValue, CreateInternalValue(y), out r);
                Debug.Assert(r.Length <= 4);
                return (ToULong(r));
            }
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                    return (Zero);
                else
                {
                    ushort r;
                    _imp.DivideRem(x._InternalValue, y._InternalValue[0], out r);
                    return (new UnsignedLongLongInteger(r));
                }
            }
            else
            {
                ushort[] r;
                _imp.DivideRem(x._InternalValue, y._InternalValue, out r);
                return (new UnsignedLongLongInteger(r));
            }
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
        public UnsignedLongLongInteger DivRem(ulong x, out ulong r)
        {
            return (DivRem(this, x, out r));
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
            return (DivRem(this, x, out r));
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
            if (y == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
            {
                r = 0;
                return (Zero);
            }
            else if (y == 1)
            {
                r = 0;
                return (x);
            }
            else if (y <= ushort.MaxValue)
            {
                ushort r2;
                ushort[] q2 = _imp.DivideRem(x._InternalValue, (ushort)y, out r2);
                r = r2;
                return (new UnsignedLongLongInteger(q2));
            }
            else
            {
                ushort[] r2;
                ushort[] q2 = _imp.DivideRem(x._InternalValue, CreateInternalValue(y), out r2);
                Debug.Assert(r2.Length <= 4);
                r = ToULong(r2);
                return (new UnsignedLongLongInteger(q2));
            }
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x == 0)
            {
                r = x;
                return (0);
            }
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                {
                    r = 0;
                    return (x);
                }
                else
                {
                    ushort r2;
                    ulong q2 = _imp.DivideRem(x, y._InternalValue[0], out r2);
                    r = r2;
                    return (q2);
                }
            }
            else if (y._InternalValue.Length <= 4)
            {
                ulong r2;
                ulong q2 = _imp.DivideRem(x, ToULong(y._InternalValue), out r2);
                r = r2;
                return (q2);
            }
            else
            {
                r = x;
                return (0);
            }
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
            if (y._InternalValue.Length == 0)
                throw (new DivideByZeroException("0による除算が行われようとしました。"));
            else if (x._InternalValue.Length == 0)
            {
                r = x;
                return (Zero);
            }
            else if (y._InternalValue.Length == 1)
            {
                if (y._InternalValue[0] == 1)
                {
                    r = Zero;
                    return (x);
                }
                else
                {
                    ushort r2;
                    ushort[] q2 = _imp.DivideRem(x._InternalValue, y._InternalValue[0], out r2);
                    r = new UnsignedLongLongInteger(r2);
                    return (new UnsignedLongLongInteger(q2));
                }
            }
            else
            {
                ushort[] r2;
                ushort[] q2 = _imp.DivideRem(x._InternalValue, y._InternalValue, out r2);
                r = new UnsignedLongLongInteger(r2);
                return (new UnsignedLongLongInteger(q2));
            }
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
        public UnsignedLongLongInteger Power(ulong exp)
        {
            return (Power(this, exp));
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
            return (Power(this, exp));
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
            return (Power(new UnsignedLongLongInteger(x), exp));
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
            if (x._InternalValue.Length == 0)
            {
                if (exp == 0)
                    return (One);
                else
                    return (Zero);
            }
            else if (x._InternalValue.Length == 1)
            {
                if (x._InternalValue[0] == 1)
                    return (One);
                else
                {
                    if (exp == 0)
                        return (One);
                    else if (exp == 1)
                        return (x);
                    else
                        return (PowerImp(x, exp));
                }
            }
            else
            {
                if (exp == 0)
                    return (One);
                else if (exp == 1)
                    return (x);
                else
                    return (PowerImp(x, exp));
            }
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
            if (x._InternalValue.Length == 0)
            {
                if (exp._InternalValue.Length == 0)
                    return (One);
                else
                    return (Zero);
            }
            else if (x._InternalValue.Length == 1)
            {
                if (x._InternalValue[0] == 1)
                    return (One);
                else
                {
                    if (exp._InternalValue.Length == 0)
                        return (One);
                    else if (exp._InternalValue.Length == 1)
                    {
                        if (exp._InternalValue[0] == 1)
                            return (x);
                        else
                            return (PowerImp(x, exp));
                    }
                    else
                        return (PowerImp(x, exp));
                }
            }
            else
            {
                if (exp._InternalValue.Length == 0)
                    return (One);
                else if (exp._InternalValue.Length == 1)
                {
                    if (exp._InternalValue[0] == 1)
                        return (x);
                    else
                        return (PowerImp(x, exp));
                }
                else
                    return (PowerImp(x, exp));
            }
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
        public UnsignedLongLongInteger GreatestCommonDivisor(ulong x)
        {
            return (GreatestCommonDivisor(this, x));
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
            return (UnsignedLongLongInteger.GreatestCommonDivisor(this, x));
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
            return (GreatestCommonDivisor(y, x));
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
            if (x._InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(y));
            else if (y == 0)
                return (x);
            else if (x._InternalValue.Length == 1)
            {
                if (x._InternalValue[0] == 1)
                    return (One);
                else
                {
                    if (y == 1)
                        return (One);
                    else
                        return (GreatestCommonDivisor(x, new UnsignedLongLongInteger(y)));
                }
            }
            else
            {
                if (y == 1)
                    return (One);
                else
                    return (GreatestCommonDivisor(x, new UnsignedLongLongInteger(y)));
            }
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
            if (x._InternalValue.Length == 0)
                return (y);
            if (y._InternalValue.Length == 0)
                return (x);
            else if (x._InternalValue.Length == 1)
            {
                if (x._InternalValue[0] == 1)
                    return (One);
                else
                {
                    if (y._InternalValue.Length == 1)
                    {
                        if (y._InternalValue[0] == 1)
                            return (One);
                        else
                            return (GreatestCommonDivisorImp(x, y));
                    }
                    else
                        return (GreatestCommonDivisorImp(x, y));
                }
            }
            else
            {
                if (y._InternalValue.Length == 1)
                {
                    if (y._InternalValue[0] == 1)
                        return (One);
                    else
                        return (GreatestCommonDivisorImp(x, y));
                }
                else
                    return (GreatestCommonDivisorImp(x, y));
            }
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
        public UnsignedLongLongInteger Max(ulong x)
        {
            return (Max(this, x));
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
            return (Max(this, x));
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
            return (Max(y, x));
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
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new UnsignedLongLongInteger(y));
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
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (y);
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
        public ulong Min(ulong x)
        {
            return (Min(this, x));
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
            return (Min(this, x));
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
            return (Min(y, x));
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
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x.ToULong(typeof(ulong)));
            else
                return (y);
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
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (y);
        }

        #endregion

        #endregion

        #region プライベートメソッド

        private static UnsignedLongLongInteger PowerImp(UnsignedLongLongInteger x, ulong exp)
        {
            UnsignedLongLongInteger v = UnsignedLongLongInteger.One;
            int k = 63;
            Debug.Assert(sizeof(ulong) == 8);
            ulong mask = (1UL << k);
            while (k >= 0 && (exp & mask) == 0)
            {
                mask >>= 1;
                --k;
            }
            Debug.Assert(k >= 0);
            while (k >= 0)
            {
                v = UnsignedLongLongInteger.Multiply(v, v);
                if ((exp & mask) != 0)
                    v = UnsignedLongLongInteger.Multiply(v, x);
                mask >>= 1;
                --k;
            }
            return (v);
        }

        private static UnsignedLongLongInteger PowerImp(UnsignedLongLongInteger x, UnsignedLongLongInteger exp)
        {
            UnsignedLongLongInteger v = UnsignedLongLongInteger.One;
            int k = exp.BitLength - 1;
            Debug.Assert(k >= 0);
            while (k >= 0)
            {
                v = UnsignedLongLongInteger.Multiply(v, v);
                if (exp.TestBit(k))
                    v = UnsignedLongLongInteger.Multiply(v, x);
                --k;
            }
            return (v);
        }

        private static UnsignedLongLongInteger GreatestCommonDivisorImp(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            Debug.Assert(x._InternalValue.Length != 0 && y._InternalValue.Length != 0 && !(x._InternalValue.Length == 1 && x._InternalValue[0] == 1) && !(y._InternalValue.Length == 1 && y._InternalValue[0] == 1));
            int k = 0;
            while (x.IsEven && y.IsEven)
            {
                x = x.RightShift(1);
                y = y.RightShift(1);
                ++k;
            }
            Debug.Assert(x._InternalValue.Length != 0 && y._InternalValue.Length != 0);
            if (y.IsEven)
            {
                UnsignedLongLongInteger t = x;
                x = y.RightShift(1);
                y = t;
            }
            Debug.Assert(x._InternalValue.Length != 0 && y._InternalValue.Length != 0);
            Debug.Assert(!y.IsEven);
            while (true)
            {
                Debug.Assert(x._InternalValue.Length != 0 && y._InternalValue.Length != 0);
                while (x.IsEven)
                    x = x.RightShift(1);
                Debug.Assert(!x.IsEven && !y.IsEven);
                if (x.CompareTo(y) < 0)
                {
                    UnsignedLongLongInteger t = x;
                    x = y;
                    y = t;
                }
                x = x.Subtract(y);
                if (x._InternalValue.Length == 0)
                    return (y.LeftShift(k));
                Debug.Assert(x.IsEven && !y.IsEven);
                x = x.RightShift(1);
            }
        }

        #endregion


    }
}
