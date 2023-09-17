// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaMakeLevelUp : Table {
  public static FB_ShenWangZhanJiaMakeLevelUp GetRootAsFB_ShenWangZhanJiaMakeLevelUp(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaMakeLevelUp(_bb, new FB_ShenWangZhanJiaMakeLevelUp()); }
  public static FB_ShenWangZhanJiaMakeLevelUp GetRootAsFB_ShenWangZhanJiaMakeLevelUp(ByteBuffer _bb, FB_ShenWangZhanJiaMakeLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaMakeLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostMakeExp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MakeExp { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaMakeLevelUp> CreateFB_ShenWangZhanJiaMakeLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int Exp = -1,
      int CostMakeExp = -1,
      int MakeExp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_ShenWangZhanJiaMakeLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ShenWangZhanJiaMakeLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_ShenWangZhanJiaMakeLevelUp.AddMakeExp(builder, MakeExp);
    FB_ShenWangZhanJiaMakeLevelUp.AddCostMakeExp(builder, CostMakeExp);
    FB_ShenWangZhanJiaMakeLevelUp.AddExp(builder, Exp);
    FB_ShenWangZhanJiaMakeLevelUp.AddID(builder, ID);
    return FB_ShenWangZhanJiaMakeLevelUp.EndFB_ShenWangZhanJiaMakeLevelUp(builder);
  }

  public static void StartFB_ShenWangZhanJiaMakeLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, -1); }
  public static void AddCostMakeExp(FlatBufferBuilder builder, int CostMakeExp) { builder.AddInt(2, CostMakeExp, -1); }
  public static void AddMakeExp(FlatBufferBuilder builder, int MakeExp) { builder.AddInt(3, MakeExp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaMakeLevelUp> EndFB_ShenWangZhanJiaMakeLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaMakeLevelUp>(o);
  }
};

public sealed class FB_ShenWangZhanJiaMakeLevelUpContainer : Table {
  public static FB_ShenWangZhanJiaMakeLevelUpContainer GetRootAsFB_ShenWangZhanJiaMakeLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaMakeLevelUpContainer(_bb, new FB_ShenWangZhanJiaMakeLevelUpContainer()); }
  public static FB_ShenWangZhanJiaMakeLevelUpContainer GetRootAsFB_ShenWangZhanJiaMakeLevelUpContainer(ByteBuffer _bb, FB_ShenWangZhanJiaMakeLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaMakeLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaMakeLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaMakeLevelUp GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaMakeLevelUp(), j); }
  public FB_ShenWangZhanJiaMakeLevelUp GetItems(FB_ShenWangZhanJiaMakeLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaMakeLevelUpContainer> CreateFB_ShenWangZhanJiaMakeLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaMakeLevelUpContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaMakeLevelUpContainer.EndFB_ShenWangZhanJiaMakeLevelUpContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaMakeLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaMakeLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaMakeLevelUpContainer> EndFB_ShenWangZhanJiaMakeLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaMakeLevelUpContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaMakeLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaMakeLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
