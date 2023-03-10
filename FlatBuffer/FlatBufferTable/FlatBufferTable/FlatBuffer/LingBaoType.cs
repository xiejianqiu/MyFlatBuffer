// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingBaoType : Table {
  public static FB_LingBaoType GetRootAsFB_LingBaoType(ByteBuffer _bb) { return GetRootAsFB_LingBaoType(_bb, new FB_LingBaoType()); }
  public static FB_LingBaoType GetRootAsFB_LingBaoType(ByteBuffer _bb, FB_LingBaoType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingBaoType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BgSpriteName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_LingBaoType> CreateFB_LingBaoType(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset BgSpriteName = default(StringOffset)) {
    builder.StartObject(3);
    FB_LingBaoType.AddBgSpriteName(builder, BgSpriteName);
    FB_LingBaoType.AddName(builder, Name);
    FB_LingBaoType.AddId(builder, Id);
    return FB_LingBaoType.EndFB_LingBaoType(builder);
  }

  public static void StartFB_LingBaoType(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddBgSpriteName(FlatBufferBuilder builder, StringOffset BgSpriteNameOffset) { builder.AddOffset(2, BgSpriteNameOffset.Value, 0); }
  public static Offset<FB_LingBaoType> EndFB_LingBaoType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoType>(o);
  }
};

public sealed class FB_LingBaoTypeContainer : Table {
  public static FB_LingBaoTypeContainer GetRootAsFB_LingBaoTypeContainer(ByteBuffer _bb) { return GetRootAsFB_LingBaoTypeContainer(_bb, new FB_LingBaoTypeContainer()); }
  public static FB_LingBaoTypeContainer GetRootAsFB_LingBaoTypeContainer(ByteBuffer _bb, FB_LingBaoTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingBaoTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingBaoTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingBaoType GetItems(int j) { return GetItems(new FB_LingBaoType(), j); }
  public FB_LingBaoType GetItems(FB_LingBaoType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingBaoTypeContainer> CreateFB_LingBaoTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingBaoTypeContainer.AddItems(builder, items);
    return FB_LingBaoTypeContainer.EndFB_LingBaoTypeContainer(builder);
  }

  public static void StartFB_LingBaoTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingBaoType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingBaoTypeContainer> EndFB_LingBaoTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoTypeContainer>(o);
  }
  public static void FinishFB_LingBaoTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingBaoTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
