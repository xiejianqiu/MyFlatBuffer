// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LevelSealAttr : Table {
  public static FB_LevelSealAttr GetRootAsFB_LevelSealAttr(ByteBuffer _bb) { return GetRootAsFB_LevelSealAttr(_bb, new FB_LevelSealAttr()); }
  public static FB_LevelSealAttr GetRootAsFB_LevelSealAttr(ByteBuffer _bb, FB_LevelSealAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LevelSealAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long Exp { get { int o = __offset(6); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelSealAttr> CreateFB_LevelSealAttr(FlatBufferBuilder builder,
      int ID = 0,
      long Exp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_LevelSealAttr.AddExp(builder, Exp);
    FB_LevelSealAttr.AddAttrValueList(builder, AttrValueList);
    FB_LevelSealAttr.AddAttrIdList(builder, AttrIdList);
    FB_LevelSealAttr.AddID(builder, ID);
    return FB_LevelSealAttr.EndFB_LevelSealAttr(builder);
  }

  public static void StartFB_LevelSealAttr(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(1, Exp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelSealAttr> EndFB_LevelSealAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealAttr>(o);
  }
};

public sealed class FB_LevelSealAttrContainer : Table {
  public static FB_LevelSealAttrContainer GetRootAsFB_LevelSealAttrContainer(ByteBuffer _bb) { return GetRootAsFB_LevelSealAttrContainer(_bb, new FB_LevelSealAttrContainer()); }
  public static FB_LevelSealAttrContainer GetRootAsFB_LevelSealAttrContainer(ByteBuffer _bb, FB_LevelSealAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LevelSealAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LevelSealAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LevelSealAttr GetItems(int j) { return GetItems(new FB_LevelSealAttr(), j); }
  public FB_LevelSealAttr GetItems(FB_LevelSealAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelSealAttrContainer> CreateFB_LevelSealAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LevelSealAttrContainer.AddItems(builder, items);
    return FB_LevelSealAttrContainer.EndFB_LevelSealAttrContainer(builder);
  }

  public static void StartFB_LevelSealAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LevelSealAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelSealAttrContainer> EndFB_LevelSealAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealAttrContainer>(o);
  }
  public static void FinishFB_LevelSealAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_LevelSealAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
