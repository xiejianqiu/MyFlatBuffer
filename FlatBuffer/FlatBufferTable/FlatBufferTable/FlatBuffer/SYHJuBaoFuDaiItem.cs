// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJuBaoFuDaiItem : Table {
  public static FB_SYHJuBaoFuDaiItem GetRootAsFB_SYHJuBaoFuDaiItem(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoFuDaiItem(_bb, new FB_SYHJuBaoFuDaiItem()); }
  public static FB_SYHJuBaoFuDaiItem GetRootAsFB_SYHJuBaoFuDaiItem(ByteBuffer _bb, FB_SYHJuBaoFuDaiItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJuBaoFuDaiItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemRate { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHJuBaoFuDaiItem> CreateFB_SYHJuBaoFuDaiItem(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      int ItemRate = -1) {
    builder.StartObject(3);
    FB_SYHJuBaoFuDaiItem.AddItemRate(builder, ItemRate);
    FB_SYHJuBaoFuDaiItem.AddType(builder, Type);
    FB_SYHJuBaoFuDaiItem.AddID(builder, ID);
    return FB_SYHJuBaoFuDaiItem.EndFB_SYHJuBaoFuDaiItem(builder);
  }

  public static void StartFB_SYHJuBaoFuDaiItem(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddItemRate(FlatBufferBuilder builder, int ItemRate) { builder.AddInt(2, ItemRate, -1); }
  public static Offset<FB_SYHJuBaoFuDaiItem> EndFB_SYHJuBaoFuDaiItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoFuDaiItem>(o);
  }
};

public sealed class FB_SYHJuBaoFuDaiItemContainer : Table {
  public static FB_SYHJuBaoFuDaiItemContainer GetRootAsFB_SYHJuBaoFuDaiItemContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoFuDaiItemContainer(_bb, new FB_SYHJuBaoFuDaiItemContainer()); }
  public static FB_SYHJuBaoFuDaiItemContainer GetRootAsFB_SYHJuBaoFuDaiItemContainer(ByteBuffer _bb, FB_SYHJuBaoFuDaiItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJuBaoFuDaiItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJuBaoFuDaiItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJuBaoFuDaiItem GetItems(int j) { return GetItems(new FB_SYHJuBaoFuDaiItem(), j); }
  public FB_SYHJuBaoFuDaiItem GetItems(FB_SYHJuBaoFuDaiItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoFuDaiItemContainer> CreateFB_SYHJuBaoFuDaiItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJuBaoFuDaiItemContainer.AddItems(builder, items);
    return FB_SYHJuBaoFuDaiItemContainer.EndFB_SYHJuBaoFuDaiItemContainer(builder);
  }

  public static void StartFB_SYHJuBaoFuDaiItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJuBaoFuDaiItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoFuDaiItemContainer> EndFB_SYHJuBaoFuDaiItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoFuDaiItemContainer>(o);
  }
  public static void FinishFB_SYHJuBaoFuDaiItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJuBaoFuDaiItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
