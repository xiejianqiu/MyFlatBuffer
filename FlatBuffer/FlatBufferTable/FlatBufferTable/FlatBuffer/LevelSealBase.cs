// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LevelSealBase : Table {
  public static FB_LevelSealBase GetRootAsFB_LevelSealBase(ByteBuffer _bb) { return GetRootAsFB_LevelSealBase(_bb, new FB_LevelSealBase()); }
  public static FB_LevelSealBase GetRootAsFB_LevelSealBase(ByteBuffer _bb, FB_LevelSealBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LevelSealBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Duration { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighCopySceneId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowCopySceneId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LevelSealBase> CreateFB_LevelSealBase(FlatBufferBuilder builder,
      int ID = 0,
      int LevelLimit = -1,
      int Duration = -1,
      int HighCopySceneId = -1,
      int LowCopySceneId = -1) {
    builder.StartObject(5);
    FB_LevelSealBase.AddLowCopySceneId(builder, LowCopySceneId);
    FB_LevelSealBase.AddHighCopySceneId(builder, HighCopySceneId);
    FB_LevelSealBase.AddDuration(builder, Duration);
    FB_LevelSealBase.AddLevelLimit(builder, LevelLimit);
    FB_LevelSealBase.AddID(builder, ID);
    return FB_LevelSealBase.EndFB_LevelSealBase(builder);
  }

  public static void StartFB_LevelSealBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(1, LevelLimit, -1); }
  public static void AddDuration(FlatBufferBuilder builder, int Duration) { builder.AddInt(2, Duration, -1); }
  public static void AddHighCopySceneId(FlatBufferBuilder builder, int HighCopySceneId) { builder.AddInt(3, HighCopySceneId, -1); }
  public static void AddLowCopySceneId(FlatBufferBuilder builder, int LowCopySceneId) { builder.AddInt(4, LowCopySceneId, -1); }
  public static Offset<FB_LevelSealBase> EndFB_LevelSealBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealBase>(o);
  }
};

public sealed class FB_LevelSealBaseContainer : Table {
  public static FB_LevelSealBaseContainer GetRootAsFB_LevelSealBaseContainer(ByteBuffer _bb) { return GetRootAsFB_LevelSealBaseContainer(_bb, new FB_LevelSealBaseContainer()); }
  public static FB_LevelSealBaseContainer GetRootAsFB_LevelSealBaseContainer(ByteBuffer _bb, FB_LevelSealBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LevelSealBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LevelSealBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LevelSealBase GetItems(int j) { return GetItems(new FB_LevelSealBase(), j); }
  public FB_LevelSealBase GetItems(FB_LevelSealBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelSealBaseContainer> CreateFB_LevelSealBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LevelSealBaseContainer.AddItems(builder, items);
    return FB_LevelSealBaseContainer.EndFB_LevelSealBaseContainer(builder);
  }

  public static void StartFB_LevelSealBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LevelSealBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelSealBaseContainer> EndFB_LevelSealBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealBaseContainer>(o);
  }
  public static void FinishFB_LevelSealBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_LevelSealBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
