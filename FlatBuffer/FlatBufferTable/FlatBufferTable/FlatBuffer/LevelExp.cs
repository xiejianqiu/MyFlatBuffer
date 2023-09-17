// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LevelExp : Table {
  public static FB_LevelExp GetRootAsFB_LevelExp(ByteBuffer _bb) { return GetRootAsFB_LevelExp(_bb, new FB_LevelExp()); }
  public static FB_LevelExp GetRootAsFB_LevelExp(ByteBuffer _bb, FB_LevelExp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LevelExp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int LevelID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long Exp { get { int o = __offset(8); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }

  public static Offset<FB_LevelExp> CreateFB_LevelExp(FlatBufferBuilder builder,
      int LevelID = 0,
      int Level = -1,
      long Exp = -1) {
    builder.StartObject(3);
    FB_LevelExp.AddExp(builder, Exp);
    FB_LevelExp.AddLevel(builder, Level);
    FB_LevelExp.AddLevelID(builder, LevelID);
    return FB_LevelExp.EndFB_LevelExp(builder);
  }

  public static void StartFB_LevelExp(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddLevelID(FlatBufferBuilder builder, int LevelID) { builder.AddInt(0, LevelID, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, -1); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(2, Exp, -1); }
  public static Offset<FB_LevelExp> EndFB_LevelExp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelExp>(o);
  }
};

public sealed class FB_LevelExpContainer : Table {
  public static FB_LevelExpContainer GetRootAsFB_LevelExpContainer(ByteBuffer _bb) { return GetRootAsFB_LevelExpContainer(_bb, new FB_LevelExpContainer()); }
  public static FB_LevelExpContainer GetRootAsFB_LevelExpContainer(ByteBuffer _bb, FB_LevelExpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LevelExpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LevelExpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LevelExp GetItems(int j) { return GetItems(new FB_LevelExp(), j); }
  public FB_LevelExp GetItems(FB_LevelExp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelExpContainer> CreateFB_LevelExpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LevelExpContainer.AddItems(builder, items);
    return FB_LevelExpContainer.EndFB_LevelExpContainer(builder);
  }

  public static void StartFB_LevelExpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LevelExp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelExpContainer> EndFB_LevelExpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelExpContainer>(o);
  }
  public static void FinishFB_LevelExpContainerBuffer(FlatBufferBuilder builder, Offset<FB_LevelExpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
