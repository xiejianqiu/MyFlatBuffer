// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AnimationCurve : Table {
  public static FB_AnimationCurve GetRootAsFB_AnimationCurve(ByteBuffer _bb) { return GetRootAsFB_AnimationCurve(_bb, new FB_AnimationCurve()); }
  public static FB_AnimationCurve GetRootAsFB_AnimationCurve(ByteBuffer _bb, FB_AnimationCurve obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AnimationCurve __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetTimeList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TimeListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public float GetSpeedXList(int j) { int o = __offset(8); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int SpeedXListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public float GetSpeedYList(int j) { int o = __offset(10); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int SpeedYListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public float GetSpeedZList(int j) { int o = __offset(12); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int SpeedZListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AnimationCurve> CreateFB_AnimationCurve(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset TimeList = default(VectorOffset),
      VectorOffset SpeedXList = default(VectorOffset),
      VectorOffset SpeedYList = default(VectorOffset),
      VectorOffset SpeedZList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_AnimationCurve.AddSpeedZList(builder, SpeedZList);
    FB_AnimationCurve.AddSpeedYList(builder, SpeedYList);
    FB_AnimationCurve.AddSpeedXList(builder, SpeedXList);
    FB_AnimationCurve.AddTimeList(builder, TimeList);
    FB_AnimationCurve.AddId(builder, Id);
    return FB_AnimationCurve.EndFB_AnimationCurve(builder);
  }

  public static void StartFB_AnimationCurve(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTimeList(FlatBufferBuilder builder, VectorOffset TimeListOffset) { builder.AddOffset(1, TimeListOffset.Value, 0); }
  public static VectorOffset CreateTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpeedXList(FlatBufferBuilder builder, VectorOffset SpeedXListOffset) { builder.AddOffset(2, SpeedXListOffset.Value, 0); }
  public static VectorOffset CreateSpeedXListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartSpeedXListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpeedYList(FlatBufferBuilder builder, VectorOffset SpeedYListOffset) { builder.AddOffset(3, SpeedYListOffset.Value, 0); }
  public static VectorOffset CreateSpeedYListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartSpeedYListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpeedZList(FlatBufferBuilder builder, VectorOffset SpeedZListOffset) { builder.AddOffset(4, SpeedZListOffset.Value, 0); }
  public static VectorOffset CreateSpeedZListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartSpeedZListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AnimationCurve> EndFB_AnimationCurve(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AnimationCurve>(o);
  }
};

public sealed class FB_AnimationCurveContainer : Table {
  public static FB_AnimationCurveContainer GetRootAsFB_AnimationCurveContainer(ByteBuffer _bb) { return GetRootAsFB_AnimationCurveContainer(_bb, new FB_AnimationCurveContainer()); }
  public static FB_AnimationCurveContainer GetRootAsFB_AnimationCurveContainer(ByteBuffer _bb, FB_AnimationCurveContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AnimationCurveContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AnimationCurveContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AnimationCurve GetItems(int j) { return GetItems(new FB_AnimationCurve(), j); }
  public FB_AnimationCurve GetItems(FB_AnimationCurve obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AnimationCurveContainer> CreateFB_AnimationCurveContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AnimationCurveContainer.AddItems(builder, items);
    return FB_AnimationCurveContainer.EndFB_AnimationCurveContainer(builder);
  }

  public static void StartFB_AnimationCurveContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AnimationCurve>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AnimationCurveContainer> EndFB_AnimationCurveContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AnimationCurveContainer>(o);
  }
  public static void FinishFB_AnimationCurveContainerBuffer(FlatBufferBuilder builder, Offset<FB_AnimationCurveContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
