// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShieldString : Table {
  public static FB_ShieldString GetRootAsFB_ShieldString(ByteBuffer _bb) { return GetRootAsFB_ShieldString(_bb, new FB_ShieldString()); }
  public static FB_ShieldString GetRootAsFB_ShieldString(ByteBuffer _bb, FB_ShieldString obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShieldString __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ShieldStr { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_ShieldString> CreateFB_ShieldString(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset ShieldStr = default(StringOffset)) {
    builder.StartObject(2);
    FB_ShieldString.AddShieldStr(builder, ShieldStr);
    FB_ShieldString.AddId(builder, Id);
    return FB_ShieldString.EndFB_ShieldString(builder);
  }

  public static void StartFB_ShieldString(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddShieldStr(FlatBufferBuilder builder, StringOffset ShieldStrOffset) { builder.AddOffset(1, ShieldStrOffset.Value, 0); }
  public static Offset<FB_ShieldString> EndFB_ShieldString(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShieldString>(o);
  }
};

public sealed class FB_ShieldStringContainer : Table {
  public static FB_ShieldStringContainer GetRootAsFB_ShieldStringContainer(ByteBuffer _bb) { return GetRootAsFB_ShieldStringContainer(_bb, new FB_ShieldStringContainer()); }
  public static FB_ShieldStringContainer GetRootAsFB_ShieldStringContainer(ByteBuffer _bb, FB_ShieldStringContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShieldStringContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShieldStringContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShieldString GetItems(int j) { return GetItems(new FB_ShieldString(), j); }
  public FB_ShieldString GetItems(FB_ShieldString obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShieldStringContainer> CreateFB_ShieldStringContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShieldStringContainer.AddItems(builder, items);
    return FB_ShieldStringContainer.EndFB_ShieldStringContainer(builder);
  }

  public static void StartFB_ShieldStringContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShieldString>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShieldStringContainer> EndFB_ShieldStringContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShieldStringContainer>(o);
  }
  public static void FinishFB_ShieldStringContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShieldStringContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
