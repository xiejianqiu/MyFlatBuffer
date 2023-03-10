// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingAttrPercentLevelUp : Table {
  public static FB_JiLingAttrPercentLevelUp GetRootAsFB_JiLingAttrPercentLevelUp(ByteBuffer _bb) { return GetRootAsFB_JiLingAttrPercentLevelUp(_bb, new FB_JiLingAttrPercentLevelUp()); }
  public static FB_JiLingAttrPercentLevelUp GetRootAsFB_JiLingAttrPercentLevelUp(ByteBuffer _bb, FB_JiLingAttrPercentLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingAttrPercentLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddAttrPercent { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_JiLingAttrPercentLevelUp> CreateFB_JiLingAttrPercentLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemId = -1,
      int CostItemNum = -1,
      int AttrId = -1,
      int AddAttrPercent = 0) {
    builder.StartObject(5);
    FB_JiLingAttrPercentLevelUp.AddAddAttrPercent(builder, AddAttrPercent);
    FB_JiLingAttrPercentLevelUp.AddAttrId(builder, AttrId);
    FB_JiLingAttrPercentLevelUp.AddCostItemNum(builder, CostItemNum);
    FB_JiLingAttrPercentLevelUp.AddCostItemId(builder, CostItemId);
    FB_JiLingAttrPercentLevelUp.AddId(builder, Id);
    return FB_JiLingAttrPercentLevelUp.EndFB_JiLingAttrPercentLevelUp(builder);
  }

  public static void StartFB_JiLingAttrPercentLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(2, CostItemNum, -1); }
  public static void AddAttrId(FlatBufferBuilder builder, int AttrId) { builder.AddInt(3, AttrId, -1); }
  public static void AddAddAttrPercent(FlatBufferBuilder builder, int AddAttrPercent) { builder.AddInt(4, AddAttrPercent, 0); }
  public static Offset<FB_JiLingAttrPercentLevelUp> EndFB_JiLingAttrPercentLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingAttrPercentLevelUp>(o);
  }
};

public sealed class FB_JiLingAttrPercentLevelUpContainer : Table {
  public static FB_JiLingAttrPercentLevelUpContainer GetRootAsFB_JiLingAttrPercentLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingAttrPercentLevelUpContainer(_bb, new FB_JiLingAttrPercentLevelUpContainer()); }
  public static FB_JiLingAttrPercentLevelUpContainer GetRootAsFB_JiLingAttrPercentLevelUpContainer(ByteBuffer _bb, FB_JiLingAttrPercentLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingAttrPercentLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingAttrPercentLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingAttrPercentLevelUp GetItems(int j) { return GetItems(new FB_JiLingAttrPercentLevelUp(), j); }
  public FB_JiLingAttrPercentLevelUp GetItems(FB_JiLingAttrPercentLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingAttrPercentLevelUpContainer> CreateFB_JiLingAttrPercentLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingAttrPercentLevelUpContainer.AddItems(builder, items);
    return FB_JiLingAttrPercentLevelUpContainer.EndFB_JiLingAttrPercentLevelUpContainer(builder);
  }

  public static void StartFB_JiLingAttrPercentLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingAttrPercentLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingAttrPercentLevelUpContainer> EndFB_JiLingAttrPercentLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingAttrPercentLevelUpContainer>(o);
  }
  public static void FinishFB_JiLingAttrPercentLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingAttrPercentLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
