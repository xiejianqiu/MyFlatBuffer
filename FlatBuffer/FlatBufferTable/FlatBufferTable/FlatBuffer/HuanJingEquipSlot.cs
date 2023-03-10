// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingEquipSlot : Table {
  public static FB_HuanJingEquipSlot GetRootAsFB_HuanJingEquipSlot(ByteBuffer _bb) { return GetRootAsFB_HuanJingEquipSlot(_bb, new FB_HuanJingEquipSlot()); }
  public static FB_HuanJingEquipSlot GetRootAsFB_HuanJingEquipSlot(ByteBuffer _bb, FB_HuanJingEquipSlot obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingEquipSlot __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HuanJingBaseId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Slot { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_HuanJingEquipSlot> CreateFB_HuanJingEquipSlot(FlatBufferBuilder builder,
      int ID = 0,
      int HuanJingBaseId = 0,
      int Slot = 0,
      int CostItemId = 0,
      int CostItemCount = 0) {
    builder.StartObject(5);
    FB_HuanJingEquipSlot.AddCostItemCount(builder, CostItemCount);
    FB_HuanJingEquipSlot.AddCostItemId(builder, CostItemId);
    FB_HuanJingEquipSlot.AddSlot(builder, Slot);
    FB_HuanJingEquipSlot.AddHuanJingBaseId(builder, HuanJingBaseId);
    FB_HuanJingEquipSlot.AddID(builder, ID);
    return FB_HuanJingEquipSlot.EndFB_HuanJingEquipSlot(builder);
  }

  public static void StartFB_HuanJingEquipSlot(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHuanJingBaseId(FlatBufferBuilder builder, int HuanJingBaseId) { builder.AddInt(1, HuanJingBaseId, 0); }
  public static void AddSlot(FlatBufferBuilder builder, int Slot) { builder.AddInt(2, Slot, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(3, CostItemId, 0); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(4, CostItemCount, 0); }
  public static Offset<FB_HuanJingEquipSlot> EndFB_HuanJingEquipSlot(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingEquipSlot>(o);
  }
};

public sealed class FB_HuanJingEquipSlotContainer : Table {
  public static FB_HuanJingEquipSlotContainer GetRootAsFB_HuanJingEquipSlotContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingEquipSlotContainer(_bb, new FB_HuanJingEquipSlotContainer()); }
  public static FB_HuanJingEquipSlotContainer GetRootAsFB_HuanJingEquipSlotContainer(ByteBuffer _bb, FB_HuanJingEquipSlotContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingEquipSlotContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingEquipSlotContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingEquipSlot GetItems(int j) { return GetItems(new FB_HuanJingEquipSlot(), j); }
  public FB_HuanJingEquipSlot GetItems(FB_HuanJingEquipSlot obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingEquipSlotContainer> CreateFB_HuanJingEquipSlotContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingEquipSlotContainer.AddItems(builder, items);
    return FB_HuanJingEquipSlotContainer.EndFB_HuanJingEquipSlotContainer(builder);
  }

  public static void StartFB_HuanJingEquipSlotContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingEquipSlot>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingEquipSlotContainer> EndFB_HuanJingEquipSlotContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingEquipSlotContainer>(o);
  }
  public static void FinishFB_HuanJingEquipSlotContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingEquipSlotContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
