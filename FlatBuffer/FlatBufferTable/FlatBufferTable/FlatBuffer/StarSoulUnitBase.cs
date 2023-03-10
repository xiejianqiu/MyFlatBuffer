// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarSoulUnitBase : Table {
  public static FB_StarSoulUnitBase GetRootAsFB_StarSoulUnitBase(ByteBuffer _bb) { return GetRootAsFB_StarSoulUnitBase(_bb, new FB_StarSoulUnitBase()); }
  public static FB_StarSoulUnitBase GetRootAsFB_StarSoulUnitBase(ByteBuffer _bb, FB_StarSoulUnitBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarSoulUnitBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string NameIcon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RaceIcon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ItemIcon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuncOpenFakeObjId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharSoulId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockAttr { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockModel { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockParamList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockParamListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int Quality { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSkillList(int j) { int o = __offset(32); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkillListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }
  public int GetExtSkillList(int j) { int o = __offset(34); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ExtSkillListLength { get { int o = __offset(34); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIdList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public int DescStrId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockDescStrId { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanDecompose { get { int o = __offset(42); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int RankFakeObjID { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Race { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShopItemId { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JuHunItemId { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JuHunItemCount { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBoxItemId { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemNum { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JuHunJiXu { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathStrId { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathId { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StarSoulUnitBase> CreateFB_StarSoulUnitBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset NameIcon = default(StringOffset),
      StringOffset RaceIcon = default(StringOffset),
      StringOffset ItemIcon = default(StringOffset),
      int FakeObjId = -1,
      int FuncOpenFakeObjId = -1,
      int CharSoulId = -1,
      int UnLockAttr = -1,
      int UnLockModel = -1,
      int MaxLevel = -1,
      int UnLockType = -1,
      VectorOffset UnLockParamList = default(VectorOffset),
      int Quality = -1,
      VectorOffset SkillList = default(VectorOffset),
      VectorOffset ExtSkillList = default(VectorOffset),
      VectorOffset ItemIdList = default(VectorOffset),
      int DescStrId = -1,
      int unlockDescStrId = -1,
      bool CanDecompose = false,
      int RankFakeObjID = -1,
      int Race = -1,
      int ShopItemId = -1,
      int JuHunItemId = -1,
      int JuHunItemCount = -1,
      int DropBoxItemId = -1,
      int GetItemNum = -1,
      int JuHunJiXu = -1,
      int GetPathStrId = -1,
      int GetPathId = -1) {
    builder.StartObject(30);
    FB_StarSoulUnitBase.AddGetPathId(builder, GetPathId);
    FB_StarSoulUnitBase.AddGetPathStrId(builder, GetPathStrId);
    FB_StarSoulUnitBase.AddJuHunJiXu(builder, JuHunJiXu);
    FB_StarSoulUnitBase.AddGetItemNum(builder, GetItemNum);
    FB_StarSoulUnitBase.AddDropBoxItemId(builder, DropBoxItemId);
    FB_StarSoulUnitBase.AddJuHunItemCount(builder, JuHunItemCount);
    FB_StarSoulUnitBase.AddJuHunItemId(builder, JuHunItemId);
    FB_StarSoulUnitBase.AddShopItemId(builder, ShopItemId);
    FB_StarSoulUnitBase.AddRace(builder, Race);
    FB_StarSoulUnitBase.AddRankFakeObjID(builder, RankFakeObjID);
    FB_StarSoulUnitBase.AddUnlockDescStrId(builder, unlockDescStrId);
    FB_StarSoulUnitBase.AddDescStrId(builder, DescStrId);
    FB_StarSoulUnitBase.AddItemIdList(builder, ItemIdList);
    FB_StarSoulUnitBase.AddExtSkillList(builder, ExtSkillList);
    FB_StarSoulUnitBase.AddSkillList(builder, SkillList);
    FB_StarSoulUnitBase.AddQuality(builder, Quality);
    FB_StarSoulUnitBase.AddUnLockParamList(builder, UnLockParamList);
    FB_StarSoulUnitBase.AddUnLockType(builder, UnLockType);
    FB_StarSoulUnitBase.AddMaxLevel(builder, MaxLevel);
    FB_StarSoulUnitBase.AddUnLockModel(builder, UnLockModel);
    FB_StarSoulUnitBase.AddUnLockAttr(builder, UnLockAttr);
    FB_StarSoulUnitBase.AddCharSoulId(builder, CharSoulId);
    FB_StarSoulUnitBase.AddFuncOpenFakeObjId(builder, FuncOpenFakeObjId);
    FB_StarSoulUnitBase.AddFakeObjId(builder, FakeObjId);
    FB_StarSoulUnitBase.AddItemIcon(builder, ItemIcon);
    FB_StarSoulUnitBase.AddRaceIcon(builder, RaceIcon);
    FB_StarSoulUnitBase.AddNameIcon(builder, NameIcon);
    FB_StarSoulUnitBase.AddName(builder, Name);
    FB_StarSoulUnitBase.AddID(builder, ID);
    FB_StarSoulUnitBase.AddCanDecompose(builder, CanDecompose);
    return FB_StarSoulUnitBase.EndFB_StarSoulUnitBase(builder);
  }

  public static void StartFB_StarSoulUnitBase(FlatBufferBuilder builder) { builder.StartObject(30); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNameIcon(FlatBufferBuilder builder, StringOffset NameIconOffset) { builder.AddOffset(2, NameIconOffset.Value, 0); }
  public static void AddRaceIcon(FlatBufferBuilder builder, StringOffset RaceIconOffset) { builder.AddOffset(3, RaceIconOffset.Value, 0); }
  public static void AddItemIcon(FlatBufferBuilder builder, StringOffset ItemIconOffset) { builder.AddOffset(4, ItemIconOffset.Value, 0); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(5, FakeObjId, -1); }
  public static void AddFuncOpenFakeObjId(FlatBufferBuilder builder, int FuncOpenFakeObjId) { builder.AddInt(6, FuncOpenFakeObjId, -1); }
  public static void AddCharSoulId(FlatBufferBuilder builder, int CharSoulId) { builder.AddInt(7, CharSoulId, -1); }
  public static void AddUnLockAttr(FlatBufferBuilder builder, int UnLockAttr) { builder.AddInt(8, UnLockAttr, -1); }
  public static void AddUnLockModel(FlatBufferBuilder builder, int UnLockModel) { builder.AddInt(9, UnLockModel, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(10, MaxLevel, -1); }
  public static void AddUnLockType(FlatBufferBuilder builder, int UnLockType) { builder.AddInt(11, UnLockType, -1); }
  public static void AddUnLockParamList(FlatBufferBuilder builder, VectorOffset UnLockParamListOffset) { builder.AddOffset(12, UnLockParamListOffset.Value, 0); }
  public static VectorOffset CreateUnLockParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(13, Quality, -1); }
  public static void AddSkillList(FlatBufferBuilder builder, VectorOffset SkillListOffset) { builder.AddOffset(14, SkillListOffset.Value, 0); }
  public static VectorOffset CreateSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtSkillList(FlatBufferBuilder builder, VectorOffset ExtSkillListOffset) { builder.AddOffset(15, ExtSkillListOffset.Value, 0); }
  public static VectorOffset CreateExtSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartExtSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(16, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDescStrId(FlatBufferBuilder builder, int DescStrId) { builder.AddInt(17, DescStrId, -1); }
  public static void AddUnlockDescStrId(FlatBufferBuilder builder, int unlockDescStrId) { builder.AddInt(18, unlockDescStrId, -1); }
  public static void AddCanDecompose(FlatBufferBuilder builder, bool CanDecompose) { builder.AddBool(19, CanDecompose, false); }
  public static void AddRankFakeObjID(FlatBufferBuilder builder, int RankFakeObjID) { builder.AddInt(20, RankFakeObjID, -1); }
  public static void AddRace(FlatBufferBuilder builder, int Race) { builder.AddInt(21, Race, -1); }
  public static void AddShopItemId(FlatBufferBuilder builder, int ShopItemId) { builder.AddInt(22, ShopItemId, -1); }
  public static void AddJuHunItemId(FlatBufferBuilder builder, int JuHunItemId) { builder.AddInt(23, JuHunItemId, -1); }
  public static void AddJuHunItemCount(FlatBufferBuilder builder, int JuHunItemCount) { builder.AddInt(24, JuHunItemCount, -1); }
  public static void AddDropBoxItemId(FlatBufferBuilder builder, int DropBoxItemId) { builder.AddInt(25, DropBoxItemId, -1); }
  public static void AddGetItemNum(FlatBufferBuilder builder, int GetItemNum) { builder.AddInt(26, GetItemNum, -1); }
  public static void AddJuHunJiXu(FlatBufferBuilder builder, int JuHunJiXu) { builder.AddInt(27, JuHunJiXu, -1); }
  public static void AddGetPathStrId(FlatBufferBuilder builder, int GetPathStrId) { builder.AddInt(28, GetPathStrId, -1); }
  public static void AddGetPathId(FlatBufferBuilder builder, int GetPathId) { builder.AddInt(29, GetPathId, -1); }
  public static Offset<FB_StarSoulUnitBase> EndFB_StarSoulUnitBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulUnitBase>(o);
  }
};

public sealed class FB_StarSoulUnitBaseContainer : Table {
  public static FB_StarSoulUnitBaseContainer GetRootAsFB_StarSoulUnitBaseContainer(ByteBuffer _bb) { return GetRootAsFB_StarSoulUnitBaseContainer(_bb, new FB_StarSoulUnitBaseContainer()); }
  public static FB_StarSoulUnitBaseContainer GetRootAsFB_StarSoulUnitBaseContainer(ByteBuffer _bb, FB_StarSoulUnitBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarSoulUnitBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarSoulUnitBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarSoulUnitBase GetItems(int j) { return GetItems(new FB_StarSoulUnitBase(), j); }
  public FB_StarSoulUnitBase GetItems(FB_StarSoulUnitBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarSoulUnitBaseContainer> CreateFB_StarSoulUnitBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarSoulUnitBaseContainer.AddItems(builder, items);
    return FB_StarSoulUnitBaseContainer.EndFB_StarSoulUnitBaseContainer(builder);
  }

  public static void StartFB_StarSoulUnitBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarSoulUnitBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarSoulUnitBaseContainer> EndFB_StarSoulUnitBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulUnitBaseContainer>(o);
  }
  public static void FinishFB_StarSoulUnitBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarSoulUnitBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
