/*
  SignType.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

namespace Palmtree.Math
{
#if true
    internal enum SignType
    {
        Zero = 0,
        Positive = 1,
        Negative = -1,
    }
#else

    internal struct SignType
        : IEquatable<SignType>
    {
        #region プライベートフィールド

        private int _value;

        #endregion

        #region パブリックフィールド

        public static readonly SignType Zero;
        public static readonly SignType Positive;
        public static readonly SignType Negative;

        #endregion

        #region コンストラクタ

        static SignType()
        {
            Zero = new SignType(0);
            Positive = new SignType(1);
            Negative = new SignType(-1);
        }

        private SignType(int value)
        {
            _value = value;
        }

        #endregion

        #region パブリックメソッド

        public static explicit operator int(SignType o)
        {
            return (o._value);
        }

        public static bool operator ==(SignType x, SignType y)
        {
            return (x._value.Equals(y._value));
        }

        public static bool operator !=(SignType x, SignType y)
        {
            return (!x._value.Equals(y._value));
        }

        #endregion

        #region object から継承されたメンバ

        public override bool Equals(object o)
        {
            if (o == null || GetType() != o.GetType())
                return (false);
            return (Equals((SignType)o));
        }

        public override int GetHashCode()
        {
            return (_value.GetHashCode());
        }

        #endregion

        #region IEquatable<SignType> のメンバ

        public bool Equals(SignType o)
        {
            return (_value.Equals(o._value));
        }

        #endregion
    }

#endif
}
