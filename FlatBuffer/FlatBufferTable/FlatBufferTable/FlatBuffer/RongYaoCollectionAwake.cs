// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RongYaoCollectionAwake : Table {
  public static FB_RongYaoCollectionAwake GetRootAsFB_RongYaoCollectionAwake(ByteBuffer _bb) { return GetRootAsFB_RongYaoCollectionAwake(_bb, new FB_RongYaoCollectionAwake()); }
  public static FB_RongYaoCollectionAwake GetRootAsFB_RongYaoCollectionAwake(ByteBuffer _bb, FB_RongYaoCollectionAwake obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RongYaoCollectionAwake __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CollectionId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string DestName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAwakeItemList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AwakeItemListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAwakeItemNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AwakeItemNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFakeObjIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FakeObjIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public string BackGroundBg { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int OpenServerDay { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_RongYaoCollectionAwake> CreateFB_RongYaoCollectionAwake(FlatBufferBuilder builder,
      int Id = 0,
      int CollectionId = -1,
      StringOffset DestName = default(StringOffset),
      VectorOffset AwakeItemList = default(VectorOffset),
      VectorOffset AwakeItemNumList = default(VectorOffset),
      VectorOffset FakeObjIDList = default(VectorOffset),
      StringOffset BackGroundBg = default(StringOffset),
      int OpenServerDay = 0) {
    builder.StartObject(8);
    FB_RongYaoCollectionAwake.AddOpenServerDay(builder, OpenServerDay);
    FB_RongYaoCollectionAwake.AddBackGroundBg(builder, BackGroundBg);
    FB_RongYaoCollectionAwake.AddFakeObjIDList(builder, FakeObjIDList);
    FB_RongYaoCollectionAwake.AddAwakeItemNumList(builder, AwakeItemNumList);
    FB_RongYaoCollectionAwake.AddAwakeItemList(builder, AwakeItemList);
    FB_RongYaoCollectionAwake.AddDestName(builder, DestName);
    FB_RongYaoCollectionAwake.AddCollectionId(builder, CollectionId);
    FB_RongYaoCollectionAwake.AddId(builder, Id);
    return FB_RongYaoCollectionAwake.EndFB_RongYaoCollectionAwake(builder);
  }

  public static void StartFB_RongYaoCollectionAwake(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCollectionId(FlatBufferBuilder builder, int CollectionId) { builder.AddInt(1, CollectionId, -1); }
  public static void AddDestName(FlatBufferBuilder builder, StringOffset DestNameOffset) { builder.AddOffset(2, DestNameOffset.Value, 0); }
  public static void AddAwakeItemList(FlatBufferBuilder builder, VectorOffset AwakeItemListOffset) { builder.AddOffset(3, AwakeItemListOffset.Value, 0); }
  public static VectorOffset CreateAwakeItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAwakeItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAwakeItemNumList(FlatBufferBuilder builder, VectorOffset AwakeItemNumListOffset) { builder.AddOffset(4, AwakeItemNumListOffset.Value, 0); }
  public static VectorOffset CreateAwakeItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAwakeItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFakeObjIDList(FlatBufferBuilder builder, VectorOffset FakeObjIDListOffset) { builder.AddOffset(5, FakeObjIDListOffset.Value, 0); }
  public static VectorOffset CreateFakeObjIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFakeObjIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBackGroundBg(FlatBufferBuilder builder, StringOffset BackGroundBgOffset) { builder.AddOffset(6, BackGroundBgOffset.Value, 0); }
  public static void AddOpenServerDay(FlatBufferBuilder builder, int OpenServerDay) { builder.AddInt(7, OpenServerDay, 0); }
  public static Offset<FB_RongYaoCollectionAwake> EndFB_RongYaoCollectionAwake(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RongYaoCollectionAwake>(o);
  }
};

public sealed class FB_RongYaoCollectionAwakeContainer : Table {
  public static FB_RongYaoCollectionAwakeContainer GetRootAsFB_RongYaoCollectionAwakeContainer(ByteBuffer _bb) { return GetRootAsFB_RongYaoCollectionAwakeContainer(_bb, new FB_RongYaoCollectionAwakeContainer()); }
  public static FB_RongYaoCollectionAwakeContainer GetRootAsFB_RongYaoCollectionAwakeContainer(ByteBuffer _bb, FB_RongYaoCollectionAwakeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RongYaoCollectionAwakeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RongYaoCollectionAwakeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RongYaoCollectionAwake GetItems(int j) { return GetItems(new FB_RongYaoCollectionAwake(), j); }
  public FB_RongYaoCollectionAwake GetItems(FB_RongYaoCollectionAwake obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RongYaoCollectionAwakeContainer> CreateFB_RongYaoCollectionAwakeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RongYaoCollectionAwakeContainer.AddItems(builder, items);
    return FB_RongYaoCollectionAwakeContainer.EndFB_RongYaoCollectionAwakeContainer(builder);
  }

  public static void StartFB_RongYaoCollectionAwakeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RongYaoCollectionAwake>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RongYaoCollectionAwakeContainer> EndFB_RongYaoCollectionAwakeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RongYaoCollectionAwakeContainer>(o);
  }
  public static void FinishFB_RongYaoCollectionAwakeContainerBuffer(FlatBufferBuilder builder, Offset<FB_RongYaoCollectionAwakeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
