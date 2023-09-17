// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityBase : Table {
  public static FB_ActivityBase GetRootAsFB_ActivityBase(ByteBuffer _bb) { return GetRootAsFB_ActivityBase(_bb, new FB_ActivityBase()); }
  public static FB_ActivityBase GetRootAsFB_ActivityBase(ByteBuffer _bb, FB_ActivityBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ActivityType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InitLogic { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLvlLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLvlLimit { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortWeight { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Icon { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IntroduceId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshType { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Rounds { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JoinCountId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddActivityId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityPoint { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TotalPoint { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool CanJoinAfterDone { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int OpenTimeType { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PrepareTime { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetOpenTimeList(int j) { int o = __offset(42); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OpenTimeListLength { get { int o = __offset(42); return o != 0 ? __vector_len(o) : 0; } }
  public int GetEndTimeList(int j) { int o = __offset(44); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EndTimeListLength { get { int o = __offset(44); return o != 0 ? __vector_len(o) : 0; } }
  public int JoinLimitType { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JoinLimit { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardIDList(int j) { int o = __offset(50); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardIDListLength { get { int o = __offset(50); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsRecommond { get { int o = __offset(52); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsRedPoint { get { int o = __offset(54); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ActivityRewardType { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowType { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowLevel { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SearchType { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float TargetNpcPosX { get { int o = __offset(64); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float TargetNpcPosZ { get { int o = __offset(66); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public int TargetNpcSceneID { get { int o = __offset(68); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int TargetNpcDataID { get { int o = __offset(70); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int MissionID { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TxtTips { get { int o = __offset(74); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UIID { get { int o = __offset(76); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SubUIID { get { int o = __offset(78); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ActivityTxtType { get { int o = __offset(80); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TimeDesc { get { int o = __offset(82); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CopySceneID { get { int o = __offset(84); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MopUpID { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MopUpMDID { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TunSongIndex { get { int o = __offset(90); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string MenuIcon { get { int o = __offset(92); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MenuIconName { get { int o = __offset(94); return o != 0 ? __string(o + bb_pos) : null; } }
  public int AfterSomeDayOpen { get { int o = __offset(96); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string BtnName { get { int o = __offset(98); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsSupportOtherWorld { get { int o = __offset(100); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int FunctionBaseID { get { int o = __offset(102); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsStillShow { get { int o = __offset(104); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetDropBtnIDList(int j) { int o = __offset(106); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DropBtnIDListLength { get { int o = __offset(106); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityBase> CreateFB_ActivityBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int ActivityType = -1,
      int InitLogic = -1,
      int OpenType = -1,
      int MinLvlLimit = -1,
      int MaxLvlLimit = -1,
      int SortWeight = -1,
      int icon = -1,
      int IntroduceId = -1,
      int RefreshType = -1,
      int Rounds = 0,
      int JoinCountId = -1,
      int AddActivityId = -1,
      int ActivityPoint = 0,
      int TotalPoint = 0,
      bool CanJoinAfterDone = false,
      int OpenTimeType = -1,
      int PrepareTime = -1,
      VectorOffset OpenTimeList = default(VectorOffset),
      VectorOffset EndTimeList = default(VectorOffset),
      int JoinLimitType = -1,
      int JoinLimit = -1,
      VectorOffset RewardIDList = default(VectorOffset),
      bool IsRecommond = false,
      bool IsRedPoint = false,
      int ActivityRewardType = -1,
      int ShowType = -1,
      int ShowLevel = -1,
      int SearchType = -1,
      float TargetNpcPosX = 1,
      float TargetNpcPosZ = 1,
      int TargetNpcSceneID = 1,
      int TargetNpcDataID = 1,
      int MissionID = -1,
      StringOffset TxtTips = default(StringOffset),
      int UIID = -1,
      int SubUIID = -1,
      StringOffset ActivityTxtType = default(StringOffset),
      StringOffset TimeDesc = default(StringOffset),
      int CopySceneID = -1,
      int MopUpID = -1,
      int MopUpMDID = -1,
      int TunSongIndex = -1,
      StringOffset MenuIcon = default(StringOffset),
      StringOffset MenuIconName = default(StringOffset),
      int AfterSomeDayOpen = -1,
      StringOffset BtnName = default(StringOffset),
      bool IsSupportOtherWorld = false,
      int FunctionBaseID = -1,
      bool IsStillShow = false,
      VectorOffset DropBtnIDList = default(VectorOffset)) {
    builder.StartObject(52);
    FB_ActivityBase.AddDropBtnIDList(builder, DropBtnIDList);
    FB_ActivityBase.AddFunctionBaseID(builder, FunctionBaseID);
    FB_ActivityBase.AddBtnName(builder, BtnName);
    FB_ActivityBase.AddAfterSomeDayOpen(builder, AfterSomeDayOpen);
    FB_ActivityBase.AddMenuIconName(builder, MenuIconName);
    FB_ActivityBase.AddMenuIcon(builder, MenuIcon);
    FB_ActivityBase.AddTunSongIndex(builder, TunSongIndex);
    FB_ActivityBase.AddMopUpMDID(builder, MopUpMDID);
    FB_ActivityBase.AddMopUpID(builder, MopUpID);
    FB_ActivityBase.AddCopySceneID(builder, CopySceneID);
    FB_ActivityBase.AddTimeDesc(builder, TimeDesc);
    FB_ActivityBase.AddActivityTxtType(builder, ActivityTxtType);
    FB_ActivityBase.AddSubUIID(builder, SubUIID);
    FB_ActivityBase.AddUIID(builder, UIID);
    FB_ActivityBase.AddTxtTips(builder, TxtTips);
    FB_ActivityBase.AddMissionID(builder, MissionID);
    FB_ActivityBase.AddTargetNpcDataID(builder, TargetNpcDataID);
    FB_ActivityBase.AddTargetNpcSceneID(builder, TargetNpcSceneID);
    FB_ActivityBase.AddTargetNpcPosZ(builder, TargetNpcPosZ);
    FB_ActivityBase.AddTargetNpcPosX(builder, TargetNpcPosX);
    FB_ActivityBase.AddSearchType(builder, SearchType);
    FB_ActivityBase.AddShowLevel(builder, ShowLevel);
    FB_ActivityBase.AddShowType(builder, ShowType);
    FB_ActivityBase.AddActivityRewardType(builder, ActivityRewardType);
    FB_ActivityBase.AddRewardIDList(builder, RewardIDList);
    FB_ActivityBase.AddJoinLimit(builder, JoinLimit);
    FB_ActivityBase.AddJoinLimitType(builder, JoinLimitType);
    FB_ActivityBase.AddEndTimeList(builder, EndTimeList);
    FB_ActivityBase.AddOpenTimeList(builder, OpenTimeList);
    FB_ActivityBase.AddPrepareTime(builder, PrepareTime);
    FB_ActivityBase.AddOpenTimeType(builder, OpenTimeType);
    FB_ActivityBase.AddTotalPoint(builder, TotalPoint);
    FB_ActivityBase.AddActivityPoint(builder, ActivityPoint);
    FB_ActivityBase.AddAddActivityId(builder, AddActivityId);
    FB_ActivityBase.AddJoinCountId(builder, JoinCountId);
    FB_ActivityBase.AddRounds(builder, Rounds);
    FB_ActivityBase.AddRefreshType(builder, RefreshType);
    FB_ActivityBase.AddIntroduceId(builder, IntroduceId);
    FB_ActivityBase.AddIcon(builder, icon);
    FB_ActivityBase.AddSortWeight(builder, SortWeight);
    FB_ActivityBase.AddMaxLvlLimit(builder, MaxLvlLimit);
    FB_ActivityBase.AddMinLvlLimit(builder, MinLvlLimit);
    FB_ActivityBase.AddOpenType(builder, OpenType);
    FB_ActivityBase.AddInitLogic(builder, InitLogic);
    FB_ActivityBase.AddActivityType(builder, ActivityType);
    FB_ActivityBase.AddName(builder, Name);
    FB_ActivityBase.AddID(builder, ID);
    FB_ActivityBase.AddIsStillShow(builder, IsStillShow);
    FB_ActivityBase.AddIsSupportOtherWorld(builder, IsSupportOtherWorld);
    FB_ActivityBase.AddIsRedPoint(builder, IsRedPoint);
    FB_ActivityBase.AddIsRecommond(builder, IsRecommond);
    FB_ActivityBase.AddCanJoinAfterDone(builder, CanJoinAfterDone);
    return FB_ActivityBase.EndFB_ActivityBase(builder);
  }

  public static void StartFB_ActivityBase(FlatBufferBuilder builder) { builder.StartObject(52); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddActivityType(FlatBufferBuilder builder, int ActivityType) { builder.AddInt(2, ActivityType, -1); }
  public static void AddInitLogic(FlatBufferBuilder builder, int InitLogic) { builder.AddInt(3, InitLogic, -1); }
  public static void AddOpenType(FlatBufferBuilder builder, int OpenType) { builder.AddInt(4, OpenType, -1); }
  public static void AddMinLvlLimit(FlatBufferBuilder builder, int MinLvlLimit) { builder.AddInt(5, MinLvlLimit, -1); }
  public static void AddMaxLvlLimit(FlatBufferBuilder builder, int MaxLvlLimit) { builder.AddInt(6, MaxLvlLimit, -1); }
  public static void AddSortWeight(FlatBufferBuilder builder, int SortWeight) { builder.AddInt(7, SortWeight, -1); }
  public static void AddIcon(FlatBufferBuilder builder, int icon) { builder.AddInt(8, icon, -1); }
  public static void AddIntroduceId(FlatBufferBuilder builder, int IntroduceId) { builder.AddInt(9, IntroduceId, -1); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(10, RefreshType, -1); }
  public static void AddRounds(FlatBufferBuilder builder, int Rounds) { builder.AddInt(11, Rounds, 0); }
  public static void AddJoinCountId(FlatBufferBuilder builder, int JoinCountId) { builder.AddInt(12, JoinCountId, -1); }
  public static void AddAddActivityId(FlatBufferBuilder builder, int AddActivityId) { builder.AddInt(13, AddActivityId, -1); }
  public static void AddActivityPoint(FlatBufferBuilder builder, int ActivityPoint) { builder.AddInt(14, ActivityPoint, 0); }
  public static void AddTotalPoint(FlatBufferBuilder builder, int TotalPoint) { builder.AddInt(15, TotalPoint, 0); }
  public static void AddCanJoinAfterDone(FlatBufferBuilder builder, bool CanJoinAfterDone) { builder.AddBool(16, CanJoinAfterDone, false); }
  public static void AddOpenTimeType(FlatBufferBuilder builder, int OpenTimeType) { builder.AddInt(17, OpenTimeType, -1); }
  public static void AddPrepareTime(FlatBufferBuilder builder, int PrepareTime) { builder.AddInt(18, PrepareTime, -1); }
  public static void AddOpenTimeList(FlatBufferBuilder builder, VectorOffset OpenTimeListOffset) { builder.AddOffset(19, OpenTimeListOffset.Value, 0); }
  public static VectorOffset CreateOpenTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOpenTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEndTimeList(FlatBufferBuilder builder, VectorOffset EndTimeListOffset) { builder.AddOffset(20, EndTimeListOffset.Value, 0); }
  public static VectorOffset CreateEndTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEndTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddJoinLimitType(FlatBufferBuilder builder, int JoinLimitType) { builder.AddInt(21, JoinLimitType, -1); }
  public static void AddJoinLimit(FlatBufferBuilder builder, int JoinLimit) { builder.AddInt(22, JoinLimit, -1); }
  public static void AddRewardIDList(FlatBufferBuilder builder, VectorOffset RewardIDListOffset) { builder.AddOffset(23, RewardIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsRecommond(FlatBufferBuilder builder, bool IsRecommond) { builder.AddBool(24, IsRecommond, false); }
  public static void AddIsRedPoint(FlatBufferBuilder builder, bool IsRedPoint) { builder.AddBool(25, IsRedPoint, false); }
  public static void AddActivityRewardType(FlatBufferBuilder builder, int ActivityRewardType) { builder.AddInt(26, ActivityRewardType, -1); }
  public static void AddShowType(FlatBufferBuilder builder, int ShowType) { builder.AddInt(27, ShowType, -1); }
  public static void AddShowLevel(FlatBufferBuilder builder, int ShowLevel) { builder.AddInt(28, ShowLevel, -1); }
  public static void AddSearchType(FlatBufferBuilder builder, int SearchType) { builder.AddInt(29, SearchType, -1); }
  public static void AddTargetNpcPosX(FlatBufferBuilder builder, float TargetNpcPosX) { builder.AddFloat(30, TargetNpcPosX, 1); }
  public static void AddTargetNpcPosZ(FlatBufferBuilder builder, float TargetNpcPosZ) { builder.AddFloat(31, TargetNpcPosZ, 1); }
  public static void AddTargetNpcSceneID(FlatBufferBuilder builder, int TargetNpcSceneID) { builder.AddInt(32, TargetNpcSceneID, 1); }
  public static void AddTargetNpcDataID(FlatBufferBuilder builder, int TargetNpcDataID) { builder.AddInt(33, TargetNpcDataID, 1); }
  public static void AddMissionID(FlatBufferBuilder builder, int MissionID) { builder.AddInt(34, MissionID, -1); }
  public static void AddTxtTips(FlatBufferBuilder builder, StringOffset TxtTipsOffset) { builder.AddOffset(35, TxtTipsOffset.Value, 0); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(36, UIID, -1); }
  public static void AddSubUIID(FlatBufferBuilder builder, int SubUIID) { builder.AddInt(37, SubUIID, -1); }
  public static void AddActivityTxtType(FlatBufferBuilder builder, StringOffset ActivityTxtTypeOffset) { builder.AddOffset(38, ActivityTxtTypeOffset.Value, 0); }
  public static void AddTimeDesc(FlatBufferBuilder builder, StringOffset TimeDescOffset) { builder.AddOffset(39, TimeDescOffset.Value, 0); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(40, CopySceneID, -1); }
  public static void AddMopUpID(FlatBufferBuilder builder, int MopUpID) { builder.AddInt(41, MopUpID, -1); }
  public static void AddMopUpMDID(FlatBufferBuilder builder, int MopUpMDID) { builder.AddInt(42, MopUpMDID, -1); }
  public static void AddTunSongIndex(FlatBufferBuilder builder, int TunSongIndex) { builder.AddInt(43, TunSongIndex, -1); }
  public static void AddMenuIcon(FlatBufferBuilder builder, StringOffset MenuIconOffset) { builder.AddOffset(44, MenuIconOffset.Value, 0); }
  public static void AddMenuIconName(FlatBufferBuilder builder, StringOffset MenuIconNameOffset) { builder.AddOffset(45, MenuIconNameOffset.Value, 0); }
  public static void AddAfterSomeDayOpen(FlatBufferBuilder builder, int AfterSomeDayOpen) { builder.AddInt(46, AfterSomeDayOpen, -1); }
  public static void AddBtnName(FlatBufferBuilder builder, StringOffset BtnNameOffset) { builder.AddOffset(47, BtnNameOffset.Value, 0); }
  public static void AddIsSupportOtherWorld(FlatBufferBuilder builder, bool IsSupportOtherWorld) { builder.AddBool(48, IsSupportOtherWorld, false); }
  public static void AddFunctionBaseID(FlatBufferBuilder builder, int FunctionBaseID) { builder.AddInt(49, FunctionBaseID, -1); }
  public static void AddIsStillShow(FlatBufferBuilder builder, bool IsStillShow) { builder.AddBool(50, IsStillShow, false); }
  public static void AddDropBtnIDList(FlatBufferBuilder builder, VectorOffset DropBtnIDListOffset) { builder.AddOffset(51, DropBtnIDListOffset.Value, 0); }
  public static VectorOffset CreateDropBtnIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDropBtnIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityBase> EndFB_ActivityBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityBase>(o);
  }
};

public sealed class FB_ActivityBaseContainer : Table {
  public static FB_ActivityBaseContainer GetRootAsFB_ActivityBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityBaseContainer(_bb, new FB_ActivityBaseContainer()); }
  public static FB_ActivityBaseContainer GetRootAsFB_ActivityBaseContainer(ByteBuffer _bb, FB_ActivityBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityBase GetItems(int j) { return GetItems(new FB_ActivityBase(), j); }
  public FB_ActivityBase GetItems(FB_ActivityBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityBaseContainer> CreateFB_ActivityBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityBaseContainer.AddItems(builder, items);
    return FB_ActivityBaseContainer.EndFB_ActivityBaseContainer(builder);
  }

  public static void StartFB_ActivityBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityBaseContainer> EndFB_ActivityBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityBaseContainer>(o);
  }
  public static void FinishFB_ActivityBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
