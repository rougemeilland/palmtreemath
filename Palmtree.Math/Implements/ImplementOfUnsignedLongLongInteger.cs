
namespace Palmtree.Math.Implements
{
    internal class ImplementOfUnsignedLongLongInteger
    {
        #region プライベートフィールド

        private AddImplementOfUnsignedLongLongInteger _imp_Add;
        private AndImplementOfUnsignedLongLongInteger _imp_And;
        private BitOperationImplementOfUnsignedLongLongInteger _imp_BitOperation;
        private CompareImplementOfUnsignedLongLongInteger _imp_Compare;
        private ComplementAndImplementOfUnsignedLongLongInteger _imp_ComplementAnd;
        private DivideRemImplementOfUnsignedLongLongInteger _imp_DivideRem;
        private EqualsImplementOfUnsignedLongLongInteger _imp_Equals;
        private IncrementDecrementImplementOfUnsignedLongLongInteger _imp_IncrementDecrement;
        private MultiplyImplementOfUnsignedLongLongInteger _imp_Multiply;
        private OrImplementOfUnsignedLongLongInteger _imp_Or;
        private SubtractImplementOfUnsignedLongLongInteger _imp_Subtract;
        private XorImplementOfUnsignedLongLongInteger _imp_Xor;

        #endregion

        #region コンストラクタ

        public ImplementOfUnsignedLongLongInteger()
        {
            _imp_Add = new AddImplementOfUnsignedLongLongInteger();
            _imp_And = new AndImplementOfUnsignedLongLongInteger();
            _imp_BitOperation = new BitOperationImplementOfUnsignedLongLongInteger();
            _imp_Compare = new CompareImplementOfUnsignedLongLongInteger();
            _imp_ComplementAnd = new ComplementAndImplementOfUnsignedLongLongInteger();
            _imp_DivideRem = new DivideRemImplementOfUnsignedLongLongInteger();
            _imp_Equals = new EqualsImplementOfUnsignedLongLongInteger();
            _imp_IncrementDecrement = new IncrementDecrementImplementOfUnsignedLongLongInteger();
            _imp_Multiply = new MultiplyImplementOfUnsignedLongLongInteger();
            _imp_Or = new OrImplementOfUnsignedLongLongInteger();
            _imp_Subtract = new SubtractImplementOfUnsignedLongLongInteger();
            _imp_Xor = new XorImplementOfUnsignedLongLongInteger();
        }

        #endregion

        #region パブリックメソッド

        #region Add のオーバーロード

        public ushort[] Add(ushort x, ushort y)
        {
            return (_imp_Add.Add(x, y));
        }

        public ushort[] Add(ushort[] x, ushort y)
        {
            return (_imp_Add.Add(x, y));
        }

        public ushort[] Add(ushort[] x, ushort[] y)
        {
            return (_imp_Add.Add(x, y));
        }

        #endregion

        #region Increment のオーバーロード

        public ushort[] Increment(ushort[] x)
        {
            return (_imp_IncrementDecrement.Increment(x));
        }

        #endregion

        #region Subtract のオーバーロード

        public ushort[] Subtract(ushort x, ushort y)
        {
            return (_imp_Subtract.Subtract(x, y));
        }

        public ushort[] Subtract(ushort[] x, ushort y)
        {
            return (_imp_Subtract.Subtract(x, y));
        }

        public ushort[] Subtract(ushort x, ushort[] y)
        {
            return (_imp_Subtract.Subtract(x, y));
        }

        public ushort[] Subtract(ushort[] x, ushort[] y)
        {
            return (_imp_Subtract.Subtract(x, y));
        }

        #endregion

        #region Decrement のオーバーロード

        public ushort[] Decrement(ushort[] x)
        {
            return (_imp_IncrementDecrement.Decrement(x));
        }

        #endregion

        #region Multiply のオーバーロード

        public ushort[] Multiply(ushort x, ushort y)
        {
            return (_imp_Multiply.Multiply(x, y));
        }

        public ushort[] Multiply(ushort[] x, ushort y)
        {
            return (_imp_Multiply.Multiply(x, y));
        }

        public ushort[] Multiply(ushort[] x, ushort[] y)
        {
            return (_imp_Multiply.Multiply(x, y));
        }

        #endregion

        #region Multiply10AndAddQuick のオーバーロード

        public ushort[] Multiply10AndAddQuick(ushort[] x, ushort y)
        {
            return (_imp_Multiply.Multiply10AndAddQuick(x, y));
        }

        #endregion

        #region Multiply16AndAddQuick のオーバーロード

        public ushort[] Multiply16AndAddQuick(ushort[] x, ushort y)
        {
            return (_imp_Multiply.Multiply16AndAddQuick(x, y));
        }

        #endregion

        #region DivRem のオーバーロード

        public ushort DivRem(ushort x, ushort y, out ushort r)
        {
            return (_imp_DivideRem.DivRem(x, y, out r));
        }

        public ulong DivRem(ulong x, ushort y, out ushort r)
        {
            return (_imp_DivideRem.DivRem(x, y, out r));
        }

        public ulong DivRem(ulong x, ulong y, out ulong r)
        {
            return (_imp_DivideRem.DivRem(x, y, out r));
        }

        public ushort[] DivRem(ushort[] x, ushort y, out ushort r)
        {
            return (_imp_DivideRem.DivRem(x, y, out r));
        }

        public ushort DivRem(ushort x, ushort[] y, out ushort r)
        {
            return (_imp_DivideRem.DivRem(x, y, out r));
        }

