/*
  LongLongInteger.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace Palmtree.Math
{
    /// <summary>
    /// ���{�������̃N���X�ł��B
    /// </summary>
    [Serializable]
    public partial struct LongLongInteger
        : ISerializable
    {
        #region �p�u���b�N�t�B�[���h

        /// <summary>
        /// ����0������C���X�^���X�ł��B
        /// </summary>
        public static readonly LongLongInteger Zero;

        /// <summary>
        /// ����1������C���X�^���X�ł��B
        /// </summary>
        public static readonly LongLongInteger One;

        /// <summary>
        /// ����-1������C���X�^���X�ł��B
        /// </summary>
        public static readonly LongLongInteger MinusOne;

        #endregion

        #region �v���C�x�[�g�t�B�[���h

        private static string _member_name = "Value";
        private const ulong _nagated_long_min_value = 9223372036854775808UL;
        private static FormatterCreator _formatter_creator;
        private SignType _sign;
        private UnsignedLongLongInteger _abs;
        private int? _bit_length_cache;
        private bool? _is_power_of_two_cache;

        #endregion

        #region �R���X�g���N�^

        static LongLongInteger()
        {
            Zero = new LongLongInteger();
            One = new LongLongInteger(SignType.Positive, UnsignedLongLongInteger.One);
            MinusOne = new LongLongInteger(SignType.Negative, UnsignedLongLongInteger.One);
            _formatter_creator = new FormatterCreator();
#if DEBUG
            Debug.Assert("-" + _nagated_long_min_value.ToString() == long.MinValue.ToString());
#endif
        }

#if false
        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        public LongLongInteger()
        {
            _sign = 0;
            _abs = new UnsignedLongLongInteger();
            Debug.Assert((_sign == 0 && _abs.IsZero) || (_sign != 0 && !_abs.IsZero));
        }
#endif

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        public LongLongInteger(int value)
            : this((long)value)
        {
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        public LongLongInteger(long value)
        {
            if (value > 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger((ulong)value);
            }
            else if (value == 0)
            {
                _sign = SignType.Zero;
                _abs = UnsignedLongLongInteger.Zero;
            }
            else if (value == long.MinValue)
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger(_nagated_long_min_value);
            }
            else
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger((ulong)-value);
            }
            _bit_length_cache = null;
            _is_power_of_two_cache = null;
            Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        [CLSCompliant(false)]
        public LongLongInteger(uint value)
            : this((ulong)value)
        {
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        [CLSCompliant(false)]
        public LongLongInteger(ulong value)
        {
            if (value > 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger(value);
            }
            else
            {
                _sign = SignType.Zero;
                _abs = UnsignedLongLongInteger.Zero;
            }
            _bit_length_cache = null;
            _is_power_of_two_cache = null;
            Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        public LongLongInteger(UnsignedLongLongInteger value)
        {
            if (value.IsZero)
            {
                _sign = SignType.Zero;
                _abs = UnsignedLongLongInteger.Zero;
            }
            else
            {
                _sign = SignType.Positive;
                _abs = value;
            }
            _bit_length_cache = null;
            _is_power_of_two_cache = null;
            Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        public LongLongInteger(float value)
            : this((double)value)
        {
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        public LongLongInteger(double value)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
                throw (new ArgumentException(@"LongLongInteger�ŕ\���ł��Ȃ��l���w�肳��܂����B", "value"));
            if (value >= 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger(value);
            }
            else
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger(-value);
            }
            if (_abs.IsZero)
                _sign = SignType.Zero;
            _bit_length_cache = null;
            _is_power_of_two_cache = null;
            Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���ł��B
        /// </param>
        public LongLongInteger(decimal value)
        {
            if (value >= 0)
            {
                _sign = SignType.Positive;
                _abs = new UnsignedLongLongInteger(value);
            }
            else
            {
                _sign = SignType.Negative;
                _abs = new UnsignedLongLongInteger(-value);
            }
            if (_abs.IsZero)
                _sign = SignType.Zero;
            _bit_length_cache = null;
            _is_power_of_two_cache = null;
            Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        private LongLongInteger(SerializationInfo info, StreamingContext context)
        {
            string s = info.GetString(_member_name);
            if (!TryParseImp(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out _sign, out _abs))
                throw (new FormatException(string.Format("������'{0}'��LongLongInteger�̌`���ł͂���܂���B", s)));
            _bit_length_cache = null;
            _is_power_of_two_cache = null;
            Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        internal LongLongInteger(SignType sign, UnsignedLongLongInteger value)
        {
            _sign = value.IsZero ? SignType.Zero : sign;
            _abs = value;
            _bit_length_cache = null;
            _is_power_of_two_cache = null;
            Debug.Assert((_sign == SignType.Zero && _abs.IsZero) || (_sign != SignType.Zero && !_abs.IsZero));
        }

        #endregion

        #region �p�u���b�N���\�b�h

#if DEBUG

        /// <summary>
        /// �e�X�g�f�[�^����<see cref="LongLongInteger"/>�I�u�W�F�N�g�𐶐����܂��B
        /// </summary>
        /// <param name="data">
        /// �e�X�g�f�[�^�ł��B
        /// </param>
        /// <returns>
        /// �������ꂽ<see cref="LongLongInteger"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static LongLongInteger FromTestData(ushort[] data)
        {
            TestDataReader reader = new TestDataReader(data);
            ushort header = reader.GetUShortValue();
            SignType sign;
            if (header == 1)
                sign = SignType.Positive;
            else if (header == 2)
                sign = SignType.Negative;
            else
                throw (new ArgumentException("�e�X�g�f�[�^�̌`���Ɍ�肪����܂��B", "data"));
            ArraySegment<ushort> p = reader.GetSegment();
            reader.AssertEndOfData();
            if (p.Count == 0)
                return (Zero);
            else
                return (new LongLongInteger(sign, new UnsignedLongLongInteger(p)));
        }

        /// <summary>
        /// �I�u�W�F�N�g�̓�e��������܂��B
        /// </summary>
        /// <param name="data">
        /// �I�u�W�F�N�g�̓�e��������邽�߂̔�r�f�[�^�ł��B
        /// </param>
        /// <returns>
        /// �����ɐ��������true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public bool EqualsInternally(ushort[] data)
        {
            TestDataReader reader = new TestDataReader(data);
            ushort header = reader.GetUShortValue();
            SignType data_sign;
            if (header == 1)
                data_sign = SignType.Positive;
            else if (header == 2)
                data_sign = SignType.Negative;
            else
                throw (new ArgumentException("�e�X�g�f�[�^�̌`���Ɍ�肪����܂��B", "data"));
            ArraySegment<ushort> data_abs = reader.GetSegment();
            reader.AssertEndOfData();
            if (data_abs.Count == 0)
                data_sign = SignType.Zero;
            return (EqualsInternally(data_sign, data_abs));
        }

#endif

        #endregion

        #region �p�u���b�N�v���p�e�B

        /// <summary>
        /// �l�����Ȃ琳�̐����A�l��0�Ȃ��0�A�l�����Ȃ�Ε��̐����ł��B
        /// </summary>
        public int Sign
        {
            get
            {
                return ((int)_sign);
            }
        }

        /// <summary>
        /// �l��0�Ȃ�true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsZero
        {
            get
            {
                return (_sign == SignType.Zero);
            }
        }

        /// <summary>
        /// �l��1�Ȃ�true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsOne
        {
            get
            {
                return (_sign == SignType.Positive && _abs.IsOne);
            }
        }

        /// <summary>
        /// �l��-1�Ȃ�true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsMinusOne
        {
            get
            {
                return (_sign == SignType.Negative && _abs.IsOne);
            }
        }

        /// <summary>
        /// �l������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsEven
        {
            get
            {
                return (_abs.IsEven);
            }
        }

        #endregion

        #region �C���^�[�i�����\�b�h

        internal bool EqualsInternally(SignType data_sign, ArraySegment<ushort> data_abs)
        {
            return (_sign == data_sign && _abs.EqualsInternally(data_abs));
        }

        internal long ToLong(Type target_type)
        {
            ulong value = _abs.ToULong(target_type);
            switch (_sign)
            {
                case SignType.Zero:
                    return (0L);
                case SignType.Positive:
                    if (value > long.MaxValue)
                        throw (CreateOverflowExceptionObject(target_type, this));
                    return ((long)value);
                default:
                    if (value == _nagated_long_min_value)
                        return (long.MinValue);
                    else if (value >= _nagated_long_min_value)
                        throw (CreateOverflowExceptionObject(target_type, this));
                    return (-(long)value);
            }
        }

        internal SignType InternalSign
        {
            get
            {
                return (_sign);
            }
        }

        #endregion

        #region object ����p�����ꂽ�����o

        /// <summary>
        /// �I�u�W�F�N�g���_���I�ɓ��������ǂ������ׂ܂��B
        /// </summary>
        /// <param name="o">
        /// ��r�Ώۂ̃I�u�W�F�N�g�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g���_���I�ɓ������Ȃ��true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </returns>
        public override bool Equals(object o)
        {
            if (o == null)
                return (false);
            else if (o is ulong)
                return (Equals((ulong)o));
            else if (o is long)
                return (Equals((long)o));
            else if (o is UnsignedLongLongInteger)
                return (Equals((UnsignedLongLongInteger)o));
            else if (o is LongLongInteger)
                return (Equals((LongLongInteger)o));
            else
                return (false);
        }

        /// <summary>
        /// �I�u�W�F�N�g�̃n�b�V���R�[�h��v�Z���܂��B
        /// </summary>
        /// <returns>
        /// �v�Z���ʂ̃n�b�V���R�[�h�ł��B
        /// </returns>
        public override int GetHashCode()
        {
            return (_sign.GetHashCode() ^ _abs.GetHashCode());
        }

        /// <summary>
        /// �I�u�W�F�N�g��\�����镶�����쐬���܂��B
        /// </summary>
        /// <returns>
        /// �I�u�W�F�N�g��\�����镶����ł��B
        /// </returns>
        public override string ToString()
        {
            return (ToString("G", null));
        }

        #endregion

        #region ISerializable �����o

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(_member_name, ToString("R", CultureInfo.InvariantCulture));
        }

        #endregion
    }
}