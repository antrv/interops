namespace Antrv.Interop.WindowsSDK
{
    public struct OBJECT_ATTRIBUTES64
    {
        public uint Length;
        public ulong RootDirectory;
        public ulong ObjectName;
        public ObjectAttributes Attributes;
        public ulong SecurityDescriptor;
        public ulong SecurityQualityOfService;
    }
}