// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHFestivalMonster : Table {
  public static FB_SYHFestivalMonster GetRootAsFB_SYHFestivalMonster(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalMonster(_bb, new FB_SYHFestivalMonster()); }
  public static FB_SYHFestivalMonster GetRootAsFB_SYHFestivalMonster(ByteBuffer _bb, FB_SYHFestivalMonster obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHFestivalMonster __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ActivityName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ActivityTime { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHFestivalMonster> CreateFB_SYHFestivalMonster(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ActivityName = default(StringOffset),
      int ActivityTime = -1) {
    builder.StartObject(3);
    FB_SYHFestivalMonster.AddActivityTime(builder, ActivityTime);
    FB_SYHFestivalMonster.AddActivityName(builder, ActivityName);
    FB_SYHFestivalMonster.AddID(builder, ID);
    return FB_SYHFestivalMonster.EndFB_SYHFestivalMonster(builder);
  }

  public static void StartFB_SYHFestivalMonster(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActivityName(FlatBufferBuilder builder, StringOffset ActivityNameOffset) { builder.AddOffset(1, ActivityNameOffset.Value, 0); }
  public static void AddActivityTime(FlatBufferBuilder builder, int ActivityTime) { builder.AddInt(2, ActivityTime, -1); }
  public static Offset<FB_SYHFestivalMonster> EndFB_SYHFestivalMonster(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalMonster>(o);
  }
};

public sealed class FB_SYHFestivalMonsterContainer : Table {
  public static FB_SYHFestivalMonsterContainer GetRootAsFB_SYHFestivalMonsterContainer(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalMonsterContainer(_bb, new FB_SYHFestivalMonsterContainer()); }
  public static FB_SYHFestivalMonsterContainer GetRootAsFB_SYHFestivalMonsterContainer(ByteBuffer _bb, FB_SYHFestivalMonsterContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHFestivalMonsterContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHFestivalMonsterContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHFestivalMonster GetItems(int j) { return GetItems(new FB_SYHFestivalMonster(), j); }
  public FB_SYHFestivalMonster GetItems(FB_SYHFestivalMonster obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHFestivalMonsterContainer> CreateFB_SYHFestivalMonsterContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHFestivalMonsterContainer.AddItems(builder, items);
    return FB_SYHFestivalMonsterContainer.EndFB_SYHFestivalMonsterContainer(builder);
  }

  public static void StartFB_SYHFestivalMonsterContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHFestivalMonster>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHFestivalMonsterContainer> EndFB_SYHFestivalMonsterContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalMonsterContainer>(o);
  }
  public static void FinishFB_SYHFestivalMonsterContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHFestivalMonsterContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
