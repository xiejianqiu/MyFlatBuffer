// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RevivePrice : Table {
  public static FB_RevivePrice GetRootAsFB_RevivePrice(ByteBuffer _bb) { return GetRootAsFB_RevivePrice(_bb, new FB_RevivePrice()); }
  public static FB_RevivePrice GetRootAsFB_RevivePrice(ByteBuffer _bb, FB_RevivePrice obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RevivePrice __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AdvanceLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPriceRangeList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PriceRangeListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPriceTypeList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PriceTypeListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPriceList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PriceListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RevivePrice> CreateFB_RevivePrice(FlatBufferBuilder builder,
      int ID = 0,
      int AdvanceLimit = -1,
      VectorOffset PriceRangeList = default(VectorOffset),
      VectorOffset PriceTypeList = default(VectorOffset),
      VectorOffset PriceList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_RevivePrice.AddPriceList(builder, PriceList);
    FB_RevivePrice.AddPriceTypeList(builder, PriceTypeList);
    FB_RevivePrice.AddPriceRangeList(builder, PriceRangeList);
    FB_RevivePrice.AddAdvanceLimit(builder, AdvanceLimit);
    FB_RevivePrice.AddID(builder, ID);
    return FB_RevivePrice.EndFB_RevivePrice(builder);
  }

  public static void StartFB_RevivePrice(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAdvanceLimit(FlatBufferBuilder builder, int AdvanceLimit) { builder.AddInt(1, AdvanceLimit, -1); }
  public static void AddPriceRangeList(FlatBufferBuilder builder, VectorOffset PriceRangeListOffset) { builder.AddOffset(2, PriceRangeListOffset.Value, 0); }
  public static VectorOffset CreatePriceRangeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPriceRangeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPriceTypeList(FlatBufferBuilder builder, VectorOffset PriceTypeListOffset) { builder.AddOffset(3, PriceTypeListOffset.Value, 0); }
  public static VectorOffset CreatePriceTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPriceTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPriceList(FlatBufferBuilder builder, VectorOffset PriceListOffset) { builder.AddOffset(4, PriceListOffset.Value, 0); }
  public static VectorOffset CreatePriceListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPriceListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RevivePrice> EndFB_RevivePrice(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RevivePrice>(o);
  }
};

public sealed class FB_RevivePriceContainer : Table {
  public static FB_RevivePriceContainer GetRootAsFB_RevivePriceContainer(ByteBuffer _bb) { return GetRootAsFB_RevivePriceContainer(_bb, new FB_RevivePriceContainer()); }
  public static FB_RevivePriceContainer GetRootAsFB_RevivePriceContainer(ByteBuffer _bb, FB_RevivePriceContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RevivePriceContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RevivePriceContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RevivePrice GetItems(int j) { return GetItems(new FB_RevivePrice(), j); }
  public FB_RevivePrice GetItems(FB_RevivePrice obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RevivePriceContainer> CreateFB_RevivePriceContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RevivePriceContainer.AddItems(builder, items);
    return FB_RevivePriceContainer.EndFB_RevivePriceContainer(builder);
  }

  public static void StartFB_RevivePriceContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RevivePrice>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RevivePriceContainer> EndFB_RevivePriceContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RevivePriceContainer>(o);
  }
  public static void FinishFB_RevivePriceContainerBuffer(FlatBufferBuilder builder, Offset<FB_RevivePriceContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
