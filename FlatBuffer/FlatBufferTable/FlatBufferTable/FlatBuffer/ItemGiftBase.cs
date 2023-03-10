// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ItemGiftBase : Table {
  public static FB_ItemGiftBase GetRootAsFB_ItemGiftBase(ByteBuffer _bb) { return GetRootAsFB_ItemGiftBase(_bb, new FB_ItemGiftBase()); }
  public static FB_ItemGiftBase GetRootAsFB_ItemGiftBase(ByteBuffer _bb, FB_ItemGiftBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ItemGiftBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GiftNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ItemGiftBase> CreateFB_ItemGiftBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      int Param = -1,
      int GiftNum = 0) {
    builder.StartObject(5);
    FB_ItemGiftBase.AddGiftNum(builder, GiftNum);
    FB_ItemGiftBase.AddParam(builder, Param);
    FB_ItemGiftBase.AddType(builder, Type);
    FB_ItemGiftBase.AddName(builder, Name);
    FB_ItemGiftBase.AddId(builder, Id);
    return FB_ItemGiftBase.EndFB_ItemGiftBase(builder);
  }

  public static void StartFB_ItemGiftBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(3, Param, -1); }
  public static void AddGiftNum(FlatBufferBuilder builder, int GiftNum) { builder.AddInt(4, GiftNum, 0); }
  public static Offset<FB_ItemGiftBase> EndFB_ItemGiftBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemGiftBase>(o);
  }
};

public sealed class FB_ItemGiftBaseContainer : Table {
  public static FB_ItemGiftBaseContainer GetRootAsFB_ItemGiftBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ItemGiftBaseContainer(_bb, new FB_ItemGiftBaseContainer()); }
  public static FB_ItemGiftBaseContainer GetRootAsFB_ItemGiftBaseContainer(ByteBuffer _bb, FB_ItemGiftBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ItemGiftBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ItemGiftBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ItemGiftBase GetItems(int j) { return GetItems(new FB_ItemGiftBase(), j); }
  public FB_ItemGiftBase GetItems(FB_ItemGiftBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemGiftBaseContainer> CreateFB_ItemGiftBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ItemGiftBaseContainer.AddItems(builder, items);
    return FB_ItemGiftBaseContainer.EndFB_ItemGiftBaseContainer(builder);
  }

  public static void StartFB_ItemGiftBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ItemGiftBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemGiftBaseContainer> EndFB_ItemGiftBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemGiftBaseContainer>(o);
  }
  public static void FinishFB_ItemGiftBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ItemGiftBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
