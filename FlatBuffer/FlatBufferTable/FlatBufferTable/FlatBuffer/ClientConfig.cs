// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ClientConfig : Table {
  public static FB_ClientConfig GetRootAsFB_ClientConfig(ByteBuffer _bb) { return GetRootAsFB_ClientConfig(_bb, new FB_ClientConfig()); }
  public static FB_ClientConfig GetRootAsFB_ClientConfig(ByteBuffer _bb, FB_ClientConfig obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ClientConfig __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Param { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string StringParam { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_ClientConfig> CreateFB_ClientConfig(FlatBufferBuilder builder,
      int Id = 0,
      int Param = -1,
      StringOffset StringParam = default(StringOffset)) {
    builder.StartObject(3);
    FB_ClientConfig.AddStringParam(builder, StringParam);
    FB_ClientConfig.AddParam(builder, Param);
    FB_ClientConfig.AddId(builder, Id);
    return FB_ClientConfig.EndFB_ClientConfig(builder);
  }

  public static void StartFB_ClientConfig(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(1, Param, -1); }
  public static void AddStringParam(FlatBufferBuilder builder, StringOffset StringParamOffset) { builder.AddOffset(2, StringParamOffset.Value, 0); }
  public static Offset<FB_ClientConfig> EndFB_ClientConfig(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ClientConfig>(o);
  }
};

public sealed class FB_ClientConfigContainer : Table {
  public static FB_ClientConfigContainer GetRootAsFB_ClientConfigContainer(ByteBuffer _bb) { return GetRootAsFB_ClientConfigContainer(_bb, new FB_ClientConfigContainer()); }
  public static FB_ClientConfigContainer GetRootAsFB_ClientConfigContainer(ByteBuffer _bb, FB_ClientConfigContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ClientConfigContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ClientConfigContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ClientConfig GetItems(int j) { return GetItems(new FB_ClientConfig(), j); }
  public FB_ClientConfig GetItems(FB_ClientConfig obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ClientConfigContainer> CreateFB_ClientConfigContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ClientConfigContainer.AddItems(builder, items);
    return FB_ClientConfigContainer.EndFB_ClientConfigContainer(builder);
  }

  public static void StartFB_ClientConfigContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ClientConfig>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ClientConfigContainer> EndFB_ClientConfigContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ClientConfigContainer>(o);
  }
  public static void FinishFB_ClientConfigContainerBuffer(FlatBufferBuilder builder, Offset<FB_ClientConfigContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
