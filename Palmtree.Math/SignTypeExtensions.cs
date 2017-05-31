/*
  SignTypeExtensions.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math
{
    internal static class SignTypeExtensions
    {
        internal static SignType Negate(this SignType sign)
        {
            switch (sign)
            {
                case SignType.Zero:
                    return (SignType.Zero);
                case SignType.Positive:
                    return (SignType.Negative);
                default:
                    return (SignType.Positive);
            }
        }

        internal static SignType Multiply(this SignType x, SignType y)
        {
            switch (x)
            {
                case SignType.Zero:
                    return (SignType.Zero);
                case SignType.Positive:
                    return (y);
                default:
                    switch (y)
                    {
                        case SignType.Zero:
                            return (SignType.Zero);
                        case SignType.Positive:
                            return (SignType.Negative);
                        default:
                            return (SignType.Positive);
                    }
            }
        }

        internal static SignType Divide(this SignType x, SignType y)
        {
            switch (y)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0による除算が行われようとしました。"));
                case SignType.Positive:
                    return (x);
                default:
                    switch (x)
                    {
                        case SignType.Zero:
                            return (SignType.Zero);
                        case SignType.Positive:
                            return (SignType.Negative);
                        default:
                            return (SignType.Positive);
                    }
            }
        }
    }
}
