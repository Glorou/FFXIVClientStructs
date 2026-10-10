namespace FFXIVClientStructs.FFXIV.Client.Graphics.Vfx;

[StructLayout(LayoutKind.Explicit)]
public struct SchedulerVfx {
    [FieldOffset(0)] public unsafe nint* __vfTable;

    [FieldOffset(0x80)] public unsafe VfxObject* Instance;
}
