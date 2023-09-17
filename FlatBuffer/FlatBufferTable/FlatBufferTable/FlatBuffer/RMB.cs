// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RMB : Table {
  public static FB_RMB GetRootAsFB_RMB(ByteBuffer _bb) { return GetRootAsFB_RMB(_bb, new FB_RMB()); }
  public static FB_RMB GetRootAsFB_RMB(ByteBuffer _bb, FB_RMB obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RMB __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ProductDesc { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string IconUrl { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int PriceSDK { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Price { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float PriceUS { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int CostTianYu { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string PlatformProductId { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public string AOSProductId { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string AOS9SProductId { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public string WEBProductId { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ShopId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshType { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitValue { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LastGiftId { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MDId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Mark { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MailId { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long OnSaleTime { get { int o = __offset(44); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public long OffSaleTime { get { int o = __offset(46); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int ShowVipLimit { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowLevelLimit { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BuyVipLimit { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BuyLevelLimit { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowVipLimitMax { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowLevelLimitMax { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OldMoney { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RealValue { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int YuanBao { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TianYu { get { int o = __offset(66); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMoneyTypeList(int j) { int o = __offset(68); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MoneyTypeListLength { get { int o = __offset(68); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBindYuanBaoList(int j) { int o = __offset(70); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BindYuanBaoListLength { get { int o = __offset(70); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMenPaiItemIdList(int j) { int o = __offset(72); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiItemIdListLength { get { int o = __offset(72); return o != 0 ? __vector_len(o) : 0; } }
  public int MenPaiItemCount { get { int o = __offset(74); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(76); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(76); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(78); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(78); return o != 0 ? __vector_len(o) : 0; } }
  public int ItemYuanBaoId { get { int o = __offset(80); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemYuanBaoCount { get { int o = __offset(82); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenServiceDayAct { get { int o = __offset(84); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndServiceDayAct { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TaiGuYiBaoId { get { int o = __offset(88); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_RMB> CreateFB_RMB(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ProductDesc = default(StringOffset),
      StringOffset IconUrl = default(StringOffset),
      StringOffset Name = default(StringOffset),
      int PriceSDK = -1,
      int Price = -1,
      float PriceUS = 0,
      int CostTianYu = -1,
      StringOffset PlatformProductId = default(StringOffset),
      StringOffset AOSProductId = default(StringOffset),
      StringOffset AOS9SProductId = default(StringOffset),
      StringOffset WEBProductId = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int ShopId = -1,
      int RefreshType = -1,
      int LimitValue = -1,
      int LastGiftId = -1,
      int MDId = -1,
      int Mark = -1,
      int MailId = -1,
      long OnSaleTime = -1,
      long OffSaleTime = -1,
      int ShowVipLimit = -1,
      int ShowLevelLimit = -1,
      int BuyVipLimit = -1,
      int BuyLevelLimit = -1,
      int ShowVipLimitMax = -1,
      int ShowLevelLimitMax = -1,
      int OldMoney = -1,
      int RealValue = -1,
      int YuanBao = -1,
      int TianYu = -1,
      VectorOffset MoneyTypeList = default(VectorOffset),
      VectorOffset BindYuanBaoList = default(VectorOffset),
      VectorOffset MenPaiItemIdList = default(VectorOffset),
      int MenPaiItemCount = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      int ItemYuanBaoId = -1,
      int ItemYuanBaoCount = -1,
      int OpenServiceDayAct = -1,
      int EndServiceDayAct = -1,
      int TaiGuYiBaoId = -1) {
    builder.StartObject(43);
    FB_RMB.AddOffSaleTime(builder, OffSaleTime);
    FB_RMB.AddOnSaleTime(builder, OnSaleTime);
    FB_RMB.AddTaiGuYiBaoId(builder, TaiGuYiBaoId);
    FB_RMB.AddEndServiceDayAct(builder, EndServiceDayAct);
    FB_RMB.AddOpenServiceDayAct(builder, OpenServiceDayAct);
    FB_RMB.AddItemYuanBaoCount(builder, ItemYuanBaoCount);
    FB_RMB.AddItemYuanBaoId(builder, ItemYuanBaoId);
    FB_RMB.AddItemCountList(builder, ItemCountList);
    FB_RMB.AddItemIdList(builder, ItemIdList);
    FB_RMB.AddMenPaiItemCount(builder, MenPaiItemCount);
    FB_RMB.AddMenPaiItemIdList(builder, MenPaiItemIdList);
    FB_RMB.AddBindYuanBaoList(builder, BindYuanBaoList);
    FB_RMB.AddMoneyTypeList(builder, MoneyTypeList);
    FB_RMB.AddTianYu(builder, TianYu);
    FB_RMB.AddYuanBao(builder, YuanBao);
    FB_RMB.AddRealValue(builder, RealValue);
    FB_RMB.AddOldMoney(builder, OldMoney);
    FB_RMB.AddShowLevelLimitMax(builder, ShowLevelLimitMax);
    FB_RMB.AddShowVipLimitMax(builder, ShowVipLimitMax);
    FB_RMB.AddBuyLevelLimit(builder, BuyLevelLimit);
    FB_RMB.AddBuyVipLimit(builder, BuyVipLimit);
    FB_RMB.AddShowLevelLimit(builder, ShowLevelLimit);
    FB_RMB.AddShowVipLimit(builder, ShowVipLimit);
    FB_RMB.AddMailId(builder, MailId);
    FB_RMB.AddMark(builder, Mark);
    FB_RMB.AddMDId(builder, MDId);
    FB_RMB.AddLastGiftId(builder, LastGiftId);
    FB_RMB.AddLimitValue(builder, LimitValue);
    FB_RMB.AddRefreshType(builder, RefreshType);
    FB_RMB.AddShopId(builder, ShopId);
    FB_RMB.AddIcon(builder, Icon);
    FB_RMB.AddWEBProductId(builder, WEBProductId);
    FB_RMB.AddAOS9SProductId(builder, AOS9SProductId);
    FB_RMB.AddAOSProductId(builder, AOSProductId);
    FB_RMB.AddPlatformProductId(builder, PlatformProductId);
    FB_RMB.AddCostTianYu(builder, CostTianYu);
    FB_RMB.AddPriceUS(builder, PriceUS);
    FB_RMB.AddPrice(builder, Price);
    FB_RMB.AddPriceSDK(builder, PriceSDK);
    FB_RMB.AddName(builder, Name);
    FB_RMB.AddIconUrl(builder, IconUrl);
    FB_RMB.AddProductDesc(builder, ProductDesc);
    FB_RMB.AddID(builder, ID);
    return FB_RMB.EndFB_RMB(builder);
  }

  public static void StartFB_RMB(FlatBufferBuilder builder) { builder.StartObject(43); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddProductDesc(FlatBufferBuilder builder, StringOffset ProductDescOffset) { builder.AddOffset(1, ProductDescOffset.Value, 0); }
  public static void AddIconUrl(FlatBufferBuilder builder, StringOffset IconUrlOffset) { builder.AddOffset(2, IconUrlOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(3, NameOffset.Value, 0); }
  public static void AddPriceSDK(FlatBufferBuilder builder, int PriceSDK) { builder.AddInt(4, PriceSDK, -1); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(5, Price, -1); }
  public static void AddPriceUS(FlatBufferBuilder builder, float PriceUS) { builder.AddFloat(6, PriceUS, 0); }
  public static void AddCostTianYu(FlatBufferBuilder builder, int CostTianYu) { builder.AddInt(7, CostTianYu, -1); }
  public static void AddPlatformProductId(FlatBufferBuilder builder, StringOffset PlatformProductIdOffset) { builder.AddOffset(8, PlatformProductIdOffset.Value, 0); }
  public static void AddAOSProductId(FlatBufferBuilder builder, StringOffset AOSProductIdOffset) { builder.AddOffset(9, AOSProductIdOffset.Value, 0); }
  public static void AddAOS9SProductId(FlatBufferBuilder builder, StringOffset AOS9SProductIdOffset) { builder.AddOffset(10, AOS9SProductIdOffset.Value, 0); }
  public static void AddWEBProductId(FlatBufferBuilder builder, StringOffset WEBProductIdOffset) { builder.AddOffset(11, WEBProductIdOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(12, IconOffset.Value, 0); }
  public static void AddShopId(FlatBufferBuilder builder, int ShopId) { builder.AddInt(13, ShopId, -1); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(14, RefreshType, -1); }
  public static void AddLimitValue(FlatBufferBuilder builder, int LimitValue) { builder.AddInt(15, LimitValue, -1); }
  public static void AddLastGiftId(FlatBufferBuilder builder, int LastGiftId) { builder.AddInt(16, LastGiftId, -1); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(17, MDId, -1); }
  public static void AddMark(FlatBufferBuilder builder, int Mark) { builder.AddInt(18, Mark, -1); }
  public static void AddMailId(FlatBufferBuilder builder, int MailId) { builder.AddInt(19, MailId, -1); }
  public static void AddOnSaleTime(FlatBufferBuilder builder, long OnSaleTime) { builder.AddLong(20, OnSaleTime, -1); }
  public static void AddOffSaleTime(FlatBufferBuilder builder, long OffSaleTime) { builder.AddLong(21, OffSaleTime, -1); }
  public static void AddShowVipLimit(FlatBufferBuilder builder, int ShowVipLimit) { builder.AddInt(22, ShowVipLimit, -1); }
  public static void AddShowLevelLimit(FlatBufferBuilder builder, int ShowLevelLimit) { builder.AddInt(23, ShowLevelLimit, -1); }
  public static void AddBuyVipLimit(FlatBufferBuilder builder, int BuyVipLimit) { builder.AddInt(24, BuyVipLimit, -1); }
  public static void AddBuyLevelLimit(FlatBufferBuilder builder, int BuyLevelLimit) { builder.AddInt(25, BuyLevelLimit, -1); }
  public static void AddShowVipLimitMax(FlatBufferBuilder builder, int ShowVipLimitMax) { builder.AddInt(26, ShowVipLimitMax, -1); }
  public static void AddShowLevelLimitMax(FlatBufferBuilder builder, int ShowLevelLimitMax) { builder.AddInt(27, ShowLevelLimitMax, -1); }
  public static void AddOldMoney(FlatBufferBuilder builder, int OldMoney) { builder.AddInt(28, OldMoney, -1); }
  public static void AddRealValue(FlatBufferBuilder builder, int RealValue) { builder.AddInt(29, RealValue, -1); }
  public static void AddYuanBao(FlatBufferBuilder builder, int YuanBao) { builder.AddInt(30, YuanBao, -1); }
  public static void AddTianYu(FlatBufferBuilder builder, int TianYu) { builder.AddInt(31, TianYu, -1); }
  public static void AddMoneyTypeList(FlatBufferBuilder builder, VectorOffset MoneyTypeListOffset) { builder.AddOffset(32, MoneyTypeListOffset.Value, 0); }
  public static VectorOffset CreateMoneyTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMoneyTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBindYuanBaoList(FlatBufferBuilder builder, VectorOffset BindYuanBaoListOffset) { builder.AddOffset(33, BindYuanBaoListOffset.Value, 0); }
  public static VectorOffset CreateBindYuanBaoListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBindYuanBaoListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiItemIdList(FlatBufferBuilder builder, VectorOffset MenPaiItemIdListOffset) { builder.AddOffset(34, MenPaiItemIdListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiItemCount(FlatBufferBuilder builder, int MenPaiItemCount) { builder.AddInt(35, MenPaiItemCount, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(36, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(37, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemYuanBaoId(FlatBufferBuilder builder, int ItemYuanBaoId) { builder.AddInt(38, ItemYuanBaoId, -1); }
  public static void AddItemYuanBaoCount(FlatBufferBuilder builder, int ItemYuanBaoCount) { builder.AddInt(39, ItemYuanBaoCount, -1); }
  public static void AddOpenServiceDayAct(FlatBufferBuilder builder, int OpenServiceDayAct) { builder.AddInt(40, OpenServiceDayAct, -1); }
  public static void AddEndServiceDayAct(FlatBufferBuilder builder, int EndServiceDayAct) { builder.AddInt(41, EndServiceDayAct, -1); }
  public static void AddTaiGuYiBaoId(FlatBufferBuilder builder, int TaiGuYiBaoId) { builder.AddInt(42, TaiGuYiBaoId, -1); }
  public static Offset<FB_RMB> EndFB_RMB(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RMB>(o);
  }
};

public sealed class FB_RMBContainer : Table {
  public static FB_RMBContainer GetRootAsFB_RMBContainer(ByteBuffer _bb) { return GetRootAsFB_RMBContainer(_bb, new FB_RMBContainer()); }
  public static FB_RMBContainer GetRootAsFB_RMBContainer(ByteBuffer _bb, FB_RMBContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RMBContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RMBContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RMB GetItems(int j) { return GetItems(new FB_RMB(), j); }
  public FB_RMB GetItems(FB_RMB obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RMBContainer> CreateFB_RMBContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RMBContainer.AddItems(builder, items);
    return FB_RMBContainer.EndFB_RMBContainer(builder);
  }

  public static void StartFB_RMBContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RMB>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RMBContainer> EndFB_RMBContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RMBContainer>(o);
  }
  public static void FinishFB_RMBContainerBuffer(FlatBufferBuilder builder, Offset<FB_RMBContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
