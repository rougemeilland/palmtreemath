/*
  UnsignedLongLongInteger.Parsers.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Globalization;
using Palmtree.Math.Formatter;

namespace Palmtree.Math
{
    partial struct UnsignedLongLongInteger
    {
        #region パブリックメソッド

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="UnsignedLongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <returns>
        /// 変換された<see cref="UnsignedLongLongInteger"/>オブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s)
        {
            return (Parse(s, NumberStyles.Integer, null));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="UnsignedLongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="provider">
        /// sに関するカルチャに固有の書式情報を提供する<see cref="System.IFormatProvider"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換された<see cref="UnsignedLongLongInteger"/>オブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s, IFormatProvider provider)
        {
            return (Parse(s, NumberStyles.Integer, provider));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="UnsignedLongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="style">
        /// sで使用可能な書式を示す、<see cref="System.Globalization.NumberStyles"/>値のビットごとの組み合わせです。
        /// 通常指定する値は、<see cref="System.Globalization.NumberStyles.Integer"/>です。
        /// </param>
        /// <returns>
        /// 変換された<see cref="UnsignedLongLongInteger"/>オブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s, NumberStyles style)
        {
            return (Parse(s, style, null));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="UnsignedLongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="style">
        /// sで使用可能な書式を示す、<see cref="System.Globalization.NumberStyles"/>値のビットごとの組み合わせです。
        /// 通常指定する値は、<see cref="System.Globalization.NumberStyles.Integer"/>です。
        /// </param>
        /// <param name="provider">
        /// sに関するカルチャに固有の書式情報を提供する<see cref="System.IFormatProvider"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換された<see cref="UnsignedLongLongInteger"/>オブジェクトです。
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            UnsignedLongLongInteger value;
            if (!TryParse(s, style, provider, out value))
                throw (new FormatException(string.Format("文字列\"{0}\"が正しいUnsignedLongLongIntegerの書式ではありません。", s)));
            return (value);
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式をそれと等価な<see cref="UnsignedLongLongInteger"/>オブジェクトに変換します。
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式です。
        /// </param>
        /// <param name="result">
        /// 変換に成功した場合、変換された<see cref="UnsignedLongLongInteger"/>オブジェクトです。
        /// </param>
        /// <returns>
        /// 変換に成功した場合はtrue、そうではないのならfalseです。
        /// </returns>
        public static bool TryParse(string s, out UnsignedLongLongInteger result)
        {
            return (TryParse(s, NumberStyles.Integer, null, out result));
        }

        /// <summary>
        /// 指定したスタイルおよびカルチャに固有の書式による数値の文字列形式を、それと等価の<see cref="UnsignedLongLongInteger"/>オブジェクトに変換します。
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
        /// 変換が成功した場合、このメソッドが返されるときに、sに格納された数値と等価の<see cref="UnsignedLongLongInteger"/>オブジェクトを格納します。
        /// 変換に失敗した場合はnullを格納します。
        /// </param>
        /// <returns>
        /// sが正常に変換された場合はtrue、そうではない場合はfalseです。
        /// </returns>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out UnsignedLongLongInteger result)
        {
            result = UnsignedLongLongInteger.Zero;
            ushort[] imp;
            if (!TryParseImp(s, style, provider, out imp))
                return (false);
            result = new UnsignedLongLongInteger(imp);
            return (true);
        }

        #endregion

        #region プライベートメソッド

        private static bool TryParseImp(string s, NumberStyles style, IFormatProvider provider, out ushort[] result)
        {
            result = new ushort[0];
            bool negative;
            ushort[] numerator_imp;
            ushort[] denominator_imp;
            if (!FormatterCreatorBase.TryParse(s, style, provider, out negative, out numerator_imp, out denominator_imp))
                return (false);
            if (negative)
                return (false);
            if (denominator_imp.Length != 1 || denominator_imp[0] != 1)
                return (false);
            result = numerator_imp;
            return (true);
        }

        #endregion
    }
}
