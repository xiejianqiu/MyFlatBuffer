// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TeamPlatform : Table {
  public static FB_TeamPlatform GetRootAsFB_TeamPlatform(ByteBuffer _bb) { return GetRootAsFB_TeamPlatform(_bb, new FB_TeamPlatform()); }
  public static FB_TeamPlatform GetRootAsFB_TeamPlatform(ByteBuffer _bb, FB_TeamPlatform obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TeamPlatform __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ClassID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool ContainChild { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int MinLevelLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevelLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetOpenTimeList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OpenTimeListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetEndTimeList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EndTimeListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int DefaultMin { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DefaultMax { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PlayerLimitID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TimeLimitID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneClassID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float PosX { get { int o = __offset(34); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(36); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int RolebaseID { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowLevelTips { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowAddHp { get { int o = __offset(42); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsRobot { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int WaitingTime { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinRobotId { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxRobotId { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChangeJobLimit { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TeamPlatform> CreateFB_TeamPlatform(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int ClassID = -1,
      bool ContainChild = false,
      int MinLevelLimit = -1,
      int MaxLevelLimit = -1,
      int OpenType = -1,
      VectorOffset OpenTimeList = default(VectorOffset),
      VectorOffset EndTimeList = default(VectorOffset),
      int DefaultMin = 0,
      int DefaultMax = 0,
      int PlayerLimitID = -1,
      int TimeLimitID = -1,
      int CopySceneID = -1,
      int SceneClassID = -1,
      float PosX = 0,
      float PosZ = 0,
      int RolebaseID = -1,
      int LowLevelTips = -1,
      bool IsShowAddHp = false,
      bool IsRobot = false,
      int WaitingTime = -1,
      int MinRobotId = -1,
      int MaxRobotId = -1,
      int ChangeJobLimit = -1) {
    builder.StartObject(25);
    FB_TeamPlatform.AddChangeJobLimit(builder, ChangeJobLimit);
    FB_TeamPlatform.AddMaxRobotId(builder, MaxRobotId);
    FB_TeamPlatform.AddMinRobotId(builder, MinRobotId);
    FB_TeamPlatform.AddWaitingTime(builder, WaitingTime);
    FB_TeamPlatform.AddLowLevelTips(builder, LowLevelTips);
    FB_TeamPlatform.AddRolebaseID(builder, RolebaseID);
    FB_TeamPlatform.AddPosZ(builder, PosZ);
    FB_TeamPlatform.AddPosX(builder, PosX);
    FB_TeamPlatform.AddSceneClassID(builder, SceneClassID);
    FB_TeamPlatform.AddCopySceneID(builder, CopySceneID);
    FB_TeamPlatform.AddTimeLimitID(builder, TimeLimitID);
    FB_TeamPlatform.AddPlayerLimitID(builder, PlayerLimitID);
    FB_TeamPlatform.AddDefaultMax(builder, DefaultMax);
    FB_TeamPlatform.AddDefaultMin(builder, DefaultMin);
    FB_TeamPlatform.AddEndTimeList(builder, EndTimeList);
    FB_TeamPlatform.AddOpenTimeList(builder, OpenTimeList);
    FB_TeamPlatform.AddOpenType(builder, OpenType);
    FB_TeamPlatform.AddMaxLevelLimit(builder, MaxLevelLimit);
    FB_TeamPlatform.AddMinLevelLimit(builder, MinLevelLimit);
    FB_TeamPlatform.AddClassID(builder, ClassID);
    FB_TeamPlatform.AddName(builder, Name);
    FB_TeamPlatform.AddID(builder, ID);
    FB_TeamPlatform.AddIsRobot(builder, IsRobot);
    FB_TeamPlatform.AddIsShowAddHp(builder, IsShowAddHp);
    FB_TeamPlatform.AddContainChild(builder, ContainChild);
    return FB_TeamPlatform.EndFB_TeamPlatform(builder);
  }

  public static void StartFB_TeamPlatform(FlatBufferBuilder builder) { builder.StartObject(25); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddClassID(FlatBufferBuilder builder, int ClassID) { builder.AddInt(2, ClassID, -1); }
  public static void AddContainChild(FlatBufferBuilder builder, bool ContainChild) { builder.AddBool(3, ContainChild, false); }
  public static void AddMinLevelLimit(FlatBufferBuilder builder, int MinLevelLimit) { builder.AddInt(4, MinLevelLimit, -1); }
  public static void AddMaxLevelLimit(FlatBufferBuilder builder, int MaxLevelLimit) { builder.AddInt(5, MaxLevelLimit, -1); }
  public static void AddOpenType(FlatBufferBuilder builder, int OpenType) { builder.AddInt(6, OpenType, -1); }
  public static void AddOpenTimeList(FlatBufferBuilder builder, VectorOffset OpenTimeListOffset) { builder.AddOffset(7, OpenTimeListOffset.Value, 0); }
  public static VectorOffset CreateOpenTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOpenTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEndTimeList(FlatBufferBuilder builder, VectorOffset EndTimeListOffset) { builder.AddOffset(8, EndTimeListOffset.Value, 0); }
  public static VectorOffset CreateEndTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEndTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDefaultMin(FlatBufferBuilder builder, int DefaultMin) { builder.AddInt(9, DefaultMin, 0); }
  public static void AddDefaultMax(FlatBufferBuilder builder, int DefaultMax) { builder.AddInt(10, DefaultMax, 0); }
  public static void AddPlayerLimitID(FlatBufferBuilder builder, int PlayerLimitID) { builder.AddInt(11, PlayerLimitID, -1); }
  public static void AddTimeLimitID(FlatBufferBuilder builder, int TimeLimitID) { builder.AddInt(12, TimeLimitID, -1); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(13, CopySceneID, -1); }
  public static void AddSceneClassID(FlatBufferBuilder builder, int SceneClassID) { builder.AddInt(14, SceneClassID, -1); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(15, PosX, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(16, PosZ, 0); }
  public static void AddRolebaseID(FlatBufferBuilder builder, int RolebaseID) { builder.AddInt(17, RolebaseID, -1); }
  public static void AddLowLevelTips(FlatBufferBuilder builder, int LowLevelTips) { builder.AddInt(18, LowLevelTips, -1); }
  public static void AddIsShowAddHp(FlatBufferBuilder builder, bool IsShowAddHp) { builder.AddBool(19, IsShowAddHp, false); }
  public static void AddIsRobot(FlatBufferBuilder builder, bool IsRobot) { builder.AddBool(20, IsRobot, false); }
  public static void AddWaitingTime(FlatBufferBuilder builder, int WaitingTime) { builder.AddInt(21, WaitingTime, -1); }
  public static void AddMinRobotId(FlatBufferBuilder builder, int MinRobotId) { builder.AddInt(22, MinRobotId, -1); }
  public static void AddMaxRobotId(FlatBufferBuilder builder, int MaxRobotId) { builder.AddInt(23, MaxRobotId, -1); }
  public static void AddChangeJobLimit(FlatBufferBuilder builder, int ChangeJobLimit) { builder.AddInt(24, ChangeJobLimit, -1); }
  public static Offset<FB_TeamPlatform> EndFB_TeamPlatform(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TeamPlatform>(o);
  }
};

public sealed class FB_TeamPlatformContainer : Table {
  public static FB_TeamPlatformContainer GetRootAsFB_TeamPlatformContainer(ByteBuffer _bb) { return GetRootAsFB_TeamPlatformContainer(_bb, new FB_TeamPlatformContainer()); }
  public static FB_TeamPlatformContainer GetRootAsFB_TeamPlatformContainer(ByteBuffer _bb, FB_TeamPlatformContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TeamPlatformContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TeamPlatformContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TeamPlatform GetItems(int j) { return GetItems(new FB_TeamPlatform(), j); }
  public FB_TeamPlatform GetItems(FB_TeamPlatform obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TeamPlatformContainer> CreateFB_TeamPlatformContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TeamPlatformContainer.AddItems(builder, items);
    return FB_TeamPlatformContainer.EndFB_TeamPlatformContainer(builder);
  }

  public static void StartFB_TeamPlatformContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TeamPlatform>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TeamPlatformContainer> EndFB_TeamPlatformContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TeamPlatformContainer>(o);
  }
  public static void FinishFB_TeamPlatformContainerBuffer(FlatBufferBuilder builder, Offset<FB_TeamPlatformContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
