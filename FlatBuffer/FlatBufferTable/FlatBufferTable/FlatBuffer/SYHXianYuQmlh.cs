// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHXianYuQmlh : Table {
  public static FB_SYHXianYuQmlh GetRootAsFB_SYHXianYuQmlh(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuQmlh(_bb, new FB_SYHXianYuQmlh()); }
  public static FB_SYHXianYuQmlh GetRootAsFB_SYHXianYuQmlh(ByteBuffer _bb, FB_SYHXianYuQmlh obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHXianYuQmlh __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScoreLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHXianYuQmlh> CreateFB_SYHXianYuQmlh(FlatBufferBuilder builder,
      int ID = 0,
      int ScoreLimit = -1,
      int DicId = -1) {
    builder.StartObject(3);
    FB_SYHXianYuQmlh.AddDicId(builder, DicId);
    FB_SYHXianYuQmlh.AddScoreLimit(builder, ScoreLimit);
    FB_SYHXianYuQmlh.AddID(builder, ID);
    return FB_SYHXianYuQmlh.EndFB_SYHXianYuQmlh(builder);
  }

  public static void StartFB_SYHXianYuQmlh(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScoreLimit(FlatBufferBuilder builder, int ScoreLimit) { builder.AddInt(1, ScoreLimit, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(2, DicId, -1); }
  public static Offset<FB_SYHXianYuQmlh> EndFB_SYHXianYuQmlh(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuQmlh>(o);
  }
};

public sealed class FB_SYHXianYuQmlhContainer : Table {
  public static FB_SYHXianYuQmlhContainer GetRootAsFB_SYHXianYuQmlhContainer(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuQmlhContainer(_bb, new FB_SYHXianYuQmlhContainer()); }
  public static FB_SYHXianYuQmlhContainer GetRootAsFB_SYHXianYuQmlhContainer(ByteBuffer _bb, FB_SYHXianYuQmlhContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHXianYuQmlhContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHXianYuQmlhContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHXianYuQmlh GetItems(int j) { return GetItems(new FB_SYHXianYuQmlh(), j); }
  public FB_SYHXianYuQmlh GetItems(FB_SYHXianYuQmlh obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianYuQmlhContainer> CreateFB_SYHXianYuQmlhContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHXianYuQmlhContainer.AddItems(builder, items);
    return FB_SYHXianYuQmlhContainer.EndFB_SYHXianYuQmlhContainer(builder);
  }

  public static void StartFB_SYHXianYuQmlhContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHXianYuQmlh>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianYuQmlhContainer> EndFB_SYHXianYuQmlhContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuQmlhContainer>(o);
  }
  public static void FinishFB_SYHXianYuQmlhContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHXianYuQmlhContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
