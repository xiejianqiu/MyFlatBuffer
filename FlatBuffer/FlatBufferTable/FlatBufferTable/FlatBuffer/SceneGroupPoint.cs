// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SceneGroupPoint : Table {
  public static FB_SceneGroupPoint GetRootAsFB_SceneGroupPoint(ByteBuffer _bb) { return GetRootAsFB_SceneGroupPoint(_bb, new FB_SceneGroupPoint()); }
  public static FB_SceneGroupPoint GetRootAsFB_SceneGroupPoint(ByteBuffer _bb, FB_SceneGroupPoint obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SceneGroupPoint __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GroupPointID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FaceDirection { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_SceneGroupPoint> CreateFB_SceneGroupPoint(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int SceneID = 0,
      int GroupPointID = 0,
      float PosX = 0,
      float PosZ = 0,
      float FaceDirection = 0) {
    builder.StartObject(7);
    FB_SceneGroupPoint.AddFaceDirection(builder, FaceDirection);
    FB_SceneGroupPoint.AddPosZ(builder, PosZ);
    FB_SceneGroupPoint.AddPosX(builder, PosX);
    FB_SceneGroupPoint.AddGroupPointID(builder, GroupPointID);
    FB_SceneGroupPoint.AddSceneID(builder, SceneID);
    FB_SceneGroupPoint.AddName(builder, Name);
    FB_SceneGroupPoint.AddId(builder, Id);
    return FB_SceneGroupPoint.EndFB_SceneGroupPoint(builder);
  }

  public static void StartFB_SceneGroupPoint(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, 0); }
  public static void AddGroupPointID(FlatBufferBuilder builder, int GroupPointID) { builder.AddInt(3, GroupPointID, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(4, PosX, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(5, PosZ, 0); }
  public static void AddFaceDirection(FlatBufferBuilder builder, float FaceDirection) { builder.AddFloat(6, FaceDirection, 0); }
  public static Offset<FB_SceneGroupPoint> EndFB_SceneGroupPoint(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneGroupPoint>(o);
  }
};

public sealed class FB_SceneGroupPointContainer : Table {
  public static FB_SceneGroupPointContainer GetRootAsFB_SceneGroupPointContainer(ByteBuffer _bb) { return GetRootAsFB_SceneGroupPointContainer(_bb, new FB_SceneGroupPointContainer()); }
  public static FB_SceneGroupPointContainer GetRootAsFB_SceneGroupPointContainer(ByteBuffer _bb, FB_SceneGroupPointContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SceneGroupPointContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SceneGroupPointContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SceneGroupPoint GetItems(int j) { return GetItems(new FB_SceneGroupPoint(), j); }
  public FB_SceneGroupPoint GetItems(FB_SceneGroupPoint obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneGroupPointContainer> CreateFB_SceneGroupPointContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SceneGroupPointContainer.AddItems(builder, items);
    return FB_SceneGroupPointContainer.EndFB_SceneGroupPointContainer(builder);
  }

  public static void StartFB_SceneGroupPointContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SceneGroupPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneGroupPointContainer> EndFB_SceneGroupPointContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneGroupPointContainer>(o);
  }
  public static void FinishFB_SceneGroupPointContainerBuffer(FlatBufferBuilder builder, Offset<FB_SceneGroupPointContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
