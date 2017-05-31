/*
  LongLongInteger.Parsers.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Globalization;
using Palmtree.Math.Formatter;

namespace Palmtree.Math
{
    partial struct LongLongInteger
    {
        #region �p�u���b�N���\�b�h

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="LongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="LongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Parse(string s)
        {
            return (Parse(s, NumberStyles.Integer, null));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="LongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="provider">
        /// s�Ɋւ���J���`���ɌŗL�̏�������񋟂���<see cref="System.IFormatProvider"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="LongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Parse(string s, IFormatProvider provider)
        {
            return (Parse(s, NumberStyles.Integer, provider));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="LongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="style">
        /// s�Ŏg�p�\�ȏ���������A<see cref="System.Globalization.NumberStyles"/>�l�̃r�b�g���Ƃ̑g�ݍ��킹�ł��B
        /// �ʏ�w�肷��l�́A<see cref="System.Globalization.NumberStyles.Integer"/>�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="LongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Parse(string s, NumberStyles style)
        {
            return (Parse(s, style, null));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="LongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="style">
        /// s�Ŏg�p�\�ȏ���������A<see cref="System.Globalization.NumberStyles"/>�l�̃r�b�g���Ƃ̑g�ݍ��킹�ł��B
        /// �ʏ�w�肷��l�́A<see cref="System.Globalization.NumberStyles.Integer"/>�ł��B
        /// </param>
        /// <param name="provider">
        /// s�Ɋւ���J���`���ɌŗL�̏�������񋟂���<see cref="System.IFormatProvider"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="LongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            LongLongInteger value;
            if (!TryParse(s, style, provider, out value))
                throw (new FormatException(string.Format("������\"{0}\"��������LongLongInteger�̏����ł͂���܂���B", s)));
            return (value);
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="LongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="result">
        /// �ϊ��ɐ��������ꍇ�A�ϊ����ꂽ<see cref="LongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ��ɐ��������ꍇ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool TryParse(string s, out LongLongInteger result)
        {
            return (TryParse(s, NumberStyles.Integer, null, out result));
        }

        /// <summary>
        /// �w�肵���X�^�C������уJ���`���ɌŗL�̏����ɂ�鐔�l�̕�����`����A����Ɠ�����<see cref="LongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
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
        /// �ϊ������������ꍇ�A���̃��\�b�h���Ԃ����Ƃ��ɁAs�Ɋi�[���ꂽ���l�Ɠ�����<see cref="LongLongInteger"/>�I�u�W�F�N�g��i�[���܂��B
        /// �ϊ��Ɏ��s�����ꍇ��null��i�[���܂��B
        /// </param>
        /// <returns>
        /// s������ɕϊ����ꂽ�ꍇ��true�A�����ł͂Ȃ��ꍇ��false�ł��B
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

        #region �v���C�x�[�g���\�b�h

        private static bool TryParseImp(string s, NumberStyles style, IFormatProvider provider, out SignType sign, out UnsignedLongLongInteger abs)
        {
            sign = SignType.Zero;
            abs = UnsignedLongLongInteger.Zero;
            bool negative;
            ushort[] numerator_imp;
            ushort[] denominator_imp;
            if (!FormatterCreatorBase.TryParse(s, style, provider, out negative, out numerator_imp, out denominator_imp))
                return (false);
            if (denominator_imp.Length != 1 || denominator_imp[0] != 1)
                return (false);
            if (numerator_imp.Length == 0)
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
