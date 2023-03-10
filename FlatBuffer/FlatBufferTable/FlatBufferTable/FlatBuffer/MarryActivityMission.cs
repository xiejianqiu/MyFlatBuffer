// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryActivityMission : Table {
  public static FB_MarryActivityMission GetRootAsFB_MarryActivityMission(ByteBuffer _bb) { return GetRootAsFB_MarryActivityMission(_bb, new FB_MarryActivityMission()); }
  public static FB_MarryActivityMission GetRootAsFB_MarryActivityMission(ByteBuffer _bb, FB_MarryActivityMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryActivityMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Score { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Target { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitTimes { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ShowItemId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int UIID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ParmID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MarryActivityMission> CreateFB_MarryActivityMission(FlatBufferBuilder builder,
      int ID = 0,
      int Score = 0,
      int target = 0,
      int limitTimes = -1,
      int DicId = -1,
      StringOffset Name = default(StringOffset),
      int ShowItemId = -1,
      int Type = -1,
      int SortId = 1,
      int UIID = -1,
      int ParmID = -1,
      int ActivityType = -1) {
    builder.StartObject(12);
    FB_MarryActivityMission.AddActivityType(builder, ActivityType);
    FB_MarryActivityMission.AddParmID(builder, ParmID);
    FB_MarryActivityMission.AddUIID(builder, UIID);
    FB_MarryActivityMission.AddSortId(builder, SortId);
    FB_MarryActivityMission.AddType(builder, Type);
    FB_MarryActivityMission.AddShowItemId(builder, ShowItemId);
    FB_MarryActivityMission.AddName(builder, Name);
    FB_MarryActivityMission.AddDicId(builder, DicId);
    FB_MarryActivityMission.AddLimitTimes(builder, limitTimes);
    FB_MarryActivityMission.AddTarget(builder, target);
    FB_MarryActivityMission.AddScore(builder, Score);
    FB_MarryActivityMission.AddID(builder, ID);
    return FB_MarryActivityMission.EndFB_MarryActivityMission(builder);
  }

  public static void StartFB_MarryActivityMission(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(1, Score, 0); }
  public static void AddTarget(FlatBufferBuilder builder, int target) { builder.AddInt(2, target, 0); }
  public static void AddLimitTimes(FlatBufferBuilder builder, int limitTimes) { builder.AddInt(3, limitTimes, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(4, DicId, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(5, NameOffset.Value, 0); }
  public static void AddShowItemId(FlatBufferBuilder builder, int ShowItemId) { builder.AddInt(6, ShowItemId, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(7, Type, -1); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(8, SortId, 1); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(9, UIID, -1); }
  public static void AddParmID(FlatBufferBuilder builder, int ParmID) { builder.AddInt(10, ParmID, -1); }
  public static void AddActivityType(FlatBufferBuilder builder, int ActivityType) { builder.AddInt(11, ActivityType, -1); }
  public static Offset<FB_MarryActivityMission> EndFB_MarryActivityMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryActivityMission>(o);
  }
};

public sealed class FB_MarryActivityMissionContainer : Table {
  public static FB_MarryActivityMissionContainer GetRootAsFB_MarryActivityMissionContainer(ByteBuffer _bb) { return GetRootAsFB_MarryActivityMissionContainer(_bb, new FB_MarryActivityMissionContainer()); }
  public static FB_MarryActivityMissionContainer GetRootAsFB_MarryActivityMissionContainer(ByteBuffer _bb, FB_MarryActivityMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryActivityMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryActivityMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryActivityMission GetItems(int j) { return GetItems(new FB_MarryActivityMission(), j); }
  public FB_MarryActivityMission GetItems(FB_MarryActivityMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryActivityMissionContainer> CreateFB_MarryActivityMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryActivityMissionContainer.AddItems(builder, items);
    return FB_MarryActivityMissionContainer.EndFB_MarryActivityMissionContainer(builder);
  }

  public static void StartFB_MarryActivityMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryActivityMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryActivityMissionContainer> EndFB_MarryActivityMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryActivityMissionContainer>(o);
  }
  public static void FinishFB_MarryActivityMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryActivityMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
