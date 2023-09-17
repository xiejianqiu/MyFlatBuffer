// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetEquipStarLevelUp : Table {
  public static FB_WarPetEquipStarLevelUp GetRootAsFB_WarPetEquipStarLevelUp(ByteBuffer _bb) { return GetRootAsFB_WarPetEquipStarLevelUp(_bb, new FB_WarPetEquipStarLevelUp()); }
  public static FB_WarPetEquipStarLevelUp GetRootAsFB_WarPetEquipStarLevelUp(ByteBuffer _bb, FB_WarPetEquipStarLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetEquipStarLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetCostItemIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostItemNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetEquipStarLevelUp> CreateFB_WarPetEquipStarLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset CostItemIdList = default(VectorOffset),
      VectorOffset CostItemNumList = default(VectorOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_WarPetEquipStarLevelUp.AddAttrValList(builder, AttrValList);
    FB_WarPetEquipStarLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_WarPetEquipStarLevelUp.AddCostItemNumList(builder, CostItemNumList);
    FB_WarPetEquipStarLevelUp.AddCostItemIdList(builder, CostItemIdList);
    FB_WarPetEquipStarLevelUp.AddID(builder, ID);
    return FB_WarPetEquipStarLevelUp.EndFB_WarPetEquipStarLevelUp(builder);
  }

  public static void StartFB_WarPetEquipStarLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCostItemIdList(FlatBufferBuilder builder, VectorOffset CostItemIdListOffset) { builder.AddOffset(1, CostItemIdListOffset.Value, 0); }
  public static VectorOffset CreateCostItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostItemNumList(FlatBufferBuilder builder, VectorOffset CostItemNumListOffset) { builder.AddOffset(2, CostItemNumListOffset.Value, 0); }
  public static VectorOffset CreateCostItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValList(FlatBufferBuilder builder, VectorOffset AttrValListOffset) { builder.AddOffset(4, AttrValListOffset.Value, 0); }
  public static VectorOffset CreateAttrValListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetEquipStarLevelUp> EndFB_WarPetEquipStarLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetEquipStarLevelUp>(o);
  }
};

public sealed class FB_WarPetEquipStarLevelUpContainer : Table {
  public static FB_WarPetEquipStarLevelUpContainer GetRootAsFB_WarPetEquipStarLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetEquipStarLevelUpContainer(_bb, new FB_WarPetEquipStarLevelUpContainer()); }
  public static FB_WarPetEquipStarLevelUpContainer GetRootAsFB_WarPetEquipStarLevelUpContainer(ByteBuffer _bb, FB_WarPetEquipStarLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetEquipStarLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetEquipStarLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetEquipStarLevelUp GetItems(int j) { return GetItems(new FB_WarPetEquipStarLevelUp(), j); }
  public FB_WarPetEquipStarLevelUp GetItems(FB_WarPetEquipStarLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetEquipStarLevelUpContainer> CreateFB_WarPetEquipStarLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetEquipStarLevelUpContainer.AddItems(builder, items);
    return FB_WarPetEquipStarLevelUpContainer.EndFB_WarPetEquipStarLevelUpContainer(builder);
  }

  public static void StartFB_WarPetEquipStarLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetEquipStarLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetEquipStarLevelUpContainer> EndFB_WarPetEquipStarLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetEquipStarLevelUpContainer>(o);
  }
  public static void FinishFB_WarPetEquipStarLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetEquipStarLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
