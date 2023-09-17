// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SceneNpc : Table {
  public static FB_SceneNpc GetRootAsFB_SceneNpc(ByteBuffer _bb) { return GetRootAsFB_SceneNpc(_bb, new FB_SceneNpc()); }
  public static FB_SceneNpc GetRootAsFB_SceneNpc(ByteBuffer _bb, FB_SceneNpc obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SceneNpc __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DataID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FaceDirection { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int GroupID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MutexID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PatrolId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosY { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_SceneNpc> CreateFB_SceneNpc(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int SceneID = 0,
      int DataID = 0,
      float PosX = 0,
      float PosZ = 0,
      float FaceDirection = 0,
      int GroupID = 0,
      int MutexID = 0,
      int PatrolId = 0,
      float PosY = 0) {
    builder.StartObject(11);
    FB_SceneNpc.AddPosY(builder, PosY);
    FB_SceneNpc.AddPatrolId(builder, PatrolId);
    FB_SceneNpc.AddMutexID(builder, MutexID);
    FB_SceneNpc.AddGroupID(builder, GroupID);
    FB_SceneNpc.AddFaceDirection(builder, FaceDirection);
    FB_SceneNpc.AddPosZ(builder, PosZ);
    FB_SceneNpc.AddPosX(builder, PosX);
    FB_SceneNpc.AddDataID(builder, DataID);
    FB_SceneNpc.AddSceneID(builder, SceneID);
    FB_SceneNpc.AddName(builder, Name);
    FB_SceneNpc.AddId(builder, Id);
    return FB_SceneNpc.EndFB_SceneNpc(builder);
  }

  public static void StartFB_SceneNpc(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, 0); }
  public static void AddDataID(FlatBufferBuilder builder, int DataID) { builder.AddInt(3, DataID, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(4, PosX, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(5, PosZ, 0); }
  public static void AddFaceDirection(FlatBufferBuilder builder, float FaceDirection) { builder.AddFloat(6, FaceDirection, 0); }
  public static void AddGroupID(FlatBufferBuilder builder, int GroupID) { builder.AddInt(7, GroupID, 0); }
  public static void AddMutexID(FlatBufferBuilder builder, int MutexID) { builder.AddInt(8, MutexID, 0); }
  public static void AddPatrolId(FlatBufferBuilder builder, int PatrolId) { builder.AddInt(9, PatrolId, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(10, PosY, 0); }
  public static Offset<FB_SceneNpc> EndFB_SceneNpc(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneNpc>(o);
  }
};

public sealed class FB_SceneNpcContainer : Table {
  public static FB_SceneNpcContainer GetRootAsFB_SceneNpcContainer(ByteBuffer _bb) { return GetRootAsFB_SceneNpcContainer(_bb, new FB_SceneNpcContainer()); }
  public static FB_SceneNpcContainer GetRootAsFB_SceneNpcContainer(ByteBuffer _bb, FB_SceneNpcContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SceneNpcContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SceneNpcContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SceneNpc GetItems(int j) { return GetItems(new FB_SceneNpc(), j); }
  public FB_SceneNpc GetItems(FB_SceneNpc obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneNpcContainer> CreateFB_SceneNpcContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SceneNpcContainer.AddItems(builder, items);
    return FB_SceneNpcContainer.EndFB_SceneNpcContainer(builder);
  }

  public static void StartFB_SceneNpcContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SceneNpc>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneNpcContainer> EndFB_SceneNpcContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneNpcContainer>(o);
  }
  public static void FinishFB_SceneNpcContainerBuffer(FlatBufferBuilder builder, Offset<FB_SceneNpcContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
