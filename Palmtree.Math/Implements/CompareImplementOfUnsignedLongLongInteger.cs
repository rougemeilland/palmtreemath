using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class CompareImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public int Compare(ushort x, ushort y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            return (x.CompareTo(y));
        }

        public int Compare(ushort[] x, ushort y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (x.Length == 1)
                return (Compare(x[0], y));
            return (1);
        }

        public int Compare(ushort x, ushort[] y)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y.Length > 0);
            if (y.Length == 1)
                return (Compare(x, y[0]));
            return (-1);
        }

        public int Compare(ushort[] x, ushort[] y)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y.Length > 0);
            if (x.Length != y.Length)
                return (x.Length.CompareTo(y.Length));
            if (x.Length == 1)
                return (Compare(x[0], y[0]));
            for (int index = x.Length - 1; index >= 0; --index)
            {
                if (x[index] != y[index])
                    return (x[index].CompareTo(y[index]));
            }
            return (0);
        }

        #endregion
    }
}
