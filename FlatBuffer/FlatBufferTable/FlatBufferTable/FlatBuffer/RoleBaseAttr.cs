// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RoleBaseAttr : Table {
  public static FB_RoleBaseAttr GetRootAsFB_RoleBaseAttr(ByteBuffer _bb) { return GetRootAsFB_RoleBaseAttr(_bb, new FB_RoleBaseAttr()); }
  public static FB_RoleBaseAttr GetRootAsFB_RoleBaseAttr(ByteBuffer _bb, FB_RoleBaseAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RoleBaseAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CharModelID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Sex { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int NpcType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int AttackType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxAP { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Camp { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CorpseTime { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)3000; } }
  public int ReviveTime { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)2000; } }
  public int DialogID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DropItemId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long Exp { get { int o = __offset(30); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public bool CanAttackFly { get { int o = __offset(32); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int BornEffctID { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BornTime { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RampType { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BelongType { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int TeamBelongType { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int DimensionId { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AIType { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetSkillIdList(int j) { int o = __offset(48); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkillIdListLength { get { int o = __offset(48); return o != 0 ? __vector_len(o) : 0; } }
  public int ShowNameBoard { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsShowNameBoard { get { int o = __offset(52); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public string Title { get { int o = __offset(54); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsStatic { get { int o = __offset(56); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsHitBack { get { int o = __offset(58); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsThrough { get { int o = __offset(60); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsXiuXian { get { int o = __offset(62); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int IsStatistics { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float LogicRadius { get { int o = __offset(66); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int WorldBossType { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ScriptsId { get { int o = __offset(70); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ScenePoint { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsLevelSuppress { get { int o = __offset(74); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public long YuanShenExp { get { int o = __offset(76); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }

  public static Offset<FB_RoleBaseAttr> CreateFB_RoleBaseAttr(FlatBufferBuilder builder,
      int Id = 0,
      int CharModelID = -1,
      StringOffset Name = default(StringOffset),
      int Sex = 0,
      int NpcType = 0,
      int Level = 1,
      int AttackType = 0,
      int MaxAP = 0,
      int Camp = 0,
      int CorpseTime = 3000,
      int ReviveTime = 2000,
      int DialogID = 0,
      int DropItemId = 0,
      long Exp = 0,
      bool CanAttackFly = false,
      int BornEffctID = -1,
      int BornTime = 0,
      int RampType = 0,
      int BelongType = 1,
      int TeamBelongType = 1,
      int DimensionId = 0,
      int AIType = 0,
      VectorOffset SkillIdList = default(VectorOffset),
      int ShowNameBoard = 0,
      bool IsShowNameBoard = false,
      StringOffset Title = default(StringOffset),
      bool IsStatic = false,
      bool IsHitBack = false,
      bool IsThrough = false,
      bool IsXiuXian = false,
      int IsStatistics = -1,
      float LogicRadius = 0,
      int WorldBossType = -1,
      int ScriptsId = -1,
      int ScenePoint = -1,
      bool IsLevelSuppress = false,
      long YuanShenExp = -1) {
    builder.StartObject(37);
    FB_RoleBaseAttr.AddYuanShenExp(builder, YuanShenExp);
    FB_RoleBaseAttr.AddExp(builder, Exp);
    FB_RoleBaseAttr.AddScenePoint(builder, ScenePoint);
    FB_RoleBaseAttr.AddScriptsId(builder, ScriptsId);
    FB_RoleBaseAttr.AddWorldBossType(builder, WorldBossType);
    FB_RoleBaseAttr.AddLogicRadius(builder, LogicRadius);
    FB_RoleBaseAttr.AddIsStatistics(builder, IsStatistics);
    FB_RoleBaseAttr.AddTitle(builder, Title);
    FB_RoleBaseAttr.AddShowNameBoard(builder, ShowNameBoard);
    FB_RoleBaseAttr.AddSkillIdList(builder, SkillIdList);
    FB_RoleBaseAttr.AddAIType(builder, AIType);
    FB_RoleBaseAttr.AddDimensionId(builder, DimensionId);
    FB_RoleBaseAttr.AddTeamBelongType(builder, TeamBelongType);
    FB_RoleBaseAttr.AddBelongType(builder, BelongType);
    FB_RoleBaseAttr.AddRampType(builder, RampType);
    FB_RoleBaseAttr.AddBornTime(builder, BornTime);
    FB_RoleBaseAttr.AddBornEffctID(builder, BornEffctID);
    FB_RoleBaseAttr.AddDropItemId(builder, DropItemId);
    FB_RoleBaseAttr.AddDialogID(builder, DialogID);
    FB_RoleBaseAttr.AddReviveTime(builder, ReviveTime);
    FB_RoleBaseAttr.AddCorpseTime(builder, CorpseTime);
    FB_RoleBaseAttr.AddCamp(builder, Camp);
    FB_RoleBaseAttr.AddMaxAP(builder, MaxAP);
    FB_RoleBaseAttr.AddAttackType(builder, AttackType);
    FB_RoleBaseAttr.AddLevel(builder, Level);
    FB_RoleBaseAttr.AddNpcType(builder, NpcType);
    FB_RoleBaseAttr.AddSex(builder, Sex);
    FB_RoleBaseAttr.AddName(builder, Name);
    FB_RoleBaseAttr.AddCharModelID(builder, CharModelID);
    FB_RoleBaseAttr.AddId(builder, Id);
    FB_RoleBaseAttr.AddIsLevelSuppress(builder, IsLevelSuppress);
    FB_RoleBaseAttr.AddIsXiuXian(builder, IsXiuXian);
    FB_RoleBaseAttr.AddIsThrough(builder, IsThrough);
    FB_RoleBaseAttr.AddIsHitBack(builder, IsHitBack);
    FB_RoleBaseAttr.AddIsStatic(builder, IsStatic);
    FB_RoleBaseAttr.AddIsShowNameBoard(builder, IsShowNameBoard);
    FB_RoleBaseAttr.AddCanAttackFly(builder, CanAttackFly);
    return FB_RoleBaseAttr.EndFB_RoleBaseAttr(builder);
  }

  public static void StartFB_RoleBaseAttr(FlatBufferBuilder builder) { builder.StartObject(37); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCharModelID(FlatBufferBuilder builder, int CharModelID) { builder.AddInt(1, CharModelID, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(3, Sex, 0); }
  public static void AddNpcType(FlatBufferBuilder builder, int NpcType) { builder.AddInt(4, NpcType, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(5, Level, 1); }
  public static void AddAttackType(FlatBufferBuilder builder, int AttackType) { builder.AddInt(6, AttackType, 0); }
  public static void AddMaxAP(FlatBufferBuilder builder, int MaxAP) { builder.AddInt(7, MaxAP, 0); }
  public static void AddCamp(FlatBufferBuilder builder, int Camp) { builder.AddInt(8, Camp, 0); }
  public static void AddCorpseTime(FlatBufferBuilder builder, int CorpseTime) { builder.AddInt(9, CorpseTime, 3000); }
  public static void AddReviveTime(FlatBufferBuilder builder, int ReviveTime) { builder.AddInt(10, ReviveTime, 2000); }
  public static void AddDialogID(FlatBufferBuilder builder, int DialogID) { builder.AddInt(11, DialogID, 0); }
  public static void AddDropItemId(FlatBufferBuilder builder, int DropItemId) { builder.AddInt(12, DropItemId, 0); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(13, Exp, 0); }
  public static void AddCanAttackFly(FlatBufferBuilder builder, bool CanAttackFly) { builder.AddBool(14, CanAttackFly, false); }
  public static void AddBornEffctID(FlatBufferBuilder builder, int BornEffctID) { builder.AddInt(15, BornEffctID, -1); }
  public static void AddBornTime(FlatBufferBuilder builder, int BornTime) { builder.AddInt(16, BornTime, 0); }
  public static void AddRampType(FlatBufferBuilder builder, int RampType) { builder.AddInt(17, RampType, 0); }
  public static void AddBelongType(FlatBufferBuilder builder, int BelongType) { builder.AddInt(18, BelongType, 1); }
  public static void AddTeamBelongType(FlatBufferBuilder builder, int TeamBelongType) { builder.AddInt(19, TeamBelongType, 1); }
  public static void AddDimensionId(FlatBufferBuilder builder, int DimensionId) { builder.AddInt(20, DimensionId, 0); }
  public static void AddAIType(FlatBufferBuilder builder, int AIType) { builder.AddInt(21, AIType, 0); }
  public static void AddSkillIdList(FlatBufferBuilder builder, VectorOffset SkillIdListOffset) { builder.AddOffset(22, SkillIdListOffset.Value, 0); }
  public static VectorOffset CreateSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowNameBoard(FlatBufferBuilder builder, int ShowNameBoard) { builder.AddInt(23, ShowNameBoard, 0); }
  public static void AddIsShowNameBoard(FlatBufferBuilder builder, bool IsShowNameBoard) { builder.AddBool(24, IsShowNameBoard, false); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset TitleOffset) { builder.AddOffset(25, TitleOffset.Value, 0); }
  public static void AddIsStatic(FlatBufferBuilder builder, bool IsStatic) { builder.AddBool(26, IsStatic, false); }
  public static void AddIsHitBack(FlatBufferBuilder builder, bool IsHitBack) { builder.AddBool(27, IsHitBack, false); }
  public static void AddIsThrough(FlatBufferBuilder builder, bool IsThrough) { builder.AddBool(28, IsThrough, false); }
  public static void AddIsXiuXian(FlatBufferBuilder builder, bool IsXiuXian) { builder.AddBool(29, IsXiuXian, false); }
  public static void AddIsStatistics(FlatBufferBuilder builder, int IsStatistics) { builder.AddInt(30, IsStatistics, -1); }
  public static void AddLogicRadius(FlatBufferBuilder builder, float LogicRadius) { builder.AddFloat(31, LogicRadius, 0); }
  public static void AddWorldBossType(FlatBufferBuilder builder, int WorldBossType) { builder.AddInt(32, WorldBossType, -1); }
  public static void AddScriptsId(FlatBufferBuilder builder, int ScriptsId) { builder.AddInt(33, ScriptsId, -1); }
  public static void AddScenePoint(FlatBufferBuilder builder, int ScenePoint) { builder.AddInt(34, ScenePoint, -1); }
  public static void AddIsLevelSuppress(FlatBufferBuilder builder, bool IsLevelSuppress) { builder.AddBool(35, IsLevelSuppress, false); }
  public static void AddYuanShenExp(FlatBufferBuilder builder, long YuanShenExp) { builder.AddLong(36, YuanShenExp, -1); }
  public static Offset<FB_RoleBaseAttr> EndFB_RoleBaseAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RoleBaseAttr>(o);
  }
};

public sealed class FB_RoleBaseAttrContainer : Table {
  public static FB_RoleBaseAttrContainer GetRootAsFB_RoleBaseAttrContainer(ByteBuffer _bb) { return GetRootAsFB_RoleBaseAttrContainer(_bb, new FB_RoleBaseAttrContainer()); }
  public static FB_RoleBaseAttrContainer GetRootAsFB_RoleBaseAttrContainer(ByteBuffer _bb, FB_RoleBaseAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RoleBaseAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RoleBaseAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RoleBaseAttr GetItems(int j) { return GetItems(new FB_RoleBaseAttr(), j); }
  public FB_RoleBaseAttr GetItems(FB_RoleBaseAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RoleBaseAttrContainer> CreateFB_RoleBaseAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RoleBaseAttrContainer.AddItems(builder, items);
    return FB_RoleBaseAttrContainer.EndFB_RoleBaseAttrContainer(builder);
  }

  public static void StartFB_RoleBaseAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RoleBaseAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RoleBaseAttrContainer> EndFB_RoleBaseAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RoleBaseAttrContainer>(o);
  }
  public static void FinishFB_RoleBaseAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_RoleBaseAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
