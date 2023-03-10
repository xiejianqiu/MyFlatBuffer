// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Effect : Table {
  public static FB_Effect GetRootAsFB_Effect(ByteBuffer _bb) { return GetRootAsFB_Effect(_bb, new FB_Effect()); }
  public static FB_Effect GetRootAsFB_Effect(ByteBuffer _bb, FB_Effect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Effect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int EffectID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Path { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public float DelayTime { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool IsDestroy { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public string ParentName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsFellowOwner { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public float PosX { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotationX { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotationY { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float RotationZ { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Duration { get { int o = __offset(30); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int NextID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool BreakEffect { get { int o = __offset(34); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsRotateOwner { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsRefCount { get { int o = __offset(38); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool DestroyOnBlood { get { int o = __offset(40); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsNeedMountOffset { get { int o = __offset(42); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int Sound { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_Effect> CreateFB_Effect(FlatBufferBuilder builder,
      int EffectID = 0,
      StringOffset Path = default(StringOffset),
      float DelayTime = 0,
      bool IsDestroy = true,
      StringOffset ParentName = default(StringOffset),
      bool IsFellowOwner = true,
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0,
      float RotationX = 0,
      float RotationY = 0,
      float RotationZ = 0,
      float Scale = 0,
      float Duration = 0,
      int NextID = -1,
      bool BreakEffect = false,
      bool IsRotateOwner = true,
      bool IsRefCount = false,
      bool DestroyOnBlood = false,
      bool IsNeedMountOffset = false,
      int Sound = -1) {
    builder.StartObject(21);
    FB_Effect.AddSound(builder, Sound);
    FB_Effect.AddNextID(builder, NextID);
    FB_Effect.AddDuration(builder, Duration);
    FB_Effect.AddScale(builder, Scale);
    FB_Effect.AddRotationZ(builder, RotationZ);
    FB_Effect.AddRotationY(builder, RotationY);
    FB_Effect.AddRotationX(builder, RotationX);
    FB_Effect.AddPosZ(builder, PosZ);
    FB_Effect.AddPosY(builder, PosY);
    FB_Effect.AddPosX(builder, PosX);
    FB_Effect.AddParentName(builder, ParentName);
    FB_Effect.AddDelayTime(builder, DelayTime);
    FB_Effect.AddPath(builder, Path);
    FB_Effect.AddEffectID(builder, EffectID);
    FB_Effect.AddIsNeedMountOffset(builder, IsNeedMountOffset);
    FB_Effect.AddDestroyOnBlood(builder, DestroyOnBlood);
    FB_Effect.AddIsRefCount(builder, IsRefCount);
    FB_Effect.AddIsRotateOwner(builder, IsRotateOwner);
    FB_Effect.AddBreakEffect(builder, BreakEffect);
    FB_Effect.AddIsFellowOwner(builder, IsFellowOwner);
    FB_Effect.AddIsDestroy(builder, IsDestroy);
    return FB_Effect.EndFB_Effect(builder);
  }

  public static void StartFB_Effect(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddEffectID(FlatBufferBuilder builder, int EffectID) { builder.AddInt(0, EffectID, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(1, PathOffset.Value, 0); }
  public static void AddDelayTime(FlatBufferBuilder builder, float DelayTime) { builder.AddFloat(2, DelayTime, 0); }
  public static void AddIsDestroy(FlatBufferBuilder builder, bool IsDestroy) { builder.AddBool(3, IsDestroy, true); }
  public static void AddParentName(FlatBufferBuilder builder, StringOffset ParentNameOffset) { builder.AddOffset(4, ParentNameOffset.Value, 0); }
  public static void AddIsFellowOwner(FlatBufferBuilder builder, bool IsFellowOwner) { builder.AddBool(5, IsFellowOwner, true); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(6, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(7, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(8, PosZ, 0); }
  public static void AddRotationX(FlatBufferBuilder builder, float RotationX) { builder.AddFloat(9, RotationX, 0); }
  public static void AddRotationY(FlatBufferBuilder builder, float RotationY) { builder.AddFloat(10, RotationY, 0); }
  public static void AddRotationZ(FlatBufferBuilder builder, float RotationZ) { builder.AddFloat(11, RotationZ, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(12, Scale, 0); }
  public static void AddDuration(FlatBufferBuilder builder, float Duration) { builder.AddFloat(13, Duration, 0); }
  public static void AddNextID(FlatBufferBuilder builder, int NextID) { builder.AddInt(14, NextID, -1); }
  public static void AddBreakEffect(FlatBufferBuilder builder, bool BreakEffect) { builder.AddBool(15, BreakEffect, false); }
  public static void AddIsRotateOwner(FlatBufferBuilder builder, bool IsRotateOwner) { builder.AddBool(16, IsRotateOwner, true); }
  public static void AddIsRefCount(FlatBufferBuilder builder, bool IsRefCount) { builder.AddBool(17, IsRefCount, false); }
  public static void AddDestroyOnBlood(FlatBufferBuilder builder, bool DestroyOnBlood) { builder.AddBool(18, DestroyOnBlood, false); }
  public static void AddIsNeedMountOffset(FlatBufferBuilder builder, bool IsNeedMountOffset) { builder.AddBool(19, IsNeedMountOffset, false); }
  public static void AddSound(FlatBufferBuilder builder, int Sound) { builder.AddInt(20, Sound, -1); }
  public static Offset<FB_Effect> EndFB_Effect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Effect>(o);
  }
};

public sealed class FB_EffectContainer : Table {
  public static FB_EffectContainer GetRootAsFB_EffectContainer(ByteBuffer _bb) { return GetRootAsFB_EffectContainer(_bb, new FB_EffectContainer()); }
  public static FB_EffectContainer GetRootAsFB_EffectContainer(ByteBuffer _bb, FB_EffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Effect GetItems(int j) { return GetItems(new FB_Effect(), j); }
  public FB_Effect GetItems(FB_Effect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EffectContainer> CreateFB_EffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EffectContainer.AddItems(builder, items);
    return FB_EffectContainer.EndFB_EffectContainer(builder);
  }

  public static void StartFB_EffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Effect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EffectContainer> EndFB_EffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EffectContainer>(o);
  }
  public static void FinishFB_EffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_EffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
