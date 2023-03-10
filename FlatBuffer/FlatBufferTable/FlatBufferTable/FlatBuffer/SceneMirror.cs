// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SceneMirror : Table {
  public static FB_SceneMirror GetRootAsFB_SceneMirror(ByteBuffer _bb) { return GetRootAsFB_SceneMirror(_bb, new FB_SceneMirror()); }
  public static FB_SceneMirror GetRootAsFB_SceneMirror(ByteBuffer _bb, FB_SceneMirror obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SceneMirror __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int SceneID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetDayGapList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DayGapListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMirrorCountList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MirrorCountListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneMirror> CreateFB_SceneMirror(FlatBufferBuilder builder,
      int SceneID = 0,
      VectorOffset DayGapList = default(VectorOffset),
      VectorOffset MirrorCountList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_SceneMirror.AddMirrorCountList(builder, MirrorCountList);
    FB_SceneMirror.AddDayGapList(builder, DayGapList);
    FB_SceneMirror.AddSceneID(builder, SceneID);
    return FB_SceneMirror.EndFB_SceneMirror(builder);
  }

  public static void StartFB_SceneMirror(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(0, SceneID, 0); }
  public static void AddDayGapList(FlatBufferBuilder builder, VectorOffset DayGapListOffset) { builder.AddOffset(1, DayGapListOffset.Value, 0); }
  public static VectorOffset CreateDayGapListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDayGapListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMirrorCountList(FlatBufferBuilder builder, VectorOffset MirrorCountListOffset) { builder.AddOffset(2, MirrorCountListOffset.Value, 0); }
  public static VectorOffset CreateMirrorCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMirrorCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneMirror> EndFB_SceneMirror(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneMirror>(o);
  }
};

public sealed class FB_SceneMirrorContainer : Table {
  public static FB_SceneMirrorContainer GetRootAsFB_SceneMirrorContainer(ByteBuffer _bb) { return GetRootAsFB_SceneMirrorContainer(_bb, new FB_SceneMirrorContainer()); }
  public static FB_SceneMirrorContainer GetRootAsFB_SceneMirrorContainer(ByteBuffer _bb, FB_SceneMirrorContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SceneMirrorContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SceneMirrorContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SceneMirror GetItems(int j) { return GetItems(new FB_SceneMirror(), j); }
  public FB_SceneMirror GetItems(FB_SceneMirror obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneMirrorContainer> CreateFB_SceneMirrorContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SceneMirrorContainer.AddItems(builder, items);
    return FB_SceneMirrorContainer.EndFB_SceneMirrorContainer(builder);
  }

  public static void StartFB_SceneMirrorContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SceneMirror>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneMirrorContainer> EndFB_SceneMirrorContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneMirrorContainer>(o);
  }
  public static void FinishFB_SceneMirrorContainerBuffer(FlatBufferBuilder builder, Offset<FB_SceneMirrorContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
