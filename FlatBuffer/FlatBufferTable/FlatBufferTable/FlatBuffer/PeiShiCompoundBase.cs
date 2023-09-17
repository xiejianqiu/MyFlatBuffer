// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PeiShiCompoundBase : Table {
  public static FB_PeiShiCompoundBase GetRootAsFB_PeiShiCompoundBase(ByteBuffer _bb) { return GetRootAsFB_PeiShiCompoundBase(_bb, new FB_PeiShiCompoundBase()); }
  public static FB_PeiShiCompoundBase GetRootAsFB_PeiShiCompoundBase(ByteBuffer _bb, FB_PeiShiCompoundBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PeiShiCompoundBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRequireIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RequireIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRequireNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RequireNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int Sort { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitValue { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockItemId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AvatarExp { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool EquipOnGet { get { int o = __offset(28); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public string EffectName { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DurationTime { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(38); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(38); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PeiShiCompoundBase> CreateFB_PeiShiCompoundBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      VectorOffset RequireIDList = default(VectorOffset),
      VectorOffset RequireNumList = default(VectorOffset),
      int Sort = -1,
      int LimitType = 0,
      int LimitValue = 0,
      int UnLockItemId = 0,
      int AvatarExp = -1,
      int Quality = -1,
      int StrID = -1,
      bool EquipOnGet = false,
      StringOffset EffectName = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int DurationTime = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(18);
    FB_PeiShiCompoundBase.AddAttrValueList(builder, AttrValueList);
    FB_PeiShiCompoundBase.AddAttrIdList(builder, AttrIdList);
    FB_PeiShiCompoundBase.AddDurationTime(builder, DurationTime);
    FB_PeiShiCompoundBase.AddIcon(builder, Icon);
    FB_PeiShiCompoundBase.AddEffectName(builder, EffectName);
    FB_PeiShiCompoundBase.AddStrID(builder, StrID);
    FB_PeiShiCompoundBase.AddQuality(builder, Quality);
    FB_PeiShiCompoundBase.AddAvatarExp(builder, AvatarExp);
    FB_PeiShiCompoundBase.AddUnLockItemId(builder, UnLockItemId);
    FB_PeiShiCompoundBase.AddLimitValue(builder, LimitValue);
    FB_PeiShiCompoundBase.AddLimitType(builder, LimitType);
    FB_PeiShiCompoundBase.AddSort(builder, Sort);
    FB_PeiShiCompoundBase.AddRequireNumList(builder, RequireNumList);
    FB_PeiShiCompoundBase.AddRequireIDList(builder, RequireIDList);
    FB_PeiShiCompoundBase.AddType(builder, Type);
    FB_PeiShiCompoundBase.AddName(builder, Name);
    FB_PeiShiCompoundBase.AddID(builder, ID);
    FB_PeiShiCompoundBase.AddEquipOnGet(builder, EquipOnGet);
    return FB_PeiShiCompoundBase.EndFB_PeiShiCompoundBase(builder);
  }

  public static void StartFB_PeiShiCompoundBase(FlatBufferBuilder builder) { builder.StartObject(18); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddRequireIDList(FlatBufferBuilder builder, VectorOffset RequireIDListOffset) { builder.AddOffset(3, RequireIDListOffset.Value, 0); }
  public static VectorOffset CreateRequireIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRequireIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRequireNumList(FlatBufferBuilder builder, VectorOffset RequireNumListOffset) { builder.AddOffset(4, RequireNumListOffset.Value, 0); }
  public static VectorOffset CreateRequireNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRequireNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSort(FlatBufferBuilder builder, int Sort) { builder.AddInt(5, Sort, -1); }
  public static void AddLimitType(FlatBufferBuilder builder, int LimitType) { builder.AddInt(6, LimitType, 0); }
  public static void AddLimitValue(FlatBufferBuilder builder, int LimitValue) { builder.AddInt(7, LimitValue, 0); }
  public static void AddUnLockItemId(FlatBufferBuilder builder, int UnLockItemId) { builder.AddInt(8, UnLockItemId, 0); }
  public static void AddAvatarExp(FlatBufferBuilder builder, int AvatarExp) { builder.AddInt(9, AvatarExp, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(10, Quality, -1); }
  public static void AddStrID(FlatBufferBuilder builder, int StrID) { builder.AddInt(11, StrID, -1); }
  public static void AddEquipOnGet(FlatBufferBuilder builder, bool EquipOnGet) { builder.AddBool(12, EquipOnGet, false); }
  public static void AddEffectName(FlatBufferBuilder builder, StringOffset EffectNameOffset) { builder.AddOffset(13, EffectNameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(14, IconOffset.Value, 0); }
  public static void AddDurationTime(FlatBufferBuilder builder, int DurationTime) { builder.AddInt(15, DurationTime, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(16, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(17, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PeiShiCompoundBase> EndFB_PeiShiCompoundBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PeiShiCompoundBase>(o);
  }
};

public sealed class FB_PeiShiCompoundBaseContainer : Table {
  public static FB_PeiShiCompoundBaseContainer GetRootAsFB_PeiShiCompoundBaseContainer(ByteBuffer _bb) { return GetRootAsFB_PeiShiCompoundBaseContainer(_bb, new FB_PeiShiCompoundBaseContainer()); }
  public static FB_PeiShiCompoundBaseContainer GetRootAsFB_PeiShiCompoundBaseContainer(ByteBuffer _bb, FB_PeiShiCompoundBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PeiShiCompoundBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PeiShiCompoundBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PeiShiCompoundBase GetItems(int j) { return GetItems(new FB_PeiShiCompoundBase(), j); }
  public FB_PeiShiCompoundBase GetItems(FB_PeiShiCompoundBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PeiShiCompoundBaseContainer> CreateFB_PeiShiCompoundBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PeiShiCompoundBaseContainer.AddItems(builder, items);
    return FB_PeiShiCompoundBaseContainer.EndFB_PeiShiCompoundBaseContainer(builder);
  }

  public static void StartFB_PeiShiCompoundBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PeiShiCompoundBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PeiShiCompoundBaseContainer> EndFB_PeiShiCompoundBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PeiShiCompoundBaseContainer>(o);
  }
  public static void FinishFB_PeiShiCompoundBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_PeiShiCompoundBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
