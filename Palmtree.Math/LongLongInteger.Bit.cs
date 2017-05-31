/*
  LongLongInteger.Bit.cs

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
    {
        #region 演算子

#if !CONCEAL_OPERATORS

        #region ~ のオーバーロード

        /// <summary>
        /// 整数のビット毎の否定を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger operator ~(LongLongInteger x)
        {
            return (OnesComplement(x));
        }

        #endregion

        #region << のオーバーロード

        /// <summary>
        /// 整数を左シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger operator <<(LongLongInteger x, int n)
        {
            return (LeftShift(x, n));
        }

        #endregion

        #region >> のオーバーロード

        /// <summary>
        /// 整数を右シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger operator >>(LongLongInteger x, int n)
        {
            return (RightShift(x, n));
        }

        #endregion

        #region & のオーバーロード

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
        public static LongLongInteger operator &(long x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
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
        public static ulong operator &(ulong x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
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
        public static UnsignedLongLongInteger operator &(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
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
        public static LongLongInteger operator &(LongLongInteger x, long y)
        {
            return (BitwiseAnd(x, y));
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
        public static ulong operator &(LongLongInteger x, ulong y)
        {
            return (BitwiseAnd(x, y));
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
        public static UnsignedLongLongInteger operator &(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (BitwiseAnd(x, y));
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
        public static LongLongInteger operator &(LongLongInteger x, LongLongInteger y)
        {
            return (BitwiseAnd(x, y));
        }

        #endregion

        #region | のオーバーロード

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
        public static LongLongInteger operator |(long x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
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
        public static LongLongInteger operator |(ulong x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
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
        public static LongLongInteger operator |(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
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
        public static LongLongInteger operator |(LongLongInteger x, long y)
        {
            return (BitwiseOr(x, y));
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
        public static LongLongInteger operator |(LongLongInteger x, ulong y)
        {
            return (BitwiseOr(x, y));
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
        public static LongLongInteger operator |(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (BitwiseOr(x, y));
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
        public static LongLongInteger operator |(LongLongInteger x, LongLongInteger y)
        {
            return (BitwiseOr(x, y));
        }

        #endregion

        #region ^ のオーバーロード

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
        public static LongLongInteger operator ^(long x, LongLongInteger y)
        {
            return (Xor(y, x));
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
        public static LongLongInteger operator ^(ulong x, LongLongInteger y)
        {
            return (Xor(y, x));
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
        public static LongLongInteger operator ^(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Xor(y, x));
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
        public static LongLongInteger operator ^(LongLongInteger x, long y)
        {
            return (Xor(x, y));
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
        public static LongLongInteger operator ^(LongLongInteger x, ulong y)
        {
            return (Xor(x, y));
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
        public static LongLongInteger operator ^(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Xor(x, y));
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
        public static LongLongInteger operator ^(LongLongInteger x, LongLongInteger y)
        {
            return (Xor(x, y));
        }

        #endregion

#endif

        #endregion

        #region パブリックメソッド

        #region OnesComplement のオーバーロード

        // 公式: ~x == -x - 1 == -(x + 1)

        /// <summary>
        /// 与えられた整数のビット毎の否定を計算します。
        /// </summary>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger OnesComplement()
        {
            return (OnesComplement(this));
        }

        /// <summary>
        /// 整数のビット毎の否定を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger OnesComplement(UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                return (MinusOne);
            else
                return (x.Increment().Negate());
        }

        /// <summary>
        /// 整数のビット毎の否定を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger OnesComplement(LongLongInteger x)
        {
            if (x._sign == SignType.Zero)
                return (MinusOne);
            else if (x._sign == SignType.Positive)
                return (x._abs.Increment().Negate());
            else
                return (x._abs.Decrement().ToLongLongInteger());
        }

        #endregion

        #region LeftShift のオーバーロード

        /// <summary>
        /// 与えられた整数を左シフトします。
        /// </summary>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger LeftShift(int n)
        {
            return (LeftShift(this, n));
        }

        /// <summary>
        /// 整数を左シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger LeftShift(LongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("シフト回数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (x);
            if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.LeftShift(n)));
        }

        #endregion

        #region RightShift のオーバーロード

        /// <summary>
        /// 与えられた整数を右シフトします。
        /// </summary>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger RightShift(int n)
        {
            return (RightShift(this, n));
        }

        /// <summary>
        /// 整数を右シフトします。
        /// </summary>
        /// <param name="x">
        /// シフト対象の整数です。
        /// </param>
        /// <param name="n">
        /// シフトするビット数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public static LongLongInteger RightShift(LongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("シフト回数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (x);
            if (x._sign == SignType.Zero)
                return (Zero);
            else if (x._sign == SignType.Positive)
                return (x._abs.RightShift(n).ToLongLongInteger());
            else
                return (x._abs.Decrement().RightShift(n).Increment().Negate());
        }

        #endregion

        #region TruncateBit のオーバーロード

        /// <summary>
        /// 下位からnビット分を除いて全てのビットを0にした値を計算します。
        /// </summary>
        /// <param name="n">
        /// 保持するビットの数です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger TruncateBit(int n)
        {
            if (n < 0)
                throw (new ArgumentException("ビットの数は正または0でなくてはなりません。", "n"));
            if (n == 0)
                return (UnsignedLongLongInteger.Zero);
            else if (_sign == SignType.Zero)
                return (UnsignedLongLongInteger.Zero);
            else if (_sign == SignType.Positive)
                return (_abs.TruncateBit(n));
            else
                return (_abs.Negate(n));
        }

        #endregion

        #region TestBit のオーバーロード

        /// <summary>
        /// あるひとつのビットが1かどうかを調べます。
        /// これは (this &amp; (1 &lt;&lt; n)) != 0 と等価です。 
        /// </summary>
        /// <param name="pos">
        /// 調べるビットの位置です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public bool TestBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("ビットの位置は正または0でなくてはなりません。", "pos"));
            if (_sign == SignType.Zero)
                return (false);
            else if (_sign == SignType.Positive)
                return (_abs.TestBit(pos));
            else
                return (!_abs.Decrement().TestBit(pos));
        }

        #endregion

        #region SetBit のオーバーロード

        /// <summary>
        /// あるひとつのビットをセットした値を計算します。
        /// </summary>
        /// <param name="pos">
        /// セットするビットの位置です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger SetBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("ビットの位置は正または0でなくてはなりません。", "pos"));
            if (_sign == SignType.Zero)
                return (UnsignedLongLongInteger.One.LeftShift(pos).ToLongLongInteger());
            else if (_sign == SignType.Positive)
                return (_abs.SetBit(pos).ToLongLongInteger());
            else
                return (_abs.Decrement().ClearBit(pos).Increment().Negate());
        }

        #endregion

        #region ClearBit のオーバーロード

        /// <summary>
        /// あるひとつのビットをクリアした値を計算します。
        /// </summary>
        /// <param name="pos">
        /// クリアするビットの位置です。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger ClearBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("ビットの位置は正または0でなくてはなりません。", "pos"));
            if (_sign == SignType.Zero)
                return (Zero);
            else if (_sign == SignType.Positive)
                return (_abs.ClearBit(pos).ToLongLongInteger());
            else
                return (_abs.Decrement().SetBit(pos).Increment().Negate());
        }

        #endregion

        #region BitwiseAnd のオーバーロード

        // z = x & yにて、xとyのどちらかまたは両方が負の場合には以下のように変形する。
        //
        // 1) x < 0, y > 0のとき、
        // 公式 t == ~(-t - 1)より
        // z = ~(|x| - 1) & y
        //
        // 2) x < 0, y < 0のとき、
        // 公式 t == ~(-t - 1)より
        // ~(-z - 1) = ~(|x| - 1) & ~(|y| - 1)
        // (-z - 1) = (|x| - 1) | (|y| - 1)
        // z = -( (|x| - 1) | (|y| - 1) + 1 )

        /// <summary>
        /// 与えられた整数とのビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger BitwiseAnd(long x)
        {
            return (BitwiseAnd(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public ulong BitwiseAnd(ulong x)
        {
            return (BitwiseAnd(this, x));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public UnsignedLongLongInteger BitwiseAnd(UnsignedLongLongInteger x)
        {
            return (BitwiseAnd(this, x));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理積を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger BitwiseAnd(LongLongInteger x)
        {
            return (BitwiseAnd(this, x));
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
        public static LongLongInteger BitwiseAnd(long x, LongLongInteger y)
        {
            return (BitwiseAnd(y, new LongLongInteger(x)));
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
        public static ulong BitwiseAnd(ulong x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
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
        public static UnsignedLongLongInteger BitwiseAnd(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
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
        public static LongLongInteger BitwiseAnd(LongLongInteger x, long y)
        {
            return (BitwiseAnd(x, new LongLongInteger(y)));
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
        public static ulong BitwiseAnd(LongLongInteger x, ulong y)
        {
            if (x._sign == SignType.Zero || y == 0)
                return (0);
            if (x._sign == SignType.Positive)
                return (x._abs.BitwiseAnd(y));
            else
                return (y.BitwiseComplementAnd(x._abs.Decrement()));
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
        public static UnsignedLongLongInteger BitwiseAnd(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero || y.IsZero)
                return (UnsignedLongLongInteger.Zero);
            if (x._sign == SignType.Positive)
                return (x._abs.BitwiseAnd(y));
            else
                return (y.BitwiseComplementAnd(x._abs.Decrement()));
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
        public static LongLongInteger BitwiseAnd(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero || y._sign == SignType.Zero)
                return (Zero);
            if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (x._abs.BitwiseAnd(y._abs).ToLongLongInteger());
                else
                    return (x._abs.BitwiseComplementAnd(y._abs.Decrement()).ToLongLongInteger());
            }
            else
            {
                if (y._sign == SignType.Positive)
                    return (y._abs.BitwiseComplementAnd(x._abs.Decrement()).ToLongLongInteger());
                else
                    return (x._abs.Decrement().BitwiseOr(y._abs.Decrement()).Increment().Negate());
            }
        }

        #endregion

        #region BitwiseOr のオーバーロード

        // z = x | yにて、xとyのどちらかまたは両方が負の場合には以下のように変形する。
        //
        // 1) x < 0, y > 0のとき、
        // ~z = ~x | ~y
        // 公式 t == ~(-t - 1)より
        // z = -(((|x| - 1) & ~y) + 1)
        //
        // 2) x < 0, y < 0のとき、
        // 公式 t == ~(-t - 1)より
        // ~(-z - 1) = ~(|x| - 1) | ~(|y| - 1)
        // (-z - 1) = (|x| - 1) & (|y| - 1)
        // z = -( (|x| - 1) & (|y| - 1) + 1 )

        /// <summary>
        /// 与えられた整数とのビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger BitwiseOr(long x)
        {
            return (BitwiseOr(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger BitwiseOr(ulong x)
        {
            return (BitwiseOr(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger BitwiseOr(UnsignedLongLongInteger x)
        {
            return (BitwiseOr(this, x));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger BitwiseOr(LongLongInteger x)
        {
            return (BitwiseOr(this, x));
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
        public static LongLongInteger BitwiseOr(long x, LongLongInteger y)
        {
            return (BitwiseOr(y, new LongLongInteger(x)));
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
        public static LongLongInteger BitwiseOr(ulong x, LongLongInteger y)
        {
            return (BitwiseOr(y, new UnsignedLongLongInteger(x)));
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
        public static LongLongInteger BitwiseOr(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
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
        public static LongLongInteger BitwiseOr(LongLongInteger x, long y)
        {
            return (BitwiseOr(x, new LongLongInteger(y)));
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
        public static LongLongInteger BitwiseOr(LongLongInteger x, ulong y)
        {
            return (BitwiseOr(x, new UnsignedLongLongInteger(y)));
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
        public static LongLongInteger BitwiseOr(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y.ToLongLongInteger());
            if (y.IsZero)
                return (x);
            if (x._sign == SignType.Positive)
                return (x._abs.BitwiseOr(y).ToLongLongInteger());
            else
                return (x._abs.Decrement().BitwiseComplementAnd(y).Increment().Negate());
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
        public static LongLongInteger BitwiseOr(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y);
            if (y._sign == SignType.Zero)
                return (x);
            if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (x._abs.BitwiseOr(y._abs).ToLongLongInteger());
                else
                    return (y._abs.Decrement().BitwiseComplementAnd(x._abs).Increment().Negate());
            }
            else
            {
                if (y._sign == SignType.Positive)
                    return (x._abs.Decrement().BitwiseComplementAnd(y._abs).Increment().Negate());
                else
                    return (x._abs.Decrement().BitwiseAnd(y._abs.Decrement()).Increment().Negate());
            }
        }

        #endregion

        #region Xor のオーバーロード

        // z = (x & ~y) | (~x & y)にて、xとyのどちらかまたは両方が負の場合には以下のように変形する。
        //
        // 1) x < 0, y > 0のとき、
        // ~z = ~(x & ~y | (~x & y))
        // ~z = ~(x & ~y) & ~(~x & y)
        // ~z = (~x | y) & ~(~x & y)
        // 公式 t == ~(-t - 1)より
        // z = -((((|x| - 1) | y) & ~((|x| - 1) & y)) + 1)
        // 
        // 2) x < 0, y < 0のとき、
        // z = (x & ~y) | (~x & y)
        // 公式 t == ~(-t - 1)より
        // z = (~(|x| - 1) & (|y| - 1)) | ((|x| - 1) & ~(|y| - 1))

        /// <summary>
        /// 与えられた整数とのビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger Xor(long x)
        {
            return (Xor(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Xor(ulong x)
        {
            return (Xor(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger Xor(UnsignedLongLongInteger x)
        {
            return (Xor(this, x));
        }

        /// <summary>
        /// 与えられた整数とのビット毎の排他的論理和を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public LongLongInteger Xor(LongLongInteger x)
        {
            return (Xor(this, x));
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
        public static LongLongInteger Xor(long x, LongLongInteger y)
        {
            return (Xor(y, new LongLongInteger(x)));
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
        public static LongLongInteger Xor(ulong x, LongLongInteger y)
        {
            return (Xor(y, new UnsignedLongLongInteger(x)));
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
        public static LongLongInteger Xor(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Xor(y, x));
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
        public static LongLongInteger Xor(LongLongInteger x, long y)
        {
            return (Xor(x, new LongLongInteger(y)));
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
        public static LongLongInteger Xor(LongLongInteger x, ulong y)
        {
            return (Xor(x, new UnsignedLongLongInteger(y)));
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
        public static LongLongInteger Xor(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y.ToLongLongInteger());
            if (y.IsZero)
                return (x);
            if (x._sign == SignType.Positive)
                return (y.BitwiseComplementAnd(x._abs).BitwiseOr(x._abs.BitwiseComplementAnd(y)).ToLongLongInteger());
            else
            {
                UnsignedLongLongInteger x2 = x._abs.Decrement();
                return (x2.BitwiseOr(y).BitwiseComplementAnd(x2.BitwiseAnd(y)).Increment().Negate());
            }
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
        public static LongLongInteger Xor(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y);
            if (y._sign == SignType.Zero)
                return (x);
            if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (y._abs.BitwiseComplementAnd(x._abs).BitwiseOr(x._abs.BitwiseComplementAnd(y._abs)).ToLongLongInteger());
                else
                {
                    UnsignedLongLongInteger x2 = x._abs;
                    UnsignedLongLongInteger y2 = y._abs.Decrement();
                    return (x2.BitwiseOr(y2).BitwiseComplementAnd(x2.BitwiseAnd(y2)).Increment().Negate());
                }
            }
            else
            {
                if (y._sign == SignType.Positive)
                {
                    UnsignedLongLongInteger x2 = x._abs.Decrement();
                    UnsignedLongLongInteger y2 = y._abs;
                    return (x2.BitwiseOr(y2).BitwiseComplementAnd(x2.BitwiseAnd(y2)).Increment().Negate());
                }
                else
                {
                    UnsignedLongLongInteger x2 = x._abs.Decrement();
                    UnsignedLongLongInteger y2 = y._abs.Decrement();
                    return (y2.BitwiseComplementAnd(x2).BitwiseOr(x2.BitwiseComplementAnd(y2)).ToLongLongInteger());
                }
            }
        }

        #endregion

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// オブジェクトをビット配列として見た場合の配列の長さです。
        /// </summary>
        /// <remarks>
        /// このプロパティの値は以下の定義により求められます。
        /// thisが正または0の場合: this + 1 &lt;= (1 &lt;&lt; n) である最小のn
        /// thisが負の場合: -this &lt;= (1 &lt;&lt; n) である最小のn
        /// </remarks>
        public int BitLength
        {
            get
            {
                if (!_bit_length_cache.HasValue)
                    _bit_length_cache = GetBitLength();
                return (_bit_length_cache.Value);
            }
        }

        /// <summary>
        /// オブジェクトが2のべき乗であるならばtrue、そうではないのならfalseです。
        /// </summary>
        public bool IsPowerOfTwo
        {
            get
            {
                if (!_is_power_of_two_cache.HasValue)
                    _is_power_of_two_cache = GetIsPowerOfTwo();
                return (_is_power_of_two_cache.Value);
            }
        }

        #endregion

        #region プライベートメソッド

        private int GetBitLength()
        {
            if (_sign == SignType.Positive)
                return (_abs.BitLength);
            else if (_sign == SignType.Zero)
                return (0);
            else
                return (_abs.Decrement().BitLength);
        }

        private bool GetIsPowerOfTwo()
        {
            return (_sign == SignType.Positive && _abs.IsPowerOfTwo);
        }

        #endregion
    }
}
