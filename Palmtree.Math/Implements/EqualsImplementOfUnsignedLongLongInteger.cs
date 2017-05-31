using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class EqualsImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public bool Equals(ushort x, ushort y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            return (x.Equals(y));
        }

        public bool Equals(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (!x.Length.Equals(1))
                return (false);
            return (x[0].Equals(y));
        }

        public bool Equals(ushort x, ushort[] y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y.Length > 0);
            if (!y.Length.Equals(1))
                return (false);
            return (x.Equals(y[0]));
        }

        public bool Equals(ushort[] x, ushort[] y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y.Length > 0);
            if (!x.Length.Equals(y.Length))
                return (false);
            for (int index = 0 ; index < x.Length ; ++index)
            {
                if (!x[index].Equals(y[index]))
                    return (false);
            }
            return (true);
        }

        #endregion
    }
}
