/*
  IFormattingTypeInfo.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System.Globalization;

namespace Palmtree.Math.Formatter
{
    internal interface IFormattingTypeInfo
    {
        bool IsValidFormatType(char format_type);
        ushort GetDefaultPrecision(char format_type, NumberFormatInfo number_format_info);
    }
}
