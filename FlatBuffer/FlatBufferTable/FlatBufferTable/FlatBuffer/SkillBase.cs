// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillBase : Table {
  public static FB_SkillBase GetRootAsFB_SkillBase(ByteBuffer _bb) { return GetRootAsFB_SkillBase(_bb, new FB_SkillBase()); }
  public static FB_SkillBase GetRootAsFB_SkillBase(ByteBuffer _bb, FB_SkillBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LevelUpID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowSkillName { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsAutoSelectTar { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public string Icon { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SkillClass { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int UseType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int IsMove { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IsMoveBreak { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IsSkillBreak { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IsBreakBeAttacked { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TargetType { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)4; } }
  public int SelLogic { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IsNeedStopEffectId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IsTargetDieBreak { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_SkillBase> CreateFB_SkillBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int LevelUpID = -1,
      bool IsShowSkillName = true,
      bool IsAutoSelectTar = true,
      StringOffset Icon = default(StringOffset),
      int SkillClass = 1,
      int UseType = 1,
      int IsMove = 0,
      int IsMoveBreak = 0,
      int IsSkillBreak = 0,
      int IsBreakBeAttacked = 0,
      int TargetType = 4,
      int SelLogic = 0,
      int IsNeedStopEffectId = -1,
      int IsTargetDieBreak = 0) {
    builder.StartObject(16);
    FB_SkillBase.AddIsTargetDieBreak(builder, IsTargetDieBreak);
    FB_SkillBase.AddIsNeedStopEffectId(builder, IsNeedStopEffectId);
    FB_SkillBase.AddSelLogic(builder, SelLogic);
    FB_SkillBase.AddTargetType(builder, TargetType);
    FB_SkillBase.AddIsBreakBeAttacked(builder, IsBreakBeAttacked);
    FB_SkillBase.AddIsSkillBreak(builder, IsSkillBreak);
    FB_SkillBase.AddIsMoveBreak(builder, IsMoveBreak);
    FB_SkillBase.AddIsMove(builder, IsMove);
    FB_SkillBase.AddUseType(builder, UseType);
    FB_SkillBase.AddSkillClass(builder, SkillClass);
    FB_SkillBase.AddIcon(builder, Icon);
    FB_SkillBase.AddLevelUpID(builder, LevelUpID);
    FB_SkillBase.AddName(builder, Name);
    FB_SkillBase.AddId(builder, Id);
    FB_SkillBase.AddIsAutoSelectTar(builder, IsAutoSelectTar);
    FB_SkillBase.AddIsShowSkillName(builder, IsShowSkillName);
    return FB_SkillBase.EndFB_SkillBase(builder);
  }

  public static void StartFB_SkillBase(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLevelUpID(FlatBufferBuilder builder, int LevelUpID) { builder.AddInt(2, LevelUpID, -1); }
  public static void AddIsShowSkillName(FlatBufferBuilder builder, bool IsShowSkillName) { builder.AddBool(3, IsShowSkillName, true); }
  public static void AddIsAutoSelectTar(FlatBufferBuilder builder, bool IsAutoSelectTar) { builder.AddBool(4, IsAutoSelectTar, true); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(5, IconOffset.Value, 0); }
  public static void AddSkillClass(FlatBufferBuilder builder, int SkillClass) { builder.AddInt(6, SkillClass, 1); }
  public static void AddUseType(FlatBufferBuilder builder, int UseType) { builder.AddInt(7, UseType, 1); }
  public static void AddIsMove(FlatBufferBuilder builder, int IsMove) { builder.AddInt(8, IsMove, 0); }
  public static void AddIsMoveBreak(FlatBufferBuilder builder, int IsMoveBreak) { builder.AddInt(9, IsMoveBreak, 0); }
  public static void AddIsSkillBreak(FlatBufferBuilder builder, int IsSkillBreak) { builder.AddInt(10, IsSkillBreak, 0); }
  public static void AddIsBreakBeAttacked(FlatBufferBuilder builder, int IsBreakBeAttacked) { builder.AddInt(11, IsBreakBeAttacked, 0); }
  public static void AddTargetType(FlatBufferBuilder builder, int TargetType) { builder.AddInt(12, TargetType, 4); }
  public static void AddSelLogic(FlatBufferBuilder builder, int SelLogic) { builder.AddInt(13, SelLogic, 0); }
  public static void AddIsNeedStopEffectId(FlatBufferBuilder builder, int IsNeedStopEffectId) { builder.AddInt(14, IsNeedStopEffectId, -1); }
  public static void AddIsTargetDieBreak(FlatBufferBuilder builder, int IsTargetDieBreak) { builder.AddInt(15, IsTargetDieBreak, 0); }
  public static Offset<FB_SkillBase> EndFB_SkillBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillBase>(o);
  }
};

public sealed class FB_SkillBaseContainer : Table {
  public static FB_SkillBaseContainer GetRootAsFB_SkillBaseContainer(ByteBuffer _bb) { return GetRootAsFB_SkillBaseContainer(_bb, new FB_SkillBaseContainer()); }
  public static FB_SkillBaseContainer GetRootAsFB_SkillBaseContainer(ByteBuffer _bb, FB_SkillBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillBase GetItems(int j) { return GetItems(new FB_SkillBase(), j); }
  public FB_SkillBase GetItems(FB_SkillBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillBaseContainer> CreateFB_SkillBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillBaseContainer.AddItems(builder, items);
    return FB_SkillBaseContainer.EndFB_SkillBaseContainer(builder);
  }

  public static void StartFB_SkillBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillBaseContainer> EndFB_SkillBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillBaseContainer>(o);
  }
  public static void FinishFB_SkillBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
