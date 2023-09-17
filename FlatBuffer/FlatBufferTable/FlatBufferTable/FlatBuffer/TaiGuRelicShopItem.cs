// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TaiGuRelicShopItem : Table {
  public static FB_TaiGuRelicShopItem GetRootAsFB_TaiGuRelicShopItem(ByteBuffer _bb) { return GetRootAsFB_TaiGuRelicShopItem(_bb, new FB_TaiGuRelicShopItem()); }
  public static FB_TaiGuRelicShopItem GetRootAsFB_TaiGuRelicShopItem(ByteBuffer _bb, FB_TaiGuRelicShopItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TaiGuRelicShopItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BinType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevelLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxPayLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int LimitBuyNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ItemName { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ItemValidTime { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CoolingTime { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Weight { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PushNum { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CcurPrice { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RmbTabId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(40); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(40); return o != 0 ? __vector_len(o) : 0; } }
  public int GetParamItemIdList(int j) { int o = __offset(42); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamItemIdListLength { get { int o = __offset(42); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaiGuRelicShopItem> CreateFB_TaiGuRelicShopItem(FlatBufferBuilder builder,
      int ID = 0,
      int BinType = -1,
      int LevelLimit = -1,
      int PayLimit = -1,
      int MaxLevelLimit = -1,
      int MaxPayLimit = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int LimitBuyNum = -1,
      int Quality = -1,
      StringOffset ItemName = default(StringOffset),
      int ItemValidTime = -1,
      int CoolingTime = -1,
      int Weight = -1,
      int PushNum = -1,
      int MoneyType = -1,
      int CcurPrice = -1,
      int RmbTabId = -1,
      VectorOffset ParamList = default(VectorOffset),
      VectorOffset ParamItemIdList = default(VectorOffset)) {
    builder.StartObject(20);
    FB_TaiGuRelicShopItem.AddParamItemIdList(builder, ParamItemIdList);
    FB_TaiGuRelicShopItem.AddParamList(builder, ParamList);
    FB_TaiGuRelicShopItem.AddRmbTabId(builder, RmbTabId);
    FB_TaiGuRelicShopItem.AddCcurPrice(builder, CcurPrice);
    FB_TaiGuRelicShopItem.AddMoneyType(builder, MoneyType);
    FB_TaiGuRelicShopItem.AddPushNum(builder, PushNum);
    FB_TaiGuRelicShopItem.AddWeight(builder, Weight);
    FB_TaiGuRelicShopItem.AddCoolingTime(builder, CoolingTime);
    FB_TaiGuRelicShopItem.AddItemValidTime(builder, ItemValidTime);
    FB_TaiGuRelicShopItem.AddItemName(builder, ItemName);
    FB_TaiGuRelicShopItem.AddQuality(builder, Quality);
    FB_TaiGuRelicShopItem.AddLimitBuyNum(builder, LimitBuyNum);
    FB_TaiGuRelicShopItem.AddItemNumList(builder, ItemNumList);
    FB_TaiGuRelicShopItem.AddItemIDList(builder, ItemIDList);
    FB_TaiGuRelicShopItem.AddMaxPayLimit(builder, MaxPayLimit);
    FB_TaiGuRelicShopItem.AddMaxLevelLimit(builder, MaxLevelLimit);
    FB_TaiGuRelicShopItem.AddPayLimit(builder, PayLimit);
    FB_TaiGuRelicShopItem.AddLevelLimit(builder, LevelLimit);
    FB_TaiGuRelicShopItem.AddBinType(builder, BinType);
    FB_TaiGuRelicShopItem.AddID(builder, ID);
    return FB_TaiGuRelicShopItem.EndFB_TaiGuRelicShopItem(builder);
  }

  public static void StartFB_TaiGuRelicShopItem(FlatBufferBuilder builder) { builder.StartObject(20); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBinType(FlatBufferBuilder builder, int BinType) { builder.AddInt(1, BinType, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(2, LevelLimit, -1); }
  public static void AddPayLimit(FlatBufferBuilder builder, int PayLimit) { builder.AddInt(3, PayLimit, -1); }
  public static void AddMaxLevelLimit(FlatBufferBuilder builder, int MaxLevelLimit) { builder.AddInt(4, MaxLevelLimit, -1); }
  public static void AddMaxPayLimit(FlatBufferBuilder builder, int MaxPayLimit) { builder.AddInt(5, MaxPayLimit, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(6, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(7, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLimitBuyNum(FlatBufferBuilder builder, int LimitBuyNum) { builder.AddInt(8, LimitBuyNum, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(9, Quality, -1); }
  public static void AddItemName(FlatBufferBuilder builder, StringOffset ItemNameOffset) { builder.AddOffset(10, ItemNameOffset.Value, 0); }
  public static void AddItemValidTime(FlatBufferBuilder builder, int ItemValidTime) { builder.AddInt(11, ItemValidTime, -1); }
  public static void AddCoolingTime(FlatBufferBuilder builder, int CoolingTime) { builder.AddInt(12, CoolingTime, -1); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(13, Weight, -1); }
  public static void AddPushNum(FlatBufferBuilder builder, int PushNum) { builder.AddInt(14, PushNum, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(15, MoneyType, -1); }
  public static void AddCcurPrice(FlatBufferBuilder builder, int CcurPrice) { builder.AddInt(16, CcurPrice, -1); }
  public static void AddRmbTabId(FlatBufferBuilder builder, int RmbTabId) { builder.AddInt(17, RmbTabId, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(18, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParamItemIdList(FlatBufferBuilder builder, VectorOffset ParamItemIdListOffset) { builder.AddOffset(19, ParamItemIdListOffset.Value, 0); }
  public static VectorOffset CreateParamItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaiGuRelicShopItem> EndFB_TaiGuRelicShopItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaiGuRelicShopItem>(o);
  }
};

public sealed class FB_TaiGuRelicShopItemContainer : Table {
  public static FB_TaiGuRelicShopItemContainer GetRootAsFB_TaiGuRelicShopItemContainer(ByteBuffer _bb) { return GetRootAsFB_TaiGuRelicShopItemContainer(_bb, new FB_TaiGuRelicShopItemContainer()); }
  public static FB_TaiGuRelicShopItemContainer GetRootAsFB_TaiGuRelicShopItemContainer(ByteBuffer _bb, FB_TaiGuRelicShopItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TaiGuRelicShopItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TaiGuRelicShopItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TaiGuRelicShopItem GetItems(int j) { return GetItems(new FB_TaiGuRelicShopItem(), j); }
  public FB_TaiGuRelicShopItem GetItems(FB_TaiGuRelicShopItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaiGuRelicShopItemContainer> CreateFB_TaiGuRelicShopItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TaiGuRelicShopItemContainer.AddItems(builder, items);
    return FB_TaiGuRelicShopItemContainer.EndFB_TaiGuRelicShopItemContainer(builder);
  }

  public static void StartFB_TaiGuRelicShopItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TaiGuRelicShopItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaiGuRelicShopItemContainer> EndFB_TaiGuRelicShopItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaiGuRelicShopItemContainer>(o);
  }
  public static void FinishFB_TaiGuRelicShopItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_TaiGuRelicShopItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
