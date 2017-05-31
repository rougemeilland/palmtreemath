/*
  NativeUnsignedInteger.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Palmtree.Math
{
    internal sealed class NativeUnsignedInteger
        : IDisposable
    {
        #region ネイティブコードの宣言

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_Initialize();

        [DllImport("Palmtree.Math.Native.dll")]
        static extern UInt64 PMN_GetUInt32EffectiveBitCount(UInt32 value);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern UInt64 PMN_GetUInt64EffectiveBitCount(UInt64 value);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_GetEffectiveBitCount(IntPtr buffer, UInt64 buffer_size, out UInt64 bit_count);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_SetUint32Value(IntPtr buffer, ref UInt64 buffer_size, UInt64 value);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_SetUint64Value(IntPtr buffer, ref UInt64 buffer_size, UInt64 value);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_GetUint32Value(IntPtr buffer, UInt64 buffer_size, out UInt32 value);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_GetUint64Value(IntPtr buffer, UInt64 buffer_size, out UInt64 value);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_IsOne(IntPtr buffer, UInt64 buffer_size, out bool result);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_Add(IntPtr x, UInt64 x_length, IntPtr y, UInt64 y_length, IntPtr z, ref UInt64 z_length);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_AddUInt32(IntPtr x, UInt64 x_length, UInt32 value, IntPtr z, ref UInt64 z_length);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_AddUInt64(IntPtr x, UInt64 x_length, UInt64 value, IntPtr z, ref UInt64 z_length);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern bool PMN_Multiply(IntPtr x, UInt64 x_length, IntPtr y, UInt64 y_length, IntPtr z, ref UInt64 z_length);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern IntPtr PMN_AllocateBuffer(UInt64 size);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern void PMN_FreeBuffer(IntPtr buffer);

        #endregion

        #region パブリックフィールド

        public readonly static NativeUnsignedInteger Zero;
        public readonly static NativeUnsignedInteger One;

        #endregion

        #region プライベートフィールド

        private bool _disposed;
        private IntPtr _buffer_ptr;
        private UInt64 _buffer_byte_count;
        private UInt64 _effective_bit_count;

        #endregion

        #region コンストラクタ

        static NativeUnsignedInteger()
        {
            var base_dir = Path.GetDirectoryName(typeof(NativeUnsignedInteger).Assembly.Location);
            switch (IntPtr.Size * 8)
            {
                case 64:
                    SetDllDirectory(Path.Combine(base_dir, "x64"));
                    break;
                case 32:
                    SetDllDirectory(Path.Combine(base_dir, "x86"));
                    break;
                default:
                    throw new PlatformNotSupportedException();
            }
            if (!PMN_Initialize())
                throw new PlatformNotSupportedException();
            Zero = new NativeUnsignedInteger(0);
            One = new NativeUnsignedInteger(1);
        }

        public NativeUnsignedInteger(UInt32 value)
        {
            _disposed = false;
            if (value == 0)
            {
                _buffer_ptr = IntPtr.Zero;
                _buffer_byte_count = 0;
                _effective_bit_count = 0;
            }
            else
            {
                UInt64 size = sizeof(UInt32);
                var buffer = PMN_AllocateBuffer(size);
                if (buffer == null)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_SetUint32Value(buffer, ref size, value))
                        throw new ApplicationException();
                    UInt64 bit_count;
                    if (!PMN_GetEffectiveBitCount(buffer, size, out bit_count))
                        throw new ApplicationException();
                    success = true;
                    _buffer_ptr = buffer;
                    _buffer_byte_count = size;
                    _effective_bit_count = bit_count;
                }
                finally
                {
                    if (!success)
                        PMN_FreeBuffer(buffer);
                }
            }
        }

        public NativeUnsignedInteger(UInt64 value)
        {
            if (value == 0)
            {
                _buffer_ptr = IntPtr.Zero;
                _buffer_byte_count = 0;
                _effective_bit_count = 0;
            }
            else
            {
                UInt64 size = sizeof(UInt64);
                var buffer = PMN_AllocateBuffer(size);
                if (buffer == null)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (value <= UInt32.MaxValue)
                    {
                        if (!PMN_SetUint32Value(buffer, ref size, value))
                            throw new ApplicationException();
                    }
                    else
                    {
                        if (!PMN_SetUint64Value(buffer, ref size, value))
                            throw new ApplicationException();
                    }
                    UInt64 bit_count;
                    if (!PMN_GetEffectiveBitCount(buffer, size, out bit_count))
                        throw new ApplicationException();
                    success = true;
                    _buffer_ptr = buffer;
                    _buffer_byte_count = size;
                    _effective_bit_count = bit_count;
                }
                finally
                {
                    if (!success)
                        PMN_FreeBuffer(buffer);
                }
            }
        }

        private NativeUnsignedInteger(IntPtr buffer, UInt64 size, UInt64 bit_count)
        {
            _disposed = false;
            _buffer_ptr = buffer;
            _buffer_byte_count = size;
            _effective_bit_count = bit_count;
        }

        ~NativeUnsignedInteger()
        {
            Dispose(false);
        }

        #endregion

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
                    if (!PMN_AddUInt32(_buffer_ptr, _buffer_byte_count, value, result_buffer, ref result_buffer_size))
                        throw new ApplicationException();
                    UInt64 bit_count;
                    if (!PMN_GetEffectiveBitCount(result_buffer, result_buffer_size, out bit_count))
                        throw new ApplicationException();
                    success = true;
                    return (new NativeUnsignedInteger(result_buffer, result_buffer_size, bit_count));
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
                return (value == 0 ? Zero : value <= UInt32.MaxValue ? new NativeUnsignedInteger((UInt32)value) : new NativeUnsignedInteger(value));
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
                    if (value <= UInt32.MaxValue)
                    {
                        if (!PMN_AddUInt32(_buffer_ptr, _buffer_byte_count, (UInt32)value, result_buffer, ref result_buffer_size))
                            throw new ApplicationException();
                    }
                    else
                    {
                        if (!PMN_AddUInt64(_buffer_ptr, _buffer_byte_count, value, result_buffer, ref result_buffer_size))
                            throw new ApplicationException();
                    }
                    UInt64 bit_count;
                    if (!PMN_GetEffectiveBitCount(result_buffer, result_buffer_size, out bit_count))
                        throw new ApplicationException();
                    success = true;
                    return (new NativeUnsignedInteger(result_buffer, result_buffer_size, bit_count));
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
                        if (!PMN_Add(_buffer_ptr, _buffer_byte_count, value._buffer_ptr, value._buffer_byte_count, result_buffer, ref result_buffer_size))
                            throw new ApplicationException();
                    }
                    else
                    {
                        if (!PMN_Add(value._buffer_ptr, value._buffer_byte_count, _buffer_ptr, _buffer_byte_count, result_buffer, ref result_buffer_size))
                            throw new ApplicationException();
                    }
                    UInt64 bit_count;
                    if (!PMN_GetEffectiveBitCount(result_buffer, result_buffer_size, out bit_count))
                        throw new ApplicationException();
                    success = true;
                    return (new NativeUnsignedInteger(result_buffer, result_buffer_size, bit_count));
                }
                finally
                {
                    if (!success)
                        PMN_FreeBuffer(result_buffer);
                }
            }
        }

        /*
        public NativeUnsignedInteger Multiply(UInt32 value)
        {
        }

        public NativeUnsignedInteger Multiply(UInt64 value)
        {
        }

        public NativeUnsignedInteger Multiply(NativeUnsignedInteger value)
        {
        }
        */

        #endregion

        #region パブリックプロパティ

        public bool IsZero
        {
            get
            {
                return (_buffer_ptr == null || _buffer_byte_count == 0);
            }
        }

        #endregion

        #region プライベートメソッド

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // マネージリソースの解放
                }
                if (_buffer_ptr != IntPtr.Zero)
                {
                    PMN_FreeBuffer(_buffer_ptr);
                    _buffer_ptr = IntPtr.Zero;
                }
                _disposed = true;
            }
        }

        #endregion

        #region IDisposable のメンバ

        public void Dispose()
        {
            Dispose(true);
             GC.SuppressFinalize(this);
        }

        #endregion
    }
}