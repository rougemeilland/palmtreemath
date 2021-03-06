﻿/*
  HexaDecimalBaseNumberInfo.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Diagnostics;
using Palmtree.Math.Implements;

namespace Palmtree.Math.Formatter
{
    /// <summary>
    /// 16進数の数値の基数に依存する操作を行うクラスです。
    /// </summary>
    internal class HexaDecimalBaseNumberInfo
        : BaseNumberInfoBase
    {
        #region プライベートフィールド

        private static IBaseNumberInfo _instance_upper;
        private static IBaseNumberInfo _instance_lower;

        #endregion

        #region コンストラクタ

        static HexaDecimalBaseNumberInfo()
        {
            _instance_upper = new HexaDecimalBaseNumberInfo(true);
            _instance_lower = new HexaDecimalBaseNumberInfo(false);
        }

        private HexaDecimalBaseNumberInfo(bool prior_upper_case)
            : base(16, false)
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
            if (prior_upper_case)
            {
                RegisterUpperDigit();
                RegisterLowerDigit();
            }
            else
            {
                RegisterLowerDigit();
                RegisterUpperDigit();
            }
        }

        #endregion

        #region パブリックプロパティ

        /// <summary>
        /// 英大文字を使用する<see cref="HexaDecimalBaseNumberInfo"/>のインスタンスです。
        /// </summary>
        public static IBaseNumberInfo DefaultInstanceUsingUpperCaseDigit
        {
            get
            {
                return (_instance_upper);
            }
        }

        /// <summary>
        /// 英小文字を使用する<see cref="HexaDecimalBaseNumberInfo"/>のインスタンスです。
        /// </summary>
        public static IBaseNumberInfo DefaultInstanceUsingLowerCaseDigit
        {
            get
            {
                return (_instance_lower);
            }
        }

        #endregion

        #region プライベートメソッド

        private void RegisterUpperDigit()
        {
            RegisterBaseNumberChar('A', 10);
            RegisterBaseNumberChar('B', 11);
            RegisterBaseNumberChar('C', 12);
            RegisterBaseNumberChar('D', 13);
            RegisterBaseNumberChar('E', 14);
            RegisterBaseNumberChar('F', 15);
        }

        private void RegisterLowerDigit()
        {
            RegisterBaseNumberChar('a', 10);
            RegisterBaseNumberChar('b', 11);
            RegisterBaseNumberChar('c', 12);
            RegisterBaseNumberChar('d', 13);
            RegisterBaseNumberChar('e', 14);
            RegisterBaseNumberChar('f', 15);
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
            return (value.Multiply16AndAddQuick(0));
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
            return (value.Multiply16AndAddQuick(digit));
        }

        /// <summary>
        /// 整数部をあらわす数値から最下位桁の数字を取り出します。
        /// </summary>
        /// <param name="value">
        /// 整数部をあらわす数値です。( value &gt; 0 )
        /// </param>
        /// <param name="updated_value">
        /// 更新された整数部です。( value / 基数 )
        /// </param>
        /// <returns>
        /// 最下位桁の数字です。( value % 基数 )
        /// </returns>
        protected override byte GetLeastSignificantDigitFromIntegerPart(NativeUnsignedInteger value, out NativeUnsignedInteger updated_value)
        {
            Debug.Assert(!value.IsZero);
            var data = (byte)value.BitwiseAnd(0x0fU);
            updated_value = value.RightShift(4);
            return (data);
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
            // denominator が素因数としてが2だけを含むかどうかを調べる
            return (denominator.IsPowerOfTwo);
        }

        #endregion
    }
}