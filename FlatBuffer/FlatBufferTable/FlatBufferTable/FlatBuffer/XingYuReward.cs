// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYuReward : Table {
  public static FB_XingYuReward GetRootAsFB_XingYuReward(ByteBuffer _bb) { return GetRootAsFB_XingYuReward(_bb, new FB_XingYuReward()); }
  public static FB_XingYuReward GetRootAsFB_XingYuReward(ByteBuffer _bb, FB_XingYuReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYuReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetParamList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuReward> CreateFB_XingYuReward(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      VectorOffset RewardList = default(VectorOffset),
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_XingYuReward.AddParamList(builder, ParamList);
    FB_XingYuReward.AddRewardList(builder, RewardList);
    FB_XingYuReward.AddType(builder, Type);
    FB_XingYuReward.AddID(builder, ID);
    return FB_XingYuReward.EndFB_XingYuReward(builder);
  }

  public static void StartFB_XingYuReward(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset RewardListOffset) { builder.AddOffset(2, RewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(3, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuReward> EndFB_XingYuReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuReward>(o);
  }
};

public sealed class FB_XingYuRewardContainer : Table {
  public static FB_XingYuRewardContainer GetRootAsFB_XingYuRewardContainer(ByteBuffer _bb) { return GetRootAsFB_XingYuRewardContainer(_bb, new FB_XingYuRewardContainer()); }
  public static FB_XingYuRewardContainer GetRootAsFB_XingYuRewardContainer(ByteBuffer _bb, FB_XingYuRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYuRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYuRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYuReward GetItems(int j) { return GetItems(new FB_XingYuReward(), j); }
  public FB_XingYuReward GetItems(FB_XingYuReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuRewardContainer> CreateFB_XingYuRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYuRewardContainer.AddItems(builder, items);
    return FB_XingYuRewardContainer.EndFB_XingYuRewardContainer(builder);
  }

  public static void StartFB_XingYuRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYuReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuRewardContainer> EndFB_XingYuRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuRewardContainer>(o);
  }
  public static void FinishFB_XingYuRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYuRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
