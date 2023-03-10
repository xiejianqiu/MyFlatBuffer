// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PlayerSkinBase : Table {
  public static FB_PlayerSkinBase GetRootAsFB_PlayerSkinBase(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinBase(_bb, new FB_PlayerSkinBase()); }
  public static FB_PlayerSkinBase GetRootAsFB_PlayerSkinBase(ByteBuffer _bb, FB_PlayerSkinBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PlayerSkinBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Sort { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OccupationLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SexLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EquipType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ModelID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPartColorIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PartColorIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int PartsNumber { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitValue { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockItemId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool EquipOnGet { get { int o = __offset(28); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int AvatarExp { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpireDays { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PlayerSkinBase> CreateFB_PlayerSkinBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Sort = -1,
      int OccupationLimit = -1,
      int SexLimit = -1,
      int EquipType = -1,
      int ModelID = -1,
      VectorOffset PartColorIDList = default(VectorOffset),
      int PartsNumber = -1,
      int LimitType = 0,
      int LimitValue = 0,
      int UnLockItemId = 0,
      bool EquipOnGet = false,
      int AvatarExp = -1,
      int ExpireDays = -1) {
    builder.StartObject(15);
    FB_PlayerSkinBase.AddExpireDays(builder, ExpireDays);
    FB_PlayerSkinBase.AddAvatarExp(builder, AvatarExp);
    FB_PlayerSkinBase.AddUnLockItemId(builder, UnLockItemId);
    FB_PlayerSkinBase.AddLimitValue(builder, LimitValue);
    FB_PlayerSkinBase.AddLimitType(builder, LimitType);
    FB_PlayerSkinBase.AddPartsNumber(builder, PartsNumber);
    FB_PlayerSkinBase.AddPartColorIDList(builder, PartColorIDList);
    FB_PlayerSkinBase.AddModelID(builder, ModelID);
    FB_PlayerSkinBase.AddEquipType(builder, EquipType);
    FB_PlayerSkinBase.AddSexLimit(builder, SexLimit);
    FB_PlayerSkinBase.AddOccupationLimit(builder, OccupationLimit);
    FB_PlayerSkinBase.AddSort(builder, Sort);
    FB_PlayerSkinBase.AddName(builder, Name);
    FB_PlayerSkinBase.AddID(builder, ID);
    FB_PlayerSkinBase.AddEquipOnGet(builder, EquipOnGet);
    return FB_PlayerSkinBase.EndFB_PlayerSkinBase(builder);
  }

  public static void StartFB_PlayerSkinBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddSort(FlatBufferBuilder builder, int Sort) { builder.AddInt(2, Sort, -1); }
  public static void AddOccupationLimit(FlatBufferBuilder builder, int OccupationLimit) { builder.AddInt(3, OccupationLimit, -1); }
  public static void AddSexLimit(FlatBufferBuilder builder, int SexLimit) { builder.AddInt(4, SexLimit, -1); }
  public static void AddEquipType(FlatBufferBuilder builder, int EquipType) { builder.AddInt(5, EquipType, -1); }
  public static void AddModelID(FlatBufferBuilder builder, int ModelID) { builder.AddInt(6, ModelID, -1); }
  public static void AddPartColorIDList(FlatBufferBuilder builder, VectorOffset PartColorIDListOffset) { builder.AddOffset(7, PartColorIDListOffset.Value, 0); }
  public static VectorOffset CreatePartColorIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPartColorIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPartsNumber(FlatBufferBuilder builder, int PartsNumber) { builder.AddInt(8, PartsNumber, -1); }
  public static void AddLimitType(FlatBufferBuilder builder, int LimitType) { builder.AddInt(9, LimitType, 0); }
  public static void AddLimitValue(FlatBufferBuilder builder, int LimitValue) { builder.AddInt(10, LimitValue, 0); }
  public static void AddUnLockItemId(FlatBufferBuilder builder, int UnLockItemId) { builder.AddInt(11, UnLockItemId, 0); }
  public static void AddEquipOnGet(FlatBufferBuilder builder, bool EquipOnGet) { builder.AddBool(12, EquipOnGet, false); }
  public static void AddAvatarExp(FlatBufferBuilder builder, int AvatarExp) { builder.AddInt(13, AvatarExp, -1); }
  public static void AddExpireDays(FlatBufferBuilder builder, int ExpireDays) { builder.AddInt(14, ExpireDays, -1); }
  public static Offset<FB_PlayerSkinBase> EndFB_PlayerSkinBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinBase>(o);
  }
};

public sealed class FB_PlayerSkinBaseContainer : Table {
  public static FB_PlayerSkinBaseContainer GetRootAsFB_PlayerSkinBaseContainer(ByteBuffer _bb) { return GetRootAsFB_PlayerSkinBaseContainer(_bb, new FB_PlayerSkinBaseContainer()); }
  public static FB_PlayerSkinBaseContainer GetRootAsFB_PlayerSkinBaseContainer(ByteBuffer _bb, FB_PlayerSkinBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PlayerSkinBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PlayerSkinBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PlayerSkinBase GetItems(int j) { return GetItems(new FB_PlayerSkinBase(), j); }
  public FB_PlayerSkinBase GetItems(FB_PlayerSkinBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerSkinBaseContainer> CreateFB_PlayerSkinBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PlayerSkinBaseContainer.AddItems(builder, items);
    return FB_PlayerSkinBaseContainer.EndFB_PlayerSkinBaseContainer(builder);
  }

  public static void StartFB_PlayerSkinBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PlayerSkinBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerSkinBaseContainer> EndFB_PlayerSkinBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerSkinBaseContainer>(o);
  }
  public static void FinishFB_PlayerSkinBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_PlayerSkinBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
