// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChangeJob6ItemBase : Table {
  public static FB_ChangeJob6ItemBase GetRootAsFB_ChangeJob6ItemBase(ByteBuffer _bb) { return GetRootAsFB_ChangeJob6ItemBase(_bb, new FB_ChangeJob6ItemBase()); }
  public static FB_ChangeJob6ItemBase GetRootAsFB_ChangeJob6ItemBase(ByteBuffer _bb, FB_ChangeJob6ItemBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChangeJob6ItemBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int ItemId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChangeJob6ItemBase> CreateFB_ChangeJob6ItemBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int ItemId = -1,
      int ItemCount = -1) {
    builder.StartObject(6);
    FB_ChangeJob6ItemBase.AddItemCount(builder, ItemCount);
    FB_ChangeJob6ItemBase.AddItemId(builder, ItemId);
    FB_ChangeJob6ItemBase.AddAttrValueList(builder, AttrValueList);
    FB_ChangeJob6ItemBase.AddAttrIdList(builder, AttrIdList);
    FB_ChangeJob6ItemBase.AddName(builder, Name);
    FB_ChangeJob6ItemBase.AddId(builder, Id);
    return FB_ChangeJob6ItemBase.EndFB_ChangeJob6ItemBase(builder);
  }

  public static void StartFB_ChangeJob6ItemBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(4, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(5, ItemCount, -1); }
  public static Offset<FB_ChangeJob6ItemBase> EndFB_ChangeJob6ItemBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJob6ItemBase>(o);
  }
};

public sealed class FB_ChangeJob6ItemBaseContainer : Table {
  public static FB_ChangeJob6ItemBaseContainer GetRootAsFB_ChangeJob6ItemBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ChangeJob6ItemBaseContainer(_bb, new FB_ChangeJob6ItemBaseContainer()); }
  public static FB_ChangeJob6ItemBaseContainer GetRootAsFB_ChangeJob6ItemBaseContainer(ByteBuffer _bb, FB_ChangeJob6ItemBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChangeJob6ItemBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChangeJob6ItemBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChangeJob6ItemBase GetItems(int j) { return GetItems(new FB_ChangeJob6ItemBase(), j); }
  public FB_ChangeJob6ItemBase GetItems(FB_ChangeJob6ItemBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeJob6ItemBaseContainer> CreateFB_ChangeJob6ItemBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChangeJob6ItemBaseContainer.AddItems(builder, items);
    return FB_ChangeJob6ItemBaseContainer.EndFB_ChangeJob6ItemBaseContainer(builder);
  }

  public static void StartFB_ChangeJob6ItemBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChangeJob6ItemBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeJob6ItemBaseContainer> EndFB_ChangeJob6ItemBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJob6ItemBaseContainer>(o);
  }
  public static void FinishFB_ChangeJob6ItemBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChangeJob6ItemBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
