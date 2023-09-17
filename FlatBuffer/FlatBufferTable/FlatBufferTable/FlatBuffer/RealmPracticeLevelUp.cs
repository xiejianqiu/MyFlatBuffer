// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RealmPracticeLevelUp : Table {
  public static FB_RealmPracticeLevelUp GetRootAsFB_RealmPracticeLevelUp(ByteBuffer _bb) { return GetRootAsFB_RealmPracticeLevelUp(_bb, new FB_RealmPracticeLevelUp()); }
  public static FB_RealmPracticeLevelUp GetRootAsFB_RealmPracticeLevelUp(ByteBuffer _bb, FB_RealmPracticeLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RealmPracticeLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BreakThrough { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RealmPracticeLevelUp> CreateFB_RealmPracticeLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int BreakThrough = -1,
      int CostItemId = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_RealmPracticeLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_RealmPracticeLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_RealmPracticeLevelUp.AddCostItemCount(builder, CostItemCount);
    FB_RealmPracticeLevelUp.AddCostItemId(builder, CostItemId);
    FB_RealmPracticeLevelUp.AddBreakThrough(builder, BreakThrough);
    FB_RealmPracticeLevelUp.AddId(builder, Id);
    return FB_RealmPracticeLevelUp.EndFB_RealmPracticeLevelUp(builder);
  }

  public static void StartFB_RealmPracticeLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddBreakThrough(FlatBufferBuilder builder, int BreakThrough) { builder.AddInt(1, BreakThrough, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(2, CostItemId, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(3, CostItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RealmPracticeLevelUp> EndFB_RealmPracticeLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RealmPracticeLevelUp>(o);
  }
};

public sealed class FB_RealmPracticeLevelUpContainer : Table {
  public static FB_RealmPracticeLevelUpContainer GetRootAsFB_RealmPracticeLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_RealmPracticeLevelUpContainer(_bb, new FB_RealmPracticeLevelUpContainer()); }
  public static FB_RealmPracticeLevelUpContainer GetRootAsFB_RealmPracticeLevelUpContainer(ByteBuffer _bb, FB_RealmPracticeLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RealmPracticeLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RealmPracticeLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RealmPracticeLevelUp GetItems(int j) { return GetItems(new FB_RealmPracticeLevelUp(), j); }
  public FB_RealmPracticeLevelUp GetItems(FB_RealmPracticeLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RealmPracticeLevelUpContainer> CreateFB_RealmPracticeLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RealmPracticeLevelUpContainer.AddItems(builder, items);
    return FB_RealmPracticeLevelUpContainer.EndFB_RealmPracticeLevelUpContainer(builder);
  }

  public static void StartFB_RealmPracticeLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RealmPracticeLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RealmPracticeLevelUpContainer> EndFB_RealmPracticeLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RealmPracticeLevelUpContainer>(o);
  }
  public static void FinishFB_RealmPracticeLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_RealmPracticeLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
