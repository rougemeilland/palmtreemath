/*
  LongLongInteger.Relation.cs

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
        : IComparable, IComparable<LongLongInteger>
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
        public static bool operator <(long x, LongLongInteger y)
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
        public static bool operator <(ulong x, LongLongInteger y)
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
        public static bool operator <(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator <(LongLongInteger x, long y)
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
        public static bool operator <(LongLongInteger x, ulong y)
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
        public static bool operator <(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator <(LongLongInteger x, LongLongInteger y)
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
        public static bool operator <=(long x, LongLongInteger y)
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
        public static bool operator <=(ulong x, LongLongInteger y)
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
        public static bool operator <=(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator <=(LongLongInteger x, long y)
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
        public static bool operator <=(LongLongInteger x, ulong y)
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
        public static bool operator <=(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator <=(LongLongInteger x, LongLongInteger y)
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
        public static bool operator >(long x, LongLongInteger y)
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
        public static bool operator >(ulong x, LongLongInteger y)
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
        public static bool operator >(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator >(LongLongInteger x, long y)
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
        public static bool operator >(LongLongInteger x, ulong y)
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
        public static bool operator >(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator >(LongLongInteger x, LongLongInteger y)
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
        public static bool operator >=(long x, LongLongInteger y)
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
        public static bool operator >=(ulong x, LongLongInteger y)
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
        public static bool operator >=(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static bool operator >=(LongLongInteger x, long y)
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
        public static bool operator >=(LongLongInteger x, ulong y)
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
        public static bool operator >=(LongLongInteger x, UnsignedLongLongInteger y)
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
        public static bool operator >=(LongLongInteger x, LongLongInteger y)
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
            return (Compare(this, new UnsignedLongLongInteger(o)));
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
        public static int Compare(long x, LongLongInteger y)
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
        public static int Compare(ulong x, LongLongInteger y)
        {
            return (-Compare(y, new UnsignedLongLongInteger(x)));
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
        public static int Compare(UnsignedLongLongInteger x, LongLongInteger y)
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
        public static int Compare(LongLongInteger x, long y)
        {
            if (x._sign == SignType.Zero)
            {
                if (y > 0)
                    return (-1);
                else if (y == 0)
                    return (0);
                else
                    return (1);
            }
            else if (y == 0)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
            {
                if (y > 0)
                    return (UnsignedLongLongInteger.Compare(x._abs, (ulong)y));
                else
                    return (1);
            }
            else
            {
                if (y > 0)
                    return (-1);
                else if (y == long.MinValue)
                    return (UnsignedLongLongInteger.Compare(_nagated_long_min_value, x._abs));
                else
                    return (UnsignedLongLongInteger.Compare((ulong)-y, x._abs));
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
        public static int Compare(LongLongInteger x, ulong y)
        {
            if (x._sign == SignType.Zero)
                return (y == 0 ? 0 : -1);
            else if (y == 0)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
                return (UnsignedLongLongInteger.Compare(x._abs, y));
            else
                return (-1);
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
        public static int Compare(LongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (y.IsZero ? 0 : -1);
            else if (y.IsZero)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
                return (UnsignedLongLongInteger.Compare(x._abs, y));
            else
                return (-1);
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
        public static int Compare(LongLongInteger x, LongLongInteger y)
        {
            if (x._sign == SignType.Zero)
                return (-(int)y._sign);
            else if (y._sign == SignType.Zero)
                return ((int)x._sign);
            else if (x._sign == SignType.Positive)
            {
                if (y._sign == SignType.Positive)
                    return (UnsignedLongLongInteger.Compare(x._abs, y._abs));
                else
                    return (1);
            }
            else
            {
                if (y._sign == SignType.Positive)
                    return (-1);
                else
                    return (UnsignedLongLongInteger.Compare(y._abs, x._abs));
            }
        }

        #endregion

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
            else
                throw (new ArgumentException("LongLongInteger�I�u�W�F�N�g�Ɣ�r�ł��Ȃ��I�u�W�F�N�g���^�����܂����B", "o"));
        }

        #endregion

        #region IComparable<LongLongInteger> �����o

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

        #endregion
    }
}
