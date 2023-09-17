// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RMBAttribute : Table {
  public static FB_RMBAttribute GetRootAsFB_RMBAttribute(ByteBuffer _bb) { return GetRootAsFB_RMBAttribute(_bb, new FB_RMBAttribute()); }
  public static FB_RMBAttribute GetRootAsFB_RMBAttribute(ByteBuffer _bb, FB_RMBAttribute obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RMBAttribute __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetParamList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RMBAttribute> CreateFB_RMBAttribute(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_RMBAttribute.AddParamList(builder, ParamList);
    FB_RMBAttribute.AddId(builder, Id);
    return FB_RMBAttribute.EndFB_RMBAttribute(builder);
  }

  public static void StartFB_RMBAttribute(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(1, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RMBAttribute> EndFB_RMBAttribute(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RMBAttribute>(o);
  }
};

public sealed class FB_RMBAttributeContainer : Table {
  public static FB_RMBAttributeContainer GetRootAsFB_RMBAttributeContainer(ByteBuffer _bb) { return GetRootAsFB_RMBAttributeContainer(_bb, new FB_RMBAttributeContainer()); }
  public static FB_RMBAttributeContainer GetRootAsFB_RMBAttributeContainer(ByteBuffer _bb, FB_RMBAttributeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RMBAttributeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RMBAttributeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RMBAttribute GetItems(int j) { return GetItems(new FB_RMBAttribute(), j); }
  public FB_RMBAttribute GetItems(FB_RMBAttribute obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RMBAttributeContainer> CreateFB_RMBAttributeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RMBAttributeContainer.AddItems(builder, items);
    return FB_RMBAttributeContainer.EndFB_RMBAttributeContainer(builder);
  }

  public static void StartFB_RMBAttributeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RMBAttribute>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RMBAttributeContainer> EndFB_RMBAttributeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RMBAttributeContainer>(o);
  }
  public static void FinishFB_RMBAttributeContainerBuffer(FlatBufferBuilder builder, Offset<FB_RMBAttributeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
