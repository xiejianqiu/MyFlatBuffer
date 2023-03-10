// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipFusionAttr : Table {
  public static FB_EquipFusionAttr GetRootAsFB_EquipFusionAttr(ByteBuffer _bb) { return GetRootAsFB_EquipFusionAttr(_bb, new FB_EquipFusionAttr()); }
  public static FB_EquipFusionAttr GetRootAsFB_EquipFusionAttr(ByteBuffer _bb, FB_EquipFusionAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipFusionAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSuitAttrIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SuitAttrIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSuitAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SuitAttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipFusionAttr> CreateFB_EquipFusionAttr(FlatBufferBuilder builder,
      int ID = 0,
      int CostItemId = -1,
      int CostItemNum = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset SuitAttrIdList = default(VectorOffset),
      VectorOffset SuitAttrValueList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_EquipFusionAttr.AddSuitAttrValueList(builder, SuitAttrValueList);
    FB_EquipFusionAttr.AddSuitAttrIdList(builder, SuitAttrIdList);
    FB_EquipFusionAttr.AddAttrValueList(builder, AttrValueList);
    FB_EquipFusionAttr.AddAttrIdList(builder, AttrIdList);
    FB_EquipFusionAttr.AddCostItemNum(builder, CostItemNum);
    FB_EquipFusionAttr.AddCostItemId(builder, CostItemId);
    FB_EquipFusionAttr.AddID(builder, ID);
    return FB_EquipFusionAttr.EndFB_EquipFusionAttr(builder);
  }

  public static void StartFB_EquipFusionAttr(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(2, CostItemNum, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSuitAttrIdList(FlatBufferBuilder builder, VectorOffset SuitAttrIdListOffset) { builder.AddOffset(5, SuitAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateSuitAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSuitAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSuitAttrValueList(FlatBufferBuilder builder, VectorOffset SuitAttrValueListOffset) { builder.AddOffset(6, SuitAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateSuitAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSuitAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipFusionAttr> EndFB_EquipFusionAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFusionAttr>(o);
  }
};

public sealed class FB_EquipFusionAttrContainer : Table {
  public static FB_EquipFusionAttrContainer GetRootAsFB_EquipFusionAttrContainer(ByteBuffer _bb) { return GetRootAsFB_EquipFusionAttrContainer(_bb, new FB_EquipFusionAttrContainer()); }
  public static FB_EquipFusionAttrContainer GetRootAsFB_EquipFusionAttrContainer(ByteBuffer _bb, FB_EquipFusionAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipFusionAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipFusionAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipFusionAttr GetItems(int j) { return GetItems(new FB_EquipFusionAttr(), j); }
  public FB_EquipFusionAttr GetItems(FB_EquipFusionAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipFusionAttrContainer> CreateFB_EquipFusionAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipFusionAttrContainer.AddItems(builder, items);
    return FB_EquipFusionAttrContainer.EndFB_EquipFusionAttrContainer(builder);
  }

  public static void StartFB_EquipFusionAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipFusionAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipFusionAttrContainer> EndFB_EquipFusionAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipFusionAttrContainer>(o);
  }
  public static void FinishFB_EquipFusionAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipFusionAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
