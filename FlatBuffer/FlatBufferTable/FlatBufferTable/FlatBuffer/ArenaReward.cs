// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ArenaReward : Table {
  public static FB_ArenaReward GetRootAsFB_ArenaReward(ByteBuffer _bb) { return GetRootAsFB_ArenaReward(_bb, new FB_ArenaReward()); }
  public static FB_ArenaReward GetRootAsFB_ArenaReward(ByteBuffer _bb, FB_ArenaReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ArenaReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Infor { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int RankMin { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankMax { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ArenaReward> CreateFB_ArenaReward(FlatBufferBuilder builder,
      int ID = 0,
      int infor = -1,
      int RewardType = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      int RankMin = -1,
      int RankMax = -1) {
    builder.StartObject(7);
    FB_ArenaReward.AddRankMax(builder, RankMax);
    FB_ArenaReward.AddRankMin(builder, RankMin);
    FB_ArenaReward.AddItemCountList(builder, ItemCountList);
    FB_ArenaReward.AddItemIdList(builder, ItemIdList);
    FB_ArenaReward.AddRewardType(builder, RewardType);
    FB_ArenaReward.AddInfor(builder, infor);
    FB_ArenaReward.AddID(builder, ID);
    return FB_ArenaReward.EndFB_ArenaReward(builder);
  }

  public static void StartFB_ArenaReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddInfor(FlatBufferBuilder builder, int infor) { builder.AddInt(1, infor, -1); }
  public static void AddRewardType(FlatBufferBuilder builder, int RewardType) { builder.AddInt(2, RewardType, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(3, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(4, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRankMin(FlatBufferBuilder builder, int RankMin) { builder.AddInt(5, RankMin, -1); }
  public static void AddRankMax(FlatBufferBuilder builder, int RankMax) { builder.AddInt(6, RankMax, -1); }
  public static Offset<FB_ArenaReward> EndFB_ArenaReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArenaReward>(o);
  }
};

public sealed class FB_ArenaRewardContainer : Table {
  public static FB_ArenaRewardContainer GetRootAsFB_ArenaRewardContainer(ByteBuffer _bb) { return GetRootAsFB_ArenaRewardContainer(_bb, new FB_ArenaRewardContainer()); }
  public static FB_ArenaRewardContainer GetRootAsFB_ArenaRewardContainer(ByteBuffer _bb, FB_ArenaRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ArenaRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ArenaRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ArenaReward GetItems(int j) { return GetItems(new FB_ArenaReward(), j); }
  public FB_ArenaReward GetItems(FB_ArenaReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ArenaRewardContainer> CreateFB_ArenaRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ArenaRewardContainer.AddItems(builder, items);
    return FB_ArenaRewardContainer.EndFB_ArenaRewardContainer(builder);
  }

  public static void StartFB_ArenaRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ArenaReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ArenaRewardContainer> EndFB_ArenaRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArenaRewardContainer>(o);
  }
  public static void FinishFB_ArenaRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_ArenaRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
