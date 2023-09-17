// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionSceneEffect : Table {
  public static FB_MissionSceneEffect GetRootAsFB_MissionSceneEffect(ByteBuffer _bb) { return GetRootAsFB_MissionSceneEffect(_bb, new FB_MissionSceneEffect()); }
  public static FB_MissionSceneEffect GetRootAsFB_MissionSceneEffect(ByteBuffer _bb, FB_MissionSceneEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionSceneEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EffectId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_MissionSceneEffect> CreateFB_MissionSceneEffect(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int SceneID = 0,
      int EffectId = 0,
      float PosX = 0,
      float PosZ = 0,
      float PosY = 0) {
    builder.StartObject(7);
    FB_MissionSceneEffect.AddPosY(builder, PosY);
    FB_MissionSceneEffect.AddPosZ(builder, PosZ);
    FB_MissionSceneEffect.AddPosX(builder, PosX);
    FB_MissionSceneEffect.AddEffectId(builder, EffectId);
    FB_MissionSceneEffect.AddSceneID(builder, SceneID);
    FB_MissionSceneEffect.AddName(builder, Name);
    FB_MissionSceneEffect.AddId(builder, Id);
    return FB_MissionSceneEffect.EndFB_MissionSceneEffect(builder);
  }

  public static void StartFB_MissionSceneEffect(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, 0); }
  public static void AddEffectId(FlatBufferBuilder builder, int EffectId) { builder.AddInt(3, EffectId, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(4, PosX, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(5, PosZ, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(6, PosY, 0); }
  public static Offset<FB_MissionSceneEffect> EndFB_MissionSceneEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionSceneEffect>(o);
  }
};

public sealed class FB_MissionSceneEffectContainer : Table {
  public static FB_MissionSceneEffectContainer GetRootAsFB_MissionSceneEffectContainer(ByteBuffer _bb) { return GetRootAsFB_MissionSceneEffectContainer(_bb, new FB_MissionSceneEffectContainer()); }
  public static FB_MissionSceneEffectContainer GetRootAsFB_MissionSceneEffectContainer(ByteBuffer _bb, FB_MissionSceneEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionSceneEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionSceneEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionSceneEffect GetItems(int j) { return GetItems(new FB_MissionSceneEffect(), j); }
  public FB_MissionSceneEffect GetItems(FB_MissionSceneEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionSceneEffectContainer> CreateFB_MissionSceneEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionSceneEffectContainer.AddItems(builder, items);
    return FB_MissionSceneEffectContainer.EndFB_MissionSceneEffectContainer(builder);
  }

  public static void StartFB_MissionSceneEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionSceneEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionSceneEffectContainer> EndFB_MissionSceneEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionSceneEffectContainer>(o);
  }
  public static void FinishFB_MissionSceneEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionSceneEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
