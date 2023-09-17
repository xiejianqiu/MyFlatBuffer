// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PlayMethodBroadcast : Table {
  public static FB_PlayMethodBroadcast GetRootAsFB_PlayMethodBroadcast(ByteBuffer _bb) { return GetRootAsFB_PlayMethodBroadcast(_bb, new FB_PlayMethodBroadcast()); }
  public static FB_PlayMethodBroadcast GetRootAsFB_PlayMethodBroadcast(ByteBuffer _bb, FB_PlayMethodBroadcast obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PlayMethodBroadcast __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrDic { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLvl { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLvl { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PlayMethodBroadcast> CreateFB_PlayMethodBroadcast(FlatBufferBuilder builder,
      int ID = 0,
      int StrDic = -1,
      int MinLvl = -1,
      int MaxLvl = -1) {
    builder.StartObject(4);
    FB_PlayMethodBroadcast.AddMaxLvl(builder, MaxLvl);
    FB_PlayMethodBroadcast.AddMinLvl(builder, MinLvl);
    FB_PlayMethodBroadcast.AddStrDic(builder, StrDic);
    FB_PlayMethodBroadcast.AddID(builder, ID);
    return FB_PlayMethodBroadcast.EndFB_PlayMethodBroadcast(builder);
  }

  public static void StartFB_PlayMethodBroadcast(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStrDic(FlatBufferBuilder builder, int StrDic) { builder.AddInt(1, StrDic, -1); }
  public static void AddMinLvl(FlatBufferBuilder builder, int MinLvl) { builder.AddInt(2, MinLvl, -1); }
  public static void AddMaxLvl(FlatBufferBuilder builder, int MaxLvl) { builder.AddInt(3, MaxLvl, -1); }
  public static Offset<FB_PlayMethodBroadcast> EndFB_PlayMethodBroadcast(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayMethodBroadcast>(o);
  }
};

public sealed class FB_PlayMethodBroadcastContainer : Table {
  public static FB_PlayMethodBroadcastContainer GetRootAsFB_PlayMethodBroadcastContainer(ByteBuffer _bb) { return GetRootAsFB_PlayMethodBroadcastContainer(_bb, new FB_PlayMethodBroadcastContainer()); }
  public static FB_PlayMethodBroadcastContainer GetRootAsFB_PlayMethodBroadcastContainer(ByteBuffer _bb, FB_PlayMethodBroadcastContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PlayMethodBroadcastContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PlayMethodBroadcastContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PlayMethodBroadcast GetItems(int j) { return GetItems(new FB_PlayMethodBroadcast(), j); }
  public FB_PlayMethodBroadcast GetItems(FB_PlayMethodBroadcast obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayMethodBroadcastContainer> CreateFB_PlayMethodBroadcastContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PlayMethodBroadcastContainer.AddItems(builder, items);
    return FB_PlayMethodBroadcastContainer.EndFB_PlayMethodBroadcastContainer(builder);
  }

  public static void StartFB_PlayMethodBroadcastContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PlayMethodBroadcast>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayMethodBroadcastContainer> EndFB_PlayMethodBroadcastContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayMethodBroadcastContainer>(o);
  }
  public static void FinishFB_PlayMethodBroadcastContainerBuffer(FlatBufferBuilder builder, Offset<FB_PlayMethodBroadcastContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
