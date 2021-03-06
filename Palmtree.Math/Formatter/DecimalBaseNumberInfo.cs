﻿/*
  DecimalBaseNumberInfo.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using Palmtree.Math.Implements;

namespace Palmtree.Math.Formatter
{
    /// <summary>
    /// 10進数の数値の基数に依存する操作を行うクラスです。
    /// </summary>
    internal class DecimalBaseNumberInfo
        : BaseNumberInfoBase
    {
        #region プライベートフィールド

        private static IBaseNumberInfo _instance;

        #endregion

        #region コンストラクタ

        static DecimalBaseNumberInfo()
        {
            _instance = new DecimalBaseNumberInfo();
        }

        private DecimalBaseNumberInfo()
            : base(10, true)
        {
            RegisterBaseNumberChar('0', 0);
            RegisterBaseNumberChar('1', 1);
            RegisterBaseNumberChar('2', 2);
            RegisterBaseNumberChar('3', 3);
            RegisterBaseNumberChar('4', 4);
            RegisterBaseNumberChar('5', 5);
            RegisterBaseNumberChar('6', 6);
            RegisterBaseNumberChar('7', 7);
            RegisterBaseNumberChar('8', 8);
            RegisterBaseNumberChar('9', 9);
        }

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// <see cref="DecimalBaseNumberInfo"/>の既定のインスタンスです。
        /// </summary>
        public static IBaseNumberInfo DefaultInstance
        {
            get
            {
                return (_instance);
            }
        }

        #endregion

        #region BaseNumberInfoBase から継承されたメンバ

        /// <summary>
        /// ある整数値に基数をかけた値を得ます。
        /// 計算結果は (value * 基数) と等価です。
        /// </summary>
        /// <param name="value">
        /// 計算対象の値です。
        /// </param>
        /// <returns>
        /// 計算結果の値です。
        /// </returns>
        protected override NativeUnsignedInteger Multiply(NativeUnsignedInteger value)
        {
            return (value.Multiply10AndAddQuick(0));
        }

        /// <summary>
        /// ある整数値に基数をかけ、与えられた値を足した値を得ます。
        /// 計算結果は (value * 基数 + digit) と等価です。
        /// </summary>
        /// <param name="value">
        /// 計算対象の値です。
        /// </param>
        /// <param name="digit">
        /// 加算する値です。
        /// </param>
        /// <returns>
        /// 計算結果の値です。
        /// </returns>
        protected override NativeUnsignedInteger MultiplyAndAdd(NativeUnsignedInteger value, byte digit)
        {
            return (value.Multiply10AndAddQuick(digit));
        }

        /// <summary>
        /// 与えられた有理数の分母部分から、有理数が小数以下有限桁数で表現できるかどうかを調べます。
        /// </summary>
        /// <param name="denominator">
        /// 調べる対象の有理数の分母部分です。
        /// nullの場合は分母が1を意味します。
        /// </param>
        /// <returns>
        /// 有理数が小数以下有限桁数で表現できると判断可能ならtrue、そうではないのならfalseです。
        /// </returns>
        protected override bool IsRationalNumberRepresentableByFiniteDigits(NativeUnsignedInteger denominator)
        {
            // denominator が素因数としてが2と5だけを含むかどうかを調べる

            System.Diagnostics.Debug.Assert(!denominator.IsZero);

            // denominator から素因数2を除去する (偶数である限り2で割り続ける)
            while (denominator.IsEven)
                denominator = denominator.RightShift1Quick();

            System.Diagnostics.Debug.Assert(!denominator.IsZero);

            // denominator から素因数5を除去する (5で割り切れる限り5で割り続ける)
            while (true)
            {
                UInt32 r;
                var t = denominator.DivRem(5, out r);
                if (r > 0)
                    break;
                denominator = t;
            }
            // この時点で denominator は5で割り切れなくなった最後の値

            System.Diagnostics.Debug.Assert(!denominator.IsZero);

            // この時点で denominator が1なら素因数として2と5以外は含まないので、小数点以下を有限桁数で表現できる。
            return (denominator.IsOne);
        }

        #endregion
    }
}