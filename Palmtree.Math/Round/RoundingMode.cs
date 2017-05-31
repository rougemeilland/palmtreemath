/*
  RoundingMode.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math.Round
{
    /// <summary>
    /// 非整数数値型を丸める際のモードをあらわす列挙体です。
    /// </summary>
    public enum RoundingMode
    {
        /// <summary>
        /// 0に近づくように丸めるモードです。
        /// 破棄される小数部に先行する桁を増やしません(つまり切り捨て)。
        /// この丸めモードは、計算された値の絶対値を増やしません。
        /// </summary>
        ROUND_DOWN,

        /// <summary>
        /// 0から離れるように丸めるモードです。
        /// 破棄される0以外の小数部に先行する桁を常に増やします。
        /// この丸めモードは、計算された値の絶対値を減らしません。
        /// </summary>
        ROUND_UP,

        /// <summary>
        /// 負の無限大に近づくように丸めるモードです。
        /// <see cref="RationalNumber"/> が正の場合は ROUND_DOWN のように動作し、負の場合は ROUND_UP のように動作します。
        /// この丸めモードは、計算された値を増やしません。
        /// </summary>
        ROUND_FLOOR,

        /// <summary>
        /// 正の無限大に近づくように丸めるモードです。
        /// <see cref="RationalNumber"/> が正の場合は ROUND_UP のように動作し、負の場合は ROUND_DOWN のように動作します。
        /// この丸めモードは、計算された値を減らしません。
        /// </summary>
        ROUND_CEILING,

        /// <summary>
        /// 「もっとも近い数字」に丸めるモードです。
        /// ただし、両隣りの数字が等距離の場合は切り捨てます。
        /// 破棄される小数部が 0.5 を超える場合は ROUND_UP のように動作し、それ以外の場合は ROUND_DOWN のように動作します。
        /// </summary>
        ROUND_HALF_DOWN,

        /// <summary>
        /// 「もっとも近い数字」に丸めるモードです。
        /// ただし、両隣りの数字が等距離の場合は切り上げます。
        /// 破棄される小数部が 0.5 以上の場合は ROUND_UP のように動作し、それ以外の場合は ROUND_DOWN のように動作します。
        /// これは我々の大半が小学校で習った丸めモードのことです。
        /// </summary>
        ROUND_HALF_UP,

        /// <summary>
        /// 「もっとも近い数字」に丸めるモードです。
        /// ただし、両隣りの数字が等距離の場合は偶数側に丸めます。
        /// 破棄する小数部の左辺の桁が奇数の場合は ROUND_HALF_UP のように動作し、偶数の場合は ROUND_HALF_DOWN のように動作します。
        /// この丸めモードは、連続する計算で繰り返し適用される場合に累積エラーを最小限にします。
        /// </summary>
        ROUND_HALF_EVEN,

        /// <summary>
        /// 丸めが不要であるため、丸めを行わないモードです。
        /// 端数が存在する場合には<see cref="ArithmeticException"/>例外が発生します。
        /// </summary>
        ROUND_UNNECESSARY,
    }
}
