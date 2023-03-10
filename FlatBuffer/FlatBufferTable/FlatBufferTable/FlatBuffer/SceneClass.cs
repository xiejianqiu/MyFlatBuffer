// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SceneClass : Table {
  public static FB_SceneClass GetRootAsFB_SceneClass(ByteBuffer _bb) { return GetRootAsFB_SceneClass(_bb, new FB_SceneClass()); }
  public static FB_SceneClass GetRootAsFB_SceneClass(ByteBuffer _bb, FB_SceneClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SceneClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int SceneID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ResName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Length { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Width { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string Path { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int OffX { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OffZ { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FlyHeightDefault { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int FlyHeightMin { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int FlyHeightMax { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string Obstacle { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public int BGMusic { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PVPRule { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetReliveTypeList(int j) { int o = __offset(34); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ReliveTypeListLength { get { int o = __offset(34); return o != 0 ? __vector_len(o) : 0; } }
  public float EntryX { get { int o = __offset(36); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)50; } }
  public float EntryZ { get { int o = __offset(38); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)50; } }
  public float EntryY { get { int o = __offset(40); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)50; } }
  public float EntryRotation { get { int o = __offset(42); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)50; } }
  public float SafeX { get { int o = __offset(44); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)50; } }
  public float SafeZ { get { int o = __offset(46); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)50; } }
  public int DeadPunishRule { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CopySceneID { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PlayersMaxA { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PlayersMaxB { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IsCanUseXp { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int IsCanUseLight { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string SceneMapTexture { get { int o = __offset(60); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneMapWidth { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)320; } }
  public int SceneMapHeight { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)320; } }
  public int SceneMapLogicWidth { get { int o = __offset(66); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int SceneMapLogicHeight { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int SceneMapLogicDeltaX { get { int o = __offset(70); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int ZoneSize { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)8; } }
  public int IsCanTeamFollow { get { int o = __offset(74); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int IsCanCallTeam { get { int o = __offset(76); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScriptID { get { int o = __offset(78); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string LoadingPath { get { int o = __offset(80); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsCanFly { get { int o = __offset(82); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsCanMount { get { int o = __offset(84); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int LevelLimit { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldMap { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PkDefault { get { int o = __offset(90); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PkAllowChange { get { int o = __offset(92); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PkValue { get { int o = __offset(94); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool ChangeSceneTeamFollow { get { int o = __offset(96); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanTransmit { get { int o = __offset(98); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanTeamShip { get { int o = __offset(100); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool RecoverCamera { get { int o = __offset(102); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ExitTextID { get { int o = __offset(104); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float ShadowRotateX { get { int o = __offset(106); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ShadowRotateY { get { int o = __offset(108); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public string LevelRange { get { int o = __offset(110); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool CanUseMedicine { get { int o = __offset(112); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int FlyPathMin { get { int o = __offset(114); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlyLength { get { int o = __offset(116); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlyWidth { get { int o = __offset(118); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlyOffX { get { int o = __offset(120); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlyOffZ { get { int o = __offset(122); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MiniMapXOffset { get { int o = __offset(124); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MiniMapYOffset { get { int o = __offset(126); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool CanEnterCopyScene { get { int o = __offset(128); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsAutoPickup { get { int o = __offset(130); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool ChangeSceneFlyEffect { get { int o = __offset(132); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool CanBloodAwake { get { int o = __offset(134); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool CanShowDeathUI { get { int o = __offset(136); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int PkModeAutoChange { get { int o = __offset(138); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool TiredDeath { get { int o = __offset(140); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool ShowGuildChiefDieTip { get { int o = __offset(142); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int AutoReliveTime { get { int o = __offset(144); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool CostMoneyScene { get { int o = __offset(146); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public float WaitMoment { get { int o = __offset(148); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public string FirstLightMap { get { int o = __offset(150); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SecondLightMap { get { int o = __offset(152); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FogColorNoon { get { int o = __offset(154); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FogColorMoringOrDusk { get { int o = __offset(156); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FogColorNight { get { int o = __offset(158); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShaderParamID { get { int o = __offset(160); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsArtifact { get { int o = __offset(162); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsShowBossMov { get { int o = __offset(164); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int YuanShenLevelLimit { get { int o = __offset(166); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long PowerLimit { get { int o = __offset(168); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public string PowerLimitShow { get { int o = __offset(170); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_SceneClass> CreateFB_SceneClass(FlatBufferBuilder builder,
      int SceneID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset ResName = default(StringOffset),
      int Type = 0,
      int Length = 1,
      int Width = 1,
      StringOffset Path = default(StringOffset),
      int OffX = 0,
      int OffZ = 0,
      int FlyHeightDefault = 1,
      int FlyHeightMin = 1,
      int FlyHeightMax = 1,
      StringOffset Obstacle = default(StringOffset),
      int BGMusic = -1,
      int PVPRule = -1,
      VectorOffset ReliveType_List = default(VectorOffset),
      float Entry_x = 50,
      float Entry_z = 50,
      float Entry_y = 50,
      float Entry_Rotation = 50,
      float Safe_x = 50,
      float Safe_z = 50,
      int DeadPunishRule = 0,
      int CopySceneID = -1,
      int PlayersMaxA = -1,
      int PlayersMaxB = -1,
      int IsCanUseXp = 1,
      int IsCanUseLight = 0,
      StringOffset SceneMapTexture = default(StringOffset),
      int SceneMapWidth = 320,
      int SceneMapHeight = 320,
      int SceneMapLogicWidth = 1,
      int SceneMapLogicHeight = 1,
      int SceneMapLogicDeltaX = 1,
      int ZoneSize = 8,
      int IsCanTeamFollow = 1,
      int IsCanCallTeam = 0,
      int ScriptID = -1,
      StringOffset LoadingPath = default(StringOffset),
      bool IsCanFly = true,
      bool IsCanMount = true,
      int LevelLimit = -1,
      int WorldMap = -1,
      int PkDefault = 0,
      int PkAllowChange = 0,
      int PkValue = 0,
      bool ChangeSceneTeamFollow = false,
      bool CanTransmit = false,
      bool CanTeamShip = false,
      bool RecoverCamera = false,
      int ExitTextID = -1,
      float ShadowRotateX = 0,
      float ShadowRotateY = 0,
      StringOffset LevelRange = default(StringOffset),
      bool CanUseMedicine = false,
      int FlyPathMin = -1,
      int FlyLength = -1,
      int FlyWidth = -1,
      int FlyOffX = -1,
      int FlyOffZ = -1,
      int MiniMapXOffset = 0,
      int MiniMapYOffset = 0,
      bool CanEnterCopyScene = false,
      bool IsAutoPickup = false,
      bool ChangeSceneFlyEffect = true,
      bool CanBloodAwake = true,
      bool CanShowDeathUI = true,
      int PkModeAutoChange = 0,
      bool TiredDeath = false,
      bool ShowGuildChiefDieTip = false,
      int AutoReliveTime = 0,
      bool CostMoneyScene = false,
      float WaitMoment = -1,
      StringOffset FirstLightMap = default(StringOffset),
      StringOffset SecondLightMap = default(StringOffset),
      int FogColorNoon = -1,
      int FogColorMoringOrDusk = -1,
      int FogColorNight = -1,
      int ShaderParamID = -1,
      bool IsArtifact = true,
      bool IsShowBossMov = false,
      int YuanShenLevelLimit = -1,
      long PowerLimit = 0,
      StringOffset PowerLimitShow = default(StringOffset)) {
    builder.StartObject(84);
    FB_SceneClass.AddPowerLimit(builder, PowerLimit);
    FB_SceneClass.AddPowerLimitShow(builder, PowerLimitShow);
    FB_SceneClass.AddYuanShenLevelLimit(builder, YuanShenLevelLimit);
    FB_SceneClass.AddShaderParamID(builder, ShaderParamID);
    FB_SceneClass.AddFogColorNight(builder, FogColorNight);
    FB_SceneClass.AddFogColorMoringOrDusk(builder, FogColorMoringOrDusk);
    FB_SceneClass.AddFogColorNoon(builder, FogColorNoon);
    FB_SceneClass.AddSecondLightMap(builder, SecondLightMap);
    FB_SceneClass.AddFirstLightMap(builder, FirstLightMap);
    FB_SceneClass.AddWaitMoment(builder, WaitMoment);
    FB_SceneClass.AddAutoReliveTime(builder, AutoReliveTime);
    FB_SceneClass.AddPkModeAutoChange(builder, PkModeAutoChange);
    FB_SceneClass.AddMiniMapYOffset(builder, MiniMapYOffset);
    FB_SceneClass.AddMiniMapXOffset(builder, MiniMapXOffset);
    FB_SceneClass.AddFlyOffZ(builder, FlyOffZ);
    FB_SceneClass.AddFlyOffX(builder, FlyOffX);
    FB_SceneClass.AddFlyWidth(builder, FlyWidth);
    FB_SceneClass.AddFlyLength(builder, FlyLength);
    FB_SceneClass.AddFlyPathMin(builder, FlyPathMin);
    FB_SceneClass.AddLevelRange(builder, LevelRange);
    FB_SceneClass.AddShadowRotateY(builder, ShadowRotateY);
    FB_SceneClass.AddShadowRotateX(builder, ShadowRotateX);
    FB_SceneClass.AddExitTextID(builder, ExitTextID);
    FB_SceneClass.AddPkValue(builder, PkValue);
    FB_SceneClass.AddPkAllowChange(builder, PkAllowChange);
    FB_SceneClass.AddPkDefault(builder, PkDefault);
    FB_SceneClass.AddWorldMap(builder, WorldMap);
    FB_SceneClass.AddLevelLimit(builder, LevelLimit);
    FB_SceneClass.AddLoadingPath(builder, LoadingPath);
    FB_SceneClass.AddScriptID(builder, ScriptID);
    FB_SceneClass.AddIsCanCallTeam(builder, IsCanCallTeam);
    FB_SceneClass.AddIsCanTeamFollow(builder, IsCanTeamFollow);
    FB_SceneClass.AddZoneSize(builder, ZoneSize);
    FB_SceneClass.AddSceneMapLogicDeltaX(builder, SceneMapLogicDeltaX);
    FB_SceneClass.AddSceneMapLogicHeight(builder, SceneMapLogicHeight);
    FB_SceneClass.AddSceneMapLogicWidth(builder, SceneMapLogicWidth);
    FB_SceneClass.AddSceneMapHeight(builder, SceneMapHeight);
    FB_SceneClass.AddSceneMapWidth(builder, SceneMapWidth);
    FB_SceneClass.AddSceneMapTexture(builder, SceneMapTexture);
    FB_SceneClass.AddIsCanUseLight(builder, IsCanUseLight);
    FB_SceneClass.AddIsCanUseXp(builder, IsCanUseXp);
    FB_SceneClass.AddPlayersMaxB(builder, PlayersMaxB);
    FB_SceneClass.AddPlayersMaxA(builder, PlayersMaxA);
    FB_SceneClass.AddCopySceneID(builder, CopySceneID);
    FB_SceneClass.AddDeadPunishRule(builder, DeadPunishRule);
    FB_SceneClass.AddSafeZ(builder, Safe_z);
    FB_SceneClass.AddSafeX(builder, Safe_x);
    FB_SceneClass.AddEntryRotation(builder, Entry_Rotation);
    FB_SceneClass.AddEntryY(builder, Entry_y);
    FB_SceneClass.AddEntryZ(builder, Entry_z);
    FB_SceneClass.AddEntryX(builder, Entry_x);
    FB_SceneClass.AddReliveTypeList(builder, ReliveType_List);
    FB_SceneClass.AddPVPRule(builder, PVPRule);
    FB_SceneClass.AddBGMusic(builder, BGMusic);
    FB_SceneClass.AddObstacle(builder, Obstacle);
    FB_SceneClass.AddFlyHeightMax(builder, FlyHeightMax);
    FB_SceneClass.AddFlyHeightMin(builder, FlyHeightMin);
    FB_SceneClass.AddFlyHeightDefault(builder, FlyHeightDefault);
    FB_SceneClass.AddOffZ(builder, OffZ);
    FB_SceneClass.AddOffX(builder, OffX);
    FB_SceneClass.AddPath(builder, Path);
    FB_SceneClass.AddWidth(builder, Width);
    FB_SceneClass.AddLength(builder, Length);
    FB_SceneClass.AddType(builder, Type);
    FB_SceneClass.AddResName(builder, ResName);
    FB_SceneClass.AddName(builder, Name);
    FB_SceneClass.AddSceneID(builder, SceneID);
    FB_SceneClass.AddIsShowBossMov(builder, IsShowBossMov);
    FB_SceneClass.AddIsArtifact(builder, IsArtifact);
    FB_SceneClass.AddCostMoneyScene(builder, CostMoneyScene);
    FB_SceneClass.AddShowGuildChiefDieTip(builder, ShowGuildChiefDieTip);
    FB_SceneClass.AddTiredDeath(builder, TiredDeath);
    FB_SceneClass.AddCanShowDeathUI(builder, CanShowDeathUI);
    FB_SceneClass.AddCanBloodAwake(builder, CanBloodAwake);
    FB_SceneClass.AddChangeSceneFlyEffect(builder, ChangeSceneFlyEffect);
    FB_SceneClass.AddIsAutoPickup(builder, IsAutoPickup);
    FB_SceneClass.AddCanEnterCopyScene(builder, CanEnterCopyScene);
    FB_SceneClass.AddCanUseMedicine(builder, CanUseMedicine);
    FB_SceneClass.AddRecoverCamera(builder, RecoverCamera);
    FB_SceneClass.AddCanTeamShip(builder, CanTeamShip);
    FB_SceneClass.AddCanTransmit(builder, CanTransmit);
    FB_SceneClass.AddChangeSceneTeamFollow(builder, ChangeSceneTeamFollow);
    FB_SceneClass.AddIsCanMount(builder, IsCanMount);
    FB_SceneClass.AddIsCanFly(builder, IsCanFly);
    return FB_SceneClass.EndFB_SceneClass(builder);
  }

  public static void StartFB_SceneClass(FlatBufferBuilder builder) { builder.StartObject(84); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(0, SceneID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddResName(FlatBufferBuilder builder, StringOffset ResNameOffset) { builder.AddOffset(2, ResNameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, 0); }
  public static void AddLength(FlatBufferBuilder builder, int Length) { builder.AddInt(4, Length, 1); }
  public static void AddWidth(FlatBufferBuilder builder, int Width) { builder.AddInt(5, Width, 1); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(6, PathOffset.Value, 0); }
  public static void AddOffX(FlatBufferBuilder builder, int OffX) { builder.AddInt(7, OffX, 0); }
  public static void AddOffZ(FlatBufferBuilder builder, int OffZ) { builder.AddInt(8, OffZ, 0); }
  public static void AddFlyHeightDefault(FlatBufferBuilder builder, int FlyHeightDefault) { builder.AddInt(9, FlyHeightDefault, 1); }
  public static void AddFlyHeightMin(FlatBufferBuilder builder, int FlyHeightMin) { builder.AddInt(10, FlyHeightMin, 1); }
  public static void AddFlyHeightMax(FlatBufferBuilder builder, int FlyHeightMax) { builder.AddInt(11, FlyHeightMax, 1); }
  public static void AddObstacle(FlatBufferBuilder builder, StringOffset ObstacleOffset) { builder.AddOffset(12, ObstacleOffset.Value, 0); }
  public static void AddBGMusic(FlatBufferBuilder builder, int BGMusic) { builder.AddInt(13, BGMusic, -1); }
  public static void AddPVPRule(FlatBufferBuilder builder, int PVPRule) { builder.AddInt(14, PVPRule, -1); }
  public static void AddReliveTypeList(FlatBufferBuilder builder, VectorOffset ReliveTypeListOffset) { builder.AddOffset(15, ReliveTypeListOffset.Value, 0); }
  public static VectorOffset CreateReliveTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartReliveTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEntryX(FlatBufferBuilder builder, float EntryX) { builder.AddFloat(16, EntryX, 50); }
  public static void AddEntryZ(FlatBufferBuilder builder, float EntryZ) { builder.AddFloat(17, EntryZ, 50); }
  public static void AddEntryY(FlatBufferBuilder builder, float EntryY) { builder.AddFloat(18, EntryY, 50); }
  public static void AddEntryRotation(FlatBufferBuilder builder, float EntryRotation) { builder.AddFloat(19, EntryRotation, 50); }
  public static void AddSafeX(FlatBufferBuilder builder, float SafeX) { builder.AddFloat(20, SafeX, 50); }
  public static void AddSafeZ(FlatBufferBuilder builder, float SafeZ) { builder.AddFloat(21, SafeZ, 50); }
  public static void AddDeadPunishRule(FlatBufferBuilder builder, int DeadPunishRule) { builder.AddInt(22, DeadPunishRule, 0); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(23, CopySceneID, -1); }
  public static void AddPlayersMaxA(FlatBufferBuilder builder, int PlayersMaxA) { builder.AddInt(24, PlayersMaxA, -1); }
  public static void AddPlayersMaxB(FlatBufferBuilder builder, int PlayersMaxB) { builder.AddInt(25, PlayersMaxB, -1); }
  public static void AddIsCanUseXp(FlatBufferBuilder builder, int IsCanUseXp) { builder.AddInt(26, IsCanUseXp, 1); }
  public static void AddIsCanUseLight(FlatBufferBuilder builder, int IsCanUseLight) { builder.AddInt(27, IsCanUseLight, 0); }
  public static void AddSceneMapTexture(FlatBufferBuilder builder, StringOffset SceneMapTextureOffset) { builder.AddOffset(28, SceneMapTextureOffset.Value, 0); }
  public static void AddSceneMapWidth(FlatBufferBuilder builder, int SceneMapWidth) { builder.AddInt(29, SceneMapWidth, 320); }
  public static void AddSceneMapHeight(FlatBufferBuilder builder, int SceneMapHeight) { builder.AddInt(30, SceneMapHeight, 320); }
  public static void AddSceneMapLogicWidth(FlatBufferBuilder builder, int SceneMapLogicWidth) { builder.AddInt(31, SceneMapLogicWidth, 1); }
  public static void AddSceneMapLogicHeight(FlatBufferBuilder builder, int SceneMapLogicHeight) { builder.AddInt(32, SceneMapLogicHeight, 1); }
  public static void AddSceneMapLogicDeltaX(FlatBufferBuilder builder, int SceneMapLogicDeltaX) { builder.AddInt(33, SceneMapLogicDeltaX, 1); }
  public static void AddZoneSize(FlatBufferBuilder builder, int ZoneSize) { builder.AddInt(34, ZoneSize, 8); }
  public static void AddIsCanTeamFollow(FlatBufferBuilder builder, int IsCanTeamFollow) { builder.AddInt(35, IsCanTeamFollow, 1); }
  public static void AddIsCanCallTeam(FlatBufferBuilder builder, int IsCanCallTeam) { builder.AddInt(36, IsCanCallTeam, 0); }
  public static void AddScriptID(FlatBufferBuilder builder, int ScriptID) { builder.AddInt(37, ScriptID, -1); }
  public static void AddLoadingPath(FlatBufferBuilder builder, StringOffset LoadingPathOffset) { builder.AddOffset(38, LoadingPathOffset.Value, 0); }
  public static void AddIsCanFly(FlatBufferBuilder builder, bool IsCanFly) { builder.AddBool(39, IsCanFly, true); }
  public static void AddIsCanMount(FlatBufferBuilder builder, bool IsCanMount) { builder.AddBool(40, IsCanMount, true); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(41, LevelLimit, -1); }
  public static void AddWorldMap(FlatBufferBuilder builder, int WorldMap) { builder.AddInt(42, WorldMap, -1); }
  public static void AddPkDefault(FlatBufferBuilder builder, int PkDefault) { builder.AddInt(43, PkDefault, 0); }
  public static void AddPkAllowChange(FlatBufferBuilder builder, int PkAllowChange) { builder.AddInt(44, PkAllowChange, 0); }
  public static void AddPkValue(FlatBufferBuilder builder, int PkValue) { builder.AddInt(45, PkValue, 0); }
  public static void AddChangeSceneTeamFollow(FlatBufferBuilder builder, bool ChangeSceneTeamFollow) { builder.AddBool(46, ChangeSceneTeamFollow, false); }
  public static void AddCanTransmit(FlatBufferBuilder builder, bool CanTransmit) { builder.AddBool(47, CanTransmit, false); }
  public static void AddCanTeamShip(FlatBufferBuilder builder, bool CanTeamShip) { builder.AddBool(48, CanTeamShip, false); }
  public static void AddRecoverCamera(FlatBufferBuilder builder, bool RecoverCamera) { builder.AddBool(49, RecoverCamera, false); }
  public static void AddExitTextID(FlatBufferBuilder builder, int ExitTextID) { builder.AddInt(50, ExitTextID, -1); }
  public static void AddShadowRotateX(FlatBufferBuilder builder, float ShadowRotateX) { builder.AddFloat(51, ShadowRotateX, 0); }
  public static void AddShadowRotateY(FlatBufferBuilder builder, float ShadowRotateY) { builder.AddFloat(52, ShadowRotateY, 0); }
  public static void AddLevelRange(FlatBufferBuilder builder, StringOffset LevelRangeOffset) { builder.AddOffset(53, LevelRangeOffset.Value, 0); }
  public static void AddCanUseMedicine(FlatBufferBuilder builder, bool CanUseMedicine) { builder.AddBool(54, CanUseMedicine, false); }
  public static void AddFlyPathMin(FlatBufferBuilder builder, int FlyPathMin) { builder.AddInt(55, FlyPathMin, -1); }
  public static void AddFlyLength(FlatBufferBuilder builder, int FlyLength) { builder.AddInt(56, FlyLength, -1); }
  public static void AddFlyWidth(FlatBufferBuilder builder, int FlyWidth) { builder.AddInt(57, FlyWidth, -1); }
  public static void AddFlyOffX(FlatBufferBuilder builder, int FlyOffX) { builder.AddInt(58, FlyOffX, -1); }
  public static void AddFlyOffZ(FlatBufferBuilder builder, int FlyOffZ) { builder.AddInt(59, FlyOffZ, -1); }
  public static void AddMiniMapXOffset(FlatBufferBuilder builder, int MiniMapXOffset) { builder.AddInt(60, MiniMapXOffset, 0); }
  public static void AddMiniMapYOffset(FlatBufferBuilder builder, int MiniMapYOffset) { builder.AddInt(61, MiniMapYOffset, 0); }
  public static void AddCanEnterCopyScene(FlatBufferBuilder builder, bool CanEnterCopyScene) { builder.AddBool(62, CanEnterCopyScene, false); }
  public static void AddIsAutoPickup(FlatBufferBuilder builder, bool IsAutoPickup) { builder.AddBool(63, IsAutoPickup, false); }
  public static void AddChangeSceneFlyEffect(FlatBufferBuilder builder, bool ChangeSceneFlyEffect) { builder.AddBool(64, ChangeSceneFlyEffect, true); }
  public static void AddCanBloodAwake(FlatBufferBuilder builder, bool CanBloodAwake) { builder.AddBool(65, CanBloodAwake, true); }
  public static void AddCanShowDeathUI(FlatBufferBuilder builder, bool CanShowDeathUI) { builder.AddBool(66, CanShowDeathUI, true); }
  public static void AddPkModeAutoChange(FlatBufferBuilder builder, int PkModeAutoChange) { builder.AddInt(67, PkModeAutoChange, 0); }
  public static void AddTiredDeath(FlatBufferBuilder builder, bool TiredDeath) { builder.AddBool(68, TiredDeath, false); }
  public static void AddShowGuildChiefDieTip(FlatBufferBuilder builder, bool ShowGuildChiefDieTip) { builder.AddBool(69, ShowGuildChiefDieTip, false); }
  public static void AddAutoReliveTime(FlatBufferBuilder builder, int AutoReliveTime) { builder.AddInt(70, AutoReliveTime, 0); }
  public static void AddCostMoneyScene(FlatBufferBuilder builder, bool CostMoneyScene) { builder.AddBool(71, CostMoneyScene, false); }
  public static void AddWaitMoment(FlatBufferBuilder builder, float WaitMoment) { builder.AddFloat(72, WaitMoment, -1); }
  public static void AddFirstLightMap(FlatBufferBuilder builder, StringOffset FirstLightMapOffset) { builder.AddOffset(73, FirstLightMapOffset.Value, 0); }
  public static void AddSecondLightMap(FlatBufferBuilder builder, StringOffset SecondLightMapOffset) { builder.AddOffset(74, SecondLightMapOffset.Value, 0); }
  public static void AddFogColorNoon(FlatBufferBuilder builder, int FogColorNoon) { builder.AddInt(75, FogColorNoon, -1); }
  public static void AddFogColorMoringOrDusk(FlatBufferBuilder builder, int FogColorMoringOrDusk) { builder.AddInt(76, FogColorMoringOrDusk, -1); }
  public static void AddFogColorNight(FlatBufferBuilder builder, int FogColorNight) { builder.AddInt(77, FogColorNight, -1); }
  public static void AddShaderParamID(FlatBufferBuilder builder, int ShaderParamID) { builder.AddInt(78, ShaderParamID, -1); }
  public static void AddIsArtifact(FlatBufferBuilder builder, bool IsArtifact) { builder.AddBool(79, IsArtifact, true); }
  public static void AddIsShowBossMov(FlatBufferBuilder builder, bool IsShowBossMov) { builder.AddBool(80, IsShowBossMov, false); }
  public static void AddYuanShenLevelLimit(FlatBufferBuilder builder, int YuanShenLevelLimit) { builder.AddInt(81, YuanShenLevelLimit, -1); }
  public static void AddPowerLimit(FlatBufferBuilder builder, long PowerLimit) { builder.AddLong(82, PowerLimit, 0); }
  public static void AddPowerLimitShow(FlatBufferBuilder builder, StringOffset PowerLimitShowOffset) { builder.AddOffset(83, PowerLimitShowOffset.Value, 0); }
  public static Offset<FB_SceneClass> EndFB_SceneClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneClass>(o);
  }
};

public sealed class FB_SceneClassContainer : Table {
  public static FB_SceneClassContainer GetRootAsFB_SceneClassContainer(ByteBuffer _bb) { return GetRootAsFB_SceneClassContainer(_bb, new FB_SceneClassContainer()); }
  public static FB_SceneClassContainer GetRootAsFB_SceneClassContainer(ByteBuffer _bb, FB_SceneClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SceneClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SceneClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SceneClass GetItems(int j) { return GetItems(new FB_SceneClass(), j); }
  public FB_SceneClass GetItems(FB_SceneClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneClassContainer> CreateFB_SceneClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SceneClassContainer.AddItems(builder, items);
    return FB_SceneClassContainer.EndFB_SceneClassContainer(builder);
  }

  public static void StartFB_SceneClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SceneClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneClassContainer> EndFB_SceneClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneClassContainer>(o);
  }
  public static void FinishFB_SceneClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_SceneClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
