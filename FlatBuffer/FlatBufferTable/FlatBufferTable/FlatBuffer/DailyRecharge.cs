// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DailyRecharge : Table {
  public static FB_DailyRecharge GetRootAsFB_DailyRecharge(ByteBuffer _bb) { return GetRootAsFB_DailyRecharge(_bb, new FB_DailyRecharge()); }
  public static FB_DailyRecharge GetRootAsFB_DailyRecharge(ByteBuffer _bb, FB_DailyRecharge obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DailyRecharge __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScoreLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DailyRecharge> CreateFB_DailyRecharge(FlatBufferBuilder builder,
      int ID = 0,
      int ScoreLimit = -1,
      int Type = -1) {
    builder.StartObject(3);
    FB_DailyRecharge.AddType(builder, Type);
    FB_DailyRecharge.AddScoreLimit(builder, ScoreLimit);
    FB_DailyRecharge.AddID(builder, ID);
    return FB_DailyRecharge.EndFB_DailyRecharge(builder);
  }

  public static void StartFB_DailyRecharge(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScoreLimit(FlatBufferBuilder builder, int ScoreLimit) { builder.AddInt(1, ScoreLimit, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static Offset<FB_DailyRecharge> EndFB_DailyRecharge(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DailyRecharge>(o);
  }
};

public sealed class FB_DailyRechargeContainer : Table {
  public static FB_DailyRechargeContainer GetRootAsFB_DailyRechargeContainer(ByteBuffer _bb) { return GetRootAsFB_DailyRechargeContainer(_bb, new FB_DailyRechargeContainer()); }
  public static FB_DailyRechargeContainer GetRootAsFB_DailyRechargeContainer(ByteBuffer _bb, FB_DailyRechargeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DailyRechargeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DailyRechargeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DailyRecharge GetItems(int j) { return GetItems(new FB_DailyRecharge(), j); }
  public FB_DailyRecharge GetItems(FB_DailyRecharge obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DailyRechargeContainer> CreateFB_DailyRechargeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DailyRechargeContainer.AddItems(builder, items);
    return FB_DailyRechargeContainer.EndFB_DailyRechargeContainer(builder);
  }

  public static void StartFB_DailyRechargeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DailyRecharge>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DailyRechargeContainer> EndFB_DailyRechargeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DailyRechargeContainer>(o);
  }
  public static void FinishFB_DailyRechargeContainerBuffer(FlatBufferBuilder builder, Offset<FB_DailyRechargeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
