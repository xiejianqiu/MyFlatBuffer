// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaLegendAttr : Table {
  public static FB_ShenWangZhanJiaLegendAttr GetRootAsFB_ShenWangZhanJiaLegendAttr(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaLegendAttr(_bb, new FB_ShenWangZhanJiaLegendAttr()); }
  public static FB_ShenWangZhanJiaLegendAttr GetRootAsFB_ShenWangZhanJiaLegendAttr(ByteBuffer _bb, FB_ShenWangZhanJiaLegendAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaLegendAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaLegendAttr> CreateFB_ShenWangZhanJiaLegendAttr(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_ShenWangZhanJiaLegendAttr.AddAttrValueList(builder, AttrValueList);
    FB_ShenWangZhanJiaLegendAttr.AddAttrIdList(builder, AttrIdList);
    FB_ShenWangZhanJiaLegendAttr.AddID(builder, ID);
    return FB_ShenWangZhanJiaLegendAttr.EndFB_ShenWangZhanJiaLegendAttr(builder);
  }

  public static void StartFB_ShenWangZhanJiaLegendAttr(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(1, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(2, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaLegendAttr> EndFB_ShenWangZhanJiaLegendAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaLegendAttr>(o);
  }
};

public sealed class FB_ShenWangZhanJiaLegendAttrContainer : Table {
  public static FB_ShenWangZhanJiaLegendAttrContainer GetRootAsFB_ShenWangZhanJiaLegendAttrContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaLegendAttrContainer(_bb, new FB_ShenWangZhanJiaLegendAttrContainer()); }
  public static FB_ShenWangZhanJiaLegendAttrContainer GetRootAsFB_ShenWangZhanJiaLegendAttrContainer(ByteBuffer _bb, FB_ShenWangZhanJiaLegendAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaLegendAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaLegendAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaLegendAttr GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaLegendAttr(), j); }
  public FB_ShenWangZhanJiaLegendAttr GetItems(FB_ShenWangZhanJiaLegendAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaLegendAttrContainer> CreateFB_ShenWangZhanJiaLegendAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaLegendAttrContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaLegendAttrContainer.EndFB_ShenWangZhanJiaLegendAttrContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaLegendAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaLegendAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaLegendAttrContainer> EndFB_ShenWangZhanJiaLegendAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaLegendAttrContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaLegendAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaLegendAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
