// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_NPCSounds : Table {
  public static FB_NPCSounds GetRootAsFB_NPCSounds(ByteBuffer _bb) { return GetRootAsFB_NPCSounds(_bb, new FB_NPCSounds()); }
  public static FB_NPCSounds GetRootAsFB_NPCSounds(ByteBuffer _bb, FB_NPCSounds obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_NPCSounds __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SoundID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_NPCSounds> CreateFB_NPCSounds(FlatBufferBuilder builder,
      int ID = 0,
      int SoundID = 0) {
    builder.StartObject(2);
    FB_NPCSounds.AddSoundID(builder, SoundID);
    FB_NPCSounds.AddID(builder, ID);
    return FB_NPCSounds.EndFB_NPCSounds(builder);
  }

  public static void StartFB_NPCSounds(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddSoundID(FlatBufferBuilder builder, int SoundID) { builder.AddInt(1, SoundID, 0); }
  public static Offset<FB_NPCSounds> EndFB_NPCSounds(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_NPCSounds>(o);
  }
};

public sealed class FB_NPCSoundsContainer : Table {
  public static FB_NPCSoundsContainer GetRootAsFB_NPCSoundsContainer(ByteBuffer _bb) { return GetRootAsFB_NPCSoundsContainer(_bb, new FB_NPCSoundsContainer()); }
  public static FB_NPCSoundsContainer GetRootAsFB_NPCSoundsContainer(ByteBuffer _bb, FB_NPCSoundsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_NPCSoundsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_NPCSoundsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_NPCSounds GetItems(int j) { return GetItems(new FB_NPCSounds(), j); }
  public FB_NPCSounds GetItems(FB_NPCSounds obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_NPCSoundsContainer> CreateFB_NPCSoundsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_NPCSoundsContainer.AddItems(builder, items);
    return FB_NPCSoundsContainer.EndFB_NPCSoundsContainer(builder);
  }

  public static void StartFB_NPCSoundsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_NPCSounds>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_NPCSoundsContainer> EndFB_NPCSoundsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_NPCSoundsContainer>(o);
  }
  public static void FinishFB_NPCSoundsContainerBuffer(FlatBufferBuilder builder, Offset<FB_NPCSoundsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
