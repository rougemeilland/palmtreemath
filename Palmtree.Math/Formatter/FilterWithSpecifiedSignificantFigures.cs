/*
  FilterWithSpecifiedSignificantFigures.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Palmtree.Math.Formatter
{
    internal class FilterWithSpecifiedSignificantFigures
        : IParserOfNumber
    {
        #region �v���C�x�[�g�t�B�[���h

        private IParserOfNumber _parser_imp;
        private int _offset;
        private byte[] _digits;

        #endregion

        #region �R���X�g���N�^

        public FilterWithSpecifiedSignificantFigures(IParserOfNumber parser_imp, int significant_figures, bool omit_least_zero)
        {
            _parser_imp = parser_imp;
            List<byte> digits = new List<byte>();
            INumberSequence sequence = parser_imp.NumberSequence;
            _offset = parser_imp.Offset;
            byte digit = sequence.GetDigit();
            while (digit == 0 && !sequence.IsZero)
            {
                digit = sequence.GetDigit();
                --_offset;
            }
            for (int count = 0; count < significant_figures/* && !sequence.IsZero*/; ++count)
            {
                digits.Add(digit);
                digit = sequence.GetDigit();
            }
            _digits = FixedNumberSequence.HalfAdjust(digits.ToArray(), digit, parser_imp.BaseNumberInfo, ref _offset);
            if (_digits.Length > significant_figures)
            {
                Debug.Assert(_digits.Length == significant_figures + 1);
                Debug.Assert(_digits[_digits.Length - 1] == 0);
                Array.Resize<byte>(ref _digits, significant_figures);
            }
            if (omit_least_zero)
            {
                int index = _digits.Length - 1;
                for (; index >= 0; --index)
                {
                    if (_digits[index] != 0)
                        break;
                }
                Array.Resize<byte>(ref _digits, index + 1);
            }
        }

        #endregion

        #region IParserOfNumber �����o

        int IParserOfNumber.Offset
        {
            get
            {
                return (_offset);
            }
        }

        bool IParserOfNumber.IsLimittedDigits
        {
            get
            {
                return (true);
            }
        }

        INumberSequence IParserOfNumber.NumberSequence
        {
            get
            {
                return (new FixedNumberSequence(_digits));
            }
        }

        string IParserOfNumber.FormatDigit(byte digit)
        {
            return (_parser_imp.FormatDigit(digit));
        }

        IBaseNumberInfo IParserOfNumber.BaseNumberInfo
        {
            get
            {
                return (_parser_imp.BaseNumberInfo);
            }
        }

        byte IParserOfNumber.MostSignificantPaddingDigit
        {
            get
            {
                return (_parser_imp.MostSignificantPaddingDigit);
            }
        }

        #endregion
    }
}
