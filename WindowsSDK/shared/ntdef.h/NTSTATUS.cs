namespace Antrv.Interop.WindowsSDK
{
    public readonly struct NTSTATUS
    {
        private const uint APPLICATION_ERROR_MASK = 0x20000000;
        private const uint ERROR_SEVERITY_SUCCESS = 0x00000000;
        private const uint ERROR_SEVERITY_INFORMATIONAL = 0x40000000;
        private const uint ERROR_SEVERITY_WARNING = 0x80000000;
        private const uint ERROR_SEVERITY_ERROR = 0xC0000000;

        private readonly int _value;

        public bool Success => _value >= 0;

        public bool Information => ((uint)_value & 0xC0000000u) == ERROR_SEVERITY_INFORMATIONAL;

        public bool Warning => ((uint)_value & 0xC0000000u) == ERROR_SEVERITY_WARNING;

        public bool Error => ((uint)_value & 0xC0000000u) == ERROR_SEVERITY_ERROR;
    }
}
