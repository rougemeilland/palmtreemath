/*
  NativeUnsignedInteger.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.IO;

namespace Palmtree.Math.Implements
{
    internal sealed partial class NativeUnsignedInteger
        : IDisposable
    {
        #region パブリックフィールド

        public readonly static NativeUnsignedInteger Zero;
        public readonly static NativeUnsignedInteger One;

        #endregion

        #region プライベートフィールド

        private bool _disposed;
        private IntPtr _buffer_ptr;
        private UInt64 _effective_bit_count;
        private int _hash_code;
        private bool _is_one;
        private bool _is_even;
        private bool _is_power_of_two;

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
                _effective_bit_count = 0;
                _hash_code = 0;
                _is_one = false;
                _is_even = true;
                _is_power_of_two = false;
            }
            else
            {
                var buffer = PMN_AllocateBuffer(sizeof(UInt32));
                if (buffer == null)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (!PMN_SetUint32Value(buffer, value))
                        throw new ApplicationException();
                    UInt64 bit_count;
                    int hash_code;
                    UInt32 flags;
                    if (!PMN_GetProperties(buffer, out bit_count, out hash_code, out flags))
                        throw new ApplicationException();
                    success = true;
                    _buffer_ptr = buffer;
                    _effective_bit_count = bit_count;
                    _hash_code = hash_code;
                    _is_one = (flags & 0x01) != 0;
                    _is_even = (flags & 0x02) != 0;
                    _is_power_of_two = (flags & 0x04) != 0;
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
                _effective_bit_count = 0;
                _hash_code = 0;
                _is_one = false;
                _is_even = true;
                _is_power_of_two = false;
            }
            else
            {
                var buffer = PMN_AllocateBuffer(sizeof(UInt64));
                if (buffer == null)
                    throw new ApplicationException();
                var success = false;
                try
                {
                    if (value <= UInt32.MaxValue)
                    {
                        if (!PMN_SetUint32Value(buffer, (UInt32)value))
                            throw new ApplicationException();
                    }
                    else
                    {
                        if (!PMN_SetUint64Value(buffer, value))
                            throw new ApplicationException();
                    }
                    UInt64 bit_count;
                    int hash_code;
                    UInt32 flags;
                    if (!PMN_GetProperties(buffer, out bit_count, out hash_code, out flags))
                        throw new ApplicationException();
                    success = true;
                    _buffer_ptr = buffer;
                    _effective_bit_count = bit_count;
                    _hash_code = hash_code;
                    _is_one = (flags & 0x01) != 0;
                    _is_even = (flags & 0x02) != 0;
                    _is_power_of_two = (flags & 0x04) != 0;
                }
                finally
                {
                    if (!success)
                        PMN_FreeBuffer(buffer);
                }
            }
        }

        private NativeUnsignedInteger(IntPtr buffer)
        {
            _disposed = false;
            _buffer_ptr = buffer;
            if (_buffer_ptr == IntPtr.Zero)
            {
                _buffer_ptr = IntPtr.Zero;
                _effective_bit_count = 0;
                _hash_code = 0;
                _is_one = false;
                _is_even = true;
                _is_power_of_two = false;
            }
            else
            {
                UInt64 bit_count;
                int hash_code;
                UInt32 flags;
                if (!PMN_GetProperties(buffer, out bit_count, out hash_code, out flags))
                    throw new ApplicationException();
                _buffer_ptr = buffer;
                _effective_bit_count = bit_count;
                _hash_code = hash_code;
                _is_one = (flags & 0x01) != 0;
                _is_even = (flags & 0x02) != 0;
                _is_power_of_two = (flags & 0x04) != 0;
            }
        }

        ~NativeUnsignedInteger()
        {
            Dispose(false);
        }

        #endregion

        #region パブリックプロパティ

        public int BitCount
        {
            get
            {
                if (_effective_bit_count > int.MaxValue)
                    throw new InvalidOperationException();
                return ((int)_effective_bit_count);
            }
        }

        public bool IsZero
        {
            get
            {
                return (_buffer_ptr == null);
            }
        }

        public bool IsOne
        {
            get
            {
                return (_is_one);
            }
        }

        public bool IsEven
        {
            get
            {
                return (_is_even);
            }
        }

        public long LongBitCount
        {
            get
            {
                if (_effective_bit_count > long.MaxValue)
                    throw new InvalidOperationException();
                return ((long)_effective_bit_count);
            }
        }

        public bool IsPowerOfTwo
        {
            get
            {
                return (_is_power_of_two);
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

        #region object から継承されたメンバ

        public override bool Equals(object o)
        {
            if (o == null || GetType() != o.GetType())
                return (false);
            return (Equals((NativeUnsignedInteger)o));
        }

        public override int GetHashCode()
        {
            return (_hash_code);
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