// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangJuHun : Table {
  public static FB_HunJiangJuHun GetRootAsFB_HunJiangJuHun(ByteBuffer _bb) { return GetRootAsFB_HunJiangJuHun(_bb, new FB_HunJiangJuHun()); }
  public static FB_HunJiangJuHun GetRootAsFB_HunJiangJuHun(ByteBuffer _bb, FB_HunJiangJuHun obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangJuHun __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnitId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShopItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBoxItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_HunJiangJuHun> CreateFB_HunJiangJuHun(FlatBufferBuilder builder,
      int ID = 0,
      int UnitId = -1,
      int ShopItemId = -1,
      int ItemId = -1,
      int ItemCount = -1,
      int DropBoxItemId = -1,
      int GetItemNum = -1) {
    builder.StartObject(7);
    FB_HunJiangJuHun.AddGetItemNum(builder, GetItemNum);
    FB_HunJiangJuHun.AddDropBoxItemId(builder, DropBoxItemId);
    FB_HunJiangJuHun.AddItemCount(builder, ItemCount);
    FB_HunJiangJuHun.AddItemId(builder, ItemId);
    FB_HunJiangJuHun.AddShopItemId(builder, ShopItemId);
    FB_HunJiangJuHun.AddUnitId(builder, UnitId);
    FB_HunJiangJuHun.AddID(builder, ID);
    return FB_HunJiangJuHun.EndFB_HunJiangJuHun(builder);
  }

  public static void StartFB_HunJiangJuHun(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddUnitId(FlatBufferBuilder builder, int UnitId) { builder.AddInt(1, UnitId, -1); }
  public static void AddShopItemId(FlatBufferBuilder builder, int ShopItemId) { builder.AddInt(2, ShopItemId, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(3, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(4, ItemCount, -1); }
  public static void AddDropBoxItemId(FlatBufferBuilder builder, int DropBoxItemId) { builder.AddInt(5, DropBoxItemId, -1); }
  public static void AddGetItemNum(FlatBufferBuilder builder, int GetItemNum) { builder.AddInt(6, GetItemNum, -1); }
  public static Offset<FB_HunJiangJuHun> EndFB_HunJiangJuHun(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJuHun>(o);
  }
};

public sealed class FB_HunJiangJuHunContainer : Table {
  public static FB_HunJiangJuHunContainer GetRootAsFB_HunJiangJuHunContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangJuHunContainer(_bb, new FB_HunJiangJuHunContainer()); }
  public static FB_HunJiangJuHunContainer GetRootAsFB_HunJiangJuHunContainer(ByteBuffer _bb, FB_HunJiangJuHunContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangJuHunContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangJuHunContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangJuHun GetItems(int j) { return GetItems(new FB_HunJiangJuHun(), j); }
  public FB_HunJiangJuHun GetItems(FB_HunJiangJuHun obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangJuHunContainer> CreateFB_HunJiangJuHunContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangJuHunContainer.AddItems(builder, items);
    return FB_HunJiangJuHunContainer.EndFB_HunJiangJuHunContainer(builder);
  }

  public static void StartFB_HunJiangJuHunContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangJuHun>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangJuHunContainer> EndFB_HunJiangJuHunContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJuHunContainer>(o);
  }
  public static void FinishFB_HunJiangJuHunContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangJuHunContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
