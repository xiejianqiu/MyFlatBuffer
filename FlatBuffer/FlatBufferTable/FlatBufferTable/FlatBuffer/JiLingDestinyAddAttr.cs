// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingDestinyAddAttr : Table {
  public static FB_JiLingDestinyAddAttr GetRootAsFB_JiLingDestinyAddAttr(ByteBuffer _bb) { return GetRootAsFB_JiLingDestinyAddAttr(_bb, new FB_JiLingDestinyAddAttr()); }
  public static FB_JiLingDestinyAddAttr GetRootAsFB_JiLingDestinyAddAttr(ByteBuffer _bb, FB_JiLingDestinyAddAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingDestinyAddAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnlockingLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int GetAttrIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingDestinyAddAttr> CreateFB_JiLingDestinyAddAttr(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int UnlockingLevel = 1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_JiLingDestinyAddAttr.AddAttrValueList(builder, AttrValueList);
    FB_JiLingDestinyAddAttr.AddAttrIDList(builder, AttrIDList);
    FB_JiLingDestinyAddAttr.AddUnlockingLevel(builder, UnlockingLevel);
    FB_JiLingDestinyAddAttr.AddName(builder, Name);
    FB_JiLingDestinyAddAttr.AddId(builder, Id);
    return FB_JiLingDestinyAddAttr.EndFB_JiLingDestinyAddAttr(builder);
  }

  public static void StartFB_JiLingDestinyAddAttr(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddUnlockingLevel(FlatBufferBuilder builder, int UnlockingLevel) { builder.AddInt(2, UnlockingLevel, 1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(3, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingDestinyAddAttr> EndFB_JiLingDestinyAddAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingDestinyAddAttr>(o);
  }
};

public sealed class FB_JiLingDestinyAddAttrContainer : Table {
  public static FB_JiLingDestinyAddAttrContainer GetRootAsFB_JiLingDestinyAddAttrContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingDestinyAddAttrContainer(_bb, new FB_JiLingDestinyAddAttrContainer()); }
  public static FB_JiLingDestinyAddAttrContainer GetRootAsFB_JiLingDestinyAddAttrContainer(ByteBuffer _bb, FB_JiLingDestinyAddAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingDestinyAddAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingDestinyAddAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingDestinyAddAttr GetItems(int j) { return GetItems(new FB_JiLingDestinyAddAttr(), j); }
  public FB_JiLingDestinyAddAttr GetItems(FB_JiLingDestinyAddAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingDestinyAddAttrContainer> CreateFB_JiLingDestinyAddAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingDestinyAddAttrContainer.AddItems(builder, items);
    return FB_JiLingDestinyAddAttrContainer.EndFB_JiLingDestinyAddAttrContainer(builder);
  }

  public static void StartFB_JiLingDestinyAddAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingDestinyAddAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingDestinyAddAttrContainer> EndFB_JiLingDestinyAddAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingDestinyAddAttrContainer>(o);
  }
  public static void FinishFB_JiLingDestinyAddAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingDestinyAddAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
