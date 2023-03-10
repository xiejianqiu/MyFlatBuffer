// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_VIPLimit : Table {
  public static FB_VIPLimit GetRootAsFB_VIPLimit(ByteBuffer _bb) { return GetRootAsFB_VIPLimit(_bb, new FB_VIPLimit()); }
  public static FB_VIPLimit GetRootAsFB_VIPLimit(ByteBuffer _bb, FB_VIPLimit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_VIPLimit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetVIPList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int VIPListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VIPLimit> CreateFB_VIPLimit(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset VIPList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_VIPLimit.AddVIPList(builder, VIPList);
    FB_VIPLimit.AddID(builder, ID);
    return FB_VIPLimit.EndFB_VIPLimit(builder);
  }

  public static void StartFB_VIPLimit(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddVIPList(FlatBufferBuilder builder, VectorOffset VIPListOffset) { builder.AddOffset(1, VIPListOffset.Value, 0); }
  public static VectorOffset CreateVIPListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartVIPListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VIPLimit> EndFB_VIPLimit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VIPLimit>(o);
  }
};

public sealed class FB_VIPLimitContainer : Table {
  public static FB_VIPLimitContainer GetRootAsFB_VIPLimitContainer(ByteBuffer _bb) { return GetRootAsFB_VIPLimitContainer(_bb, new FB_VIPLimitContainer()); }
  public static FB_VIPLimitContainer GetRootAsFB_VIPLimitContainer(ByteBuffer _bb, FB_VIPLimitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_VIPLimitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_VIPLimitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_VIPLimit GetItems(int j) { return GetItems(new FB_VIPLimit(), j); }
  public FB_VIPLimit GetItems(FB_VIPLimit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VIPLimitContainer> CreateFB_VIPLimitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_VIPLimitContainer.AddItems(builder, items);
    return FB_VIPLimitContainer.EndFB_VIPLimitContainer(builder);
  }

  public static void StartFB_VIPLimitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_VIPLimit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VIPLimitContainer> EndFB_VIPLimitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VIPLimitContainer>(o);
  }
  public static void FinishFB_VIPLimitContainerBuffer(FlatBufferBuilder builder, Offset<FB_VIPLimitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
