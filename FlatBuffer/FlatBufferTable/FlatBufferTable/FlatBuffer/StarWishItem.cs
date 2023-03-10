// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarWishItem : Table {
  public static FB_StarWishItem GetRootAsFB_StarWishItem(ByteBuffer _bb) { return GetRootAsFB_StarWishItem(_bb, new FB_StarWishItem()); }
  public static FB_StarWishItem GetRootAsFB_StarWishItem(ByteBuffer _bb, FB_StarWishItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarWishItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int WorldMin { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int WorldMax { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CountLimit { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MDId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsBigReward { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ParamSec { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_StarWishItem> CreateFB_StarWishItem(FlatBufferBuilder builder,
      int ID = 0,
      int WorldMin = 0,
      int WorldMax = 0,
      int ItemId = 0,
      int ItemCount = 0,
      int RewardType = 0,
      int CountLimit = 0,
      int MDId = 0,
      bool IsBigReward = false,
      int paramSec = 0) {
    builder.StartObject(10);
    FB_StarWishItem.AddParamSec(builder, paramSec);
    FB_StarWishItem.AddMDId(builder, MDId);
    FB_StarWishItem.AddCountLimit(builder, CountLimit);
    FB_StarWishItem.AddRewardType(builder, RewardType);
    FB_StarWishItem.AddItemCount(builder, ItemCount);
    FB_StarWishItem.AddItemId(builder, ItemId);
    FB_StarWishItem.AddWorldMax(builder, WorldMax);
    FB_StarWishItem.AddWorldMin(builder, WorldMin);
    FB_StarWishItem.AddID(builder, ID);
    FB_StarWishItem.AddIsBigReward(builder, IsBigReward);
    return FB_StarWishItem.EndFB_StarWishItem(builder);
  }

  public static void StartFB_StarWishItem(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddWorldMin(FlatBufferBuilder builder, int WorldMin) { builder.AddInt(1, WorldMin, 0); }
  public static void AddWorldMax(FlatBufferBuilder builder, int WorldMax) { builder.AddInt(2, WorldMax, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(3, ItemId, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(4, ItemCount, 0); }
  public static void AddRewardType(FlatBufferBuilder builder, int RewardType) { builder.AddInt(5, RewardType, 0); }
  public static void AddCountLimit(FlatBufferBuilder builder, int CountLimit) { builder.AddInt(6, CountLimit, 0); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(7, MDId, 0); }
  public static void AddIsBigReward(FlatBufferBuilder builder, bool IsBigReward) { builder.AddBool(8, IsBigReward, false); }
  public static void AddParamSec(FlatBufferBuilder builder, int paramSec) { builder.AddInt(9, paramSec, 0); }
  public static Offset<FB_StarWishItem> EndFB_StarWishItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarWishItem>(o);
  }
};

public sealed class FB_StarWishItemContainer : Table {
  public static FB_StarWishItemContainer GetRootAsFB_StarWishItemContainer(ByteBuffer _bb) { return GetRootAsFB_StarWishItemContainer(_bb, new FB_StarWishItemContainer()); }
  public static FB_StarWishItemContainer GetRootAsFB_StarWishItemContainer(ByteBuffer _bb, FB_StarWishItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarWishItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarWishItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarWishItem GetItems(int j) { return GetItems(new FB_StarWishItem(), j); }
  public FB_StarWishItem GetItems(FB_StarWishItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarWishItemContainer> CreateFB_StarWishItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarWishItemContainer.AddItems(builder, items);
    return FB_StarWishItemContainer.EndFB_StarWishItemContainer(builder);
  }

  public static void StartFB_StarWishItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarWishItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarWishItemContainer> EndFB_StarWishItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarWishItemContainer>(o);
  }
  public static void FinishFB_StarWishItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarWishItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
