/*
  RationalNumber.Parsers.cs

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
    {
        #region �p�u���b�N���\�b�h

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="RationalNumber"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="RationalNumber"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber Parse(string s)
        {
            return (Parse(s, NumberStyles.Number, null));
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="RationalNumber"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="provider">
        /// s�Ɋւ���J���`���ɌŗL�̏�������񋟂���<see cref="System.IFormatProvider"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="RationalNumber"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber Parse(string s, IFormatProvider provider)
        {
            return (Parse(s, NumberStyles.Number, provider));
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="RationalNumber"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="style">
        /// s�Ŏg�p�\�ȏ���������A<see cref="System.Globalization.NumberStyles"/>�l�̃r�b�g���Ƃ̑g�ݍ��킹�ł��B
        /// �ʏ�w�肷��l�́A<see cref="System.Globalization.NumberStyles.Integer"/>�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="RationalNumber"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber Parse(string s, NumberStyles style)
        {
            return (Parse(s, style, null));
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="RationalNumber"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="style">
        /// s�Ŏg�p�\�ȏ���������A<see cref="System.Globalization.NumberStyles"/>�l�̃r�b�g���Ƃ̑g�ݍ��킹�ł��B
        /// �ʏ�w�肷��l�́A<see cref="System.Globalization.NumberStyles.Integer"/>�ł��B
        /// </param>
        /// <param name="provider">
        /// s�Ɋւ���J���`���ɌŗL�̏�������񋟂���<see cref="System.IFormatProvider"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="RationalNumber"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            RationalNumber value;
            if (!TryParse(s, style, provider, out value))
                throw (new FormatException(string.Format("������\"{0}\"��������Fraction�̏����ł͂���܂���B", s)));
            return (value);
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="RationalNumber"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="result">
        /// �ϊ��ɐ��������ꍇ�A�ϊ����ꂽ<see cref="RationalNumber"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ��ɐ��������ꍇ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool TryParse(string s, out RationalNumber result)
        {
            return (TryParse(s, NumberStyles.Number, null, out result));
        }

        /// <summary>
        /// �w�肵���X�^�C������уJ���`���ɌŗL�̏����ɂ�鐔�l�̕�����`����A����Ɠ�����<see cref="RationalNumber"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// �߂�l�́A�ϊ����������������s������������܂��B
        /// </summary>
        /// <param name="s">
        /// �ϊ����鐔�l��i�[���Ă��镶����ł��B
        /// </param>
        /// <param name="style">
        /// s�Ŏg�p�\�ȏ���������A<see cref="System.Globalization.NumberStyles"/>�l�̃r�b�g���Ƃ̑g�ݍ��킹�ł��B
        /// �ʏ�w�肷��l�́A<see cref="System.Globalization.NumberStyles.Integer"/>�ł��B
        /// </param>
        /// <param name="provider">
        /// s�Ɋւ���J���`���ɌŗL�̏�������񋟂���<see cref="System.IFormatProvider"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="result">
        /// �ϊ������������ꍇ�A���̃��\�b�h���Ԃ����Ƃ��ɁAs�Ɋi�[���ꂽ���l�Ɠ�����<see cref="RationalNumber"/>�I�u�W�F�N�g��i�[���܂��B
        /// �ϊ��Ɏ��s�����ꍇ��null��i�[���܂��B
        /// </param>
        /// <returns>
        /// s������ɕϊ����ꂽ�ꍇ��true�A�����ł͂Ȃ��ꍇ��false�ł��B
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

        #region �v���C�x�[�g���\�b�h

        private static bool TryParseImp(string s, NumberStyles style, IFormatProvider provider, out LongLongInteger numerator, out UnsignedLongLongInteger denominator)
        {
            if ((style & NumberStyles.AllowHexSpecifier) != 0)
                throw (new ArgumentException("�������RationalNumber�I�u�W�F�N�g�ɕϊ�����ۂ�NumberStyles.AllowHexSpecifier�t���O�͎w��ł��܂���B"));
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
            ushort[] numerator_imp;
            ushort[] denominator_imp;
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
