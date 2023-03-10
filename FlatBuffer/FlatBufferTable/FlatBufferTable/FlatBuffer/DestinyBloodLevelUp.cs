// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyBloodLevelUp : Table {
  public static FB_DestinyBloodLevelUp GetRootAsFB_DestinyBloodLevelUp(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodLevelUp(_bb, new FB_DestinyBloodLevelUp()); }
  public static FB_DestinyBloodLevelUp GetRootAsFB_DestinyBloodLevelUp(ByteBuffer _bb, FB_DestinyBloodLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyBloodLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BreakThrough { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBloodLevelUp> CreateFB_DestinyBloodLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int BreakThrough = -1,
      int CostItemId = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_DestinyBloodLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_DestinyBloodLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_DestinyBloodLevelUp.AddCostItemCount(builder, CostItemCount);
    FB_DestinyBloodLevelUp.AddCostItemId(builder, CostItemId);
    FB_DestinyBloodLevelUp.AddBreakThrough(builder, BreakThrough);
    FB_DestinyBloodLevelUp.AddId(builder, Id);
    return FB_DestinyBloodLevelUp.EndFB_DestinyBloodLevelUp(builder);
  }

  public static void StartFB_DestinyBloodLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
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
  public static Offset<FB_DestinyBloodLevelUp> EndFB_DestinyBloodLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodLevelUp>(o);
  }
};

public sealed class FB_DestinyBloodLevelUpContainer : Table {
  public static FB_DestinyBloodLevelUpContainer GetRootAsFB_DestinyBloodLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodLevelUpContainer(_bb, new FB_DestinyBloodLevelUpContainer()); }
  public static FB_DestinyBloodLevelUpContainer GetRootAsFB_DestinyBloodLevelUpContainer(ByteBuffer _bb, FB_DestinyBloodLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyBloodLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyBloodLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyBloodLevelUp GetItems(int j) { return GetItems(new FB_DestinyBloodLevelUp(), j); }
  public FB_DestinyBloodLevelUp GetItems(FB_DestinyBloodLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBloodLevelUpContainer> CreateFB_DestinyBloodLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyBloodLevelUpContainer.AddItems(builder, items);
    return FB_DestinyBloodLevelUpContainer.EndFB_DestinyBloodLevelUpContainer(builder);
  }

  public static void StartFB_DestinyBloodLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyBloodLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBloodLevelUpContainer> EndFB_DestinyBloodLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodLevelUpContainer>(o);
  }
  public static void FinishFB_DestinyBloodLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyBloodLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
