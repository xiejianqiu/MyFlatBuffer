// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MondayLuckDrawBase : Table {
  public static FB_MondayLuckDrawBase GetRootAsFB_MondayLuckDrawBase(ByteBuffer _bb) { return GetRootAsFB_MondayLuckDrawBase(_bb, new FB_MondayLuckDrawBase()); }
  public static FB_MondayLuckDrawBase GetRootAsFB_MondayLuckDrawBase(ByteBuffer _bb, FB_MondayLuckDrawBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MondayLuckDrawBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MondayLuckDrawBase> CreateFB_MondayLuckDrawBase(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_MondayLuckDrawBase.AddItemList(builder, ItemList);
    FB_MondayLuckDrawBase.AddID(builder, ID);
    return FB_MondayLuckDrawBase.EndFB_MondayLuckDrawBase(builder);
  }

  public static void StartFB_MondayLuckDrawBase(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(1, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MondayLuckDrawBase> EndFB_MondayLuckDrawBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MondayLuckDrawBase>(o);
  }
};

public sealed class FB_MondayLuckDrawBaseContainer : Table {
  public static FB_MondayLuckDrawBaseContainer GetRootAsFB_MondayLuckDrawBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MondayLuckDrawBaseContainer(_bb, new FB_MondayLuckDrawBaseContainer()); }
  public static FB_MondayLuckDrawBaseContainer GetRootAsFB_MondayLuckDrawBaseContainer(ByteBuffer _bb, FB_MondayLuckDrawBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MondayLuckDrawBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MondayLuckDrawBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MondayLuckDrawBase GetItems(int j) { return GetItems(new FB_MondayLuckDrawBase(), j); }
  public FB_MondayLuckDrawBase GetItems(FB_MondayLuckDrawBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MondayLuckDrawBaseContainer> CreateFB_MondayLuckDrawBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MondayLuckDrawBaseContainer.AddItems(builder, items);
    return FB_MondayLuckDrawBaseContainer.EndFB_MondayLuckDrawBaseContainer(builder);
  }

  public static void StartFB_MondayLuckDrawBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MondayLuckDrawBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MondayLuckDrawBaseContainer> EndFB_MondayLuckDrawBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MondayLuckDrawBaseContainer>(o);
  }
  public static void FinishFB_MondayLuckDrawBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MondayLuckDrawBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
