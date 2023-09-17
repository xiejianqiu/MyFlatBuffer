// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CopySceneTower : Table {
  public static FB_CopySceneTower GetRootAsFB_CopySceneTower(ByteBuffer _bb) { return GetRootAsFB_CopySceneTower(_bb, new FB_CopySceneTower()); }
  public static FB_CopySceneTower GetRootAsFB_CopySceneTower(ByteBuffer _bb, FB_CopySceneTower obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CopySceneTower __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string TowerName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RankTowerName { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DescStrDictID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StageClearDrop { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StageClearRuneExp { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MosterFakeObjId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMonsterIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MonsterIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMonsterPosXList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MonsterPosXListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMonsterPosZList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MonsterPosZListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public float GetMonsterRotationList(int j) { int o = __offset(26); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int MonsterRotationListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int RecommendPower { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsUnlockRune { get { int o = __offset(30); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int LevelLimit { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TowerNumString { get { int o = __offset(34); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetRewardItemIDList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIDListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemCountList(int j) { int o = __offset(38); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemCountListLength { get { int o = __offset(38); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardJobIDList(int j) { int o = __offset(40); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardJobIDListLength { get { int o = __offset(40); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneTower> CreateFB_CopySceneTower(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset TowerName = default(StringOffset),
      StringOffset Name = default(StringOffset),
      StringOffset RankTowerName = default(StringOffset),
      int DescStrDictID = -1,
      int StageClearDrop = -1,
      int StageClearRuneExp = -1,
      int MosterFakeObjId = -1,
      VectorOffset MonsterIDList = default(VectorOffset),
      VectorOffset MonsterPosXList = default(VectorOffset),
      VectorOffset MonsterPosZList = default(VectorOffset),
      VectorOffset MonsterRotationList = default(VectorOffset),
      int RecommendPower = -1,
      bool IsUnlockRune = false,
      int LevelLimit = -1,
      StringOffset TowerNumString = default(StringOffset),
      VectorOffset RewardItemIDList = default(VectorOffset),
      VectorOffset RewardItemCountList = default(VectorOffset),
      VectorOffset RewardJobIDList = default(VectorOffset)) {
    builder.StartObject(19);
    FB_CopySceneTower.AddRewardJobIDList(builder, RewardJobIDList);
    FB_CopySceneTower.AddRewardItemCountList(builder, RewardItemCountList);
    FB_CopySceneTower.AddRewardItemIDList(builder, RewardItemIDList);
    FB_CopySceneTower.AddTowerNumString(builder, TowerNumString);
    FB_CopySceneTower.AddLevelLimit(builder, LevelLimit);
    FB_CopySceneTower.AddRecommendPower(builder, RecommendPower);
    FB_CopySceneTower.AddMonsterRotationList(builder, MonsterRotationList);
    FB_CopySceneTower.AddMonsterPosZList(builder, MonsterPosZList);
    FB_CopySceneTower.AddMonsterPosXList(builder, MonsterPosXList);
    FB_CopySceneTower.AddMonsterIDList(builder, MonsterIDList);
    FB_CopySceneTower.AddMosterFakeObjId(builder, MosterFakeObjId);
    FB_CopySceneTower.AddStageClearRuneExp(builder, StageClearRuneExp);
    FB_CopySceneTower.AddStageClearDrop(builder, StageClearDrop);
    FB_CopySceneTower.AddDescStrDictID(builder, DescStrDictID);
    FB_CopySceneTower.AddRankTowerName(builder, RankTowerName);
    FB_CopySceneTower.AddName(builder, Name);
    FB_CopySceneTower.AddTowerName(builder, TowerName);
    FB_CopySceneTower.AddId(builder, Id);
    FB_CopySceneTower.AddIsUnlockRune(builder, IsUnlockRune);
    return FB_CopySceneTower.EndFB_CopySceneTower(builder);
  }

  public static void StartFB_CopySceneTower(FlatBufferBuilder builder) { builder.StartObject(19); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTowerName(FlatBufferBuilder builder, StringOffset TowerNameOffset) { builder.AddOffset(1, TowerNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddRankTowerName(FlatBufferBuilder builder, StringOffset RankTowerNameOffset) { builder.AddOffset(3, RankTowerNameOffset.Value, 0); }
  public static void AddDescStrDictID(FlatBufferBuilder builder, int DescStrDictID) { builder.AddInt(4, DescStrDictID, -1); }
  public static void AddStageClearDrop(FlatBufferBuilder builder, int StageClearDrop) { builder.AddInt(5, StageClearDrop, -1); }
  public static void AddStageClearRuneExp(FlatBufferBuilder builder, int StageClearRuneExp) { builder.AddInt(6, StageClearRuneExp, -1); }
  public static void AddMosterFakeObjId(FlatBufferBuilder builder, int MosterFakeObjId) { builder.AddInt(7, MosterFakeObjId, -1); }
  public static void AddMonsterIDList(FlatBufferBuilder builder, VectorOffset MonsterIDListOffset) { builder.AddOffset(8, MonsterIDListOffset.Value, 0); }
  public static VectorOffset CreateMonsterIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMonsterIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMonsterPosXList(FlatBufferBuilder builder, VectorOffset MonsterPosXListOffset) { builder.AddOffset(9, MonsterPosXListOffset.Value, 0); }
  public static VectorOffset CreateMonsterPosXListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMonsterPosXListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMonsterPosZList(FlatBufferBuilder builder, VectorOffset MonsterPosZListOffset) { builder.AddOffset(10, MonsterPosZListOffset.Value, 0); }
  public static VectorOffset CreateMonsterPosZListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMonsterPosZListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMonsterRotationList(FlatBufferBuilder builder, VectorOffset MonsterRotationListOffset) { builder.AddOffset(11, MonsterRotationListOffset.Value, 0); }
  public static VectorOffset CreateMonsterRotationListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartMonsterRotationListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRecommendPower(FlatBufferBuilder builder, int RecommendPower) { builder.AddInt(12, RecommendPower, -1); }
  public static void AddIsUnlockRune(FlatBufferBuilder builder, bool IsUnlockRune) { builder.AddBool(13, IsUnlockRune, false); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(14, LevelLimit, -1); }
  public static void AddTowerNumString(FlatBufferBuilder builder, StringOffset TowerNumStringOffset) { builder.AddOffset(15, TowerNumStringOffset.Value, 0); }
  public static void AddRewardItemIDList(FlatBufferBuilder builder, VectorOffset RewardItemIDListOffset) { builder.AddOffset(16, RewardItemIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemCountList(FlatBufferBuilder builder, VectorOffset RewardItemCountListOffset) { builder.AddOffset(17, RewardItemCountListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardJobIDList(FlatBufferBuilder builder, VectorOffset RewardJobIDListOffset) { builder.AddOffset(18, RewardJobIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardJobIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardJobIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneTower> EndFB_CopySceneTower(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneTower>(o);
  }
};

public sealed class FB_CopySceneTowerContainer : Table {
  public static FB_CopySceneTowerContainer GetRootAsFB_CopySceneTowerContainer(ByteBuffer _bb) { return GetRootAsFB_CopySceneTowerContainer(_bb, new FB_CopySceneTowerContainer()); }
  public static FB_CopySceneTowerContainer GetRootAsFB_CopySceneTowerContainer(ByteBuffer _bb, FB_CopySceneTowerContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CopySceneTowerContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CopySceneTowerContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CopySceneTower GetItems(int j) { return GetItems(new FB_CopySceneTower(), j); }
  public FB_CopySceneTower GetItems(FB_CopySceneTower obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneTowerContainer> CreateFB_CopySceneTowerContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CopySceneTowerContainer.AddItems(builder, items);
    return FB_CopySceneTowerContainer.EndFB_CopySceneTowerContainer(builder);
  }

  public static void StartFB_CopySceneTowerContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CopySceneTower>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneTowerContainer> EndFB_CopySceneTowerContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneTowerContainer>(o);
  }
  public static void FinishFB_CopySceneTowerContainerBuffer(FlatBufferBuilder builder, Offset<FB_CopySceneTowerContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
