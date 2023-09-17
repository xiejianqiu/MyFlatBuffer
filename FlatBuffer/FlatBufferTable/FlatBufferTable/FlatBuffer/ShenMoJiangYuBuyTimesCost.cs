// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenMoJiangYuBuyTimesCost : Table {
  public static FB_ShenMoJiangYuBuyTimesCost GetRootAsFB_ShenMoJiangYuBuyTimesCost(ByteBuffer _bb) { return GetRootAsFB_ShenMoJiangYuBuyTimesCost(_bb, new FB_ShenMoJiangYuBuyTimesCost()); }
  public static FB_ShenMoJiangYuBuyTimesCost GetRootAsFB_ShenMoJiangYuBuyTimesCost(ByteBuffer _bb, FB_ShenMoJiangYuBuyTimesCost obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenMoJiangYuBuyTimesCost __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostMoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostMoneyValue { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShenMoJiangYuBuyTimesCost> CreateFB_ShenMoJiangYuBuyTimesCost(FlatBufferBuilder builder,
      int ID = 0,
      int CostMoneyType = -1,
      int CostMoneyValue = -1) {
    builder.StartObject(3);
    FB_ShenMoJiangYuBuyTimesCost.AddCostMoneyValue(builder, CostMoneyValue);
    FB_ShenMoJiangYuBuyTimesCost.AddCostMoneyType(builder, CostMoneyType);
    FB_ShenMoJiangYuBuyTimesCost.AddID(builder, ID);
    return FB_ShenMoJiangYuBuyTimesCost.EndFB_ShenMoJiangYuBuyTimesCost(builder);
  }

  public static void StartFB_ShenMoJiangYuBuyTimesCost(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCostMoneyType(FlatBufferBuilder builder, int CostMoneyType) { builder.AddInt(1, CostMoneyType, -1); }
  public static void AddCostMoneyValue(FlatBufferBuilder builder, int CostMoneyValue) { builder.AddInt(2, CostMoneyValue, -1); }
  public static Offset<FB_ShenMoJiangYuBuyTimesCost> EndFB_ShenMoJiangYuBuyTimesCost(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenMoJiangYuBuyTimesCost>(o);
  }
};

public sealed class FB_ShenMoJiangYuBuyTimesCostContainer : Table {
  public static FB_ShenMoJiangYuBuyTimesCostContainer GetRootAsFB_ShenMoJiangYuBuyTimesCostContainer(ByteBuffer _bb) { return GetRootAsFB_ShenMoJiangYuBuyTimesCostContainer(_bb, new FB_ShenMoJiangYuBuyTimesCostContainer()); }
  public static FB_ShenMoJiangYuBuyTimesCostContainer GetRootAsFB_ShenMoJiangYuBuyTimesCostContainer(ByteBuffer _bb, FB_ShenMoJiangYuBuyTimesCostContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenMoJiangYuBuyTimesCostContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenMoJiangYuBuyTimesCostContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenMoJiangYuBuyTimesCost GetItems(int j) { return GetItems(new FB_ShenMoJiangYuBuyTimesCost(), j); }
  public FB_ShenMoJiangYuBuyTimesCost GetItems(FB_ShenMoJiangYuBuyTimesCost obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenMoJiangYuBuyTimesCostContainer> CreateFB_ShenMoJiangYuBuyTimesCostContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenMoJiangYuBuyTimesCostContainer.AddItems(builder, items);
    return FB_ShenMoJiangYuBuyTimesCostContainer.EndFB_ShenMoJiangYuBuyTimesCostContainer(builder);
  }

  public static void StartFB_ShenMoJiangYuBuyTimesCostContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenMoJiangYuBuyTimesCost>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenMoJiangYuBuyTimesCostContainer> EndFB_ShenMoJiangYuBuyTimesCostContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenMoJiangYuBuyTimesCostContainer>(o);
  }
  public static void FinishFB_ShenMoJiangYuBuyTimesCostContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenMoJiangYuBuyTimesCostContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
