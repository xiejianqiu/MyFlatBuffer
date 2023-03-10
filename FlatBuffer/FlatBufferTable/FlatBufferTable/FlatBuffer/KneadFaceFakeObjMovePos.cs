// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KneadFaceFakeObjMovePos : Table {
  public static FB_KneadFaceFakeObjMovePos GetRootAsFB_KneadFaceFakeObjMovePos(ByteBuffer _bb) { return GetRootAsFB_KneadFaceFakeObjMovePos(_bb, new FB_KneadFaceFakeObjMovePos()); }
  public static FB_KneadFaceFakeObjMovePos GetRootAsFB_KneadFaceFakeObjMovePos(ByteBuffer _bb, FB_KneadFaceFakeObjMovePos obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KneadFaceFakeObjMovePos __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float NearPosX { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float NearPosY { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float NearPosZ { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float NearRotateX { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float NearRotateY { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float NearRotateZ { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FarPosX { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FarPosY { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FarPosZ { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FarRotateX { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FarRotateY { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FarRotateZ { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }

  public static Offset<FB_KneadFaceFakeObjMovePos> CreateFB_KneadFaceFakeObjMovePos(FlatBufferBuilder builder,
      int Id = 0,
      float NearPosX = -1,
      float NearPosY = -1,
      float NearPosZ = -1,
      float NearRotateX = -1,
      float NearRotateY = -1,
      float NearRotateZ = -1,
      float FarPosX = -1,
      float FarPosY = -1,
      float FarPosZ = -1,
      float FarRotateX = -1,
      float FarRotateY = -1,
      float FarRotateZ = -1) {
    builder.StartObject(13);
    FB_KneadFaceFakeObjMovePos.AddFarRotateZ(builder, FarRotateZ);
    FB_KneadFaceFakeObjMovePos.AddFarRotateY(builder, FarRotateY);
    FB_KneadFaceFakeObjMovePos.AddFarRotateX(builder, FarRotateX);
    FB_KneadFaceFakeObjMovePos.AddFarPosZ(builder, FarPosZ);
    FB_KneadFaceFakeObjMovePos.AddFarPosY(builder, FarPosY);
    FB_KneadFaceFakeObjMovePos.AddFarPosX(builder, FarPosX);
    FB_KneadFaceFakeObjMovePos.AddNearRotateZ(builder, NearRotateZ);
    FB_KneadFaceFakeObjMovePos.AddNearRotateY(builder, NearRotateY);
    FB_KneadFaceFakeObjMovePos.AddNearRotateX(builder, NearRotateX);
    FB_KneadFaceFakeObjMovePos.AddNearPosZ(builder, NearPosZ);
    FB_KneadFaceFakeObjMovePos.AddNearPosY(builder, NearPosY);
    FB_KneadFaceFakeObjMovePos.AddNearPosX(builder, NearPosX);
    FB_KneadFaceFakeObjMovePos.AddId(builder, Id);
    return FB_KneadFaceFakeObjMovePos.EndFB_KneadFaceFakeObjMovePos(builder);
  }

  public static void StartFB_KneadFaceFakeObjMovePos(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddNearPosX(FlatBufferBuilder builder, float NearPosX) { builder.AddFloat(1, NearPosX, -1); }
  public static void AddNearPosY(FlatBufferBuilder builder, float NearPosY) { builder.AddFloat(2, NearPosY, -1); }
  public static void AddNearPosZ(FlatBufferBuilder builder, float NearPosZ) { builder.AddFloat(3, NearPosZ, -1); }
  public static void AddNearRotateX(FlatBufferBuilder builder, float NearRotateX) { builder.AddFloat(4, NearRotateX, -1); }
  public static void AddNearRotateY(FlatBufferBuilder builder, float NearRotateY) { builder.AddFloat(5, NearRotateY, -1); }
  public static void AddNearRotateZ(FlatBufferBuilder builder, float NearRotateZ) { builder.AddFloat(6, NearRotateZ, -1); }
  public static void AddFarPosX(FlatBufferBuilder builder, float FarPosX) { builder.AddFloat(7, FarPosX, -1); }
  public static void AddFarPosY(FlatBufferBuilder builder, float FarPosY) { builder.AddFloat(8, FarPosY, -1); }
  public static void AddFarPosZ(FlatBufferBuilder builder, float FarPosZ) { builder.AddFloat(9, FarPosZ, -1); }
  public static void AddFarRotateX(FlatBufferBuilder builder, float FarRotateX) { builder.AddFloat(10, FarRotateX, -1); }
  public static void AddFarRotateY(FlatBufferBuilder builder, float FarRotateY) { builder.AddFloat(11, FarRotateY, -1); }
  public static void AddFarRotateZ(FlatBufferBuilder builder, float FarRotateZ) { builder.AddFloat(12, FarRotateZ, -1); }
  public static Offset<FB_KneadFaceFakeObjMovePos> EndFB_KneadFaceFakeObjMovePos(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceFakeObjMovePos>(o);
  }
};

public sealed class FB_KneadFaceFakeObjMovePosContainer : Table {
  public static FB_KneadFaceFakeObjMovePosContainer GetRootAsFB_KneadFaceFakeObjMovePosContainer(ByteBuffer _bb) { return GetRootAsFB_KneadFaceFakeObjMovePosContainer(_bb, new FB_KneadFaceFakeObjMovePosContainer()); }
  public static FB_KneadFaceFakeObjMovePosContainer GetRootAsFB_KneadFaceFakeObjMovePosContainer(ByteBuffer _bb, FB_KneadFaceFakeObjMovePosContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KneadFaceFakeObjMovePosContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KneadFaceFakeObjMovePosContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KneadFaceFakeObjMovePos GetItems(int j) { return GetItems(new FB_KneadFaceFakeObjMovePos(), j); }
  public FB_KneadFaceFakeObjMovePos GetItems(FB_KneadFaceFakeObjMovePos obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KneadFaceFakeObjMovePosContainer> CreateFB_KneadFaceFakeObjMovePosContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KneadFaceFakeObjMovePosContainer.AddItems(builder, items);
    return FB_KneadFaceFakeObjMovePosContainer.EndFB_KneadFaceFakeObjMovePosContainer(builder);
  }

  public static void StartFB_KneadFaceFakeObjMovePosContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KneadFaceFakeObjMovePos>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KneadFaceFakeObjMovePosContainer> EndFB_KneadFaceFakeObjMovePosContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceFakeObjMovePosContainer>(o);
  }
  public static void FinishFB_KneadFaceFakeObjMovePosContainerBuffer(FlatBufferBuilder builder, Offset<FB_KneadFaceFakeObjMovePosContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
