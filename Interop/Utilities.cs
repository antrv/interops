using System.Runtime.InteropServices;
using System.Text;

namespace Antrv.Interop
{
    internal static class Utilities
    {
        internal static unsafe string? PtrToStringUtf8(nint ptr)
        {
            if (ptr == 0)
                return null;

            nint length = GetUtf8StringLength(ptr);
            if (length >= int.MaxValue)
                throw new InteropException("UTF-8 is too long");

            int intLength = (int)length;

#if NET45
            return Encoding.UTF8.GetString(GetUtf8StringBytes(ptr, intLength), 0, intLength);
#else
            return Encoding.UTF8.GetString((byte*)ptr, intLength);
#endif
        }

        private static unsafe nint GetUtf8StringLength(nint ptr)
        {
            nint charPtr = ptr;
            while (*(byte*)charPtr != 0)
                charPtr++;

            return charPtr - ptr;
        }

        private static byte[] GetUtf8StringBytes(nint ptr, int length)
        {
            byte[] bytes = new byte[length];
            Marshal.Copy(ptr, bytes, 0, length);
            return bytes;
        }
    }
}
