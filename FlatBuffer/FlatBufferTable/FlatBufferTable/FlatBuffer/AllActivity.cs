// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AllActivity : Table {
  public static FB_AllActivity GetRootAsFB_AllActivity(ByteBuffer _bb) { return GetRootAsFB_AllActivity(_bb, new FB_AllActivity()); }
  public static FB_AllActivity GetRootAsFB_AllActivity(ByteBuffer _bb, FB_AllActivity obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AllActivity __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UIID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_AllActivity> CreateFB_AllActivity(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int UIID = -1) {
    builder.StartObject(3);
    FB_AllActivity.AddUIID(builder, UIID);
    FB_AllActivity.AddName(builder, Name);
    FB_AllActivity.AddId(builder, Id);
    return FB_AllActivity.EndFB_AllActivity(builder);
  }

  public static void StartFB_AllActivity(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(2, UIID, -1); }
  public static Offset<FB_AllActivity> EndFB_AllActivity(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AllActivity>(o);
  }
};

public sealed class FB_AllActivityContainer : Table {
  public static FB_AllActivityContainer GetRootAsFB_AllActivityContainer(ByteBuffer _bb) { return GetRootAsFB_AllActivityContainer(_bb, new FB_AllActivityContainer()); }
  public static FB_AllActivityContainer GetRootAsFB_AllActivityContainer(ByteBuffer _bb, FB_AllActivityContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AllActivityContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AllActivityContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AllActivity GetItems(int j) { return GetItems(new FB_AllActivity(), j); }
  public FB_AllActivity GetItems(FB_AllActivity obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AllActivityContainer> CreateFB_AllActivityContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AllActivityContainer.AddItems(builder, items);
    return FB_AllActivityContainer.EndFB_AllActivityContainer(builder);
  }

  public static void StartFB_AllActivityContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AllActivity>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AllActivityContainer> EndFB_AllActivityContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AllActivityContainer>(o);
  }
  public static void FinishFB_AllActivityContainerBuffer(FlatBufferBuilder builder, Offset<FB_AllActivityContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
