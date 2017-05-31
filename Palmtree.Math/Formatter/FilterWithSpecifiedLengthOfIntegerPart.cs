/*
  FilterWithSpecifiedLengthOfIntegerPart.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Formatter
{
    internal class FilterWithSpecifiedLengthOfIntegerPart
        : IParserOfNumber
    {
        #region NumberSequence クラスの定義

        private class NumberSequence
            : INumberSequence
        {
            #region プライベートフィールド

            private int _counter_of_leadeng_zero;
            private INumberSequence _sequence_imp;
            private byte _most_significant_padding_digit;

            #endregion

            #region コンストラクタ

            public NumberSequence(IParserOfNumber parser_imp, int length_of_integer_part)
            {
                _counter_of_leadeng_zero = 0;
                if (length_of_integer_part > parser_imp.Offset)
                    _counter_of_leadeng_zero = length_of_integer_part - parser_imp.Offset;
                _sequence_imp = parser_imp.NumberSequence;
                _most_significant_padding_digit = parser_imp.MostSignificantPaddingDigit;
            }

            #endregion

            #region INumberSequence メンバ

            bool INumberSequence.IsZero
            {
                get
                {
                    return (_sequence_imp.IsZero);
                }
            }

            byte INumberSequence.GetDigit()
            {
                if (_counter_of_leadeng_zero > 0)
                {
                    --_counter_of_leadeng_zero;
                    return (_most_significant_padding_digit);
                }
                else
                    return (_sequence_imp.GetDigit());
            }

            #endregion
        }

        #endregion

        #region プライベートフィールド

        private IParserOfNumber _parser_imp;
        private int _length_of_integer_part;
        private int _offset;

        #endregion

        #region コンストラクタ

        public FilterWithSpecifiedLengthOfIntegerPart(IParserOfNumber parser_imp, int length_of_integer_part)
        {
            _parser_imp = parser_imp;
            _length_of_integer_part = length_of_integer_part;
            _offset = _parser_imp.Offset;
            if (_offset < _length_of_integer_part)
                _offset = _length_of_integer_part;
        }

        #endregion

        #region IParserOfNumber メンバ

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
                return (_parser_imp.IsLimittedDigits);
            }
        }

        INumberSequence IParserOfNumber.NumberSequence
        {
            get
            {
                return (new NumberSequence(_parser_imp, _length_of_integer_part));
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
