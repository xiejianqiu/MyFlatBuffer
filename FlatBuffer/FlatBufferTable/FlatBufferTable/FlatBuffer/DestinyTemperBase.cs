// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyTemperBase : Table {
  public static FB_DestinyTemperBase GetRootAsFB_DestinyTemperBase(ByteBuffer _bb) { return GetRootAsFB_DestinyTemperBase(_bb, new FB_DestinyTemperBase()); }
  public static FB_DestinyTemperBase GetRootAsFB_DestinyTemperBase(ByteBuffer _bb, FB_DestinyTemperBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyTemperBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxPercent { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyTemperBase> CreateFB_DestinyTemperBase(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemId = -1,
      int CostItemNum = -1,
      int MaxPercent = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_DestinyTemperBase.AddAttrValueList(builder, AttrValueList);
    FB_DestinyTemperBase.AddAttrIdList(builder, AttrIdList);
    FB_DestinyTemperBase.AddMaxPercent(builder, MaxPercent);
    FB_DestinyTemperBase.AddCostItemNum(builder, CostItemNum);
    FB_DestinyTemperBase.AddCostItemId(builder, CostItemId);
    FB_DestinyTemperBase.AddId(builder, Id);
    return FB_DestinyTemperBase.EndFB_DestinyTemperBase(builder);
  }

  public static void StartFB_DestinyTemperBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(2, CostItemNum, -1); }
  public static void AddMaxPercent(FlatBufferBuilder builder, int MaxPercent) { builder.AddInt(3, MaxPercent, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyTemperBase> EndFB_DestinyTemperBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyTemperBase>(o);
  }
};

public sealed class FB_DestinyTemperBaseContainer : Table {
  public static FB_DestinyTemperBaseContainer GetRootAsFB_DestinyTemperBaseContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyTemperBaseContainer(_bb, new FB_DestinyTemperBaseContainer()); }
  public static FB_DestinyTemperBaseContainer GetRootAsFB_DestinyTemperBaseContainer(ByteBuffer _bb, FB_DestinyTemperBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyTemperBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyTemperBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyTemperBase GetItems(int j) { return GetItems(new FB_DestinyTemperBase(), j); }
  public FB_DestinyTemperBase GetItems(FB_DestinyTemperBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyTemperBaseContainer> CreateFB_DestinyTemperBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyTemperBaseContainer.AddItems(builder, items);
    return FB_DestinyTemperBaseContainer.EndFB_DestinyTemperBaseContainer(builder);
  }

  public static void StartFB_DestinyTemperBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyTemperBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyTemperBaseContainer> EndFB_DestinyTemperBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyTemperBaseContainer>(o);
  }
  public static void FinishFB_DestinyTemperBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyTemperBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
