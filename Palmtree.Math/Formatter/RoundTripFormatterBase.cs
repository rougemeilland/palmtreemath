/*
  RoundTripFormatterBase.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;
using System.Globalization;

namespace Palmtree.Math.Formatter
{
    internal abstract class RoundTripFormatterBase
        : INumberFormatter
    {
        #region プライベートフィールド

        private NumberFormatInfo _number_format_info;
        private IBaseNumberInfo _base_number_info;

        #endregion

        #region コンストラクタ

        protected RoundTripFormatterBase()
        {
            _number_format_info = CultureInfo.InvariantCulture.NumberFormat;
            _base_number_info = DecimalBaseNumberInfo.DefaultInstance;
        }

        #endregion

        #region プロテクテッドメソッド

        protected string SimpleFormatter(bool negative, ushort[] value)
        {
            Stack<string> digits = new Stack<string>();
            while (value.Length > 0)
            {
                ushort[] value2;
                byte digit =  _base_number_info.GetLeastSignificantDigitFromIntegerPart(value, out value2);
                digits.Push(_base_number_info.FormatChar(digit).ToString());
                value = value2;
            }
            if (digits.Count == 0)
            {
                digits.Push("0");
                negative = false;
            }
            if (negative)
                digits.Push(_number_format_info.NegativeSign);
            return (string.Concat(digits.ToArray()));
        }

        protected abstract string Format();

        #endregion

        #region INumberFormatter メンバ

        string INumberFormatter.Format()
        {
            return (Format());
        }

        #endregion
    }
}
