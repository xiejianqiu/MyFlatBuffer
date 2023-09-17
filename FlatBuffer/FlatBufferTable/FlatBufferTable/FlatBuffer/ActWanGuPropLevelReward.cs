// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActWanGuPropLevelReward : Table {
  public static FB_ActWanGuPropLevelReward GetRootAsFB_ActWanGuPropLevelReward(ByteBuffer _bb) { return GetRootAsFB_ActWanGuPropLevelReward(_bb, new FB_ActWanGuPropLevelReward()); }
  public static FB_ActWanGuPropLevelReward GetRootAsFB_ActWanGuPropLevelReward(ByteBuffer _bb, FB_ActWanGuPropLevelReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActWanGuPropLevelReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRewardIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardTypeList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardTypeListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuPropLevelReward> CreateFB_ActWanGuPropLevelReward(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset RewardIdList = default(VectorOffset),
      VectorOffset RewardNumList = default(VectorOffset),
      VectorOffset RewardTypeList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_ActWanGuPropLevelReward.AddRewardTypeList(builder, RewardTypeList);
    FB_ActWanGuPropLevelReward.AddRewardNumList(builder, RewardNumList);
    FB_ActWanGuPropLevelReward.AddRewardIdList(builder, RewardIdList);
    FB_ActWanGuPropLevelReward.AddId(builder, Id);
    return FB_ActWanGuPropLevelReward.EndFB_ActWanGuPropLevelReward(builder);
  }

  public static void StartFB_ActWanGuPropLevelReward(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRewardIdList(FlatBufferBuilder builder, VectorOffset RewardIdListOffset) { builder.AddOffset(1, RewardIdListOffset.Value, 0); }
  public static VectorOffset CreateRewardIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardNumList(FlatBufferBuilder builder, VectorOffset RewardNumListOffset) { builder.AddOffset(2, RewardNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardTypeList(FlatBufferBuilder builder, VectorOffset RewardTypeListOffset) { builder.AddOffset(3, RewardTypeListOffset.Value, 0); }
  public static VectorOffset CreateRewardTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuPropLevelReward> EndFB_ActWanGuPropLevelReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuPropLevelReward>(o);
  }
};

public sealed class FB_ActWanGuPropLevelRewardContainer : Table {
  public static FB_ActWanGuPropLevelRewardContainer GetRootAsFB_ActWanGuPropLevelRewardContainer(ByteBuffer _bb) { return GetRootAsFB_ActWanGuPropLevelRewardContainer(_bb, new FB_ActWanGuPropLevelRewardContainer()); }
  public static FB_ActWanGuPropLevelRewardContainer GetRootAsFB_ActWanGuPropLevelRewardContainer(ByteBuffer _bb, FB_ActWanGuPropLevelRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActWanGuPropLevelRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActWanGuPropLevelRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActWanGuPropLevelReward GetItems(int j) { return GetItems(new FB_ActWanGuPropLevelReward(), j); }
  public FB_ActWanGuPropLevelReward GetItems(FB_ActWanGuPropLevelReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuPropLevelRewardContainer> CreateFB_ActWanGuPropLevelRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActWanGuPropLevelRewardContainer.AddItems(builder, items);
    return FB_ActWanGuPropLevelRewardContainer.EndFB_ActWanGuPropLevelRewardContainer(builder);
  }

  public static void StartFB_ActWanGuPropLevelRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActWanGuPropLevelReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuPropLevelRewardContainer> EndFB_ActWanGuPropLevelRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuPropLevelRewardContainer>(o);
  }
  public static void FinishFB_ActWanGuPropLevelRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActWanGuPropLevelRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
