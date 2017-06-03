/*
  NativeUnsignedInteger.NativeMethods.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Runtime.InteropServices;

namespace Palmtree.Math.Implements
{
    partial class NativeUnsignedInteger
    {
        #region ネイティブメソッドの宣言

        #region Windows API

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);

        #endregion

        #region ネイティブコードの初期化

        /// <summary>
        /// ネイティブコードの初期化を行います。
        /// この関数はほかの関数より先に一度だけ呼ばれる必要があります。
        /// </summary>
        /// <returns>
        /// 初期化に成功した場合はtrue、そうでない場合はfalseです。
        /// falseが返った場合、PMN_Initialize関数も含めてどのネイティブ関数を呼び出してはいけません。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_Initialize();

        #endregion

        #region メモリ管理

        /// <summary>
        /// 多倍長整数を格納する領域を獲得します。
        /// </summary>
        /// <param name="size">
        /// 多倍長整数を格納する領域のサイズをバイト単位で指定します。
        /// </param>
        /// <returns>
        /// 獲得された領域の識別子です。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern IntPtr PMN_AllocateBuffer(UInt64 size);

        /// <summary>
        /// PMN_AllocateBuffer関数で獲得された領域を解放します。
        /// </summary>
        /// <param name="buffer">
        /// PMN_AllocateBuffer関数が返した識別子です。
        /// </param>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern void PMN_FreeBuffer(IntPtr buffer);

        #endregion

        #region 単純な属性の取得

        /// <summary>
        /// 与えられた32ビット整数の有効ビット長を調べます。
        /// </summary>
        /// <param name="value">
        /// 32ビット整数です。
        /// </param>
        /// <returns>
        /// 与えられた32ビット整数の有効ビット長です。
        /// 0が与えられた場合は0を返します。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern UInt64 PMN_GetUInt32EffectiveBitCount(UInt32 value);

        /// <summary>
        /// 与えられた64ビット整数の有効ビット長を調べます。
        /// </summary>
        /// <param name="value">
        /// 64ビット整数です。
        /// </param>
        /// <returns>
        /// 与えられた64ビット整数の有効ビット長です。
        /// 0が与えられた場合は0を返します。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern UInt64 PMN_GetUInt64EffectiveBitCount(UInt64 value);

        /// <summary>
        /// 与えられた多倍長整数について、いくつかの情報を調べます。
        /// </summary>
        /// <param name="buffer">
        /// 調べる対象の多倍長整数です。
        /// </param>
        /// <param name="bit_count">
        /// 多倍長整数の有効ビット長です。
        /// </param>
        /// <param name="hash_code">
        /// 多倍長整数のハッシュコードです。
        /// </param>
        /// <param name="flags">
        /// 各ビットは以下を意味します。
        /// 0: 多倍長整数が1ならばON、それ以外ならOFF。
        /// 1: 多倍長整数が偶数ならばON、それ以外ならOFF。
        /// 2: 多倍長整数が2のべき乗であればON、それ以外ならOFF。
        /// </param>
        /// <returns>
        /// 正常に実行できたならtrue、そうではないのならfalseです。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_GetProperties(IntPtr buffer, out UInt64 bit_count, out Int32 hash_code, out UInt32 flags);

        #endregion

        #region 値の参照

        /// <summary>
        /// 与えられた多倍長整数のUInt32型への変換を試みます。
        /// </summary>
        /// <param name="buffer">
        /// 変換する多倍長整数です。
        /// </param>
        /// <param name="value">
        /// 変換されたUInt32整数です。
        /// </param>
        /// <returns>
        /// 変換に成功した場合はtrue、そうではないのならfalseです。
        /// 多倍長整数の値がUInt32型で表現できる範囲外である場合もfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_GetUint32Value(IntPtr buffer, out UInt32 value);

        /// <summary>
        /// 与えられた多倍長整数のUInt64型への変換を試みます。
        /// </summary>
        /// <param name="buffer">
        /// 変換する多倍長整数です。
        /// </param>
        /// <param name="value">
        /// 変換されたUInt64整数です。
        /// </param>
        /// <returns>
        /// 変換に成功した場合はtrue、そうではないのならfalseです。
        /// 多倍長整数の値がUInt64型で表現できる範囲外である場合もfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_GetUint64Value(IntPtr buffer, out UInt64 value);

        #endregion

        #region 値の設定

        /// <summary>
        /// 与えられた多倍長整数の領域に与えられたUInt32整数を格納します。
        /// </summary>
        /// <param name="buffer">
        /// 格納先の多倍長整数の領域です。
        /// </param>
        /// <param name="value">
        /// 格納するUInt32整数です。
        /// </param>
        /// <returns>
        /// 格納に成功した場合はtrue、そうではない場合はfalseです。
        /// ゼロを格納しようとした場合はfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_SetUint32Value(IntPtr buffer, UInt32 value);

        /// <summary>
        /// 与えられた多倍長整数の領域に与えられたUInt64整数を格納します。
        /// </summary>
        /// <param name="buffer">
        /// 格納先の多倍長整数の領域です。
        /// </param>
        /// <param name="value">
        /// 格納するUInt64整数です。
        /// </param>
        /// <returns>
        /// 格納に成功した場合はtrue、そうではない場合はfalseです。
        /// ゼロを格納しようとした場合はfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_SetUint64Value(IntPtr buffer, UInt64 value);

        #endregion

        #region 加算

        /// <summary>
        /// 多倍長整数と多倍長整数の加算を行います。
        /// </summary>
        /// <param name="x">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="y">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="z">
        /// 演算結果の多倍長整数を格納する領域です。
        /// この領域のサイズは演算結果を格納するのに十分でなければなりません。
        /// </param>
        /// <returns>
        /// 演算に成功した場合はtrue、そうではない場合はfalseが返ります。
        /// xのサイズがyのサイズより小さい場合、またはzのサイズが演算結果を格納するのに不十分である場合にもfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_Add(IntPtr x, IntPtr y, IntPtr z);

        /// <summary>
        /// 多倍長整数とUInt32整数の加算を行います。
        /// </summary>
        /// <param name="x">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="y">
        /// 演算対象のUInt32整数です。
        /// </param>
        /// <param name="z">
        /// 演算結果の多倍長整数を格納する領域です。
        /// この領域のサイズは演算結果を格納するのに十分でなければなりません。
        /// </param>
        /// <returns>
        /// 演算に成功した場合はtrue、そうではない場合はfalseが返ります。
        /// zのサイズが演算結果を格納するのに不十分である場合にもfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_AddUInt32(IntPtr x, UInt32 y, IntPtr z);

        /// <summary>
        /// 多倍長整数とUInt64整数の加算を行います。
        /// </summary>
        /// <param name="x">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="y">
        /// 演算対象のUInt64整数です。
        /// </param>
        /// <param name="z">
        /// 演算結果の多倍長整数を格納する領域です。
        /// この領域のサイズは演算結果を格納するのに十分でなければなりません。
        /// </param>
        /// <returns>
        /// 演算に成功した場合はtrue、そうではない場合はfalseが返ります。
        /// zのサイズが演算結果を格納するのに不十分である場合にもfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_AddUInt64(IntPtr x, UInt64 y, IntPtr z);

        #endregion

        #region 乗算

        /// <summary>
        /// 多倍長整数と多倍長整数の乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="y">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="z">
        /// 演算結果の多倍長整数を格納する領域です。
        /// この領域のサイズは演算結果を格納するのに十分でなければなりません。
        /// </param>
        /// <returns>
        /// 演算に成功した場合はtrue、そうではない場合はfalseが返ります。
        /// xのサイズがyのサイズより小さい場合、またはzのサイズが演算結果を格納するのに不十分である場合にもfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_Multiply(IntPtr x, IntPtr y, IntPtr z);

        /// <summary>
        /// 多倍長整数とUInt32整数の乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="y">
        /// 演算対象のUInt32整数です。
        /// </param>
        /// <param name="z">
        /// 演算結果の多倍長整数を格納する領域です。
        /// この領域のサイズは演算結果を格納するのに十分でなければなりません。
        /// </param>
        /// <returns>
        /// 演算に成功した場合はtrue、そうではない場合はfalseが返ります。
        /// zのサイズが演算結果を格納するのに不十分である場合にもfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_MultiplyUInt32(IntPtr x, UInt32 y, IntPtr z);

        /// <summary>
        /// 多倍長整数とUInt64整数の乗算を行います。
        /// </summary>
        /// <param name="x">
        /// 演算対象の多倍長整数です。
        /// </param>
        /// <param name="y">
        /// 演算対象のUInt64整数です。
        /// </param>
        /// <param name="z">
        /// 演算結果の多倍長整数を格納する領域です。
        /// この領域のサイズは演算結果を格納するのに十分でなければなりません。
        /// </param>
        /// <returns>
        /// 演算に成功した場合はtrue、そうではない場合はfalseが返ります。
        /// zのサイズが演算結果を格納するのに不十分である場合にもfalseが返ります。
        /// </returns>
        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_MultiplyUInt64(IntPtr x, UInt64 y, IntPtr z);

        #endregion

        #endregion

    }
}