// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHFestivalCarnivalMission : Table {
  public static FB_SYHFestivalCarnivalMission GetRootAsFB_SYHFestivalCarnivalMission(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalCarnivalMission(_bb, new FB_SYHFestivalCarnivalMission()); }
  public static FB_SYHFestivalCarnivalMission GetRootAsFB_SYHFestivalCarnivalMission(ByteBuffer _bb, FB_SYHFestivalCarnivalMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHFestivalCarnivalMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScoreLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHFestivalCarnivalMission> CreateFB_SYHFestivalCarnivalMission(FlatBufferBuilder builder,
      int ID = 0,
      int ScoreLimit = -1,
      int ShowItemId = -1) {
    builder.StartObject(3);
    FB_SYHFestivalCarnivalMission.AddShowItemId(builder, ShowItemId);
    FB_SYHFestivalCarnivalMission.AddScoreLimit(builder, ScoreLimit);
    FB_SYHFestivalCarnivalMission.AddID(builder, ID);
    return FB_SYHFestivalCarnivalMission.EndFB_SYHFestivalCarnivalMission(builder);
  }

  public static void StartFB_SYHFestivalCarnivalMission(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScoreLimit(FlatBufferBuilder builder, int ScoreLimit) { builder.AddInt(1, ScoreLimit, -1); }
  public static void AddShowItemId(FlatBufferBuilder builder, int ShowItemId) { builder.AddInt(2, ShowItemId, -1); }
  public static Offset<FB_SYHFestivalCarnivalMission> EndFB_SYHFestivalCarnivalMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalCarnivalMission>(o);
  }
};

public sealed class FB_SYHFestivalCarnivalMissionContainer : Table {
  public static FB_SYHFestivalCarnivalMissionContainer GetRootAsFB_SYHFestivalCarnivalMissionContainer(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalCarnivalMissionContainer(_bb, new FB_SYHFestivalCarnivalMissionContainer()); }
  public static FB_SYHFestivalCarnivalMissionContainer GetRootAsFB_SYHFestivalCarnivalMissionContainer(ByteBuffer _bb, FB_SYHFestivalCarnivalMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHFestivalCarnivalMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHFestivalCarnivalMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHFestivalCarnivalMission GetItems(int j) { return GetItems(new FB_SYHFestivalCarnivalMission(), j); }
  public FB_SYHFestivalCarnivalMission GetItems(FB_SYHFestivalCarnivalMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHFestivalCarnivalMissionContainer> CreateFB_SYHFestivalCarnivalMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHFestivalCarnivalMissionContainer.AddItems(builder, items);
    return FB_SYHFestivalCarnivalMissionContainer.EndFB_SYHFestivalCarnivalMissionContainer(builder);
  }

  public static void StartFB_SYHFestivalCarnivalMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHFestivalCarnivalMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHFestivalCarnivalMissionContainer> EndFB_SYHFestivalCarnivalMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalCarnivalMissionContainer>(o);
  }
  public static void FinishFB_SYHFestivalCarnivalMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHFestivalCarnivalMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
