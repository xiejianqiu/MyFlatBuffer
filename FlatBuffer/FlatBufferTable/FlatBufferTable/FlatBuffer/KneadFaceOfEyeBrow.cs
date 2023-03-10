// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KneadFaceOfEyeBrow : Table {
  public static FB_KneadFaceOfEyeBrow GetRootAsFB_KneadFaceOfEyeBrow(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfEyeBrow(_bb, new FB_KneadFaceOfEyeBrow()); }
  public static FB_KneadFaceOfEyeBrow GetRootAsFB_KneadFaceOfEyeBrow(ByteBuffer _bb, FB_KneadFaceOfEyeBrow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KneadFaceOfEyeBrow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public float EyeBrowOffX { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeBrowOffY { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeBrowScaleX { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeBrowScaleY { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeBrowXLimitMin { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeBrowXLimitMax { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeBrowYLimitMin { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float EyeBrowYLimitMax { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public string EyeBrowResPath { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public string EyeBrowIcon { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_KneadFaceOfEyeBrow> CreateFB_KneadFaceOfEyeBrow(FlatBufferBuilder builder,
      int Id = 0,
      int MenPai = -1,
      int Sex = 1,
      float EyeBrowOffX = -1,
      float EyeBrowOffY = -1,
      float EyeBrowScaleX = -1,
      float EyeBrowScaleY = -1,
      float EyeBrowXLimitMin = -1,
      float EyeBrowXLimitMax = -1,
      float EyeBrowYLimitMin = -1,
      float EyeBrowYLimitMax = -1,
      StringOffset EyeBrowResPath = default(StringOffset),
      StringOffset EyeBrowIcon = default(StringOffset)) {
    builder.StartObject(13);
    FB_KneadFaceOfEyeBrow.AddEyeBrowIcon(builder, EyeBrowIcon);
    FB_KneadFaceOfEyeBrow.AddEyeBrowResPath(builder, EyeBrowResPath);
    FB_KneadFaceOfEyeBrow.AddEyeBrowYLimitMax(builder, EyeBrowYLimitMax);
    FB_KneadFaceOfEyeBrow.AddEyeBrowYLimitMin(builder, EyeBrowYLimitMin);
    FB_KneadFaceOfEyeBrow.AddEyeBrowXLimitMax(builder, EyeBrowXLimitMax);
    FB_KneadFaceOfEyeBrow.AddEyeBrowXLimitMin(builder, EyeBrowXLimitMin);
    FB_KneadFaceOfEyeBrow.AddEyeBrowScaleY(builder, EyeBrowScaleY);
    FB_KneadFaceOfEyeBrow.AddEyeBrowScaleX(builder, EyeBrowScaleX);
    FB_KneadFaceOfEyeBrow.AddEyeBrowOffY(builder, EyeBrowOffY);
    FB_KneadFaceOfEyeBrow.AddEyeBrowOffX(builder, EyeBrowOffX);
    FB_KneadFaceOfEyeBrow.AddSex(builder, Sex);
    FB_KneadFaceOfEyeBrow.AddMenPai(builder, MenPai);
    FB_KneadFaceOfEyeBrow.AddId(builder, Id);
    return FB_KneadFaceOfEyeBrow.EndFB_KneadFaceOfEyeBrow(builder);
  }

  public static void StartFB_KneadFaceOfEyeBrow(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(2, Sex, 1); }
  public static void AddEyeBrowOffX(FlatBufferBuilder builder, float EyeBrowOffX) { builder.AddFloat(3, EyeBrowOffX, -1); }
  public static void AddEyeBrowOffY(FlatBufferBuilder builder, float EyeBrowOffY) { builder.AddFloat(4, EyeBrowOffY, -1); }
  public static void AddEyeBrowScaleX(FlatBufferBuilder builder, float EyeBrowScaleX) { builder.AddFloat(5, EyeBrowScaleX, -1); }
  public static void AddEyeBrowScaleY(FlatBufferBuilder builder, float EyeBrowScaleY) { builder.AddFloat(6, EyeBrowScaleY, -1); }
  public static void AddEyeBrowXLimitMin(FlatBufferBuilder builder, float EyeBrowXLimitMin) { builder.AddFloat(7, EyeBrowXLimitMin, -1); }
  public static void AddEyeBrowXLimitMax(FlatBufferBuilder builder, float EyeBrowXLimitMax) { builder.AddFloat(8, EyeBrowXLimitMax, -1); }
  public static void AddEyeBrowYLimitMin(FlatBufferBuilder builder, float EyeBrowYLimitMin) { builder.AddFloat(9, EyeBrowYLimitMin, -1); }
  public static void AddEyeBrowYLimitMax(FlatBufferBuilder builder, float EyeBrowYLimitMax) { builder.AddFloat(10, EyeBrowYLimitMax, -1); }
  public static void AddEyeBrowResPath(FlatBufferBuilder builder, StringOffset EyeBrowResPathOffset) { builder.AddOffset(11, EyeBrowResPathOffset.Value, 0); }
  public static void AddEyeBrowIcon(FlatBufferBuilder builder, StringOffset EyeBrowIconOffset) { builder.AddOffset(12, EyeBrowIconOffset.Value, 0); }
  public static Offset<FB_KneadFaceOfEyeBrow> EndFB_KneadFaceOfEyeBrow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfEyeBrow>(o);
  }
};

public sealed class FB_KneadFaceOfEyeBrowContainer : Table {
  public static FB_KneadFaceOfEyeBrowContainer GetRootAsFB_KneadFaceOfEyeBrowContainer(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfEyeBrowContainer(_bb, new FB_KneadFaceOfEyeBrowContainer()); }
  public static FB_KneadFaceOfEyeBrowContainer GetRootAsFB_KneadFaceOfEyeBrowContainer(ByteBuffer _bb, FB_KneadFaceOfEyeBrowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KneadFaceOfEyeBrowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KneadFaceOfEyeBrowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KneadFaceOfEyeBrow GetItems(int j) { return GetItems(new FB_KneadFaceOfEyeBrow(), j); }
  public FB_KneadFaceOfEyeBrow GetItems(FB_KneadFaceOfEyeBrow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KneadFaceOfEyeBrowContainer> CreateFB_KneadFaceOfEyeBrowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KneadFaceOfEyeBrowContainer.AddItems(builder, items);
    return FB_KneadFaceOfEyeBrowContainer.EndFB_KneadFaceOfEyeBrowContainer(builder);
  }

  public static void StartFB_KneadFaceOfEyeBrowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KneadFaceOfEyeBrow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KneadFaceOfEyeBrowContainer> EndFB_KneadFaceOfEyeBrowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfEyeBrowContainer>(o);
  }
  public static void FinishFB_KneadFaceOfEyeBrowContainerBuffer(FlatBufferBuilder builder, Offset<FB_KneadFaceOfEyeBrowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
