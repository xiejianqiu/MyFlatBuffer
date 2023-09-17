// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYunMission : Table {
  public static FB_XingYunMission GetRootAsFB_XingYunMission(ByteBuffer _bb) { return GetRootAsFB_XingYunMission(_bb, new FB_XingYunMission()); }
  public static FB_XingYunMission GetRootAsFB_XingYunMission(ByteBuffer _bb, FB_XingYunMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYunMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int MissionID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MissionDesc { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MissionType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissionTargetNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimitType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLevelLimit { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevelLimit { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankLimit { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Weights { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityBaseId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EventType { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XingYunMission> CreateFB_XingYunMission(FlatBufferBuilder builder,
      int MissionID = 0,
      int MissionDesc = 0,
      int MissionType = -1,
      int MissionTargetNum = -1,
      int RewardID = -1,
      int RewardNum = -1,
      int LevelLimitType = -1,
      int MinLevelLimit = -1,
      int MaxLevelLimit = -1,
      int RankLimit = -1,
      int Weights = -1,
      int ActivityBaseId = -1,
      int EventType = -1) {
    builder.StartObject(13);
    FB_XingYunMission.AddEventType(builder, EventType);
    FB_XingYunMission.AddActivityBaseId(builder, ActivityBaseId);
    FB_XingYunMission.AddWeights(builder, Weights);
    FB_XingYunMission.AddRankLimit(builder, RankLimit);
    FB_XingYunMission.AddMaxLevelLimit(builder, MaxLevelLimit);
    FB_XingYunMission.AddMinLevelLimit(builder, MinLevelLimit);
    FB_XingYunMission.AddLevelLimitType(builder, LevelLimitType);
    FB_XingYunMission.AddRewardNum(builder, RewardNum);
    FB_XingYunMission.AddRewardID(builder, RewardID);
    FB_XingYunMission.AddMissionTargetNum(builder, MissionTargetNum);
    FB_XingYunMission.AddMissionType(builder, MissionType);
    FB_XingYunMission.AddMissionDesc(builder, MissionDesc);
    FB_XingYunMission.AddMissionID(builder, MissionID);
    return FB_XingYunMission.EndFB_XingYunMission(builder);
  }

  public static void StartFB_XingYunMission(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddMissionID(FlatBufferBuilder builder, int MissionID) { builder.AddInt(0, MissionID, 0); }
  public static void AddMissionDesc(FlatBufferBuilder builder, int MissionDesc) { builder.AddInt(1, MissionDesc, 0); }
  public static void AddMissionType(FlatBufferBuilder builder, int MissionType) { builder.AddInt(2, MissionType, -1); }
  public static void AddMissionTargetNum(FlatBufferBuilder builder, int MissionTargetNum) { builder.AddInt(3, MissionTargetNum, -1); }
  public static void AddRewardID(FlatBufferBuilder builder, int RewardID) { builder.AddInt(4, RewardID, -1); }
  public static void AddRewardNum(FlatBufferBuilder builder, int RewardNum) { builder.AddInt(5, RewardNum, -1); }
  public static void AddLevelLimitType(FlatBufferBuilder builder, int LevelLimitType) { builder.AddInt(6, LevelLimitType, -1); }
  public static void AddMinLevelLimit(FlatBufferBuilder builder, int MinLevelLimit) { builder.AddInt(7, MinLevelLimit, -1); }
  public static void AddMaxLevelLimit(FlatBufferBuilder builder, int MaxLevelLimit) { builder.AddInt(8, MaxLevelLimit, -1); }
  public static void AddRankLimit(FlatBufferBuilder builder, int RankLimit) { builder.AddInt(9, RankLimit, -1); }
  public static void AddWeights(FlatBufferBuilder builder, int Weights) { builder.AddInt(10, Weights, -1); }
  public static void AddActivityBaseId(FlatBufferBuilder builder, int ActivityBaseId) { builder.AddInt(11, ActivityBaseId, -1); }
  public static void AddEventType(FlatBufferBuilder builder, int EventType) { builder.AddInt(12, EventType, -1); }
  public static Offset<FB_XingYunMission> EndFB_XingYunMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunMission>(o);
  }
};

public sealed class FB_XingYunMissionContainer : Table {
  public static FB_XingYunMissionContainer GetRootAsFB_XingYunMissionContainer(ByteBuffer _bb) { return GetRootAsFB_XingYunMissionContainer(_bb, new FB_XingYunMissionContainer()); }
  public static FB_XingYunMissionContainer GetRootAsFB_XingYunMissionContainer(ByteBuffer _bb, FB_XingYunMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYunMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYunMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYunMission GetItems(int j) { return GetItems(new FB_XingYunMission(), j); }
  public FB_XingYunMission GetItems(FB_XingYunMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYunMissionContainer> CreateFB_XingYunMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYunMissionContainer.AddItems(builder, items);
    return FB_XingYunMissionContainer.EndFB_XingYunMissionContainer(builder);
  }

  public static void StartFB_XingYunMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYunMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYunMissionContainer> EndFB_XingYunMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunMissionContainer>(o);
  }
  public static void FinishFB_XingYunMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYunMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
