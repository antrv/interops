using System;

namespace Antrv.Interop.WindowsSDK
{
    // Use this as the type reference.

    // Basic types.
    using PVOID = IntPtr;
    using CHAR = Byte;
    using UCHAR = Byte;
    using SCHAR = SByte;
    using SHORT = Int16;
    using USHORT = UInt16;
    using INT = Int32;
    using UINT = UInt32;
    using LONG = Int32;
    using ULONG = UInt32;
    using LONGLONG = Int64;
    using ULONGLONG = UInt64;
    using ULONG64 = UInt64;
    using DOUBLE = Double;
    using QUAD = Int64;
    using UQUAD = Int64;
    using DWORDLONG = UInt64;
    using BOOLEAN = Byte;
    using DWORD = UInt32;
    using BOOL = Int32;
    using BYTE = Byte;
    using WORD = UInt16;
    using FLOAT = Single;
    using INT_PTR = IntPtr;
    using UINT_PTR = UIntPtr;
    using LONG_PTR = IntPtr;
    using ULONG_PTR = UIntPtr;

    // Types use for passing & returning polymorphic values
    using WPARAM = UIntPtr;
    using LPARAM = IntPtr;
    using LRESULT = IntPtr;
    using ATOM = UInt16;

    // Update Sequence Number
    using USN = Int64;

    // Flag (bit) fields
    using FCHAR = Byte;
    using FSHORT = UInt16;
    using FLONG = UInt32;

    // Cardinal Data Types [0 - 2**N-2)
    using CCHAR = SByte;
    using CSHORT = Int16;
    using CLONG = Int32;
    using PCCHAR = Ptr<sbyte>;
    using PCSHORT = Ptr<short>;
    using PCLONG = Ptr<int>;

    // Logical Data Type - These are 32-bit logical values.
    using LOGICAL = UInt32;
    using PLOGICAL = Ptr<uint>;

    // Large (64-bit) integer types and operations
    using TIME = Int64;
    using PTIME = Ptr<long>;

    // Reference count
    using RTL_REFERENCE_COUNT = UIntPtr;
    using PRTL_REFERENCE_COUNT = Ptr<nuint>;
    using RTL_REFERENCE_COUNT32 = Int32;
    using PRTL_REFERENCE_COUNT32 = Ptr<int>;

    // NLS basics (Locale and Language Ids)
    using LCID = UInt32;
    using PLCID = Ptr<uint>;
    using LANGID = UInt16;

    // Pointer to Basics
    using PSCHAR = Ptr<sbyte>;
    using PSHORT = Ptr<short>;
    using PLONG = Ptr<int>;
    using PLONGLONG = Ptr<long>;
    using PULONGLONG = Ptr<ulong>;
    using PUCHAR = Ptr<byte>;
    using PUSHORT = Ptr<ushort>;
    using PUINT = Ptr<uint>;
    using PULONG = Ptr<uint>;
    using PQUAD = Ptr<long>;
    using PUQUAD = Ptr<long>;
    using PDWORDLONG = Ptr<ulong>;
    using PBOOLEAN = Ptr<byte>;
    using PFLOAT = Ptr<float>;
    using PBOOL = Ptr<int>;
    using LPBOOL = Ptr<int>;
    using PBYTE = Ptr<byte>;
    using LPBYTE = Ptr<byte>;
    using PINT = Ptr<int>;
    using LPINT = Ptr<int>;
    using PWORD = Ptr<ushort>;
    using LPWORD = Ptr<ushort>;
    using LPLONG = Ptr<int>;
    using PDWORD = Ptr<uint>;
    using LPDWORD = Ptr<uint>;
    using LPVOID = IntPtr;
    using LPCVOID = IntPtr;
    using PINT_PTR = Ptr<nint>;
    using PUINT_PTR = Ptr<nuint>;
    using PULONG_PTR = Ptr<nuint>;
    using PLONG_PTR = Ptr<nint>;

    // Pointer to Const Basics
    using PCUCHAR = Ptr<byte>;
    using PCSCHAR = Ptr<sbyte>;
    using PCUSHORT = Ptr<ushort>;
    using PCULONG = Ptr<uint>;
    using PCUQUAD = Ptr<long>;

    // Physical address
    using PHYSICAL_ADDRESS = Int64;
    using PPHYSICAL_ADDRESS = Ptr<long>;

