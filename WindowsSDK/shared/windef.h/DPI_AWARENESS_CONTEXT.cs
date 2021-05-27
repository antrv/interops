namespace Antrv.Interop.WindowsSDK
{
    public readonly struct DPI_AWARENESS_CONTEXT
    {
        private readonly nint _value;

        private DPI_AWARENESS_CONTEXT(nint value) => _value = value;

        public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_UNAWARE { get; } = new(-1);
        public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_SYSTEM_AWARE { get; } = new(-2);
        public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE { get; } = new(-3);
        public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 { get; } = new(-4);
        public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED { get; } = new(-5);
    }
}