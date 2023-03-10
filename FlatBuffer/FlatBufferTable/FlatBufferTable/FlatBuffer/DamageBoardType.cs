// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DamageBoardType : Table {
  public static FB_DamageBoardType GetRootAsFB_DamageBoardType(ByteBuffer _bb) { return GetRootAsFB_DamageBoardType(_bb, new FB_DamageBoardType()); }
  public static FB_DamageBoardType GetRootAsFB_DamageBoardType(ByteBuffer _bb, FB_DamageBoardType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DamageBoardType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int DamageBoardTypeID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float OriginX { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float OriginY { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FadeStartTime { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FadeDurationTime { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public string TextColor { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string OutlineColor { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public float TextSize { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int MaxNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)10; } }
  public string AnimaName { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GradientTop { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GradientBottom { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool NeedShow { get { int o = __offset(28); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_DamageBoardType> CreateFB_DamageBoardType(FlatBufferBuilder builder,
      int DamageBoardTypeID = 0,
      float OriginX = 0,
      float OriginY = 0,
      float FadeStartTime = 0,
      float FadeDurationTime = 0,
      StringOffset TextColor = default(StringOffset),
      StringOffset OutlineColor = default(StringOffset),
      float TextSize = 0,
      int MaxNum = 10,
      StringOffset AnimaName = default(StringOffset),
      StringOffset GradientTop = default(StringOffset),
      StringOffset GradientBottom = default(StringOffset),
      bool NeedShow = false) {
    builder.StartObject(13);
    FB_DamageBoardType.AddGradientBottom(builder, GradientBottom);
    FB_DamageBoardType.AddGradientTop(builder, GradientTop);
    FB_DamageBoardType.AddAnimaName(builder, AnimaName);
    FB_DamageBoardType.AddMaxNum(builder, MaxNum);
    FB_DamageBoardType.AddTextSize(builder, TextSize);
    FB_DamageBoardType.AddOutlineColor(builder, OutlineColor);
    FB_DamageBoardType.AddTextColor(builder, TextColor);
    FB_DamageBoardType.AddFadeDurationTime(builder, FadeDurationTime);
    FB_DamageBoardType.AddFadeStartTime(builder, FadeStartTime);
    FB_DamageBoardType.AddOriginY(builder, OriginY);
    FB_DamageBoardType.AddOriginX(builder, OriginX);
    FB_DamageBoardType.AddDamageBoardTypeID(builder, DamageBoardTypeID);
    FB_DamageBoardType.AddNeedShow(builder, NeedShow);
    return FB_DamageBoardType.EndFB_DamageBoardType(builder);
  }

  public static void StartFB_DamageBoardType(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddDamageBoardTypeID(FlatBufferBuilder builder, int DamageBoardTypeID) { builder.AddInt(0, DamageBoardTypeID, 0); }
  public static void AddOriginX(FlatBufferBuilder builder, float OriginX) { builder.AddFloat(1, OriginX, 0); }
  public static void AddOriginY(FlatBufferBuilder builder, float OriginY) { builder.AddFloat(2, OriginY, 0); }
  public static void AddFadeStartTime(FlatBufferBuilder builder, float FadeStartTime) { builder.AddFloat(3, FadeStartTime, 0); }
  public static void AddFadeDurationTime(FlatBufferBuilder builder, float FadeDurationTime) { builder.AddFloat(4, FadeDurationTime, 0); }
  public static void AddTextColor(FlatBufferBuilder builder, StringOffset TextColorOffset) { builder.AddOffset(5, TextColorOffset.Value, 0); }
  public static void AddOutlineColor(FlatBufferBuilder builder, StringOffset OutlineColorOffset) { builder.AddOffset(6, OutlineColorOffset.Value, 0); }
  public static void AddTextSize(FlatBufferBuilder builder, float TextSize) { builder.AddFloat(7, TextSize, 0); }
  public static void AddMaxNum(FlatBufferBuilder builder, int MaxNum) { builder.AddInt(8, MaxNum, 10); }
  public static void AddAnimaName(FlatBufferBuilder builder, StringOffset AnimaNameOffset) { builder.AddOffset(9, AnimaNameOffset.Value, 0); }
  public static void AddGradientTop(FlatBufferBuilder builder, StringOffset GradientTopOffset) { builder.AddOffset(10, GradientTopOffset.Value, 0); }
  public static void AddGradientBottom(FlatBufferBuilder builder, StringOffset GradientBottomOffset) { builder.AddOffset(11, GradientBottomOffset.Value, 0); }
  public static void AddNeedShow(FlatBufferBuilder builder, bool NeedShow) { builder.AddBool(12, NeedShow, false); }
  public static Offset<FB_DamageBoardType> EndFB_DamageBoardType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DamageBoardType>(o);
  }
};

public sealed class FB_DamageBoardTypeContainer : Table {
  public static FB_DamageBoardTypeContainer GetRootAsFB_DamageBoardTypeContainer(ByteBuffer _bb) { return GetRootAsFB_DamageBoardTypeContainer(_bb, new FB_DamageBoardTypeContainer()); }
  public static FB_DamageBoardTypeContainer GetRootAsFB_DamageBoardTypeContainer(ByteBuffer _bb, FB_DamageBoardTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DamageBoardTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DamageBoardTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DamageBoardType GetItems(int j) { return GetItems(new FB_DamageBoardType(), j); }
  public FB_DamageBoardType GetItems(FB_DamageBoardType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DamageBoardTypeContainer> CreateFB_DamageBoardTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DamageBoardTypeContainer.AddItems(builder, items);
    return FB_DamageBoardTypeContainer.EndFB_DamageBoardTypeContainer(builder);
  }

  public static void StartFB_DamageBoardTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DamageBoardType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DamageBoardTypeContainer> EndFB_DamageBoardTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DamageBoardTypeContainer>(o);
  }
  public static void FinishFB_DamageBoardTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_DamageBoardTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
