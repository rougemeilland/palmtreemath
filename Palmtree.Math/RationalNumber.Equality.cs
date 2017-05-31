/*
  RationalNumber.Equality.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// ���Z�q�̃I�[�o�[���[�h�Ɋւ���K�C�h���C��:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx

namespace Palmtree.Math
{
    partial struct RationalNumber
        : IEquatable<RationalNumber>
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
        public static bool operator ==(long x, RationalNumber y)
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
        public static bool operator ==(ulong x, RationalNumber y)
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
        public static bool operator ==(UnsignedLongLongInteger x, RationalNumber y)
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
        public static bool operator ==(LongLongInteger x, RationalNumber y)
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
        public static bool operator ==(RationalNumber x, long y)
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
        public static bool operator ==(RationalNumber x, ulong y)
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
        public static bool operator ==(RationalNumber x, UnsignedLongLongInteger y)
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
        public static bool operator ==(RationalNumber x, LongLongInteger y)
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
        public static bool operator ==(RationalNumber x, RationalNumber y)
        {
            return (Equals(x, y));
        }

        #endregion

        #region != �̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g�̑召�֌W�𒲂ׂ܂��B
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
        public static bool operator !=(long x, RationalNumber y)
        {
            return (!Equals(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̑召�֌W�𒲂ׂ܂��B
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
        public static bool operator !=(ulong x, RationalNumber y)
        {
            return (!Equals(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̑召�֌W�𒲂ׂ܂��B
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
        public static bool operator !=(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (!Equals(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̑召�֌W�𒲂ׂ܂��B
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
        public static bool operator !=(LongLongInteger x, RationalNumber y)
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
        public static bool operator !=(RationalNumber x, long y)
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
        public static bool operator !=(RationalNumber x, ulong y)
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
        public static bool operator !=(RationalNumber x, UnsignedLongLongInteger y)
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
        public static bool operator !=(RationalNumber x, LongLongInteger y)
        {
            return (!Equals(x, y));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̑召�֌W�𒲂ׂ܂��B
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
        public static bool operator !=(RationalNumber x, RationalNumber y)
        {
            return (!Equals(x, y));
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
        public static bool Equals(long x, RationalNumber y)
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
        public static bool Equals(ulong x, RationalNumber y)
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
        public static bool Equals(UnsignedLongLongInteger x, RationalNumber y)
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
        public static bool Equals(LongLongInteger x, RationalNumber y)
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
        public static bool Equals(RationalNumber x, long y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, ulong y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, LongLongInteger y)
        {
            return (x._InternalDenominator.IsOne && x._InternalNumerator.Equals(y));
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
        public static bool Equals(RationalNumber x, RationalNumber y)
        {
            return (x._InternalDenominator.Equals(y._InternalDenominator) && x._InternalNumerator.Equals(y._InternalNumerator));
        }

        #endregion

        #endregion

        #region IEquatable<RationalNumber> �����o

        /// <summary>
        /// �I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public bool Equals(RationalNumber o)
        {
            return (RationalNumber.Equals(this, o));
        }

        #endregion
    }
}
