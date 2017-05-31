/*
  LongLongInteger.Arithmetic.cs

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

        #region �P�� + ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g����̂܂ܕԂ��܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x�ɓ������I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x)
        {
            return (x);
        }

        #endregion

        #region �P�� - ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// �I�u�W�F�N�g�̕������]��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x�̕������]�̌��ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x)
        {
            return (Negate(x));
        }

        #endregion

        #region �P�� ++ ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// ������C���N�������g���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̐����ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator ++(LongLongInteger x)
        {
            return (Increment(x));
        }

        #endregion

        #region �P�� -- ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// ������f�N�������g���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̐����ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator --(LongLongInteger x)
        {
            return (Decrement(x));
        }

        #endregion

        #region �� + ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator +(long x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator +(ulong x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator +(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x, long y)
        {
            return (Add(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator +(LongLongInteger x, ulong y)
        {
            return (Add(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Add(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator +(LongLongInteger x, LongLongInteger y)
        {
            return (Add(x, y));
        }

        #endregion

        #region �� - ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator -(long x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator -(ulong x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator -(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x, long y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator -(LongLongInteger x, ulong y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Subtract(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator -(LongLongInteger x, LongLongInteger y)
        {
            return (Subtract(x, y));
        }

        #endregion

        #region �� * ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator *(long x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator *(ulong x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator *(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator *(LongLongInteger x, long y)
        {
            return (Multiply(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator *(LongLongInteger x, ulong y)
        {
            return (Multiply(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator *(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Multiply(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator *(LongLongInteger x, LongLongInteger y)
        {
            return (Multiply(x, y));
        }

        #endregion

        #region �� / ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator /(long x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator /(ulong x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator /(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator /(LongLongInteger x, long y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator /(LongLongInteger x, ulong y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator /(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Divide(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator /(LongLongInteger x, LongLongInteger y)
        {
            return (Divide(x, y));
        }

        #endregion

        #region �� % ���Z�q�̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator %(long x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger operator %(ulong x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger operator %(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator %(LongLongInteger x, long y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger operator %(LongLongInteger x, ulong y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator %(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Mod(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B(r = x - q * y, q = x / y)
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger operator %(LongLongInteger x, LongLongInteger y)
        {
            return (Mod(x, y));
        }

        #endregion

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        #region Add �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Add(long x)
        {
            return (Add(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Add(ulong x)
        {
            return (Add(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Add(UnsignedLongLongInteger x)
        {
            return (Add(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Add(LongLongInteger x)
        {
            return (Add(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Add(long x, LongLongInteger y)
        {
            return (Add(y, new LongLongInteger(x)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Add(ulong x, LongLongInteger y)
        {
            return (Add(y, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Add(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Add(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Add(LongLongInteger x, long y)
        {
            return (Add(x, new LongLongInteger(y)));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Add(LongLongInteger x, ulong y)
        {
            return (Add(x, new UnsignedLongLongInteger(y)));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Add(LongLongInteger x, UnsignedLongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y.IsZero ? Zero : y.ToLongLongInteger());
                case SignType.Positive:
                    return (y.IsZero ? x : x._abs.Add(y).ToLongLongInteger());
                default:
                    return (y.IsZero ? x : Subtract(y, x._abs));
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̉��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Add(LongLongInteger x, LongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y);
                case SignType.Positive:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (x._abs.Add(y._abs).ToLongLongInteger());
                        default:
                            return (Subtract(x._abs, y._abs));
                    }
                default:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (Subtract(y._abs, x._abs));
                        default:
                            return (x._abs.Add(y._abs).Negate());
                    }
            }
        }

        #endregion

        #region Subtract �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Subtract(long x)
        {
            return (Subtract(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Subtract(ulong x)
        {
            return (Subtract(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Subtract(UnsignedLongLongInteger x)
        {
            return (Subtract(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Subtract(LongLongInteger x)
        {
            return (Subtract(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Subtract(long x, LongLongInteger y)
        {
            return (Subtract(new LongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Subtract(ulong x, LongLongInteger y)
        {
            return (Subtract(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Subtract(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (x.IsZero)
                return (y._sign == SignType.Zero ? Zero : new LongLongInteger(y._sign.Negate(), y._abs));
            else
            {
                switch (y._sign)
                {
                    case SignType.Zero:
                        return (x.ToLongLongInteger());
                    case SignType.Positive:
                        return (Subtract(x, y._abs));
                    default:
                        return (x.Add(y._abs).ToLongLongInteger());
                }
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Subtract(LongLongInteger x, long y)
        {
            return (Subtract(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Subtract(LongLongInteger x, ulong y)
        {
            return (Subtract(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Subtract(LongLongInteger x, UnsignedLongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y.IsZero ? Zero : y.Negate());
                case SignType.Positive:
                    return (y.IsZero ? x : Subtract(x._abs, y));
                default:
                    return (y.IsZero ? x : x._abs.Add(y).Negate());
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̌��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x����y����Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Subtract(LongLongInteger x, LongLongInteger y)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (y._sign == SignType.Zero ? Zero : new LongLongInteger(y._sign.Negate(), y._abs));
                case SignType.Positive:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (Subtract(x._abs, y._abs));
                        default:
                            return (x._abs.Add(y._abs).ToLongLongInteger());
                    }
                default:
                    switch (y._sign)
                    {
                        case SignType.Zero:
                            return (x);
                        case SignType.Positive:
                            return (x._abs.Add(y._abs).Negate());
                        default:
                            return (Subtract(y._abs, x._abs));
                    }
            }
        }

        #endregion

        #region Increment �̃I�[�o�[���[�h

        /// <summary>
        /// ������C���N�������g���܂��B
        /// </summary>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Increment()
        {
            return (Increment(this));
        }

        /// <summary>
        /// ������C���N�������g���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̐����ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Increment(LongLongInteger x)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (One);
                case SignType.Positive:
                    return (x._abs.Increment().ToLongLongInteger());
                default:
                    return (x._abs.Decrement().Negate());
            }
        }

        #endregion

        #region Decrement �̃I�[�o�[���[�h

        /// <summary>
        /// ������f�N�������g���܂��B
        /// </summary>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Decrement()
        {
            return (Decrement(this));
        }

        /// <summary>
        /// ������f�N�������g���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̐����ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Decrement(LongLongInteger x)
        {
            switch (x._sign)
            {
                case SignType.Zero:
                    return (MinusOne);
                case SignType.Positive:
                    return (x._abs.Decrement().ToLongLongInteger());
                default:
                    return (x._abs.Increment().Negate());
            }
        }

        #endregion

        #region Multiply �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Multiply(long x)
        {
            return (Multiply(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Multiply(ulong x)
        {
            return (Multiply(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Multiply(UnsignedLongLongInteger x)
        {
            return (Multiply(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Multiply(LongLongInteger x)
        {
            return (Multiply(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Multiply(long x, LongLongInteger y)
        {
            return (Multiply(y, new LongLongInteger(x)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Multiply(ulong x, LongLongInteger y)
        {
            return (Multiply(y, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Multiply(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Multiply(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Multiply(LongLongInteger x, long y)
        {
            return (Multiply(x, new LongLongInteger(y)));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Multiply(LongLongInteger x, ulong y)
        {
            return (Multiply(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Multiply(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero || y.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Multiply(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Multiply(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero || x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Multiply(y._sign), x._abs.Multiply(y._abs)));
        }

        #endregion

        #region Divide �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Divide(long x)
        {
            return (Divide(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Divide(ulong x)
        {
            return (Divide(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Divide(UnsignedLongLongInteger x)
        {
            return (Divide(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Divide(LongLongInteger x)
        {
            return (Divide(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Divide(long x, LongLongInteger y)
        {
            return (Divide(new LongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Divide(ulong x, LongLongInteger y)
        {
            return (Divide(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Divide(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(y._sign, x.Divide(y._abs)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Divide(LongLongInteger x, long y)
        {
            return (Divide(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Divide(LongLongInteger x, ulong y)
        {
            return (Divide(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Divide(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Divide(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Divide(LongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Divide(y._sign), x._abs.Divide(y._abs)));
        }

        #endregion

        #region DivideExactly �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger DivideExactly(long x)
        {
            return (DivideExactly(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger DivideExactly(ulong x)
        {
            return (DivideExactly(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger DivideExactly(UnsignedLongLongInteger x)
        {
            return (DivideExactly(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger DivideExactly(LongLongInteger x)
        {
            return (DivideExactly(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivideExactly(long x, LongLongInteger y)
        {
            return (DivideExactly(new LongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivideExactly(ulong x, LongLongInteger y)
        {
            return (DivideExactly(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivideExactly(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(y._sign, x.DivideExactly(y._abs)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivideExactly(LongLongInteger x, long y)
        {
            return (DivideExactly(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivideExactly(LongLongInteger x, ulong y)
        {
            return (DivideExactly(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivideExactly(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.DivideExactly(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Z��s���܂��B
        /// ����؂�Ȃ��ꍇ�ɂ͗�O���������܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivideExactly(LongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Divide(y._sign), x._abs.DivideExactly(y._abs)));
        }

        #endregion

        #region Mod �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Mod(long x)
        {
            return (Mod(this, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Mod(ulong x)
        {
            return (Mod(this, new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Mod(UnsignedLongLongInteger x)
        {
            return (Mod(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Mod(LongLongInteger x)
        {
            return (Mod(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Mod(long x, LongLongInteger y)
        {
            return (Mod(new LongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Mod(ulong x, LongLongInteger y)
        {
            return (Mod(new UnsignedLongLongInteger(x), y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Mod(UnsignedLongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x.IsZero)
                return (UnsignedLongLongInteger.Zero);
            else
                return (x.Mod(y._abs));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Mod(LongLongInteger x, long y)
        {
            return (Mod(x, new LongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Mod(LongLongInteger x, ulong y)
        {
            return (Mod(x, new UnsignedLongLongInteger(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Mod(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Mod(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <returns>
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Mod(LongLongInteger x, LongLongInteger y)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign, x._abs.Mod(y._abs)));
        }

        #endregion

        #region DivRem �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger DivRem(long x, out LongLongInteger r)
        {
            return (DivRem(this, new LongLongInteger(x), out r));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger DivRem(ulong x, out LongLongInteger r)
        {
            return (DivRem(this, new UnsignedLongLongInteger(x), out r));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger DivRem(UnsignedLongLongInteger x, out LongLongInteger r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger DivRem(LongLongInteger x, out LongLongInteger r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivRem(long x, LongLongInteger y, out LongLongInteger r)
        {
            return (DivRem(new LongLongInteger(x), y, out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivRem(ulong x, LongLongInteger y, out UnsignedLongLongInteger r)
        {
            return (DivRem(new UnsignedLongLongInteger(x), y, out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivRem(UnsignedLongLongInteger x, LongLongInteger y, out UnsignedLongLongInteger r)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x.IsZero)
            {
                r = UnsignedLongLongInteger.Zero;
                return (Zero);
            }
            else
                return (new LongLongInteger(y._sign, x.DivRem(y._abs, out r)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivRem(LongLongInteger x, long y, out LongLongInteger r)
        {
            return (DivRem(x, new LongLongInteger(y), out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger DivRem(LongLongInteger x, ulong y, out LongLongInteger r)
        {
            return (DivRem(x, new UnsignedLongLongInteger(y), out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivRem(LongLongInteger x, UnsignedLongLongInteger y, out LongLongInteger r)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
            {
                r = Zero;
                return (Zero);
            }
            else
            {
                UnsignedLongLongInteger r_u;
                UnsignedLongLongInteger q_u = x._abs.DivRem(y, out r_u);
                r = new LongLongInteger(x._sign, r_u);
                return (new LongLongInteger(x._sign, q_u));
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(�폜��)
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B(����)
        /// </param>
        /// <param name="r">
        /// ��]��\���I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ����\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger DivRem(LongLongInteger x, LongLongInteger y, out LongLongInteger r)
        {
            if (y._sign == SignType.Zero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (x._sign == SignType.Zero)
            {
                r = Zero;
                return (Zero);
            }
            else
            {
                UnsignedLongLongInteger r_u;
                UnsignedLongLongInteger q_u = x._abs.DivRem(y._abs, out r_u);
                r = new LongLongInteger(x._sign, r_u);
                return (new LongLongInteger(x._sign.Divide(y._sign), q_u));
            }
        }

        #endregion

        #region Negate �̃I�[�o�[���[�h

        /// <summary>
        /// ���݂̃I�u�W�F�N�g�̕��������]�����l��v�Z���܂��B
        /// </summary>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Negate()
        {
            return (Negate(this));
        }

        /// <summary>
        /// ���������]�����l��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Negate(UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                return (Zero);
            else
                return (new LongLongInteger(SignType.Negative, x));
        }

        /// <summary>
        /// ���������]�����l��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Negate(LongLongInteger x)
        {
            if (x._sign == SignType.Zero)
                return (Zero);
            else
                return (new LongLongInteger(x._sign.Negate(), x._abs));
        }

        #endregion

        #region Power �̃I�[�o�[���[�h

        /// <summary>
        /// �I�u�W�F�N�g�ׂ̂����v�Z���܂��B
        /// </summary>
        /// <param name="exp">
        /// �ׂ���̎w���ł��B
        /// </param>
        /// <returns>
        /// �ׂ���̌v�Z���ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Power(ulong exp)
        {
            return (Power(this, new UnsignedLongLongInteger(exp)));
        }

        /// <summary>
        /// �I�u�W�F�N�g�ׂ̂����v�Z���܂��B
        /// </summary>
        /// <param name="exp">
        /// �ׂ���̎w���ł��B
        /// </param>
        /// <returns>
        /// �ׂ���̌v�Z���ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Power(UnsignedLongLongInteger exp)
        {
            return (Power(this, exp));
        }

        /// <summary>
        /// �I�u�W�F�N�g�ׂ̂����v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �ׂ���̊�ł��B
        /// </param>
        /// <param name="exp">
        /// �ׂ���̎w���ł��B
        /// </param>
        /// <returns>
        /// �ׂ���̌v�Z���ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Power(LongLongInteger x, ulong exp)
        {
            return (Power(x, new UnsignedLongLongInteger(exp)));
        }

        /// <summary>
        /// �I�u�W�F�N�g�ׂ̂����v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �ׂ���̊�ł��B
        /// </param>
        /// <param name="exp">
        /// �ׂ���̎w���ł��B
        /// </param>
        /// <returns>
        /// �ׂ���̌v�Z���ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Power(LongLongInteger x, UnsignedLongLongInteger exp)
        {
            if (exp.IsZero)
                return (One);
            else if (exp.IsOne)
                return (x);
            else if (x._sign == SignType.Zero)
                return (Zero);
            else if (x._sign == SignType.Positive)
                return (x._abs.Power(exp).ToLongLongInteger());
            else if (exp.IsEven)
                return (x._abs.Power(exp).ToLongLongInteger());
            else
                return (x._abs.Power(exp).Negate());
        }

        #endregion

        #region Abs �̃I�[�o�[���[�h

        /// <summary>
        /// ���݂̃I�u�W�F�N�g�̐�Βl��v�Z���܂��B
        /// </summary>
        /// <returns>
        /// ��Βl�ł��B
        /// </returns>
        public UnsignedLongLongInteger Abs()
        {
            return (Abs(this));
        }

        /// <summary>
        /// ��Βl��v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// ��Βl�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Abs(LongLongInteger x)
        {
            return (x._abs);
        }

        #endregion

        #region GreatestCommonDivisor �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger GreatestCommonDivisor(long x)
        {
            return (GreatestCommonDivisor(_abs, new LongLongInteger(x)));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger GreatestCommonDivisor(ulong x)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(_abs, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger GreatestCommonDivisor(UnsignedLongLongInteger x)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(_abs, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(_abs, x._abs));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y�̍ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(long x, LongLongInteger y)
        {
            return (GreatestCommonDivisor(new LongLongInteger(x), y._abs));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y�̍ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger GreatestCommonDivisor(ulong x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x, y._abs));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y�̍ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x, y._abs));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y�̍ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, long y)
        {
            return (GreatestCommonDivisor(x._abs, new LongLongInteger(y)));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y�̍ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, ulong y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x._abs, y));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y�̍ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, UnsignedLongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x._abs, y));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő���񐔂�v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y�̍ő���񐔂�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger GreatestCommonDivisor(LongLongInteger x, LongLongInteger y)
        {
            return (UnsignedLongLongInteger.GreatestCommonDivisor(x._abs, y._abs));
        }

        #endregion

        #region Max �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Max(long x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public UnsignedLongLongInteger Max(ulong x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger Max(UnsignedLongLongInteger x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Max(LongLongInteger x)
        {
            return (Max(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Max(long x, LongLongInteger y)
        {
            return (Max(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Max(ulong x, LongLongInteger y)
        {
            return (Max(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Max(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Max(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Max(LongLongInteger x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger Max(LongLongInteger x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x._abs);
            else
                return (new UnsignedLongLongInteger(y));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger Max(LongLongInteger x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x._abs);
            else
                return (y);
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ő�l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ő�l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Max(LongLongInteger x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (y);
        }

        #endregion

        #region Min �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Min(long x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public LongLongInteger Min(ulong x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Min(UnsignedLongLongInteger x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger Min(LongLongInteger x)
        {
            return (Min(this, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Min(long x, LongLongInteger y)
        {
            return (Min(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Min(ulong x, LongLongInteger y)
        {
            return (Min(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Min(UnsignedLongLongInteger x, LongLongInteger y)
        {
            return (Min(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Min(LongLongInteger x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger Min(LongLongInteger x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Min(LongLongInteger x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new LongLongInteger(y));
        }


        /// <summary>
        /// ��̃I�u�W�F�N�g�̍ŏ��l����߂܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ŏ��l��\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger Min(LongLongInteger x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (y);
        }

        #endregion

        #endregion

        #region �v���C�x�[�g���\�b�h

        private static LongLongInteger Subtract(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            int cmp = x.CompareTo(y);
            if (cmp > 0)
                return (x.Subtract(y).ToLongLongInteger());
            else if (cmp == 0)
                return (Zero);
            else
                return (y.Subtract(x).Negate());
        }

        #endregion
    }
}
