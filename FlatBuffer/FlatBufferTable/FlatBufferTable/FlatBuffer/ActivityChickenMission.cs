// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityChickenMission : Table {
  public static FB_ActivityChickenMission GetRootAsFB_ActivityChickenMission(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenMission(_bb, new FB_ActivityChickenMission()); }
  public static FB_ActivityChickenMission GetRootAsFB_ActivityChickenMission(ByteBuffer _bb, FB_ActivityChickenMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityChickenMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string TaskName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MissionType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Score { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitTimes { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissionLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityChickenMission> CreateFB_ActivityChickenMission(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset TaskName = default(StringOffset),
      int MissionType = -1,
      int Score = 0,
      int limitTimes = -1,
      int DicId = -1,
      int MissionLevel = -1,
      int ItemId = -1,
      int ItemNum = -1) {
    builder.StartObject(9);
    FB_ActivityChickenMission.AddItemNum(builder, ItemNum);
    FB_ActivityChickenMission.AddItemId(builder, ItemId);
    FB_ActivityChickenMission.AddMissionLevel(builder, MissionLevel);
    FB_ActivityChickenMission.AddDicId(builder, DicId);
    FB_ActivityChickenMission.AddLimitTimes(builder, limitTimes);
    FB_ActivityChickenMission.AddScore(builder, Score);
    FB_ActivityChickenMission.AddMissionType(builder, MissionType);
    FB_ActivityChickenMission.AddTaskName(builder, TaskName);
    FB_ActivityChickenMission.AddID(builder, ID);
    return FB_ActivityChickenMission.EndFB_ActivityChickenMission(builder);
  }

  public static void StartFB_ActivityChickenMission(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTaskName(FlatBufferBuilder builder, StringOffset TaskNameOffset) { builder.AddOffset(1, TaskNameOffset.Value, 0); }
  public static void AddMissionType(FlatBufferBuilder builder, int MissionType) { builder.AddInt(2, MissionType, -1); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(3, Score, 0); }
  public static void AddLimitTimes(FlatBufferBuilder builder, int limitTimes) { builder.AddInt(4, limitTimes, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(5, DicId, -1); }
  public static void AddMissionLevel(FlatBufferBuilder builder, int MissionLevel) { builder.AddInt(6, MissionLevel, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(7, ItemId, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(8, ItemNum, -1); }
  public static Offset<FB_ActivityChickenMission> EndFB_ActivityChickenMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenMission>(o);
  }
};

public sealed class FB_ActivityChickenMissionContainer : Table {
  public static FB_ActivityChickenMissionContainer GetRootAsFB_ActivityChickenMissionContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenMissionContainer(_bb, new FB_ActivityChickenMissionContainer()); }
  public static FB_ActivityChickenMissionContainer GetRootAsFB_ActivityChickenMissionContainer(ByteBuffer _bb, FB_ActivityChickenMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityChickenMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityChickenMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityChickenMission GetItems(int j) { return GetItems(new FB_ActivityChickenMission(), j); }
  public FB_ActivityChickenMission GetItems(FB_ActivityChickenMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityChickenMissionContainer> CreateFB_ActivityChickenMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityChickenMissionContainer.AddItems(builder, items);
    return FB_ActivityChickenMissionContainer.EndFB_ActivityChickenMissionContainer(builder);
  }

  public static void StartFB_ActivityChickenMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityChickenMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityChickenMissionContainer> EndFB_ActivityChickenMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenMissionContainer>(o);
  }
  public static void FinishFB_ActivityChickenMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityChickenMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
