// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StrengthenRate : Table {
  public static FB_StrengthenRate GetRootAsFB_StrengthenRate(ByteBuffer _bb) { return GetRootAsFB_StrengthenRate(_bb, new FB_StrengthenRate()); }
  public static FB_StrengthenRate GetRootAsFB_StrengthenRate(ByteBuffer _bb, FB_StrengthenRate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StrengthenRate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRateList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RateListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrengthenRate> CreateFB_StrengthenRate(FlatBufferBuilder builder,
      int ID = 0,
      int Level = -1,
      VectorOffset RateList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_StrengthenRate.AddRateList(builder, RateList);
    FB_StrengthenRate.AddLevel(builder, Level);
    FB_StrengthenRate.AddID(builder, ID);
    return FB_StrengthenRate.EndFB_StrengthenRate(builder);
  }

  public static void StartFB_StrengthenRate(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, -1); }
  public static void AddRateList(FlatBufferBuilder builder, VectorOffset RateListOffset) { builder.AddOffset(2, RateListOffset.Value, 0); }
  public static VectorOffset CreateRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrengthenRate> EndFB_StrengthenRate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenRate>(o);
  }
};

public sealed class FB_StrengthenRateContainer : Table {
  public static FB_StrengthenRateContainer GetRootAsFB_StrengthenRateContainer(ByteBuffer _bb) { return GetRootAsFB_StrengthenRateContainer(_bb, new FB_StrengthenRateContainer()); }
  public static FB_StrengthenRateContainer GetRootAsFB_StrengthenRateContainer(ByteBuffer _bb, FB_StrengthenRateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StrengthenRateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StrengthenRateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StrengthenRate GetItems(int j) { return GetItems(new FB_StrengthenRate(), j); }
  public FB_StrengthenRate GetItems(FB_StrengthenRate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrengthenRateContainer> CreateFB_StrengthenRateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StrengthenRateContainer.AddItems(builder, items);
    return FB_StrengthenRateContainer.EndFB_StrengthenRateContainer(builder);
  }

  public static void StartFB_StrengthenRateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StrengthenRate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrengthenRateContainer> EndFB_StrengthenRateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenRateContainer>(o);
  }
  public static void FinishFB_StrengthenRateContainerBuffer(FlatBufferBuilder builder, Offset<FB_StrengthenRateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
