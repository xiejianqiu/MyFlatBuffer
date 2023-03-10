// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShieldingSymbol : Table {
  public static FB_ShieldingSymbol GetRootAsFB_ShieldingSymbol(ByteBuffer _bb) { return GetRootAsFB_ShieldingSymbol(_bb, new FB_ShieldingSymbol()); }
  public static FB_ShieldingSymbol GetRootAsFB_ShieldingSymbol(ByteBuffer _bb, FB_ShieldingSymbol obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShieldingSymbol __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string StrSymbol { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_ShieldingSymbol> CreateFB_ShieldingSymbol(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset StrSymbol = default(StringOffset)) {
    builder.StartObject(2);
    FB_ShieldingSymbol.AddStrSymbol(builder, StrSymbol);
    FB_ShieldingSymbol.AddId(builder, Id);
    return FB_ShieldingSymbol.EndFB_ShieldingSymbol(builder);
  }

  public static void StartFB_ShieldingSymbol(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStrSymbol(FlatBufferBuilder builder, StringOffset StrSymbolOffset) { builder.AddOffset(1, StrSymbolOffset.Value, 0); }
  public static Offset<FB_ShieldingSymbol> EndFB_ShieldingSymbol(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShieldingSymbol>(o);
  }
};

public sealed class FB_ShieldingSymbolContainer : Table {
  public static FB_ShieldingSymbolContainer GetRootAsFB_ShieldingSymbolContainer(ByteBuffer _bb) { return GetRootAsFB_ShieldingSymbolContainer(_bb, new FB_ShieldingSymbolContainer()); }
  public static FB_ShieldingSymbolContainer GetRootAsFB_ShieldingSymbolContainer(ByteBuffer _bb, FB_ShieldingSymbolContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShieldingSymbolContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShieldingSymbolContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShieldingSymbol GetItems(int j) { return GetItems(new FB_ShieldingSymbol(), j); }
  public FB_ShieldingSymbol GetItems(FB_ShieldingSymbol obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShieldingSymbolContainer> CreateFB_ShieldingSymbolContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShieldingSymbolContainer.AddItems(builder, items);
    return FB_ShieldingSymbolContainer.EndFB_ShieldingSymbolContainer(builder);
  }

  public static void StartFB_ShieldingSymbolContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShieldingSymbol>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShieldingSymbolContainer> EndFB_ShieldingSymbolContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShieldingSymbolContainer>(o);
  }
  public static void FinishFB_ShieldingSymbolContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShieldingSymbolContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
