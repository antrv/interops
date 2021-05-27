namespace Antrv.Interop.WindowsSDK
{
    public struct UNICODE_STRING
    {
        public ushort Length;
        public ushort MaximumLength;
        public Ptr<char> Buffer;
    }
}
