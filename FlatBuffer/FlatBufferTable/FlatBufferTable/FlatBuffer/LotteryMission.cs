// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LotteryMission : Table {
  public static FB_LotteryMission GetRootAsFB_LotteryMission(ByteBuffer _bb) { return GetRootAsFB_LotteryMission(_bb, new FB_LotteryMission()); }
  public static FB_LotteryMission GetRootAsFB_LotteryMission(ByteBuffer _bb, FB_LotteryMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LotteryMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StrDictID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long GoalNum { get { int o = __offset(14); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public long GetParamList(int j) { int o = __offset(16); return o != 0 ? bb.GetLong(__vector(o) + j * 8) : (long)0; }
  public int ParamListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetParamTypeList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamTypeListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusTypeList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusTypeListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusIDList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusIDListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusNumList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusNumListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LotteryMission> CreateFB_LotteryMission(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int StrDictID = -1,
      StringOffset Icon = default(StringOffset),
      int Type = -1,
      long GoalNum = -1,
      VectorOffset ParamList = default(VectorOffset),
      VectorOffset ParamTypeList = default(VectorOffset),
      VectorOffset BonusTypeList = default(VectorOffset),
      VectorOffset BonusIDList = default(VectorOffset),
      VectorOffset BonusNumList = default(VectorOffset)) {
    builder.StartObject(11);
    FB_LotteryMission.AddGoalNum(builder, GoalNum);
    FB_LotteryMission.AddBonusNumList(builder, BonusNumList);
    FB_LotteryMission.AddBonusIDList(builder, BonusIDList);
    FB_LotteryMission.AddBonusTypeList(builder, BonusTypeList);
    FB_LotteryMission.AddParamTypeList(builder, ParamTypeList);
    FB_LotteryMission.AddParamList(builder, ParamList);
    FB_LotteryMission.AddType(builder, Type);
    FB_LotteryMission.AddIcon(builder, Icon);
    FB_LotteryMission.AddStrDictID(builder, StrDictID);
    FB_LotteryMission.AddName(builder, Name);
    FB_LotteryMission.AddID(builder, ID);
    return FB_LotteryMission.EndFB_LotteryMission(builder);
  }

  public static void StartFB_LotteryMission(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddStrDictID(FlatBufferBuilder builder, int StrDictID) { builder.AddInt(2, StrDictID, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(4, Type, -1); }
  public static void AddGoalNum(FlatBufferBuilder builder, long GoalNum) { builder.AddLong(5, GoalNum, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(6, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddParamTypeList(FlatBufferBuilder builder, VectorOffset ParamTypeListOffset) { builder.AddOffset(7, ParamTypeListOffset.Value, 0); }
  public static VectorOffset CreateParamTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusTypeList(FlatBufferBuilder builder, VectorOffset BonusTypeListOffset) { builder.AddOffset(8, BonusTypeListOffset.Value, 0); }
  public static VectorOffset CreateBonusTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusIDList(FlatBufferBuilder builder, VectorOffset BonusIDListOffset) { builder.AddOffset(9, BonusIDListOffset.Value, 0); }
  public static VectorOffset CreateBonusIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusNumList(FlatBufferBuilder builder, VectorOffset BonusNumListOffset) { builder.AddOffset(10, BonusNumListOffset.Value, 0); }
  public static VectorOffset CreateBonusNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LotteryMission> EndFB_LotteryMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LotteryMission>(o);
  }
};

public sealed class FB_LotteryMissionContainer : Table {
  public static FB_LotteryMissionContainer GetRootAsFB_LotteryMissionContainer(ByteBuffer _bb) { return GetRootAsFB_LotteryMissionContainer(_bb, new FB_LotteryMissionContainer()); }
  public static FB_LotteryMissionContainer GetRootAsFB_LotteryMissionContainer(ByteBuffer _bb, FB_LotteryMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LotteryMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LotteryMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LotteryMission GetItems(int j) { return GetItems(new FB_LotteryMission(), j); }
  public FB_LotteryMission GetItems(FB_LotteryMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LotteryMissionContainer> CreateFB_LotteryMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LotteryMissionContainer.AddItems(builder, items);
    return FB_LotteryMissionContainer.EndFB_LotteryMissionContainer(builder);
  }

  public static void StartFB_LotteryMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LotteryMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LotteryMissionContainer> EndFB_LotteryMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LotteryMissionContainer>(o);
  }
  public static void FinishFB_LotteryMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_LotteryMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
