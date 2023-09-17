// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipFuLingAttr : Table {
  public static FB_EquipFuLingAttr GetRootAsFB_EquipFuLingAttr(ByteBuffer _bb) { return GetRootAsFB_EquipFuLingAttr(_bb, new FB_EquipFuLingAttr()); }
  public static FB_EquipFuLingAttr GetRootAsFB_EquipFuLingAttr(ByteBuffer _bb, FB_EquipFuLingAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipFuLingAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipFuLingAttr> CreateFB_EquipFuLingAttr(FlatBufferBuilder builder,
      int ID = 0,
      int UnlockLevel = -1,
      int Component = -1,
      int AttrId = -1,
      int AttrValue = -1) {
    builder.StartObject(5);
    FB_EquipFuLingAttr.AddAttrValue(builder, AttrValue);
    FB_EquipFuLingAttr.AddAttrId(builder, AttrId);
    FB_EquipFuLingAttr.AddComponent(builder, Component);
    FB_EquipFuLingAttr.AddUnlockLevel(builder, UnlockLevel);
    FB_EquipFuLingAttr.AddID(builder, ID);
    return FB_EquipFuLingAttr.EndFB_EquipFuLingAttr(builder);
  }

  public static void StartFB_EquipFuLingAttr(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddUnlockLevel(FlatBufferBuilder builder, int UnlockLevel) { builder.AddInt(1, UnlockLevel, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(2, Component, -1); }
  public static void AddAttrId(FlatBufferBuilder builder, int AttrId) { builder.AddInt(3, AttrId, -1); }
  public static void AddAttrValue(FlatBufferBuilder builder, int AttrValue) { builder.AddInt(4, AttrValue, -1); }
  public static Offset<FB_EquipFuLingAttr> EndFB_EquipFuLingAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFuLingAttr>(o);
  }
};

public sealed class FB_EquipFuLingAttrContainer : Table {
  public static FB_EquipFuLingAttrContainer GetRootAsFB_EquipFuLingAttrContainer(ByteBuffer _bb) { return GetRootAsFB_EquipFuLingAttrContainer(_bb, new FB_EquipFuLingAttrContainer()); }
  public static FB_EquipFuLingAttrContainer GetRootAsFB_EquipFuLingAttrContainer(ByteBuffer _bb, FB_EquipFuLingAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipFuLingAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipFuLingAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipFuLingAttr GetItems(int j) { return GetItems(new FB_EquipFuLingAttr(), j); }
  public FB_EquipFuLingAttr GetItems(FB_EquipFuLingAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipFuLingAttrContainer> CreateFB_EquipFuLingAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipFuLingAttrContainer.AddItems(builder, items);
    return FB_EquipFuLingAttrContainer.EndFB_EquipFuLingAttrContainer(builder);
  }

  public static void StartFB_EquipFuLingAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipFuLingAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipFuLingAttrContainer> EndFB_EquipFuLingAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFuLingAttrContainer>(o);
  }
  public static void FinishFB_EquipFuLingAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipFuLingAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
