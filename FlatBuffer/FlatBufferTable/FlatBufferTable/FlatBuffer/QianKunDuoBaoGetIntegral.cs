// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_QianKunDuoBaoGetIntegral : Table {
  public static FB_QianKunDuoBaoGetIntegral GetRootAsFB_QianKunDuoBaoGetIntegral(ByteBuffer _bb) { return GetRootAsFB_QianKunDuoBaoGetIntegral(_bb, new FB_QianKunDuoBaoGetIntegral()); }
  public static FB_QianKunDuoBaoGetIntegral GetRootAsFB_QianKunDuoBaoGetIntegral(ByteBuffer _bb, FB_QianKunDuoBaoGetIntegral obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_QianKunDuoBaoGetIntegral __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DoubleCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string DescStr { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TuiJian { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_QianKunDuoBaoGetIntegral> CreateFB_QianKunDuoBaoGetIntegral(FlatBufferBuilder builder,
      int ID = 0,
      int DoubleCount = -1,
      StringOffset DescStr = default(StringOffset),
      int TuiJian = -1) {
    builder.StartObject(4);
    FB_QianKunDuoBaoGetIntegral.AddTuiJian(builder, TuiJian);
    FB_QianKunDuoBaoGetIntegral.AddDescStr(builder, DescStr);
    FB_QianKunDuoBaoGetIntegral.AddDoubleCount(builder, DoubleCount);
    FB_QianKunDuoBaoGetIntegral.AddID(builder, ID);
    return FB_QianKunDuoBaoGetIntegral.EndFB_QianKunDuoBaoGetIntegral(builder);
  }

  public static void StartFB_QianKunDuoBaoGetIntegral(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDoubleCount(FlatBufferBuilder builder, int DoubleCount) { builder.AddInt(1, DoubleCount, -1); }
  public static void AddDescStr(FlatBufferBuilder builder, StringOffset DescStrOffset) { builder.AddOffset(2, DescStrOffset.Value, 0); }
  public static void AddTuiJian(FlatBufferBuilder builder, int TuiJian) { builder.AddInt(3, TuiJian, -1); }
  public static Offset<FB_QianKunDuoBaoGetIntegral> EndFB_QianKunDuoBaoGetIntegral(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_QianKunDuoBaoGetIntegral>(o);
  }
};

public sealed class FB_QianKunDuoBaoGetIntegralContainer : Table {
  public static FB_QianKunDuoBaoGetIntegralContainer GetRootAsFB_QianKunDuoBaoGetIntegralContainer(ByteBuffer _bb) { return GetRootAsFB_QianKunDuoBaoGetIntegralContainer(_bb, new FB_QianKunDuoBaoGetIntegralContainer()); }
  public static FB_QianKunDuoBaoGetIntegralContainer GetRootAsFB_QianKunDuoBaoGetIntegralContainer(ByteBuffer _bb, FB_QianKunDuoBaoGetIntegralContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_QianKunDuoBaoGetIntegralContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_QianKunDuoBaoGetIntegralContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_QianKunDuoBaoGetIntegral GetItems(int j) { return GetItems(new FB_QianKunDuoBaoGetIntegral(), j); }
  public FB_QianKunDuoBaoGetIntegral GetItems(FB_QianKunDuoBaoGetIntegral obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_QianKunDuoBaoGetIntegralContainer> CreateFB_QianKunDuoBaoGetIntegralContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_QianKunDuoBaoGetIntegralContainer.AddItems(builder, items);
    return FB_QianKunDuoBaoGetIntegralContainer.EndFB_QianKunDuoBaoGetIntegralContainer(builder);
  }

  public static void StartFB_QianKunDuoBaoGetIntegralContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_QianKunDuoBaoGetIntegral>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_QianKunDuoBaoGetIntegralContainer> EndFB_QianKunDuoBaoGetIntegralContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_QianKunDuoBaoGetIntegralContainer>(o);
  }
  public static void FinishFB_QianKunDuoBaoGetIntegralContainerBuffer(FlatBufferBuilder builder, Offset<FB_QianKunDuoBaoGetIntegralContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
