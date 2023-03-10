// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryShowItem : Table {
  public static FB_MarryShowItem GetRootAsFB_MarryShowItem(ByteBuffer _bb) { return GetRootAsFB_MarryShowItem(_bb, new FB_MarryShowItem()); }
  public static FB_MarryShowItem GetRootAsFB_MarryShowItem(ByteBuffer _bb, FB_MarryShowItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryShowItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryShowItem> CreateFB_MarryShowItem(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_MarryShowItem.AddItemCountList(builder, ItemCountList);
    FB_MarryShowItem.AddItemIDList(builder, ItemIDList);
    FB_MarryShowItem.AddID(builder, ID);
    return FB_MarryShowItem.EndFB_MarryShowItem(builder);
  }

  public static void StartFB_MarryShowItem(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(1, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(2, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryShowItem> EndFB_MarryShowItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryShowItem>(o);
  }
};

public sealed class FB_MarryShowItemContainer : Table {
  public static FB_MarryShowItemContainer GetRootAsFB_MarryShowItemContainer(ByteBuffer _bb) { return GetRootAsFB_MarryShowItemContainer(_bb, new FB_MarryShowItemContainer()); }
  public static FB_MarryShowItemContainer GetRootAsFB_MarryShowItemContainer(ByteBuffer _bb, FB_MarryShowItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryShowItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryShowItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryShowItem GetItems(int j) { return GetItems(new FB_MarryShowItem(), j); }
  public FB_MarryShowItem GetItems(FB_MarryShowItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryShowItemContainer> CreateFB_MarryShowItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryShowItemContainer.AddItems(builder, items);
    return FB_MarryShowItemContainer.EndFB_MarryShowItemContainer(builder);
  }

  public static void StartFB_MarryShowItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryShowItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryShowItemContainer> EndFB_MarryShowItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryShowItemContainer>(o);
  }
  public static void FinishFB_MarryShowItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryShowItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
