/*
  NativeUnsignedIntegerExtensions.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Implements
{
    internal static class NativeUnsignedIntegerExtensions
    {
        #region パブリックメソッド

        /// <summary>
        /// ある整数と、もうひとつの整数の否定の論理積(x &amp; ~y)を計算します。
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
        public static uint BitwiseComplementAnd(this uint x, NativeUnsignedInteger y)
        {
            return (NativeUnsignedInteger.BitwiseComplementAnd(x, y));
        }

        /// <summary>
        /// ある整数と、もうひとつの整数の否定の論理積(x &amp; ~y)を計算します。
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
        public static ulong BitwiseComplementAnd(this ulong x, NativeUnsignedInteger y)
        {
            return (NativeUnsignedInteger.BitwiseComplementAnd(x, y));
        }

        public static uint Subtract(this uint x, NativeUnsignedInteger y)
        {
            return (NativeUnsignedInteger.Subtract(x, y));
        }

        public static ulong Subtract(this ulong x, NativeUnsignedInteger y)
        {
            return (NativeUnsignedInteger.Subtract(x, y));
        }

        public static uint DivRem(this uint x, NativeUnsignedInteger y, out uint r)
        {
            return (NativeUnsignedInteger.DivRem(x, y, out r));
        }

        public static ulong DivRem(this ulong x, NativeUnsignedInteger y, out ulong r)
        {
            return (NativeUnsignedInteger.DivRem(x, y, out r));
        }

        public static NativeUnsignedInteger Power(this uint x, NativeUnsignedInteger y)
        {
            return (new NativeUnsignedInteger(x).Power(y));
        }

        public static NativeUnsignedInteger Power(this ulong x, NativeUnsignedInteger y)
        {
            return (new NativeUnsignedInteger(x).Power(y));
        }

        #endregion
    }
}