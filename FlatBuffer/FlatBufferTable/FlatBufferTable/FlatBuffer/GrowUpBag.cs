// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GrowUpBag : Table {
  public static FB_GrowUpBag GetRootAsFB_GrowUpBag(ByteBuffer _bb) { return GetRootAsFB_GrowUpBag(_bb, new FB_GrowUpBag()); }
  public static FB_GrowUpBag GetRootAsFB_GrowUpBag(ByteBuffer _bb, FB_GrowUpBag obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GrowUpBag __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Days { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ConsumeMoney { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int AddBuff { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GrowUpBag> CreateFB_GrowUpBag(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      int Days = -1,
      int ConsumeMoney = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int AddBuff = -1) {
    builder.StartObject(7);
    FB_GrowUpBag.AddAddBuff(builder, AddBuff);
    FB_GrowUpBag.AddItemNumList(builder, ItemNumList);
    FB_GrowUpBag.AddItemIDList(builder, ItemIDList);
    FB_GrowUpBag.AddConsumeMoney(builder, ConsumeMoney);
    FB_GrowUpBag.AddDays(builder, Days);
    FB_GrowUpBag.AddType(builder, Type);
    FB_GrowUpBag.AddID(builder, ID);
    return FB_GrowUpBag.EndFB_GrowUpBag(builder);
  }

  public static void StartFB_GrowUpBag(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddDays(FlatBufferBuilder builder, int Days) { builder.AddInt(2, Days, -1); }
  public static void AddConsumeMoney(FlatBufferBuilder builder, int ConsumeMoney) { builder.AddInt(3, ConsumeMoney, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(4, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(5, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAddBuff(FlatBufferBuilder builder, int AddBuff) { builder.AddInt(6, AddBuff, -1); }
  public static Offset<FB_GrowUpBag> EndFB_GrowUpBag(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GrowUpBag>(o);
  }
};

public sealed class FB_GrowUpBagContainer : Table {
  public static FB_GrowUpBagContainer GetRootAsFB_GrowUpBagContainer(ByteBuffer _bb) { return GetRootAsFB_GrowUpBagContainer(_bb, new FB_GrowUpBagContainer()); }
  public static FB_GrowUpBagContainer GetRootAsFB_GrowUpBagContainer(ByteBuffer _bb, FB_GrowUpBagContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GrowUpBagContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GrowUpBagContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GrowUpBag GetItems(int j) { return GetItems(new FB_GrowUpBag(), j); }
  public FB_GrowUpBag GetItems(FB_GrowUpBag obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GrowUpBagContainer> CreateFB_GrowUpBagContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GrowUpBagContainer.AddItems(builder, items);
    return FB_GrowUpBagContainer.EndFB_GrowUpBagContainer(builder);
  }

  public static void StartFB_GrowUpBagContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GrowUpBag>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GrowUpBagContainer> EndFB_GrowUpBagContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GrowUpBagContainer>(o);
  }
  public static void FinishFB_GrowUpBagContainerBuffer(FlatBufferBuilder builder, Offset<FB_GrowUpBagContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
