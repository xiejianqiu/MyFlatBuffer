// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JuhunBoxWeight : Table {
  public static FB_JuhunBoxWeight GetRootAsFB_JuhunBoxWeight(ByteBuffer _bb) { return GetRootAsFB_JuhunBoxWeight(_bb, new FB_JuhunBoxWeight()); }
  public static FB_JuhunBoxWeight GetRootAsFB_JuhunBoxWeight(ByteBuffer _bb, FB_JuhunBoxWeight obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JuhunBoxWeight __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWeightList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuhunBoxWeight> CreateFB_JuhunBoxWeight(FlatBufferBuilder builder,
      int ID = 0,
      int UnLockLevel = -1,
      VectorOffset WeightList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_JuhunBoxWeight.AddWeightList(builder, WeightList);
    FB_JuhunBoxWeight.AddUnLockLevel(builder, UnLockLevel);
    FB_JuhunBoxWeight.AddID(builder, ID);
    return FB_JuhunBoxWeight.EndFB_JuhunBoxWeight(builder);
  }

  public static void StartFB_JuhunBoxWeight(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(1, UnLockLevel, -1); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(2, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuhunBoxWeight> EndFB_JuhunBoxWeight(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuhunBoxWeight>(o);
  }
};

public sealed class FB_JuhunBoxWeightContainer : Table {
  public static FB_JuhunBoxWeightContainer GetRootAsFB_JuhunBoxWeightContainer(ByteBuffer _bb) { return GetRootAsFB_JuhunBoxWeightContainer(_bb, new FB_JuhunBoxWeightContainer()); }
  public static FB_JuhunBoxWeightContainer GetRootAsFB_JuhunBoxWeightContainer(ByteBuffer _bb, FB_JuhunBoxWeightContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JuhunBoxWeightContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JuhunBoxWeightContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JuhunBoxWeight GetItems(int j) { return GetItems(new FB_JuhunBoxWeight(), j); }
  public FB_JuhunBoxWeight GetItems(FB_JuhunBoxWeight obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuhunBoxWeightContainer> CreateFB_JuhunBoxWeightContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JuhunBoxWeightContainer.AddItems(builder, items);
    return FB_JuhunBoxWeightContainer.EndFB_JuhunBoxWeightContainer(builder);
  }

  public static void StartFB_JuhunBoxWeightContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JuhunBoxWeight>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuhunBoxWeightContainer> EndFB_JuhunBoxWeightContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuhunBoxWeightContainer>(o);
  }
  public static void FinishFB_JuhunBoxWeightContainerBuffer(FlatBufferBuilder builder, Offset<FB_JuhunBoxWeightContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
