// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PetSoulStone : Table {
  public static FB_PetSoulStone GetRootAsFB_PetSoulStone(ByteBuffer _bb) { return GetRootAsFB_PetSoulStone(_bb, new FB_PetSoulStone()); }
  public static FB_PetSoulStone GetRootAsFB_PetSoulStone(ByteBuffer _bb, FB_PetSoulStone obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PetSoulStone __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PetSoulStone> CreateFB_PetSoulStone(FlatBufferBuilder builder,
      int Id = 0,
      int Type = -1,
      int Level = -1,
      int ItemID = -1,
      int UnlockLimit = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_PetSoulStone.AddAttrList(builder, AttrList);
    FB_PetSoulStone.AddAttrIDList(builder, AttrIDList);
    FB_PetSoulStone.AddUnlockLimit(builder, UnlockLimit);
    FB_PetSoulStone.AddItemID(builder, ItemID);
    FB_PetSoulStone.AddLevel(builder, Level);
    FB_PetSoulStone.AddType(builder, Type);
    FB_PetSoulStone.AddId(builder, Id);
    return FB_PetSoulStone.EndFB_PetSoulStone(builder);
  }

  public static void StartFB_PetSoulStone(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(3, ItemID, -1); }
  public static void AddUnlockLimit(FlatBufferBuilder builder, int UnlockLimit) { builder.AddInt(4, UnlockLimit, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(5, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrList(FlatBufferBuilder builder, VectorOffset AttrListOffset) { builder.AddOffset(6, AttrListOffset.Value, 0); }
  public static VectorOffset CreateAttrListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PetSoulStone> EndFB_PetSoulStone(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetSoulStone>(o);
  }
};

public sealed class FB_PetSoulStoneContainer : Table {
  public static FB_PetSoulStoneContainer GetRootAsFB_PetSoulStoneContainer(ByteBuffer _bb) { return GetRootAsFB_PetSoulStoneContainer(_bb, new FB_PetSoulStoneContainer()); }
  public static FB_PetSoulStoneContainer GetRootAsFB_PetSoulStoneContainer(ByteBuffer _bb, FB_PetSoulStoneContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PetSoulStoneContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PetSoulStoneContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PetSoulStone GetItems(int j) { return GetItems(new FB_PetSoulStone(), j); }
  public FB_PetSoulStone GetItems(FB_PetSoulStone obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PetSoulStoneContainer> CreateFB_PetSoulStoneContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PetSoulStoneContainer.AddItems(builder, items);
    return FB_PetSoulStoneContainer.EndFB_PetSoulStoneContainer(builder);
  }

  public static void StartFB_PetSoulStoneContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PetSoulStone>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PetSoulStoneContainer> EndFB_PetSoulStoneContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetSoulStoneContainer>(o);
  }
  public static void FinishFB_PetSoulStoneContainerBuffer(FlatBufferBuilder builder, Offset<FB_PetSoulStoneContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
