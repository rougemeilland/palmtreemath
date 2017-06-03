/*
  NativeUnsignedInteger.Arithmetic.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;

namespace Palmtree.Math.Implements
{
    partial class NativeUnsignedInteger
    {
        #region パブリックメソッド

        public NativeUnsignedInteger Add(UInt32 value)
        {
            if (IsZero)
                return (value == 0 ? Zero : new NativeUnsignedInteger(value));
            else if (value == 0)
                return (this);
            else
            {
                var result_bit_count = System.Math.Max(_effective_bit_count, PMN_GetUInt32EffectiveBitCount(value)) + 1;
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_AddUInt32(_buffer_ptr, value, result_buffer))
                        throw new ApplicationException();
                    var result_obj = new NativeUnsignedInteger(result_buffer);
                    success = true;
                    return (result_obj);
                }
                finally
                {
                    if (!success)
                        PMN_FreeBuffer(result_buffer);
                }
            }
        }

        public NativeUnsignedInteger Add(UInt64 value)
        {
            if (IsZero)
                return (value == 0 ? Zero : new NativeUnsignedInteger(value));
            else if (value == 0)
                return (this);
            else
            {
                var result_bit_count = System.Math.Max(_effective_bit_count, PMN_GetUInt64EffectiveBitCount(value)) + 1;
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_AddUInt64(_buffer_ptr, value, result_buffer))
                        throw new ApplicationException();
                    var result_obj = new NativeUnsignedInteger(result_buffer);
                    success = true;
                    return (result_obj);
                }
                finally
                {
                    if (!success)
                        PMN_FreeBuffer(result_buffer);
                }
            }
        }

        public NativeUnsignedInteger Add(NativeUnsignedInteger value)
        {
            if (IsZero)
                return (value);
            else if (value.IsZero)
                return (this);
            else
            {
                var result_bit_count = System.Math.Max(_effective_bit_count, value._effective_bit_count) + 1;
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (_effective_bit_count >= value._effective_bit_count)
                    {
                        if (!PMN_Add(_buffer_ptr, value._buffer_ptr, result_buffer))
                            throw new ApplicationException();
                    }
                    else
                    {
                        if (!PMN_Add(value._buffer_ptr, _buffer_ptr, result_buffer))
                            throw new ApplicationException();
                    }
                    var result_obj = new NativeUnsignedInteger(result_buffer);
                    success = true;
                    return (result_obj);
                }
                finally
                {
                    if (!success)
                        PMN_FreeBuffer(result_buffer);
                }
            }
        }

        public NativeUnsignedInteger Subtract(UInt32 value)
        {
        }

        public NativeUnsignedInteger Subtract(UInt64 value)
        {
        }

        public NativeUnsignedInteger Subtract(NativeUnsignedInteger value)
        {
        }

        public static UInt32 Subtract(UInt32 x, NativeUnsignedInteger y)
        {
        }

        public static UInt64 Subtract(UInt64 x, NativeUnsignedInteger y)
        {
        }

        public NativeUnsignedInteger Multiply(UInt32 value)
        {
        }

        public NativeUnsignedInteger Multiply(UInt64 value)
        {
        }

        public NativeUnsignedInteger Multiply(NativeUnsignedInteger value)
        {
        }

        public NativeUnsignedInteger DivRem(UInt32 x, out UInt32 r)
        {
        }

        public NativeUnsignedInteger DivRem(UInt64 x, out UInt64 r)
        {
        }

        public NativeUnsignedInteger DivRem(NativeUnsignedInteger x, out NativeUnsignedInteger r)
        {
        }

        public static UInt32 DivRem(UInt32 x, NativeUnsignedInteger y, out UInt32 r)
        {
        }

        public static UInt64 DivRem(UInt64 x, NativeUnsignedInteger y, out UInt64 r)
        {
        }

        public NativeUnsignedInteger Multiply10AndAddQuick(UInt32 x)
        {
        }

        public NativeUnsignedInteger Multiply16AndAddQuick(UInt32 x)
        {
        }

        public NativeUnsignedInteger Power(uint exp)
        {
            if (IsZero)
                return (exp == 0 ? One : Zero);
            else if (IsOne)
                return (One);
            else if (exp == 0)
                return (One);
            else if (exp == 1)
                return (this);
            else
                return (PowerImp(this, exp));
        }

        public NativeUnsignedInteger Power(ulong exp)
        {
            if (IsZero)
                return (exp == 0 ? One : Zero);
            else if (IsOne)
                return (One);
            else if (exp == 0)
                return (One);
            else if (exp == 1)
                return (this);
            else
                return (PowerImp(this, exp));
        }

        public NativeUnsignedInteger Power(NativeUnsignedInteger exp)
        {
            if (IsZero)
                return (exp.IsZero ? One : Zero);
            else if (IsOne)
                return (One);
            else if (exp.IsZero)
                return (One);
            else if (exp.IsOne)
                return (this);
            else
                return (PowerImp(this, exp));
        }

        public NativeUnsignedInteger GreatestCommonDivisor(uint x)
        {
            if (IsZero)
                return (new NativeUnsignedInteger(x));
            if (x == 0)
                return (this);
            else if (IsOne)
                return (One);
            else if (x == 1)
                return (One);
            else
                return (GreatestCommonDivisorImp(this, new NativeUnsignedInteger(x)));
        }

        public NativeUnsignedInteger GreatestCommonDivisor(ulong x)
        {
            if (IsZero)
                return (new NativeUnsignedInteger(x));
            if (x == 0)
                return (this);
            else if (IsOne)
                return (One);
            else if (x == 1)
                return (One);
            else
                return (GreatestCommonDivisorImp(this, new NativeUnsignedInteger(x)));
        }

        public NativeUnsignedInteger GreatestCommonDivisor(NativeUnsignedInteger x)
        {
            if (IsZero)
                return (x);
            if (x.IsZero)
                return (this);
            else if (IsOne)
                return (One);
            else if (x.IsOne)
                return (One);
            else
                return (GreatestCommonDivisorImp(this, x));
        }

        #endregion

        #region プライベートメソッド

        private static NativeUnsignedInteger PowerImp(NativeUnsignedInteger x, uint exp)
        {
            var v = NativeUnsignedInteger.One;
            int k = sizeof(uint) * 8 - 1;
            System.Diagnostics.Debug.Assert(sizeof(uint) == 4);
            ulong mask = (1UL << k);
            while (k >= 0 && (exp & mask) == 0)
            {
                mask >>= 1;
                --k;
            }
            System.Diagnostics.Debug.Assert(k >= 0);
            while (k >= 0)
            {
                v = v.Multiply(v);
                if ((exp & mask) != 0)
                    v = v.Multiply(x);
                mask >>= 1;
                --k;
            }
            return (v);
        }

        private static NativeUnsignedInteger PowerImp(NativeUnsignedInteger x, ulong exp)
        {
            var v = NativeUnsignedInteger.One;
            int k = sizeof(ulong) * 8 - 1;
            System.Diagnostics.Debug.Assert(sizeof(ulong) == 8);
            ulong mask = (1UL << k);
            while (k >= 0 && (exp & mask) == 0)
            {
                mask >>= 1;
                --k;
            }
            System.Diagnostics.Debug.Assert(k >= 0);
            while (k >= 0)
            {
                v = v.Multiply(v);
                if ((exp & mask) != 0)
                    v = v.Multiply(x);
                mask >>= 1;
                --k;
            }
            return (v);
        }

        private static NativeUnsignedInteger PowerImp(NativeUnsignedInteger x, NativeUnsignedInteger exp)
        {
            var v = NativeUnsignedInteger.One;
            int k = exp.BitCount - 1;
            System.Diagnostics.Debug.Assert(k >= 0);
            while (k >= 0)
            {
                v = v.Multiply(v);
                if (exp.TestBit(k))
                    v = v.Multiply(x);
                --k;
            }
            return (v);
        }

        private static NativeUnsignedInteger GreatestCommonDivisorImp(NativeUnsignedInteger x, NativeUnsignedInteger y)
        {
            System.Diagnostics.Debug.Assert(!x.IsZero && !y.IsZero && !x.IsOne && !y.IsOne);
            int k = 0;
            while (x.IsEven && y.IsEven)
            {
                x = x.RightShift(1);
                y = y.RightShift(1);
                ++k;
            }
            System.Diagnostics.Debug.Assert(!x.IsZero && !y.IsZero);
            if (y.IsEven)
            {
                var t = x;
                x = y.RightShift(1);
                y = t;
            }
            System.Diagnostics.Debug.Assert(!x.IsZero && y.IsZero);
            System.Diagnostics.Debug.Assert(!y.IsEven);
            while (true)
            {
                System.Diagnostics.Debug.Assert(!x.IsZero && !y.IsZero);
                while (x.IsEven)
                    x = x.RightShift(1);
                System.Diagnostics.Debug.Assert(!x.IsEven && !y.IsEven);
                if (x.CompareTo(y) < 0)
                {
                    var t = x;
                    x = y;
                    y = t;
                }
                x = x.Subtract(y);
                if (x.IsZero)
                    return (y.LeftShift(k));
                System.Diagnostics.Debug.Assert(x.IsEven && !y.IsEven);
                x = x.RightShift(1);
            }
        }

        #endregion
    }
}