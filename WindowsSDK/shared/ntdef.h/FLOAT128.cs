namespace Antrv.Interop.WindowsSDK
{
    public readonly struct FLOAT128 // must be aligned to 128-bits
    {
        public readonly long LowPart;
        public readonly long HighPart;
    }
}
