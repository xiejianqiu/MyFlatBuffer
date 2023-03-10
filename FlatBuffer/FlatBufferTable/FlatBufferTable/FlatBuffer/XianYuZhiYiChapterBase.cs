// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XianYuZhiYiChapterBase : Table {
  public static FB_XianYuZhiYiChapterBase GetRootAsFB_XianYuZhiYiChapterBase(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiChapterBase(_bb, new FB_XianYuZhiYiChapterBase()); }
  public static FB_XianYuZhiYiChapterBase GetRootAsFB_XianYuZhiYiChapterBase(ByteBuffer _bb, FB_XianYuZhiYiChapterBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XianYuZhiYiChapterBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetBookIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BookIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XianYuZhiYiChapterBase> CreateFB_XianYuZhiYiChapterBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset BookIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_XianYuZhiYiChapterBase.AddBookIDList(builder, BookIDList);
    FB_XianYuZhiYiChapterBase.AddName(builder, Name);
    FB_XianYuZhiYiChapterBase.AddID(builder, ID);
    return FB_XianYuZhiYiChapterBase.EndFB_XianYuZhiYiChapterBase(builder);
  }

  public static void StartFB_XianYuZhiYiChapterBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddBookIDList(FlatBufferBuilder builder, VectorOffset BookIDListOffset) { builder.AddOffset(2, BookIDListOffset.Value, 0); }
  public static VectorOffset CreateBookIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBookIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XianYuZhiYiChapterBase> EndFB_XianYuZhiYiChapterBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiChapterBase>(o);
  }
};

public sealed class FB_XianYuZhiYiChapterBaseContainer : Table {
  public static FB_XianYuZhiYiChapterBaseContainer GetRootAsFB_XianYuZhiYiChapterBaseContainer(ByteBuffer _bb) { return GetRootAsFB_XianYuZhiYiChapterBaseContainer(_bb, new FB_XianYuZhiYiChapterBaseContainer()); }
  public static FB_XianYuZhiYiChapterBaseContainer GetRootAsFB_XianYuZhiYiChapterBaseContainer(ByteBuffer _bb, FB_XianYuZhiYiChapterBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XianYuZhiYiChapterBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XianYuZhiYiChapterBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XianYuZhiYiChapterBase GetItems(int j) { return GetItems(new FB_XianYuZhiYiChapterBase(), j); }
  public FB_XianYuZhiYiChapterBase GetItems(FB_XianYuZhiYiChapterBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XianYuZhiYiChapterBaseContainer> CreateFB_XianYuZhiYiChapterBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XianYuZhiYiChapterBaseContainer.AddItems(builder, items);
    return FB_XianYuZhiYiChapterBaseContainer.EndFB_XianYuZhiYiChapterBaseContainer(builder);
  }

  public static void StartFB_XianYuZhiYiChapterBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiChapterBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XianYuZhiYiChapterBaseContainer> EndFB_XianYuZhiYiChapterBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XianYuZhiYiChapterBaseContainer>(o);
  }
  public static void FinishFB_XianYuZhiYiChapterBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_XianYuZhiYiChapterBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
