// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShakeCamera : Table {
  public static FB_ShakeCamera GetRootAsFB_ShakeCamera(ByteBuffer _bb) { return GetRootAsFB_ShakeCamera(_bb, new FB_ShakeCamera()); }
  public static FB_ShakeCamera GetRootAsFB_ShakeCamera(ByteBuffer _bb, FB_ShakeCamera obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShakeCamera __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ShakeCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)10; } }
  public float ShakeInterval { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ShakePower { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int ShakeMode { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public float ReduceFactor { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Delay { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int HpShakeRate { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ShakeCamera> CreateFB_ShakeCamera(FlatBufferBuilder builder,
      int Id = 0,
      int ShakeCount = 10,
      float ShakeInterval = 0,
      float ShakePower = 0,
      int ShakeMode = 1,
      float ReduceFactor = 0,
      float Delay = 0,
      int HpShakeRate = 0) {
    builder.StartObject(8);
    FB_ShakeCamera.AddHpShakeRate(builder, HpShakeRate);
    FB_ShakeCamera.AddDelay(builder, Delay);
    FB_ShakeCamera.AddReduceFactor(builder, ReduceFactor);
    FB_ShakeCamera.AddShakeMode(builder, ShakeMode);
    FB_ShakeCamera.AddShakePower(builder, ShakePower);
    FB_ShakeCamera.AddShakeInterval(builder, ShakeInterval);
    FB_ShakeCamera.AddShakeCount(builder, ShakeCount);
    FB_ShakeCamera.AddId(builder, Id);
    return FB_ShakeCamera.EndFB_ShakeCamera(builder);
  }

  public static void StartFB_ShakeCamera(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddShakeCount(FlatBufferBuilder builder, int ShakeCount) { builder.AddInt(1, ShakeCount, 10); }
  public static void AddShakeInterval(FlatBufferBuilder builder, float ShakeInterval) { builder.AddFloat(2, ShakeInterval, 0); }
  public static void AddShakePower(FlatBufferBuilder builder, float ShakePower) { builder.AddFloat(3, ShakePower, 0); }
  public static void AddShakeMode(FlatBufferBuilder builder, int ShakeMode) { builder.AddInt(4, ShakeMode, 1); }
  public static void AddReduceFactor(FlatBufferBuilder builder, float ReduceFactor) { builder.AddFloat(5, ReduceFactor, 0); }
  public static void AddDelay(FlatBufferBuilder builder, float Delay) { builder.AddFloat(6, Delay, 0); }
  public static void AddHpShakeRate(FlatBufferBuilder builder, int HpShakeRate) { builder.AddInt(7, HpShakeRate, 0); }
  public static Offset<FB_ShakeCamera> EndFB_ShakeCamera(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShakeCamera>(o);
  }
};

public sealed class FB_ShakeCameraContainer : Table {
  public static FB_ShakeCameraContainer GetRootAsFB_ShakeCameraContainer(ByteBuffer _bb) { return GetRootAsFB_ShakeCameraContainer(_bb, new FB_ShakeCameraContainer()); }
  public static FB_ShakeCameraContainer GetRootAsFB_ShakeCameraContainer(ByteBuffer _bb, FB_ShakeCameraContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShakeCameraContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShakeCameraContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShakeCamera GetItems(int j) { return GetItems(new FB_ShakeCamera(), j); }
  public FB_ShakeCamera GetItems(FB_ShakeCamera obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShakeCameraContainer> CreateFB_ShakeCameraContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShakeCameraContainer.AddItems(builder, items);
    return FB_ShakeCameraContainer.EndFB_ShakeCameraContainer(builder);
  }

  public static void StartFB_ShakeCameraContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShakeCamera>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShakeCameraContainer> EndFB_ShakeCameraContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShakeCameraContainer>(o);
  }
  public static void FinishFB_ShakeCameraContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShakeCameraContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
