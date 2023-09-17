// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYunBlessing : Table {
  public static FB_XingYunBlessing GetRootAsFB_XingYunBlessing(ByteBuffer _bb) { return GetRootAsFB_XingYunBlessing(_bb, new FB_XingYunBlessing()); }
  public static FB_XingYunBlessing GetRootAsFB_XingYunBlessing(ByteBuffer _bb, FB_XingYunBlessing obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYunBlessing __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int EventId { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BlessType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SpecialEventType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float SpecialEventParam { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int BuffID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BufDescId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EventWeights { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimitType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLevelLimit { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxLevelLimit { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RankLimit { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityBaseId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XingYunBlessing> CreateFB_XingYunBlessing(FlatBufferBuilder builder,
      int EventId = 0,
      int BlessType = -1,
      int RewardID = -1,
      int RewardNum = -1,
      int SpecialEventType = -1,
      float SpecialEventParam = -1,
      int BuffID = -1,
      int BufDescId = 0,
      int EventWeights = -1,
      int LevelLimitType = -1,
      int MinLevelLimit = 0,
      int MaxLevelLimit = 0,
      int RankLimit = -1,
      int ActivityBaseId = -1) {
    builder.StartObject(14);
    FB_XingYunBlessing.AddActivityBaseId(builder, ActivityBaseId);
    FB_XingYunBlessing.AddRankLimit(builder, RankLimit);
    FB_XingYunBlessing.AddMaxLevelLimit(builder, MaxLevelLimit);
    FB_XingYunBlessing.AddMinLevelLimit(builder, MinLevelLimit);
    FB_XingYunBlessing.AddLevelLimitType(builder, LevelLimitType);
    FB_XingYunBlessing.AddEventWeights(builder, EventWeights);
    FB_XingYunBlessing.AddBufDescId(builder, BufDescId);
    FB_XingYunBlessing.AddBuffID(builder, BuffID);
    FB_XingYunBlessing.AddSpecialEventParam(builder, SpecialEventParam);
    FB_XingYunBlessing.AddSpecialEventType(builder, SpecialEventType);
    FB_XingYunBlessing.AddRewardNum(builder, RewardNum);
    FB_XingYunBlessing.AddRewardID(builder, RewardID);
    FB_XingYunBlessing.AddBlessType(builder, BlessType);
    FB_XingYunBlessing.AddEventId(builder, EventId);
    return FB_XingYunBlessing.EndFB_XingYunBlessing(builder);
  }

  public static void StartFB_XingYunBlessing(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddEventId(FlatBufferBuilder builder, int EventId) { builder.AddInt(0, EventId, 0); }
  public static void AddBlessType(FlatBufferBuilder builder, int BlessType) { builder.AddInt(1, BlessType, -1); }
  public static void AddRewardID(FlatBufferBuilder builder, int RewardID) { builder.AddInt(2, RewardID, -1); }
  public static void AddRewardNum(FlatBufferBuilder builder, int RewardNum) { builder.AddInt(3, RewardNum, -1); }
  public static void AddSpecialEventType(FlatBufferBuilder builder, int SpecialEventType) { builder.AddInt(4, SpecialEventType, -1); }
  public static void AddSpecialEventParam(FlatBufferBuilder builder, float SpecialEventParam) { builder.AddFloat(5, SpecialEventParam, -1); }
  public static void AddBuffID(FlatBufferBuilder builder, int BuffID) { builder.AddInt(6, BuffID, -1); }
  public static void AddBufDescId(FlatBufferBuilder builder, int BufDescId) { builder.AddInt(7, BufDescId, 0); }
  public static void AddEventWeights(FlatBufferBuilder builder, int EventWeights) { builder.AddInt(8, EventWeights, -1); }
  public static void AddLevelLimitType(FlatBufferBuilder builder, int LevelLimitType) { builder.AddInt(9, LevelLimitType, -1); }
  public static void AddMinLevelLimit(FlatBufferBuilder builder, int MinLevelLimit) { builder.AddInt(10, MinLevelLimit, 0); }
  public static void AddMaxLevelLimit(FlatBufferBuilder builder, int MaxLevelLimit) { builder.AddInt(11, MaxLevelLimit, 0); }
  public static void AddRankLimit(FlatBufferBuilder builder, int RankLimit) { builder.AddInt(12, RankLimit, -1); }
  public static void AddActivityBaseId(FlatBufferBuilder builder, int ActivityBaseId) { builder.AddInt(13, ActivityBaseId, -1); }
  public static Offset<FB_XingYunBlessing> EndFB_XingYunBlessing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunBlessing>(o);
  }
};

public sealed class FB_XingYunBlessingContainer : Table {
  public static FB_XingYunBlessingContainer GetRootAsFB_XingYunBlessingContainer(ByteBuffer _bb) { return GetRootAsFB_XingYunBlessingContainer(_bb, new FB_XingYunBlessingContainer()); }
  public static FB_XingYunBlessingContainer GetRootAsFB_XingYunBlessingContainer(ByteBuffer _bb, FB_XingYunBlessingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYunBlessingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYunBlessingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYunBlessing GetItems(int j) { return GetItems(new FB_XingYunBlessing(), j); }
  public FB_XingYunBlessing GetItems(FB_XingYunBlessing obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYunBlessingContainer> CreateFB_XingYunBlessingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYunBlessingContainer.AddItems(builder, items);
    return FB_XingYunBlessingContainer.EndFB_XingYunBlessingContainer(builder);
  }

  public static void StartFB_XingYunBlessingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYunBlessing>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYunBlessingContainer> EndFB_XingYunBlessingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunBlessingContainer>(o);
  }
  public static void FinishFB_XingYunBlessingContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYunBlessingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
