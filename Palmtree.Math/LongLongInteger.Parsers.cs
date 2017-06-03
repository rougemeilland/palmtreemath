/*
  LongLongInteger.Parsers.cs

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
    partial struct LongLongInteger
    {
        #region パブリックメソッド

        /// <summary>
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="LongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <returns>
        /// 変換された<see cref="LongLongInteger"/>オブジェクトです。
        /// </returns>
        public static LongLongInteger Parse(string s)
        {
            return (Parse(s, NumberStyles.Integer, null));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="LongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="provider">
        /// sに関するカルチャに固有の書式情報を提供する<see cref="System.IFormatProvider"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換された<see cref="LongLongInteger"/>オブジェクトです。
        /// </returns>
        public static LongLongInteger Parse(string s, IFormatProvider provider)
        {
            return (Parse(s, NumberStyles.Integer, provider));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="LongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="style">
        /// sで使用可能な書式を示す、<see cref="System.Globalization.NumberStyles"/>値のビットごとの組み合わせです。
        /// 通常指定する値は、<see cref="System.Globalization.NumberStyles.Integer"/>です。
        /// </param>
        /// <returns>
        /// 変換された<see cref="LongLongInteger"/>オブジェクトです。
        /// </returns>
        public static LongLongInteger Parse(string s, NumberStyles style)
        {
            return (Parse(s, style, null));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="LongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="style">
        /// sで使用可能な書式を示す、<see cref="System.Globalization.NumberStyles"/>値のビットごとの組み合わせです。
        /// 通常指定する値は、<see cref="System.Globalization.NumberStyles.Integer"/>です。
        /// </param>
        /// <param name="provider">
        /// sに関するカルチャに固有の書式情報を提供する<see cref="System.IFormatProvider"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換された<see cref="LongLongInteger"/>オブジェクトです。
        /// </returns>
        public static LongLongInteger Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            LongLongInteger value;
            if (!TryParse(s, style, provider, out value))
                throw (new FormatException(string.Format("文字列\"{0}\"が正しいLongLongIntegerの書式ではありません。", s)));
            return (value);
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="LongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="result">
        /// 変換に成功した場合、変換された<see cref="LongLongInteger"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換に成功した場合はtrue、そうではないのならfalseです。
        /// </returns>
        public static bool TryParse(string s, out LongLongInteger result)
        {
            return (TryParse(s, NumberStyles.Integer, null, out result));
        }

        /// <summary>
        /// 指定したスタイルおよびカルチャに固有の書式による数値の文字列形式を、それと等価の<see cref="LongLongInteger"/>オブジェクトに変換します。
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
        /// 変換が成功した場合、このメソッドが返されるときに、sに格納された数値と等価の<see cref="LongLongInteger"/>オブジェクトを格納します。
        /// 変換に失敗した場合はnullを格納します。
        /// </param>
        /// <returns>
        /// sが正常に変換された場合はtrue、そうではない場合はfalseです。
        /// </returns>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out LongLongInteger result)
        {
            result = LongLongInteger.Zero;
            SignType sign;
            UnsignedLongLongInteger abs;
            if (!TryParseImp(s, style, provider, out sign, out abs))
                return (false);
            result = new LongLongInteger(sign, abs);
            return (true);
        }

        #endregion

        #region プライベートメソッド

        private static bool TryParseImp(string s, NumberStyles style, IFormatProvider provider, out SignType sign, out UnsignedLongLongInteger abs)
        {
            sign = SignType.Zero;
            abs = UnsignedLongLongInteger.Zero;
            bool negative;
            NativeUnsignedInteger numerator_imp;
            NativeUnsignedInteger denominator_imp;
            if (!FormatterCreatorBase.TryParse(s, style, provider, out negative, out numerator_imp, out denominator_imp))
                return (false);
            if (!denominator_imp.IsOne)
                return (false);
            if (numerator_imp.IsZero)
            {
            }
            else if (negative)
            {
                sign = SignType.Negative;
                abs = new UnsignedLongLongInteger(numerator_imp);
            }
            else
            {
                sign = SignType.Positive;
                abs = new UnsignedLongLongInteger(numerator_imp);
            }
            return (true);
        }

        #endregion
    }
}