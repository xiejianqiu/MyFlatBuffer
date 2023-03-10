// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PassiveSkillBase : Table {
  public static FB_PassiveSkillBase GetRootAsFB_PassiveSkillBase(ByteBuffer _bb) { return GetRootAsFB_PassiveSkillBase(_bb, new FB_PassiveSkillBase()); }
  public static FB_PassiveSkillBase GetRootAsFB_PassiveSkillBase(ByteBuffer _bb, FB_PassiveSkillBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PassiveSkillBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ClassId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SkillDescId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CoolDownTime { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TriggerType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerChance { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerChanceAddValue { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerHPTarget { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerHPPercent { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CombatType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerTarget { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerResult { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool DestroyEffect { get { int o = __offset(32); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetTriggerConditionList(int j) { int o = __offset(34); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TriggerConditionListLength { get { int o = __offset(34); return o != 0 ? __vector_len(o) : 0; } }
  public int GetTriggerParamList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TriggerParamListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public int GetChildPassiveSkillList(int j) { int o = __offset(38); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ChildPassiveSkillListLength { get { int o = __offset(38); return o != 0 ? __vector_len(o) : 0; } }
  public int DamageBoardID { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SoundId { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Priority { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsBroadCast { get { int o = __offset(46); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public float ContiueTime { get { int o = __offset(48); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }

  public static Offset<FB_PassiveSkillBase> CreateFB_PassiveSkillBase(FlatBufferBuilder builder,
      int ID = 0,
      int ClassId = -1,
      StringOffset Name = default(StringOffset),
      int SkillDescId = -1,
      StringOffset Icon = default(StringOffset),
      int CoolDownTime = 0,
      int TriggerType = -1,
      int TriggerChance = -1,
      int TriggerChanceAddValue = -1,
      int TriggerHPTarget = -1,
      int TriggerHPPercent = -1,
      int CombatType = -1,
      int TriggerTarget = -1,
      int TriggerResult = -1,
      bool DestroyEffect = false,
      VectorOffset TriggerConditionList = default(VectorOffset),
      VectorOffset TriggerParamList = default(VectorOffset),
      VectorOffset ChildPassiveSkillList = default(VectorOffset),
      int DamageBoardID = -1,
      int SoundId = -1,
      int Priority = -1,
      bool IsBroadCast = false,
      float ContiueTime = -1) {
    builder.StartObject(23);
    FB_PassiveSkillBase.AddContiueTime(builder, ContiueTime);
    FB_PassiveSkillBase.AddPriority(builder, Priority);
    FB_PassiveSkillBase.AddSoundId(builder, SoundId);
    FB_PassiveSkillBase.AddDamageBoardID(builder, DamageBoardID);
    FB_PassiveSkillBase.AddChildPassiveSkillList(builder, ChildPassiveSkillList);
    FB_PassiveSkillBase.AddTriggerParamList(builder, TriggerParamList);
    FB_PassiveSkillBase.AddTriggerConditionList(builder, TriggerConditionList);
    FB_PassiveSkillBase.AddTriggerResult(builder, TriggerResult);
    FB_PassiveSkillBase.AddTriggerTarget(builder, TriggerTarget);
    FB_PassiveSkillBase.AddCombatType(builder, CombatType);
    FB_PassiveSkillBase.AddTriggerHPPercent(builder, TriggerHPPercent);
    FB_PassiveSkillBase.AddTriggerHPTarget(builder, TriggerHPTarget);
    FB_PassiveSkillBase.AddTriggerChanceAddValue(builder, TriggerChanceAddValue);
    FB_PassiveSkillBase.AddTriggerChance(builder, TriggerChance);
    FB_PassiveSkillBase.AddTriggerType(builder, TriggerType);
    FB_PassiveSkillBase.AddCoolDownTime(builder, CoolDownTime);
    FB_PassiveSkillBase.AddIcon(builder, Icon);
    FB_PassiveSkillBase.AddSkillDescId(builder, SkillDescId);
    FB_PassiveSkillBase.AddName(builder, Name);
    FB_PassiveSkillBase.AddClassId(builder, ClassId);
    FB_PassiveSkillBase.AddID(builder, ID);
    FB_PassiveSkillBase.AddIsBroadCast(builder, IsBroadCast);
    FB_PassiveSkillBase.AddDestroyEffect(builder, DestroyEffect);
    return FB_PassiveSkillBase.EndFB_PassiveSkillBase(builder);
  }

  public static void StartFB_PassiveSkillBase(FlatBufferBuilder builder) { builder.StartObject(23); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddClassId(FlatBufferBuilder builder, int ClassId) { builder.AddInt(1, ClassId, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddSkillDescId(FlatBufferBuilder builder, int SkillDescId) { builder.AddInt(3, SkillDescId, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(4, IconOffset.Value, 0); }
  public static void AddCoolDownTime(FlatBufferBuilder builder, int CoolDownTime) { builder.AddInt(5, CoolDownTime, 0); }
  public static void AddTriggerType(FlatBufferBuilder builder, int TriggerType) { builder.AddInt(6, TriggerType, -1); }
  public static void AddTriggerChance(FlatBufferBuilder builder, int TriggerChance) { builder.AddInt(7, TriggerChance, -1); }
  public static void AddTriggerChanceAddValue(FlatBufferBuilder builder, int TriggerChanceAddValue) { builder.AddInt(8, TriggerChanceAddValue, -1); }
  public static void AddTriggerHPTarget(FlatBufferBuilder builder, int TriggerHPTarget) { builder.AddInt(9, TriggerHPTarget, -1); }
  public static void AddTriggerHPPercent(FlatBufferBuilder builder, int TriggerHPPercent) { builder.AddInt(10, TriggerHPPercent, -1); }
  public static void AddCombatType(FlatBufferBuilder builder, int CombatType) { builder.AddInt(11, CombatType, -1); }
  public static void AddTriggerTarget(FlatBufferBuilder builder, int TriggerTarget) { builder.AddInt(12, TriggerTarget, -1); }
  public static void AddTriggerResult(FlatBufferBuilder builder, int TriggerResult) { builder.AddInt(13, TriggerResult, -1); }
  public static void AddDestroyEffect(FlatBufferBuilder builder, bool DestroyEffect) { builder.AddBool(14, DestroyEffect, false); }
  public static void AddTriggerConditionList(FlatBufferBuilder builder, VectorOffset TriggerConditionListOffset) { builder.AddOffset(15, TriggerConditionListOffset.Value, 0); }
  public static VectorOffset CreateTriggerConditionListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTriggerConditionListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTriggerParamList(FlatBufferBuilder builder, VectorOffset TriggerParamListOffset) { builder.AddOffset(16, TriggerParamListOffset.Value, 0); }
  public static VectorOffset CreateTriggerParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTriggerParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChildPassiveSkillList(FlatBufferBuilder builder, VectorOffset ChildPassiveSkillListOffset) { builder.AddOffset(17, ChildPassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreateChildPassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartChildPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDamageBoardID(FlatBufferBuilder builder, int DamageBoardID) { builder.AddInt(18, DamageBoardID, -1); }
  public static void AddSoundId(FlatBufferBuilder builder, int SoundId) { builder.AddInt(19, SoundId, -1); }
  public static void AddPriority(FlatBufferBuilder builder, int Priority) { builder.AddInt(20, Priority, -1); }
  public static void AddIsBroadCast(FlatBufferBuilder builder, bool IsBroadCast) { builder.AddBool(21, IsBroadCast, false); }
  public static void AddContiueTime(FlatBufferBuilder builder, float ContiueTime) { builder.AddFloat(22, ContiueTime, -1); }
  public static Offset<FB_PassiveSkillBase> EndFB_PassiveSkillBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PassiveSkillBase>(o);
  }
};

public sealed class FB_PassiveSkillBaseContainer : Table {
  public static FB_PassiveSkillBaseContainer GetRootAsFB_PassiveSkillBaseContainer(ByteBuffer _bb) { return GetRootAsFB_PassiveSkillBaseContainer(_bb, new FB_PassiveSkillBaseContainer()); }
  public static FB_PassiveSkillBaseContainer GetRootAsFB_PassiveSkillBaseContainer(ByteBuffer _bb, FB_PassiveSkillBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PassiveSkillBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PassiveSkillBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PassiveSkillBase GetItems(int j) { return GetItems(new FB_PassiveSkillBase(), j); }
  public FB_PassiveSkillBase GetItems(FB_PassiveSkillBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PassiveSkillBaseContainer> CreateFB_PassiveSkillBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PassiveSkillBaseContainer.AddItems(builder, items);
    return FB_PassiveSkillBaseContainer.EndFB_PassiveSkillBaseContainer(builder);
  }

  public static void StartFB_PassiveSkillBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PassiveSkillBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PassiveSkillBaseContainer> EndFB_PassiveSkillBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PassiveSkillBaseContainer>(o);
  }
  public static void FinishFB_PassiveSkillBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_PassiveSkillBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
