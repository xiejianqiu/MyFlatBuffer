// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OppoReward : Table {
  public static FB_OppoReward GetRootAsFB_OppoReward(ByteBuffer _bb) { return GetRootAsFB_OppoReward(_bb, new FB_OppoReward()); }
  public static FB_OppoReward GetRootAsFB_OppoReward(ByteBuffer _bb, FB_OppoReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OppoReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MainType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VipType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PacketId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_OppoReward> CreateFB_OppoReward(FlatBufferBuilder builder,
      int ID = 0,
      int MainType = -1,
      int VipType = -1,
      int PacketId = -1) {
    builder.StartObject(4);
    FB_OppoReward.AddPacketId(builder, PacketId);
    FB_OppoReward.AddVipType(builder, VipType);
    FB_OppoReward.AddMainType(builder, MainType);
    FB_OppoReward.AddID(builder, ID);
    return FB_OppoReward.EndFB_OppoReward(builder);
  }

  public static void StartFB_OppoReward(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMainType(FlatBufferBuilder builder, int MainType) { builder.AddInt(1, MainType, -1); }
  public static void AddVipType(FlatBufferBuilder builder, int VipType) { builder.AddInt(2, VipType, -1); }
  public static void AddPacketId(FlatBufferBuilder builder, int PacketId) { builder.AddInt(3, PacketId, -1); }
  public static Offset<FB_OppoReward> EndFB_OppoReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OppoReward>(o);
  }
};

public sealed class FB_OppoRewardContainer : Table {
  public static FB_OppoRewardContainer GetRootAsFB_OppoRewardContainer(ByteBuffer _bb) { return GetRootAsFB_OppoRewardContainer(_bb, new FB_OppoRewardContainer()); }
  public static FB_OppoRewardContainer GetRootAsFB_OppoRewardContainer(ByteBuffer _bb, FB_OppoRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OppoRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OppoRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OppoReward GetItems(int j) { return GetItems(new FB_OppoReward(), j); }
  public FB_OppoReward GetItems(FB_OppoReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OppoRewardContainer> CreateFB_OppoRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OppoRewardContainer.AddItems(builder, items);
    return FB_OppoRewardContainer.EndFB_OppoRewardContainer(builder);
  }

  public static void StartFB_OppoRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OppoReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OppoRewardContainer> EndFB_OppoRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OppoRewardContainer>(o);
  }
  public static void FinishFB_OppoRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_OppoRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
