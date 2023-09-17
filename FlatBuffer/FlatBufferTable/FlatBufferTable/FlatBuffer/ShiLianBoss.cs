// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShiLianBoss : Table {
  public static FB_ShiLianBoss GetRootAsFB_ShiLianBoss(ByteBuffer _bb) { return GetRootAsFB_ShiLianBoss(_bb, new FB_ShiLianBoss()); }
  public static FB_ShiLianBoss GetRootAsFB_ShiLianBoss(ByteBuffer _bb, FB_ShiLianBoss obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShiLianBoss __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string CSName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BossName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DictID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropDescID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetShowItemIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDropBoxIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DropBoxIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public string BgName { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TitalName { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TeamPlatformId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Bossicon { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public int BigBoxId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SmallBoxId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BloodBigBoxDropId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BloodSmallBoxDropId { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShiLianBoss> CreateFB_ShiLianBoss(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset CSName = default(StringOffset),
      StringOffset BossName = default(StringOffset),
      int DictID = -1,
      int LevelLimit = -1,
      int FakeObjID = -1,
      int DropDescID = -1,
      VectorOffset ShowItemIDList = default(VectorOffset),
      VectorOffset DropBoxIDList = default(VectorOffset),
      StringOffset BgName = default(StringOffset),
      StringOffset TitalName = default(StringOffset),
      int TeamPlatformId = -1,
      StringOffset bossicon = default(StringOffset),
      int BigBoxId = -1,
      int SmallBoxId = -1,
      int BloodBigBoxDropId = -1,
      int BloodSmallBoxDropId = -1) {
    builder.StartObject(17);
    FB_ShiLianBoss.AddBloodSmallBoxDropId(builder, BloodSmallBoxDropId);
    FB_ShiLianBoss.AddBloodBigBoxDropId(builder, BloodBigBoxDropId);
    FB_ShiLianBoss.AddSmallBoxId(builder, SmallBoxId);
    FB_ShiLianBoss.AddBigBoxId(builder, BigBoxId);
    FB_ShiLianBoss.AddBossicon(builder, bossicon);
    FB_ShiLianBoss.AddTeamPlatformId(builder, TeamPlatformId);
    FB_ShiLianBoss.AddTitalName(builder, TitalName);
    FB_ShiLianBoss.AddBgName(builder, BgName);
    FB_ShiLianBoss.AddDropBoxIDList(builder, DropBoxIDList);
    FB_ShiLianBoss.AddShowItemIDList(builder, ShowItemIDList);
    FB_ShiLianBoss.AddDropDescID(builder, DropDescID);
    FB_ShiLianBoss.AddFakeObjID(builder, FakeObjID);
    FB_ShiLianBoss.AddLevelLimit(builder, LevelLimit);
    FB_ShiLianBoss.AddDictID(builder, DictID);
    FB_ShiLianBoss.AddBossName(builder, BossName);
    FB_ShiLianBoss.AddCSName(builder, CSName);
    FB_ShiLianBoss.AddID(builder, ID);
    return FB_ShiLianBoss.EndFB_ShiLianBoss(builder);
  }

  public static void StartFB_ShiLianBoss(FlatBufferBuilder builder) { builder.StartObject(17); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCSName(FlatBufferBuilder builder, StringOffset CSNameOffset) { builder.AddOffset(1, CSNameOffset.Value, 0); }
  public static void AddBossName(FlatBufferBuilder builder, StringOffset BossNameOffset) { builder.AddOffset(2, BossNameOffset.Value, 0); }
  public static void AddDictID(FlatBufferBuilder builder, int DictID) { builder.AddInt(3, DictID, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(4, LevelLimit, -1); }
  public static void AddFakeObjID(FlatBufferBuilder builder, int FakeObjID) { builder.AddInt(5, FakeObjID, -1); }
  public static void AddDropDescID(FlatBufferBuilder builder, int DropDescID) { builder.AddInt(6, DropDescID, -1); }
  public static void AddShowItemIDList(FlatBufferBuilder builder, VectorOffset ShowItemIDListOffset) { builder.AddOffset(7, ShowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateShowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDropBoxIDList(FlatBufferBuilder builder, VectorOffset DropBoxIDListOffset) { builder.AddOffset(8, DropBoxIDListOffset.Value, 0); }
  public static VectorOffset CreateDropBoxIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDropBoxIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBgName(FlatBufferBuilder builder, StringOffset BgNameOffset) { builder.AddOffset(9, BgNameOffset.Value, 0); }
  public static void AddTitalName(FlatBufferBuilder builder, StringOffset TitalNameOffset) { builder.AddOffset(10, TitalNameOffset.Value, 0); }
  public static void AddTeamPlatformId(FlatBufferBuilder builder, int TeamPlatformId) { builder.AddInt(11, TeamPlatformId, -1); }
  public static void AddBossicon(FlatBufferBuilder builder, StringOffset bossiconOffset) { builder.AddOffset(12, bossiconOffset.Value, 0); }
  public static void AddBigBoxId(FlatBufferBuilder builder, int BigBoxId) { builder.AddInt(13, BigBoxId, -1); }
  public static void AddSmallBoxId(FlatBufferBuilder builder, int SmallBoxId) { builder.AddInt(14, SmallBoxId, -1); }
  public static void AddBloodBigBoxDropId(FlatBufferBuilder builder, int BloodBigBoxDropId) { builder.AddInt(15, BloodBigBoxDropId, -1); }
  public static void AddBloodSmallBoxDropId(FlatBufferBuilder builder, int BloodSmallBoxDropId) { builder.AddInt(16, BloodSmallBoxDropId, -1); }
  public static Offset<FB_ShiLianBoss> EndFB_ShiLianBoss(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShiLianBoss>(o);
  }
};

public sealed class FB_ShiLianBossContainer : Table {
  public static FB_ShiLianBossContainer GetRootAsFB_ShiLianBossContainer(ByteBuffer _bb) { return GetRootAsFB_ShiLianBossContainer(_bb, new FB_ShiLianBossContainer()); }
  public static FB_ShiLianBossContainer GetRootAsFB_ShiLianBossContainer(ByteBuffer _bb, FB_ShiLianBossContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShiLianBossContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShiLianBossContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShiLianBoss GetItems(int j) { return GetItems(new FB_ShiLianBoss(), j); }
  public FB_ShiLianBoss GetItems(FB_ShiLianBoss obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShiLianBossContainer> CreateFB_ShiLianBossContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShiLianBossContainer.AddItems(builder, items);
    return FB_ShiLianBossContainer.EndFB_ShiLianBossContainer(builder);
  }

  public static void StartFB_ShiLianBossContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShiLianBoss>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShiLianBossContainer> EndFB_ShiLianBossContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShiLianBossContainer>(o);
  }
  public static void FinishFB_ShiLianBossContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShiLianBossContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
