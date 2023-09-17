// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CopySceneLimit : Table {
  public static FB_CopySceneLimit GetRootAsFB_CopySceneLimit(ByteBuffer _bb) { return GetRootAsFB_CopySceneLimit(_bb, new FB_CopySceneLimit()); }
  public static FB_CopySceneLimit GetRootAsFB_CopySceneLimit(ByteBuffer _bb, FB_CopySceneLimit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CopySceneLimit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CopySceneType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdaptType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinAdvanced { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxAdvance { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)81; } }
  public int MinLvl { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLvl { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)999; } }
  public int MinMenCount { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int MaxMemCount { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int AttendTimes { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)3; } }
  public int RefreshType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MDId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ScriptId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WaitStarTime { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)3000; } }
  public int LogicTime { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)600000; } }
  public int WaitEndTime { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)5000; } }
  public int LogicInterval { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)5000; } }
  public int RankID { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityID { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CsBonusRefresh { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CSBonusTimes { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CSBonusID { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CSBonusMDID { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExtraPassLimit { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExtraPassReward { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HelpWeakLimit { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HelpWeakReward { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LeaderShipsTime { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LeaderReward { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MemberReward { get { int o = __offset(66); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TeamMoneyMDID { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassIndex { get { int o = __offset(70); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReliveTimes { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FriendValue { get { int o = __offset(74); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TargetDictID { get { int o = __offset(76); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetGuideDictIDList(int j) { int o = __offset(78); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GuideDictIDListLength { get { int o = __offset(78); return o != 0 ? __vector_len(o) : 0; } }
  public int DamageRankID { get { int o = __offset(80); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TeamPlatformId { get { int o = __offset(82); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissionLimitID { get { int o = __offset(84); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReliveMdid { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BuyAttendTimesMDID { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UseItemAddCountID { get { int o = __offset(90); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CoolDownTimeMDID { get { int o = __offset(92); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CoolDownTime { get { int o = __offset(94); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemID { get { int o = __offset(96); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostNum { get { int o = __offset(98); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IntroduceId { get { int o = __offset(100); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanMopUp { get { int o = __offset(102); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanGotoCopyScene { get { int o = __offset(104); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int VIPLimitID { get { int o = __offset(106); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BuyCostID { get { int o = __offset(108); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsNowCount { get { int o = __offset(110); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int SJMissionLimit { get { int o = __offset(112); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowAutoExit { get { int o = __offset(114); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int EvaluationId { get { int o = __offset(116); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowMov { get { int o = __offset(118); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int EvaluationLogic { get { int o = __offset(120); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TreasureId { get { int o = __offset(122); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int XianYuID { get { int o = __offset(124); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CDLevelLimit { get { int o = __offset(126); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CarnivalId { get { int o = __offset(128); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelSealId { get { int o = __offset(130); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsDieEnd { get { int o = __offset(132); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ChangeJobLimit { get { int o = __offset(134); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CopySceneLimit> CreateFB_CopySceneLimit(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int CopySceneType = -1,
      int AdaptType = -1,
      int MinAdvanced = -1,
      int MaxAdvance = 81,
      int MinLvl = -1,
      int MaxLvl = 999,
      int MinMenCount = 1,
      int MaxMemCount = 1,
      int AttendTimes = 3,
      int RefreshType = 0,
      int MDId = -1,
      int SceneId = -1,
      int ScriptId = -1,
      int WaitStarTime = 3000,
      int LogicTime = 600000,
      int WaitEndTime = 5000,
      int LogicInterval = 5000,
      int RankID = -1,
      int ActivityID = -1,
      int CsBonusRefresh = 0,
      int CSBonusTimes = -1,
      int CSBonusID = -1,
      int CSBonusMDID = -1,
      int ExtraPassLimit = -1,
      int ExtraPassReward = -1,
      int HelpWeakLimit = -1,
      int HelpWeakReward = -1,
      int LeaderShipsTime = -1,
      int LeaderReward = -1,
      int MemberReward = -1,
      int TeamMoneyMDID = -1,
      int PassIndex = -1,
      int ReliveTimes = -1,
      int FriendValue = -1,
      int TargetDictID = -1,
      VectorOffset GuideDictIDList = default(VectorOffset),
      int DamageRankID = -1,
      int TeamPlatformId = -1,
      int MissionLimitID = -1,
      int ReliveMdid = -1,
      int BuyAttendTimesMDID = -1,
      int UseItemAddCountID = -1,
      int CoolDownTimeMDID = -1,
      int CoolDownTime = -1,
      int CostItemID = -1,
      int CostNum = -1,
      int IntroduceId = -1,
      bool CanMopUp = false,
      bool CanGotoCopyScene = false,
      int VIPLimitID = -1,
      int BuyCostID = -1,
      bool IsNowCount = false,
      int SJMissionLimit = -1,
      bool IsShowAutoExit = false,
      int EvaluationId = -1,
      bool IsShowMov = false,
      int EvaluationLogic = -1,
      int TreasureId = -1,
      int XianYuID = -1,
      int CDLevelLimit = -1,
      int CarnivalId = -1,
      int LevelSealId = -1,
      bool IsDieEnd = false,
      int ChangeJobLimit = -1) {
    builder.StartObject(66);
    FB_CopySceneLimit.AddChangeJobLimit(builder, ChangeJobLimit);
    FB_CopySceneLimit.AddLevelSealId(builder, LevelSealId);
    FB_CopySceneLimit.AddCarnivalId(builder, CarnivalId);
    FB_CopySceneLimit.AddCDLevelLimit(builder, CDLevelLimit);
    FB_CopySceneLimit.AddXianYuID(builder, XianYuID);
    FB_CopySceneLimit.AddTreasureId(builder, TreasureId);
    FB_CopySceneLimit.AddEvaluationLogic(builder, EvaluationLogic);
    FB_CopySceneLimit.AddEvaluationId(builder, EvaluationId);
    FB_CopySceneLimit.AddSJMissionLimit(builder, SJMissionLimit);
    FB_CopySceneLimit.AddBuyCostID(builder, BuyCostID);
    FB_CopySceneLimit.AddVIPLimitID(builder, VIPLimitID);
    FB_CopySceneLimit.AddIntroduceId(builder, IntroduceId);
    FB_CopySceneLimit.AddCostNum(builder, CostNum);
    FB_CopySceneLimit.AddCostItemID(builder, CostItemID);
    FB_CopySceneLimit.AddCoolDownTime(builder, CoolDownTime);
    FB_CopySceneLimit.AddCoolDownTimeMDID(builder, CoolDownTimeMDID);
    FB_CopySceneLimit.AddUseItemAddCountID(builder, UseItemAddCountID);
    FB_CopySceneLimit.AddBuyAttendTimesMDID(builder, BuyAttendTimesMDID);
    FB_CopySceneLimit.AddReliveMdid(builder, ReliveMdid);
    FB_CopySceneLimit.AddMissionLimitID(builder, MissionLimitID);
    FB_CopySceneLimit.AddTeamPlatformId(builder, TeamPlatformId);
    FB_CopySceneLimit.AddDamageRankID(builder, DamageRankID);
    FB_CopySceneLimit.AddGuideDictIDList(builder, GuideDictIDList);
    FB_CopySceneLimit.AddTargetDictID(builder, TargetDictID);
    FB_CopySceneLimit.AddFriendValue(builder, FriendValue);
    FB_CopySceneLimit.AddReliveTimes(builder, ReliveTimes);
    FB_CopySceneLimit.AddPassIndex(builder, PassIndex);
    FB_CopySceneLimit.AddTeamMoneyMDID(builder, TeamMoneyMDID);
    FB_CopySceneLimit.AddMemberReward(builder, MemberReward);
    FB_CopySceneLimit.AddLeaderReward(builder, LeaderReward);
    FB_CopySceneLimit.AddLeaderShipsTime(builder, LeaderShipsTime);
    FB_CopySceneLimit.AddHelpWeakReward(builder, HelpWeakReward);
    FB_CopySceneLimit.AddHelpWeakLimit(builder, HelpWeakLimit);
    FB_CopySceneLimit.AddExtraPassReward(builder, ExtraPassReward);
    FB_CopySceneLimit.AddExtraPassLimit(builder, ExtraPassLimit);
    FB_CopySceneLimit.AddCSBonusMDID(builder, CSBonusMDID);
    FB_CopySceneLimit.AddCSBonusID(builder, CSBonusID);
    FB_CopySceneLimit.AddCSBonusTimes(builder, CSBonusTimes);
    FB_CopySceneLimit.AddCsBonusRefresh(builder, CsBonusRefresh);
    FB_CopySceneLimit.AddActivityID(builder, ActivityID);
    FB_CopySceneLimit.AddRankID(builder, RankID);
    FB_CopySceneLimit.AddLogicInterval(builder, LogicInterval);
    FB_CopySceneLimit.AddWaitEndTime(builder, WaitEndTime);
    FB_CopySceneLimit.AddLogicTime(builder, LogicTime);
    FB_CopySceneLimit.AddWaitStarTime(builder, WaitStarTime);
    FB_CopySceneLimit.AddScriptId(builder, ScriptId);
    FB_CopySceneLimit.AddSceneId(builder, SceneId);
    FB_CopySceneLimit.AddMDId(builder, MDId);
    FB_CopySceneLimit.AddRefreshType(builder, RefreshType);
    FB_CopySceneLimit.AddAttendTimes(builder, AttendTimes);
    FB_CopySceneLimit.AddMaxMemCount(builder, MaxMemCount);
    FB_CopySceneLimit.AddMinMenCount(builder, MinMenCount);
    FB_CopySceneLimit.AddMaxLvl(builder, MaxLvl);
    FB_CopySceneLimit.AddMinLvl(builder, MinLvl);
    FB_CopySceneLimit.AddMaxAdvance(builder, MaxAdvance);
    FB_CopySceneLimit.AddMinAdvanced(builder, MinAdvanced);
    FB_CopySceneLimit.AddAdaptType(builder, AdaptType);
    FB_CopySceneLimit.AddCopySceneType(builder, CopySceneType);
    FB_CopySceneLimit.AddName(builder, Name);
    FB_CopySceneLimit.AddId(builder, Id);
    FB_CopySceneLimit.AddIsDieEnd(builder, IsDieEnd);
    FB_CopySceneLimit.AddIsShowMov(builder, IsShowMov);
    FB_CopySceneLimit.AddIsShowAutoExit(builder, IsShowAutoExit);
    FB_CopySceneLimit.AddIsNowCount(builder, IsNowCount);
    FB_CopySceneLimit.AddCanGotoCopyScene(builder, CanGotoCopyScene);
    FB_CopySceneLimit.AddCanMopUp(builder, CanMopUp);
    return FB_CopySceneLimit.EndFB_CopySceneLimit(builder);
  }

  public static void StartFB_CopySceneLimit(FlatBufferBuilder builder) { builder.StartObject(66); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddCopySceneType(FlatBufferBuilder builder, int CopySceneType) { builder.AddInt(2, CopySceneType, -1); }
  public static void AddAdaptType(FlatBufferBuilder builder, int AdaptType) { builder.AddInt(3, AdaptType, -1); }
  public static void AddMinAdvanced(FlatBufferBuilder builder, int MinAdvanced) { builder.AddInt(4, MinAdvanced, -1); }
  public static void AddMaxAdvance(FlatBufferBuilder builder, int MaxAdvance) { builder.AddInt(5, MaxAdvance, 81); }
  public static void AddMinLvl(FlatBufferBuilder builder, int MinLvl) { builder.AddInt(6, MinLvl, -1); }
  public static void AddMaxLvl(FlatBufferBuilder builder, int MaxLvl) { builder.AddInt(7, MaxLvl, 999); }
  public static void AddMinMenCount(FlatBufferBuilder builder, int MinMenCount) { builder.AddInt(8, MinMenCount, 1); }
  public static void AddMaxMemCount(FlatBufferBuilder builder, int MaxMemCount) { builder.AddInt(9, MaxMemCount, 1); }
  public static void AddAttendTimes(FlatBufferBuilder builder, int AttendTimes) { builder.AddInt(10, AttendTimes, 3); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(11, RefreshType, 0); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(12, MDId, -1); }
  public static void AddSceneId(FlatBufferBuilder builder, int SceneId) { builder.AddInt(13, SceneId, -1); }
  public static void AddScriptId(FlatBufferBuilder builder, int ScriptId) { builder.AddInt(14, ScriptId, -1); }
  public static void AddWaitStarTime(FlatBufferBuilder builder, int WaitStarTime) { builder.AddInt(15, WaitStarTime, 3000); }
  public static void AddLogicTime(FlatBufferBuilder builder, int LogicTime) { builder.AddInt(16, LogicTime, 600000); }
  public static void AddWaitEndTime(FlatBufferBuilder builder, int WaitEndTime) { builder.AddInt(17, WaitEndTime, 5000); }
  public static void AddLogicInterval(FlatBufferBuilder builder, int LogicInterval) { builder.AddInt(18, LogicInterval, 5000); }
  public static void AddRankID(FlatBufferBuilder builder, int RankID) { builder.AddInt(19, RankID, -1); }
  public static void AddActivityID(FlatBufferBuilder builder, int ActivityID) { builder.AddInt(20, ActivityID, -1); }
  public static void AddCsBonusRefresh(FlatBufferBuilder builder, int CsBonusRefresh) { builder.AddInt(21, CsBonusRefresh, 0); }
  public static void AddCSBonusTimes(FlatBufferBuilder builder, int CSBonusTimes) { builder.AddInt(22, CSBonusTimes, -1); }
  public static void AddCSBonusID(FlatBufferBuilder builder, int CSBonusID) { builder.AddInt(23, CSBonusID, -1); }
  public static void AddCSBonusMDID(FlatBufferBuilder builder, int CSBonusMDID) { builder.AddInt(24, CSBonusMDID, -1); }
  public static void AddExtraPassLimit(FlatBufferBuilder builder, int ExtraPassLimit) { builder.AddInt(25, ExtraPassLimit, -1); }
  public static void AddExtraPassReward(FlatBufferBuilder builder, int ExtraPassReward) { builder.AddInt(26, ExtraPassReward, -1); }
  public static void AddHelpWeakLimit(FlatBufferBuilder builder, int HelpWeakLimit) { builder.AddInt(27, HelpWeakLimit, -1); }
  public static void AddHelpWeakReward(FlatBufferBuilder builder, int HelpWeakReward) { builder.AddInt(28, HelpWeakReward, -1); }
  public static void AddLeaderShipsTime(FlatBufferBuilder builder, int LeaderShipsTime) { builder.AddInt(29, LeaderShipsTime, -1); }
  public static void AddLeaderReward(FlatBufferBuilder builder, int LeaderReward) { builder.AddInt(30, LeaderReward, -1); }
  public static void AddMemberReward(FlatBufferBuilder builder, int MemberReward) { builder.AddInt(31, MemberReward, -1); }
  public static void AddTeamMoneyMDID(FlatBufferBuilder builder, int TeamMoneyMDID) { builder.AddInt(32, TeamMoneyMDID, -1); }
  public static void AddPassIndex(FlatBufferBuilder builder, int PassIndex) { builder.AddInt(33, PassIndex, -1); }
  public static void AddReliveTimes(FlatBufferBuilder builder, int ReliveTimes) { builder.AddInt(34, ReliveTimes, -1); }
  public static void AddFriendValue(FlatBufferBuilder builder, int FriendValue) { builder.AddInt(35, FriendValue, -1); }
  public static void AddTargetDictID(FlatBufferBuilder builder, int TargetDictID) { builder.AddInt(36, TargetDictID, -1); }
  public static void AddGuideDictIDList(FlatBufferBuilder builder, VectorOffset GuideDictIDListOffset) { builder.AddOffset(37, GuideDictIDListOffset.Value, 0); }
  public static VectorOffset CreateGuideDictIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGuideDictIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDamageRankID(FlatBufferBuilder builder, int DamageRankID) { builder.AddInt(38, DamageRankID, -1); }
  public static void AddTeamPlatformId(FlatBufferBuilder builder, int TeamPlatformId) { builder.AddInt(39, TeamPlatformId, -1); }
  public static void AddMissionLimitID(FlatBufferBuilder builder, int MissionLimitID) { builder.AddInt(40, MissionLimitID, -1); }
  public static void AddReliveMdid(FlatBufferBuilder builder, int ReliveMdid) { builder.AddInt(41, ReliveMdid, -1); }
  public static void AddBuyAttendTimesMDID(FlatBufferBuilder builder, int BuyAttendTimesMDID) { builder.AddInt(42, BuyAttendTimesMDID, -1); }
  public static void AddUseItemAddCountID(FlatBufferBuilder builder, int UseItemAddCountID) { builder.AddInt(43, UseItemAddCountID, -1); }
  public static void AddCoolDownTimeMDID(FlatBufferBuilder builder, int CoolDownTimeMDID) { builder.AddInt(44, CoolDownTimeMDID, -1); }
  public static void AddCoolDownTime(FlatBufferBuilder builder, int CoolDownTime) { builder.AddInt(45, CoolDownTime, -1); }
  public static void AddCostItemID(FlatBufferBuilder builder, int CostItemID) { builder.AddInt(46, CostItemID, -1); }
  public static void AddCostNum(FlatBufferBuilder builder, int CostNum) { builder.AddInt(47, CostNum, -1); }
  public static void AddIntroduceId(FlatBufferBuilder builder, int IntroduceId) { builder.AddInt(48, IntroduceId, -1); }
  public static void AddCanMopUp(FlatBufferBuilder builder, bool CanMopUp) { builder.AddBool(49, CanMopUp, false); }
  public static void AddCanGotoCopyScene(FlatBufferBuilder builder, bool CanGotoCopyScene) { builder.AddBool(50, CanGotoCopyScene, false); }
  public static void AddVIPLimitID(FlatBufferBuilder builder, int VIPLimitID) { builder.AddInt(51, VIPLimitID, -1); }
  public static void AddBuyCostID(FlatBufferBuilder builder, int BuyCostID) { builder.AddInt(52, BuyCostID, -1); }
  public static void AddIsNowCount(FlatBufferBuilder builder, bool IsNowCount) { builder.AddBool(53, IsNowCount, false); }
  public static void AddSJMissionLimit(FlatBufferBuilder builder, int SJMissionLimit) { builder.AddInt(54, SJMissionLimit, -1); }
  public static void AddIsShowAutoExit(FlatBufferBuilder builder, bool IsShowAutoExit) { builder.AddBool(55, IsShowAutoExit, false); }
  public static void AddEvaluationId(FlatBufferBuilder builder, int EvaluationId) { builder.AddInt(56, EvaluationId, -1); }
  public static void AddIsShowMov(FlatBufferBuilder builder, bool IsShowMov) { builder.AddBool(57, IsShowMov, false); }
  public static void AddEvaluationLogic(FlatBufferBuilder builder, int EvaluationLogic) { builder.AddInt(58, EvaluationLogic, -1); }
  public static void AddTreasureId(FlatBufferBuilder builder, int TreasureId) { builder.AddInt(59, TreasureId, -1); }
  public static void AddXianYuID(FlatBufferBuilder builder, int XianYuID) { builder.AddInt(60, XianYuID, -1); }
  public static void AddCDLevelLimit(FlatBufferBuilder builder, int CDLevelLimit) { builder.AddInt(61, CDLevelLimit, -1); }
  public static void AddCarnivalId(FlatBufferBuilder builder, int CarnivalId) { builder.AddInt(62, CarnivalId, -1); }
  public static void AddLevelSealId(FlatBufferBuilder builder, int LevelSealId) { builder.AddInt(63, LevelSealId, -1); }
  public static void AddIsDieEnd(FlatBufferBuilder builder, bool IsDieEnd) { builder.AddBool(64, IsDieEnd, false); }
  public static void AddChangeJobLimit(FlatBufferBuilder builder, int ChangeJobLimit) { builder.AddInt(65, ChangeJobLimit, -1); }
  public static Offset<FB_CopySceneLimit> EndFB_CopySceneLimit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneLimit>(o);
  }
};

public sealed class FB_CopySceneLimitContainer : Table {
  public static FB_CopySceneLimitContainer GetRootAsFB_CopySceneLimitContainer(ByteBuffer _bb) { return GetRootAsFB_CopySceneLimitContainer(_bb, new FB_CopySceneLimitContainer()); }
  public static FB_CopySceneLimitContainer GetRootAsFB_CopySceneLimitContainer(ByteBuffer _bb, FB_CopySceneLimitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CopySceneLimitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CopySceneLimitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CopySceneLimit GetItems(int j) { return GetItems(new FB_CopySceneLimit(), j); }
  public FB_CopySceneLimit GetItems(FB_CopySceneLimit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneLimitContainer> CreateFB_CopySceneLimitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CopySceneLimitContainer.AddItems(builder, items);
    return FB_CopySceneLimitContainer.EndFB_CopySceneLimitContainer(builder);
  }

  public static void StartFB_CopySceneLimitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CopySceneLimit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneLimitContainer> EndFB_CopySceneLimitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneLimitContainer>(o);
  }
  public static void FinishFB_CopySceneLimitContainerBuffer(FlatBufferBuilder builder, Offset<FB_CopySceneLimitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
