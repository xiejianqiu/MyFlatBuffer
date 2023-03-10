// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJingXiXianGouBase : Table {
  public static FB_SYHJingXiXianGouBase GetRootAsFB_SYHJingXiXianGouBase(ByteBuffer _bb) { return GetRootAsFB_SYHJingXiXianGouBase(_bb, new FB_SYHJingXiXianGouBase()); }
  public static FB_SYHJingXiXianGouBase GetRootAsFB_SYHJingXiXianGouBase(ByteBuffer _bb, FB_SYHJingXiXianGouBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJingXiXianGouBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string RewardName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int RewardItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StartTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EndTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockParam { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Duration { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Price { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OriginPrice { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Discount { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlagId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowLevel { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHJingXiXianGouBase> CreateFB_SYHJingXiXianGouBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset RewardName = default(StringOffset),
      int RewardItemId = -1,
      int StartTime = 0,
      int EndTime = 0,
      int RewardCount = -1,
      int UnlockType = -1,
      int UnlockParam = -1,
      int Duration = -1,
      int Price = -1,
      int OriginPrice = -1,
      int Discount = -1,
      int FlagId = -1,
      int ShowLevel = -1) {
    builder.StartObject(14);
    FB_SYHJingXiXianGouBase.AddShowLevel(builder, ShowLevel);
    FB_SYHJingXiXianGouBase.AddFlagId(builder, FlagId);
    FB_SYHJingXiXianGouBase.AddDiscount(builder, Discount);
    FB_SYHJingXiXianGouBase.AddOriginPrice(builder, OriginPrice);
    FB_SYHJingXiXianGouBase.AddPrice(builder, Price);
    FB_SYHJingXiXianGouBase.AddDuration(builder, Duration);
    FB_SYHJingXiXianGouBase.AddUnlockParam(builder, UnlockParam);
    FB_SYHJingXiXianGouBase.AddUnlockType(builder, UnlockType);
    FB_SYHJingXiXianGouBase.AddRewardCount(builder, RewardCount);
    FB_SYHJingXiXianGouBase.AddEndTime(builder, EndTime);
    FB_SYHJingXiXianGouBase.AddStartTime(builder, StartTime);
    FB_SYHJingXiXianGouBase.AddRewardItemId(builder, RewardItemId);
    FB_SYHJingXiXianGouBase.AddRewardName(builder, RewardName);
    FB_SYHJingXiXianGouBase.AddID(builder, ID);
    return FB_SYHJingXiXianGouBase.EndFB_SYHJingXiXianGouBase(builder);
  }

  public static void StartFB_SYHJingXiXianGouBase(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRewardName(FlatBufferBuilder builder, StringOffset RewardNameOffset) { builder.AddOffset(1, RewardNameOffset.Value, 0); }
  public static void AddRewardItemId(FlatBufferBuilder builder, int RewardItemId) { builder.AddInt(2, RewardItemId, -1); }
  public static void AddStartTime(FlatBufferBuilder builder, int StartTime) { builder.AddInt(3, StartTime, 0); }
  public static void AddEndTime(FlatBufferBuilder builder, int EndTime) { builder.AddInt(4, EndTime, 0); }
  public static void AddRewardCount(FlatBufferBuilder builder, int RewardCount) { builder.AddInt(5, RewardCount, -1); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(6, UnlockType, -1); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(7, UnlockParam, -1); }
  public static void AddDuration(FlatBufferBuilder builder, int Duration) { builder.AddInt(8, Duration, -1); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(9, Price, -1); }
  public static void AddOriginPrice(FlatBufferBuilder builder, int OriginPrice) { builder.AddInt(10, OriginPrice, -1); }
  public static void AddDiscount(FlatBufferBuilder builder, int Discount) { builder.AddInt(11, Discount, -1); }
  public static void AddFlagId(FlatBufferBuilder builder, int FlagId) { builder.AddInt(12, FlagId, -1); }
  public static void AddShowLevel(FlatBufferBuilder builder, int ShowLevel) { builder.AddInt(13, ShowLevel, -1); }
  public static Offset<FB_SYHJingXiXianGouBase> EndFB_SYHJingXiXianGouBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJingXiXianGouBase>(o);
  }
};

public sealed class FB_SYHJingXiXianGouBaseContainer : Table {
  public static FB_SYHJingXiXianGouBaseContainer GetRootAsFB_SYHJingXiXianGouBaseContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJingXiXianGouBaseContainer(_bb, new FB_SYHJingXiXianGouBaseContainer()); }
  public static FB_SYHJingXiXianGouBaseContainer GetRootAsFB_SYHJingXiXianGouBaseContainer(ByteBuffer _bb, FB_SYHJingXiXianGouBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJingXiXianGouBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJingXiXianGouBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJingXiXianGouBase GetItems(int j) { return GetItems(new FB_SYHJingXiXianGouBase(), j); }
  public FB_SYHJingXiXianGouBase GetItems(FB_SYHJingXiXianGouBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJingXiXianGouBaseContainer> CreateFB_SYHJingXiXianGouBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJingXiXianGouBaseContainer.AddItems(builder, items);
    return FB_SYHJingXiXianGouBaseContainer.EndFB_SYHJingXiXianGouBaseContainer(builder);
  }

  public static void StartFB_SYHJingXiXianGouBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJingXiXianGouBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJingXiXianGouBaseContainer> EndFB_SYHJingXiXianGouBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJingXiXianGouBaseContainer>(o);
  }
  public static void FinishFB_SYHJingXiXianGouBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJingXiXianGouBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
