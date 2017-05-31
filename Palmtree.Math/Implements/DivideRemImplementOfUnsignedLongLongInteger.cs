using System;
using System.Diagnostics;

namespace Palmtree.Math.Implements
{
    internal class DivideRemImplementOfUnsignedLongLongInteger
        : ImplementOfUnsignedLongLongIntegerBase
    {
        #region パブリックメソッド

        public ushort DivideRem(ushort x, ushort y, out ushort r)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            r = (ushort)(x % y);
            ushort q = (ushort)(x / y);
            return (q);
        }

        public ulong DivideRem(ulong x, ushort y, out ushort r)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            r = (ushort)(x % y);
            ulong q = (x / y);
            return (q);
        }

        public ulong DivideRem(ulong x, ulong y, out ulong r)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y > 0);
            r = (x % y);
            ulong q = (x / y);
            return (q);
        }

        public ushort[] DivideRem(ushort[] x, ushort y, out ushort r)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y > 0);
            if (x.Length == 1)
                return (UShortToUShortArray(DivideRem(x[0], y, out r)));
            r = 0;
            ushort[] z = new ushort[x.Length];
            for (int index = x.Length - 1; index >= 0; --index)
            {
                ulong t = ((ulong)r << 16) + x[index];
                z[index] = (ushort)(t / y);
                r = (ushort)(t % y);
            }
            return (Regularize(z));
        }

        public ushort DivideRem(ushort x, ushort[] y, out ushort r)
        {
            Debug.Assert(x > 0);
            Debug.Assert(y.Length > 0);
            if (y.Length == 1)
                return (DivideRem(x, y[0], out r));
            r = x;
            return (0);
        }

        public ushort[] DivideRem(ushort[] x, ushort[] y, out ushort[] r)
        {
            Debug.Assert(x.Length > 0);
            Debug.Assert(y.Length > 0);
            if (x.Length == 1)
            {
                ushort r2;
                ushort q2 = DivideRem(x[0], y, out r2);
                r = UShortToUShortArray(r2);
                return (UShortToUShortArray(q2));
            }
            if (y.Length == 1)
            {
                ushort r2;
                ushort[] q2 = DivideRem(x, y[0], out r2);
                r = UShortToUShortArray(r2);
                return (q2);
            }
            if (x.Length < y.Length)
            {
                r = x;
                return (Zero);
            }
            Debug.Assert(x.Length >= 2);
            Debug.Assert(y.Length >= 2);
            int n = y.Length;
            int m = x.Length - n;
            int d = CalculateD(y[y.Length - 1]);
            ushort[] array_u = LeftShift(x, d, true);
            ushort[] array_v = LeftShift(y, d, false);
            ushort[] array_q = new ushort[m + 1];
            Debug.Assert(array_u.Length >= 3);
            Debug.Assert(array_v.Length >= 2);
            ushort v1 = array_v[array_v.Length - 1];
            ushort v2 = array_v[array_v.Length - 2];
            for (int j = 0; j <= m; ++j)
            {
                ushort u_j = array_u[array_u.Length - 1 - j];
                ushort u_j_1 = array_u[array_u.Length - 2 - j];
                ushort u_j_2 = array_u[array_u.Length - 3 - j];
                ushort q = ushort.MaxValue;
                if (u_j != v1)
                {
                    ulong t = (((ulong)u_j << 16) + u_j_1) / v1;
                    q = (ushort)t;
                    Debug.Assert((ulong)q == t);
                }
                Debug.Assert(q >= 0 && q <= ushort.MaxValue);
                while (CheckQ(q, v1, v2, u_j, u_j_1, u_j_2))
                    --q;
                MultiplyAndSubtract(ref array_u, m - j, array_v, ref q);
                array_q[array_q.Length - 1 - j] = q;
            }
            r = Regularize(RightShift(array_u, d));
            return (Regularize(array_q));

        }

        #endregion

        #region プライベートメソッド

        /// <summary>
        /// 除算の初期化に必要なdパラメタを計算します。
        /// </summary>
        /// <param name="x">
        /// 除数の最上位桁の値です。
        /// </param>
        /// <returns>
        /// dパラメタの計算結果です。
        /// </returns>
        private int CalculateD(ushort x)
        {
            if ((x & 0x8000) != 0)
                return (0);
            if ((x & 0x4000) != 0)
                return (1);
            if ((x & 0x2000) != 0)
                return (2);
            if ((x & 0x1000) != 0)
                return (3);
            if ((x & 0x0800) != 0)
                return (4);
            if ((x & 0x0400) != 0)
                return (5);
            if ((x & 0x0200) != 0)
                return (6);
            if ((x & 0x0100) != 0)
                return (7);
            if ((x & 0x0080) != 0)
                return (8);
            if ((x & 0x0040) != 0)
                return (9);
            if ((x & 0x0020) != 0)
                return (10);
            if ((x & 0x0010) != 0)
                return (11);
            if ((x & 0x0008) != 0)
                return (12);
            if ((x & 0x0004) != 0)
                return (13);
            if ((x & 0x0002) != 0)
                return (14);
            if ((x & 0x0001) != 0)
                return (15);
            throw (new ArgumentException("最上位桁の値が0です。", "x"));
        }

        private bool CheckQ(ushort q, ushort v1, ushort v2, ushort u_j, ushort u_j_1, ushort u_j_2)
        {
            long left_part = (uint)q * (uint)v2;
            long right_part = (uint)u_j << 16;
            right_part += (uint)u_j_1;
            right_part -= (uint)q * (uint)v1;
            right_part <<= 16;
            right_part += (uint)u_j_2;
            return (left_part > right_part);
        }

        private void MultiplyAndSubtract(ref ushort[] u, int offset_u, ushort[] v, ref ushort q)
        {
            Debug.Assert(u.Length > 1);
            Debug.Assert(v.Length > 1);
            long carry = (uint)u[offset_u];
            carry -= (uint)v[0] * (uint)q;
            u[offset_u] = (ushort)carry;
            carry >>= 16;
            int index = 1;
            for (; index < v.Length; ++index)
            {
                carry += (uint)u[offset_u + index];
                carry -= (uint)v[index] * (uint)q;
                u[offset_u + index] = (ushort)carry;
                carry >>= 16;
            }
            carry += (uint)u[offset_u + index];
            u[offset_u + index] = (ushort)carry;
            carry >>= 16;
            if (carry != 0)
            {
                --q;
                long previous_carry = carry;
                carry = (uint)u[offset_u];
                carry += (uint)v[0];
                u[offset_u] = (ushort)carry;
                carry >>= 16;
                index = 1;
                for (; index < v.Length; ++index)
                {
                    carry += (uint)u[offset_u + index];
                    carry += (uint)v[index];
                    u[offset_u + index] = (ushort)carry;
                    carry >>= 16;
                }
                carry += (uint)u[offset_u + index];
                u[offset_u + index] = (ushort)carry;
                carry >>= 16;
                Debug.Assert(carry + previous_carry == 0);
            }
        }

        private ushort[] LeftShift(ushort[] x, int shift_bits, bool expand_array)
        {
            Debug.Assert(shift_bits >= 0 && shift_bits < 16);
            Debug.Assert((shift_bits << 0) == shift_bits);
            Debug.Assert((shift_bits >> 0) == shift_bits);
            ushort[] result = new ushort[expand_array ? x.Length + 1 : x.Length];
            int index = 0;
            uint carry = (uint)((uint)x[index] << shift_bits);
            result[index] = (ushort)carry;
            ++index;
            carry >>= 16;
            for (; index < x.Length; ++index)
            {
                carry |= (uint)((uint)x[index] << shift_bits);
                result[index] = (ushort)carry;
                carry >>= 16;
            }
            if (expand_array)
            {
                result[index] = (ushort)carry;
                carry >>= 16;
            }
            Debug.Assert(carry == 0);
            return (result);
        }

        private ushort[] RightShift(ushort[] x, int n)
        {
            Debug.Assert(n >= 0);
            Debug.Assert((n << 0) == n);
            Debug.Assert((n >> 0) == n);
            if (x.Length <= 0)
                return (new ushort[0]);
            int reverse_shift_bits = 16 - n;
            ushort[] result = new ushort[x.Length];
            int index_x = 0;
            int index_r = 0;
            uint carry = (uint)((uint)x[index_x] >> n);
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
            return (result);
        }

        #endregion
    }
}


