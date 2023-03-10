// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionEnterArea : Table {
  public static FB_MissionEnterArea GetRootAsFB_MissionEnterArea(ByteBuffer _bb) { return GetRootAsFB_MissionEnterArea(_bb, new FB_MissionEnterArea()); }
  public static FB_MissionEnterArea GetRootAsFB_MissionEnterArea(ByteBuffer _bb, FB_MissionEnterArea obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionEnterArea __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TargetSceneID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TargetAreaId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float TargetPosX { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TargetPosY { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int TargetPosRadius { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EffectID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float TargetPosZ { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_MissionEnterArea> CreateFB_MissionEnterArea(FlatBufferBuilder builder,
      int Id = 0,
      int TargetSceneID = -1,
      int TargetAreaId = -1,
      float TargetPosX = -1,
      float TargetPosY = 0,
      int TargetPosRadius = 0,
      int EffectID = -1,
      float TargetPosZ = 0) {
    builder.StartObject(8);
    FB_MissionEnterArea.AddTargetPosZ(builder, TargetPosZ);
    FB_MissionEnterArea.AddEffectID(builder, EffectID);
    FB_MissionEnterArea.AddTargetPosRadius(builder, TargetPosRadius);
    FB_MissionEnterArea.AddTargetPosY(builder, TargetPosY);
    FB_MissionEnterArea.AddTargetPosX(builder, TargetPosX);
    FB_MissionEnterArea.AddTargetAreaId(builder, TargetAreaId);
    FB_MissionEnterArea.AddTargetSceneID(builder, TargetSceneID);
    FB_MissionEnterArea.AddId(builder, Id);
    return FB_MissionEnterArea.EndFB_MissionEnterArea(builder);
  }

  public static void StartFB_MissionEnterArea(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTargetSceneID(FlatBufferBuilder builder, int TargetSceneID) { builder.AddInt(1, TargetSceneID, -1); }
  public static void AddTargetAreaId(FlatBufferBuilder builder, int TargetAreaId) { builder.AddInt(2, TargetAreaId, -1); }
  public static void AddTargetPosX(FlatBufferBuilder builder, float TargetPosX) { builder.AddFloat(3, TargetPosX, -1); }
  public static void AddTargetPosY(FlatBufferBuilder builder, float TargetPosY) { builder.AddFloat(4, TargetPosY, 0); }
  public static void AddTargetPosRadius(FlatBufferBuilder builder, int TargetPosRadius) { builder.AddInt(5, TargetPosRadius, 0); }
  public static void AddEffectID(FlatBufferBuilder builder, int EffectID) { builder.AddInt(6, EffectID, -1); }
  public static void AddTargetPosZ(FlatBufferBuilder builder, float TargetPosZ) { builder.AddFloat(7, TargetPosZ, 0); }
  public static Offset<FB_MissionEnterArea> EndFB_MissionEnterArea(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionEnterArea>(o);
  }
};

public sealed class FB_MissionEnterAreaContainer : Table {
  public static FB_MissionEnterAreaContainer GetRootAsFB_MissionEnterAreaContainer(ByteBuffer _bb) { return GetRootAsFB_MissionEnterAreaContainer(_bb, new FB_MissionEnterAreaContainer()); }
  public static FB_MissionEnterAreaContainer GetRootAsFB_MissionEnterAreaContainer(ByteBuffer _bb, FB_MissionEnterAreaContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionEnterAreaContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionEnterAreaContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionEnterArea GetItems(int j) { return GetItems(new FB_MissionEnterArea(), j); }
  public FB_MissionEnterArea GetItems(FB_MissionEnterArea obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionEnterAreaContainer> CreateFB_MissionEnterAreaContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionEnterAreaContainer.AddItems(builder, items);
    return FB_MissionEnterAreaContainer.EndFB_MissionEnterAreaContainer(builder);
  }

  public static void StartFB_MissionEnterAreaContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionEnterArea>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionEnterAreaContainer> EndFB_MissionEnterAreaContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionEnterAreaContainer>(o);
  }
  public static void FinishFB_MissionEnterAreaContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionEnterAreaContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
