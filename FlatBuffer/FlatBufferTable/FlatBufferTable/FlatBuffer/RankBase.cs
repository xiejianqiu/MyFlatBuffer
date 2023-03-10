// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RankBase : Table {
  public static FB_RankBase GetRootAsFB_RankBase(ByteBuffer _bb) { return GetRootAsFB_RankBase(_bb, new FB_RankBase()); }
  public static FB_RankBase GetRootAsFB_RankBase(ByteBuffer _bb, FB_RankBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RankBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LogicType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GroupCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int RefreshType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int RefreshTime { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int BounsTarget { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BounsType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int BounsTime { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int BounsMailID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowNum { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int ShowType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsSaveDB { get { int o = __offset(28); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsOutCopySceneRank { get { int o = __offset(30); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_RankBase> CreateFB_RankBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int LogicType = 0,
      int GroupCount = 1,
      int RefreshType = 1,
      int RefreshTime = 1,
      int BounsTarget = 0,
      int BounsType = 1,
      int BounsTime = 1,
      int BounsMailID = -1,
      int ShowNum = 1,
      int ShowType = -1,
      bool IsSaveDB = false,
      bool IsOutCopySceneRank = false) {
    builder.StartObject(14);
    FB_RankBase.AddShowType(builder, ShowType);
    FB_RankBase.AddShowNum(builder, ShowNum);
    FB_RankBase.AddBounsMailID(builder, BounsMailID);
    FB_RankBase.AddBounsTime(builder, BounsTime);
    FB_RankBase.AddBounsType(builder, BounsType);
    FB_RankBase.AddBounsTarget(builder, BounsTarget);
    FB_RankBase.AddRefreshTime(builder, RefreshTime);
    FB_RankBase.AddRefreshType(builder, RefreshType);
    FB_RankBase.AddGroupCount(builder, GroupCount);
    FB_RankBase.AddLogicType(builder, LogicType);
    FB_RankBase.AddName(builder, Name);
    FB_RankBase.AddID(builder, ID);
    FB_RankBase.AddIsOutCopySceneRank(builder, IsOutCopySceneRank);
    FB_RankBase.AddIsSaveDB(builder, IsSaveDB);
    return FB_RankBase.EndFB_RankBase(builder);
  }

  public static void StartFB_RankBase(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLogicType(FlatBufferBuilder builder, int LogicType) { builder.AddInt(2, LogicType, 0); }
  public static void AddGroupCount(FlatBufferBuilder builder, int GroupCount) { builder.AddInt(3, GroupCount, 1); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(4, RefreshType, 1); }
  public static void AddRefreshTime(FlatBufferBuilder builder, int RefreshTime) { builder.AddInt(5, RefreshTime, 1); }
  public static void AddBounsTarget(FlatBufferBuilder builder, int BounsTarget) { builder.AddInt(6, BounsTarget, 0); }
  public static void AddBounsType(FlatBufferBuilder builder, int BounsType) { builder.AddInt(7, BounsType, 1); }
  public static void AddBounsTime(FlatBufferBuilder builder, int BounsTime) { builder.AddInt(8, BounsTime, 1); }
  public static void AddBounsMailID(FlatBufferBuilder builder, int BounsMailID) { builder.AddInt(9, BounsMailID, -1); }
  public static void AddShowNum(FlatBufferBuilder builder, int ShowNum) { builder.AddInt(10, ShowNum, 1); }
  public static void AddShowType(FlatBufferBuilder builder, int ShowType) { builder.AddInt(11, ShowType, -1); }
  public static void AddIsSaveDB(FlatBufferBuilder builder, bool IsSaveDB) { builder.AddBool(12, IsSaveDB, false); }
  public static void AddIsOutCopySceneRank(FlatBufferBuilder builder, bool IsOutCopySceneRank) { builder.AddBool(13, IsOutCopySceneRank, false); }
  public static Offset<FB_RankBase> EndFB_RankBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RankBase>(o);
  }
};

public sealed class FB_RankBaseContainer : Table {
  public static FB_RankBaseContainer GetRootAsFB_RankBaseContainer(ByteBuffer _bb) { return GetRootAsFB_RankBaseContainer(_bb, new FB_RankBaseContainer()); }
  public static FB_RankBaseContainer GetRootAsFB_RankBaseContainer(ByteBuffer _bb, FB_RankBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RankBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RankBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RankBase GetItems(int j) { return GetItems(new FB_RankBase(), j); }
  public FB_RankBase GetItems(FB_RankBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RankBaseContainer> CreateFB_RankBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RankBaseContainer.AddItems(builder, items);
    return FB_RankBaseContainer.EndFB_RankBaseContainer(builder);
  }

  public static void StartFB_RankBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RankBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RankBaseContainer> EndFB_RankBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RankBaseContainer>(o);
  }
  public static void FinishFB_RankBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_RankBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
