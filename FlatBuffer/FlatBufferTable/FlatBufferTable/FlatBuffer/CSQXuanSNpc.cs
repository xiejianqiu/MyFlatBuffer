// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CSQXuanSNpc : Table {
  public static FB_CSQXuanSNpc GetRootAsFB_CSQXuanSNpc(ByteBuffer _bb) { return GetRootAsFB_CSQXuanSNpc(_bb, new FB_CSQXuanSNpc()); }
  public static FB_CSQXuanSNpc GetRootAsFB_CSQXuanSNpc(ByteBuffer _bb, FB_CSQXuanSNpc obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CSQXuanSNpc __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DataID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FaceDirection { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int GroupID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_CSQXuanSNpc> CreateFB_CSQXuanSNpc(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int SceneID = 0,
      int DataID = 0,
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0,
      float FaceDirection = 0,
      int GroupID = 0) {
    builder.StartObject(9);
    FB_CSQXuanSNpc.AddGroupID(builder, GroupID);
    FB_CSQXuanSNpc.AddFaceDirection(builder, FaceDirection);
    FB_CSQXuanSNpc.AddPosZ(builder, PosZ);
    FB_CSQXuanSNpc.AddPosY(builder, PosY);
    FB_CSQXuanSNpc.AddPosX(builder, PosX);
    FB_CSQXuanSNpc.AddDataID(builder, DataID);
    FB_CSQXuanSNpc.AddSceneID(builder, SceneID);
    FB_CSQXuanSNpc.AddName(builder, Name);
    FB_CSQXuanSNpc.AddId(builder, Id);
    return FB_CSQXuanSNpc.EndFB_CSQXuanSNpc(builder);
  }

  public static void StartFB_CSQXuanSNpc(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, 0); }
  public static void AddDataID(FlatBufferBuilder builder, int DataID) { builder.AddInt(3, DataID, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(4, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(5, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(6, PosZ, 0); }
  public static void AddFaceDirection(FlatBufferBuilder builder, float FaceDirection) { builder.AddFloat(7, FaceDirection, 0); }
  public static void AddGroupID(FlatBufferBuilder builder, int GroupID) { builder.AddInt(8, GroupID, 0); }
  public static Offset<FB_CSQXuanSNpc> EndFB_CSQXuanSNpc(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CSQXuanSNpc>(o);
  }
};

public sealed class FB_CSQXuanSNpcContainer : Table {
  public static FB_CSQXuanSNpcContainer GetRootAsFB_CSQXuanSNpcContainer(ByteBuffer _bb) { return GetRootAsFB_CSQXuanSNpcContainer(_bb, new FB_CSQXuanSNpcContainer()); }
  public static FB_CSQXuanSNpcContainer GetRootAsFB_CSQXuanSNpcContainer(ByteBuffer _bb, FB_CSQXuanSNpcContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CSQXuanSNpcContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CSQXuanSNpcContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CSQXuanSNpc GetItems(int j) { return GetItems(new FB_CSQXuanSNpc(), j); }
  public FB_CSQXuanSNpc GetItems(FB_CSQXuanSNpc obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CSQXuanSNpcContainer> CreateFB_CSQXuanSNpcContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CSQXuanSNpcContainer.AddItems(builder, items);
    return FB_CSQXuanSNpcContainer.EndFB_CSQXuanSNpcContainer(builder);
  }

  public static void StartFB_CSQXuanSNpcContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CSQXuanSNpc>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CSQXuanSNpcContainer> EndFB_CSQXuanSNpcContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CSQXuanSNpcContainer>(o);
  }
  public static void FinishFB_CSQXuanSNpcContainerBuffer(FlatBufferBuilder builder, Offset<FB_CSQXuanSNpcContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
