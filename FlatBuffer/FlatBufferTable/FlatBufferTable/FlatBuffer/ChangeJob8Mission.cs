// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChangeJob8Mission : Table {
  public static FB_ChangeJob8Mission GetRootAsFB_ChangeJob8Mission(ByteBuffer _bb) { return GetRootAsFB_ChangeJob8Mission(_bb, new FB_ChangeJob8Mission()); }
  public static FB_ChangeJob8Mission GetRootAsFB_ChangeJob8Mission(ByteBuffer _bb, FB_ChangeJob8Mission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChangeJob8Mission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int MissionId { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MissionDesc { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissionTriggerType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissionTargetNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChangeJob8Mission> CreateFB_ChangeJob8Mission(FlatBufferBuilder builder,
      int MissionId = 0,
      int MissionDesc = -1,
      int MissionTriggerType = -1,
      int Param = -1,
      int MissionTargetNum = -1,
      int RewardId = -1,
      int RewardNum = -1) {
    builder.StartObject(7);
    FB_ChangeJob8Mission.AddRewardNum(builder, RewardNum);
    FB_ChangeJob8Mission.AddRewardId(builder, RewardId);
    FB_ChangeJob8Mission.AddMissionTargetNum(builder, MissionTargetNum);
    FB_ChangeJob8Mission.AddParam(builder, Param);
    FB_ChangeJob8Mission.AddMissionTriggerType(builder, MissionTriggerType);
    FB_ChangeJob8Mission.AddMissionDesc(builder, MissionDesc);
    FB_ChangeJob8Mission.AddMissionId(builder, MissionId);
    return FB_ChangeJob8Mission.EndFB_ChangeJob8Mission(builder);
  }

  public static void StartFB_ChangeJob8Mission(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddMissionId(FlatBufferBuilder builder, int MissionId) { builder.AddInt(0, MissionId, 0); }
  public static void AddMissionDesc(FlatBufferBuilder builder, int MissionDesc) { builder.AddInt(1, MissionDesc, -1); }
  public static void AddMissionTriggerType(FlatBufferBuilder builder, int MissionTriggerType) { builder.AddInt(2, MissionTriggerType, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(3, Param, -1); }
  public static void AddMissionTargetNum(FlatBufferBuilder builder, int MissionTargetNum) { builder.AddInt(4, MissionTargetNum, -1); }
  public static void AddRewardId(FlatBufferBuilder builder, int RewardId) { builder.AddInt(5, RewardId, -1); }
  public static void AddRewardNum(FlatBufferBuilder builder, int RewardNum) { builder.AddInt(6, RewardNum, -1); }
  public static Offset<FB_ChangeJob8Mission> EndFB_ChangeJob8Mission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJob8Mission>(o);
  }
};

public sealed class FB_ChangeJob8MissionContainer : Table {
  public static FB_ChangeJob8MissionContainer GetRootAsFB_ChangeJob8MissionContainer(ByteBuffer _bb) { return GetRootAsFB_ChangeJob8MissionContainer(_bb, new FB_ChangeJob8MissionContainer()); }
  public static FB_ChangeJob8MissionContainer GetRootAsFB_ChangeJob8MissionContainer(ByteBuffer _bb, FB_ChangeJob8MissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChangeJob8MissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChangeJob8MissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChangeJob8Mission GetItems(int j) { return GetItems(new FB_ChangeJob8Mission(), j); }
  public FB_ChangeJob8Mission GetItems(FB_ChangeJob8Mission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeJob8MissionContainer> CreateFB_ChangeJob8MissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChangeJob8MissionContainer.AddItems(builder, items);
    return FB_ChangeJob8MissionContainer.EndFB_ChangeJob8MissionContainer(builder);
  }

  public static void StartFB_ChangeJob8MissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChangeJob8Mission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeJob8MissionContainer> EndFB_ChangeJob8MissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJob8MissionContainer>(o);
  }
  public static void FinishFB_ChangeJob8MissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChangeJob8MissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
