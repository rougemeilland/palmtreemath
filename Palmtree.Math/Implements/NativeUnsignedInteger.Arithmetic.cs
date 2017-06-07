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
            if (IsZero)
            {
                if (value != 0)
                    throw new OverflowException();
                return (Zero);
            }
            else if (value == 0)
                return (this);
            else
            {
                var x_length = _effective_bit_count;
                var y_length = PMN_GetUInt32EffectiveBitCount(value);
                if (x_length < y_length)
                    throw new OverflowException();
                var result_bit_count = x_length;
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_SubtractUInt32(_buffer_ptr, value, result_buffer))
                        throw new OverflowException();
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

        public NativeUnsignedInteger Subtract(UInt64 value)
        {
            if (IsZero)
            {
                if (value != 0)
                    throw new OverflowException();
                return (Zero);
            }
            else if (value == 0)
                return (this);
            else
            {
                var x_length = _effective_bit_count;
                var y_length = PMN_GetUInt64EffectiveBitCount(value);
                if (x_length < y_length)
                    throw new OverflowException();
                var result_bit_count = x_length;
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_SubtractUInt64(_buffer_ptr, value, result_buffer))
                        throw new OverflowException();
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

        public NativeUnsignedInteger Subtract(NativeUnsignedInteger value)
        {
            if (IsZero)
            {
                if (!value.IsZero)
                    throw new OverflowException();
                return (Zero);
            }
            else if (value.IsZero)
                return (this);
            else
            {
                var x_length = _effective_bit_count;
                var y_length = _effective_bit_count;
                if (x_length < y_length)
                    throw new OverflowException();
                var result_bit_count = x_length;
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_Subtract(_buffer_ptr, value._buffer_ptr, result_buffer))
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

        public static UInt32 Subtract(UInt32 x, NativeUnsignedInteger y)
        {
            if (x == 0)
            {
                if (!y.IsZero)
                    throw new OverflowException();
                return (0);
            }
            else if (y.IsZero)
                return (x);
            else
            {
                var x_length = PMN_GetUInt32EffectiveBitCount(x);
                var y_length = y._effective_bit_count;
                if (x_length < y_length)
                    throw new OverflowException();
                UInt32 y_value;
                if (!PMN_GetUint32Value(y._buffer_ptr, out y_value))
                    throw new OverflowException();
                if (x < y_value)
                    throw new OverflowException();
                return (x - y_value);
            }
        }

        public static UInt64 Subtract(UInt64 x, NativeUnsignedInteger y)
        {
            if (x == 0)
            {
                if (!y.IsZero)
                    throw new OverflowException();
                return (0);
            }
            else if (y.IsZero)
                return (x);
            else
            {
                var x_length = PMN_GetUInt64EffectiveBitCount(x);
                var y_length = y._effective_bit_count;
                if (x_length < y_length)
                    throw new OverflowException();
                UInt64 y_value;
                if (!PMN_GetUint64Value(y._buffer_ptr, out y_value))
                    throw new OverflowException();
                if (x < y_value)
                    throw new OverflowException();
                return (x - y_value);
            }
        }

        public NativeUnsignedInteger Multiply(UInt32 value)
        {
            if (IsZero)
                return (Zero);
            else if (IsOne)
            {
                if (value == 0)
                    return (Zero);
                else if (value == 1)
                    return (One);
                else
                    return (new NativeUnsignedInteger(value));
            }
            else if (value == 0)
                return (Zero);
            else if (value == 1)
                return (this);
            else
            {
                var result_bit_count = _effective_bit_count + PMN_GetUInt32EffectiveBitCount(value);
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_MultiplyUInt32(_buffer_ptr, value, result_buffer))
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

        public NativeUnsignedInteger Multiply(UInt64 value)
        {
            if (IsZero)
                return (Zero);
            else if (IsOne)
            {
                if (value == 0)
                    return (Zero);
                else if (value == 1)
                    return (One);
                else
                    return (new NativeUnsignedInteger(value));
            }
            else if (value == 0)
                return (Zero);
            else if (value == 1)
                return (this);
            else
            {
                var result_bit_count = _effective_bit_count + PMN_GetUInt64EffectiveBitCount(value);
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_MultiplyUInt64(_buffer_ptr, value, result_buffer))
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

        public NativeUnsignedInteger Multiply(NativeUnsignedInteger value)
        {
            if (IsZero)
                return (Zero);
            else if (IsOne)
                return (value);
            else if (value.IsZero)
                return (Zero);
            else if (value.IsOne)
                return (this);
            else
            {
                var result_bit_count = _effective_bit_count + value._effective_bit_count;
                UInt64 result_buffer_size = (result_bit_count + 7) / 8;
                var result_buffer = PMN_AllocateBuffer(result_buffer_size);
                if (result_buffer == IntPtr.Zero)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (_effective_bit_count >= value._effective_bit_count)
                    {
                        if (!PMN_Multiply(_buffer_ptr, value._buffer_ptr, result_buffer))
                            throw new ApplicationException();
                    }
                    else
                    {
                        if (!PMN_Multiply(value._buffer_ptr, _buffer_ptr, result_buffer))
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

        public NativeUnsignedInteger DivRem(UInt32 x, out UInt32 r)
        {
            if (x == 0)
                throw new DivideByZeroException();
            else if (x == 1)
            {
                r = 0;
                return (this);
            }
            else if (IsZero)
            {
                r = 0;
                return (Zero);
            }
            else
            {
                var this_length = _effective_bit_count;
                var x_length = PMN_GetUInt32EffectiveBitCount(x);
                if (this_length < x_length)
                {
                    UInt32 this_value;
                    if (!PMN_GetUint32Value(_buffer_ptr, out this_value))
                        throw new ApplicationException();
                    r = this_value;
                    return (Zero);
                }
                else
                {
                    var q_bit_count = this_length - x_length + 1;
                    UInt64 q_buffer_size = (q_bit_count + 7) / 8;
                    var q_buffer = PMN_AllocateBuffer(q_buffer_size);
                    if (q_buffer == IntPtr.Zero)
                        throw new ApplicationException();
                    var success = false;
                    try
                    {
                        if (!PMN_DivRemUInt32(_buffer_ptr, x, q_buffer, out r))
                            throw new ApplicationException();
                        var q_obj = new NativeUnsignedInteger(q_buffer);
                        success = true;
                        return (q_obj);
                    }
                    finally
                    {
                        if (!success)
                            PMN_FreeBuffer(q_buffer);
                    }
                }
            }
        }

        public NativeUnsignedInteger DivRem(UInt64 x, out UInt64 r)
        {
            if (x == 0)
                throw new DivideByZeroException();
            else if (x == 1)
            {
                r = 0;
                return (this);
            }
            else if (IsZero)
            {
                r = 0;
                return (Zero);
            }
            else
            {
                var this_length = _effective_bit_count;
                var x_length = PMN_GetUInt64EffectiveBitCount(x);
                if (this_length < x_length)
                {
                    UInt64 this_value;
                    if (!PMN_GetUint64Value(_buffer_ptr, out this_value))
                        throw new ApplicationException();
                    r = this_value;
                    return (Zero);
                }
                else
                {
                    var q_bit_count = this_length - x_length + 1;
                    UInt64 q_buffer_size = (q_bit_count + 7) / 8;
                    var q_buffer = PMN_AllocateBuffer(q_buffer_size);
                    if (q_buffer == IntPtr.Zero)
                        throw new ApplicationException();
                    var success = false;
                    try
                    {
                        if (!PMN_DivRemUInt64(_buffer_ptr, x, q_buffer, out r))
                            throw new ApplicationException();
                        var q_obj = new NativeUnsignedInteger(q_buffer);
                        success = true;
                        return (q_obj);
                    }
                    finally
                    {
                        if (!success)
                            PMN_FreeBuffer(q_buffer);
                    }
                }
            }
        }

        public NativeUnsignedInteger DivRem(NativeUnsignedInteger x, out NativeUnsignedInteger r)
        {
            if (x.IsZero)
                throw new DivideByZeroException();
            else if (x.IsOne)
            {
                r = Zero;
                return (this);
            }
            else if (IsZero)
            {
                r = Zero;
                return (Zero);
            }
            else
            {
                var this_length = _effective_bit_count;
                var x_length = x._effective_bit_count;
                if (this_length < x_length)
                {
                    r = this;
                    return (Zero);
                }
                else
                {
                    IntPtr q_buffer = IntPtr.Zero;
                    IntPtr r_buffer = IntPtr.Zero;
                    var success = false;
                    try
                    {
                        var q_bit_count = this_length - x_length + 1;
                        UInt64 q_buffer_size = (q_bit_count + 7) / 8;
                        q_buffer = PMN_AllocateBuffer(q_buffer_size);
                        if (q_buffer == IntPtr.Zero)
                            throw new ApplicationException();
                        var r_bit_count = x_length;
                        UInt64 r_buffer_size = (r_bit_count + 7) / 8;
                        r_buffer = PMN_AllocateBuffer(r_buffer_size);
                        if (r_buffer == IntPtr.Zero)
                            throw new ApplicationException();
                        if (!PMN_DivRem(_buffer_ptr, x._buffer_ptr, q_buffer, r_buffer))
                            throw new ApplicationException();
                        var q_obj = new NativeUnsignedInteger(q_buffer);
                        q_buffer = IntPtr.Zero;
                        var r_obj = new NativeUnsignedInteger(r_buffer);
                        success = true;
                        r = r_obj;
                        return (q_obj);
                    }
                    finally
                    {
                        if (!success)
                        {
                            if (q_buffer != IntPtr.Zero)
                                PMN_FreeBuffer(q_buffer);
                            if (r_buffer != IntPtr.Zero)
                                PMN_FreeBuffer(r_buffer);
                        }
                    }
                }
            }
        }

        public static UInt32 DivRem(UInt32 x, NativeUnsignedInteger y, out UInt32 r)
        {
            if (y.IsZero)
                throw new DivideByZeroException();
            else if (y.IsOne)
            {
                r = 0;
                return (x);
            }
            else if (x == 0)
            {
                r = 0;
                return (0);
            }
            else
            {
                if (PMN_GetUInt32EffectiveBitCount(x) < y._effective_bit_count)
                {
                    r = x;
                    return (0);
                }
                else
                {
                    UInt32 y_value;
                    if (!PMN_GetUint32Value(y._buffer_ptr, out y_value))
                        throw new ApplicationException();
                    r = x % y_value;
                    return (x / y_value);
                }
            }
        }

        public static UInt64 DivRem(UInt64 x, NativeUnsignedInteger y, out UInt64 r)
        {
            if (y.IsZero)
                throw new DivideByZeroException();
            else if (y.IsOne)
            {
                r = 0;
                return (x);
            }
            else if (x == 0)
            {
                r = 0;
                return (0);
            }
            else
            {
                if (PMN_GetUInt64EffectiveBitCount(x) < y._effective_bit_count)
                {
                    r = x;
                    return (0);
                }
                else
                { 
                    UInt64 y_value;
                    if (!PMN_GetUint64Value(y._buffer_ptr, out y_value))
                        throw new ApplicationException();
                    r = x % y_value;
                    return (x / y_value);
                }
            }
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