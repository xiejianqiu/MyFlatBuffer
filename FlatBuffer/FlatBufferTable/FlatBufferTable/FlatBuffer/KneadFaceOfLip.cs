// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KneadFaceOfLip : Table {
  public static FB_KneadFaceOfLip GetRootAsFB_KneadFaceOfLip(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfLip(_bb, new FB_KneadFaceOfLip()); }
  public static FB_KneadFaceOfLip GetRootAsFB_KneadFaceOfLip(ByteBuffer _bb, FB_KneadFaceOfLip obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KneadFaceOfLip __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public float LipOffX { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float LipOffY { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float LipXLimitMin { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float LipXLimitMax { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float LipYLimitMin { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float LipYLimitMax { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public string LipResPath { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LipIcon { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_KneadFaceOfLip> CreateFB_KneadFaceOfLip(FlatBufferBuilder builder,
      int Id = 0,
      int MenPai = -1,
      int Sex = 1,
      float LipOffX = -1,
      float LipOffY = -1,
      float LipXLimitMin = -1,
      float LipXLimitMax = -1,
      float LipYLimitMin = -1,
      float LipYLimitMax = -1,
      StringOffset LipResPath = default(StringOffset),
      StringOffset LipIcon = default(StringOffset)) {
    builder.StartObject(11);
    FB_KneadFaceOfLip.AddLipIcon(builder, LipIcon);
    FB_KneadFaceOfLip.AddLipResPath(builder, LipResPath);
    FB_KneadFaceOfLip.AddLipYLimitMax(builder, LipYLimitMax);
    FB_KneadFaceOfLip.AddLipYLimitMin(builder, LipYLimitMin);
    FB_KneadFaceOfLip.AddLipXLimitMax(builder, LipXLimitMax);
    FB_KneadFaceOfLip.AddLipXLimitMin(builder, LipXLimitMin);
    FB_KneadFaceOfLip.AddLipOffY(builder, LipOffY);
    FB_KneadFaceOfLip.AddLipOffX(builder, LipOffX);
    FB_KneadFaceOfLip.AddSex(builder, Sex);
    FB_KneadFaceOfLip.AddMenPai(builder, MenPai);
    FB_KneadFaceOfLip.AddId(builder, Id);
    return FB_KneadFaceOfLip.EndFB_KneadFaceOfLip(builder);
  }

  public static void StartFB_KneadFaceOfLip(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(2, Sex, 1); }
  public static void AddLipOffX(FlatBufferBuilder builder, float LipOffX) { builder.AddFloat(3, LipOffX, -1); }
  public static void AddLipOffY(FlatBufferBuilder builder, float LipOffY) { builder.AddFloat(4, LipOffY, -1); }
  public static void AddLipXLimitMin(FlatBufferBuilder builder, float LipXLimitMin) { builder.AddFloat(5, LipXLimitMin, -1); }
  public static void AddLipXLimitMax(FlatBufferBuilder builder, float LipXLimitMax) { builder.AddFloat(6, LipXLimitMax, -1); }
  public static void AddLipYLimitMin(FlatBufferBuilder builder, float LipYLimitMin) { builder.AddFloat(7, LipYLimitMin, -1); }
  public static void AddLipYLimitMax(FlatBufferBuilder builder, float LipYLimitMax) { builder.AddFloat(8, LipYLimitMax, -1); }
  public static void AddLipResPath(FlatBufferBuilder builder, StringOffset LipResPathOffset) { builder.AddOffset(9, LipResPathOffset.Value, 0); }
  public static void AddLipIcon(FlatBufferBuilder builder, StringOffset LipIconOffset) { builder.AddOffset(10, LipIconOffset.Value, 0); }
  public static Offset<FB_KneadFaceOfLip> EndFB_KneadFaceOfLip(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfLip>(o);
  }
};

public sealed class FB_KneadFaceOfLipContainer : Table {
  public static FB_KneadFaceOfLipContainer GetRootAsFB_KneadFaceOfLipContainer(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfLipContainer(_bb, new FB_KneadFaceOfLipContainer()); }
  public static FB_KneadFaceOfLipContainer GetRootAsFB_KneadFaceOfLipContainer(ByteBuffer _bb, FB_KneadFaceOfLipContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KneadFaceOfLipContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KneadFaceOfLipContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KneadFaceOfLip GetItems(int j) { return GetItems(new FB_KneadFaceOfLip(), j); }
  public FB_KneadFaceOfLip GetItems(FB_KneadFaceOfLip obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KneadFaceOfLipContainer> CreateFB_KneadFaceOfLipContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KneadFaceOfLipContainer.AddItems(builder, items);
    return FB_KneadFaceOfLipContainer.EndFB_KneadFaceOfLipContainer(builder);
  }

  public static void StartFB_KneadFaceOfLipContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KneadFaceOfLip>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KneadFaceOfLipContainer> EndFB_KneadFaceOfLipContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfLipContainer>(o);
  }
  public static void FinishFB_KneadFaceOfLipContainerBuffer(FlatBufferBuilder builder, Offset<FB_KneadFaceOfLipContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
