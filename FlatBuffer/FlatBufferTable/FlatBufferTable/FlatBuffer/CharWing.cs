// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CharWing : Table {
  public static FB_CharWing GetRootAsFB_CharWing(ByteBuffer _bb) { return GetRootAsFB_CharWing(_bb, new FB_CharWing()); }
  public static FB_CharWing GetRootAsFB_CharWing(ByteBuffer _bb, FB_CharWing obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CharWing __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MountModel { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BindPoint { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string AnimPath { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Dummy { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public float ScaleX { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ScaleY { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ScaleZ { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int UIModel { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float EffectWingScale { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_CharWing> CreateFB_CharWing(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset MountModel = default(StringOffset),
      StringOffset BindPoint = default(StringOffset),
      StringOffset AnimPath = default(StringOffset),
      int FakeObjID = 0,
      StringOffset Dummy = default(StringOffset),
      float ScaleX = 0,
      float ScaleY = 0,
      float ScaleZ = 0,
      int UIModel = -1,
      float EffectWingScale = 0) {
    builder.StartObject(11);
    FB_CharWing.AddEffectWingScale(builder, EffectWingScale);
    FB_CharWing.AddUIModel(builder, UIModel);
    FB_CharWing.AddScaleZ(builder, ScaleZ);
    FB_CharWing.AddScaleY(builder, ScaleY);
    FB_CharWing.AddScaleX(builder, ScaleX);
    FB_CharWing.AddDummy(builder, Dummy);
    FB_CharWing.AddFakeObjID(builder, FakeObjID);
    FB_CharWing.AddAnimPath(builder, AnimPath);
    FB_CharWing.AddBindPoint(builder, BindPoint);
    FB_CharWing.AddMountModel(builder, MountModel);
    FB_CharWing.AddId(builder, Id);
    return FB_CharWing.EndFB_CharWing(builder);
  }

  public static void StartFB_CharWing(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMountModel(FlatBufferBuilder builder, StringOffset MountModelOffset) { builder.AddOffset(1, MountModelOffset.Value, 0); }
  public static void AddBindPoint(FlatBufferBuilder builder, StringOffset BindPointOffset) { builder.AddOffset(2, BindPointOffset.Value, 0); }
  public static void AddAnimPath(FlatBufferBuilder builder, StringOffset AnimPathOffset) { builder.AddOffset(3, AnimPathOffset.Value, 0); }
  public static void AddFakeObjID(FlatBufferBuilder builder, int FakeObjID) { builder.AddInt(4, FakeObjID, 0); }
  public static void AddDummy(FlatBufferBuilder builder, StringOffset DummyOffset) { builder.AddOffset(5, DummyOffset.Value, 0); }
  public static void AddScaleX(FlatBufferBuilder builder, float ScaleX) { builder.AddFloat(6, ScaleX, 0); }
  public static void AddScaleY(FlatBufferBuilder builder, float ScaleY) { builder.AddFloat(7, ScaleY, 0); }
  public static void AddScaleZ(FlatBufferBuilder builder, float ScaleZ) { builder.AddFloat(8, ScaleZ, 0); }
  public static void AddUIModel(FlatBufferBuilder builder, int UIModel) { builder.AddInt(9, UIModel, -1); }
  public static void AddEffectWingScale(FlatBufferBuilder builder, float EffectWingScale) { builder.AddFloat(10, EffectWingScale, 0); }
  public static Offset<FB_CharWing> EndFB_CharWing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharWing>(o);
  }
};

public sealed class FB_CharWingContainer : Table {
  public static FB_CharWingContainer GetRootAsFB_CharWingContainer(ByteBuffer _bb) { return GetRootAsFB_CharWingContainer(_bb, new FB_CharWingContainer()); }
  public static FB_CharWingContainer GetRootAsFB_CharWingContainer(ByteBuffer _bb, FB_CharWingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CharWingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CharWingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CharWing GetItems(int j) { return GetItems(new FB_CharWing(), j); }
  public FB_CharWing GetItems(FB_CharWing obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharWingContainer> CreateFB_CharWingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CharWingContainer.AddItems(builder, items);
    return FB_CharWingContainer.EndFB_CharWingContainer(builder);
  }

  public static void StartFB_CharWingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CharWing>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharWingContainer> EndFB_CharWingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharWingContainer>(o);
  }
  public static void FinishFB_CharWingContainerBuffer(FlatBufferBuilder builder, Offset<FB_CharWingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
