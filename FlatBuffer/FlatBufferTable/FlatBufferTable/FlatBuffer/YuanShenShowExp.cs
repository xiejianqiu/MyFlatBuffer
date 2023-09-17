// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_YuanShenShowExp : Table {
  public static FB_YuanShenShowExp GetRootAsFB_YuanShenShowExp(ByteBuffer _bb) { return GetRootAsFB_YuanShenShowExp(_bb, new FB_YuanShenShowExp()); }
  public static FB_YuanShenShowExp GetRootAsFB_YuanShenShowExp(ByteBuffer _bb, FB_YuanShenShowExp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_YuanShenShowExp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PlayerLv { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long GetParamList(int j) { int o = __offset(8); return o != 0 ? bb.GetLong(__vector(o) + j * 8) : (long)0; }
  public int ParamListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YuanShenShowExp> CreateFB_YuanShenShowExp(FlatBufferBuilder builder,
      int ID = 0,
      int PlayerLv = -1,
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_YuanShenShowExp.AddParamList(builder, ParamList);
    FB_YuanShenShowExp.AddPlayerLv(builder, PlayerLv);
    FB_YuanShenShowExp.AddID(builder, ID);
    return FB_YuanShenShowExp.EndFB_YuanShenShowExp(builder);
  }

  public static void StartFB_YuanShenShowExp(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPlayerLv(FlatBufferBuilder builder, int PlayerLv) { builder.AddInt(1, PlayerLv, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(2, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FB_YuanShenShowExp> EndFB_YuanShenShowExp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YuanShenShowExp>(o);
  }
};

public sealed class FB_YuanShenShowExpContainer : Table {
  public static FB_YuanShenShowExpContainer GetRootAsFB_YuanShenShowExpContainer(ByteBuffer _bb) { return GetRootAsFB_YuanShenShowExpContainer(_bb, new FB_YuanShenShowExpContainer()); }
  public static FB_YuanShenShowExpContainer GetRootAsFB_YuanShenShowExpContainer(ByteBuffer _bb, FB_YuanShenShowExpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_YuanShenShowExpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_YuanShenShowExpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_YuanShenShowExp GetItems(int j) { return GetItems(new FB_YuanShenShowExp(), j); }
  public FB_YuanShenShowExp GetItems(FB_YuanShenShowExp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YuanShenShowExpContainer> CreateFB_YuanShenShowExpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_YuanShenShowExpContainer.AddItems(builder, items);
    return FB_YuanShenShowExpContainer.EndFB_YuanShenShowExpContainer(builder);
  }

  public static void StartFB_YuanShenShowExpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_YuanShenShowExp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_YuanShenShowExpContainer> EndFB_YuanShenShowExpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YuanShenShowExpContainer>(o);
  }
  public static void FinishFB_YuanShenShowExpContainerBuffer(FlatBufferBuilder builder, Offset<FB_YuanShenShowExpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
