// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaCsReward : Table {
  public static FB_ShenWangZhanJiaCsReward GetRootAsFB_ShenWangZhanJiaCsReward(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCsReward(_bb, new FB_ShenWangZhanJiaCsReward()); }
  public static FB_ShenWangZhanJiaCsReward GetRootAsFB_ShenWangZhanJiaCsReward(ByteBuffer _bb, FB_ShenWangZhanJiaCsReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaCsReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string RankNum { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SeasonId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankMin { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankMax { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaCsReward> CreateFB_ShenWangZhanJiaCsReward(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset RankNum = default(StringOffset),
      int SeasonId = -1,
      int RankMin = -1,
      int RankMax = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_ShenWangZhanJiaCsReward.AddItemNumList(builder, ItemNumList);
    FB_ShenWangZhanJiaCsReward.AddItemIdList(builder, ItemIdList);
    FB_ShenWangZhanJiaCsReward.AddRankMax(builder, RankMax);
    FB_ShenWangZhanJiaCsReward.AddRankMin(builder, RankMin);
    FB_ShenWangZhanJiaCsReward.AddSeasonId(builder, SeasonId);
    FB_ShenWangZhanJiaCsReward.AddRankNum(builder, RankNum);
    FB_ShenWangZhanJiaCsReward.AddID(builder, ID);
    return FB_ShenWangZhanJiaCsReward.EndFB_ShenWangZhanJiaCsReward(builder);
  }

  public static void StartFB_ShenWangZhanJiaCsReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRankNum(FlatBufferBuilder builder, StringOffset RankNumOffset) { builder.AddOffset(1, RankNumOffset.Value, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, int SeasonId) { builder.AddInt(2, SeasonId, -1); }
  public static void AddRankMin(FlatBufferBuilder builder, int RankMin) { builder.AddInt(3, RankMin, -1); }
  public static void AddRankMax(FlatBufferBuilder builder, int RankMax) { builder.AddInt(4, RankMax, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(5, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(6, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaCsReward> EndFB_ShenWangZhanJiaCsReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCsReward>(o);
  }
};

public sealed class FB_ShenWangZhanJiaCsRewardContainer : Table {
  public static FB_ShenWangZhanJiaCsRewardContainer GetRootAsFB_ShenWangZhanJiaCsRewardContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCsRewardContainer(_bb, new FB_ShenWangZhanJiaCsRewardContainer()); }
  public static FB_ShenWangZhanJiaCsRewardContainer GetRootAsFB_ShenWangZhanJiaCsRewardContainer(ByteBuffer _bb, FB_ShenWangZhanJiaCsRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaCsRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaCsRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaCsReward GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaCsReward(), j); }
  public FB_ShenWangZhanJiaCsReward GetItems(FB_ShenWangZhanJiaCsReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaCsRewardContainer> CreateFB_ShenWangZhanJiaCsRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaCsRewardContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaCsRewardContainer.EndFB_ShenWangZhanJiaCsRewardContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaCsRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCsReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaCsRewardContainer> EndFB_ShenWangZhanJiaCsRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCsRewardContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaCsRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCsRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
