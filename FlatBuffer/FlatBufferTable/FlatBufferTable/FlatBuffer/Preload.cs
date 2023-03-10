// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Preload : Table {
  public static FB_Preload GetRootAsFB_Preload(ByteBuffer _bb) { return GetRootAsFB_Preload(_bb, new FB_Preload()); }
  public static FB_Preload GetRootAsFB_Preload(ByteBuffer _bb, FB_Preload obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Preload __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Path { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MenPaiId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsNewborn { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_Preload> CreateFB_Preload(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Path = default(StringOffset),
      int MenPaiId = -1,
      bool IsNewborn = false) {
    builder.StartObject(4);
    FB_Preload.AddMenPaiId(builder, MenPaiId);
    FB_Preload.AddPath(builder, Path);
    FB_Preload.AddId(builder, Id);
    FB_Preload.AddIsNewborn(builder, IsNewborn);
    return FB_Preload.EndFB_Preload(builder);
  }

  public static void StartFB_Preload(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(1, PathOffset.Value, 0); }
  public static void AddMenPaiId(FlatBufferBuilder builder, int MenPaiId) { builder.AddInt(2, MenPaiId, -1); }
  public static void AddIsNewborn(FlatBufferBuilder builder, bool IsNewborn) { builder.AddBool(3, IsNewborn, false); }
  public static Offset<FB_Preload> EndFB_Preload(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Preload>(o);
  }
};

public sealed class FB_PreloadContainer : Table {
  public static FB_PreloadContainer GetRootAsFB_PreloadContainer(ByteBuffer _bb) { return GetRootAsFB_PreloadContainer(_bb, new FB_PreloadContainer()); }
  public static FB_PreloadContainer GetRootAsFB_PreloadContainer(ByteBuffer _bb, FB_PreloadContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PreloadContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PreloadContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Preload GetItems(int j) { return GetItems(new FB_Preload(), j); }
  public FB_Preload GetItems(FB_Preload obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PreloadContainer> CreateFB_PreloadContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PreloadContainer.AddItems(builder, items);
    return FB_PreloadContainer.EndFB_PreloadContainer(builder);
  }

  public static void StartFB_PreloadContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Preload>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PreloadContainer> EndFB_PreloadContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PreloadContainer>(o);
  }
  public static void FinishFB_PreloadContainerBuffer(FlatBufferBuilder builder, Offset<FB_PreloadContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
