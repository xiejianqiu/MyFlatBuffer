// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_IapGiftReward : Table {
  public static FB_IapGiftReward GetRootAsFB_IapGiftReward(ByteBuffer _bb) { return GetRootAsFB_IapGiftReward(_bb, new FB_IapGiftReward()); }
  public static FB_IapGiftReward GetRootAsFB_IapGiftReward(ByteBuffer _bb, FB_IapGiftReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_IapGiftReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RmbId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitValue { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_IapGiftReward> CreateFB_IapGiftReward(FlatBufferBuilder builder,
      int Id = 0,
      int RmbId = -1,
      int RefreshType = -1,
      int LimitValue = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_IapGiftReward.AddItemCountList(builder, ItemCountList);
    FB_IapGiftReward.AddItemIdList(builder, ItemIdList);
    FB_IapGiftReward.AddLimitValue(builder, LimitValue);
    FB_IapGiftReward.AddRefreshType(builder, RefreshType);
    FB_IapGiftReward.AddRmbId(builder, RmbId);
    FB_IapGiftReward.AddId(builder, Id);
    return FB_IapGiftReward.EndFB_IapGiftReward(builder);
  }

  public static void StartFB_IapGiftReward(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRmbId(FlatBufferBuilder builder, int RmbId) { builder.AddInt(1, RmbId, -1); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(2, RefreshType, -1); }
  public static void AddLimitValue(FlatBufferBuilder builder, int LimitValue) { builder.AddInt(3, LimitValue, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(4, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(5, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_IapGiftReward> EndFB_IapGiftReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGiftReward>(o);
  }
};

public sealed class FB_IapGiftRewardContainer : Table {
  public static FB_IapGiftRewardContainer GetRootAsFB_IapGiftRewardContainer(ByteBuffer _bb) { return GetRootAsFB_IapGiftRewardContainer(_bb, new FB_IapGiftRewardContainer()); }
  public static FB_IapGiftRewardContainer GetRootAsFB_IapGiftRewardContainer(ByteBuffer _bb, FB_IapGiftRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_IapGiftRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_IapGiftRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_IapGiftReward GetItems(int j) { return GetItems(new FB_IapGiftReward(), j); }
  public FB_IapGiftReward GetItems(FB_IapGiftReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_IapGiftRewardContainer> CreateFB_IapGiftRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_IapGiftRewardContainer.AddItems(builder, items);
    return FB_IapGiftRewardContainer.EndFB_IapGiftRewardContainer(builder);
  }

  public static void StartFB_IapGiftRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_IapGiftReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_IapGiftRewardContainer> EndFB_IapGiftRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_IapGiftRewardContainer>(o);
  }
  public static void FinishFB_IapGiftRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_IapGiftRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
