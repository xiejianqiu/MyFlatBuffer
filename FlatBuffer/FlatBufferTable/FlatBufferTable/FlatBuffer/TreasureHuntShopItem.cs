// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TreasureHuntShopItem : Table {
  public static FB_TreasureHuntShopItem GetRootAsFB_TreasureHuntShopItem(ByteBuffer _bb) { return GetRootAsFB_TreasureHuntShopItem(_bb, new FB_TreasureHuntShopItem()); }
  public static FB_TreasureHuntShopItem GetRootAsFB_TreasureHuntShopItem(ByteBuffer _bb, FB_TreasureHuntShopItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TreasureHuntShopItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GiftName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LimitItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Price { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CcurPrice { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Discount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMin { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMax { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TreasureHuntShopItem> CreateFB_TreasureHuntShopItem(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset GiftName = default(StringOffset),
      int LimitItemNum = -1,
      int MoneyType = -1,
      int Price = -1,
      int CcurPrice = -1,
      int Discount = -1,
      int ItemId = -1,
      int ItemNum = -1,
      int WorldLvMin = -1,
      int WorldLvMax = -1) {
    builder.StartObject(11);
    FB_TreasureHuntShopItem.AddWorldLvMax(builder, WorldLvMax);
    FB_TreasureHuntShopItem.AddWorldLvMin(builder, WorldLvMin);
    FB_TreasureHuntShopItem.AddItemNum(builder, ItemNum);
    FB_TreasureHuntShopItem.AddItemId(builder, ItemId);
    FB_TreasureHuntShopItem.AddDiscount(builder, Discount);
    FB_TreasureHuntShopItem.AddCcurPrice(builder, CcurPrice);
    FB_TreasureHuntShopItem.AddPrice(builder, Price);
    FB_TreasureHuntShopItem.AddMoneyType(builder, MoneyType);
    FB_TreasureHuntShopItem.AddLimitItemNum(builder, LimitItemNum);
    FB_TreasureHuntShopItem.AddGiftName(builder, GiftName);
    FB_TreasureHuntShopItem.AddID(builder, ID);
    return FB_TreasureHuntShopItem.EndFB_TreasureHuntShopItem(builder);
  }

  public static void StartFB_TreasureHuntShopItem(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGiftName(FlatBufferBuilder builder, StringOffset GiftNameOffset) { builder.AddOffset(1, GiftNameOffset.Value, 0); }
  public static void AddLimitItemNum(FlatBufferBuilder builder, int LimitItemNum) { builder.AddInt(2, LimitItemNum, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(3, MoneyType, -1); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(4, Price, -1); }
  public static void AddCcurPrice(FlatBufferBuilder builder, int CcurPrice) { builder.AddInt(5, CcurPrice, -1); }
  public static void AddDiscount(FlatBufferBuilder builder, int Discount) { builder.AddInt(6, Discount, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(7, ItemId, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(8, ItemNum, -1); }
  public static void AddWorldLvMin(FlatBufferBuilder builder, int WorldLvMin) { builder.AddInt(9, WorldLvMin, -1); }
  public static void AddWorldLvMax(FlatBufferBuilder builder, int WorldLvMax) { builder.AddInt(10, WorldLvMax, -1); }
  public static Offset<FB_TreasureHuntShopItem> EndFB_TreasureHuntShopItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TreasureHuntShopItem>(o);
  }
};

public sealed class FB_TreasureHuntShopItemContainer : Table {
  public static FB_TreasureHuntShopItemContainer GetRootAsFB_TreasureHuntShopItemContainer(ByteBuffer _bb) { return GetRootAsFB_TreasureHuntShopItemContainer(_bb, new FB_TreasureHuntShopItemContainer()); }
  public static FB_TreasureHuntShopItemContainer GetRootAsFB_TreasureHuntShopItemContainer(ByteBuffer _bb, FB_TreasureHuntShopItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TreasureHuntShopItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TreasureHuntShopItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TreasureHuntShopItem GetItems(int j) { return GetItems(new FB_TreasureHuntShopItem(), j); }
  public FB_TreasureHuntShopItem GetItems(FB_TreasureHuntShopItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TreasureHuntShopItemContainer> CreateFB_TreasureHuntShopItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TreasureHuntShopItemContainer.AddItems(builder, items);
    return FB_TreasureHuntShopItemContainer.EndFB_TreasureHuntShopItemContainer(builder);
  }

  public static void StartFB_TreasureHuntShopItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TreasureHuntShopItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TreasureHuntShopItemContainer> EndFB_TreasureHuntShopItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TreasureHuntShopItemContainer>(o);
  }
  public static void FinishFB_TreasureHuntShopItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_TreasureHuntShopItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
