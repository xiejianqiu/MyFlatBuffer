// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MondayLuckDrawMissions : Table {
  public static FB_MondayLuckDrawMissions GetRootAsFB_MondayLuckDrawMissions(ByteBuffer _bb) { return GetRootAsFB_MondayLuckDrawMissions(_bb, new FB_MondayLuckDrawMissions()); }
  public static FB_MondayLuckDrawMissions GetRootAsFB_MondayLuckDrawMissions(ByteBuffer _bb, FB_MondayLuckDrawMissions obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MondayLuckDrawMissions __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TypeParam { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FunctionId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIInfoId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MondayLuckDrawMissions> CreateFB_MondayLuckDrawMissions(FlatBufferBuilder builder,
      int ID = 0,
      int StrId = -1,
      int RewardCount = 0,
      int TypeParam = 0,
      int FunctionId = -1,
      int RefreshType = -1,
      int UIInfoId = -1,
      int Param = -1) {
    builder.StartObject(8);
    FB_MondayLuckDrawMissions.AddParam(builder, Param);
    FB_MondayLuckDrawMissions.AddUIInfoId(builder, UIInfoId);
    FB_MondayLuckDrawMissions.AddRefreshType(builder, RefreshType);
    FB_MondayLuckDrawMissions.AddFunctionId(builder, FunctionId);
    FB_MondayLuckDrawMissions.AddTypeParam(builder, TypeParam);
    FB_MondayLuckDrawMissions.AddRewardCount(builder, RewardCount);
    FB_MondayLuckDrawMissions.AddStrId(builder, StrId);
    FB_MondayLuckDrawMissions.AddID(builder, ID);
    return FB_MondayLuckDrawMissions.EndFB_MondayLuckDrawMissions(builder);
  }

  public static void StartFB_MondayLuckDrawMissions(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStrId(FlatBufferBuilder builder, int StrId) { builder.AddInt(1, StrId, -1); }
  public static void AddRewardCount(FlatBufferBuilder builder, int RewardCount) { builder.AddInt(2, RewardCount, 0); }
  public static void AddTypeParam(FlatBufferBuilder builder, int TypeParam) { builder.AddInt(3, TypeParam, 0); }
  public static void AddFunctionId(FlatBufferBuilder builder, int FunctionId) { builder.AddInt(4, FunctionId, -1); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(5, RefreshType, -1); }
  public static void AddUIInfoId(FlatBufferBuilder builder, int UIInfoId) { builder.AddInt(6, UIInfoId, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(7, Param, -1); }
  public static Offset<FB_MondayLuckDrawMissions> EndFB_MondayLuckDrawMissions(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MondayLuckDrawMissions>(o);
  }
};

public sealed class FB_MondayLuckDrawMissionsContainer : Table {
  public static FB_MondayLuckDrawMissionsContainer GetRootAsFB_MondayLuckDrawMissionsContainer(ByteBuffer _bb) { return GetRootAsFB_MondayLuckDrawMissionsContainer(_bb, new FB_MondayLuckDrawMissionsContainer()); }
  public static FB_MondayLuckDrawMissionsContainer GetRootAsFB_MondayLuckDrawMissionsContainer(ByteBuffer _bb, FB_MondayLuckDrawMissionsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MondayLuckDrawMissionsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MondayLuckDrawMissionsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MondayLuckDrawMissions GetItems(int j) { return GetItems(new FB_MondayLuckDrawMissions(), j); }
  public FB_MondayLuckDrawMissions GetItems(FB_MondayLuckDrawMissions obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MondayLuckDrawMissionsContainer> CreateFB_MondayLuckDrawMissionsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MondayLuckDrawMissionsContainer.AddItems(builder, items);
    return FB_MondayLuckDrawMissionsContainer.EndFB_MondayLuckDrawMissionsContainer(builder);
  }

  public static void StartFB_MondayLuckDrawMissionsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MondayLuckDrawMissions>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MondayLuckDrawMissionsContainer> EndFB_MondayLuckDrawMissionsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MondayLuckDrawMissionsContainer>(o);
  }
  public static void FinishFB_MondayLuckDrawMissionsContainerBuffer(FlatBufferBuilder builder, Offset<FB_MondayLuckDrawMissionsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
