// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingQiLingGongMingAddAttr : Table {
  public static FB_JiLingQiLingGongMingAddAttr GetRootAsFB_JiLingQiLingGongMingAddAttr(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingGongMingAddAttr(_bb, new FB_JiLingQiLingGongMingAddAttr()); }
  public static FB_JiLingQiLingGongMingAddAttr GetRootAsFB_JiLingQiLingGongMingAddAttr(ByteBuffer _bb, FB_JiLingQiLingGongMingAddAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingQiLingGongMingAddAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int QiLingType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int QiLingLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int GongMingLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int GetAttrIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingQiLingGongMingAddAttr> CreateFB_JiLingQiLingGongMingAddAttr(FlatBufferBuilder builder,
      int Id = 0,
      int QiLingType = 1,
      int QiLingLevel = 1,
      int GongMingLevel = 1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_JiLingQiLingGongMingAddAttr.AddAttrValueList(builder, AttrValueList);
    FB_JiLingQiLingGongMingAddAttr.AddAttrIDList(builder, AttrIDList);
    FB_JiLingQiLingGongMingAddAttr.AddGongMingLevel(builder, GongMingLevel);
    FB_JiLingQiLingGongMingAddAttr.AddQiLingLevel(builder, QiLingLevel);
    FB_JiLingQiLingGongMingAddAttr.AddQiLingType(builder, QiLingType);
    FB_JiLingQiLingGongMingAddAttr.AddId(builder, Id);
    return FB_JiLingQiLingGongMingAddAttr.EndFB_JiLingQiLingGongMingAddAttr(builder);
  }

  public static void StartFB_JiLingQiLingGongMingAddAttr(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddQiLingType(FlatBufferBuilder builder, int QiLingType) { builder.AddInt(1, QiLingType, 1); }
  public static void AddQiLingLevel(FlatBufferBuilder builder, int QiLingLevel) { builder.AddInt(2, QiLingLevel, 1); }
  public static void AddGongMingLevel(FlatBufferBuilder builder, int GongMingLevel) { builder.AddInt(3, GongMingLevel, 1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(4, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingQiLingGongMingAddAttr> EndFB_JiLingQiLingGongMingAddAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingGongMingAddAttr>(o);
  }
};

public sealed class FB_JiLingQiLingGongMingAddAttrContainer : Table {
  public static FB_JiLingQiLingGongMingAddAttrContainer GetRootAsFB_JiLingQiLingGongMingAddAttrContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingGongMingAddAttrContainer(_bb, new FB_JiLingQiLingGongMingAddAttrContainer()); }
  public static FB_JiLingQiLingGongMingAddAttrContainer GetRootAsFB_JiLingQiLingGongMingAddAttrContainer(ByteBuffer _bb, FB_JiLingQiLingGongMingAddAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingQiLingGongMingAddAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingQiLingGongMingAddAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingQiLingGongMingAddAttr GetItems(int j) { return GetItems(new FB_JiLingQiLingGongMingAddAttr(), j); }
  public FB_JiLingQiLingGongMingAddAttr GetItems(FB_JiLingQiLingGongMingAddAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingQiLingGongMingAddAttrContainer> CreateFB_JiLingQiLingGongMingAddAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingQiLingGongMingAddAttrContainer.AddItems(builder, items);
    return FB_JiLingQiLingGongMingAddAttrContainer.EndFB_JiLingQiLingGongMingAddAttrContainer(builder);
  }

  public static void StartFB_JiLingQiLingGongMingAddAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingQiLingGongMingAddAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingQiLingGongMingAddAttrContainer> EndFB_JiLingQiLingGongMingAddAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingGongMingAddAttrContainer>(o);
  }
  public static void FinishFB_JiLingQiLingGongMingAddAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingQiLingGongMingAddAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
