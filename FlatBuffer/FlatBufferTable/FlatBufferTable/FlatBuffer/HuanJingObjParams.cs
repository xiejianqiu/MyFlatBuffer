// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingObjParams : Table {
  public static FB_HuanJingObjParams GetRootAsFB_HuanJingObjParams(ByteBuffer _bb) { return GetRootAsFB_HuanJingObjParams(_bb, new FB_HuanJingObjParams()); }
  public static FB_HuanJingObjParams GetRootAsFB_HuanJingObjParams(ByteBuffer _bb, FB_HuanJingObjParams obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingObjParams __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FreeOrFixed { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DefaultFOV { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ResPath { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ModelPath { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_HuanJingObjParams> CreateFB_HuanJingObjParams(FlatBufferBuilder builder,
      int Id = 0,
      int Type = -1,
      int FreeOrFixed = -1,
      int DefaultFOV = -1,
      StringOffset ResPath = default(StringOffset),
      StringOffset ModelPath = default(StringOffset)) {
    builder.StartObject(6);
    FB_HuanJingObjParams.AddModelPath(builder, ModelPath);
    FB_HuanJingObjParams.AddResPath(builder, ResPath);
    FB_HuanJingObjParams.AddDefaultFOV(builder, DefaultFOV);
    FB_HuanJingObjParams.AddFreeOrFixed(builder, FreeOrFixed);
    FB_HuanJingObjParams.AddType(builder, Type);
    FB_HuanJingObjParams.AddId(builder, Id);
    return FB_HuanJingObjParams.EndFB_HuanJingObjParams(builder);
  }

  public static void StartFB_HuanJingObjParams(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddFreeOrFixed(FlatBufferBuilder builder, int FreeOrFixed) { builder.AddInt(2, FreeOrFixed, -1); }
  public static void AddDefaultFOV(FlatBufferBuilder builder, int DefaultFOV) { builder.AddInt(3, DefaultFOV, -1); }
  public static void AddResPath(FlatBufferBuilder builder, StringOffset ResPathOffset) { builder.AddOffset(4, ResPathOffset.Value, 0); }
  public static void AddModelPath(FlatBufferBuilder builder, StringOffset ModelPathOffset) { builder.AddOffset(5, ModelPathOffset.Value, 0); }
  public static Offset<FB_HuanJingObjParams> EndFB_HuanJingObjParams(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingObjParams>(o);
  }
};

public sealed class FB_HuanJingObjParamsContainer : Table {
  public static FB_HuanJingObjParamsContainer GetRootAsFB_HuanJingObjParamsContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingObjParamsContainer(_bb, new FB_HuanJingObjParamsContainer()); }
  public static FB_HuanJingObjParamsContainer GetRootAsFB_HuanJingObjParamsContainer(ByteBuffer _bb, FB_HuanJingObjParamsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingObjParamsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingObjParamsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingObjParams GetItems(int j) { return GetItems(new FB_HuanJingObjParams(), j); }
  public FB_HuanJingObjParams GetItems(FB_HuanJingObjParams obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingObjParamsContainer> CreateFB_HuanJingObjParamsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingObjParamsContainer.AddItems(builder, items);
    return FB_HuanJingObjParamsContainer.EndFB_HuanJingObjParamsContainer(builder);
  }

  public static void StartFB_HuanJingObjParamsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingObjParams>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingObjParamsContainer> EndFB_HuanJingObjParamsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingObjParamsContainer>(o);
  }
  public static void FinishFB_HuanJingObjParamsContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingObjParamsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
