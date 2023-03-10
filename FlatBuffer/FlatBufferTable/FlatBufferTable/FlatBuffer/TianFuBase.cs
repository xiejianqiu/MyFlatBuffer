// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TianFuBase : Table {
  public static FB_TianFuBase GetRootAsFB_TianFuBase(ByteBuffer _bb) { return GetRootAsFB_TianFuBase(_bb, new FB_TianFuBase()); }
  public static FB_TianFuBase GetRootAsFB_TianFuBase(ByteBuffer _bb, FB_TianFuBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TianFuBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MenPai { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Position { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockTypeList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockTypeListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int TakeEffectType { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectValue { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TakeEffectValueSec { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrDescId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float GetDescParamList(int j) { int o = __offset(32); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int DescParamListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianFuBase> CreateFB_TianFuBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int MenPai = -1,
      int Type = -1,
      int Position = -1,
      int MaxLevel = -1,
      VectorOffset UnLockTypeList = default(VectorOffset),
      VectorOffset UnLockIdList = default(VectorOffset),
      VectorOffset UnLockValueList = default(VectorOffset),
      int TakeEffectType = -1,
      int TakeEffectValue = -1,
      int TakeEffectValueSec = -1,
      int StrDescId = -1,
      VectorOffset DescParamList = default(VectorOffset)) {
    builder.StartObject(15);
    FB_TianFuBase.AddDescParamList(builder, DescParamList);
    FB_TianFuBase.AddStrDescId(builder, StrDescId);
    FB_TianFuBase.AddTakeEffectValueSec(builder, TakeEffectValueSec);
    FB_TianFuBase.AddTakeEffectValue(builder, TakeEffectValue);
    FB_TianFuBase.AddTakeEffectType(builder, TakeEffectType);
    FB_TianFuBase.AddUnLockValueList(builder, UnLockValueList);
    FB_TianFuBase.AddUnLockIdList(builder, UnLockIdList);
    FB_TianFuBase.AddUnLockTypeList(builder, UnLockTypeList);
    FB_TianFuBase.AddMaxLevel(builder, MaxLevel);
    FB_TianFuBase.AddPosition(builder, Position);
    FB_TianFuBase.AddType(builder, Type);
    FB_TianFuBase.AddMenPai(builder, MenPai);
    FB_TianFuBase.AddIcon(builder, Icon);
    FB_TianFuBase.AddName(builder, Name);
    FB_TianFuBase.AddID(builder, ID);
    return FB_TianFuBase.EndFB_TianFuBase(builder);
  }

  public static void StartFB_TianFuBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(3, MenPai, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(4, Type, -1); }
  public static void AddPosition(FlatBufferBuilder builder, int Position) { builder.AddInt(5, Position, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(6, MaxLevel, -1); }
  public static void AddUnLockTypeList(FlatBufferBuilder builder, VectorOffset UnLockTypeListOffset) { builder.AddOffset(7, UnLockTypeListOffset.Value, 0); }
  public static VectorOffset CreateUnLockTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockIdList(FlatBufferBuilder builder, VectorOffset UnLockIdListOffset) { builder.AddOffset(8, UnLockIdListOffset.Value, 0); }
  public static VectorOffset CreateUnLockIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockValueList(FlatBufferBuilder builder, VectorOffset UnLockValueListOffset) { builder.AddOffset(9, UnLockValueListOffset.Value, 0); }
  public static VectorOffset CreateUnLockValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTakeEffectType(FlatBufferBuilder builder, int TakeEffectType) { builder.AddInt(10, TakeEffectType, -1); }
  public static void AddTakeEffectValue(FlatBufferBuilder builder, int TakeEffectValue) { builder.AddInt(11, TakeEffectValue, -1); }
  public static void AddTakeEffectValueSec(FlatBufferBuilder builder, int TakeEffectValueSec) { builder.AddInt(12, TakeEffectValueSec, -1); }
  public static void AddStrDescId(FlatBufferBuilder builder, int StrDescId) { builder.AddInt(13, StrDescId, -1); }
  public static void AddDescParamList(FlatBufferBuilder builder, VectorOffset DescParamListOffset) { builder.AddOffset(14, DescParamListOffset.Value, 0); }
  public static VectorOffset CreateDescParamListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartDescParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianFuBase> EndFB_TianFuBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianFuBase>(o);
  }
};

public sealed class FB_TianFuBaseContainer : Table {
  public static FB_TianFuBaseContainer GetRootAsFB_TianFuBaseContainer(ByteBuffer _bb) { return GetRootAsFB_TianFuBaseContainer(_bb, new FB_TianFuBaseContainer()); }
  public static FB_TianFuBaseContainer GetRootAsFB_TianFuBaseContainer(ByteBuffer _bb, FB_TianFuBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TianFuBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TianFuBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TianFuBase GetItems(int j) { return GetItems(new FB_TianFuBase(), j); }
  public FB_TianFuBase GetItems(FB_TianFuBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianFuBaseContainer> CreateFB_TianFuBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TianFuBaseContainer.AddItems(builder, items);
    return FB_TianFuBaseContainer.EndFB_TianFuBaseContainer(builder);
  }

  public static void StartFB_TianFuBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TianFuBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianFuBaseContainer> EndFB_TianFuBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianFuBaseContainer>(o);
  }
  public static void FinishFB_TianFuBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_TianFuBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
