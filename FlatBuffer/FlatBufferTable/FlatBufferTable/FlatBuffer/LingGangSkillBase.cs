// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingGangSkillBase : Table {
  public static FB_LingGangSkillBase GetRootAsFB_LingGangSkillBase(ByteBuffer _bb) { return GetRootAsFB_LingGangSkillBase(_bb, new FB_LingGangSkillBase()); }
  public static FB_LingGangSkillBase GetRootAsFB_LingGangSkillBase(ByteBuffer _bb, FB_LingGangSkillBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingGangSkillBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MenPai { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Position { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int UnLockValue { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectValue { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectValueSec { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrDescId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float GetDescParamList(int j) { int o = __offset(30); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int DescParamListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int BorderType { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LingGangSkillBase> CreateFB_LingGangSkillBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int MenPai = -1,
      int Type = -1,
      int Position = -1,
      int MaxLevel = -1,
      VectorOffset UnLockIdList = default(VectorOffset),
      int UnLockValue = -1,
      int TakeEffectType = -1,
      int TakeEffectValue = -1,
      int TakeEffectValueSec = -1,
      int StrDescId = -1,
      VectorOffset DescParamList = default(VectorOffset),
      int BorderType = -1) {
    builder.StartObject(15);
    FB_LingGangSkillBase.AddBorderType(builder, BorderType);
    FB_LingGangSkillBase.AddDescParamList(builder, DescParamList);
    FB_LingGangSkillBase.AddStrDescId(builder, StrDescId);
    FB_LingGangSkillBase.AddTakeEffectValueSec(builder, TakeEffectValueSec);
    FB_LingGangSkillBase.AddTakeEffectValue(builder, TakeEffectValue);
    FB_LingGangSkillBase.AddTakeEffectType(builder, TakeEffectType);
    FB_LingGangSkillBase.AddUnLockValue(builder, UnLockValue);
    FB_LingGangSkillBase.AddUnLockIdList(builder, UnLockIdList);
    FB_LingGangSkillBase.AddMaxLevel(builder, MaxLevel);
    FB_LingGangSkillBase.AddPosition(builder, Position);
    FB_LingGangSkillBase.AddType(builder, Type);
    FB_LingGangSkillBase.AddMenPai(builder, MenPai);
    FB_LingGangSkillBase.AddIcon(builder, Icon);
    FB_LingGangSkillBase.AddName(builder, Name);
    FB_LingGangSkillBase.AddID(builder, ID);
    return FB_LingGangSkillBase.EndFB_LingGangSkillBase(builder);
  }

  public static void StartFB_LingGangSkillBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(3, MenPai, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(4, Type, -1); }
  public static void AddPosition(FlatBufferBuilder builder, int Position) { builder.AddInt(5, Position, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(6, MaxLevel, -1); }
  public static void AddUnLockIdList(FlatBufferBuilder builder, VectorOffset UnLockIdListOffset) { builder.AddOffset(7, UnLockIdListOffset.Value, 0); }
  public static VectorOffset CreateUnLockIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockValue(FlatBufferBuilder builder, int UnLockValue) { builder.AddInt(8, UnLockValue, -1); }
  public static void AddTakeEffectType(FlatBufferBuilder builder, int TakeEffectType) { builder.AddInt(9, TakeEffectType, -1); }
  public static void AddTakeEffectValue(FlatBufferBuilder builder, int TakeEffectValue) { builder.AddInt(10, TakeEffectValue, -1); }
  public static void AddTakeEffectValueSec(FlatBufferBuilder builder, int TakeEffectValueSec) { builder.AddInt(11, TakeEffectValueSec, -1); }
  public static void AddStrDescId(FlatBufferBuilder builder, int StrDescId) { builder.AddInt(12, StrDescId, -1); }
  public static void AddDescParamList(FlatBufferBuilder builder, VectorOffset DescParamListOffset) { builder.AddOffset(13, DescParamListOffset.Value, 0); }
  public static VectorOffset CreateDescParamListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartDescParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBorderType(FlatBufferBuilder builder, int BorderType) { builder.AddInt(14, BorderType, -1); }
  public static Offset<FB_LingGangSkillBase> EndFB_LingGangSkillBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangSkillBase>(o);
  }
};

public sealed class FB_LingGangSkillBaseContainer : Table {
  public static FB_LingGangSkillBaseContainer GetRootAsFB_LingGangSkillBaseContainer(ByteBuffer _bb) { return GetRootAsFB_LingGangSkillBaseContainer(_bb, new FB_LingGangSkillBaseContainer()); }
  public static FB_LingGangSkillBaseContainer GetRootAsFB_LingGangSkillBaseContainer(ByteBuffer _bb, FB_LingGangSkillBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingGangSkillBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingGangSkillBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingGangSkillBase GetItems(int j) { return GetItems(new FB_LingGangSkillBase(), j); }
  public FB_LingGangSkillBase GetItems(FB_LingGangSkillBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangSkillBaseContainer> CreateFB_LingGangSkillBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingGangSkillBaseContainer.AddItems(builder, items);
    return FB_LingGangSkillBaseContainer.EndFB_LingGangSkillBaseContainer(builder);
  }

  public static void StartFB_LingGangSkillBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingGangSkillBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangSkillBaseContainer> EndFB_LingGangSkillBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangSkillBaseContainer>(o);
  }
  public static void FinishFB_LingGangSkillBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingGangSkillBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
