// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityDaZhiGouReward : Table {
  public static FB_ActivityDaZhiGouReward GetRootAsFB_ActivityDaZhiGouReward(ByteBuffer _bb) { return GetRootAsFB_ActivityDaZhiGouReward(_bb, new FB_ActivityDaZhiGouReward()); }
  public static FB_ActivityDaZhiGouReward GetRootAsFB_ActivityDaZhiGouReward(ByteBuffer _bb, FB_ActivityDaZhiGouReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityDaZhiGouReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TriggerId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MDIndex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int DailyDropID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityDaZhiGouReward> CreateFB_ActivityDaZhiGouReward(FlatBufferBuilder builder,
      int Id = 0,
      int TriggerId = -1,
      int MDIndex = -1,
      int ShowId = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      int DailyDropID = -1) {
    builder.StartObject(7);
    FB_ActivityDaZhiGouReward.AddDailyDropID(builder, DailyDropID);
    FB_ActivityDaZhiGouReward.AddItemCountList(builder, ItemCountList);
    FB_ActivityDaZhiGouReward.AddItemIdList(builder, ItemIdList);
    FB_ActivityDaZhiGouReward.AddShowId(builder, ShowId);
    FB_ActivityDaZhiGouReward.AddMDIndex(builder, MDIndex);
    FB_ActivityDaZhiGouReward.AddTriggerId(builder, TriggerId);
    FB_ActivityDaZhiGouReward.AddId(builder, Id);
    return FB_ActivityDaZhiGouReward.EndFB_ActivityDaZhiGouReward(builder);
  }

  public static void StartFB_ActivityDaZhiGouReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTriggerId(FlatBufferBuilder builder, int TriggerId) { builder.AddInt(1, TriggerId, -1); }
  public static void AddMDIndex(FlatBufferBuilder builder, int MDIndex) { builder.AddInt(2, MDIndex, -1); }
  public static void AddShowId(FlatBufferBuilder builder, int ShowId) { builder.AddInt(3, ShowId, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(4, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(5, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDailyDropID(FlatBufferBuilder builder, int DailyDropID) { builder.AddInt(6, DailyDropID, -1); }
  public static Offset<FB_ActivityDaZhiGouReward> EndFB_ActivityDaZhiGouReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityDaZhiGouReward>(o);
  }
};

public sealed class FB_ActivityDaZhiGouRewardContainer : Table {
  public static FB_ActivityDaZhiGouRewardContainer GetRootAsFB_ActivityDaZhiGouRewardContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityDaZhiGouRewardContainer(_bb, new FB_ActivityDaZhiGouRewardContainer()); }
  public static FB_ActivityDaZhiGouRewardContainer GetRootAsFB_ActivityDaZhiGouRewardContainer(ByteBuffer _bb, FB_ActivityDaZhiGouRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityDaZhiGouRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityDaZhiGouRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityDaZhiGouReward GetItems(int j) { return GetItems(new FB_ActivityDaZhiGouReward(), j); }
  public FB_ActivityDaZhiGouReward GetItems(FB_ActivityDaZhiGouReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityDaZhiGouRewardContainer> CreateFB_ActivityDaZhiGouRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityDaZhiGouRewardContainer.AddItems(builder, items);
    return FB_ActivityDaZhiGouRewardContainer.EndFB_ActivityDaZhiGouRewardContainer(builder);
  }

  public static void StartFB_ActivityDaZhiGouRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityDaZhiGouReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityDaZhiGouRewardContainer> EndFB_ActivityDaZhiGouRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityDaZhiGouRewardContainer>(o);
  }
  public static void FinishFB_ActivityDaZhiGouRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityDaZhiGouRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
