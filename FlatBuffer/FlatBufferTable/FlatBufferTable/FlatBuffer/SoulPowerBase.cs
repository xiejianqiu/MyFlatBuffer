// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SoulPowerBase : Table {
  public static FB_SoulPowerBase GetRootAsFB_SoulPowerBase(ByteBuffer _bb) { return GetRootAsFB_SoulPowerBase(_bb, new FB_SoulPowerBase()); }
  public static FB_SoulPowerBase GetRootAsFB_SoulPowerBase(ByteBuffer _bb, FB_SoulPowerBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SoulPowerBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnlockItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockParam { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_SoulPowerBase> CreateFB_SoulPowerBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int UnlockItemId = 0,
      int UnlockParam = 0) {
    builder.StartObject(4);
    FB_SoulPowerBase.AddUnlockParam(builder, UnlockParam);
    FB_SoulPowerBase.AddUnlockItemId(builder, UnlockItemId);
    FB_SoulPowerBase.AddName(builder, Name);
    FB_SoulPowerBase.AddId(builder, Id);
    return FB_SoulPowerBase.EndFB_SoulPowerBase(builder);
  }

  public static void StartFB_SoulPowerBase(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddUnlockItemId(FlatBufferBuilder builder, int UnlockItemId) { builder.AddInt(2, UnlockItemId, 0); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(3, UnlockParam, 0); }
  public static Offset<FB_SoulPowerBase> EndFB_SoulPowerBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerBase>(o);
  }
};

public sealed class FB_SoulPowerBaseContainer : Table {
  public static FB_SoulPowerBaseContainer GetRootAsFB_SoulPowerBaseContainer(ByteBuffer _bb) { return GetRootAsFB_SoulPowerBaseContainer(_bb, new FB_SoulPowerBaseContainer()); }
  public static FB_SoulPowerBaseContainer GetRootAsFB_SoulPowerBaseContainer(ByteBuffer _bb, FB_SoulPowerBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SoulPowerBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SoulPowerBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SoulPowerBase GetItems(int j) { return GetItems(new FB_SoulPowerBase(), j); }
  public FB_SoulPowerBase GetItems(FB_SoulPowerBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SoulPowerBaseContainer> CreateFB_SoulPowerBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SoulPowerBaseContainer.AddItems(builder, items);
    return FB_SoulPowerBaseContainer.EndFB_SoulPowerBaseContainer(builder);
  }

  public static void StartFB_SoulPowerBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SoulPowerBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SoulPowerBaseContainer> EndFB_SoulPowerBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerBaseContainer>(o);
  }
  public static void FinishFB_SoulPowerBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_SoulPowerBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
