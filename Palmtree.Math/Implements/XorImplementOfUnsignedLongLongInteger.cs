using System;
using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class XorImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort Xor(ushort x, ushort y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            ushort z = (ushort)(x ^ y);
            return (z);
        }

        public ushort[] Xor(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (x.Length == 1)
                return (UShortToUShortArray(Xor(x[0], y)));
            ushort[] z = new ushort[x.Length];
            z[0] = (ushort)(x[0] ^ y);
            Array.Copy(x, 1, z, 1, x.Length - 1);
            return (z);
        }

        public ushort[] Xor(ushort[] x, ushort[] y)
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
                return (UShortToUShortArray(Xor(x[0], y[0])));
            if (y.Length == 1)
                return (Xor(x, y[0]));
            Debug.Assert(x.Length > 1);
            Debug.Assert(y.Length > 1);
            Debug.Assert(x.Length >= y.Length);
            ushort[] z = new ushort[x.Length];
            int index = 0;
            for (; index < y.Length; ++index)
                z[index] = (ushort)(x[index] ^ y[index]);
            if (index < x.Length)
            {
                Array.Copy(x, index, z, index, x.Length - index);
                return (z);
            }
            else
            {
                return (Regularize(z));
            }
        }

        #endregion
    }
}
