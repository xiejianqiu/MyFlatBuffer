// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunUnitBase : Table {
  public static FB_XingHunUnitBase GetRootAsFB_XingHunUnitBase(ByteBuffer _bb) { return GetRootAsFB_XingHunUnitBase(_bb, new FB_XingHunUnitBase()); }
  public static FB_XingHunUnitBase GetRootAsFB_XingHunUnitBase(ByteBuffer _bb, FB_XingHunUnitBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunUnitBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string NameIcon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string StarSoulName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string EffectPath { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MenPai { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharXingHunId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EffectIndex { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockTypeList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockTypeListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockParamList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockParamListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int UnlockDescStrId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(32); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunUnitBase> CreateFB_XingHunUnitBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int ItemId = -1,
      StringOffset NameIcon = default(StringOffset),
      StringOffset StarSoulName = default(StringOffset),
      StringOffset EffectPath = default(StringOffset),
      int MenPai = -1,
      int FakeObjId = -1,
      int CharXingHunId = -1,
      int EffectIndex = -1,
      VectorOffset UnLockTypeList = default(VectorOffset),
      VectorOffset UnLockParamList = default(VectorOffset),
      int UnlockDescStrId = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(15);
    FB_XingHunUnitBase.AddAttrValueList(builder, AttrValueList);
    FB_XingHunUnitBase.AddAttrIdList(builder, AttrIdList);
    FB_XingHunUnitBase.AddUnlockDescStrId(builder, UnlockDescStrId);
    FB_XingHunUnitBase.AddUnLockParamList(builder, UnLockParamList);
    FB_XingHunUnitBase.AddUnLockTypeList(builder, UnLockTypeList);
    FB_XingHunUnitBase.AddEffectIndex(builder, EffectIndex);
    FB_XingHunUnitBase.AddCharXingHunId(builder, CharXingHunId);
    FB_XingHunUnitBase.AddFakeObjId(builder, FakeObjId);
    FB_XingHunUnitBase.AddMenPai(builder, MenPai);
    FB_XingHunUnitBase.AddEffectPath(builder, EffectPath);
    FB_XingHunUnitBase.AddStarSoulName(builder, StarSoulName);
    FB_XingHunUnitBase.AddNameIcon(builder, NameIcon);
    FB_XingHunUnitBase.AddItemId(builder, ItemId);
    FB_XingHunUnitBase.AddName(builder, Name);
    FB_XingHunUnitBase.AddID(builder, ID);
    return FB_XingHunUnitBase.EndFB_XingHunUnitBase(builder);
  }

  public static void StartFB_XingHunUnitBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(2, ItemId, -1); }
  public static void AddNameIcon(FlatBufferBuilder builder, StringOffset NameIconOffset) { builder.AddOffset(3, NameIconOffset.Value, 0); }
  public static void AddStarSoulName(FlatBufferBuilder builder, StringOffset StarSoulNameOffset) { builder.AddOffset(4, StarSoulNameOffset.Value, 0); }
  public static void AddEffectPath(FlatBufferBuilder builder, StringOffset EffectPathOffset) { builder.AddOffset(5, EffectPathOffset.Value, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(6, MenPai, -1); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(7, FakeObjId, -1); }
  public static void AddCharXingHunId(FlatBufferBuilder builder, int CharXingHunId) { builder.AddInt(8, CharXingHunId, -1); }
  public static void AddEffectIndex(FlatBufferBuilder builder, int EffectIndex) { builder.AddInt(9, EffectIndex, -1); }
  public static void AddUnLockTypeList(FlatBufferBuilder builder, VectorOffset UnLockTypeListOffset) { builder.AddOffset(10, UnLockTypeListOffset.Value, 0); }
  public static VectorOffset CreateUnLockTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockParamList(FlatBufferBuilder builder, VectorOffset UnLockParamListOffset) { builder.AddOffset(11, UnLockParamListOffset.Value, 0); }
  public static VectorOffset CreateUnLockParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnlockDescStrId(FlatBufferBuilder builder, int UnlockDescStrId) { builder.AddInt(12, UnlockDescStrId, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(13, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(14, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunUnitBase> EndFB_XingHunUnitBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunUnitBase>(o);
  }
};

public sealed class FB_XingHunUnitBaseContainer : Table {
  public static FB_XingHunUnitBaseContainer GetRootAsFB_XingHunUnitBaseContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunUnitBaseContainer(_bb, new FB_XingHunUnitBaseContainer()); }
  public static FB_XingHunUnitBaseContainer GetRootAsFB_XingHunUnitBaseContainer(ByteBuffer _bb, FB_XingHunUnitBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunUnitBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunUnitBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunUnitBase GetItems(int j) { return GetItems(new FB_XingHunUnitBase(), j); }
  public FB_XingHunUnitBase GetItems(FB_XingHunUnitBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunUnitBaseContainer> CreateFB_XingHunUnitBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunUnitBaseContainer.AddItems(builder, items);
    return FB_XingHunUnitBaseContainer.EndFB_XingHunUnitBaseContainer(builder);
  }

  public static void StartFB_XingHunUnitBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunUnitBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunUnitBaseContainer> EndFB_XingHunUnitBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunUnitBaseContainer>(o);
  }
  public static void FinishFB_XingHunUnitBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunUnitBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
