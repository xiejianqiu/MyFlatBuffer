// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AuctionClass : Table {
  public static FB_AuctionClass GetRootAsFB_AuctionClass(ByteBuffer _bb) { return GetRootAsFB_AuctionClass(_bb, new FB_AuctionClass()); }
  public static FB_AuctionClass GetRootAsFB_AuctionClass(ByteBuffer _bb, FB_AuctionClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AuctionClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsRare { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetTypeList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TypeListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AuctionClass> CreateFB_AuctionClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      bool IsRare = false,
      VectorOffset TypeList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_AuctionClass.AddTypeList(builder, TypeList);
    FB_AuctionClass.AddName(builder, Name);
    FB_AuctionClass.AddID(builder, ID);
    FB_AuctionClass.AddIsRare(builder, IsRare);
    return FB_AuctionClass.EndFB_AuctionClass(builder);
  }

  public static void StartFB_AuctionClass(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIsRare(FlatBufferBuilder builder, bool IsRare) { builder.AddBool(2, IsRare, false); }
  public static void AddTypeList(FlatBufferBuilder builder, VectorOffset TypeListOffset) { builder.AddOffset(3, TypeListOffset.Value, 0); }
  public static VectorOffset CreateTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AuctionClass> EndFB_AuctionClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AuctionClass>(o);
  }
};

public sealed class FB_AuctionClassContainer : Table {
  public static FB_AuctionClassContainer GetRootAsFB_AuctionClassContainer(ByteBuffer _bb) { return GetRootAsFB_AuctionClassContainer(_bb, new FB_AuctionClassContainer()); }
  public static FB_AuctionClassContainer GetRootAsFB_AuctionClassContainer(ByteBuffer _bb, FB_AuctionClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AuctionClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AuctionClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AuctionClass GetItems(int j) { return GetItems(new FB_AuctionClass(), j); }
  public FB_AuctionClass GetItems(FB_AuctionClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AuctionClassContainer> CreateFB_AuctionClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AuctionClassContainer.AddItems(builder, items);
    return FB_AuctionClassContainer.EndFB_AuctionClassContainer(builder);
  }

  public static void StartFB_AuctionClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AuctionClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AuctionClassContainer> EndFB_AuctionClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AuctionClassContainer>(o);
  }
  public static void FinishFB_AuctionClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_AuctionClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
