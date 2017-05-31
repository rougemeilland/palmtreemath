/*
  RoundHalfEvenModeRationalNumberRounder.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Round
{
    internal class RoundHalfEvenModeRationalNumberRounder
        : RationalNumberRounderBase
    {
        #region コンストラクタ

        public RoundHalfEvenModeRationalNumberRounder()
            : base(RoundingMode.ROUND_HALF_EVEN)
        {
        }

        #endregion

        #region RationalNumberRounderBase から継承されたメンバ

        protected override LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            r = r.LeftShift(1);
            int c = r.CompareTo(denominator);
            if (c > 0)
                return (new LongLongInteger(sign, q.Increment()));
            else if (c < 0)
                return (new LongLongInteger(sign, q));
            else if (q.IsEven)
                return (new LongLongInteger(sign, q));
            else
                return (new LongLongInteger(sign, q.Increment()));
        }

        #endregion
    }
}
