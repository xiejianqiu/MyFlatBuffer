// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondStrengthen : Table {
  public static FB_DiamondStrengthen GetRootAsFB_DiamondStrengthen(ByteBuffer _bb) { return GetRootAsFB_DiamondStrengthen(_bb, new FB_DiamondStrengthen()); }
  public static FB_DiamondStrengthen GetRootAsFB_DiamondStrengthen(ByteBuffer _bb, FB_DiamondStrengthen obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondStrengthen __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int NeedItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedItemNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DiamondStrengthen> CreateFB_DiamondStrengthen(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrNumList = default(VectorOffset),
      int NeedItemId = -1,
      int NeedItemNum = -1) {
    builder.StartObject(5);
    FB_DiamondStrengthen.AddNeedItemNum(builder, NeedItemNum);
    FB_DiamondStrengthen.AddNeedItemId(builder, NeedItemId);
    FB_DiamondStrengthen.AddAttrNumList(builder, AttrNumList);
    FB_DiamondStrengthen.AddAttrIdList(builder, AttrIdList);
    FB_DiamondStrengthen.AddID(builder, ID);
    return FB_DiamondStrengthen.EndFB_DiamondStrengthen(builder);
  }

  public static void StartFB_DiamondStrengthen(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(1, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrNumList(FlatBufferBuilder builder, VectorOffset AttrNumListOffset) { builder.AddOffset(2, AttrNumListOffset.Value, 0); }
  public static VectorOffset CreateAttrNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNeedItemId(FlatBufferBuilder builder, int NeedItemId) { builder.AddInt(3, NeedItemId, -1); }
  public static void AddNeedItemNum(FlatBufferBuilder builder, int NeedItemNum) { builder.AddInt(4, NeedItemNum, -1); }
  public static Offset<FB_DiamondStrengthen> EndFB_DiamondStrengthen(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondStrengthen>(o);
  }
};

public sealed class FB_DiamondStrengthenContainer : Table {
  public static FB_DiamondStrengthenContainer GetRootAsFB_DiamondStrengthenContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondStrengthenContainer(_bb, new FB_DiamondStrengthenContainer()); }
  public static FB_DiamondStrengthenContainer GetRootAsFB_DiamondStrengthenContainer(ByteBuffer _bb, FB_DiamondStrengthenContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondStrengthenContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondStrengthenContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondStrengthen GetItems(int j) { return GetItems(new FB_DiamondStrengthen(), j); }
  public FB_DiamondStrengthen GetItems(FB_DiamondStrengthen obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondStrengthenContainer> CreateFB_DiamondStrengthenContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondStrengthenContainer.AddItems(builder, items);
    return FB_DiamondStrengthenContainer.EndFB_DiamondStrengthenContainer(builder);
  }

  public static void StartFB_DiamondStrengthenContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondStrengthen>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondStrengthenContainer> EndFB_DiamondStrengthenContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondStrengthenContainer>(o);
  }
  public static void FinishFB_DiamondStrengthenContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondStrengthenContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
