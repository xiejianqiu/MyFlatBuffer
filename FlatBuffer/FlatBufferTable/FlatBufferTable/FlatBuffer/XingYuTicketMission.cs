// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYuTicketMission : Table {
  public static FB_XingYuTicketMission GetRootAsFB_XingYuTicketMission(ByteBuffer _bb) { return GetRootAsFB_XingYuTicketMission(_bb, new FB_XingYuTicketMission()); }
  public static FB_XingYuTicketMission GetRootAsFB_XingYuTicketMission(ByteBuffer _bb, FB_XingYuTicketMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYuTicketMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MissionDesc { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UI { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UiNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetStageList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StageListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetStageRewardList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StageRewardListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int MIssionType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Weight { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Show { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XingYuTicketMission> CreateFB_XingYuTicketMission(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset MissionDesc = default(StringOffset),
      int Type = -1,
      int UI = -1,
      int UiNum = -1,
      VectorOffset StageList = default(VectorOffset),
      VectorOffset StageRewardList = default(VectorOffset),
      int MIssionType = -1,
      int Weight = -1,
      int Show = -1) {
    builder.StartObject(10);
    FB_XingYuTicketMission.AddShow(builder, Show);
    FB_XingYuTicketMission.AddWeight(builder, Weight);
    FB_XingYuTicketMission.AddMIssionType(builder, MIssionType);
    FB_XingYuTicketMission.AddStageRewardList(builder, StageRewardList);
    FB_XingYuTicketMission.AddStageList(builder, StageList);
    FB_XingYuTicketMission.AddUiNum(builder, UiNum);
    FB_XingYuTicketMission.AddUI(builder, UI);
    FB_XingYuTicketMission.AddType(builder, Type);
    FB_XingYuTicketMission.AddMissionDesc(builder, MissionDesc);
    FB_XingYuTicketMission.AddID(builder, ID);
    return FB_XingYuTicketMission.EndFB_XingYuTicketMission(builder);
  }

  public static void StartFB_XingYuTicketMission(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMissionDesc(FlatBufferBuilder builder, StringOffset MissionDescOffset) { builder.AddOffset(1, MissionDescOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddUI(FlatBufferBuilder builder, int UI) { builder.AddInt(3, UI, -1); }
  public static void AddUiNum(FlatBufferBuilder builder, int UiNum) { builder.AddInt(4, UiNum, -1); }
  public static void AddStageList(FlatBufferBuilder builder, VectorOffset StageListOffset) { builder.AddOffset(5, StageListOffset.Value, 0); }
  public static VectorOffset CreateStageListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStageListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStageRewardList(FlatBufferBuilder builder, VectorOffset StageRewardListOffset) { builder.AddOffset(6, StageRewardListOffset.Value, 0); }
  public static VectorOffset CreateStageRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStageRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMIssionType(FlatBufferBuilder builder, int MIssionType) { builder.AddInt(7, MIssionType, -1); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(8, Weight, -1); }
  public static void AddShow(FlatBufferBuilder builder, int Show) { builder.AddInt(9, Show, -1); }
  public static Offset<FB_XingYuTicketMission> EndFB_XingYuTicketMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuTicketMission>(o);
  }
};

public sealed class FB_XingYuTicketMissionContainer : Table {
  public static FB_XingYuTicketMissionContainer GetRootAsFB_XingYuTicketMissionContainer(ByteBuffer _bb) { return GetRootAsFB_XingYuTicketMissionContainer(_bb, new FB_XingYuTicketMissionContainer()); }
  public static FB_XingYuTicketMissionContainer GetRootAsFB_XingYuTicketMissionContainer(ByteBuffer _bb, FB_XingYuTicketMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYuTicketMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYuTicketMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYuTicketMission GetItems(int j) { return GetItems(new FB_XingYuTicketMission(), j); }
  public FB_XingYuTicketMission GetItems(FB_XingYuTicketMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuTicketMissionContainer> CreateFB_XingYuTicketMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYuTicketMissionContainer.AddItems(builder, items);
    return FB_XingYuTicketMissionContainer.EndFB_XingYuTicketMissionContainer(builder);
  }

  public static void StartFB_XingYuTicketMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYuTicketMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuTicketMissionContainer> EndFB_XingYuTicketMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuTicketMissionContainer>(o);
  }
  public static void FinishFB_XingYuTicketMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYuTicketMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
