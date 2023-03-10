// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LuckyRollDailyMissions : Table {
  public static FB_LuckyRollDailyMissions GetRootAsFB_LuckyRollDailyMissions(ByteBuffer _bb) { return GetRootAsFB_LuckyRollDailyMissions(_bb, new FB_LuckyRollDailyMissions()); }
  public static FB_LuckyRollDailyMissions GetRootAsFB_LuckyRollDailyMissions(ByteBuffer _bb, FB_LuckyRollDailyMissions obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LuckyRollDailyMissions __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LogicType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardItem { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TypeParam { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FunctionId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIInfoId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LuckyRollDailyMissions> CreateFB_LuckyRollDailyMissions(FlatBufferBuilder builder,
      int ID = 0,
      int StrId = -1,
      int LogicType = -1,
      int RewardItem = 0,
      int RewardCount = 0,
      int TypeParam = 0,
      int FunctionId = -1,
      int UIInfoId = -1,
      int Param = -1) {
    builder.StartObject(9);
    FB_LuckyRollDailyMissions.AddParam(builder, Param);
    FB_LuckyRollDailyMissions.AddUIInfoId(builder, UIInfoId);
    FB_LuckyRollDailyMissions.AddFunctionId(builder, FunctionId);
    FB_LuckyRollDailyMissions.AddTypeParam(builder, TypeParam);
    FB_LuckyRollDailyMissions.AddRewardCount(builder, RewardCount);
    FB_LuckyRollDailyMissions.AddRewardItem(builder, RewardItem);
    FB_LuckyRollDailyMissions.AddLogicType(builder, LogicType);
    FB_LuckyRollDailyMissions.AddStrId(builder, StrId);
    FB_LuckyRollDailyMissions.AddID(builder, ID);
    return FB_LuckyRollDailyMissions.EndFB_LuckyRollDailyMissions(builder);
  }

  public static void StartFB_LuckyRollDailyMissions(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStrId(FlatBufferBuilder builder, int StrId) { builder.AddInt(1, StrId, -1); }
  public static void AddLogicType(FlatBufferBuilder builder, int LogicType) { builder.AddInt(2, LogicType, -1); }
  public static void AddRewardItem(FlatBufferBuilder builder, int RewardItem) { builder.AddInt(3, RewardItem, 0); }
  public static void AddRewardCount(FlatBufferBuilder builder, int RewardCount) { builder.AddInt(4, RewardCount, 0); }
  public static void AddTypeParam(FlatBufferBuilder builder, int TypeParam) { builder.AddInt(5, TypeParam, 0); }
  public static void AddFunctionId(FlatBufferBuilder builder, int FunctionId) { builder.AddInt(6, FunctionId, -1); }
  public static void AddUIInfoId(FlatBufferBuilder builder, int UIInfoId) { builder.AddInt(7, UIInfoId, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(8, Param, -1); }
  public static Offset<FB_LuckyRollDailyMissions> EndFB_LuckyRollDailyMissions(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LuckyRollDailyMissions>(o);
  }
};

public sealed class FB_LuckyRollDailyMissionsContainer : Table {
  public static FB_LuckyRollDailyMissionsContainer GetRootAsFB_LuckyRollDailyMissionsContainer(ByteBuffer _bb) { return GetRootAsFB_LuckyRollDailyMissionsContainer(_bb, new FB_LuckyRollDailyMissionsContainer()); }
  public static FB_LuckyRollDailyMissionsContainer GetRootAsFB_LuckyRollDailyMissionsContainer(ByteBuffer _bb, FB_LuckyRollDailyMissionsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LuckyRollDailyMissionsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LuckyRollDailyMissionsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LuckyRollDailyMissions GetItems(int j) { return GetItems(new FB_LuckyRollDailyMissions(), j); }
  public FB_LuckyRollDailyMissions GetItems(FB_LuckyRollDailyMissions obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LuckyRollDailyMissionsContainer> CreateFB_LuckyRollDailyMissionsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LuckyRollDailyMissionsContainer.AddItems(builder, items);
    return FB_LuckyRollDailyMissionsContainer.EndFB_LuckyRollDailyMissionsContainer(builder);
  }

  public static void StartFB_LuckyRollDailyMissionsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LuckyRollDailyMissions>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LuckyRollDailyMissionsContainer> EndFB_LuckyRollDailyMissionsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LuckyRollDailyMissionsContainer>(o);
  }
  public static void FinishFB_LuckyRollDailyMissionsContainerBuffer(FlatBufferBuilder builder, Offset<FB_LuckyRollDailyMissionsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
