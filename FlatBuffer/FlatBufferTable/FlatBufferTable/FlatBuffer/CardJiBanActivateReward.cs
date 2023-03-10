// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CardJiBanActivateReward : Table {
  public static FB_CardJiBanActivateReward GetRootAsFB_CardJiBanActivateReward(ByteBuffer _bb) { return GetRootAsFB_CardJiBanActivateReward(_bb, new FB_CardJiBanActivateReward()); }
  public static FB_CardJiBanActivateReward GetRootAsFB_CardJiBanActivateReward(ByteBuffer _bb, FB_CardJiBanActivateReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CardJiBanActivateReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActivateLimitNum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardItemIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemNumList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemNumListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardJiBanActivateReward> CreateFB_CardJiBanActivateReward(FlatBufferBuilder builder,
      int Id = 0,
      int ActivateLimitNum = -1,
      VectorOffset RewardItemIdList = default(VectorOffset),
      VectorOffset RewardItemNumList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_CardJiBanActivateReward.AddRewardItemNumList(builder, RewardItemNumList);
    FB_CardJiBanActivateReward.AddRewardItemIdList(builder, RewardItemIdList);
    FB_CardJiBanActivateReward.AddActivateLimitNum(builder, ActivateLimitNum);
    FB_CardJiBanActivateReward.AddId(builder, Id);
    return FB_CardJiBanActivateReward.EndFB_CardJiBanActivateReward(builder);
  }

  public static void StartFB_CardJiBanActivateReward(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddActivateLimitNum(FlatBufferBuilder builder, int ActivateLimitNum) { builder.AddInt(1, ActivateLimitNum, -1); }
  public static void AddRewardItemIdList(FlatBufferBuilder builder, VectorOffset RewardItemIdListOffset) { builder.AddOffset(2, RewardItemIdListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemNumList(FlatBufferBuilder builder, VectorOffset RewardItemNumListOffset) { builder.AddOffset(3, RewardItemNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardJiBanActivateReward> EndFB_CardJiBanActivateReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardJiBanActivateReward>(o);
  }
};

public sealed class FB_CardJiBanActivateRewardContainer : Table {
  public static FB_CardJiBanActivateRewardContainer GetRootAsFB_CardJiBanActivateRewardContainer(ByteBuffer _bb) { return GetRootAsFB_CardJiBanActivateRewardContainer(_bb, new FB_CardJiBanActivateRewardContainer()); }
  public static FB_CardJiBanActivateRewardContainer GetRootAsFB_CardJiBanActivateRewardContainer(ByteBuffer _bb, FB_CardJiBanActivateRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CardJiBanActivateRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CardJiBanActivateRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CardJiBanActivateReward GetItems(int j) { return GetItems(new FB_CardJiBanActivateReward(), j); }
  public FB_CardJiBanActivateReward GetItems(FB_CardJiBanActivateReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardJiBanActivateRewardContainer> CreateFB_CardJiBanActivateRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CardJiBanActivateRewardContainer.AddItems(builder, items);
    return FB_CardJiBanActivateRewardContainer.EndFB_CardJiBanActivateRewardContainer(builder);
  }

  public static void StartFB_CardJiBanActivateRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CardJiBanActivateReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardJiBanActivateRewardContainer> EndFB_CardJiBanActivateRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardJiBanActivateRewardContainer>(o);
  }
  public static void FinishFB_CardJiBanActivateRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_CardJiBanActivateRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
