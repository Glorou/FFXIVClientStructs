using FFXIVClientStructs.FFXIV.Client.System.Scheduler.Base;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Vfx;

[StructLayout(LayoutKind.Explicit, Size = 0xF0)]
public struct VfxControl {
    [FieldOffset(0)] public SchedulerState State;

    [FieldOffset(0x28)] public unsafe SchedulerVfx* SchedulerVfx;
}
