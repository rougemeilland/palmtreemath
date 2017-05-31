/*
  RoundUpModeRationalNumberRounder.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Round
{
    internal class RoundUpModeRationalNumberRounder
        : RationalNumberRounderBase
    {
        #region コンストラクタ

        public RoundUpModeRationalNumberRounder()
            : base(RoundingMode.ROUND_UP)
        {
        }

        #endregion

        #region RationalNumberRounderBase から継承されたメンバ

        protected override LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            return (new LongLongInteger(sign, q.Increment()));
        }

        #endregion
    }
}
