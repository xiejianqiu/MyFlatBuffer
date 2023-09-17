// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenQiRenZhuType : Table {
  public static FB_ShenQiRenZhuType GetRootAsFB_ShenQiRenZhuType(ByteBuffer _bb) { return GetRootAsFB_ShenQiRenZhuType(_bb, new FB_ShenQiRenZhuType()); }
  public static FB_ShenQiRenZhuType GetRootAsFB_ShenQiRenZhuType(ByteBuffer _bb, FB_ShenQiRenZhuType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenQiRenZhuType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DicStrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoalType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoalNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewaredId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewaredNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool ShowRewardNum { get { int o = __offset(18); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int GetRewardItemIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenQiRenZhuType> CreateFB_ShenQiRenZhuType(FlatBufferBuilder builder,
      int ID = 0,
      int DicStrId = -1,
      int GoalType = -1,
      int GoalNum = -1,
      int Param = -1,
      int RewaredId = -1,
      int RewaredNum = -1,
      bool ShowRewardNum = true,
      VectorOffset RewardItemIdList = default(VectorOffset)) {
    builder.StartObject(9);
    FB_ShenQiRenZhuType.AddRewardItemIdList(builder, RewardItemIdList);
    FB_ShenQiRenZhuType.AddRewaredNum(builder, RewaredNum);
    FB_ShenQiRenZhuType.AddRewaredId(builder, RewaredId);
    FB_ShenQiRenZhuType.AddParam(builder, Param);
    FB_ShenQiRenZhuType.AddGoalNum(builder, GoalNum);
    FB_ShenQiRenZhuType.AddGoalType(builder, GoalType);
    FB_ShenQiRenZhuType.AddDicStrId(builder, DicStrId);
    FB_ShenQiRenZhuType.AddID(builder, ID);
    FB_ShenQiRenZhuType.AddShowRewardNum(builder, ShowRewardNum);
    return FB_ShenQiRenZhuType.EndFB_ShenQiRenZhuType(builder);
  }

  public static void StartFB_ShenQiRenZhuType(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDicStrId(FlatBufferBuilder builder, int DicStrId) { builder.AddInt(1, DicStrId, -1); }
  public static void AddGoalType(FlatBufferBuilder builder, int GoalType) { builder.AddInt(2, GoalType, -1); }
  public static void AddGoalNum(FlatBufferBuilder builder, int GoalNum) { builder.AddInt(3, GoalNum, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(4, Param, -1); }
  public static void AddRewaredId(FlatBufferBuilder builder, int RewaredId) { builder.AddInt(5, RewaredId, -1); }
  public static void AddRewaredNum(FlatBufferBuilder builder, int RewaredNum) { builder.AddInt(6, RewaredNum, -1); }
  public static void AddShowRewardNum(FlatBufferBuilder builder, bool ShowRewardNum) { builder.AddBool(7, ShowRewardNum, true); }
  public static void AddRewardItemIdList(FlatBufferBuilder builder, VectorOffset RewardItemIdListOffset) { builder.AddOffset(8, RewardItemIdListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenQiRenZhuType> EndFB_ShenQiRenZhuType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenQiRenZhuType>(o);
  }
};

public sealed class FB_ShenQiRenZhuTypeContainer : Table {
  public static FB_ShenQiRenZhuTypeContainer GetRootAsFB_ShenQiRenZhuTypeContainer(ByteBuffer _bb) { return GetRootAsFB_ShenQiRenZhuTypeContainer(_bb, new FB_ShenQiRenZhuTypeContainer()); }
  public static FB_ShenQiRenZhuTypeContainer GetRootAsFB_ShenQiRenZhuTypeContainer(ByteBuffer _bb, FB_ShenQiRenZhuTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenQiRenZhuTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenQiRenZhuTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenQiRenZhuType GetItems(int j) { return GetItems(new FB_ShenQiRenZhuType(), j); }
  public FB_ShenQiRenZhuType GetItems(FB_ShenQiRenZhuType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenQiRenZhuTypeContainer> CreateFB_ShenQiRenZhuTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenQiRenZhuTypeContainer.AddItems(builder, items);
    return FB_ShenQiRenZhuTypeContainer.EndFB_ShenQiRenZhuTypeContainer(builder);
  }

  public static void StartFB_ShenQiRenZhuTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenQiRenZhuType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenQiRenZhuTypeContainer> EndFB_ShenQiRenZhuTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenQiRenZhuTypeContainer>(o);
  }
  public static void FinishFB_ShenQiRenZhuTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenQiRenZhuTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
