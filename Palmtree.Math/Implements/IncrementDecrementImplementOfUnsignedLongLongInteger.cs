using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class IncrementDecrementImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort[] Increment(ushort[] x)
        {
            Debug.Assert(x.Length > 0);
            ushort[] z = new ushort[x.Length + 1];
            bool carry = true;
            int index = 0;
            for (; index < x.Length && carry == true; ++index)
            {
                ushort v = x[index];
                ++v;
                if (v != 0)
                    carry = false;
                z[index] = v;
            }
            for (; index < x.Length; ++index)
                z[index] = x[index];
            z[index] = carry ? (ushort)1 : (ushort)0;
            return (Regularize(z));
        }

        public ushort[] Decrement(ushort[] x)
        {
            Debug.Assert(x.Length > 0);
            ushort[] z = new ushort[x.Length];
            int index = 0;
            bool carry = true;
            for (; index < x.Length && carry == true; ++index)
            {
                ushort v = x[index];
                if (v != 0)
                    carry = false;
                --v;
                z[index] = v;
            }
            for (; index < x.Length; ++index)
                z[index] = x[index];
            return (Regularize(z));
        }

        #endregion
    }
}
