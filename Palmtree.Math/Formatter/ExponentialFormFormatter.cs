/*
  ExponentialFormFormatter.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Palmtree.Math.Formatter
{
    internal class ExponentialFormFormatter
        : INumberFormatter
    {
        #region ExponentialPartDigits の定義

        public enum ExponentialPartDigits
        {
            Digits_2,
            Digits_3,
        }

        #endregion

        #region プライベートフィールド

        private IParserOfNumber _parser;
        private NumberFormatInfo _info;
        private FormatterSpecification _formatter_spec;
        private bool _negative;
        private ExponentialPartDigits _exponential_part_digits;

        #endregion

        #region コンストラクタ

        public ExponentialFormFormatter(IParserOfNumber parser, NumberFormatInfo info, bool negative, FormatterSpecification formatter_spec, ExponentialPartDigits exponential_part_digits)
        {
            if (!parser.BaseNumberInfo.AllowedExponentialForm)
                throw (new ArgumentException(@"指数表現のフォーマッタに指数表現が使用できないパーサが与えられました。", "parser"));
            _parser = parser;
            _info = info;
            _negative = negative;
            _formatter_spec = formatter_spec;
            _exponential_part_digits = exponential_part_digits;
        }

        #endregion

        #region INumberFormatter メンバ

        string INumberFormatter.Format()
        {
            List<string> result = new List<string>();
            bool nonzero = false;
            INumberSequence sequence = _parser.NumberSequence;
            byte digit = sequence.GetDigit();
            if (digit != 0)
                nonzero = true;
            result.Add(_parser.FormatDigit(digit));
            if (!sequence.IsZero)
            {
                result.Add(_info.NumberDecimalSeparator);
                while (!sequence.IsZero)
                    result.Add(_parser.FormatDigit(sequence.GetDigit()));
            }
            int exp = _parser.Offset - 1;
            result.Add((_formatter_spec & FormatterSpecification.UseUpperCase) != 0 ? "E" : "e");
            if (exp < 0)
            {
                exp = -exp;
                result.Add(_info.NegativeSign);
            }
            else
                result.Add(_info.PositiveSign);
            string exp_format = "D2";
            if (_exponential_part_digits == ExponentialPartDigits.Digits_3)
                exp_format = "D3";
            Debug.Assert(exp >= 0);
            result.Add(exp.ToString(exp_format, _info));
            string result_s = string.Concat(result.ToArray());
            if (nonzero && _negative)
                return (_info.NegativeSign + result_s);
            else
                return (result_s);
        }

        #endregion
    }
}
