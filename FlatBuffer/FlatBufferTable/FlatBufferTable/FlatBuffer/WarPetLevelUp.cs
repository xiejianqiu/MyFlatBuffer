// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetLevelUp : Table {
  public static FB_WarPetLevelUp GetRootAsFB_WarPetLevelUp(ByteBuffer _bb) { return GetRootAsFB_WarPetLevelUp(_bb, new FB_WarPetLevelUp()); }
  public static FB_WarPetLevelUp GetRootAsFB_WarPetLevelUp(ByteBuffer _bb, FB_WarPetLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PetExp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetLevelUp> CreateFB_WarPetLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int PetExp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_WarPetLevelUp.AddAttrValList(builder, AttrValList);
    FB_WarPetLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_WarPetLevelUp.AddPetExp(builder, PetExp);
    FB_WarPetLevelUp.AddID(builder, ID);
    return FB_WarPetLevelUp.EndFB_WarPetLevelUp(builder);
  }

  public static void StartFB_WarPetLevelUp(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPetExp(FlatBufferBuilder builder, int PetExp) { builder.AddInt(1, PetExp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValList(FlatBufferBuilder builder, VectorOffset AttrValListOffset) { builder.AddOffset(3, AttrValListOffset.Value, 0); }
  public static VectorOffset CreateAttrValListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetLevelUp> EndFB_WarPetLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetLevelUp>(o);
  }
};

public sealed class FB_WarPetLevelUpContainer : Table {
  public static FB_WarPetLevelUpContainer GetRootAsFB_WarPetLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetLevelUpContainer(_bb, new FB_WarPetLevelUpContainer()); }
  public static FB_WarPetLevelUpContainer GetRootAsFB_WarPetLevelUpContainer(ByteBuffer _bb, FB_WarPetLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetLevelUp GetItems(int j) { return GetItems(new FB_WarPetLevelUp(), j); }
  public FB_WarPetLevelUp GetItems(FB_WarPetLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetLevelUpContainer> CreateFB_WarPetLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetLevelUpContainer.AddItems(builder, items);
    return FB_WarPetLevelUpContainer.EndFB_WarPetLevelUpContainer(builder);
  }

  public static void StartFB_WarPetLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetLevelUpContainer> EndFB_WarPetLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetLevelUpContainer>(o);
  }
  public static void FinishFB_WarPetLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
