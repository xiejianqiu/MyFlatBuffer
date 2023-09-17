// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CameraEffect : Table {
  public static FB_CameraEffect GetRootAsFB_CameraEffect(ByteBuffer _bb) { return GetRootAsFB_CameraEffect(_bb, new FB_CameraEffect()); }
  public static FB_CameraEffect GetRootAsFB_CameraEffect(ByteBuffer _bb, FB_CameraEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CameraEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float GetParamList(int j) { int o = __offset(8); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int ParamListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CameraEffect> CreateFB_CameraEffect(FlatBufferBuilder builder,
      int Id = 0,
      int Type = -1,
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_CameraEffect.AddParamList(builder, ParamList);
    FB_CameraEffect.AddType(builder, Type);
    FB_CameraEffect.AddId(builder, Id);
    return FB_CameraEffect.EndFB_CameraEffect(builder);
  }

  public static void StartFB_CameraEffect(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(2, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CameraEffect> EndFB_CameraEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CameraEffect>(o);
  }
};

public sealed class FB_CameraEffectContainer : Table {
  public static FB_CameraEffectContainer GetRootAsFB_CameraEffectContainer(ByteBuffer _bb) { return GetRootAsFB_CameraEffectContainer(_bb, new FB_CameraEffectContainer()); }
  public static FB_CameraEffectContainer GetRootAsFB_CameraEffectContainer(ByteBuffer _bb, FB_CameraEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CameraEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CameraEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CameraEffect GetItems(int j) { return GetItems(new FB_CameraEffect(), j); }
  public FB_CameraEffect GetItems(FB_CameraEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CameraEffectContainer> CreateFB_CameraEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CameraEffectContainer.AddItems(builder, items);
    return FB_CameraEffectContainer.EndFB_CameraEffectContainer(builder);
  }

  public static void StartFB_CameraEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CameraEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CameraEffectContainer> EndFB_CameraEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CameraEffectContainer>(o);
  }
  public static void FinishFB_CameraEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_CameraEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
