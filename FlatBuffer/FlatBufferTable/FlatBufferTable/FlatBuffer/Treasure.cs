// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Treasure : Table {
  public static FB_Treasure GetRootAsFB_Treasure(ByteBuffer _bb) { return GetRootAsFB_Treasure(_bb, new FB_Treasure()); }
  public static FB_Treasure GetRootAsFB_Treasure(ByteBuffer _bb, FB_Treasure obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Treasure __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCostNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int ItemPriceMoney { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemPrice { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FreeCd { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowBigItem { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BroadcastBig { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ShowItem { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public int RecordNum { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RecordNormal { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SaleId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CountNum { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Blessing { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Score { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BroadcastLink { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_Treasure> CreateFB_Treasure(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemID = -1,
      VectorOffset CostNumList = default(VectorOffset),
      int ItemPriceMoney = -1,
      int ItemPrice = -1,
      int FreeCd = -1,
      int ShowBigItem = -1,
      int BroadcastBig = -1,
      StringOffset ShowItem = default(StringOffset),
      int RecordNum = -1,
      int RecordNormal = -1,
      int SaleId = -1,
      int CountNum = -1,
      int Blessing = -1,
      int Score = -1,
      int BroadcastLink = -1) {
    builder.StartObject(16);
    FB_Treasure.AddBroadcastLink(builder, BroadcastLink);
    FB_Treasure.AddScore(builder, Score);
    FB_Treasure.AddBlessing(builder, Blessing);
    FB_Treasure.AddCountNum(builder, CountNum);
    FB_Treasure.AddSaleId(builder, SaleId);
    FB_Treasure.AddRecordNormal(builder, RecordNormal);
    FB_Treasure.AddRecordNum(builder, RecordNum);
    FB_Treasure.AddShowItem(builder, ShowItem);
    FB_Treasure.AddBroadcastBig(builder, BroadcastBig);
    FB_Treasure.AddShowBigItem(builder, ShowBigItem);
    FB_Treasure.AddFreeCd(builder, FreeCd);
    FB_Treasure.AddItemPrice(builder, ItemPrice);
    FB_Treasure.AddItemPriceMoney(builder, ItemPriceMoney);
    FB_Treasure.AddCostNumList(builder, CostNumList);
    FB_Treasure.AddCostItemID(builder, CostItemID);
    FB_Treasure.AddId(builder, Id);
    return FB_Treasure.EndFB_Treasure(builder);
  }

  public static void StartFB_Treasure(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemID(FlatBufferBuilder builder, int CostItemID) { builder.AddInt(1, CostItemID, -1); }
  public static void AddCostNumList(FlatBufferBuilder builder, VectorOffset CostNumListOffset) { builder.AddOffset(2, CostNumListOffset.Value, 0); }
  public static VectorOffset CreateCostNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemPriceMoney(FlatBufferBuilder builder, int ItemPriceMoney) { builder.AddInt(3, ItemPriceMoney, -1); }
  public static void AddItemPrice(FlatBufferBuilder builder, int ItemPrice) { builder.AddInt(4, ItemPrice, -1); }
  public static void AddFreeCd(FlatBufferBuilder builder, int FreeCd) { builder.AddInt(5, FreeCd, -1); }
  public static void AddShowBigItem(FlatBufferBuilder builder, int ShowBigItem) { builder.AddInt(6, ShowBigItem, -1); }
  public static void AddBroadcastBig(FlatBufferBuilder builder, int BroadcastBig) { builder.AddInt(7, BroadcastBig, -1); }
  public static void AddShowItem(FlatBufferBuilder builder, StringOffset ShowItemOffset) { builder.AddOffset(8, ShowItemOffset.Value, 0); }
  public static void AddRecordNum(FlatBufferBuilder builder, int RecordNum) { builder.AddInt(9, RecordNum, -1); }
  public static void AddRecordNormal(FlatBufferBuilder builder, int RecordNormal) { builder.AddInt(10, RecordNormal, -1); }
  public static void AddSaleId(FlatBufferBuilder builder, int SaleId) { builder.AddInt(11, SaleId, -1); }
  public static void AddCountNum(FlatBufferBuilder builder, int CountNum) { builder.AddInt(12, CountNum, -1); }
  public static void AddBlessing(FlatBufferBuilder builder, int Blessing) { builder.AddInt(13, Blessing, -1); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(14, Score, -1); }
  public static void AddBroadcastLink(FlatBufferBuilder builder, int BroadcastLink) { builder.AddInt(15, BroadcastLink, -1); }
  public static Offset<FB_Treasure> EndFB_Treasure(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Treasure>(o);
  }
};

public sealed class FB_TreasureContainer : Table {
  public static FB_TreasureContainer GetRootAsFB_TreasureContainer(ByteBuffer _bb) { return GetRootAsFB_TreasureContainer(_bb, new FB_TreasureContainer()); }
  public static FB_TreasureContainer GetRootAsFB_TreasureContainer(ByteBuffer _bb, FB_TreasureContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TreasureContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TreasureContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Treasure GetItems(int j) { return GetItems(new FB_Treasure(), j); }
  public FB_Treasure GetItems(FB_Treasure obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TreasureContainer> CreateFB_TreasureContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TreasureContainer.AddItems(builder, items);
    return FB_TreasureContainer.EndFB_TreasureContainer(builder);
  }

  public static void StartFB_TreasureContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Treasure>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TreasureContainer> EndFB_TreasureContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TreasureContainer>(o);
  }
  public static void FinishFB_TreasureContainerBuffer(FlatBufferBuilder builder, Offset<FB_TreasureContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
