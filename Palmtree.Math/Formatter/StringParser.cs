/*
  StringParser.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Palmtree.Math.Formatter
{
    internal class StringParser
        : IParserOfNumber
    {
        #region プライベートフィールド

        private class NumberSequence
            : INumberSequence
        {
            #region 

            private enum SequenceType { Integer, Fraction };

            #endregion

            #region プライベートフィールド

            private byte[] _integer_part;
            private byte[] _fraction_part;
            private SequenceType _current_sequence;
            private int _index;

            #endregion

            #region コンストラクタ

            public NumberSequence(byte[] integer_part, byte[] fraction_part)
            {
                _integer_part = integer_part;
                _fraction_part = fraction_part;
                _current_sequence = _integer_part.Length > 0 ? SequenceType.Integer : SequenceType.Fraction;
                _index = 0;
            }

            #endregion

            #region INumberSequence メンバ

            bool INumberSequence.IsZero
            {
                get
                {
                    return (_current_sequence == SequenceType.Fraction && _index >= _fraction_part.Length);
                }
            }

            byte INumberSequence.GetDigit()
            {
                switch (_current_sequence)
                {
                    case SequenceType.Integer:
                        {
                            byte digit = _integer_part[_index];
                            ++_index;
                            if (_index >= _integer_part.Length)
                            {
                                _current_sequence = SequenceType.Fraction;
                                _index = 0;
                            }
                            return (digit);
                        }
                        //break;
                    case SequenceType.Fraction:
                        {
                            if (_index >= _fraction_part.Length)
                                return (0);
                            else
                            {
                                byte digit = _fraction_part[_index];
                                ++_index;
                                return (digit);
                            }
                        }
                        //break;
                    default:
                        throw (new ApplicationException("サポートされていないSequenceTypeが指定されました。"));
                }
            }

            #endregion
        }

        #endregion

        #region プライベートフィールド

        private static IBaseNumberInfo _decimal_base_number_info;
        private static IBaseNumberInfo _hexadecimal_base_number_info;
        private IBaseNumberInfo _base_number_info;
        private byte[] _integer_part;
        private byte[] _fraction_part;
        private int _offset;

        #endregion

        #region コンストラクタ

        static StringParser()
        {
            _decimal_base_number_info = DecimalBaseNumberInfo.DefaultInstance;
            _hexadecimal_base_number_info = HexaDecimalBaseNumberInfo.DefaultInstanceUsingUpperCaseDigit;
        }

        private StringParser(IBaseNumberInfo base_number_info, byte[] integer_part, byte[] fraction_part, int exp)
        {
            _base_number_info = base_number_info;
            _offset = integer_part.Length + exp;
            _integer_part = integer_part;
            _fraction_part = fraction_part;
        }

        #endregion

        #region パブリックメソッド

        public static IParserOfNumber CreateInstance(string s, NumberStyles style, IFormatProvider provider, out bool negative)
        {
            negative = false;
            if (DefinedStyle(style, NumberStyles.AllowHexSpecifier))
            {
                NumberStyles flag = style;
                flag = (flag & ~NumberStyles.AllowHexSpecifier);
                flag = (flag & ~NumberStyles.AllowLeadingWhite);
                flag = (flag & ~NumberStyles.AllowTrailingWhite);
                if (flag != NumberStyles.None)
                    throw (new ArgumentException("組み合わせができないフラグが指定されました。", "style"));
            }
            NumberFormatInfo number_format_info = NumberFormatInfo.GetInstance(provider);
            CultureInfo culture = provider as CultureInfo;
            if (culture == null)
                culture = CultureInfo.CurrentCulture;
            string comma_s = number_format_info.NumberGroupSeparator;
            string period_s = number_format_info.NumberDecimalSeparator;
            string plus_s = number_format_info.PositiveSign;
            string minus_s = number_format_info.NegativeSign;
            string currency_s = number_format_info.CurrencySymbol;
            string leading_bracket_s = "(";
            string traling_bracket_s = ")";
            IBaseNumberInfo base_number_info = DefinedStyle(style, NumberStyles.AllowHexSpecifier) ? _hexadecimal_base_number_info : _decimal_base_number_info;
            List<byte> integer_part = new List<byte>();
            List<byte> fraction_part = new List<byte>();
            List<char> exponential_part = new List<char>();
            bool found_sign_symbol = false;
            bool found_currency_symbol = false;
            bool double_defined_sign_symbol = false;
            bool double_defined_currency_symbol = false;
            bool found_leading_bracket = false;
            bool found_trailing_bracket = false;
            int index = 0;
            // 先行する空白の解析
            if (index < s.Length && DefinedStyle(style, NumberStyles.AllowLeadingWhite))
            {
                for (; index < s.Length; ++index)
                {
                    if (!char.IsWhiteSpace(s, index))
                        break;
                }
            }
            // 先行する開き括弧の解析
            if (index < s.Length && DefinedStyle(style, NumberStyles.AllowParentheses) && IsMatch(s, index, leading_bracket_s))
            {
                found_leading_bracket = true;
                negative = true;
                index += leading_bracket_s.Length;
            }
            // 通貨記号と符号の解析
            while (index < s.Length && (IsMatch(s, index, plus_s) || IsMatch(s, index, minus_s) || IsMatch(s, index, currency_s)))
            {
                if (DefinedStyle(style, NumberStyles.AllowLeadingSign) && IsMatch(s, index, plus_s))
                {
                    if (found_sign_symbol)
                        double_defined_sign_symbol = true;
                    found_sign_symbol = true;
                    index += plus_s.Length;
                }
                else if (DefinedStyle(style, NumberStyles.AllowLeadingSign) && IsMatch(s, index, minus_s))
                {
                    if (found_sign_symbol)
                        double_defined_sign_symbol = true;
                    found_sign_symbol = true;
                    negative = true;
                    index += minus_s.Length;
                }
                else if (DefinedStyle(style, NumberStyles.AllowCurrencySymbol) && IsMatch(s, index, currency_s))
                {
                    if (found_currency_symbol)
                        double_defined_currency_symbol = true;
                    found_currency_symbol = true;
                    index += currency_s.Length;
                }
                else
                    break;
                if (index < s.Length && DefinedStyle(style, NumberStyles.AllowLeadingWhite))
                {
                    for (; index < s.Length; ++index)
                    {
                        if (!char.IsWhiteSpace(s, index))
                            break;
                    }
                }
            }
            if (index < s.Length && base_number_info.IsValidChar(s[index]))
            {
                // 整数部の最初の数字の解析
                integer_part.Add(base_number_info.ParseChar(s[index]));
                ++index;
                // 整数部の後続の数字列の解析
                while (index < s.Length)
                {
                    if (base_number_info.IsValidChar(s[index]))
                    {
                        integer_part.Add(base_number_info.ParseChar(s[index]));
                        ++index;
                    }
                    else if (DefinedStyle(style, NumberStyles.AllowThousands) && IsMatchComma(s, index, comma_s))
                        index += comma_s.Length;
                    else
                        break;
                }
            }
            // 小数部の解析
            if (index < s.Length && DefinedStyle(style, NumberStyles.AllowDecimalPoint) && IsMatch(s, index, period_s))
            {
                index += period_s.Length;
                while (index < s.Length)
                {
                    if (base_number_info.IsValidChar(s[index]))
                    {
                        fraction_part.Add(base_number_info.ParseChar(s[index]));
                        ++index;
                    }
                    else
                        break;
                }
            }
            // 指数部の解析
            if (index < s.Length && DefinedStyle(style, NumberStyles.AllowExponent) && (s[index] == 'E' || s[index] == 'e'))
            {
                ++index;
                if (index < s.Length)
                {
                    if (IsMatch(s, index, plus_s))
                    {
                        exponential_part.Add(s[index]);
                        index += plus_s.Length;
                    }
                    else if (IsMatch(s, index, minus_s))
                    {
                        exponential_part.Add(s[index]);
                        index += minus_s.Length;
                    }
                    else
                    {
                    }
                }
                int exp_digits = 0;
                while (index < s.Length)
                {
                    if (base_number_info.IsValidChar(s[index]))
                    {
                        exponential_part.Add(s[index]);
                        ++exp_digits;
                        ++index;
                    }
                    else
                        break;
                }
                if (exp_digits == 0)
                    return (null);
            }
            // 通貨記号と符号の解析
            while (index < s.Length)
            {
                int index2 = index;
                if (DefinedStyle(style, NumberStyles.AllowTrailingWhite))
                {
                    for (; index2 < s.Length; ++index2)
                    {
                        if (!char.IsWhiteSpace(s, index2))
                            break;
                    }
                }
                if (DefinedStyle(style, NumberStyles.AllowTrailingSign) && IsMatch(s, index2, plus_s))
                {
                    if (found_sign_symbol)
                        double_defined_sign_symbol = true;
                    found_sign_symbol = true;
                    index = index2 + plus_s.Length;
                }
                else if (DefinedStyle(style, NumberStyles.AllowTrailingSign) && IsMatch(s, index2, minus_s))
                {
                    if (found_sign_symbol)
                        double_defined_sign_symbol = true;
                    found_sign_symbol = true;
                    negative = true;
                    index = index2 + minus_s.Length;
                }
                else if (DefinedStyle(style, NumberStyles.AllowCurrencySymbol) && IsMatch(s, index2, currency_s))
                {
                    if (found_currency_symbol)
                        double_defined_currency_symbol = true;
                    found_currency_symbol = true;
                    index = index2 + currency_s.Length;
                }
                else
                    break;
            }
            // 後続の閉じ括弧の解析
            if (index < s.Length && DefinedStyle(style, NumberStyles.AllowParentheses) && IsMatch(s, index, traling_bracket_s))
            {
                found_trailing_bracket = true;
                index += traling_bracket_s.Length;
            }
            // 後続の空白の解析
            if (index < s.Length && DefinedStyle(style, NumberStyles.AllowTrailingWhite))
            {
                for (; index < s.Length; ++index)
                {
                    if (!char.IsWhiteSpace(s, index))
                        break;
                }
            }
            if (index < s.Length)
                return (null);
            if (double_defined_currency_symbol || double_defined_sign_symbol)
                return (null);
            if (found_leading_bracket ^ found_trailing_bracket)
                return (null);
            if (found_leading_bracket && found_sign_symbol)
                return (null);
            int exp = 0;
            if (exponential_part.Count > 0)
            {
                if (!int.TryParse(new string(exponential_part.ToArray()), NumberStyles.AllowLeadingSign, provider, out exp))
                    return (null);
            }
            if (integer_part.Count == 0 && fraction_part.Count == 0)
                return (null);
            return (new StringParser(base_number_info, integer_part.ToArray(), fraction_part.ToArray(), exp));
        }

        public static bool DefinedStyle(NumberStyles style, NumberStyles x)
        {
            return ((style & x) != 0);
        }

        public static bool IsMatch(string s, int index, string keyword)
        {
            return (string.Compare(s, index, keyword, 0, keyword.Length) == 0);
        }

        public static bool IsMatchComma(string s, int index, string keyword)
        {
            if (string.Compare(s, index, keyword, 0, keyword.Length) == 0)
                return (true);
            else if (keyword.Equals("\u00a0"))
                return (string.Compare(s, index, " ", 0, 1) == 0);
            else
                return (false);
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
                return (true);
            }
        }

        INumberSequence IParserOfNumber.NumberSequence
        {
            get
            {
                return (new NumberSequence(_integer_part, _fraction_part));
            }
        }

        string IParserOfNumber.FormatDigit(byte digit)
        {
            return (new string(_base_number_info.FormatChar(digit), 1));
        }

        IBaseNumberInfo IParserOfNumber.BaseNumberInfo
        {
            get
            {
                return (_base_number_info);
            }
        }

        byte IParserOfNumber.MostSignificantPaddingDigit
        {
            get
            {
                throw (new NotSupportedException());
            }
        }

        #endregion
    }
}
