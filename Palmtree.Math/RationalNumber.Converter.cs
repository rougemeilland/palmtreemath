/*
  RationalNumber.Converter.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Diagnostics;

// ���Z�q�̃I�[�o�[���[�h�Ɋւ���K�C�h���C��:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx
// �ϊ����Z�q�̃K�C�h���C���F
//   http://msdn.microsoft.com/ja-jp/library/ms229033(v=VS.100).aspx

namespace Palmtree.Math
{
    partial struct RationalNumber
        : IConvertible
    {
        #region ���Z�q

#if !CONCEAL_OPERATORS

#if !CONCEAL_IMPLICIT_OPERATORS
        
        /// <summary>
        /// <see cref="sbyte"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator RationalNumber(sbyte o)
        {
            return (FromSByte(o));
        }

        /// <summary>
        /// <see cref="short"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator RationalNumber(short o)
        {
            return (FromInt16(o));
        }

        /// <summary>
        /// <see cref="int"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator RationalNumber(int o)
        {
            return (FromInt32(o));
        }

        /// <summary>
        /// <see cref="long"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator RationalNumber(long o)
        {
            return (FromInt64(o));
        }

        /// <summary>
        /// <see cref="byte"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator RationalNumber(byte o)
        {
            return (FromByte(o));
        }

        /// <summary>
        /// <see cref="ushort"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator RationalNumber(ushort o)
        {
            return (FromUInt16(o));
        }

        /// <summary>
        /// <see cref="uint"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator RationalNumber(uint o)
        {
            return (FromUInt32(o));
        }

        /// <summary>
        /// <see cref="ulong"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator RationalNumber(ulong o)
        {
            return (FromUInt64(o));
        }

#endif

        /// <summary>
        /// <see cref="float"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator RationalNumber(float o)
        {
            return (FromSingle(o));
        }

        /// <summary>
        /// <see cref="double"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator RationalNumber(double o)
        {
            return (FromDouble(o));
        }

        /// <summary>
        /// <see cref="decimal"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator RationalNumber(decimal o)
        {
            return (FromDecimal(o));
        }

#if !CONCEAL_IMPLICIT_OPERATORS

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator RationalNumber(UnsignedLongLongInteger o)
        {
            return (FromUnsignedLongLongInteger(o));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator RationalNumber(LongLongInteger o)
        {
            return (FromLongLongInteger(o));
        }

#endif

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="sbyte"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator sbyte(RationalNumber o)
        {
            return (o.ToSByte());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="short"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator short(RationalNumber o)
        {
            return (o.ToInt16());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="int"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator int(RationalNumber o)
        {
            return (o.ToInt32());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="long"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator long(RationalNumber o)
        {
            return (o.ToInt64());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="byte"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator byte(RationalNumber o)
        {
            return (o.ToByte());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ushort(RationalNumber o)
        {
            return (o.ToUInt16());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="uint"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator uint(RationalNumber o)
        {
            return (o.ToUInt32());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="ulong"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ulong(RationalNumber o)
        {
            return (o.ToUInt64());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="float"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator float(RationalNumber o)
        {
            return (o.ToSingle());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="double"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator double(RationalNumber o)
        {
            return (o.ToDouble());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="decimal"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator decimal(RationalNumber o)
        {
            return (o.ToDecimal());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(RationalNumber o)
        {
            return (o.ToUnsignedLongLongInteger());
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator LongLongInteger(RationalNumber o)
        {
            return (o.ToLongLongInteger());
        }

#endif
        #endregion

        #region �p�u���b�N���\�b�h

        /// <summary>
        /// <see cref="sbyte"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber FromSByte(sbyte o)
        {
            return (new RationalNumber((long)o));
        }

        /// <summary>
        /// <see cref="short"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromInt16(short o)
        {
            return (new RationalNumber((long)o));
        }

        /// <summary>
        /// <see cref="int"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromInt32(int o)
        {
            return (new RationalNumber(o));
        }

        /// <summary>
        /// <see cref="long"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromInt64(long o)
        {
            return (new RationalNumber(o));
        }

        /// <summary>
        /// <see cref="byte"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromByte(byte o)
        {
            return (new RationalNumber((ulong)o));
        }

        /// <summary>
        /// <see cref="ushort"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber FromUInt16(ushort o)
        {
            return (new RationalNumber((ulong)o));
        }

        /// <summary>
        /// <see cref="uint"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber FromUInt32(uint o)
        {
            return (new RationalNumber(o));
        }

        /// <summary>
        /// <see cref="ulong"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber FromUInt64(ulong o)
        {
            return (new RationalNumber(o));
        }

        /// <summary>
        /// <see cref="float"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromSingle(float o)
        {
            try
            {
                return (new RationalNumber(o));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(RationalNumber), o, e));
            }
        }

        /// <summary>
        /// <see cref="double"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromDouble(double o)
        {
            try
            {
                return (new RationalNumber(o));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(RationalNumber), o, e));
            }
        }

        /// <summary>
        /// <see cref="decimal"/>�I�u�W�F�N�g��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromDecimal(decimal o)
        {
            return (new RationalNumber(o));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromUnsignedLongLongInteger(UnsignedLongLongInteger o)
        {
            return (new RationalNumber(o));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="RationalNumber"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static RationalNumber FromLongLongInteger(LongLongInteger o)
        {
            return (new RationalNumber(o));
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g<see cref="byte"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public byte ToByte()
        {
            try
            {
                return (ConvertToSignedInteger().ToByte());
            }
            catch (OverflowException e)
            {
                throw (CreateOverflowExceptionObject(typeof(byte), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="short"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public short ToInt16()
        {
            try
            {
                return (ConvertToSignedInteger().ToInt16());
            }
            catch (OverflowException e)
            {
                throw (CreateOverflowExceptionObject(typeof(short), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="int"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public int ToInt32()
        {
            try
            {
                return (ConvertToSignedInteger().ToInt32());
            }
            catch (OverflowException e)
            {
                throw (CreateOverflowExceptionObject(typeof(int), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="long"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public long ToInt64()
        {
            try
            {
                return (ConvertToSignedInteger().ToInt64());
            }
            catch (OverflowException e)
            {
                throw (CreateOverflowExceptionObject(typeof(long), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="float"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public float ToSingle()
        {
            int factor;
            LongLongInteger q = ToIEEERealNumberImp(24, out factor);
            float real_value = q.ToSingle();
            if (factor == 0)
            {
            }
            else if (factor > 0)
            {
                while (factor >= 16)
                {
                    real_value /= 65536;
                    factor -= 16;
                }
                while (factor > 0)
                {
                    real_value /= 2;
                    --factor;
                }
            }
            else
            {
                while (factor <= -16)
                {
                    real_value *= 65536;
                    factor += 16;
                }
                while (factor < 0)
                {
                    real_value *= 2;
                    ++factor;
                }
            }
            return (real_value);
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="double"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public double ToDouble()
        {
            int factor;
            LongLongInteger q = ToIEEERealNumberImp(53, out factor);
            double real_value = q.ToDouble();
            if (factor == 0)
            {
            }
            else if (factor > 0)
            {
                while (factor >= 16)
                {
                    real_value /= 65536;
                    factor -= 16;
                }
                while (factor > 0)
                {
                    real_value /= 2;
                    --factor;
                }
            }
            else
            {
                while (factor <= -16)
                {
                    real_value *= 65536;
                    factor += 16;
                }
                while (factor < 0)
                {
                    real_value *= 2;
                    ++factor;
                }
            }
            return (real_value);
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="decimal"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public decimal ToDecimal()
        {
            try
            {
                SignType sign = _InternalNumerator.InternalSign;
                if (sign == SignType.Zero)
                    return (0m);
                UnsignedLongLongInteger n = _InternalNumerator.Abs();
                UnsignedLongLongInteger d = _InternalDenominator;
                Debug.Assert(!n.IsZero);
                Debug.Assert(!d.IsZero);
                UnsignedLongLongInteger max_n = d.LeftShift(96);
                int factor = 0;
                while (true)
                {
                    UnsignedLongLongInteger n2 = n.Multiply(10);
                    if (n2.CompareTo(max_n) >= 0)
                        break;
                    n = n2;
                    ++factor;
                }
                UnsignedLongLongInteger r;
                UnsignedLongLongInteger q = n.DivRem(d, out r);
                decimal real_value = q.ToDecimal();
                if (r.LeftShift(1).CompareTo(d) >= 0)
                    real_value += 1;
                while (factor >= 5)
                {
                    real_value /= 100000m;
                    factor -= 5;
                }
                while (factor > 0)
                {
                    real_value /= 10;
                    --factor;
                }
                if (sign == SignType.Negative)
                    real_value = -real_value;
                return (real_value);
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(decimal), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="sbyte"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public sbyte ToSByte()
        {
            try
            {
                return (ConvertToSignedInteger().ToSByte());
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(sbyte), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public ushort ToUInt16()
        {
            try
            {
                return (ConvertToSignedInteger().ToUInt16());
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(ushort), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public uint ToUInt32()
        {
            try
            {
                return (ConvertToSignedInteger().ToUInt32());
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(uint), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public ulong ToUInt64()
        {
            try
            {
                return (ConvertToSignedInteger().ToUInt64());
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(ulong), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger ToUnsignedLongLongInteger()
        {
            try
            {
                return (ConvertToSignedInteger().ToUnsignedLongLongInteger());
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), this, e));
            }
        }

        /// <summary>
        /// <see cref="RationalNumber"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public LongLongInteger ToLongLongInteger()
        {
            try
            {
                return (ConvertToSignedInteger());
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(LongLongInteger), this, e));
            }
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        private LongLongInteger ToIEEERealNumberImp(int max_fraction_part_bits, out int factor)
        {
            SignType sign = _InternalNumerator.InternalSign;
            if (sign == SignType.Zero)
            {
                factor = 0;
                return (LongLongInteger.Zero);
            }
            UnsignedLongLongInteger n = _InternalNumerator.Abs();
            UnsignedLongLongInteger d = _InternalDenominator;
            UnsignedLongLongInteger q;
            if (d.IsPowerOfTwo)
            {
                factor = d.BitLength - 1;
                q = n;
                if (q.BitLength == max_fraction_part_bits + 1)
                {
                    if (!q.IsEven)
                    {
                        if (q.TestBit(1))
                            q = q.Decrement();
                        else
                            q = q.Increment();
                    }
                    Debug.Assert(q.IsEven);
                    q = q.RightShift(1);
                    --factor;
                    Debug.Assert(q.BitLength == max_fraction_part_bits);
                }
                else if (q.BitLength > max_fraction_part_bits + 1)
                {
                    int bits = q.BitLength - max_fraction_part_bits - 1;
                    q = q.RightShift(bits);
                    factor -= bits;
                    Debug.Assert(q.BitLength == max_fraction_part_bits + 1);
                    if (!q.IsEven)
                    {
                        q = q.Increment();
                        if (q.IsPowerOfTwo)
                        {
                            q = q.RightShift(1);
                            --factor;
                        }
                    }
                    Debug.Assert(q.IsEven);
                    q = q.RightShift(1);
                    --factor;
                    Debug.Assert(q.BitLength == max_fraction_part_bits);
                }
                else
                {
                    Debug.Assert(q.BitLength <= max_fraction_part_bits);
                }
            }
            else
            {
                UnsignedLongLongInteger max_n = d.LeftShift(max_fraction_part_bits);
                //UnsignedLongLongInteger max_n_1 = d.LeftShift(max_fraction_part_bits - 1);
                factor = 0;
                q = n;
                if (max_fraction_part_bits + d.BitLength > n.BitLength)
                {
                    int bits = d.BitLength + max_fraction_part_bits - n.BitLength;
                    q = q.LeftShift(bits);
                    factor += bits;
                }
                if (q.CompareTo(max_n) < 0)
                {
                    q = q.LeftShift(1);
                    factor += 1;
                }
                Debug.Assert(q.CompareTo(max_n) >= 0);
                q = q.Divide(d);
                Debug.Assert(q.BitLength >= max_fraction_part_bits + 1);
                if (q.BitLength > max_fraction_part_bits + 1)
                {
                    int bits = q.BitLength - max_fraction_part_bits - 1;
                    q = q.RightShift(bits);
                    factor -= bits;
                }
                Debug.Assert(q.BitLength == max_fraction_part_bits + 1);
                if (!q.IsEven)
                {
                    q = q.Increment();
                    if (q.IsPowerOfTwo)
                    {
                        q = q.RightShift(1);
                        --factor;
                    }
                }
                Debug.Assert(q.IsEven);
                q = q.RightShift(1);
                --factor;
                Debug.Assert(q.BitLength == max_fraction_part_bits);
            }
            Debug.Assert(q.BitLength <= max_fraction_part_bits);
#if DEBUG
            // | q - (n / d << factor)| <= 0.5 �ł��邱�Ƃ���؂���
            if (factor >= 0)
            {
                UnsignedLongLongInteger v1 = q.Multiply(d).LeftShift(1);
                UnsignedLongLongInteger v2 = n.LeftShift(factor + 1);
                UnsignedLongLongInteger v3 = d;
                Debug.Assert(v1.ToLongLongInteger().Subtract(v2).Abs().CompareTo(v3) <= 0);
            }
            else
            {
                UnsignedLongLongInteger v1 = q.Multiply(d).LeftShift(-factor);
                UnsignedLongLongInteger v2 = n;
                UnsignedLongLongInteger v3 = d.LeftShift(-factor - 1);
                Debug.Assert(v1.ToLongLongInteger().Subtract(v2).Abs().CompareTo(v3) <= 0);
            }
#endif
            return (sign == SignType.Positive ? q.ToLongLongInteger() : q.Negate());
        }
        

        private bool ToBoolean()
        {
            return (Sign != 0);
        }

        private char ToChar()
        {
            try
            {
                return (ConvertToSignedInteger().ToChar());
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(char), this, e));
            }
        }

        private LongLongInteger ConvertToSignedInteger()
        {
            return (_InternalNumerator.Divide(_InternalDenominator));
        }

        private static Exception CreateOverflowExceptionObject(Type target_type, object value)
        {
            return (new OverflowException(string.Format(@"{0} �^�̃I�u�W�F�N�g'{1}'�́A{2} �^�ł͕\���ł��Ȃ��l�ł��B", value.GetType().FullName, value.ToString(), target_type.FullName)));
        }

        private static Exception CreateOverflowExceptionObject(Type target_type, object value, Exception e)
        {
            return (new OverflowException(string.Format(@"{0} �^�̃I�u�W�F�N�g'{1}'�́A{2} �^�ł͕\���ł��Ȃ��l�ł��B", value.GetType().FullName, value.ToString(), target_type.FullName), e));
        }

        #endregion

        #region IConvertible �����o

        TypeCode IConvertible.GetTypeCode()
        {
            return (TypeCode.Object);
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return (ToBoolean());
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return (ToByte());
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            return (ToChar());
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw (new InvalidCastException("DateTime�^�ɕϊ����邱�Ƃ͂ł��܂���B"));
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return (ToDecimal());
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return (ToDouble());
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return (ToInt16());
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return (ToInt32());
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return (ToInt64());
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return (ToSByte());
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return (ToSingle());
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return (ToString(provider));
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(UnsignedLongLongInteger))
                return (ToUnsignedLongLongInteger());
            else if (conversionType == typeof(LongLongInteger))
                return (ToLongLongInteger());
            else if (conversionType == typeof(RationalNumber))
                return (this);
            else if (conversionType == typeof(bool))
                return (((IConvertible)this).ToBoolean(provider));
            else if (conversionType == typeof(byte))
                return (((IConvertible)this).ToByte(provider));
            else if (conversionType == typeof(char))
                return (((IConvertible)this).ToChar(provider));
            else if (conversionType == typeof(DateTime))
                return (((IConvertible)this).ToDateTime(provider));
            else if (conversionType == typeof(decimal))
                return (((IConvertible)this).ToDecimal(provider));
            else if (conversionType == typeof(double))
                return (((IConvertible)this).ToDouble(provider));
            else if (conversionType == typeof(short))
                return (((IConvertible)this).ToInt16(provider));
            else if (conversionType == typeof(int))
                return (((IConvertible)this).ToInt32(provider));
            else if (conversionType == typeof(long))
                return (((IConvertible)this).ToInt64(provider));
            else if (conversionType == typeof(sbyte))
                return (((IConvertible)this).ToSByte(provider));
            else if (conversionType == typeof(float))
                return (((IConvertible)this).ToSingle(provider));
            else if (conversionType == typeof(string))
                return (((IConvertible)this).ToString(provider));
            else if (conversionType == typeof(ushort))
                return (((IConvertible)this).ToUInt16(provider));
            else if (conversionType == typeof(uint))
                return (((IConvertible)this).ToUInt32(provider));
            else if (conversionType == typeof(ulong))
                return (((IConvertible)this).ToUInt64(provider));
            else
                throw (new InvalidCastException(conversionType.FullName + "�^�ɂ͕ϊ��ł��܂���B"));
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return (ToUInt16());
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return (ToUInt32());
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return (ToUInt64());
        }

        #endregion
    }
}
