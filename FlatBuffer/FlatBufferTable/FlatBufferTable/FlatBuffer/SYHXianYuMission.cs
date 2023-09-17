// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHXianYuMission : Table {
  public static FB_SYHXianYuMission GetRootAsFB_SYHXianYuMission(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuMission(_bb, new FB_SYHXianYuMission()); }
  public static FB_SYHXianYuMission GetRootAsFB_SYHXianYuMission(ByteBuffer _bb, FB_SYHXianYuMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHXianYuMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ActivityName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Score { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CountLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MDId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowItemId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuntionOpenID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UIID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }

  public static Offset<FB_SYHXianYuMission> CreateFB_SYHXianYuMission(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ActivityName = default(StringOffset),
      int Score = -1,
      int CountLimit = -1,
      int DicId = -1,
      int MDId = -1,
      int ShowItemId = -1,
      int ActivityId = -1,
      int FuntionOpenID = 0,
      int UIID = 1) {
    builder.StartObject(10);
    FB_SYHXianYuMission.AddUIID(builder, UIID);
    FB_SYHXianYuMission.AddFuntionOpenID(builder, FuntionOpenID);
    FB_SYHXianYuMission.AddActivityId(builder, ActivityId);
    FB_SYHXianYuMission.AddShowItemId(builder, ShowItemId);
    FB_SYHXianYuMission.AddMDId(builder, MDId);
    FB_SYHXianYuMission.AddDicId(builder, DicId);
    FB_SYHXianYuMission.AddCountLimit(builder, CountLimit);
    FB_SYHXianYuMission.AddScore(builder, Score);
    FB_SYHXianYuMission.AddActivityName(builder, ActivityName);
    FB_SYHXianYuMission.AddID(builder, ID);
    return FB_SYHXianYuMission.EndFB_SYHXianYuMission(builder);
  }

  public static void StartFB_SYHXianYuMission(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActivityName(FlatBufferBuilder builder, StringOffset ActivityNameOffset) { builder.AddOffset(1, ActivityNameOffset.Value, 0); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(2, Score, -1); }
  public static void AddCountLimit(FlatBufferBuilder builder, int CountLimit) { builder.AddInt(3, CountLimit, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(4, DicId, -1); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(5, MDId, -1); }
  public static void AddShowItemId(FlatBufferBuilder builder, int ShowItemId) { builder.AddInt(6, ShowItemId, -1); }
  public static void AddActivityId(FlatBufferBuilder builder, int ActivityId) { builder.AddInt(7, ActivityId, -1); }
  public static void AddFuntionOpenID(FlatBufferBuilder builder, int FuntionOpenID) { builder.AddInt(8, FuntionOpenID, 0); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(9, UIID, 1); }
  public static Offset<FB_SYHXianYuMission> EndFB_SYHXianYuMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuMission>(o);
  }
};

public sealed class FB_SYHXianYuMissionContainer : Table {
  public static FB_SYHXianYuMissionContainer GetRootAsFB_SYHXianYuMissionContainer(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuMissionContainer(_bb, new FB_SYHXianYuMissionContainer()); }
  public static FB_SYHXianYuMissionContainer GetRootAsFB_SYHXianYuMissionContainer(ByteBuffer _bb, FB_SYHXianYuMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHXianYuMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHXianYuMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHXianYuMission GetItems(int j) { return GetItems(new FB_SYHXianYuMission(), j); }
  public FB_SYHXianYuMission GetItems(FB_SYHXianYuMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianYuMissionContainer> CreateFB_SYHXianYuMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHXianYuMissionContainer.AddItems(builder, items);
    return FB_SYHXianYuMissionContainer.EndFB_SYHXianYuMissionContainer(builder);
  }

  public static void StartFB_SYHXianYuMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHXianYuMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianYuMissionContainer> EndFB_SYHXianYuMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuMissionContainer>(o);
  }
  public static void FinishFB_SYHXianYuMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHXianYuMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
