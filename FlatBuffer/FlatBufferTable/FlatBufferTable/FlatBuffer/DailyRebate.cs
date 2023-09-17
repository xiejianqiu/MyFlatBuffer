// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DailyRebate : Table {
  public static FB_DailyRebate GetRootAsFB_DailyRebate(ByteBuffer _bb) { return GetRootAsFB_DailyRebate(_bb, new FB_DailyRebate()); }
  public static FB_DailyRebate GetRootAsFB_DailyRebate(ByteBuffer _bb, FB_DailyRebate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DailyRebate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PriceMin { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PriceMax { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRateList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RateListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMoneyTypeList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MoneyTypeListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DailyRebate> CreateFB_DailyRebate(FlatBufferBuilder builder,
      int ID = 0,
      int PriceMin = 0,
      int PriceMax = -1,
      VectorOffset RateList = default(VectorOffset),
      VectorOffset MoneyTypeList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_DailyRebate.AddMoneyTypeList(builder, MoneyTypeList);
    FB_DailyRebate.AddRateList(builder, RateList);
    FB_DailyRebate.AddPriceMax(builder, PriceMax);
    FB_DailyRebate.AddPriceMin(builder, PriceMin);
    FB_DailyRebate.AddID(builder, ID);
    return FB_DailyRebate.EndFB_DailyRebate(builder);
  }

  public static void StartFB_DailyRebate(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPriceMin(FlatBufferBuilder builder, int PriceMin) { builder.AddInt(1, PriceMin, 0); }
  public static void AddPriceMax(FlatBufferBuilder builder, int PriceMax) { builder.AddInt(2, PriceMax, -1); }
  public static void AddRateList(FlatBufferBuilder builder, VectorOffset RateListOffset) { builder.AddOffset(3, RateListOffset.Value, 0); }
  public static VectorOffset CreateRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMoneyTypeList(FlatBufferBuilder builder, VectorOffset MoneyTypeListOffset) { builder.AddOffset(4, MoneyTypeListOffset.Value, 0); }
  public static VectorOffset CreateMoneyTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMoneyTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DailyRebate> EndFB_DailyRebate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DailyRebate>(o);
  }
};

public sealed class FB_DailyRebateContainer : Table {
  public static FB_DailyRebateContainer GetRootAsFB_DailyRebateContainer(ByteBuffer _bb) { return GetRootAsFB_DailyRebateContainer(_bb, new FB_DailyRebateContainer()); }
  public static FB_DailyRebateContainer GetRootAsFB_DailyRebateContainer(ByteBuffer _bb, FB_DailyRebateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DailyRebateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DailyRebateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DailyRebate GetItems(int j) { return GetItems(new FB_DailyRebate(), j); }
  public FB_DailyRebate GetItems(FB_DailyRebate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DailyRebateContainer> CreateFB_DailyRebateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DailyRebateContainer.AddItems(builder, items);
    return FB_DailyRebateContainer.EndFB_DailyRebateContainer(builder);
  }

  public static void StartFB_DailyRebateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DailyRebate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DailyRebateContainer> EndFB_DailyRebateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DailyRebateContainer>(o);
  }
  public static void FinishFB_DailyRebateContainerBuffer(FlatBufferBuilder builder, Offset<FB_DailyRebateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
