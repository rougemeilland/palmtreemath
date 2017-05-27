/*
NativeUnsignedInteger.cs

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

using System;
using System.IO;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static extern int PMN_Add(int x, int y);

        [DllImport("Palmtree.Math.Native.dll")]
        static extern int PMN_Multiply(int x, int y);

        #endregion

        #region プライベートフィールド

        private bool _disposed;
        private IntPtr _buffer_ptr;
        private int _buffer_byte_count;
        private int _effective_bit_count;

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
        }

        private NativeUnsignedInteger()
        {
         _disposed = false;
        _buffer_ptr = IntPtr.Zero;
            _buffer_byte_count = 0;
            _effective_bit_count = 0;
        }

        ~NativeUnsignedInteger()
        {
            Dispose(false);
        }

        #endregion

        #region パブリックメソッド

        public static NativeUnsignedInteger FromUInt32(UInt32 value)
        {
        }

        public static NativeUnsignedInteger FromUInt64(UInt64 value)
        {
        }

        public NativeUnsignedInteger Add(UInt32 value)
        {
        }

        public NativeUnsignedInteger Add(UInt64 value)
        {
        }

        public NativeUnsignedInteger Add(NativeUnsignedInteger value)
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

        #endregion

        #region プライベートメソッド

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。

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