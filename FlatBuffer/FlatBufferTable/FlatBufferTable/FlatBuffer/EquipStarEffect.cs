// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipStarEffect : Table {
  public static FB_EquipStarEffect GetRootAsFB_EquipStarEffect(ByteBuffer _bb) { return GetRootAsFB_EquipStarEffect(_bb, new FB_EquipStarEffect()); }
  public static FB_EquipStarEffect GetRootAsFB_EquipStarEffect(ByteBuffer _bb, FB_EquipStarEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipStarEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GetEffectPathList(int j) { int o = __offset(6); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int EffectPathListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int StarCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MountPoint { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ExclusionId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GetLightColorList(int j) { int o = __offset(14); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int LightColorListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public float GetLightPowerList(int j) { int o = __offset(16); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int LightPowerListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public string GetRimbColorList(int j) { int o = __offset(18); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int RimbColorListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public float GetRimbPowerList(int j) { int o = __offset(20); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int RimbPowerListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public float GetRimbWidthList(int j) { int o = __offset(22); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int RimbWidthListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipStarEffect> CreateFB_EquipStarEffect(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset EffectPathList = default(VectorOffset),
      int StarCount = 0,
      StringOffset MountPoint = default(StringOffset),
      int ExclusionId = 0,
      VectorOffset LightColorList = default(VectorOffset),
      VectorOffset LightPowerList = default(VectorOffset),
      VectorOffset RimbColorList = default(VectorOffset),
      VectorOffset RimbPowerList = default(VectorOffset),
      VectorOffset RimbWidthList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_EquipStarEffect.AddRimbWidthList(builder, RimbWidthList);
    FB_EquipStarEffect.AddRimbPowerList(builder, RimbPowerList);
    FB_EquipStarEffect.AddRimbColorList(builder, RimbColorList);
    FB_EquipStarEffect.AddLightPowerList(builder, LightPowerList);
    FB_EquipStarEffect.AddLightColorList(builder, LightColorList);
    FB_EquipStarEffect.AddExclusionId(builder, ExclusionId);
    FB_EquipStarEffect.AddMountPoint(builder, MountPoint);
    FB_EquipStarEffect.AddStarCount(builder, StarCount);
    FB_EquipStarEffect.AddEffectPathList(builder, EffectPathList);
    FB_EquipStarEffect.AddID(builder, ID);
    return FB_EquipStarEffect.EndFB_EquipStarEffect(builder);
  }

  public static void StartFB_EquipStarEffect(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddEffectPathList(FlatBufferBuilder builder, VectorOffset EffectPathListOffset) { builder.AddOffset(1, EffectPathListOffset.Value, 0); }
  public static VectorOffset CreateEffectPathListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartEffectPathListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(2, StarCount, 0); }
  public static void AddMountPoint(FlatBufferBuilder builder, StringOffset MountPointOffset) { builder.AddOffset(3, MountPointOffset.Value, 0); }
  public static void AddExclusionId(FlatBufferBuilder builder, int ExclusionId) { builder.AddInt(4, ExclusionId, 0); }
  public static void AddLightColorList(FlatBufferBuilder builder, VectorOffset LightColorListOffset) { builder.AddOffset(5, LightColorListOffset.Value, 0); }
  public static VectorOffset CreateLightColorListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartLightColorListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLightPowerList(FlatBufferBuilder builder, VectorOffset LightPowerListOffset) { builder.AddOffset(6, LightPowerListOffset.Value, 0); }
  public static VectorOffset CreateLightPowerListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartLightPowerListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRimbColorList(FlatBufferBuilder builder, VectorOffset RimbColorListOffset) { builder.AddOffset(7, RimbColorListOffset.Value, 0); }
  public static VectorOffset CreateRimbColorListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartRimbColorListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRimbPowerList(FlatBufferBuilder builder, VectorOffset RimbPowerListOffset) { builder.AddOffset(8, RimbPowerListOffset.Value, 0); }
  public static VectorOffset CreateRimbPowerListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartRimbPowerListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRimbWidthList(FlatBufferBuilder builder, VectorOffset RimbWidthListOffset) { builder.AddOffset(9, RimbWidthListOffset.Value, 0); }
  public static VectorOffset CreateRimbWidthListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartRimbWidthListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipStarEffect> EndFB_EquipStarEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipStarEffect>(o);
  }
};

public sealed class FB_EquipStarEffectContainer : Table {
  public static FB_EquipStarEffectContainer GetRootAsFB_EquipStarEffectContainer(ByteBuffer _bb) { return GetRootAsFB_EquipStarEffectContainer(_bb, new FB_EquipStarEffectContainer()); }
  public static FB_EquipStarEffectContainer GetRootAsFB_EquipStarEffectContainer(ByteBuffer _bb, FB_EquipStarEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipStarEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipStarEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipStarEffect GetItems(int j) { return GetItems(new FB_EquipStarEffect(), j); }
  public FB_EquipStarEffect GetItems(FB_EquipStarEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipStarEffectContainer> CreateFB_EquipStarEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipStarEffectContainer.AddItems(builder, items);
    return FB_EquipStarEffectContainer.EndFB_EquipStarEffectContainer(builder);
  }

  public static void StartFB_EquipStarEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipStarEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipStarEffectContainer> EndFB_EquipStarEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipStarEffectContainer>(o);
  }
  public static void FinishFB_EquipStarEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipStarEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
