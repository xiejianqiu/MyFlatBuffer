// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GoldCopyAward : Table {
  public static FB_GoldCopyAward GetRootAsFB_GoldCopyAward(ByteBuffer _bb) { return GetRootAsFB_GoldCopyAward(_bb, new FB_GoldCopyAward()); }
  public static FB_GoldCopyAward GetRootAsFB_GoldCopyAward(ByteBuffer _bb, FB_GoldCopyAward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GoldCopyAward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DicId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GoldCopyAward> CreateFB_GoldCopyAward(FlatBufferBuilder builder,
      int ID = 0,
      int DicId = -1,
      int ItemNum = -1) {
    builder.StartObject(3);
    FB_GoldCopyAward.AddItemNum(builder, ItemNum);
    FB_GoldCopyAward.AddDicId(builder, DicId);
    FB_GoldCopyAward.AddID(builder, ID);
    return FB_GoldCopyAward.EndFB_GoldCopyAward(builder);
  }

  public static void StartFB_GoldCopyAward(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(1, DicId, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(2, ItemNum, -1); }
  public static Offset<FB_GoldCopyAward> EndFB_GoldCopyAward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GoldCopyAward>(o);
  }
};

public sealed class FB_GoldCopyAwardContainer : Table {
  public static FB_GoldCopyAwardContainer GetRootAsFB_GoldCopyAwardContainer(ByteBuffer _bb) { return GetRootAsFB_GoldCopyAwardContainer(_bb, new FB_GoldCopyAwardContainer()); }
  public static FB_GoldCopyAwardContainer GetRootAsFB_GoldCopyAwardContainer(ByteBuffer _bb, FB_GoldCopyAwardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GoldCopyAwardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GoldCopyAwardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GoldCopyAward GetItems(int j) { return GetItems(new FB_GoldCopyAward(), j); }
  public FB_GoldCopyAward GetItems(FB_GoldCopyAward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GoldCopyAwardContainer> CreateFB_GoldCopyAwardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GoldCopyAwardContainer.AddItems(builder, items);
    return FB_GoldCopyAwardContainer.EndFB_GoldCopyAwardContainer(builder);
  }

  public static void StartFB_GoldCopyAwardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GoldCopyAward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GoldCopyAwardContainer> EndFB_GoldCopyAwardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GoldCopyAwardContainer>(o);
  }
  public static void FinishFB_GoldCopyAwardContainerBuffer(FlatBufferBuilder builder, Offset<FB_GoldCopyAwardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
