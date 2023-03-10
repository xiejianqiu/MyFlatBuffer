// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BloodMixLevel : Table {
  public static FB_BloodMixLevel GetRootAsFB_BloodMixLevel(ByteBuffer _bb) { return GetRootAsFB_BloodMixLevel(_bb, new FB_BloodMixLevel()); }
  public static FB_BloodMixLevel GetRootAsFB_BloodMixLevel(ByteBuffer _bb, FB_BloodMixLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BloodMixLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BloodMixLevel> CreateFB_BloodMixLevel(FlatBufferBuilder builder,
      int ID = 0,
      int CostItemID = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_BloodMixLevel.AddAttrValueList(builder, AttrValueList);
    FB_BloodMixLevel.AddAttrIdList(builder, AttrIdList);
    FB_BloodMixLevel.AddCostItemCount(builder, CostItemCount);
    FB_BloodMixLevel.AddCostItemID(builder, CostItemID);
    FB_BloodMixLevel.AddID(builder, ID);
    return FB_BloodMixLevel.EndFB_BloodMixLevel(builder);
  }

  public static void StartFB_BloodMixLevel(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCostItemID(FlatBufferBuilder builder, int CostItemID) { builder.AddInt(1, CostItemID, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(2, CostItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BloodMixLevel> EndFB_BloodMixLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodMixLevel>(o);
  }
};

public sealed class FB_BloodMixLevelContainer : Table {
  public static FB_BloodMixLevelContainer GetRootAsFB_BloodMixLevelContainer(ByteBuffer _bb) { return GetRootAsFB_BloodMixLevelContainer(_bb, new FB_BloodMixLevelContainer()); }
  public static FB_BloodMixLevelContainer GetRootAsFB_BloodMixLevelContainer(ByteBuffer _bb, FB_BloodMixLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BloodMixLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BloodMixLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BloodMixLevel GetItems(int j) { return GetItems(new FB_BloodMixLevel(), j); }
  public FB_BloodMixLevel GetItems(FB_BloodMixLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BloodMixLevelContainer> CreateFB_BloodMixLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BloodMixLevelContainer.AddItems(builder, items);
    return FB_BloodMixLevelContainer.EndFB_BloodMixLevelContainer(builder);
  }

  public static void StartFB_BloodMixLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BloodMixLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BloodMixLevelContainer> EndFB_BloodMixLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodMixLevelContainer>(o);
  }
  public static void FinishFB_BloodMixLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_BloodMixLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
