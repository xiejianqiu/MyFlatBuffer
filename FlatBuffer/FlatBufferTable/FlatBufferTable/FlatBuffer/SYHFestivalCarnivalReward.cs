// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHFestivalCarnivalReward : Table {
  public static FB_SYHFestivalCarnivalReward GetRootAsFB_SYHFestivalCarnivalReward(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalCarnivalReward(_bb, new FB_SYHFestivalCarnivalReward()); }
  public static FB_SYHFestivalCarnivalReward GetRootAsFB_SYHFestivalCarnivalReward(ByteBuffer _bb, FB_SYHFestivalCarnivalReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHFestivalCarnivalReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ActivityName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Score { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CountLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MDId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowItemId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuntionOpenID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UIID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int AwardId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AwardCount { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int WorldLimit { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LogicId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_SYHFestivalCarnivalReward> CreateFB_SYHFestivalCarnivalReward(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ActivityName = default(StringOffset),
      int Score = -1,
      int CountLimit = -1,
      int DicId = -1,
      int MDId = -1,
      int ShowItemId = -1,
      int ActivityId = -1,
      int FuntionOpenID = 0,
      int UIID = 1,
      int AwardId = -1,
      int AwardCount = 0,
      int WorldLimit = 0,
      int LogicId = 0) {
    builder.StartObject(14);
    FB_SYHFestivalCarnivalReward.AddLogicId(builder, LogicId);
    FB_SYHFestivalCarnivalReward.AddWorldLimit(builder, WorldLimit);
    FB_SYHFestivalCarnivalReward.AddAwardCount(builder, AwardCount);
    FB_SYHFestivalCarnivalReward.AddAwardId(builder, AwardId);
    FB_SYHFestivalCarnivalReward.AddUIID(builder, UIID);
    FB_SYHFestivalCarnivalReward.AddFuntionOpenID(builder, FuntionOpenID);
    FB_SYHFestivalCarnivalReward.AddActivityId(builder, ActivityId);
    FB_SYHFestivalCarnivalReward.AddShowItemId(builder, ShowItemId);
    FB_SYHFestivalCarnivalReward.AddMDId(builder, MDId);
    FB_SYHFestivalCarnivalReward.AddDicId(builder, DicId);
    FB_SYHFestivalCarnivalReward.AddCountLimit(builder, CountLimit);
    FB_SYHFestivalCarnivalReward.AddScore(builder, Score);
    FB_SYHFestivalCarnivalReward.AddActivityName(builder, ActivityName);
    FB_SYHFestivalCarnivalReward.AddID(builder, ID);
    return FB_SYHFestivalCarnivalReward.EndFB_SYHFestivalCarnivalReward(builder);
  }

  public static void StartFB_SYHFestivalCarnivalReward(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActivityName(FlatBufferBuilder builder, StringOffset ActivityNameOffset) { builder.AddOffset(1, ActivityNameOffset.Value, 0); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(2, Score, -1); }
  public static void AddCountLimit(FlatBufferBuilder builder, int CountLimit) { builder.AddInt(3, CountLimit, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(4, DicId, -1); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(5, MDId, -1); }
  public static void AddShowItemId(FlatBufferBuilder builder, int ShowItemId) { builder.AddInt(6, ShowItemId, -1); }
  public static void AddActivityId(FlatBufferBuilder builder, int ActivityId) { builder.AddInt(7, ActivityId, -1); }
  public static void AddFuntionOpenID(FlatBufferBuilder builder, int FuntionOpenID) { builder.AddInt(8, FuntionOpenID, 0); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(9, UIID, 1); }
  public static void AddAwardId(FlatBufferBuilder builder, int AwardId) { builder.AddInt(10, AwardId, -1); }
  public static void AddAwardCount(FlatBufferBuilder builder, int AwardCount) { builder.AddInt(11, AwardCount, 0); }
  public static void AddWorldLimit(FlatBufferBuilder builder, int WorldLimit) { builder.AddInt(12, WorldLimit, 0); }
  public static void AddLogicId(FlatBufferBuilder builder, int LogicId) { builder.AddInt(13, LogicId, 0); }
  public static Offset<FB_SYHFestivalCarnivalReward> EndFB_SYHFestivalCarnivalReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalCarnivalReward>(o);
  }
};

public sealed class FB_SYHFestivalCarnivalRewardContainer : Table {
  public static FB_SYHFestivalCarnivalRewardContainer GetRootAsFB_SYHFestivalCarnivalRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalCarnivalRewardContainer(_bb, new FB_SYHFestivalCarnivalRewardContainer()); }
  public static FB_SYHFestivalCarnivalRewardContainer GetRootAsFB_SYHFestivalCarnivalRewardContainer(ByteBuffer _bb, FB_SYHFestivalCarnivalRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHFestivalCarnivalRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHFestivalCarnivalRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHFestivalCarnivalReward GetItems(int j) { return GetItems(new FB_SYHFestivalCarnivalReward(), j); }
  public FB_SYHFestivalCarnivalReward GetItems(FB_SYHFestivalCarnivalReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHFestivalCarnivalRewardContainer> CreateFB_SYHFestivalCarnivalRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHFestivalCarnivalRewardContainer.AddItems(builder, items);
    return FB_SYHFestivalCarnivalRewardContainer.EndFB_SYHFestivalCarnivalRewardContainer(builder);
  }

  public static void StartFB_SYHFestivalCarnivalRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHFestivalCarnivalReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHFestivalCarnivalRewardContainer> EndFB_SYHFestivalCarnivalRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalCarnivalRewardContainer>(o);
  }
  public static void FinishFB_SYHFestivalCarnivalRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHFestivalCarnivalRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
