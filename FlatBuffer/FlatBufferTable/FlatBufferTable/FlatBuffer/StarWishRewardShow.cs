// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarWishRewardShow : Table {
  public static FB_StarWishRewardShow GetRootAsFB_StarWishRewardShow(ByteBuffer _bb) { return GetRootAsFB_StarWishRewardShow(_bb, new FB_StarWishRewardShow()); }
  public static FB_StarWishRewardShow GetRootAsFB_StarWishRewardShow(ByteBuffer _bb, FB_StarWishRewardShow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarWishRewardShow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ModelTypeId { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int ParamSec { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StarWishRewardShow> CreateFB_StarWishRewardShow(FlatBufferBuilder builder,
      int ModelTypeId = 0,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int paramSec = -1) {
    builder.StartObject(4);
    FB_StarWishRewardShow.AddParamSec(builder, paramSec);
    FB_StarWishRewardShow.AddItemNumList(builder, ItemNumList);
    FB_StarWishRewardShow.AddItemIDList(builder, ItemIDList);
    FB_StarWishRewardShow.AddModelTypeId(builder, ModelTypeId);
    return FB_StarWishRewardShow.EndFB_StarWishRewardShow(builder);
  }

  public static void StartFB_StarWishRewardShow(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddModelTypeId(FlatBufferBuilder builder, int ModelTypeId) { builder.AddInt(0, ModelTypeId, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(1, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(2, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParamSec(FlatBufferBuilder builder, int paramSec) { builder.AddInt(3, paramSec, -1); }
  public static Offset<FB_StarWishRewardShow> EndFB_StarWishRewardShow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarWishRewardShow>(o);
  }
};

public sealed class FB_StarWishRewardShowContainer : Table {
  public static FB_StarWishRewardShowContainer GetRootAsFB_StarWishRewardShowContainer(ByteBuffer _bb) { return GetRootAsFB_StarWishRewardShowContainer(_bb, new FB_StarWishRewardShowContainer()); }
  public static FB_StarWishRewardShowContainer GetRootAsFB_StarWishRewardShowContainer(ByteBuffer _bb, FB_StarWishRewardShowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarWishRewardShowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarWishRewardShowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarWishRewardShow GetItems(int j) { return GetItems(new FB_StarWishRewardShow(), j); }
  public FB_StarWishRewardShow GetItems(FB_StarWishRewardShow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarWishRewardShowContainer> CreateFB_StarWishRewardShowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarWishRewardShowContainer.AddItems(builder, items);
    return FB_StarWishRewardShowContainer.EndFB_StarWishRewardShowContainer(builder);
  }

  public static void StartFB_StarWishRewardShowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarWishRewardShow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarWishRewardShowContainer> EndFB_StarWishRewardShowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarWishRewardShowContainer>(o);
  }
  public static void FinishFB_StarWishRewardShowContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarWishRewardShowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
