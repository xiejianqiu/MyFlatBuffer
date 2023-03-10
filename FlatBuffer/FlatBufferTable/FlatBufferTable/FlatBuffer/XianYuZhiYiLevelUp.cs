// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XianYuZhiYiLevelUp : Table {
  public static FB_XianYuZhiYiLevelUp GetRootAsFB_XianYuZhiYiLevelUp(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiLevelUp(_bb, new FB_XianYuZhiYiLevelUp()); }
  public static FB_XianYuZhiYiLevelUp GetRootAsFB_XianYuZhiYiLevelUp(ByteBuffer _bb, FB_XianYuZhiYiLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XianYuZhiYiLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostMoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostMoneyNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostCardScore { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int AttrAddition { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XianYuZhiYiLevelUp> CreateFB_XianYuZhiYiLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int CostMoneyType = -1,
      int CostMoneyNum = -1,
      int CostCardScore = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int AttrAddition = -1) {
    builder.StartObject(7);
    FB_XianYuZhiYiLevelUp.AddAttrAddition(builder, AttrAddition);
    FB_XianYuZhiYiLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_XianYuZhiYiLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_XianYuZhiYiLevelUp.AddCostCardScore(builder, CostCardScore);
    FB_XianYuZhiYiLevelUp.AddCostMoneyNum(builder, CostMoneyNum);
    FB_XianYuZhiYiLevelUp.AddCostMoneyType(builder, CostMoneyType);
    FB_XianYuZhiYiLevelUp.AddID(builder, ID);
    return FB_XianYuZhiYiLevelUp.EndFB_XianYuZhiYiLevelUp(builder);
  }

  public static void StartFB_XianYuZhiYiLevelUp(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCostMoneyType(FlatBufferBuilder builder, int CostMoneyType) { builder.AddInt(1, CostMoneyType, -1); }
  public static void AddCostMoneyNum(FlatBufferBuilder builder, int CostMoneyNum) { builder.AddInt(2, CostMoneyNum, -1); }
  public static void AddCostCardScore(FlatBufferBuilder builder, int CostCardScore) { builder.AddInt(3, CostCardScore, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrAddition(FlatBufferBuilder builder, int AttrAddition) { builder.AddInt(6, AttrAddition, -1); }
  public static Offset<FB_XianYuZhiYiLevelUp> EndFB_XianYuZhiYiLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiLevelUp>(o);
  }
};

public sealed class FB_XianYuZhiYiLevelUpContainer : Table {
  public static FB_XianYuZhiYiLevelUpContainer GetRootAsFB_XianYuZhiYiLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiLevelUpContainer(_bb, new FB_XianYuZhiYiLevelUpContainer()); }
  public static FB_XianYuZhiYiLevelUpContainer GetRootAsFB_XianYuZhiYiLevelUpContainer(ByteBuffer _bb, FB_XianYuZhiYiLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XianYuZhiYiLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XianYuZhiYiLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XianYuZhiYiLevelUp GetItems(int j) { return GetItems(new FB_XianYuZhiYiLevelUp(), j); }
  public FB_XianYuZhiYiLevelUp GetItems(FB_XianYuZhiYiLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XianYuZhiYiLevelUpContainer> CreateFB_XianYuZhiYiLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XianYuZhiYiLevelUpContainer.AddItems(builder, items);
    return FB_XianYuZhiYiLevelUpContainer.EndFB_XianYuZhiYiLevelUpContainer(builder);
  }

  public static void StartFB_XianYuZhiYiLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XianYuZhiYiLevelUpContainer> EndFB_XianYuZhiYiLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiLevelUpContainer>(o);
  }
  public static void FinishFB_XianYuZhiYiLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
