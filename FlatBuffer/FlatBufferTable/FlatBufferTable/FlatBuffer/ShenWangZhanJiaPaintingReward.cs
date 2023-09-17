// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaPaintingReward : Table {
  public static FB_ShenWangZhanJiaPaintingReward GetRootAsFB_ShenWangZhanJiaPaintingReward(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPaintingReward(_bb, new FB_ShenWangZhanJiaPaintingReward()); }
  public static FB_ShenWangZhanJiaPaintingReward GetRootAsFB_ShenWangZhanJiaPaintingReward(ByteBuffer _bb, FB_ShenWangZhanJiaPaintingReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaPaintingReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPayItemIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PayItemIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPayItemNunList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PayItemNunListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaPaintingReward> CreateFB_ShenWangZhanJiaPaintingReward(FlatBufferBuilder builder,
      int ID = 0,
      int Exp = -1,
      int RewardType = -1,
      int ItemId = -1,
      int ItemNum = -1,
      VectorOffset PayItemIdList = default(VectorOffset),
      VectorOffset PayItemNunList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_ShenWangZhanJiaPaintingReward.AddPayItemNunList(builder, PayItemNunList);
    FB_ShenWangZhanJiaPaintingReward.AddPayItemIdList(builder, PayItemIdList);
    FB_ShenWangZhanJiaPaintingReward.AddItemNum(builder, ItemNum);
    FB_ShenWangZhanJiaPaintingReward.AddItemId(builder, ItemId);
    FB_ShenWangZhanJiaPaintingReward.AddRewardType(builder, RewardType);
    FB_ShenWangZhanJiaPaintingReward.AddExp(builder, Exp);
    FB_ShenWangZhanJiaPaintingReward.AddID(builder, ID);
    return FB_ShenWangZhanJiaPaintingReward.EndFB_ShenWangZhanJiaPaintingReward(builder);
  }

  public static void StartFB_ShenWangZhanJiaPaintingReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, -1); }
  public static void AddRewardType(FlatBufferBuilder builder, int RewardType) { builder.AddInt(2, RewardType, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(3, ItemId, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(4, ItemNum, -1); }
  public static void AddPayItemIdList(FlatBufferBuilder builder, VectorOffset PayItemIdListOffset) { builder.AddOffset(5, PayItemIdListOffset.Value, 0); }
  public static VectorOffset CreatePayItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPayItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPayItemNunList(FlatBufferBuilder builder, VectorOffset PayItemNunListOffset) { builder.AddOffset(6, PayItemNunListOffset.Value, 0); }
  public static VectorOffset CreatePayItemNunListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPayItemNunListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaPaintingReward> EndFB_ShenWangZhanJiaPaintingReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPaintingReward>(o);
  }
};

public sealed class FB_ShenWangZhanJiaPaintingRewardContainer : Table {
  public static FB_ShenWangZhanJiaPaintingRewardContainer GetRootAsFB_ShenWangZhanJiaPaintingRewardContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPaintingRewardContainer(_bb, new FB_ShenWangZhanJiaPaintingRewardContainer()); }
  public static FB_ShenWangZhanJiaPaintingRewardContainer GetRootAsFB_ShenWangZhanJiaPaintingRewardContainer(ByteBuffer _bb, FB_ShenWangZhanJiaPaintingRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaPaintingRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaPaintingRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaPaintingReward GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaPaintingReward(), j); }
  public FB_ShenWangZhanJiaPaintingReward GetItems(FB_ShenWangZhanJiaPaintingReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaPaintingRewardContainer> CreateFB_ShenWangZhanJiaPaintingRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaPaintingRewardContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaPaintingRewardContainer.EndFB_ShenWangZhanJiaPaintingRewardContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaPaintingRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPaintingReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaPaintingRewardContainer> EndFB_ShenWangZhanJiaPaintingRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPaintingRewardContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaPaintingRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPaintingRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
