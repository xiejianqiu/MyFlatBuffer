// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingDestinyLevelUp : Table {
  public static FB_JiLingDestinyLevelUp GetRootAsFB_JiLingDestinyLevelUp(ByteBuffer _bb) { return GetRootAsFB_JiLingDestinyLevelUp(_bb, new FB_JiLingDestinyLevelUp()); }
  public static FB_JiLingDestinyLevelUp GetRootAsFB_JiLingDestinyLevelUp(ByteBuffer _bb, FB_JiLingDestinyLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingDestinyLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostValue { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingDestinyLevelUp> CreateFB_JiLingDestinyLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostType = -1,
      int CostValue = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_JiLingDestinyLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_JiLingDestinyLevelUp.AddAttrIDList(builder, AttrIDList);
    FB_JiLingDestinyLevelUp.AddCostValue(builder, CostValue);
    FB_JiLingDestinyLevelUp.AddCostType(builder, CostType);
    FB_JiLingDestinyLevelUp.AddId(builder, Id);
    return FB_JiLingDestinyLevelUp.EndFB_JiLingDestinyLevelUp(builder);
  }

  public static void StartFB_JiLingDestinyLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(1, CostType, -1); }
  public static void AddCostValue(FlatBufferBuilder builder, int CostValue) { builder.AddInt(2, CostValue, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(3, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingDestinyLevelUp> EndFB_JiLingDestinyLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingDestinyLevelUp>(o);
  }
};

public sealed class FB_JiLingDestinyLevelUpContainer : Table {
  public static FB_JiLingDestinyLevelUpContainer GetRootAsFB_JiLingDestinyLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingDestinyLevelUpContainer(_bb, new FB_JiLingDestinyLevelUpContainer()); }
  public static FB_JiLingDestinyLevelUpContainer GetRootAsFB_JiLingDestinyLevelUpContainer(ByteBuffer _bb, FB_JiLingDestinyLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingDestinyLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingDestinyLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingDestinyLevelUp GetItems(int j) { return GetItems(new FB_JiLingDestinyLevelUp(), j); }
  public FB_JiLingDestinyLevelUp GetItems(FB_JiLingDestinyLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingDestinyLevelUpContainer> CreateFB_JiLingDestinyLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingDestinyLevelUpContainer.AddItems(builder, items);
    return FB_JiLingDestinyLevelUpContainer.EndFB_JiLingDestinyLevelUpContainer(builder);
  }

  public static void StartFB_JiLingDestinyLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingDestinyLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingDestinyLevelUpContainer> EndFB_JiLingDestinyLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingDestinyLevelUpContainer>(o);
  }
  public static void FinishFB_JiLingDestinyLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingDestinyLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
