// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingLevel : Table {
  public static FB_HuanJingLevel GetRootAsFB_HuanJingLevel(ByteBuffer _bb) { return GetRootAsFB_HuanJingLevel(_bb, new FB_HuanJingLevel()); }
  public static FB_HuanJingLevel GetRootAsFB_HuanJingLevel(ByteBuffer _bb, FB_HuanJingLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HuanJingBaseId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HuanJingLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BreakThrough { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCostItemIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostItemCountList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemCountListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingLevel> CreateFB_HuanJingLevel(FlatBufferBuilder builder,
      int Id = 0,
      int HuanJingBaseId = -1,
      int HuanJingLevel = -1,
      int BreakThrough = -1,
      VectorOffset CostItemIdList = default(VectorOffset),
      VectorOffset CostItemCountList = default(VectorOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_HuanJingLevel.AddAttrValueList(builder, AttrValueList);
    FB_HuanJingLevel.AddAttrIdList(builder, AttrIdList);
    FB_HuanJingLevel.AddCostItemCountList(builder, CostItemCountList);
    FB_HuanJingLevel.AddCostItemIdList(builder, CostItemIdList);
    FB_HuanJingLevel.AddBreakThrough(builder, BreakThrough);
    FB_HuanJingLevel.AddHuanJingLevel(builder, HuanJingLevel);
    FB_HuanJingLevel.AddHuanJingBaseId(builder, HuanJingBaseId);
    FB_HuanJingLevel.AddId(builder, Id);
    return FB_HuanJingLevel.EndFB_HuanJingLevel(builder);
  }

  public static void StartFB_HuanJingLevel(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddHuanJingBaseId(FlatBufferBuilder builder, int HuanJingBaseId) { builder.AddInt(1, HuanJingBaseId, -1); }
  public static void AddHuanJingLevel(FlatBufferBuilder builder, int HuanJingLevel) { builder.AddInt(2, HuanJingLevel, -1); }
  public static void AddBreakThrough(FlatBufferBuilder builder, int BreakThrough) { builder.AddInt(3, BreakThrough, -1); }
  public static void AddCostItemIdList(FlatBufferBuilder builder, VectorOffset CostItemIdListOffset) { builder.AddOffset(4, CostItemIdListOffset.Value, 0); }
  public static VectorOffset CreateCostItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostItemCountList(FlatBufferBuilder builder, VectorOffset CostItemCountListOffset) { builder.AddOffset(5, CostItemCountListOffset.Value, 0); }
  public static VectorOffset CreateCostItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(6, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(7, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingLevel> EndFB_HuanJingLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingLevel>(o);
  }
};

public sealed class FB_HuanJingLevelContainer : Table {
  public static FB_HuanJingLevelContainer GetRootAsFB_HuanJingLevelContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingLevelContainer(_bb, new FB_HuanJingLevelContainer()); }
  public static FB_HuanJingLevelContainer GetRootAsFB_HuanJingLevelContainer(ByteBuffer _bb, FB_HuanJingLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingLevel GetItems(int j) { return GetItems(new FB_HuanJingLevel(), j); }
  public FB_HuanJingLevel GetItems(FB_HuanJingLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingLevelContainer> CreateFB_HuanJingLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingLevelContainer.AddItems(builder, items);
    return FB_HuanJingLevelContainer.EndFB_HuanJingLevelContainer(builder);
  }

  public static void StartFB_HuanJingLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingLevelContainer> EndFB_HuanJingLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingLevelContainer>(o);
  }
  public static void FinishFB_HuanJingLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
