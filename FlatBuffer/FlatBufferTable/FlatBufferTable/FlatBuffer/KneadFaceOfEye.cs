// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KneadFaceOfEye : Table {
  public static FB_KneadFaceOfEye GetRootAsFB_KneadFaceOfEye(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfEye(_bb, new FB_KneadFaceOfEye()); }
  public static FB_KneadFaceOfEye GetRootAsFB_KneadFaceOfEye(ByteBuffer _bb, FB_KneadFaceOfEye obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KneadFaceOfEye __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float EyeOffX { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeOffY { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeScaleX { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeScaleY { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeXLimitMin { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeXLimitMax { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeYLimitMin { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeYLimitMax { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public string EyeResPath { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public string EyeIcon { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_KneadFaceOfEye> CreateFB_KneadFaceOfEye(FlatBufferBuilder builder,
      int Id = 0,
      int MenPai = -1,
      int Sex = -1,
      float EyeOffX = -1,
      float EyeOffY = -1,
      float EyeScaleX = -1,
      float EyeScaleY = -1,
      float EyeXLimitMin = -1,
      float EyeXLimitMax = -1,
      float EyeYLimitMin = -1,
      float EyeYLimitMax = -1,
      StringOffset EyeResPath = default(StringOffset),
      StringOffset EyeIcon = default(StringOffset)) {
    builder.StartObject(13);
    FB_KneadFaceOfEye.AddEyeIcon(builder, EyeIcon);
    FB_KneadFaceOfEye.AddEyeResPath(builder, EyeResPath);
    FB_KneadFaceOfEye.AddEyeYLimitMax(builder, EyeYLimitMax);
    FB_KneadFaceOfEye.AddEyeYLimitMin(builder, EyeYLimitMin);
    FB_KneadFaceOfEye.AddEyeXLimitMax(builder, EyeXLimitMax);
    FB_KneadFaceOfEye.AddEyeXLimitMin(builder, EyeXLimitMin);
    FB_KneadFaceOfEye.AddEyeScaleY(builder, EyeScaleY);
    FB_KneadFaceOfEye.AddEyeScaleX(builder, EyeScaleX);
    FB_KneadFaceOfEye.AddEyeOffY(builder, EyeOffY);
    FB_KneadFaceOfEye.AddEyeOffX(builder, EyeOffX);
    FB_KneadFaceOfEye.AddSex(builder, Sex);
    FB_KneadFaceOfEye.AddMenPai(builder, MenPai);
    FB_KneadFaceOfEye.AddId(builder, Id);
    return FB_KneadFaceOfEye.EndFB_KneadFaceOfEye(builder);
  }

  public static void StartFB_KneadFaceOfEye(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(2, Sex, -1); }
  public static void AddEyeOffX(FlatBufferBuilder builder, float EyeOffX) { builder.AddFloat(3, EyeOffX, -1); }
  public static void AddEyeOffY(FlatBufferBuilder builder, float EyeOffY) { builder.AddFloat(4, EyeOffY, -1); }
  public static void AddEyeScaleX(FlatBufferBuilder builder, float EyeScaleX) { builder.AddFloat(5, EyeScaleX, -1); }
  public static void AddEyeScaleY(FlatBufferBuilder builder, float EyeScaleY) { builder.AddFloat(6, EyeScaleY, -1); }
  public static void AddEyeXLimitMin(FlatBufferBuilder builder, float EyeXLimitMin) { builder.AddFloat(7, EyeXLimitMin, -1); }
  public static void AddEyeXLimitMax(FlatBufferBuilder builder, float EyeXLimitMax) { builder.AddFloat(8, EyeXLimitMax, -1); }
  public static void AddEyeYLimitMin(FlatBufferBuilder builder, float EyeYLimitMin) { builder.AddFloat(9, EyeYLimitMin, -1); }
  public static void AddEyeYLimitMax(FlatBufferBuilder builder, float EyeYLimitMax) { builder.AddFloat(10, EyeYLimitMax, -1); }
  public static void AddEyeResPath(FlatBufferBuilder builder, StringOffset EyeResPathOffset) { builder.AddOffset(11, EyeResPathOffset.Value, 0); }
  public static void AddEyeIcon(FlatBufferBuilder builder, StringOffset EyeIconOffset) { builder.AddOffset(12, EyeIconOffset.Value, 0); }
  public static Offset<FB_KneadFaceOfEye> EndFB_KneadFaceOfEye(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfEye>(o);
  }
};

public sealed class FB_KneadFaceOfEyeContainer : Table {
  public static FB_KneadFaceOfEyeContainer GetRootAsFB_KneadFaceOfEyeContainer(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfEyeContainer(_bb, new FB_KneadFaceOfEyeContainer()); }
  public static FB_KneadFaceOfEyeContainer GetRootAsFB_KneadFaceOfEyeContainer(ByteBuffer _bb, FB_KneadFaceOfEyeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KneadFaceOfEyeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KneadFaceOfEyeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KneadFaceOfEye GetItems(int j) { return GetItems(new FB_KneadFaceOfEye(), j); }
  public FB_KneadFaceOfEye GetItems(FB_KneadFaceOfEye obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KneadFaceOfEyeContainer> CreateFB_KneadFaceOfEyeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KneadFaceOfEyeContainer.AddItems(builder, items);
    return FB_KneadFaceOfEyeContainer.EndFB_KneadFaceOfEyeContainer(builder);
  }

  public static void StartFB_KneadFaceOfEyeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KneadFaceOfEye>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KneadFaceOfEyeContainer> EndFB_KneadFaceOfEyeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfEyeContainer>(o);
  }
  public static void FinishFB_KneadFaceOfEyeContainerBuffer(FlatBufferBuilder builder, Offset<FB_KneadFaceOfEyeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
