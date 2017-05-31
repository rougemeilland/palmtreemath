/*
  UnnecessaryModeRationalNumberRounder.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math.Round
{
    internal class UnnecessaryModeRationalNumberRounder
        : RationalNumberRounderBase
    {
        #region コンストラクタ

        public UnnecessaryModeRationalNumberRounder()
            : base(RoundingMode.ROUND_UNNECESSARY)
        {
        }

        #endregion

        #region RationalNumberRounderBase から継承されたメンバ

        protected override LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            if (!r.IsZero)
                throw (new ArithmeticException());
            return (new LongLongInteger(sign, q));
        }

        #endregion
    }
}
