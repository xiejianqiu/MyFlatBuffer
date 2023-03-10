// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CopySceneLastShot : Table {
  public static FB_CopySceneLastShot GetRootAsFB_CopySceneLastShot(ByteBuffer _bb) { return GetRootAsFB_CopySceneLastShot(_bb, new FB_CopySceneLastShot()); }
  public static FB_CopySceneLastShot GetRootAsFB_CopySceneLastShot(ByteBuffer _bb, FB_CopySceneLastShot obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CopySceneLastShot __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RoleBaseID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CopySceneLastShot> CreateFB_CopySceneLastShot(FlatBufferBuilder builder,
      int ID = 0,
      int RoleBaseID = -1,
      int SceneID = -1) {
    builder.StartObject(3);
    FB_CopySceneLastShot.AddSceneID(builder, SceneID);
    FB_CopySceneLastShot.AddRoleBaseID(builder, RoleBaseID);
    FB_CopySceneLastShot.AddID(builder, ID);
    return FB_CopySceneLastShot.EndFB_CopySceneLastShot(builder);
  }

  public static void StartFB_CopySceneLastShot(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRoleBaseID(FlatBufferBuilder builder, int RoleBaseID) { builder.AddInt(1, RoleBaseID, -1); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, -1); }
  public static Offset<FB_CopySceneLastShot> EndFB_CopySceneLastShot(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneLastShot>(o);
  }
};

public sealed class FB_CopySceneLastShotContainer : Table {
  public static FB_CopySceneLastShotContainer GetRootAsFB_CopySceneLastShotContainer(ByteBuffer _bb) { return GetRootAsFB_CopySceneLastShotContainer(_bb, new FB_CopySceneLastShotContainer()); }
  public static FB_CopySceneLastShotContainer GetRootAsFB_CopySceneLastShotContainer(ByteBuffer _bb, FB_CopySceneLastShotContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CopySceneLastShotContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CopySceneLastShotContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CopySceneLastShot GetItems(int j) { return GetItems(new FB_CopySceneLastShot(), j); }
  public FB_CopySceneLastShot GetItems(FB_CopySceneLastShot obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneLastShotContainer> CreateFB_CopySceneLastShotContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CopySceneLastShotContainer.AddItems(builder, items);
    return FB_CopySceneLastShotContainer.EndFB_CopySceneLastShotContainer(builder);
  }

  public static void StartFB_CopySceneLastShotContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CopySceneLastShot>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneLastShotContainer> EndFB_CopySceneLastShotContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneLastShotContainer>(o);
  }
  public static void FinishFB_CopySceneLastShotContainerBuffer(FlatBufferBuilder builder, Offset<FB_CopySceneLastShotContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
