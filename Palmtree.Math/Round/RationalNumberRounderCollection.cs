/*
  RationalNumberRounderCollection.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Collections.Generic;

namespace Palmtree.Math.Round
{
    internal class RationalNumberRounderCollection
    {
        #region プライベートフィールド

        private Dictionary<RoundingMode, IRoundRationalNumber> _items;

        #endregion

        #region コンストラクタ

        public RationalNumberRounderCollection()
        {
            _items = new Dictionary<RoundingMode, IRoundRationalNumber>();
            AddRounder(new CeilingModeRationalNumberRounder());
            AddRounder(new FloorModeRationalNumberRounder());
            AddRounder(new RoundDownModeRationalNumberRounder());
            AddRounder(new RoundHalfDownModeRationalNumberRounder());
            AddRounder(new RoundHalfEvenModeRationalNumberRounder());
            AddRounder(new RoundHalfUpModeRationalNumberRounder());
            AddRounder(new RoundUpModeRationalNumberRounder());
            AddRounder(new UnnecessaryModeRationalNumberRounder());
        }

        private void AddRounder(IRoundRationalNumber item)
        {
            _items.Add(item.Mode, item);
        }

        #endregion

        #region パブリックメソッド

        public LongLongInteger Round(RoundingMode mode, SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger q, UnsignedLongLongInteger r)
        {
            return (_items[mode].Round(sign, denominator, q, r));
        }

        #endregion
    }
}
