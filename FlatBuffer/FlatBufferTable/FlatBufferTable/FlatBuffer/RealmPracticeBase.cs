// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RealmPracticeBase : Table {
  public static FB_RealmPracticeBase GetRootAsFB_RealmPracticeBase(ByteBuffer _bb) { return GetRootAsFB_RealmPracticeBase(_bb, new FB_RealmPracticeBase()); }
  public static FB_RealmPracticeBase GetRootAsFB_RealmPracticeBase(ByteBuffer _bb, FB_RealmPracticeBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RealmPracticeBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_RealmPracticeBase> CreateFB_RealmPracticeBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset)) {
    builder.StartObject(2);
    FB_RealmPracticeBase.AddName(builder, Name);
    FB_RealmPracticeBase.AddID(builder, ID);
    return FB_RealmPracticeBase.EndFB_RealmPracticeBase(builder);
  }

  public static void StartFB_RealmPracticeBase(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static Offset<FB_RealmPracticeBase> EndFB_RealmPracticeBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RealmPracticeBase>(o);
  }
};

public sealed class FB_RealmPracticeBaseContainer : Table {
  public static FB_RealmPracticeBaseContainer GetRootAsFB_RealmPracticeBaseContainer(ByteBuffer _bb) { return GetRootAsFB_RealmPracticeBaseContainer(_bb, new FB_RealmPracticeBaseContainer()); }
  public static FB_RealmPracticeBaseContainer GetRootAsFB_RealmPracticeBaseContainer(ByteBuffer _bb, FB_RealmPracticeBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RealmPracticeBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RealmPracticeBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RealmPracticeBase GetItems(int j) { return GetItems(new FB_RealmPracticeBase(), j); }
  public FB_RealmPracticeBase GetItems(FB_RealmPracticeBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RealmPracticeBaseContainer> CreateFB_RealmPracticeBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RealmPracticeBaseContainer.AddItems(builder, items);
    return FB_RealmPracticeBaseContainer.EndFB_RealmPracticeBaseContainer(builder);
  }

  public static void StartFB_RealmPracticeBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RealmPracticeBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RealmPracticeBaseContainer> EndFB_RealmPracticeBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RealmPracticeBaseContainer>(o);
  }
  public static void FinishFB_RealmPracticeBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_RealmPracticeBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
