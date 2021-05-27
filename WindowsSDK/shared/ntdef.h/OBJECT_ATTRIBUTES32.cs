namespace Antrv.Interop.WindowsSDK
{
    public struct OBJECT_ATTRIBUTES32
    {
        public uint Length;
        public uint RootDirectory;
        public uint ObjectName;
        public ObjectAttributes Attributes;
        public uint SecurityDescriptor;
        public uint SecurityQualityOfService;
    }
}