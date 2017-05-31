/*
  FloorModeRationalNumberRounder.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Round
{
    internal class FloorModeRationalNumberRounder
        : RationalNumberRounderBase
    {
        #region コンストラクタ

        public FloorModeRationalNumberRounder()
            : base(RoundingMode.ROUND_FLOOR)
        {
        }

        #endregion

        #region RationalNumberRounderBase から継承されたメンバ

        protected override LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            if (sign != SignType.Negative )
                return (q.ToLongLongInteger());
            else
                return (q.Increment().Negate());
        }

        #endregion
    }
}
