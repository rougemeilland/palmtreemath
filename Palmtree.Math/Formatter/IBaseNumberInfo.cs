/*
  IBaseNumberInfo.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math.Formatter
{
    /// <summary>
    /// 数値の基数に依存する操作を行うためのインターフェースです。
    /// </summary>
    internal interface IBaseNumberInfo
    {
        /// <summary>
        /// 基数の値です。
        /// </summary>
        byte Value { get; }

        /// <summary>
        /// ある整数値に基数をかけた値を得ます。
        /// 計算結果は (value * 基数) と等価です。
        /// </summary>
        /// <param name="value">
        /// 計算対象の値です。
        /// </param>
        /// <returns>
        /// 計算結果の値です。
        /// </returns>
        ushort[] Multiply(ushort[] value);

        /// <summary>
        /// ある整数値に基数をかけ、与えられた値を足した値を得ます。
        /// 計算結果は (value * 基数 + digit) と等価です。
        /// </summary>
        /// <param name="value">
        /// 計算対象の値です。
        /// </param>
        /// <param name="digit">
        /// 加算する値です。
        /// </param>
        /// <returns>
        /// 計算結果の値です。
        /// </returns>
        ushort[] MultiplyAndAdd(ushort[] value, byte digit);

        /// <summary>
        /// 整数部をあらわす数値から最下位桁の数字を取り出します。
        /// </summary>
        /// <param name="value">
        /// 整数部をあらわす数値です。( value &gt; 0 )
        /// </param>
        /// <param name="updated_value">
        /// 更新された整数部です。( value / 基数 )
        /// </param>
        /// <returns>
        /// 最下位桁の数字です。( value % 基数 )
        /// </returns>
        byte GetLeastSignificantDigitFromIntegerPart(ushort[] value, out  ushort[] updated_value);

        /// <summary>
        /// 小数部をあらわす数値から、小数第一位の桁の数字を取り出します。
        /// </summary>
        /// <remarks>
        /// value_numeratorとvalue_denominatorで表される有理数をvalue、updated_value_numeratorとvalue_denominatorで表される有理数をupdated_valueとすると、以下の関係が成立します。
        /// <list type="bullet">
        /// <item>
        /// 0 &lt;= value &lt; 1
        /// </item>
        /// <item>
        /// 復帰値 == Floor(value * 基数)
        /// </item>
        /// <item>
        /// updated_value == value * 基数 - 復帰値, 0 &lt;= updated_value &lt; 1
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="value_numerator">
        /// 小数部をあらわす数値の分子部分です。
        /// </param>
        /// <param name="value_denominator">
        /// 小数部をあらわす数値の分母部分です。
        /// </param>
        /// <param name="updated_value_numerator">
        /// 更新された小数部をあらわす数値の分子部分です。
        /// </param>
        /// <returns>
        /// 小数第一位の桁の数字です。
        /// </returns>
        byte GetMostSignificantDigitFromFractionPart(ushort[] value_numerator, ushort[] value_denominator,  out ushort[] updated_value_numerator);

        /// <summary>
        /// 与えられた有理数の分母部分から、有理数が小数以下有限桁数で表現できるかどうかを調べます。
        /// </summary>
        /// <param name="denominator">
        /// 調べる対象の有理数の分母部分です。
        /// nullの場合は分母が1を意味します。
        /// </param>
        /// <returns>
        /// 有理数が小数以下有限桁数で表現できると判断可能ならtrue、そうではないのならfalseです。
        /// </returns>
        bool IsRationalNumberRepresentableByFiniteDigits(ushort[] denominator);

        /// <summary>
        /// 数値として有効な文字かどうかを調べます。
        /// </summary>
        /// <param name="c">
        /// 調べる対象の文字です。
        /// </param>
        /// <returns>
        /// 数字が有効であればtrue、そうではないのならfalseです。
        /// </returns>
        bool IsValidChar(char c);

        /// <summary>
        /// 文字を数値に変換します。
        /// </summary>
        /// <param name="c">
        /// 変換する対象の文字です。
        /// </param>
        /// <returns>
        /// 文字に対応する数値です。
        /// </returns>
        byte ParseChar(char c);

        /// <summary>
        /// 数値を文字に変換します。
        /// </summary>
        /// <param name="n">
        /// 変換する対象の数値です。
        /// </param>
        /// <returns>
        /// 数値に対応する文字です。
        /// </returns>
        char FormatChar(byte n);

        /// <summary>
        /// 指数表現が可能な基数ならばtrue、そうではないのならfalseです。
        /// </summary>
        bool AllowedExponentialForm { get; }
    }
}
