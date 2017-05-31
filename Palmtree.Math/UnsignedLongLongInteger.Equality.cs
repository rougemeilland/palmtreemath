/*
  UnsignedLongLongInteger.Equality.cs

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
        : IEquatable<UnsignedLongLongInteger>
    {
        #region ���Z�q

#if !CONCEAL_OPERATORS

        #region == �̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator ==(ulong x, UnsignedLongLongInteger y)
        {
            return (Equals(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator ==(UnsignedLongLongInteger x, ulong y)
        {
            return (Equals(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator ==(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (Equals(x, y));
        }

        #endregion

        #region != �̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���������Ȃ��Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator !=(ulong x, UnsignedLongLongInteger y)
        {
            return (!Equals(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���������Ȃ��Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator !=(UnsignedLongLongInteger x, ulong y)
        {
            return (!Equals(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���������Ȃ��Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator !=(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            return (!Equals(y, x));
        }

        #endregion

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        #region Equals �̃I�[�o�[���[�h

        /// <summary>
        /// �I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public bool Equals(ulong o)
        {
            return (Equals(this, o));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool Equals(ulong x, UnsignedLongLongInteger y)
        {
            return (Equals(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool Equals(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (y == 0);
            else if (y == 0)
                return (false);
            else if (y <= ushort.MaxValue)
                return (_imp.Equals(x._InternalValue, (ushort)y));
            else
                return (_imp.Equals(x._InternalValue, CreateInternalValue(y)));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="x">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool Equals(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (y._InternalValue.Length == 0);
            else if (y._InternalValue.Length == 0)
                return (false);
            else
                return (_imp.Equals(x._InternalValue, y._InternalValue));
        }

        #endregion

        #endregion

        #region IEquatable<UnsignedLongLongInteger> �����o

        /// <summary>
        /// �I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public bool Equals(UnsignedLongLongInteger o)
        {
            return (UnsignedLongLongInteger.Equals(this, o));
        }

        #endregion
    }
}
