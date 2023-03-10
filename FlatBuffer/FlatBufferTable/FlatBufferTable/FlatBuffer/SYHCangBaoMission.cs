// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHCangBaoMission : Table {
  public static FB_SYHCangBaoMission GetRootAsFB_SYHCangBaoMission(ByteBuffer _bb) { return GetRootAsFB_SYHCangBaoMission(_bb, new FB_SYHCangBaoMission()); }
  public static FB_SYHCangBaoMission GetRootAsFB_SYHCangBaoMission(ByteBuffer _bb, FB_SYHCangBaoMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHCangBaoMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ActivityName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Score { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCountLimitList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CountLimitListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int DicId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MDId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowItemId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuntionOpenID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UIID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }

  public static Offset<FB_SYHCangBaoMission> CreateFB_SYHCangBaoMission(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ActivityName = default(StringOffset),
      int Score = -1,
      VectorOffset CountLimitList = default(VectorOffset),
      int DicId = -1,
      int MDId = -1,
      int ShowItemId = -1,
      int ActivityId = -1,
      int FuntionOpenID = 0,
      int UIID = 1) {
    builder.StartObject(10);
    FB_SYHCangBaoMission.AddUIID(builder, UIID);
    FB_SYHCangBaoMission.AddFuntionOpenID(builder, FuntionOpenID);
    FB_SYHCangBaoMission.AddActivityId(builder, ActivityId);
    FB_SYHCangBaoMission.AddShowItemId(builder, ShowItemId);
    FB_SYHCangBaoMission.AddMDId(builder, MDId);
    FB_SYHCangBaoMission.AddDicId(builder, DicId);
    FB_SYHCangBaoMission.AddCountLimitList(builder, CountLimitList);
    FB_SYHCangBaoMission.AddScore(builder, Score);
    FB_SYHCangBaoMission.AddActivityName(builder, ActivityName);
    FB_SYHCangBaoMission.AddID(builder, ID);
    return FB_SYHCangBaoMission.EndFB_SYHCangBaoMission(builder);
  }

  public static void StartFB_SYHCangBaoMission(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActivityName(FlatBufferBuilder builder, StringOffset ActivityNameOffset) { builder.AddOffset(1, ActivityNameOffset.Value, 0); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(2, Score, -1); }
  public static void AddCountLimitList(FlatBufferBuilder builder, VectorOffset CountLimitListOffset) { builder.AddOffset(3, CountLimitListOffset.Value, 0); }
  public static VectorOffset CreateCountLimitListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCountLimitListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(4, DicId, -1); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(5, MDId, -1); }
  public static void AddShowItemId(FlatBufferBuilder builder, int ShowItemId) { builder.AddInt(6, ShowItemId, -1); }
  public static void AddActivityId(FlatBufferBuilder builder, int ActivityId) { builder.AddInt(7, ActivityId, -1); }
  public static void AddFuntionOpenID(FlatBufferBuilder builder, int FuntionOpenID) { builder.AddInt(8, FuntionOpenID, 0); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(9, UIID, 1); }
  public static Offset<FB_SYHCangBaoMission> EndFB_SYHCangBaoMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHCangBaoMission>(o);
  }
};

public sealed class FB_SYHCangBaoMissionContainer : Table {
  public static FB_SYHCangBaoMissionContainer GetRootAsFB_SYHCangBaoMissionContainer(ByteBuffer _bb) { return GetRootAsFB_SYHCangBaoMissionContainer(_bb, new FB_SYHCangBaoMissionContainer()); }
  public static FB_SYHCangBaoMissionContainer GetRootAsFB_SYHCangBaoMissionContainer(ByteBuffer _bb, FB_SYHCangBaoMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHCangBaoMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHCangBaoMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHCangBaoMission GetItems(int j) { return GetItems(new FB_SYHCangBaoMission(), j); }
  public FB_SYHCangBaoMission GetItems(FB_SYHCangBaoMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHCangBaoMissionContainer> CreateFB_SYHCangBaoMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHCangBaoMissionContainer.AddItems(builder, items);
    return FB_SYHCangBaoMissionContainer.EndFB_SYHCangBaoMissionContainer(builder);
  }

  public static void StartFB_SYHCangBaoMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHCangBaoMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHCangBaoMissionContainer> EndFB_SYHCangBaoMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHCangBaoMissionContainer>(o);
  }
  public static void FinishFB_SYHCangBaoMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHCangBaoMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
