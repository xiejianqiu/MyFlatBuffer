// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ParamCollectionPublic : Table {
  public static FB_ParamCollectionPublic GetRootAsFB_ParamCollectionPublic(ByteBuffer _bb) { return GetRootAsFB_ParamCollectionPublic(_bb, new FB_ParamCollectionPublic()); }
  public static FB_ParamCollectionPublic GetRootAsFB_ParamCollectionPublic(ByteBuffer _bb, FB_ParamCollectionPublic obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ParamCollectionPublic __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long GetParamList(int j) { int o = __offset(6); return o != 0 ? bb.GetLong(__vector(o) + j * 8) : (long)0; }
  public int ParamListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ParamCollectionPublic> CreateFB_ParamCollectionPublic(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_ParamCollectionPublic.AddParamList(builder, ParamList);
    FB_ParamCollectionPublic.AddID(builder, ID);
    return FB_ParamCollectionPublic.EndFB_ParamCollectionPublic(builder);
  }

  public static void StartFB_ParamCollectionPublic(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(1, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FB_ParamCollectionPublic> EndFB_ParamCollectionPublic(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ParamCollectionPublic>(o);
  }
};

public sealed class FB_ParamCollectionPublicContainer : Table {
  public static FB_ParamCollectionPublicContainer GetRootAsFB_ParamCollectionPublicContainer(ByteBuffer _bb) { return GetRootAsFB_ParamCollectionPublicContainer(_bb, new FB_ParamCollectionPublicContainer()); }
  public static FB_ParamCollectionPublicContainer GetRootAsFB_ParamCollectionPublicContainer(ByteBuffer _bb, FB_ParamCollectionPublicContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ParamCollectionPublicContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ParamCollectionPublicContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ParamCollectionPublic GetItems(int j) { return GetItems(new FB_ParamCollectionPublic(), j); }
  public FB_ParamCollectionPublic GetItems(FB_ParamCollectionPublic obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ParamCollectionPublicContainer> CreateFB_ParamCollectionPublicContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ParamCollectionPublicContainer.AddItems(builder, items);
    return FB_ParamCollectionPublicContainer.EndFB_ParamCollectionPublicContainer(builder);
  }

  public static void StartFB_ParamCollectionPublicContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ParamCollectionPublic>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ParamCollectionPublicContainer> EndFB_ParamCollectionPublicContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ParamCollectionPublicContainer>(o);
  }
  public static void FinishFB_ParamCollectionPublicContainerBuffer(FlatBufferBuilder builder, Offset<FB_ParamCollectionPublicContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
