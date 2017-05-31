/*
  IParserOfNumber.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Formatter
{
    internal interface INumberSequence
    {
        /// <summary>
        /// �܂�GetDigit()��0�łȂ��������擾�ł���\�����Ȃ��Ȃ�true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// ���̃v���p�e�B��true�ɂȂ����ꍇ�A����ȍ~�̌��͏o�͂���Ȃ����Ƃ�����܂��B
        /// �m���ɏo�͂��������ł͂��̃v���p�e�B��false�ɂȂ�悤�ɂ��Ă��������B
        /// </summary>
        bool IsZero
        {
            get;
        }

        /// <summary>
        /// ���̈ꌅ�̐�������o���܂��B
        /// </summary>
        /// <returns>
        /// �����ł��B
        /// </returns>
        byte GetDigit();
    }

    internal interface IParserOfNumber
    {
        /// <summary>
        /// ���Ȃ�ΐ������̌����ł��B
        /// ���Ȃ�Ώ������̐�s����0�̐��ł��B
        /// ��F���ۂ̒l��"1234.56"�Ȃ��4�ł��B
        /// ��F���ۂ̒l��"0.00123456"�Ȃ��-2�ł��B
        /// </summary>
        int Offset
        {
            get;
        }

        /// <summary>
        /// �L�������ł��邱�Ƃ��ۏ؂���Ă���Ȃ��true�A�L���ł���Ƃ͌���Ȃ��Ȃ��false�ł��B
        /// </summary>
        bool IsLimittedDigits
        {
            get;
        }

        /// <summary>
        /// �������擾���邽�߂̃C���^�[�t�F�[�X�ł��B
        /// </summary>
        INumberSequence NumberSequence
        {
            get;
        }

        /// <summary>
        /// ��������̐����ɑ������镶����ɕϊ����܂��B
        /// </summary>
        /// <param name="digit">
        /// �ϊ����鐔���ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ������ł��B
        /// </returns>
        string FormatDigit(byte digit);

        /// <summary>
        /// ��Ɉˑ�������ł��B
        /// </summary>
        IBaseNumberInfo BaseNumberInfo { get; }

        /// <summary>
        /// �\�����鐔�l���Œጅ���ɖ����Ȃ��ꍇ�ɍŏ�ʌ��Ƀp�f�B���O���鐔���ł��B
        /// </summary>
        byte MostSignificantPaddingDigit
        {
            get;
        }
    }
}
