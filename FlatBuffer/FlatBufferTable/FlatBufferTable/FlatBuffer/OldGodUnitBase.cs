// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OldGodUnitBase : Table {
  public static FB_OldGodUnitBase GetRootAsFB_OldGodUnitBase(ByteBuffer _bb) { return GetRootAsFB_OldGodUnitBase(_bb, new FB_OldGodUnitBase()); }
  public static FB_OldGodUnitBase GetRootAsFB_OldGodUnitBase(ByteBuffer _bb, FB_OldGodUnitBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OldGodUnitBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string NameIcon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string UnitIcon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SquareUnitIcon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuncOpenFakeObjId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharSoulId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockItemId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockItemCount { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPassiveCountList(int j) { int o = __offset(32); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveCountListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPassiveIdList(int j) { int o = __offset(34); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveIdListLength { get { int o = __offset(34); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodUnitBase> CreateFB_OldGodUnitBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset NameIcon = default(StringOffset),
      StringOffset UnitIcon = default(StringOffset),
      StringOffset SquareUnitIcon = default(StringOffset),
      int FakeObjId = -1,
      int FuncOpenFakeObjId = -1,
      int CharSoulId = -1,
      int Quality = -1,
      int UnLockType = -1,
      int UnLockItemId = -1,
      int UnLockItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset PassiveCountList = default(VectorOffset),
      VectorOffset PassiveIdList = default(VectorOffset)) {
    builder.StartObject(16);
    FB_OldGodUnitBase.AddPassiveIdList(builder, PassiveIdList);
    FB_OldGodUnitBase.AddPassiveCountList(builder, PassiveCountList);
    FB_OldGodUnitBase.AddAttrValueList(builder, AttrValueList);
    FB_OldGodUnitBase.AddAttrIdList(builder, AttrIdList);
    FB_OldGodUnitBase.AddUnLockItemCount(builder, UnLockItemCount);
    FB_OldGodUnitBase.AddUnLockItemId(builder, UnLockItemId);
    FB_OldGodUnitBase.AddUnLockType(builder, UnLockType);
    FB_OldGodUnitBase.AddQuality(builder, Quality);
    FB_OldGodUnitBase.AddCharSoulId(builder, CharSoulId);
    FB_OldGodUnitBase.AddFuncOpenFakeObjId(builder, FuncOpenFakeObjId);
    FB_OldGodUnitBase.AddFakeObjId(builder, FakeObjId);
    FB_OldGodUnitBase.AddSquareUnitIcon(builder, SquareUnitIcon);
    FB_OldGodUnitBase.AddUnitIcon(builder, UnitIcon);
    FB_OldGodUnitBase.AddNameIcon(builder, NameIcon);
    FB_OldGodUnitBase.AddName(builder, Name);
    FB_OldGodUnitBase.AddID(builder, ID);
    return FB_OldGodUnitBase.EndFB_OldGodUnitBase(builder);
  }

  public static void StartFB_OldGodUnitBase(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNameIcon(FlatBufferBuilder builder, StringOffset NameIconOffset) { builder.AddOffset(2, NameIconOffset.Value, 0); }
  public static void AddUnitIcon(FlatBufferBuilder builder, StringOffset UnitIconOffset) { builder.AddOffset(3, UnitIconOffset.Value, 0); }
  public static void AddSquareUnitIcon(FlatBufferBuilder builder, StringOffset SquareUnitIconOffset) { builder.AddOffset(4, SquareUnitIconOffset.Value, 0); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(5, FakeObjId, -1); }
  public static void AddFuncOpenFakeObjId(FlatBufferBuilder builder, int FuncOpenFakeObjId) { builder.AddInt(6, FuncOpenFakeObjId, -1); }
  public static void AddCharSoulId(FlatBufferBuilder builder, int CharSoulId) { builder.AddInt(7, CharSoulId, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(8, Quality, -1); }
  public static void AddUnLockType(FlatBufferBuilder builder, int UnLockType) { builder.AddInt(9, UnLockType, -1); }
  public static void AddUnLockItemId(FlatBufferBuilder builder, int UnLockItemId) { builder.AddInt(10, UnLockItemId, -1); }
  public static void AddUnLockItemCount(FlatBufferBuilder builder, int UnLockItemCount) { builder.AddInt(11, UnLockItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(12, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(13, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveCountList(FlatBufferBuilder builder, VectorOffset PassiveCountListOffset) { builder.AddOffset(14, PassiveCountListOffset.Value, 0); }
  public static VectorOffset CreatePassiveCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveIdList(FlatBufferBuilder builder, VectorOffset PassiveIdListOffset) { builder.AddOffset(15, PassiveIdListOffset.Value, 0); }
  public static VectorOffset CreatePassiveIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodUnitBase> EndFB_OldGodUnitBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodUnitBase>(o);
  }
};

public sealed class FB_OldGodUnitBaseContainer : Table {
  public static FB_OldGodUnitBaseContainer GetRootAsFB_OldGodUnitBaseContainer(ByteBuffer _bb) { return GetRootAsFB_OldGodUnitBaseContainer(_bb, new FB_OldGodUnitBaseContainer()); }
  public static FB_OldGodUnitBaseContainer GetRootAsFB_OldGodUnitBaseContainer(ByteBuffer _bb, FB_OldGodUnitBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OldGodUnitBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OldGodUnitBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OldGodUnitBase GetItems(int j) { return GetItems(new FB_OldGodUnitBase(), j); }
  public FB_OldGodUnitBase GetItems(FB_OldGodUnitBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodUnitBaseContainer> CreateFB_OldGodUnitBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OldGodUnitBaseContainer.AddItems(builder, items);
    return FB_OldGodUnitBaseContainer.EndFB_OldGodUnitBaseContainer(builder);
  }

  public static void StartFB_OldGodUnitBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OldGodUnitBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodUnitBaseContainer> EndFB_OldGodUnitBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodUnitBaseContainer>(o);
  }
  public static void FinishFB_OldGodUnitBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_OldGodUnitBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
