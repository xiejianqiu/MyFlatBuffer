// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenShiBase : Table {
  public static FB_ShenShiBase GetRootAsFB_ShenShiBase(ByteBuffer _bb) { return GetRootAsFB_ShenShiBase(_bb, new FB_ShenShiBase()); }
  public static FB_ShenShiBase GetRootAsFB_ShenShiBase(ByteBuffer _bb, FB_ShenShiBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenShiBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MenPai { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Position { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockLogicList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockLogicListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockTypeList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockTypeListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockIdList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockIdListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockValueList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockValueListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int TakeEffectType { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectValue { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectTypeSec { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectValueSec { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddSystemId { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddSystemPoint { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrDescId { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float GetDescParamList(int j) { int o = __offset(42); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int DescParamListLength { get { int o = __offset(42); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShiBase> CreateFB_ShenShiBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int MenPai = -1,
      int Type = -1,
      int Position = -1,
      int MaxLevel = -1,
      int SkillType = -1,
      VectorOffset UnLockLogicList = default(VectorOffset),
      VectorOffset UnLockTypeList = default(VectorOffset),
      VectorOffset UnLockIdList = default(VectorOffset),
      VectorOffset UnLockValueList = default(VectorOffset),
      int TakeEffectType = -1,
      int TakeEffectValue = -1,
      int TakeEffectTypeSec = -1,
      int TakeEffectValueSec = -1,
      int AddSystemId = -1,
      int AddSystemPoint = -1,
      int StrDescId = -1,
      VectorOffset DescParamList = default(VectorOffset)) {
    builder.StartObject(20);
    FB_ShenShiBase.AddDescParamList(builder, DescParamList);
    FB_ShenShiBase.AddStrDescId(builder, StrDescId);
    FB_ShenShiBase.AddAddSystemPoint(builder, AddSystemPoint);
    FB_ShenShiBase.AddAddSystemId(builder, AddSystemId);
    FB_ShenShiBase.AddTakeEffectValueSec(builder, TakeEffectValueSec);
    FB_ShenShiBase.AddTakeEffectTypeSec(builder, TakeEffectTypeSec);
    FB_ShenShiBase.AddTakeEffectValue(builder, TakeEffectValue);
    FB_ShenShiBase.AddTakeEffectType(builder, TakeEffectType);
    FB_ShenShiBase.AddUnLockValueList(builder, UnLockValueList);
    FB_ShenShiBase.AddUnLockIdList(builder, UnLockIdList);
    FB_ShenShiBase.AddUnLockTypeList(builder, UnLockTypeList);
    FB_ShenShiBase.AddUnLockLogicList(builder, UnLockLogicList);
    FB_ShenShiBase.AddSkillType(builder, SkillType);
    FB_ShenShiBase.AddMaxLevel(builder, MaxLevel);
    FB_ShenShiBase.AddPosition(builder, Position);
    FB_ShenShiBase.AddType(builder, Type);
    FB_ShenShiBase.AddMenPai(builder, MenPai);
    FB_ShenShiBase.AddIcon(builder, Icon);
    FB_ShenShiBase.AddName(builder, Name);
    FB_ShenShiBase.AddID(builder, ID);
    return FB_ShenShiBase.EndFB_ShenShiBase(builder);
  }

  public static void StartFB_ShenShiBase(FlatBufferBuilder builder) { builder.StartObject(20); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(3, MenPai, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(4, Type, -1); }
  public static void AddPosition(FlatBufferBuilder builder, int Position) { builder.AddInt(5, Position, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(6, MaxLevel, -1); }
  public static void AddSkillType(FlatBufferBuilder builder, int SkillType) { builder.AddInt(7, SkillType, -1); }
  public static void AddUnLockLogicList(FlatBufferBuilder builder, VectorOffset UnLockLogicListOffset) { builder.AddOffset(8, UnLockLogicListOffset.Value, 0); }
  public static VectorOffset CreateUnLockLogicListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockLogicListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockTypeList(FlatBufferBuilder builder, VectorOffset UnLockTypeListOffset) { builder.AddOffset(9, UnLockTypeListOffset.Value, 0); }
  public static VectorOffset CreateUnLockTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockIdList(FlatBufferBuilder builder, VectorOffset UnLockIdListOffset) { builder.AddOffset(10, UnLockIdListOffset.Value, 0); }
  public static VectorOffset CreateUnLockIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockValueList(FlatBufferBuilder builder, VectorOffset UnLockValueListOffset) { builder.AddOffset(11, UnLockValueListOffset.Value, 0); }
  public static VectorOffset CreateUnLockValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTakeEffectType(FlatBufferBuilder builder, int TakeEffectType) { builder.AddInt(12, TakeEffectType, -1); }
  public static void AddTakeEffectValue(FlatBufferBuilder builder, int TakeEffectValue) { builder.AddInt(13, TakeEffectValue, -1); }
  public static void AddTakeEffectTypeSec(FlatBufferBuilder builder, int TakeEffectTypeSec) { builder.AddInt(14, TakeEffectTypeSec, -1); }
  public static void AddTakeEffectValueSec(FlatBufferBuilder builder, int TakeEffectValueSec) { builder.AddInt(15, TakeEffectValueSec, -1); }
  public static void AddAddSystemId(FlatBufferBuilder builder, int AddSystemId) { builder.AddInt(16, AddSystemId, -1); }
  public static void AddAddSystemPoint(FlatBufferBuilder builder, int AddSystemPoint) { builder.AddInt(17, AddSystemPoint, -1); }
  public static void AddStrDescId(FlatBufferBuilder builder, int StrDescId) { builder.AddInt(18, StrDescId, -1); }
  public static void AddDescParamList(FlatBufferBuilder builder, VectorOffset DescParamListOffset) { builder.AddOffset(19, DescParamListOffset.Value, 0); }
  public static VectorOffset CreateDescParamListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartDescParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShiBase> EndFB_ShenShiBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShiBase>(o);
  }
};

public sealed class FB_ShenShiBaseContainer : Table {
  public static FB_ShenShiBaseContainer GetRootAsFB_ShenShiBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShenShiBaseContainer(_bb, new FB_ShenShiBaseContainer()); }
  public static FB_ShenShiBaseContainer GetRootAsFB_ShenShiBaseContainer(ByteBuffer _bb, FB_ShenShiBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenShiBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenShiBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenShiBase GetItems(int j) { return GetItems(new FB_ShenShiBase(), j); }
  public FB_ShenShiBase GetItems(FB_ShenShiBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShiBaseContainer> CreateFB_ShenShiBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenShiBaseContainer.AddItems(builder, items);
    return FB_ShenShiBaseContainer.EndFB_ShenShiBaseContainer(builder);
  }

  public static void StartFB_ShenShiBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenShiBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShiBaseContainer> EndFB_ShenShiBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShiBaseContainer>(o);
  }
  public static void FinishFB_ShenShiBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenShiBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
