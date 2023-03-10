// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_UISubPanelPath : Table {
  public static FB_UISubPanelPath GetRootAsFB_UISubPanelPath(ByteBuffer _bb) { return GetRootAsFB_UISubPanelPath(_bb, new FB_UISubPanelPath()); }
  public static FB_UISubPanelPath GetRootAsFB_UISubPanelPath(ByteBuffer _bb, FB_UISubPanelPath obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_UISubPanelPath __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Path { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_UISubPanelPath> CreateFB_UISubPanelPath(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Path = default(StringOffset)) {
    builder.StartObject(2);
    FB_UISubPanelPath.AddPath(builder, Path);
    FB_UISubPanelPath.AddID(builder, ID);
    return FB_UISubPanelPath.EndFB_UISubPanelPath(builder);
  }

  public static void StartFB_UISubPanelPath(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(1, PathOffset.Value, 0); }
  public static Offset<FB_UISubPanelPath> EndFB_UISubPanelPath(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UISubPanelPath>(o);
  }
};

public sealed class FB_UISubPanelPathContainer : Table {
  public static FB_UISubPanelPathContainer GetRootAsFB_UISubPanelPathContainer(ByteBuffer _bb) { return GetRootAsFB_UISubPanelPathContainer(_bb, new FB_UISubPanelPathContainer()); }
  public static FB_UISubPanelPathContainer GetRootAsFB_UISubPanelPathContainer(ByteBuffer _bb, FB_UISubPanelPathContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_UISubPanelPathContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_UISubPanelPathContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_UISubPanelPath GetItems(int j) { return GetItems(new FB_UISubPanelPath(), j); }
  public FB_UISubPanelPath GetItems(FB_UISubPanelPath obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_UISubPanelPathContainer> CreateFB_UISubPanelPathContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_UISubPanelPathContainer.AddItems(builder, items);
    return FB_UISubPanelPathContainer.EndFB_UISubPanelPathContainer(builder);
  }

  public static void StartFB_UISubPanelPathContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_UISubPanelPath>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_UISubPanelPathContainer> EndFB_UISubPanelPathContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UISubPanelPathContainer>(o);
  }
  public static void FinishFB_UISubPanelPathContainerBuffer(FlatBufferBuilder builder, Offset<FB_UISubPanelPathContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
