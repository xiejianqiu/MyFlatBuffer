// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangLiLian : Table {
  public static FB_ShenWangLiLian GetRootAsFB_ShenWangLiLian(ByteBuffer _bb) { return GetRootAsFB_ShenWangLiLian(_bb, new FB_ShenWangLiLian()); }
  public static FB_ShenWangLiLian GetRootAsFB_ShenWangLiLian(ByteBuffer _bb, FB_ShenWangLiLian obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangLiLian __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DicStrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoalType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoalNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewaredId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewaredNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardItemId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangLiLian> CreateFB_ShenWangLiLian(FlatBufferBuilder builder,
      int ID = 0,
      int DicStrId = -1,
      int GoalType = -1,
      int GoalNum = -1,
      int RewaredId = -1,
      int RewaredNum = -1,
      int RewardItemId = -1,
      VectorOffset ItemIdList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_ShenWangLiLian.AddItemIdList(builder, ItemIdList);
    FB_ShenWangLiLian.AddRewardItemId(builder, RewardItemId);
    FB_ShenWangLiLian.AddRewaredNum(builder, RewaredNum);
    FB_ShenWangLiLian.AddRewaredId(builder, RewaredId);
    FB_ShenWangLiLian.AddGoalNum(builder, GoalNum);
    FB_ShenWangLiLian.AddGoalType(builder, GoalType);
    FB_ShenWangLiLian.AddDicStrId(builder, DicStrId);
    FB_ShenWangLiLian.AddID(builder, ID);
    return FB_ShenWangLiLian.EndFB_ShenWangLiLian(builder);
  }

  public static void StartFB_ShenWangLiLian(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDicStrId(FlatBufferBuilder builder, int DicStrId) { builder.AddInt(1, DicStrId, -1); }
  public static void AddGoalType(FlatBufferBuilder builder, int GoalType) { builder.AddInt(2, GoalType, -1); }
  public static void AddGoalNum(FlatBufferBuilder builder, int GoalNum) { builder.AddInt(3, GoalNum, -1); }
  public static void AddRewaredId(FlatBufferBuilder builder, int RewaredId) { builder.AddInt(4, RewaredId, -1); }
  public static void AddRewaredNum(FlatBufferBuilder builder, int RewaredNum) { builder.AddInt(5, RewaredNum, -1); }
  public static void AddRewardItemId(FlatBufferBuilder builder, int RewardItemId) { builder.AddInt(6, RewardItemId, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(7, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangLiLian> EndFB_ShenWangLiLian(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangLiLian>(o);
  }
};

public sealed class FB_ShenWangLiLianContainer : Table {
  public static FB_ShenWangLiLianContainer GetRootAsFB_ShenWangLiLianContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangLiLianContainer(_bb, new FB_ShenWangLiLianContainer()); }
  public static FB_ShenWangLiLianContainer GetRootAsFB_ShenWangLiLianContainer(ByteBuffer _bb, FB_ShenWangLiLianContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangLiLianContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangLiLianContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangLiLian GetItems(int j) { return GetItems(new FB_ShenWangLiLian(), j); }
  public FB_ShenWangLiLian GetItems(FB_ShenWangLiLian obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangLiLianContainer> CreateFB_ShenWangLiLianContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangLiLianContainer.AddItems(builder, items);
    return FB_ShenWangLiLianContainer.EndFB_ShenWangLiLianContainer(builder);
  }

  public static void StartFB_ShenWangLiLianContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangLiLian>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangLiLianContainer> EndFB_ShenWangLiLianContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangLiLianContainer>(o);
  }
  public static void FinishFB_ShenWangLiLianContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangLiLianContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
