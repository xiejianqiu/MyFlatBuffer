// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TitleClass : Table {
  public static FB_TitleClass GetRootAsFB_TitleClass(ByteBuffer _bb) { return GetRootAsFB_TitleClass(_bb, new FB_TitleClass()); }
  public static FB_TitleClass GetRootAsFB_TitleClass(ByteBuffer _bb, FB_TitleClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TitleClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TitleNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetTitleIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TitleIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TitleClass> CreateFB_TitleClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int TitleNum = -1,
      VectorOffset TitleIDList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_TitleClass.AddTitleIDList(builder, TitleIDList);
    FB_TitleClass.AddTitleNum(builder, TitleNum);
    FB_TitleClass.AddName(builder, Name);
    FB_TitleClass.AddID(builder, ID);
    return FB_TitleClass.EndFB_TitleClass(builder);
  }

  public static void StartFB_TitleClass(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTitleNum(FlatBufferBuilder builder, int TitleNum) { builder.AddInt(2, TitleNum, -1); }
  public static void AddTitleIDList(FlatBufferBuilder builder, VectorOffset TitleIDListOffset) { builder.AddOffset(3, TitleIDListOffset.Value, 0); }
  public static VectorOffset CreateTitleIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTitleIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TitleClass> EndFB_TitleClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TitleClass>(o);
  }
};

public sealed class FB_TitleClassContainer : Table {
  public static FB_TitleClassContainer GetRootAsFB_TitleClassContainer(ByteBuffer _bb) { return GetRootAsFB_TitleClassContainer(_bb, new FB_TitleClassContainer()); }
  public static FB_TitleClassContainer GetRootAsFB_TitleClassContainer(ByteBuffer _bb, FB_TitleClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TitleClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TitleClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TitleClass GetItems(int j) { return GetItems(new FB_TitleClass(), j); }
  public FB_TitleClass GetItems(FB_TitleClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TitleClassContainer> CreateFB_TitleClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TitleClassContainer.AddItems(builder, items);
    return FB_TitleClassContainer.EndFB_TitleClassContainer(builder);
  }

  public static void StartFB_TitleClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TitleClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TitleClassContainer> EndFB_TitleClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TitleClassContainer>(o);
  }
  public static void FinishFB_TitleClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_TitleClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
