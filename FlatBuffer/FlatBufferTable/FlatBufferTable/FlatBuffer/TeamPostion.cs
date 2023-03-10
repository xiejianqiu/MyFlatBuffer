// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TeamPostion : Table {
  public static FB_TeamPostion GetRootAsFB_TeamPostion(ByteBuffer _bb) { return GetRootAsFB_TeamPostion(_bb, new FB_TeamPostion()); }
  public static FB_TeamPostion GetRootAsFB_TeamPostion(ByteBuffer _bb, FB_TeamPostion obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TeamPostion __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XRotation { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float YRotation { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ZRotation { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int AnimationID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TeamPostion> CreateFB_TeamPostion(FlatBufferBuilder builder,
      int Id = 0,
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0,
      float XRotation = 0,
      float YRotation = 0,
      float ZRotation = 0,
      float Scale = 0,
      int AnimationID = -1) {
    builder.StartObject(9);
    FB_TeamPostion.AddAnimationID(builder, AnimationID);
    FB_TeamPostion.AddScale(builder, Scale);
    FB_TeamPostion.AddZRotation(builder, ZRotation);
    FB_TeamPostion.AddYRotation(builder, YRotation);
    FB_TeamPostion.AddXRotation(builder, XRotation);
    FB_TeamPostion.AddPosZ(builder, PosZ);
    FB_TeamPostion.AddPosY(builder, PosY);
    FB_TeamPostion.AddPosX(builder, PosX);
    FB_TeamPostion.AddId(builder, Id);
    return FB_TeamPostion.EndFB_TeamPostion(builder);
  }

  public static void StartFB_TeamPostion(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(1, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(2, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(3, PosZ, 0); }
  public static void AddXRotation(FlatBufferBuilder builder, float XRotation) { builder.AddFloat(4, XRotation, 0); }
  public static void AddYRotation(FlatBufferBuilder builder, float YRotation) { builder.AddFloat(5, YRotation, 0); }
  public static void AddZRotation(FlatBufferBuilder builder, float ZRotation) { builder.AddFloat(6, ZRotation, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(7, Scale, 0); }
  public static void AddAnimationID(FlatBufferBuilder builder, int AnimationID) { builder.AddInt(8, AnimationID, -1); }
  public static Offset<FB_TeamPostion> EndFB_TeamPostion(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TeamPostion>(o);
  }
};

public sealed class FB_TeamPostionContainer : Table {
  public static FB_TeamPostionContainer GetRootAsFB_TeamPostionContainer(ByteBuffer _bb) { return GetRootAsFB_TeamPostionContainer(_bb, new FB_TeamPostionContainer()); }
  public static FB_TeamPostionContainer GetRootAsFB_TeamPostionContainer(ByteBuffer _bb, FB_TeamPostionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TeamPostionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TeamPostionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TeamPostion GetItems(int j) { return GetItems(new FB_TeamPostion(), j); }
  public FB_TeamPostion GetItems(FB_TeamPostion obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TeamPostionContainer> CreateFB_TeamPostionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TeamPostionContainer.AddItems(builder, items);
    return FB_TeamPostionContainer.EndFB_TeamPostionContainer(builder);
  }

  public static void StartFB_TeamPostionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TeamPostion>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TeamPostionContainer> EndFB_TeamPostionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TeamPostionContainer>(o);
  }
  public static void FinishFB_TeamPostionContainerBuffer(FlatBufferBuilder builder, Offset<FB_TeamPostionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
