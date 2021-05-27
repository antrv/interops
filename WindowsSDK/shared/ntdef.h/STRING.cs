namespace Antrv.Interop.WindowsSDK
{
    public struct STRING
    {
        public ushort Length;
        public ushort MaximumLength;
        public Ptr<byte> Buffer;
    }
}
