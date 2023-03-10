// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingDecompose : Table {
  public static FB_JiLingDecompose GetRootAsFB_JiLingDecompose(ByteBuffer _bb) { return GetRootAsFB_JiLingDecompose(_bb, new FB_JiLingDecompose()); }
  public static FB_JiLingDecompose GetRootAsFB_JiLingDecompose(ByteBuffer _bb, FB_JiLingDecompose obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingDecompose __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DecomposeType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_JiLingDecompose> CreateFB_JiLingDecompose(FlatBufferBuilder builder,
      int Id = 0,
      int DecomposeType = -1,
      int MoneyType = -1,
      int MoneyNum = -1) {
    builder.StartObject(4);
    FB_JiLingDecompose.AddMoneyNum(builder, MoneyNum);
    FB_JiLingDecompose.AddMoneyType(builder, MoneyType);
    FB_JiLingDecompose.AddDecomposeType(builder, DecomposeType);
    FB_JiLingDecompose.AddId(builder, Id);
    return FB_JiLingDecompose.EndFB_JiLingDecompose(builder);
  }

  public static void StartFB_JiLingDecompose(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddDecomposeType(FlatBufferBuilder builder, int DecomposeType) { builder.AddInt(1, DecomposeType, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(2, MoneyType, -1); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(3, MoneyNum, -1); }
  public static Offset<FB_JiLingDecompose> EndFB_JiLingDecompose(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingDecompose>(o);
  }
};

public sealed class FB_JiLingDecomposeContainer : Table {
  public static FB_JiLingDecomposeContainer GetRootAsFB_JiLingDecomposeContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingDecomposeContainer(_bb, new FB_JiLingDecomposeContainer()); }
  public static FB_JiLingDecomposeContainer GetRootAsFB_JiLingDecomposeContainer(ByteBuffer _bb, FB_JiLingDecomposeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingDecomposeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingDecomposeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingDecompose GetItems(int j) { return GetItems(new FB_JiLingDecompose(), j); }
  public FB_JiLingDecompose GetItems(FB_JiLingDecompose obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingDecomposeContainer> CreateFB_JiLingDecomposeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingDecomposeContainer.AddItems(builder, items);
    return FB_JiLingDecomposeContainer.EndFB_JiLingDecomposeContainer(builder);
  }

  public static void StartFB_JiLingDecomposeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingDecompose>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingDecomposeContainer> EndFB_JiLingDecomposeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingDecomposeContainer>(o);
  }
  public static void FinishFB_JiLingDecomposeContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingDecomposeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
