// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CardXunBaoShow : Table {
  public static FB_CardXunBaoShow GetRootAsFB_CardXunBaoShow(ByteBuffer _bb) { return GetRootAsFB_CardXunBaoShow(_bb, new FB_CardXunBaoShow()); }
  public static FB_CardXunBaoShow GetRootAsFB_CardXunBaoShow(ByteBuffer _bb, FB_CardXunBaoShow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CardXunBaoShow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CardType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CardShow { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CardXunBaoShow> CreateFB_CardXunBaoShow(FlatBufferBuilder builder,
      int ID = 0,
      int CardType = -1,
      int CardShow = -1) {
    builder.StartObject(3);
    FB_CardXunBaoShow.AddCardShow(builder, CardShow);
    FB_CardXunBaoShow.AddCardType(builder, CardType);
    FB_CardXunBaoShow.AddID(builder, ID);
    return FB_CardXunBaoShow.EndFB_CardXunBaoShow(builder);
  }

  public static void StartFB_CardXunBaoShow(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCardType(FlatBufferBuilder builder, int CardType) { builder.AddInt(1, CardType, -1); }
  public static void AddCardShow(FlatBufferBuilder builder, int CardShow) { builder.AddInt(2, CardShow, -1); }
  public static Offset<FB_CardXunBaoShow> EndFB_CardXunBaoShow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardXunBaoShow>(o);
  }
};

public sealed class FB_CardXunBaoShowContainer : Table {
  public static FB_CardXunBaoShowContainer GetRootAsFB_CardXunBaoShowContainer(ByteBuffer _bb) { return GetRootAsFB_CardXunBaoShowContainer(_bb, new FB_CardXunBaoShowContainer()); }
  public static FB_CardXunBaoShowContainer GetRootAsFB_CardXunBaoShowContainer(ByteBuffer _bb, FB_CardXunBaoShowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CardXunBaoShowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CardXunBaoShowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CardXunBaoShow GetItems(int j) { return GetItems(new FB_CardXunBaoShow(), j); }
  public FB_CardXunBaoShow GetItems(FB_CardXunBaoShow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardXunBaoShowContainer> CreateFB_CardXunBaoShowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CardXunBaoShowContainer.AddItems(builder, items);
    return FB_CardXunBaoShowContainer.EndFB_CardXunBaoShowContainer(builder);
  }

  public static void StartFB_CardXunBaoShowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CardXunBaoShow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardXunBaoShowContainer> EndFB_CardXunBaoShowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardXunBaoShowContainer>(o);
  }
  public static void FinishFB_CardXunBaoShowContainerBuffer(FlatBufferBuilder builder, Offset<FB_CardXunBaoShowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
