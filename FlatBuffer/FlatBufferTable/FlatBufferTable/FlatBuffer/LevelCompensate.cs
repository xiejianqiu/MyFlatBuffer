// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LevelCompensate : Table {
  public static FB_LevelCompensate GetRootAsFB_LevelCompensate(ByteBuffer _bb) { return GetRootAsFB_LevelCompensate(_bb, new FB_LevelCompensate()); }
  public static FB_LevelCompensate GetRootAsFB_LevelCompensate(ByteBuffer _bb, FB_LevelCompensate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LevelCompensate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRewardList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelCompensate> CreateFB_LevelCompensate(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset RewardList = default(VectorOffset),
      VectorOffset RewardNumList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_LevelCompensate.AddRewardNumList(builder, RewardNumList);
    FB_LevelCompensate.AddRewardList(builder, RewardList);
    FB_LevelCompensate.AddID(builder, ID);
    return FB_LevelCompensate.EndFB_LevelCompensate(builder);
  }

  public static void StartFB_LevelCompensate(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset RewardListOffset) { builder.AddOffset(1, RewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardNumList(FlatBufferBuilder builder, VectorOffset RewardNumListOffset) { builder.AddOffset(2, RewardNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelCompensate> EndFB_LevelCompensate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelCompensate>(o);
  }
};

public sealed class FB_LevelCompensateContainer : Table {
  public static FB_LevelCompensateContainer GetRootAsFB_LevelCompensateContainer(ByteBuffer _bb) { return GetRootAsFB_LevelCompensateContainer(_bb, new FB_LevelCompensateContainer()); }
  public static FB_LevelCompensateContainer GetRootAsFB_LevelCompensateContainer(ByteBuffer _bb, FB_LevelCompensateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LevelCompensateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LevelCompensateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LevelCompensate GetItems(int j) { return GetItems(new FB_LevelCompensate(), j); }
  public FB_LevelCompensate GetItems(FB_LevelCompensate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelCompensateContainer> CreateFB_LevelCompensateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LevelCompensateContainer.AddItems(builder, items);
    return FB_LevelCompensateContainer.EndFB_LevelCompensateContainer(builder);
  }

  public static void StartFB_LevelCompensateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LevelCompensate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelCompensateContainer> EndFB_LevelCompensateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelCompensateContainer>(o);
  }
  public static void FinishFB_LevelCompensateContainerBuffer(FlatBufferBuilder builder, Offset<FB_LevelCompensateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
