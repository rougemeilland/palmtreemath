/*
  RationalNumber.Arithmetic.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using Palmtree.Math.Round;

// ���Z�q�̃I�[�o�[���[�h�Ɋւ���K�C�h���C��:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct RationalNumber
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
        public static RationalNumber operator +(RationalNumber x)
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
        public static RationalNumber operator -(RationalNumber x)
        {
            return (Negate(x));
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
        public static RationalNumber operator +(long x, RationalNumber y)
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
        public static RationalNumber operator +(ulong x, RationalNumber y)
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
        public static RationalNumber operator +(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator +(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator +(RationalNumber x, long y)
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
        public static RationalNumber operator +(RationalNumber x, ulong y)
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
        public static RationalNumber operator +(RationalNumber x, UnsignedLongLongInteger y)
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
        public static RationalNumber operator +(RationalNumber x, LongLongInteger y)
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
        public static RationalNumber operator +(RationalNumber x, RationalNumber y)
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
        public static RationalNumber operator -(long x, RationalNumber y)
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
        public static RationalNumber operator -(ulong x, RationalNumber y)
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
        public static RationalNumber operator -(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator -(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator -(RationalNumber x, long y)
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
        public static RationalNumber operator -(RationalNumber x, ulong y)
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
        public static RationalNumber operator -(RationalNumber x, UnsignedLongLongInteger y)
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
        public static RationalNumber operator -(RationalNumber x, LongLongInteger y)
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
        public static RationalNumber operator -(RationalNumber x, RationalNumber y)
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
        public static RationalNumber operator *(long x, RationalNumber y)
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
        public static RationalNumber operator *(ulong x, RationalNumber y)
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
        public static RationalNumber operator *(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator *(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber operator *(RationalNumber x, long y)
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
        public static RationalNumber operator *(RationalNumber x, ulong y)
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
        public static RationalNumber operator *(RationalNumber x, UnsignedLongLongInteger y)
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
        public static RationalNumber operator *(RationalNumber x, LongLongInteger y)
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
        public static RationalNumber operator *(RationalNumber x, RationalNumber y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber operator /(long x, RationalNumber y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber operator /(ulong x, RationalNumber y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber operator /(UnsignedLongLongInteger x, RationalNumber y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber operator /(LongLongInteger x, RationalNumber y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, long y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber operator /(RationalNumber x, ulong y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, UnsignedLongLongInteger y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, LongLongInteger y)
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
        /// x��y�ŏ��Z�������ʂ�\���I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber operator /(RationalNumber x, RationalNumber y)
        {
            if (y.Sign == 0)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else if (y.Sign > 0)
                return (new RationalNumber(x._InternalNumerator * y._InternalDenominator, x._InternalDenominator * y._InternalNumerator.Abs()));
            else
                return (new RationalNumber(-x._InternalNumerator * y._InternalDenominator, x._InternalDenominator * y._InternalNumerator.Abs()));
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
        public RationalNumber Add(long x)
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
        public RationalNumber Add(ulong x)
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
        public RationalNumber Add(UnsignedLongLongInteger x)
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
        public RationalNumber Add(LongLongInteger x)
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
        public RationalNumber Add(RationalNumber x)
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
        public static RationalNumber Add(long x, RationalNumber y)
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
        public static RationalNumber Add(ulong x, RationalNumber y)
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
        public static RationalNumber Add(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Add(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Add(RationalNumber x, long y)
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
        public static RationalNumber Add(RationalNumber x, ulong y)
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
        public static RationalNumber Add(RationalNumber x, UnsignedLongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            UnsignedLongLongInteger n2 = x._InternalDenominator.Multiply(y);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Add(n2), d));
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
        public static RationalNumber Add(RationalNumber x, LongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            LongLongInteger n2 = x._InternalDenominator.Multiply(y);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Add(n2), d));
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
        public static RationalNumber Add(RationalNumber x, RationalNumber y)
        {
            LongLongInteger n1 = x._InternalNumerator.Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator.Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator.Multiply(y._InternalDenominator);
            return (new RationalNumber(n1.Add(n2), d));
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
        public RationalNumber Subtract(long x)
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
        public RationalNumber Subtract(ulong x)
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
        public RationalNumber Subtract(UnsignedLongLongInteger x)
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
        public RationalNumber Subtract(LongLongInteger x)
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
        public RationalNumber Subtract(RationalNumber x)
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
        public static RationalNumber Subtract(long x, RationalNumber y)
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
        public static RationalNumber Subtract(ulong x, RationalNumber y)
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
        public static RationalNumber Subtract(UnsignedLongLongInteger x, RationalNumber y)
        {
            LongLongInteger n1 = x.ToLongLongInteger().Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator;
            UnsignedLongLongInteger d = y._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(LongLongInteger x, RationalNumber y)
        {
            LongLongInteger n1 = x.Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator;
            UnsignedLongLongInteger d = y._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(RationalNumber x, long y)
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
        public static RationalNumber Subtract(RationalNumber x, ulong y)
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
        public static RationalNumber Subtract(RationalNumber x, UnsignedLongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            LongLongInteger n2 = y.ToLongLongInteger().Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(RationalNumber x, LongLongInteger y)
        {
            LongLongInteger n1 = x._InternalNumerator;
            LongLongInteger n2 = y.Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator;
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public static RationalNumber Subtract(RationalNumber x, RationalNumber y)
        {
            LongLongInteger n1 = x._InternalNumerator.Multiply(y._InternalDenominator);
            LongLongInteger n2 = y._InternalNumerator.Multiply(x._InternalDenominator);
            UnsignedLongLongInteger d = x._InternalDenominator.Multiply(y._InternalDenominator);
            return (new RationalNumber(n1.Subtract(n2), d));
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
        public RationalNumber Multiply(long x)
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
        public RationalNumber Multiply(ulong x)
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
        public RationalNumber Multiply(UnsignedLongLongInteger x)
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
        public RationalNumber Multiply(LongLongInteger x)
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
        public RationalNumber Multiply(RationalNumber x)
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
        public static RationalNumber Multiply(long x, RationalNumber y)
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
        public static RationalNumber Multiply(ulong x, RationalNumber y)
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
        public static RationalNumber Multiply(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Multiply(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Multiply(RationalNumber x, long y)
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
        public static RationalNumber Multiply(RationalNumber x, ulong y)
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
        public static RationalNumber Multiply(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (new RationalNumber(x._InternalNumerator.Multiply(y), x._InternalDenominator));
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
        public static RationalNumber Multiply(RationalNumber x, LongLongInteger y)
        {
            return (new RationalNumber(x._InternalNumerator.Multiply(y), x._InternalDenominator));
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
        public static RationalNumber Multiply(RationalNumber x, RationalNumber y)
        {
            return (new RationalNumber(x._InternalNumerator.Multiply(y._InternalNumerator), x._InternalDenominator.Multiply(y._InternalDenominator)));
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
        public RationalNumber Divide(long x)
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
        public RationalNumber Divide(ulong x)
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
        public RationalNumber Divide(UnsignedLongLongInteger x)
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
        public RationalNumber Divide(LongLongInteger x)
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
        public RationalNumber Divide(RationalNumber x)
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
        public static RationalNumber Divide(long x, RationalNumber y)
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
        public static RationalNumber Divide(ulong x, RationalNumber y)
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
        public static RationalNumber Divide(UnsignedLongLongInteger x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    return (new RationalNumber(x.ToLongLongInteger().Multiply(y._InternalDenominator), y._InternalNumerator.Abs()));
                default:
                    return (new RationalNumber(x.ToLongLongInteger().Multiply(y._InternalDenominator).Negate(), y._InternalNumerator.Abs()));
            }
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
        public static RationalNumber Divide(LongLongInteger x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    return (new RationalNumber(x.Multiply(y._InternalDenominator), y._InternalNumerator.Abs()));
                default:
                    return (new RationalNumber(x.Multiply(y._InternalDenominator).Negate(), y._InternalNumerator.Abs()));
            }
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
        public static RationalNumber Divide(RationalNumber x, long y)
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
        public static RationalNumber Divide(RationalNumber x, ulong y)
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
        public static RationalNumber Divide(RationalNumber x, UnsignedLongLongInteger y)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else
                return (new RationalNumber(x._InternalNumerator, x._InternalDenominator.Multiply(y)));
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
        public static RationalNumber Divide(RationalNumber x, LongLongInteger y)
        {
            switch (y.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    return (new RationalNumber(x._InternalNumerator, x._InternalDenominator.Multiply(y.Abs())));
                default:
                    return (new RationalNumber(x._InternalNumerator.Negate(), x._InternalDenominator.Multiply(y.Abs())));
            }
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
        public static RationalNumber Divide(RationalNumber x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    return (new RationalNumber(x._InternalNumerator.Multiply(y._InternalDenominator), x._InternalDenominator.Multiply(y._InternalNumerator.Abs())));
                default:
                    return (new RationalNumber(x._InternalNumerator.Multiply(y._InternalDenominator).Negate(), x._InternalDenominator.Multiply(y._InternalNumerator.Abs())));
            }
        }

        #endregion

        #region DivRem �̃I�[�o�[���[�h

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(long x, out RationalNumber r)
        {
            return (DivRem(this, new LongLongInteger(x), out r));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(ulong x, out RationalNumber r)
        {
            return (DivRem(this, new UnsignedLongLongInteger(x), out r));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(UnsignedLongLongInteger x, out RationalNumber r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(LongLongInteger x, out RationalNumber r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// �^����ꂽ�I�u�W�F�N�g�Ƃ̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public LongLongInteger DivRem(RationalNumber x, out RationalNumber r)
        {
            return (DivRem(this, x, out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(long x, RationalNumber y, out RationalNumber r)
        {
            return (DivRem(new LongLongInteger(x), y, out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(ulong x, RationalNumber y, out RationalNumber r)
        {
            return (DivRem(new UnsignedLongLongInteger(x), y, out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(UnsignedLongLongInteger x, RationalNumber y, out RationalNumber r)
        {
            UnsignedLongLongInteger t;
            LongLongInteger q;
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(SignType.Positive, t, y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Subtract(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
                default:
                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(SignType.Negative, t, y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Add(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(LongLongInteger x, RationalNumber y, out RationalNumber r)
        {
            LongLongInteger t;
            LongLongInteger q;
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(t.InternalSign, t.Abs(), y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Subtract(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
                default:

                    t = x.Multiply(y._InternalDenominator);
                    q = FloorImp(t.InternalSign.Negate(), t.Abs(), y._InternalNumerator.Abs());
                    r = new RationalNumber(t.Add(q.Multiply(y._InternalNumerator.Abs())), y._InternalDenominator);
                    return (q);
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, long y, out RationalNumber r)
        {
            return (DivRem(x, new LongLongInteger(y), out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, ulong y, out RationalNumber r)
        {
            return (DivRem(x, new UnsignedLongLongInteger(y), out r));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, UnsignedLongLongInteger y, out RationalNumber r)
        {
            if (y.IsZero)
                throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
            else
            {
                UnsignedLongLongInteger t = x._InternalDenominator.Multiply(y);
                LongLongInteger q = FloorImp(x._InternalNumerator.InternalSign, x._InternalNumerator.Abs(), t);
                r = new RationalNumber(x._InternalNumerator.Subtract(q.Multiply(t)), x._InternalDenominator);
                return (q);
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, LongLongInteger y, out RationalNumber r)
        {
            UnsignedLongLongInteger t;
            LongLongInteger q;
            switch (y.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    t = x._InternalDenominator.Multiply(y.Abs());
                    q = FloorImp(x._InternalNumerator.InternalSign, x._InternalNumerator.Abs(), t);
                    r = new RationalNumber(x._InternalNumerator.Subtract(q.Multiply(t)), x._InternalDenominator);
                    return (q);
                default:
                    t = x._InternalDenominator.Multiply(y.Abs());
                    q = FloorImp(x._InternalNumerator.InternalSign.Negate(), x._InternalNumerator.Abs(), t);
                    r = new RationalNumber(x._InternalNumerator.Add(q.Multiply(t)), x._InternalDenominator);
                    return (q);
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̏��Ə�]��v�Z���܂��B
        /// �폜����u�A������v�Ƃ����ꍇ�A��q�Ə�]r�͈ȉ��̎��Œ�`����܂��B
        /// q = Floor(x / y), r = x - q * y
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
        public static LongLongInteger DivRem(RationalNumber x, RationalNumber y, out RationalNumber r)
        {
            LongLongInteger t1;
            UnsignedLongLongInteger t2;
            LongLongInteger q;
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                case SignType.Positive:
                    t1 = x._InternalNumerator.Multiply(y._InternalDenominator);
                    t2 = x._InternalDenominator.Multiply(y._InternalNumerator.Abs());
                    q = FloorImp(t1.InternalSign, t1.Abs(), t2);
                    r = new RationalNumber(t1.Subtract(q.Multiply(t2)), x._InternalDenominator.Multiply(y._InternalDenominator));
                    return (q);
                default:
                    t1 = x._InternalNumerator.Multiply(y._InternalDenominator);
                    t2 = x._InternalDenominator.Multiply(y._InternalNumerator.Abs()); ;
                    q = FloorImp(t1.InternalSign.Negate(), t1.Abs(), t2);
                    r = new RationalNumber(t1.Add(q.Multiply(t2)), x._InternalDenominator.Multiply(y._InternalDenominator));
                    return (q);
            }
        }

        #endregion

        #region Negate �̃I�[�o�[���[�h

        /// <summary>
        /// ���������]�����l��v�Z���܂��B
        /// </summary>
        /// <returns>
        /// �v�Z���ʂ̃I�u�W�F�N�g�ł��B
        /// </returns>
        public RationalNumber Negate()
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
        public static RationalNumber Negate(RationalNumber x)
        {
            return (new RationalNumber(x._InternalNumerator.Negate(), x._InternalDenominator));
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
        public RationalNumber Power(long exp)
        {
            return (Power(this, new LongLongInteger(exp)));
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
        [CLSCompliant(false)]
        public RationalNumber Power(ulong exp)
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
        public RationalNumber Power(UnsignedLongLongInteger exp)
        {
            return (Power(this, exp));
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
        public RationalNumber Power(LongLongInteger exp)
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
        public static RationalNumber Power(RationalNumber x, long exp)
        {
            return (Power(x, new LongLongInteger(exp)));
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
        public static RationalNumber Power(RationalNumber x, ulong exp)
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
        public static RationalNumber Power(RationalNumber x, UnsignedLongLongInteger exp)
        {
            if (exp.IsZero)
                return (One);
            else if (x._InternalNumerator.InternalSign == SignType.Zero)
                return (Zero);
            else
                return (new RationalNumber(x._InternalNumerator.Power(exp), x._InternalDenominator.Power(exp)));
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
        public static RationalNumber Power(RationalNumber x, LongLongInteger exp)
        {
            switch (exp.InternalSign)
            {
                case SignType.Zero:
                    return (One);
                case SignType.Negative:
                    if (x._InternalNumerator.InternalSign == SignType.Zero)
                        throw (new DivideByZeroException("0�ɂ�鏜�Z���s���悤�Ƃ��܂����B"));
                    else
                        return (Reciprocal(x._InternalDenominator.Power(exp.Abs()), x._InternalNumerator.Power(exp.Abs())));
                default:
                    if (x._InternalNumerator.InternalSign == SignType.Zero)
                        return (Zero);
                    else
                        return (new RationalNumber(x._InternalNumerator.Power(exp.Abs()), x._InternalDenominator.Power(exp.Abs())));
            }
        }

        #endregion

        #region Abs �̃I�[�o�[���[�h

        /// <summary>
        /// ���݂̃I�u�W�F�N�g�̐�Βl��v�Z���܂��B
        /// </summary>
        /// <returns>
        /// ��Βl�ł��B
        /// </returns>
        public RationalNumber Abs()
        {
            return (new RationalNumber(_InternalNumerator.Abs().ToLongLongInteger(), _InternalDenominator));
        }

        #endregion

        #region Floor �̃I�[�o�[���[�h

        /// <summary>
        /// ���݂̃I�u�W�F�N�g��菬�����ő�̐�����v�Z���܂��B
        /// </summary>
        /// <returns>
        /// ���݂̃I�u�W�F�N�g��菬�����ő�̐����ł��B
        /// </returns>
        public LongLongInteger Floor()
        {
            return (FloorImp(_InternalNumerator.InternalSign, _InternalNumerator.Abs(), _InternalDenominator));
        }

        #endregion

        #region Ceiling �̃I�[�o�[���[�h

        /// <summary>
        /// ���݂̃I�u�W�F�N�g���傫���ŏ��̐�����v�Z���܂��B
        /// </summary>
        /// <returns>
        /// ���݂̃I�u�W�F�N�g���傫���ŏ��̐����ł��B
        /// </returns>
        public LongLongInteger Ceiling()
        {
            UnsignedLongLongInteger r;
            UnsignedLongLongInteger q = UnsignedLongLongInteger.DivRem(_InternalNumerator.Abs(), _InternalDenominator, out r);
            if (r.IsZero)
                return (new LongLongInteger(_InternalNumerator.InternalSign, q));
            else
                return (_rounders.Round(RoundingMode.ROUND_CEILING, _InternalNumerator.InternalSign, _InternalDenominator, q, r));
        }

        #endregion

        #region Round �̃I�[�o�[���[�h

        /// <summary>
        /// ���݂̃I�u�W�F�N�g�̒l��ۂ߂��I�u�W�F�N�g��Ԃ��܂��B
        /// </summary>
        /// <param name="mode">
        /// �ۂ߂���@������܂��B
        /// </param>
        /// <returns>
        /// �ۂ߂�ꂽ�I�u�W�F�N�g��Ԃ��܂��B
        /// </returns>
        public LongLongInteger Round(RoundingMode mode)
        {
            UnsignedLongLongInteger r;
            UnsignedLongLongInteger q = UnsignedLongLongInteger.DivRem(_InternalNumerator.Abs(), _InternalDenominator, out r);
            if (r.IsZero)
                return (new LongLongInteger(_InternalNumerator.InternalSign, q));
            else
                return (_rounders.Round(mode, _InternalNumerator.InternalSign, _InternalDenominator, q, r));
        }

        #endregion

        #region Reciprocal �̃I�[�o�[���[�h

        /// <summary>
        /// �I�u�W�F�N�g�̋t����v�Z���܂��B
        /// </summary>
        /// <returns>
        /// �v�Z���ʂ̋t���ł��B
        /// </returns>
        public RationalNumber Reciprocal()
        {
            return (Reciprocal(this));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̋t����v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̋t���ł��B
        /// </returns>
        public static RationalNumber Reciprocal(long x)
        {
            return (Reciprocal(new LongLongInteger(x)));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̋t����v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̋t���ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber Reciprocal(ulong x)
        {
            return (Reciprocal(new UnsignedLongLongInteger(x)));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̋t����v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̋t���ł��B
        /// </returns>
        public static RationalNumber Reciprocal(UnsignedLongLongInteger x)
        {
            if (x.IsZero)
                throw (new DivideByZeroException("0�̋t���͌v�Z�ł��܂���B"));
            else
                return (Reciprocal(SignType.Positive, x));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̋t����v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̋t���ł��B
        /// </returns>
        public static RationalNumber Reciprocal(LongLongInteger x)
        {
            if (x.InternalSign == SignType.Zero)
                throw (new DivideByZeroException("0�̋t���͌v�Z�ł��܂���B"));
            else
                return (Reciprocal(x.InternalSign, x.Abs()));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̋t����v�Z���܂��B
        /// </summary>
        /// <param name="x">
        /// �v�Z�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �v�Z���ʂ̋t���ł��B
        /// </returns>
        public static RationalNumber Reciprocal(RationalNumber x)
        {
            UnsignedLongLongInteger denominator;
            LongLongInteger numerator = x.ToFraction(out denominator);
            if (numerator.IsZero) 
                throw (new DivideByZeroException("0�̋t���͌v�Z�ł��܂���B"));
            else
                return (Reciprocal(numerator.InternalSign, denominator, numerator.Abs()));
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
        [CLSCompliant(false)]
        public RationalNumber Max(ulong x)
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
        public RationalNumber Max(long x)
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
        public RationalNumber Max(UnsignedLongLongInteger x)
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
        public RationalNumber Max(LongLongInteger x)
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
        public RationalNumber Max(RationalNumber x)
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
        [CLSCompliant(false)]
        public static RationalNumber Max(ulong x, RationalNumber y)
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
        public static RationalNumber Max(long x, RationalNumber y)
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
        public static RationalNumber Max(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Max(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Max(RationalNumber x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare >= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Max(RationalNumber x, RationalNumber y)
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
        [CLSCompliant(false)]
        public RationalNumber Min(ulong x)
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
        public RationalNumber Min(long x)
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
        public RationalNumber Min(UnsignedLongLongInteger x)
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
        public RationalNumber Min(LongLongInteger x)
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
        public RationalNumber Min(RationalNumber x)
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
        [CLSCompliant(false)]
        public static RationalNumber Min(ulong x, RationalNumber y)
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
        public static RationalNumber Min(long x, RationalNumber y)
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
        public static RationalNumber Min(UnsignedLongLongInteger x, RationalNumber y)
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
        public static RationalNumber Min(LongLongInteger x, RationalNumber y)
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
        public static RationalNumber Min(RationalNumber x, ulong y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, long y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, UnsignedLongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, LongLongInteger y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (new RationalNumber(y));
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
        public static RationalNumber Min(RationalNumber x, RationalNumber y)
        {
            int compare = x.CompareTo(y);
            if (compare <= 0)
                return (x);
            else
                return (y);
        }

        #endregion

        #endregion

        #region �C���^�[�i�����\�b�h

        internal static RationalNumber Reciprocal(SignType sign, UnsignedLongLongInteger value)
        {
            return (Reciprocal(sign, UnsignedLongLongInteger.One, value));
        }

        internal static RationalNumber Reciprocal(UnsignedLongLongInteger denominator, LongLongInteger numerator)
        {
            return (Reciprocal(numerator.InternalSign, denominator, numerator.Abs()));
        }

        internal static RationalNumber Reciprocal(SignType sign, UnsignedLongLongInteger denominator, UnsignedLongLongInteger numerator)
        {
            return (new RationalNumber(new LongLongInteger(sign, denominator), numerator));
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        private static LongLongInteger FloorImp(SignType sign, UnsignedLongLongInteger numerator, UnsignedLongLongInteger denominator)
        {
            UnsignedLongLongInteger r;
            UnsignedLongLongInteger q = UnsignedLongLongInteger.DivRem(numerator, denominator, out r);
            if (r.IsZero)
                return (new LongLongInteger(sign, q));
            else
                return (_rounders.Round(RoundingMode.ROUND_FLOOR, sign, denominator, q, r));
        }

        #endregion
    }
}