// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PhotoEffect : Table {
  public static FB_PhotoEffect GetRootAsFB_PhotoEffect(ByteBuffer _bb) { return GetRootAsFB_PhotoEffect(_bb, new FB_PhotoEffect()); }
  public static FB_PhotoEffect GetRootAsFB_PhotoEffect(ByteBuffer _bb, FB_PhotoEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PhotoEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string IconPath { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int EffectID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string BtnBgIconName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string PhotoEffectName { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BtnLabelColor { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public float Temperature { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Tint { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float HueShift { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Saturation { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Brightness { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Contrast { get { int o = __offset(28); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int SortId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PhotoEffect> CreateFB_PhotoEffect(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset IconPath = default(StringOffset),
      int EffectID = -1,
      StringOffset BtnBgIconName = default(StringOffset),
      StringOffset PhotoEffectName = default(StringOffset),
      StringOffset BtnLabelColor = default(StringOffset),
      float Temperature = 0,
      float Tint = 0,
      float HueShift = 0,
      float Saturation = 0,
      float Brightness = 0,
      float Contrast = 0,
      int SortId = -1) {
    builder.StartObject(14);
    FB_PhotoEffect.AddSortId(builder, SortId);
    FB_PhotoEffect.AddContrast(builder, Contrast);
    FB_PhotoEffect.AddBrightness(builder, Brightness);
    FB_PhotoEffect.AddSaturation(builder, Saturation);
    FB_PhotoEffect.AddHueShift(builder, HueShift);
    FB_PhotoEffect.AddTint(builder, Tint);
    FB_PhotoEffect.AddTemperature(builder, Temperature);
    FB_PhotoEffect.AddBtnLabelColor(builder, BtnLabelColor);
    FB_PhotoEffect.AddPhotoEffectName(builder, PhotoEffectName);
    FB_PhotoEffect.AddBtnBgIconName(builder, BtnBgIconName);
    FB_PhotoEffect.AddEffectID(builder, EffectID);
    FB_PhotoEffect.AddIconPath(builder, IconPath);
    FB_PhotoEffect.AddName(builder, Name);
    FB_PhotoEffect.AddID(builder, ID);
    return FB_PhotoEffect.EndFB_PhotoEffect(builder);
  }

  public static void StartFB_PhotoEffect(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(2, IconPathOffset.Value, 0); }
  public static void AddEffectID(FlatBufferBuilder builder, int EffectID) { builder.AddInt(3, EffectID, -1); }
  public static void AddBtnBgIconName(FlatBufferBuilder builder, StringOffset BtnBgIconNameOffset) { builder.AddOffset(4, BtnBgIconNameOffset.Value, 0); }
  public static void AddPhotoEffectName(FlatBufferBuilder builder, StringOffset PhotoEffectNameOffset) { builder.AddOffset(5, PhotoEffectNameOffset.Value, 0); }
  public static void AddBtnLabelColor(FlatBufferBuilder builder, StringOffset BtnLabelColorOffset) { builder.AddOffset(6, BtnLabelColorOffset.Value, 0); }
  public static void AddTemperature(FlatBufferBuilder builder, float Temperature) { builder.AddFloat(7, Temperature, 0); }
  public static void AddTint(FlatBufferBuilder builder, float Tint) { builder.AddFloat(8, Tint, 0); }
  public static void AddHueShift(FlatBufferBuilder builder, float HueShift) { builder.AddFloat(9, HueShift, 0); }
  public static void AddSaturation(FlatBufferBuilder builder, float Saturation) { builder.AddFloat(10, Saturation, 0); }
  public static void AddBrightness(FlatBufferBuilder builder, float Brightness) { builder.AddFloat(11, Brightness, 0); }
  public static void AddContrast(FlatBufferBuilder builder, float Contrast) { builder.AddFloat(12, Contrast, 0); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(13, SortId, -1); }
  public static Offset<FB_PhotoEffect> EndFB_PhotoEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PhotoEffect>(o);
  }
};

public sealed class FB_PhotoEffectContainer : Table {
  public static FB_PhotoEffectContainer GetRootAsFB_PhotoEffectContainer(ByteBuffer _bb) { return GetRootAsFB_PhotoEffectContainer(_bb, new FB_PhotoEffectContainer()); }
  public static FB_PhotoEffectContainer GetRootAsFB_PhotoEffectContainer(ByteBuffer _bb, FB_PhotoEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PhotoEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PhotoEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PhotoEffect GetItems(int j) { return GetItems(new FB_PhotoEffect(), j); }
  public FB_PhotoEffect GetItems(FB_PhotoEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PhotoEffectContainer> CreateFB_PhotoEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PhotoEffectContainer.AddItems(builder, items);
    return FB_PhotoEffectContainer.EndFB_PhotoEffectContainer(builder);
  }

  public static void StartFB_PhotoEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PhotoEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PhotoEffectContainer> EndFB_PhotoEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PhotoEffectContainer>(o);
  }
  public static void FinishFB_PhotoEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_PhotoEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
