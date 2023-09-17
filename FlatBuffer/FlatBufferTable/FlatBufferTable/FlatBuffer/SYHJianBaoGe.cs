// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJianBaoGe : Table {
  public static FB_SYHJianBaoGe GetRootAsFB_SYHJianBaoGe(ByteBuffer _bb) { return GetRootAsFB_SYHJianBaoGe(_bb, new FB_SYHJianBaoGe()); }
  public static FB_SYHJianBaoGe GetRootAsFB_SYHJianBaoGe(ByteBuffer _bb, FB_SYHJianBaoGe obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJianBaoGe __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HighDropBoxId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LowDropBoxId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ThreeDropBox { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MagicNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Param { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Seq { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int BuyManyTime { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItem { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShopItemId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxTime { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHJianBaoGe> CreateFB_SYHJianBaoGe(FlatBufferBuilder builder,
      int ID = 0,
      int HighDropBoxId = 0,
      int LowDropBoxId = 0,
      int ThreeDropBox = 0,
      int MagicNum = 0,
      int LevelLimit = 0,
      int Param = -1,
      int Seq = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int BuyManyTime = -1,
      int CostItem = -1,
      int ShopItemId = -1,
      int MaxTime = -1,
      int FakeObjId = -1) {
    builder.StartObject(15);
    FB_SYHJianBaoGe.AddFakeObjId(builder, FakeObjId);
    FB_SYHJianBaoGe.AddMaxTime(builder, MaxTime);
    FB_SYHJianBaoGe.AddShopItemId(builder, ShopItemId);
    FB_SYHJianBaoGe.AddCostItem(builder, CostItem);
    FB_SYHJianBaoGe.AddBuyManyTime(builder, BuyManyTime);
    FB_SYHJianBaoGe.AddItemNumList(builder, ItemNumList);
    FB_SYHJianBaoGe.AddItemIdList(builder, ItemIdList);
    FB_SYHJianBaoGe.AddSeq(builder, Seq);
    FB_SYHJianBaoGe.AddParam(builder, Param);
    FB_SYHJianBaoGe.AddLevelLimit(builder, LevelLimit);
    FB_SYHJianBaoGe.AddMagicNum(builder, MagicNum);
    FB_SYHJianBaoGe.AddThreeDropBox(builder, ThreeDropBox);
    FB_SYHJianBaoGe.AddLowDropBoxId(builder, LowDropBoxId);
    FB_SYHJianBaoGe.AddHighDropBoxId(builder, HighDropBoxId);
    FB_SYHJianBaoGe.AddID(builder, ID);
    return FB_SYHJianBaoGe.EndFB_SYHJianBaoGe(builder);
  }

  public static void StartFB_SYHJianBaoGe(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHighDropBoxId(FlatBufferBuilder builder, int HighDropBoxId) { builder.AddInt(1, HighDropBoxId, 0); }
  public static void AddLowDropBoxId(FlatBufferBuilder builder, int LowDropBoxId) { builder.AddInt(2, LowDropBoxId, 0); }
  public static void AddThreeDropBox(FlatBufferBuilder builder, int ThreeDropBox) { builder.AddInt(3, ThreeDropBox, 0); }
  public static void AddMagicNum(FlatBufferBuilder builder, int MagicNum) { builder.AddInt(4, MagicNum, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(5, LevelLimit, 0); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(6, Param, -1); }
  public static void AddSeq(FlatBufferBuilder builder, int Seq) { builder.AddInt(7, Seq, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(8, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(9, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBuyManyTime(FlatBufferBuilder builder, int BuyManyTime) { builder.AddInt(10, BuyManyTime, -1); }
  public static void AddCostItem(FlatBufferBuilder builder, int CostItem) { builder.AddInt(11, CostItem, -1); }
  public static void AddShopItemId(FlatBufferBuilder builder, int ShopItemId) { builder.AddInt(12, ShopItemId, -1); }
  public static void AddMaxTime(FlatBufferBuilder builder, int MaxTime) { builder.AddInt(13, MaxTime, -1); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(14, FakeObjId, -1); }
  public static Offset<FB_SYHJianBaoGe> EndFB_SYHJianBaoGe(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJianBaoGe>(o);
  }
};

public sealed class FB_SYHJianBaoGeContainer : Table {
  public static FB_SYHJianBaoGeContainer GetRootAsFB_SYHJianBaoGeContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJianBaoGeContainer(_bb, new FB_SYHJianBaoGeContainer()); }
  public static FB_SYHJianBaoGeContainer GetRootAsFB_SYHJianBaoGeContainer(ByteBuffer _bb, FB_SYHJianBaoGeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJianBaoGeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJianBaoGeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJianBaoGe GetItems(int j) { return GetItems(new FB_SYHJianBaoGe(), j); }
  public FB_SYHJianBaoGe GetItems(FB_SYHJianBaoGe obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJianBaoGeContainer> CreateFB_SYHJianBaoGeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJianBaoGeContainer.AddItems(builder, items);
    return FB_SYHJianBaoGeContainer.EndFB_SYHJianBaoGeContainer(builder);
  }

  public static void StartFB_SYHJianBaoGeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJianBaoGe>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJianBaoGeContainer> EndFB_SYHJianBaoGeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJianBaoGeContainer>(o);
  }
  public static void FinishFB_SYHJianBaoGeContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJianBaoGeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
