// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ArtifactBaseLevelUp : Table {
  public static FB_ArtifactBaseLevelUp GetRootAsFB_ArtifactBaseLevelUp(ByteBuffer _bb) { return GetRootAsFB_ArtifactBaseLevelUp(_bb, new FB_ArtifactBaseLevelUp()); }
  public static FB_ArtifactBaseLevelUp GetRootAsFB_ArtifactBaseLevelUp(ByteBuffer _bb, FB_ArtifactBaseLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ArtifactBaseLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ArtifactBaseLevelUp> CreateFB_ArtifactBaseLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemId = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ArtifactBaseLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ArtifactBaseLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_ArtifactBaseLevelUp.AddCostItemCount(builder, CostItemCount);
    FB_ArtifactBaseLevelUp.AddCostItemId(builder, CostItemId);
    FB_ArtifactBaseLevelUp.AddId(builder, Id);
    return FB_ArtifactBaseLevelUp.EndFB_ArtifactBaseLevelUp(builder);
  }

  public static void StartFB_ArtifactBaseLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(2, CostItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ArtifactBaseLevelUp> EndFB_ArtifactBaseLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArtifactBaseLevelUp>(o);
  }
};

public sealed class FB_ArtifactBaseLevelUpContainer : Table {
  public static FB_ArtifactBaseLevelUpContainer GetRootAsFB_ArtifactBaseLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ArtifactBaseLevelUpContainer(_bb, new FB_ArtifactBaseLevelUpContainer()); }
  public static FB_ArtifactBaseLevelUpContainer GetRootAsFB_ArtifactBaseLevelUpContainer(ByteBuffer _bb, FB_ArtifactBaseLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ArtifactBaseLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ArtifactBaseLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ArtifactBaseLevelUp GetItems(int j) { return GetItems(new FB_ArtifactBaseLevelUp(), j); }
  public FB_ArtifactBaseLevelUp GetItems(FB_ArtifactBaseLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ArtifactBaseLevelUpContainer> CreateFB_ArtifactBaseLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ArtifactBaseLevelUpContainer.AddItems(builder, items);
    return FB_ArtifactBaseLevelUpContainer.EndFB_ArtifactBaseLevelUpContainer(builder);
  }

  public static void StartFB_ArtifactBaseLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ArtifactBaseLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ArtifactBaseLevelUpContainer> EndFB_ArtifactBaseLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArtifactBaseLevelUpContainer>(o);
  }
  public static void FinishFB_ArtifactBaseLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ArtifactBaseLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
