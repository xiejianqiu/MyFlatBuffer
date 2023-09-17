// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaPracticeLevelUp : Table {
  public static FB_ShenWangZhanJiaPracticeLevelUp GetRootAsFB_ShenWangZhanJiaPracticeLevelUp(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPracticeLevelUp(_bb, new FB_ShenWangZhanJiaPracticeLevelUp()); }
  public static FB_ShenWangZhanJiaPracticeLevelUp GetRootAsFB_ShenWangZhanJiaPracticeLevelUp(ByteBuffer _bb, FB_ShenWangZhanJiaPracticeLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaPracticeLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Exp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostPractice { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Practice { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLegendAttrIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LegendAttrIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLegendAttrValueList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LegendAttrValueListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaPracticeLevelUp> CreateFB_ShenWangZhanJiaPracticeLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int CostType = -1,
      int Exp = -1,
      int CostPractice = -1,
      int Practice = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset LegendAttrIdList = default(VectorOffset),
      VectorOffset LegendAttrValueList = default(VectorOffset)) {
    builder.StartObject(9);
    FB_ShenWangZhanJiaPracticeLevelUp.AddLegendAttrValueList(builder, LegendAttrValueList);
    FB_ShenWangZhanJiaPracticeLevelUp.AddLegendAttrIdList(builder, LegendAttrIdList);
    FB_ShenWangZhanJiaPracticeLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ShenWangZhanJiaPracticeLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_ShenWangZhanJiaPracticeLevelUp.AddPractice(builder, Practice);
    FB_ShenWangZhanJiaPracticeLevelUp.AddCostPractice(builder, CostPractice);
    FB_ShenWangZhanJiaPracticeLevelUp.AddExp(builder, Exp);
    FB_ShenWangZhanJiaPracticeLevelUp.AddCostType(builder, CostType);
    FB_ShenWangZhanJiaPracticeLevelUp.AddID(builder, ID);
    return FB_ShenWangZhanJiaPracticeLevelUp.EndFB_ShenWangZhanJiaPracticeLevelUp(builder);
  }

  public static void StartFB_ShenWangZhanJiaPracticeLevelUp(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(1, CostType, -1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(2, Exp, -1); }
  public static void AddCostPractice(FlatBufferBuilder builder, int CostPractice) { builder.AddInt(3, CostPractice, -1); }
  public static void AddPractice(FlatBufferBuilder builder, int Practice) { builder.AddInt(4, Practice, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(5, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLegendAttrIdList(FlatBufferBuilder builder, VectorOffset LegendAttrIdListOffset) { builder.AddOffset(7, LegendAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateLegendAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLegendAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLegendAttrValueList(FlatBufferBuilder builder, VectorOffset LegendAttrValueListOffset) { builder.AddOffset(8, LegendAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateLegendAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLegendAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaPracticeLevelUp> EndFB_ShenWangZhanJiaPracticeLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPracticeLevelUp>(o);
  }
};

public sealed class FB_ShenWangZhanJiaPracticeLevelUpContainer : Table {
  public static FB_ShenWangZhanJiaPracticeLevelUpContainer GetRootAsFB_ShenWangZhanJiaPracticeLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPracticeLevelUpContainer(_bb, new FB_ShenWangZhanJiaPracticeLevelUpContainer()); }
  public static FB_ShenWangZhanJiaPracticeLevelUpContainer GetRootAsFB_ShenWangZhanJiaPracticeLevelUpContainer(ByteBuffer _bb, FB_ShenWangZhanJiaPracticeLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaPracticeLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaPracticeLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaPracticeLevelUp GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaPracticeLevelUp(), j); }
  public FB_ShenWangZhanJiaPracticeLevelUp GetItems(FB_ShenWangZhanJiaPracticeLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaPracticeLevelUpContainer> CreateFB_ShenWangZhanJiaPracticeLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaPracticeLevelUpContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaPracticeLevelUpContainer.EndFB_ShenWangZhanJiaPracticeLevelUpContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaPracticeLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPracticeLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaPracticeLevelUpContainer> EndFB_ShenWangZhanJiaPracticeLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPracticeLevelUpContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaPracticeLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPracticeLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
