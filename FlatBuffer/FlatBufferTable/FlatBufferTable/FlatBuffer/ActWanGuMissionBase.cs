// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActWanGuMissionBase : Table {
  public static FB_ActWanGuMissionBase GetRootAsFB_ActWanGuMissionBase(ByteBuffer _bb) { return GetRootAsFB_ActWanGuMissionBase(_bb, new FB_ActWanGuMissionBase()); }
  public static FB_ActWanGuMissionBase GetRootAsFB_ActWanGuMissionBase(ByteBuffer _bb, FB_ActWanGuMissionBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActWanGuMissionBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrDictID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long GoalNum { get { int o = __offset(8); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int GetBonusIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int RewardPoint { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ClassID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SubClassID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActWanGuId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActWanGuMissionBase> CreateFB_ActWanGuMissionBase(FlatBufferBuilder builder,
      int ID = 0,
      int StrDictID = -1,
      long GoalNum = -1,
      VectorOffset BonusIDList = default(VectorOffset),
      VectorOffset BonusNumList = default(VectorOffset),
      int RewardPoint = -1,
      int ClassID = -1,
      int SubClassID = -1,
      int ActWanGuId = -1) {
    builder.StartObject(9);
    FB_ActWanGuMissionBase.AddGoalNum(builder, GoalNum);
    FB_ActWanGuMissionBase.AddActWanGuId(builder, ActWanGuId);
    FB_ActWanGuMissionBase.AddSubClassID(builder, SubClassID);
    FB_ActWanGuMissionBase.AddClassID(builder, ClassID);
    FB_ActWanGuMissionBase.AddRewardPoint(builder, RewardPoint);
    FB_ActWanGuMissionBase.AddBonusNumList(builder, BonusNumList);
    FB_ActWanGuMissionBase.AddBonusIDList(builder, BonusIDList);
    FB_ActWanGuMissionBase.AddStrDictID(builder, StrDictID);
    FB_ActWanGuMissionBase.AddID(builder, ID);
    return FB_ActWanGuMissionBase.EndFB_ActWanGuMissionBase(builder);
  }

  public static void StartFB_ActWanGuMissionBase(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStrDictID(FlatBufferBuilder builder, int StrDictID) { builder.AddInt(1, StrDictID, -1); }
  public static void AddGoalNum(FlatBufferBuilder builder, long GoalNum) { builder.AddLong(2, GoalNum, -1); }
  public static void AddBonusIDList(FlatBufferBuilder builder, VectorOffset BonusIDListOffset) { builder.AddOffset(3, BonusIDListOffset.Value, 0); }
  public static VectorOffset CreateBonusIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusNumList(FlatBufferBuilder builder, VectorOffset BonusNumListOffset) { builder.AddOffset(4, BonusNumListOffset.Value, 0); }
  public static VectorOffset CreateBonusNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardPoint(FlatBufferBuilder builder, int RewardPoint) { builder.AddInt(5, RewardPoint, -1); }
  public static void AddClassID(FlatBufferBuilder builder, int ClassID) { builder.AddInt(6, ClassID, -1); }
  public static void AddSubClassID(FlatBufferBuilder builder, int SubClassID) { builder.AddInt(7, SubClassID, -1); }
  public static void AddActWanGuId(FlatBufferBuilder builder, int ActWanGuId) { builder.AddInt(8, ActWanGuId, -1); }
  public static Offset<FB_ActWanGuMissionBase> EndFB_ActWanGuMissionBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuMissionBase>(o);
  }
};

public sealed class FB_ActWanGuMissionBaseContainer : Table {
  public static FB_ActWanGuMissionBaseContainer GetRootAsFB_ActWanGuMissionBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ActWanGuMissionBaseContainer(_bb, new FB_ActWanGuMissionBaseContainer()); }
  public static FB_ActWanGuMissionBaseContainer GetRootAsFB_ActWanGuMissionBaseContainer(ByteBuffer _bb, FB_ActWanGuMissionBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActWanGuMissionBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActWanGuMissionBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActWanGuMissionBase GetItems(int j) { return GetItems(new FB_ActWanGuMissionBase(), j); }
  public FB_ActWanGuMissionBase GetItems(FB_ActWanGuMissionBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuMissionBaseContainer> CreateFB_ActWanGuMissionBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActWanGuMissionBaseContainer.AddItems(builder, items);
    return FB_ActWanGuMissionBaseContainer.EndFB_ActWanGuMissionBaseContainer(builder);
  }

  public static void StartFB_ActWanGuMissionBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActWanGuMissionBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuMissionBaseContainer> EndFB_ActWanGuMissionBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuMissionBaseContainer>(o);
  }
  public static void FinishFB_ActWanGuMissionBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActWanGuMissionBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
