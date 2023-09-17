// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OperationActivityList : Table {
  public static FB_OperationActivityList GetRootAsFB_OperationActivityList(ByteBuffer _bb) { return GetRootAsFB_OperationActivityList(_bb, new FB_OperationActivityList()); }
  public static FB_OperationActivityList GetRootAsFB_OperationActivityList(ByteBuffer _bb, FB_OperationActivityList obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OperationActivityList __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GiftType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenTimeType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenTime { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndTime { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardTime { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenLevel { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_OperationActivityList> CreateFB_OperationActivityList(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int GiftType = -1,
      int RefreshType = -1,
      int OpenTimeType = -1,
      int OpenTime = -1,
      int EndTime = -1,
      int RewardTime = -1,
      int OpenLevel = -1) {
    builder.StartObject(9);
    FB_OperationActivityList.AddOpenLevel(builder, OpenLevel);
    FB_OperationActivityList.AddRewardTime(builder, RewardTime);
    FB_OperationActivityList.AddEndTime(builder, EndTime);
    FB_OperationActivityList.AddOpenTime(builder, OpenTime);
    FB_OperationActivityList.AddOpenTimeType(builder, OpenTimeType);
    FB_OperationActivityList.AddRefreshType(builder, RefreshType);
    FB_OperationActivityList.AddGiftType(builder, GiftType);
    FB_OperationActivityList.AddName(builder, Name);
    FB_OperationActivityList.AddID(builder, ID);
    return FB_OperationActivityList.EndFB_OperationActivityList(builder);
  }

  public static void StartFB_OperationActivityList(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddGiftType(FlatBufferBuilder builder, int GiftType) { builder.AddInt(2, GiftType, -1); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(3, RefreshType, -1); }
  public static void AddOpenTimeType(FlatBufferBuilder builder, int OpenTimeType) { builder.AddInt(4, OpenTimeType, -1); }
  public static void AddOpenTime(FlatBufferBuilder builder, int OpenTime) { builder.AddInt(5, OpenTime, -1); }
  public static void AddEndTime(FlatBufferBuilder builder, int EndTime) { builder.AddInt(6, EndTime, -1); }
  public static void AddRewardTime(FlatBufferBuilder builder, int RewardTime) { builder.AddInt(7, RewardTime, -1); }
  public static void AddOpenLevel(FlatBufferBuilder builder, int OpenLevel) { builder.AddInt(8, OpenLevel, -1); }
  public static Offset<FB_OperationActivityList> EndFB_OperationActivityList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OperationActivityList>(o);
  }
};

public sealed class FB_OperationActivityListContainer : Table {
  public static FB_OperationActivityListContainer GetRootAsFB_OperationActivityListContainer(ByteBuffer _bb) { return GetRootAsFB_OperationActivityListContainer(_bb, new FB_OperationActivityListContainer()); }
  public static FB_OperationActivityListContainer GetRootAsFB_OperationActivityListContainer(ByteBuffer _bb, FB_OperationActivityListContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OperationActivityListContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OperationActivityListContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OperationActivityList GetItems(int j) { return GetItems(new FB_OperationActivityList(), j); }
  public FB_OperationActivityList GetItems(FB_OperationActivityList obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OperationActivityListContainer> CreateFB_OperationActivityListContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OperationActivityListContainer.AddItems(builder, items);
    return FB_OperationActivityListContainer.EndFB_OperationActivityListContainer(builder);
  }

  public static void StartFB_OperationActivityListContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OperationActivityList>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OperationActivityListContainer> EndFB_OperationActivityListContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OperationActivityListContainer>(o);
  }
  public static void FinishFB_OperationActivityListContainerBuffer(FlatBufferBuilder builder, Offset<FB_OperationActivityListContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
