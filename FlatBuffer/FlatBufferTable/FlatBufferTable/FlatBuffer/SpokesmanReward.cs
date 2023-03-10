// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SpokesmanReward : Table {
  public static FB_SpokesmanReward GetRootAsFB_SpokesmanReward(ByteBuffer _bb) { return GetRootAsFB_SpokesmanReward(_bb, new FB_SpokesmanReward()); }
  public static FB_SpokesmanReward GetRootAsFB_SpokesmanReward(ByteBuffer _bb, FB_SpokesmanReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SpokesmanReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string StrDesc { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DropID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SpokesmanReward> CreateFB_SpokesmanReward(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset strDesc = default(StringOffset),
      int DropID = -1) {
    builder.StartObject(3);
    FB_SpokesmanReward.AddDropID(builder, DropID);
    FB_SpokesmanReward.AddStrDesc(builder, strDesc);
    FB_SpokesmanReward.AddID(builder, ID);
    return FB_SpokesmanReward.EndFB_SpokesmanReward(builder);
  }

  public static void StartFB_SpokesmanReward(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStrDesc(FlatBufferBuilder builder, StringOffset strDescOffset) { builder.AddOffset(1, strDescOffset.Value, 0); }
  public static void AddDropID(FlatBufferBuilder builder, int DropID) { builder.AddInt(2, DropID, -1); }
  public static Offset<FB_SpokesmanReward> EndFB_SpokesmanReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SpokesmanReward>(o);
  }
};

public sealed class FB_SpokesmanRewardContainer : Table {
  public static FB_SpokesmanRewardContainer GetRootAsFB_SpokesmanRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SpokesmanRewardContainer(_bb, new FB_SpokesmanRewardContainer()); }
  public static FB_SpokesmanRewardContainer GetRootAsFB_SpokesmanRewardContainer(ByteBuffer _bb, FB_SpokesmanRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SpokesmanRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SpokesmanRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SpokesmanReward GetItems(int j) { return GetItems(new FB_SpokesmanReward(), j); }
  public FB_SpokesmanReward GetItems(FB_SpokesmanReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SpokesmanRewardContainer> CreateFB_SpokesmanRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SpokesmanRewardContainer.AddItems(builder, items);
    return FB_SpokesmanRewardContainer.EndFB_SpokesmanRewardContainer(builder);
  }

  public static void StartFB_SpokesmanRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SpokesmanReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SpokesmanRewardContainer> EndFB_SpokesmanRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SpokesmanRewardContainer>(o);
  }
  public static void FinishFB_SpokesmanRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SpokesmanRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
