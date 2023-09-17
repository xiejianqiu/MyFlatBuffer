// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TreasureHuntMissions : Table {
  public static FB_TreasureHuntMissions GetRootAsFB_TreasureHuntMissions(ByteBuffer _bb) { return GetRootAsFB_TreasureHuntMissions(_bb, new FB_TreasureHuntMissions()); }
  public static FB_TreasureHuntMissions GetRootAsFB_TreasureHuntMissions(ByteBuffer _bb, FB_TreasureHuntMissions obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TreasureHuntMissions __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StrId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMin { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMax { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LogicType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardItem { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TypeParam { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FunctionId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIInfoId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TreasureHuntMissions> CreateFB_TreasureHuntMissions(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int StrId = -1,
      int WorldLvMin = -1,
      int WorldLvMax = -1,
      int LogicType = -1,
      int RewardItem = 0,
      int RewardCount = 0,
      int TypeParam = 0,
      int FunctionId = -1,
      int UIInfoId = -1,
      int Param = -1) {
    builder.StartObject(12);
    FB_TreasureHuntMissions.AddParam(builder, Param);
    FB_TreasureHuntMissions.AddUIInfoId(builder, UIInfoId);
    FB_TreasureHuntMissions.AddFunctionId(builder, FunctionId);
    FB_TreasureHuntMissions.AddTypeParam(builder, TypeParam);
    FB_TreasureHuntMissions.AddRewardCount(builder, RewardCount);
    FB_TreasureHuntMissions.AddRewardItem(builder, RewardItem);
    FB_TreasureHuntMissions.AddLogicType(builder, LogicType);
    FB_TreasureHuntMissions.AddWorldLvMax(builder, WorldLvMax);
    FB_TreasureHuntMissions.AddWorldLvMin(builder, WorldLvMin);
    FB_TreasureHuntMissions.AddStrId(builder, StrId);
    FB_TreasureHuntMissions.AddName(builder, Name);
    FB_TreasureHuntMissions.AddID(builder, ID);
    return FB_TreasureHuntMissions.EndFB_TreasureHuntMissions(builder);
  }

  public static void StartFB_TreasureHuntMissions(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddStrId(FlatBufferBuilder builder, int StrId) { builder.AddInt(2, StrId, -1); }
  public static void AddWorldLvMin(FlatBufferBuilder builder, int WorldLvMin) { builder.AddInt(3, WorldLvMin, -1); }
  public static void AddWorldLvMax(FlatBufferBuilder builder, int WorldLvMax) { builder.AddInt(4, WorldLvMax, -1); }
  public static void AddLogicType(FlatBufferBuilder builder, int LogicType) { builder.AddInt(5, LogicType, -1); }
  public static void AddRewardItem(FlatBufferBuilder builder, int RewardItem) { builder.AddInt(6, RewardItem, 0); }
  public static void AddRewardCount(FlatBufferBuilder builder, int RewardCount) { builder.AddInt(7, RewardCount, 0); }
  public static void AddTypeParam(FlatBufferBuilder builder, int TypeParam) { builder.AddInt(8, TypeParam, 0); }
  public static void AddFunctionId(FlatBufferBuilder builder, int FunctionId) { builder.AddInt(9, FunctionId, -1); }
  public static void AddUIInfoId(FlatBufferBuilder builder, int UIInfoId) { builder.AddInt(10, UIInfoId, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(11, Param, -1); }
  public static Offset<FB_TreasureHuntMissions> EndFB_TreasureHuntMissions(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TreasureHuntMissions>(o);
  }
};

public sealed class FB_TreasureHuntMissionsContainer : Table {
  public static FB_TreasureHuntMissionsContainer GetRootAsFB_TreasureHuntMissionsContainer(ByteBuffer _bb) { return GetRootAsFB_TreasureHuntMissionsContainer(_bb, new FB_TreasureHuntMissionsContainer()); }
  public static FB_TreasureHuntMissionsContainer GetRootAsFB_TreasureHuntMissionsContainer(ByteBuffer _bb, FB_TreasureHuntMissionsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TreasureHuntMissionsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TreasureHuntMissionsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TreasureHuntMissions GetItems(int j) { return GetItems(new FB_TreasureHuntMissions(), j); }
  public FB_TreasureHuntMissions GetItems(FB_TreasureHuntMissions obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TreasureHuntMissionsContainer> CreateFB_TreasureHuntMissionsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TreasureHuntMissionsContainer.AddItems(builder, items);
    return FB_TreasureHuntMissionsContainer.EndFB_TreasureHuntMissionsContainer(builder);
  }

  public static void StartFB_TreasureHuntMissionsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TreasureHuntMissions>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TreasureHuntMissionsContainer> EndFB_TreasureHuntMissionsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TreasureHuntMissionsContainer>(o);
  }
  public static void FinishFB_TreasureHuntMissionsContainerBuffer(FlatBufferBuilder builder, Offset<FB_TreasureHuntMissionsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
