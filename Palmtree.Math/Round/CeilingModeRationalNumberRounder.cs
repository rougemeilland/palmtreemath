/*
  CeilingModeRationalNumberRounder.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Round
{
    internal class CeilingModeRationalNumberRounder
        : RationalNumberRounderBase
    {
        #region コンストラクタ

        public CeilingModeRationalNumberRounder()
            : base(RoundingMode.ROUND_CEILING)
        {
        }

        #endregion

        #region RationalNumberRounderBase から継承されたメンバ

        protected override LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            if (sign != SignType.Negative)
                return (q.Increment().ToLongLongInteger());
            else
                return (q.Negate());
        }

        #endregion
    }
}
