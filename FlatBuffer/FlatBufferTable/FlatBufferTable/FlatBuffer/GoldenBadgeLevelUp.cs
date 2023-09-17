// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GoldenBadgeLevelUp : Table {
  public static FB_GoldenBadgeLevelUp GetRootAsFB_GoldenBadgeLevelUp(ByteBuffer _bb) { return GetRootAsFB_GoldenBadgeLevelUp(_bb, new FB_GoldenBadgeLevelUp()); }
  public static FB_GoldenBadgeLevelUp GetRootAsFB_GoldenBadgeLevelUp(ByteBuffer _bb, FB_GoldenBadgeLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GoldenBadgeLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GoldenBadgeLevelUp> CreateFB_GoldenBadgeLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemId = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_GoldenBadgeLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_GoldenBadgeLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_GoldenBadgeLevelUp.AddCostItemCount(builder, CostItemCount);
    FB_GoldenBadgeLevelUp.AddCostItemId(builder, CostItemId);
    FB_GoldenBadgeLevelUp.AddId(builder, Id);
    return FB_GoldenBadgeLevelUp.EndFB_GoldenBadgeLevelUp(builder);
  }

  public static void StartFB_GoldenBadgeLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(2, CostItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GoldenBadgeLevelUp> EndFB_GoldenBadgeLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GoldenBadgeLevelUp>(o);
  }
};

public sealed class FB_GoldenBadgeLevelUpContainer : Table {
  public static FB_GoldenBadgeLevelUpContainer GetRootAsFB_GoldenBadgeLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_GoldenBadgeLevelUpContainer(_bb, new FB_GoldenBadgeLevelUpContainer()); }
  public static FB_GoldenBadgeLevelUpContainer GetRootAsFB_GoldenBadgeLevelUpContainer(ByteBuffer _bb, FB_GoldenBadgeLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GoldenBadgeLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GoldenBadgeLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GoldenBadgeLevelUp GetItems(int j) { return GetItems(new FB_GoldenBadgeLevelUp(), j); }
  public FB_GoldenBadgeLevelUp GetItems(FB_GoldenBadgeLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GoldenBadgeLevelUpContainer> CreateFB_GoldenBadgeLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GoldenBadgeLevelUpContainer.AddItems(builder, items);
    return FB_GoldenBadgeLevelUpContainer.EndFB_GoldenBadgeLevelUpContainer(builder);
  }

  public static void StartFB_GoldenBadgeLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GoldenBadgeLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GoldenBadgeLevelUpContainer> EndFB_GoldenBadgeLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GoldenBadgeLevelUpContainer>(o);
  }
  public static void FinishFB_GoldenBadgeLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_GoldenBadgeLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
