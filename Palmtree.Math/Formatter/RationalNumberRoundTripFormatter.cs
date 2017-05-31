/*
  RationalNumberRoundTripFormatter.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Text;

namespace Palmtree.Math.Formatter
{
    internal class RationalNumberRoundTripFormatter
        : RoundTripFormatterBase
    {
        #region �v���C�x�[�g�t�B�[���h

        private bool _negative;
        private ushort[] _value_numerator;
        private ushort[] _value_denominator;

        #endregion

        #region �R���X�g���N�^

        public RationalNumberRoundTripFormatter(bool negative, ushort[] value_numerator, ushort[] value_denominator)
        {
            _negative = negative;
            _value_numerator = value_numerator;
            _value_denominator = value_denominator;
        }

        #endregion

        #region RoundTripFormatterBase ����p�����ꂽ�����o

        protected override string Format()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            sb.Append(SimpleFormatter(_negative, _value_numerator));
            sb.Append(',');
            sb.Append(_value_denominator == null ? "1" : SimpleFormatter(false, _value_denominator));
            sb.Append(']');
            return (sb.ToString());
        }

        #endregion
    }
}
