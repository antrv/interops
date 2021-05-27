namespace Antrv.Interop.WindowsSDK
{
    public struct RTL_BALANCED_NODE
    {
        public Ptr<RTL_BALANCED_NODE> Left;
        public Ptr<RTL_BALANCED_NODE> Right;

        public nuint ParentValue;

        public Ptr<RTL_BALANCED_NODE> GetParentPointer() =>
            (Ptr<RTL_BALANCED_NODE>)(ParentValue & ~Constants.RTL_BALANCED_NODE_RESERVED_PARENT_MASK);
    }
}
