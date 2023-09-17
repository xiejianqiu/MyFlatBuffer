// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_QianKunDuoBaoBase : Table {
  public static FB_QianKunDuoBaoBase GetRootAsFB_QianKunDuoBaoBase(ByteBuffer _bb) { return GetRootAsFB_QianKunDuoBaoBase(_bb, new FB_QianKunDuoBaoBase()); }
  public static FB_QianKunDuoBaoBase GetRootAsFB_QianKunDuoBaoBase(ByteBuffer _bb, FB_QianKunDuoBaoBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_QianKunDuoBaoBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActStartTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActIntegralEndTime { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActEndTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Integral { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HisRecordMaxNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewItemListList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewItemListListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewItemNumList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewItemNumListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int MenPai { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_QianKunDuoBaoBase> CreateFB_QianKunDuoBaoBase(FlatBufferBuilder builder,
      int ID = 0,
      int ActStartTime = -1,
      int ActIntegralEndTime = -1,
      int ActEndTime = -1,
      int LimitLevel = -1,
      int Integral = -1,
      int HisRecordMaxNum = -1,
      VectorOffset RewItemListList = default(VectorOffset),
      VectorOffset RewItemNumList = default(VectorOffset),
      VectorOffset WeightList = default(VectorOffset),
      int MenPai = -1) {
    builder.StartObject(11);
    FB_QianKunDuoBaoBase.AddMenPai(builder, MenPai);
    FB_QianKunDuoBaoBase.AddWeightList(builder, WeightList);
    FB_QianKunDuoBaoBase.AddRewItemNumList(builder, RewItemNumList);
    FB_QianKunDuoBaoBase.AddRewItemListList(builder, RewItemListList);
    FB_QianKunDuoBaoBase.AddHisRecordMaxNum(builder, HisRecordMaxNum);
    FB_QianKunDuoBaoBase.AddIntegral(builder, Integral);
    FB_QianKunDuoBaoBase.AddLimitLevel(builder, LimitLevel);
    FB_QianKunDuoBaoBase.AddActEndTime(builder, ActEndTime);
    FB_QianKunDuoBaoBase.AddActIntegralEndTime(builder, ActIntegralEndTime);
    FB_QianKunDuoBaoBase.AddActStartTime(builder, ActStartTime);
    FB_QianKunDuoBaoBase.AddID(builder, ID);
    return FB_QianKunDuoBaoBase.EndFB_QianKunDuoBaoBase(builder);
  }

  public static void StartFB_QianKunDuoBaoBase(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActStartTime(FlatBufferBuilder builder, int ActStartTime) { builder.AddInt(1, ActStartTime, -1); }
  public static void AddActIntegralEndTime(FlatBufferBuilder builder, int ActIntegralEndTime) { builder.AddInt(2, ActIntegralEndTime, -1); }
  public static void AddActEndTime(FlatBufferBuilder builder, int ActEndTime) { builder.AddInt(3, ActEndTime, -1); }
  public static void AddLimitLevel(FlatBufferBuilder builder, int LimitLevel) { builder.AddInt(4, LimitLevel, -1); }
  public static void AddIntegral(FlatBufferBuilder builder, int Integral) { builder.AddInt(5, Integral, -1); }
  public static void AddHisRecordMaxNum(FlatBufferBuilder builder, int HisRecordMaxNum) { builder.AddInt(6, HisRecordMaxNum, -1); }
  public static void AddRewItemListList(FlatBufferBuilder builder, VectorOffset RewItemListListOffset) { builder.AddOffset(7, RewItemListListOffset.Value, 0); }
  public static VectorOffset CreateRewItemListListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewItemListListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewItemNumList(FlatBufferBuilder builder, VectorOffset RewItemNumListOffset) { builder.AddOffset(8, RewItemNumListOffset.Value, 0); }
  public static VectorOffset CreateRewItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(9, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(10, MenPai, -1); }
  public static Offset<FB_QianKunDuoBaoBase> EndFB_QianKunDuoBaoBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_QianKunDuoBaoBase>(o);
  }
};

public sealed class FB_QianKunDuoBaoBaseContainer : Table {
  public static FB_QianKunDuoBaoBaseContainer GetRootAsFB_QianKunDuoBaoBaseContainer(ByteBuffer _bb) { return GetRootAsFB_QianKunDuoBaoBaseContainer(_bb, new FB_QianKunDuoBaoBaseContainer()); }
  public static FB_QianKunDuoBaoBaseContainer GetRootAsFB_QianKunDuoBaoBaseContainer(ByteBuffer _bb, FB_QianKunDuoBaoBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_QianKunDuoBaoBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_QianKunDuoBaoBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_QianKunDuoBaoBase GetItems(int j) { return GetItems(new FB_QianKunDuoBaoBase(), j); }
  public FB_QianKunDuoBaoBase GetItems(FB_QianKunDuoBaoBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_QianKunDuoBaoBaseContainer> CreateFB_QianKunDuoBaoBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_QianKunDuoBaoBaseContainer.AddItems(builder, items);
    return FB_QianKunDuoBaoBaseContainer.EndFB_QianKunDuoBaoBaseContainer(builder);
  }

  public static void StartFB_QianKunDuoBaoBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_QianKunDuoBaoBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_QianKunDuoBaoBaseContainer> EndFB_QianKunDuoBaoBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_QianKunDuoBaoBaseContainer>(o);
  }
  public static void FinishFB_QianKunDuoBaoBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_QianKunDuoBaoBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
