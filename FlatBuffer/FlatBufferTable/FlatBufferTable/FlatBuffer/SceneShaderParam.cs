// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SceneShaderParam : Table {
  public static FB_SceneShaderParam GetRootAsFB_SceneShaderParam(ByteBuffer _bb) { return GetRootAsFB_SceneShaderParam(_bb, new FB_SceneShaderParam()); }
  public static FB_SceneShaderParam GetRootAsFB_SceneShaderParam(ByteBuffer _bb, FB_SceneShaderParam obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SceneShaderParam __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float FirstDiffusePower { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float SecondDiffusePower { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FirstFinalPower { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float SecondFinalPower { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FirstShadowFactor { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float SecondShadowFactor { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FogStart { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FogEnd { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FogHightPower { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FakeLightDirX { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FakeLightDirY { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FakeLightDirZ { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int Ambient { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float FogLowLimit { get { int o = __offset(32); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FogPowerLimit { get { int o = __offset(34); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public bool IsWeather { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int PBRAmbientColorDay { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PBRLightColorDay { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PBRBackLightColorDay { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PBRAmbientColorNight { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PBRLightColorNight { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PBRBackLightColorNight { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SceneShaderParam> CreateFB_SceneShaderParam(FlatBufferBuilder builder,
      int ID = 0,
      float FirstDiffusePower = -1,
      float SecondDiffusePower = -1,
      float FirstFinalPower = -1,
      float SecondFinalPower = -1,
      float FirstShadowFactor = -1,
      float SecondShadowFactor = -1,
      float FogStart = -1,
      float FogEnd = -1,
      float FogHightPower = -1,
      float FakeLightDirX = -1,
      float FakeLightDirY = -1,
      float FakeLightDirZ = -1,
      int Ambient = -1,
      float FogLowLimit = -1,
      float FogPowerLimit = -1,
      bool IsWeather = true,
      int PBRAmbientColorDay = -1,
      int PBRLightColorDay = -1,
      int PBRBackLightColorDay = -1,
      int PBRAmbientColorNight = -1,
      int PBRLightColorNight = -1,
      int PBRBackLightColorNight = -1) {
    builder.StartObject(23);
    FB_SceneShaderParam.AddPBRBackLightColorNight(builder, PBRBackLightColorNight);
    FB_SceneShaderParam.AddPBRLightColorNight(builder, PBRLightColorNight);
    FB_SceneShaderParam.AddPBRAmbientColorNight(builder, PBRAmbientColorNight);
    FB_SceneShaderParam.AddPBRBackLightColorDay(builder, PBRBackLightColorDay);
    FB_SceneShaderParam.AddPBRLightColorDay(builder, PBRLightColorDay);
    FB_SceneShaderParam.AddPBRAmbientColorDay(builder, PBRAmbientColorDay);
    FB_SceneShaderParam.AddFogPowerLimit(builder, FogPowerLimit);
    FB_SceneShaderParam.AddFogLowLimit(builder, FogLowLimit);
    FB_SceneShaderParam.AddAmbient(builder, Ambient);
    FB_SceneShaderParam.AddFakeLightDirZ(builder, FakeLightDirZ);
    FB_SceneShaderParam.AddFakeLightDirY(builder, FakeLightDirY);
    FB_SceneShaderParam.AddFakeLightDirX(builder, FakeLightDirX);
    FB_SceneShaderParam.AddFogHightPower(builder, FogHightPower);
    FB_SceneShaderParam.AddFogEnd(builder, FogEnd);
    FB_SceneShaderParam.AddFogStart(builder, FogStart);
    FB_SceneShaderParam.AddSecondShadowFactor(builder, SecondShadowFactor);
    FB_SceneShaderParam.AddFirstShadowFactor(builder, FirstShadowFactor);
    FB_SceneShaderParam.AddSecondFinalPower(builder, SecondFinalPower);
    FB_SceneShaderParam.AddFirstFinalPower(builder, FirstFinalPower);
    FB_SceneShaderParam.AddSecondDiffusePower(builder, SecondDiffusePower);
    FB_SceneShaderParam.AddFirstDiffusePower(builder, FirstDiffusePower);
    FB_SceneShaderParam.AddID(builder, ID);
    FB_SceneShaderParam.AddIsWeather(builder, IsWeather);
    return FB_SceneShaderParam.EndFB_SceneShaderParam(builder);
  }

  public static void StartFB_SceneShaderParam(FlatBufferBuilder builder) { builder.StartObject(23); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddFirstDiffusePower(FlatBufferBuilder builder, float FirstDiffusePower) { builder.AddFloat(1, FirstDiffusePower, -1); }
  public static void AddSecondDiffusePower(FlatBufferBuilder builder, float SecondDiffusePower) { builder.AddFloat(2, SecondDiffusePower, -1); }
  public static void AddFirstFinalPower(FlatBufferBuilder builder, float FirstFinalPower) { builder.AddFloat(3, FirstFinalPower, -1); }
  public static void AddSecondFinalPower(FlatBufferBuilder builder, float SecondFinalPower) { builder.AddFloat(4, SecondFinalPower, -1); }
  public static void AddFirstShadowFactor(FlatBufferBuilder builder, float FirstShadowFactor) { builder.AddFloat(5, FirstShadowFactor, -1); }
  public static void AddSecondShadowFactor(FlatBufferBuilder builder, float SecondShadowFactor) { builder.AddFloat(6, SecondShadowFactor, -1); }
  public static void AddFogStart(FlatBufferBuilder builder, float FogStart) { builder.AddFloat(7, FogStart, -1); }
  public static void AddFogEnd(FlatBufferBuilder builder, float FogEnd) { builder.AddFloat(8, FogEnd, -1); }
  public static void AddFogHightPower(FlatBufferBuilder builder, float FogHightPower) { builder.AddFloat(9, FogHightPower, -1); }
  public static void AddFakeLightDirX(FlatBufferBuilder builder, float FakeLightDirX) { builder.AddFloat(10, FakeLightDirX, -1); }
  public static void AddFakeLightDirY(FlatBufferBuilder builder, float FakeLightDirY) { builder.AddFloat(11, FakeLightDirY, -1); }
  public static void AddFakeLightDirZ(FlatBufferBuilder builder, float FakeLightDirZ) { builder.AddFloat(12, FakeLightDirZ, -1); }
  public static void AddAmbient(FlatBufferBuilder builder, int Ambient) { builder.AddInt(13, Ambient, -1); }
  public static void AddFogLowLimit(FlatBufferBuilder builder, float FogLowLimit) { builder.AddFloat(14, FogLowLimit, -1); }
  public static void AddFogPowerLimit(FlatBufferBuilder builder, float FogPowerLimit) { builder.AddFloat(15, FogPowerLimit, -1); }
  public static void AddIsWeather(FlatBufferBuilder builder, bool IsWeather) { builder.AddBool(16, IsWeather, true); }
  public static void AddPBRAmbientColorDay(FlatBufferBuilder builder, int PBRAmbientColorDay) { builder.AddInt(17, PBRAmbientColorDay, -1); }
  public static void AddPBRLightColorDay(FlatBufferBuilder builder, int PBRLightColorDay) { builder.AddInt(18, PBRLightColorDay, -1); }
  public static void AddPBRBackLightColorDay(FlatBufferBuilder builder, int PBRBackLightColorDay) { builder.AddInt(19, PBRBackLightColorDay, -1); }
  public static void AddPBRAmbientColorNight(FlatBufferBuilder builder, int PBRAmbientColorNight) { builder.AddInt(20, PBRAmbientColorNight, -1); }
  public static void AddPBRLightColorNight(FlatBufferBuilder builder, int PBRLightColorNight) { builder.AddInt(21, PBRLightColorNight, -1); }
  public static void AddPBRBackLightColorNight(FlatBufferBuilder builder, int PBRBackLightColorNight) { builder.AddInt(22, PBRBackLightColorNight, -1); }
  public static Offset<FB_SceneShaderParam> EndFB_SceneShaderParam(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneShaderParam>(o);
  }
};

public sealed class FB_SceneShaderParamContainer : Table {
  public static FB_SceneShaderParamContainer GetRootAsFB_SceneShaderParamContainer(ByteBuffer _bb) { return GetRootAsFB_SceneShaderParamContainer(_bb, new FB_SceneShaderParamContainer()); }
  public static FB_SceneShaderParamContainer GetRootAsFB_SceneShaderParamContainer(ByteBuffer _bb, FB_SceneShaderParamContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SceneShaderParamContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SceneShaderParamContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SceneShaderParam GetItems(int j) { return GetItems(new FB_SceneShaderParam(), j); }
  public FB_SceneShaderParam GetItems(FB_SceneShaderParam obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneShaderParamContainer> CreateFB_SceneShaderParamContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SceneShaderParamContainer.AddItems(builder, items);
    return FB_SceneShaderParamContainer.EndFB_SceneShaderParamContainer(builder);
  }

  public static void StartFB_SceneShaderParamContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SceneShaderParam>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneShaderParamContainer> EndFB_SceneShaderParamContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneShaderParamContainer>(o);
  }
  public static void FinishFB_SceneShaderParamContainerBuffer(FlatBufferBuilder builder, Offset<FB_SceneShaderParamContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
