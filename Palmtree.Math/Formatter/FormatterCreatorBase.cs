﻿/*
  FormatterCreatorBase.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Palmtree.Math.Implements;

namespace Palmtree.Math.Formatter
{
    internal abstract class FormatterCreatorBase
        : IFormattingTypeInfo
    {
        #region NumberSeqience クラスの定義

        private class NumberSequence
            : INumberSequence
        {
            #region プライベートフィールド

            private byte[] _integer_part_digits;
            private NativeUnsignedInteger _fraction_part_numerator;
            private NativeUnsignedInteger _fraction_part_denominator;
            private IBaseNumberInfo _base_number_info;
            private int _integer_part_digits_index;

            #endregion

            #region コンストラクタ

            public NumberSequence(byte[] integer_part_digits, NativeUnsignedInteger fraction_part_numerator, NativeUnsignedInteger fraction_part_denominator, IBaseNumberInfo base_number_info)
            {
                _integer_part_digits = integer_part_digits;
                _fraction_part_numerator = fraction_part_numerator;
                _fraction_part_denominator = fraction_part_denominator;
                _base_number_info = base_number_info;
                _integer_part_digits_index = 0;
            }

            #endregion

            #region INumberSequence メンバ

            bool INumberSequence.IsZero
            {
                get
                {
                    return (_integer_part_digits_index >= _integer_part_digits.Length && _fraction_part_numerator.IsZero);
                }
            }

            byte INumberSequence.GetDigit()
            {
                if (_integer_part_digits_index < _integer_part_digits.Length)
                {
                    byte result = _integer_part_digits[_integer_part_digits_index];
                    ++_integer_part_digits_index;
                    return (result);
                }
                else
                {
                    if (_fraction_part_numerator.IsZero)
                        return (0);
                    else
                    {
                        NativeUnsignedInteger updated_numerator;
                        byte digit = _base_number_info.GetMostSignificantDigitFromFractionPart(_fraction_part_numerator, _fraction_part_denominator, out updated_numerator);
                        _fraction_part_numerator = updated_numerator;
                        return (digit);
                    }
                }
            }

            #endregion
        }

        #endregion

        #region ParserOfHexaDecimalInteger クラスの定義

        private class ParserOfHexaDecimalInteger
            : IParserOfNumber
        {
            #region プライベートフィールド

            private IBaseNumberInfo _base_number_info;
            private byte[] _digits;
            private byte _most_significant_padding_digit;

            #endregion

            #region コンストラクタ

            public ParserOfHexaDecimalInteger(IBaseNumberInfo base_number_info, bool negative, NativeUnsignedInteger value)
            {
                if (base_number_info.Value != 16)
                    throw (new ArgumentException("ParserOfHexaDecimalIntegerで指定する基数は16でなければなりません。", "base_number_info"));
                _base_number_info = base_number_info;
                Stack<byte> digits = new Stack<byte>();
                if (negative)
                {
                    value = value.Negate((value.BitCount + 7) / 4 * 4);
                    while (!value.IsZero)
                    {
                        NativeUnsignedInteger updated_value;
                        byte digit = base_number_info.GetLeastSignificantDigitFromIntegerPart(value, out updated_value);
                        value = updated_value;
                        digits.Push(digit);
                    }
                    while (digits.Count >= 2)
                    {
                        byte data1 = digits.Pop();
                        if (data1 != 15 || digits.Peek() < 8)
                        {
                            digits.Push(data1);
                            break;
                        }
                    }
                    _digits = digits.ToArray();
                    _most_significant_padding_digit = 15;
                }
                else
                {
                    byte most_significant_digit = 0;
                    while (!value.IsZero)
                    {
                        NativeUnsignedInteger updated_value;
                        byte digit = base_number_info.GetLeastSignificantDigitFromIntegerPart(value, out updated_value);
                        value = updated_value;
                        digits.Push(digit);
                        most_significant_digit = digit;
                    }
                    if (most_significant_digit >= 8)
                        digits.Push(0);
                    _digits = digits.ToArray();
                    _most_significant_padding_digit = 0;
                }
            }

            #endregion

            #region IParserOfNumber メンバ

            int IParserOfNumber.Offset
            {
                get
                {
                    return (_digits.Length);
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
                    return (_most_significant_padding_digit);
                }
            }

            #endregion

        }

        #endregion

        #region ParserOfRationalNumber クラスの定義

        private class ParserOfRationalNumber
            : IParserOfNumber
        {
            #region プライベートフィールド

            private IBaseNumberInfo _base_number_info;
            private byte[] _integer_part_digits;
            private NativeUnsignedInteger _fraction_part_numerator;
            private NativeUnsignedInteger _fraction_part_denominator;

            #endregion

            #region コンストラクタ

            public ParserOfRationalNumber(IBaseNumberInfo base_number_info, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator)
            {
                _base_number_info = base_number_info;
                if (value_numerator.IsZero)
                {
                    _integer_part_digits = new byte[] { 0 };
                    _fraction_part_numerator = NativeUnsignedInteger.Zero;
                    _fraction_part_denominator = NativeUnsignedInteger.One;
                }
                else
                {
                    NativeUnsignedInteger integer_part;
                    if (value_denominator == null)
                    {
                        _integer_part_digits = new byte[] { 0 };
                        integer_part = value_numerator;
                        _fraction_part_numerator = NativeUnsignedInteger.Zero;
                        _fraction_part_denominator = NativeUnsignedInteger.One;
                    }
                    else
                    {
                        _integer_part_digits = new byte[] { 0 };
                        integer_part = value_numerator.DivRem(value_denominator, out _fraction_part_numerator);
                        _fraction_part_denominator = value_denominator;
                    }
                    Stack<byte> integer_part_digits = new Stack<byte>();
                    while (!integer_part.IsZero)
                    {
                        NativeUnsignedInteger updated_integer_part;
                        byte digit = _base_number_info.GetLeastSignificantDigitFromIntegerPart(integer_part, out updated_integer_part);
                        integer_part_digits.Push(digit);
                        integer_part = updated_integer_part;
                    }
                    _integer_part_digits = integer_part_digits.ToArray();
                }
            }

            #endregion

            #region IParserOfNumber メンバ

            int IParserOfNumber.Offset
            {
                get
                {
                    return (_integer_part_digits.Length);
                }
            }

            bool IParserOfNumber.IsLimittedDigits
            {
                get
                {
                    return (false);
                }
            }

            INumberSequence IParserOfNumber.NumberSequence
            {
                get
                {
                    return (new NumberSequence(_integer_part_digits, _fraction_part_numerator, _fraction_part_denominator, _base_number_info));
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
                    return (0);
                }
            }

            #endregion
        }

        #endregion

        #region StandardNumericFormatStringInfo の定義

        private class StandardNumericFormatStringInfo
        {
            #region プライベートフィールド

            private char _format_type;
            private ushort? _precision;
            private bool _is_infinite_precision;
            private bool _not_specified_precision;

            #endregion

            #region コンストラクタ

            private StandardNumericFormatStringInfo(char format_type, ushort? precision, bool not_specified_precision, bool is_infinite_precision)
            {
                _format_type = format_type;
                _precision = precision;
                _not_specified_precision = not_specified_precision;
                _is_infinite_precision = is_infinite_precision;
            }

            #endregion

            #region パブリックメソッド

            public static StandardNumericFormatStringInfo Parse(IFormattingTypeInfo format_type_info, string format)
            {
                if (format == null || format.Length == 0)
                    format = "G";
                char format_type = format[0];
                if (!format_type_info.IsValidFormatType(format_type))
                    return (null);
                string precision_string = format.Substring(1);
                if (precision_string.Length > 2)
                    return (null);
                if (precision_string.Length == 0)
                    return (new StandardNumericFormatStringInfo(format_type, null, true, false));
                if (precision_string == "*")
                    return (new StandardNumericFormatStringInfo(format_type, null, false, true));
                ushort precision;
                if (!ushort.TryParse(precision_string, NumberStyles.None, CultureInfo.InvariantCulture, out precision))
                    return (null);
                if (precision < 0 || precision > 99)
                    return (null);
                if ((format_type == 'G' || format_type == 'g') && precision == 0)
                    return (new StandardNumericFormatStringInfo(format_type, null, true, false));
                return (new StandardNumericFormatStringInfo(format_type, precision, false, false));
            }

            #endregion

            #region パブリックメソッド

            public ushort GetPrecision(IFormattingTypeInfo formatting_type_info, NumberFormatInfo number_format_info)
            {
                if (_not_specified_precision)
                    return (formatting_type_info.GetDefaultPrecision(_format_type, number_format_info));
                else
                    return (_precision.Value);
            }

            #endregion

            #region パブリックプロパティ

            public char FormatType
            {
                get
                {
                    return (_format_type);
                }
            }

            public bool IsInfinitePrecision
            {
                get
                {
                    return (_is_infinite_precision);
                }
            }

            public bool NotSpecifiedPrecision
            {
                get
                {
                    return (_not_specified_precision);
                }
            }

            #endregion

        }

        #endregion

        #region FormatterCreatorHandler の定義

        private delegate INumberFormatter FormatterCreatorHandler(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec);

        #endregion

        #region プライベートフィールド

        private IFormattingTypeInfo _formatting_type_info;
        private IBaseNumberInfo _decimal_base_number_info;
        private IBaseNumberInfo _upper_case_hexadecimal_base_number_info;
        private IBaseNumberInfo _lower_case_hexadecimal_base_number_info;
        private Dictionary<char, FormatterCreatorHandler> _handlers;

        #endregion

        #region コンストラクタ

        public FormatterCreatorBase()
        {
            _formatting_type_info = this;
            _decimal_base_number_info = DecimalBaseNumberInfo.DefaultInstance;
            _upper_case_hexadecimal_base_number_info = HexaDecimalBaseNumberInfo.DefaultInstanceUsingUpperCaseDigit;
            _lower_case_hexadecimal_base_number_info = HexaDecimalBaseNumberInfo.DefaultInstanceUsingLowerCaseDigit;
            _handlers = new Dictionary<char, FormatterCreatorHandler>();
            _handlers.Add('C', CreateFormatterOfC);
            _handlers.Add('c', CreateFormatterOfC);
            _handlers.Add('D', CreateFormatterOfD);
            _handlers.Add('d', CreateFormatterOfD);
            _handlers.Add('E', CreateFormatterOfE_UpperCase);
            _handlers.Add('e', CreateFormatterOfE_LowerCase);
            _handlers.Add('F', CreateFormatterOfF);
            _handlers.Add('f', CreateFormatterOfF);
            _handlers.Add('G', CreateFormatterOfG_UpperCase);
            _handlers.Add('g', CreateFormatterOfG_LowerCase);
            _handlers.Add('N', CreateFormatterOfN);
            _handlers.Add('n', CreateFormatterOfN);
            _handlers.Add('P', CreateFormatterOfP);
            _handlers.Add('p', CreateFormatterOfP);
            _handlers.Add('R', CreateFormatterOfR);
            _handlers.Add('r', CreateFormatterOfR);
            _handlers.Add('X', CreateFormatterOfX_UpperCase);
            _handlers.Add('x', CreateFormatterOfX_LowerCase);
        }

        #endregion

        #region パブリックメソッド

        public INumberFormatter CreateFormatter(string format, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value)
        {
            return (CreateFormatter(format, number_format_info, negative, value, null));
        }

        public INumberFormatter CreateFormatter(string format, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator)
        {
            if (value_denominator != null && value_denominator.IsOne)
                value_denominator = null;
            StandardNumericFormatStringInfo format_param = StandardNumericFormatStringInfo.Parse(_formatting_type_info, format);
            if (format_param == null)
                return (CreateCustomFormatter(format, number_format_info, negative, value_numerator, value_denominator));
            INumberFormatter result = null;
            if (_handlers.ContainsKey(format_param.FormatType) &&
                _formatting_type_info.IsValidFormatType(format_param.FormatType))
            {
                result = _handlers[format_param.FormatType](format_param, number_format_info, negative, value_numerator, value_denominator, FormatterSpecification.None);
            }
            if (result == null)
                throw (new ArgumentException(string.Format("未知の書式指定文字列\"{0}\"が与えられました。", format), "format"));
            return (result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out bool negative, out NativeUnsignedInteger numerator, out NativeUnsignedInteger denominator)
        {
            negative = false;
            NumberFormatInfo info = NumberFormatInfo.GetInstance(provider);
            IParserOfNumber parser = StringParser.CreateInstance(s, style, provider, out negative);
            if (parser == null)
            {
                numerator = NativeUnsignedInteger.Zero;
                denominator = NativeUnsignedInteger.One;
                return (false);
            }
            INumberSequence sequence = parser.NumberSequence;
            IBaseNumberInfo base_number_info = parser.BaseNumberInfo;
            if (base_number_info.Value == 16)
            {
                if (negative)
                {
                    numerator = NativeUnsignedInteger.Zero;
                    denominator = NativeUnsignedInteger.One;
                    return (false);
                }
                bool msb;
                int digits;
                TryParseImp(base_number_info, sequence, parser.Offset, out numerator, out denominator, out msb, out digits);
                if (msb && !numerator.IsZero)
                {
                    negative = true;
                    numerator =numerator.Negate(digits * 4);
                }
                return (true);
            }
            else
            {
                bool msb;
                int digits;
                TryParseImp(base_number_info, sequence, parser.Offset, out numerator, out denominator, out msb, out digits);
                if (numerator.IsZero)
                    negative = false;
                return (true);
            }
        }

        #endregion

        #region プロテクテッドメソッド

        protected virtual INumberFormatter CreateRoundTripFormatter(NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator)
        {
            return (null);
        }

        #endregion

        #region プロテクテッドプロパティ

        protected abstract string ValidFormatTypes { get; }
        protected abstract ushort DefaultPrecisionOfG { get; }

        #endregion

        #region プライベートメソッド

        private INumberFormatter CreateFormatterOfC(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
                return (null);
            ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
            IParserOfNumber parser = new ParserOfRationalNumber(_decimal_base_number_info, value_numerator, value_denominator);
            parser = new FilterWithSpecifiedLengthOfFractionPart(parser, precision);
            return (new FixedPointFormFormatter(parser, number_format_info, negative, true, NumberFormatType.Currency));
        }

        private INumberFormatter CreateFormatterOfD(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
                return (null);
            if (value_denominator != null)
                return (null);
            ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
            IParserOfNumber parser = new ParserOfRationalNumber(_decimal_base_number_info, value_numerator, null);
            parser = new FilterWithSpecifiedLengthOfIntegerPart(parser, precision);
            return (new FixedPointFormFormatter(parser, number_format_info, negative, false, NumberFormatType.Normal));
        }

        private INumberFormatter CreateFormatterOfE_UpperCase(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            return (CreateFormatterOfE(format_param, number_format_info, negative, value_numerator, value_denominator, formatter_spec | FormatterSpecification.UseUpperCase));
        }

        private INumberFormatter CreateFormatterOfE_LowerCase(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            return (CreateFormatterOfE(format_param, number_format_info, negative, value_numerator, value_denominator, formatter_spec));
        }

        private INumberFormatter CreateFormatterOfE(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
                return (null);
            ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
            IParserOfNumber parser = new ParserOfRationalNumber(_decimal_base_number_info, value_numerator, value_denominator);
            parser = new FilterWithSpecifiedSignificantFigures(parser, precision + 1, false);
            return (new ExponentialFormFormatter(parser, number_format_info, negative, formatter_spec, ExponentialFormFormatter.ExponentialPartDigits.Digits_3));
        }

        private INumberFormatter CreateFormatterOfF(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
            {
                // 無限精度のF形式変換を行う(value_denominatorは2および5以外の素因数を含んでいてはならない)
                IBaseNumberInfo base_number_info = _decimal_base_number_info;
                if (!base_number_info.IsRationalNumberRepresentableByFiniteDigits(value_denominator))
                    throw (new InvalidOperationException("小数部が無限に続く値に精度指定'*'を指定することはできません。"));
                IParserOfNumber parser = new ParserOfRationalNumber(base_number_info, value_numerator, value_denominator);
                return (new FixedPointFormFormatter(parser, number_format_info, negative, false, NumberFormatType.Normal));
            }
            else
            {
                ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
                IParserOfNumber parser = new ParserOfRationalNumber(_decimal_base_number_info, value_numerator, value_denominator);
                parser = new FilterWithSpecifiedLengthOfFractionPart(parser, precision);
                return (new FixedPointFormFormatter(parser, number_format_info, negative, false, NumberFormatType.Normal));
            }
        }

        private INumberFormatter CreateFormatterOfG_UpperCase(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            return (CreateFormatterOfG(format_param, number_format_info, negative, value_numerator, value_denominator, formatter_spec | FormatterSpecification.UseUpperCase));
        }

        private INumberFormatter CreateFormatterOfG_LowerCase(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            return (CreateFormatterOfG(format_param, number_format_info, negative, value_numerator, value_denominator, formatter_spec));
        }

        private INumberFormatter CreateFormatterOfG(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
                return (null);
            ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
            IParserOfNumber parser = new ParserOfRationalNumber(_decimal_base_number_info, value_numerator, value_denominator);
            parser = new FilterWithSpecifiedSignificantFigures(parser, precision, true);
            INumberFormatter formatter;
            if (parser.Offset >= -3 && parser.Offset <= precision)
                formatter = new FixedPointFormFormatter(parser, number_format_info, negative, false, NumberFormatType.Normal);
            else
                formatter = new ExponentialFormFormatter(parser, number_format_info, negative, formatter_spec, ExponentialFormFormatter.ExponentialPartDigits.Digits_2);
            return (formatter);
        }

#if false
        private INumberFormatter CreateFormatterOfG(StandardNumericFormatStringInfo format_param , NumberFormatInfo number_format_info, bool negative, ushort[] value_numerator, ushort[] value_denominator, FormatterSpecification formatter_spec)
        {
            if (precision <= 0)
                precision = 20;
            IParserOfNumber parser = new ParserOfInteger(_decimal_base_number_info, value);
            parser = new FilterWithSpecifiedSignificantFigures(parser, precision, true);
            INumberFormatter formatter;
            if (precision < parser.Offset)
                formatter = new ExponentialFormFormatter(parser, info, false, upper_case, ExponentialFormFormatter.ExponentialPartDigits.Digits_2);
            else
                formatter = new FixedPointFormFormatter(parser, info, false, false, NumberFormatType.Normal);
            return (formatter);
        }
#endif

        private INumberFormatter CreateFormatterOfN(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
            {
                // 無限精度のN形式変換を行う(value_denominatorは2および5以外の素因数を含んでいてはならない)
                IBaseNumberInfo base_number_info = _decimal_base_number_info;
                if (!base_number_info.IsRationalNumberRepresentableByFiniteDigits(value_denominator))
                    throw (new InvalidOperationException("小数部が無限に続く値に精度指定'*'を指定することはできません。"));
                IParserOfNumber parser = new ParserOfRationalNumber(base_number_info, value_numerator, value_denominator);
                return (new FixedPointFormFormatter(parser, number_format_info, negative, true, NumberFormatType.Normal));
            }
            else
            {
                ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
                IParserOfNumber parser = new ParserOfRationalNumber(_decimal_base_number_info, value_numerator, value_denominator);
                parser = new FilterWithSpecifiedLengthOfFractionPart(parser, precision);
                return (new FixedPointFormFormatter(parser, number_format_info, negative, true, NumberFormatType.Normal));
            }
        }

#if false
        private INumberFormatter CreateFormatterOfN(StandardNumericFormatStringInfo format_param , NumberFormatInfo number_format_info, bool negative, ushort[] value_numerator, ushort[] value_denominator, FormatterSpecification formatter_spec)
        {
            if (precision < 0)
                precision = info.NumberDecimalDigits;
            IParserOfNumber parser = new ParserOfInteger(_decimal_base_number_info, value);
            parser = new FilterWithSpecifiedLengthOfFractionPart(parser, precision);
            return (new FixedPointFormFormatter(parser, info, false, true, NumberFormatType.Normal));
        }
#endif

        private INumberFormatter CreateFormatterOfP(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
                return (null);
            MultiplyQuick100(ref value_numerator, ref value_denominator);
            ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
            IParserOfNumber parser = new ParserOfRationalNumber(_decimal_base_number_info, value_numerator, value_denominator);
            parser = new FilterWithSpecifiedLengthOfFractionPart(parser, precision);
            return (new FixedPointFormFormatter(parser, number_format_info, negative, true, NumberFormatType.Percent));
        }

        private INumberFormatter CreateFormatterOfR(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
                return (null);
            return (CreateRoundTripFormatter(number_format_info, negative, value_numerator, value_denominator));
        }

        private INumberFormatter CreateFormatterOfX_UpperCase(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            return (CreateFormatterOfX(format_param, number_format_info, negative, value_numerator, value_denominator, formatter_spec | FormatterSpecification.UseUpperCase));
        }

        private INumberFormatter CreateFormatterOfX_LowerCase(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            return (CreateFormatterOfX(format_param, number_format_info, negative, value_numerator, value_denominator, formatter_spec));
        }

        private INumberFormatter CreateFormatterOfX(StandardNumericFormatStringInfo format_param, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator, FormatterSpecification formatter_spec)
        {
            if (format_param.IsInfinitePrecision)
                return (null);
            if (value_denominator != null)
                return (null);
            ushort precision = format_param.GetPrecision(_formatting_type_info, number_format_info);
            IParserOfNumber parser = new ParserOfHexaDecimalInteger((formatter_spec & FormatterSpecification.UseUpperCase) != 0 ? _upper_case_hexadecimal_base_number_info : _lower_case_hexadecimal_base_number_info, negative, value_numerator);
            parser = new FilterWithSpecifiedLengthOfIntegerPart(parser, precision);
            return (new FixedPointFormFormatter(parser, number_format_info, false, false, NumberFormatType.Normal));
        }

        private INumberFormatter CreateCustomFormatter(string format, NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator)
        {
            throw (new ArgumentException(string.Format("未知の書式指定文字列\"{0}\"が与えられました。", format), "format"));
        }

        private static void TryParseImp(IBaseNumberInfo base_number_info, INumberSequence sequence, int exp, out NativeUnsignedInteger numerator, out NativeUnsignedInteger denominator, out bool msb, out int digits)
        {
            numerator = NativeUnsignedInteger.Zero;
            denominator = NativeUnsignedInteger.One;
            msb = false;
            digits = 0;/*numeratorに返される数値の桁数*/
            int least_ZEROs = 0;
            bool is_first = true;
            while (!sequence.IsZero)
            {
                byte digit = sequence.GetDigit();
                if (is_first)
                {
                    if (base_number_info.Value == 16 && digit >= 8)
                        msb = true;
                    is_first = false;
                }
                if (digit == 0)
                    ++least_ZEROs;
                else
                {
                    while (least_ZEROs > 0)
                    {
                        numerator = base_number_info.Multiply(numerator);
                        --least_ZEROs;
                        ++digits;
                    }
                    numerator = base_number_info.MultiplyAndAdd(numerator, digit);
                    ++digits;
                }
            }
            if (!numerator.IsZero)
            {
                int e = exp - digits;
                while (e > 0)
                {
                    numerator = base_number_info.Multiply(numerator);
                    ++digits;
                    --e;
                }
                while (e < 0)
                {
                    denominator = base_number_info.Multiply(denominator);
                    ++e;
                }
            }
        }

        private void MultiplyQuick100(ref NativeUnsignedInteger value_numerator, ref NativeUnsignedInteger value_denominator)
        {
            if (value_denominator == null)
            {
                if (!value_numerator.IsZero)
                    value_numerator = value_numerator.Multiply(100);
            }
            else
            {
                if (value_denominator.IsZero)
                    throw new ApplicationException();
                Debug.Assert(!value_numerator.IsZero);
                uint n = 1;
                if (!value_denominator.IsEven)
                    n *= 4;
                else
                {
                    value_denominator = value_denominator.RightShift1Quick();
                    if (!value_denominator.IsEven)
                        n *= 2;
                    else
                        value_denominator = value_denominator.RightShift1Quick();
                }
                uint r;
                var q = value_denominator.DivRem(5, out r);
                if (r != 0)
                    n *= 25;
                else
                {
                    value_denominator = q;
                    q = value_denominator.DivRem(5, out r);
                    if (r != 0)
                        n *= 5;
                    else
                        value_denominator = q;
                }
                Debug.Assert(n <= 100);
                value_numerator = value_numerator.Multiply(n);
                if (value_denominator.IsOne)
                    value_denominator = null;
            }
        }

        #endregion

        #region IFormattingTypeInfo のメンバ

        bool IFormattingTypeInfo.IsValidFormatType(char format_type)
        {
            return (ValidFormatTypes.IndexOf(char.ToUpper(format_type)) >= 0);
        }

        ushort IFormattingTypeInfo.GetDefaultPrecision(char format_type, NumberFormatInfo number_format_info)
        {
            switch (char.ToUpper(format_type))
            {
                case 'C':
                    return ((ushort)number_format_info.CurrencyDecimalDigits);
                case 'D':
                    return (0);
                case 'E':
                    return (6);
                case 'F':
                    return ((ushort)number_format_info.NumberDecimalDigits);
                case 'G':
                    return (DefaultPrecisionOfG);
                case 'N':
                    return ((ushort)number_format_info.NumberDecimalDigits);
                case 'P':
                    return ((ushort)number_format_info.PercentDecimalDigits);
                case 'X':
                    return (0);
                default:
                    throw (new FormatException("書式文字列の形式に誤りがあります。"));
            }
        }

        #endregion
    }

}
