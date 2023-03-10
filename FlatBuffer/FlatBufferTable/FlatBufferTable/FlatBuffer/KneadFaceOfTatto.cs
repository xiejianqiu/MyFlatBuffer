// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KneadFaceOfTatto : Table {
  public static FB_KneadFaceOfTatto GetRootAsFB_KneadFaceOfTatto(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfTatto(_bb, new FB_KneadFaceOfTatto()); }
  public static FB_KneadFaceOfTatto GetRootAsFB_KneadFaceOfTatto(ByteBuffer _bb, FB_KneadFaceOfTatto obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KneadFaceOfTatto __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string TattoResPath { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public float TattoOffX { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TattoOffY { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TattoXLimitMin { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TattoXLimitMax { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TattoYLimitMin { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TattoYLimitMax { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TattoScaleX { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float TattoScaleY { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public string TattoIcon { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_KneadFaceOfTatto> CreateFB_KneadFaceOfTatto(FlatBufferBuilder builder,
      int Id = 0,
      int MenPai = -1,
      int Sex = 1,
      StringOffset TattoResPath = default(StringOffset),
      float TattoOffX = -1,
      float TattoOffY = -1,
      float TattoXLimitMin = -1,
      float TattoXLimitMax = -1,
      float TattoYLimitMin = -1,
      float TattoYLimitMax = -1,
      float TattoScaleX = -1,
      float TattoScaleY = -1,
      StringOffset TattoIcon = default(StringOffset)) {
    builder.StartObject(13);
    FB_KneadFaceOfTatto.AddTattoIcon(builder, TattoIcon);
    FB_KneadFaceOfTatto.AddTattoScaleY(builder, TattoScaleY);
    FB_KneadFaceOfTatto.AddTattoScaleX(builder, TattoScaleX);
    FB_KneadFaceOfTatto.AddTattoYLimitMax(builder, TattoYLimitMax);
    FB_KneadFaceOfTatto.AddTattoYLimitMin(builder, TattoYLimitMin);
    FB_KneadFaceOfTatto.AddTattoXLimitMax(builder, TattoXLimitMax);
    FB_KneadFaceOfTatto.AddTattoXLimitMin(builder, TattoXLimitMin);
    FB_KneadFaceOfTatto.AddTattoOffY(builder, TattoOffY);
    FB_KneadFaceOfTatto.AddTattoOffX(builder, TattoOffX);
    FB_KneadFaceOfTatto.AddTattoResPath(builder, TattoResPath);
    FB_KneadFaceOfTatto.AddSex(builder, Sex);
    FB_KneadFaceOfTatto.AddMenPai(builder, MenPai);
    FB_KneadFaceOfTatto.AddId(builder, Id);
    return FB_KneadFaceOfTatto.EndFB_KneadFaceOfTatto(builder);
  }

  public static void StartFB_KneadFaceOfTatto(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(2, Sex, 1); }
  public static void AddTattoResPath(FlatBufferBuilder builder, StringOffset TattoResPathOffset) { builder.AddOffset(3, TattoResPathOffset.Value, 0); }
  public static void AddTattoOffX(FlatBufferBuilder builder, float TattoOffX) { builder.AddFloat(4, TattoOffX, -1); }
  public static void AddTattoOffY(FlatBufferBuilder builder, float TattoOffY) { builder.AddFloat(5, TattoOffY, -1); }
  public static void AddTattoXLimitMin(FlatBufferBuilder builder, float TattoXLimitMin) { builder.AddFloat(6, TattoXLimitMin, -1); }
  public static void AddTattoXLimitMax(FlatBufferBuilder builder, float TattoXLimitMax) { builder.AddFloat(7, TattoXLimitMax, -1); }
  public static void AddTattoYLimitMin(FlatBufferBuilder builder, float TattoYLimitMin) { builder.AddFloat(8, TattoYLimitMin, -1); }
  public static void AddTattoYLimitMax(FlatBufferBuilder builder, float TattoYLimitMax) { builder.AddFloat(9, TattoYLimitMax, -1); }
  public static void AddTattoScaleX(FlatBufferBuilder builder, float TattoScaleX) { builder.AddFloat(10, TattoScaleX, -1); }
  public static void AddTattoScaleY(FlatBufferBuilder builder, float TattoScaleY) { builder.AddFloat(11, TattoScaleY, -1); }
  public static void AddTattoIcon(FlatBufferBuilder builder, StringOffset TattoIconOffset) { builder.AddOffset(12, TattoIconOffset.Value, 0); }
  public static Offset<FB_KneadFaceOfTatto> EndFB_KneadFaceOfTatto(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfTatto>(o);
  }
};

public sealed class FB_KneadFaceOfTattoContainer : Table {
  public static FB_KneadFaceOfTattoContainer GetRootAsFB_KneadFaceOfTattoContainer(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfTattoContainer(_bb, new FB_KneadFaceOfTattoContainer()); }
  public static FB_KneadFaceOfTattoContainer GetRootAsFB_KneadFaceOfTattoContainer(ByteBuffer _bb, FB_KneadFaceOfTattoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KneadFaceOfTattoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KneadFaceOfTattoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KneadFaceOfTatto GetItems(int j) { return GetItems(new FB_KneadFaceOfTatto(), j); }
  public FB_KneadFaceOfTatto GetItems(FB_KneadFaceOfTatto obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KneadFaceOfTattoContainer> CreateFB_KneadFaceOfTattoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KneadFaceOfTattoContainer.AddItems(builder, items);
    return FB_KneadFaceOfTattoContainer.EndFB_KneadFaceOfTattoContainer(builder);
  }

  public static void StartFB_KneadFaceOfTattoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KneadFaceOfTatto>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KneadFaceOfTattoContainer> EndFB_KneadFaceOfTattoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfTattoContainer>(o);
  }
  public static void FinishFB_KneadFaceOfTattoContainerBuffer(FlatBufferBuilder builder, Offset<FB_KneadFaceOfTattoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
