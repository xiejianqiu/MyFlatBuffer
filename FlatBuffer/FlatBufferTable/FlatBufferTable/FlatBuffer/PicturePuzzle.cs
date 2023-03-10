// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PicturePuzzle : Table {
  public static FB_PicturePuzzle GetRootAsFB_PicturePuzzle(ByteBuffer _bb) { return GetRootAsFB_PicturePuzzle(_bb, new FB_PicturePuzzle()); }
  public static FB_PicturePuzzle GetRootAsFB_PicturePuzzle(ByteBuffer _bb, FB_PicturePuzzle obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PicturePuzzle __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Level { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TimeLinit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ViewLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ViewLimitRate { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GetPictureList(int j) { int o = __offset(12); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int PictureListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPictureWidthList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PictureWidthListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPictureHeightList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PictureHeightListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PicturePuzzle> CreateFB_PicturePuzzle(FlatBufferBuilder builder,
      int Level = 0,
      int TimeLinit = 0,
      int ViewLimit = 0,
      int ViewLimitRate = 0,
      VectorOffset PictureList = default(VectorOffset),
      VectorOffset PictureWidthList = default(VectorOffset),
      VectorOffset PictureHeightList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_PicturePuzzle.AddPictureHeightList(builder, PictureHeightList);
    FB_PicturePuzzle.AddPictureWidthList(builder, PictureWidthList);
    FB_PicturePuzzle.AddPictureList(builder, PictureList);
    FB_PicturePuzzle.AddViewLimitRate(builder, ViewLimitRate);
    FB_PicturePuzzle.AddViewLimit(builder, ViewLimit);
    FB_PicturePuzzle.AddTimeLinit(builder, TimeLinit);
    FB_PicturePuzzle.AddLevel(builder, Level);
    return FB_PicturePuzzle.EndFB_PicturePuzzle(builder);
  }

  public static void StartFB_PicturePuzzle(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(0, Level, 0); }
  public static void AddTimeLinit(FlatBufferBuilder builder, int TimeLinit) { builder.AddInt(1, TimeLinit, 0); }
  public static void AddViewLimit(FlatBufferBuilder builder, int ViewLimit) { builder.AddInt(2, ViewLimit, 0); }
  public static void AddViewLimitRate(FlatBufferBuilder builder, int ViewLimitRate) { builder.AddInt(3, ViewLimitRate, 0); }
  public static void AddPictureList(FlatBufferBuilder builder, VectorOffset PictureListOffset) { builder.AddOffset(4, PictureListOffset.Value, 0); }
  public static VectorOffset CreatePictureListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartPictureListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPictureWidthList(FlatBufferBuilder builder, VectorOffset PictureWidthListOffset) { builder.AddOffset(5, PictureWidthListOffset.Value, 0); }
  public static VectorOffset CreatePictureWidthListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPictureWidthListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPictureHeightList(FlatBufferBuilder builder, VectorOffset PictureHeightListOffset) { builder.AddOffset(6, PictureHeightListOffset.Value, 0); }
  public static VectorOffset CreatePictureHeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPictureHeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PicturePuzzle> EndFB_PicturePuzzle(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PicturePuzzle>(o);
  }
};

public sealed class FB_PicturePuzzleContainer : Table {
  public static FB_PicturePuzzleContainer GetRootAsFB_PicturePuzzleContainer(ByteBuffer _bb) { return GetRootAsFB_PicturePuzzleContainer(_bb, new FB_PicturePuzzleContainer()); }
  public static FB_PicturePuzzleContainer GetRootAsFB_PicturePuzzleContainer(ByteBuffer _bb, FB_PicturePuzzleContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PicturePuzzleContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PicturePuzzleContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PicturePuzzle GetItems(int j) { return GetItems(new FB_PicturePuzzle(), j); }
  public FB_PicturePuzzle GetItems(FB_PicturePuzzle obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PicturePuzzleContainer> CreateFB_PicturePuzzleContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PicturePuzzleContainer.AddItems(builder, items);
    return FB_PicturePuzzleContainer.EndFB_PicturePuzzleContainer(builder);
  }

  public static void StartFB_PicturePuzzleContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PicturePuzzle>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PicturePuzzleContainer> EndFB_PicturePuzzleContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PicturePuzzleContainer>(o);
  }
  public static void FinishFB_PicturePuzzleContainerBuffer(FlatBufferBuilder builder, Offset<FB_PicturePuzzleContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
