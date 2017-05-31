using System;
using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class ComplementAndImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort ComplementAnd(ushort x, ushort y)
        {
            ushort z = (ushort)(x & ~y);
            return (z);
        }

        public ulong ComplementAnd(ulong x, ushort y)
        {
            ulong z = (x & ~(ulong)y);
            return (z);
        }

        public ulong ComplementAnd(ulong x, ulong y)
        {
            ulong z = (x & ~y);
            return (z);
        }

        public ushort[] ComplementAnd(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (x.Length == 1)
                return (UShortToUShortArray(ComplementAnd(x[0], y)));
            ushort[] z = new ushort[x.Length];
            z[0] = (ushort)(x[0] & ~y);
            Array.Copy(x, 1, z, 1, x.Length - 1);
            return (z);
        }

        public ushort[] ComplementAnd(ushort[] x, ushort[] y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y.Length > 0);
            if (x.Length == 1)
            {
                Debug.Assert(x[0] != 0);
                if (y[0] == 0)
                    return (x);
                else
                    return (UShortToUShortArray(ComplementAnd(x[0], y[0])));
            }
            if (y.Length == 1)
                return (ComplementAnd(x, y[0]));
            Debug.Assert(x.Length > 1);
            Debug.Assert(y.Length > 1);
            ushort[] z = new ushort[x.Length];
            int index = 0;
            for (; index < x.Length && index < y.Length; ++index)
                z[index] = (ushort)(x[index] & ~y[index]);
            if (index < x.Length)
                Array.Copy(x, index, z, index, x.Length - index);
            return (Regularize(z));
        }

        #endregion
    }
}
