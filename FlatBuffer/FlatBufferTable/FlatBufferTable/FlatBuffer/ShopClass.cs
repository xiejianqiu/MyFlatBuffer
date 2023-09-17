// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShopClass : Table {
  public static FB_ShopClass GetRootAsFB_ShopClass(ByteBuffer _bb) { return GetRootAsFB_ShopClass(_bb, new FB_ShopClass()); }
  public static FB_ShopClass GetRootAsFB_ShopClass(ByteBuffer _bb, FB_ShopClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShopClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetTypeIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TypeIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShopClass> CreateFB_ShopClass(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset TypeIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_ShopClass.AddTypeIDList(builder, TypeIDList);
    FB_ShopClass.AddName(builder, Name);
    FB_ShopClass.AddId(builder, Id);
    return FB_ShopClass.EndFB_ShopClass(builder);
  }

  public static void StartFB_ShopClass(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTypeIDList(FlatBufferBuilder builder, VectorOffset TypeIDListOffset) { builder.AddOffset(2, TypeIDListOffset.Value, 0); }
  public static VectorOffset CreateTypeIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTypeIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShopClass> EndFB_ShopClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShopClass>(o);
  }
};

public sealed class FB_ShopClassContainer : Table {
  public static FB_ShopClassContainer GetRootAsFB_ShopClassContainer(ByteBuffer _bb) { return GetRootAsFB_ShopClassContainer(_bb, new FB_ShopClassContainer()); }
  public static FB_ShopClassContainer GetRootAsFB_ShopClassContainer(ByteBuffer _bb, FB_ShopClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShopClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShopClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShopClass GetItems(int j) { return GetItems(new FB_ShopClass(), j); }
  public FB_ShopClass GetItems(FB_ShopClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShopClassContainer> CreateFB_ShopClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShopClassContainer.AddItems(builder, items);
    return FB_ShopClassContainer.EndFB_ShopClassContainer(builder);
  }

  public static void StartFB_ShopClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShopClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShopClassContainer> EndFB_ShopClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShopClassContainer>(o);
  }
  public static void FinishFB_ShopClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShopClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
