// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CollectActivity : Table {
  public static FB_CollectActivity GetRootAsFB_CollectActivity(ByteBuffer _bb) { return GetRootAsFB_CollectActivity(_bb, new FB_CollectActivity()); }
  public static FB_CollectActivity GetRootAsFB_CollectActivity(ByteBuffer _bb, FB_CollectActivity obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CollectActivity __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DropDescID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetShowItemIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetShowItemNumList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemNumListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int SumItem { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CollectActivity> CreateFB_CollectActivity(FlatBufferBuilder builder,
      int ID = 0,
      int DropDescID = -1,
      VectorOffset ShowItemIDList = default(VectorOffset),
      VectorOffset ShowItemNumList = default(VectorOffset),
      int SumItem = -1) {
    builder.StartObject(5);
    FB_CollectActivity.AddSumItem(builder, SumItem);
    FB_CollectActivity.AddShowItemNumList(builder, ShowItemNumList);
    FB_CollectActivity.AddShowItemIDList(builder, ShowItemIDList);
    FB_CollectActivity.AddDropDescID(builder, DropDescID);
    FB_CollectActivity.AddID(builder, ID);
    return FB_CollectActivity.EndFB_CollectActivity(builder);
  }

  public static void StartFB_CollectActivity(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDropDescID(FlatBufferBuilder builder, int DropDescID) { builder.AddInt(1, DropDescID, -1); }
  public static void AddShowItemIDList(FlatBufferBuilder builder, VectorOffset ShowItemIDListOffset) { builder.AddOffset(2, ShowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateShowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowItemNumList(FlatBufferBuilder builder, VectorOffset ShowItemNumListOffset) { builder.AddOffset(3, ShowItemNumListOffset.Value, 0); }
  public static VectorOffset CreateShowItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSumItem(FlatBufferBuilder builder, int SumItem) { builder.AddInt(4, SumItem, -1); }
  public static Offset<FB_CollectActivity> EndFB_CollectActivity(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CollectActivity>(o);
  }
};

public sealed class FB_CollectActivityContainer : Table {
  public static FB_CollectActivityContainer GetRootAsFB_CollectActivityContainer(ByteBuffer _bb) { return GetRootAsFB_CollectActivityContainer(_bb, new FB_CollectActivityContainer()); }
  public static FB_CollectActivityContainer GetRootAsFB_CollectActivityContainer(ByteBuffer _bb, FB_CollectActivityContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CollectActivityContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CollectActivityContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CollectActivity GetItems(int j) { return GetItems(new FB_CollectActivity(), j); }
  public FB_CollectActivity GetItems(FB_CollectActivity obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CollectActivityContainer> CreateFB_CollectActivityContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CollectActivityContainer.AddItems(builder, items);
    return FB_CollectActivityContainer.EndFB_CollectActivityContainer(builder);
  }

  public static void StartFB_CollectActivityContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CollectActivity>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CollectActivityContainer> EndFB_CollectActivityContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CollectActivityContainer>(o);
  }
  public static void FinishFB_CollectActivityContainerBuffer(FlatBufferBuilder builder, Offset<FB_CollectActivityContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
