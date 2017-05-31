/*
  RoundingMode.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math.Round
{
    /// <summary>
    /// �񐮐����l�^��ۂ߂�ۂ̃��[�h�����킷�񋓑̂ł��B
    /// </summary>
    public enum RoundingMode
    {
        /// <summary>
        /// 0�ɋ߂Â��悤�Ɋۂ߂郂�[�h�ł��B
        /// �j������鏬�����ɐ�s���錅�𑝂₵�܂���(�܂�؂�̂�)�B
        /// ���̊ۂ߃��[�h�́A�v�Z���ꂽ�l�̐�Βl�𑝂₵�܂���B
        /// </summary>
        ROUND_DOWN,

        /// <summary>
        /// 0���痣���悤�Ɋۂ߂郂�[�h�ł��B
        /// �j�������0�ȊO�̏������ɐ�s���錅���ɑ��₵�܂��B
        /// ���̊ۂ߃��[�h�́A�v�Z���ꂽ�l�̐�Βl����炵�܂���B
        /// </summary>
        ROUND_UP,

        /// <summary>
        /// ���̖�����ɋ߂Â��悤�Ɋۂ߂郂�[�h�ł��B
        /// <see cref="RationalNumber"/> �����̏ꍇ�� ROUND_DOWN �̂悤�ɓ��삵�A���̏ꍇ�� ROUND_UP �̂悤�ɓ��삵�܂��B
        /// ���̊ۂ߃��[�h�́A�v�Z���ꂽ�l�𑝂₵�܂���B
        /// </summary>
        ROUND_FLOOR,

        /// <summary>
        /// ���̖�����ɋ߂Â��悤�Ɋۂ߂郂�[�h�ł��B
        /// <see cref="RationalNumber"/> �����̏ꍇ�� ROUND_UP �̂悤�ɓ��삵�A���̏ꍇ�� ROUND_DOWN �̂悤�ɓ��삵�܂��B
        /// ���̊ۂ߃��[�h�́A�v�Z���ꂽ�l����炵�܂���B
        /// </summary>
        ROUND_CEILING,

        /// <summary>
        /// �u����Ƃ�߂������v�Ɋۂ߂郂�[�h�ł��B
        /// �������A���ׂ�̐������������̏ꍇ�͐؂�̂Ă܂��B
        /// �j������鏬������ 0.5 �𒴂���ꍇ�� ROUND_UP �̂悤�ɓ��삵�A����ȊO�̏ꍇ�� ROUND_DOWN �̂悤�ɓ��삵�܂��B
        /// </summary>
        ROUND_HALF_DOWN,

        /// <summary>
        /// �u����Ƃ�߂������v�Ɋۂ߂郂�[�h�ł��B
        /// �������A���ׂ�̐������������̏ꍇ�͐؂�グ�܂��B
        /// �j������鏬������ 0.5 �ȏ�̏ꍇ�� ROUND_UP �̂悤�ɓ��삵�A����ȊO�̏ꍇ�� ROUND_DOWN �̂悤�ɓ��삵�܂��B
        /// ����͉�X�̑唼�����w�Z�ŏK�����ۂ߃��[�h�̂��Ƃł��B
        /// </summary>
        ROUND_HALF_UP,

        /// <summary>
        /// �u����Ƃ�߂������v�Ɋۂ߂郂�[�h�ł��B
        /// �������A���ׂ�̐������������̏ꍇ�͋�����Ɋۂ߂܂��B
        /// �j�����鏬�����̍��ӂ̌�����̏ꍇ�� ROUND_HALF_UP �̂悤�ɓ��삵�A����̏ꍇ�� ROUND_HALF_DOWN �̂悤�ɓ��삵�܂��B
        /// ���̊ۂ߃��[�h�́A�A������v�Z�ŌJ��Ԃ��K�p�����ꍇ�ɗݐσG���[��ŏ����ɂ��܂��B
        /// </summary>
        ROUND_HALF_EVEN,

        /// <summary>
        /// �ۂ߂��s�v�ł��邽�߁A�ۂ߂�s��Ȃ����[�h�ł��B
        /// �[�������݂���ꍇ�ɂ�<see cref="ArithmeticException"/>��O���������܂��B
        /// </summary>
        ROUND_UNNECESSARY,
    }
}
