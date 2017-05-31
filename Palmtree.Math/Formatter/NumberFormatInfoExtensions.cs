/*
  NumberFormatInfoExtensions.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Palmtree.Math.Formatter
{
    internal static class NumberFormatInfoExtensions
    {
        #region プライベートフィールド

        private static string[] _currency_negative_patterns = new string[]
            {
                /*  0 */ "($n)",
                /*  1 */ "-$n",
                /*  2 */ "$-n",
                /*  3 */ "$n-",
                /*  4 */ "(n$)",
                /*  5 */ "-n$",
                /*  6 */ "n-$",
                /*  7 */ "n$-",
                /*  8 */ "-n $",
                /*  9 */ "-$ n",
                /* 10 */ "n $-",
                /* 11 */ "$ n-",
                /* 12 */ "$ -n",
                /* 13 */ "n- $",
                /* 14 */ "($ n)",
                /* 15 */ "(n $)",
            };
        private static string[] _currency_positive_patterns = new string[]
            {
                /*  0 */ "$n",
                /*  1 */ "n$",
                /*  2 */ "$ n",
                /*  3 */ "n $",
            };
        private static string[] _number_negative_patterns = new string[]
            {
                /*  0 */ "(n)",
                /*  1 */ "-n",
                /*  2 */ "- n",
                /*  3 */ "n-",
                /*  4 */ "n -",
            };
        private static string[] _number_positive_patterns = new string[]
            {
                /*  0 */ "n",
            };
        private static string[] _percent_negative_patterns = new string[]
            {
                /*  0 */ "-n %",
                /*  1 */ "-n%",
                /*  2 */ "-%n",
                /*  3 */ "%-n",
                /*  4 */ "%n-",
                /*  5 */ "n-%",
                /*  6 */ "n%-",
                /*  7 */ "-%n",
                /*  8 */ "n %-",
                /*  9 */ "% n-",
                /* 10 */ "% -n",
                /* 11 */ "n- %",
            };

        private static string[] _percent_positive_patterns = new string[]
            {
                /*  0 */ "n %",
                /*  1 */ "n%",
                /*  2 */ "%n",
                /*  3 */ "%n",
            };

        #endregion

        #region パブリックメソッド

        public static string FormatIntegerPartString(this NumberFormatInfo info, NumberFormatType number_format_type, char[] integer_part_digits, bool thousand_separated)
        {
            if (!thousand_separated)
                return (new string(integer_part_digits));
            string group_separator = info.GetGroupSeparator(number_format_type);
            int[] group_sizes = info.GetGroupSizes(number_format_type);
            Debug.Assert(group_sizes.Length > 0);
            StringBuilder sb = new StringBuilder();
            int group_size_index = 0;
            int string_index = integer_part_digits.Length;
            while (string_index > 0)
            {
                int group_size = group_sizes[group_size_index];
                if (group_size == 0)
                {
                    sb.Insert(0, new string(integer_part_digits, 0, string_index));
                    break;
                }
                else if (string_index > group_size)
                {
                    int start_index = string_index - group_size;
                    int length = group_size;
                    sb.Insert(0, new string(integer_part_digits, start_index, length));
                    sb.Insert(0, group_separator);
                    string_index = start_index;
                    if (group_size_index < group_sizes.Length - 1)
                        ++group_size_index;
                }
                else
                {
                    int length = group_size;
                    sb.Insert(0, new string(integer_part_digits, 0, string_index));
                    string_index = 0;
                    break;
                }
            }
            return (sb.ToString());
        }

        private static string FormatNumberString(string format, string currency_symbol, string percent_symbol, string negative_symbol, string digits)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in format)
            {
                switch (c)
                {
                    case 'n':
                        sb.Append(digits);
                        break;
                    case '-':
                        sb.Append(negative_symbol);
                        break;
                    case '$':
                        sb.Append(currency_symbol);
                        break;
                    case '%':
                        sb.Append(percent_symbol);
                        break;
                    case ' ':
                    case '(':
                    case ')':
                        sb.Append(c);
                        break;
                    default:
                        throw (new ApplicationException(string.Format("書式'{0}'に未知の文字'{1}'が見つかりました。", format, c)));
                }
            }
            return (sb.ToString());
        }

        public static string FormatNumberString(this NumberFormatInfo info, NumberFormatType number_format_type, bool is_negative, string digits)
        {
            switch (number_format_type)
            {
                case NumberFormatType.Normal:
                    if (is_negative)
                        return (FormatNumberString(_number_negative_patterns[info.NumberNegativePattern], info.CurrencySymbol, info.PercentSymbol, info.NegativeSign, digits));
                    else
                        return (FormatNumberString(_number_positive_patterns[0], info.CurrencySymbol, info.PercentSymbol, info.NegativeSign, digits));
                case NumberFormatType.Currency:
                    if (is_negative)
                        return (FormatNumberString(_currency_negative_patterns[info.CurrencyNegativePattern], info.CurrencySymbol, info.PercentSymbol, info.NegativeSign, digits));
                    else
                        return (FormatNumberString(_currency_positive_patterns[info.CurrencyPositivePattern], info.CurrencySymbol, info.PercentSymbol, info.NegativeSign, digits));
                case NumberFormatType.Percent:
                    if (is_negative)
                        return (FormatNumberString(_percent_negative_patterns[info.PercentNegativePattern], info.CurrencySymbol, info.PercentSymbol, info.NegativeSign, digits));
                    else
                        return (FormatNumberString(_percent_positive_patterns[info.PercentPositivePattern], info.CurrencySymbol, info.PercentSymbol, info.NegativeSign, digits));
                default:
                    throw (new ArgumentException());
            }
        }

        public static string GetGroupSeparator(this NumberFormatInfo info, NumberFormatType number_format_type)
        {
            switch (number_format_type)
            {
                case NumberFormatType.Normal:
                    return (info.NumberGroupSeparator);
                case NumberFormatType.Currency:
                    return (info.CurrencyGroupSeparator);
                case NumberFormatType.Percent:
                    return (info.PercentGroupSeparator);
                default:
                    throw (new ArgumentException());
            }
        }

        public static string GetDecimalSeparator(this NumberFormatInfo info, NumberFormatType number_format_type)
        {
            switch (number_format_type)
            {
                case NumberFormatType.Normal:
                    return (info.NumberDecimalSeparator);
                case NumberFormatType.Currency:
                    return (info.CurrencyDecimalSeparator);
                case NumberFormatType.Percent:
                    return (info.PercentDecimalSeparator);
                default:
                    throw (new ArgumentException());
            }
        }

        #endregion

        #region プライベートメソッド

        private static int[] GetGroupSizes(this NumberFormatInfo info, NumberFormatType number_format_type)
        {
            switch (number_format_type)
            {
                case NumberFormatType.Normal:
                    return (info.NumberGroupSizes);
                case NumberFormatType.Currency:
                    return (info.CurrencyGroupSizes);
                case NumberFormatType.Percent:
                    return (info.PercentGroupSizes);
                default:
                    throw (new ArgumentException());
            }
        }

        #endregion


    }
}
