// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_VIPInvestReward : Table {
  public static FB_VIPInvestReward GetRootAsFB_VIPInvestReward(ByteBuffer _bb) { return GetRootAsFB_VIPInvestReward(_bb, new FB_VIPInvestReward()); }
  public static FB_VIPInvestReward GetRootAsFB_VIPInvestReward(ByteBuffer _bb, FB_VIPInvestReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_VIPInvestReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RefreshType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLvlLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLvlLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DayNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetGiftIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GiftIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetGiftNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GiftNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VIPInvestReward> CreateFB_VIPInvestReward(FlatBufferBuilder builder,
      int ID = 0,
      int RefreshType = -1,
      int MinLvlLimit = -1,
      int MaxLvlLimit = -1,
      int DayNum = -1,
      VectorOffset GiftIDList = default(VectorOffset),
      VectorOffset GiftNumList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_VIPInvestReward.AddGiftNumList(builder, GiftNumList);
    FB_VIPInvestReward.AddGiftIDList(builder, GiftIDList);
    FB_VIPInvestReward.AddDayNum(builder, DayNum);
    FB_VIPInvestReward.AddMaxLvlLimit(builder, MaxLvlLimit);
    FB_VIPInvestReward.AddMinLvlLimit(builder, MinLvlLimit);
    FB_VIPInvestReward.AddRefreshType(builder, RefreshType);
    FB_VIPInvestReward.AddID(builder, ID);
    return FB_VIPInvestReward.EndFB_VIPInvestReward(builder);
  }

  public static void StartFB_VIPInvestReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(1, RefreshType, -1); }
  public static void AddMinLvlLimit(FlatBufferBuilder builder, int MinLvlLimit) { builder.AddInt(2, MinLvlLimit, -1); }
  public static void AddMaxLvlLimit(FlatBufferBuilder builder, int MaxLvlLimit) { builder.AddInt(3, MaxLvlLimit, -1); }
  public static void AddDayNum(FlatBufferBuilder builder, int DayNum) { builder.AddInt(4, DayNum, -1); }
  public static void AddGiftIDList(FlatBufferBuilder builder, VectorOffset GiftIDListOffset) { builder.AddOffset(5, GiftIDListOffset.Value, 0); }
  public static VectorOffset CreateGiftIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGiftIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGiftNumList(FlatBufferBuilder builder, VectorOffset GiftNumListOffset) { builder.AddOffset(6, GiftNumListOffset.Value, 0); }
  public static VectorOffset CreateGiftNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGiftNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VIPInvestReward> EndFB_VIPInvestReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VIPInvestReward>(o);
  }
};

public sealed class FB_VIPInvestRewardContainer : Table {
  public static FB_VIPInvestRewardContainer GetRootAsFB_VIPInvestRewardContainer(ByteBuffer _bb) { return GetRootAsFB_VIPInvestRewardContainer(_bb, new FB_VIPInvestRewardContainer()); }
  public static FB_VIPInvestRewardContainer GetRootAsFB_VIPInvestRewardContainer(ByteBuffer _bb, FB_VIPInvestRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_VIPInvestRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_VIPInvestRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_VIPInvestReward GetItems(int j) { return GetItems(new FB_VIPInvestReward(), j); }
  public FB_VIPInvestReward GetItems(FB_VIPInvestReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VIPInvestRewardContainer> CreateFB_VIPInvestRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_VIPInvestRewardContainer.AddItems(builder, items);
    return FB_VIPInvestRewardContainer.EndFB_VIPInvestRewardContainer(builder);
  }

  public static void StartFB_VIPInvestRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_VIPInvestReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VIPInvestRewardContainer> EndFB_VIPInvestRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VIPInvestRewardContainer>(o);
  }
  public static void FinishFB_VIPInvestRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_VIPInvestRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
