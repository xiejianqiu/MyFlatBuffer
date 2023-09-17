// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJuBaoFuDaiBase : Table {
  public static FB_SYHJuBaoFuDaiBase GetRootAsFB_SYHJuBaoFuDaiBase(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoFuDaiBase(_bb, new FB_SYHJuBaoFuDaiBase()); }
  public static FB_SYHJuBaoFuDaiBase GetRootAsFB_SYHJuBaoFuDaiBase(ByteBuffer _bb, FB_SYHJuBaoFuDaiBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJuBaoFuDaiBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoFuDaiBase> CreateFB_SYHJuBaoFuDaiBase(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_SYHJuBaoFuDaiBase.AddItemList(builder, ItemList);
    FB_SYHJuBaoFuDaiBase.AddID(builder, ID);
    return FB_SYHJuBaoFuDaiBase.EndFB_SYHJuBaoFuDaiBase(builder);
  }

  public static void StartFB_SYHJuBaoFuDaiBase(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(1, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoFuDaiBase> EndFB_SYHJuBaoFuDaiBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoFuDaiBase>(o);
  }
};

public sealed class FB_SYHJuBaoFuDaiBaseContainer : Table {
  public static FB_SYHJuBaoFuDaiBaseContainer GetRootAsFB_SYHJuBaoFuDaiBaseContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoFuDaiBaseContainer(_bb, new FB_SYHJuBaoFuDaiBaseContainer()); }
  public static FB_SYHJuBaoFuDaiBaseContainer GetRootAsFB_SYHJuBaoFuDaiBaseContainer(ByteBuffer _bb, FB_SYHJuBaoFuDaiBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJuBaoFuDaiBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJuBaoFuDaiBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJuBaoFuDaiBase GetItems(int j) { return GetItems(new FB_SYHJuBaoFuDaiBase(), j); }
  public FB_SYHJuBaoFuDaiBase GetItems(FB_SYHJuBaoFuDaiBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoFuDaiBaseContainer> CreateFB_SYHJuBaoFuDaiBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJuBaoFuDaiBaseContainer.AddItems(builder, items);
    return FB_SYHJuBaoFuDaiBaseContainer.EndFB_SYHJuBaoFuDaiBaseContainer(builder);
  }

  public static void StartFB_SYHJuBaoFuDaiBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJuBaoFuDaiBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoFuDaiBaseContainer> EndFB_SYHJuBaoFuDaiBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoFuDaiBaseContainer>(o);
  }
  public static void FinishFB_SYHJuBaoFuDaiBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJuBaoFuDaiBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
