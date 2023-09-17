// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BagTreasure : Table {
  public static FB_BagTreasure GetRootAsFB_BagTreasure(ByteBuffer _bb) { return GetRootAsFB_BagTreasure(_bb, new FB_BagTreasure()); }
  public static FB_BagTreasure GetRootAsFB_BagTreasure(ByteBuffer _bb, FB_BagTreasure obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BagTreasure __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BagType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetParamList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsBanding { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int LimitType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int VipLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BagTreasure> CreateFB_BagTreasure(FlatBufferBuilder builder,
      int ID = 0,
      int BagType = 0,
      VectorOffset ParamList = default(VectorOffset),
      bool IsBanding = false,
      int LimitType = 0,
      int VipLimit = 0,
      int LevelLimit = 0,
      VectorOffset ItemList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(9);
    FB_BagTreasure.AddItemNumList(builder, ItemNumList);
    FB_BagTreasure.AddItemList(builder, ItemList);
    FB_BagTreasure.AddLevelLimit(builder, LevelLimit);
    FB_BagTreasure.AddVipLimit(builder, VipLimit);
    FB_BagTreasure.AddLimitType(builder, LimitType);
    FB_BagTreasure.AddParamList(builder, ParamList);
    FB_BagTreasure.AddBagType(builder, BagType);
    FB_BagTreasure.AddID(builder, ID);
    FB_BagTreasure.AddIsBanding(builder, IsBanding);
    return FB_BagTreasure.EndFB_BagTreasure(builder);
  }

  public static void StartFB_BagTreasure(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBagType(FlatBufferBuilder builder, int BagType) { builder.AddInt(1, BagType, 0); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(2, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsBanding(FlatBufferBuilder builder, bool IsBanding) { builder.AddBool(3, IsBanding, false); }
  public static void AddLimitType(FlatBufferBuilder builder, int LimitType) { builder.AddInt(4, LimitType, 0); }
  public static void AddVipLimit(FlatBufferBuilder builder, int VipLimit) { builder.AddInt(5, VipLimit, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(6, LevelLimit, 0); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(7, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(8, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BagTreasure> EndFB_BagTreasure(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BagTreasure>(o);
  }
};

public sealed class FB_BagTreasureContainer : Table {
  public static FB_BagTreasureContainer GetRootAsFB_BagTreasureContainer(ByteBuffer _bb) { return GetRootAsFB_BagTreasureContainer(_bb, new FB_BagTreasureContainer()); }
  public static FB_BagTreasureContainer GetRootAsFB_BagTreasureContainer(ByteBuffer _bb, FB_BagTreasureContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BagTreasureContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BagTreasureContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BagTreasure GetItems(int j) { return GetItems(new FB_BagTreasure(), j); }
  public FB_BagTreasure GetItems(FB_BagTreasure obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BagTreasureContainer> CreateFB_BagTreasureContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BagTreasureContainer.AddItems(builder, items);
    return FB_BagTreasureContainer.EndFB_BagTreasureContainer(builder);
  }

  public static void StartFB_BagTreasureContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BagTreasure>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BagTreasureContainer> EndFB_BagTreasureContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BagTreasureContainer>(o);
  }
  public static void FinishFB_BagTreasureContainerBuffer(FlatBufferBuilder builder, Offset<FB_BagTreasureContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
