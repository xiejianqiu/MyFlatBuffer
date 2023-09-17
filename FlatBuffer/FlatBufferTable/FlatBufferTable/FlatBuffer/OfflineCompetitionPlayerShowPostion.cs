// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OfflineCompetitionPlayerShowPostion : Table {
  public static FB_OfflineCompetitionPlayerShowPostion GetRootAsFB_OfflineCompetitionPlayerShowPostion(ByteBuffer _bb) { return GetRootAsFB_OfflineCompetitionPlayerShowPostion(_bb, new FB_OfflineCompetitionPlayerShowPostion()); }
  public static FB_OfflineCompetitionPlayerShowPostion GetRootAsFB_OfflineCompetitionPlayerShowPostion(ByteBuffer _bb, FB_OfflineCompetitionPlayerShowPostion obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OfflineCompetitionPlayerShowPostion __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XRotation { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float YRotation { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ZRotation { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int AnimationID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_OfflineCompetitionPlayerShowPostion> CreateFB_OfflineCompetitionPlayerShowPostion(FlatBufferBuilder builder,
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
    FB_OfflineCompetitionPlayerShowPostion.AddAnimationID(builder, AnimationID);
    FB_OfflineCompetitionPlayerShowPostion.AddScale(builder, Scale);
    FB_OfflineCompetitionPlayerShowPostion.AddZRotation(builder, ZRotation);
    FB_OfflineCompetitionPlayerShowPostion.AddYRotation(builder, YRotation);
    FB_OfflineCompetitionPlayerShowPostion.AddXRotation(builder, XRotation);
    FB_OfflineCompetitionPlayerShowPostion.AddPosZ(builder, PosZ);
    FB_OfflineCompetitionPlayerShowPostion.AddPosY(builder, PosY);
    FB_OfflineCompetitionPlayerShowPostion.AddPosX(builder, PosX);
    FB_OfflineCompetitionPlayerShowPostion.AddId(builder, Id);
    return FB_OfflineCompetitionPlayerShowPostion.EndFB_OfflineCompetitionPlayerShowPostion(builder);
  }

  public static void StartFB_OfflineCompetitionPlayerShowPostion(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(1, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(2, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(3, PosZ, 0); }
  public static void AddXRotation(FlatBufferBuilder builder, float XRotation) { builder.AddFloat(4, XRotation, 0); }
  public static void AddYRotation(FlatBufferBuilder builder, float YRotation) { builder.AddFloat(5, YRotation, 0); }
  public static void AddZRotation(FlatBufferBuilder builder, float ZRotation) { builder.AddFloat(6, ZRotation, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(7, Scale, 0); }
  public static void AddAnimationID(FlatBufferBuilder builder, int AnimationID) { builder.AddInt(8, AnimationID, -1); }
  public static Offset<FB_OfflineCompetitionPlayerShowPostion> EndFB_OfflineCompetitionPlayerShowPostion(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OfflineCompetitionPlayerShowPostion>(o);
  }
};

public sealed class FB_OfflineCompetitionPlayerShowPostionContainer : Table {
  public static FB_OfflineCompetitionPlayerShowPostionContainer GetRootAsFB_OfflineCompetitionPlayerShowPostionContainer(ByteBuffer _bb) { return GetRootAsFB_OfflineCompetitionPlayerShowPostionContainer(_bb, new FB_OfflineCompetitionPlayerShowPostionContainer()); }
  public static FB_OfflineCompetitionPlayerShowPostionContainer GetRootAsFB_OfflineCompetitionPlayerShowPostionContainer(ByteBuffer _bb, FB_OfflineCompetitionPlayerShowPostionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OfflineCompetitionPlayerShowPostionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OfflineCompetitionPlayerShowPostionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OfflineCompetitionPlayerShowPostion GetItems(int j) { return GetItems(new FB_OfflineCompetitionPlayerShowPostion(), j); }
  public FB_OfflineCompetitionPlayerShowPostion GetItems(FB_OfflineCompetitionPlayerShowPostion obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OfflineCompetitionPlayerShowPostionContainer> CreateFB_OfflineCompetitionPlayerShowPostionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OfflineCompetitionPlayerShowPostionContainer.AddItems(builder, items);
    return FB_OfflineCompetitionPlayerShowPostionContainer.EndFB_OfflineCompetitionPlayerShowPostionContainer(builder);
  }

  public static void StartFB_OfflineCompetitionPlayerShowPostionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OfflineCompetitionPlayerShowPostion>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OfflineCompetitionPlayerShowPostionContainer> EndFB_OfflineCompetitionPlayerShowPostionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OfflineCompetitionPlayerShowPostionContainer>(o);
  }
  public static void FinishFB_OfflineCompetitionPlayerShowPostionContainerBuffer(FlatBufferBuilder builder, Offset<FB_OfflineCompetitionPlayerShowPostionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
