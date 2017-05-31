using System;
using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class BitOperationImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort[] OnesComplement(ushort[] x, int n)
        {
            //Debug.Assert(x.Length > 0);
            Debug.Assert(n > 0);
            int n_words = (n - 1) / 16 + 1;
            ushort[] z = new ushort[n_words];
            int index = 0;
            for (; index < x.Length && index < z.Length; ++index)
            {
                z[index] = (ushort)~x[index];
                n -= 16;
            }
            for (; index < z.Length; ++index)
            {
                z[index] = 0xffff;
                n -= 16;
            }
            Debug.Assert(n > -16 && n <= 0);
            if (n < 0)
                z[z.Length - 1] = (ushort)(z[z.Length - 1] & ((0x10000 >> -n) - 1));
            return (Regularize(z));
        }

        public ushort[] Negate(ushort[] x, int n)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(n > 0);
            int n_words = (n - 1) / 16 + 1;
            ushort[] z = new ushort[n_words];
            int index = 0;
            long carry = 0;
            for (; index < x.Length && index < z.Length; ++index)
            {
                carry -= x[index];
                z[index] = (ushort)carry;
                carry >>= 16;
                n -= 16;
            }
            for (; index < z.Length; ++index)
            {
                z[index] = (ushort)carry;
                carry >>= 16;
                n -= 16;
            }
            Debug.Assert(n > -16 && n <= 0);
            if (n < 0)
                z[z.Length - 1] = (ushort)(z[z.Length - 1] & ((0x10000 >> -n) - 1));
            return (Regularize(z));
        }

        public ushort[] Truncate(ushort[] x, int n)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(n > 0);
            if (x.Length * 16 <= n)
                return (x);
            int n_words = (n - 1) / 16 + 1;
            Debug.Assert(n_words <= x.Length);
            ushort[] z = new ushort[n_words];
            int index = 0;
            for (; index < z.Length; ++index)
            {
                z[index] = x[index];
                n -= 16;
            }
            Debug.Assert(n > -16 && n <= 0);
            if (n < 0)
                z[z.Length - 1] = (ushort)(z[z.Length - 1] & ((0x10000 >> -n) - 1));
            return (Regularize(z));
        }

        public ushort[] LeftShift(ushort[] x, int n)
        {
            Debug.Assert(n >= 0);
            Debug.Assert((n << 0) == n);
            Debug.Assert((n >> 0) == n);
            int shift_bits = (n & 0x000f);
            int shift_words = (n >> 4);
            ushort[] result = new ushort[x.Length + shift_words + 1];
            int index_x = 0;
            int index_r = shift_words;
            uint carry = (uint)((uint)x[index_x] << shift_bits);
            result[index_r] = (ushort)carry;
            ++index_x;
            ++index_r;
            carry >>= 16;
            for (; index_x < x.Length; ++index_x, ++index_r)
            {
                carry |= (uint)((uint)x[index_x] << shift_bits);
                result[index_r] = (ushort)carry;
                carry >>= 16;
            }
            result[index_r] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(result));
        }

        public ushort[] LeftShift1Quick(ushort[] x)
        {
            bool msb = ((uint)x[x.Length - 1] & 0x8000U) != 0;
            ushort[] result = new ushort[msb == true ? x.Length + 1 : x.Length];
            bool carry = false;
            for (int index = 0; index <x.Length; ++index)
            {
                uint d = x[index];
                bool new_carry = (d & 0x8000U) != 0;
                d = (ushort)(d << 1);
                if (carry)
                    d = d | 0x0001U;
                result[index] = (ushort)d;
                carry = new_carry;
            }
            Debug.Assert(carry == msb);
            if (carry)
                result[x.Length] = 0x0001;
            return (Regularize(result));
        }

        public ushort[] RightShift(ushort[] x, int n)
        {
            Debug.Assert(n >= 0);
            Debug.Assert((n << 0) == n);
            Debug.Assert((n >> 0) == n);
            int shift_bits = (n & 0x000f);
            int shift_words = (n >> 4);
            if (x.Length <= shift_words)
                return (new ushort[0]);
            int reverse_shift_bits = 16 - shift_bits;
            ushort[] result = new ushort[x.Length - shift_words];
            int index_x = shift_words;
            int index_r = 0;
            uint carry = (uint)((uint)x[index_x] >> shift_bits);
            ++index_x;
            for (; index_x < x.Length; ++index_x, ++index_r)
            {
                carry |= (uint)((uint)x[index_x] << reverse_shift_bits);
                result[index_r] = (ushort)carry;
                carry >>= 16;
            }
            result[index_r] = (ushort)carry;
            carry >>= 16;
            Debug.Assert(carry == 0);
            return (Regularize(result));
        }

        public ushort[] RightShift1Quick(ushort[] x)
        {
            ushort[] result = new ushort[x.Length];
            bool carry = false;
            for (int index = x.Length - 1; index >= 0 ; --index)
            {
                uint d = x[index];
                bool new_carry = (d & 1) != 0;
                d = (ushort)(d >> 1);
                if (carry)
                    d = d | 0x8000U;
                result[index] = (ushort)d;
                carry = new_carry;
            }
            return (Regularize(result));
        }

        public ushort[] SetBit(ushort[] x, int pos)
        {
            Debug.Assert((pos << 0) == pos);
            Debug.Assert(x.Length > 0);
            Debug.Assert(pos >= 0);
            int pos_word = pos >> 4;
            int pos_bit = pos & 0xf;
            Debug.Assert(pos_word >= 0);
            Debug.Assert(pos_bit >= 0 && pos_bit < 16);
            Debug.Assert(pos == pos_word * 16 + pos_bit);
            int length = x.Length;
            if (length <= pos_word)
                length = pos_word + 1;
            ushort[] z = new ushort[length];
            Array.Copy(x, z, x.Length);
            z[pos_word] |= (ushort)(1 << pos_bit);
            return (Regularize(z));
        }

        public ushort[] ClearBit(ushort[] x, int pos)
        {
            Debug.Assert((pos << 0) == pos);
            Debug.Assert(x.Length > 0);
            Debug.Assert(pos >= 0);
            int pos_word = pos >> 4;
            int pos_bit = pos & 0xf;
            Debug.Assert(pos_word >= 0);
            Debug.Assert(pos_bit >= 0 && pos_bit < 16);
            Debug.Assert(pos == pos_word * 16 + pos_bit);
            if (pos_word >= x.Length)
                return (x);
            ushort[] z = new ushort[x.Length];
            Array.Copy(x, z, x.Length);
            z[pos_word] &= (ushort)(~(1 << pos_bit));
            return (Regularize(z));
        }

        public bool TestBit(ushort[] x, int pos)
        {
            Debug.Assert((pos << 0) == pos);
            Debug.Assert(x.Length > 0);
            Debug.Assert(pos >= 0);
            int pos_word = pos >> 4;
            int pos_bit = pos & 0xf;
            Debug.Assert(pos_word >= 0);
            Debug.Assert(pos_bit >= 0 && pos_bit < 16);
            Debug.Assert(pos == pos_word * 16 + pos_bit);
            if (pos_word >= x.Length)
                return (false);
            return ((x[pos_word] & (1 << pos_bit)) != 0);
        }

        public int GetBitLength(ushort[] x)
        {
            Debug.Assert(x.Length > 0);
            int offset = 16 * (x.Length - 1);
            ushort data = x[x.Length - 1];
            if (data >= 0x100)
            {
                // 0x100-0x8000
                if (data >= 0x1000)
                {
                    // 0x1000-0x8000
                    if (data >= 0x4000)
                    {
                        // 0x4000-0x8000
                        if (data >= 0x8000)
                            return (16 + offset);
                        else
                            return (15 + offset);
                    }
                    else
                    {
                        // 0x1000-0x2000
                        if (data >= 0x2000)
                            return (14 + offset);
                        else
                            return (13 + offset);
                    }
                }
                else
                {
                    // 0x100-0x800
                    if (data >= 0x400)
                    {
                        // 0x400-0x800
                        if (data >= 0x800)
                            return (12 + offset);
                        else
                            return (11 + offset);
                    }
                    else
                    {
                        // 0x100-0x200
                        if (data >= 0x200)
                            return (10 + offset);
                        else
                            return (9 + offset);
                    }
                }
            }
            else
            {
                // 0x1-0x80
                if (data >= 0x10)
                {
                    // 0x10-0x80
                    if (data >= 0x40)
                    {
                        // 0x40-0x80
                        if (data >= 0x80)
                            return (8 + offset);
                        else
                            return (7 + offset);
                    }
                    else
                    {
                        // 0x10-0x20
                        if (data >= 0x20)
                            return (6 + offset);
                        else
                            return (5 + offset);
                    }
                }
                else
                {
                    // 0x1-0x8
                    if (data >= 0x4)
                    {
                        // 0x4-0x8
                        if (data >= 0x8)
                            return (4 + offset);
                        else
                            return (3 + offset);
                    }
                    else
                    {
                        // 0x1-0x2
                        if (data >= 0x2)
                            return (2 + offset);
                        else
                            return (1 + offset);
                    }
                }
            }
        }

        public bool GetIsPowerOfTwo(ushort[] x)
        {
            Debug.Assert(x.Length > 0);
            for (int index = 0; index < x.Length - 1; ++index)
            {
                if (x[index] != 0)
                    return (false);
            }
            ushort data = x[x.Length - 1];
            if (data >= 0x100)
            {
                // 0x100-0x8000
                if (data >= 0x1000)
                {
                    // 0x1000-0x8000
                    if (data >= 0x4000)
                    {
                        // 0x4000-0x8000
                        return (data == 0x4000 || data == 0x8000);
                    }
                    else
                    {
                        // 0x1000-0x2000
                        return (data == 0x1000 || data == 0x2000);
                    }
                }
                else
                {
                    // 0x100-0x800
                    if (data >= 0x400)
                    {
                        // 0x400-0x800
                        return (data == 0x400 || data == 0x800);
                    }
                    else
                    {
                        // 0x100-0x200
                        return (data == 0x100 || data == 0x200);
                    }
                }
            }
            else
            {
                // 0x1-0x80
                if (data >= 0x10)
                {
                    // 0x10-0x80
                    if (data >= 0x40)
                    {
                        // 0x40-0x80
                        return (data == 0x40 || data == 0x80);
                    }
                    else
                    {
                        // 0x10-0x20
                        return (data == 0x10 || data == 0x20);
                    }
                }
                else
                {
                    // 0x1-0x8
                    if (data >= 0x4)
                    {
                        // 0x4-0x8
                        return (data == 0x4 || data == 0x8);
                    }
                    else
                    {
                        // 0x1-0x2
                        return (data == 0x1 || data == 0x2);
                    }
                }
            }
        }

        #endregion
    }
}
