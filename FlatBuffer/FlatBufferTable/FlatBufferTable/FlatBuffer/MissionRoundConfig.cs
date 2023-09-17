// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionRoundConfig : Table {
  public static FB_MissionRoundConfig GetRootAsFB_MissionRoundConfig(ByteBuffer _bb) { return GetRootAsFB_MissionRoundConfig(_bb, new FB_MissionRoundConfig()); }
  public static FB_MissionRoundConfig GetRootAsFB_MissionRoundConfig(ByteBuffer _bb, FB_MissionRoundConfig obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionRoundConfig __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Rounds { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sessions { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DoubleExp { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CooldownType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReceiveType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReceiveID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Prefix { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RoundDesc { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RoundTitle { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RoundTitleInBoard { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetShowItemIDList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemIDListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMissionCostType { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMissionCost { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(34); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GiveupDictID { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpireType { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int ExpireTime { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public bool IsAutoContinus { get { int o = __offset(42); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int EndDesc { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ScriptId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VipNeed { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelDict { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionRoundConfig> CreateFB_MissionRoundConfig(FlatBufferBuilder builder,
      int Id = 0,
      int Type = 0,
      int Rounds = -1,
      int Sessions = -1,
      int DoubleExp = -1,
      int CooldownType = -1,
      int ReceiveType = -1,
      int ReceiveID = -1,
      int Prefix = -1,
      int RoundDesc = -1,
      int RoundTitle = -1,
      int RoundTitleInBoard = -1,
      VectorOffset ShowItemIDList = default(VectorOffset),
      int GetMissionCostType = -1,
      int GetMissionCost = -1,
      StringOffset Name = default(StringOffset),
      int GiveupDictID = -1,
      int ExpireType = 1,
      int ExpireTime = 1,
      bool IsAutoContinus = false,
      int EndDesc = -1,
      int ScriptId = -1,
      int VipNeed = -1,
      int LevelLimit = -1,
      int LevelDict = -1) {
    builder.StartObject(25);
    FB_MissionRoundConfig.AddLevelDict(builder, LevelDict);
    FB_MissionRoundConfig.AddLevelLimit(builder, LevelLimit);
    FB_MissionRoundConfig.AddVipNeed(builder, VipNeed);
    FB_MissionRoundConfig.AddScriptId(builder, ScriptId);
    FB_MissionRoundConfig.AddEndDesc(builder, EndDesc);
    FB_MissionRoundConfig.AddExpireTime(builder, ExpireTime);
    FB_MissionRoundConfig.AddExpireType(builder, ExpireType);
    FB_MissionRoundConfig.AddGiveupDictID(builder, GiveupDictID);
    FB_MissionRoundConfig.AddName(builder, Name);
    FB_MissionRoundConfig.AddGetMissionCost(builder, GetMissionCost);
    FB_MissionRoundConfig.AddGetMissionCostType(builder, GetMissionCostType);
    FB_MissionRoundConfig.AddShowItemIDList(builder, ShowItemIDList);
    FB_MissionRoundConfig.AddRoundTitleInBoard(builder, RoundTitleInBoard);
    FB_MissionRoundConfig.AddRoundTitle(builder, RoundTitle);
    FB_MissionRoundConfig.AddRoundDesc(builder, RoundDesc);
    FB_MissionRoundConfig.AddPrefix(builder, Prefix);
    FB_MissionRoundConfig.AddReceiveID(builder, ReceiveID);
    FB_MissionRoundConfig.AddReceiveType(builder, ReceiveType);
    FB_MissionRoundConfig.AddCooldownType(builder, CooldownType);
    FB_MissionRoundConfig.AddDoubleExp(builder, DoubleExp);
    FB_MissionRoundConfig.AddSessions(builder, Sessions);
    FB_MissionRoundConfig.AddRounds(builder, Rounds);
    FB_MissionRoundConfig.AddType(builder, Type);
    FB_MissionRoundConfig.AddId(builder, Id);
    FB_MissionRoundConfig.AddIsAutoContinus(builder, IsAutoContinus);
    return FB_MissionRoundConfig.EndFB_MissionRoundConfig(builder);
  }

  public static void StartFB_MissionRoundConfig(FlatBufferBuilder builder) { builder.StartObject(25); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, 0); }
  public static void AddRounds(FlatBufferBuilder builder, int Rounds) { builder.AddInt(2, Rounds, -1); }
  public static void AddSessions(FlatBufferBuilder builder, int Sessions) { builder.AddInt(3, Sessions, -1); }
  public static void AddDoubleExp(FlatBufferBuilder builder, int DoubleExp) { builder.AddInt(4, DoubleExp, -1); }
  public static void AddCooldownType(FlatBufferBuilder builder, int CooldownType) { builder.AddInt(5, CooldownType, -1); }
  public static void AddReceiveType(FlatBufferBuilder builder, int ReceiveType) { builder.AddInt(6, ReceiveType, -1); }
  public static void AddReceiveID(FlatBufferBuilder builder, int ReceiveID) { builder.AddInt(7, ReceiveID, -1); }
  public static void AddPrefix(FlatBufferBuilder builder, int Prefix) { builder.AddInt(8, Prefix, -1); }
  public static void AddRoundDesc(FlatBufferBuilder builder, int RoundDesc) { builder.AddInt(9, RoundDesc, -1); }
  public static void AddRoundTitle(FlatBufferBuilder builder, int RoundTitle) { builder.AddInt(10, RoundTitle, -1); }
  public static void AddRoundTitleInBoard(FlatBufferBuilder builder, int RoundTitleInBoard) { builder.AddInt(11, RoundTitleInBoard, -1); }
  public static void AddShowItemIDList(FlatBufferBuilder builder, VectorOffset ShowItemIDListOffset) { builder.AddOffset(12, ShowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateShowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGetMissionCostType(FlatBufferBuilder builder, int GetMissionCostType) { builder.AddInt(13, GetMissionCostType, -1); }
  public static void AddGetMissionCost(FlatBufferBuilder builder, int GetMissionCost) { builder.AddInt(14, GetMissionCost, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(15, NameOffset.Value, 0); }
  public static void AddGiveupDictID(FlatBufferBuilder builder, int GiveupDictID) { builder.AddInt(16, GiveupDictID, -1); }
  public static void AddExpireType(FlatBufferBuilder builder, int ExpireType) { builder.AddInt(17, ExpireType, 1); }
  public static void AddExpireTime(FlatBufferBuilder builder, int ExpireTime) { builder.AddInt(18, ExpireTime, 1); }
  public static void AddIsAutoContinus(FlatBufferBuilder builder, bool IsAutoContinus) { builder.AddBool(19, IsAutoContinus, false); }
  public static void AddEndDesc(FlatBufferBuilder builder, int EndDesc) { builder.AddInt(20, EndDesc, -1); }
  public static void AddScriptId(FlatBufferBuilder builder, int ScriptId) { builder.AddInt(21, ScriptId, -1); }
  public static void AddVipNeed(FlatBufferBuilder builder, int VipNeed) { builder.AddInt(22, VipNeed, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(23, LevelLimit, -1); }
  public static void AddLevelDict(FlatBufferBuilder builder, int LevelDict) { builder.AddInt(24, LevelDict, -1); }
  public static Offset<FB_MissionRoundConfig> EndFB_MissionRoundConfig(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundConfig>(o);
  }
};

public sealed class FB_MissionRoundConfigContainer : Table {
  public static FB_MissionRoundConfigContainer GetRootAsFB_MissionRoundConfigContainer(ByteBuffer _bb) { return GetRootAsFB_MissionRoundConfigContainer(_bb, new FB_MissionRoundConfigContainer()); }
  public static FB_MissionRoundConfigContainer GetRootAsFB_MissionRoundConfigContainer(ByteBuffer _bb, FB_MissionRoundConfigContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionRoundConfigContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionRoundConfigContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionRoundConfig GetItems(int j) { return GetItems(new FB_MissionRoundConfig(), j); }
  public FB_MissionRoundConfig GetItems(FB_MissionRoundConfig obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionRoundConfigContainer> CreateFB_MissionRoundConfigContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionRoundConfigContainer.AddItems(builder, items);
    return FB_MissionRoundConfigContainer.EndFB_MissionRoundConfigContainer(builder);
  }

  public static void StartFB_MissionRoundConfigContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionRoundConfig>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionRoundConfigContainer> EndFB_MissionRoundConfigContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundConfigContainer>(o);
  }
  public static void FinishFB_MissionRoundConfigContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionRoundConfigContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
