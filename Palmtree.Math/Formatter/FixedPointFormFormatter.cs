/*
  FixedPointFormFormatter.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Palmtree.Math.Formatter
{
    internal class FixedPointFormFormatter
        : INumberFormatter
    {
        #region �v���C�x�[�g�t�B�[���h

        private IParserOfNumber _parser;
        private NumberFormatInfo _number_format_info;
        private bool _thousand_separated;
        private NumberFormatType _number_format_type;
        private bool _negative;
        private byte _most_significant_padding_digit;

        #endregion

        #region �R���X�g���N�^

        public FixedPointFormFormatter(IParserOfNumber parser, NumberFormatInfo number_format_info, bool negative, bool thousand_separated, NumberFormatType number_format_type)
        {
            _parser = parser;
            _number_format_info = number_format_info;
            _negative = negative;
            _thousand_separated = thousand_separated;
            _number_format_type = number_format_type;
            _most_significant_padding_digit = _parser.MostSignificantPaddingDigit;
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        private string GetDigitsString(string integer_part_string, string fraction_part_string)
        {
            string digits = integer_part_string;
            if (fraction_part_string.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(integer_part_string);
                sb.Append(_number_format_info.GetDecimalSeparator(_number_format_type));
                sb.Append(fraction_part_string);
                digits = sb.ToString();
            }
            return digits;
        }

        private string GetFractionPartString(INumberSequence sequence, ref int index, ref bool nonzero)
        {
            StringBuilder sb = new StringBuilder();
            if (!sequence.IsZero)
            {
                while (index < 0)
                {
                    sb.Append("0");
                    ++index;
                }
                while (!sequence.IsZero)
                {
                    byte digit = sequence.GetDigit();
                    if (digit != 0)
                        nonzero = true;
                    sb.Append(_parser.FormatDigit(digit));
                }
            }
            return (sb.ToString());
        }

        private string GetIntegerPartString(INumberSequence sequence, ref int index, ref bool nonzero)
        {
            List<char> buffer = new List<char>();
            if (index <= 0)
                buffer.Add('0');
            else
            {
                for (; index > 0; --index)
                {
                    byte digit = sequence.GetDigit();
                    if (digit != 0)
                        nonzero = true;
                    buffer.AddRange(_parser.FormatDigit(digit).ToCharArray());
                }
            }
            return (_number_format_info.FormatIntegerPartString(_number_format_type, buffer.ToArray(), _thousand_separated));
        }

        #endregion

        #region INumberFormatter �����o

        string INumberFormatter.Format()
        {
            INumberSequence sequence = _parser.NumberSequence;
            int index = _parser.Offset;
            bool nonzero = false;
            string integer_part_string = GetIntegerPartString(sequence, ref index, ref nonzero);
            string fraction_part_string = GetFractionPartString(sequence, ref index, ref nonzero);
            return (_number_format_info.FormatNumberString(_number_format_type, nonzero && _negative, GetDigitsString(integer_part_string, fraction_part_string)));
        }

        #endregion
    }
}
