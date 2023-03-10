// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipRandomAttr : Table {
  public static FB_EquipRandomAttr GetRootAsFB_EquipRandomAttr(ByteBuffer _bb) { return GetRootAsFB_EquipRandomAttr(_bb, new FB_EquipRandomAttr()); }
  public static FB_EquipRandomAttr GetRootAsFB_EquipRandomAttr(ByteBuffer _bb, FB_EquipRandomAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipRandomAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetDropTypeList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DropTypeListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemDropRateList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemDropRateListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipRandomAttr> CreateFB_EquipRandomAttr(FlatBufferBuilder builder,
      int Id = 0,
      int Type = 0,
      VectorOffset DropType_List = default(VectorOffset),
      VectorOffset ItemID_List = default(VectorOffset),
      VectorOffset ItemDropRate_List = default(VectorOffset)) {
    builder.StartObject(5);
    FB_EquipRandomAttr.AddItemDropRateList(builder, ItemDropRate_List);
    FB_EquipRandomAttr.AddItemIDList(builder, ItemID_List);
    FB_EquipRandomAttr.AddDropTypeList(builder, DropType_List);
    FB_EquipRandomAttr.AddType(builder, Type);
    FB_EquipRandomAttr.AddId(builder, Id);
    return FB_EquipRandomAttr.EndFB_EquipRandomAttr(builder);
  }

  public static void StartFB_EquipRandomAttr(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, 0); }
  public static void AddDropTypeList(FlatBufferBuilder builder, VectorOffset DropTypeListOffset) { builder.AddOffset(2, DropTypeListOffset.Value, 0); }
  public static VectorOffset CreateDropTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDropTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(3, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemDropRateList(FlatBufferBuilder builder, VectorOffset ItemDropRateListOffset) { builder.AddOffset(4, ItemDropRateListOffset.Value, 0); }
  public static VectorOffset CreateItemDropRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemDropRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipRandomAttr> EndFB_EquipRandomAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipRandomAttr>(o);
  }
};

public sealed class FB_EquipRandomAttrContainer : Table {
  public static FB_EquipRandomAttrContainer GetRootAsFB_EquipRandomAttrContainer(ByteBuffer _bb) { return GetRootAsFB_EquipRandomAttrContainer(_bb, new FB_EquipRandomAttrContainer()); }
  public static FB_EquipRandomAttrContainer GetRootAsFB_EquipRandomAttrContainer(ByteBuffer _bb, FB_EquipRandomAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipRandomAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipRandomAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipRandomAttr GetItems(int j) { return GetItems(new FB_EquipRandomAttr(), j); }
  public FB_EquipRandomAttr GetItems(FB_EquipRandomAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipRandomAttrContainer> CreateFB_EquipRandomAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipRandomAttrContainer.AddItems(builder, items);
    return FB_EquipRandomAttrContainer.EndFB_EquipRandomAttrContainer(builder);
  }

  public static void StartFB_EquipRandomAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipRandomAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipRandomAttrContainer> EndFB_EquipRandomAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipRandomAttrContainer>(o);
  }
  public static void FinishFB_EquipRandomAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipRandomAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
