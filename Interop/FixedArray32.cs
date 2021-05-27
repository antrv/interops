namespace Antrv.Interop
{
    public struct FixedArray32<T>
        where T : unmanaged
    {
        private FixedArray4<FixedArray8<T>> _values;

        public Ptr<T> Ptr => _values.Ptr.Ref.Ptr;

        public ref T this[int index] => ref Ptr[index];
    }
}
