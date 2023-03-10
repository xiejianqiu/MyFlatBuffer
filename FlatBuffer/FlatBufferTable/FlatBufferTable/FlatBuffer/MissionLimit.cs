// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionLimit : Table {
  public static FB_MissionLimit GetRootAsFB_MissionLimit(ByteBuffer _bb) { return GetRootAsFB_MissionLimit(_bb, new FB_MissionLimit()); }
  public static FB_MissionLimit GetRootAsFB_MissionLimit(ByteBuffer _bb, FB_MissionLimit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionLimit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LowLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PreMission { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNeed { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsLoop { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_MissionLimit> CreateFB_MissionLimit(FlatBufferBuilder builder,
      int Id = 0,
      int LowLevel = -1,
      int PreMission = -1,
      int ItemNeed = -1,
      int ItemCount = -1,
      bool IsLoop = false) {
    builder.StartObject(6);
    FB_MissionLimit.AddItemCount(builder, ItemCount);
    FB_MissionLimit.AddItemNeed(builder, ItemNeed);
    FB_MissionLimit.AddPreMission(builder, PreMission);
    FB_MissionLimit.AddLowLevel(builder, LowLevel);
    FB_MissionLimit.AddId(builder, Id);
    FB_MissionLimit.AddIsLoop(builder, IsLoop);
    return FB_MissionLimit.EndFB_MissionLimit(builder);
  }

  public static void StartFB_MissionLimit(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLowLevel(FlatBufferBuilder builder, int LowLevel) { builder.AddInt(1, LowLevel, -1); }
  public static void AddPreMission(FlatBufferBuilder builder, int PreMission) { builder.AddInt(2, PreMission, -1); }
  public static void AddItemNeed(FlatBufferBuilder builder, int ItemNeed) { builder.AddInt(3, ItemNeed, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(4, ItemCount, -1); }
  public static void AddIsLoop(FlatBufferBuilder builder, bool IsLoop) { builder.AddBool(5, IsLoop, false); }
  public static Offset<FB_MissionLimit> EndFB_MissionLimit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionLimit>(o);
  }
};

public sealed class FB_MissionLimitContainer : Table {
  public static FB_MissionLimitContainer GetRootAsFB_MissionLimitContainer(ByteBuffer _bb) { return GetRootAsFB_MissionLimitContainer(_bb, new FB_MissionLimitContainer()); }
  public static FB_MissionLimitContainer GetRootAsFB_MissionLimitContainer(ByteBuffer _bb, FB_MissionLimitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionLimitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionLimitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionLimit GetItems(int j) { return GetItems(new FB_MissionLimit(), j); }
  public FB_MissionLimit GetItems(FB_MissionLimit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionLimitContainer> CreateFB_MissionLimitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionLimitContainer.AddItems(builder, items);
    return FB_MissionLimitContainer.EndFB_MissionLimitContainer(builder);
  }

  public static void StartFB_MissionLimitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionLimit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionLimitContainer> EndFB_MissionLimitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionLimitContainer>(o);
  }
  public static void FinishFB_MissionLimitContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionLimitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
