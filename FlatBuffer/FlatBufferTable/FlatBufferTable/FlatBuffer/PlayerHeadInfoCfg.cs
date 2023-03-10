// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PlayerHeadInfoCfg : Table {
  public static FB_PlayerHeadInfoCfg GetRootAsFB_PlayerHeadInfoCfg(ByteBuffer _bb) { return GetRootAsFB_PlayerHeadInfoCfg(_bb, new FB_PlayerHeadInfoCfg()); }
  public static FB_PlayerHeadInfoCfg GetRootAsFB_PlayerHeadInfoCfg(ByteBuffer _bb, FB_PlayerHeadInfoCfg obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PlayerHeadInfoCfg __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Height { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PlayerHeadInfoCfg> CreateFB_PlayerHeadInfoCfg(FlatBufferBuilder builder,
      int Id = 0,
      int Height = -1) {
    builder.StartObject(2);
    FB_PlayerHeadInfoCfg.AddHeight(builder, Height);
    FB_PlayerHeadInfoCfg.AddId(builder, Id);
    return FB_PlayerHeadInfoCfg.EndFB_PlayerHeadInfoCfg(builder);
  }

  public static void StartFB_PlayerHeadInfoCfg(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddHeight(FlatBufferBuilder builder, int Height) { builder.AddInt(1, Height, -1); }
  public static Offset<FB_PlayerHeadInfoCfg> EndFB_PlayerHeadInfoCfg(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerHeadInfoCfg>(o);
  }
};

public sealed class FB_PlayerHeadInfoCfgContainer : Table {
  public static FB_PlayerHeadInfoCfgContainer GetRootAsFB_PlayerHeadInfoCfgContainer(ByteBuffer _bb) { return GetRootAsFB_PlayerHeadInfoCfgContainer(_bb, new FB_PlayerHeadInfoCfgContainer()); }
  public static FB_PlayerHeadInfoCfgContainer GetRootAsFB_PlayerHeadInfoCfgContainer(ByteBuffer _bb, FB_PlayerHeadInfoCfgContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PlayerHeadInfoCfgContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PlayerHeadInfoCfgContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PlayerHeadInfoCfg GetItems(int j) { return GetItems(new FB_PlayerHeadInfoCfg(), j); }
  public FB_PlayerHeadInfoCfg GetItems(FB_PlayerHeadInfoCfg obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerHeadInfoCfgContainer> CreateFB_PlayerHeadInfoCfgContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PlayerHeadInfoCfgContainer.AddItems(builder, items);
    return FB_PlayerHeadInfoCfgContainer.EndFB_PlayerHeadInfoCfgContainer(builder);
  }

  public static void StartFB_PlayerHeadInfoCfgContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PlayerHeadInfoCfg>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerHeadInfoCfgContainer> EndFB_PlayerHeadInfoCfgContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerHeadInfoCfgContainer>(o);
  }
  public static void FinishFB_PlayerHeadInfoCfgContainerBuffer(FlatBufferBuilder builder, Offset<FB_PlayerHeadInfoCfgContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
