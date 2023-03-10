// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetItemDecompose : Table {
  public static FB_WarPetItemDecompose GetRootAsFB_WarPetItemDecompose(ByteBuffer _bb) { return GetRootAsFB_WarPetItemDecompose(_bb, new FB_WarPetItemDecompose()); }
  public static FB_WarPetItemDecompose GetRootAsFB_WarPetItemDecompose(ByteBuffer _bb, FB_WarPetItemDecompose obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetItemDecompose __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Decompose { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WarPetItemDecompose> CreateFB_WarPetItemDecompose(FlatBufferBuilder builder,
      int ID = 0,
      int Decompose = -1,
      int Type = -1) {
    builder.StartObject(3);
    FB_WarPetItemDecompose.AddType(builder, Type);
    FB_WarPetItemDecompose.AddDecompose(builder, Decompose);
    FB_WarPetItemDecompose.AddID(builder, ID);
    return FB_WarPetItemDecompose.EndFB_WarPetItemDecompose(builder);
  }

  public static void StartFB_WarPetItemDecompose(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDecompose(FlatBufferBuilder builder, int Decompose) { builder.AddInt(1, Decompose, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static Offset<FB_WarPetItemDecompose> EndFB_WarPetItemDecompose(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetItemDecompose>(o);
  }
};

public sealed class FB_WarPetItemDecomposeContainer : Table {
  public static FB_WarPetItemDecomposeContainer GetRootAsFB_WarPetItemDecomposeContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetItemDecomposeContainer(_bb, new FB_WarPetItemDecomposeContainer()); }
  public static FB_WarPetItemDecomposeContainer GetRootAsFB_WarPetItemDecomposeContainer(ByteBuffer _bb, FB_WarPetItemDecomposeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetItemDecomposeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetItemDecomposeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetItemDecompose GetItems(int j) { return GetItems(new FB_WarPetItemDecompose(), j); }
  public FB_WarPetItemDecompose GetItems(FB_WarPetItemDecompose obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetItemDecomposeContainer> CreateFB_WarPetItemDecomposeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetItemDecomposeContainer.AddItems(builder, items);
    return FB_WarPetItemDecomposeContainer.EndFB_WarPetItemDecomposeContainer(builder);
  }

  public static void StartFB_WarPetItemDecomposeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetItemDecompose>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetItemDecomposeContainer> EndFB_WarPetItemDecomposeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetItemDecomposeContainer>(o);
  }
  public static void FinishFB_WarPetItemDecomposeContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetItemDecomposeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
