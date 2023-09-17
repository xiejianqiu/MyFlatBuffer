// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TaoZhuangAttr : Table {
  public static FB_TaoZhuangAttr GetRootAsFB_TaoZhuangAttr(ByteBuffer _bb) { return GetRootAsFB_TaoZhuangAttr(_bb, new FB_TaoZhuangAttr()); }
  public static FB_TaoZhuangAttr GetRootAsFB_TaoZhuangAttr(ByteBuffer _bb, FB_TaoZhuangAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TaoZhuangAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TaoZhuangId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quantity { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaoZhuangAttr> CreateFB_TaoZhuangAttr(FlatBufferBuilder builder,
      int ID = 0,
      int TaoZhuangId = -1,
      int Quantity = -1,
      VectorOffset AttrList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_TaoZhuangAttr.AddAttrValueList(builder, AttrValueList);
    FB_TaoZhuangAttr.AddAttrList(builder, AttrList);
    FB_TaoZhuangAttr.AddQuantity(builder, Quantity);
    FB_TaoZhuangAttr.AddTaoZhuangId(builder, TaoZhuangId);
    FB_TaoZhuangAttr.AddID(builder, ID);
    return FB_TaoZhuangAttr.EndFB_TaoZhuangAttr(builder);
  }

  public static void StartFB_TaoZhuangAttr(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTaoZhuangId(FlatBufferBuilder builder, int TaoZhuangId) { builder.AddInt(1, TaoZhuangId, -1); }
  public static void AddQuantity(FlatBufferBuilder builder, int Quantity) { builder.AddInt(2, Quantity, -1); }
  public static void AddAttrList(FlatBufferBuilder builder, VectorOffset AttrListOffset) { builder.AddOffset(3, AttrListOffset.Value, 0); }
  public static VectorOffset CreateAttrListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaoZhuangAttr> EndFB_TaoZhuangAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaoZhuangAttr>(o);
  }
};

public sealed class FB_TaoZhuangAttrContainer : Table {
  public static FB_TaoZhuangAttrContainer GetRootAsFB_TaoZhuangAttrContainer(ByteBuffer _bb) { return GetRootAsFB_TaoZhuangAttrContainer(_bb, new FB_TaoZhuangAttrContainer()); }
  public static FB_TaoZhuangAttrContainer GetRootAsFB_TaoZhuangAttrContainer(ByteBuffer _bb, FB_TaoZhuangAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TaoZhuangAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TaoZhuangAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TaoZhuangAttr GetItems(int j) { return GetItems(new FB_TaoZhuangAttr(), j); }
  public FB_TaoZhuangAttr GetItems(FB_TaoZhuangAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaoZhuangAttrContainer> CreateFB_TaoZhuangAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TaoZhuangAttrContainer.AddItems(builder, items);
    return FB_TaoZhuangAttrContainer.EndFB_TaoZhuangAttrContainer(builder);
  }

  public static void StartFB_TaoZhuangAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TaoZhuangAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaoZhuangAttrContainer> EndFB_TaoZhuangAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaoZhuangAttrContainer>(o);
  }
  public static void FinishFB_TaoZhuangAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_TaoZhuangAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
