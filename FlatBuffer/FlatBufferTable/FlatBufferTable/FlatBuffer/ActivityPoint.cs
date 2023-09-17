// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityPoint : Table {
  public static FB_ActivityPoint GetRootAsFB_ActivityPoint(ByteBuffer _bb) { return GetRootAsFB_ActivityPoint(_bb, new FB_ActivityPoint()); }
  public static FB_ActivityPoint GetRootAsFB_ActivityPoint(ByteBuffer _bb, FB_ActivityPoint obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityPoint __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardPoint { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int RewardID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLevel { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityPoint> CreateFB_ActivityPoint(FlatBufferBuilder builder,
      int ID = 0,
      int RewardPoint = -1,
      StringOffset Icon = default(StringOffset),
      int RewardID = -1,
      int RewardCount = -1,
      int MinLevel = -1,
      int MaxLevel = -1) {
    builder.StartObject(7);
    FB_ActivityPoint.AddMaxLevel(builder, MaxLevel);
    FB_ActivityPoint.AddMinLevel(builder, MinLevel);
    FB_ActivityPoint.AddRewardCount(builder, RewardCount);
    FB_ActivityPoint.AddRewardID(builder, RewardID);
    FB_ActivityPoint.AddIcon(builder, Icon);
    FB_ActivityPoint.AddRewardPoint(builder, RewardPoint);
    FB_ActivityPoint.AddID(builder, ID);
    return FB_ActivityPoint.EndFB_ActivityPoint(builder);
  }

  public static void StartFB_ActivityPoint(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRewardPoint(FlatBufferBuilder builder, int RewardPoint) { builder.AddInt(1, RewardPoint, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddRewardID(FlatBufferBuilder builder, int RewardID) { builder.AddInt(3, RewardID, -1); }
  public static void AddRewardCount(FlatBufferBuilder builder, int RewardCount) { builder.AddInt(4, RewardCount, -1); }
  public static void AddMinLevel(FlatBufferBuilder builder, int MinLevel) { builder.AddInt(5, MinLevel, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(6, MaxLevel, -1); }
  public static Offset<FB_ActivityPoint> EndFB_ActivityPoint(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPoint>(o);
  }
};

public sealed class FB_ActivityPointContainer : Table {
  public static FB_ActivityPointContainer GetRootAsFB_ActivityPointContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityPointContainer(_bb, new FB_ActivityPointContainer()); }
  public static FB_ActivityPointContainer GetRootAsFB_ActivityPointContainer(ByteBuffer _bb, FB_ActivityPointContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityPointContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityPointContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityPoint GetItems(int j) { return GetItems(new FB_ActivityPoint(), j); }
  public FB_ActivityPoint GetItems(FB_ActivityPoint obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityPointContainer> CreateFB_ActivityPointContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityPointContainer.AddItems(builder, items);
    return FB_ActivityPointContainer.EndFB_ActivityPointContainer(builder);
  }

  public static void StartFB_ActivityPointContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityPointContainer> EndFB_ActivityPointContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPointContainer>(o);
  }
  public static void FinishFB_ActivityPointContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityPointContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
