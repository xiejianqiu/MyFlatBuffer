// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHFestivalActivityList : Table {
  public static FB_SYHFestivalActivityList GetRootAsFB_SYHFestivalActivityList(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalActivityList(_bb, new FB_SYHFestivalActivityList()); }
  public static FB_SYHFestivalActivityList GetRootAsFB_SYHFestivalActivityList(ByteBuffer _bb, FB_SYHFestivalActivityList obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHFestivalActivityList __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Describe { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int OpenTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NPCID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float NPCX { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float NPCZ { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_SYHFestivalActivityList> CreateFB_SYHFestivalActivityList(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Describe = default(StringOffset),
      int OpenTime = -1,
      int EndTime = -1,
      int NPCID = -1,
      int SceneID = -1,
      float NPCX = 0,
      float NPCZ = 0) {
    builder.StartObject(9);
    FB_SYHFestivalActivityList.AddNPCZ(builder, NPCZ);
    FB_SYHFestivalActivityList.AddNPCX(builder, NPCX);
    FB_SYHFestivalActivityList.AddSceneID(builder, SceneID);
    FB_SYHFestivalActivityList.AddNPCID(builder, NPCID);
    FB_SYHFestivalActivityList.AddEndTime(builder, EndTime);
    FB_SYHFestivalActivityList.AddOpenTime(builder, OpenTime);
    FB_SYHFestivalActivityList.AddDescribe(builder, Describe);
    FB_SYHFestivalActivityList.AddName(builder, Name);
    FB_SYHFestivalActivityList.AddID(builder, ID);
    return FB_SYHFestivalActivityList.EndFB_SYHFestivalActivityList(builder);
  }

  public static void StartFB_SYHFestivalActivityList(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDescribe(FlatBufferBuilder builder, StringOffset DescribeOffset) { builder.AddOffset(2, DescribeOffset.Value, 0); }
  public static void AddOpenTime(FlatBufferBuilder builder, int OpenTime) { builder.AddInt(3, OpenTime, -1); }
  public static void AddEndTime(FlatBufferBuilder builder, int EndTime) { builder.AddInt(4, EndTime, -1); }
  public static void AddNPCID(FlatBufferBuilder builder, int NPCID) { builder.AddInt(5, NPCID, -1); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(6, SceneID, -1); }
  public static void AddNPCX(FlatBufferBuilder builder, float NPCX) { builder.AddFloat(7, NPCX, 0); }
  public static void AddNPCZ(FlatBufferBuilder builder, float NPCZ) { builder.AddFloat(8, NPCZ, 0); }
  public static Offset<FB_SYHFestivalActivityList> EndFB_SYHFestivalActivityList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalActivityList>(o);
  }
};

public sealed class FB_SYHFestivalActivityListContainer : Table {
  public static FB_SYHFestivalActivityListContainer GetRootAsFB_SYHFestivalActivityListContainer(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalActivityListContainer(_bb, new FB_SYHFestivalActivityListContainer()); }
  public static FB_SYHFestivalActivityListContainer GetRootAsFB_SYHFestivalActivityListContainer(ByteBuffer _bb, FB_SYHFestivalActivityListContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHFestivalActivityListContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHFestivalActivityListContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHFestivalActivityList GetItems(int j) { return GetItems(new FB_SYHFestivalActivityList(), j); }
  public FB_SYHFestivalActivityList GetItems(FB_SYHFestivalActivityList obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHFestivalActivityListContainer> CreateFB_SYHFestivalActivityListContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHFestivalActivityListContainer.AddItems(builder, items);
    return FB_SYHFestivalActivityListContainer.EndFB_SYHFestivalActivityListContainer(builder);
  }

  public static void StartFB_SYHFestivalActivityListContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHFestivalActivityList>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHFestivalActivityListContainer> EndFB_SYHFestivalActivityListContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalActivityListContainer>(o);
  }
  public static void FinishFB_SYHFestivalActivityListContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHFestivalActivityListContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
