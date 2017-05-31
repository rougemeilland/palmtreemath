/*
  RationalNumber.Relation.cs

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
        : IComparable<RationalNumber>, IComparable
    {
        #region ���Z�q

#if !CONCEAL_OPERATORS

        #region < �̃I�[�o�[���[�h

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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <(long x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <(ulong x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) > 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <(RationalNumber x, long y)
        {
            return (Compare(x, y) < 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <(RationalNumber x, ulong y)
        {
            return (Compare(x, y) < 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) < 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) < 0);
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
        /// x��y��菬�����Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) < 0);
        }

        #endregion

        #region <= �̃I�[�o�[���[�h

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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <=(long x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <=(ulong x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <=(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <=(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) >= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <=(RationalNumber x, long y)
        {
            return (Compare(x, y) <= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator <=(RationalNumber x, ulong y)
        {
            return (Compare(x, y) <= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <=(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) <= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <=(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) <= 0);
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
        /// x��y��菬�����܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator <=(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) <= 0);
        }

        #endregion

        #region > �̃I�[�o�[���[�h

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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >(long x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >(ulong x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) < 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >(RationalNumber x, long y)
        {
            return (Compare(x, y) > 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >(RationalNumber x, ulong y)
        {
            return (Compare(x, y) > 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) > 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) > 0);
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
        /// x��y���傫���Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) > 0);
        }

        #endregion

        #region >= �̃I�[�o�[���[�h

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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >=(long x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >=(ulong x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >=(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >=(LongLongInteger x, RationalNumber y)
        {
            return (Compare(y, x) <= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >=(RationalNumber x, long y)
        {
            return (Compare(x, y) >= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static bool operator >=(RationalNumber x, ulong y)
        {
            return (Compare(x, y) >= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >=(RationalNumber x, UnsignedLongLongInteger y)
        {
            return (Compare(x, y) >= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >=(RationalNumber x, LongLongInteger y)
        {
            return (Compare(x, y) >= 0);
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
        /// x��y���傫���܂��͓������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public static bool operator >=(RationalNumber x, RationalNumber y)
        {
            return (Compare(x, y) >= 0);
        }

        #endregion

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        #region CompareTo �̃I�[�o�[���[�h

        /// <summary>
        /// �I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g��o��菬�����Ȃ�Ε��̐��A�I�u�W�F�N�g��o�Ɠ������Ȃ��0�A�I�u�W�F�N�g��o���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public int CompareTo(long o)
        {
            return (Compare(this, o));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g��o��菬�����Ȃ�Ε��̐��A�I�u�W�F�N�g��o�Ɠ������Ȃ��0�A�I�u�W�F�N�g��o���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        [CLSCompliant(false)]
        public int CompareTo(ulong o)
        {
            return (Compare(this, o));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g��o��菬�����Ȃ�Ε��̐��A�I�u�W�F�N�g��o�Ɠ������Ȃ��0�A�I�u�W�F�N�g��o���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public int CompareTo(LongLongInteger o)
        {
            return (Compare(this, o));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g��o��菬�����Ȃ�Ε��̐��A�I�u�W�F�N�g��o�Ɠ������Ȃ��0�A�I�u�W�F�N�g��o���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public int CompareTo(UnsignedLongLongInteger o)
        {
            return (Compare(this, o));
        }

        #endregion

        #region Compare �̃I�[�o�[���[�h

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public static int Compare(long x, RationalNumber y)
        {
            return (-Compare(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static int Compare(ulong x, RationalNumber y)
        {
            return (-Compare(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public static int Compare(UnsignedLongLongInteger x, RationalNumber y)
        {
            return (-Compare(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public static int Compare(LongLongInteger x, RationalNumber y)
        {
            return (-Compare(y, x));
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public static int Compare(RationalNumber x, long y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    if (y == 0)
                        return (0);
                    else if (y > 0)
                        return (-1);
                    else
                        return (1);
                case SignType.Positive:
                    if (y > 0)
                        return (x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply((ulong)y)));
                    else
                        return (1);
                default:
                    if (y >= 0)
                        return (-1);
                    else if (y == long.MinValue)
                        return (x._InternalDenominator.Multiply(_nagated_long_min_value).CompareTo(x._InternalNumerator.Abs()));
                    else
                        return (x._InternalDenominator.Multiply((ulong)-y).CompareTo(x._InternalNumerator.Abs()));
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static int Compare(RationalNumber x, ulong y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    return (y == 0 ? 0 : -1);
                case SignType.Positive:
                    return (y == 0 ? 1 : x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply(y)));
                default:
                    return (-1);
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public static int Compare(RationalNumber x, UnsignedLongLongInteger y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    return (y.IsZero ? 0 : -1);
                case SignType.Positive:
                    return (y.IsZero ? 1 : x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply(y)));
                default:
                    return (-1);
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public static int Compare(RationalNumber x, LongLongInteger y)
        {
            switch (x._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    if (y.InternalSign == SignType.Zero)
                        return (0);
                    else if (y.InternalSign == SignType.Positive)
                        return (-1);
                    else
                        return (1);
                case SignType.Positive:
                    if (y.InternalSign == SignType.Positive)
                        return (x._InternalNumerator.Abs().CompareTo(x._InternalDenominator.Multiply(y.Abs())));
                    else
                        return (1);
                default:
                    if (y.InternalSign != SignType.Negative)
                        return (-1);
                    else
                        return (x._InternalDenominator.Multiply(y.Abs()).CompareTo(x._InternalNumerator.Abs()));
            }
        }

        /// <summary>
        /// ��̃I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="x">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <param name="y">
        /// ��r����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// x��y��菬�����Ȃ�Ε��̐��Ax��y�Ɠ������Ȃ��0�Ax��y���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public static int Compare(RationalNumber x, RationalNumber y)
        {
            switch (y._InternalNumerator.InternalSign)
            {
                case SignType.Zero:
                    return ((int)x._InternalNumerator.InternalSign);
                case SignType.Positive:
                    return (x._InternalNumerator.InternalSign == SignType.Positive ? x._InternalNumerator.Abs().Multiply(y._InternalDenominator).CompareTo(y._InternalNumerator.Abs().Multiply(x._InternalDenominator)) : -1);
                default:
                    return (x._InternalNumerator.InternalSign == SignType.Negative ? y._InternalNumerator.Abs().Multiply(x._InternalDenominator).CompareTo(x._InternalNumerator.Abs().Multiply(y._InternalDenominator)) : 1);
            }
        }

        #endregion

        #endregion

        #region IComparable<RationalNumber> �����o

        /// <summary>
        /// �I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g��o��菬�����Ȃ�Ε��̐��A�I�u�W�F�N�g��o�Ɠ������Ȃ��0�A�I�u�W�F�N�g��o���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public int CompareTo(RationalNumber o)
        {
            return (RationalNumber.Compare(this, o));
        }

        #endregion

        #region IComparable �����o

        /// <summary>
        /// �I�u�W�F�N�g�̘_���I�ȑ召�֌W����߂܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g��o��菬�����Ȃ�Ε��̐��A�I�u�W�F�N�g��o�Ɠ������Ȃ��0�A�I�u�W�F�N�g��o���傫���Ȃ�ΐ��̐��ł��B
        /// </returns>
        public int CompareTo(object o)
        {
            if (o == null)
                return (1);
            else if (o is ulong)
                return (Compare(this, (ulong)o));
            else if (o is long)
                return (Compare(this, (long)o));
            else if (o is UnsignedLongLongInteger)
                return (Compare(this, (UnsignedLongLongInteger)o));
            else if (o is LongLongInteger)
                return (Compare(this, (LongLongInteger)o));
            else if (o is RationalNumber)
                return (Compare(this, (RationalNumber)o));
            else
                throw (new ArgumentException("RationalNumber�I�u�W�F�N�g��RationalNumber�ȊO�̃I�u�W�F�N�g���r���悤�Ƃ��܂����B", "o"));
        }

        #endregion
    }
}
