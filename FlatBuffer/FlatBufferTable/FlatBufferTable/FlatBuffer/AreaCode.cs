// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AreaCode : Table {
  public static FB_AreaCode GetRootAsFB_AreaCode(ByteBuffer _bb) { return GetRootAsFB_AreaCode(_bb, new FB_AreaCode()); }
  public static FB_AreaCode GetRootAsFB_AreaCode(ByteBuffer _bb, FB_AreaCode obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AreaCode __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FrontNumber { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_AreaCode> CreateFB_AreaCode(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int FrontNumber = -1) {
    builder.StartObject(3);
    FB_AreaCode.AddFrontNumber(builder, FrontNumber);
    FB_AreaCode.AddName(builder, Name);
    FB_AreaCode.AddId(builder, Id);
    return FB_AreaCode.EndFB_AreaCode(builder);
  }

  public static void StartFB_AreaCode(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddFrontNumber(FlatBufferBuilder builder, int FrontNumber) { builder.AddInt(2, FrontNumber, -1); }
  public static Offset<FB_AreaCode> EndFB_AreaCode(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AreaCode>(o);
  }
};

public sealed class FB_AreaCodeContainer : Table {
  public static FB_AreaCodeContainer GetRootAsFB_AreaCodeContainer(ByteBuffer _bb) { return GetRootAsFB_AreaCodeContainer(_bb, new FB_AreaCodeContainer()); }
  public static FB_AreaCodeContainer GetRootAsFB_AreaCodeContainer(ByteBuffer _bb, FB_AreaCodeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AreaCodeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AreaCodeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AreaCode GetItems(int j) { return GetItems(new FB_AreaCode(), j); }
  public FB_AreaCode GetItems(FB_AreaCode obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AreaCodeContainer> CreateFB_AreaCodeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AreaCodeContainer.AddItems(builder, items);
    return FB_AreaCodeContainer.EndFB_AreaCodeContainer(builder);
  }

  public static void StartFB_AreaCodeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AreaCode>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AreaCodeContainer> EndFB_AreaCodeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AreaCodeContainer>(o);
  }
  public static void FinishFB_AreaCodeContainerBuffer(FlatBufferBuilder builder, Offset<FB_AreaCodeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
