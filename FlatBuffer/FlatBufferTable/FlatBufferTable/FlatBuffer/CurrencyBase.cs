// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CurrencyBase : Table {
  public static FB_CurrencyBase GetRootAsFB_CurrencyBase(ByteBuffer _bb) { return GetRootAsFB_CurrencyBase(_bb, new FB_CurrencyBase()); }
  public static FB_CurrencyBase GetRootAsFB_CurrencyBase(ByteBuffer _bb, FB_CurrencyBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CurrencyBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string IconPath { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LimitType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Limit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EveryLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TimeDataID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NumberDataID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DictID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TargetType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetTargetParamList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TargetParamListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int UnlockType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockParam { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CurrencyBase> CreateFB_CurrencyBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset IconPath = default(StringOffset),
      int LimitType = -1,
      int Limit = -1,
      int EveryLimit = -1,
      int TimeDataID = -1,
      int NumberDataID = -1,
      int DictID = -1,
      int TargetType = -1,
      VectorOffset TargetParamList = default(VectorOffset),
      int UnlockType = -1,
      int UnlockParam = -1) {
    builder.StartObject(13);
    FB_CurrencyBase.AddUnlockParam(builder, UnlockParam);
    FB_CurrencyBase.AddUnlockType(builder, UnlockType);
    FB_CurrencyBase.AddTargetParamList(builder, TargetParamList);
    FB_CurrencyBase.AddTargetType(builder, TargetType);
    FB_CurrencyBase.AddDictID(builder, DictID);
    FB_CurrencyBase.AddNumberDataID(builder, NumberDataID);
    FB_CurrencyBase.AddTimeDataID(builder, TimeDataID);
    FB_CurrencyBase.AddEveryLimit(builder, EveryLimit);
    FB_CurrencyBase.AddLimit(builder, Limit);
    FB_CurrencyBase.AddLimitType(builder, LimitType);
    FB_CurrencyBase.AddIconPath(builder, IconPath);
    FB_CurrencyBase.AddName(builder, Name);
    FB_CurrencyBase.AddID(builder, ID);
    return FB_CurrencyBase.EndFB_CurrencyBase(builder);
  }

  public static void StartFB_CurrencyBase(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(2, IconPathOffset.Value, 0); }
  public static void AddLimitType(FlatBufferBuilder builder, int LimitType) { builder.AddInt(3, LimitType, -1); }
  public static void AddLimit(FlatBufferBuilder builder, int Limit) { builder.AddInt(4, Limit, -1); }
  public static void AddEveryLimit(FlatBufferBuilder builder, int EveryLimit) { builder.AddInt(5, EveryLimit, -1); }
  public static void AddTimeDataID(FlatBufferBuilder builder, int TimeDataID) { builder.AddInt(6, TimeDataID, -1); }
  public static void AddNumberDataID(FlatBufferBuilder builder, int NumberDataID) { builder.AddInt(7, NumberDataID, -1); }
  public static void AddDictID(FlatBufferBuilder builder, int DictID) { builder.AddInt(8, DictID, -1); }
  public static void AddTargetType(FlatBufferBuilder builder, int TargetType) { builder.AddInt(9, TargetType, -1); }
  public static void AddTargetParamList(FlatBufferBuilder builder, VectorOffset TargetParamListOffset) { builder.AddOffset(10, TargetParamListOffset.Value, 0); }
  public static VectorOffset CreateTargetParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTargetParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(11, UnlockType, -1); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(12, UnlockParam, -1); }
  public static Offset<FB_CurrencyBase> EndFB_CurrencyBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CurrencyBase>(o);
  }
};

public sealed class FB_CurrencyBaseContainer : Table {
  public static FB_CurrencyBaseContainer GetRootAsFB_CurrencyBaseContainer(ByteBuffer _bb) { return GetRootAsFB_CurrencyBaseContainer(_bb, new FB_CurrencyBaseContainer()); }
  public static FB_CurrencyBaseContainer GetRootAsFB_CurrencyBaseContainer(ByteBuffer _bb, FB_CurrencyBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CurrencyBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CurrencyBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CurrencyBase GetItems(int j) { return GetItems(new FB_CurrencyBase(), j); }
  public FB_CurrencyBase GetItems(FB_CurrencyBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CurrencyBaseContainer> CreateFB_CurrencyBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CurrencyBaseContainer.AddItems(builder, items);
    return FB_CurrencyBaseContainer.EndFB_CurrencyBaseContainer(builder);
  }

  public static void StartFB_CurrencyBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CurrencyBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CurrencyBaseContainer> EndFB_CurrencyBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CurrencyBaseContainer>(o);
  }
  public static void FinishFB_CurrencyBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_CurrencyBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
