// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FakeObject : Table {
  public static FB_FakeObject GetRootAsFB_FakeObject(ByteBuffer _bb) { return GetRootAsFB_FakeObject(_bb, new FB_FakeObject()); }
  public static FB_FakeObject GetRootAsFB_FakeObject(ByteBuffer _bb, FB_FakeObject obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FakeObject __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CharModelId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AnimaId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float XOffSet { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float YOffSet { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ZOffset { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XRotation { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float YRotation { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ZRotation { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float CameraRotationX { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool IsPlayer { get { int o = __offset(24); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public string BGPath { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public float Scale { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SCamYRota { get { int o = __offset(30); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SCamXOffset { get { int o = __offset(32); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SCamZOffset { get { int o = __offset(34); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float SCamSize { get { int o = __offset(36); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool HasShadow { get { int o = __offset(38); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public float CamFieldOfView { get { int o = __offset(40); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)30; } }

  public static Offset<FB_FakeObject> CreateFB_FakeObject(FlatBufferBuilder builder,
      int Id = 0,
      int CharModelId = -1,
      int AnimaId = 0,
      float XOffSet = 0,
      float YOffSet = 0,
      float ZOffset = 0,
      float XRotation = 0,
      float YRotation = 0,
      float ZRotation = 0,
      float CameraRotationX = 0,
      bool IsPlayer = false,
      StringOffset BGPath = default(StringOffset),
      float Scale = 0,
      float sCamYRota = 0,
      float sCamXOffset = 0,
      float sCamZOffset = 0,
      float sCamSize = 0,
      bool HasShadow = false,
      float CamFieldOfView = 30) {
    builder.StartObject(19);
    FB_FakeObject.AddCamFieldOfView(builder, CamFieldOfView);
    FB_FakeObject.AddSCamSize(builder, sCamSize);
    FB_FakeObject.AddSCamZOffset(builder, sCamZOffset);
    FB_FakeObject.AddSCamXOffset(builder, sCamXOffset);
    FB_FakeObject.AddSCamYRota(builder, sCamYRota);
    FB_FakeObject.AddScale(builder, Scale);
    FB_FakeObject.AddBGPath(builder, BGPath);
    FB_FakeObject.AddCameraRotationX(builder, CameraRotationX);
    FB_FakeObject.AddZRotation(builder, ZRotation);
    FB_FakeObject.AddYRotation(builder, YRotation);
    FB_FakeObject.AddXRotation(builder, XRotation);
    FB_FakeObject.AddZOffset(builder, ZOffset);
    FB_FakeObject.AddYOffSet(builder, YOffSet);
    FB_FakeObject.AddXOffSet(builder, XOffSet);
    FB_FakeObject.AddAnimaId(builder, AnimaId);
    FB_FakeObject.AddCharModelId(builder, CharModelId);
    FB_FakeObject.AddId(builder, Id);
    FB_FakeObject.AddHasShadow(builder, HasShadow);
    FB_FakeObject.AddIsPlayer(builder, IsPlayer);
    return FB_FakeObject.EndFB_FakeObject(builder);
  }

  public static void StartFB_FakeObject(FlatBufferBuilder builder) { builder.StartObject(19); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCharModelId(FlatBufferBuilder builder, int CharModelId) { builder.AddInt(1, CharModelId, -1); }
  public static void AddAnimaId(FlatBufferBuilder builder, int AnimaId) { builder.AddInt(2, AnimaId, 0); }
  public static void AddXOffSet(FlatBufferBuilder builder, float XOffSet) { builder.AddFloat(3, XOffSet, 0); }
  public static void AddYOffSet(FlatBufferBuilder builder, float YOffSet) { builder.AddFloat(4, YOffSet, 0); }
  public static void AddZOffset(FlatBufferBuilder builder, float ZOffset) { builder.AddFloat(5, ZOffset, 0); }
  public static void AddXRotation(FlatBufferBuilder builder, float XRotation) { builder.AddFloat(6, XRotation, 0); }
  public static void AddYRotation(FlatBufferBuilder builder, float YRotation) { builder.AddFloat(7, YRotation, 0); }
  public static void AddZRotation(FlatBufferBuilder builder, float ZRotation) { builder.AddFloat(8, ZRotation, 0); }
  public static void AddCameraRotationX(FlatBufferBuilder builder, float CameraRotationX) { builder.AddFloat(9, CameraRotationX, 0); }
  public static void AddIsPlayer(FlatBufferBuilder builder, bool IsPlayer) { builder.AddBool(10, IsPlayer, false); }
  public static void AddBGPath(FlatBufferBuilder builder, StringOffset BGPathOffset) { builder.AddOffset(11, BGPathOffset.Value, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(12, Scale, 0); }
  public static void AddSCamYRota(FlatBufferBuilder builder, float sCamYRota) { builder.AddFloat(13, sCamYRota, 0); }
  public static void AddSCamXOffset(FlatBufferBuilder builder, float sCamXOffset) { builder.AddFloat(14, sCamXOffset, 0); }
  public static void AddSCamZOffset(FlatBufferBuilder builder, float sCamZOffset) { builder.AddFloat(15, sCamZOffset, 0); }
  public static void AddSCamSize(FlatBufferBuilder builder, float sCamSize) { builder.AddFloat(16, sCamSize, 0); }
  public static void AddHasShadow(FlatBufferBuilder builder, bool HasShadow) { builder.AddBool(17, HasShadow, false); }
  public static void AddCamFieldOfView(FlatBufferBuilder builder, float CamFieldOfView) { builder.AddFloat(18, CamFieldOfView, 30); }
  public static Offset<FB_FakeObject> EndFB_FakeObject(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FakeObject>(o);
  }
};

public sealed class FB_FakeObjectContainer : Table {
  public static FB_FakeObjectContainer GetRootAsFB_FakeObjectContainer(ByteBuffer _bb) { return GetRootAsFB_FakeObjectContainer(_bb, new FB_FakeObjectContainer()); }
  public static FB_FakeObjectContainer GetRootAsFB_FakeObjectContainer(ByteBuffer _bb, FB_FakeObjectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FakeObjectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FakeObjectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FakeObject GetItems(int j) { return GetItems(new FB_FakeObject(), j); }
  public FB_FakeObject GetItems(FB_FakeObject obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FakeObjectContainer> CreateFB_FakeObjectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FakeObjectContainer.AddItems(builder, items);
    return FB_FakeObjectContainer.EndFB_FakeObjectContainer(builder);
  }

  public static void StartFB_FakeObjectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FakeObject>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FakeObjectContainer> EndFB_FakeObjectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FakeObjectContainer>(o);
  }
  public static void FinishFB_FakeObjectContainerBuffer(FlatBufferBuilder builder, Offset<FB_FakeObjectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
