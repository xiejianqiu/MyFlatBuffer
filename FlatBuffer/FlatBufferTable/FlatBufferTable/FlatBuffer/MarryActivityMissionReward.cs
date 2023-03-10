// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryActivityMissionReward : Table {
  public static FB_MarryActivityMissionReward GetRootAsFB_MarryActivityMissionReward(ByteBuffer _bb) { return GetRootAsFB_MarryActivityMissionReward(_bb, new FB_MarryActivityMissionReward()); }
  public static FB_MarryActivityMissionReward GetRootAsFB_MarryActivityMissionReward(ByteBuffer _bb, FB_MarryActivityMissionReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryActivityMissionReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScoreLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BonusIndex { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MarryActivityMissionReward> CreateFB_MarryActivityMissionReward(FlatBufferBuilder builder,
      int ID = 0,
      int ScoreLimit = -1,
      int Level = -1,
      int DicId = -1,
      int BonusIndex = -1,
      int RewardType = -1,
      int ActivityType = -1) {
    builder.StartObject(7);
    FB_MarryActivityMissionReward.AddActivityType(builder, ActivityType);
    FB_MarryActivityMissionReward.AddRewardType(builder, RewardType);
    FB_MarryActivityMissionReward.AddBonusIndex(builder, BonusIndex);
    FB_MarryActivityMissionReward.AddDicId(builder, DicId);
    FB_MarryActivityMissionReward.AddLevel(builder, Level);
    FB_MarryActivityMissionReward.AddScoreLimit(builder, ScoreLimit);
    FB_MarryActivityMissionReward.AddID(builder, ID);
    return FB_MarryActivityMissionReward.EndFB_MarryActivityMissionReward(builder);
  }

  public static void StartFB_MarryActivityMissionReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScoreLimit(FlatBufferBuilder builder, int ScoreLimit) { builder.AddInt(1, ScoreLimit, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(3, DicId, -1); }
  public static void AddBonusIndex(FlatBufferBuilder builder, int BonusIndex) { builder.AddInt(4, BonusIndex, -1); }
  public static void AddRewardType(FlatBufferBuilder builder, int RewardType) { builder.AddInt(5, RewardType, -1); }
  public static void AddActivityType(FlatBufferBuilder builder, int ActivityType) { builder.AddInt(6, ActivityType, -1); }
  public static Offset<FB_MarryActivityMissionReward> EndFB_MarryActivityMissionReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryActivityMissionReward>(o);
  }
};

public sealed class FB_MarryActivityMissionRewardContainer : Table {
  public static FB_MarryActivityMissionRewardContainer GetRootAsFB_MarryActivityMissionRewardContainer(ByteBuffer _bb) { return GetRootAsFB_MarryActivityMissionRewardContainer(_bb, new FB_MarryActivityMissionRewardContainer()); }
  public static FB_MarryActivityMissionRewardContainer GetRootAsFB_MarryActivityMissionRewardContainer(ByteBuffer _bb, FB_MarryActivityMissionRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryActivityMissionRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryActivityMissionRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryActivityMissionReward GetItems(int j) { return GetItems(new FB_MarryActivityMissionReward(), j); }
  public FB_MarryActivityMissionReward GetItems(FB_MarryActivityMissionReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryActivityMissionRewardContainer> CreateFB_MarryActivityMissionRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryActivityMissionRewardContainer.AddItems(builder, items);
    return FB_MarryActivityMissionRewardContainer.EndFB_MarryActivityMissionRewardContainer(builder);
  }

  public static void StartFB_MarryActivityMissionRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryActivityMissionReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryActivityMissionRewardContainer> EndFB_MarryActivityMissionRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryActivityMissionRewardContainer>(o);
  }
  public static void FinishFB_MarryActivityMissionRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryActivityMissionRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
