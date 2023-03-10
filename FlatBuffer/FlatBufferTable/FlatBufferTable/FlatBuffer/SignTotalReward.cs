// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SignTotalReward : Table {
  public static FB_SignTotalReward GetRootAsFB_SignTotalReward(ByteBuffer _bb) { return GetRootAsFB_SignTotalReward(_bb, new FB_SignTotalReward()); }
  public static FB_SignTotalReward GetRootAsFB_SignTotalReward(ByteBuffer _bb, FB_SignTotalReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SignTotalReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Index { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SignTotalReward> CreateFB_SignTotalReward(FlatBufferBuilder builder,
      int ID = 0,
      int ItemType = -1,
      int ItemID = -1,
      int ItemNum = -1,
      int Index = -1) {
    builder.StartObject(5);
    FB_SignTotalReward.AddIndex(builder, Index);
    FB_SignTotalReward.AddItemNum(builder, ItemNum);
    FB_SignTotalReward.AddItemID(builder, ItemID);
    FB_SignTotalReward.AddItemType(builder, ItemType);
    FB_SignTotalReward.AddID(builder, ID);
    return FB_SignTotalReward.EndFB_SignTotalReward(builder);
  }

  public static void StartFB_SignTotalReward(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemType(FlatBufferBuilder builder, int ItemType) { builder.AddInt(1, ItemType, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(2, ItemID, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(3, ItemNum, -1); }
  public static void AddIndex(FlatBufferBuilder builder, int Index) { builder.AddInt(4, Index, -1); }
  public static Offset<FB_SignTotalReward> EndFB_SignTotalReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SignTotalReward>(o);
  }
};

public sealed class FB_SignTotalRewardContainer : Table {
  public static FB_SignTotalRewardContainer GetRootAsFB_SignTotalRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SignTotalRewardContainer(_bb, new FB_SignTotalRewardContainer()); }
  public static FB_SignTotalRewardContainer GetRootAsFB_SignTotalRewardContainer(ByteBuffer _bb, FB_SignTotalRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SignTotalRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SignTotalRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SignTotalReward GetItems(int j) { return GetItems(new FB_SignTotalReward(), j); }
  public FB_SignTotalReward GetItems(FB_SignTotalReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SignTotalRewardContainer> CreateFB_SignTotalRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SignTotalRewardContainer.AddItems(builder, items);
    return FB_SignTotalRewardContainer.EndFB_SignTotalRewardContainer(builder);
  }

  public static void StartFB_SignTotalRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SignTotalReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SignTotalRewardContainer> EndFB_SignTotalRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SignTotalRewardContainer>(o);
  }
  public static void FinishFB_SignTotalRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SignTotalRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
