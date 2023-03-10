// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OperationActivityGift : Table {
  public static FB_OperationActivityGift GetRootAsFB_OperationActivityGift(ByteBuffer _bb) { return GetRootAsFB_OperationActivityGift(_bb, new FB_OperationActivityGift()); }
  public static FB_OperationActivityGift GetRootAsFB_OperationActivityGift(ByteBuffer _bb, FB_OperationActivityGift obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OperationActivityGift __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetGiftJobIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GiftJobIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GiftJobNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetTwoGiftJobIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TwoGiftJobIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int TwoGiftJobNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetGiftTypeList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GiftTypeListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetGiftIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GiftIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetGiftNumList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GiftNumListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int NumLimit { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsBanding { get { int o = __offset(26); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GiftLevel { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_OperationActivityGift> CreateFB_OperationActivityGift(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      int Param = -1,
      VectorOffset GiftJobIDList = default(VectorOffset),
      int GiftJobNum = -1,
      VectorOffset TwoGiftJobIdList = default(VectorOffset),
      int TwoGiftJobNum = -1,
      VectorOffset GiftTypeList = default(VectorOffset),
      VectorOffset GiftIDList = default(VectorOffset),
      VectorOffset GiftNumList = default(VectorOffset),
      int NumLimit = -1,
      bool IsBanding = false,
      int GiftLevel = -1) {
    builder.StartObject(13);
    FB_OperationActivityGift.AddGiftLevel(builder, GiftLevel);
    FB_OperationActivityGift.AddNumLimit(builder, NumLimit);
    FB_OperationActivityGift.AddGiftNumList(builder, GiftNumList);
    FB_OperationActivityGift.AddGiftIDList(builder, GiftIDList);
    FB_OperationActivityGift.AddGiftTypeList(builder, GiftTypeList);
    FB_OperationActivityGift.AddTwoGiftJobNum(builder, TwoGiftJobNum);
    FB_OperationActivityGift.AddTwoGiftJobIdList(builder, TwoGiftJobIdList);
    FB_OperationActivityGift.AddGiftJobNum(builder, GiftJobNum);
    FB_OperationActivityGift.AddGiftJobIDList(builder, GiftJobIDList);
    FB_OperationActivityGift.AddParam(builder, Param);
    FB_OperationActivityGift.AddType(builder, Type);
    FB_OperationActivityGift.AddID(builder, ID);
    FB_OperationActivityGift.AddIsBanding(builder, IsBanding);
    return FB_OperationActivityGift.EndFB_OperationActivityGift(builder);
  }

  public static void StartFB_OperationActivityGift(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(2, Param, -1); }
  public static void AddGiftJobIDList(FlatBufferBuilder builder, VectorOffset GiftJobIDListOffset) { builder.AddOffset(3, GiftJobIDListOffset.Value, 0); }
  public static VectorOffset CreateGiftJobIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGiftJobIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGiftJobNum(FlatBufferBuilder builder, int GiftJobNum) { builder.AddInt(4, GiftJobNum, -1); }
  public static void AddTwoGiftJobIdList(FlatBufferBuilder builder, VectorOffset TwoGiftJobIdListOffset) { builder.AddOffset(5, TwoGiftJobIdListOffset.Value, 0); }
  public static VectorOffset CreateTwoGiftJobIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTwoGiftJobIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTwoGiftJobNum(FlatBufferBuilder builder, int TwoGiftJobNum) { builder.AddInt(6, TwoGiftJobNum, -1); }
  public static void AddGiftTypeList(FlatBufferBuilder builder, VectorOffset GiftTypeListOffset) { builder.AddOffset(7, GiftTypeListOffset.Value, 0); }
  public static VectorOffset CreateGiftTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGiftTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGiftIDList(FlatBufferBuilder builder, VectorOffset GiftIDListOffset) { builder.AddOffset(8, GiftIDListOffset.Value, 0); }
  public static VectorOffset CreateGiftIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGiftIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGiftNumList(FlatBufferBuilder builder, VectorOffset GiftNumListOffset) { builder.AddOffset(9, GiftNumListOffset.Value, 0); }
  public static VectorOffset CreateGiftNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGiftNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNumLimit(FlatBufferBuilder builder, int NumLimit) { builder.AddInt(10, NumLimit, -1); }
  public static void AddIsBanding(FlatBufferBuilder builder, bool IsBanding) { builder.AddBool(11, IsBanding, false); }
  public static void AddGiftLevel(FlatBufferBuilder builder, int GiftLevel) { builder.AddInt(12, GiftLevel, -1); }
  public static Offset<FB_OperationActivityGift> EndFB_OperationActivityGift(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OperationActivityGift>(o);
  }
};

public sealed class FB_OperationActivityGiftContainer : Table {
  public static FB_OperationActivityGiftContainer GetRootAsFB_OperationActivityGiftContainer(ByteBuffer _bb) { return GetRootAsFB_OperationActivityGiftContainer(_bb, new FB_OperationActivityGiftContainer()); }
  public static FB_OperationActivityGiftContainer GetRootAsFB_OperationActivityGiftContainer(ByteBuffer _bb, FB_OperationActivityGiftContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OperationActivityGiftContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OperationActivityGiftContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OperationActivityGift GetItems(int j) { return GetItems(new FB_OperationActivityGift(), j); }
  public FB_OperationActivityGift GetItems(FB_OperationActivityGift obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OperationActivityGiftContainer> CreateFB_OperationActivityGiftContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OperationActivityGiftContainer.AddItems(builder, items);
    return FB_OperationActivityGiftContainer.EndFB_OperationActivityGiftContainer(builder);
  }

  public static void StartFB_OperationActivityGiftContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OperationActivityGift>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OperationActivityGiftContainer> EndFB_OperationActivityGiftContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OperationActivityGiftContainer>(o);
  }
  public static void FinishFB_OperationActivityGiftContainerBuffer(FlatBufferBuilder builder, Offset<FB_OperationActivityGiftContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
