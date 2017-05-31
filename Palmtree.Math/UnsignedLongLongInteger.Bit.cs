/*
  UnsignedLongLongInteger.Bit.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// ���Z�q�̃I�[�o�[���[�h�Ɋւ���K�C�h���C��:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct UnsignedLongLongInteger
    {
        #region ���Z�q

#if !CONCEAL_OPERATORS

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
        public static UnsignedLongLongInteger operator <<(UnsignedLongLongInteger x, int n)
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
        public static UnsignedLongLongInteger operator >>(UnsignedLongLongInteger x, int n)
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
        [CLSCompliant(false)]
        public static ulong operator &(ulong x, UnsignedLongLongInteger y)
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
        public static ulong operator &(UnsignedLongLongInteger x, ulong y)
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
        public static UnsignedLongLongInteger operator &(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (BitwiseAnd(x, y));
        }

        #endregion

        #region || �̃I�[�o�[���[�h

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
        public static UnsignedLongLongInteger operator |(ulong x, UnsignedLongLongInteger y)
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
        public static UnsignedLongLongInteger operator |(UnsignedLongLongInteger x, ulong y)
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
        public static UnsignedLongLongInteger operator |(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator ^(ulong x, UnsignedLongLongInteger y)
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
        public static UnsignedLongLongInteger operator ^(UnsignedLongLongInteger x, ulong y)
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
        public static UnsignedLongLongInteger operator ^(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Xor(x, y));
        }

        #endregion

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        #region OnesComplement �̃I�[�o�[���[�h

        /// <summary>
        /// �r�b�g���̔ے��v�Z���A���ʂ���n�r�b�g���̂ݎ��o���܂��B
        /// ����� (~this).Truncate(n) �Ɠ����ł��B
        /// </summary>
        /// <param name="n">
        /// ���o���r�b�g�̐��ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger OnesComplement(int n)
        {
            return (OnesComplement(this, n));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�̃r�b�g���̔ے��v�Z���A���ʂ���n�r�b�g���̂ݎ��o���܂��B
        /// ����� (~this).Truncate(n) �Ɠ����ł��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="n">
        /// ���o���r�b�g�̐��ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger OnesComplement(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("�r�b�g�̐��͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "n"));
            if (n == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.OnesComplement(x._InternalValue, n)));
        }

        #endregion

        #region Negative �̃I�[�o�[���[�h

        /// <summary>
        /// ���������]�����l��v�Z���A���ʂ���n�r�b�g���̂ݎ��o���܂��B
        /// ����� (-this).Truncate(n) �Ɠ����ł��B
        /// </summary>
        /// <param name="n">
        /// ���o���r�b�g�̐��ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger Negate(int n)
        {
            return (Negate(this, n));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�̕��������]�����l��v�Z���A���ʂ���n�r�b�g���̂ݎ��o���܂��B
        /// ����� (-this).Truncate(n) �Ɠ����ł��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="n">
        /// ���o���r�b�g�̐��ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Negate(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("�r�b�g�̐��͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "n"));
            if (n == 0)
                return (Zero);
            else if (x._InternalValue.Length == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.Negate(x._InternalValue, n)));
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
                return (Zero);
            else if (_InternalValue.Length == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.Truncate(_InternalValue, n)));
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
            if (_InternalValue.Length == 0)
                return (false);
            else
                return (_imp.TestBit(_InternalValue, pos));
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
        public UnsignedLongLongInteger SetBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("�r�b�g�̈ʒu�͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "pos"));
            if (_InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(_imp.LeftShift(new ushort[] { 1 }, pos)));
            else
                return (new UnsignedLongLongInteger(_imp.SetBit(_InternalValue, pos)));
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
        public UnsignedLongLongInteger ClearBit(int pos)
        {
            if (pos < 0)
                throw (new ArgumentException("�r�b�g�̈ʒu�͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "pos"));
            if (_InternalValue.Length == 0)
                return (Zero);
            else
                return (new UnsignedLongLongInteger(_imp.ClearBit(_InternalValue, pos)));
        }

        #endregion

        #region Xor �̃I�[�o�[���[�h

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
        public UnsignedLongLongInteger Xor(ulong x)
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
        public UnsignedLongLongInteger Xor(UnsignedLongLongInteger x)
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Xor(ulong x, UnsignedLongLongInteger y)
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
        public static UnsignedLongLongInteger Xor(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(y));
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.Xor(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.Xor(x._InternalValue, CreateInternalValue(y))));
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
        public static UnsignedLongLongInteger Xor(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (y);
            else if (y._InternalValue.Length == 0)
                return (x);
            else
                return (new UnsignedLongLongInteger(_imp.Xor(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region BitwiseAnd �̃I�[�o�[���[�h

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
        public static ulong BitwiseAnd(ulong x, UnsignedLongLongInteger y)
        {
            if (x == 0 || y._InternalValue.Length == 0)
                return (0);
            else if (x <= ushort.MaxValue || y._InternalValue.Length == 1)
                return (_imp.And((ushort)x, y._InternalValue[0]));
            else
                return (_imp.And(x, ToULong(y._InternalValue)));
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
        public static ulong BitwiseAnd(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0 || y == 0)
                return (0);
            else if (x._InternalValue.Length == 1 || y <= ushort.MaxValue)
                return (_imp.And(x._InternalValue[0], (ushort)y));
            else
                return (_imp.And(ToULong(x._InternalValue), y));
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
        public static UnsignedLongLongInteger BitwiseAnd(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0 || y._InternalValue.Length == 0)
                return (Zero);
            else if (x._InternalValue.Length == 1 || y._InternalValue.Length == 1)
                return (new UnsignedLongLongInteger(_imp.And(x._InternalValue[0], y._InternalValue[0])));
            else
                return (new UnsignedLongLongInteger(_imp.And(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region BitwiseOr �̃I�[�o�[���[�h

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
        public UnsignedLongLongInteger BitwiseOr(ulong x)
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
        public UnsignedLongLongInteger BitwiseOr(UnsignedLongLongInteger x)
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
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger BitwiseOr(ulong x, UnsignedLongLongInteger y)
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
        public static UnsignedLongLongInteger BitwiseOr(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (new UnsignedLongLongInteger(y));
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.Or(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.Or(x._InternalValue, CreateInternalValue(y))));
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
        public static UnsignedLongLongInteger BitwiseOr(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (y);
            else if (y._InternalValue.Length == 0)
                return (x);
            else
                return (new UnsignedLongLongInteger(_imp.Or(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region BitwiseComplementAnd �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�����̔ے�Ƃ̘_����(x &amp; ~y)��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger BitwiseComplementAnd(ulong x)
        {
            return (BitwiseComplementAnd(this, x));
        }

        /// <summary>
        /// �^����ꂽ�����̔ے�Ƃ̘_����(x &amp; ~y)��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x)
        {
            return (BitwiseComplementAnd(this, x));
        }

        /// <summary>
        /// ���鐮���ƁA����ЂƂ̐����̔ے�̘_����(x &amp; ~y)��v�Z���܂��B
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
        public static UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y == 0)
                return (x);
            else if (y <= ushort.MaxValue)
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, (ushort)y)));
            else
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, CreateInternalValue(y))));
        }

        /// <summary>
        /// ���鐮���ƁA����ЂƂ̐����̔ے�̘_����(x &amp; ~y)��v�Z���܂��B
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
        public static ulong BitwiseComplementAnd(ulong x, UnsignedLongLongInteger y)
        {
            if (x == 0)
                return (0);
            else if (y._InternalValue.Length == 0)
                return (x);
            else if (x <= ushort.MaxValue)
                return (_imp.ComplementAnd((ushort)x, y._InternalValue[0]));
            else if (y._InternalValue.Length == 1)
                return (_imp.ComplementAnd(x, y._InternalValue[0]));
            else
                return (_imp.ComplementAnd(x, ToULong(y._InternalValue)));
        }

        /// <summary>
        /// ���鐮���ƁA����ЂƂ̐����̔ے�̘_����(x &amp; ~y)��v�Z���܂��B
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
        public static UnsignedLongLongInteger BitwiseComplementAnd(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (Zero);
            else if (y._InternalValue.Length == 0)
                return (x);
            else if (x._InternalValue.Length == 1)
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue[0], y._InternalValue[0])));
            else if (y._InternalValue.Length == 1)
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, y._InternalValue[0])));
            else
                return (new UnsignedLongLongInteger(_imp.ComplementAnd(x._InternalValue, y._InternalValue)));
        }

        #endregion

        #region LeftShift �̃I�[�o�[���[�h

        /// <summary>
        /// ��������V�t�g���܂��B
        /// </summary>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger LeftShift(int n)
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
        public static UnsignedLongLongInteger LeftShift(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("�V�t�g�񐔂͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "n"));
            if (n == 0)
                return (x);
            if (x._InternalValue.Length == 0)
                return (Zero);
            return (new UnsignedLongLongInteger(_imp.LeftShift(x._InternalValue, n)));
        }

        #endregion

        #region RightShift �̃I�[�o�[���[�h

        /// <summary>
        /// ������E�V�t�g���܂��B
        /// </summary>
        /// <param name="n">
        /// �V�t�g����r�b�g���ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger RightShift(int n)
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
        public static UnsignedLongLongInteger RightShift(UnsignedLongLongInteger x, int n)
        {
            if (n < 0)
                throw (new ArgumentException("�V�t�g�񐔂͐��܂���0�łȂ��Ă͂Ȃ�܂���B", "n"));
            if (n == 0)
                return (x);
            if (x._InternalValue.Length == 0)
                return (Zero);
            return (new UnsignedLongLongInteger(_imp.RightShift(x._InternalValue, n)));
        }

        #endregion

        #endregion

        #region �p�u���b�N�v���p�e�B

        /// <summary>
        /// �I�u�W�F�N�g��r�b�g�z��Ƃ��Č����ꍇ�̔z��̒����ł��B
        /// </summary>
        /// <remarks>
        /// ���̃v���p�e�B�̒l�͈ȉ��̒�`�ɂ�苁�߂��܂��B
        /// this + 1 &lt;= (1 &lt;&lt; n) �ł���ŏ���n
        /// </remarks>
        public int BitLength
        {
            get
            {
                if (!_bit_length_cache.HasValue)
                    _bit_length_cache = _InternalValue.Length == 0 ? 0 : _imp.GetBitLength(_InternalValue);
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
                    _is_power_of_two_cache = _InternalValue.Length > 0 && _imp.GetIsPowerOfTwo(_InternalValue);
                return (_is_power_of_two_cache.Value);
            }
        }

        #endregion
    }
}
