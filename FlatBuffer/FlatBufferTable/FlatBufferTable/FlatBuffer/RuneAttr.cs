// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RuneAttr : Table {
  public static FB_RuneAttr GetRootAsFB_RuneAttr(ByteBuffer _bb) { return GetRootAsFB_RuneAttr(_bb, new FB_RuneAttr()); }
  public static FB_RuneAttr GetRootAsFB_RuneAttr(ByteBuffer _bb, FB_RuneAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RuneAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelupType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JieupType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Exp { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueIncList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueIncListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueJieIncList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueJieIncListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int UnLockTowerId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockTowID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneType { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneComBatBaseValue { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneLevelCombatValue { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneJieCombatValue { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneSkillBaseValue { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneSkillLevelValue { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneSkillJieValue { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassiveSkillID { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_RuneAttr> CreateFB_RuneAttr(FlatBufferBuilder builder,
      int ID = 0,
      int LevelupType = -1,
      int JieupType = -1,
      int Exp = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset AttrValueIncList = default(VectorOffset),
      VectorOffset AttrValueJieIncList = default(VectorOffset),
      int UnLockTowerId = -1,
      int UnlockTowID = -1,
      int RuneType = -1,
      int RuneComBatBaseValue = -1,
      int RuneLevelCombatValue = -1,
      int RuneJieCombatValue = -1,
      int RuneSkillBaseValue = -1,
      int RuneSkillLevelValue = -1,
      int RuneSkillJieValue = -1,
      int PassiveSkillID = -1) {
    builder.StartObject(18);
    FB_RuneAttr.AddPassiveSkillID(builder, PassiveSkillID);
    FB_RuneAttr.AddRuneSkillJieValue(builder, RuneSkillJieValue);
    FB_RuneAttr.AddRuneSkillLevelValue(builder, RuneSkillLevelValue);
    FB_RuneAttr.AddRuneSkillBaseValue(builder, RuneSkillBaseValue);
    FB_RuneAttr.AddRuneJieCombatValue(builder, RuneJieCombatValue);
    FB_RuneAttr.AddRuneLevelCombatValue(builder, RuneLevelCombatValue);
    FB_RuneAttr.AddRuneComBatBaseValue(builder, RuneComBatBaseValue);
    FB_RuneAttr.AddRuneType(builder, RuneType);
    FB_RuneAttr.AddUnlockTowID(builder, UnlockTowID);
    FB_RuneAttr.AddUnLockTowerId(builder, UnLockTowerId);
    FB_RuneAttr.AddAttrValueJieIncList(builder, AttrValueJieIncList);
    FB_RuneAttr.AddAttrValueIncList(builder, AttrValueIncList);
    FB_RuneAttr.AddAttrValueList(builder, AttrValueList);
    FB_RuneAttr.AddAttrIDList(builder, AttrIDList);
    FB_RuneAttr.AddExp(builder, Exp);
    FB_RuneAttr.AddJieupType(builder, JieupType);
    FB_RuneAttr.AddLevelupType(builder, LevelupType);
    FB_RuneAttr.AddID(builder, ID);
    return FB_RuneAttr.EndFB_RuneAttr(builder);
  }

  public static void StartFB_RuneAttr(FlatBufferBuilder builder) { builder.StartObject(18); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevelupType(FlatBufferBuilder builder, int LevelupType) { builder.AddInt(1, LevelupType, -1); }
  public static void AddJieupType(FlatBufferBuilder builder, int JieupType) { builder.AddInt(2, JieupType, -1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(3, Exp, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(4, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueIncList(FlatBufferBuilder builder, VectorOffset AttrValueIncListOffset) { builder.AddOffset(6, AttrValueIncListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueIncListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueIncListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueJieIncList(FlatBufferBuilder builder, VectorOffset AttrValueJieIncListOffset) { builder.AddOffset(7, AttrValueJieIncListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueJieIncListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueJieIncListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockTowerId(FlatBufferBuilder builder, int UnLockTowerId) { builder.AddInt(8, UnLockTowerId, -1); }
  public static void AddUnlockTowID(FlatBufferBuilder builder, int UnlockTowID) { builder.AddInt(9, UnlockTowID, -1); }
  public static void AddRuneType(FlatBufferBuilder builder, int RuneType) { builder.AddInt(10, RuneType, -1); }
  public static void AddRuneComBatBaseValue(FlatBufferBuilder builder, int RuneComBatBaseValue) { builder.AddInt(11, RuneComBatBaseValue, -1); }
  public static void AddRuneLevelCombatValue(FlatBufferBuilder builder, int RuneLevelCombatValue) { builder.AddInt(12, RuneLevelCombatValue, -1); }
  public static void AddRuneJieCombatValue(FlatBufferBuilder builder, int RuneJieCombatValue) { builder.AddInt(13, RuneJieCombatValue, -1); }
  public static void AddRuneSkillBaseValue(FlatBufferBuilder builder, int RuneSkillBaseValue) { builder.AddInt(14, RuneSkillBaseValue, -1); }
  public static void AddRuneSkillLevelValue(FlatBufferBuilder builder, int RuneSkillLevelValue) { builder.AddInt(15, RuneSkillLevelValue, -1); }
  public static void AddRuneSkillJieValue(FlatBufferBuilder builder, int RuneSkillJieValue) { builder.AddInt(16, RuneSkillJieValue, -1); }
  public static void AddPassiveSkillID(FlatBufferBuilder builder, int PassiveSkillID) { builder.AddInt(17, PassiveSkillID, -1); }
  public static Offset<FB_RuneAttr> EndFB_RuneAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneAttr>(o);
  }
};

public sealed class FB_RuneAttrContainer : Table {
  public static FB_RuneAttrContainer GetRootAsFB_RuneAttrContainer(ByteBuffer _bb) { return GetRootAsFB_RuneAttrContainer(_bb, new FB_RuneAttrContainer()); }
  public static FB_RuneAttrContainer GetRootAsFB_RuneAttrContainer(ByteBuffer _bb, FB_RuneAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RuneAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RuneAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RuneAttr GetItems(int j) { return GetItems(new FB_RuneAttr(), j); }
  public FB_RuneAttr GetItems(FB_RuneAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RuneAttrContainer> CreateFB_RuneAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RuneAttrContainer.AddItems(builder, items);
    return FB_RuneAttrContainer.EndFB_RuneAttrContainer(builder);
  }

  public static void StartFB_RuneAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RuneAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RuneAttrContainer> EndFB_RuneAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneAttrContainer>(o);
  }
  public static void FinishFB_RuneAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_RuneAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
