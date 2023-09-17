// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingWuHunLevelUp : Table {
  public static FB_JiLingWuHunLevelUp GetRootAsFB_JiLingWuHunLevelUp(ByteBuffer _bb) { return GetRootAsFB_JiLingWuHunLevelUp(_bb, new FB_JiLingWuHunLevelUp()); }
  public static FB_JiLingWuHunLevelUp GetRootAsFB_JiLingWuHunLevelUp(ByteBuffer _bb, FB_JiLingWuHunLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingWuHunLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Step { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string StepSprite { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CostType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RealityCostType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingWuHunLevelUp> CreateFB_JiLingWuHunLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int Step = 1,
      StringOffset StepSprite = default(StringOffset),
      int CostType = -1,
      int CostValue = -1,
      int RealityCostType = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_JiLingWuHunLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_JiLingWuHunLevelUp.AddAttrIDList(builder, AttrIDList);
    FB_JiLingWuHunLevelUp.AddRealityCostType(builder, RealityCostType);
    FB_JiLingWuHunLevelUp.AddCostValue(builder, CostValue);
    FB_JiLingWuHunLevelUp.AddCostType(builder, CostType);
    FB_JiLingWuHunLevelUp.AddStepSprite(builder, StepSprite);
    FB_JiLingWuHunLevelUp.AddStep(builder, Step);
    FB_JiLingWuHunLevelUp.AddId(builder, Id);
    return FB_JiLingWuHunLevelUp.EndFB_JiLingWuHunLevelUp(builder);
  }

  public static void StartFB_JiLingWuHunLevelUp(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(1, Step, 1); }
  public static void AddStepSprite(FlatBufferBuilder builder, StringOffset StepSpriteOffset) { builder.AddOffset(2, StepSpriteOffset.Value, 0); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(3, CostType, -1); }
  public static void AddCostValue(FlatBufferBuilder builder, int CostValue) { builder.AddInt(4, CostValue, -1); }
  public static void AddRealityCostType(FlatBufferBuilder builder, int RealityCostType) { builder.AddInt(5, RealityCostType, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(6, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(7, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingWuHunLevelUp> EndFB_JiLingWuHunLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingWuHunLevelUp>(o);
  }
};

public sealed class FB_JiLingWuHunLevelUpContainer : Table {
  public static FB_JiLingWuHunLevelUpContainer GetRootAsFB_JiLingWuHunLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingWuHunLevelUpContainer(_bb, new FB_JiLingWuHunLevelUpContainer()); }
  public static FB_JiLingWuHunLevelUpContainer GetRootAsFB_JiLingWuHunLevelUpContainer(ByteBuffer _bb, FB_JiLingWuHunLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingWuHunLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingWuHunLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingWuHunLevelUp GetItems(int j) { return GetItems(new FB_JiLingWuHunLevelUp(), j); }
  public FB_JiLingWuHunLevelUp GetItems(FB_JiLingWuHunLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingWuHunLevelUpContainer> CreateFB_JiLingWuHunLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingWuHunLevelUpContainer.AddItems(builder, items);
    return FB_JiLingWuHunLevelUpContainer.EndFB_JiLingWuHunLevelUpContainer(builder);
  }

  public static void StartFB_JiLingWuHunLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingWuHunLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingWuHunLevelUpContainer> EndFB_JiLingWuHunLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingWuHunLevelUpContainer>(o);
  }
  public static void FinishFB_JiLingWuHunLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingWuHunLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
