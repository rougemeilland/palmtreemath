using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class MultiplyImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort[] Multiply(ushort x, ushort y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            ulong z = (uint)x * (uint)y;
            if (z <= ushort.MaxValue)
                return (new ushort[] { (ushort)z, });
            else
                return (new ushort[] { (ushort)z, (ushort)(z >> 16) });
        }

        public ushort[] Multiply(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (x.Length == 1)
                return (Multiply(x[0], y));
            ushort[] z = new ushort[x.Length + 1];
            int index = 1;
            ulong carry = (uint)x[0] * (uint)y;
            z[0] = (ushort)carry;
            carry >>= 16;
            for (; index < x.Length; ++index)
            {
                carry += (uint)x[index] * (uint)y;
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            z[index] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(z));
        }

        public ushort[] Multiply(ushort[] x, ushort[] y)
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
                return (Multiply(x[0], y[0]));
            if (y.Length == 1)
                return (Multiply(x, y[0]));
            ushort[] z = new ushort[x.Length + y.Length];
            int index = 1;
            ulong carry = (uint)x[0] * (uint)y[0];
            z[0] = (ushort)carry;
            carry >>= 16;
            for (; index < x.Length + y.Length - 1; ++index)
            {
                int min_index_x = 0;
                if (index > y.Length - 1)
                    min_index_x = index - (y.Length - 1);
                int max_index_x = x.Length;
                if (index < x.Length - 1)
                    max_index_x = index + 1;
                for (int index_x = min_index_x; index_x < max_index_x; ++index_x)
                {
                    int index_y = index - index_x;
                    carry += (uint)x[index_x] * (uint)y[index_y];
                }
                z[index] = (ushort)carry;
                carry >>= 16;
            }
            z[index] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(z));
        }

        public ushort[] Multiply10AndAddQuick(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            ushort[] z = new ushort[x.Length + 1];
            uint carry = y;
            int index = 0;
            for (; index < x.Length; ++index)
            {
                uint v = x[index];
                v = ((v << 2) + v) << 1;
                carry = carry + v;
                z[index] = (ushort)carry;
                carry = carry >> 16;
            }
            z[index] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(z));
        }

        public ushort[] Multiply16AndAddQuick(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            ushort[] z = new ushort[x.Length + 1];
            uint carry = y;
            int index = 0;
            for (; index < x.Length; ++index)
            {
                uint v = x[index];
                v = v << 4;
                carry = carry + v;
                z[index] = (ushort)carry;
                carry = carry >> 16;
            }
            z[index] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(z));
        }

        #endregion
    }
}
