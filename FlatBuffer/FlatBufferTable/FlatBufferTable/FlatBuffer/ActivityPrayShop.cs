// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityPrayShop : Table {
  public static FB_ActivityPrayShop GetRootAsFB_ActivityPrayShop(ByteBuffer _bb) { return GetRootAsFB_ActivityPrayShop(_bb, new FB_ActivityPrayShop()); }
  public static FB_ActivityPrayShop GetRootAsFB_ActivityPrayShop(ByteBuffer _bb, FB_ActivityPrayShop obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityPrayShop __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TriggerId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMin { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WorldLvMax { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetChangeItemList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ChangeItemListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostNumList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostNumListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLimitList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LimitListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityPrayShop> CreateFB_ActivityPrayShop(FlatBufferBuilder builder,
      int Id = 0,
      int TriggerId = -1,
      int WorldLvMin = -1,
      int WorldLvMax = -1,
      VectorOffset ChangeItemList = default(VectorOffset),
      VectorOffset CostNumList = default(VectorOffset),
      VectorOffset LimitList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_ActivityPrayShop.AddLimitList(builder, LimitList);
    FB_ActivityPrayShop.AddCostNumList(builder, CostNumList);
    FB_ActivityPrayShop.AddChangeItemList(builder, ChangeItemList);
    FB_ActivityPrayShop.AddWorldLvMax(builder, WorldLvMax);
    FB_ActivityPrayShop.AddWorldLvMin(builder, WorldLvMin);
    FB_ActivityPrayShop.AddTriggerId(builder, TriggerId);
    FB_ActivityPrayShop.AddId(builder, Id);
    return FB_ActivityPrayShop.EndFB_ActivityPrayShop(builder);
  }

  public static void StartFB_ActivityPrayShop(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTriggerId(FlatBufferBuilder builder, int TriggerId) { builder.AddInt(1, TriggerId, -1); }
  public static void AddWorldLvMin(FlatBufferBuilder builder, int WorldLvMin) { builder.AddInt(2, WorldLvMin, -1); }
  public static void AddWorldLvMax(FlatBufferBuilder builder, int WorldLvMax) { builder.AddInt(3, WorldLvMax, -1); }
  public static void AddChangeItemList(FlatBufferBuilder builder, VectorOffset ChangeItemListOffset) { builder.AddOffset(4, ChangeItemListOffset.Value, 0); }
  public static VectorOffset CreateChangeItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartChangeItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostNumList(FlatBufferBuilder builder, VectorOffset CostNumListOffset) { builder.AddOffset(5, CostNumListOffset.Value, 0); }
  public static VectorOffset CreateCostNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLimitList(FlatBufferBuilder builder, VectorOffset LimitListOffset) { builder.AddOffset(6, LimitListOffset.Value, 0); }
  public static VectorOffset CreateLimitListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLimitListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityPrayShop> EndFB_ActivityPrayShop(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPrayShop>(o);
  }
};

public sealed class FB_ActivityPrayShopContainer : Table {
  public static FB_ActivityPrayShopContainer GetRootAsFB_ActivityPrayShopContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityPrayShopContainer(_bb, new FB_ActivityPrayShopContainer()); }
  public static FB_ActivityPrayShopContainer GetRootAsFB_ActivityPrayShopContainer(ByteBuffer _bb, FB_ActivityPrayShopContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityPrayShopContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityPrayShopContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityPrayShop GetItems(int j) { return GetItems(new FB_ActivityPrayShop(), j); }
  public FB_ActivityPrayShop GetItems(FB_ActivityPrayShop obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityPrayShopContainer> CreateFB_ActivityPrayShopContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityPrayShopContainer.AddItems(builder, items);
    return FB_ActivityPrayShopContainer.EndFB_ActivityPrayShopContainer(builder);
  }

  public static void StartFB_ActivityPrayShopContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityPrayShop>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityPrayShopContainer> EndFB_ActivityPrayShopContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPrayShopContainer>(o);
  }
  public static void FinishFB_ActivityPrayShopContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityPrayShopContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
