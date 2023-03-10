// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WorldBossLike : Table {
  public static FB_WorldBossLike GetRootAsFB_WorldBossLike(ByteBuffer _bb) { return GetRootAsFB_WorldBossLike(_bb, new FB_WorldBossLike()); }
  public static FB_WorldBossLike GetRootAsFB_WorldBossLike(ByteBuffer _bb, FB_WorldBossLike obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WorldBossLike __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CountDownSeconds { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WorldBossLike> CreateFB_WorldBossLike(FlatBufferBuilder builder,
      int Id = 0,
      int CountDownSeconds = -1,
      int MoneyType = -1,
      int MoneyNum = -1) {
    builder.StartObject(4);
    FB_WorldBossLike.AddMoneyNum(builder, MoneyNum);
    FB_WorldBossLike.AddMoneyType(builder, MoneyType);
    FB_WorldBossLike.AddCountDownSeconds(builder, CountDownSeconds);
    FB_WorldBossLike.AddId(builder, Id);
    return FB_WorldBossLike.EndFB_WorldBossLike(builder);
  }

  public static void StartFB_WorldBossLike(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCountDownSeconds(FlatBufferBuilder builder, int CountDownSeconds) { builder.AddInt(1, CountDownSeconds, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(2, MoneyType, -1); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(3, MoneyNum, -1); }
  public static Offset<FB_WorldBossLike> EndFB_WorldBossLike(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WorldBossLike>(o);
  }
};

public sealed class FB_WorldBossLikeContainer : Table {
  public static FB_WorldBossLikeContainer GetRootAsFB_WorldBossLikeContainer(ByteBuffer _bb) { return GetRootAsFB_WorldBossLikeContainer(_bb, new FB_WorldBossLikeContainer()); }
  public static FB_WorldBossLikeContainer GetRootAsFB_WorldBossLikeContainer(ByteBuffer _bb, FB_WorldBossLikeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WorldBossLikeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WorldBossLikeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WorldBossLike GetItems(int j) { return GetItems(new FB_WorldBossLike(), j); }
  public FB_WorldBossLike GetItems(FB_WorldBossLike obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WorldBossLikeContainer> CreateFB_WorldBossLikeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WorldBossLikeContainer.AddItems(builder, items);
    return FB_WorldBossLikeContainer.EndFB_WorldBossLikeContainer(builder);
  }

  public static void StartFB_WorldBossLikeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WorldBossLike>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WorldBossLikeContainer> EndFB_WorldBossLikeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WorldBossLikeContainer>(o);
  }
  public static void FinishFB_WorldBossLikeContainerBuffer(FlatBufferBuilder builder, Offset<FB_WorldBossLikeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
