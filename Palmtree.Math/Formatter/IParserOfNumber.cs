/*
  IParserOfNumber.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Formatter
{
    internal interface INumberSequence
    {
        /// <summary>
        /// まだGetDigit()で0でない数字が取得できる可能性がないならtrue、そうではないのならfalseです。
        /// このプロパティがtrueになった場合、それ以降の桁は出力されないことがあります。
        /// 確実に出力したい桁ではこのプロパティがfalseになるようにしてください。
        /// </summary>
        bool IsZero
        {
            get;
        }

        /// <summary>
        /// 次の一桁の数字を取り出します。
        /// </summary>
        /// <returns>
        /// 数字です。
        /// </returns>
        byte GetDigit();
    }

    internal interface IParserOfNumber
    {
        /// <summary>
        /// 正ならば整数部の桁数です。
        /// 負ならば小数部の先行する0の数です。
        /// 例：実際の値が"1234.56"ならば4です。
        /// 例：実際の値が"0.00123456"ならば-2です。
        /// </summary>
        int Offset
        {
            get;
        }

        /// <summary>
        /// 有限桁数であることが保証されているならばtrue、有限であるとは限らないならばfalseです。
        /// </summary>
        bool IsLimittedDigits
        {
            get;
        }

        /// <summary>
        /// 数字列を取得するためのインターフェースです。
        /// </summary>
        INumberSequence NumberSequence
        {
            get;
        }

        /// <summary>
        /// 数字をその数字に相当する文字列に変換します。
        /// </summary>
        /// <param name="digit">
        /// 変換する数字です。
        /// </param>
        /// <returns>
        /// 変換された文字列です。
        /// </returns>
        string FormatDigit(byte digit);

        /// <summary>
        /// 基数に依存する情報です。
        /// </summary>
        IBaseNumberInfo BaseNumberInfo { get; }

        /// <summary>
        /// 表示する数値が最低桁数に満たない場合に最上位桁にパディングする数字です。
        /// </summary>
        byte MostSignificantPaddingDigit
        {
            get;
        }
    }
}
