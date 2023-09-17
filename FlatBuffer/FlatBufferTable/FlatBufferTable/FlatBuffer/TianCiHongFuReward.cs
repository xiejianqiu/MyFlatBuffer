// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TianCiHongFuReward : Table {
  public static FB_TianCiHongFuReward GetRootAsFB_TianCiHongFuReward(ByteBuffer _bb) { return GetRootAsFB_TianCiHongFuReward(_bb, new FB_TianCiHongFuReward()); }
  public static FB_TianCiHongFuReward GetRootAsFB_TianCiHongFuReward(ByteBuffer _bb, FB_TianCiHongFuReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TianCiHongFuReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetDropIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DropIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianCiHongFuReward> CreateFB_TianCiHongFuReward(FlatBufferBuilder builder,
      int ID = 0,
      int actType = 0,
      int LevelLimit = 0,
      VectorOffset DropIdList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_TianCiHongFuReward.AddDropIdList(builder, DropIdList);
    FB_TianCiHongFuReward.AddLevelLimit(builder, LevelLimit);
    FB_TianCiHongFuReward.AddActType(builder, actType);
    FB_TianCiHongFuReward.AddID(builder, ID);
    return FB_TianCiHongFuReward.EndFB_TianCiHongFuReward(builder);
  }

  public static void StartFB_TianCiHongFuReward(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActType(FlatBufferBuilder builder, int actType) { builder.AddInt(1, actType, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(2, LevelLimit, 0); }
  public static void AddDropIdList(FlatBufferBuilder builder, VectorOffset DropIdListOffset) { builder.AddOffset(3, DropIdListOffset.Value, 0); }
  public static VectorOffset CreateDropIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDropIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianCiHongFuReward> EndFB_TianCiHongFuReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianCiHongFuReward>(o);
  }
};

public sealed class FB_TianCiHongFuRewardContainer : Table {
  public static FB_TianCiHongFuRewardContainer GetRootAsFB_TianCiHongFuRewardContainer(ByteBuffer _bb) { return GetRootAsFB_TianCiHongFuRewardContainer(_bb, new FB_TianCiHongFuRewardContainer()); }
  public static FB_TianCiHongFuRewardContainer GetRootAsFB_TianCiHongFuRewardContainer(ByteBuffer _bb, FB_TianCiHongFuRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TianCiHongFuRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TianCiHongFuRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TianCiHongFuReward GetItems(int j) { return GetItems(new FB_TianCiHongFuReward(), j); }
  public FB_TianCiHongFuReward GetItems(FB_TianCiHongFuReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianCiHongFuRewardContainer> CreateFB_TianCiHongFuRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TianCiHongFuRewardContainer.AddItems(builder, items);
    return FB_TianCiHongFuRewardContainer.EndFB_TianCiHongFuRewardContainer(builder);
  }

  public static void StartFB_TianCiHongFuRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TianCiHongFuReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianCiHongFuRewardContainer> EndFB_TianCiHongFuRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianCiHongFuRewardContainer>(o);
  }
  public static void FinishFB_TianCiHongFuRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_TianCiHongFuRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
