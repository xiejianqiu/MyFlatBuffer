// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShouHuangXiLevelUp : Table {
  public static FB_ShouHuangXiLevelUp GetRootAsFB_ShouHuangXiLevelUp(ByteBuffer _bb) { return GetRootAsFB_ShouHuangXiLevelUp(_bb, new FB_ShouHuangXiLevelUp()); }
  public static FB_ShouHuangXiLevelUp GetRootAsFB_ShouHuangXiLevelUp(ByteBuffer _bb, FB_ShouHuangXiLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShouHuangXiLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShouHuangXiLevelUp> CreateFB_ShouHuangXiLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemId = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ShouHuangXiLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ShouHuangXiLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_ShouHuangXiLevelUp.AddCostItemCount(builder, CostItemCount);
    FB_ShouHuangXiLevelUp.AddCostItemId(builder, CostItemId);
    FB_ShouHuangXiLevelUp.AddId(builder, Id);
    return FB_ShouHuangXiLevelUp.EndFB_ShouHuangXiLevelUp(builder);
  }

  public static void StartFB_ShouHuangXiLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(2, CostItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShouHuangXiLevelUp> EndFB_ShouHuangXiLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShouHuangXiLevelUp>(o);
  }
};

public sealed class FB_ShouHuangXiLevelUpContainer : Table {
  public static FB_ShouHuangXiLevelUpContainer GetRootAsFB_ShouHuangXiLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ShouHuangXiLevelUpContainer(_bb, new FB_ShouHuangXiLevelUpContainer()); }
  public static FB_ShouHuangXiLevelUpContainer GetRootAsFB_ShouHuangXiLevelUpContainer(ByteBuffer _bb, FB_ShouHuangXiLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShouHuangXiLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShouHuangXiLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShouHuangXiLevelUp GetItems(int j) { return GetItems(new FB_ShouHuangXiLevelUp(), j); }
  public FB_ShouHuangXiLevelUp GetItems(FB_ShouHuangXiLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShouHuangXiLevelUpContainer> CreateFB_ShouHuangXiLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShouHuangXiLevelUpContainer.AddItems(builder, items);
    return FB_ShouHuangXiLevelUpContainer.EndFB_ShouHuangXiLevelUpContainer(builder);
  }

  public static void StartFB_ShouHuangXiLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShouHuangXiLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShouHuangXiLevelUpContainer> EndFB_ShouHuangXiLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShouHuangXiLevelUpContainer>(o);
  }
  public static void FinishFB_ShouHuangXiLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShouHuangXiLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
