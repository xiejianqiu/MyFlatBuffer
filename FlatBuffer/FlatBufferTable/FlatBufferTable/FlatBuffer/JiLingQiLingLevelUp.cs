// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingQiLingLevelUp : Table {
  public static FB_JiLingQiLingLevelUp GetRootAsFB_JiLingQiLingLevelUp(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingLevelUp(_bb, new FB_JiLingQiLingLevelUp()); }
  public static FB_JiLingQiLingLevelUp GetRootAsFB_JiLingQiLingLevelUp(ByteBuffer _bb, FB_JiLingQiLingLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingQiLingLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Step { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int CostType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostValue { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingQiLingLevelUp> CreateFB_JiLingQiLingLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int Step = 1,
      int CostType = -1,
      int CostValue = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_JiLingQiLingLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_JiLingQiLingLevelUp.AddAttrIDList(builder, AttrIDList);
    FB_JiLingQiLingLevelUp.AddCostValue(builder, CostValue);
    FB_JiLingQiLingLevelUp.AddCostType(builder, CostType);
    FB_JiLingQiLingLevelUp.AddStep(builder, Step);
    FB_JiLingQiLingLevelUp.AddId(builder, Id);
    return FB_JiLingQiLingLevelUp.EndFB_JiLingQiLingLevelUp(builder);
  }

  public static void StartFB_JiLingQiLingLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(1, Step, 1); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(2, CostType, -1); }
  public static void AddCostValue(FlatBufferBuilder builder, int CostValue) { builder.AddInt(3, CostValue, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(4, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingQiLingLevelUp> EndFB_JiLingQiLingLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingLevelUp>(o);
  }
};

public sealed class FB_JiLingQiLingLevelUpContainer : Table {
  public static FB_JiLingQiLingLevelUpContainer GetRootAsFB_JiLingQiLingLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingLevelUpContainer(_bb, new FB_JiLingQiLingLevelUpContainer()); }
  public static FB_JiLingQiLingLevelUpContainer GetRootAsFB_JiLingQiLingLevelUpContainer(ByteBuffer _bb, FB_JiLingQiLingLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingQiLingLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingQiLingLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingQiLingLevelUp GetItems(int j) { return GetItems(new FB_JiLingQiLingLevelUp(), j); }
  public FB_JiLingQiLingLevelUp GetItems(FB_JiLingQiLingLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingQiLingLevelUpContainer> CreateFB_JiLingQiLingLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingQiLingLevelUpContainer.AddItems(builder, items);
    return FB_JiLingQiLingLevelUpContainer.EndFB_JiLingQiLingLevelUpContainer(builder);
  }

  public static void StartFB_JiLingQiLingLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingQiLingLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingQiLingLevelUpContainer> EndFB_JiLingQiLingLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingLevelUpContainer>(o);
  }
  public static void FinishFB_JiLingQiLingLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingQiLingLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