    // UNICODE (Wide Character) types
    using WCHAR = Char;
    using PWCHAR = Ptr<char>;
    using LPWCH = Ptr<char>;
    using PWCH = Ptr<char>;
    using LPCWCH = Ptr<char>; // const
    using PCWCH = Ptr<char>; // const
    using NWPSTR = Ptr<char>; // null-terminated
    using LPWSTR = Ptr<char>; // null-terminated
    using PWSTR = Ptr<char>; // null-terminated
    using PZPWSTR = Ptr<Ptr<char>>; // null-terminated
    using PCZPWSTR = Ptr<Ptr<char>>; // const null-terminated
    using LPUWSTR = Ptr<char>; // unaligned null-terminated
    using PUWSTR = Ptr<char>; // unaligned null-terminated
    using LPCWSTR = Ptr<char>; // const null-terminated
    using PCWSTR = Ptr<char>; // const null-terminated
    using PZPCWSTR = Ptr<Ptr<char>>; // null-terminated
    using PCZPCWSTR = Ptr<Ptr<char>>; // const null-terminated
    using LPCUWSTR = Ptr<char>; // unaligned null-terminated
    using PCUWSTR = Ptr<char>; // unaligned null-terminated
    using PZZWSTR = Ptr<char>; // null-null-terminated
    using PCZZWSTR = Ptr<char>; // const null-null-terminated
    using PUZZWSTR = Ptr<char>; // unaligned null-null-terminated
    using PCUZZWSTR = Ptr<char>; // const unaligned null-null-terminated
    using PNZWCH = Ptr<char>;
    using PCNZWCH = Ptr<char>; // const
    using PUNZWCH = Ptr<char>; // unaligned
    using PCUNZWCH = Ptr<char>; // const unaligned
    using LPCWCHAR = Ptr<char>; // const
    using PCWCHAR = Ptr<char>; // const
    using LPCUWCHAR = Ptr<char>; // const unaligned
    using PCUWCHAR = Ptr<char>; // const unaligned

    // UCS (Universal Character Set) types
    using UCSCHAR = UInt32; // 32-bit character
    using PUCSCHAR = Ptr<uint>;
    using PCUCSCHAR = Ptr<uint>; // const
    using PUCSSTR = Ptr<Ptr<uint>>;
    using PUUCSSTR = Ptr<Ptr<uint>>; // unaligned
    using PCUCSSTR = Ptr<Ptr<uint>>; // const
    using PCUUCSSTR = Ptr<Ptr<uint>>; // const unaligned
    using PUUCSCHAR = Ptr<Ptr<uint>>; // unaligned
    using PCUUCSCHAR = Ptr<Ptr<uint>>; // const unaligned

    // ANSI (Multi-byte Character) types
    using PCHAR = Byte;
    using LPCH = Ptr<byte>;
    using PCH = Ptr<byte>;
    using LPCCH = Ptr<byte>; // const
    using PCCH = Ptr<byte>; // const
    using NPSTR = Ptr<byte>; // null-terminated
    using LPSTR = Ptr<byte>; // null-terminated
    using PSTR = Ptr<byte>; // null-terminated
    using PZPSTR = Ptr<Ptr<byte>>; // null-terminated
    using PCZPSTR = Ptr<Ptr<byte>>; // const null-terminated
    using LPCSTR = Ptr<byte>; // null-terminated
    using PCSTR = Ptr<byte>; // null-terminated
    using PZPCSTR = Ptr<Ptr<byte>>; // null-terminated
    using PCZPCSTR = Ptr<Ptr<byte>>; // const null-terminated
    using PZZSTR = Ptr<byte>; // null-null-terminated
    using PCZZSTR = Ptr<byte>; // const null-null-terminated
    using PNZCH = Ptr<byte>;
    using PCNZCH = Ptr<byte>; // const

    // Neutral ANSI/UNICODE types and macros (Windows 2000+ uses unicode)
    using TCHAR = Char;
    using PTCHAR = Ptr<char>;
    using LPTCH = Ptr<char>;
    using PTCH = Ptr<char>;
    using LPCTCH = Ptr<char>;
    using PCTCH = Ptr<char>;
    using PTSTR = Ptr<char>;
    using LPTSTR = Ptr<char>;
    using PCTSTR = Ptr<char>;
    using LPCTSTR = Ptr<char>;
    using PUTSTR = Ptr<char>;
    using LPUTSTR = Ptr<char>;
    using PCUTSTR = Ptr<char>;
    using LPCUTSTR = Ptr<char>;
    using LP = Ptr<char>;
    using PZZTSTR = Ptr<char>;
    using PCZZTSTR = Ptr<char>;
    using PUZZTSTR = Ptr<char>;
    using PCUZZTSTR = Ptr<char>;
    using PZPTSTR = Ptr<Ptr<char>>;
    using PNZTCH = Ptr<char>;
    using PCNZTCH = Ptr<char>;
    using PUNZTCH = Ptr<char>;
    using PCUNZTCH = Ptr<char>;