        public ushort[] DivRem(ushort[] x, ushort[] y, out ushort[] r)
        {
            return (_imp_DivideRem.DivRem(x, y, out r));
        }

        #endregion

        #region Equals のオーバーロード

        public bool Equals(ushort x, ushort y)
        {
            return (_imp_Equals.Equals(x, y));
        }

        public bool Equals(ushort[] x, ushort y)
        {
            return (_imp_Equals.Equals(x, y));
        }

        public bool Equals(ushort x, ushort[] y)
        {
            return (_imp_Equals.Equals(x, y));
        }

        public bool Equals(ushort[] x, ushort[] y)
        {
            return (_imp_Equals.Equals(x, y));
        }

        #endregion

        #region Compare のオーバーロード

        public int Compare(ushort x, ushort y)
        {
            return (_imp_Compare.Compare(x, y));
        }

        public int Compare(ushort[] x, ushort y)
        {
            return (_imp_Compare.Compare(x, y));
        }

        public int Compare(ushort x, ushort[] y)
        {
            return (_imp_Compare.Compare(x, y));
        }

        public int Compare(ushort[] x, ushort[] y)
        {
            return (_imp_Compare.Compare(x, y));
        }

        #endregion

        #region And のオーバーロード

        public ushort And(ushort x, ushort y)
        {
            return (_imp_And.And(x, y));
        }

        public ulong And(ulong x, ulong y)
        {
            return (_imp_And.And(x, y));
        }

        public ushort[] And(ushort[] x, ushort[] y)
        {
            return (_imp_And.And(x, y));
        }

        #endregion

        #region Or のオーバーロード

        public ushort Or(ushort x, ushort y)
        {
            return (_imp_Or.Or(x, y));
        }

        public ushort[] Or(ushort[] x, ushort y)
        {
            return (_imp_Or.Or(x, y));
        }

        public ushort[] Or(ushort[] x, ushort[] y)
        {
            return (_imp_Or.Or(x, y));
        }

        #endregion

        #region Xor のオーバーロード

        public ushort Xor(ushort x, ushort y)
        {
            return (_imp_Xor.Xor(x, y));
        }

        public ushort[] Xor(ushort[] x, ushort y)
        {
            return (_imp_Xor.Xor(x, y));
        }

        public ushort[] Xor(ushort[] x, ushort[] y)
        {
            return (_imp_Xor.Xor(x, y));
        }

        #endregion

        #region ComplementAnd のオーバーロード

        public ushort ComplementAnd(ushort x, ushort y)
        {
            return (_imp_ComplementAnd.ComplementAnd(x, y));
        }

        public ulong ComplementAnd(ulong x, ushort y)
        {
            return (_imp_ComplementAnd.ComplementAnd(x, y));
        }

        public ulong ComplementAnd(ulong x, ulong y)
        {
            return (_imp_ComplementAnd.ComplementAnd(x, y));
        }

        public ushort[] ComplementAnd(ushort[] x, ushort y)
        {
            return (_imp_ComplementAnd.ComplementAnd(x, y));
        }

        public ushort[] ComplementAnd(ushort[] x, ushort[] y)
        {
            return (_imp_ComplementAnd.ComplementAnd(x, y));
        }

        #endregion

        #region OnesComplement のオーバーロード

        public ushort[] OnesComplement(ushort[] x, int n)
        {
            return (_imp_BitOperation.OnesComplement(x, n));
        }

        #endregion

        #region Negate のオーバーロード

        public ushort[] Negate(ushort[] x, int n)
        {
            return (_imp_BitOperation.Negate(x, n));
        }

        #endregion

        #region Truncate のオーバーロード

        public ushort[] Truncate(ushort[] x, int n)
        {
            return (_imp_BitOperation.Truncate(x, n));
        }

        #endregion

        #region LeftShift のオーバーロード

        public ushort[] LeftShift(ushort[] x, int n)
        {
            return (_imp_BitOperation.LeftShift(x, n));
        }

        #endregion

        #region LeftShift1Quick のオーバーロード

        public ushort[] LeftShift1Quick(ushort[] x)
        {
            return (_imp_BitOperation.LeftShift1Quick(x));
        }

        #endregion

        #region RightShift のオーバーロード

        public ushort[] RightShift(ushort[] x, int n)
        {
            return (_imp_BitOperation.RightShift(x, n));
        }

        #endregion

        #region RightShift1Quick のオーバーロード

        public ushort[] RightShift1Quick(ushort[] x)
        {
            return (_imp_BitOperation.RightShift1Quick(x));
        }

        #endregion

        #region SetBit のオーバーロード

        public ushort[] SetBit(ushort[] x, int pos)
        {
            return (_imp_BitOperation.SetBit(x, pos));
        }

        #endregion

        #region ClearBit のオーバーロード

        public ushort[] ClearBit(ushort[] x, int pos)
        {
            return (_imp_BitOperation.ClearBit(x, pos));
        }

        #endregion

        #region TestBit のオーバーロード

        public bool TestBit(ushort[] x, int pos)
        {
            return (_imp_BitOperation.TestBit(x, pos));
        }

        #endregion

        #region GetBitLength のオーバーロード

        public int GetBitLength(ushort[] x)
        {
            return (_imp_BitOperation.GetBitLength(x));
        }

        #endregion

        #region GetIsPowerOfTwo のオーバーロード

        public bool GetIsPowerOfTwo(ushort[] x)
        {
            return (_imp_BitOperation.GetIsPowerOfTwo(x));
        }

        #endregion

        #endregion
    }
}