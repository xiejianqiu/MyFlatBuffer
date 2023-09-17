// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AchievementBase : Table {
  public static FB_AchievementBase GetRootAsFB_AchievementBase(ByteBuffer _bb) { return GetRootAsFB_AchievementBase(_bb, new FB_AchievementBase()); }
  public static FB_AchievementBase GetRootAsFB_AchievementBase(ByteBuffer _bb, FB_AchievementBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AchievementBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

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
  public int AchievementPoint { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ClassID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SubClassID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool ShowAtClient { get { int o = __offset(32); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsSendSystemShout { get { int o = __offset(34); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool ShowNearList { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_AchievementBase> CreateFB_AchievementBase(FlatBufferBuilder builder,
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
      VectorOffset BonusNumList = default(VectorOffset),
      int AchievementPoint = -1,
      int ClassID = -1,
      int SubClassID = -1,
      bool ShowAtClient = false,
      bool IsSendSystemShout = false,
      bool ShowNearList = false) {
    builder.StartObject(17);
    FB_AchievementBase.AddGoalNum(builder, GoalNum);
    FB_AchievementBase.AddSubClassID(builder, SubClassID);
    FB_AchievementBase.AddClassID(builder, ClassID);
    FB_AchievementBase.AddAchievementPoint(builder, AchievementPoint);
    FB_AchievementBase.AddBonusNumList(builder, BonusNumList);
    FB_AchievementBase.AddBonusIDList(builder, BonusIDList);
    FB_AchievementBase.AddBonusTypeList(builder, BonusTypeList);
    FB_AchievementBase.AddParamTypeList(builder, ParamTypeList);
    FB_AchievementBase.AddParamList(builder, ParamList);
    FB_AchievementBase.AddType(builder, Type);
    FB_AchievementBase.AddIcon(builder, Icon);
    FB_AchievementBase.AddStrDictID(builder, StrDictID);
    FB_AchievementBase.AddName(builder, Name);
    FB_AchievementBase.AddID(builder, ID);
    FB_AchievementBase.AddShowNearList(builder, ShowNearList);
    FB_AchievementBase.AddIsSendSystemShout(builder, IsSendSystemShout);
    FB_AchievementBase.AddShowAtClient(builder, ShowAtClient);
    return FB_AchievementBase.EndFB_AchievementBase(builder);
  }

  public static void StartFB_AchievementBase(FlatBufferBuilder builder) { builder.StartObject(17); }
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
  public static void AddAchievementPoint(FlatBufferBuilder builder, int AchievementPoint) { builder.AddInt(11, AchievementPoint, -1); }
  public static void AddClassID(FlatBufferBuilder builder, int ClassID) { builder.AddInt(12, ClassID, -1); }
  public static void AddSubClassID(FlatBufferBuilder builder, int SubClassID) { builder.AddInt(13, SubClassID, -1); }
  public static void AddShowAtClient(FlatBufferBuilder builder, bool ShowAtClient) { builder.AddBool(14, ShowAtClient, false); }
  public static void AddIsSendSystemShout(FlatBufferBuilder builder, bool IsSendSystemShout) { builder.AddBool(15, IsSendSystemShout, false); }
  public static void AddShowNearList(FlatBufferBuilder builder, bool ShowNearList) { builder.AddBool(16, ShowNearList, false); }
  public static Offset<FB_AchievementBase> EndFB_AchievementBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementBase>(o);
  }
};

public sealed class FB_AchievementBaseContainer : Table {
  public static FB_AchievementBaseContainer GetRootAsFB_AchievementBaseContainer(ByteBuffer _bb) { return GetRootAsFB_AchievementBaseContainer(_bb, new FB_AchievementBaseContainer()); }
  public static FB_AchievementBaseContainer GetRootAsFB_AchievementBaseContainer(ByteBuffer _bb, FB_AchievementBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AchievementBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AchievementBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AchievementBase GetItems(int j) { return GetItems(new FB_AchievementBase(), j); }
  public FB_AchievementBase GetItems(FB_AchievementBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AchievementBaseContainer> CreateFB_AchievementBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AchievementBaseContainer.AddItems(builder, items);
    return FB_AchievementBaseContainer.EndFB_AchievementBaseContainer(builder);
  }

  public static void StartFB_AchievementBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AchievementBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AchievementBaseContainer> EndFB_AchievementBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementBaseContainer>(o);
  }
  public static void FinishFB_AchievementBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_AchievementBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
