// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MiniMap : Table {
  public static FB_MiniMap GetRootAsFB_MiniMap(ByteBuffer _bb) { return GetRootAsFB_MiniMap(_bb, new FB_MiniMap()); }
  public static FB_MiniMap GetRootAsFB_MiniMap(ByteBuffer _bb, FB_MiniMap obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MiniMap __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Scene { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int NpcID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OpenType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetOpenTimeList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OpenTimeListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetEndTimeList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EndTimeListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public float PosY { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int OfflineRewardID { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLvl { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLvl { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowFlyShoe { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int RefreshLevel { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MiniMap> CreateFB_MiniMap(FlatBufferBuilder builder,
      int Id = 0,
      int Scene = -1,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      int ShowType = 0,
      float PosX = 0,
      float PosZ = 0,
      int NpcID = 0,
      int OpenType = -1,
      VectorOffset OpenTimeList = default(VectorOffset),
      VectorOffset EndTimeList = default(VectorOffset),
      float PosY = 0,
      int OfflineRewardID = -1,
      int MinLvl = -1,
      int MaxLvl = -1,
      int Quality = -1,
      bool IsShowFlyShoe = true,
      int RefreshLevel = -1) {
    builder.StartObject(18);
    FB_MiniMap.AddRefreshLevel(builder, RefreshLevel);
    FB_MiniMap.AddQuality(builder, Quality);
    FB_MiniMap.AddMaxLvl(builder, MaxLvl);
    FB_MiniMap.AddMinLvl(builder, MinLvl);
    FB_MiniMap.AddOfflineRewardID(builder, OfflineRewardID);
    FB_MiniMap.AddPosY(builder, PosY);
    FB_MiniMap.AddEndTimeList(builder, EndTimeList);
    FB_MiniMap.AddOpenTimeList(builder, OpenTimeList);
    FB_MiniMap.AddOpenType(builder, OpenType);
    FB_MiniMap.AddNpcID(builder, NpcID);
    FB_MiniMap.AddPosZ(builder, PosZ);
    FB_MiniMap.AddPosX(builder, PosX);
    FB_MiniMap.AddShowType(builder, ShowType);
    FB_MiniMap.AddType(builder, Type);
    FB_MiniMap.AddName(builder, Name);
    FB_MiniMap.AddScene(builder, Scene);
    FB_MiniMap.AddId(builder, Id);
    FB_MiniMap.AddIsShowFlyShoe(builder, IsShowFlyShoe);
    return FB_MiniMap.EndFB_MiniMap(builder);
  }

  public static void StartFB_MiniMap(FlatBufferBuilder builder) { builder.StartObject(18); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddScene(FlatBufferBuilder builder, int Scene) { builder.AddInt(1, Scene, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static void AddShowType(FlatBufferBuilder builder, int ShowType) { builder.AddInt(4, ShowType, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(5, PosX, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(6, PosZ, 0); }
  public static void AddNpcID(FlatBufferBuilder builder, int NpcID) { builder.AddInt(7, NpcID, 0); }
  public static void AddOpenType(FlatBufferBuilder builder, int OpenType) { builder.AddInt(8, OpenType, -1); }
  public static void AddOpenTimeList(FlatBufferBuilder builder, VectorOffset OpenTimeListOffset) { builder.AddOffset(9, OpenTimeListOffset.Value, 0); }
  public static VectorOffset CreateOpenTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOpenTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEndTimeList(FlatBufferBuilder builder, VectorOffset EndTimeListOffset) { builder.AddOffset(10, EndTimeListOffset.Value, 0); }
  public static VectorOffset CreateEndTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEndTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(11, PosY, 0); }
  public static void AddOfflineRewardID(FlatBufferBuilder builder, int OfflineRewardID) { builder.AddInt(12, OfflineRewardID, -1); }
  public static void AddMinLvl(FlatBufferBuilder builder, int MinLvl) { builder.AddInt(13, MinLvl, -1); }
  public static void AddMaxLvl(FlatBufferBuilder builder, int MaxLvl) { builder.AddInt(14, MaxLvl, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(15, Quality, -1); }
  public static void AddIsShowFlyShoe(FlatBufferBuilder builder, bool IsShowFlyShoe) { builder.AddBool(16, IsShowFlyShoe, true); }
  public static void AddRefreshLevel(FlatBufferBuilder builder, int RefreshLevel) { builder.AddInt(17, RefreshLevel, -1); }
  public static Offset<FB_MiniMap> EndFB_MiniMap(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MiniMap>(o);
  }
};

public sealed class FB_MiniMapContainer : Table {
  public static FB_MiniMapContainer GetRootAsFB_MiniMapContainer(ByteBuffer _bb) { return GetRootAsFB_MiniMapContainer(_bb, new FB_MiniMapContainer()); }
  public static FB_MiniMapContainer GetRootAsFB_MiniMapContainer(ByteBuffer _bb, FB_MiniMapContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MiniMapContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MiniMapContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MiniMap GetItems(int j) { return GetItems(new FB_MiniMap(), j); }
  public FB_MiniMap GetItems(FB_MiniMap obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MiniMapContainer> CreateFB_MiniMapContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MiniMapContainer.AddItems(builder, items);
    return FB_MiniMapContainer.EndFB_MiniMapContainer(builder);
  }

  public static void StartFB_MiniMapContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MiniMap>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MiniMapContainer> EndFB_MiniMapContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MiniMapContainer>(o);
  }
  public static void FinishFB_MiniMapContainerBuffer(FlatBufferBuilder builder, Offset<FB_MiniMapContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
