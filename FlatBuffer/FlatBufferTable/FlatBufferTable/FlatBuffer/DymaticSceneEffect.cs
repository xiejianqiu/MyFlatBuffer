// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DymaticSceneEffect : Table {
  public static FB_DymaticSceneEffect GetRootAsFB_DymaticSceneEffect(ByteBuffer _bb) { return GetRootAsFB_DymaticSceneEffect(_bb, new FB_DymaticSceneEffect()); }
  public static FB_DymaticSceneEffect GetRootAsFB_DymaticSceneEffect(ByteBuffer _bb, FB_DymaticSceneEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DymaticSceneEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Path { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Distance { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)3; } }
  public int Rate { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WSSceneID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float PosX { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FaceDir { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float UpOrDownAngle { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public bool IsDefaultShow { get { int o = __offset(26); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }

  public static Offset<FB_DymaticSceneEffect> CreateFB_DymaticSceneEffect(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Path = default(StringOffset),
      int Distance = 3,
      int Rate = -1,
      int WSSceneID = -1,
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0,
      float FaceDir = 0,
      float UpOrDownAngle = 0,
      float Scale = 1,
      bool IsDefaultShow = true) {
    builder.StartObject(12);
    FB_DymaticSceneEffect.AddScale(builder, Scale);
    FB_DymaticSceneEffect.AddUpOrDownAngle(builder, UpOrDownAngle);
    FB_DymaticSceneEffect.AddFaceDir(builder, FaceDir);
    FB_DymaticSceneEffect.AddPosZ(builder, PosZ);
    FB_DymaticSceneEffect.AddPosY(builder, PosY);
    FB_DymaticSceneEffect.AddPosX(builder, PosX);
    FB_DymaticSceneEffect.AddWSSceneID(builder, WSSceneID);
    FB_DymaticSceneEffect.AddRate(builder, Rate);
    FB_DymaticSceneEffect.AddDistance(builder, Distance);
    FB_DymaticSceneEffect.AddPath(builder, Path);
    FB_DymaticSceneEffect.AddId(builder, Id);
    FB_DymaticSceneEffect.AddIsDefaultShow(builder, IsDefaultShow);
    return FB_DymaticSceneEffect.EndFB_DymaticSceneEffect(builder);
  }

  public static void StartFB_DymaticSceneEffect(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(1, PathOffset.Value, 0); }
  public static void AddDistance(FlatBufferBuilder builder, int Distance) { builder.AddInt(2, Distance, 3); }
  public static void AddRate(FlatBufferBuilder builder, int Rate) { builder.AddInt(3, Rate, -1); }
  public static void AddWSSceneID(FlatBufferBuilder builder, int WSSceneID) { builder.AddInt(4, WSSceneID, -1); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(5, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(6, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(7, PosZ, 0); }
  public static void AddFaceDir(FlatBufferBuilder builder, float FaceDir) { builder.AddFloat(8, FaceDir, 0); }
  public static void AddUpOrDownAngle(FlatBufferBuilder builder, float UpOrDownAngle) { builder.AddFloat(9, UpOrDownAngle, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(10, Scale, 1); }
  public static void AddIsDefaultShow(FlatBufferBuilder builder, bool IsDefaultShow) { builder.AddBool(11, IsDefaultShow, true); }
  public static Offset<FB_DymaticSceneEffect> EndFB_DymaticSceneEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DymaticSceneEffect>(o);
  }
};

public sealed class FB_DymaticSceneEffectContainer : Table {
  public static FB_DymaticSceneEffectContainer GetRootAsFB_DymaticSceneEffectContainer(ByteBuffer _bb) { return GetRootAsFB_DymaticSceneEffectContainer(_bb, new FB_DymaticSceneEffectContainer()); }
  public static FB_DymaticSceneEffectContainer GetRootAsFB_DymaticSceneEffectContainer(ByteBuffer _bb, FB_DymaticSceneEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DymaticSceneEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DymaticSceneEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DymaticSceneEffect GetItems(int j) { return GetItems(new FB_DymaticSceneEffect(), j); }
  public FB_DymaticSceneEffect GetItems(FB_DymaticSceneEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DymaticSceneEffectContainer> CreateFB_DymaticSceneEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DymaticSceneEffectContainer.AddItems(builder, items);
    return FB_DymaticSceneEffectContainer.EndFB_DymaticSceneEffectContainer(builder);
  }

  public static void StartFB_DymaticSceneEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DymaticSceneEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DymaticSceneEffectContainer> EndFB_DymaticSceneEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DymaticSceneEffectContainer>(o);
  }
  public static void FinishFB_DymaticSceneEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_DymaticSceneEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
