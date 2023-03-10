// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaCSChapter : Table {
  public static FB_ShenWangZhanJiaCSChapter GetRootAsFB_ShenWangZhanJiaCSChapter(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCSChapter(_bb, new FB_ShenWangZhanJiaCSChapter()); }
  public static FB_ShenWangZhanJiaCSChapter GetRootAsFB_ShenWangZhanJiaCSChapter(ByteBuffer _bb, FB_ShenWangZhanJiaCSChapter obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaCSChapter __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ChapterStr { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ChapterName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ChapterType { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetItemListList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaCSChapter> CreateFB_ShenWangZhanJiaCSChapter(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset ChapterStr = default(StringOffset),
      StringOffset ChapterName = default(StringOffset),
      StringOffset ChapterType = default(StringOffset),
      VectorOffset ItemListList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_ShenWangZhanJiaCSChapter.AddItemListList(builder, ItemListList);
    FB_ShenWangZhanJiaCSChapter.AddChapterType(builder, ChapterType);
    FB_ShenWangZhanJiaCSChapter.AddChapterName(builder, ChapterName);
    FB_ShenWangZhanJiaCSChapter.AddChapterStr(builder, ChapterStr);
    FB_ShenWangZhanJiaCSChapter.AddId(builder, Id);
    return FB_ShenWangZhanJiaCSChapter.EndFB_ShenWangZhanJiaCSChapter(builder);
  }

  public static void StartFB_ShenWangZhanJiaCSChapter(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddChapterStr(FlatBufferBuilder builder, StringOffset ChapterStrOffset) { builder.AddOffset(1, ChapterStrOffset.Value, 0); }
  public static void AddChapterName(FlatBufferBuilder builder, StringOffset ChapterNameOffset) { builder.AddOffset(2, ChapterNameOffset.Value, 0); }
  public static void AddChapterType(FlatBufferBuilder builder, StringOffset ChapterTypeOffset) { builder.AddOffset(3, ChapterTypeOffset.Value, 0); }
  public static void AddItemListList(FlatBufferBuilder builder, VectorOffset ItemListListOffset) { builder.AddOffset(4, ItemListListOffset.Value, 0); }
  public static VectorOffset CreateItemListListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaCSChapter> EndFB_ShenWangZhanJiaCSChapter(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCSChapter>(o);
  }
};

public sealed class FB_ShenWangZhanJiaCSChapterContainer : Table {
  public static FB_ShenWangZhanJiaCSChapterContainer GetRootAsFB_ShenWangZhanJiaCSChapterContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCSChapterContainer(_bb, new FB_ShenWangZhanJiaCSChapterContainer()); }
  public static FB_ShenWangZhanJiaCSChapterContainer GetRootAsFB_ShenWangZhanJiaCSChapterContainer(ByteBuffer _bb, FB_ShenWangZhanJiaCSChapterContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaCSChapterContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaCSChapterContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaCSChapter GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaCSChapter(), j); }
  public FB_ShenWangZhanJiaCSChapter GetItems(FB_ShenWangZhanJiaCSChapter obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaCSChapterContainer> CreateFB_ShenWangZhanJiaCSChapterContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaCSChapterContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaCSChapterContainer.EndFB_ShenWangZhanJiaCSChapterContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaCSChapterContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCSChapter>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaCSChapterContainer> EndFB_ShenWangZhanJiaCSChapterContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCSChapterContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaCSChapterContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCSChapterContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
