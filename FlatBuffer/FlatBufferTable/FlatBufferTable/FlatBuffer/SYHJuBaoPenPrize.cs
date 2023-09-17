// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJuBaoPenPrize : Table {
  public static FB_SYHJuBaoPenPrize GetRootAsFB_SYHJuBaoPenPrize(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPenPrize(_bb, new FB_SYHJuBaoPenPrize()); }
  public static FB_SYHJuBaoPenPrize GetRootAsFB_SYHJuBaoPenPrize(ByteBuffer _bb, FB_SYHJuBaoPenPrize obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJuBaoPenPrize __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DayLeast { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DayMax { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Prize { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHJuBaoPenPrize> CreateFB_SYHJuBaoPenPrize(FlatBufferBuilder builder,
      int ID = 0,
      int DayLeast = -1,
      int DayMax = -1,
      int Prize = -1) {
    builder.StartObject(4);
    FB_SYHJuBaoPenPrize.AddPrize(builder, Prize);
    FB_SYHJuBaoPenPrize.AddDayMax(builder, DayMax);
    FB_SYHJuBaoPenPrize.AddDayLeast(builder, DayLeast);
    FB_SYHJuBaoPenPrize.AddID(builder, ID);
    return FB_SYHJuBaoPenPrize.EndFB_SYHJuBaoPenPrize(builder);
  }

  public static void StartFB_SYHJuBaoPenPrize(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDayLeast(FlatBufferBuilder builder, int DayLeast) { builder.AddInt(1, DayLeast, -1); }
  public static void AddDayMax(FlatBufferBuilder builder, int DayMax) { builder.AddInt(2, DayMax, -1); }
  public static void AddPrize(FlatBufferBuilder builder, int Prize) { builder.AddInt(3, Prize, -1); }
  public static Offset<FB_SYHJuBaoPenPrize> EndFB_SYHJuBaoPenPrize(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPenPrize>(o);
  }
};

public sealed class FB_SYHJuBaoPenPrizeContainer : Table {
  public static FB_SYHJuBaoPenPrizeContainer GetRootAsFB_SYHJuBaoPenPrizeContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPenPrizeContainer(_bb, new FB_SYHJuBaoPenPrizeContainer()); }
  public static FB_SYHJuBaoPenPrizeContainer GetRootAsFB_SYHJuBaoPenPrizeContainer(ByteBuffer _bb, FB_SYHJuBaoPenPrizeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJuBaoPenPrizeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJuBaoPenPrizeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJuBaoPenPrize GetItems(int j) { return GetItems(new FB_SYHJuBaoPenPrize(), j); }
  public FB_SYHJuBaoPenPrize GetItems(FB_SYHJuBaoPenPrize obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoPenPrizeContainer> CreateFB_SYHJuBaoPenPrizeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJuBaoPenPrizeContainer.AddItems(builder, items);
    return FB_SYHJuBaoPenPrizeContainer.EndFB_SYHJuBaoPenPrizeContainer(builder);
  }

  public static void StartFB_SYHJuBaoPenPrizeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPenPrize>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoPenPrizeContainer> EndFB_SYHJuBaoPenPrizeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPenPrizeContainer>(o);
  }
  public static void FinishFB_SYHJuBaoPenPrizeContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPenPrizeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
