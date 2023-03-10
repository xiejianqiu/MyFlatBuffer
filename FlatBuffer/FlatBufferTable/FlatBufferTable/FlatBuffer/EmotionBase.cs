// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EmotionBase : Table {
  public static FB_EmotionBase GetRootAsFB_EmotionBase(ByteBuffer _bb) { return GetRootAsFB_EmotionBase(_bb, new FB_EmotionBase()); }
  public static FB_EmotionBase GetRootAsFB_EmotionBase(ByteBuffer _bb, FB_EmotionBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EmotionBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Class { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string SpriteName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_EmotionBase> CreateFB_EmotionBase(FlatBufferBuilder builder,
      int ID = 0,
      int Class = -1,
      StringOffset SpriteName = default(StringOffset),
      StringOffset Name = default(StringOffset)) {
    builder.StartObject(4);
    FB_EmotionBase.AddName(builder, Name);
    FB_EmotionBase.AddSpriteName(builder, SpriteName);
    FB_EmotionBase.AddClass(builder, Class);
    FB_EmotionBase.AddID(builder, ID);
    return FB_EmotionBase.EndFB_EmotionBase(builder);
  }

  public static void StartFB_EmotionBase(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddClass(FlatBufferBuilder builder, int Class) { builder.AddInt(1, Class, -1); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset SpriteNameOffset) { builder.AddOffset(2, SpriteNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(3, NameOffset.Value, 0); }
  public static Offset<FB_EmotionBase> EndFB_EmotionBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EmotionBase>(o);
  }
};

public sealed class FB_EmotionBaseContainer : Table {
  public static FB_EmotionBaseContainer GetRootAsFB_EmotionBaseContainer(ByteBuffer _bb) { return GetRootAsFB_EmotionBaseContainer(_bb, new FB_EmotionBaseContainer()); }
  public static FB_EmotionBaseContainer GetRootAsFB_EmotionBaseContainer(ByteBuffer _bb, FB_EmotionBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EmotionBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EmotionBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EmotionBase GetItems(int j) { return GetItems(new FB_EmotionBase(), j); }
  public FB_EmotionBase GetItems(FB_EmotionBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EmotionBaseContainer> CreateFB_EmotionBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EmotionBaseContainer.AddItems(builder, items);
    return FB_EmotionBaseContainer.EndFB_EmotionBaseContainer(builder);
  }

  public static void StartFB_EmotionBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EmotionBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EmotionBaseContainer> EndFB_EmotionBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EmotionBaseContainer>(o);
  }
  public static void FinishFB_EmotionBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_EmotionBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
