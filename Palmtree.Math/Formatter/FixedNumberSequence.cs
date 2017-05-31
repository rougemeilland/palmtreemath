/*
  FixedNumberSequence.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Diagnostics;

namespace Palmtree.Math.Formatter
{
    internal class FixedNumberSequence
        : INumberSequence
    {
        #region �v���C�x�[�g�t�B�[���h

        private byte[] _digits;
        private int _index;

        #endregion

        #region �R���X�g���N�^

        public FixedNumberSequence(byte[] digits)
        {
            _digits = digits;
            _index = 0;
        }

        #endregion

        #region �v���C�x�[�g���\�b�h

        public static byte[] HalfAdjust(byte[] digits, byte last_digit, IBaseNumberInfo base_number_info, ref int offset)
        {
            byte base_number = base_number_info.Value;
            if (last_digit * 2 < base_number)
                return (digits);
            byte[] result = new byte[digits.Length];
            int index = digits.Length - 1;
            int carry = 1;
            for (; index >= 0; --index)
            {
                carry += digits[index];
                result[index] = (byte)(carry % base_number);
                carry /= base_number;
            }
            Debug.Assert(carry <= byte.MaxValue);
            if (carry > 0)
            {
                digits = result;
                result = new byte[digits.Length + 1];
                if (digits.Length > 0)
                    Array.Copy(digits, 0, result, 1, digits.Length);
                result[0] = (byte)carry;
                ++offset;
            }
            return (result);
        }

        #endregion

        #region INumberSequence �����o

        bool INumberSequence.IsZero
        {
            get
            {
                return (_index >= _digits.Length);
            }
        }

        byte INumberSequence.GetDigit()
        {
            if (_index >= _digits.Length)
            {
                ++_index;
                return (0);
            }
            else
            {
                byte value = _digits[_index];
                ++_index;
                return (value);
            }
        }

        #endregion
    }
}
