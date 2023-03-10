// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryShopItem : Table {
  public static FB_MarryShopItem GetRootAsFB_MarryShopItem(ByteBuffer _bb) { return GetRootAsFB_MarryShopItem(_bb, new FB_MarryShopItem()); }
  public static FB_MarryShopItem GetRootAsFB_MarryShopItem(ByteBuffer _bb, FB_MarryShopItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryShopItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GiftName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LimitItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Price { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CcurPrice { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Discount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BonusId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MarryShopItem> CreateFB_MarryShopItem(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset GiftName = default(StringOffset),
      int LimitItemNum = -1,
      int MoneyType = -1,
      int Price = -1,
      int CcurPrice = -1,
      int Discount = -1,
      int BonusId = -1,
      int ActivityType = -1) {
    builder.StartObject(9);
    FB_MarryShopItem.AddActivityType(builder, ActivityType);
    FB_MarryShopItem.AddBonusId(builder, BonusId);
    FB_MarryShopItem.AddDiscount(builder, Discount);
    FB_MarryShopItem.AddCcurPrice(builder, CcurPrice);
    FB_MarryShopItem.AddPrice(builder, Price);
    FB_MarryShopItem.AddMoneyType(builder, MoneyType);
    FB_MarryShopItem.AddLimitItemNum(builder, LimitItemNum);
    FB_MarryShopItem.AddGiftName(builder, GiftName);
    FB_MarryShopItem.AddID(builder, ID);
    return FB_MarryShopItem.EndFB_MarryShopItem(builder);
  }

  public static void StartFB_MarryShopItem(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGiftName(FlatBufferBuilder builder, StringOffset GiftNameOffset) { builder.AddOffset(1, GiftNameOffset.Value, 0); }
  public static void AddLimitItemNum(FlatBufferBuilder builder, int LimitItemNum) { builder.AddInt(2, LimitItemNum, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(3, MoneyType, -1); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(4, Price, -1); }
  public static void AddCcurPrice(FlatBufferBuilder builder, int CcurPrice) { builder.AddInt(5, CcurPrice, -1); }
  public static void AddDiscount(FlatBufferBuilder builder, int Discount) { builder.AddInt(6, Discount, -1); }
  public static void AddBonusId(FlatBufferBuilder builder, int BonusId) { builder.AddInt(7, BonusId, -1); }
  public static void AddActivityType(FlatBufferBuilder builder, int ActivityType) { builder.AddInt(8, ActivityType, -1); }
  public static Offset<FB_MarryShopItem> EndFB_MarryShopItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryShopItem>(o);
  }
};

public sealed class FB_MarryShopItemContainer : Table {
  public static FB_MarryShopItemContainer GetRootAsFB_MarryShopItemContainer(ByteBuffer _bb) { return GetRootAsFB_MarryShopItemContainer(_bb, new FB_MarryShopItemContainer()); }
  public static FB_MarryShopItemContainer GetRootAsFB_MarryShopItemContainer(ByteBuffer _bb, FB_MarryShopItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryShopItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryShopItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryShopItem GetItems(int j) { return GetItems(new FB_MarryShopItem(), j); }
  public FB_MarryShopItem GetItems(FB_MarryShopItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryShopItemContainer> CreateFB_MarryShopItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryShopItemContainer.AddItems(builder, items);
    return FB_MarryShopItemContainer.EndFB_MarryShopItemContainer(builder);
  }

  public static void StartFB_MarryShopItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryShopItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryShopItemContainer> EndFB_MarryShopItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryShopItemContainer>(o);
  }
  public static void FinishFB_MarryShopItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryShopItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
