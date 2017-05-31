using System;
using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class SubtractImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort[] Subtract(ushort x, ushort y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            if (x < y)
                throw (new OverflowException("減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
            else if (x == y)
                return (new ushort[0]);
            else
                return (new ushort[] { (ushort)(x - y) });
        }

        public ushort[] Subtract(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (x.Length == 1)
                return (Subtract(x[0], y));
            ushort[] z = new ushort[x.Length];
            int index = 1;
            long carry = (uint)x[0];
            carry -= (uint)y;
            z[0] = (ushort)carry;
            carry >>= 16;
            for (; index < x.Length; ++index)
            {
                carry += (uint)x[index];
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            Debug.Assert(carry == 0);
            return (Regularize(z));
        }

        public ushort[] Subtract(ushort x, ushort[] y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y.Length > 0);
            if (y.Length == 1)
                return (Subtract(x, y[0]));
            else
                throw (new OverflowException("減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
        }

        public ushort[] Subtract(ushort[] x, ushort[] y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y.Length > 0);
            if (x.Length < y.Length)
                throw (new OverflowException("減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
            if (x.Length == 1)
                return (Subtract(x[0], y[0]));
            if (y.Length == 1)
                return (Subtract(x, y[0]));
            ushort[] z = new ushort[x.Length];
            int index = 1;
            long carry = (uint)x[0];
            carry -= (uint)y[0];
            z[0] = (ushort)carry;
            carry >>= 16;
            for (; index < y.Length; ++index)
            {
                carry += (uint)x[index];
                carry -= (uint)y[index];
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            for (; index < x.Length; ++index)
            {
                carry += (uint)x[index];
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            if (carry != 0)
                throw (new OverflowException("減算の結果がUnsignedLongLongIntegerで表現不可能な値になりました。"));
            return (Regularize(z));
        }

        #endregion
    }
}
