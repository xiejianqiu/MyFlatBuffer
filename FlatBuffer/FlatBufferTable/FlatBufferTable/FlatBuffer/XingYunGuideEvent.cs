// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYunGuideEvent : Table {
  public static FB_XingYunGuideEvent GetRootAsFB_XingYunGuideEvent(ByteBuffer _bb) { return GetRootAsFB_XingYunGuideEvent(_bb, new FB_XingYunGuideEvent()); }
  public static FB_XingYunGuideEvent GetRootAsFB_XingYunGuideEvent(ByteBuffer _bb, FB_XingYunGuideEvent obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYunGuideEvent __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int EventId { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EventDescId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExtraDropItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ExtraDropItemName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int EvaLevel { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowPrompt { get { int o = __offset(16); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int Weights { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimitType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLevelLimit { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevelLimit { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankLimit { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddFactor { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxFortune { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinFortune { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxAddProportion { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerProbability { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EventTriggerType { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SystemBroadCastId { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldServerType { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LastRetRatio { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActivityBaseId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XingYunGuideEvent> CreateFB_XingYunGuideEvent(FlatBufferBuilder builder,
      int EventId = 0,
      int EventDescId = 0,
      int Type = -1,
      int ExtraDropItemId = -1,
      StringOffset ExtraDropItemName = default(StringOffset),
      int EvaLevel = -1,
      bool IsShowPrompt = false,
      int Weights = -1,
      int LevelLimitType = -1,
      int MinLevelLimit = -1,
      int MaxLevelLimit = -1,
      int RankLimit = -1,
      int AddFactor = -1,
      int MaxFortune = -1,
      int MinFortune = -1,
      int MaxAddProportion = -1,
      int TriggerProbability = -1,
      int EventTriggerType = -1,
      int SystemBroadCastId = -1,
      int WorldServerType = -1,
      int LastRetRatio = 0,
      int ActivityBaseId = -1) {
    builder.StartObject(22);
    FB_XingYunGuideEvent.AddActivityBaseId(builder, ActivityBaseId);
    FB_XingYunGuideEvent.AddLastRetRatio(builder, LastRetRatio);
    FB_XingYunGuideEvent.AddWorldServerType(builder, WorldServerType);
    FB_XingYunGuideEvent.AddSystemBroadCastId(builder, SystemBroadCastId);
    FB_XingYunGuideEvent.AddEventTriggerType(builder, EventTriggerType);
    FB_XingYunGuideEvent.AddTriggerProbability(builder, TriggerProbability);
    FB_XingYunGuideEvent.AddMaxAddProportion(builder, MaxAddProportion);
    FB_XingYunGuideEvent.AddMinFortune(builder, MinFortune);
    FB_XingYunGuideEvent.AddMaxFortune(builder, MaxFortune);
    FB_XingYunGuideEvent.AddAddFactor(builder, AddFactor);
    FB_XingYunGuideEvent.AddRankLimit(builder, RankLimit);
    FB_XingYunGuideEvent.AddMaxLevelLimit(builder, MaxLevelLimit);
    FB_XingYunGuideEvent.AddMinLevelLimit(builder, MinLevelLimit);
    FB_XingYunGuideEvent.AddLevelLimitType(builder, LevelLimitType);
    FB_XingYunGuideEvent.AddWeights(builder, Weights);
    FB_XingYunGuideEvent.AddEvaLevel(builder, EvaLevel);
    FB_XingYunGuideEvent.AddExtraDropItemName(builder, ExtraDropItemName);
    FB_XingYunGuideEvent.AddExtraDropItemId(builder, ExtraDropItemId);
    FB_XingYunGuideEvent.AddType(builder, Type);
    FB_XingYunGuideEvent.AddEventDescId(builder, EventDescId);
    FB_XingYunGuideEvent.AddEventId(builder, EventId);
    FB_XingYunGuideEvent.AddIsShowPrompt(builder, IsShowPrompt);
    return FB_XingYunGuideEvent.EndFB_XingYunGuideEvent(builder);
  }

  public static void StartFB_XingYunGuideEvent(FlatBufferBuilder builder) { builder.StartObject(22); }
  public static void AddEventId(FlatBufferBuilder builder, int EventId) { builder.AddInt(0, EventId, 0); }
  public static void AddEventDescId(FlatBufferBuilder builder, int EventDescId) { builder.AddInt(1, EventDescId, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddExtraDropItemId(FlatBufferBuilder builder, int ExtraDropItemId) { builder.AddInt(3, ExtraDropItemId, -1); }
  public static void AddExtraDropItemName(FlatBufferBuilder builder, StringOffset ExtraDropItemNameOffset) { builder.AddOffset(4, ExtraDropItemNameOffset.Value, 0); }
  public static void AddEvaLevel(FlatBufferBuilder builder, int EvaLevel) { builder.AddInt(5, EvaLevel, -1); }
  public static void AddIsShowPrompt(FlatBufferBuilder builder, bool IsShowPrompt) { builder.AddBool(6, IsShowPrompt, false); }
  public static void AddWeights(FlatBufferBuilder builder, int Weights) { builder.AddInt(7, Weights, -1); }
  public static void AddLevelLimitType(FlatBufferBuilder builder, int LevelLimitType) { builder.AddInt(8, LevelLimitType, -1); }
  public static void AddMinLevelLimit(FlatBufferBuilder builder, int MinLevelLimit) { builder.AddInt(9, MinLevelLimit, -1); }
  public static void AddMaxLevelLimit(FlatBufferBuilder builder, int MaxLevelLimit) { builder.AddInt(10, MaxLevelLimit, -1); }
  public static void AddRankLimit(FlatBufferBuilder builder, int RankLimit) { builder.AddInt(11, RankLimit, -1); }
  public static void AddAddFactor(FlatBufferBuilder builder, int AddFactor) { builder.AddInt(12, AddFactor, -1); }
  public static void AddMaxFortune(FlatBufferBuilder builder, int MaxFortune) { builder.AddInt(13, MaxFortune, -1); }
  public static void AddMinFortune(FlatBufferBuilder builder, int MinFortune) { builder.AddInt(14, MinFortune, -1); }
  public static void AddMaxAddProportion(FlatBufferBuilder builder, int MaxAddProportion) { builder.AddInt(15, MaxAddProportion, -1); }
  public static void AddTriggerProbability(FlatBufferBuilder builder, int TriggerProbability) { builder.AddInt(16, TriggerProbability, -1); }
  public static void AddEventTriggerType(FlatBufferBuilder builder, int EventTriggerType) { builder.AddInt(17, EventTriggerType, -1); }
  public static void AddSystemBroadCastId(FlatBufferBuilder builder, int SystemBroadCastId) { builder.AddInt(18, SystemBroadCastId, -1); }
  public static void AddWorldServerType(FlatBufferBuilder builder, int WorldServerType) { builder.AddInt(19, WorldServerType, -1); }
  public static void AddLastRetRatio(FlatBufferBuilder builder, int LastRetRatio) { builder.AddInt(20, LastRetRatio, 0); }
  public static void AddActivityBaseId(FlatBufferBuilder builder, int ActivityBaseId) { builder.AddInt(21, ActivityBaseId, -1); }
  public static Offset<FB_XingYunGuideEvent> EndFB_XingYunGuideEvent(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunGuideEvent>(o);
  }
};

public sealed class FB_XingYunGuideEventContainer : Table {
  public static FB_XingYunGuideEventContainer GetRootAsFB_XingYunGuideEventContainer(ByteBuffer _bb) { return GetRootAsFB_XingYunGuideEventContainer(_bb, new FB_XingYunGuideEventContainer()); }
  public static FB_XingYunGuideEventContainer GetRootAsFB_XingYunGuideEventContainer(ByteBuffer _bb, FB_XingYunGuideEventContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYunGuideEventContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYunGuideEventContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYunGuideEvent GetItems(int j) { return GetItems(new FB_XingYunGuideEvent(), j); }
  public FB_XingYunGuideEvent GetItems(FB_XingYunGuideEvent obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYunGuideEventContainer> CreateFB_XingYunGuideEventContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYunGuideEventContainer.AddItems(builder, items);
    return FB_XingYunGuideEventContainer.EndFB_XingYunGuideEventContainer(builder);
  }

  public static void StartFB_XingYunGuideEventContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYunGuideEvent>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYunGuideEventContainer> EndFB_XingYunGuideEventContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunGuideEventContainer>(o);
  }
  public static void FinishFB_XingYunGuideEventContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYunGuideEventContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
