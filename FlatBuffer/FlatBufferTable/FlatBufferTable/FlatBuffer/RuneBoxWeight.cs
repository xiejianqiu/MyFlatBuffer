// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RuneBoxWeight : Table {
  public static FB_RuneBoxWeight GetRootAsFB_RuneBoxWeight(ByteBuffer _bb) { return GetRootAsFB_RuneBoxWeight(_bb, new FB_RuneBoxWeight()); }
  public static FB_RuneBoxWeight GetRootAsFB_RuneBoxWeight(ByteBuffer _bb, FB_RuneBoxWeight obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RuneBoxWeight __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockTowerId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWeightList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RuneBoxWeight> CreateFB_RuneBoxWeight(FlatBufferBuilder builder,
      int ID = 0,
      int UnLockTowerId = -1,
      VectorOffset WeightList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_RuneBoxWeight.AddWeightList(builder, WeightList);
    FB_RuneBoxWeight.AddUnLockTowerId(builder, UnLockTowerId);
    FB_RuneBoxWeight.AddID(builder, ID);
    return FB_RuneBoxWeight.EndFB_RuneBoxWeight(builder);
  }

  public static void StartFB_RuneBoxWeight(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddUnLockTowerId(FlatBufferBuilder builder, int UnLockTowerId) { builder.AddInt(1, UnLockTowerId, -1); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(2, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RuneBoxWeight> EndFB_RuneBoxWeight(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneBoxWeight>(o);
  }
};

public sealed class FB_RuneBoxWeightContainer : Table {
  public static FB_RuneBoxWeightContainer GetRootAsFB_RuneBoxWeightContainer(ByteBuffer _bb) { return GetRootAsFB_RuneBoxWeightContainer(_bb, new FB_RuneBoxWeightContainer()); }
  public static FB_RuneBoxWeightContainer GetRootAsFB_RuneBoxWeightContainer(ByteBuffer _bb, FB_RuneBoxWeightContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RuneBoxWeightContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RuneBoxWeightContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RuneBoxWeight GetItems(int j) { return GetItems(new FB_RuneBoxWeight(), j); }
  public FB_RuneBoxWeight GetItems(FB_RuneBoxWeight obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RuneBoxWeightContainer> CreateFB_RuneBoxWeightContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RuneBoxWeightContainer.AddItems(builder, items);
    return FB_RuneBoxWeightContainer.EndFB_RuneBoxWeightContainer(builder);
  }

  public static void StartFB_RuneBoxWeightContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RuneBoxWeight>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RuneBoxWeightContainer> EndFB_RuneBoxWeightContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneBoxWeightContainer>(o);
  }
  public static void FinishFB_RuneBoxWeightContainerBuffer(FlatBufferBuilder builder, Offset<FB_RuneBoxWeightContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
