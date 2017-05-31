/*
  RationalNumber.Formatters.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Globalization;
using Palmtree.Math.Formatter;

namespace Palmtree.Math
{
    partial struct RationalNumber
        : IFormattable
    {
        #region FormatterCreator �̒�`

        private class FormatterCreator
            : FormatterCreatorBase
        {
            #region �R���X�g���N�^

            public FormatterCreator()
            {
            }

            #endregion

            #region FormattingTypeInfoBase ����p�����ꂽ�����o

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

            protected override INumberFormatter CreateRoundTripFormatter(NumberFormatInfo number_format_info, bool negative, ushort[] value_numerator, ushort[] value_denominator)
            {
                return (new RationalNumberRoundTripFormatter(negative, value_numerator, value_denominator));
            }

            #endregion
        }

        #endregion

        #region �p�u���b�N���\�b�h

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𕶎���`���ɕϊ����܂��B
        /// </summary>
        /// <param name="format">
        /// �ϊ��Ɏg�p���鏑���w�蕶����ł��B
        /// </param>
        /// <returns>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </returns>
        public string ToString(string format)
        {
            return (ToString(format, null));
        }

        /// <summary>
        /// �w�肵����������уJ���`���ɌŗL�̏�������g�p���āA���̃C���X�^���X�̐��l�����Ɠ����ȕ�����`���ɕϊ����܂��B
        /// </summary>
        /// <param name="provider">
        /// �J���`���ŗL�̏�������񋟂���v���o�C�_�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ������ł��B
        /// </returns>
        public string ToString(IFormatProvider provider)
        {
            return (ToString("G", provider));
        }

        #endregion

        #region IFormattable �����o

        /// <summary>
        /// �w�肵����������уJ���`���ɌŗL�̏�������g�p���āA���̃C���X�^���X�̐��l�����Ɠ����ȕ�����`���ɕϊ����܂��B
        /// </summary>
        /// <param name="format">
        /// ������\��������ł��B
        /// </param>
        /// <param name="provider">
        /// �J���`���ŗL�̏�������񋟂���v���o�C�_�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ������ł��B
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
            int precision = -1;// ����͐��x�w��Ȃ�
            if (format.Length >= 2)
            {
                string precision_string = format.Substring(1);
                if (precision_string == "*")
                    precision = -2;// �������x�w��
                else if (!int.TryParse(precision_string, NumberStyles.None, provider, out precision))
                    throw (new FormatException("�����w�蕶����̌`���Ɍ�肪����܂��B"));
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
