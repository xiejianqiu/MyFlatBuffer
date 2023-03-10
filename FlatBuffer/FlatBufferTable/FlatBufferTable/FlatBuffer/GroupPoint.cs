// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GroupPoint : Table {
  public static FB_GroupPoint GetRootAsFB_GroupPoint(ByteBuffer _bb) { return GetRootAsFB_GroupPoint(_bb, new FB_GroupPoint()); }
  public static FB_GroupPoint GetRootAsFB_GroupPoint(ByteBuffer _bb, FB_GroupPoint obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GroupPoint __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string FlowText { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CharModelID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsOnlyClient { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int NotifyId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Area { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CollectTime { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RespawnTime { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LiveTime { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsDelete { get { int o = __offset(26); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int InitAnimId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FinishAnimId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SelfEffectId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PlayerKZEffectId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PlayerHLEffectId { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PlayerCKEffectId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PlayerYJEffectId { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string IconPath { get { int o = __offset(42); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Subtype { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetParamList(int j) { int o = __offset(46); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(46); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsNeedClick { get { int o = __offset(48); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int BuffId { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsRespawn { get { int o = __offset(52); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int DefaultEffectID { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FinishedEffectID { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitNum { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitType { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitIndex { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitDict { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ProgressBase { get { int o = __offset(66); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DelDict { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float Height { get { int o = __offset(70); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int PStrId { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PLifeTime { get { int o = __offset(74); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool PShowInChat { get { int o = __offset(76); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsShowNameBoard { get { int o = __offset(78); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int PlayerInBloodEffect { get { int o = __offset(80); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AchieveAnimId { get { int o = __offset(82); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool AchieveEffect { get { int o = __offset(84); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int MissionId { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ModelEffectId { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float StopRange { get { int o = __offset(90); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int SoundId { get { int o = __offset(92); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_GroupPoint> CreateFB_GroupPoint(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset FlowText = default(StringOffset),
      int CharModelID = 0,
      int Type = 0,
      bool IsOnlyClient = false,
      int NotifyId = 0,
      int Area = 0,
      int CollectTime = 0,
      int RespawnTime = 0,
      int LiveTime = 0,
      bool IsDelete = false,
      int InitAnimId = 0,
      int FinishAnimId = 0,
      int SelfEffectId = 0,
      int PlayerKZEffectId = 0,
      int PlayerHLEffectId = 0,
      int PlayerCKEffectId = 0,
      int PlayerYJEffectId = 0,
      StringOffset IconPath = default(StringOffset),
      int subtype = 0,
      VectorOffset ParamList = default(VectorOffset),
      bool IsNeedClick = false,
      int buffId = 0,
      bool IsRespawn = false,
      int DefaultEffectID = 0,
      int FinishedEffectID = 0,
      int LimitNum = 0,
      int LimitType = 0,
      int LimitIndex = 0,
      int LimitDict = 0,
      int ProgressBase = 0,
      int DelDict = 0,
      float Height = 0,
      int PStrId = 0,
      float PLifeTime = 0,
      bool PShowInChat = false,
      bool IsShowNameBoard = false,
      int PlayerInBloodEffect = 0,
      int AchieveAnimId = 0,
      bool AchieveEffect = false,
      int MissionId = 0,
      int ModelEffectId = 0,
      float StopRange = 0,
      int SoundId = 0) {
    builder.StartObject(45);
    FB_GroupPoint.AddSoundId(builder, SoundId);
    FB_GroupPoint.AddStopRange(builder, StopRange);
    FB_GroupPoint.AddModelEffectId(builder, ModelEffectId);
    FB_GroupPoint.AddMissionId(builder, MissionId);
    FB_GroupPoint.AddAchieveAnimId(builder, AchieveAnimId);
    FB_GroupPoint.AddPlayerInBloodEffect(builder, PlayerInBloodEffect);
    FB_GroupPoint.AddPLifeTime(builder, PLifeTime);
    FB_GroupPoint.AddPStrId(builder, PStrId);
    FB_GroupPoint.AddHeight(builder, Height);
    FB_GroupPoint.AddDelDict(builder, DelDict);
    FB_GroupPoint.AddProgressBase(builder, ProgressBase);
    FB_GroupPoint.AddLimitDict(builder, LimitDict);
    FB_GroupPoint.AddLimitIndex(builder, LimitIndex);
    FB_GroupPoint.AddLimitType(builder, LimitType);
    FB_GroupPoint.AddLimitNum(builder, LimitNum);
    FB_GroupPoint.AddFinishedEffectID(builder, FinishedEffectID);
    FB_GroupPoint.AddDefaultEffectID(builder, DefaultEffectID);
    FB_GroupPoint.AddBuffId(builder, buffId);
    FB_GroupPoint.AddParamList(builder, ParamList);
    FB_GroupPoint.AddSubtype(builder, subtype);
    FB_GroupPoint.AddIconPath(builder, IconPath);
    FB_GroupPoint.AddPlayerYJEffectId(builder, PlayerYJEffectId);
    FB_GroupPoint.AddPlayerCKEffectId(builder, PlayerCKEffectId);
    FB_GroupPoint.AddPlayerHLEffectId(builder, PlayerHLEffectId);
    FB_GroupPoint.AddPlayerKZEffectId(builder, PlayerKZEffectId);
    FB_GroupPoint.AddSelfEffectId(builder, SelfEffectId);
    FB_GroupPoint.AddFinishAnimId(builder, FinishAnimId);
    FB_GroupPoint.AddInitAnimId(builder, InitAnimId);
    FB_GroupPoint.AddLiveTime(builder, LiveTime);
    FB_GroupPoint.AddRespawnTime(builder, RespawnTime);
    FB_GroupPoint.AddCollectTime(builder, CollectTime);
    FB_GroupPoint.AddArea(builder, Area);
    FB_GroupPoint.AddNotifyId(builder, NotifyId);
    FB_GroupPoint.AddType(builder, Type);
    FB_GroupPoint.AddCharModelID(builder, CharModelID);
    FB_GroupPoint.AddFlowText(builder, FlowText);
    FB_GroupPoint.AddName(builder, Name);
    FB_GroupPoint.AddId(builder, Id);
    FB_GroupPoint.AddAchieveEffect(builder, AchieveEffect);
    FB_GroupPoint.AddIsShowNameBoard(builder, IsShowNameBoard);
    FB_GroupPoint.AddPShowInChat(builder, PShowInChat);
    FB_GroupPoint.AddIsRespawn(builder, IsRespawn);
    FB_GroupPoint.AddIsNeedClick(builder, IsNeedClick);
    FB_GroupPoint.AddIsDelete(builder, IsDelete);
    FB_GroupPoint.AddIsOnlyClient(builder, IsOnlyClient);
    return FB_GroupPoint.EndFB_GroupPoint(builder);
  }

  public static void StartFB_GroupPoint(FlatBufferBuilder builder) { builder.StartObject(45); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddFlowText(FlatBufferBuilder builder, StringOffset FlowTextOffset) { builder.AddOffset(2, FlowTextOffset.Value, 0); }
  public static void AddCharModelID(FlatBufferBuilder builder, int CharModelID) { builder.AddInt(3, CharModelID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(4, Type, 0); }
  public static void AddIsOnlyClient(FlatBufferBuilder builder, bool IsOnlyClient) { builder.AddBool(5, IsOnlyClient, false); }
  public static void AddNotifyId(FlatBufferBuilder builder, int NotifyId) { builder.AddInt(6, NotifyId, 0); }
  public static void AddArea(FlatBufferBuilder builder, int Area) { builder.AddInt(7, Area, 0); }
  public static void AddCollectTime(FlatBufferBuilder builder, int CollectTime) { builder.AddInt(8, CollectTime, 0); }
  public static void AddRespawnTime(FlatBufferBuilder builder, int RespawnTime) { builder.AddInt(9, RespawnTime, 0); }
  public static void AddLiveTime(FlatBufferBuilder builder, int LiveTime) { builder.AddInt(10, LiveTime, 0); }
  public static void AddIsDelete(FlatBufferBuilder builder, bool IsDelete) { builder.AddBool(11, IsDelete, false); }
  public static void AddInitAnimId(FlatBufferBuilder builder, int InitAnimId) { builder.AddInt(12, InitAnimId, 0); }
  public static void AddFinishAnimId(FlatBufferBuilder builder, int FinishAnimId) { builder.AddInt(13, FinishAnimId, 0); }
  public static void AddSelfEffectId(FlatBufferBuilder builder, int SelfEffectId) { builder.AddInt(14, SelfEffectId, 0); }
  public static void AddPlayerKZEffectId(FlatBufferBuilder builder, int PlayerKZEffectId) { builder.AddInt(15, PlayerKZEffectId, 0); }
  public static void AddPlayerHLEffectId(FlatBufferBuilder builder, int PlayerHLEffectId) { builder.AddInt(16, PlayerHLEffectId, 0); }
  public static void AddPlayerCKEffectId(FlatBufferBuilder builder, int PlayerCKEffectId) { builder.AddInt(17, PlayerCKEffectId, 0); }
  public static void AddPlayerYJEffectId(FlatBufferBuilder builder, int PlayerYJEffectId) { builder.AddInt(18, PlayerYJEffectId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(19, IconPathOffset.Value, 0); }
  public static void AddSubtype(FlatBufferBuilder builder, int subtype) { builder.AddInt(20, subtype, 0); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(21, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsNeedClick(FlatBufferBuilder builder, bool IsNeedClick) { builder.AddBool(22, IsNeedClick, false); }
  public static void AddBuffId(FlatBufferBuilder builder, int buffId) { builder.AddInt(23, buffId, 0); }
  public static void AddIsRespawn(FlatBufferBuilder builder, bool IsRespawn) { builder.AddBool(24, IsRespawn, false); }
  public static void AddDefaultEffectID(FlatBufferBuilder builder, int DefaultEffectID) { builder.AddInt(25, DefaultEffectID, 0); }
  public static void AddFinishedEffectID(FlatBufferBuilder builder, int FinishedEffectID) { builder.AddInt(26, FinishedEffectID, 0); }
  public static void AddLimitNum(FlatBufferBuilder builder, int LimitNum) { builder.AddInt(27, LimitNum, 0); }
  public static void AddLimitType(FlatBufferBuilder builder, int LimitType) { builder.AddInt(28, LimitType, 0); }
  public static void AddLimitIndex(FlatBufferBuilder builder, int LimitIndex) { builder.AddInt(29, LimitIndex, 0); }
  public static void AddLimitDict(FlatBufferBuilder builder, int LimitDict) { builder.AddInt(30, LimitDict, 0); }
  public static void AddProgressBase(FlatBufferBuilder builder, int ProgressBase) { builder.AddInt(31, ProgressBase, 0); }
  public static void AddDelDict(FlatBufferBuilder builder, int DelDict) { builder.AddInt(32, DelDict, 0); }
  public static void AddHeight(FlatBufferBuilder builder, float Height) { builder.AddFloat(33, Height, 0); }
  public static void AddPStrId(FlatBufferBuilder builder, int PStrId) { builder.AddInt(34, PStrId, 0); }
  public static void AddPLifeTime(FlatBufferBuilder builder, float PLifeTime) { builder.AddFloat(35, PLifeTime, 0); }
  public static void AddPShowInChat(FlatBufferBuilder builder, bool PShowInChat) { builder.AddBool(36, PShowInChat, false); }
  public static void AddIsShowNameBoard(FlatBufferBuilder builder, bool IsShowNameBoard) { builder.AddBool(37, IsShowNameBoard, false); }
  public static void AddPlayerInBloodEffect(FlatBufferBuilder builder, int PlayerInBloodEffect) { builder.AddInt(38, PlayerInBloodEffect, 0); }
  public static void AddAchieveAnimId(FlatBufferBuilder builder, int AchieveAnimId) { builder.AddInt(39, AchieveAnimId, 0); }
  public static void AddAchieveEffect(FlatBufferBuilder builder, bool AchieveEffect) { builder.AddBool(40, AchieveEffect, false); }
  public static void AddMissionId(FlatBufferBuilder builder, int MissionId) { builder.AddInt(41, MissionId, 0); }
  public static void AddModelEffectId(FlatBufferBuilder builder, int ModelEffectId) { builder.AddInt(42, ModelEffectId, 0); }
  public static void AddStopRange(FlatBufferBuilder builder, float StopRange) { builder.AddFloat(43, StopRange, 0); }
  public static void AddSoundId(FlatBufferBuilder builder, int SoundId) { builder.AddInt(44, SoundId, 0); }
  public static Offset<FB_GroupPoint> EndFB_GroupPoint(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GroupPoint>(o);
  }
};

public sealed class FB_GroupPointContainer : Table {
  public static FB_GroupPointContainer GetRootAsFB_GroupPointContainer(ByteBuffer _bb) { return GetRootAsFB_GroupPointContainer(_bb, new FB_GroupPointContainer()); }
  public static FB_GroupPointContainer GetRootAsFB_GroupPointContainer(ByteBuffer _bb, FB_GroupPointContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GroupPointContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GroupPointContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GroupPoint GetItems(int j) { return GetItems(new FB_GroupPoint(), j); }
  public FB_GroupPoint GetItems(FB_GroupPoint obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GroupPointContainer> CreateFB_GroupPointContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GroupPointContainer.AddItems(builder, items);
    return FB_GroupPointContainer.EndFB_GroupPointContainer(builder);
  }

  public static void StartFB_GroupPointContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GroupPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GroupPointContainer> EndFB_GroupPointContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GroupPointContainer>(o);
  }
  public static void FinishFB_GroupPointContainerBuffer(FlatBufferBuilder builder, Offset<FB_GroupPointContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
