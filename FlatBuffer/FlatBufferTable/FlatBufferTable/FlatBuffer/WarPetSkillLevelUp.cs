// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetSkillLevelUp : Table {
  public static FB_WarPetSkillLevelUp GetRootAsFB_WarPetSkillLevelUp(ByteBuffer _bb) { return GetRootAsFB_WarPetSkillLevelUp(_bb, new FB_WarPetSkillLevelUp()); }
  public static FB_WarPetSkillLevelUp GetRootAsFB_WarPetSkillLevelUp(ByteBuffer _bb, FB_WarPetSkillLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetSkillLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetDescParamList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DescParamListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetSkillLevelUp> CreateFB_WarPetSkillLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int SkillLevel = -1,
      int CostItemId = -1,
      int CostItemNum = -1,
      VectorOffset DescParamList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_WarPetSkillLevelUp.AddDescParamList(builder, DescParamList);
    FB_WarPetSkillLevelUp.AddCostItemNum(builder, CostItemNum);
    FB_WarPetSkillLevelUp.AddCostItemId(builder, CostItemId);
    FB_WarPetSkillLevelUp.AddSkillLevel(builder, SkillLevel);
    FB_WarPetSkillLevelUp.AddID(builder, ID);
    return FB_WarPetSkillLevelUp.EndFB_WarPetSkillLevelUp(builder);
  }

  public static void StartFB_WarPetSkillLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddSkillLevel(FlatBufferBuilder builder, int SkillLevel) { builder.AddInt(1, SkillLevel, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(2, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(3, CostItemNum, -1); }
  public static void AddDescParamList(FlatBufferBuilder builder, VectorOffset DescParamListOffset) { builder.AddOffset(4, DescParamListOffset.Value, 0); }
  public static VectorOffset CreateDescParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDescParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetSkillLevelUp> EndFB_WarPetSkillLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetSkillLevelUp>(o);
  }
};

public sealed class FB_WarPetSkillLevelUpContainer : Table {
  public static FB_WarPetSkillLevelUpContainer GetRootAsFB_WarPetSkillLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetSkillLevelUpContainer(_bb, new FB_WarPetSkillLevelUpContainer()); }
  public static FB_WarPetSkillLevelUpContainer GetRootAsFB_WarPetSkillLevelUpContainer(ByteBuffer _bb, FB_WarPetSkillLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetSkillLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetSkillLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetSkillLevelUp GetItems(int j) { return GetItems(new FB_WarPetSkillLevelUp(), j); }
  public FB_WarPetSkillLevelUp GetItems(FB_WarPetSkillLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetSkillLevelUpContainer> CreateFB_WarPetSkillLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetSkillLevelUpContainer.AddItems(builder, items);
    return FB_WarPetSkillLevelUpContainer.EndFB_WarPetSkillLevelUpContainer(builder);
  }

  public static void StartFB_WarPetSkillLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetSkillLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetSkillLevelUpContainer> EndFB_WarPetSkillLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetSkillLevelUpContainer>(o);
  }
  public static void FinishFB_WarPetSkillLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetSkillLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
