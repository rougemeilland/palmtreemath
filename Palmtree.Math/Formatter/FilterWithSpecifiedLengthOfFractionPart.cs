/*
  FilterWithSpecifiedLengthOfFractionPart.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;

namespace Palmtree.Math.Formatter
{
    internal class FilterWithSpecifiedLengthOfFractionPart
        : IParserOfNumber
    {
        #region �v���C�x�[�g�t�B�[���h

        private IParserOfNumber _parser_imp;
        private int _offset;
        private byte[] _digits;

        #endregion

        #region �R���X�g���N�^

        public FilterWithSpecifiedLengthOfFractionPart(IParserOfNumber parser_imp, ushort length_of_fraction_part)
        {
            _parser_imp = parser_imp;
            List<byte> digits = new List<byte>();
            INumberSequence sequence = parser_imp.NumberSequence;
            if (parser_imp.Offset <= 0)
                _offset = 0;
            else
            {
                _offset = parser_imp.Offset;
                for (int count = 0; count < parser_imp.Offset && !sequence.IsZero; ++count)
                    digits.Add(sequence.GetDigit());
            }
            int index = 0;
            for (; index > parser_imp.Offset && index > -length_of_fraction_part; --index)
                digits.Add(0);
            if (index > -length_of_fraction_part)
            {
                for (; index > -length_of_fraction_part; --index)
                    digits.Add(sequence.GetDigit());
                _digits = FixedNumberSequence.HalfAdjust(digits.ToArray(), sequence.GetDigit(), parser_imp.BaseNumberInfo, ref _offset);
            }
            else
                _digits = FixedNumberSequence.HalfAdjust(digits.ToArray(), sequence.GetDigit(), parser_imp.BaseNumberInfo, ref _offset);
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
