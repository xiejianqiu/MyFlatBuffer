// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JieYuanSlotResonance : Table {
  public static FB_JieYuanSlotResonance GetRootAsFB_JieYuanSlotResonance(ByteBuffer _bb) { return GetRootAsFB_JieYuanSlotResonance(_bb, new FB_JieYuanSlotResonance()); }
  public static FB_JieYuanSlotResonance GetRootAsFB_JieYuanSlotResonance(ByteBuffer _bb, FB_JieYuanSlotResonance obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JieYuanSlotResonance __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MinLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanSlotResonance> CreateFB_JieYuanSlotResonance(FlatBufferBuilder builder,
      int ID = 0,
      int MinLevel = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_JieYuanSlotResonance.AddAttrValueList(builder, AttrValueList);
    FB_JieYuanSlotResonance.AddAttrIDList(builder, AttrIDList);
    FB_JieYuanSlotResonance.AddMinLevel(builder, MinLevel);
    FB_JieYuanSlotResonance.AddID(builder, ID);
    return FB_JieYuanSlotResonance.EndFB_JieYuanSlotResonance(builder);
  }

  public static void StartFB_JieYuanSlotResonance(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMinLevel(FlatBufferBuilder builder, int MinLevel) { builder.AddInt(1, MinLevel, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(2, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanSlotResonance> EndFB_JieYuanSlotResonance(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanSlotResonance>(o);
  }
};

public sealed class FB_JieYuanSlotResonanceContainer : Table {
  public static FB_JieYuanSlotResonanceContainer GetRootAsFB_JieYuanSlotResonanceContainer(ByteBuffer _bb) { return GetRootAsFB_JieYuanSlotResonanceContainer(_bb, new FB_JieYuanSlotResonanceContainer()); }
  public static FB_JieYuanSlotResonanceContainer GetRootAsFB_JieYuanSlotResonanceContainer(ByteBuffer _bb, FB_JieYuanSlotResonanceContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JieYuanSlotResonanceContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JieYuanSlotResonanceContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JieYuanSlotResonance GetItems(int j) { return GetItems(new FB_JieYuanSlotResonance(), j); }
  public FB_JieYuanSlotResonance GetItems(FB_JieYuanSlotResonance obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanSlotResonanceContainer> CreateFB_JieYuanSlotResonanceContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JieYuanSlotResonanceContainer.AddItems(builder, items);
    return FB_JieYuanSlotResonanceContainer.EndFB_JieYuanSlotResonanceContainer(builder);
  }

  public static void StartFB_JieYuanSlotResonanceContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JieYuanSlotResonance>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanSlotResonanceContainer> EndFB_JieYuanSlotResonanceContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanSlotResonanceContainer>(o);
  }
  public static void FinishFB_JieYuanSlotResonanceContainerBuffer(FlatBufferBuilder builder, Offset<FB_JieYuanSlotResonanceContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
