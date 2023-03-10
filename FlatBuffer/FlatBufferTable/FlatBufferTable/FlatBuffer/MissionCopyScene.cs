// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionCopyScene : Table {
  public static FB_MissionCopyScene GetRootAsFB_MissionCopyScene(ByteBuffer _bb) { return GetRootAsFB_MissionCopyScene(_bb, new FB_MissionCopyScene()); }
  public static FB_MissionCopyScene GetRootAsFB_MissionCopyScene(ByteBuffer _bb, FB_MissionCopyScene obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionCopyScene __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CopySceneID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsEnterCSOnAccept { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_MissionCopyScene> CreateFB_MissionCopyScene(FlatBufferBuilder builder,
      int Id = 0,
      int CopySceneID = -1,
      bool IsEnterCSOnAccept = false) {
    builder.StartObject(3);
    FB_MissionCopyScene.AddCopySceneID(builder, CopySceneID);
    FB_MissionCopyScene.AddId(builder, Id);
    FB_MissionCopyScene.AddIsEnterCSOnAccept(builder, IsEnterCSOnAccept);
    return FB_MissionCopyScene.EndFB_MissionCopyScene(builder);
  }

  public static void StartFB_MissionCopyScene(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(1, CopySceneID, -1); }
  public static void AddIsEnterCSOnAccept(FlatBufferBuilder builder, bool IsEnterCSOnAccept) { builder.AddBool(2, IsEnterCSOnAccept, false); }
  public static Offset<FB_MissionCopyScene> EndFB_MissionCopyScene(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionCopyScene>(o);
  }
};

public sealed class FB_MissionCopySceneContainer : Table {
  public static FB_MissionCopySceneContainer GetRootAsFB_MissionCopySceneContainer(ByteBuffer _bb) { return GetRootAsFB_MissionCopySceneContainer(_bb, new FB_MissionCopySceneContainer()); }
  public static FB_MissionCopySceneContainer GetRootAsFB_MissionCopySceneContainer(ByteBuffer _bb, FB_MissionCopySceneContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionCopySceneContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionCopySceneContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionCopyScene GetItems(int j) { return GetItems(new FB_MissionCopyScene(), j); }
  public FB_MissionCopyScene GetItems(FB_MissionCopyScene obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionCopySceneContainer> CreateFB_MissionCopySceneContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionCopySceneContainer.AddItems(builder, items);
    return FB_MissionCopySceneContainer.EndFB_MissionCopySceneContainer(builder);
  }

  public static void StartFB_MissionCopySceneContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionCopyScene>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionCopySceneContainer> EndFB_MissionCopySceneContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionCopySceneContainer>(o);
  }
  public static void FinishFB_MissionCopySceneContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionCopySceneContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
