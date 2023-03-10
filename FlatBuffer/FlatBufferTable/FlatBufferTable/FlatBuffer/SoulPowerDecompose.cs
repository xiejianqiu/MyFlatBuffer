// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SoulPowerDecompose : Table {
  public static FB_SoulPowerDecompose GetRootAsFB_SoulPowerDecompose(ByteBuffer _bb) { return GetRootAsFB_SoulPowerDecompose(_bb, new FB_SoulPowerDecompose()); }
  public static FB_SoulPowerDecompose GetRootAsFB_SoulPowerDecompose(ByteBuffer _bb, FB_SoulPowerDecompose obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SoulPowerDecompose __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SoulPowerDecompose> CreateFB_SoulPowerDecompose(FlatBufferBuilder builder,
      int Id = 0,
      int MoneyType = -1,
      int MoneyCost = -1) {
    builder.StartObject(3);
    FB_SoulPowerDecompose.AddMoneyCost(builder, MoneyCost);
    FB_SoulPowerDecompose.AddMoneyType(builder, MoneyType);
    FB_SoulPowerDecompose.AddId(builder, Id);
    return FB_SoulPowerDecompose.EndFB_SoulPowerDecompose(builder);
  }

  public static void StartFB_SoulPowerDecompose(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(2, MoneyCost, -1); }
  public static Offset<FB_SoulPowerDecompose> EndFB_SoulPowerDecompose(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerDecompose>(o);
  }
};

public sealed class FB_SoulPowerDecomposeContainer : Table {
  public static FB_SoulPowerDecomposeContainer GetRootAsFB_SoulPowerDecomposeContainer(ByteBuffer _bb) { return GetRootAsFB_SoulPowerDecomposeContainer(_bb, new FB_SoulPowerDecomposeContainer()); }
  public static FB_SoulPowerDecomposeContainer GetRootAsFB_SoulPowerDecomposeContainer(ByteBuffer _bb, FB_SoulPowerDecomposeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SoulPowerDecomposeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SoulPowerDecomposeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SoulPowerDecompose GetItems(int j) { return GetItems(new FB_SoulPowerDecompose(), j); }
  public FB_SoulPowerDecompose GetItems(FB_SoulPowerDecompose obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SoulPowerDecomposeContainer> CreateFB_SoulPowerDecomposeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SoulPowerDecomposeContainer.AddItems(builder, items);
    return FB_SoulPowerDecomposeContainer.EndFB_SoulPowerDecomposeContainer(builder);
  }

  public static void StartFB_SoulPowerDecomposeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SoulPowerDecompose>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SoulPowerDecomposeContainer> EndFB_SoulPowerDecomposeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoulPowerDecomposeContainer>(o);
  }
  public static void FinishFB_SoulPowerDecomposeContainerBuffer(FlatBufferBuilder builder, Offset<FB_SoulPowerDecomposeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
