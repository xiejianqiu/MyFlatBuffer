// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShopItem : Table {
  public static FB_ShopItem GetRootAsFB_ShopItem(ByteBuffer _bb) { return GetRootAsFB_ShopItem(_bb, new FB_ShopItem()); }
  public static FB_ShopItem GetRootAsFB_ShopItem(ByteBuffer _bb, FB_ShopItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShopItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ItemDesc { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GoldType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayGold { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitValue { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VipLvlVisible { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Discount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)10; } }
  public int OnSaleTime { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OffSaleTime { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Weight { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TradeCDType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MiniLvl { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLvl { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinJingJie { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MiniLvlShiLi { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VipLvlBuyable { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BuyLimitOnce { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)99; } }
  public int RefType { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShopItem> CreateFB_ShopItem(FlatBufferBuilder builder,
      int ID = 0,
      int ItemID = -1,
      StringOffset ItemDesc = default(StringOffset),
      int GoldType = -1,
      int PayGold = -1,
      int LimitValue = -1,
      int VipLvlVisible = -1,
      int Discount = 10,
      int OnSaleTime = -1,
      int OffSaleTime = -1,
      int Weight = 0,
      int TradeCDType = -1,
      int MiniLvl = -1,
      int MaxLvl = -1,
      int MinJingJie = -1,
      int MiniLvlShiLi = -1,
      int VipLvlBuyable = -1,
      int BuyLimitOnce = 99,
      int RefType = -1) {
    builder.StartObject(19);
    FB_ShopItem.AddRefType(builder, RefType);
    FB_ShopItem.AddBuyLimitOnce(builder, BuyLimitOnce);
    FB_ShopItem.AddVipLvlBuyable(builder, VipLvlBuyable);
    FB_ShopItem.AddMiniLvlShiLi(builder, MiniLvlShiLi);
    FB_ShopItem.AddMinJingJie(builder, MinJingJie);
    FB_ShopItem.AddMaxLvl(builder, MaxLvl);
    FB_ShopItem.AddMiniLvl(builder, MiniLvl);
    FB_ShopItem.AddTradeCDType(builder, TradeCDType);
    FB_ShopItem.AddWeight(builder, Weight);
    FB_ShopItem.AddOffSaleTime(builder, OffSaleTime);
    FB_ShopItem.AddOnSaleTime(builder, OnSaleTime);
    FB_ShopItem.AddDiscount(builder, Discount);
    FB_ShopItem.AddVipLvlVisible(builder, VipLvlVisible);
    FB_ShopItem.AddLimitValue(builder, LimitValue);
    FB_ShopItem.AddPayGold(builder, PayGold);
    FB_ShopItem.AddGoldType(builder, GoldType);
    FB_ShopItem.AddItemDesc(builder, ItemDesc);
    FB_ShopItem.AddItemID(builder, ItemID);
    FB_ShopItem.AddID(builder, ID);
    return FB_ShopItem.EndFB_ShopItem(builder);
  }

  public static void StartFB_ShopItem(FlatBufferBuilder builder) { builder.StartObject(19); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(1, ItemID, -1); }
  public static void AddItemDesc(FlatBufferBuilder builder, StringOffset ItemDescOffset) { builder.AddOffset(2, ItemDescOffset.Value, 0); }
  public static void AddGoldType(FlatBufferBuilder builder, int GoldType) { builder.AddInt(3, GoldType, -1); }
  public static void AddPayGold(FlatBufferBuilder builder, int PayGold) { builder.AddInt(4, PayGold, -1); }
  public static void AddLimitValue(FlatBufferBuilder builder, int LimitValue) { builder.AddInt(5, LimitValue, -1); }
  public static void AddVipLvlVisible(FlatBufferBuilder builder, int VipLvlVisible) { builder.AddInt(6, VipLvlVisible, -1); }
  public static void AddDiscount(FlatBufferBuilder builder, int Discount) { builder.AddInt(7, Discount, 10); }
  public static void AddOnSaleTime(FlatBufferBuilder builder, int OnSaleTime) { builder.AddInt(8, OnSaleTime, -1); }
  public static void AddOffSaleTime(FlatBufferBuilder builder, int OffSaleTime) { builder.AddInt(9, OffSaleTime, -1); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(10, Weight, 0); }
  public static void AddTradeCDType(FlatBufferBuilder builder, int TradeCDType) { builder.AddInt(11, TradeCDType, -1); }
  public static void AddMiniLvl(FlatBufferBuilder builder, int MiniLvl) { builder.AddInt(12, MiniLvl, -1); }
  public static void AddMaxLvl(FlatBufferBuilder builder, int MaxLvl) { builder.AddInt(13, MaxLvl, -1); }
  public static void AddMinJingJie(FlatBufferBuilder builder, int MinJingJie) { builder.AddInt(14, MinJingJie, -1); }
  public static void AddMiniLvlShiLi(FlatBufferBuilder builder, int MiniLvlShiLi) { builder.AddInt(15, MiniLvlShiLi, -1); }
  public static void AddVipLvlBuyable(FlatBufferBuilder builder, int VipLvlBuyable) { builder.AddInt(16, VipLvlBuyable, -1); }
  public static void AddBuyLimitOnce(FlatBufferBuilder builder, int BuyLimitOnce) { builder.AddInt(17, BuyLimitOnce, 99); }
  public static void AddRefType(FlatBufferBuilder builder, int RefType) { builder.AddInt(18, RefType, -1); }
  public static Offset<FB_ShopItem> EndFB_ShopItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShopItem>(o);
  }
};

public sealed class FB_ShopItemContainer : Table {
  public static FB_ShopItemContainer GetRootAsFB_ShopItemContainer(ByteBuffer _bb) { return GetRootAsFB_ShopItemContainer(_bb, new FB_ShopItemContainer()); }
  public static FB_ShopItemContainer GetRootAsFB_ShopItemContainer(ByteBuffer _bb, FB_ShopItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShopItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShopItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShopItem GetItems(int j) { return GetItems(new FB_ShopItem(), j); }
  public FB_ShopItem GetItems(FB_ShopItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShopItemContainer> CreateFB_ShopItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShopItemContainer.AddItems(builder, items);
    return FB_ShopItemContainer.EndFB_ShopItemContainer(builder);
  }

  public static void StartFB_ShopItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShopItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShopItemContainer> EndFB_ShopItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShopItemContainer>(o);
  }
  public static void FinishFB_ShopItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShopItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
