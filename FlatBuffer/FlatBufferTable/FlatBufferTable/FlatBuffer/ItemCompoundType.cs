// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ItemCompoundType : Table {
  public static FB_ItemCompoundType GetRootAsFB_ItemCompoundType(ByteBuffer _bb) { return GetRootAsFB_ItemCompoundType(_bb, new FB_ItemCompoundType()); }
  public static FB_ItemCompoundType GetRootAsFB_ItemCompoundType(ByteBuffer _bb, FB_ItemCompoundType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ItemCompoundType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Page { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FirstPage { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SecondPage { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MenPai { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCompoundIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CompoundIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemCompoundType> CreateFB_ItemCompoundType(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Page = -1,
      int FirstPage = -1,
      int SecondPage = -1,
      int MenPai = -1,
      VectorOffset CompoundIDList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_ItemCompoundType.AddCompoundIDList(builder, CompoundIDList);
    FB_ItemCompoundType.AddMenPai(builder, MenPai);
    FB_ItemCompoundType.AddSecondPage(builder, SecondPage);
    FB_ItemCompoundType.AddFirstPage(builder, FirstPage);
    FB_ItemCompoundType.AddPage(builder, Page);
    FB_ItemCompoundType.AddName(builder, Name);
    FB_ItemCompoundType.AddID(builder, ID);
    return FB_ItemCompoundType.EndFB_ItemCompoundType(builder);
  }

  public static void StartFB_ItemCompoundType(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPage(FlatBufferBuilder builder, int Page) { builder.AddInt(2, Page, -1); }
  public static void AddFirstPage(FlatBufferBuilder builder, int FirstPage) { builder.AddInt(3, FirstPage, -1); }
  public static void AddSecondPage(FlatBufferBuilder builder, int SecondPage) { builder.AddInt(4, SecondPage, -1); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(5, MenPai, -1); }
  public static void AddCompoundIDList(FlatBufferBuilder builder, VectorOffset CompoundIDListOffset) { builder.AddOffset(6, CompoundIDListOffset.Value, 0); }
  public static VectorOffset CreateCompoundIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCompoundIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemCompoundType> EndFB_ItemCompoundType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemCompoundType>(o);
  }
};

public sealed class FB_ItemCompoundTypeContainer : Table {
  public static FB_ItemCompoundTypeContainer GetRootAsFB_ItemCompoundTypeContainer(ByteBuffer _bb) { return GetRootAsFB_ItemCompoundTypeContainer(_bb, new FB_ItemCompoundTypeContainer()); }
  public static FB_ItemCompoundTypeContainer GetRootAsFB_ItemCompoundTypeContainer(ByteBuffer _bb, FB_ItemCompoundTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ItemCompoundTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ItemCompoundTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ItemCompoundType GetItems(int j) { return GetItems(new FB_ItemCompoundType(), j); }
  public FB_ItemCompoundType GetItems(FB_ItemCompoundType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemCompoundTypeContainer> CreateFB_ItemCompoundTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ItemCompoundTypeContainer.AddItems(builder, items);
    return FB_ItemCompoundTypeContainer.EndFB_ItemCompoundTypeContainer(builder);
  }

  public static void StartFB_ItemCompoundTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ItemCompoundType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemCompoundTypeContainer> EndFB_ItemCompoundTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemCompoundTypeContainer>(o);
  }
  public static void FinishFB_ItemCompoundTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_ItemCompoundTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
