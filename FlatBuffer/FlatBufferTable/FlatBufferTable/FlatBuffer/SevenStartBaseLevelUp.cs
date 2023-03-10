// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SevenStartBaseLevelUp : Table {
  public static FB_SevenStartBaseLevelUp GetRootAsFB_SevenStartBaseLevelUp(ByteBuffer _bb) { return GetRootAsFB_SevenStartBaseLevelUp(_bb, new FB_SevenStartBaseLevelUp()); }
  public static FB_SevenStartBaseLevelUp GetRootAsFB_SevenStartBaseLevelUp(ByteBuffer _bb, FB_SevenStartBaseLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SevenStartBaseLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SevenStartBaseLevelUp> CreateFB_SevenStartBaseLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemId = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_SevenStartBaseLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_SevenStartBaseLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_SevenStartBaseLevelUp.AddCostItemCount(builder, CostItemCount);
    FB_SevenStartBaseLevelUp.AddCostItemId(builder, CostItemId);
    FB_SevenStartBaseLevelUp.AddId(builder, Id);
    return FB_SevenStartBaseLevelUp.EndFB_SevenStartBaseLevelUp(builder);
  }

  public static void StartFB_SevenStartBaseLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(2, CostItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SevenStartBaseLevelUp> EndFB_SevenStartBaseLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SevenStartBaseLevelUp>(o);
  }
};

public sealed class FB_SevenStartBaseLevelUpContainer : Table {
  public static FB_SevenStartBaseLevelUpContainer GetRootAsFB_SevenStartBaseLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_SevenStartBaseLevelUpContainer(_bb, new FB_SevenStartBaseLevelUpContainer()); }
  public static FB_SevenStartBaseLevelUpContainer GetRootAsFB_SevenStartBaseLevelUpContainer(ByteBuffer _bb, FB_SevenStartBaseLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SevenStartBaseLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SevenStartBaseLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SevenStartBaseLevelUp GetItems(int j) { return GetItems(new FB_SevenStartBaseLevelUp(), j); }
  public FB_SevenStartBaseLevelUp GetItems(FB_SevenStartBaseLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SevenStartBaseLevelUpContainer> CreateFB_SevenStartBaseLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SevenStartBaseLevelUpContainer.AddItems(builder, items);
    return FB_SevenStartBaseLevelUpContainer.EndFB_SevenStartBaseLevelUpContainer(builder);
  }

  public static void StartFB_SevenStartBaseLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SevenStartBaseLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SevenStartBaseLevelUpContainer> EndFB_SevenStartBaseLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SevenStartBaseLevelUpContainer>(o);
  }
  public static void FinishFB_SevenStartBaseLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_SevenStartBaseLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
