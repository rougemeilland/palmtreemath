/*
  IntegerRoundTripFormatter.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Formatter
{
    internal class IntegerRoundTripFormatter
        : RoundTripFormatterBase
    {
        #region �v���C�x�[�g�t�B�[���h

        private bool _negative;
        private ushort[] _value;

        #endregion

        #region �R���X�g���N�^

        public IntegerRoundTripFormatter(bool negative, ushort[] value_numerator)
        {
            _negative = negative;
            _value = value_numerator;
        }

        #endregion

        #region RoundTripFormatterBase ����p�����ꂽ�����o

        protected override string Format()
        {
            return (SimpleFormatter(_negative, _value));
        }

        #endregion
    }
}
