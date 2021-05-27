using System;
using System.Runtime.InteropServices;

namespace Antrv.Interop
{
    /// <summary>
    /// Pointer to a utf-8 zero-terminated string.
    /// </summary>
    public readonly struct Utf8StringPtr: IEquatable<Utf8StringPtr>
    {
        private readonly nint _ptr;

        public Utf8StringPtr(nint ptr) => _ptr = ptr;

        public static explicit operator Utf8StringPtr(nint ptr) => new(ptr);
        public static explicit operator nint(Utf8StringPtr ptr) => ptr._ptr;

        public bool IsNull => _ptr == IntPtr.Zero;

        public static bool operator ==(Utf8StringPtr left, Utf8StringPtr right) => left._ptr == right._ptr;
        public static bool operator !=(Utf8StringPtr left, Utf8StringPtr right) => left._ptr != right._ptr;

        public static bool operator !(Utf8StringPtr ptr) => ptr._ptr == 0;
        public static bool operator false(Utf8StringPtr ptr) => ptr._ptr == 0;
        public static bool operator true(Utf8StringPtr ptr) => ptr._ptr != 0;

        public override int GetHashCode() => (int)_ptr;

        public override bool Equals(object? obj) => obj switch
        {
            null => _ptr == 0,
            Utf8StringPtr ptr => _ptr == ptr._ptr,
            nint ptr => _ptr == ptr,
            _ => false
        };

        public bool Equals(Utf8StringPtr other) => _ptr == other._ptr;

        public override string ToString()
        {
            return
#if NET45 || NET46 || NETSTANDARD2_0
                Utilities.PtrToStringUtf8(_ptr)
#else
                Marshal.PtrToStringUTF8(_ptr)
#endif
                ?? string.Empty;
        }
    }
}
