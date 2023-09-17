// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RechargeAndConsumeBase : Table {
  public static FB_RechargeAndConsumeBase GetRootAsFB_RechargeAndConsumeBase(ByteBuffer _bb) { return GetRootAsFB_RechargeAndConsumeBase(_bb, new FB_RechargeAndConsumeBase()); }
  public static FB_RechargeAndConsumeBase GetRootAsFB_RechargeAndConsumeBase(ByteBuffer _bb, FB_RechargeAndConsumeBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RechargeAndConsumeBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardMD { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_RechargeAndConsumeBase> CreateFB_RechargeAndConsumeBase(FlatBufferBuilder builder,
      int ID = 0,
      int RewardMD = 0) {
    builder.StartObject(2);
    FB_RechargeAndConsumeBase.AddRewardMD(builder, RewardMD);
    FB_RechargeAndConsumeBase.AddID(builder, ID);
    return FB_RechargeAndConsumeBase.EndFB_RechargeAndConsumeBase(builder);
  }

  public static void StartFB_RechargeAndConsumeBase(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRewardMD(FlatBufferBuilder builder, int RewardMD) { builder.AddInt(1, RewardMD, 0); }
  public static Offset<FB_RechargeAndConsumeBase> EndFB_RechargeAndConsumeBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RechargeAndConsumeBase>(o);
  }
};

public sealed class FB_RechargeAndConsumeBaseContainer : Table {
  public static FB_RechargeAndConsumeBaseContainer GetRootAsFB_RechargeAndConsumeBaseContainer(ByteBuffer _bb) { return GetRootAsFB_RechargeAndConsumeBaseContainer(_bb, new FB_RechargeAndConsumeBaseContainer()); }
  public static FB_RechargeAndConsumeBaseContainer GetRootAsFB_RechargeAndConsumeBaseContainer(ByteBuffer _bb, FB_RechargeAndConsumeBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RechargeAndConsumeBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RechargeAndConsumeBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RechargeAndConsumeBase GetItems(int j) { return GetItems(new FB_RechargeAndConsumeBase(), j); }
  public FB_RechargeAndConsumeBase GetItems(FB_RechargeAndConsumeBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RechargeAndConsumeBaseContainer> CreateFB_RechargeAndConsumeBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RechargeAndConsumeBaseContainer.AddItems(builder, items);
    return FB_RechargeAndConsumeBaseContainer.EndFB_RechargeAndConsumeBaseContainer(builder);
  }

  public static void StartFB_RechargeAndConsumeBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RechargeAndConsumeBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RechargeAndConsumeBaseContainer> EndFB_RechargeAndConsumeBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RechargeAndConsumeBaseContainer>(o);
  }
  public static void FinishFB_RechargeAndConsumeBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_RechargeAndConsumeBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
