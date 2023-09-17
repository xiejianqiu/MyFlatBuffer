// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Animation : Table {
  public static FB_Animation GetRootAsFB_Animation(ByteBuffer _bb) { return GetRootAsFB_Animation(_bb, new FB_Animation()); }
  public static FB_Animation GetRootAsFB_Animation(ByteBuffer _bb, FB_Animation obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Animation __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int AnimID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string AinmName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Layer { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int WrapMode { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int ShakeId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float TransitTime { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool IsCanBreak { get { int o = __offset(16); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetStartEffectList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StartEffectListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsCallEnd { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int NextAnimId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SoundID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int IdCameraAnimCurve { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CloseUpShot { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WeaponTransformationId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UISpecialHideId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillCamAnimId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_Animation> CreateFB_Animation(FlatBufferBuilder builder,
      int AnimID = 0,
      StringOffset AinmName = default(StringOffset),
      int Layer = 0,
      int WrapMode = 1,
      int ShakeId = -1,
      float TransitTime = 0,
      bool IsCanBreak = false,
      VectorOffset StartEffectList = default(VectorOffset),
      bool IsCallEnd = true,
      int NextAnimId = -1,
      int SoundID = -1,
      int IdCameraAnimCurve = -1,
      int CloseUpShot = -1,
      int WeaponTransformationId = -1,
      int UISpecialHideId = -1,
      int SkillCamAnimId = -1) {
    builder.StartObject(16);
    FB_Animation.AddSkillCamAnimId(builder, SkillCamAnimId);
    FB_Animation.AddUISpecialHideId(builder, UISpecialHideId);
    FB_Animation.AddWeaponTransformationId(builder, WeaponTransformationId);
    FB_Animation.AddCloseUpShot(builder, CloseUpShot);
    FB_Animation.AddIdCameraAnimCurve(builder, IdCameraAnimCurve);
    FB_Animation.AddSoundID(builder, SoundID);
    FB_Animation.AddNextAnimId(builder, NextAnimId);
    FB_Animation.AddStartEffectList(builder, StartEffectList);
    FB_Animation.AddTransitTime(builder, TransitTime);
    FB_Animation.AddShakeId(builder, ShakeId);
    FB_Animation.AddWrapMode(builder, WrapMode);
    FB_Animation.AddLayer(builder, Layer);
    FB_Animation.AddAinmName(builder, AinmName);
    FB_Animation.AddAnimID(builder, AnimID);
    FB_Animation.AddIsCallEnd(builder, IsCallEnd);
    FB_Animation.AddIsCanBreak(builder, IsCanBreak);
    return FB_Animation.EndFB_Animation(builder);
  }

  public static void StartFB_Animation(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddAnimID(FlatBufferBuilder builder, int AnimID) { builder.AddInt(0, AnimID, 0); }
  public static void AddAinmName(FlatBufferBuilder builder, StringOffset AinmNameOffset) { builder.AddOffset(1, AinmNameOffset.Value, 0); }
  public static void AddLayer(FlatBufferBuilder builder, int Layer) { builder.AddInt(2, Layer, 0); }
  public static void AddWrapMode(FlatBufferBuilder builder, int WrapMode) { builder.AddInt(3, WrapMode, 1); }
  public static void AddShakeId(FlatBufferBuilder builder, int ShakeId) { builder.AddInt(4, ShakeId, -1); }
  public static void AddTransitTime(FlatBufferBuilder builder, float TransitTime) { builder.AddFloat(5, TransitTime, 0); }
  public static void AddIsCanBreak(FlatBufferBuilder builder, bool IsCanBreak) { builder.AddBool(6, IsCanBreak, false); }
  public static void AddStartEffectList(FlatBufferBuilder builder, VectorOffset StartEffectListOffset) { builder.AddOffset(7, StartEffectListOffset.Value, 0); }
  public static VectorOffset CreateStartEffectListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStartEffectListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsCallEnd(FlatBufferBuilder builder, bool IsCallEnd) { builder.AddBool(8, IsCallEnd, true); }
  public static void AddNextAnimId(FlatBufferBuilder builder, int NextAnimId) { builder.AddInt(9, NextAnimId, -1); }
  public static void AddSoundID(FlatBufferBuilder builder, int SoundID) { builder.AddInt(10, SoundID, -1); }
  public static void AddIdCameraAnimCurve(FlatBufferBuilder builder, int IdCameraAnimCurve) { builder.AddInt(11, IdCameraAnimCurve, -1); }
  public static void AddCloseUpShot(FlatBufferBuilder builder, int CloseUpShot) { builder.AddInt(12, CloseUpShot, -1); }
  public static void AddWeaponTransformationId(FlatBufferBuilder builder, int WeaponTransformationId) { builder.AddInt(13, WeaponTransformationId, -1); }
  public static void AddUISpecialHideId(FlatBufferBuilder builder, int UISpecialHideId) { builder.AddInt(14, UISpecialHideId, -1); }
  public static void AddSkillCamAnimId(FlatBufferBuilder builder, int SkillCamAnimId) { builder.AddInt(15, SkillCamAnimId, -1); }
  public static Offset<FB_Animation> EndFB_Animation(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Animation>(o);
  }
};

public sealed class FB_AnimationContainer : Table {
  public static FB_AnimationContainer GetRootAsFB_AnimationContainer(ByteBuffer _bb) { return GetRootAsFB_AnimationContainer(_bb, new FB_AnimationContainer()); }
  public static FB_AnimationContainer GetRootAsFB_AnimationContainer(ByteBuffer _bb, FB_AnimationContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AnimationContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AnimationContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Animation GetItems(int j) { return GetItems(new FB_Animation(), j); }
  public FB_Animation GetItems(FB_Animation obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AnimationContainer> CreateFB_AnimationContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AnimationContainer.AddItems(builder, items);
    return FB_AnimationContainer.EndFB_AnimationContainer(builder);
  }

  public static void StartFB_AnimationContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Animation>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AnimationContainer> EndFB_AnimationContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AnimationContainer>(o);
  }
  public static void FinishFB_AnimationContainerBuffer(FlatBufferBuilder builder, Offset<FB_AnimationContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
