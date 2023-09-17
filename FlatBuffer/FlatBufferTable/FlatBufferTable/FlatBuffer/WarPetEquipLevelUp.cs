// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetEquipLevelUp : Table {
  public static FB_WarPetEquipLevelUp GetRootAsFB_WarPetEquipLevelUp(ByteBuffer _bb) { return GetRootAsFB_WarPetEquipLevelUp(_bb, new FB_WarPetEquipLevelUp()); }
  public static FB_WarPetEquipLevelUp GetRootAsFB_WarPetEquipLevelUp(ByteBuffer _bb, FB_WarPetEquipLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetEquipLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostExp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddExp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelUpExp { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetEquipLevelUp> CreateFB_WarPetEquipLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int CostExp = -1,
      int AddExp = -1,
      int LevelUpExp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_WarPetEquipLevelUp.AddAttrValList(builder, AttrValList);
    FB_WarPetEquipLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_WarPetEquipLevelUp.AddLevelUpExp(builder, LevelUpExp);
    FB_WarPetEquipLevelUp.AddAddExp(builder, AddExp);
    FB_WarPetEquipLevelUp.AddCostExp(builder, CostExp);
    FB_WarPetEquipLevelUp.AddID(builder, ID);
    return FB_WarPetEquipLevelUp.EndFB_WarPetEquipLevelUp(builder);
  }

  public static void StartFB_WarPetEquipLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCostExp(FlatBufferBuilder builder, int CostExp) { builder.AddInt(1, CostExp, -1); }
  public static void AddAddExp(FlatBufferBuilder builder, int AddExp) { builder.AddInt(2, AddExp, -1); }
  public static void AddLevelUpExp(FlatBufferBuilder builder, int LevelUpExp) { builder.AddInt(3, LevelUpExp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValList(FlatBufferBuilder builder, VectorOffset AttrValListOffset) { builder.AddOffset(5, AttrValListOffset.Value, 0); }
  public static VectorOffset CreateAttrValListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetEquipLevelUp> EndFB_WarPetEquipLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetEquipLevelUp>(o);
  }
};

public sealed class FB_WarPetEquipLevelUpContainer : Table {
  public static FB_WarPetEquipLevelUpContainer GetRootAsFB_WarPetEquipLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetEquipLevelUpContainer(_bb, new FB_WarPetEquipLevelUpContainer()); }
  public static FB_WarPetEquipLevelUpContainer GetRootAsFB_WarPetEquipLevelUpContainer(ByteBuffer _bb, FB_WarPetEquipLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetEquipLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetEquipLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetEquipLevelUp GetItems(int j) { return GetItems(new FB_WarPetEquipLevelUp(), j); }
  public FB_WarPetEquipLevelUp GetItems(FB_WarPetEquipLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetEquipLevelUpContainer> CreateFB_WarPetEquipLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetEquipLevelUpContainer.AddItems(builder, items);
    return FB_WarPetEquipLevelUpContainer.EndFB_WarPetEquipLevelUpContainer(builder);
  }

  public static void StartFB_WarPetEquipLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetEquipLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetEquipLevelUpContainer> EndFB_WarPetEquipLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetEquipLevelUpContainer>(o);
  }
  public static void FinishFB_WarPetEquipLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetEquipLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
