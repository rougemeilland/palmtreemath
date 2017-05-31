/*
  UnsignedLongLongInteger.Relation.cs

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
        : IComparable, IComparable<UnsignedLongLongInteger>
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
        [CLSCompliant(false)]
        public static bool operator <(ulong x, UnsignedLongLongInteger y)
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
        public static bool operator <(UnsignedLongLongInteger x, ulong y)
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
        public static bool operator <(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
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
        [CLSCompliant(false)]
        public static bool operator <=(ulong x, UnsignedLongLongInteger y)
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
        public static bool operator <=(UnsignedLongLongInteger x, ulong y)
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
        public static bool operator <=(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
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
        [CLSCompliant(false)]
        public static bool operator >(ulong x, UnsignedLongLongInteger y)
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
        public static bool operator >(UnsignedLongLongInteger x, ulong y)
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
        public static bool operator >(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
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
        [CLSCompliant(false)]
        public static bool operator >=(ulong x, UnsignedLongLongInteger y)
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
        public static bool operator >=(UnsignedLongLongInteger x, ulong y)
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
        public static bool operator >=(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
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
        [CLSCompliant(false)]
        public int CompareTo(ulong o)
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
        [CLSCompliant(false)]
        public static int Compare(UnsignedLongLongInteger x, ulong y)
        {
            if (x._InternalValue.Length == 0)
                return (((ulong)0).CompareTo(y));
            else if (y == 0)
                return (1);
            else if (y <= ushort.MaxValue)
                return (_imp.Compare(x._InternalValue, (ushort)y));
            else
                return (_imp.Compare(x._InternalValue, CreateInternalValue(y)));
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
        public static int Compare(ulong x, UnsignedLongLongInteger y)
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
        public static int Compare(UnsignedLongLongInteger x, UnsignedLongLongInteger y)
        {
            if (x._InternalValue.Length == 0)
                return (y._InternalValue.Length == 0 ? 0 : -1);
            else if (y._InternalValue.Length == 0)
                return (1);
            else
                return (_imp.Compare(x._InternalValue, y._InternalValue));
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
            else if (o is UnsignedLongLongInteger)
                return (Compare(this, (UnsignedLongLongInteger)o));
            else
                throw (new ArgumentException("UnsignedLongLongInteger�I�u�W�F�N�g�Ɣ�r�ł��Ȃ��I�u�W�F�N�g���^�����܂����B", "o"));
        }

        #endregion

        #region IComparable<UnsignedLongLongInteger> �����o

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
    }
}
