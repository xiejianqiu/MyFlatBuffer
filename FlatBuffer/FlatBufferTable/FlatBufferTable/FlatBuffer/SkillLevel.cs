// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillLevel : Table {
  public static FB_SkillLevel GetRootAsFB_SkillLevel(ByteBuffer _bb) { return GetRootAsFB_SkillLevel(_bb, new FB_SkillLevel()); }
  public static FB_SkillLevel GetRootAsFB_SkillLevel(ByteBuffer _bb, FB_SkillLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayGold { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayItem { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NextLevel { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvancedExp { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BattlePower { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetLogicList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LogicListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLogicOneParamList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LogicOneParamListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLogicTowParamList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LogicTowParamListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public string LevelUpDesc { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_SkillLevel> CreateFB_SkillLevel(FlatBufferBuilder builder,
      int ID = 0,
      int Level = -1,
      int LevelLimit = -1,
      int GoldType = -1,
      int PayGold = -1,
      int ItemID = -1,
      int PayItem = -1,
      int NextLevel = -1,
      int AdvancedExp = 0,
      int BattlePower = 0,
      VectorOffset LogicList = default(VectorOffset),
      VectorOffset LogicOneParamList = default(VectorOffset),
      VectorOffset LogicTowParamList = default(VectorOffset),
      StringOffset LevelUpDesc = default(StringOffset)) {
    builder.StartObject(14);
    FB_SkillLevel.AddLevelUpDesc(builder, LevelUpDesc);
    FB_SkillLevel.AddLogicTowParamList(builder, LogicTowParamList);
    FB_SkillLevel.AddLogicOneParamList(builder, LogicOneParamList);
    FB_SkillLevel.AddLogicList(builder, LogicList);
    FB_SkillLevel.AddBattlePower(builder, BattlePower);
    FB_SkillLevel.AddAdvancedExp(builder, AdvancedExp);
    FB_SkillLevel.AddNextLevel(builder, NextLevel);
    FB_SkillLevel.AddPayItem(builder, PayItem);
    FB_SkillLevel.AddItemID(builder, ItemID);
    FB_SkillLevel.AddPayGold(builder, PayGold);
    FB_SkillLevel.AddGoldType(builder, GoldType);
    FB_SkillLevel.AddLevelLimit(builder, LevelLimit);
    FB_SkillLevel.AddLevel(builder, Level);
    FB_SkillLevel.AddID(builder, ID);
    return FB_SkillLevel.EndFB_SkillLevel(builder);
  }

  public static void StartFB_SkillLevel(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(2, LevelLimit, -1); }
  public static void AddGoldType(FlatBufferBuilder builder, int GoldType) { builder.AddInt(3, GoldType, -1); }
  public static void AddPayGold(FlatBufferBuilder builder, int PayGold) { builder.AddInt(4, PayGold, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(5, ItemID, -1); }
  public static void AddPayItem(FlatBufferBuilder builder, int PayItem) { builder.AddInt(6, PayItem, -1); }
  public static void AddNextLevel(FlatBufferBuilder builder, int NextLevel) { builder.AddInt(7, NextLevel, -1); }
  public static void AddAdvancedExp(FlatBufferBuilder builder, int AdvancedExp) { builder.AddInt(8, AdvancedExp, 0); }
  public static void AddBattlePower(FlatBufferBuilder builder, int BattlePower) { builder.AddInt(9, BattlePower, 0); }
  public static void AddLogicList(FlatBufferBuilder builder, VectorOffset LogicListOffset) { builder.AddOffset(10, LogicListOffset.Value, 0); }
  public static VectorOffset CreateLogicListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLogicListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLogicOneParamList(FlatBufferBuilder builder, VectorOffset LogicOneParamListOffset) { builder.AddOffset(11, LogicOneParamListOffset.Value, 0); }
  public static VectorOffset CreateLogicOneParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLogicOneParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLogicTowParamList(FlatBufferBuilder builder, VectorOffset LogicTowParamListOffset) { builder.AddOffset(12, LogicTowParamListOffset.Value, 0); }
  public static VectorOffset CreateLogicTowParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLogicTowParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelUpDesc(FlatBufferBuilder builder, StringOffset LevelUpDescOffset) { builder.AddOffset(13, LevelUpDescOffset.Value, 0); }
  public static Offset<FB_SkillLevel> EndFB_SkillLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillLevel>(o);
  }
};

public sealed class FB_SkillLevelContainer : Table {
  public static FB_SkillLevelContainer GetRootAsFB_SkillLevelContainer(ByteBuffer _bb) { return GetRootAsFB_SkillLevelContainer(_bb, new FB_SkillLevelContainer()); }
  public static FB_SkillLevelContainer GetRootAsFB_SkillLevelContainer(ByteBuffer _bb, FB_SkillLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillLevel GetItems(int j) { return GetItems(new FB_SkillLevel(), j); }
  public FB_SkillLevel GetItems(FB_SkillLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillLevelContainer> CreateFB_SkillLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillLevelContainer.AddItems(builder, items);
    return FB_SkillLevelContainer.EndFB_SkillLevelContainer(builder);
  }

  public static void StartFB_SkillLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillLevelContainer> EndFB_SkillLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillLevelContainer>(o);
  }
  public static void FinishFB_SkillLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
