// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JieSoulStone : Table {
  public static FB_JieSoulStone GetRootAsFB_JieSoulStone(ByteBuffer _bb) { return GetRootAsFB_JieSoulStone(_bb, new FB_JieSoulStone()); }
  public static FB_JieSoulStone GetRootAsFB_JieSoulStone(ByteBuffer _bb, FB_JieSoulStone obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JieSoulStone __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieSoulStone> CreateFB_JieSoulStone(FlatBufferBuilder builder,
      int Id = 0,
      int Level = -1,
      int ItemID = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_JieSoulStone.AddAttrList(builder, AttrList);
    FB_JieSoulStone.AddAttrIDList(builder, AttrIDList);
    FB_JieSoulStone.AddItemID(builder, ItemID);
    FB_JieSoulStone.AddLevel(builder, Level);
    FB_JieSoulStone.AddId(builder, Id);
    return FB_JieSoulStone.EndFB_JieSoulStone(builder);
  }

  public static void StartFB_JieSoulStone(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(2, ItemID, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(3, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrList(FlatBufferBuilder builder, VectorOffset AttrListOffset) { builder.AddOffset(4, AttrListOffset.Value, 0); }
  public static VectorOffset CreateAttrListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieSoulStone> EndFB_JieSoulStone(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieSoulStone>(o);
  }
};

public sealed class FB_JieSoulStoneContainer : Table {
  public static FB_JieSoulStoneContainer GetRootAsFB_JieSoulStoneContainer(ByteBuffer _bb) { return GetRootAsFB_JieSoulStoneContainer(_bb, new FB_JieSoulStoneContainer()); }
  public static FB_JieSoulStoneContainer GetRootAsFB_JieSoulStoneContainer(ByteBuffer _bb, FB_JieSoulStoneContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JieSoulStoneContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JieSoulStoneContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JieSoulStone GetItems(int j) { return GetItems(new FB_JieSoulStone(), j); }
  public FB_JieSoulStone GetItems(FB_JieSoulStone obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieSoulStoneContainer> CreateFB_JieSoulStoneContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JieSoulStoneContainer.AddItems(builder, items);
    return FB_JieSoulStoneContainer.EndFB_JieSoulStoneContainer(builder);
  }

  public static void StartFB_JieSoulStoneContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JieSoulStone>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieSoulStoneContainer> EndFB_JieSoulStoneContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieSoulStoneContainer>(o);
  }
  public static void FinishFB_JieSoulStoneContainerBuffer(FlatBufferBuilder builder, Offset<FB_JieSoulStoneContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
