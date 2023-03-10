// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionBase : Table {
  public static FB_MissionBase GetRootAsFB_MissionBase(ByteBuffer _bb) { return GetRootAsFB_MissionBase(_bb, new FB_MissionBase()); }
  public static FB_MissionBase GetRootAsFB_MissionBase(ByteBuffer _bb, FB_MissionBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BonusID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MissionType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)2; } }
  public int LogicType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LogicID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)9; } }
  public int ScriptID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)2039; } }
  public int NextMissionID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsAutoAptMission { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int AcceptDataID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)104; } }
  public int CompleteDataID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)105; } }
  public int ExpireType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpireTime { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NextBranchMissionID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsAutoComplete { get { int o = __offset(32); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsCanAbandon { get { int o = __offset(34); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int PreMissionStoryID { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BeforeMissionStoryID { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StoryMovId { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DimChangeOnAccept { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BianShenId { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DelayAffterCommit { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EventIdOnAccept { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsMissionComplete { get { int o = __offset(50); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsUseFlyPath { get { int o = __offset(52); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int SubId { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChapterStringID { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AccepteNpcSceneID { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TargetNpcSceneID { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CompleteNpcSceneID { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FailedID { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsUseMount { get { int o = __offset(66); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int EventIdOnCollection { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsTeamSync { get { int o = __offset(70); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int SyncId { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityID { get { int o = __offset(74); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneStoryID { get { int o = __offset(76); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassMissionCostList(int j) { int o = __offset(78); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassMissionCostListLength { get { int o = __offset(78); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsReturnLua { get { int o = __offset(80); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ExpBonusID { get { int o = __offset(82); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldBonusID { get { int o = __offset(84); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MidMissionStoryID { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChapterNameStringID { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float TargetNpcPosX { get { int o = __offset(90); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float TargetNpcPosZ { get { int o = __offset(92); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float TargetNpcPosY { get { int o = __offset(94); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float TargetFace { get { int o = __offset(96); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float AccepteNpcPosX { get { int o = __offset(98); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float AccepteNpcPosZ { get { int o = __offset(100); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float AccepteNpcPosY { get { int o = __offset(102); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float AccepteFace { get { int o = __offset(104); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CompleteNpcPosX { get { int o = __offset(106); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float CompleteNpcPosZ { get { int o = __offset(108); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float CompleteNpcPosY { get { int o = __offset(110); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float CompleteFace { get { int o = __offset(112); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool IsCanUseShoe { get { int o = __offset(114); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsNeedTransmit { get { int o = __offset(116); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int TargetDataID { get { int o = __offset(118); return o != 0 ? bb.GetInt(o + bb_pos) : (int)104; } }
  public int OpenUIID { get { int o = __offset(120); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIParam { get { int o = __offset(122); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharSouId { get { int o = __offset(124); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionBase> CreateFB_MissionBase(FlatBufferBuilder builder,
      int Id = 0,
      int LimitID = 0,
      int BonusID = 0,
      int MissionType = 2,
      int LogicType = 0,
      int LogicID = 9,
      int ScriptID = 2039,
      int NextMissionID = -1,
      bool IsAutoAptMission = false,
      int AcceptDataID = 104,
      int CompleteDataID = 105,
      int ExpireType = -1,
      int ExpireTime = -1,
      int NextBranchMissionID = -1,
      bool IsAutoComplete = false,
      bool IsCanAbandon = false,
      int PreMissionStoryID = -1,
      int BeforeMissionStoryID = -1,
      int StoryMovId = -1,
      int DimChangeOnAccept = -1,
      int BianShenId = -1,
      int DelayAffterCommit = -1,
      int EventIdOnAccept = -1,
      bool IsMissionComplete = true,
      bool IsUseFlyPath = false,
      int SubId = -1,
      int ChapterStringID = -1,
      int AccepteNpcSceneID = -1,
      int TargetNpcSceneID = -1,
      int CompleteNpcSceneID = -1,
      int FailedID = -1,
      bool IsUseMount = false,
      int EventIdOnCollection = -1,
      bool IsTeamSync = false,
      int SyncId = -1,
      int ActivityID = -1,
      int CopySceneStoryID = -1,
      VectorOffset PassMissionCostList = default(VectorOffset),
      bool IsReturnLua = false,
      int ExpBonusID = -1,
      int GoldBonusID = -1,
      int MidMissionStoryID = -1,
      int ChapterNameStringID = -1,
      float TargetNpcPosX = 1,
      float TargetNpcPosZ = 1,
      float TargetNpcPosY = 1,
      float TargetFace = 0,
      float AccepteNpcPosX = -1,
      float AccepteNpcPosZ = 1,
      float AccepteNpcPosY = -1,
      float AccepteFace = 0,
      float CompleteNpcPosX = -1,
      float CompleteNpcPosZ = 1,
      float CompleteNpcPosY = -1,
      float CompleteFace = 0,
      bool IsCanUseShoe = false,
      bool IsNeedTransmit = false,
      int TargetDataID = 104,
      int OpenUIID = -1,
      int UIParam = -1,
      int CharSouId = -1) {
    builder.StartObject(61);
    FB_MissionBase.AddCharSouId(builder, CharSouId);
    FB_MissionBase.AddUIParam(builder, UIParam);
    FB_MissionBase.AddOpenUIID(builder, OpenUIID);
    FB_MissionBase.AddTargetDataID(builder, TargetDataID);
    FB_MissionBase.AddCompleteFace(builder, CompleteFace);
    FB_MissionBase.AddCompleteNpcPosY(builder, CompleteNpcPosY);
    FB_MissionBase.AddCompleteNpcPosZ(builder, CompleteNpcPosZ);
    FB_MissionBase.AddCompleteNpcPosX(builder, CompleteNpcPosX);
    FB_MissionBase.AddAccepteFace(builder, AccepteFace);
    FB_MissionBase.AddAccepteNpcPosY(builder, AccepteNpcPosY);
    FB_MissionBase.AddAccepteNpcPosZ(builder, AccepteNpcPosZ);
    FB_MissionBase.AddAccepteNpcPosX(builder, AccepteNpcPosX);
    FB_MissionBase.AddTargetFace(builder, TargetFace);
    FB_MissionBase.AddTargetNpcPosY(builder, TargetNpcPosY);
    FB_MissionBase.AddTargetNpcPosZ(builder, TargetNpcPosZ);
    FB_MissionBase.AddTargetNpcPosX(builder, TargetNpcPosX);
    FB_MissionBase.AddChapterNameStringID(builder, ChapterNameStringID);
    FB_MissionBase.AddMidMissionStoryID(builder, MidMissionStoryID);
    FB_MissionBase.AddGoldBonusID(builder, GoldBonusID);
    FB_MissionBase.AddExpBonusID(builder, ExpBonusID);
    FB_MissionBase.AddPassMissionCostList(builder, PassMissionCostList);
    FB_MissionBase.AddCopySceneStoryID(builder, CopySceneStoryID);
    FB_MissionBase.AddActivityID(builder, ActivityID);
    FB_MissionBase.AddSyncId(builder, SyncId);
    FB_MissionBase.AddEventIdOnCollection(builder, EventIdOnCollection);
    FB_MissionBase.AddFailedID(builder, FailedID);
    FB_MissionBase.AddCompleteNpcSceneID(builder, CompleteNpcSceneID);
    FB_MissionBase.AddTargetNpcSceneID(builder, TargetNpcSceneID);
    FB_MissionBase.AddAccepteNpcSceneID(builder, AccepteNpcSceneID);
    FB_MissionBase.AddChapterStringID(builder, ChapterStringID);
    FB_MissionBase.AddSubId(builder, SubId);
    FB_MissionBase.AddEventIdOnAccept(builder, EventIdOnAccept);
    FB_MissionBase.AddDelayAffterCommit(builder, DelayAffterCommit);
    FB_MissionBase.AddBianShenId(builder, BianShenId);
    FB_MissionBase.AddDimChangeOnAccept(builder, DimChangeOnAccept);
    FB_MissionBase.AddStoryMovId(builder, StoryMovId);
    FB_MissionBase.AddBeforeMissionStoryID(builder, BeforeMissionStoryID);
    FB_MissionBase.AddPreMissionStoryID(builder, PreMissionStoryID);
    FB_MissionBase.AddNextBranchMissionID(builder, NextBranchMissionID);
    FB_MissionBase.AddExpireTime(builder, ExpireTime);
    FB_MissionBase.AddExpireType(builder, ExpireType);
    FB_MissionBase.AddCompleteDataID(builder, CompleteDataID);
    FB_MissionBase.AddAcceptDataID(builder, AcceptDataID);
    FB_MissionBase.AddNextMissionID(builder, NextMissionID);
    FB_MissionBase.AddScriptID(builder, ScriptID);
    FB_MissionBase.AddLogicID(builder, LogicID);
    FB_MissionBase.AddLogicType(builder, LogicType);
    FB_MissionBase.AddMissionType(builder, MissionType);
    FB_MissionBase.AddBonusID(builder, BonusID);
    FB_MissionBase.AddLimitID(builder, LimitID);
    FB_MissionBase.AddId(builder, Id);
    FB_MissionBase.AddIsNeedTransmit(builder, IsNeedTransmit);
    FB_MissionBase.AddIsCanUseShoe(builder, IsCanUseShoe);
    FB_MissionBase.AddIsReturnLua(builder, IsReturnLua);
    FB_MissionBase.AddIsTeamSync(builder, IsTeamSync);
    FB_MissionBase.AddIsUseMount(builder, IsUseMount);
    FB_MissionBase.AddIsUseFlyPath(builder, IsUseFlyPath);
    FB_MissionBase.AddIsMissionComplete(builder, IsMissionComplete);
    FB_MissionBase.AddIsCanAbandon(builder, IsCanAbandon);
    FB_MissionBase.AddIsAutoComplete(builder, IsAutoComplete);
    FB_MissionBase.AddIsAutoAptMission(builder, IsAutoAptMission);
    return FB_MissionBase.EndFB_MissionBase(builder);
  }

  public static void StartFB_MissionBase(FlatBufferBuilder builder) { builder.StartObject(61); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLimitID(FlatBufferBuilder builder, int LimitID) { builder.AddInt(1, LimitID, 0); }
  public static void AddBonusID(FlatBufferBuilder builder, int BonusID) { builder.AddInt(2, BonusID, 0); }
  public static void AddMissionType(FlatBufferBuilder builder, int MissionType) { builder.AddInt(3, MissionType, 2); }
  public static void AddLogicType(FlatBufferBuilder builder, int LogicType) { builder.AddInt(4, LogicType, 0); }
  public static void AddLogicID(FlatBufferBuilder builder, int LogicID) { builder.AddInt(5, LogicID, 9); }
  public static void AddScriptID(FlatBufferBuilder builder, int ScriptID) { builder.AddInt(6, ScriptID, 2039); }
  public static void AddNextMissionID(FlatBufferBuilder builder, int NextMissionID) { builder.AddInt(7, NextMissionID, -1); }
  public static void AddIsAutoAptMission(FlatBufferBuilder builder, bool IsAutoAptMission) { builder.AddBool(8, IsAutoAptMission, false); }
  public static void AddAcceptDataID(FlatBufferBuilder builder, int AcceptDataID) { builder.AddInt(9, AcceptDataID, 104); }
  public static void AddCompleteDataID(FlatBufferBuilder builder, int CompleteDataID) { builder.AddInt(10, CompleteDataID, 105); }
  public static void AddExpireType(FlatBufferBuilder builder, int ExpireType) { builder.AddInt(11, ExpireType, -1); }
  public static void AddExpireTime(FlatBufferBuilder builder, int ExpireTime) { builder.AddInt(12, ExpireTime, -1); }
  public static void AddNextBranchMissionID(FlatBufferBuilder builder, int NextBranchMissionID) { builder.AddInt(13, NextBranchMissionID, -1); }
  public static void AddIsAutoComplete(FlatBufferBuilder builder, bool IsAutoComplete) { builder.AddBool(14, IsAutoComplete, false); }
  public static void AddIsCanAbandon(FlatBufferBuilder builder, bool IsCanAbandon) { builder.AddBool(15, IsCanAbandon, false); }
  public static void AddPreMissionStoryID(FlatBufferBuilder builder, int PreMissionStoryID) { builder.AddInt(16, PreMissionStoryID, -1); }
  public static void AddBeforeMissionStoryID(FlatBufferBuilder builder, int BeforeMissionStoryID) { builder.AddInt(17, BeforeMissionStoryID, -1); }
  public static void AddStoryMovId(FlatBufferBuilder builder, int StoryMovId) { builder.AddInt(18, StoryMovId, -1); }
  public static void AddDimChangeOnAccept(FlatBufferBuilder builder, int DimChangeOnAccept) { builder.AddInt(19, DimChangeOnAccept, -1); }
  public static void AddBianShenId(FlatBufferBuilder builder, int BianShenId) { builder.AddInt(20, BianShenId, -1); }
  public static void AddDelayAffterCommit(FlatBufferBuilder builder, int DelayAffterCommit) { builder.AddInt(21, DelayAffterCommit, -1); }
  public static void AddEventIdOnAccept(FlatBufferBuilder builder, int EventIdOnAccept) { builder.AddInt(22, EventIdOnAccept, -1); }
  public static void AddIsMissionComplete(FlatBufferBuilder builder, bool IsMissionComplete) { builder.AddBool(23, IsMissionComplete, true); }
  public static void AddIsUseFlyPath(FlatBufferBuilder builder, bool IsUseFlyPath) { builder.AddBool(24, IsUseFlyPath, false); }
  public static void AddSubId(FlatBufferBuilder builder, int SubId) { builder.AddInt(25, SubId, -1); }
  public static void AddChapterStringID(FlatBufferBuilder builder, int ChapterStringID) { builder.AddInt(26, ChapterStringID, -1); }
  public static void AddAccepteNpcSceneID(FlatBufferBuilder builder, int AccepteNpcSceneID) { builder.AddInt(27, AccepteNpcSceneID, -1); }
  public static void AddTargetNpcSceneID(FlatBufferBuilder builder, int TargetNpcSceneID) { builder.AddInt(28, TargetNpcSceneID, -1); }
  public static void AddCompleteNpcSceneID(FlatBufferBuilder builder, int CompleteNpcSceneID) { builder.AddInt(29, CompleteNpcSceneID, -1); }
  public static void AddFailedID(FlatBufferBuilder builder, int FailedID) { builder.AddInt(30, FailedID, -1); }
  public static void AddIsUseMount(FlatBufferBuilder builder, bool IsUseMount) { builder.AddBool(31, IsUseMount, false); }
  public static void AddEventIdOnCollection(FlatBufferBuilder builder, int EventIdOnCollection) { builder.AddInt(32, EventIdOnCollection, -1); }
  public static void AddIsTeamSync(FlatBufferBuilder builder, bool IsTeamSync) { builder.AddBool(33, IsTeamSync, false); }
  public static void AddSyncId(FlatBufferBuilder builder, int SyncId) { builder.AddInt(34, SyncId, -1); }
  public static void AddActivityID(FlatBufferBuilder builder, int ActivityID) { builder.AddInt(35, ActivityID, -1); }
  public static void AddCopySceneStoryID(FlatBufferBuilder builder, int CopySceneStoryID) { builder.AddInt(36, CopySceneStoryID, -1); }
  public static void AddPassMissionCostList(FlatBufferBuilder builder, VectorOffset PassMissionCostListOffset) { builder.AddOffset(37, PassMissionCostListOffset.Value, 0); }
  public static VectorOffset CreatePassMissionCostListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassMissionCostListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsReturnLua(FlatBufferBuilder builder, bool IsReturnLua) { builder.AddBool(38, IsReturnLua, false); }
  public static void AddExpBonusID(FlatBufferBuilder builder, int ExpBonusID) { builder.AddInt(39, ExpBonusID, -1); }
  public static void AddGoldBonusID(FlatBufferBuilder builder, int GoldBonusID) { builder.AddInt(40, GoldBonusID, -1); }
  public static void AddMidMissionStoryID(FlatBufferBuilder builder, int MidMissionStoryID) { builder.AddInt(41, MidMissionStoryID, -1); }
  public static void AddChapterNameStringID(FlatBufferBuilder builder, int ChapterNameStringID) { builder.AddInt(42, ChapterNameStringID, -1); }
  public static void AddTargetNpcPosX(FlatBufferBuilder builder, float TargetNpcPosX) { builder.AddFloat(43, TargetNpcPosX, 1); }
  public static void AddTargetNpcPosZ(FlatBufferBuilder builder, float TargetNpcPosZ) { builder.AddFloat(44, TargetNpcPosZ, 1); }
  public static void AddTargetNpcPosY(FlatBufferBuilder builder, float TargetNpcPosY) { builder.AddFloat(45, TargetNpcPosY, 1); }
  public static void AddTargetFace(FlatBufferBuilder builder, float TargetFace) { builder.AddFloat(46, TargetFace, 0); }
  public static void AddAccepteNpcPosX(FlatBufferBuilder builder, float AccepteNpcPosX) { builder.AddFloat(47, AccepteNpcPosX, -1); }
  public static void AddAccepteNpcPosZ(FlatBufferBuilder builder, float AccepteNpcPosZ) { builder.AddFloat(48, AccepteNpcPosZ, 1); }
  public static void AddAccepteNpcPosY(FlatBufferBuilder builder, float AccepteNpcPosY) { builder.AddFloat(49, AccepteNpcPosY, -1); }
  public static void AddAccepteFace(FlatBufferBuilder builder, float AccepteFace) { builder.AddFloat(50, AccepteFace, 0); }
  public static void AddCompleteNpcPosX(FlatBufferBuilder builder, float CompleteNpcPosX) { builder.AddFloat(51, CompleteNpcPosX, -1); }
  public static void AddCompleteNpcPosZ(FlatBufferBuilder builder, float CompleteNpcPosZ) { builder.AddFloat(52, CompleteNpcPosZ, 1); }
  public static void AddCompleteNpcPosY(FlatBufferBuilder builder, float CompleteNpcPosY) { builder.AddFloat(53, CompleteNpcPosY, -1); }
  public static void AddCompleteFace(FlatBufferBuilder builder, float CompleteFace) { builder.AddFloat(54, CompleteFace, 0); }
  public static void AddIsCanUseShoe(FlatBufferBuilder builder, bool IsCanUseShoe) { builder.AddBool(55, IsCanUseShoe, false); }
  public static void AddIsNeedTransmit(FlatBufferBuilder builder, bool IsNeedTransmit) { builder.AddBool(56, IsNeedTransmit, false); }
  public static void AddTargetDataID(FlatBufferBuilder builder, int TargetDataID) { builder.AddInt(57, TargetDataID, 104); }
  public static void AddOpenUIID(FlatBufferBuilder builder, int OpenUIID) { builder.AddInt(58, OpenUIID, -1); }
  public static void AddUIParam(FlatBufferBuilder builder, int UIParam) { builder.AddInt(59, UIParam, -1); }
  public static void AddCharSouId(FlatBufferBuilder builder, int CharSouId) { builder.AddInt(60, CharSouId, -1); }
  public static Offset<FB_MissionBase> EndFB_MissionBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionBase>(o);
  }
};

public sealed class FB_MissionBaseContainer : Table {
  public static FB_MissionBaseContainer GetRootAsFB_MissionBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MissionBaseContainer(_bb, new FB_MissionBaseContainer()); }
  public static FB_MissionBaseContainer GetRootAsFB_MissionBaseContainer(ByteBuffer _bb, FB_MissionBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionBase GetItems(int j) { return GetItems(new FB_MissionBase(), j); }
  public FB_MissionBase GetItems(FB_MissionBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionBaseContainer> CreateFB_MissionBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionBaseContainer.AddItems(builder, items);
    return FB_MissionBaseContainer.EndFB_MissionBaseContainer(builder);
  }

  public static void StartFB_MissionBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionBaseContainer> EndFB_MissionBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionBaseContainer>(o);
  }
  public static void FinishFB_MissionBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
