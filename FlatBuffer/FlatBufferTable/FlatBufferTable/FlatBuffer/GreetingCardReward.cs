// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GreetingCardReward : Table {
  public static FB_GreetingCardReward GetRootAsFB_GreetingCardReward(ByteBuffer _bb) { return GetRootAsFB_GreetingCardReward(_bb, new FB_GreetingCardReward()); }
  public static FB_GreetingCardReward GetRootAsFB_GreetingCardReward(ByteBuffer _bb, FB_GreetingCardReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GreetingCardReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int SpecialItem { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SpecialCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_GreetingCardReward> CreateFB_GreetingCardReward(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      int SpecialItem = 0,
      int SpecialCount = 0) {
    builder.StartObject(5);
    FB_GreetingCardReward.AddSpecialCount(builder, SpecialCount);
    FB_GreetingCardReward.AddSpecialItem(builder, SpecialItem);
    FB_GreetingCardReward.AddItemCountList(builder, ItemCountList);
    FB_GreetingCardReward.AddItemList(builder, ItemList);
    FB_GreetingCardReward.AddID(builder, ID);
    return FB_GreetingCardReward.EndFB_GreetingCardReward(builder);
  }

  public static void StartFB_GreetingCardReward(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(1, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(2, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpecialItem(FlatBufferBuilder builder, int SpecialItem) { builder.AddInt(3, SpecialItem, 0); }
  public static void AddSpecialCount(FlatBufferBuilder builder, int SpecialCount) { builder.AddInt(4, SpecialCount, 0); }
  public static Offset<FB_GreetingCardReward> EndFB_GreetingCardReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GreetingCardReward>(o);
  }
};

public sealed class FB_GreetingCardRewardContainer : Table {
  public static FB_GreetingCardRewardContainer GetRootAsFB_GreetingCardRewardContainer(ByteBuffer _bb) { return GetRootAsFB_GreetingCardRewardContainer(_bb, new FB_GreetingCardRewardContainer()); }
  public static FB_GreetingCardRewardContainer GetRootAsFB_GreetingCardRewardContainer(ByteBuffer _bb, FB_GreetingCardRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GreetingCardRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GreetingCardRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GreetingCardReward GetItems(int j) { return GetItems(new FB_GreetingCardReward(), j); }
  public FB_GreetingCardReward GetItems(FB_GreetingCardReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GreetingCardRewardContainer> CreateFB_GreetingCardRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GreetingCardRewardContainer.AddItems(builder, items);
    return FB_GreetingCardRewardContainer.EndFB_GreetingCardRewardContainer(builder);
  }

  public static void StartFB_GreetingCardRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GreetingCardReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GreetingCardRewardContainer> EndFB_GreetingCardRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GreetingCardRewardContainer>(o);
  }
  public static void FinishFB_GreetingCardRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_GreetingCardRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
