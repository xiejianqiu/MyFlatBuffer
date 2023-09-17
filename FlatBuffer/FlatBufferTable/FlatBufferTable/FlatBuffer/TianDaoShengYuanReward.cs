// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TianDaoShengYuanReward : Table {
  public static FB_TianDaoShengYuanReward GetRootAsFB_TianDaoShengYuanReward(ByteBuffer _bb) { return GetRootAsFB_TianDaoShengYuanReward(_bb, new FB_TianDaoShengYuanReward()); }
  public static FB_TianDaoShengYuanReward GetRootAsFB_TianDaoShengYuanReward(ByteBuffer _bb, FB_TianDaoShengYuanReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TianDaoShengYuanReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int HighDropBox { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowDropBox { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SystemShoutId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TianDaoShengYuanReward> CreateFB_TianDaoShengYuanReward(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int HighDropBox = -1,
      int LowDropBox = -1,
      int SystemShoutId = -1) {
    builder.StartObject(6);
    FB_TianDaoShengYuanReward.AddSystemShoutId(builder, SystemShoutId);
    FB_TianDaoShengYuanReward.AddLowDropBox(builder, LowDropBox);
    FB_TianDaoShengYuanReward.AddHighDropBox(builder, HighDropBox);
    FB_TianDaoShengYuanReward.AddItemNumList(builder, ItemNumList);
    FB_TianDaoShengYuanReward.AddItemIDList(builder, ItemIDList);
    FB_TianDaoShengYuanReward.AddID(builder, ID);
    return FB_TianDaoShengYuanReward.EndFB_TianDaoShengYuanReward(builder);
  }

  public static void StartFB_TianDaoShengYuanReward(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(1, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(2, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighDropBox(FlatBufferBuilder builder, int HighDropBox) { builder.AddInt(3, HighDropBox, -1); }
  public static void AddLowDropBox(FlatBufferBuilder builder, int LowDropBox) { builder.AddInt(4, LowDropBox, -1); }
  public static void AddSystemShoutId(FlatBufferBuilder builder, int SystemShoutId) { builder.AddInt(5, SystemShoutId, -1); }
  public static Offset<FB_TianDaoShengYuanReward> EndFB_TianDaoShengYuanReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianDaoShengYuanReward>(o);
  }
};

public sealed class FB_TianDaoShengYuanRewardContainer : Table {
  public static FB_TianDaoShengYuanRewardContainer GetRootAsFB_TianDaoShengYuanRewardContainer(ByteBuffer _bb) { return GetRootAsFB_TianDaoShengYuanRewardContainer(_bb, new FB_TianDaoShengYuanRewardContainer()); }
  public static FB_TianDaoShengYuanRewardContainer GetRootAsFB_TianDaoShengYuanRewardContainer(ByteBuffer _bb, FB_TianDaoShengYuanRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TianDaoShengYuanRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TianDaoShengYuanRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TianDaoShengYuanReward GetItems(int j) { return GetItems(new FB_TianDaoShengYuanReward(), j); }
  public FB_TianDaoShengYuanReward GetItems(FB_TianDaoShengYuanReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianDaoShengYuanRewardContainer> CreateFB_TianDaoShengYuanRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TianDaoShengYuanRewardContainer.AddItems(builder, items);
    return FB_TianDaoShengYuanRewardContainer.EndFB_TianDaoShengYuanRewardContainer(builder);
  }

  public static void StartFB_TianDaoShengYuanRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TianDaoShengYuanReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianDaoShengYuanRewardContainer> EndFB_TianDaoShengYuanRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianDaoShengYuanRewardContainer>(o);
  }
  public static void FinishFB_TianDaoShengYuanRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_TianDaoShengYuanRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
