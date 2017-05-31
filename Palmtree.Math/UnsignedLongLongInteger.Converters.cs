/*
  UnsignedLongLongInteger.Converters.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

// ���Z�q�̃I�[�o�[���[�h�Ɋւ���K�C�h���C��:
//   http://msdn.microsoft.com/ja-jp/library/ms229032.aspx
// �ϊ����Z�q�̃K�C�h���C���F
//   http://msdn.microsoft.com/ja-jp/library/ms229033(v=VS.100).aspx

namespace Palmtree.Math
{
    partial struct UnsignedLongLongInteger
         : IConvertible
    {
        #region ���Z�q

#if !CONCEAL_OPERATORS

        /// <summary>
        /// <see cref="sbyte"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator UnsignedLongLongInteger(sbyte o)
        {
            return (FromSByte(o));
        }

        /// <summary>
        /// <see cref="short"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(short o)
        {
            return (FromInt16(o));
        }

        /// <summary>
        /// <see cref="int"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(int o)
        {
            return (FromInt32(o));
        }

        /// <summary>
        /// <see cref="long"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(long o)
        {
            return (FromInt64(o));
        }

#if !CONCEAL_IMPLICIT_OPERATORS


        /// <summary>
        /// <see cref="byte"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator UnsignedLongLongInteger(byte o)
        {
            return (FromByte(o));
        }

        /// <summary>
        /// <see cref="ushort"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator UnsignedLongLongInteger(ushort o)
        {
            return (FromUInt16(o));
        }

        /// <summary>
        /// <see cref="uint"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator UnsignedLongLongInteger(uint o)
        {
            return (FromUInt32(o));
        }

        /// <summary>
        /// <see cref="ulong"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator UnsignedLongLongInteger(ulong o)
        {
            return (FromUInt64(o));
        }

#endif

        /// <summary>
        /// <see cref="float"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(float o)
        {
            return (FromSingle(o));
        }

        /// <summary>
        /// <see cref="double"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(double o)
        {
            return (FromDouble(o));
        }

        /// <summary>
        /// <see cref="decimal"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(decimal o)
        {
            return (FromDecimal(o));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="sbyte"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator sbyte(UnsignedLongLongInteger o)
        {
            return (o.ToSByte());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="short"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator short(UnsignedLongLongInteger o)
        {
            return (o.ToInt16());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="int"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator int(UnsignedLongLongInteger o)
        {
            return (o.ToInt32());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="long"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator long(UnsignedLongLongInteger o)
        {
            return (o.ToInt64());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="byte"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator byte(UnsignedLongLongInteger o)
        {
            return (o.ToByte());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ushort(UnsignedLongLongInteger o)
        {
            return (o.ToUInt16());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="uint"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator uint(UnsignedLongLongInteger o)
        {
            return (o.ToUInt32());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ulong"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ulong(UnsignedLongLongInteger o)
        {
            return (o.ToUInt64());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="float"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator float(UnsignedLongLongInteger o)
        {
            return (o.ToSingle());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="double"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator double(UnsignedLongLongInteger o)
        {
            return (o.ToDouble());
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="decimal"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator decimal(UnsignedLongLongInteger o)
        {
            return (o.ToDecimal());
        }

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        /// <summary>
        /// <see cref="sbyte"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromSByte(sbyte value)
        {
            try
            {
                return (new UnsignedLongLongInteger((long)value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="short"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger FromInt16(short value)
        {
            try
            {
                return (new UnsignedLongLongInteger((long)value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="int"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger FromInt32(int value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="long"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger FromInt64(long value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="byte"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger FromByte(byte value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="ushort"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromUInt16(ushort value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="uint"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromUInt32(uint value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="ulong"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static UnsignedLongLongInteger FromUInt64(ulong value)
        {
            return (new UnsignedLongLongInteger(value));
        }

        /// <summary>
        /// <see cref="float"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger FromSingle(float value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="double"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger FromDouble(double value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="decimal"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <param name="value">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static UnsignedLongLongInteger FromDecimal(decimal value)
        {
            try
            {
                return (new UnsignedLongLongInteger(value));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), value, e));
            }
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="sbyte"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public sbyte ToSByte()
        {
            return ((sbyte)CastToUnsignedInteger(typeof(sbyte), (ulong)sbyte.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="short"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public short ToInt16()
        {
            return ((short)CastToUnsignedInteger(typeof(short), (ulong)short.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="int"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public int ToInt32()
        {
            return ((int)CastToUnsignedInteger(typeof(int), (ulong)int.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="long"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public long ToInt64()
        {
            return ((long)CastToUnsignedInteger(typeof(long), (ulong)long.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="byte"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public byte ToByte()
        {
            return ((byte)CastToUnsignedInteger(typeof(byte), (ulong)byte.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public ushort ToUInt16()
        {
            return ((ushort)CastToUnsignedInteger(typeof(ushort), (ulong)ushort.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="uint"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public uint ToUInt32()
        {
            return ((uint)CastToUnsignedInteger(typeof(uint), (ulong)uint.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ulong"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public ulong ToUInt64()
        {
            return ((ulong)CastToUnsignedInteger(typeof(ulong), (ulong)ulong.MaxValue));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="float"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public float ToSingle()
        {
            float result = 0;
            for (int index = _InternalValue.Length - 1; index >= 0; --index)
                result = result * 0x10000U + _InternalValue[index];
            return (result);
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="double"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public double ToDouble()
        {
            double result = 0;
            for (int index = _InternalValue.Length - 1; index >= 0; --index)
                result = result * 0x10000U + _InternalValue[index];
            return (result);
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="decimal"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public decimal ToDecimal()
        {
            try
            {
                decimal result = 0;
                for (int index = _InternalValue.Length - 1; index >= 0; --index)
                    result = result * 0x10000 + _InternalValue[index];
                return (result);
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(decimal), this, e));
            }
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        private bool ToBoolean()
        {
            return (_InternalValue.Length != 0);
        }

        private char ToChar()
        {
            return ((char)CastToUnsignedInteger(typeof(char), (ulong)char.MaxValue));
        }

        private ulong CastToUnsignedInteger(Type target_type, ulong max_value)
        {
            ulong value = ToULong(target_type);
            if (value > (ulong)max_value)
                throw (CreateOverflowExceptionObject(target_type, this));
            return (value);
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

        TypeCode IConvertible.GetTypeCode()
        {
            return (TypeCode.Object);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if (conversionType == typeof(UnsignedLongLongInteger))
                return (this);
            else if (conversionType == typeof(LongLongInteger))
                return (new LongLongInteger(SignType.Positive, this));
            else if (conversionType == typeof(RationalNumber))
                return (new RationalNumber(this));
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

        #endregion
    }
}