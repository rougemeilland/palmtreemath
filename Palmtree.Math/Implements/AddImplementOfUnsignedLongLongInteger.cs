using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class AddImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort[] Add(ushort x, ushort y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            ulong z = (ulong)x + y;
            if (z <= ushort.MaxValue)
                return (new ushort[] { (ushort)z, });
            else
                return (new ushort[] { (ushort)z, (ushort)(z >> 16) });
        }

        public ushort[] Add(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (x.Length == 1)
                return (Add(x[0], y));
            ushort[] z = new ushort[x.Length + 1];
            int index = 1;
            long carry = (uint)x[0];
            carry += (uint)y;
            z[0] = (ushort)carry;
            carry >>= 16;
            for (; index < x.Length; ++index)
            {
                carry += x[index];
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            z[index] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(z));
        }

        public ushort[] Add(ushort[] x, ushort[] y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y.Length > 0);
            if (x.Length < y.Length)
            {
                ushort[] t = x;
                x = y;
                y = t;
            }
            if (x.Length == 1)
                return (Add(x[0], y[0]));
            if (y.Length == 1)
                return (Add(x, y[0]));
            ushort[] z = new ushort[x.Length + 1];
            int index = 1;
            long carry = (uint)x[0];
            carry += (uint)y[0];
            z[0] = (ushort)carry;
            carry >>= 16;
            for (; index < y.Length; ++index)
            {
                carry += (uint)x[index];
                carry += (uint)y[index];
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            for (; index < x.Length; ++index)
            {
                carry += (uint)x[index];
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            z[index] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(z));
        }

        #endregion
    }
}
