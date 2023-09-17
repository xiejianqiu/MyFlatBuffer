// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyBloodItem : Table {
  public static FB_DestinyBloodItem GetRootAsFB_DestinyBloodItem(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodItem(_bb, new FB_DestinyBloodItem()); }
  public static FB_DestinyBloodItem GetRootAsFB_DestinyBloodItem(ByteBuffer _bb, FB_DestinyBloodItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyBloodItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int Max { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DestinyBloodItem> CreateFB_DestinyBloodItem(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int Max = -1) {
    builder.StartObject(4);
    FB_DestinyBloodItem.AddMax(builder, Max);
    FB_DestinyBloodItem.AddAttrValueList(builder, AttrValueList);
    FB_DestinyBloodItem.AddAttrIDList(builder, AttrIDList);
    FB_DestinyBloodItem.AddId(builder, Id);
    return FB_DestinyBloodItem.EndFB_DestinyBloodItem(builder);
  }

  public static void StartFB_DestinyBloodItem(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(1, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(2, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMax(FlatBufferBuilder builder, int Max) { builder.AddInt(3, Max, -1); }
  public static Offset<FB_DestinyBloodItem> EndFB_DestinyBloodItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodItem>(o);
  }
};

public sealed class FB_DestinyBloodItemContainer : Table {
  public static FB_DestinyBloodItemContainer GetRootAsFB_DestinyBloodItemContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodItemContainer(_bb, new FB_DestinyBloodItemContainer()); }
  public static FB_DestinyBloodItemContainer GetRootAsFB_DestinyBloodItemContainer(ByteBuffer _bb, FB_DestinyBloodItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyBloodItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyBloodItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyBloodItem GetItems(int j) { return GetItems(new FB_DestinyBloodItem(), j); }
  public FB_DestinyBloodItem GetItems(FB_DestinyBloodItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBloodItemContainer> CreateFB_DestinyBloodItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyBloodItemContainer.AddItems(builder, items);
    return FB_DestinyBloodItemContainer.EndFB_DestinyBloodItemContainer(builder);
  }

  public static void StartFB_DestinyBloodItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyBloodItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBloodItemContainer> EndFB_DestinyBloodItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodItemContainer>(o);
  }
  public static void FinishFB_DestinyBloodItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyBloodItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
