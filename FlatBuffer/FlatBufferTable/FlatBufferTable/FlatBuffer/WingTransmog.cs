// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WingTransmog : Table {
  public static FB_WingTransmog GetRootAsFB_WingTransmog(ByteBuffer _bb) { return GetRootAsFB_WingTransmog(_bb, new FB_WingTransmog()); }
  public static FB_WingTransmog GetRootAsFB_WingTransmog(ByteBuffer _bb, FB_WingTransmog obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WingTransmog __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsShowAfterGetting { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int DescribeID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int KPJDesStrID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockWingDesStrID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DictionaryID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharWingID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EffectID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWingModelIDList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WingModelIDListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public string IconPath { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnLockItemId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockItemNum { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenuFakeObjID { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WingLevel { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string WingStep { get { int o = __offset(38); return o != 0 ? __string(o + bb_pos) : null; } }
  public int AvatarExp { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string FakeObjEffect { get { int o = __offset(42); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool HasExtraModel { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ExtraModelId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExtraWingEffectId { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpireDays { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenServerDay { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowOnUI { get { int o = __offset(54); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_WingTransmog> CreateFB_WingTransmog(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      bool IsShowAfterGetting = false,
      int DescribeID = -1,
      int KPJDesStrID = -1,
      int UnlockWingDesStrID = -1,
      int DictionaryID = -1,
      int UnlockType = 0,
      int UnlockID = -1,
      int CharWingID = -1,
      int EffectID = -1,
      VectorOffset WingModelIDList = default(VectorOffset),
      StringOffset IconPath = default(StringOffset),
      int UnLockItemId = 0,
      int UnLockItemNum = 0,
      int MenuFakeObjID = -1,
      int WingLevel = -1,
      StringOffset WingStep = default(StringOffset),
      int AvatarExp = -1,
      StringOffset FakeObjEffect = default(StringOffset),
      bool HasExtraModel = false,
      int ExtraModelId = -1,
      int ExtraWingEffectId = -1,
      int ExpireDays = -1,
      int OpenServerDay = -1,
      bool IsShowOnUI = false) {
    builder.StartObject(26);
    FB_WingTransmog.AddOpenServerDay(builder, OpenServerDay);
    FB_WingTransmog.AddExpireDays(builder, ExpireDays);
    FB_WingTransmog.AddExtraWingEffectId(builder, ExtraWingEffectId);
    FB_WingTransmog.AddExtraModelId(builder, ExtraModelId);
    FB_WingTransmog.AddFakeObjEffect(builder, FakeObjEffect);
    FB_WingTransmog.AddAvatarExp(builder, AvatarExp);
    FB_WingTransmog.AddWingStep(builder, WingStep);
    FB_WingTransmog.AddWingLevel(builder, WingLevel);
    FB_WingTransmog.AddMenuFakeObjID(builder, MenuFakeObjID);
    FB_WingTransmog.AddUnLockItemNum(builder, UnLockItemNum);
    FB_WingTransmog.AddUnLockItemId(builder, UnLockItemId);
    FB_WingTransmog.AddIconPath(builder, IconPath);
    FB_WingTransmog.AddWingModelIDList(builder, WingModelIDList);
    FB_WingTransmog.AddEffectID(builder, EffectID);
    FB_WingTransmog.AddCharWingID(builder, CharWingID);
    FB_WingTransmog.AddUnlockID(builder, UnlockID);
    FB_WingTransmog.AddUnlockType(builder, UnlockType);
    FB_WingTransmog.AddDictionaryID(builder, DictionaryID);
    FB_WingTransmog.AddUnlockWingDesStrID(builder, UnlockWingDesStrID);
    FB_WingTransmog.AddKPJDesStrID(builder, KPJDesStrID);
    FB_WingTransmog.AddDescribeID(builder, DescribeID);
    FB_WingTransmog.AddName(builder, Name);
    FB_WingTransmog.AddID(builder, ID);
    FB_WingTransmog.AddIsShowOnUI(builder, IsShowOnUI);
    FB_WingTransmog.AddHasExtraModel(builder, HasExtraModel);
    FB_WingTransmog.AddIsShowAfterGetting(builder, IsShowAfterGetting);
    return FB_WingTransmog.EndFB_WingTransmog(builder);
  }

  public static void StartFB_WingTransmog(FlatBufferBuilder builder) { builder.StartObject(26); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIsShowAfterGetting(FlatBufferBuilder builder, bool IsShowAfterGetting) { builder.AddBool(2, IsShowAfterGetting, false); }
  public static void AddDescribeID(FlatBufferBuilder builder, int DescribeID) { builder.AddInt(3, DescribeID, -1); }
  public static void AddKPJDesStrID(FlatBufferBuilder builder, int KPJDesStrID) { builder.AddInt(4, KPJDesStrID, -1); }
  public static void AddUnlockWingDesStrID(FlatBufferBuilder builder, int UnlockWingDesStrID) { builder.AddInt(5, UnlockWingDesStrID, -1); }
  public static void AddDictionaryID(FlatBufferBuilder builder, int DictionaryID) { builder.AddInt(6, DictionaryID, -1); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(7, UnlockType, 0); }
  public static void AddUnlockID(FlatBufferBuilder builder, int UnlockID) { builder.AddInt(8, UnlockID, -1); }
  public static void AddCharWingID(FlatBufferBuilder builder, int CharWingID) { builder.AddInt(9, CharWingID, -1); }
  public static void AddEffectID(FlatBufferBuilder builder, int EffectID) { builder.AddInt(10, EffectID, -1); }
  public static void AddWingModelIDList(FlatBufferBuilder builder, VectorOffset WingModelIDListOffset) { builder.AddOffset(11, WingModelIDListOffset.Value, 0); }
  public static VectorOffset CreateWingModelIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWingModelIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(12, IconPathOffset.Value, 0); }
  public static void AddUnLockItemId(FlatBufferBuilder builder, int UnLockItemId) { builder.AddInt(13, UnLockItemId, 0); }
  public static void AddUnLockItemNum(FlatBufferBuilder builder, int UnLockItemNum) { builder.AddInt(14, UnLockItemNum, 0); }
  public static void AddMenuFakeObjID(FlatBufferBuilder builder, int MenuFakeObjID) { builder.AddInt(15, MenuFakeObjID, -1); }
  public static void AddWingLevel(FlatBufferBuilder builder, int WingLevel) { builder.AddInt(16, WingLevel, -1); }
  public static void AddWingStep(FlatBufferBuilder builder, StringOffset WingStepOffset) { builder.AddOffset(17, WingStepOffset.Value, 0); }
  public static void AddAvatarExp(FlatBufferBuilder builder, int AvatarExp) { builder.AddInt(18, AvatarExp, -1); }
  public static void AddFakeObjEffect(FlatBufferBuilder builder, StringOffset FakeObjEffectOffset) { builder.AddOffset(19, FakeObjEffectOffset.Value, 0); }
  public static void AddHasExtraModel(FlatBufferBuilder builder, bool HasExtraModel) { builder.AddBool(20, HasExtraModel, false); }
  public static void AddExtraModelId(FlatBufferBuilder builder, int ExtraModelId) { builder.AddInt(21, ExtraModelId, -1); }
  public static void AddExtraWingEffectId(FlatBufferBuilder builder, int ExtraWingEffectId) { builder.AddInt(22, ExtraWingEffectId, -1); }
  public static void AddExpireDays(FlatBufferBuilder builder, int ExpireDays) { builder.AddInt(23, ExpireDays, -1); }
  public static void AddOpenServerDay(FlatBufferBuilder builder, int OpenServerDay) { builder.AddInt(24, OpenServerDay, -1); }
  public static void AddIsShowOnUI(FlatBufferBuilder builder, bool IsShowOnUI) { builder.AddBool(25, IsShowOnUI, false); }
  public static Offset<FB_WingTransmog> EndFB_WingTransmog(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WingTransmog>(o);
  }
};

public sealed class FB_WingTransmogContainer : Table {
  public static FB_WingTransmogContainer GetRootAsFB_WingTransmogContainer(ByteBuffer _bb) { return GetRootAsFB_WingTransmogContainer(_bb, new FB_WingTransmogContainer()); }
  public static FB_WingTransmogContainer GetRootAsFB_WingTransmogContainer(ByteBuffer _bb, FB_WingTransmogContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WingTransmogContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WingTransmogContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WingTransmog GetItems(int j) { return GetItems(new FB_WingTransmog(), j); }
  public FB_WingTransmog GetItems(FB_WingTransmog obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WingTransmogContainer> CreateFB_WingTransmogContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WingTransmogContainer.AddItems(builder, items);
    return FB_WingTransmogContainer.EndFB_WingTransmogContainer(builder);
  }

  public static void StartFB_WingTransmogContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WingTransmog>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WingTransmogContainer> EndFB_WingTransmogContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WingTransmogContainer>(o);
  }
  public static void FinishFB_WingTransmogContainerBuffer(FlatBufferBuilder builder, Offset<FB_WingTransmogContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
