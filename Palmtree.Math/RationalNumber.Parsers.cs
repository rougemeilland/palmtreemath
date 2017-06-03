/*
  RationalNumber.Parsers.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Globalization;
using Palmtree.Math.Formatter;
using Palmtree.Math.Implements;

namespace Palmtree.Math
{
    partial struct RationalNumber
    {
        #region パブリックメソッド

        /// <summary>
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式をそれと等価な<see cref="RationalNumber"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式です。
        /// </param>
        /// <returns>
        /// 変換された<see cref="RationalNumber"/>オブジェクトです。
        /// </returns>
        public static RationalNumber Parse(string s)
        {
            return (Parse(s, NumberStyles.Number, null));
        }

        /// <summary>
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式をそれと等価な<see cref="RationalNumber"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="provider">
        /// sに関するカルチャに固有の書式情報を提供する<see cref="System.IFormatProvider"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換された<see cref="RationalNumber"/>オブジェクトです。
        /// </returns>
        public static RationalNumber Parse(string s, IFormatProvider provider)
        {
            return (Parse(s, NumberStyles.Number, provider));
        }

        /// <summary>
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式をそれと等価な<see cref="RationalNumber"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="style">
        /// sで使用可能な書式を示す、<see cref="System.Globalization.NumberStyles"/>値のビットごとの組み合わせです。
        /// 通常指定する値は、<see cref="System.Globalization.NumberStyles.Integer"/>です。
        /// </param>
        /// <returns>
        /// 変換された<see cref="RationalNumber"/>オブジェクトです。
        /// </returns>
        public static RationalNumber Parse(string s, NumberStyles style)
        {
            return (Parse(s, style, null));
        }

        /// <summary>
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式をそれと等価な<see cref="RationalNumber"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="style">
        /// sで使用可能な書式を示す、<see cref="System.Globalization.NumberStyles"/>値のビットごとの組み合わせです。
        /// 通常指定する値は、<see cref="System.Globalization.NumberStyles.Integer"/>です。
        /// </param>
        /// <param name="provider">
        /// sに関するカルチャに固有の書式情報を提供する<see cref="System.IFormatProvider"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換された<see cref="RationalNumber"/>オブジェクトです。
        /// </returns>
        public static RationalNumber Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            RationalNumber value;
            if (!TryParse(s, style, provider, out value))
                throw (new FormatException(string.Format("文字列\"{0}\"が正しいFractionの書式ではありません。", s)));
            return (value);
        }

        /// <summary>
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式をそれと等価な<see cref="RationalNumber"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="result">
        /// 変換に成功した場合、変換された<see cref="RationalNumber"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換に成功した場合はtrue、そうではないのならfalseです。
        /// </returns>
        public static bool TryParse(string s, out RationalNumber result)
        {
            return (TryParse(s, NumberStyles.Number, null, out result));
        }

        /// <summary>
        /// 指定したスタイルおよびカルチャに固有の書式による数値の文字列形式を、それと等価の<see cref="RationalNumber"/>オブジェクトに変換します。
        /// 戻り値は、変換が成功したか失敗したかを示します。
        /// </summary>
        /// <param name="s">
        /// 変換する数値を格納している文字列です。
        /// </param>
        /// <param name="style">
        /// sで使用可能な書式を示す、<see cref="System.Globalization.NumberStyles"/>値のビットごとの組み合わせです。
        /// 通常指定する値は、<see cref="System.Globalization.NumberStyles.Integer"/>です。
        /// </param>
        /// <param name="provider">
        /// sに関するカルチャに固有の書式情報を提供する<see cref="System.IFormatProvider"/>オブジェクトです。
        /// </param>
        /// <param name="result">
        /// 変換が成功した場合、このメソッドが返されるときに、sに格納された数値と等価の<see cref="RationalNumber"/>オブジェクトを格納します。
        /// 変換に失敗した場合はnullを格納します。
        /// </param>
        /// <returns>
        /// sが正常に変換された場合はtrue、そうではない場合はfalseです。
        /// </returns>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out RationalNumber result)
        {
            result = RationalNumber.Zero;
            LongLongInteger numerator;
            UnsignedLongLongInteger denominator;
            if (!TryParseImp(s, style, provider, out numerator, out denominator))
                return (false);
            result = new RationalNumber(numerator, denominator);
            return (true);
        }

        #endregion

        #region プライベートメソッド

        private static bool TryParseImp(string s, NumberStyles style, IFormatProvider provider, out LongLongInteger numerator, out UnsignedLongLongInteger denominator)
        {
            if ((style & NumberStyles.AllowHexSpecifier) != 0)
                throw (new ArgumentException("文字列をRationalNumberオブジェクトに変換する際にNumberStyles.AllowHexSpecifierフラグは指定できません。"));
            if (s.IndexOf('[') >= 0)
                return (TryParseRoundTripFormat(s, style, out numerator, out denominator));
            else
                return (TryParseNormalFormat(s, style, provider, out numerator, out denominator));
        }

        private static bool TryParseRoundTripFormat(string s, NumberStyles style, out LongLongInteger numerator, out UnsignedLongLongInteger denominator)
        {
            IFormatProvider provider = CultureInfo.InvariantCulture;
            numerator = LongLongInteger.Zero;
            denominator = UnsignedLongLongInteger.Zero;
            int index_of_parenthesis_open = SkipSpace(s, 0, style);
            if (index_of_parenthesis_open >= s.Length || s[index_of_parenthesis_open] != '[')
                return (false);
            int index_of_column = s.IndexOf(':', index_of_parenthesis_open + 1);
            if (index_of_column < 0)
                return (false);
            int index_of_parenthesis_close = s.IndexOf(']', index_of_column + 1);
            if (index_of_parenthesis_close < 0)
                return (false);
            int index_of_end = SkipSpace(s, index_of_parenthesis_close + 1, style);
            if (index_of_end != s.Length)
                return (false);
            string numerator_s = s.Substring(index_of_parenthesis_open + 1, index_of_column - index_of_parenthesis_open - 1);
            string denominator_s = s.Substring(index_of_column + 1, index_of_parenthesis_close - index_of_column - 1);
            if (!LongLongInteger.TryParse(numerator_s, style & NumberStyles.AllowLeadingSign, provider, out numerator))
                return (false);
            if (!UnsignedLongLongInteger.TryParse(denominator_s, NumberStyles.None, provider, out denominator))
                return (false);
            return (true);
        }

        private static int SkipSpace(string s, int index, NumberStyles style)
        {
            if ((style & NumberStyles.AllowLeadingWhite) != 0)
            {
                while (index < s.Length && char.IsWhiteSpace(s, index))
                    ++index;
            }
            return (index);
        }

        private static bool TryParseNormalFormat(string s, NumberStyles style, IFormatProvider provider, out LongLongInteger numerator, out UnsignedLongLongInteger denominator)
        {
            numerator = LongLongInteger.Zero;
            denominator = UnsignedLongLongInteger.One;
            bool negative;
            NativeUnsignedInteger numerator_imp;
            NativeUnsignedInteger denominator_imp;
            if (!FormatterCreatorBase.TryParse(s, style, provider, out negative, out numerator_imp, out denominator_imp))
                return (false);
            UnsignedLongLongInteger numerator_abs = new UnsignedLongLongInteger(numerator_imp);
            numerator = new LongLongInteger(negative ? SignType.Negative : SignType.Positive, numerator_abs);
            denominator = new UnsignedLongLongInteger(denominator_imp);
            return (true);
        }

        #endregion
    }
}