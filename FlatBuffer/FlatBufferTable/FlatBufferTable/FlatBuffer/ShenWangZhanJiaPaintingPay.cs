// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaPaintingPay : Table {
  public static FB_ShenWangZhanJiaPaintingPay GetRootAsFB_ShenWangZhanJiaPaintingPay(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPaintingPay(_bb, new FB_ShenWangZhanJiaPaintingPay()); }
  public static FB_ShenWangZhanJiaPaintingPay GetRootAsFB_ShenWangZhanJiaPaintingPay(ByteBuffer _bb, FB_ShenWangZhanJiaPaintingPay obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaPaintingPay __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RMBId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Value { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TitleId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShenWangZhanJiaPaintingPay> CreateFB_ShenWangZhanJiaPaintingPay(FlatBufferBuilder builder,
      int ID = 0,
      int RMBId = -1,
      int Value = -1,
      int AddLevel = -1,
      int TitleId = -1) {
    builder.StartObject(5);
    FB_ShenWangZhanJiaPaintingPay.AddTitleId(builder, TitleId);
    FB_ShenWangZhanJiaPaintingPay.AddAddLevel(builder, AddLevel);
    FB_ShenWangZhanJiaPaintingPay.AddValue(builder, Value);
    FB_ShenWangZhanJiaPaintingPay.AddRMBId(builder, RMBId);
    FB_ShenWangZhanJiaPaintingPay.AddID(builder, ID);
    return FB_ShenWangZhanJiaPaintingPay.EndFB_ShenWangZhanJiaPaintingPay(builder);
  }

  public static void StartFB_ShenWangZhanJiaPaintingPay(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRMBId(FlatBufferBuilder builder, int RMBId) { builder.AddInt(1, RMBId, -1); }
  public static void AddValue(FlatBufferBuilder builder, int Value) { builder.AddInt(2, Value, -1); }
  public static void AddAddLevel(FlatBufferBuilder builder, int AddLevel) { builder.AddInt(3, AddLevel, -1); }
  public static void AddTitleId(FlatBufferBuilder builder, int TitleId) { builder.AddInt(4, TitleId, -1); }
  public static Offset<FB_ShenWangZhanJiaPaintingPay> EndFB_ShenWangZhanJiaPaintingPay(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPaintingPay>(o);
  }
};

public sealed class FB_ShenWangZhanJiaPaintingPayContainer : Table {
  public static FB_ShenWangZhanJiaPaintingPayContainer GetRootAsFB_ShenWangZhanJiaPaintingPayContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaPaintingPayContainer(_bb, new FB_ShenWangZhanJiaPaintingPayContainer()); }
  public static FB_ShenWangZhanJiaPaintingPayContainer GetRootAsFB_ShenWangZhanJiaPaintingPayContainer(ByteBuffer _bb, FB_ShenWangZhanJiaPaintingPayContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaPaintingPayContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaPaintingPayContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaPaintingPay GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaPaintingPay(), j); }
  public FB_ShenWangZhanJiaPaintingPay GetItems(FB_ShenWangZhanJiaPaintingPay obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaPaintingPayContainer> CreateFB_ShenWangZhanJiaPaintingPayContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaPaintingPayContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaPaintingPayContainer.EndFB_ShenWangZhanJiaPaintingPayContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaPaintingPayContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPaintingPay>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaPaintingPayContainer> EndFB_ShenWangZhanJiaPaintingPayContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaPaintingPayContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaPaintingPayContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaPaintingPayContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
