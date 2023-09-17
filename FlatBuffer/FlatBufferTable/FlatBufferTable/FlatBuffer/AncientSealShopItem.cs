// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AncientSealShopItem : Table {
  public static FB_AncientSealShopItem GetRootAsFB_AncientSealShopItem(ByteBuffer _bb) { return GetRootAsFB_AncientSealShopItem(_bb, new FB_AncientSealShopItem()); }
  public static FB_AncientSealShopItem GetRootAsFB_AncientSealShopItem(ByteBuffer _bb, FB_AncientSealShopItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AncientSealShopItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GiftName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LimitItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Price { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CcurPrice { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Discount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_AncientSealShopItem> CreateFB_AncientSealShopItem(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset GiftName = default(StringOffset),
      int LimitItemNum = -1,
      int MoneyType = -1,
      int Price = -1,
      int CcurPrice = -1,
      int Discount = -1,
      int ItemId = -1,
      int ItemNum = -1) {
    builder.StartObject(9);
    FB_AncientSealShopItem.AddItemNum(builder, ItemNum);
    FB_AncientSealShopItem.AddItemId(builder, ItemId);
    FB_AncientSealShopItem.AddDiscount(builder, Discount);
    FB_AncientSealShopItem.AddCcurPrice(builder, CcurPrice);
    FB_AncientSealShopItem.AddPrice(builder, Price);
    FB_AncientSealShopItem.AddMoneyType(builder, MoneyType);
    FB_AncientSealShopItem.AddLimitItemNum(builder, LimitItemNum);
    FB_AncientSealShopItem.AddGiftName(builder, GiftName);
    FB_AncientSealShopItem.AddID(builder, ID);
    return FB_AncientSealShopItem.EndFB_AncientSealShopItem(builder);
  }

  public static void StartFB_AncientSealShopItem(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGiftName(FlatBufferBuilder builder, StringOffset GiftNameOffset) { builder.AddOffset(1, GiftNameOffset.Value, 0); }
  public static void AddLimitItemNum(FlatBufferBuilder builder, int LimitItemNum) { builder.AddInt(2, LimitItemNum, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(3, MoneyType, -1); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(4, Price, -1); }
  public static void AddCcurPrice(FlatBufferBuilder builder, int CcurPrice) { builder.AddInt(5, CcurPrice, -1); }
  public static void AddDiscount(FlatBufferBuilder builder, int Discount) { builder.AddInt(6, Discount, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(7, ItemId, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(8, ItemNum, -1); }
  public static Offset<FB_AncientSealShopItem> EndFB_AncientSealShopItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AncientSealShopItem>(o);
  }
};

public sealed class FB_AncientSealShopItemContainer : Table {
  public static FB_AncientSealShopItemContainer GetRootAsFB_AncientSealShopItemContainer(ByteBuffer _bb) { return GetRootAsFB_AncientSealShopItemContainer(_bb, new FB_AncientSealShopItemContainer()); }
  public static FB_AncientSealShopItemContainer GetRootAsFB_AncientSealShopItemContainer(ByteBuffer _bb, FB_AncientSealShopItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AncientSealShopItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AncientSealShopItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AncientSealShopItem GetItems(int j) { return GetItems(new FB_AncientSealShopItem(), j); }
  public FB_AncientSealShopItem GetItems(FB_AncientSealShopItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AncientSealShopItemContainer> CreateFB_AncientSealShopItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AncientSealShopItemContainer.AddItems(builder, items);
    return FB_AncientSealShopItemContainer.EndFB_AncientSealShopItemContainer(builder);
  }

  public static void StartFB_AncientSealShopItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AncientSealShopItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AncientSealShopItemContainer> EndFB_AncientSealShopItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AncientSealShopItemContainer>(o);
  }
  public static void FinishFB_AncientSealShopItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_AncientSealShopItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
