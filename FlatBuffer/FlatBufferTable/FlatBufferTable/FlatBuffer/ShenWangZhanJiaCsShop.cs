// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaCsShop : Table {
  public static FB_ShenWangZhanJiaCsShop GetRootAsFB_ShenWangZhanJiaCsShop(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCsShop(_bb, new FB_ShenWangZhanJiaCsShop()); }
  public static FB_ShenWangZhanJiaCsShop GetRootAsFB_ShenWangZhanJiaCsShop(ByteBuffer _bb, FB_ShenWangZhanJiaCsShop obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaCsShop __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPriceList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PriceListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCcurPriceList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CcurPriceListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMoneyTypeList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MoneyTypeListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaCsShop> CreateFB_ShenWangZhanJiaCsShop(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemList = default(VectorOffset),
      VectorOffset PriceList = default(VectorOffset),
      VectorOffset CcurPriceList = default(VectorOffset),
      VectorOffset MoneyTypeList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ShenWangZhanJiaCsShop.AddMoneyTypeList(builder, MoneyTypeList);
    FB_ShenWangZhanJiaCsShop.AddCcurPriceList(builder, CcurPriceList);
    FB_ShenWangZhanJiaCsShop.AddPriceList(builder, PriceList);
    FB_ShenWangZhanJiaCsShop.AddItemList(builder, ItemList);
    FB_ShenWangZhanJiaCsShop.AddID(builder, ID);
    return FB_ShenWangZhanJiaCsShop.EndFB_ShenWangZhanJiaCsShop(builder);
  }

  public static void StartFB_ShenWangZhanJiaCsShop(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(1, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPriceList(FlatBufferBuilder builder, VectorOffset PriceListOffset) { builder.AddOffset(2, PriceListOffset.Value, 0); }
  public static VectorOffset CreatePriceListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPriceListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCcurPriceList(FlatBufferBuilder builder, VectorOffset CcurPriceListOffset) { builder.AddOffset(3, CcurPriceListOffset.Value, 0); }
  public static VectorOffset CreateCcurPriceListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCcurPriceListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMoneyTypeList(FlatBufferBuilder builder, VectorOffset MoneyTypeListOffset) { builder.AddOffset(4, MoneyTypeListOffset.Value, 0); }
  public static VectorOffset CreateMoneyTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMoneyTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaCsShop> EndFB_ShenWangZhanJiaCsShop(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCsShop>(o);
  }
};

public sealed class FB_ShenWangZhanJiaCsShopContainer : Table {
  public static FB_ShenWangZhanJiaCsShopContainer GetRootAsFB_ShenWangZhanJiaCsShopContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCsShopContainer(_bb, new FB_ShenWangZhanJiaCsShopContainer()); }
  public static FB_ShenWangZhanJiaCsShopContainer GetRootAsFB_ShenWangZhanJiaCsShopContainer(ByteBuffer _bb, FB_ShenWangZhanJiaCsShopContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaCsShopContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaCsShopContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaCsShop GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaCsShop(), j); }
  public FB_ShenWangZhanJiaCsShop GetItems(FB_ShenWangZhanJiaCsShop obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaCsShopContainer> CreateFB_ShenWangZhanJiaCsShopContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaCsShopContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaCsShopContainer.EndFB_ShenWangZhanJiaCsShopContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaCsShopContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCsShop>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaCsShopContainer> EndFB_ShenWangZhanJiaCsShopContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCsShopContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaCsShopContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCsShopContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
