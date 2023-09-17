// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ArtifactBase : Table {
  public static FB_ArtifactBase GetRootAsFB_ArtifactBase(ByteBuffer _bb) { return GetRootAsFB_ArtifactBase(_bb, new FB_ArtifactBase()); }
  public static FB_ArtifactBase GetRootAsFB_ArtifactBase(ByteBuffer _bb, FB_ArtifactBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ArtifactBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string NameSprite { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Title { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SubTitle { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DescId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Getpath { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetpathName { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeobjID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Class { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Index { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int MissionID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttributeLessId { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneGroupPointId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Scale { get { int o = __offset(40); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotateY { get { int o = __offset(42); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float OffsetY { get { int o = __offset(44); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int SystemBroadCastId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetLevelAddPassiveSkillList(int j) { int o = __offset(48); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelAddPassiveSkillListLength { get { int o = __offset(48); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLevelConditionList(int j) { int o = __offset(50); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelConditionListLength { get { int o = __offset(50); return o != 0 ? __vector_len(o) : 0; } }
  public int DropBoxId { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelUpType { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long GetExp { get { int o = __offset(56); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }

  public static Offset<FB_ArtifactBase> CreateFB_ArtifactBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
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
      VectorOffset PassiveSkillList = default(VectorOffset),
      int MissionID = -1,
      int CopySceneID = -1,
      int LevelLimit = -1,
      int AttributeLessId = -1,
      int SceneGroupPointId = -1,
      float Scale = 0,
      float RotateY = 0,
      float OffsetY = 0,
      int SystemBroadCastId = -1,
      VectorOffset LevelAddPassiveSkillList = default(VectorOffset),
      VectorOffset LevelConditionList = default(VectorOffset),
      int DropBoxId = -1,
      int LevelUpType = -1,
      long GetExp = 0) {
    builder.StartObject(27);
    FB_ArtifactBase.AddGetExp(builder, GetExp);
    FB_ArtifactBase.AddLevelUpType(builder, LevelUpType);
    FB_ArtifactBase.AddDropBoxId(builder, DropBoxId);
    FB_ArtifactBase.AddLevelConditionList(builder, LevelConditionList);
    FB_ArtifactBase.AddLevelAddPassiveSkillList(builder, LevelAddPassiveSkillList);
    FB_ArtifactBase.AddSystemBroadCastId(builder, SystemBroadCastId);
    FB_ArtifactBase.AddOffsetY(builder, OffsetY);
    FB_ArtifactBase.AddRotateY(builder, RotateY);
    FB_ArtifactBase.AddScale(builder, Scale);
    FB_ArtifactBase.AddSceneGroupPointId(builder, SceneGroupPointId);
    FB_ArtifactBase.AddAttributeLessId(builder, AttributeLessId);
    FB_ArtifactBase.AddLevelLimit(builder, LevelLimit);
    FB_ArtifactBase.AddCopySceneID(builder, CopySceneID);
    FB_ArtifactBase.AddMissionID(builder, MissionID);
    FB_ArtifactBase.AddPassiveSkillList(builder, PassiveSkillList);
    FB_ArtifactBase.AddIndex(builder, Index);
    FB_ArtifactBase.AddClass(builder, Class);
    FB_ArtifactBase.AddIcon(builder, Icon);
    FB_ArtifactBase.AddFakeobjID(builder, FakeobjID);
    FB_ArtifactBase.AddGetpathName(builder, GetpathName);
    FB_ArtifactBase.AddGetpath(builder, Getpath);
    FB_ArtifactBase.AddDescId(builder, DescId);
    FB_ArtifactBase.AddSubTitle(builder, SubTitle);
    FB_ArtifactBase.AddTitle(builder, Title);
    FB_ArtifactBase.AddNameSprite(builder, NameSprite);
    FB_ArtifactBase.AddName(builder, Name);
    FB_ArtifactBase.AddId(builder, Id);
    return FB_ArtifactBase.EndFB_ArtifactBase(builder);
  }

  public static void StartFB_ArtifactBase(FlatBufferBuilder builder) { builder.StartObject(27); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNameSprite(FlatBufferBuilder builder, StringOffset NameSpriteOffset) { builder.AddOffset(2, NameSpriteOffset.Value, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset TitleOffset) { builder.AddOffset(3, TitleOffset.Value, 0); }
  public static void AddSubTitle(FlatBufferBuilder builder, StringOffset SubTitleOffset) { builder.AddOffset(4, SubTitleOffset.Value, 0); }
  public static void AddDescId(FlatBufferBuilder builder, int DescId) { builder.AddInt(5, DescId, -1); }
  public static void AddGetpath(FlatBufferBuilder builder, StringOffset GetpathOffset) { builder.AddOffset(6, GetpathOffset.Value, 0); }
  public static void AddGetpathName(FlatBufferBuilder builder, StringOffset GetpathNameOffset) { builder.AddOffset(7, GetpathNameOffset.Value, 0); }
  public static void AddFakeobjID(FlatBufferBuilder builder, int FakeobjID) { builder.AddInt(8, FakeobjID, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(9, IconOffset.Value, 0); }
  public static void AddClass(FlatBufferBuilder builder, int Class) { builder.AddInt(10, Class, -1); }
  public static void AddIndex(FlatBufferBuilder builder, int Index) { builder.AddInt(11, Index, -1); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(12, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionID(FlatBufferBuilder builder, int MissionID) { builder.AddInt(13, MissionID, -1); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(14, CopySceneID, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(15, LevelLimit, -1); }
  public static void AddAttributeLessId(FlatBufferBuilder builder, int AttributeLessId) { builder.AddInt(16, AttributeLessId, -1); }
  public static void AddSceneGroupPointId(FlatBufferBuilder builder, int SceneGroupPointId) { builder.AddInt(17, SceneGroupPointId, -1); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(18, Scale, 0); }
  public static void AddRotateY(FlatBufferBuilder builder, float RotateY) { builder.AddFloat(19, RotateY, 0); }
  public static void AddOffsetY(FlatBufferBuilder builder, float OffsetY) { builder.AddFloat(20, OffsetY, 0); }
  public static void AddSystemBroadCastId(FlatBufferBuilder builder, int SystemBroadCastId) { builder.AddInt(21, SystemBroadCastId, -1); }
  public static void AddLevelAddPassiveSkillList(FlatBufferBuilder builder, VectorOffset LevelAddPassiveSkillListOffset) { builder.AddOffset(22, LevelAddPassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreateLevelAddPassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelAddPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelConditionList(FlatBufferBuilder builder, VectorOffset LevelConditionListOffset) { builder.AddOffset(23, LevelConditionListOffset.Value, 0); }
  public static VectorOffset CreateLevelConditionListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelConditionListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDropBoxId(FlatBufferBuilder builder, int DropBoxId) { builder.AddInt(24, DropBoxId, -1); }
  public static void AddLevelUpType(FlatBufferBuilder builder, int LevelUpType) { builder.AddInt(25, LevelUpType, -1); }
  public static void AddGetExp(FlatBufferBuilder builder, long GetExp) { builder.AddLong(26, GetExp, 0); }
  public static Offset<FB_ArtifactBase> EndFB_ArtifactBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArtifactBase>(o);
  }
};

public sealed class FB_ArtifactBaseContainer : Table {
  public static FB_ArtifactBaseContainer GetRootAsFB_ArtifactBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ArtifactBaseContainer(_bb, new FB_ArtifactBaseContainer()); }
  public static FB_ArtifactBaseContainer GetRootAsFB_ArtifactBaseContainer(ByteBuffer _bb, FB_ArtifactBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ArtifactBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ArtifactBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ArtifactBase GetItems(int j) { return GetItems(new FB_ArtifactBase(), j); }
  public FB_ArtifactBase GetItems(FB_ArtifactBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ArtifactBaseContainer> CreateFB_ArtifactBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ArtifactBaseContainer.AddItems(builder, items);
    return FB_ArtifactBaseContainer.EndFB_ArtifactBaseContainer(builder);
  }

  public static void StartFB_ArtifactBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ArtifactBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ArtifactBaseContainer> EndFB_ArtifactBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArtifactBaseContainer>(o);
  }
  public static void FinishFB_ArtifactBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ArtifactBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
