/*
  LongLongInteger.Equality.cs

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
        : IEquatable<LongLongInteger>
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
        public static bool operator ==(long x, LongLongInteger y)
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
        public static bool operator ==(ulong x, LongLongInteger y)
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
        public static bool operator ==(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator ==(LongLongInteger x, long y)
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
        [CLSCompliant(false)]
        public static bool operator ==(LongLongInteger x, ulong y)
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
        public static bool operator ==(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator ==(LongLongInteger x, LongLongInteger y)
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
        public static bool operator !=(long x, LongLongInteger y)
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
        public static bool operator !=(ulong x, LongLongInteger y)
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
        public static bool operator !=(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator !=(LongLongInteger x, long y)
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
        [CLSCompliant(false)]
        public static bool operator !=(LongLongInteger x, ulong y)
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
        public static bool operator !=(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator !=(LongLongInteger x, LongLongInteger y)
        {
            return (!Equals(x, y));
        }

        #endregion

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        #region Eqauls �̃I�[�o�[���[�h

        /// <summary>
        /// �I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public bool Equals(long o)
        {
            return (Equals(this, o));
        }

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
        public static bool Equals(long x, LongLongInteger y)
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
        public static bool Equals(ulong x, LongLongInteger y)
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
        public static bool Equals(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool Equals(LongLongInteger x, long y)
        {
            if (x._sign == SignType.Zero)
                return (y == 0);
            else if (x._sign == SignType.Positive)
                return (y > 0 && x._abs.Equals((ulong)y));
            else if (y >= 0)
                return (false);
            else if (y == long.MinValue)
                return (x._abs.Equals(_nagated_long_min_value));
            else
                return (x._abs.Equals((ulong)-y));
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
        public static bool Equals(LongLongInteger x, ulong y)
        {
            if (x._sign == SignType.Zero)
                return (y == 0);
            else
                return (x._sign == SignType.Positive && y > 0 && x._abs.Equals(y));
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
        public static bool Equals(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y.IsZero);
            else
                return (x._sign == SignType.Positive && !y.IsZero && x._abs.Equals(y));
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
        public static bool Equals(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y._sign == SignType.Zero);
            else if (y._sign == SignType.Zero)
                return (false);
            else if (x._sign == SignType.Positive)
                return (y._sign == SignType.Positive && x._abs.Equals(y._abs));
            else
                return (y._sign == SignType.Negative && x._abs.Equals(y._abs));
        }

        #endregion

        #endregion

        #region IEquatable<LongLongInteger> �����o

        /// <summary>
        /// �I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public bool Equals(LongLongInteger o)
        {
            return (Equals(this, o));
        }

        #endregion
    }
}
