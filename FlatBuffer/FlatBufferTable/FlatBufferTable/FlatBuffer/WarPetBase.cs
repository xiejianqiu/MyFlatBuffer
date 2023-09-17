// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetBase : Table {
  public static FB_WarPetBase GetRootAsFB_WarPetBase(ByteBuffer _bb) { return GetRootAsFB_WarPetBase(_bb, new FB_WarPetBase()); }
  public static FB_WarPetBase GetRootAsFB_WarPetBase(ByteBuffer _bb, FB_WarPetBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string NameIcon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ItemIcon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankFakeObjID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharSoulId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Generation { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InheritMoney { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReleaseExp { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassiveSkilId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FixedTalent { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRandomTalentList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RandomTalentListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public int GetQualificationsList(int j) { int o = __offset(38); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int QualificationsListLength { get { int o = __offset(38); return o != 0 ? __vector_len(o) : 0; } }
  public int MaxQualifications { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathBaseId { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EvolutionMap { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPathStrId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WarPetBase> CreateFB_WarPetBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset NameIcon = default(StringOffset),
      StringOffset ItemIcon = default(StringOffset),
      int FakeObjId = -1,
      int RankFakeObjID = -1,
      int CharSoulId = -1,
      int Quality = -1,
      int Generation = -1,
      int ItemId = -1,
      int ItemNum = -1,
      int MaxLevel = -1,
      int InheritMoney = -1,
      int ReleaseExp = -1,
      int PassiveSkilId = -1,
      int FixedTalent = -1,
      VectorOffset RandomTalentList = default(VectorOffset),
      VectorOffset QualificationsList = default(VectorOffset),
      int MaxQualifications = -1,
      int GetPathBaseId = -1,
      int EvolutionMap = -1,
      int GetPathStrId = -1) {
    builder.StartObject(22);
    FB_WarPetBase.AddGetPathStrId(builder, GetPathStrId);
    FB_WarPetBase.AddEvolutionMap(builder, EvolutionMap);
    FB_WarPetBase.AddGetPathBaseId(builder, GetPathBaseId);
    FB_WarPetBase.AddMaxQualifications(builder, MaxQualifications);
    FB_WarPetBase.AddQualificationsList(builder, QualificationsList);
    FB_WarPetBase.AddRandomTalentList(builder, RandomTalentList);
    FB_WarPetBase.AddFixedTalent(builder, FixedTalent);
    FB_WarPetBase.AddPassiveSkilId(builder, PassiveSkilId);
    FB_WarPetBase.AddReleaseExp(builder, ReleaseExp);
    FB_WarPetBase.AddInheritMoney(builder, InheritMoney);
    FB_WarPetBase.AddMaxLevel(builder, MaxLevel);
    FB_WarPetBase.AddItemNum(builder, ItemNum);
    FB_WarPetBase.AddItemId(builder, ItemId);
    FB_WarPetBase.AddGeneration(builder, Generation);
    FB_WarPetBase.AddQuality(builder, Quality);
    FB_WarPetBase.AddCharSoulId(builder, CharSoulId);
    FB_WarPetBase.AddRankFakeObjID(builder, RankFakeObjID);
    FB_WarPetBase.AddFakeObjId(builder, FakeObjId);
    FB_WarPetBase.AddItemIcon(builder, ItemIcon);
    FB_WarPetBase.AddNameIcon(builder, NameIcon);
    FB_WarPetBase.AddName(builder, Name);
    FB_WarPetBase.AddID(builder, ID);
    return FB_WarPetBase.EndFB_WarPetBase(builder);
  }

  public static void StartFB_WarPetBase(FlatBufferBuilder builder) { builder.StartObject(22); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNameIcon(FlatBufferBuilder builder, StringOffset NameIconOffset) { builder.AddOffset(2, NameIconOffset.Value, 0); }
  public static void AddItemIcon(FlatBufferBuilder builder, StringOffset ItemIconOffset) { builder.AddOffset(3, ItemIconOffset.Value, 0); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(4, FakeObjId, -1); }
  public static void AddRankFakeObjID(FlatBufferBuilder builder, int RankFakeObjID) { builder.AddInt(5, RankFakeObjID, -1); }
  public static void AddCharSoulId(FlatBufferBuilder builder, int CharSoulId) { builder.AddInt(6, CharSoulId, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(7, Quality, -1); }
  public static void AddGeneration(FlatBufferBuilder builder, int Generation) { builder.AddInt(8, Generation, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(9, ItemId, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(10, ItemNum, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(11, MaxLevel, -1); }
  public static void AddInheritMoney(FlatBufferBuilder builder, int InheritMoney) { builder.AddInt(12, InheritMoney, -1); }
  public static void AddReleaseExp(FlatBufferBuilder builder, int ReleaseExp) { builder.AddInt(13, ReleaseExp, -1); }
  public static void AddPassiveSkilId(FlatBufferBuilder builder, int PassiveSkilId) { builder.AddInt(14, PassiveSkilId, -1); }
  public static void AddFixedTalent(FlatBufferBuilder builder, int FixedTalent) { builder.AddInt(15, FixedTalent, -1); }
  public static void AddRandomTalentList(FlatBufferBuilder builder, VectorOffset RandomTalentListOffset) { builder.AddOffset(16, RandomTalentListOffset.Value, 0); }
  public static VectorOffset CreateRandomTalentListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRandomTalentListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddQualificationsList(FlatBufferBuilder builder, VectorOffset QualificationsListOffset) { builder.AddOffset(17, QualificationsListOffset.Value, 0); }
  public static VectorOffset CreateQualificationsListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartQualificationsListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxQualifications(FlatBufferBuilder builder, int MaxQualifications) { builder.AddInt(18, MaxQualifications, -1); }
  public static void AddGetPathBaseId(FlatBufferBuilder builder, int GetPathBaseId) { builder.AddInt(19, GetPathBaseId, -1); }
  public static void AddEvolutionMap(FlatBufferBuilder builder, int EvolutionMap) { builder.AddInt(20, EvolutionMap, -1); }
  public static void AddGetPathStrId(FlatBufferBuilder builder, int GetPathStrId) { builder.AddInt(21, GetPathStrId, -1); }
  public static Offset<FB_WarPetBase> EndFB_WarPetBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetBase>(o);
  }
};

public sealed class FB_WarPetBaseContainer : Table {
  public static FB_WarPetBaseContainer GetRootAsFB_WarPetBaseContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetBaseContainer(_bb, new FB_WarPetBaseContainer()); }
  public static FB_WarPetBaseContainer GetRootAsFB_WarPetBaseContainer(ByteBuffer _bb, FB_WarPetBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetBase GetItems(int j) { return GetItems(new FB_WarPetBase(), j); }
  public FB_WarPetBase GetItems(FB_WarPetBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetBaseContainer> CreateFB_WarPetBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetBaseContainer.AddItems(builder, items);
    return FB_WarPetBaseContainer.EndFB_WarPetBaseContainer(builder);
  }

  public static void StartFB_WarPetBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetBaseContainer> EndFB_WarPetBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetBaseContainer>(o);
  }
  public static void FinishFB_WarPetBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
