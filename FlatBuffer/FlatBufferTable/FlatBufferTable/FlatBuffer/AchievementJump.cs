// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AchievementJump : Table {
  public static FB_AchievementJump GetRootAsFB_AchievementJump(ByteBuffer _bb) { return GetRootAsFB_AchievementJump(_bb, new FB_AchievementJump()); }
  public static FB_AchievementJump GetRootAsFB_AchievementJump(ByteBuffer _bb, FB_AchievementJump obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AchievementJump __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetPathBaseId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_AchievementJump> CreateFB_AchievementJump(FlatBufferBuilder builder,
      int ID = 0,
      int GetPathBaseId = -1) {
    builder.StartObject(2);
    FB_AchievementJump.AddGetPathBaseId(builder, GetPathBaseId);
    FB_AchievementJump.AddID(builder, ID);
    return FB_AchievementJump.EndFB_AchievementJump(builder);
  }

  public static void StartFB_AchievementJump(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGetPathBaseId(FlatBufferBuilder builder, int GetPathBaseId) { builder.AddInt(1, GetPathBaseId, -1); }
  public static Offset<FB_AchievementJump> EndFB_AchievementJump(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementJump>(o);
  }
};

public sealed class FB_AchievementJumpContainer : Table {
  public static FB_AchievementJumpContainer GetRootAsFB_AchievementJumpContainer(ByteBuffer _bb) { return GetRootAsFB_AchievementJumpContainer(_bb, new FB_AchievementJumpContainer()); }
  public static FB_AchievementJumpContainer GetRootAsFB_AchievementJumpContainer(ByteBuffer _bb, FB_AchievementJumpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AchievementJumpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AchievementJumpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AchievementJump GetItems(int j) { return GetItems(new FB_AchievementJump(), j); }
  public FB_AchievementJump GetItems(FB_AchievementJump obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AchievementJumpContainer> CreateFB_AchievementJumpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AchievementJumpContainer.AddItems(builder, items);
    return FB_AchievementJumpContainer.EndFB_AchievementJumpContainer(builder);
  }

  public static void StartFB_AchievementJumpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AchievementJump>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AchievementJumpContainer> EndFB_AchievementJumpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementJumpContainer>(o);
  }
  public static void FinishFB_AchievementJumpContainerBuffer(FlatBufferBuilder builder, Offset<FB_AchievementJumpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
