// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipSlotAttr : Table {
  public static FB_EquipSlotAttr GetRootAsFB_EquipSlotAttr(ByteBuffer _bb) { return GetRootAsFB_EquipSlotAttr(_bb, new FB_EquipSlotAttr()); }
  public static FB_EquipSlotAttr GetRootAsFB_EquipSlotAttr(ByteBuffer _bb, FB_EquipSlotAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipSlotAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Rate { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipSlotAttr> CreateFB_EquipSlotAttr(FlatBufferBuilder builder,
      int ID = 0,
      int Rate = -1,
      int Quality = -1) {
    builder.StartObject(3);
    FB_EquipSlotAttr.AddQuality(builder, Quality);
    FB_EquipSlotAttr.AddRate(builder, Rate);
    FB_EquipSlotAttr.AddID(builder, ID);
    return FB_EquipSlotAttr.EndFB_EquipSlotAttr(builder);
  }

  public static void StartFB_EquipSlotAttr(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRate(FlatBufferBuilder builder, int Rate) { builder.AddInt(1, Rate, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, -1); }
  public static Offset<FB_EquipSlotAttr> EndFB_EquipSlotAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSlotAttr>(o);
  }
};

public sealed class FB_EquipSlotAttrContainer : Table {
  public static FB_EquipSlotAttrContainer GetRootAsFB_EquipSlotAttrContainer(ByteBuffer _bb) { return GetRootAsFB_EquipSlotAttrContainer(_bb, new FB_EquipSlotAttrContainer()); }
  public static FB_EquipSlotAttrContainer GetRootAsFB_EquipSlotAttrContainer(ByteBuffer _bb, FB_EquipSlotAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipSlotAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipSlotAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipSlotAttr GetItems(int j) { return GetItems(new FB_EquipSlotAttr(), j); }
  public FB_EquipSlotAttr GetItems(FB_EquipSlotAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSlotAttrContainer> CreateFB_EquipSlotAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipSlotAttrContainer.AddItems(builder, items);
    return FB_EquipSlotAttrContainer.EndFB_EquipSlotAttrContainer(builder);
  }

  public static void StartFB_EquipSlotAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipSlotAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSlotAttrContainer> EndFB_EquipSlotAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSlotAttrContainer>(o);
  }
  public static void FinishFB_EquipSlotAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipSlotAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
