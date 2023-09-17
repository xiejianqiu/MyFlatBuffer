// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetArrayTechniqueLevelUp : Table {
  public static FB_WarPetArrayTechniqueLevelUp GetRootAsFB_WarPetArrayTechniqueLevelUp(ByteBuffer _bb) { return GetRootAsFB_WarPetArrayTechniqueLevelUp(_bb, new FB_WarPetArrayTechniqueLevelUp()); }
  public static FB_WarPetArrayTechniqueLevelUp GetRootAsFB_WarPetArrayTechniqueLevelUp(ByteBuffer _bb, FB_WarPetArrayTechniqueLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetArrayTechniqueLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PetExp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int UnLockItem { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockItemNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockItemIndex { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WarPetArrayTechniqueLevelUp> CreateFB_WarPetArrayTechniqueLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int PetExp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValList = default(VectorOffset),
      int UnLockItem = -1,
      int UnLockItemNum = -1,
      int UnLockItemIndex = -1) {
    builder.StartObject(7);
    FB_WarPetArrayTechniqueLevelUp.AddUnLockItemIndex(builder, UnLockItemIndex);
    FB_WarPetArrayTechniqueLevelUp.AddUnLockItemNum(builder, UnLockItemNum);
    FB_WarPetArrayTechniqueLevelUp.AddUnLockItem(builder, UnLockItem);
    FB_WarPetArrayTechniqueLevelUp.AddAttrValList(builder, AttrValList);
    FB_WarPetArrayTechniqueLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_WarPetArrayTechniqueLevelUp.AddPetExp(builder, PetExp);
    FB_WarPetArrayTechniqueLevelUp.AddID(builder, ID);
    return FB_WarPetArrayTechniqueLevelUp.EndFB_WarPetArrayTechniqueLevelUp(builder);
  }

  public static void StartFB_WarPetArrayTechniqueLevelUp(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPetExp(FlatBufferBuilder builder, int PetExp) { builder.AddInt(1, PetExp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValList(FlatBufferBuilder builder, VectorOffset AttrValListOffset) { builder.AddOffset(3, AttrValListOffset.Value, 0); }
  public static VectorOffset CreateAttrValListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockItem(FlatBufferBuilder builder, int UnLockItem) { builder.AddInt(4, UnLockItem, -1); }
  public static void AddUnLockItemNum(FlatBufferBuilder builder, int UnLockItemNum) { builder.AddInt(5, UnLockItemNum, -1); }
  public static void AddUnLockItemIndex(FlatBufferBuilder builder, int UnLockItemIndex) { builder.AddInt(6, UnLockItemIndex, -1); }
  public static Offset<FB_WarPetArrayTechniqueLevelUp> EndFB_WarPetArrayTechniqueLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetArrayTechniqueLevelUp>(o);
  }
};

public sealed class FB_WarPetArrayTechniqueLevelUpContainer : Table {
  public static FB_WarPetArrayTechniqueLevelUpContainer GetRootAsFB_WarPetArrayTechniqueLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetArrayTechniqueLevelUpContainer(_bb, new FB_WarPetArrayTechniqueLevelUpContainer()); }
  public static FB_WarPetArrayTechniqueLevelUpContainer GetRootAsFB_WarPetArrayTechniqueLevelUpContainer(ByteBuffer _bb, FB_WarPetArrayTechniqueLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetArrayTechniqueLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetArrayTechniqueLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetArrayTechniqueLevelUp GetItems(int j) { return GetItems(new FB_WarPetArrayTechniqueLevelUp(), j); }
  public FB_WarPetArrayTechniqueLevelUp GetItems(FB_WarPetArrayTechniqueLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetArrayTechniqueLevelUpContainer> CreateFB_WarPetArrayTechniqueLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetArrayTechniqueLevelUpContainer.AddItems(builder, items);
    return FB_WarPetArrayTechniqueLevelUpContainer.EndFB_WarPetArrayTechniqueLevelUpContainer(builder);
  }

  public static void StartFB_WarPetArrayTechniqueLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetArrayTechniqueLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetArrayTechniqueLevelUpContainer> EndFB_WarPetArrayTechniqueLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetArrayTechniqueLevelUpContainer>(o);
  }
  public static void FinishFB_WarPetArrayTechniqueLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetArrayTechniqueLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
