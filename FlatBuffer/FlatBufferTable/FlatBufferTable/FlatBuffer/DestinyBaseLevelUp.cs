// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyBaseLevelUp : Table {
  public static FB_DestinyBaseLevelUp GetRootAsFB_DestinyBaseLevelUp(ByteBuffer _bb) { return GetRootAsFB_DestinyBaseLevelUp(_bb, new FB_DestinyBaseLevelUp()); }
  public static FB_DestinyBaseLevelUp GetRootAsFB_DestinyBaseLevelUp(ByteBuffer _bb, FB_DestinyBaseLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyBaseLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetCostItemIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostItemCountList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemCountListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBaseLevelUp> CreateFB_DestinyBaseLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset CostItemIdList = default(VectorOffset),
      VectorOffset CostItemCountList = default(VectorOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_DestinyBaseLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_DestinyBaseLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_DestinyBaseLevelUp.AddCostItemCountList(builder, CostItemCountList);
    FB_DestinyBaseLevelUp.AddCostItemIdList(builder, CostItemIdList);
    FB_DestinyBaseLevelUp.AddId(builder, Id);
    return FB_DestinyBaseLevelUp.EndFB_DestinyBaseLevelUp(builder);
  }

  public static void StartFB_DestinyBaseLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemIdList(FlatBufferBuilder builder, VectorOffset CostItemIdListOffset) { builder.AddOffset(1, CostItemIdListOffset.Value, 0); }
  public static VectorOffset CreateCostItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostItemCountList(FlatBufferBuilder builder, VectorOffset CostItemCountListOffset) { builder.AddOffset(2, CostItemCountListOffset.Value, 0); }
  public static VectorOffset CreateCostItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBaseLevelUp> EndFB_DestinyBaseLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBaseLevelUp>(o);
  }
};

public sealed class FB_DestinyBaseLevelUpContainer : Table {
  public static FB_DestinyBaseLevelUpContainer GetRootAsFB_DestinyBaseLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyBaseLevelUpContainer(_bb, new FB_DestinyBaseLevelUpContainer()); }
  public static FB_DestinyBaseLevelUpContainer GetRootAsFB_DestinyBaseLevelUpContainer(ByteBuffer _bb, FB_DestinyBaseLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyBaseLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyBaseLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyBaseLevelUp GetItems(int j) { return GetItems(new FB_DestinyBaseLevelUp(), j); }
  public FB_DestinyBaseLevelUp GetItems(FB_DestinyBaseLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBaseLevelUpContainer> CreateFB_DestinyBaseLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyBaseLevelUpContainer.AddItems(builder, items);
    return FB_DestinyBaseLevelUpContainer.EndFB_DestinyBaseLevelUpContainer(builder);
  }

  public static void StartFB_DestinyBaseLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyBaseLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBaseLevelUpContainer> EndFB_DestinyBaseLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBaseLevelUpContainer>(o);
  }
  public static void FinishFB_DestinyBaseLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyBaseLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
