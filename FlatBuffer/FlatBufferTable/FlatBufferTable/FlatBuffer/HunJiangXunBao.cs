// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangXunBao : Table {
  public static FB_HunJiangXunBao GetRootAsFB_HunJiangXunBao(ByteBuffer _bb) { return GetRootAsFB_HunJiangXunBao(_bb, new FB_HunJiangXunBao()); }
  public static FB_HunJiangXunBao GetRootAsFB_HunJiangXunBao(ByteBuffer _bb, FB_HunJiangXunBao obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangXunBao __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HighDropBox { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowDropBox { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BaseRandom { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddRandom { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PageId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShopItemId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedItemId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TreasureAddMoney { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int FixedDropBox { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_HunJiangXunBao> CreateFB_HunJiangXunBao(FlatBufferBuilder builder,
      int Id = 0,
      int HighDropBox = -1,
      int LowDropBox = -1,
      int LowTime = -1,
      int HighTime = -1,
      int BaseRandom = -1,
      int AddRandom = -1,
      int PageId = -1,
      int ShopItemId = -1,
      int NeedItemId = -1,
      int TreasureAddMoney = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int FixedDropBox = -1) {
    builder.StartObject(14);
    FB_HunJiangXunBao.AddFixedDropBox(builder, FixedDropBox);
    FB_HunJiangXunBao.AddItemNumList(builder, ItemNumList);
    FB_HunJiangXunBao.AddItemIDList(builder, ItemIDList);
    FB_HunJiangXunBao.AddTreasureAddMoney(builder, TreasureAddMoney);
    FB_HunJiangXunBao.AddNeedItemId(builder, NeedItemId);
    FB_HunJiangXunBao.AddShopItemId(builder, ShopItemId);
    FB_HunJiangXunBao.AddPageId(builder, PageId);
    FB_HunJiangXunBao.AddAddRandom(builder, AddRandom);
    FB_HunJiangXunBao.AddBaseRandom(builder, BaseRandom);
    FB_HunJiangXunBao.AddHighTime(builder, HighTime);
    FB_HunJiangXunBao.AddLowTime(builder, LowTime);
    FB_HunJiangXunBao.AddLowDropBox(builder, LowDropBox);
    FB_HunJiangXunBao.AddHighDropBox(builder, HighDropBox);
    FB_HunJiangXunBao.AddId(builder, Id);
    return FB_HunJiangXunBao.EndFB_HunJiangXunBao(builder);
  }

  public static void StartFB_HunJiangXunBao(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddHighDropBox(FlatBufferBuilder builder, int HighDropBox) { builder.AddInt(1, HighDropBox, -1); }
  public static void AddLowDropBox(FlatBufferBuilder builder, int LowDropBox) { builder.AddInt(2, LowDropBox, -1); }
  public static void AddLowTime(FlatBufferBuilder builder, int LowTime) { builder.AddInt(3, LowTime, -1); }
  public static void AddHighTime(FlatBufferBuilder builder, int HighTime) { builder.AddInt(4, HighTime, -1); }
  public static void AddBaseRandom(FlatBufferBuilder builder, int BaseRandom) { builder.AddInt(5, BaseRandom, -1); }
  public static void AddAddRandom(FlatBufferBuilder builder, int AddRandom) { builder.AddInt(6, AddRandom, -1); }
  public static void AddPageId(FlatBufferBuilder builder, int PageId) { builder.AddInt(7, PageId, -1); }
  public static void AddShopItemId(FlatBufferBuilder builder, int ShopItemId) { builder.AddInt(8, ShopItemId, -1); }
  public static void AddNeedItemId(FlatBufferBuilder builder, int NeedItemId) { builder.AddInt(9, NeedItemId, -1); }
  public static void AddTreasureAddMoney(FlatBufferBuilder builder, int TreasureAddMoney) { builder.AddInt(10, TreasureAddMoney, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(11, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(12, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFixedDropBox(FlatBufferBuilder builder, int FixedDropBox) { builder.AddInt(13, FixedDropBox, -1); }
  public static Offset<FB_HunJiangXunBao> EndFB_HunJiangXunBao(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangXunBao>(o);
  }
};

public sealed class FB_HunJiangXunBaoContainer : Table {
  public static FB_HunJiangXunBaoContainer GetRootAsFB_HunJiangXunBaoContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangXunBaoContainer(_bb, new FB_HunJiangXunBaoContainer()); }
  public static FB_HunJiangXunBaoContainer GetRootAsFB_HunJiangXunBaoContainer(ByteBuffer _bb, FB_HunJiangXunBaoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangXunBaoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangXunBaoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangXunBao GetItems(int j) { return GetItems(new FB_HunJiangXunBao(), j); }
  public FB_HunJiangXunBao GetItems(FB_HunJiangXunBao obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangXunBaoContainer> CreateFB_HunJiangXunBaoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangXunBaoContainer.AddItems(builder, items);
    return FB_HunJiangXunBaoContainer.EndFB_HunJiangXunBaoContainer(builder);
  }

  public static void StartFB_HunJiangXunBaoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangXunBao>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangXunBaoContainer> EndFB_HunJiangXunBaoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangXunBaoContainer>(o);
  }
  public static void FinishFB_HunJiangXunBaoContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangXunBaoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
