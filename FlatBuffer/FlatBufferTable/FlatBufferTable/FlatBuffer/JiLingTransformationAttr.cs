// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingTransformationAttr : Table {
  public static FB_JiLingTransformationAttr GetRootAsFB_JiLingTransformationAttr(ByteBuffer _bb) { return GetRootAsFB_JiLingTransformationAttr(_bb, new FB_JiLingTransformationAttr()); }
  public static FB_JiLingTransformationAttr GetRootAsFB_JiLingTransformationAttr(ByteBuffer _bb, FB_JiLingTransformationAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingTransformationAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrPercentId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TransformationAttrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_JiLingTransformationAttr> CreateFB_JiLingTransformationAttr(FlatBufferBuilder builder,
      int Id = 0,
      int AttrId = -1,
      int AttrPercentId = 0,
      int TransformationAttrId = 0) {
    builder.StartObject(4);
    FB_JiLingTransformationAttr.AddTransformationAttrId(builder, TransformationAttrId);
    FB_JiLingTransformationAttr.AddAttrPercentId(builder, AttrPercentId);
    FB_JiLingTransformationAttr.AddAttrId(builder, AttrId);
    FB_JiLingTransformationAttr.AddId(builder, Id);
    return FB_JiLingTransformationAttr.EndFB_JiLingTransformationAttr(builder);
  }

  public static void StartFB_JiLingTransformationAttr(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAttrId(FlatBufferBuilder builder, int AttrId) { builder.AddInt(1, AttrId, -1); }
  public static void AddAttrPercentId(FlatBufferBuilder builder, int AttrPercentId) { builder.AddInt(2, AttrPercentId, 0); }
  public static void AddTransformationAttrId(FlatBufferBuilder builder, int TransformationAttrId) { builder.AddInt(3, TransformationAttrId, 0); }
  public static Offset<FB_JiLingTransformationAttr> EndFB_JiLingTransformationAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingTransformationAttr>(o);
  }
};

public sealed class FB_JiLingTransformationAttrContainer : Table {
  public static FB_JiLingTransformationAttrContainer GetRootAsFB_JiLingTransformationAttrContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingTransformationAttrContainer(_bb, new FB_JiLingTransformationAttrContainer()); }
  public static FB_JiLingTransformationAttrContainer GetRootAsFB_JiLingTransformationAttrContainer(ByteBuffer _bb, FB_JiLingTransformationAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingTransformationAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingTransformationAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingTransformationAttr GetItems(int j) { return GetItems(new FB_JiLingTransformationAttr(), j); }
  public FB_JiLingTransformationAttr GetItems(FB_JiLingTransformationAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingTransformationAttrContainer> CreateFB_JiLingTransformationAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingTransformationAttrContainer.AddItems(builder, items);
    return FB_JiLingTransformationAttrContainer.EndFB_JiLingTransformationAttrContainer(builder);
  }

  public static void StartFB_JiLingTransformationAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingTransformationAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingTransformationAttrContainer> EndFB_JiLingTransformationAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingTransformationAttrContainer>(o);
  }
  public static void FinishFB_JiLingTransformationAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingTransformationAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
