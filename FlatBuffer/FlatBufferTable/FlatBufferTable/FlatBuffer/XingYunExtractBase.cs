// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYunExtractBase : Table {
  public static FB_XingYunExtractBase GetRootAsFB_XingYunExtractBase(ByteBuffer _bb) { return GetRootAsFB_XingYunExtractBase(_bb, new FB_XingYunExtractBase()); }
  public static FB_XingYunExtractBase GetRootAsFB_XingYunExtractBase(ByteBuffer _bb, FB_XingYunExtractBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYunExtractBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ExtractId { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ExtraCostTimes { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostMoneyType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostMoneyCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddLuckyValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLuckyValue { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxTotalFortune { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FreeListCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XingYunExtractBase> CreateFB_XingYunExtractBase(FlatBufferBuilder builder,
      int ExtractId = 0,
      int ExtraCostTimes = -1,
      int CostMoneyType = -1,
      int CostMoneyCount = -1,
      int AddLuckyValue = -1,
      int MaxLuckyValue = -1,
      int MaxTotalFortune = -1,
      int FreeListCount = -1) {
    builder.StartObject(8);
    FB_XingYunExtractBase.AddFreeListCount(builder, FreeListCount);
    FB_XingYunExtractBase.AddMaxTotalFortune(builder, MaxTotalFortune);
    FB_XingYunExtractBase.AddMaxLuckyValue(builder, MaxLuckyValue);
    FB_XingYunExtractBase.AddAddLuckyValue(builder, AddLuckyValue);
    FB_XingYunExtractBase.AddCostMoneyCount(builder, CostMoneyCount);
    FB_XingYunExtractBase.AddCostMoneyType(builder, CostMoneyType);
    FB_XingYunExtractBase.AddExtraCostTimes(builder, ExtraCostTimes);
    FB_XingYunExtractBase.AddExtractId(builder, ExtractId);
    return FB_XingYunExtractBase.EndFB_XingYunExtractBase(builder);
  }

  public static void StartFB_XingYunExtractBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddExtractId(FlatBufferBuilder builder, int ExtractId) { builder.AddInt(0, ExtractId, 0); }
  public static void AddExtraCostTimes(FlatBufferBuilder builder, int ExtraCostTimes) { builder.AddInt(1, ExtraCostTimes, -1); }
  public static void AddCostMoneyType(FlatBufferBuilder builder, int CostMoneyType) { builder.AddInt(2, CostMoneyType, -1); }
  public static void AddCostMoneyCount(FlatBufferBuilder builder, int CostMoneyCount) { builder.AddInt(3, CostMoneyCount, -1); }
  public static void AddAddLuckyValue(FlatBufferBuilder builder, int AddLuckyValue) { builder.AddInt(4, AddLuckyValue, -1); }
  public static void AddMaxLuckyValue(FlatBufferBuilder builder, int MaxLuckyValue) { builder.AddInt(5, MaxLuckyValue, -1); }
  public static void AddMaxTotalFortune(FlatBufferBuilder builder, int MaxTotalFortune) { builder.AddInt(6, MaxTotalFortune, -1); }
  public static void AddFreeListCount(FlatBufferBuilder builder, int FreeListCount) { builder.AddInt(7, FreeListCount, -1); }
  public static Offset<FB_XingYunExtractBase> EndFB_XingYunExtractBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunExtractBase>(o);
  }
};

public sealed class FB_XingYunExtractBaseContainer : Table {
  public static FB_XingYunExtractBaseContainer GetRootAsFB_XingYunExtractBaseContainer(ByteBuffer _bb) { return GetRootAsFB_XingYunExtractBaseContainer(_bb, new FB_XingYunExtractBaseContainer()); }
  public static FB_XingYunExtractBaseContainer GetRootAsFB_XingYunExtractBaseContainer(ByteBuffer _bb, FB_XingYunExtractBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYunExtractBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYunExtractBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYunExtractBase GetItems(int j) { return GetItems(new FB_XingYunExtractBase(), j); }
  public FB_XingYunExtractBase GetItems(FB_XingYunExtractBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYunExtractBaseContainer> CreateFB_XingYunExtractBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYunExtractBaseContainer.AddItems(builder, items);
    return FB_XingYunExtractBaseContainer.EndFB_XingYunExtractBaseContainer(builder);
  }

  public static void StartFB_XingYunExtractBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYunExtractBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYunExtractBaseContainer> EndFB_XingYunExtractBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYunExtractBaseContainer>(o);
  }
  public static void FinishFB_XingYunExtractBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYunExtractBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
