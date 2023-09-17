// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OldGodSuitAttr : Table {
  public static FB_OldGodSuitAttr GetRootAsFB_OldGodSuitAttr(ByteBuffer _bb) { return GetRootAsFB_OldGodSuitAttr(_bb, new FB_OldGodSuitAttr()); }
  public static FB_OldGodSuitAttr GetRootAsFB_OldGodSuitAttr(ByteBuffer _bb, FB_OldGodSuitAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OldGodSuitAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string StepName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodSuitAttr> CreateFB_OldGodSuitAttr(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset StepName = default(StringOffset),
      StringOffset Name = default(StringOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_OldGodSuitAttr.AddAttrValueList(builder, AttrValueList);
    FB_OldGodSuitAttr.AddAttrIdList(builder, AttrIdList);
    FB_OldGodSuitAttr.AddName(builder, Name);
    FB_OldGodSuitAttr.AddStepName(builder, StepName);
    FB_OldGodSuitAttr.AddID(builder, ID);
    return FB_OldGodSuitAttr.EndFB_OldGodSuitAttr(builder);
  }

  public static void StartFB_OldGodSuitAttr(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStepName(FlatBufferBuilder builder, StringOffset StepNameOffset) { builder.AddOffset(1, StepNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodSuitAttr> EndFB_OldGodSuitAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodSuitAttr>(o);
  }
};

public sealed class FB_OldGodSuitAttrContainer : Table {
  public static FB_OldGodSuitAttrContainer GetRootAsFB_OldGodSuitAttrContainer(ByteBuffer _bb) { return GetRootAsFB_OldGodSuitAttrContainer(_bb, new FB_OldGodSuitAttrContainer()); }
  public static FB_OldGodSuitAttrContainer GetRootAsFB_OldGodSuitAttrContainer(ByteBuffer _bb, FB_OldGodSuitAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OldGodSuitAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OldGodSuitAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OldGodSuitAttr GetItems(int j) { return GetItems(new FB_OldGodSuitAttr(), j); }
  public FB_OldGodSuitAttr GetItems(FB_OldGodSuitAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodSuitAttrContainer> CreateFB_OldGodSuitAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OldGodSuitAttrContainer.AddItems(builder, items);
    return FB_OldGodSuitAttrContainer.EndFB_OldGodSuitAttrContainer(builder);
  }

  public static void StartFB_OldGodSuitAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OldGodSuitAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodSuitAttrContainer> EndFB_OldGodSuitAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodSuitAttrContainer>(o);
  }
  public static void FinishFB_OldGodSuitAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_OldGodSuitAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
