// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondCuiLian : Table {
  public static FB_DiamondCuiLian GetRootAsFB_DiamondCuiLian(ByteBuffer _bb) { return GetRootAsFB_DiamondCuiLian(_bb, new FB_DiamondCuiLian()); }
  public static FB_DiamondCuiLian GetRootAsFB_DiamondCuiLian(ByteBuffer _bb, FB_DiamondCuiLian obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondCuiLian __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ConditionCuilianLv { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int Rate { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DiamondCuiLian> CreateFB_DiamondCuiLian(FlatBufferBuilder builder,
      int Id = 0,
      int ConditionCuilianLv = -1,
      int CostItemId = -1,
      int CostItemNum = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int Rate = -1) {
    builder.StartObject(7);
    FB_DiamondCuiLian.AddRate(builder, Rate);
    FB_DiamondCuiLian.AddAttrValueList(builder, AttrValueList);
    FB_DiamondCuiLian.AddAttrIdList(builder, AttrIdList);
    FB_DiamondCuiLian.AddCostItemNum(builder, CostItemNum);
    FB_DiamondCuiLian.AddCostItemId(builder, CostItemId);
    FB_DiamondCuiLian.AddConditionCuilianLv(builder, ConditionCuilianLv);
    FB_DiamondCuiLian.AddId(builder, Id);
    return FB_DiamondCuiLian.EndFB_DiamondCuiLian(builder);
  }

  public static void StartFB_DiamondCuiLian(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddConditionCuilianLv(FlatBufferBuilder builder, int ConditionCuilianLv) { builder.AddInt(1, ConditionCuilianLv, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(2, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(3, CostItemNum, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRate(FlatBufferBuilder builder, int Rate) { builder.AddInt(6, Rate, -1); }
  public static Offset<FB_DiamondCuiLian> EndFB_DiamondCuiLian(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondCuiLian>(o);
  }
};

public sealed class FB_DiamondCuiLianContainer : Table {
  public static FB_DiamondCuiLianContainer GetRootAsFB_DiamondCuiLianContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondCuiLianContainer(_bb, new FB_DiamondCuiLianContainer()); }
  public static FB_DiamondCuiLianContainer GetRootAsFB_DiamondCuiLianContainer(ByteBuffer _bb, FB_DiamondCuiLianContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondCuiLianContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondCuiLianContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondCuiLian GetItems(int j) { return GetItems(new FB_DiamondCuiLian(), j); }
  public FB_DiamondCuiLian GetItems(FB_DiamondCuiLian obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondCuiLianContainer> CreateFB_DiamondCuiLianContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondCuiLianContainer.AddItems(builder, items);
    return FB_DiamondCuiLianContainer.EndFB_DiamondCuiLianContainer(builder);
  }

  public static void StartFB_DiamondCuiLianContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondCuiLian>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondCuiLianContainer> EndFB_DiamondCuiLianContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondCuiLianContainer>(o);
  }
  public static void FinishFB_DiamondCuiLianContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondCuiLianContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
