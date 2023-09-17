// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BloodMix : Table {
  public static FB_BloodMix GetRootAsFB_BloodMix(ByteBuffer _bb) { return GetRootAsFB_BloodMix(_bb, new FB_BloodMix()); }
  public static FB_BloodMix GetRootAsFB_BloodMix(ByteBuffer _bb, FB_BloodMix obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BloodMix __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CostItemID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLevelUpConditionTypeList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelUpConditionTypeListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLevelUpConditionValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelUpConditionValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int BloodPossessedId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetImpactList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ImpactListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFakeobjIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FakeobjIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int NameIconId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BloodMix> CreateFB_BloodMix(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int CostItemID = -1,
      int CostItemCount = -1,
      VectorOffset PassiveSkillList = default(VectorOffset),
      VectorOffset LevelUpConditionTypeList = default(VectorOffset),
      VectorOffset LevelUpConditionValueList = default(VectorOffset),
      int BloodPossessedId = -1,
      VectorOffset ImpactList = default(VectorOffset),
      VectorOffset FakeobjIdList = default(VectorOffset),
      int NameIconId = -1) {
    builder.StartObject(11);
    FB_BloodMix.AddNameIconId(builder, NameIconId);
    FB_BloodMix.AddFakeobjIdList(builder, FakeobjIdList);
    FB_BloodMix.AddImpactList(builder, ImpactList);
    FB_BloodMix.AddBloodPossessedId(builder, BloodPossessedId);
    FB_BloodMix.AddLevelUpConditionValueList(builder, LevelUpConditionValueList);
    FB_BloodMix.AddLevelUpConditionTypeList(builder, LevelUpConditionTypeList);
    FB_BloodMix.AddPassiveSkillList(builder, PassiveSkillList);
    FB_BloodMix.AddCostItemCount(builder, CostItemCount);
    FB_BloodMix.AddCostItemID(builder, CostItemID);
    FB_BloodMix.AddName(builder, Name);
    FB_BloodMix.AddID(builder, ID);
    return FB_BloodMix.EndFB_BloodMix(builder);
  }

  public static void StartFB_BloodMix(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddCostItemID(FlatBufferBuilder builder, int CostItemID) { builder.AddInt(2, CostItemID, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(3, CostItemCount, -1); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(4, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelUpConditionTypeList(FlatBufferBuilder builder, VectorOffset LevelUpConditionTypeListOffset) { builder.AddOffset(5, LevelUpConditionTypeListOffset.Value, 0); }
  public static VectorOffset CreateLevelUpConditionTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelUpConditionTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelUpConditionValueList(FlatBufferBuilder builder, VectorOffset LevelUpConditionValueListOffset) { builder.AddOffset(6, LevelUpConditionValueListOffset.Value, 0); }
  public static VectorOffset CreateLevelUpConditionValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelUpConditionValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBloodPossessedId(FlatBufferBuilder builder, int BloodPossessedId) { builder.AddInt(7, BloodPossessedId, -1); }
  public static void AddImpactList(FlatBufferBuilder builder, VectorOffset ImpactListOffset) { builder.AddOffset(8, ImpactListOffset.Value, 0); }
  public static VectorOffset CreateImpactListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartImpactListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFakeobjIdList(FlatBufferBuilder builder, VectorOffset FakeobjIdListOffset) { builder.AddOffset(9, FakeobjIdListOffset.Value, 0); }
  public static VectorOffset CreateFakeobjIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFakeobjIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNameIconId(FlatBufferBuilder builder, int NameIconId) { builder.AddInt(10, NameIconId, -1); }
  public static Offset<FB_BloodMix> EndFB_BloodMix(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodMix>(o);
  }
};

public sealed class FB_BloodMixContainer : Table {
  public static FB_BloodMixContainer GetRootAsFB_BloodMixContainer(ByteBuffer _bb) { return GetRootAsFB_BloodMixContainer(_bb, new FB_BloodMixContainer()); }
  public static FB_BloodMixContainer GetRootAsFB_BloodMixContainer(ByteBuffer _bb, FB_BloodMixContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BloodMixContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BloodMixContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BloodMix GetItems(int j) { return GetItems(new FB_BloodMix(), j); }
  public FB_BloodMix GetItems(FB_BloodMix obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BloodMixContainer> CreateFB_BloodMixContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BloodMixContainer.AddItems(builder, items);
    return FB_BloodMixContainer.EndFB_BloodMixContainer(builder);
  }

  public static void StartFB_BloodMixContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BloodMix>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BloodMixContainer> EndFB_BloodMixContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodMixContainer>(o);
  }
  public static void FinishFB_BloodMixContainerBuffer(FlatBufferBuilder builder, Offset<FB_BloodMixContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
