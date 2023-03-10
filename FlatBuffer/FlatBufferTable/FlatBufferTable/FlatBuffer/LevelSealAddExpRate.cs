// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LevelSealAddExpRate : Table {
  public static FB_LevelSealAddExpRate GetRootAsFB_LevelSealAddExpRate(ByteBuffer _bb) { return GetRootAsFB_LevelSealAddExpRate(_bb, new FB_LevelSealAddExpRate()); }
  public static FB_LevelSealAddExpRate GetRootAsFB_LevelSealAddExpRate(ByteBuffer _bb, FB_LevelSealAddExpRate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LevelSealAddExpRate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EpxAttr { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LevelSealAddExpRate> CreateFB_LevelSealAddExpRate(FlatBufferBuilder builder,
      int ID = 0,
      int EpxAttr = -1) {
    builder.StartObject(2);
    FB_LevelSealAddExpRate.AddEpxAttr(builder, EpxAttr);
    FB_LevelSealAddExpRate.AddID(builder, ID);
    return FB_LevelSealAddExpRate.EndFB_LevelSealAddExpRate(builder);
  }

  public static void StartFB_LevelSealAddExpRate(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddEpxAttr(FlatBufferBuilder builder, int EpxAttr) { builder.AddInt(1, EpxAttr, -1); }
  public static Offset<FB_LevelSealAddExpRate> EndFB_LevelSealAddExpRate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealAddExpRate>(o);
  }
};

public sealed class FB_LevelSealAddExpRateContainer : Table {
  public static FB_LevelSealAddExpRateContainer GetRootAsFB_LevelSealAddExpRateContainer(ByteBuffer _bb) { return GetRootAsFB_LevelSealAddExpRateContainer(_bb, new FB_LevelSealAddExpRateContainer()); }
  public static FB_LevelSealAddExpRateContainer GetRootAsFB_LevelSealAddExpRateContainer(ByteBuffer _bb, FB_LevelSealAddExpRateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LevelSealAddExpRateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LevelSealAddExpRateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LevelSealAddExpRate GetItems(int j) { return GetItems(new FB_LevelSealAddExpRate(), j); }
  public FB_LevelSealAddExpRate GetItems(FB_LevelSealAddExpRate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelSealAddExpRateContainer> CreateFB_LevelSealAddExpRateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LevelSealAddExpRateContainer.AddItems(builder, items);
    return FB_LevelSealAddExpRateContainer.EndFB_LevelSealAddExpRateContainer(builder);
  }

  public static void StartFB_LevelSealAddExpRateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LevelSealAddExpRate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelSealAddExpRateContainer> EndFB_LevelSealAddExpRateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealAddExpRateContainer>(o);
  }
  public static void FinishFB_LevelSealAddExpRateContainerBuffer(FlatBufferBuilder builder, Offset<FB_LevelSealAddExpRateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
