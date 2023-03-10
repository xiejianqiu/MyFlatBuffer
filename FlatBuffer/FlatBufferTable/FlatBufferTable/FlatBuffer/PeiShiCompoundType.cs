// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PeiShiCompoundType : Table {
  public static FB_PeiShiCompoundType GetRootAsFB_PeiShiCompoundType(ByteBuffer _bb) { return GetRootAsFB_PeiShiCompoundType(_bb, new FB_PeiShiCompoundType()); }
  public static FB_PeiShiCompoundType GetRootAsFB_PeiShiCompoundType(ByteBuffer _bb, FB_PeiShiCompoundType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PeiShiCompoundType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Page { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FirstTab { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SecondTab { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCompoundIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CompoundIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PeiShiCompoundType> CreateFB_PeiShiCompoundType(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Page = -1,
      int FirstTab = -1,
      int SecondTab = -1,
      VectorOffset CompoundIDList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_PeiShiCompoundType.AddCompoundIDList(builder, CompoundIDList);
    FB_PeiShiCompoundType.AddSecondTab(builder, SecondTab);
    FB_PeiShiCompoundType.AddFirstTab(builder, FirstTab);
    FB_PeiShiCompoundType.AddPage(builder, Page);
    FB_PeiShiCompoundType.AddName(builder, Name);
    FB_PeiShiCompoundType.AddID(builder, ID);
    return FB_PeiShiCompoundType.EndFB_PeiShiCompoundType(builder);
  }

  public static void StartFB_PeiShiCompoundType(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPage(FlatBufferBuilder builder, int Page) { builder.AddInt(2, Page, -1); }
  public static void AddFirstTab(FlatBufferBuilder builder, int FirstTab) { builder.AddInt(3, FirstTab, -1); }
  public static void AddSecondTab(FlatBufferBuilder builder, int SecondTab) { builder.AddInt(4, SecondTab, -1); }
  public static void AddCompoundIDList(FlatBufferBuilder builder, VectorOffset CompoundIDListOffset) { builder.AddOffset(5, CompoundIDListOffset.Value, 0); }
  public static VectorOffset CreateCompoundIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCompoundIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PeiShiCompoundType> EndFB_PeiShiCompoundType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PeiShiCompoundType>(o);
  }
};

public sealed class FB_PeiShiCompoundTypeContainer : Table {
  public static FB_PeiShiCompoundTypeContainer GetRootAsFB_PeiShiCompoundTypeContainer(ByteBuffer _bb) { return GetRootAsFB_PeiShiCompoundTypeContainer(_bb, new FB_PeiShiCompoundTypeContainer()); }
  public static FB_PeiShiCompoundTypeContainer GetRootAsFB_PeiShiCompoundTypeContainer(ByteBuffer _bb, FB_PeiShiCompoundTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PeiShiCompoundTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PeiShiCompoundTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PeiShiCompoundType GetItems(int j) { return GetItems(new FB_PeiShiCompoundType(), j); }
  public FB_PeiShiCompoundType GetItems(FB_PeiShiCompoundType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PeiShiCompoundTypeContainer> CreateFB_PeiShiCompoundTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PeiShiCompoundTypeContainer.AddItems(builder, items);
    return FB_PeiShiCompoundTypeContainer.EndFB_PeiShiCompoundTypeContainer(builder);
  }

  public static void StartFB_PeiShiCompoundTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PeiShiCompoundType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PeiShiCompoundTypeContainer> EndFB_PeiShiCompoundTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PeiShiCompoundTypeContainer>(o);
  }
  public static void FinishFB_PeiShiCompoundTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_PeiShiCompoundTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
