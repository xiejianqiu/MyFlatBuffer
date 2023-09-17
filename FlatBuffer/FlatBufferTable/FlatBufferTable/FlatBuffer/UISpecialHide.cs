// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_UISpecialHide : Table {
  public static FB_UISpecialHide GetRootAsFB_UISpecialHide(ByteBuffer _bb) { return GetRootAsFB_UISpecialHide(_bb, new FB_UISpecialHide()); }
  public static FB_UISpecialHide GetRootAsFB_UISpecialHide(ByteBuffer _bb, FB_UISpecialHide obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_UISpecialHide __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HideTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float ShowStartTime { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int ShowTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_UISpecialHide> CreateFB_UISpecialHide(FlatBufferBuilder builder,
      int Id = 0,
      int HideTime = 0,
      float ShowStartTime = 0,
      int ShowTime = 0) {
    builder.StartObject(4);
    FB_UISpecialHide.AddShowTime(builder, ShowTime);
    FB_UISpecialHide.AddShowStartTime(builder, ShowStartTime);
    FB_UISpecialHide.AddHideTime(builder, HideTime);
    FB_UISpecialHide.AddId(builder, Id);
    return FB_UISpecialHide.EndFB_UISpecialHide(builder);
  }

  public static void StartFB_UISpecialHide(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddHideTime(FlatBufferBuilder builder, int HideTime) { builder.AddInt(1, HideTime, 0); }
  public static void AddShowStartTime(FlatBufferBuilder builder, float ShowStartTime) { builder.AddFloat(2, ShowStartTime, 0); }
  public static void AddShowTime(FlatBufferBuilder builder, int ShowTime) { builder.AddInt(3, ShowTime, 0); }
  public static Offset<FB_UISpecialHide> EndFB_UISpecialHide(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UISpecialHide>(o);
  }
};

public sealed class FB_UISpecialHideContainer : Table {
  public static FB_UISpecialHideContainer GetRootAsFB_UISpecialHideContainer(ByteBuffer _bb) { return GetRootAsFB_UISpecialHideContainer(_bb, new FB_UISpecialHideContainer()); }
  public static FB_UISpecialHideContainer GetRootAsFB_UISpecialHideContainer(ByteBuffer _bb, FB_UISpecialHideContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_UISpecialHideContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_UISpecialHideContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_UISpecialHide GetItems(int j) { return GetItems(new FB_UISpecialHide(), j); }
  public FB_UISpecialHide GetItems(FB_UISpecialHide obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_UISpecialHideContainer> CreateFB_UISpecialHideContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_UISpecialHideContainer.AddItems(builder, items);
    return FB_UISpecialHideContainer.EndFB_UISpecialHideContainer(builder);
  }

  public static void StartFB_UISpecialHideContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_UISpecialHide>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_UISpecialHideContainer> EndFB_UISpecialHideContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UISpecialHideContainer>(o);
  }
  public static void FinishFB_UISpecialHideContainerBuffer(FlatBufferBuilder builder, Offset<FB_UISpecialHideContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
