using System;

namespace Antrv.Interop.WindowsSDK
{
    [Flags]
    public enum DeviceModes
    {
        None = 0,
        DM_UPDATE           =1,
        DM_COPY             =2,
        DM_PROMPT           =4,
        DM_MODIFY           =8,
        DM_IN_BUFFER       = DM_MODIFY,
        DM_IN_PROMPT        =DM_PROMPT,
        DM_OUT_BUFFER       =DM_COPY,
        DM_OUT_DEFAULT      =DM_UPDATE,
    }
}