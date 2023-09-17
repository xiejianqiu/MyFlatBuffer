// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EmotionClass : Table {
  public static FB_EmotionClass GetRootAsFB_EmotionClass(ByteBuffer _bb) { return GetRootAsFB_EmotionClass(_bb, new FB_EmotionClass()); }
  public static FB_EmotionClass GetRootAsFB_EmotionClass(ByteBuffer _bb, FB_EmotionClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EmotionClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string SpriteName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AvatarPoint { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Class { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sort { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EmotionClass> CreateFB_EmotionClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset SpriteName = default(StringOffset),
      int ItemId = 0,
      int AvatarPoint = -1,
      int Class = -1,
      int Sort = -1) {
    builder.StartObject(6);
    FB_EmotionClass.AddSort(builder, Sort);
    FB_EmotionClass.AddClass(builder, Class);
    FB_EmotionClass.AddAvatarPoint(builder, AvatarPoint);
    FB_EmotionClass.AddItemId(builder, ItemId);
    FB_EmotionClass.AddSpriteName(builder, SpriteName);
    FB_EmotionClass.AddID(builder, ID);
    return FB_EmotionClass.EndFB_EmotionClass(builder);
  }

  public static void StartFB_EmotionClass(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset SpriteNameOffset) { builder.AddOffset(1, SpriteNameOffset.Value, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(2, ItemId, 0); }
  public static void AddAvatarPoint(FlatBufferBuilder builder, int AvatarPoint) { builder.AddInt(3, AvatarPoint, -1); }
  public static void AddClass(FlatBufferBuilder builder, int Class) { builder.AddInt(4, Class, -1); }
  public static void AddSort(FlatBufferBuilder builder, int Sort) { builder.AddInt(5, Sort, -1); }
  public static Offset<FB_EmotionClass> EndFB_EmotionClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EmotionClass>(o);
  }
};

public sealed class FB_EmotionClassContainer : Table {
  public static FB_EmotionClassContainer GetRootAsFB_EmotionClassContainer(ByteBuffer _bb) { return GetRootAsFB_EmotionClassContainer(_bb, new FB_EmotionClassContainer()); }
  public static FB_EmotionClassContainer GetRootAsFB_EmotionClassContainer(ByteBuffer _bb, FB_EmotionClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EmotionClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EmotionClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EmotionClass GetItems(int j) { return GetItems(new FB_EmotionClass(), j); }
  public FB_EmotionClass GetItems(FB_EmotionClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EmotionClassContainer> CreateFB_EmotionClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EmotionClassContainer.AddItems(builder, items);
    return FB_EmotionClassContainer.EndFB_EmotionClassContainer(builder);
  }

  public static void StartFB_EmotionClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EmotionClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EmotionClassContainer> EndFB_EmotionClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EmotionClassContainer>(o);
  }
  public static void FinishFB_EmotionClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_EmotionClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
