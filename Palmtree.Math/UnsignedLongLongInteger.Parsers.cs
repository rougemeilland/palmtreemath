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
        #region �p�u���b�N���\�b�h

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s)
        {
            return (Parse(s, NumberStyles.Integer, null));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="provider">
        /// s�Ɋւ���J���`���ɌŗL�̏�������񋟂���<see cref="System.IFormatProvider"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s, IFormatProvider provider)
        {
            return (Parse(s, NumberStyles.Integer, provider));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="style">
        /// s�Ŏg�p�\�ȏ���������A<see cref="System.Globalization.NumberStyles"/>�l�̃r�b�g���Ƃ̑g�ݍ��킹�ł��B
        /// �ʏ�w�肷��l�́A<see cref="System.Globalization.NumberStyles.Integer"/>�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s, NumberStyles style)
        {
            return (Parse(s, style, null));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="style">
        /// s�Ŏg�p�\�ȏ���������A<see cref="System.Globalization.NumberStyles"/>�l�̃r�b�g���Ƃ̑g�ݍ��킹�ł��B
        /// �ʏ�w�肷��l�́A<see cref="System.Globalization.NumberStyles.Integer"/>�ł��B
        /// </param>
        /// <param name="provider">
        /// s�Ɋւ���J���`���ɌŗL�̏�������񋟂���<see cref="System.IFormatProvider"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            UnsignedLongLongInteger value;
            if (!TryParse(s, style, provider, out value))
                throw (new FormatException(string.Format("������\"{0}\"��������UnsignedLongLongInteger�̏����ł͂���܂���B", s)));
            return (value);
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`�������Ɠ�����<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
        /// </summary>
        /// <param name="s">
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�̕�����`���ł��B
        /// </param>
        /// <param name="result">
        /// �ϊ��ɐ��������ꍇ�A�ϊ����ꂽ<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ��ɐ��������ꍇ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool TryParse(string s, out UnsignedLongLongInteger result)
        {
            return (TryParse(s, NumberStyles.Integer, null, out result));
        }

        /// <summary>
        /// �w�肵���X�^�C������уJ���`���ɌŗL�̏����ɂ�鐔�l�̕�����`����A����Ɠ�����<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�ɕϊ����܂��B
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
        /// �ϊ������������ꍇ�A���̃��\�b�h���Ԃ����Ƃ��ɁAs�Ɋi�[���ꂽ���l�Ɠ�����<see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g��i�[���܂��B
        /// �ϊ��Ɏ��s�����ꍇ��null��i�[���܂��B
        /// </param>
        /// <returns>
        /// s������ɕϊ����ꂽ�ꍇ��true�A�����ł͂Ȃ��ꍇ��false�ł��B
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

        #region �v���C�x�[�g���\�b�h

        private static bool TryParseImp(string s, NumberStyles style, IFormatProvider provider, out NativeUnsignedInteger result)
        {
            result = null;
            bool negative;
            NativeUnsignedInteger numerator_imp;
            NativeUnsignedInteger denominator_imp;
            if (!FormatterCreatorBase.TryParse(s, style, provider, out negative, out numerator_imp, out denominator_imp))
                return (false);
            if (negative)
                return (false);
            if (!denominator_imp.IsOne)
                return (false);
            result = numerator_imp;
            return (true);
        }

        #endregion
    }
}
