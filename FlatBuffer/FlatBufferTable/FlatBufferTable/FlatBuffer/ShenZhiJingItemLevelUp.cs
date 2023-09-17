// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenZhiJingItemLevelUp : Table {
  public static FB_ShenZhiJingItemLevelUp GetRootAsFB_ShenZhiJingItemLevelUp(ByteBuffer _bb) { return GetRootAsFB_ShenZhiJingItemLevelUp(_bb, new FB_ShenZhiJingItemLevelUp()); }
  public static FB_ShenZhiJingItemLevelUp GetRootAsFB_ShenZhiJingItemLevelUp(ByteBuffer _bb, FB_ShenZhiJingItemLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenZhiJingItemLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelUpType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAddPropertyIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AddPropertyIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAddPropertyValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AddPropertyValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int SkillID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillLevel { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockNextSkillLevel { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HuaShenLevelLimit { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockValue { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShenZhiJingItemLevelUp> CreateFB_ShenZhiJingItemLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int LevelUpType = -1,
      int Level = -1,
      int CostItemId = -1,
      int CostItemNum = -1,
      VectorOffset AddPropertyIDList = default(VectorOffset),
      VectorOffset AddPropertyValueList = default(VectorOffset),
      int SkillID = -1,
      int SkillLevel = -1,
      int UnlockNextSkillLevel = -1,
      int HuaShenLevelLimit = -1,
      int UnlockId = -1,
      int UnlockValue = -1) {
    builder.StartObject(13);
    FB_ShenZhiJingItemLevelUp.AddUnlockValue(builder, UnlockValue);
    FB_ShenZhiJingItemLevelUp.AddUnlockId(builder, UnlockId);
    FB_ShenZhiJingItemLevelUp.AddHuaShenLevelLimit(builder, HuaShenLevelLimit);
    FB_ShenZhiJingItemLevelUp.AddUnlockNextSkillLevel(builder, UnlockNextSkillLevel);
    FB_ShenZhiJingItemLevelUp.AddSkillLevel(builder, SkillLevel);
    FB_ShenZhiJingItemLevelUp.AddSkillID(builder, SkillID);
    FB_ShenZhiJingItemLevelUp.AddAddPropertyValueList(builder, AddPropertyValueList);
    FB_ShenZhiJingItemLevelUp.AddAddPropertyIDList(builder, AddPropertyIDList);
    FB_ShenZhiJingItemLevelUp.AddCostItemNum(builder, CostItemNum);
    FB_ShenZhiJingItemLevelUp.AddCostItemId(builder, CostItemId);
    FB_ShenZhiJingItemLevelUp.AddLevel(builder, Level);
    FB_ShenZhiJingItemLevelUp.AddLevelUpType(builder, LevelUpType);
    FB_ShenZhiJingItemLevelUp.AddID(builder, ID);
    return FB_ShenZhiJingItemLevelUp.EndFB_ShenZhiJingItemLevelUp(builder);
  }

  public static void StartFB_ShenZhiJingItemLevelUp(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevelUpType(FlatBufferBuilder builder, int LevelUpType) { builder.AddInt(1, LevelUpType, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(3, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(4, CostItemNum, -1); }
  public static void AddAddPropertyIDList(FlatBufferBuilder builder, VectorOffset AddPropertyIDListOffset) { builder.AddOffset(5, AddPropertyIDListOffset.Value, 0); }
  public static VectorOffset CreateAddPropertyIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAddPropertyIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAddPropertyValueList(FlatBufferBuilder builder, VectorOffset AddPropertyValueListOffset) { builder.AddOffset(6, AddPropertyValueListOffset.Value, 0); }
  public static VectorOffset CreateAddPropertyValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAddPropertyValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillID(FlatBufferBuilder builder, int SkillID) { builder.AddInt(7, SkillID, -1); }
  public static void AddSkillLevel(FlatBufferBuilder builder, int SkillLevel) { builder.AddInt(8, SkillLevel, -1); }
  public static void AddUnlockNextSkillLevel(FlatBufferBuilder builder, int UnlockNextSkillLevel) { builder.AddInt(9, UnlockNextSkillLevel, -1); }
  public static void AddHuaShenLevelLimit(FlatBufferBuilder builder, int HuaShenLevelLimit) { builder.AddInt(10, HuaShenLevelLimit, -1); }
  public static void AddUnlockId(FlatBufferBuilder builder, int UnlockId) { builder.AddInt(11, UnlockId, -1); }
  public static void AddUnlockValue(FlatBufferBuilder builder, int UnlockValue) { builder.AddInt(12, UnlockValue, -1); }
  public static Offset<FB_ShenZhiJingItemLevelUp> EndFB_ShenZhiJingItemLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenZhiJingItemLevelUp>(o);
  }
};

public sealed class FB_ShenZhiJingItemLevelUpContainer : Table {
  public static FB_ShenZhiJingItemLevelUpContainer GetRootAsFB_ShenZhiJingItemLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ShenZhiJingItemLevelUpContainer(_bb, new FB_ShenZhiJingItemLevelUpContainer()); }
  public static FB_ShenZhiJingItemLevelUpContainer GetRootAsFB_ShenZhiJingItemLevelUpContainer(ByteBuffer _bb, FB_ShenZhiJingItemLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenZhiJingItemLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenZhiJingItemLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenZhiJingItemLevelUp GetItems(int j) { return GetItems(new FB_ShenZhiJingItemLevelUp(), j); }
  public FB_ShenZhiJingItemLevelUp GetItems(FB_ShenZhiJingItemLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenZhiJingItemLevelUpContainer> CreateFB_ShenZhiJingItemLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenZhiJingItemLevelUpContainer.AddItems(builder, items);
    return FB_ShenZhiJingItemLevelUpContainer.EndFB_ShenZhiJingItemLevelUpContainer(builder);
  }

  public static void StartFB_ShenZhiJingItemLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenZhiJingItemLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenZhiJingItemLevelUpContainer> EndFB_ShenZhiJingItemLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenZhiJingItemLevelUpContainer>(o);
  }
  public static void FinishFB_ShenZhiJingItemLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenZhiJingItemLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
