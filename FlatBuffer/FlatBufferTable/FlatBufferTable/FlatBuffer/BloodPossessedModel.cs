// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BloodPossessedModel : Table {
  public static FB_BloodPossessedModel GetRootAsFB_BloodPossessedModel(ByteBuffer _bb) { return GetRootAsFB_BloodPossessedModel(_bb, new FB_BloodPossessedModel()); }
  public static FB_BloodPossessedModel GetRootAsFB_BloodPossessedModel(ByteBuffer _bb, FB_BloodPossessedModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BloodPossessedModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CharModelID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EffectID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSkillIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkillIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int AnimID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndEffectID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float CameraOffsetX { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CameraOffsetY { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CameraOffsetZ { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CameraRotateX { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CameraRotateY { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CameraRotateZ { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CameraDistance { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_BloodPossessedModel> CreateFB_BloodPossessedModel(FlatBufferBuilder builder,
      int ID = 0,
      int CharModelID = -1,
      int EffectID = -1,
      VectorOffset SkillIDList = default(VectorOffset),
      int AnimID = -1,
      int EndEffectID = -1,
      float CameraOffsetX = 0,
      float CameraOffsetY = 0,
      float CameraOffsetZ = 0,
      float CameraRotateX = 0,
      float CameraRotateY = 0,
      float CameraRotateZ = 0,
      float CameraDistance = 0) {
    builder.StartObject(13);
    FB_BloodPossessedModel.AddCameraDistance(builder, CameraDistance);
    FB_BloodPossessedModel.AddCameraRotateZ(builder, CameraRotateZ);
    FB_BloodPossessedModel.AddCameraRotateY(builder, CameraRotateY);
    FB_BloodPossessedModel.AddCameraRotateX(builder, CameraRotateX);
    FB_BloodPossessedModel.AddCameraOffsetZ(builder, CameraOffsetZ);
    FB_BloodPossessedModel.AddCameraOffsetY(builder, CameraOffsetY);
    FB_BloodPossessedModel.AddCameraOffsetX(builder, CameraOffsetX);
    FB_BloodPossessedModel.AddEndEffectID(builder, EndEffectID);
    FB_BloodPossessedModel.AddAnimID(builder, AnimID);
    FB_BloodPossessedModel.AddSkillIDList(builder, SkillIDList);
    FB_BloodPossessedModel.AddEffectID(builder, EffectID);
    FB_BloodPossessedModel.AddCharModelID(builder, CharModelID);
    FB_BloodPossessedModel.AddID(builder, ID);
    return FB_BloodPossessedModel.EndFB_BloodPossessedModel(builder);
  }

  public static void StartFB_BloodPossessedModel(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCharModelID(FlatBufferBuilder builder, int CharModelID) { builder.AddInt(1, CharModelID, -1); }
  public static void AddEffectID(FlatBufferBuilder builder, int EffectID) { builder.AddInt(2, EffectID, -1); }
  public static void AddSkillIDList(FlatBufferBuilder builder, VectorOffset SkillIDListOffset) { builder.AddOffset(3, SkillIDListOffset.Value, 0); }
  public static VectorOffset CreateSkillIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkillIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAnimID(FlatBufferBuilder builder, int AnimID) { builder.AddInt(4, AnimID, -1); }
  public static void AddEndEffectID(FlatBufferBuilder builder, int EndEffectID) { builder.AddInt(5, EndEffectID, -1); }
  public static void AddCameraOffsetX(FlatBufferBuilder builder, float CameraOffsetX) { builder.AddFloat(6, CameraOffsetX, 0); }
  public static void AddCameraOffsetY(FlatBufferBuilder builder, float CameraOffsetY) { builder.AddFloat(7, CameraOffsetY, 0); }
  public static void AddCameraOffsetZ(FlatBufferBuilder builder, float CameraOffsetZ) { builder.AddFloat(8, CameraOffsetZ, 0); }
  public static void AddCameraRotateX(FlatBufferBuilder builder, float CameraRotateX) { builder.AddFloat(9, CameraRotateX, 0); }
  public static void AddCameraRotateY(FlatBufferBuilder builder, float CameraRotateY) { builder.AddFloat(10, CameraRotateY, 0); }
  public static void AddCameraRotateZ(FlatBufferBuilder builder, float CameraRotateZ) { builder.AddFloat(11, CameraRotateZ, 0); }
  public static void AddCameraDistance(FlatBufferBuilder builder, float CameraDistance) { builder.AddFloat(12, CameraDistance, 0); }
  public static Offset<FB_BloodPossessedModel> EndFB_BloodPossessedModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodPossessedModel>(o);
  }
};

public sealed class FB_BloodPossessedModelContainer : Table {
  public static FB_BloodPossessedModelContainer GetRootAsFB_BloodPossessedModelContainer(ByteBuffer _bb) { return GetRootAsFB_BloodPossessedModelContainer(_bb, new FB_BloodPossessedModelContainer()); }
  public static FB_BloodPossessedModelContainer GetRootAsFB_BloodPossessedModelContainer(ByteBuffer _bb, FB_BloodPossessedModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BloodPossessedModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BloodPossessedModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BloodPossessedModel GetItems(int j) { return GetItems(new FB_BloodPossessedModel(), j); }
  public FB_BloodPossessedModel GetItems(FB_BloodPossessedModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BloodPossessedModelContainer> CreateFB_BloodPossessedModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BloodPossessedModelContainer.AddItems(builder, items);
    return FB_BloodPossessedModelContainer.EndFB_BloodPossessedModelContainer(builder);
  }

  public static void StartFB_BloodPossessedModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BloodPossessedModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BloodPossessedModelContainer> EndFB_BloodPossessedModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodPossessedModelContainer>(o);
  }
  public static void FinishFB_BloodPossessedModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_BloodPossessedModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
