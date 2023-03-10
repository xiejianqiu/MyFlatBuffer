// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RunesTreasureBase : Table {
  public static FB_RunesTreasureBase GetRootAsFB_RunesTreasureBase(ByteBuffer _bb) { return GetRootAsFB_RunesTreasureBase(_bb, new FB_RunesTreasureBase()); }
  public static FB_RunesTreasureBase GetRootAsFB_RunesTreasureBase(ByteBuffer _bb, FB_RunesTreasureBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RunesTreasureBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BaseCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MustGetCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AddRandom { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TowerId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetFirstPercent { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RunesTreasureBase> CreateFB_RunesTreasureBase(FlatBufferBuilder builder,
      int ID = 0,
      int BaseCount = 0,
      int MustGetCount = 0,
      int AddRandom = 0,
      int TowerId = 0,
      int GetFirstPercent = 0,
      VectorOffset ItemList = default(VectorOffset),
      VectorOffset WeightList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_RunesTreasureBase.AddWeightList(builder, WeightList);
    FB_RunesTreasureBase.AddItemList(builder, ItemList);
    FB_RunesTreasureBase.AddGetFirstPercent(builder, GetFirstPercent);
    FB_RunesTreasureBase.AddTowerId(builder, TowerId);
    FB_RunesTreasureBase.AddAddRandom(builder, AddRandom);
    FB_RunesTreasureBase.AddMustGetCount(builder, MustGetCount);
    FB_RunesTreasureBase.AddBaseCount(builder, BaseCount);
    FB_RunesTreasureBase.AddID(builder, ID);
    return FB_RunesTreasureBase.EndFB_RunesTreasureBase(builder);
  }

  public static void StartFB_RunesTreasureBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBaseCount(FlatBufferBuilder builder, int BaseCount) { builder.AddInt(1, BaseCount, 0); }
  public static void AddMustGetCount(FlatBufferBuilder builder, int MustGetCount) { builder.AddInt(2, MustGetCount, 0); }
  public static void AddAddRandom(FlatBufferBuilder builder, int AddRandom) { builder.AddInt(3, AddRandom, 0); }
  public static void AddTowerId(FlatBufferBuilder builder, int TowerId) { builder.AddInt(4, TowerId, 0); }
  public static void AddGetFirstPercent(FlatBufferBuilder builder, int GetFirstPercent) { builder.AddInt(5, GetFirstPercent, 0); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(6, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(7, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RunesTreasureBase> EndFB_RunesTreasureBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RunesTreasureBase>(o);
  }
};

public sealed class FB_RunesTreasureBaseContainer : Table {
  public static FB_RunesTreasureBaseContainer GetRootAsFB_RunesTreasureBaseContainer(ByteBuffer _bb) { return GetRootAsFB_RunesTreasureBaseContainer(_bb, new FB_RunesTreasureBaseContainer()); }
  public static FB_RunesTreasureBaseContainer GetRootAsFB_RunesTreasureBaseContainer(ByteBuffer _bb, FB_RunesTreasureBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RunesTreasureBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RunesTreasureBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RunesTreasureBase GetItems(int j) { return GetItems(new FB_RunesTreasureBase(), j); }
  public FB_RunesTreasureBase GetItems(FB_RunesTreasureBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RunesTreasureBaseContainer> CreateFB_RunesTreasureBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RunesTreasureBaseContainer.AddItems(builder, items);
    return FB_RunesTreasureBaseContainer.EndFB_RunesTreasureBaseContainer(builder);
  }

  public static void StartFB_RunesTreasureBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RunesTreasureBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RunesTreasureBaseContainer> EndFB_RunesTreasureBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RunesTreasureBaseContainer>(o);
  }
  public static void FinishFB_RunesTreasureBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_RunesTreasureBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
