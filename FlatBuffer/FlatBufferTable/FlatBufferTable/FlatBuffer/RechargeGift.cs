// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RechargeGift : Table {
  public static FB_RechargeGift GetRootAsFB_RechargeGift(ByteBuffer _bb) { return GetRootAsFB_RechargeGift(_bb, new FB_RechargeGift()); }
  public static FB_RechargeGift GetRootAsFB_RechargeGift(ByteBuffer _bb, FB_RechargeGift obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RechargeGift __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Glod { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemByJobList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemByJobListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RechargeGift> CreateFB_RechargeGift(FlatBufferBuilder builder,
      int Id = 0,
      int Glod = -1,
      VectorOffset ItemByJobList = default(VectorOffset),
      VectorOffset RewardItemIdList = default(VectorOffset),
      VectorOffset RewardItemNumList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_RechargeGift.AddRewardItemNumList(builder, RewardItemNumList);
    FB_RechargeGift.AddRewardItemIdList(builder, RewardItemIdList);
    FB_RechargeGift.AddItemByJobList(builder, ItemByJobList);
    FB_RechargeGift.AddGlod(builder, Glod);
    FB_RechargeGift.AddId(builder, Id);
    return FB_RechargeGift.EndFB_RechargeGift(builder);
  }

  public static void StartFB_RechargeGift(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGlod(FlatBufferBuilder builder, int Glod) { builder.AddInt(1, Glod, -1); }
  public static void AddItemByJobList(FlatBufferBuilder builder, VectorOffset ItemByJobListOffset) { builder.AddOffset(2, ItemByJobListOffset.Value, 0); }
  public static VectorOffset CreateItemByJobListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemByJobListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemIdList(FlatBufferBuilder builder, VectorOffset RewardItemIdListOffset) { builder.AddOffset(3, RewardItemIdListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemNumList(FlatBufferBuilder builder, VectorOffset RewardItemNumListOffset) { builder.AddOffset(4, RewardItemNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RechargeGift> EndFB_RechargeGift(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RechargeGift>(o);
  }
};

public sealed class FB_RechargeGiftContainer : Table {
  public static FB_RechargeGiftContainer GetRootAsFB_RechargeGiftContainer(ByteBuffer _bb) { return GetRootAsFB_RechargeGiftContainer(_bb, new FB_RechargeGiftContainer()); }
  public static FB_RechargeGiftContainer GetRootAsFB_RechargeGiftContainer(ByteBuffer _bb, FB_RechargeGiftContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RechargeGiftContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RechargeGiftContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RechargeGift GetItems(int j) { return GetItems(new FB_RechargeGift(), j); }
  public FB_RechargeGift GetItems(FB_RechargeGift obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RechargeGiftContainer> CreateFB_RechargeGiftContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RechargeGiftContainer.AddItems(builder, items);
    return FB_RechargeGiftContainer.EndFB_RechargeGiftContainer(builder);
  }

  public static void StartFB_RechargeGiftContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RechargeGift>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RechargeGiftContainer> EndFB_RechargeGiftContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RechargeGiftContainer>(o);
  }
  public static void FinishFB_RechargeGiftContainerBuffer(FlatBufferBuilder builder, Offset<FB_RechargeGiftContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
