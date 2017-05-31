/*
  LongLongInteger.Bit.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// ���Z�q�̃I�[�o�[���[�h�Ɋւ���K�C�h���C��:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct LongLongInteger
    {
        #region ���Z�q

#if !CONCEAL_OPERATORS

        #region ~ �̃I�[�o�[���[�h

        /// <summary>
        /// �����̃r�b�g���̔ے��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator ~(LongLongInteger x)
        {
            return (OnesComplement(x));
        }

        #endregion

        #region << �̃I�[�o�[���[�h

        /// <summary>
        /// ��������V�t�g���܂��B
        /// </summary>
        /// <param name="x">
        /// �V�t�g�Ώۂ̐����ł��B
        /// </param>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator <<(LongLongInteger x, int n)
        {
            return (LeftShift(x, n));
        }

        #endregion

        #region >> �̃I�[�o�[���[�h

        /// <summary>
        /// ������E�V�t�g���܂��B
        /// </summary>
        /// <param name="x">
        /// �V�t�g�Ώۂ̐����ł��B
        /// </param>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator >>(LongLongInteger x, int n)
        {
            return (RightShift(x, n));
        }

        #endregion

        #region & �̃I�[�o�[���[�h

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator &(long x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static ulong operator &(ulong x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger operator &(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator &(LongLongInteger x, long y)
        {
            return (BitwiseAnd(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static ulong operator &(LongLongInteger x, ulong y)
        {
            return (BitwiseAnd(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger operator &(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (BitwiseAnd(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator &(LongLongInteger x, LongLongInteger y)
        {
            return (BitwiseAnd(x, y));
        }

        #endregion

        #region | �̃I�[�o�[���[�h

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator |(long x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator |(ulong x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator |(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator |(LongLongInteger x, long y)
        {
            return (BitwiseOr(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator |(LongLongInteger x, ulong y)
        {
            return (BitwiseOr(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator |(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (BitwiseOr(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator |(LongLongInteger x, LongLongInteger y)
        {
            return (BitwiseOr(x, y));
        }

        #endregion

        #region ^ �̃I�[�o�[���[�h

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator ^(long x, LongLongInteger y)
        {
            return (Xor(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator ^(ulong x, LongLongInteger y)
        {
            return (Xor(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator ^(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Xor(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator ^(LongLongInteger x, long y)
        {
            return (Xor(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator ^(LongLongInteger x, ulong y)
        {
            return (Xor(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator ^(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Xor(x, y));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator ^(LongLongInteger x, LongLongInteger y)
        {
            return (Xor(x, y));
        }

        #endregion

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        #region OnesComplement �̃I�[�o�[���[�h

        // ����: ~x == -x - 1 == -(x + 1)

        /// <summary>
        /// �^����ꂽ�����̃r�b�g���̔ے��v�Z���܂��B
        /// </summary>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger OnesComplement()
        {
            return (OnesComplement(this));
        }

        /// <summary>
        /// �����̃r�b�g���̔ے��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger OnesComplement(UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                return (MinusOne);
            else
                return (x.Increment().Negate());
        }

        /// <summary>
        /// �����̃r�b�g���̔ے��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger OnesComplement(LongLongInteger x)
        {
            if (x._sign == SignType.Zero)
                return (MinusOne);
            else if (x._sign == SignType.Positive)
                return (x._abs.Increment().Negate());
            else
                return (x._abs.Decrement().ToLongLongInteger());
        }

        #endregion

        #region LeftShift �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ��������V�t�g���܂��B
        /// </summary>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger LeftShift(int n)
        {
            return (LeftShift(this, n));
        }

        /// <summary>
        /// ��������V�t�g���܂��B
        /// </summary>
        /// <param name="x">
        /// �V�t�g�Ώۂ̐����ł��B
        /// </param>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger LeftShift(LongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("�V�t�g�񐔂͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "n"));
            if (n == 0)
                return (x);
            if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.LeftShift(n)));
        }

        #endregion

        #region RightShift �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ������E�V�t�g���܂��B
        /// </summary>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger RightShift(int n)
        {
            return (RightShift(this, n));
        }

        /// <summary>
        /// ������E�V�t�g���܂��B
        /// </summary>
        /// <param name="x">
        /// �V�t�g�Ώۂ̐����ł��B
        /// </param>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger RightShift(LongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("�V�t�g�񐔂͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "n"));
            if (n == 0)
                return (x);
            if (x._sign == SignType.Zero)
                return (Zero);
            else if (x._sign == SignType.Positive)
                return (x._abs.RightShift(n).ToLongLongInteger());
            else
                return (x._abs.Decrement().RightShift(n).Increment().Negate());
        }

        #endregion

        #region TruncateBit �̃I�[�o�[���[�h

        /// <summary>
        /// ���ʂ���n�r�b�g��������đS�Ẵr�b�g��0�ɂ����l��v�Z���܂��B
        /// </summary>
        /// <param name="n">
        /// �ێ�����r�b�g�̐��ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger TruncateBit(int n)
        {
            if (n < 0)
                throw (new ArgumentException("�r�b�g�̐��͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "n"));
            if (n == 0)
                return (UnsignedLongLongInteger.Zero);
            else if (_sign == SignType.Zero)
                return (UnsignedLongLongInteger.Zero);
            else if (_sign == SignType.Positive)
                return (_abs.TruncateBit(n));
            else
                return (_abs.Negate(n));
        }

        #endregion

        #region TestBit �̃I�[�o�[���[�h

        /// <summary>
        /// ����ЂƂ̃r�b�g��1���ǂ����𒲂ׂ܂��B
        /// ����� (this &amp; (1 &lt;&lt; n)) != 0 �Ɠ����ł��B 
        /// </summary>
        /// <param name="pos">
        /// ���ׂ�r�b�g�̈ʒu�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public bool TestBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("�r�b�g�̈ʒu�͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "pos"));
            if (_sign == SignType.Zero)
                return (false);
            else if (_sign == SignType.Positive)
                return (_abs.TestBit(pos));
            else
                return (!_abs.Decrement().TestBit(pos));
        }

        #endregion

        #region SetBit �̃I�[�o�[���[�h

        /// <summary>
        /// ����ЂƂ̃r�b�g��Z�b�g�����l��v�Z���܂��B
        /// </summary>
        /// <param name="pos">
        /// �Z�b�g����r�b�g�̈ʒu�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger SetBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("�r�b�g�̈ʒu�͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "pos"));
            if (_sign == SignType.Zero)
                return (UnsignedLongLongInteger.One.LeftShift(pos).ToLongLongInteger());
            else if (_sign == SignType.Positive)
                return (_abs.SetBit(pos).ToLongLongInteger());
            else
                return (_abs.Decrement().ClearBit(pos).Increment().Negate());
        }

        #endregion

        #region ClearBit �̃I�[�o�[���[�h

        /// <summary>
        /// ����ЂƂ̃r�b�g��N���A�����l��v�Z���܂��B
        /// </summary>
        /// <param name="pos">
        /// �N���A����r�b�g�̈ʒu�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger ClearBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("�r�b�g�̈ʒu�͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "pos"));
            if (_sign == SignType.Zero)
                return (Zero);
            else if (_sign == SignType.Positive)
                return (_abs.ClearBit(pos).ToLongLongInteger());
            else
                return (_abs.Decrement().SetBit(pos).Increment().Negate());
        }

        #endregion

        #region BitwiseAnd �̃I�[�o�[���[�h

        // z = x & y�ɂāAx��y�̂ǂ��炩�܂��͗��������̏ꍇ�ɂ͈ȉ��̂悤�ɕό`����B
        //
        // 1) x < 0, y > 0�̂Ƃ��A
        // ���� t == ~(-t - 1)���
        // z = ~(|x| - 1) & y
        //
        // 2) x < 0, y < 0�̂Ƃ��A
        // ���� t == ~(-t - 1)���
        // ~(-z - 1) = ~(|x| - 1) & ~(|y| - 1)
        // (-z - 1) = (|x| - 1) | (|y| - 1)
        // z = -( (|x| - 1) | (|y| - 1) + 1 )

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger BitwiseAnd(long x)
        {
            return (BitwiseAnd(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public ulong BitwiseAnd(ulong x)
        {
            return (BitwiseAnd(this, x));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger BitwiseAnd(UnsignedLongLongInteger x)
        {
            return (BitwiseAnd(this, x));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger BitwiseAnd(LongLongInteger x)
        {
            return (BitwiseAnd(this, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseAnd(long x, LongLongInteger y)
        {
            return (BitwiseAnd(y, new LongLongInteger(x)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static ulong BitwiseAnd(ulong x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger BitwiseAnd(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseAnd(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseAnd(LongLongInteger x, long y)
        {
            return (BitwiseAnd(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static ulong BitwiseAnd(LongLongInteger x, ulong y)
        {
            if (x._sign == SignType.Zero || y == 0)
                return (0);
            if (x._sign == SignType.Positive)
                return (x._abs.BitwiseAnd(y));
            else
                return (y.BitwiseComplementAnd(x._abs.Decrement()));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger BitwiseAnd(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero || y.IsZero)
                return (UnsignedLongLongInteger.Zero);
            if (x._sign == SignType.Positive)
                return (x._abs.BitwiseAnd(y));
            else
                return (y.BitwiseComplementAnd(x._abs.Decrement()));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���ς�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseAnd(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero || y._sign == SignType.Zero)
                return (Zero);
            if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (x._abs.BitwiseAnd(y._abs).ToLongLongInteger());
                else
                    return (x._abs.BitwiseComplementAnd(y._abs.Decrement()).ToLongLongInteger());
            }
            else
            {
                if (y._sign == SignType.Positive)
                    return (y._abs.BitwiseComplementAnd(x._abs.Decrement()).ToLongLongInteger());
                else
                    return (x._abs.Decrement().BitwiseOr(y._abs.Decrement()).Increment().Negate());
            }
        }

        #endregion

        #region BitwiseOr �̃I�[�o�[���[�h

        // z = x | y�ɂāAx��y�̂ǂ��炩�܂��͗��������̏ꍇ�ɂ͈ȉ��̂悤�ɕό`����B
        //
        // 1) x < 0, y > 0�̂Ƃ��A
        // ~z = ~x | ~y
        // ���� t == ~(-t - 1)���
        // z = -(((|x| - 1) & ~y) + 1)
        //
        // 2) x < 0, y < 0�̂Ƃ��A
        // ���� t == ~(-t - 1)���
        // ~(-z - 1) = ~(|x| - 1) | ~(|y| - 1)
        // (-z - 1) = (|x| - 1) & (|y| - 1)
        // z = -( (|x| - 1) & (|y| - 1) + 1 )

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger BitwiseOr(long x)
        {
            return (BitwiseOr(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger BitwiseOr(ulong x)
        {
            return (BitwiseOr(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger BitwiseOr(UnsignedLongLongInteger x)
        {
            return (BitwiseOr(this, x));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger BitwiseOr(LongLongInteger x)
        {
            return (BitwiseOr(this, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseOr(long x, LongLongInteger y)
        {
            return (BitwiseOr(y, new LongLongInteger(x)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger BitwiseOr(ulong x, LongLongInteger y)
        {
            return (BitwiseOr(y, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseOr(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (BitwiseOr(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseOr(LongLongInteger x, long y)
        {
            return (BitwiseOr(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger BitwiseOr(LongLongInteger x, ulong y)
        {
            return (BitwiseOr(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseOr(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y.ToLongLongInteger());
            if (y.IsZero)
                return (x);
            if (x._sign == SignType.Positive)
                return (x._abs.BitwiseOr(y).ToLongLongInteger());
            else
                return (x._abs.Decrement().BitwiseComplementAnd(y).Increment().Negate());
        }

        /// <summary>
        /// ��̐����̃r�b�g���̘_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger BitwiseOr(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y);
            if (y._sign == SignType.Zero)
                return (x);
            if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (x._abs.BitwiseOr(y._abs).ToLongLongInteger());
                else
                    return (y._abs.Decrement().BitwiseComplementAnd(x._abs).Increment().Negate());
            }
            else
            {
                if (y._sign == SignType.Positive)
                    return (x._abs.Decrement().BitwiseComplementAnd(y._abs).Increment().Negate());
                else
                    return (x._abs.Decrement().BitwiseAnd(y._abs.Decrement()).Increment().Negate());
            }
        }

        #endregion

        #region Xor �̃I�[�o�[���[�h

        // z = (x & ~y) | (~x & y)�ɂāAx��y�̂ǂ��炩�܂��͗��������̏ꍇ�ɂ͈ȉ��̂悤�ɕό`����B
        //
        // 1) x < 0, y > 0�̂Ƃ��A
        // ~z = ~(x & ~y | (~x & y))
        // ~z = ~(x & ~y) & ~(~x & y)
        // ~z = (~x | y) & ~(~x & y)
        // ���� t == ~(-t - 1)���
        // z = -((((|x| - 1) | y) & ~((|x| - 1) & y)) + 1)
        // 
        // 2) x < 0, y < 0�̂Ƃ��A
        // z = (x & ~y) | (~x & y)
        // ���� t == ~(-t - 1)���
        // z = (~(|x| - 1) & (|y| - 1)) | ((|x| - 1) & ~(|y| - 1))

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Xor(long x)
        {
            return (Xor(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Xor(ulong x)
        {
            return (Xor(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Xor(UnsignedLongLongInteger x)
        {
            return (Xor(this, x));
        }

        /// <summary>
        /// �^����ꂽ�����Ƃ̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Xor(LongLongInteger x)
        {
            return (Xor(this, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Xor(long x, LongLongInteger y)
        {
            return (Xor(y, new LongLongInteger(x)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Xor(ulong x, LongLongInteger y)
        {
            return (Xor(y, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Xor(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Xor(y, x));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Xor(LongLongInteger x, long y)
        {
            return (Xor(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Xor(LongLongInteger x, ulong y)
        {
            return (Xor(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Xor(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y.ToLongLongInteger());
            if (y.IsZero)
                return (x);
            if (x._sign == SignType.Positive)
                return (y.BitwiseComplementAnd(x._abs).BitwiseOr(x._abs.BitwiseComplementAnd(y)).ToLongLongInteger());
            else
            {
                UnsignedLongLongInteger x2 = x._abs.Decrement();
                return (x2.BitwiseOr(y).BitwiseComplementAnd(x2.BitwiseAnd(y)).Increment().Negate());
            }
        }

        /// <summary>
        /// ��̐����̃r�b�g���̔r���I�_���a��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Xor(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y);
            if (y._sign == SignType.Zero)
                return (x);
            if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (y._abs.BitwiseComplementAnd(x._abs).BitwiseOr(x._abs.BitwiseComplementAnd(y._abs)).ToLongLongInteger());
                else
                {
                    UnsignedLongLongInteger x2 = x._abs;
                    UnsignedLongLongInteger y2 = y._abs.Decrement();
                    return (x2.BitwiseOr(y2).BitwiseComplementAnd(x2.BitwiseAnd(y2)).Increment().Negate());
                }
            }
            else
            {
                if (y._sign == SignType.Positive)
                {
                    UnsignedLongLongInteger x2 = x._abs.Decrement();
                    UnsignedLongLongInteger y2 = y._abs;
                    return (x2.BitwiseOr(y2).BitwiseComplementAnd(x2.BitwiseAnd(y2)).Increment().Negate());
                }
                else
                {
                    UnsignedLongLongInteger x2 = x._abs.Decrement();
                    UnsignedLongLongInteger y2 = y._abs.Decrement();
                    return (y2.BitwiseComplementAnd(x2).BitwiseOr(x2.BitwiseComplementAnd(y2)).ToLongLongInteger());
                }
            }
        }

        #endregion

        #endregion

        #region �p�u���b�N�v���p�e�B

        /// <summary>
        /// �I�u�W�F�N�g��r�b�g�z��Ƃ��Č����ꍇ�̔z��̒����ł��B
        /// </summary>
        /// <remarks>
        /// ���̃v���p�e�B�̒l�͈ȉ��̒�`�ɂ�苁�߂��܂��B
        /// this�����܂���0�̏ꍇ: this + 1 &lt;= (1 &lt;&lt; n) �ł���ŏ���n
        /// this�����̏ꍇ: -this &lt;= (1 &lt;&lt; n) �ł���ŏ���n
        /// </remarks>
        public int BitLength
        {
            get
            {
                if (!_bit_length_cache.HasValue)
                    _bit_length_cache = GetBitLength();
                return (_bit_length_cache.Value);
            }
        }

        /// <summary>
        /// �I�u�W�F�N�g��2�ׂ̂���ł���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsPowerOfTwo
        {
            get
            {
                if (!_is_power_of_two_cache.HasValue)
                    _is_power_of_two_cache = GetIsPowerOfTwo();
                return (_is_power_of_two_cache.Value);
            }
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        private int GetBitLength()
        {
            if (_sign == SignType.Positive)
                return (_abs.BitLength);
            else if (_sign == SignType.Zero)
                return (0);
            else
                return (_abs.Decrement().BitLength);
        }

        private bool GetIsPowerOfTwo()
        {
            return (_sign == SignType.Positive && _abs.IsPowerOfTwo);
        }

        #endregion
    }
}
