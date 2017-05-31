/*
  UnsignedLongLongInteger.Formatters.cs

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
                    return ("CDEFGNPXR");
                }
            }

            protected override ushort DefaultPrecisionOfG
            {
                get
                {
                    return (30);
                }
            }

            protected override INumberFormatter CreateRoundTripFormatter(NumberFormatInfo number_format_info, bool negative, ushort[] value_numerator, ushort[] value_denominator)
            {
                return (new IntegerRoundTripFormatter(negative, value_numerator));
            }

            #endregion
        }

        #endregion

        #region パブリックメソッド

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトを文字列形式に変換します。
        /// </summary>
        /// <param name="format">
        /// 変換に使用する書式指定文字列です。
        /// </param>
        /// <returns>
        /// <see cref="UnsignedLongLongInteger"/>オブジェクトの文字列形式です。
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
            CultureInfo culture = provider as CultureInfo;
            if (culture == null)
                culture = CultureInfo.CurrentCulture;
            NumberFormatInfo number_format_info = NumberFormatInfo.GetInstance(culture);
            try
            {
                INumberFormatter formatter = _formatter_creator.CreateFormatter(format, number_format_info, false, _InternalValue);
                if (formatter == null)
                    throw (new FormatException(string.Format("書式文字列'{0}'の形式に誤りがあります。", format)));
                return (formatter.Format());
            }
            catch (FormatException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw (new FormatException(string.Format("書式文字列'{0}'の形式に誤りがあります。", format), e));
            }
        }

        #endregion
    }
}
