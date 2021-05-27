namespace Antrv.Interop
{
    public struct FixedArray8<T>
        where T : unmanaged
    {
        private T _value0;
        private T _value1;
        private T _value2;
        private T _value3;
        private T _value4;
        private T _value5;
        private T _value6;
        private T _value7;

        public Ptr<T> Ptr => new(ref _value0);

        public ref T this[int index] => ref Ptr[index];
    }
}
