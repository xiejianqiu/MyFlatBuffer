// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MergeRankReward : Table {
  public static FB_MergeRankReward GetRootAsFB_MergeRankReward(ByteBuffer _bb) { return GetRootAsFB_MergeRankReward(_bb, new FB_MergeRankReward()); }
  public static FB_MergeRankReward GetRootAsFB_MergeRankReward(ByteBuffer _bb, FB_MergeRankReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MergeRankReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Tpye { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Group { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AcceptType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankMin { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankMax { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Index { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowModelId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MergeRankReward> CreateFB_MergeRankReward(FlatBufferBuilder builder,
      int ID = 0,
      int tpye = -1,
      int group = -1,
      int acceptType = -1,
      int rankMin = -1,
      int rankMax = -1,
      int index = -1,
      int showModelId = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_MergeRankReward.AddItemNumList(builder, ItemNumList);
    FB_MergeRankReward.AddItemIDList(builder, ItemIDList);
    FB_MergeRankReward.AddShowModelId(builder, showModelId);
    FB_MergeRankReward.AddIndex(builder, index);
    FB_MergeRankReward.AddRankMax(builder, rankMax);
    FB_MergeRankReward.AddRankMin(builder, rankMin);
    FB_MergeRankReward.AddAcceptType(builder, acceptType);
    FB_MergeRankReward.AddGroup(builder, group);
    FB_MergeRankReward.AddTpye(builder, tpye);
    FB_MergeRankReward.AddID(builder, ID);
    return FB_MergeRankReward.EndFB_MergeRankReward(builder);
  }

  public static void StartFB_MergeRankReward(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTpye(FlatBufferBuilder builder, int tpye) { builder.AddInt(1, tpye, -1); }
  public static void AddGroup(FlatBufferBuilder builder, int group) { builder.AddInt(2, group, -1); }
  public static void AddAcceptType(FlatBufferBuilder builder, int acceptType) { builder.AddInt(3, acceptType, -1); }
  public static void AddRankMin(FlatBufferBuilder builder, int rankMin) { builder.AddInt(4, rankMin, -1); }
  public static void AddRankMax(FlatBufferBuilder builder, int rankMax) { builder.AddInt(5, rankMax, -1); }
  public static void AddIndex(FlatBufferBuilder builder, int index) { builder.AddInt(6, index, -1); }
  public static void AddShowModelId(FlatBufferBuilder builder, int showModelId) { builder.AddInt(7, showModelId, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(8, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(9, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MergeRankReward> EndFB_MergeRankReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeRankReward>(o);
  }
};

public sealed class FB_MergeRankRewardContainer : Table {
  public static FB_MergeRankRewardContainer GetRootAsFB_MergeRankRewardContainer(ByteBuffer _bb) { return GetRootAsFB_MergeRankRewardContainer(_bb, new FB_MergeRankRewardContainer()); }
  public static FB_MergeRankRewardContainer GetRootAsFB_MergeRankRewardContainer(ByteBuffer _bb, FB_MergeRankRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MergeRankRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MergeRankRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MergeRankReward GetItems(int j) { return GetItems(new FB_MergeRankReward(), j); }
  public FB_MergeRankReward GetItems(FB_MergeRankReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MergeRankRewardContainer> CreateFB_MergeRankRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MergeRankRewardContainer.AddItems(builder, items);
    return FB_MergeRankRewardContainer.EndFB_MergeRankRewardContainer(builder);
  }

  public static void StartFB_MergeRankRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MergeRankReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MergeRankRewardContainer> EndFB_MergeRankRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeRankRewardContainer>(o);
  }
  public static void FinishFB_MergeRankRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_MergeRankRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
