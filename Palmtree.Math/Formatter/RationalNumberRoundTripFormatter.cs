/*
  RationalNumberRoundTripFormatter.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Text;
using Palmtree.Math.Implements;

namespace Palmtree.Math.Formatter
{
    internal class RationalNumberRoundTripFormatter
        : RoundTripFormatterBase
    {
        #region プライベートフィールド

        private bool _negative;
        private NativeUnsignedInteger _value_numerator;
        private NativeUnsignedInteger _value_denominator;

        #endregion

        #region コンストラクタ

        public RationalNumberRoundTripFormatter(bool negative, NativeUnsignedInteger value_numerator, NativeUnsignedInteger value_denominator)
        {
            _negative = negative;
            _value_numerator = value_numerator;
            _value_denominator = value_denominator;
        }

        #endregion

        #region RoundTripFormatterBase から継承されたメンバ

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