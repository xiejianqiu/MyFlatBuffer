// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJuBaoFuDaiReward : Table {
  public static FB_SYHJuBaoFuDaiReward GetRootAsFB_SYHJuBaoFuDaiReward(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoFuDaiReward(_bb, new FB_SYHJuBaoFuDaiReward()); }
  public static FB_SYHJuBaoFuDaiReward GetRootAsFB_SYHJuBaoFuDaiReward(ByteBuffer _bb, FB_SYHJuBaoFuDaiReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJuBaoFuDaiReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Tips { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int RechargeTimes { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemRateList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemRateListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoFuDaiReward> CreateFB_SYHJuBaoFuDaiReward(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Tips = default(StringOffset),
      int RechargeTimes = -1,
      VectorOffset ItemID_List = default(VectorOffset),
      VectorOffset ItemRate_List = default(VectorOffset)) {
    builder.StartObject(5);
    FB_SYHJuBaoFuDaiReward.AddItemRateList(builder, ItemRate_List);
    FB_SYHJuBaoFuDaiReward.AddItemIDList(builder, ItemID_List);
    FB_SYHJuBaoFuDaiReward.AddRechargeTimes(builder, RechargeTimes);
    FB_SYHJuBaoFuDaiReward.AddTips(builder, Tips);
    FB_SYHJuBaoFuDaiReward.AddID(builder, ID);
    return FB_SYHJuBaoFuDaiReward.EndFB_SYHJuBaoFuDaiReward(builder);
  }

  public static void StartFB_SYHJuBaoFuDaiReward(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(1, TipsOffset.Value, 0); }
  public static void AddRechargeTimes(FlatBufferBuilder builder, int RechargeTimes) { builder.AddInt(2, RechargeTimes, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(3, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemRateList(FlatBufferBuilder builder, VectorOffset ItemRateListOffset) { builder.AddOffset(4, ItemRateListOffset.Value, 0); }
  public static VectorOffset CreateItemRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoFuDaiReward> EndFB_SYHJuBaoFuDaiReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoFuDaiReward>(o);
  }
};

public sealed class FB_SYHJuBaoFuDaiRewardContainer : Table {
  public static FB_SYHJuBaoFuDaiRewardContainer GetRootAsFB_SYHJuBaoFuDaiRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoFuDaiRewardContainer(_bb, new FB_SYHJuBaoFuDaiRewardContainer()); }
  public static FB_SYHJuBaoFuDaiRewardContainer GetRootAsFB_SYHJuBaoFuDaiRewardContainer(ByteBuffer _bb, FB_SYHJuBaoFuDaiRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJuBaoFuDaiRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJuBaoFuDaiRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJuBaoFuDaiReward GetItems(int j) { return GetItems(new FB_SYHJuBaoFuDaiReward(), j); }
  public FB_SYHJuBaoFuDaiReward GetItems(FB_SYHJuBaoFuDaiReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoFuDaiRewardContainer> CreateFB_SYHJuBaoFuDaiRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJuBaoFuDaiRewardContainer.AddItems(builder, items);
    return FB_SYHJuBaoFuDaiRewardContainer.EndFB_SYHJuBaoFuDaiRewardContainer(builder);
  }

  public static void StartFB_SYHJuBaoFuDaiRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJuBaoFuDaiReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoFuDaiRewardContainer> EndFB_SYHJuBaoFuDaiRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoFuDaiRewardContainer>(o);
  }
  public static void FinishFB_SYHJuBaoFuDaiRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJuBaoFuDaiRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
