// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipFusionBase : Table {
  public static FB_EquipFusionBase GetRootAsFB_EquipFusionBase(ByteBuffer _bb) { return GetRootAsFB_EquipFusionBase(_bb, new FB_EquipFusionBase()); }
  public static FB_EquipFusionBase GetRootAsFB_EquipFusionBase(ByteBuffer _bb, FB_EquipFusionBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipFusionBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Unlock { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string UnlockTip { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ShowNewIconMFId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipFusionBase> CreateFB_EquipFusionBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Unlock = -1,
      StringOffset UnlockTip = default(StringOffset),
      int ShowNewIconMFId = -1) {
    builder.StartObject(5);
    FB_EquipFusionBase.AddShowNewIconMFId(builder, ShowNewIconMFId);
    FB_EquipFusionBase.AddUnlockTip(builder, UnlockTip);
    FB_EquipFusionBase.AddUnlock(builder, Unlock);
    FB_EquipFusionBase.AddName(builder, Name);
    FB_EquipFusionBase.AddID(builder, ID);
    return FB_EquipFusionBase.EndFB_EquipFusionBase(builder);
  }

  public static void StartFB_EquipFusionBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddUnlock(FlatBufferBuilder builder, int Unlock) { builder.AddInt(2, Unlock, -1); }
  public static void AddUnlockTip(FlatBufferBuilder builder, StringOffset UnlockTipOffset) { builder.AddOffset(3, UnlockTipOffset.Value, 0); }
  public static void AddShowNewIconMFId(FlatBufferBuilder builder, int ShowNewIconMFId) { builder.AddInt(4, ShowNewIconMFId, -1); }
  public static Offset<FB_EquipFusionBase> EndFB_EquipFusionBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFusionBase>(o);
  }
};

public sealed class FB_EquipFusionBaseContainer : Table {
  public static FB_EquipFusionBaseContainer GetRootAsFB_EquipFusionBaseContainer(ByteBuffer _bb) { return GetRootAsFB_EquipFusionBaseContainer(_bb, new FB_EquipFusionBaseContainer()); }
  public static FB_EquipFusionBaseContainer GetRootAsFB_EquipFusionBaseContainer(ByteBuffer _bb, FB_EquipFusionBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipFusionBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipFusionBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipFusionBase GetItems(int j) { return GetItems(new FB_EquipFusionBase(), j); }
  public FB_EquipFusionBase GetItems(FB_EquipFusionBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipFusionBaseContainer> CreateFB_EquipFusionBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipFusionBaseContainer.AddItems(builder, items);
    return FB_EquipFusionBaseContainer.EndFB_EquipFusionBaseContainer(builder);
  }

  public static void StartFB_EquipFusionBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipFusionBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipFusionBaseContainer> EndFB_EquipFusionBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFusionBaseContainer>(o);
  }
  public static void FinishFB_EquipFusionBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipFusionBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
