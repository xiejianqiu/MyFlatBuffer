// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillEx : Table {
  public static FB_SkillEx GetRootAsFB_SkillEx(ByteBuffer _bb) { return GetRootAsFB_SkillEx(_bb, new FB_SkillEx()); }
  public static FB_SkillEx GetRootAsFB_SkillEx(ByteBuffer _bb, FB_SkillEx obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillEx __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int SkillExID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsPuGong { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int NextSkillExId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsBlood { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsUsePassive { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int BaseId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SkillType { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SkillDesc { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TheurgyVerse { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TheurgyDesc { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TheurgyNextLevelDes { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TheurgyRangeDes { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SkillReplaceID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetTheurgyReplaceIDList(int j) { int o = __offset(34); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TheurgyReplaceIDListLength { get { int o = __offset(34); return o != 0 ? __vector_len(o) : 0; } }
  public int TheurgyUpID { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillLogic { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetLogicParamList(int j) { int o = __offset(42); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LogicParamListLength { get { int o = __offset(42); return o != 0 ? __vector_len(o) : 0; } }
  public float Radius { get { int o = __offset(44); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)10; } }
  public int CDTimeId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)97; } }
  public int SkillDelayTime { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillContinueTime { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1000; } }
  public int YinChangTime { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Forced { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetDelTypeList(int j) { int o = __offset(56); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DelTypeListLength { get { int o = __offset(56); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDelNumList(int j) { int o = __offset(58); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DelNumListLength { get { int o = __offset(58); return o != 0 ? __vector_len(o) : 0; } }
  public int GetGainsTypeList(int j) { int o = __offset(60); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GainsTypeListLength { get { int o = __offset(60); return o != 0 ? __vector_len(o) : 0; } }
  public int GetGainsNumList(int j) { int o = __offset(62); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GainsNumListLength { get { int o = __offset(62); return o != 0 ? __vector_len(o) : 0; } }
  public int GetImpactList(int j) { int o = __offset(64); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ImpactListLength { get { int o = __offset(64); return o != 0 ? __vector_len(o) : 0; } }
  public int SatrtMotionId { get { int o = __offset(66); return o != 0 ? bb.GetInt(o + bb_pos) : (int)217; } }
  public int GetBulletEffectIDList(int j) { int o = __offset(68); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BulletEffectIDListLength { get { int o = __offset(68); return o != 0 ? __vector_len(o) : 0; } }
  public int HitEffect { get { int o = __offset(70); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PaoPaoOnStartSkill { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanUseInNotIdle { get { int o = __offset(74); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanSynchronization { get { int o = __offset(76); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ProgressId { get { int o = __offset(78); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillTipId { get { int o = __offset(80); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttackFlyRate { get { int o = __offset(82); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttackFlyRange { get { int o = __offset(84); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttackFlyTime { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Priority { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string BigSkillTex { get { int o = __offset(90); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsShenTong { get { int o = __offset(92); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsXingHunSkill { get { int o = __offset(94); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int HitSoundID { get { int o = __offset(96); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowTipId { get { int o = __offset(98); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SkillEx> CreateFB_SkillEx(FlatBufferBuilder builder,
      int SkillExID = 0,
      StringOffset Name = default(StringOffset),
      bool IsPuGong = false,
      int NextSkillExId = -1,
      bool IsBlood = false,
      bool IsUsePassive = false,
      int BaseId = -1,
      StringOffset Icon = default(StringOffset),
      StringOffset SkillType = default(StringOffset),
      StringOffset SkillDesc = default(StringOffset),
      StringOffset TheurgyVerse = default(StringOffset),
      StringOffset TheurgyDesc = default(StringOffset),
      StringOffset TheurgyNextLevelDes = default(StringOffset),
      StringOffset TheurgyRangeDes = default(StringOffset),
      int SkillReplaceID = -1,
      VectorOffset TheurgyReplaceIDList = default(VectorOffset),
      int TheurgyUpID = -1,
      int level = 0,
      int SkillLogic = 0,
      VectorOffset LogicParamList = default(VectorOffset),
      float Radius = 10,
      int CDTimeId = 97,
      int SkillDelayTime = 0,
      int SkillContinueTime = 1000,
      int YinChangTime = 0,
      int Forced = 0,
      VectorOffset DelType_List = default(VectorOffset),
      VectorOffset DelNum_List = default(VectorOffset),
      VectorOffset GainsType_List = default(VectorOffset),
      VectorOffset GainsNum_List = default(VectorOffset),
      VectorOffset Impact_List = default(VectorOffset),
      int SatrtMotionId = 217,
      VectorOffset BulletEffectID_List = default(VectorOffset),
      int HitEffect = -1,
      int PaoPaoOnStartSkill = -1,
      bool CanUseInNotIdle = false,
      bool CanSynchronization = false,
      int ProgressId = -1,
      int SkillTipId = -1,
      int AttackFlyRate = 0,
      int AttackFlyRange = 0,
      int AttackFlyTime = 0,
      int Priority = -1,
      StringOffset BigSkillTex = default(StringOffset),
      bool IsShenTong = false,
      bool IsXingHunSkill = false,
      int HitSoundID = -1,
      int ShowTipId = -1) {
    builder.StartObject(48);
    FB_SkillEx.AddShowTipId(builder, ShowTipId);
    FB_SkillEx.AddHitSoundID(builder, HitSoundID);
    FB_SkillEx.AddBigSkillTex(builder, BigSkillTex);
    FB_SkillEx.AddPriority(builder, Priority);
    FB_SkillEx.AddAttackFlyTime(builder, AttackFlyTime);
    FB_SkillEx.AddAttackFlyRange(builder, AttackFlyRange);
    FB_SkillEx.AddAttackFlyRate(builder, AttackFlyRate);
    FB_SkillEx.AddSkillTipId(builder, SkillTipId);
    FB_SkillEx.AddProgressId(builder, ProgressId);
    FB_SkillEx.AddPaoPaoOnStartSkill(builder, PaoPaoOnStartSkill);
    FB_SkillEx.AddHitEffect(builder, HitEffect);
    FB_SkillEx.AddBulletEffectIDList(builder, BulletEffectID_List);
    FB_SkillEx.AddSatrtMotionId(builder, SatrtMotionId);
    FB_SkillEx.AddImpactList(builder, Impact_List);
    FB_SkillEx.AddGainsNumList(builder, GainsNum_List);
    FB_SkillEx.AddGainsTypeList(builder, GainsType_List);
    FB_SkillEx.AddDelNumList(builder, DelNum_List);
    FB_SkillEx.AddDelTypeList(builder, DelType_List);
    FB_SkillEx.AddForced(builder, Forced);
    FB_SkillEx.AddYinChangTime(builder, YinChangTime);
    FB_SkillEx.AddSkillContinueTime(builder, SkillContinueTime);
    FB_SkillEx.AddSkillDelayTime(builder, SkillDelayTime);
    FB_SkillEx.AddCDTimeId(builder, CDTimeId);
    FB_SkillEx.AddRadius(builder, Radius);
    FB_SkillEx.AddLogicParamList(builder, LogicParamList);
    FB_SkillEx.AddSkillLogic(builder, SkillLogic);
    FB_SkillEx.AddLevel(builder, level);
    FB_SkillEx.AddTheurgyUpID(builder, TheurgyUpID);
    FB_SkillEx.AddTheurgyReplaceIDList(builder, TheurgyReplaceIDList);
    FB_SkillEx.AddSkillReplaceID(builder, SkillReplaceID);
    FB_SkillEx.AddTheurgyRangeDes(builder, TheurgyRangeDes);
    FB_SkillEx.AddTheurgyNextLevelDes(builder, TheurgyNextLevelDes);
    FB_SkillEx.AddTheurgyDesc(builder, TheurgyDesc);
    FB_SkillEx.AddTheurgyVerse(builder, TheurgyVerse);
    FB_SkillEx.AddSkillDesc(builder, SkillDesc);
    FB_SkillEx.AddSkillType(builder, SkillType);
    FB_SkillEx.AddIcon(builder, Icon);
    FB_SkillEx.AddBaseId(builder, BaseId);
    FB_SkillEx.AddNextSkillExId(builder, NextSkillExId);
    FB_SkillEx.AddName(builder, Name);
    FB_SkillEx.AddSkillExID(builder, SkillExID);
    FB_SkillEx.AddIsXingHunSkill(builder, IsXingHunSkill);
    FB_SkillEx.AddIsShenTong(builder, IsShenTong);
    FB_SkillEx.AddCanSynchronization(builder, CanSynchronization);
    FB_SkillEx.AddCanUseInNotIdle(builder, CanUseInNotIdle);
    FB_SkillEx.AddIsUsePassive(builder, IsUsePassive);
    FB_SkillEx.AddIsBlood(builder, IsBlood);
    FB_SkillEx.AddIsPuGong(builder, IsPuGong);
    return FB_SkillEx.EndFB_SkillEx(builder);
  }

  public static void StartFB_SkillEx(FlatBufferBuilder builder) { builder.StartObject(48); }
  public static void AddSkillExID(FlatBufferBuilder builder, int SkillExID) { builder.AddInt(0, SkillExID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIsPuGong(FlatBufferBuilder builder, bool IsPuGong) { builder.AddBool(2, IsPuGong, false); }
  public static void AddNextSkillExId(FlatBufferBuilder builder, int NextSkillExId) { builder.AddInt(3, NextSkillExId, -1); }
  public static void AddIsBlood(FlatBufferBuilder builder, bool IsBlood) { builder.AddBool(4, IsBlood, false); }
  public static void AddIsUsePassive(FlatBufferBuilder builder, bool IsUsePassive) { builder.AddBool(5, IsUsePassive, false); }
  public static void AddBaseId(FlatBufferBuilder builder, int BaseId) { builder.AddInt(6, BaseId, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(7, IconOffset.Value, 0); }
  public static void AddSkillType(FlatBufferBuilder builder, StringOffset SkillTypeOffset) { builder.AddOffset(8, SkillTypeOffset.Value, 0); }
  public static void AddSkillDesc(FlatBufferBuilder builder, StringOffset SkillDescOffset) { builder.AddOffset(9, SkillDescOffset.Value, 0); }
  public static void AddTheurgyVerse(FlatBufferBuilder builder, StringOffset TheurgyVerseOffset) { builder.AddOffset(10, TheurgyVerseOffset.Value, 0); }
  public static void AddTheurgyDesc(FlatBufferBuilder builder, StringOffset TheurgyDescOffset) { builder.AddOffset(11, TheurgyDescOffset.Value, 0); }
  public static void AddTheurgyNextLevelDes(FlatBufferBuilder builder, StringOffset TheurgyNextLevelDesOffset) { builder.AddOffset(12, TheurgyNextLevelDesOffset.Value, 0); }
  public static void AddTheurgyRangeDes(FlatBufferBuilder builder, StringOffset TheurgyRangeDesOffset) { builder.AddOffset(13, TheurgyRangeDesOffset.Value, 0); }
  public static void AddSkillReplaceID(FlatBufferBuilder builder, int SkillReplaceID) { builder.AddInt(14, SkillReplaceID, -1); }
  public static void AddTheurgyReplaceIDList(FlatBufferBuilder builder, VectorOffset TheurgyReplaceIDListOffset) { builder.AddOffset(15, TheurgyReplaceIDListOffset.Value, 0); }
  public static VectorOffset CreateTheurgyReplaceIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTheurgyReplaceIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTheurgyUpID(FlatBufferBuilder builder, int TheurgyUpID) { builder.AddInt(16, TheurgyUpID, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(17, level, 0); }
  public static void AddSkillLogic(FlatBufferBuilder builder, int SkillLogic) { builder.AddInt(18, SkillLogic, 0); }
  public static void AddLogicParamList(FlatBufferBuilder builder, VectorOffset LogicParamListOffset) { builder.AddOffset(19, LogicParamListOffset.Value, 0); }
  public static VectorOffset CreateLogicParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLogicParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRadius(FlatBufferBuilder builder, float Radius) { builder.AddFloat(20, Radius, 10); }
  public static void AddCDTimeId(FlatBufferBuilder builder, int CDTimeId) { builder.AddInt(21, CDTimeId, 97); }
  public static void AddSkillDelayTime(FlatBufferBuilder builder, int SkillDelayTime) { builder.AddInt(22, SkillDelayTime, 0); }
  public static void AddSkillContinueTime(FlatBufferBuilder builder, int SkillContinueTime) { builder.AddInt(23, SkillContinueTime, 1000); }
  public static void AddYinChangTime(FlatBufferBuilder builder, int YinChangTime) { builder.AddInt(24, YinChangTime, 0); }
  public static void AddForced(FlatBufferBuilder builder, int Forced) { builder.AddInt(25, Forced, 0); }
  public static void AddDelTypeList(FlatBufferBuilder builder, VectorOffset DelTypeListOffset) { builder.AddOffset(26, DelTypeListOffset.Value, 0); }
  public static VectorOffset CreateDelTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDelTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDelNumList(FlatBufferBuilder builder, VectorOffset DelNumListOffset) { builder.AddOffset(27, DelNumListOffset.Value, 0); }
  public static VectorOffset CreateDelNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDelNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGainsTypeList(FlatBufferBuilder builder, VectorOffset GainsTypeListOffset) { builder.AddOffset(28, GainsTypeListOffset.Value, 0); }
  public static VectorOffset CreateGainsTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGainsTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGainsNumList(FlatBufferBuilder builder, VectorOffset GainsNumListOffset) { builder.AddOffset(29, GainsNumListOffset.Value, 0); }
  public static VectorOffset CreateGainsNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGainsNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddImpactList(FlatBufferBuilder builder, VectorOffset ImpactListOffset) { builder.AddOffset(30, ImpactListOffset.Value, 0); }
  public static VectorOffset CreateImpactListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartImpactListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSatrtMotionId(FlatBufferBuilder builder, int SatrtMotionId) { builder.AddInt(31, SatrtMotionId, 217); }
  public static void AddBulletEffectIDList(FlatBufferBuilder builder, VectorOffset BulletEffectIDListOffset) { builder.AddOffset(32, BulletEffectIDListOffset.Value, 0); }
  public static VectorOffset CreateBulletEffectIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBulletEffectIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHitEffect(FlatBufferBuilder builder, int HitEffect) { builder.AddInt(33, HitEffect, -1); }
  public static void AddPaoPaoOnStartSkill(FlatBufferBuilder builder, int PaoPaoOnStartSkill) { builder.AddInt(34, PaoPaoOnStartSkill, -1); }
  public static void AddCanUseInNotIdle(FlatBufferBuilder builder, bool CanUseInNotIdle) { builder.AddBool(35, CanUseInNotIdle, false); }
  public static void AddCanSynchronization(FlatBufferBuilder builder, bool CanSynchronization) { builder.AddBool(36, CanSynchronization, false); }
  public static void AddProgressId(FlatBufferBuilder builder, int ProgressId) { builder.AddInt(37, ProgressId, -1); }
  public static void AddSkillTipId(FlatBufferBuilder builder, int SkillTipId) { builder.AddInt(38, SkillTipId, -1); }
  public static void AddAttackFlyRate(FlatBufferBuilder builder, int AttackFlyRate) { builder.AddInt(39, AttackFlyRate, 0); }
  public static void AddAttackFlyRange(FlatBufferBuilder builder, int AttackFlyRange) { builder.AddInt(40, AttackFlyRange, 0); }
  public static void AddAttackFlyTime(FlatBufferBuilder builder, int AttackFlyTime) { builder.AddInt(41, AttackFlyTime, 0); }
  public static void AddPriority(FlatBufferBuilder builder, int Priority) { builder.AddInt(42, Priority, -1); }
  public static void AddBigSkillTex(FlatBufferBuilder builder, StringOffset BigSkillTexOffset) { builder.AddOffset(43, BigSkillTexOffset.Value, 0); }
  public static void AddIsShenTong(FlatBufferBuilder builder, bool IsShenTong) { builder.AddBool(44, IsShenTong, false); }
  public static void AddIsXingHunSkill(FlatBufferBuilder builder, bool IsXingHunSkill) { builder.AddBool(45, IsXingHunSkill, false); }
  public static void AddHitSoundID(FlatBufferBuilder builder, int HitSoundID) { builder.AddInt(46, HitSoundID, -1); }
  public static void AddShowTipId(FlatBufferBuilder builder, int ShowTipId) { builder.AddInt(47, ShowTipId, -1); }
  public static Offset<FB_SkillEx> EndFB_SkillEx(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillEx>(o);
  }
};

public sealed class FB_SkillExContainer : Table {
  public static FB_SkillExContainer GetRootAsFB_SkillExContainer(ByteBuffer _bb) { return GetRootAsFB_SkillExContainer(_bb, new FB_SkillExContainer()); }
  public static FB_SkillExContainer GetRootAsFB_SkillExContainer(ByteBuffer _bb, FB_SkillExContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillExContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillExContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillEx GetItems(int j) { return GetItems(new FB_SkillEx(), j); }
  public FB_SkillEx GetItems(FB_SkillEx obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillExContainer> CreateFB_SkillExContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillExContainer.AddItems(builder, items);
    return FB_SkillExContainer.EndFB_SkillExContainer(builder);
  }

  public static void StartFB_SkillExContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillEx>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillExContainer> EndFB_SkillExContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillExContainer>(o);
  }
  public static void FinishFB_SkillExContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillExContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
