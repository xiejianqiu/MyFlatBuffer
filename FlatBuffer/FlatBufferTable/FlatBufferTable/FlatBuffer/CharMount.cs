// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CharMount : Table {
  public static FB_CharMount GetRootAsFB_CharMount(ByteBuffer _bb) { return GetRootAsFB_CharMount(_bb, new FB_CharMount()); }
  public static FB_CharMount GetRootAsFB_CharMount(ByteBuffer _bb, FB_CharMount obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CharMount __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ModelId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SoundID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string BindPoint { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float GetHeadInfoAddHeightList(int j) { int o = __offset(14); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int HeadInfoAddHeightListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public float GetFemaleHeadInfoAddHeightList(int j) { int o = __offset(16); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int FemaleHeadInfoAddHeightListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public float FlyAddHeight { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int IdleAnimId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RunAnimId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int XiuXianAnimId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float SoulStarOffsetY { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int BindID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsTeamShip { get { int o = __offset(32); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int UIModelId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float EffectOffsetX { get { int o = __offset(36); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EffectOffsetY { get { int o = __offset(38); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EffectOffsetZ { get { int o = __offset(40); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float CameraDis { get { int o = __offset(42); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float PlayerScale { get { int o = __offset(44); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float GetEffecOffsetYList(int j) { int o = __offset(46); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int EffecOffsetYListLength { get { int o = __offset(46); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharMount> CreateFB_CharMount(FlatBufferBuilder builder,
      int Id = 0,
      int ModelId = -1,
      int SoundID = 0,
      StringOffset BindPoint = default(StringOffset),
      int FakeObjID = 0,
      VectorOffset HeadInfoAddHeightList = default(VectorOffset),
      VectorOffset FemaleHeadInfoAddHeightList = default(VectorOffset),
      float FlyAddHeight = 0,
      float Scale = 0,
      int IdleAnimId = -1,
      int RunAnimId = -1,
      int XiuXianAnimId = -1,
      float SoulStarOffsetY = -1,
      int BindID = -1,
      bool IsTeamShip = false,
      int UIModelId = -1,
      float EffectOffsetX = -1,
      float EffectOffsetY = -1,
      float EffectOffsetZ = -1,
      float CameraDis = -1,
      float PlayerScale = 0,
      VectorOffset EffecOffsetYList = default(VectorOffset)) {
    builder.StartObject(22);
    FB_CharMount.AddEffecOffsetYList(builder, EffecOffsetYList);
    FB_CharMount.AddPlayerScale(builder, PlayerScale);
    FB_CharMount.AddCameraDis(builder, CameraDis);
    FB_CharMount.AddEffectOffsetZ(builder, EffectOffsetZ);
    FB_CharMount.AddEffectOffsetY(builder, EffectOffsetY);
    FB_CharMount.AddEffectOffsetX(builder, EffectOffsetX);
    FB_CharMount.AddUIModelId(builder, UIModelId);
    FB_CharMount.AddBindID(builder, BindID);
    FB_CharMount.AddSoulStarOffsetY(builder, SoulStarOffsetY);
    FB_CharMount.AddXiuXianAnimId(builder, XiuXianAnimId);
    FB_CharMount.AddRunAnimId(builder, RunAnimId);
    FB_CharMount.AddIdleAnimId(builder, IdleAnimId);
    FB_CharMount.AddScale(builder, Scale);
    FB_CharMount.AddFlyAddHeight(builder, FlyAddHeight);
    FB_CharMount.AddFemaleHeadInfoAddHeightList(builder, FemaleHeadInfoAddHeightList);
    FB_CharMount.AddHeadInfoAddHeightList(builder, HeadInfoAddHeightList);
    FB_CharMount.AddFakeObjID(builder, FakeObjID);
    FB_CharMount.AddBindPoint(builder, BindPoint);
    FB_CharMount.AddSoundID(builder, SoundID);
    FB_CharMount.AddModelId(builder, ModelId);
    FB_CharMount.AddId(builder, Id);
    FB_CharMount.AddIsTeamShip(builder, IsTeamShip);
    return FB_CharMount.EndFB_CharMount(builder);
  }

  public static void StartFB_CharMount(FlatBufferBuilder builder) { builder.StartObject(22); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddModelId(FlatBufferBuilder builder, int ModelId) { builder.AddInt(1, ModelId, -1); }
  public static void AddSoundID(FlatBufferBuilder builder, int SoundID) { builder.AddInt(2, SoundID, 0); }
  public static void AddBindPoint(FlatBufferBuilder builder, StringOffset BindPointOffset) { builder.AddOffset(3, BindPointOffset.Value, 0); }
  public static void AddFakeObjID(FlatBufferBuilder builder, int FakeObjID) { builder.AddInt(4, FakeObjID, 0); }
  public static void AddHeadInfoAddHeightList(FlatBufferBuilder builder, VectorOffset HeadInfoAddHeightListOffset) { builder.AddOffset(5, HeadInfoAddHeightListOffset.Value, 0); }
  public static VectorOffset CreateHeadInfoAddHeightListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartHeadInfoAddHeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFemaleHeadInfoAddHeightList(FlatBufferBuilder builder, VectorOffset FemaleHeadInfoAddHeightListOffset) { builder.AddOffset(6, FemaleHeadInfoAddHeightListOffset.Value, 0); }
  public static VectorOffset CreateFemaleHeadInfoAddHeightListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartFemaleHeadInfoAddHeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFlyAddHeight(FlatBufferBuilder builder, float FlyAddHeight) { builder.AddFloat(7, FlyAddHeight, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(8, Scale, 0); }
  public static void AddIdleAnimId(FlatBufferBuilder builder, int IdleAnimId) { builder.AddInt(9, IdleAnimId, -1); }
  public static void AddRunAnimId(FlatBufferBuilder builder, int RunAnimId) { builder.AddInt(10, RunAnimId, -1); }
  public static void AddXiuXianAnimId(FlatBufferBuilder builder, int XiuXianAnimId) { builder.AddInt(11, XiuXianAnimId, -1); }
  public static void AddSoulStarOffsetY(FlatBufferBuilder builder, float SoulStarOffsetY) { builder.AddFloat(12, SoulStarOffsetY, -1); }
  public static void AddBindID(FlatBufferBuilder builder, int BindID) { builder.AddInt(13, BindID, -1); }
  public static void AddIsTeamShip(FlatBufferBuilder builder, bool IsTeamShip) { builder.AddBool(14, IsTeamShip, false); }
  public static void AddUIModelId(FlatBufferBuilder builder, int UIModelId) { builder.AddInt(15, UIModelId, -1); }
  public static void AddEffectOffsetX(FlatBufferBuilder builder, float EffectOffsetX) { builder.AddFloat(16, EffectOffsetX, -1); }
  public static void AddEffectOffsetY(FlatBufferBuilder builder, float EffectOffsetY) { builder.AddFloat(17, EffectOffsetY, -1); }
  public static void AddEffectOffsetZ(FlatBufferBuilder builder, float EffectOffsetZ) { builder.AddFloat(18, EffectOffsetZ, -1); }
  public static void AddCameraDis(FlatBufferBuilder builder, float CameraDis) { builder.AddFloat(19, CameraDis, -1); }
  public static void AddPlayerScale(FlatBufferBuilder builder, float PlayerScale) { builder.AddFloat(20, PlayerScale, 0); }
  public static void AddEffecOffsetYList(FlatBufferBuilder builder, VectorOffset EffecOffsetYListOffset) { builder.AddOffset(21, EffecOffsetYListOffset.Value, 0); }
  public static VectorOffset CreateEffecOffsetYListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartEffecOffsetYListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharMount> EndFB_CharMount(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharMount>(o);
  }
};

public sealed class FB_CharMountContainer : Table {
  public static FB_CharMountContainer GetRootAsFB_CharMountContainer(ByteBuffer _bb) { return GetRootAsFB_CharMountContainer(_bb, new FB_CharMountContainer()); }
  public static FB_CharMountContainer GetRootAsFB_CharMountContainer(ByteBuffer _bb, FB_CharMountContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CharMountContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CharMountContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CharMount GetItems(int j) { return GetItems(new FB_CharMount(), j); }
  public FB_CharMount GetItems(FB_CharMount obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharMountContainer> CreateFB_CharMountContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CharMountContainer.AddItems(builder, items);
    return FB_CharMountContainer.EndFB_CharMountContainer(builder);
  }

  public static void StartFB_CharMountContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CharMount>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharMountContainer> EndFB_CharMountContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharMountContainer>(o);
  }
  public static void FinishFB_CharMountContainerBuffer(FlatBufferBuilder builder, Offset<FB_CharMountContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
