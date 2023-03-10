// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityAncientSealSearch : Table {
  public static FB_ActivityAncientSealSearch GetRootAsFB_ActivityAncientSealSearch(ByteBuffer _bb) { return GetRootAsFB_ActivityAncientSealSearch(_bb, new FB_ActivityAncientSealSearch()); }
  public static FB_ActivityAncientSealSearch GetRootAsFB_ActivityAncientSealSearch(ByteBuffer _bb, FB_ActivityAncientSealSearch obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityAncientSealSearch __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BaseCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CellsNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BackNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Probability { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMaxItemsList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaxItemsListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightMaxList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightMaxListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public string SprEnterName { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string EnterName { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SprHuntName { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public float GetHuntPosXList(int j) { int o = __offset(28); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int HuntPosXListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public float GetHuntPosYList(int j) { int o = __offset(30); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int HuntPosYListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int MoneyType { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CcurPrice { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLevel { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostNum { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlcokMoneyType { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlcokMoneyNum { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemNumList(int j) { int o = __offset(46); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(46); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemMaxNumList(int j) { int o = __offset(48); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemMaxNumListLength { get { int o = __offset(48); return o != 0 ? __vector_len(o) : 0; } }
  public int BaseProbability { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EAddProbability { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityAncientSealSearch> CreateFB_ActivityAncientSealSearch(FlatBufferBuilder builder,
      int ID = 0,
      int BaseCount = -1,
      int CellsNum = 0,
      int BackNum = 0,
      int Probability = -1,
      VectorOffset ItemList = default(VectorOffset),
      VectorOffset WeightList = default(VectorOffset),
      VectorOffset MaxItemsList = default(VectorOffset),
      VectorOffset WeightMaxList = default(VectorOffset),
      StringOffset SprEnterName = default(StringOffset),
      StringOffset EnterName = default(StringOffset),
      StringOffset SprHuntName = default(StringOffset),
      VectorOffset HuntPosXList = default(VectorOffset),
      VectorOffset HuntPosYList = default(VectorOffset),
      int MoneyType = -1,
      int CcurPrice = -1,
      int WorldLevel = -1,
      int Param = -1,
      int CostNum = -1,
      int UnlcokMoneyType = -1,
      int UnlcokMoneyNum = -1,
      VectorOffset ItemNumList = default(VectorOffset),
      VectorOffset ItemMaxNumList = default(VectorOffset),
      int BaseProbability = -1,
      int EAddProbability = -1) {
    builder.StartObject(25);
    FB_ActivityAncientSealSearch.AddEAddProbability(builder, EAddProbability);
    FB_ActivityAncientSealSearch.AddBaseProbability(builder, BaseProbability);
    FB_ActivityAncientSealSearch.AddItemMaxNumList(builder, ItemMaxNumList);
    FB_ActivityAncientSealSearch.AddItemNumList(builder, ItemNumList);
    FB_ActivityAncientSealSearch.AddUnlcokMoneyNum(builder, UnlcokMoneyNum);
    FB_ActivityAncientSealSearch.AddUnlcokMoneyType(builder, UnlcokMoneyType);
    FB_ActivityAncientSealSearch.AddCostNum(builder, CostNum);
    FB_ActivityAncientSealSearch.AddParam(builder, Param);
    FB_ActivityAncientSealSearch.AddWorldLevel(builder, WorldLevel);
    FB_ActivityAncientSealSearch.AddCcurPrice(builder, CcurPrice);
    FB_ActivityAncientSealSearch.AddMoneyType(builder, MoneyType);
    FB_ActivityAncientSealSearch.AddHuntPosYList(builder, HuntPosYList);
    FB_ActivityAncientSealSearch.AddHuntPosXList(builder, HuntPosXList);
    FB_ActivityAncientSealSearch.AddSprHuntName(builder, SprHuntName);
    FB_ActivityAncientSealSearch.AddEnterName(builder, EnterName);
    FB_ActivityAncientSealSearch.AddSprEnterName(builder, SprEnterName);
    FB_ActivityAncientSealSearch.AddWeightMaxList(builder, WeightMaxList);
    FB_ActivityAncientSealSearch.AddMaxItemsList(builder, MaxItemsList);
    FB_ActivityAncientSealSearch.AddWeightList(builder, WeightList);
    FB_ActivityAncientSealSearch.AddItemList(builder, ItemList);
    FB_ActivityAncientSealSearch.AddProbability(builder, Probability);
    FB_ActivityAncientSealSearch.AddBackNum(builder, BackNum);
    FB_ActivityAncientSealSearch.AddCellsNum(builder, CellsNum);
    FB_ActivityAncientSealSearch.AddBaseCount(builder, BaseCount);
    FB_ActivityAncientSealSearch.AddID(builder, ID);
    return FB_ActivityAncientSealSearch.EndFB_ActivityAncientSealSearch(builder);
  }

  public static void StartFB_ActivityAncientSealSearch(FlatBufferBuilder builder) { builder.StartObject(25); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBaseCount(FlatBufferBuilder builder, int BaseCount) { builder.AddInt(1, BaseCount, -1); }
  public static void AddCellsNum(FlatBufferBuilder builder, int CellsNum) { builder.AddInt(2, CellsNum, 0); }
  public static void AddBackNum(FlatBufferBuilder builder, int BackNum) { builder.AddInt(3, BackNum, 0); }
  public static void AddProbability(FlatBufferBuilder builder, int Probability) { builder.AddInt(4, Probability, -1); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(5, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(6, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxItemsList(FlatBufferBuilder builder, VectorOffset MaxItemsListOffset) { builder.AddOffset(7, MaxItemsListOffset.Value, 0); }
  public static VectorOffset CreateMaxItemsListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaxItemsListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightMaxList(FlatBufferBuilder builder, VectorOffset WeightMaxListOffset) { builder.AddOffset(8, WeightMaxListOffset.Value, 0); }
  public static VectorOffset CreateWeightMaxListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightMaxListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSprEnterName(FlatBufferBuilder builder, StringOffset SprEnterNameOffset) { builder.AddOffset(9, SprEnterNameOffset.Value, 0); }
  public static void AddEnterName(FlatBufferBuilder builder, StringOffset EnterNameOffset) { builder.AddOffset(10, EnterNameOffset.Value, 0); }
  public static void AddSprHuntName(FlatBufferBuilder builder, StringOffset SprHuntNameOffset) { builder.AddOffset(11, SprHuntNameOffset.Value, 0); }
  public static void AddHuntPosXList(FlatBufferBuilder builder, VectorOffset HuntPosXListOffset) { builder.AddOffset(12, HuntPosXListOffset.Value, 0); }
  public static VectorOffset CreateHuntPosXListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartHuntPosXListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHuntPosYList(FlatBufferBuilder builder, VectorOffset HuntPosYListOffset) { builder.AddOffset(13, HuntPosYListOffset.Value, 0); }
  public static VectorOffset CreateHuntPosYListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartHuntPosYListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(14, MoneyType, -1); }
  public static void AddCcurPrice(FlatBufferBuilder builder, int CcurPrice) { builder.AddInt(15, CcurPrice, -1); }
  public static void AddWorldLevel(FlatBufferBuilder builder, int WorldLevel) { builder.AddInt(16, WorldLevel, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(17, Param, -1); }
  public static void AddCostNum(FlatBufferBuilder builder, int CostNum) { builder.AddInt(18, CostNum, -1); }
  public static void AddUnlcokMoneyType(FlatBufferBuilder builder, int UnlcokMoneyType) { builder.AddInt(19, UnlcokMoneyType, -1); }
  public static void AddUnlcokMoneyNum(FlatBufferBuilder builder, int UnlcokMoneyNum) { builder.AddInt(20, UnlcokMoneyNum, -1); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(21, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemMaxNumList(FlatBufferBuilder builder, VectorOffset ItemMaxNumListOffset) { builder.AddOffset(22, ItemMaxNumListOffset.Value, 0); }
  public static VectorOffset CreateItemMaxNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemMaxNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseProbability(FlatBufferBuilder builder, int BaseProbability) { builder.AddInt(23, BaseProbability, -1); }
  public static void AddEAddProbability(FlatBufferBuilder builder, int EAddProbability) { builder.AddInt(24, EAddProbability, -1); }
  public static Offset<FB_ActivityAncientSealSearch> EndFB_ActivityAncientSealSearch(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityAncientSealSearch>(o);
  }
};

public sealed class FB_ActivityAncientSealSearchContainer : Table {
  public static FB_ActivityAncientSealSearchContainer GetRootAsFB_ActivityAncientSealSearchContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityAncientSealSearchContainer(_bb, new FB_ActivityAncientSealSearchContainer()); }
  public static FB_ActivityAncientSealSearchContainer GetRootAsFB_ActivityAncientSealSearchContainer(ByteBuffer _bb, FB_ActivityAncientSealSearchContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityAncientSealSearchContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityAncientSealSearchContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityAncientSealSearch GetItems(int j) { return GetItems(new FB_ActivityAncientSealSearch(), j); }
  public FB_ActivityAncientSealSearch GetItems(FB_ActivityAncientSealSearch obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityAncientSealSearchContainer> CreateFB_ActivityAncientSealSearchContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityAncientSealSearchContainer.AddItems(builder, items);
    return FB_ActivityAncientSealSearchContainer.EndFB_ActivityAncientSealSearchContainer(builder);
  }

  public static void StartFB_ActivityAncientSealSearchContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityAncientSealSearch>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityAncientSealSearchContainer> EndFB_ActivityAncientSealSearchContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityAncientSealSearchContainer>(o);
  }
  public static void FinishFB_ActivityAncientSealSearchContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityAncientSealSearchContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
