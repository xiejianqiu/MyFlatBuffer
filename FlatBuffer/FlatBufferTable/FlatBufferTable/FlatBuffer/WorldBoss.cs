// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WorldBoss : Table {
  public static FB_WorldBoss GetRootAsFB_WorldBoss(ByteBuffer _bb) { return GetRootAsFB_WorldBoss(_bb, new FB_WorldBoss()); }
  public static FB_WorldBoss GetRootAsFB_WorldBoss(ByteBuffer _bb, FB_WorldBoss obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WorldBoss __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Class { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VIPLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostNum { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetShowItemIDList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemIDListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int SceneID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float PosX { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float PosZ { get { int o = __offset(30); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FaceDir { get { int o = __offset(32); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int RefreshType { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshParam { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Tired { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSureDropItemIDList(int j) { int o = __offset(40); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SureDropItemIDListLength { get { int o = __offset(40); return o != 0 ? __vector_len(o) : 0; } }
  public int PKDistance { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(44); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LevelLimit { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsSystemBroadcast { get { int o = __offset(48); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public long MaxHP { get { int o = __offset(50); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public int PAttack { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PMDefense { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Hit { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Dodge { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Penetrate { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Tenacity { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SecDropBox { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AwardType { get { int o = __offset(66); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowSkill { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldBossKillMFid { get { int o = __offset(70); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsFirstKillShow { get { int o = __offset(72); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetRewardMdId { get { int o = __offset(74); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetFirstKillItemIDList(int j) { int o = __offset(76); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FirstKillItemIDListLength { get { int o = __offset(76); return o != 0 ? __vector_len(o) : 0; } }
  public int GetKillItemIDList(int j) { int o = __offset(78); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int KillItemIDListLength { get { int o = __offset(78); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFirstKillItemCountList(int j) { int o = __offset(80); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FirstKillItemCountListLength { get { int o = __offset(80); return o != 0 ? __vector_len(o) : 0; } }
  public int GetKillItemCountList(int j) { int o = __offset(82); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int KillItemCountListLength { get { int o = __offset(82); return o != 0 ? __vector_len(o) : 0; } }
  public int BossFirstKillFakeObjID { get { int o = __offset(84); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RealIndex { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EquipmentOorder { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int KillCountMDid { get { int o = __offset(90); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BossMoney { get { int o = __offset(92); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMoneyType { get { int o = __offset(94); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int YuanShenLevel { get { int o = __offset(96); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OfflineExp { get { int o = __offset(98); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldServerType { get { int o = __offset(100); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshLevel { get { int o = __offset(102); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldAttackIce { get { int o = __offset(104); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldDefenceIce { get { int o = __offset(106); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldAttackFire { get { int o = __offset(108); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldDefenceFire { get { int o = __offset(110); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldAttackThunder { get { int o = __offset(112); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldDefenceThunder { get { int o = __offset(114); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldAttackElectric { get { int o = __offset(116); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldDefencekElectric { get { int o = __offset(118); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldAttackForst { get { int o = __offset(120); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldDefenceForst { get { int o = __offset(122); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldAttackSnow { get { int o = __offset(124); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldDefenceSnow { get { int o = __offset(126); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WorldBoss> CreateFB_WorldBoss(FlatBufferBuilder builder,
      int Id = 0,
      int Type = -1,
      int Param = -1,
      int Class = -1,
      int FakeObjID = -1,
      int VIPLimit = -1,
      int CostItemID = -1,
      int CostNum = -1,
      int MoneyType = -1,
      int MoneyCost = -1,
      VectorOffset ShowItemIDList = default(VectorOffset),
      int SceneID = -1,
      float PosX = -1,
      float PosZ = -1,
      float FaceDir = -1,
      int RefreshType = -1,
      int RefreshParam = -1,
      int Tired = -1,
      VectorOffset SureDropItemIDList = default(VectorOffset),
      int PKDistance = -1,
      StringOffset Icon = default(StringOffset),
      int LevelLimit = -1,
      bool IsSystemBroadcast = false,
      long MaxHP = 0,
      int PAttack = 0,
      int PMDefense = 0,
      int Hit = 0,
      int Dodge = 0,
      int Penetrate = 0,
      int Tenacity = 0,
      int SecDropBox = -1,
      int AwardType = -1,
      int ShowSkill = -1,
      int WorldBossKillMFid = -1,
      bool IsFirstKillShow = false,
      int GetRewardMdId = -1,
      VectorOffset FirstKillItemIDList = default(VectorOffset),
      VectorOffset KillItemIDList = default(VectorOffset),
      VectorOffset FirstKillItemCountList = default(VectorOffset),
      VectorOffset KillItemCountList = default(VectorOffset),
      int BossFirstKillFakeObjID = -1,
      int RealIndex = -1,
      int EquipmentOorder = -1,
      int KillCountMDid = -1,
      int BossMoney = -1,
      int GetMoneyType = -1,
      int YuanShenLevel = -1,
      int OfflineExp = -1,
      int WorldServerType = -1,
      int RefreshLevel = -1,
      int GoldAttackIce = -1,
      int GoldDefenceIce = -1,
      int GoldAttackFire = -1,
      int GoldDefenceFire = -1,
      int GoldAttackThunder = -1,
      int GoldDefenceThunder = -1,
      int GoldAttackElectric = -1,
      int GoldDefencekElectric = -1,
      int GoldAttackForst = -1,
      int GoldDefenceForst = -1,
      int GoldAttackSnow = -1,
      int GoldDefenceSnow = -1) {
    builder.StartObject(62);
    FB_WorldBoss.AddMaxHP(builder, MaxHP);
    FB_WorldBoss.AddGoldDefenceSnow(builder, GoldDefenceSnow);
    FB_WorldBoss.AddGoldAttackSnow(builder, GoldAttackSnow);
    FB_WorldBoss.AddGoldDefenceForst(builder, GoldDefenceForst);
    FB_WorldBoss.AddGoldAttackForst(builder, GoldAttackForst);
    FB_WorldBoss.AddGoldDefencekElectric(builder, GoldDefencekElectric);
    FB_WorldBoss.AddGoldAttackElectric(builder, GoldAttackElectric);
    FB_WorldBoss.AddGoldDefenceThunder(builder, GoldDefenceThunder);
    FB_WorldBoss.AddGoldAttackThunder(builder, GoldAttackThunder);
    FB_WorldBoss.AddGoldDefenceFire(builder, GoldDefenceFire);
    FB_WorldBoss.AddGoldAttackFire(builder, GoldAttackFire);
    FB_WorldBoss.AddGoldDefenceIce(builder, GoldDefenceIce);
    FB_WorldBoss.AddGoldAttackIce(builder, GoldAttackIce);
    FB_WorldBoss.AddRefreshLevel(builder, RefreshLevel);
    FB_WorldBoss.AddWorldServerType(builder, WorldServerType);
    FB_WorldBoss.AddOfflineExp(builder, OfflineExp);
    FB_WorldBoss.AddYuanShenLevel(builder, YuanShenLevel);
    FB_WorldBoss.AddGetMoneyType(builder, GetMoneyType);
    FB_WorldBoss.AddBossMoney(builder, BossMoney);
    FB_WorldBoss.AddKillCountMDid(builder, KillCountMDid);
    FB_WorldBoss.AddEquipmentOorder(builder, EquipmentOorder);
    FB_WorldBoss.AddRealIndex(builder, RealIndex);
    FB_WorldBoss.AddBossFirstKillFakeObjID(builder, BossFirstKillFakeObjID);
    FB_WorldBoss.AddKillItemCountList(builder, KillItemCountList);
    FB_WorldBoss.AddFirstKillItemCountList(builder, FirstKillItemCountList);
    FB_WorldBoss.AddKillItemIDList(builder, KillItemIDList);
    FB_WorldBoss.AddFirstKillItemIDList(builder, FirstKillItemIDList);
    FB_WorldBoss.AddGetRewardMdId(builder, GetRewardMdId);
    FB_WorldBoss.AddWorldBossKillMFid(builder, WorldBossKillMFid);
    FB_WorldBoss.AddShowSkill(builder, ShowSkill);
    FB_WorldBoss.AddAwardType(builder, AwardType);
    FB_WorldBoss.AddSecDropBox(builder, SecDropBox);
    FB_WorldBoss.AddTenacity(builder, Tenacity);
    FB_WorldBoss.AddPenetrate(builder, Penetrate);
    FB_WorldBoss.AddDodge(builder, Dodge);
    FB_WorldBoss.AddHit(builder, Hit);
    FB_WorldBoss.AddPMDefense(builder, PMDefense);
    FB_WorldBoss.AddPAttack(builder, PAttack);
    FB_WorldBoss.AddLevelLimit(builder, LevelLimit);
    FB_WorldBoss.AddIcon(builder, Icon);
    FB_WorldBoss.AddPKDistance(builder, PKDistance);
    FB_WorldBoss.AddSureDropItemIDList(builder, SureDropItemIDList);
    FB_WorldBoss.AddTired(builder, Tired);
    FB_WorldBoss.AddRefreshParam(builder, RefreshParam);
    FB_WorldBoss.AddRefreshType(builder, RefreshType);
    FB_WorldBoss.AddFaceDir(builder, FaceDir);
    FB_WorldBoss.AddPosZ(builder, PosZ);
    FB_WorldBoss.AddPosX(builder, PosX);
    FB_WorldBoss.AddSceneID(builder, SceneID);
    FB_WorldBoss.AddShowItemIDList(builder, ShowItemIDList);
    FB_WorldBoss.AddMoneyCost(builder, MoneyCost);
    FB_WorldBoss.AddMoneyType(builder, MoneyType);
    FB_WorldBoss.AddCostNum(builder, CostNum);
    FB_WorldBoss.AddCostItemID(builder, CostItemID);
    FB_WorldBoss.AddVIPLimit(builder, VIPLimit);
    FB_WorldBoss.AddFakeObjID(builder, FakeObjID);
    FB_WorldBoss.AddClass(builder, Class);
    FB_WorldBoss.AddParam(builder, Param);
    FB_WorldBoss.AddType(builder, Type);
    FB_WorldBoss.AddId(builder, Id);
    FB_WorldBoss.AddIsFirstKillShow(builder, IsFirstKillShow);
    FB_WorldBoss.AddIsSystemBroadcast(builder, IsSystemBroadcast);
    return FB_WorldBoss.EndFB_WorldBoss(builder);
  }

  public static void StartFB_WorldBoss(FlatBufferBuilder builder) { builder.StartObject(62); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(2, Param, -1); }
  public static void AddClass(FlatBufferBuilder builder, int Class) { builder.AddInt(3, Class, -1); }
  public static void AddFakeObjID(FlatBufferBuilder builder, int FakeObjID) { builder.AddInt(4, FakeObjID, -1); }
  public static void AddVIPLimit(FlatBufferBuilder builder, int VIPLimit) { builder.AddInt(5, VIPLimit, -1); }
  public static void AddCostItemID(FlatBufferBuilder builder, int CostItemID) { builder.AddInt(6, CostItemID, -1); }
  public static void AddCostNum(FlatBufferBuilder builder, int CostNum) { builder.AddInt(7, CostNum, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(8, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(9, MoneyCost, -1); }
  public static void AddShowItemIDList(FlatBufferBuilder builder, VectorOffset ShowItemIDListOffset) { builder.AddOffset(10, ShowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateShowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(11, SceneID, -1); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(12, PosX, -1); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(13, PosZ, -1); }
  public static void AddFaceDir(FlatBufferBuilder builder, float FaceDir) { builder.AddFloat(14, FaceDir, -1); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(15, RefreshType, -1); }
  public static void AddRefreshParam(FlatBufferBuilder builder, int RefreshParam) { builder.AddInt(16, RefreshParam, -1); }
  public static void AddTired(FlatBufferBuilder builder, int Tired) { builder.AddInt(17, Tired, -1); }
  public static void AddSureDropItemIDList(FlatBufferBuilder builder, VectorOffset SureDropItemIDListOffset) { builder.AddOffset(18, SureDropItemIDListOffset.Value, 0); }
  public static VectorOffset CreateSureDropItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSureDropItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPKDistance(FlatBufferBuilder builder, int PKDistance) { builder.AddInt(19, PKDistance, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(20, IconOffset.Value, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(21, LevelLimit, -1); }
  public static void AddIsSystemBroadcast(FlatBufferBuilder builder, bool IsSystemBroadcast) { builder.AddBool(22, IsSystemBroadcast, false); }
  public static void AddMaxHP(FlatBufferBuilder builder, long MaxHP) { builder.AddLong(23, MaxHP, 0); }
  public static void AddPAttack(FlatBufferBuilder builder, int PAttack) { builder.AddInt(24, PAttack, 0); }
  public static void AddPMDefense(FlatBufferBuilder builder, int PMDefense) { builder.AddInt(25, PMDefense, 0); }
  public static void AddHit(FlatBufferBuilder builder, int Hit) { builder.AddInt(26, Hit, 0); }
  public static void AddDodge(FlatBufferBuilder builder, int Dodge) { builder.AddInt(27, Dodge, 0); }
  public static void AddPenetrate(FlatBufferBuilder builder, int Penetrate) { builder.AddInt(28, Penetrate, 0); }
  public static void AddTenacity(FlatBufferBuilder builder, int Tenacity) { builder.AddInt(29, Tenacity, 0); }
  public static void AddSecDropBox(FlatBufferBuilder builder, int SecDropBox) { builder.AddInt(30, SecDropBox, -1); }
  public static void AddAwardType(FlatBufferBuilder builder, int AwardType) { builder.AddInt(31, AwardType, -1); }
  public static void AddShowSkill(FlatBufferBuilder builder, int ShowSkill) { builder.AddInt(32, ShowSkill, -1); }
  public static void AddWorldBossKillMFid(FlatBufferBuilder builder, int WorldBossKillMFid) { builder.AddInt(33, WorldBossKillMFid, -1); }
  public static void AddIsFirstKillShow(FlatBufferBuilder builder, bool IsFirstKillShow) { builder.AddBool(34, IsFirstKillShow, false); }
  public static void AddGetRewardMdId(FlatBufferBuilder builder, int GetRewardMdId) { builder.AddInt(35, GetRewardMdId, -1); }
  public static void AddFirstKillItemIDList(FlatBufferBuilder builder, VectorOffset FirstKillItemIDListOffset) { builder.AddOffset(36, FirstKillItemIDListOffset.Value, 0); }
  public static VectorOffset CreateFirstKillItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFirstKillItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddKillItemIDList(FlatBufferBuilder builder, VectorOffset KillItemIDListOffset) { builder.AddOffset(37, KillItemIDListOffset.Value, 0); }
  public static VectorOffset CreateKillItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartKillItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFirstKillItemCountList(FlatBufferBuilder builder, VectorOffset FirstKillItemCountListOffset) { builder.AddOffset(38, FirstKillItemCountListOffset.Value, 0); }
  public static VectorOffset CreateFirstKillItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFirstKillItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddKillItemCountList(FlatBufferBuilder builder, VectorOffset KillItemCountListOffset) { builder.AddOffset(39, KillItemCountListOffset.Value, 0); }
  public static VectorOffset CreateKillItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartKillItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBossFirstKillFakeObjID(FlatBufferBuilder builder, int BossFirstKillFakeObjID) { builder.AddInt(40, BossFirstKillFakeObjID, -1); }
  public static void AddRealIndex(FlatBufferBuilder builder, int RealIndex) { builder.AddInt(41, RealIndex, -1); }
  public static void AddEquipmentOorder(FlatBufferBuilder builder, int EquipmentOorder) { builder.AddInt(42, EquipmentOorder, -1); }
  public static void AddKillCountMDid(FlatBufferBuilder builder, int KillCountMDid) { builder.AddInt(43, KillCountMDid, -1); }
  public static void AddBossMoney(FlatBufferBuilder builder, int BossMoney) { builder.AddInt(44, BossMoney, -1); }
  public static void AddGetMoneyType(FlatBufferBuilder builder, int GetMoneyType) { builder.AddInt(45, GetMoneyType, -1); }
  public static void AddYuanShenLevel(FlatBufferBuilder builder, int YuanShenLevel) { builder.AddInt(46, YuanShenLevel, -1); }
  public static void AddOfflineExp(FlatBufferBuilder builder, int OfflineExp) { builder.AddInt(47, OfflineExp, -1); }
  public static void AddWorldServerType(FlatBufferBuilder builder, int WorldServerType) { builder.AddInt(48, WorldServerType, -1); }
  public static void AddRefreshLevel(FlatBufferBuilder builder, int RefreshLevel) { builder.AddInt(49, RefreshLevel, -1); }
  public static void AddGoldAttackIce(FlatBufferBuilder builder, int GoldAttackIce) { builder.AddInt(50, GoldAttackIce, -1); }
  public static void AddGoldDefenceIce(FlatBufferBuilder builder, int GoldDefenceIce) { builder.AddInt(51, GoldDefenceIce, -1); }
  public static void AddGoldAttackFire(FlatBufferBuilder builder, int GoldAttackFire) { builder.AddInt(52, GoldAttackFire, -1); }
  public static void AddGoldDefenceFire(FlatBufferBuilder builder, int GoldDefenceFire) { builder.AddInt(53, GoldDefenceFire, -1); }
  public static void AddGoldAttackThunder(FlatBufferBuilder builder, int GoldAttackThunder) { builder.AddInt(54, GoldAttackThunder, -1); }
  public static void AddGoldDefenceThunder(FlatBufferBuilder builder, int GoldDefenceThunder) { builder.AddInt(55, GoldDefenceThunder, -1); }
  public static void AddGoldAttackElectric(FlatBufferBuilder builder, int GoldAttackElectric) { builder.AddInt(56, GoldAttackElectric, -1); }
  public static void AddGoldDefencekElectric(FlatBufferBuilder builder, int GoldDefencekElectric) { builder.AddInt(57, GoldDefencekElectric, -1); }
  public static void AddGoldAttackForst(FlatBufferBuilder builder, int GoldAttackForst) { builder.AddInt(58, GoldAttackForst, -1); }
  public static void AddGoldDefenceForst(FlatBufferBuilder builder, int GoldDefenceForst) { builder.AddInt(59, GoldDefenceForst, -1); }
  public static void AddGoldAttackSnow(FlatBufferBuilder builder, int GoldAttackSnow) { builder.AddInt(60, GoldAttackSnow, -1); }
  public static void AddGoldDefenceSnow(FlatBufferBuilder builder, int GoldDefenceSnow) { builder.AddInt(61, GoldDefenceSnow, -1); }
  public static Offset<FB_WorldBoss> EndFB_WorldBoss(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WorldBoss>(o);
  }
};

public sealed class FB_WorldBossContainer : Table {
  public static FB_WorldBossContainer GetRootAsFB_WorldBossContainer(ByteBuffer _bb) { return GetRootAsFB_WorldBossContainer(_bb, new FB_WorldBossContainer()); }
  public static FB_WorldBossContainer GetRootAsFB_WorldBossContainer(ByteBuffer _bb, FB_WorldBossContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WorldBossContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WorldBossContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WorldBoss GetItems(int j) { return GetItems(new FB_WorldBoss(), j); }
  public FB_WorldBoss GetItems(FB_WorldBoss obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WorldBossContainer> CreateFB_WorldBossContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WorldBossContainer.AddItems(builder, items);
    return FB_WorldBossContainer.EndFB_WorldBossContainer(builder);
  }

  public static void StartFB_WorldBossContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WorldBoss>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WorldBossContainer> EndFB_WorldBossContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WorldBossContainer>(o);
  }
  public static void FinishFB_WorldBossContainerBuffer(FlatBufferBuilder builder, Offset<FB_WorldBossContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
