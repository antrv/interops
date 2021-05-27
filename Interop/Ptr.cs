using System;
using System.Runtime.CompilerServices;

namespace Antrv.Interop
{
    /// <summary>
    /// Pointer to an unmanaged structure.
    /// </summary>
    /// <typeparam name="T">The type of unmanaged structure.</typeparam>
    public readonly struct Ptr<T> : IEquatable<Ptr<T>>
        where T : unmanaged
    {
        private readonly nint _ptr;

        public Ptr(nint ptr) => _ptr = ptr;
        public Ptr(nuint ptr) => _ptr = (nint)ptr;
        public unsafe Ptr(T* ptr) => _ptr = (nint)ptr;
        public unsafe Ptr(ref T ptr) => _ptr = (nint)Unsafe.AsPointer(ref ptr);

        public static explicit operator Ptr<T>(nint ptr) => new(ptr);
        public static explicit operator Ptr<T>(nuint ptr) => new(ptr);
        public static unsafe explicit operator Ptr<T>(T* ptr) => new(ptr);
        public static explicit operator nint(Ptr<T> ptr) => ptr._ptr;
        public static explicit operator nuint(Ptr<T> ptr) => (nuint)ptr._ptr;
        public static unsafe explicit operator T*(Ptr<T> ptr) => (T*)ptr._ptr;

        public bool IsNull => _ptr == 0;
        public unsafe ref T Ref => ref Unsafe.AsRef<T>((void*)_ptr);

        public unsafe T* Pointer => (T*)_ptr;

        public Ptr<TResult> Cast<TResult>()
            where TResult : unmanaged => new(_ptr);

        public unsafe Ptr<T> Add(int offset) => new((T*)_ptr + offset);
        public unsafe Ptr<T> Add(long offset) => new((T*)_ptr + offset);
        public unsafe Ptr<T> Subtract(int offset) => new((T*)_ptr - offset);
        public unsafe Ptr<T> Subtract(long offset) => new((T*)_ptr - offset);
        public unsafe long Offset(Ptr<T> ptr) => (T*)_ptr - (T*)ptr._ptr;

        public static bool operator ==(Ptr<T> left, Ptr<T> right) => left._ptr == right._ptr;
        public static bool operator !=(Ptr<T> left, Ptr<T> right) => left._ptr != right._ptr;

        public static bool operator !(Ptr<T> ptr) => ptr._ptr == 0;
        public static bool operator false(Ptr<T> ptr) => ptr._ptr == 0;
        public static bool operator true(Ptr<T> ptr) => ptr._ptr != 0;

        public static Ptr<T> operator ++(Ptr<T> ptr) => ptr.Add(1);
        public static Ptr<T> operator --(Ptr<T> ptr) => ptr.Subtract(1);
        public static Ptr<T> operator +(Ptr<T> ptr, int offset) => ptr.Add(offset);
        public static Ptr<T> operator +(Ptr<T> ptr, long offset) => ptr.Add(offset);
        public static Ptr<T> operator -(Ptr<T> ptr, int offset) => ptr.Subtract(offset);
        public static Ptr<T> operator -(Ptr<T> ptr, long offset) => ptr.Subtract(offset);

        public ref T this[int index] => ref (this + index).Ref;

        public override int GetHashCode() => (int)_ptr;

        public override bool Equals(object? obj) => obj switch
        {
            null => _ptr == 0,
            Ptr<T> ptr => _ptr == ptr._ptr,
            nint ptr => _ptr == ptr,
            nuint ptr => _ptr == (nint)ptr,
            _ => false
        };

        public bool Equals(Ptr<T> other) => _ptr == other._ptr;

        public override string ToString() => $"Pointer 0x{_ptr:X}";
    }
}
