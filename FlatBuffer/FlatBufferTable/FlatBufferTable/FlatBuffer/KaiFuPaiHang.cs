// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KaiFuPaiHang : Table {
  public static FB_KaiFuPaiHang GetRootAsFB_KaiFuPaiHang(ByteBuffer _bb) { return GetRootAsFB_KaiFuPaiHang(_bb, new FB_KaiFuPaiHang()); }
  public static FB_KaiFuPaiHang GetRootAsFB_KaiFuPaiHang(ByteBuffer _bb, FB_KaiFuPaiHang obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KaiFuPaiHang __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRecommendList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RecommendListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetTypeList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TypeListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int ItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string RecommendName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_KaiFuPaiHang> CreateFB_KaiFuPaiHang(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset RecommendList = default(VectorOffset),
      VectorOffset TypeList = default(VectorOffset),
      int ItemId = -1,
      StringOffset RecommendName = default(StringOffset)) {
    builder.StartObject(5);
    FB_KaiFuPaiHang.AddRecommendName(builder, RecommendName);
    FB_KaiFuPaiHang.AddItemId(builder, ItemId);
    FB_KaiFuPaiHang.AddTypeList(builder, TypeList);
    FB_KaiFuPaiHang.AddRecommendList(builder, RecommendList);
    FB_KaiFuPaiHang.AddID(builder, ID);
    return FB_KaiFuPaiHang.EndFB_KaiFuPaiHang(builder);
  }

  public static void StartFB_KaiFuPaiHang(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRecommendList(FlatBufferBuilder builder, VectorOffset RecommendListOffset) { builder.AddOffset(1, RecommendListOffset.Value, 0); }
  public static VectorOffset CreateRecommendListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRecommendListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTypeList(FlatBufferBuilder builder, VectorOffset TypeListOffset) { builder.AddOffset(2, TypeListOffset.Value, 0); }
  public static VectorOffset CreateTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(3, ItemId, -1); }
  public static void AddRecommendName(FlatBufferBuilder builder, StringOffset RecommendNameOffset) { builder.AddOffset(4, RecommendNameOffset.Value, 0); }
  public static Offset<FB_KaiFuPaiHang> EndFB_KaiFuPaiHang(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KaiFuPaiHang>(o);
  }
};

public sealed class FB_KaiFuPaiHangContainer : Table {
  public static FB_KaiFuPaiHangContainer GetRootAsFB_KaiFuPaiHangContainer(ByteBuffer _bb) { return GetRootAsFB_KaiFuPaiHangContainer(_bb, new FB_KaiFuPaiHangContainer()); }
  public static FB_KaiFuPaiHangContainer GetRootAsFB_KaiFuPaiHangContainer(ByteBuffer _bb, FB_KaiFuPaiHangContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KaiFuPaiHangContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KaiFuPaiHangContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KaiFuPaiHang GetItems(int j) { return GetItems(new FB_KaiFuPaiHang(), j); }
  public FB_KaiFuPaiHang GetItems(FB_KaiFuPaiHang obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KaiFuPaiHangContainer> CreateFB_KaiFuPaiHangContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KaiFuPaiHangContainer.AddItems(builder, items);
    return FB_KaiFuPaiHangContainer.EndFB_KaiFuPaiHangContainer(builder);
  }

  public static void StartFB_KaiFuPaiHangContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KaiFuPaiHang>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KaiFuPaiHangContainer> EndFB_KaiFuPaiHangContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KaiFuPaiHangContainer>(o);
  }
  public static void FinishFB_KaiFuPaiHangContainerBuffer(FlatBufferBuilder builder, Offset<FB_KaiFuPaiHangContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
