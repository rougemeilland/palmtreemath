/*
  RationalNumber.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using Palmtree.Math.Formatter;
using Palmtree.Math.Round;

namespace Palmtree.Math
{
    /// <summary>
    /// �����揜�ɂ�萸�x�����Ȃ��Ȃ����̃N���X�ł��B
    /// </summary>
    [Serializable]
    public partial struct RationalNumber
        : ISerializable
    {
        #region �p�u���b�N�t�B�[���h

        /// <summary>
        /// 0������C���X�^���X�ł��B
        /// </summary>
        public static readonly RationalNumber Zero;

        /// <summary>
        /// 1������C���X�^���X�ł��B
        /// </summary>
        public static readonly RationalNumber One;

        /// <summary>
        /// -1������C���X�^���X�ł��B
        /// </summary>
        public static readonly RationalNumber MinusOne;

        #endregion

        #region �v���C�x�[�g�t�B�[���h

        private static string _member_name = "Value";
        private const ulong _nagated_long_min_value = 9223372036854775808UL;
        private static RationalNumberRounderCollection _rounders;
        private static IBaseNumberInfo _decimal_base_number_info;
        private static FormatterCreator _formatter_creator;
        private LongLongInteger? __InternalNumerator;
        private UnsignedLongLongInteger? __InternalDenominator;

        #endregion

        #region �v���C�x�[�g�v���p�e�B

        private LongLongInteger _InternalNumerator
        {
            get
            {
                if (!__InternalNumerator.HasValue)
                    __InternalNumerator = LongLongInteger.Zero;
                return (__InternalNumerator.Value);
            }

            set
            {
                __InternalNumerator = value;
            }
        }

        private UnsignedLongLongInteger _InternalDenominator
        {
            get
            {
                if (!__InternalDenominator.HasValue)
                    __InternalDenominator = UnsignedLongLongInteger.One;
                return (__InternalDenominator.Value);
            }

            set
            {
                __InternalDenominator = value;
            }
        }

        #endregion

        #region �R���X�g���N�^

        static RationalNumber()
        {
            Zero = new RationalNumber(LongLongInteger.Zero, UnsignedLongLongInteger.One);
            One = new RationalNumber(LongLongInteger.One, UnsignedLongLongInteger.One);
            MinusOne = new RationalNumber(LongLongInteger.MinusOne, UnsignedLongLongInteger.One);
            _rounders = new RationalNumberRounderCollection();
            _decimal_base_number_info = DecimalBaseNumberInfo.DefaultInstance;
            _formatter_creator = new FormatterCreator();
#if DEBUG
            Debug.Assert("-" + _nagated_long_min_value.ToString() == long.MinValue.ToString());
#endif
        }

#if false
        /// <summary>
        /// �f�t�H���g�R���X�g���N�^�ł��B
        /// </summary>
        public RationalNumber()
            : this(LongLongInteger.Zero, UnsignedLongLongInteger.One)
        {
        }
#endif

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���l�ł��B
        /// </param>
        public RationalNumber(int value)
            : this((long)value)
        {
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���l�ł��B
        /// </param>
        public RationalNumber(long value)
        {
            __InternalNumerator = new LongLongInteger(value);
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���l�ł��B
        /// </param>
        [CLSCompliant(false)]
        public RationalNumber(uint value)
            : this((ulong)value)
        {
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ鐮���l�ł��B
        /// </param>
        [CLSCompliant(false)]
        public RationalNumber(ulong value)
        {
            __InternalNumerator = new LongLongInteger(value);
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ镪���l�ł��B
        /// </param>
        public RationalNumber(UnsignedLongLongInteger value)
        {
            __InternalNumerator = value.ToLongLongInteger();
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ镪���l�ł��B
        /// </param>
        public RationalNumber(LongLongInteger value)
        {
            __InternalNumerator = value;
            __InternalDenominator = UnsignedLongLongInteger.One;
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ镪���l�ł��B
        /// </param>
        public RationalNumber(float value)
            : this((double)value)
        {
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ镪���l�ł��B
        /// </param>
        public RationalNumber(double value)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
                throw (new ArgumentException(@"LongLongInteger�ŕ\���ł��Ȃ��l���w�肳��܂����B", "value"));
            bool negative = false;
            if (value < 0)
            {
                negative = true;
                value = -value;
            }
            if (value == 0)
            {
                __InternalNumerator = LongLongInteger.Zero;
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else if (value >= (1L << 51))
            {
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else
            {
                int d = 0;
                double l = (double)(1UL << 21);
                double m = (double)(1UL << 32);
                while (value < l)
                {
                    value *= m;
                    d += 32;
                }
                l = (double)(1UL << 45);
                m = (double)(1UL << 8);
                while (value < l)
                {
                    value *= m;
                    d += 8;
                }
                l = (double)(1UL << 51);
                m = (double)(1UL << 2);
                while (value < l)
                {
                    value *= m;
                    d += 2;
                }
                l = (double)(1UL << 52);
                m = (double)(1UL << 1);
                while (value < l)
                {
                    value *= m;
                    d += 1;
                }
                Debug.Assert(value <= (1UL << 53) - 1);
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.One.LeftShift(d);
                Reduce();
            }
        }

        /// <summary>
        /// �R���X�g���N�^�ł��B
        /// �w�肳�ꂽ�����̒l����C���X�^���X��쐬���܂��B
        /// </summary>
        /// <param name="value">
        /// �����l�ƂȂ镪���l�ł��B
        /// </param>
        public RationalNumber(decimal value)
        {
            bool negative = false;
            if (value < 0)
            {
                negative = true;
                value = -value;
            }
            if (value == 0)
            {
                __InternalNumerator = LongLongInteger.Zero;
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else if (value >= 10000000000000000000000000000m)
            {
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.One;
            }
            else
            {
                ulong d = 0;
                decimal l = 7922816251426m;
                decimal m = 10000000000000000m;
                while (value < l)
                {
                    value *= m;
                    d += 16;
                }
                l = 7922816251426433759354395m;
                m = 10000m;
                while (value < l)
                {
                    value *= m;
                    d += 4;
                }
                l = 7922816251426433759354395033m;
                m = 10m;
                while (value < l)
                {
                    value *= m;
                    d += 1;
                }
                Debug.Assert(value >= 7922816251426433759354395033m && value <= 79228162514264337593543950335m);
                __InternalNumerator = new LongLongInteger(negative ? -value : value);
                __InternalDenominator = UnsignedLongLongInteger.Power(UnsignedLongLongInteger.Ten, d);
                Reduce();
            }
        }

        private RationalNumber(SerializationInfo info, StreamingContext context)
        {
            string s = info.GetString(_member_name);
            LongLongInteger result_numerator;
            UnsignedLongLongInteger result_denominator;
            if (!TryParseImp(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out result_numerator, out result_denominator))
                throw (new FormatException(string.Format("������'{0}'��RationalNumber�̌`���ł͂���܂���B", s)));
            __InternalNumerator = result_numerator;
            __InternalDenominator = result_denominator;
            Reduce();
        }

        private RationalNumber(LongLongInteger numerator, UnsignedLongLongInteger denominator)
        {
            if (denominator.IsZero)
                throw (new ArgumentException("����Ƃ���0���^�����܂����B", "denominator"));
            __InternalNumerator = numerator;
            __InternalDenominator = denominator;
            Reduce();
        }

        #endregion

        #region �p�u���b�N���\�b�h

        /// <summary>
        /// �I�u�W�F�N�g�𕪐��ŕ\�������ꍇ�̕��q�ƕ����擾���܂��B
        /// �擾����镪�q�ƕ���͊���ł��B
        /// </summary>
        /// <param name="denominator">
        /// �I�u�W�F�N�g�𕪐��ŕ\�������ꍇ�̕���v�f�̒l�ł��B
        /// </param>
        /// <returns>
        /// �I�u�W�F�N�g�𕪐��ŕ\�������ꍇ�̕��q�v�f�̒l�ł��B
        /// </returns>
        public LongLongInteger ToFraction(out UnsignedLongLongInteger denominator)
        {
            denominator = _InternalDenominator;
            return (_InternalNumerator);
        }

#if DEBUG

        /// <summary>
        /// �e�X�g�f�[�^����<see cref="RationalNumber"/>�I�u�W�F�N�g�𐶐����܂��B
        /// </summary>
        /// <param name="data">
        /// �e�X�g�f�[�^�ł��B
        /// </param>
        /// <returns>
        /// �������ꂽ<see cref="RationalNumber"/>�I�u�W�F�N�g�ł��B
        /// </returns>
        [CLSCompliant(false)]
        public static RationalNumber FromTestData(ushort[] data)
        {
            TestDataReader reader = new TestDataReader(data);
            ushort header = reader.GetUShortValue();
            SignType data_sign;
            if (header == 3)
                data_sign = SignType.Positive;
            else if (header == 4)
                data_sign = SignType.Negative;
            else
                throw (new ArgumentException("�e�X�g�f�[�^�̌`���Ɍ�肪����܂��B", "data"));
            ArraySegment<ushort> data_numerator = reader.GetSegment();
            ArraySegment<ushort> data_denominator = reader.GetSegment();
            reader.AssertEndOfData();
            if (data_numerator.Count == 0)
                return (Zero);
            else
                return (new RationalNumber(new LongLongInteger(data_sign, new UnsignedLongLongInteger(data_numerator)), new UnsignedLongLongInteger(data_denominator)));
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
            if (header == 3)
                data_sign = SignType.Positive;
            else if (header == 4)
                data_sign = SignType.Negative;
            else
                throw (new ArgumentException("�e�X�g�f�[�^�̌`���Ɍ�肪����܂��B", "data"));
            ArraySegment<ushort> data_numerator = reader.GetSegment();
            ArraySegment<ushort> data_denominator = reader.GetSegment();
            reader.AssertEndOfData();
            if (data_numerator.Count == 0)
                data_sign = SignType.Zero;
            return (_InternalNumerator.EqualsInternally(data_sign, data_numerator) && _InternalDenominator.EqualsInternally(data_denominator));
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
                return (_InternalNumerator.Sign);
            }
        }

        /// <summary>
        /// �l��0�Ȃ�true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsZero
        {
            get
            {
                return (_InternalNumerator.IsZero);
            }
        }

        /// <summary>
        /// �l��1�Ȃ�true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsOne
        {
            get
            {
                return (_InternalNumerator.IsOne && _InternalDenominator.IsOne);
            }
        }

        /// <summary>
        /// �l��-1�Ȃ�true�A�����ł͂Ȃ��̂Ȃ�false�ł��B
        /// </summary>
        public bool IsMinusOne
        {
            get
            {
                return (_InternalNumerator.IsMinusOne && _InternalDenominator.IsOne);
            }
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        private void Reduce()
        {
            UnsignedLongLongInteger gcd = _InternalNumerator.GreatestCommonDivisor(_InternalDenominator);
            if (!gcd.IsZero && !gcd.IsOne)
            {
                _InternalNumerator = _InternalNumerator.DivideExactly(gcd);
                _InternalDenominator = _InternalDenominator.DivideExactly(gcd);
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
                return (Equals(this, (ulong)o));
            else if (o is long)
                return (Equals(this, (long)o));
            else if (o is UnsignedLongLongInteger)
                return (Equals(this, (UnsignedLongLongInteger)o));
            else if (o is LongLongInteger)
                return (Equals(this, (LongLongInteger)o));
            else if (o is RationalNumber)
                return (Equals(this, (RationalNumber)o));
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
            return (_InternalNumerator.GetHashCode() ^ _InternalDenominator.GetHashCode());
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
