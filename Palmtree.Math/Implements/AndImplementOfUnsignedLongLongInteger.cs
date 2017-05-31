using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class AndImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort And(ushort x, ushort y)
        {
            ushort z = (ushort)(x & y);
            return (z);
        }

        public ulong And(ulong x, ulong y)
        {
            ulong z = (x & y);
            return (z);
        }

        public ushort[] And(ushort[] x, ushort[] y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y.Length > 0);
            if (x.Length < y.Length)
            {
                ushort[] t = x;
                x = y;
                y = t;
            }
            if (y.Length == 1)
            {
                Debug.Assert(y[0] != 0);
                if (x[0] == 0)
                    return (Zero);
                else
                    return (UShortToUShortArray(And(x[0], y[0])));
            }
            Debug.Assert(x.Length > 1);
            Debug.Assert(y.Length > 1);
            Debug.Assert(x.Length >= y.Length);
            ushort[] z = new ushort[y.Length];
            for (int index = 0; index < z.Length; ++index)
                z[index] = (ushort)(x[index] & y[index]);
            return (Regularize(z));
        }

        #endregion
    }
}
