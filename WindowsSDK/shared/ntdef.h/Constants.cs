using System;

namespace Antrv.Interop.WindowsSDK
{
    public static partial class Constants
    {
        public const int ANYSIZE_ARRAY = 1;

        public static int MAX_NATURAL_ALIGNMENT { get; } = IntPtr.Size;

        public static int MEMORY_ALLOCATION_ALIGNMENT { get; } = IntPtr.Size * 2;

        public static int SYSTEM_CACHE_ALIGNMENT_SIZE { get; } = Environment.Is64BitProcess ? 64 : 128;

        public const uint UCSCHAR_INVALID_CHARACTER = 0xffffffff;

        public const uint MIN_UCSCHAR = 0;
        public const uint MAX_UCSCHAR = 0x0010FFFF;

        public const ushort ALL_PROCESSOR_GROUPS = 0xffff;

        public static int MAXIMUM_PROC_PER_GROUP { get; } = IntPtr.Size * 8;

        public static int MAXIMUM_PROCESSORS { get; } = MAXIMUM_PROC_PER_GROUP;

        public const int OBJ_HANDLE_TAGBITS = 0x00000003;

        public const long MAXLONGLONG = 0x7fffffffffffffff;

        public const byte ANSI_NULL = 0;

        public const char UNICODE_NULL = (char)0;

        public const ushort UNICODE_STRING_MAX_BYTES = 65534;

        public const ushort UNICODE_STRING_MAX_CHARS = 32767;

        public const nuint RTL_BALANCED_NODE_RESERVED_PARENT_MASK = 3;
    }
}
