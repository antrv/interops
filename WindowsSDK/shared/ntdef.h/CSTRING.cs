namespace Antrv.Interop.WindowsSDK
{
    public struct CSTRING
    {
        public ushort Length;
        public ushort MaximumLength;
        public Ptr<byte> Buffer; // const
    }
}
