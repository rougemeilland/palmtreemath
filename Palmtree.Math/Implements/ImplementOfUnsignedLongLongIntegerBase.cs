using System;

namespace Palmtree.Math.Implements
{
    internal class ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックフィールド

        public static readonly ushort[] Zero;
        public static readonly ushort[] One;

        #endregion

        #region コンストラクタ

        static ImplementOfUnsignedLongLongIntegerBase()
        {
            Zero = new ushort[0];
            One = new ushort[] { 1 };
        }

        protected ImplementOfUnsignedLongLongIntegerBase()
        {
        }

        #endregion

        #region プロテクテッドメソッド

        protected ushort[] Regularize(ushort[] value)
        {
            int index = value.Length - 1;
            while (index >= 0 && value[index] == 0)
                --index;
            Array.Resize<ushort>(ref value, index + 1);
            return (value);
        }

        protected ushort[] UShortToUShortArray(ushort value)
        {
            if (value == 0)
                return (Zero);
            else
                return (new ushort[] { value });
        }

        #endregion
    }
}
