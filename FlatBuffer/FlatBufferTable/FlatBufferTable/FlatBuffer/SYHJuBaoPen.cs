// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJuBaoPen : Table {
  public static FB_SYHJuBaoPen GetRootAsFB_SYHJuBaoPen(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPen(_bb, new FB_SYHJuBaoPen()); }
  public static FB_SYHJuBaoPen GetRootAsFB_SYHJuBaoPen(ByteBuffer _bb, FB_SYHJuBaoPen obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJuBaoPen __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RMBId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetProbabilityList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ProbabilityListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRateList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RateListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoPen> CreateFB_SYHJuBaoPen(FlatBufferBuilder builder,
      int ID = 0,
      int RMBId = -1,
      VectorOffset ProbabilityList = default(VectorOffset),
      VectorOffset RateList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_SYHJuBaoPen.AddRateList(builder, RateList);
    FB_SYHJuBaoPen.AddProbabilityList(builder, ProbabilityList);
    FB_SYHJuBaoPen.AddRMBId(builder, RMBId);
    FB_SYHJuBaoPen.AddID(builder, ID);
    return FB_SYHJuBaoPen.EndFB_SYHJuBaoPen(builder);
  }

  public static void StartFB_SYHJuBaoPen(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRMBId(FlatBufferBuilder builder, int RMBId) { builder.AddInt(1, RMBId, -1); }
  public static void AddProbabilityList(FlatBufferBuilder builder, VectorOffset ProbabilityListOffset) { builder.AddOffset(2, ProbabilityListOffset.Value, 0); }
  public static VectorOffset CreateProbabilityListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartProbabilityListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRateList(FlatBufferBuilder builder, VectorOffset RateListOffset) { builder.AddOffset(3, RateListOffset.Value, 0); }
  public static VectorOffset CreateRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoPen> EndFB_SYHJuBaoPen(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPen>(o);
  }
};

public sealed class FB_SYHJuBaoPenContainer : Table {
  public static FB_SYHJuBaoPenContainer GetRootAsFB_SYHJuBaoPenContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPenContainer(_bb, new FB_SYHJuBaoPenContainer()); }
  public static FB_SYHJuBaoPenContainer GetRootAsFB_SYHJuBaoPenContainer(ByteBuffer _bb, FB_SYHJuBaoPenContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJuBaoPenContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJuBaoPenContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJuBaoPen GetItems(int j) { return GetItems(new FB_SYHJuBaoPen(), j); }
  public FB_SYHJuBaoPen GetItems(FB_SYHJuBaoPen obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoPenContainer> CreateFB_SYHJuBaoPenContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJuBaoPenContainer.AddItems(builder, items);
    return FB_SYHJuBaoPenContainer.EndFB_SYHJuBaoPenContainer(builder);
  }

  public static void StartFB_SYHJuBaoPenContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPen>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoPenContainer> EndFB_SYHJuBaoPenContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPenContainer>(o);
  }
  public static void FinishFB_SYHJuBaoPenContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPenContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
