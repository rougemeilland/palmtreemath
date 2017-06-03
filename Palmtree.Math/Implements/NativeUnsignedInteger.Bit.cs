/*
  NativeUnsignedInteger.Bit.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math.Implements
{
    partial class NativeUnsignedInteger
    {
        #region パブリックメソッド

        public UInt32 BitwiseAnd(UInt32 x)
        {
        }

        public UInt64 BitwiseAnd(UInt64 x)
        {
        }

        public NativeUnsignedInteger BitwiseAnd(NativeUnsignedInteger x)
        {
        }

        public NativeUnsignedInteger BitwiseOr(UInt32 x)
        {
        }

        public NativeUnsignedInteger BitwiseOr(UInt64 x)
        {
        }

        public NativeUnsignedInteger BitwiseOr(NativeUnsignedInteger x)
        {
        }

        public NativeUnsignedInteger Xor(UInt32 x)
        {
        }

        public NativeUnsignedInteger Xor(UInt64 x)
        {
        }

        public NativeUnsignedInteger Xor(NativeUnsignedInteger x)
        {
        }

        /// <summary>
        /// 与えられた整数の否定との論理積(this &amp; ~x)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public NativeUnsignedInteger BitwiseComplementAnd(uint x)
        {

        }

        /// <summary>
        /// 与えられた整数の否定との論理積(this &amp; ~x)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public NativeUnsignedInteger BitwiseComplementAnd(ulong x)
        {

        }

        /// <summary>
        /// 与えられた整数の否定との論理積(this &amp; ~x)を計算します。
        /// </summary>
        /// <param name="x">
        /// 計算対象のオブジェクトです。
        /// </param>
        /// <returns>
        /// 計算結果のオブジェクトです。
        /// </returns>
        public NativeUnsignedInteger BitwiseComplementAnd(NativeUnsignedInteger x)
        {

        }

        /// <summary>
        /// 与えられた整数の否定との論理積(x &amp; ~y)を計算します。
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
        public static uint BitwiseComplementAnd(uint x, NativeUnsignedInteger y)
        {

        }

        /// <summary>
        /// 与えられた整数の否定との論理積(x &amp; ~y)を計算します。
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
        public static ulong BitwiseComplementAnd(ulong x, NativeUnsignedInteger y)
        {

        }

        public NativeUnsignedInteger OnesComplement(int n)
        {
        }

        public NativeUnsignedInteger Negate(int n)
        {
        }

        public NativeUnsignedInteger Truncate(int n)
        {
        }

        public NativeUnsignedInteger LeftShift(int n)
        {
        }

        public NativeUnsignedInteger LeftShift1Quick()
        {
        }

        public NativeUnsignedInteger RightShift(int n)
        {
        }

        public NativeUnsignedInteger RightShift1Quick()
        {
        }

        public NativeUnsignedInteger SetBit(int pos)
        {
        }

        public NativeUnsignedInteger ClearBit(int pos)
        {
        }

        public bool TestBit(int pos)
        {
        }

        public int GetBitLength()
        {
        }

        public bool GetIsPowerOfTwo()
        {
        }

        public NativeUnsignedInteger ComplementAnd(UInt32 x)
        {
        }

        public NativeUnsignedInteger ComplementAnd(UInt64 x)
        {
        }

        public NativeUnsignedInteger ComplementAnd(NativeUnsignedInteger x)
        {
        }

        #endregion
    }
}