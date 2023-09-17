// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RongYaoCollectionUpdate : Table {
  public static FB_RongYaoCollectionUpdate GetRootAsFB_RongYaoCollectionUpdate(ByteBuffer _bb) { return GetRootAsFB_RongYaoCollectionUpdate(_bb, new FB_RongYaoCollectionUpdate()); }
  public static FB_RongYaoCollectionUpdate GetRootAsFB_RongYaoCollectionUpdate(ByteBuffer _bb, FB_RongYaoCollectionUpdate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RongYaoCollectionUpdate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int NextId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AwakeId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUpdateItemList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UpdateItemListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUpdateItemNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UpdateItemNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RongYaoCollectionUpdate> CreateFB_RongYaoCollectionUpdate(FlatBufferBuilder builder,
      int Id = 0,
      int NextId = -1,
      int AwakeId = -1,
      VectorOffset UpdateItemList = default(VectorOffset),
      VectorOffset UpdateItemNumList = default(VectorOffset),
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_RongYaoCollectionUpdate.AddAttrValueList(builder, AttrValueList);
    FB_RongYaoCollectionUpdate.AddAttrIDList(builder, AttrIDList);
    FB_RongYaoCollectionUpdate.AddUpdateItemNumList(builder, UpdateItemNumList);
    FB_RongYaoCollectionUpdate.AddUpdateItemList(builder, UpdateItemList);
    FB_RongYaoCollectionUpdate.AddAwakeId(builder, AwakeId);
    FB_RongYaoCollectionUpdate.AddNextId(builder, NextId);
    FB_RongYaoCollectionUpdate.AddId(builder, Id);
    return FB_RongYaoCollectionUpdate.EndFB_RongYaoCollectionUpdate(builder);
  }

  public static void StartFB_RongYaoCollectionUpdate(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddNextId(FlatBufferBuilder builder, int NextId) { builder.AddInt(1, NextId, -1); }
  public static void AddAwakeId(FlatBufferBuilder builder, int AwakeId) { builder.AddInt(2, AwakeId, -1); }
  public static void AddUpdateItemList(FlatBufferBuilder builder, VectorOffset UpdateItemListOffset) { builder.AddOffset(3, UpdateItemListOffset.Value, 0); }
  public static VectorOffset CreateUpdateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUpdateItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUpdateItemNumList(FlatBufferBuilder builder, VectorOffset UpdateItemNumListOffset) { builder.AddOffset(4, UpdateItemNumListOffset.Value, 0); }
  public static VectorOffset CreateUpdateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUpdateItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(5, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RongYaoCollectionUpdate> EndFB_RongYaoCollectionUpdate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RongYaoCollectionUpdate>(o);
  }
};

public sealed class FB_RongYaoCollectionUpdateContainer : Table {
  public static FB_RongYaoCollectionUpdateContainer GetRootAsFB_RongYaoCollectionUpdateContainer(ByteBuffer _bb) { return GetRootAsFB_RongYaoCollectionUpdateContainer(_bb, new FB_RongYaoCollectionUpdateContainer()); }
  public static FB_RongYaoCollectionUpdateContainer GetRootAsFB_RongYaoCollectionUpdateContainer(ByteBuffer _bb, FB_RongYaoCollectionUpdateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RongYaoCollectionUpdateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RongYaoCollectionUpdateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RongYaoCollectionUpdate GetItems(int j) { return GetItems(new FB_RongYaoCollectionUpdate(), j); }
  public FB_RongYaoCollectionUpdate GetItems(FB_RongYaoCollectionUpdate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RongYaoCollectionUpdateContainer> CreateFB_RongYaoCollectionUpdateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RongYaoCollectionUpdateContainer.AddItems(builder, items);
    return FB_RongYaoCollectionUpdateContainer.EndFB_RongYaoCollectionUpdateContainer(builder);
  }

  public static void StartFB_RongYaoCollectionUpdateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RongYaoCollectionUpdate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RongYaoCollectionUpdateContainer> EndFB_RongYaoCollectionUpdateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RongYaoCollectionUpdateContainer>(o);
  }
  public static void FinishFB_RongYaoCollectionUpdateContainerBuffer(FlatBufferBuilder builder, Offset<FB_RongYaoCollectionUpdateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
