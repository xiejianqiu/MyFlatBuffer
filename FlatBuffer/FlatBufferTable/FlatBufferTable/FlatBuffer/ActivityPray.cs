// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityPray : Table {
  public static FB_ActivityPray GetRootAsFB_ActivityPray(ByteBuffer _bb) { return GetRootAsFB_ActivityPray(_bb, new FB_ActivityPray()); }
  public static FB_ActivityPray GetRootAsFB_ActivityPray(ByteBuffer _bb, FB_ActivityPray obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityPray __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TriggerId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMin { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMax { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PrayPrice { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PrayScore { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PrayManyTime { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardOnce { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardMany { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ButtonOnce { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ButtonMany { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ProbailityDisplay { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowItem { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItem { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityPray> CreateFB_ActivityPray(FlatBufferBuilder builder,
      int ID = 0,
      int TriggerId = -1,
      int WorldLvMin = -1,
      int WorldLvMax = -1,
      int PrayPrice = -1,
      int PrayScore = -1,
      int PrayManyTime = -1,
      int RewardOnce = -1,
      int RewardMany = -1,
      int ButtonOnce = -1,
      int ButtonMany = -1,
      int ProbailityDisplay = -1,
      int ShowItem = -1,
      int CostItem = -1) {
    builder.StartObject(14);
    FB_ActivityPray.AddCostItem(builder, CostItem);
    FB_ActivityPray.AddShowItem(builder, ShowItem);
    FB_ActivityPray.AddProbailityDisplay(builder, ProbailityDisplay);
    FB_ActivityPray.AddButtonMany(builder, ButtonMany);
    FB_ActivityPray.AddButtonOnce(builder, ButtonOnce);
    FB_ActivityPray.AddRewardMany(builder, RewardMany);
    FB_ActivityPray.AddRewardOnce(builder, RewardOnce);
    FB_ActivityPray.AddPrayManyTime(builder, PrayManyTime);
    FB_ActivityPray.AddPrayScore(builder, PrayScore);
    FB_ActivityPray.AddPrayPrice(builder, PrayPrice);
    FB_ActivityPray.AddWorldLvMax(builder, WorldLvMax);
    FB_ActivityPray.AddWorldLvMin(builder, WorldLvMin);
    FB_ActivityPray.AddTriggerId(builder, TriggerId);
    FB_ActivityPray.AddID(builder, ID);
    return FB_ActivityPray.EndFB_ActivityPray(builder);
  }

  public static void StartFB_ActivityPray(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTriggerId(FlatBufferBuilder builder, int TriggerId) { builder.AddInt(1, TriggerId, -1); }
  public static void AddWorldLvMin(FlatBufferBuilder builder, int WorldLvMin) { builder.AddInt(2, WorldLvMin, -1); }
  public static void AddWorldLvMax(FlatBufferBuilder builder, int WorldLvMax) { builder.AddInt(3, WorldLvMax, -1); }
  public static void AddPrayPrice(FlatBufferBuilder builder, int PrayPrice) { builder.AddInt(4, PrayPrice, -1); }
  public static void AddPrayScore(FlatBufferBuilder builder, int PrayScore) { builder.AddInt(5, PrayScore, -1); }
  public static void AddPrayManyTime(FlatBufferBuilder builder, int PrayManyTime) { builder.AddInt(6, PrayManyTime, -1); }
  public static void AddRewardOnce(FlatBufferBuilder builder, int RewardOnce) { builder.AddInt(7, RewardOnce, -1); }
  public static void AddRewardMany(FlatBufferBuilder builder, int RewardMany) { builder.AddInt(8, RewardMany, -1); }
  public static void AddButtonOnce(FlatBufferBuilder builder, int ButtonOnce) { builder.AddInt(9, ButtonOnce, -1); }
  public static void AddButtonMany(FlatBufferBuilder builder, int ButtonMany) { builder.AddInt(10, ButtonMany, -1); }
  public static void AddProbailityDisplay(FlatBufferBuilder builder, int ProbailityDisplay) { builder.AddInt(11, ProbailityDisplay, -1); }
  public static void AddShowItem(FlatBufferBuilder builder, int ShowItem) { builder.AddInt(12, ShowItem, -1); }
  public static void AddCostItem(FlatBufferBuilder builder, int CostItem) { builder.AddInt(13, CostItem, -1); }
  public static Offset<FB_ActivityPray> EndFB_ActivityPray(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPray>(o);
  }
};

public sealed class FB_ActivityPrayContainer : Table {
  public static FB_ActivityPrayContainer GetRootAsFB_ActivityPrayContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityPrayContainer(_bb, new FB_ActivityPrayContainer()); }
  public static FB_ActivityPrayContainer GetRootAsFB_ActivityPrayContainer(ByteBuffer _bb, FB_ActivityPrayContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityPrayContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityPrayContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityPray GetItems(int j) { return GetItems(new FB_ActivityPray(), j); }
  public FB_ActivityPray GetItems(FB_ActivityPray obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityPrayContainer> CreateFB_ActivityPrayContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityPrayContainer.AddItems(builder, items);
    return FB_ActivityPrayContainer.EndFB_ActivityPrayContainer(builder);
  }

  public static void StartFB_ActivityPrayContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityPray>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityPrayContainer> EndFB_ActivityPrayContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPrayContainer>(o);
  }
  public static void FinishFB_ActivityPrayContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityPrayContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
