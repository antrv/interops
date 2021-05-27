using System;

namespace Antrv.Interop.WindowsSDK
{
    public struct OBJECT_ATTRIBUTES
    {
        public uint Length;
        public HANDLE RootDirectory;
        public Ptr<UNICODE_STRING> ObjectName;
        public ObjectAttributes Attributes;
        public IntPtr SecurityDescriptor; // Points to type SECURITY_DESCRIPTOR
        public IntPtr SecurityQualityOfService; // Points to type SECURITY_QUALITY_OF_SERVICE
    }
}
