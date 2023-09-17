// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyBase : Table {
  public static FB_DestinyBase GetRootAsFB_DestinyBase(ByteBuffer _bb) { return GetRootAsFB_DestinyBase(_bb, new FB_DestinyBase()); }
  public static FB_DestinyBase GetRootAsFB_DestinyBase(ByteBuffer _bb, FB_DestinyBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MaxLv { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string NameSprite { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Title { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SubTitle { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DescId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Getpath { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetpathName { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeobjID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Class { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Index { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissionID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HuaShenLevelLimit { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long AttributeLessId { get { int o = __offset(38); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public int GoldAttackIce { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldAttackFire { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneGroupPointId { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Scale { get { int o = __offset(46); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotateY { get { int o = __offset(48); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float OffsetY { get { int o = __offset(50); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int SystemBroadCastId { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillList(int j) { int o = __offset(54); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(54); return o != 0 ? __vector_len(o) : 0; } }
  public long GetExp { get { int o = __offset(56); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public int Quality { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBoxId { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillOpenId { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DestinyBase> CreateFB_DestinyBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int MaxLv = -1,
      StringOffset NameSprite = default(StringOffset),
      StringOffset Title = default(StringOffset),
      StringOffset SubTitle = default(StringOffset),
      int DescId = -1,
      StringOffset Getpath = default(StringOffset),
      StringOffset GetpathName = default(StringOffset),
      int FakeobjID = -1,
      StringOffset Icon = default(StringOffset),
      int Class = -1,
      int Index = -1,
      int MissionID = -1,
      int CopySceneID = -1,
      int LevelLimit = -1,
      int HuaShenLevelLimit = -1,
      long AttributeLessId = 0,
      int GoldAttackIce = -1,
      int GoldAttackFire = -1,
      int SceneGroupPointId = -1,
      float Scale = 0,
      float RotateY = 0,
      float OffsetY = 0,
      int SystemBroadCastId = -1,
      VectorOffset PassiveSkillList = default(VectorOffset),
      long GetExp = 0,
      int Quality = -1,
      int DropBoxId = -1,
      int SkillOpenId = -1) {
    builder.StartObject(30);
    FB_DestinyBase.AddGetExp(builder, GetExp);
    FB_DestinyBase.AddAttributeLessId(builder, AttributeLessId);
    FB_DestinyBase.AddSkillOpenId(builder, SkillOpenId);
    FB_DestinyBase.AddDropBoxId(builder, DropBoxId);
    FB_DestinyBase.AddQuality(builder, Quality);
    FB_DestinyBase.AddPassiveSkillList(builder, PassiveSkillList);
    FB_DestinyBase.AddSystemBroadCastId(builder, SystemBroadCastId);
    FB_DestinyBase.AddOffsetY(builder, OffsetY);
    FB_DestinyBase.AddRotateY(builder, RotateY);
    FB_DestinyBase.AddScale(builder, Scale);
    FB_DestinyBase.AddSceneGroupPointId(builder, SceneGroupPointId);
    FB_DestinyBase.AddGoldAttackFire(builder, GoldAttackFire);
    FB_DestinyBase.AddGoldAttackIce(builder, GoldAttackIce);
    FB_DestinyBase.AddHuaShenLevelLimit(builder, HuaShenLevelLimit);
    FB_DestinyBase.AddLevelLimit(builder, LevelLimit);
    FB_DestinyBase.AddCopySceneID(builder, CopySceneID);
    FB_DestinyBase.AddMissionID(builder, MissionID);
    FB_DestinyBase.AddIndex(builder, Index);
    FB_DestinyBase.AddClass(builder, Class);
    FB_DestinyBase.AddIcon(builder, Icon);
    FB_DestinyBase.AddFakeobjID(builder, FakeobjID);
    FB_DestinyBase.AddGetpathName(builder, GetpathName);
    FB_DestinyBase.AddGetpath(builder, Getpath);
    FB_DestinyBase.AddDescId(builder, DescId);
    FB_DestinyBase.AddSubTitle(builder, SubTitle);
    FB_DestinyBase.AddTitle(builder, Title);
    FB_DestinyBase.AddNameSprite(builder, NameSprite);
    FB_DestinyBase.AddMaxLv(builder, MaxLv);
    FB_DestinyBase.AddName(builder, Name);
    FB_DestinyBase.AddId(builder, Id);
    return FB_DestinyBase.EndFB_DestinyBase(builder);
  }

  public static void StartFB_DestinyBase(FlatBufferBuilder builder) { builder.StartObject(30); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMaxLv(FlatBufferBuilder builder, int MaxLv) { builder.AddInt(2, MaxLv, -1); }
  public static void AddNameSprite(FlatBufferBuilder builder, StringOffset NameSpriteOffset) { builder.AddOffset(3, NameSpriteOffset.Value, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset TitleOffset) { builder.AddOffset(4, TitleOffset.Value, 0); }
  public static void AddSubTitle(FlatBufferBuilder builder, StringOffset SubTitleOffset) { builder.AddOffset(5, SubTitleOffset.Value, 0); }
  public static void AddDescId(FlatBufferBuilder builder, int DescId) { builder.AddInt(6, DescId, -1); }
  public static void AddGetpath(FlatBufferBuilder builder, StringOffset GetpathOffset) { builder.AddOffset(7, GetpathOffset.Value, 0); }
  public static void AddGetpathName(FlatBufferBuilder builder, StringOffset GetpathNameOffset) { builder.AddOffset(8, GetpathNameOffset.Value, 0); }
  public static void AddFakeobjID(FlatBufferBuilder builder, int FakeobjID) { builder.AddInt(9, FakeobjID, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(10, IconOffset.Value, 0); }
  public static void AddClass(FlatBufferBuilder builder, int Class) { builder.AddInt(11, Class, -1); }
  public static void AddIndex(FlatBufferBuilder builder, int Index) { builder.AddInt(12, Index, -1); }
  public static void AddMissionID(FlatBufferBuilder builder, int MissionID) { builder.AddInt(13, MissionID, -1); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(14, CopySceneID, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(15, LevelLimit, -1); }
  public static void AddHuaShenLevelLimit(FlatBufferBuilder builder, int HuaShenLevelLimit) { builder.AddInt(16, HuaShenLevelLimit, -1); }
  public static void AddAttributeLessId(FlatBufferBuilder builder, long AttributeLessId) { builder.AddLong(17, AttributeLessId, 0); }
  public static void AddGoldAttackIce(FlatBufferBuilder builder, int GoldAttackIce) { builder.AddInt(18, GoldAttackIce, -1); }
  public static void AddGoldAttackFire(FlatBufferBuilder builder, int GoldAttackFire) { builder.AddInt(19, GoldAttackFire, -1); }
  public static void AddSceneGroupPointId(FlatBufferBuilder builder, int SceneGroupPointId) { builder.AddInt(20, SceneGroupPointId, -1); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(21, Scale, 0); }
  public static void AddRotateY(FlatBufferBuilder builder, float RotateY) { builder.AddFloat(22, RotateY, 0); }
  public static void AddOffsetY(FlatBufferBuilder builder, float OffsetY) { builder.AddFloat(23, OffsetY, 0); }
  public static void AddSystemBroadCastId(FlatBufferBuilder builder, int SystemBroadCastId) { builder.AddInt(24, SystemBroadCastId, -1); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(25, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGetExp(FlatBufferBuilder builder, long GetExp) { builder.AddLong(26, GetExp, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(27, Quality, -1); }
  public static void AddDropBoxId(FlatBufferBuilder builder, int DropBoxId) { builder.AddInt(28, DropBoxId, -1); }
  public static void AddSkillOpenId(FlatBufferBuilder builder, int SkillOpenId) { builder.AddInt(29, SkillOpenId, -1); }
  public static Offset<FB_DestinyBase> EndFB_DestinyBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBase>(o);
  }
};

public sealed class FB_DestinyBaseContainer : Table {
  public static FB_DestinyBaseContainer GetRootAsFB_DestinyBaseContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyBaseContainer(_bb, new FB_DestinyBaseContainer()); }
  public static FB_DestinyBaseContainer GetRootAsFB_DestinyBaseContainer(ByteBuffer _bb, FB_DestinyBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyBase GetItems(int j) { return GetItems(new FB_DestinyBase(), j); }
  public FB_DestinyBase GetItems(FB_DestinyBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBaseContainer> CreateFB_DestinyBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyBaseContainer.AddItems(builder, items);
    return FB_DestinyBaseContainer.EndFB_DestinyBaseContainer(builder);
  }

  public static void StartFB_DestinyBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBaseContainer> EndFB_DestinyBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBaseContainer>(o);
  }
  public static void FinishFB_DestinyBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
