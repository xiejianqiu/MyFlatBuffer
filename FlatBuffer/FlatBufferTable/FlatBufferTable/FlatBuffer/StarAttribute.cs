// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarAttribute : Table {
  public static FB_StarAttribute GetRootAsFB_StarAttribute(ByteBuffer _bb) { return GetRootAsFB_StarAttribute(_bb, new FB_StarAttribute()); }
  public static FB_StarAttribute GetRootAsFB_StarAttribute(ByteBuffer _bb, FB_StarAttribute obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarAttribute __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int EffectID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StarAttribute> CreateFB_StarAttribute(FlatBufferBuilder builder,
      int ID = 0,
      int StarNum = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int EffectID = -1) {
    builder.StartObject(5);
    FB_StarAttribute.AddEffectID(builder, EffectID);
    FB_StarAttribute.AddAttrValueList(builder, AttrValueList);
    FB_StarAttribute.AddAttrIDList(builder, AttrIDList);
    FB_StarAttribute.AddStarNum(builder, StarNum);
    FB_StarAttribute.AddID(builder, ID);
    return FB_StarAttribute.EndFB_StarAttribute(builder);
  }

  public static void StartFB_StarAttribute(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStarNum(FlatBufferBuilder builder, int StarNum) { builder.AddInt(1, StarNum, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(2, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEffectID(FlatBufferBuilder builder, int EffectID) { builder.AddInt(4, EffectID, -1); }
  public static Offset<FB_StarAttribute> EndFB_StarAttribute(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarAttribute>(o);
  }
};

public sealed class FB_StarAttributeContainer : Table {
  public static FB_StarAttributeContainer GetRootAsFB_StarAttributeContainer(ByteBuffer _bb) { return GetRootAsFB_StarAttributeContainer(_bb, new FB_StarAttributeContainer()); }
  public static FB_StarAttributeContainer GetRootAsFB_StarAttributeContainer(ByteBuffer _bb, FB_StarAttributeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarAttributeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarAttributeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarAttribute GetItems(int j) { return GetItems(new FB_StarAttribute(), j); }
  public FB_StarAttribute GetItems(FB_StarAttribute obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarAttributeContainer> CreateFB_StarAttributeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarAttributeContainer.AddItems(builder, items);
    return FB_StarAttributeContainer.EndFB_StarAttributeContainer(builder);
  }

  public static void StartFB_StarAttributeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarAttribute>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarAttributeContainer> EndFB_StarAttributeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarAttributeContainer>(o);
  }
  public static void FinishFB_StarAttributeContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarAttributeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
