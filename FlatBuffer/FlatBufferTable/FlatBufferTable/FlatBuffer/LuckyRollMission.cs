// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LuckyRollMission : Table {
  public static FB_LuckyRollMission GetRootAsFB_LuckyRollMission(ByteBuffer _bb) { return GetRootAsFB_LuckyRollMission(_bb, new FB_LuckyRollMission()); }
  public static FB_LuckyRollMission GetRootAsFB_LuckyRollMission(ByteBuffer _bb, FB_LuckyRollMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LuckyRollMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScoreLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LuckyRollMission> CreateFB_LuckyRollMission(FlatBufferBuilder builder,
      int ID = 0,
      int ScoreLimit = -1,
      int DicId = -1) {
    builder.StartObject(3);
    FB_LuckyRollMission.AddDicId(builder, DicId);
    FB_LuckyRollMission.AddScoreLimit(builder, ScoreLimit);
    FB_LuckyRollMission.AddID(builder, ID);
    return FB_LuckyRollMission.EndFB_LuckyRollMission(builder);
  }

  public static void StartFB_LuckyRollMission(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScoreLimit(FlatBufferBuilder builder, int ScoreLimit) { builder.AddInt(1, ScoreLimit, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(2, DicId, -1); }
  public static Offset<FB_LuckyRollMission> EndFB_LuckyRollMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LuckyRollMission>(o);
  }
};

public sealed class FB_LuckyRollMissionContainer : Table {
  public static FB_LuckyRollMissionContainer GetRootAsFB_LuckyRollMissionContainer(ByteBuffer _bb) { return GetRootAsFB_LuckyRollMissionContainer(_bb, new FB_LuckyRollMissionContainer()); }
  public static FB_LuckyRollMissionContainer GetRootAsFB_LuckyRollMissionContainer(ByteBuffer _bb, FB_LuckyRollMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LuckyRollMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LuckyRollMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LuckyRollMission GetItems(int j) { return GetItems(new FB_LuckyRollMission(), j); }
  public FB_LuckyRollMission GetItems(FB_LuckyRollMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LuckyRollMissionContainer> CreateFB_LuckyRollMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LuckyRollMissionContainer.AddItems(builder, items);
    return FB_LuckyRollMissionContainer.EndFB_LuckyRollMissionContainer(builder);
  }

  public static void StartFB_LuckyRollMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LuckyRollMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LuckyRollMissionContainer> EndFB_LuckyRollMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LuckyRollMissionContainer>(o);
  }
  public static void FinishFB_LuckyRollMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_LuckyRollMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
