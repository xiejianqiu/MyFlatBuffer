// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LadderHonor : Table {
  public static FB_LadderHonor GetRootAsFB_LadderHonor(ByteBuffer _bb) { return GetRootAsFB_LadderHonor(_bb, new FB_LadderHonor()); }
  public static FB_LadderHonor GetRootAsFB_LadderHonor(ByteBuffer _bb, FB_LadderHonor obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LadderHonor __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HonorNeed { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BangYuan { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BangYin { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetIdItemList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int IdItemListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCountItemList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CountItemListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LadderHonor> CreateFB_LadderHonor(FlatBufferBuilder builder,
      int ID = 0,
      int HonorNeed = 0,
      int BangYuan = 0,
      int BangYin = 0,
      VectorOffset IdItemList = default(VectorOffset),
      VectorOffset CountItemList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_LadderHonor.AddCountItemList(builder, CountItemList);
    FB_LadderHonor.AddIdItemList(builder, IdItemList);
    FB_LadderHonor.AddBangYin(builder, BangYin);
    FB_LadderHonor.AddBangYuan(builder, BangYuan);
    FB_LadderHonor.AddHonorNeed(builder, HonorNeed);
    FB_LadderHonor.AddID(builder, ID);
    return FB_LadderHonor.EndFB_LadderHonor(builder);
  }

  public static void StartFB_LadderHonor(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHonorNeed(FlatBufferBuilder builder, int HonorNeed) { builder.AddInt(1, HonorNeed, 0); }
  public static void AddBangYuan(FlatBufferBuilder builder, int BangYuan) { builder.AddInt(2, BangYuan, 0); }
  public static void AddBangYin(FlatBufferBuilder builder, int BangYin) { builder.AddInt(3, BangYin, 0); }
  public static void AddIdItemList(FlatBufferBuilder builder, VectorOffset IdItemListOffset) { builder.AddOffset(4, IdItemListOffset.Value, 0); }
  public static VectorOffset CreateIdItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartIdItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCountItemList(FlatBufferBuilder builder, VectorOffset CountItemListOffset) { builder.AddOffset(5, CountItemListOffset.Value, 0); }
  public static VectorOffset CreateCountItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCountItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LadderHonor> EndFB_LadderHonor(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LadderHonor>(o);
  }
};

public sealed class FB_LadderHonorContainer : Table {
  public static FB_LadderHonorContainer GetRootAsFB_LadderHonorContainer(ByteBuffer _bb) { return GetRootAsFB_LadderHonorContainer(_bb, new FB_LadderHonorContainer()); }
  public static FB_LadderHonorContainer GetRootAsFB_LadderHonorContainer(ByteBuffer _bb, FB_LadderHonorContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LadderHonorContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LadderHonorContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LadderHonor GetItems(int j) { return GetItems(new FB_LadderHonor(), j); }
  public FB_LadderHonor GetItems(FB_LadderHonor obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LadderHonorContainer> CreateFB_LadderHonorContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LadderHonorContainer.AddItems(builder, items);
    return FB_LadderHonorContainer.EndFB_LadderHonorContainer(builder);
  }

  public static void StartFB_LadderHonorContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LadderHonor>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LadderHonorContainer> EndFB_LadderHonorContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LadderHonorContainer>(o);
  }
  public static void FinishFB_LadderHonorContainerBuffer(FlatBufferBuilder builder, Offset<FB_LadderHonorContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
