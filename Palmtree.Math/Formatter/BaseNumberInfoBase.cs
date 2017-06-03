/*
  BaseNumberInfoBase.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Palmtree.Math.Implements;

namespace Palmtree.Math.Formatter
{
    /// <summary>
    /// 数値の基数に依存する操作を行うクラスの基本クラスです。
    /// </summary>
    internal abstract class BaseNumberInfoBase
        : IBaseNumberInfo
    {
        #region プライベートフィールド

        private byte _base_number_value;
        private bool _allowed_exponential_form;
        private Dictionary<char, byte> _digits_keyd_by_char;
        private Dictionary<byte, char> _digits_keyd_by_int;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="base_number_value">
        /// 基数です。
        /// </param>
        /// <param name="allowed_exponential_form">
        /// 指数表現が可能な基数ならばtrue、そうではないのならfalseです。
        /// </param>
        protected BaseNumberInfoBase(byte base_number_value, bool allowed_exponential_form)
        {
            if (base_number_value <= 1)
                throw (new ArgumentOutOfRangeException("基数として使用できない値です。", "base_number_value"));
            _base_number_value = base_number_value;
            _allowed_exponential_form = allowed_exponential_form;
            _digits_keyd_by_char = new Dictionary<char, byte>();
            _digits_keyd_by_int = new Dictionary<byte, char>();
        }

        #endregion

        #region プロテクテッドメソッド

        /// <summary>
        /// 数値と数字文字の対応を登録します。
        /// </summary>
        /// <param name="c">
        /// 数字を表す文字です。
        /// </param>
        /// <param name="n">
        /// 対応する数値です。
        /// </param>
        protected void RegisterBaseNumberChar(char c, byte n)
        {
            _digits_keyd_by_char.Add(c, n);
            if (!_digits_keyd_by_int.ContainsKey(n))
                _digits_keyd_by_int.Add(n, c);
        }

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
        protected abstract NativeUnsignedInteger Multiply(NativeUnsignedInteger value);

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
        protected abstract NativeUnsignedInteger MultiplyAndAdd(NativeUnsignedInteger value, byte digit);

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
        protected virtual byte GetLeastSignificantDigitFromIntegerPart(NativeUnsignedInteger value, out NativeUnsignedInteger updated_value)
        {
            if (value.IsZero)
            {
                updated_value = NativeUnsignedInteger.Zero;
                return (0);
            }
            else
            {
                UInt32 r;
                updated_value = value.DivRem(_base_number_value, out r);
                Debug.Assert(r < _base_number_value);
                return ((byte)r);
            }
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
        protected abstract bool IsRationalNumberRepresentableByFiniteDigits(NativeUnsignedInteger denominator);

        #endregion

        #region IBaseNumberInfo のメンバ

        byte IBaseNumberInfo.Value
        {
            get
            {
                return (_base_number_value);
            }
        }

        NativeUnsignedInteger IBaseNumberInfo.Multiply(NativeUnsignedInteger value)
        {
            return (Multiply(value));
        }

        NativeUnsignedInteger IBaseNumberInfo.MultiplyAndAdd(NativeUnsignedInteger value, byte digit)
        {
            return (MultiplyAndAdd(value, digit));
        }

        byte IBaseNumberInfo.GetLeastSignificantDigitFromIntegerPart(NativeUnsignedInteger value, out NativeUnsignedInteger updated_value)
        {
            return (GetLeastSignificantDigitFromIntegerPart(value, out updated_value));
        }

        byte IBaseNumberInfo.GetMostSignificantDigitFromFractionPart(NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, out NativeUnsignedInteger updated_value_numerator)
        {
            Debug.Assert(!value_numerator.IsZero);
            Debug.Assert(!value_denominator.IsZero);
            var x = value_numerator.Multiply(_base_number_value);
            NativeUnsignedInteger r;
            var q = x.DivRem(value_denominator, out r);
            updated_value_numerator = r;
            var q_uint = q.ToUInt32();
            Debug.Assert(q_uint < _base_number_value);
            return ((byte)q_uint);
        }

        bool IBaseNumberInfo.IsRationalNumberRepresentableByFiniteDigits(NativeUnsignedInteger denominator)
        {
            return (IsRationalNumberRepresentableByFiniteDigits(denominator));
        }

        bool IBaseNumberInfo.IsValidChar(char c)
        {
            return (_digits_keyd_by_char.ContainsKey(c));
        }

        byte IBaseNumberInfo.ParseChar(char c)
        {
            return (_digits_keyd_by_char[c]);
        }

        char IBaseNumberInfo.FormatChar(byte n)
        {
            return (_digits_keyd_by_int[n]);
        }

        bool IBaseNumberInfo.AllowedExponentialForm
        {
            get
            {
                return (_allowed_exponential_form);
            }
        }

        #endregion
    }
}