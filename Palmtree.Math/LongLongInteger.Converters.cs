/*
  LongLongInteger.Converters.cs

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
    partial struct LongLongInteger
        : IConvertible
    {
        #region ���Z�q

#if !CONCEAL_OPERATORS

#if !CONCEAL_IMPLICIT_OPERATORS

        /// <summary>
        /// <see cref="sbyte"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator LongLongInteger(sbyte o)
        {
            return (FromSByte(o));
        }

        /// <summary>
        /// <see cref="short"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator LongLongInteger(short o)
        {
            return (FromInt16(o));
        }

        /// <summary>
        /// <see cref="int"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator LongLongInteger(int o)
        {
            return (FromInt32(o));
        }

        /// <summary>
        /// <see cref="long"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator LongLongInteger(long o)
        {
            return (FromInt64(o));
        }

        /// <summary>
        /// <see cref="byte"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator LongLongInteger(byte o)
        {
            return (FromByte(o));
        }

        /// <summary>
        /// <see cref="short"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator LongLongInteger(ushort o)
        {
            return (FromUInt16(o));
        }

        /// <summary>
        /// <see cref="uint"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator LongLongInteger(uint o)
        {
            return (FromUInt32(o));
        }

        /// <summary>
        /// <see cref="ulong"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static implicit operator LongLongInteger(ulong o)
        {
            return (FromUInt64(o));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g��ÖٓI��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static implicit operator LongLongInteger(UnsignedLongLongInteger o)
        {
            return (FromUnsignedLongLongInteger(o));
        }

#endif

        /// <summary>
        /// <see cref="float"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator LongLongInteger(float o)
        {
            return (FromSingle(o));
        }

        /// <summary>
        /// <see cref="double"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator LongLongInteger(double o)
        {
            return (FromDouble(o));
        }

        /// <summary>
        /// <see cref="decimal"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator LongLongInteger(decimal o)
        {
            return (FromDecimal(o));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="sbyte"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator sbyte(LongLongInteger o)
        {
            return (o.ToSByte());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="short"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator short(LongLongInteger o)
        {
            return (o.ToInt16());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="int"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator int(LongLongInteger o)
        {
            return (o.ToInt32());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="long"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator long(LongLongInteger o)
        {
            return (o.ToInt64());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="byte"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator byte(LongLongInteger o)
        {
            return (o.ToByte());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ushort(LongLongInteger o)
        {
            return (o.ToUInt16());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="uint"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator uint(LongLongInteger o)
        {
            return (o.ToUInt32());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ulong"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static explicit operator ulong(LongLongInteger o)
        {
            return (o.ToUInt64());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="float"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator float(LongLongInteger o)
        {
            return (o.ToSingle());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="double"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator double(LongLongInteger o)
        {
            return (o.ToDouble());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="decimal"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator decimal(LongLongInteger o)
        {
            return (o.ToDecimal());
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����鉉�Z�q�ł��B
        /// </summary>
        /// <param name="o">
        /// �ϊ�����I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static explicit operator UnsignedLongLongInteger(LongLongInteger o)
        {
            return (o.ToUnsignedLongLongInteger());
        }

#endif

        #endregion

        #region �p�u���b�N���\�b�h

        /// <summary>
        /// <see cref="sbyte"/>�I�u�W�F�N�g��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger FromSByte(sbyte o)
        {
            return (new LongLongInteger((long)o));
        }

        /// <summary>
        /// <see cref="short"/>�I�u�W�F�N�g��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromInt16(short o)
        {
            return (new LongLongInteger((long)o));
        }

        /// <summary>
        /// <see cref="int"/>�I�u�W�F�N�g��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromInt32(int o)
        {
            return (new LongLongInteger(o));
        }

        /// <summary>
        /// <see cref="long"/>�I�u�W�F�N�g��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromInt64(long o)
        {
            return (new LongLongInteger(o));
        }

        /// <summary>
        /// <see cref="byte"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromByte(byte o)
        {
            return (new LongLongInteger((ulong)o));
        }

        /// <summary>
        /// <see cref="ushort"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger FromUInt16(ushort o)
        {
            return (new LongLongInteger((ulong)o));
        }

        /// <summary>
        /// <see cref="uint"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger FromUInt32(uint o)
        {
            return (new LongLongInteger(o));
        }

        /// <summary>
        /// <see cref="ulong"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger FromUInt64(ulong o)
        {
            return (new LongLongInteger(o));
        }

        /// <summary>
        /// <see cref="UnsignedLongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromUnsignedLongLongInteger(UnsignedLongLongInteger o)
        {
            return (new LongLongInteger(o));
        }

        /// <summary>
        /// <see cref="float"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromSingle(float o)
        {
            try
            {
                return (new LongLongInteger(o));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(LongLongInteger), o, e));
            }
        }

        /// <summary>
        /// <see cref="double"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromDouble(double o)
        {
            try
            {
                return (new LongLongInteger(o));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(LongLongInteger), o, e));
            }
        }

        /// <summary>
        /// <see cref="decimal"/>�I�u�W�F�N�g�𖾎��I��<see cref="LongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public static LongLongInteger FromDecimal(decimal o)
        {
            try
            {
                return (new LongLongInteger(o));
            }
            catch (ArgumentException e)
            {
                throw (CreateOverflowExceptionObject(typeof(LongLongInteger), o, e));
            }
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="sbyte"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public sbyte ToSByte()
        {
            return ((sbyte)CastToSignedInteger(typeof(sbyte), sbyte.MaxValue, sbyte.MinValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="short"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public short ToInt16()
        {
            return ((short)CastToSignedInteger(typeof(short), short.MaxValue, short.MinValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="int"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public int ToInt32()
        {
            return ((int)CastToSignedInteger(typeof(int), int.MaxValue, int.MinValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="long"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public long ToInt64()
        {
            return ((long)CastToSignedInteger(typeof(long), long.MaxValue, long.MinValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g<see cref="byte"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public byte ToByte()
        {
            return ((byte)CastToUnsignedInteger(typeof(byte), byte.MaxValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public ushort ToUInt16()
        {
            return ((ushort)CastToUnsignedInteger(typeof(ushort), ushort.MaxValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public uint ToUInt32()
        {
            return ((uint)CastToUnsignedInteger(typeof(uint), uint.MaxValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="ushort"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public ulong ToUInt64()
        {
            return ((ulong)CastToUnsignedInteger(typeof(ulong), ulong.MaxValue));
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="float"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public float ToSingle()
        {
            float result = _abs.ToSingle();
            if (_sign == SignType.Negative)
                result = -result;
            return (result);
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="double"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public double ToDouble()
        {
            double result = _abs.ToDouble();
            if (_sign == SignType.Negative)
                result = -result;
            return (result);
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="decimal"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public decimal ToDecimal()
        {
            try
            {
                decimal result = _abs.ToDecimal();
                if (_sign == SignType.Negative)
                    result = -result;
                return (result);
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(decimal), this, e));
            }
        }

        /// <summary>
        /// <see cref="LongLongInteger"/>�I�u�W�F�N�g�𖾎��I��<see cref="UnsignedLongLongInteger"/>�^�ɕϊ����܂��B
        /// </summary>
        /// <returns>
        /// �ϊ����ꂽ�I�u�W�F�N�g�ł��B
        /// </returns>
        public UnsignedLongLongInteger ToUnsignedLongLongInteger()
        {
            try
            {
                if (_sign == SignType.Zero)
                    return (UnsignedLongLongInteger.Zero);
                else if (_sign == SignType.Negative)
                    throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), this));
                else
                    return (_abs);
            }
            catch (Exception e)
            {
                throw (CreateOverflowExceptionObject(typeof(UnsignedLongLongInteger), this, e));
            }
        }

        #endregion

        #region �C���^�[�i�����\�b�h

        internal char ToChar()
        {
            return ((char)CastToUnsignedInteger(typeof(char), char.MaxValue));
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        private bool ToBoolean()
        {
            return (_sign != SignType.Zero);
        }

        private ulong CastToUnsignedInteger(Type target_type, ulong max_value)
        {
            if (_sign == SignType.Zero)
                return (0UL);
            else if (_sign == SignType.Positive)
            {
                ulong value = _abs.ToUInt64();
                if (value > max_value)
                    throw (CreateOverflowExceptionObject(target_type, this));
                else
                    return (value);
            }
            else
                throw (CreateOverflowExceptionObject(target_type, this));
        }

        private long CastToSignedInteger(Type target_type, long max_value, long min_value)
        {
            Debug.Assert(max_value > 0);
            Debug.Assert(min_value < 0);
            if (_sign == SignType.Zero)
                return (0L);
            else if (_sign == SignType.Positive)
            {
                ulong value = _abs.ToUInt64();
                if (value > (ulong)max_value)
                    throw (CreateOverflowExceptionObject(target_type, this));
                else
                    return ((long)value);
            }
            else
            {
                ulong value = _abs.ToUInt64();
                if (min_value == long.MinValue)
                {
                    if (value > _nagated_long_min_value)
                        throw (CreateOverflowExceptionObject(target_type, this));
                    else if (value == _nagated_long_min_value)
                        return (long.MinValue);
                    else
                        return (-(long)value);
                }
                else
                {
                    if (value > (ulong)-min_value)
                        throw (CreateOverflowExceptionObject(target_type, this));
                    else
                        return (-(long)value);
                }
            }
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
                return (this);
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