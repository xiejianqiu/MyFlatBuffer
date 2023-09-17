// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarCraftSet : Table {
  public static FB_StarCraftSet GetRootAsFB_StarCraftSet(ByteBuffer _bb) { return GetRootAsFB_StarCraftSet(_bb, new FB_StarCraftSet()); }
  public static FB_StarCraftSet GetRootAsFB_StarCraftSet(ByteBuffer _bb, FB_StarCraftSet obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarCraftSet __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LeftLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RightLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UpLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DownLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Star0Num { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Star1Num { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Star2Num { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Star3Num { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Star4Num { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StarCraftSet> CreateFB_StarCraftSet(FlatBufferBuilder builder,
      int ID = 0,
      int LeftLimit = -1,
      int RightLimit = -1,
      int UpLimit = -1,
      int DownLimit = -1,
      int Star0Num = -1,
      int Star1Num = -1,
      int Star2Num = -1,
      int Star3Num = -1,
      int Star4Num = -1) {
    builder.StartObject(10);
    FB_StarCraftSet.AddStar4Num(builder, Star4Num);
    FB_StarCraftSet.AddStar3Num(builder, Star3Num);
    FB_StarCraftSet.AddStar2Num(builder, Star2Num);
    FB_StarCraftSet.AddStar1Num(builder, Star1Num);
    FB_StarCraftSet.AddStar0Num(builder, Star0Num);
    FB_StarCraftSet.AddDownLimit(builder, DownLimit);
    FB_StarCraftSet.AddUpLimit(builder, UpLimit);
    FB_StarCraftSet.AddRightLimit(builder, RightLimit);
    FB_StarCraftSet.AddLeftLimit(builder, LeftLimit);
    FB_StarCraftSet.AddID(builder, ID);
    return FB_StarCraftSet.EndFB_StarCraftSet(builder);
  }

  public static void StartFB_StarCraftSet(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLeftLimit(FlatBufferBuilder builder, int LeftLimit) { builder.AddInt(1, LeftLimit, -1); }
  public static void AddRightLimit(FlatBufferBuilder builder, int RightLimit) { builder.AddInt(2, RightLimit, -1); }
  public static void AddUpLimit(FlatBufferBuilder builder, int UpLimit) { builder.AddInt(3, UpLimit, -1); }
  public static void AddDownLimit(FlatBufferBuilder builder, int DownLimit) { builder.AddInt(4, DownLimit, -1); }
  public static void AddStar0Num(FlatBufferBuilder builder, int Star0Num) { builder.AddInt(5, Star0Num, -1); }
  public static void AddStar1Num(FlatBufferBuilder builder, int Star1Num) { builder.AddInt(6, Star1Num, -1); }
  public static void AddStar2Num(FlatBufferBuilder builder, int Star2Num) { builder.AddInt(7, Star2Num, -1); }
  public static void AddStar3Num(FlatBufferBuilder builder, int Star3Num) { builder.AddInt(8, Star3Num, -1); }
  public static void AddStar4Num(FlatBufferBuilder builder, int Star4Num) { builder.AddInt(9, Star4Num, -1); }
  public static Offset<FB_StarCraftSet> EndFB_StarCraftSet(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftSet>(o);
  }
};

public sealed class FB_StarCraftSetContainer : Table {
  public static FB_StarCraftSetContainer GetRootAsFB_StarCraftSetContainer(ByteBuffer _bb) { return GetRootAsFB_StarCraftSetContainer(_bb, new FB_StarCraftSetContainer()); }
  public static FB_StarCraftSetContainer GetRootAsFB_StarCraftSetContainer(ByteBuffer _bb, FB_StarCraftSetContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarCraftSetContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarCraftSetContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarCraftSet GetItems(int j) { return GetItems(new FB_StarCraftSet(), j); }
  public FB_StarCraftSet GetItems(FB_StarCraftSet obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarCraftSetContainer> CreateFB_StarCraftSetContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarCraftSetContainer.AddItems(builder, items);
    return FB_StarCraftSetContainer.EndFB_StarCraftSetContainer(builder);
  }

  public static void StartFB_StarCraftSetContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarCraftSet>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarCraftSetContainer> EndFB_StarCraftSetContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftSetContainer>(o);
  }
  public static void FinishFB_StarCraftSetContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarCraftSetContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
