// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CommonItem : Table {
  public static FB_CommonItem GetRootAsFB_CommonItem(ByteBuffer _bb) { return GetRootAsFB_CommonItem(_bb, new FB_CommonItem()); }
  public static FB_CommonItem GetRootAsFB_CommonItem(ByteBuffer _bb, FB_CommonItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CommonItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TipsType { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Tips { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ClassID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SubClassID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Quality { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LogType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MinLevelRequire { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevelRequire { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinAdvRequire { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxAdvRequire { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UseLogicId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UseParam { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UseParamSec { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UseLimitType { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitMDId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UseLimitNum { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CooldownId { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BindType { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SellPrice { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SellMoneyType { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxStackSize { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)99; } }
  public int MenPaiRequire { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortId { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)201; } }
  public int CompoundId { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxStorageCount { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)9999; } }
  public int ExistTime { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanThrow { get { int o = __offset(62); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int SystemRemind { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int DecomposeId { get { int o = __offset(66); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsCanBatchUse { get { int o = __offset(68); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public string DropModle { get { int o = __offset(70); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool CanShow { get { int o = __offset(72); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanCompound { get { int o = __offset(74); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsDestory { get { int o = __offset(76); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool CanGift { get { int o = __offset(78); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsRareItem { get { int o = __offset(80); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsAuctionItem { get { int o = __offset(82); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ShopTypeID { get { int o = __offset(84); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShopBaseID { get { int o = __offset(86); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsUseOnGet { get { int o = __offset(88); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetPathID { get { int o = __offset(90); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IconAtlasName { get { int o = __offset(92); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DiamondDecomposeId { get { int o = __offset(94); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsQuickUse { get { int o = __offset(96); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool CanWarehouse { get { int o = __offset(98); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ItemButtonID { get { int o = __offset(100); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UseLimitNumTotal { get { int o = __offset(102); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TipEquipDataList { get { int o = __offset(104); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TipItemBtnListType { get { int o = __offset(106); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool BNumConvert { get { int o = __offset(108); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public string NamePrefix { get { int o = __offset(110); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MinYuanShenLevel { get { int o = __offset(112); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int XuanJiChangeJobLimit { get { int o = __offset(114); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int XuanJiLevelLimit { get { int o = __offset(116); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool SendLicense { get { int o = __offset(118); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int Money { get { int o = __offset(120); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CommonItem> CreateFB_CommonItem(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset TipsType = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      StringOffset Tips = default(StringOffset),
      int ClassID = 0,
      int SubClassID = 0,
      int Quality = -1,
      int LogType = 0,
      int MinLevelRequire = -1,
      int MaxLevelRequire = -1,
      int MinAdvRequire = -1,
      int MaxAdvRequire = -1,
      int UseLogicId = -1,
      int UseParam = 0,
      int UseParamSec = -1,
      int UseLimitType = -1,
      int LimitMDId = -1,
      int UseLimitNum = -1,
      int CooldownId = -1,
      int BindType = 0,
      int SellPrice = 0,
      int SellMoneyType = 0,
      int MaxStackSize = 99,
      int MenPaiRequire = -1,
      int SortId = 201,
      int CompoundId = -1,
      int MaxStorageCount = 9999,
      int ExistTime = -1,
      bool CanThrow = true,
      int SystemRemind = 1,
      int DecomposeId = -1,
      bool IsCanBatchUse = false,
      StringOffset DropModle = default(StringOffset),
      bool CanShow = false,
      bool CanCompound = false,
      bool IsDestory = true,
      bool CanGift = false,
      bool IsRareItem = false,
      bool IsAuctionItem = false,
      int ShopTypeID = -1,
      int ShopBaseID = -1,
      bool IsUseOnGet = false,
      int GetPathID = -1,
      int IconAtlasName = -1,
      int DiamondDecomposeId = -1,
      bool IsQuickUse = false,
      bool CanWarehouse = false,
      int ItemButtonID = -1,
      int UseLimitNumTotal = -1,
      int TipEquipDataList = -1,
      int TipItemBtnListType = -1,
      bool bNumConvert = false,
      StringOffset NamePrefix = default(StringOffset),
      int MinYuanShenLevel = -1,
      int XuanJiChangeJobLimit = -1,
      int XuanJiLevelLimit = -1,
      bool SendLicense = false,
      int Money = -1) {
    builder.StartObject(59);
    FB_CommonItem.AddMoney(builder, Money);
    FB_CommonItem.AddXuanJiLevelLimit(builder, XuanJiLevelLimit);
    FB_CommonItem.AddXuanJiChangeJobLimit(builder, XuanJiChangeJobLimit);
    FB_CommonItem.AddMinYuanShenLevel(builder, MinYuanShenLevel);
    FB_CommonItem.AddNamePrefix(builder, NamePrefix);
    FB_CommonItem.AddTipItemBtnListType(builder, TipItemBtnListType);
    FB_CommonItem.AddTipEquipDataList(builder, TipEquipDataList);
    FB_CommonItem.AddUseLimitNumTotal(builder, UseLimitNumTotal);
    FB_CommonItem.AddItemButtonID(builder, ItemButtonID);
    FB_CommonItem.AddDiamondDecomposeId(builder, DiamondDecomposeId);
    FB_CommonItem.AddIconAtlasName(builder, IconAtlasName);
    FB_CommonItem.AddGetPathID(builder, GetPathID);
    FB_CommonItem.AddShopBaseID(builder, ShopBaseID);
    FB_CommonItem.AddShopTypeID(builder, ShopTypeID);
    FB_CommonItem.AddDropModle(builder, DropModle);
    FB_CommonItem.AddDecomposeId(builder, DecomposeId);
    FB_CommonItem.AddSystemRemind(builder, SystemRemind);
    FB_CommonItem.AddExistTime(builder, ExistTime);
    FB_CommonItem.AddMaxStorageCount(builder, MaxStorageCount);
    FB_CommonItem.AddCompoundId(builder, CompoundId);
    FB_CommonItem.AddSortId(builder, SortId);
    FB_CommonItem.AddMenPaiRequire(builder, MenPaiRequire);
    FB_CommonItem.AddMaxStackSize(builder, MaxStackSize);
    FB_CommonItem.AddSellMoneyType(builder, SellMoneyType);
    FB_CommonItem.AddSellPrice(builder, SellPrice);
    FB_CommonItem.AddBindType(builder, BindType);
    FB_CommonItem.AddCooldownId(builder, CooldownId);
    FB_CommonItem.AddUseLimitNum(builder, UseLimitNum);
    FB_CommonItem.AddLimitMDId(builder, LimitMDId);
    FB_CommonItem.AddUseLimitType(builder, UseLimitType);
    FB_CommonItem.AddUseParamSec(builder, UseParamSec);
    FB_CommonItem.AddUseParam(builder, UseParam);
    FB_CommonItem.AddUseLogicId(builder, UseLogicId);
    FB_CommonItem.AddMaxAdvRequire(builder, MaxAdvRequire);
    FB_CommonItem.AddMinAdvRequire(builder, MinAdvRequire);
    FB_CommonItem.AddMaxLevelRequire(builder, MaxLevelRequire);
    FB_CommonItem.AddMinLevelRequire(builder, MinLevelRequire);
    FB_CommonItem.AddLogType(builder, LogType);
    FB_CommonItem.AddQuality(builder, Quality);
    FB_CommonItem.AddSubClassID(builder, SubClassID);
    FB_CommonItem.AddClassID(builder, ClassID);
    FB_CommonItem.AddTips(builder, Tips);
    FB_CommonItem.AddIcon(builder, Icon);
    FB_CommonItem.AddTipsType(builder, TipsType);
    FB_CommonItem.AddName(builder, Name);
    FB_CommonItem.AddId(builder, Id);
    FB_CommonItem.AddSendLicense(builder, SendLicense);
    FB_CommonItem.AddBNumConvert(builder, bNumConvert);
    FB_CommonItem.AddCanWarehouse(builder, CanWarehouse);
    FB_CommonItem.AddIsQuickUse(builder, IsQuickUse);
    FB_CommonItem.AddIsUseOnGet(builder, IsUseOnGet);
    FB_CommonItem.AddIsAuctionItem(builder, IsAuctionItem);
    FB_CommonItem.AddIsRareItem(builder, IsRareItem);
    FB_CommonItem.AddCanGift(builder, CanGift);
    FB_CommonItem.AddIsDestory(builder, IsDestory);
    FB_CommonItem.AddCanCompound(builder, CanCompound);
    FB_CommonItem.AddCanShow(builder, CanShow);
    FB_CommonItem.AddIsCanBatchUse(builder, IsCanBatchUse);
    FB_CommonItem.AddCanThrow(builder, CanThrow);
    return FB_CommonItem.EndFB_CommonItem(builder);
  }

  public static void StartFB_CommonItem(FlatBufferBuilder builder) { builder.StartObject(59); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTipsType(FlatBufferBuilder builder, StringOffset TipsTypeOffset) { builder.AddOffset(2, TipsTypeOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(4, TipsOffset.Value, 0); }
  public static void AddClassID(FlatBufferBuilder builder, int ClassID) { builder.AddInt(5, ClassID, 0); }
  public static void AddSubClassID(FlatBufferBuilder builder, int SubClassID) { builder.AddInt(6, SubClassID, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(7, Quality, -1); }
  public static void AddLogType(FlatBufferBuilder builder, int LogType) { builder.AddInt(8, LogType, 0); }
  public static void AddMinLevelRequire(FlatBufferBuilder builder, int MinLevelRequire) { builder.AddInt(9, MinLevelRequire, -1); }
  public static void AddMaxLevelRequire(FlatBufferBuilder builder, int MaxLevelRequire) { builder.AddInt(10, MaxLevelRequire, -1); }
  public static void AddMinAdvRequire(FlatBufferBuilder builder, int MinAdvRequire) { builder.AddInt(11, MinAdvRequire, -1); }
  public static void AddMaxAdvRequire(FlatBufferBuilder builder, int MaxAdvRequire) { builder.AddInt(12, MaxAdvRequire, -1); }
  public static void AddUseLogicId(FlatBufferBuilder builder, int UseLogicId) { builder.AddInt(13, UseLogicId, -1); }
  public static void AddUseParam(FlatBufferBuilder builder, int UseParam) { builder.AddInt(14, UseParam, 0); }
  public static void AddUseParamSec(FlatBufferBuilder builder, int UseParamSec) { builder.AddInt(15, UseParamSec, -1); }
  public static void AddUseLimitType(FlatBufferBuilder builder, int UseLimitType) { builder.AddInt(16, UseLimitType, -1); }
  public static void AddLimitMDId(FlatBufferBuilder builder, int LimitMDId) { builder.AddInt(17, LimitMDId, -1); }
  public static void AddUseLimitNum(FlatBufferBuilder builder, int UseLimitNum) { builder.AddInt(18, UseLimitNum, -1); }
  public static void AddCooldownId(FlatBufferBuilder builder, int CooldownId) { builder.AddInt(19, CooldownId, -1); }
  public static void AddBindType(FlatBufferBuilder builder, int BindType) { builder.AddInt(20, BindType, 0); }
  public static void AddSellPrice(FlatBufferBuilder builder, int SellPrice) { builder.AddInt(21, SellPrice, 0); }
  public static void AddSellMoneyType(FlatBufferBuilder builder, int SellMoneyType) { builder.AddInt(22, SellMoneyType, 0); }
  public static void AddMaxStackSize(FlatBufferBuilder builder, int MaxStackSize) { builder.AddInt(23, MaxStackSize, 99); }
  public static void AddMenPaiRequire(FlatBufferBuilder builder, int MenPaiRequire) { builder.AddInt(24, MenPaiRequire, -1); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(25, SortId, 201); }
  public static void AddCompoundId(FlatBufferBuilder builder, int CompoundId) { builder.AddInt(26, CompoundId, -1); }
  public static void AddMaxStorageCount(FlatBufferBuilder builder, int MaxStorageCount) { builder.AddInt(27, MaxStorageCount, 9999); }
  public static void AddExistTime(FlatBufferBuilder builder, int ExistTime) { builder.AddInt(28, ExistTime, -1); }
  public static void AddCanThrow(FlatBufferBuilder builder, bool CanThrow) { builder.AddBool(29, CanThrow, true); }
  public static void AddSystemRemind(FlatBufferBuilder builder, int SystemRemind) { builder.AddInt(30, SystemRemind, 1); }
  public static void AddDecomposeId(FlatBufferBuilder builder, int DecomposeId) { builder.AddInt(31, DecomposeId, -1); }
  public static void AddIsCanBatchUse(FlatBufferBuilder builder, bool IsCanBatchUse) { builder.AddBool(32, IsCanBatchUse, false); }
  public static void AddDropModle(FlatBufferBuilder builder, StringOffset DropModleOffset) { builder.AddOffset(33, DropModleOffset.Value, 0); }
  public static void AddCanShow(FlatBufferBuilder builder, bool CanShow) { builder.AddBool(34, CanShow, false); }
  public static void AddCanCompound(FlatBufferBuilder builder, bool CanCompound) { builder.AddBool(35, CanCompound, false); }
  public static void AddIsDestory(FlatBufferBuilder builder, bool IsDestory) { builder.AddBool(36, IsDestory, true); }
  public static void AddCanGift(FlatBufferBuilder builder, bool CanGift) { builder.AddBool(37, CanGift, false); }
  public static void AddIsRareItem(FlatBufferBuilder builder, bool IsRareItem) { builder.AddBool(38, IsRareItem, false); }
  public static void AddIsAuctionItem(FlatBufferBuilder builder, bool IsAuctionItem) { builder.AddBool(39, IsAuctionItem, false); }
  public static void AddShopTypeID(FlatBufferBuilder builder, int ShopTypeID) { builder.AddInt(40, ShopTypeID, -1); }
  public static void AddShopBaseID(FlatBufferBuilder builder, int ShopBaseID) { builder.AddInt(41, ShopBaseID, -1); }
  public static void AddIsUseOnGet(FlatBufferBuilder builder, bool IsUseOnGet) { builder.AddBool(42, IsUseOnGet, false); }
  public static void AddGetPathID(FlatBufferBuilder builder, int GetPathID) { builder.AddInt(43, GetPathID, -1); }
  public static void AddIconAtlasName(FlatBufferBuilder builder, int IconAtlasName) { builder.AddInt(44, IconAtlasName, -1); }
  public static void AddDiamondDecomposeId(FlatBufferBuilder builder, int DiamondDecomposeId) { builder.AddInt(45, DiamondDecomposeId, -1); }
  public static void AddIsQuickUse(FlatBufferBuilder builder, bool IsQuickUse) { builder.AddBool(46, IsQuickUse, false); }
  public static void AddCanWarehouse(FlatBufferBuilder builder, bool CanWarehouse) { builder.AddBool(47, CanWarehouse, false); }
  public static void AddItemButtonID(FlatBufferBuilder builder, int ItemButtonID) { builder.AddInt(48, ItemButtonID, -1); }
  public static void AddUseLimitNumTotal(FlatBufferBuilder builder, int UseLimitNumTotal) { builder.AddInt(49, UseLimitNumTotal, -1); }
  public static void AddTipEquipDataList(FlatBufferBuilder builder, int TipEquipDataList) { builder.AddInt(50, TipEquipDataList, -1); }
  public static void AddTipItemBtnListType(FlatBufferBuilder builder, int TipItemBtnListType) { builder.AddInt(51, TipItemBtnListType, -1); }
  public static void AddBNumConvert(FlatBufferBuilder builder, bool bNumConvert) { builder.AddBool(52, bNumConvert, false); }
  public static void AddNamePrefix(FlatBufferBuilder builder, StringOffset NamePrefixOffset) { builder.AddOffset(53, NamePrefixOffset.Value, 0); }
  public static void AddMinYuanShenLevel(FlatBufferBuilder builder, int MinYuanShenLevel) { builder.AddInt(54, MinYuanShenLevel, -1); }
  public static void AddXuanJiChangeJobLimit(FlatBufferBuilder builder, int XuanJiChangeJobLimit) { builder.AddInt(55, XuanJiChangeJobLimit, -1); }
  public static void AddXuanJiLevelLimit(FlatBufferBuilder builder, int XuanJiLevelLimit) { builder.AddInt(56, XuanJiLevelLimit, -1); }
  public static void AddSendLicense(FlatBufferBuilder builder, bool SendLicense) { builder.AddBool(57, SendLicense, false); }
  public static void AddMoney(FlatBufferBuilder builder, int Money) { builder.AddInt(58, Money, -1); }
  public static Offset<FB_CommonItem> EndFB_CommonItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CommonItem>(o);
  }
};

public sealed class FB_CommonItemContainer : Table {
  public static FB_CommonItemContainer GetRootAsFB_CommonItemContainer(ByteBuffer _bb) { return GetRootAsFB_CommonItemContainer(_bb, new FB_CommonItemContainer()); }
  public static FB_CommonItemContainer GetRootAsFB_CommonItemContainer(ByteBuffer _bb, FB_CommonItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CommonItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CommonItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CommonItem GetItems(int j) { return GetItems(new FB_CommonItem(), j); }
  public FB_CommonItem GetItems(FB_CommonItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CommonItemContainer> CreateFB_CommonItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CommonItemContainer.AddItems(builder, items);
    return FB_CommonItemContainer.EndFB_CommonItemContainer(builder);
  }

  public static void StartFB_CommonItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CommonItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CommonItemContainer> EndFB_CommonItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CommonItemContainer>(o);
  }
  public static void FinishFB_CommonItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_CommonItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
