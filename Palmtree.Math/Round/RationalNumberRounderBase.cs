/*
  RationalNumberRounderBase.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Diagnostics;

namespace Palmtree.Math.Round
{
    internal abstract class RationalNumberRounderBase
        : IRoundRationalNumber
    {
        #region プライベートフィールド

        private RoundingMode _mode;

        #endregion

        #region コンストラクタ

        protected RationalNumberRounderBase(RoundingMode mode)
        {
            _mode = mode;
        }

        #endregion

        #region プロテクテッドメソッド

        protected abstract LongLongInteger Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r);

        #endregion

        #region IRoundRationalNumber のメンバ

        RoundingMode IRoundRationalNumber.Mode
        {
            get
            {
                return (_mode);
            }
        }

        LongLongInteger IRoundRationalNumber.Round(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            Debug.Assert(r.IsZero == false);
            Debug.Assert(r.CompareTo(denominator) < 0);
            Debug.Assert(sign != SignType.Zero);
            return (Round(sign, denominator, q, r));
        }

        #endregion
    }
}
