// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JieYuanSuit : Table {
  public static FB_JieYuanSuit GetRootAsFB_JieYuanSuit(ByteBuffer _bb) { return GetRootAsFB_JieYuanSuit(_bb, new FB_JieYuanSuit()); }
  public static FB_JieYuanSuit GetRootAsFB_JieYuanSuit(ByteBuffer _bb, FB_JieYuanSuit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JieYuanSuit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanSuit> CreateFB_JieYuanSuit(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_JieYuanSuit.AddAttrValueList(builder, AttrValueList);
    FB_JieYuanSuit.AddAttrIdList(builder, AttrIdList);
    FB_JieYuanSuit.AddID(builder, ID);
    return FB_JieYuanSuit.EndFB_JieYuanSuit(builder);
  }

  public static void StartFB_JieYuanSuit(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(1, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(2, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanSuit> EndFB_JieYuanSuit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanSuit>(o);
  }
};

public sealed class FB_JieYuanSuitContainer : Table {
  public static FB_JieYuanSuitContainer GetRootAsFB_JieYuanSuitContainer(ByteBuffer _bb) { return GetRootAsFB_JieYuanSuitContainer(_bb, new FB_JieYuanSuitContainer()); }
  public static FB_JieYuanSuitContainer GetRootAsFB_JieYuanSuitContainer(ByteBuffer _bb, FB_JieYuanSuitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JieYuanSuitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JieYuanSuitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JieYuanSuit GetItems(int j) { return GetItems(new FB_JieYuanSuit(), j); }
  public FB_JieYuanSuit GetItems(FB_JieYuanSuit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanSuitContainer> CreateFB_JieYuanSuitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JieYuanSuitContainer.AddItems(builder, items);
    return FB_JieYuanSuitContainer.EndFB_JieYuanSuitContainer(builder);
  }

  public static void StartFB_JieYuanSuitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JieYuanSuit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanSuitContainer> EndFB_JieYuanSuitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanSuitContainer>(o);
  }
  public static void FinishFB_JieYuanSuitContainerBuffer(FlatBufferBuilder builder, Offset<FB_JieYuanSuitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
