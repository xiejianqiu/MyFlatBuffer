// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondGongZhen : Table {
  public static FB_DiamondGongZhen GetRootAsFB_DiamondGongZhen(ByteBuffer _bb) { return GetRootAsFB_DiamondGongZhen(_bb, new FB_DiamondGongZhen()); }
  public static FB_DiamondGongZhen GetRootAsFB_DiamondGongZhen(ByteBuffer _bb, FB_DiamondGongZhen obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondGongZhen __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Components { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Lv { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondGongZhen> CreateFB_DiamondGongZhen(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Components = default(StringOffset),
      int Lv = -1,
      int CostItemId = -1,
      int CostItemNum = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_DiamondGongZhen.AddAttrValueList(builder, AttrValueList);
    FB_DiamondGongZhen.AddAttrIdList(builder, AttrIdList);
    FB_DiamondGongZhen.AddCostItemNum(builder, CostItemNum);
    FB_DiamondGongZhen.AddCostItemId(builder, CostItemId);
    FB_DiamondGongZhen.AddLv(builder, Lv);
    FB_DiamondGongZhen.AddComponents(builder, Components);
    FB_DiamondGongZhen.AddId(builder, Id);
    return FB_DiamondGongZhen.EndFB_DiamondGongZhen(builder);
  }

  public static void StartFB_DiamondGongZhen(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddComponents(FlatBufferBuilder builder, StringOffset ComponentsOffset) { builder.AddOffset(1, ComponentsOffset.Value, 0); }
  public static void AddLv(FlatBufferBuilder builder, int Lv) { builder.AddInt(2, Lv, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(3, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(4, CostItemNum, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(5, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondGongZhen> EndFB_DiamondGongZhen(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondGongZhen>(o);
  }
};

public sealed class FB_DiamondGongZhenContainer : Table {
  public static FB_DiamondGongZhenContainer GetRootAsFB_DiamondGongZhenContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondGongZhenContainer(_bb, new FB_DiamondGongZhenContainer()); }
  public static FB_DiamondGongZhenContainer GetRootAsFB_DiamondGongZhenContainer(ByteBuffer _bb, FB_DiamondGongZhenContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondGongZhenContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondGongZhenContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondGongZhen GetItems(int j) { return GetItems(new FB_DiamondGongZhen(), j); }
  public FB_DiamondGongZhen GetItems(FB_DiamondGongZhen obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondGongZhenContainer> CreateFB_DiamondGongZhenContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondGongZhenContainer.AddItems(builder, items);
    return FB_DiamondGongZhenContainer.EndFB_DiamondGongZhenContainer(builder);
  }

  public static void StartFB_DiamondGongZhenContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondGongZhen>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondGongZhenContainer> EndFB_DiamondGongZhenContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondGongZhenContainer>(o);
  }
  public static void FinishFB_DiamondGongZhenContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondGongZhenContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
