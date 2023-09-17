// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanLeXunBao : Table {
  public static FB_HuanLeXunBao GetRootAsFB_HuanLeXunBao(ByteBuffer _bb) { return GetRootAsFB_HuanLeXunBao(_bb, new FB_HuanLeXunBao()); }
  public static FB_HuanLeXunBao GetRootAsFB_HuanLeXunBao(ByteBuffer _bb, FB_HuanLeXunBao obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanLeXunBao __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ModelTypeId { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanLeXunBao> CreateFB_HuanLeXunBao(FlatBufferBuilder builder,
      int ModelTypeId = 0,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_HuanLeXunBao.AddItemNumList(builder, ItemNumList);
    FB_HuanLeXunBao.AddItemIDList(builder, ItemIDList);
    FB_HuanLeXunBao.AddModelTypeId(builder, ModelTypeId);
    return FB_HuanLeXunBao.EndFB_HuanLeXunBao(builder);
  }

  public static void StartFB_HuanLeXunBao(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddModelTypeId(FlatBufferBuilder builder, int ModelTypeId) { builder.AddInt(0, ModelTypeId, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(1, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(2, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanLeXunBao> EndFB_HuanLeXunBao(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanLeXunBao>(o);
  }
};

public sealed class FB_HuanLeXunBaoContainer : Table {
  public static FB_HuanLeXunBaoContainer GetRootAsFB_HuanLeXunBaoContainer(ByteBuffer _bb) { return GetRootAsFB_HuanLeXunBaoContainer(_bb, new FB_HuanLeXunBaoContainer()); }
  public static FB_HuanLeXunBaoContainer GetRootAsFB_HuanLeXunBaoContainer(ByteBuffer _bb, FB_HuanLeXunBaoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanLeXunBaoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanLeXunBaoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanLeXunBao GetItems(int j) { return GetItems(new FB_HuanLeXunBao(), j); }
  public FB_HuanLeXunBao GetItems(FB_HuanLeXunBao obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanLeXunBaoContainer> CreateFB_HuanLeXunBaoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanLeXunBaoContainer.AddItems(builder, items);
    return FB_HuanLeXunBaoContainer.EndFB_HuanLeXunBaoContainer(builder);
  }

  public static void StartFB_HuanLeXunBaoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanLeXunBao>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanLeXunBaoContainer> EndFB_HuanLeXunBaoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanLeXunBaoContainer>(o);
  }
  public static void FinishFB_HuanLeXunBaoContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanLeXunBaoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