    // Pointer to an Asciiz string
    using PSZ = Ptr<byte>; // null-terminated
    using PCSZ = Ptr<byte>; // const null-terminated

    // Counted String
    using RTL_STRING_LENGTH_TYPE = UInt16;

    // Pointers to structures
    using PLUID = Ptr<LUID>;
    using LARGE_INTEGER = Int64;
    using PLARGE_INTEGER = Ptr<long>;
    using ULARGE_INTEGER = UInt64;
    using PULARGE_INTEGER = Ptr<ulong>;
    using PSTRING = Ptr<STRING>;
    using ANSI_STRING = STRING;
    using PANSI_STRING = Ptr<STRING>;
    using OEM_STRING = STRING;
    using POEM_STRING = Ptr<STRING>;
    using PCOEM_STRING = Ptr<STRING>; // const
    using PCSTRING = Ptr<CSTRING>;
    using CANSI_STRING = STRING;
    using PCANSI_STRING = Ptr<STRING>;
    using UTF8_STRING = STRING;
    using PUTF8_STRING = Ptr<STRING>;
    using PUNICODE_STRING = Ptr<UNICODE_STRING>;
    using PCUNICODE_STRING = Ptr<UNICODE_STRING>; // const
    using PLIST_ENTRY = Ptr<LIST_ENTRY>;
    using PRLIST_ENTRY = Ptr<LIST_ENTRY>; // restricted pointer
    using PSINGLE_LIST_ENTRY = Ptr<SINGLE_LIST_ENTRY>;
    using PRTL_BALANCED_NODE = Ptr<RTL_BALANCED_NODE>;
    using PLIST_ENTRY32 = Ptr<LIST_ENTRY32>;
    using PLIST_ENTRY64 = Ptr<LIST_ENTRY64>;
    using PSINGLE_LIST_ENTRY32 = Ptr<SINGLE_LIST_ENTRY32>;
    using PWNF_STATE_NAME = Ptr<WNF_STATE_NAME>;
    using PCWNF_STATE_NAME = Ptr<WNF_STATE_NAME>;
    using PSTRING32 = Ptr<STRING32>;
    using UNICODE_STRING32 = STRING32;
    using PUNICODE_STRING32 = Ptr<STRING32>;
    using ANSI_STRING32 = STRING32;
    using PANSI_STRING32 = Ptr<STRING32>;
    using PSTRING64 = Ptr<STRING64>;
    using UNICODE_STRING64 = STRING64;
    using PUNICODE_STRING64 = Ptr<STRING64>;
    using ANSI_STRING64 = STRING64;
    using PANSI_STRING64 = Ptr<STRING64>;
    using POBJECT_ATTRIBUTES64 = Ptr<OBJECT_ATTRIBUTES64>;
    using PCOBJECT_ATTRIBUTES64 = Ptr<OBJECT_ATTRIBUTES64>;
    using POBJECT_ATTRIBUTES32 = Ptr<OBJECT_ATTRIBUTES32>;
    using PCOBJECT_ATTRIBUTES32 = Ptr<OBJECT_ATTRIBUTES32>;
    using POBJECT_ATTRIBUTES = Ptr<OBJECT_ATTRIBUTES>;
    using PCOBJECT_ATTRIBUTES = Ptr<OBJECT_ATTRIBUTES>;
    using PFILETIME = Ptr<FILETIME>;
    using LPFILETIME = Ptr<FILETIME>;

    using COLORREF = UInt32;
    using LPCOLORREF = Ptr<uint>;

    using PRECT = Ptr<RECT>;
    using NPRECT = Ptr<RECT>;
    using LPRECT = Ptr<RECT>;
    using LPCRECT = Ptr<RECT>;
    using PRECTL = Ptr<RECTL>;
    using LPRECTL = Ptr<RECTL>;
    using LPCRECTL = Ptr<RECTL>;
    using PPOINT = Ptr<POINT>;
    using NPPOINT = Ptr<POINT>;
    using LPPOINT = Ptr<POINT>;
    using PPOINTL = Ptr<POINTL>;
    using PSIZE = Ptr<SIZE>;
    using LPSIZE = Ptr<SIZE>;
    using SIZEL = SIZE;
    using PSIZEL = Ptr<SIZE>;
    using LPSIZEL = Ptr<SIZE>;

    using HGLOBAL = HANDLE;
    using HLOCAL = HANDLE;
    using GLOBALHANDLE = HANDLE;
    using LOCALHANDLE = HANDLE;
    using SPHANDLE = Ptr<HANDLE>;
    using LPHANDLE = Ptr<HANDLE>;
    using PHKEY = Ptr<HKEY>;
    using HMODULE = HINSTANCE;
    using HFILE = Int32;
}
