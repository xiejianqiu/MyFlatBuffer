// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CloseUpShot : Table {
  public static FB_CloseUpShot GetRootAsFB_CloseUpShot(ByteBuffer _bb) { return GetRootAsFB_CloseUpShot(_bb, new FB_CloseUpShot()); }
  public static FB_CloseUpShot GetRootAsFB_CloseUpShot(ByteBuffer _bb, FB_CloseUpShot obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CloseUpShot __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AnimationID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Time { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotX { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotY { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotZ { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Distance { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FOV { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_CloseUpShot> CreateFB_CloseUpShot(FlatBufferBuilder builder,
      int Id = 0,
      int AnimationID = -1,
      int Time = 0,
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0,
      float RotX = 0,
      float RotY = 0,
      float RotZ = 0,
      float Distance = 0,
      float FOV = 0) {
    builder.StartObject(11);
    FB_CloseUpShot.AddFOV(builder, FOV);
    FB_CloseUpShot.AddDistance(builder, Distance);
    FB_CloseUpShot.AddRotZ(builder, RotZ);
    FB_CloseUpShot.AddRotY(builder, RotY);
    FB_CloseUpShot.AddRotX(builder, RotX);
    FB_CloseUpShot.AddPosZ(builder, PosZ);
    FB_CloseUpShot.AddPosY(builder, PosY);
    FB_CloseUpShot.AddPosX(builder, PosX);
    FB_CloseUpShot.AddTime(builder, Time);
    FB_CloseUpShot.AddAnimationID(builder, AnimationID);
    FB_CloseUpShot.AddId(builder, Id);
    return FB_CloseUpShot.EndFB_CloseUpShot(builder);
  }

  public static void StartFB_CloseUpShot(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAnimationID(FlatBufferBuilder builder, int AnimationID) { builder.AddInt(1, AnimationID, -1); }
  public static void AddTime(FlatBufferBuilder builder, int Time) { builder.AddInt(2, Time, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(3, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(4, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(5, PosZ, 0); }
  public static void AddRotX(FlatBufferBuilder builder, float RotX) { builder.AddFloat(6, RotX, 0); }
  public static void AddRotY(FlatBufferBuilder builder, float RotY) { builder.AddFloat(7, RotY, 0); }
  public static void AddRotZ(FlatBufferBuilder builder, float RotZ) { builder.AddFloat(8, RotZ, 0); }
  public static void AddDistance(FlatBufferBuilder builder, float Distance) { builder.AddFloat(9, Distance, 0); }
  public static void AddFOV(FlatBufferBuilder builder, float FOV) { builder.AddFloat(10, FOV, 0); }
  public static Offset<FB_CloseUpShot> EndFB_CloseUpShot(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CloseUpShot>(o);
  }
};

public sealed class FB_CloseUpShotContainer : Table {
  public static FB_CloseUpShotContainer GetRootAsFB_CloseUpShotContainer(ByteBuffer _bb) { return GetRootAsFB_CloseUpShotContainer(_bb, new FB_CloseUpShotContainer()); }
  public static FB_CloseUpShotContainer GetRootAsFB_CloseUpShotContainer(ByteBuffer _bb, FB_CloseUpShotContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CloseUpShotContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CloseUpShotContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CloseUpShot GetItems(int j) { return GetItems(new FB_CloseUpShot(), j); }
  public FB_CloseUpShot GetItems(FB_CloseUpShot obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CloseUpShotContainer> CreateFB_CloseUpShotContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CloseUpShotContainer.AddItems(builder, items);
    return FB_CloseUpShotContainer.EndFB_CloseUpShotContainer(builder);
  }

  public static void StartFB_CloseUpShotContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CloseUpShot>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CloseUpShotContainer> EndFB_CloseUpShotContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CloseUpShotContainer>(o);
  }
  public static void FinishFB_CloseUpShotContainerBuffer(FlatBufferBuilder builder, Offset<FB_CloseUpShotContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
