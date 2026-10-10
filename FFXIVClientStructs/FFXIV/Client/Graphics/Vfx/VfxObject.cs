using System.Numerics;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Vfx;

[StructLayout(LayoutKind.Explicit, Size = 0x340)]
public struct VfxObject {
    [FieldOffset(0)] public Object Object;

    [FieldOffset(0x260)] public Vector4 Color;

    [FieldOffset(0x2A0)] public unsafe VfxResourceInstance* ResourceInstance;
}
