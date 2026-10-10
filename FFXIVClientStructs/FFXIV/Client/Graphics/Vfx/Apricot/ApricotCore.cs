using Ktisis.Structs.Vfx.Apricot;
using static System.Runtime.InteropServices.LayoutKind;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Vfx.Apricot;

[GenerateInterop]
[StructLayout(Explicit, Size=0x2D74)]
public unsafe partial struct ApricotCore {
	[FieldOffset(0xD30)] public unsafe DataContainer* Data;

	[StructLayout(Explicit)]
	public struct DataContainer {
		[FieldOffset(0x2030)] public unsafe fixed byte Instances[2048 * InstanceContainer.Size];

		public unsafe InstanceContainer* GetIndex(uint index) {
			if (index > 2048)
				throw new IndexOutOfRangeException($"Index {index} is out of range.");
			
			fixed (byte* data = this.Instances) {
				return (InstanceContainer*)data + index;
			}
		}

		public unsafe Span<InstanceContainer> GetInstancesSpan() {
			fixed (byte* data = this.Instances) {
				return new Span<InstanceContainer>(data, InstanceContainer.Size);
			}
		}
	}
	
	[MemberFunction("E8 ?? ?? ?? ?? 4B 8B 0C 27")]
	public static partial ApricotCore* GetSingleton();
}
