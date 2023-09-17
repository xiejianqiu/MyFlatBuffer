// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondAttribute : Table {
  public static FB_DiamondAttribute GetRootAsFB_DiamondAttribute(ByteBuffer _bb) { return GetRootAsFB_DiamondAttribute(_bb, new FB_DiamondAttribute()); }
  public static FB_DiamondAttribute GetRootAsFB_DiamondAttribute(ByteBuffer _bb, FB_DiamondAttribute obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondAttribute __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MinLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondAttribute> CreateFB_DiamondAttribute(FlatBufferBuilder builder,
      int ID = 0,
      int MinLevel = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_DiamondAttribute.AddAttrValueList(builder, AttrValueList);
    FB_DiamondAttribute.AddAttrIDList(builder, AttrIDList);
    FB_DiamondAttribute.AddMinLevel(builder, MinLevel);
    FB_DiamondAttribute.AddID(builder, ID);
    return FB_DiamondAttribute.EndFB_DiamondAttribute(builder);
  }

  public static void StartFB_DiamondAttribute(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMinLevel(FlatBufferBuilder builder, int MinLevel) { builder.AddInt(1, MinLevel, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(2, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondAttribute> EndFB_DiamondAttribute(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondAttribute>(o);
  }
};

public sealed class FB_DiamondAttributeContainer : Table {
  public static FB_DiamondAttributeContainer GetRootAsFB_DiamondAttributeContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondAttributeContainer(_bb, new FB_DiamondAttributeContainer()); }
  public static FB_DiamondAttributeContainer GetRootAsFB_DiamondAttributeContainer(ByteBuffer _bb, FB_DiamondAttributeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondAttributeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondAttributeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondAttribute GetItems(int j) { return GetItems(new FB_DiamondAttribute(), j); }
  public FB_DiamondAttribute GetItems(FB_DiamondAttribute obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondAttributeContainer> CreateFB_DiamondAttributeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondAttributeContainer.AddItems(builder, items);
    return FB_DiamondAttributeContainer.EndFB_DiamondAttributeContainer(builder);
  }

  public static void StartFB_DiamondAttributeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondAttribute>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondAttributeContainer> EndFB_DiamondAttributeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondAttributeContainer>(o);
  }
  public static void FinishFB_DiamondAttributeContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondAttributeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
