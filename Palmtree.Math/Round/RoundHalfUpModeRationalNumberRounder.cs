/*
  RoundHalfUpModeRationalNumberRounder.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Round
{
    internal class RoundHalfUpModeRationalNumberRounder
        : RationalNumberRounderBase
    {
        #region コンストラクタ

        public RoundHalfUpModeRationalNumberRounder()
            : base(RoundingMode.ROUND_HALF_UP)
        {
        }

        #endregion

        #region RationalNumberRounderBase から継承されたメンバ

        protected override LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            r = r.LeftShift(1);
            int c = r.CompareTo(denominator);
            if (c >= 0)
                return (new LongLongInteger(sign, q.Increment()));
            else
                return (new LongLongInteger(sign, q));
        }

        #endregion
    }
}
