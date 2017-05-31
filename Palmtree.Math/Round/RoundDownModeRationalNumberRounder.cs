/*
  RoundDownModeRationalNumberRounder.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Round
{
    internal class RoundDownModeRationalNumberRounder
        : RationalNumberRounderBase
    {
        #region コンストラクタ

        public RoundDownModeRationalNumberRounder()
            : base(RoundingMode.ROUND_DOWN)
        {
        }

        #endregion

        #region RationalNumberRounderBase から継承されたメンバ

        protected override LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            return (new LongLongInteger(sign, q));
        }

        #endregion
    }
}
