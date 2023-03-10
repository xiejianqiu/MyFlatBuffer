// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CardFlopBase : Table {
  public static FB_CardFlopBase GetRootAsFB_CardFlopBase(ByteBuffer _bb) { return GetRootAsFB_CardFlopBase(_bb, new FB_CardFlopBase()); }
  public static FB_CardFlopBase GetRootAsFB_CardFlopBase(ByteBuffer _bb, FB_CardFlopBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CardFlopBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActiveLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBox { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string CardSpriteName { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_CardFlopBase> CreateFB_CardFlopBase(FlatBufferBuilder builder,
      int Id = 0,
      int ActiveLimit = -1,
      int DropBox = -1,
      StringOffset CardSpriteName = default(StringOffset)) {
    builder.StartObject(4);
    FB_CardFlopBase.AddCardSpriteName(builder, CardSpriteName);
    FB_CardFlopBase.AddDropBox(builder, DropBox);
    FB_CardFlopBase.AddActiveLimit(builder, ActiveLimit);
    FB_CardFlopBase.AddId(builder, Id);
    return FB_CardFlopBase.EndFB_CardFlopBase(builder);
  }

  public static void StartFB_CardFlopBase(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddActiveLimit(FlatBufferBuilder builder, int ActiveLimit) { builder.AddInt(1, ActiveLimit, -1); }
  public static void AddDropBox(FlatBufferBuilder builder, int DropBox) { builder.AddInt(2, DropBox, -1); }
  public static void AddCardSpriteName(FlatBufferBuilder builder, StringOffset CardSpriteNameOffset) { builder.AddOffset(3, CardSpriteNameOffset.Value, 0); }
  public static Offset<FB_CardFlopBase> EndFB_CardFlopBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardFlopBase>(o);
  }
};

public sealed class FB_CardFlopBaseContainer : Table {
  public static FB_CardFlopBaseContainer GetRootAsFB_CardFlopBaseContainer(ByteBuffer _bb) { return GetRootAsFB_CardFlopBaseContainer(_bb, new FB_CardFlopBaseContainer()); }
  public static FB_CardFlopBaseContainer GetRootAsFB_CardFlopBaseContainer(ByteBuffer _bb, FB_CardFlopBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CardFlopBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CardFlopBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CardFlopBase GetItems(int j) { return GetItems(new FB_CardFlopBase(), j); }
  public FB_CardFlopBase GetItems(FB_CardFlopBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardFlopBaseContainer> CreateFB_CardFlopBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CardFlopBaseContainer.AddItems(builder, items);
    return FB_CardFlopBaseContainer.EndFB_CardFlopBaseContainer(builder);
  }

  public static void StartFB_CardFlopBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CardFlopBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardFlopBaseContainer> EndFB_CardFlopBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardFlopBaseContainer>(o);
  }
  public static void FinishFB_CardFlopBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_CardFlopBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
