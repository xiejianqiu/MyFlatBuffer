// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyObjParams : Table {
  public static FB_DestinyObjParams GetRootAsFB_DestinyObjParams(ByteBuffer _bb) { return GetRootAsFB_DestinyObjParams(_bb, new FB_DestinyObjParams()); }
  public static FB_DestinyObjParams GetRootAsFB_DestinyObjParams(ByteBuffer _bb, FB_DestinyObjParams obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyObjParams __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FreeOrFixed { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DefaultFOV { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Path { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ModelPath { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_DestinyObjParams> CreateFB_DestinyObjParams(FlatBufferBuilder builder,
      int Id = 0,
      int FreeOrFixed = -1,
      int DefaultFOV = -1,
      StringOffset Path = default(StringOffset),
      StringOffset ModelPath = default(StringOffset)) {
    builder.StartObject(5);
    FB_DestinyObjParams.AddModelPath(builder, ModelPath);
    FB_DestinyObjParams.AddPath(builder, Path);
    FB_DestinyObjParams.AddDefaultFOV(builder, DefaultFOV);
    FB_DestinyObjParams.AddFreeOrFixed(builder, FreeOrFixed);
    FB_DestinyObjParams.AddId(builder, Id);
    return FB_DestinyObjParams.EndFB_DestinyObjParams(builder);
  }

  public static void StartFB_DestinyObjParams(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddFreeOrFixed(FlatBufferBuilder builder, int FreeOrFixed) { builder.AddInt(1, FreeOrFixed, -1); }
  public static void AddDefaultFOV(FlatBufferBuilder builder, int DefaultFOV) { builder.AddInt(2, DefaultFOV, -1); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(3, PathOffset.Value, 0); }
  public static void AddModelPath(FlatBufferBuilder builder, StringOffset ModelPathOffset) { builder.AddOffset(4, ModelPathOffset.Value, 0); }
  public static Offset<FB_DestinyObjParams> EndFB_DestinyObjParams(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyObjParams>(o);
  }
};

public sealed class FB_DestinyObjParamsContainer : Table {
  public static FB_DestinyObjParamsContainer GetRootAsFB_DestinyObjParamsContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyObjParamsContainer(_bb, new FB_DestinyObjParamsContainer()); }
  public static FB_DestinyObjParamsContainer GetRootAsFB_DestinyObjParamsContainer(ByteBuffer _bb, FB_DestinyObjParamsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyObjParamsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyObjParamsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyObjParams GetItems(int j) { return GetItems(new FB_DestinyObjParams(), j); }
  public FB_DestinyObjParams GetItems(FB_DestinyObjParams obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyObjParamsContainer> CreateFB_DestinyObjParamsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyObjParamsContainer.AddItems(builder, items);
    return FB_DestinyObjParamsContainer.EndFB_DestinyObjParamsContainer(builder);
  }

  public static void StartFB_DestinyObjParamsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyObjParams>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyObjParamsContainer> EndFB_DestinyObjParamsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyObjParamsContainer>(o);
  }
  public static void FinishFB_DestinyObjParamsContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyObjParamsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
