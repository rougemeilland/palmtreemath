/*
  RationalNumber.Formatters.cs

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
        : IFormattable
    {
        #region FormatterCreator の定義

        private class FormatterCreator
            : FormatterCreatorBase
        {
            #region コンストラクタ

            public FormatterCreator()
            {
            }

            #endregion

            #region FormattingTypeInfoBase から継承されたメンバ

            protected override string ValidFormatTypes
            {
                get
                {
                    return ("CEFGNPR");
                }
            }

            protected override ushort DefaultPrecisionOfG
            {
                get
                {
                    return (30);
                }
            }

            protected override INumberFormatter CreateRoundTripFormatter(NumberFormatInfo number_format_info, bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator)
            {
                return (new RationalNumberRoundTripFormatter(negative, value_numerator, value_denominator));
            }

            #endregion
        }

        #endregion

        #region パブリックメソッド

        /// <summary>
        /// <see cref="LongLongInteger"/>オブジェクトを文字列形式に変換します。
        /// </summary>
        /// <param name="format">
        /// 変換に使用する書式指定文字列です。
        /// </param>
        /// <returns>
        /// <see cref="LongLongInteger"/>オブジェクトの文字列形式です。
        /// </returns>
        public string ToString(string format)
        {
            return (ToString(format, null));
        }

        /// <summary>
        /// 指定した書式およびカルチャに固有の書式情報を使用して、このインスタンスの数値をそれと等価な文字列形式に変換します。
        /// </summary>
        /// <param name="provider">
        /// カルチャ固有の書式情報を提供するプロバイダです。
        /// </param>
        /// <returns>
        /// 変換された文字列です。
        /// </returns>
        public string ToString(IFormatProvider provider)
        {
            return (ToString("G", provider));
        }

        #endregion

        #region IFormattable メンバ

        /// <summary>
        /// 指定した書式およびカルチャに固有の書式情報を使用して、このインスタンスの数値をそれと等価な文字列形式に変換します。
        /// </summary>
        /// <param name="format">
        /// 書式を表す文字列です。
        /// </param>
        /// <param name="provider">
        /// カルチャ固有の書式情報を提供するプロバイダです。
        /// </param>
        /// <returns>
        /// 変換された文字列です。
        /// </returns>
        public string ToString(string format, IFormatProvider provider)
        {
#if false
            if (string.IsNullOrEmpty(format))
                format = "G";
            Debug.Assert(format.Length >= 1);
            if (string.Equals(format, "R") || string.Equals(format, "r"))
                return (string.Format(provider, "{0:R}/{1:R}", _InternalNumerator, _InternalDenominator));
            char format_spec = format[0];
            int precision = -1;// 既定は精度指定なし
            if (format.Length >= 2)
            {
                string precision_string = format.Substring(1);
                if (precision_string == "*")
                    precision = -2;// 無限精度指定
                else if (!int.TryParse(precision_string, NumberStyles.None, provider, out precision))
                    throw (new FormatException("書式指定文字列の形式に誤りがあります。"));
            }
#endif
            CultureInfo culture = provider as CultureInfo;
            if (culture == null)
                culture = CultureInfo.CurrentCulture;
            NumberFormatInfo number_format_info = NumberFormatInfo.GetInstance(culture);
            INumberFormatter formatter = _formatter_creator.CreateFormatter(format, number_format_info, _InternalNumerator.InternalSign == SignType.Negative, _InternalNumerator.Abs().GetInternalValue(), _InternalDenominator.GetInternalValue());
            return (formatter.Format());
        }

        #endregion
    }
}
