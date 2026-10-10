using System.Runtime.InteropServices;
using FFXIVClientStructs.FFXIV.Client.Graphics.Vfx.Apricot;

namespace Ktisis.Structs.Vfx.Apricot;

[StructLayout(LayoutKind.Explicit, Size = Size)]
public struct InstanceContainer {
	public const int Size = 0x88;

	[FieldOffset(0x00)] public unsafe ApricotInstance* Instance;
}
