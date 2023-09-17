// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RealTimeShadowConfig : Table {
  public static FB_RealTimeShadowConfig GetRootAsFB_RealTimeShadowConfig(ByteBuffer _bb) { return GetRootAsFB_RealTimeShadowConfig(_bb, new FB_RealTimeShadowConfig()); }
  public static FB_RealTimeShadowConfig GetRootAsFB_RealTimeShadowConfig(ByteBuffer _bb, FB_RealTimeShadowConfig obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RealTimeShadowConfig __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float Size { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int RenderTextureSize { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AntiAliasing { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ShadowColor { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public float Alpha { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_RealTimeShadowConfig> CreateFB_RealTimeShadowConfig(FlatBufferBuilder builder,
      int Id = 0,
      float Size = 0,
      int RenderTextureSize = 0,
      int AntiAliasing = 0,
      StringOffset ShadowColor = default(StringOffset),
      float Alpha = 0) {
    builder.StartObject(6);
    FB_RealTimeShadowConfig.AddAlpha(builder, Alpha);
    FB_RealTimeShadowConfig.AddShadowColor(builder, ShadowColor);
    FB_RealTimeShadowConfig.AddAntiAliasing(builder, AntiAliasing);
    FB_RealTimeShadowConfig.AddRenderTextureSize(builder, RenderTextureSize);
    FB_RealTimeShadowConfig.AddSize(builder, Size);
    FB_RealTimeShadowConfig.AddId(builder, Id);
    return FB_RealTimeShadowConfig.EndFB_RealTimeShadowConfig(builder);
  }

  public static void StartFB_RealTimeShadowConfig(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddSize(FlatBufferBuilder builder, float Size) { builder.AddFloat(1, Size, 0); }
  public static void AddRenderTextureSize(FlatBufferBuilder builder, int RenderTextureSize) { builder.AddInt(2, RenderTextureSize, 0); }
  public static void AddAntiAliasing(FlatBufferBuilder builder, int AntiAliasing) { builder.AddInt(3, AntiAliasing, 0); }
  public static void AddShadowColor(FlatBufferBuilder builder, StringOffset ShadowColorOffset) { builder.AddOffset(4, ShadowColorOffset.Value, 0); }
  public static void AddAlpha(FlatBufferBuilder builder, float Alpha) { builder.AddFloat(5, Alpha, 0); }
  public static Offset<FB_RealTimeShadowConfig> EndFB_RealTimeShadowConfig(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RealTimeShadowConfig>(o);
  }
};

public sealed class FB_RealTimeShadowConfigContainer : Table {
  public static FB_RealTimeShadowConfigContainer GetRootAsFB_RealTimeShadowConfigContainer(ByteBuffer _bb) { return GetRootAsFB_RealTimeShadowConfigContainer(_bb, new FB_RealTimeShadowConfigContainer()); }
  public static FB_RealTimeShadowConfigContainer GetRootAsFB_RealTimeShadowConfigContainer(ByteBuffer _bb, FB_RealTimeShadowConfigContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RealTimeShadowConfigContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RealTimeShadowConfigContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RealTimeShadowConfig GetItems(int j) { return GetItems(new FB_RealTimeShadowConfig(), j); }
  public FB_RealTimeShadowConfig GetItems(FB_RealTimeShadowConfig obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RealTimeShadowConfigContainer> CreateFB_RealTimeShadowConfigContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RealTimeShadowConfigContainer.AddItems(builder, items);
    return FB_RealTimeShadowConfigContainer.EndFB_RealTimeShadowConfigContainer(builder);
  }

  public static void StartFB_RealTimeShadowConfigContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RealTimeShadowConfig>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RealTimeShadowConfigContainer> EndFB_RealTimeShadowConfigContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RealTimeShadowConfigContainer>(o);
  }
  public static void FinishFB_RealTimeShadowConfigContainerBuffer(FlatBufferBuilder builder, Offset<FB_RealTimeShadowConfigContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
