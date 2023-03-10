// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TianJiBaoGe : Table {
  public static FB_TianJiBaoGe GetRootAsFB_TianJiBaoGe(ByteBuffer _bb) { return GetRootAsFB_TianJiBaoGe(_bb, new FB_TianJiBaoGe()); }
  public static FB_TianJiBaoGe GetRootAsFB_TianJiBaoGe(ByteBuffer _bb, FB_TianJiBaoGe obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TianJiBaoGe __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelMin { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelMax { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Set { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardNumber { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumberList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumberListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMoneyTypeList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MoneyTypeListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPriceList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PriceListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPriceSaleList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PriceSaleListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianJiBaoGe> CreateFB_TianJiBaoGe(FlatBufferBuilder builder,
      int ID = 0,
      int LevelMin = -1,
      int LevelMax = -1,
      int Set = -1,
      int RewardID = -1,
      int RewardNumber = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumberList = default(VectorOffset),
      VectorOffset MoneyTypeList = default(VectorOffset),
      VectorOffset PriceList = default(VectorOffset),
      VectorOffset PriceSaleList = default(VectorOffset)) {
    builder.StartObject(11);
    FB_TianJiBaoGe.AddPriceSaleList(builder, PriceSaleList);
    FB_TianJiBaoGe.AddPriceList(builder, PriceList);
    FB_TianJiBaoGe.AddMoneyTypeList(builder, MoneyTypeList);
    FB_TianJiBaoGe.AddItemNumberList(builder, ItemNumberList);
    FB_TianJiBaoGe.AddItemIDList(builder, ItemIDList);
    FB_TianJiBaoGe.AddRewardNumber(builder, RewardNumber);
    FB_TianJiBaoGe.AddRewardID(builder, RewardID);
    FB_TianJiBaoGe.AddSet(builder, Set);
    FB_TianJiBaoGe.AddLevelMax(builder, LevelMax);
    FB_TianJiBaoGe.AddLevelMin(builder, LevelMin);
    FB_TianJiBaoGe.AddID(builder, ID);
    return FB_TianJiBaoGe.EndFB_TianJiBaoGe(builder);
  }

  public static void StartFB_TianJiBaoGe(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevelMin(FlatBufferBuilder builder, int LevelMin) { builder.AddInt(1, LevelMin, -1); }
  public static void AddLevelMax(FlatBufferBuilder builder, int LevelMax) { builder.AddInt(2, LevelMax, -1); }
  public static void AddSet(FlatBufferBuilder builder, int Set) { builder.AddInt(3, Set, -1); }
  public static void AddRewardID(FlatBufferBuilder builder, int RewardID) { builder.AddInt(4, RewardID, -1); }
  public static void AddRewardNumber(FlatBufferBuilder builder, int RewardNumber) { builder.AddInt(5, RewardNumber, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(6, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumberList(FlatBufferBuilder builder, VectorOffset ItemNumberListOffset) { builder.AddOffset(7, ItemNumberListOffset.Value, 0); }
  public static VectorOffset CreateItemNumberListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumberListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMoneyTypeList(FlatBufferBuilder builder, VectorOffset MoneyTypeListOffset) { builder.AddOffset(8, MoneyTypeListOffset.Value, 0); }
  public static VectorOffset CreateMoneyTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMoneyTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPriceList(FlatBufferBuilder builder, VectorOffset PriceListOffset) { builder.AddOffset(9, PriceListOffset.Value, 0); }
  public static VectorOffset CreatePriceListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPriceListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPriceSaleList(FlatBufferBuilder builder, VectorOffset PriceSaleListOffset) { builder.AddOffset(10, PriceSaleListOffset.Value, 0); }
  public static VectorOffset CreatePriceSaleListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPriceSaleListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianJiBaoGe> EndFB_TianJiBaoGe(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianJiBaoGe>(o);
  }
};

public sealed class FB_TianJiBaoGeContainer : Table {
  public static FB_TianJiBaoGeContainer GetRootAsFB_TianJiBaoGeContainer(ByteBuffer _bb) { return GetRootAsFB_TianJiBaoGeContainer(_bb, new FB_TianJiBaoGeContainer()); }
  public static FB_TianJiBaoGeContainer GetRootAsFB_TianJiBaoGeContainer(ByteBuffer _bb, FB_TianJiBaoGeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TianJiBaoGeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TianJiBaoGeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TianJiBaoGe GetItems(int j) { return GetItems(new FB_TianJiBaoGe(), j); }
  public FB_TianJiBaoGe GetItems(FB_TianJiBaoGe obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianJiBaoGeContainer> CreateFB_TianJiBaoGeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TianJiBaoGeContainer.AddItems(builder, items);
    return FB_TianJiBaoGeContainer.EndFB_TianJiBaoGeContainer(builder);
  }

  public static void StartFB_TianJiBaoGeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TianJiBaoGe>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianJiBaoGeContainer> EndFB_TianJiBaoGeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianJiBaoGeContainer>(o);
  }
  public static void FinishFB_TianJiBaoGeContainerBuffer(FlatBufferBuilder builder, Offset<FB_TianJiBaoGeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
