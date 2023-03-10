// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JuHunAttr : Table {
  public static FB_JuHunAttr GetRootAsFB_JuHunAttr(ByteBuffer _bb) { return GetRootAsFB_JuHunAttr(_bb, new FB_JuHunAttr()); }
  public static FB_JuHunAttr GetRootAsFB_JuHunAttr(ByteBuffer _bb, FB_JuHunAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JuHunAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelupType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Exp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueIncList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueIncListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public float GetAttrValueIncRangeList(int j) { int o = __offset(20); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int AttrValueIncRangeListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public string IconSpriteName { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_JuHunAttr> CreateFB_JuHunAttr(FlatBufferBuilder builder,
      int ID = 0,
      int LevelupType = -1,
      int Exp = -1,
      int Type = -1,
      int MaxLevel = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset AttrValueIncList = default(VectorOffset),
      VectorOffset AttrValueIncRangeList = default(VectorOffset),
      StringOffset IconSpriteName = default(StringOffset)) {
    builder.StartObject(10);
    FB_JuHunAttr.AddIconSpriteName(builder, IconSpriteName);
    FB_JuHunAttr.AddAttrValueIncRangeList(builder, AttrValueIncRangeList);
    FB_JuHunAttr.AddAttrValueIncList(builder, AttrValueIncList);
    FB_JuHunAttr.AddAttrValueList(builder, AttrValueList);
    FB_JuHunAttr.AddAttrIDList(builder, AttrIDList);
    FB_JuHunAttr.AddMaxLevel(builder, MaxLevel);
    FB_JuHunAttr.AddType(builder, Type);
    FB_JuHunAttr.AddExp(builder, Exp);
    FB_JuHunAttr.AddLevelupType(builder, LevelupType);
    FB_JuHunAttr.AddID(builder, ID);
    return FB_JuHunAttr.EndFB_JuHunAttr(builder);
  }

  public static void StartFB_JuHunAttr(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevelupType(FlatBufferBuilder builder, int LevelupType) { builder.AddInt(1, LevelupType, -1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(2, Exp, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(4, MaxLevel, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(5, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueIncList(FlatBufferBuilder builder, VectorOffset AttrValueIncListOffset) { builder.AddOffset(7, AttrValueIncListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueIncListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueIncListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueIncRangeList(FlatBufferBuilder builder, VectorOffset AttrValueIncRangeListOffset) { builder.AddOffset(8, AttrValueIncRangeListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueIncRangeListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartAttrValueIncRangeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIconSpriteName(FlatBufferBuilder builder, StringOffset IconSpriteNameOffset) { builder.AddOffset(9, IconSpriteNameOffset.Value, 0); }
  public static Offset<FB_JuHunAttr> EndFB_JuHunAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuHunAttr>(o);
  }
};

public sealed class FB_JuHunAttrContainer : Table {
  public static FB_JuHunAttrContainer GetRootAsFB_JuHunAttrContainer(ByteBuffer _bb) { return GetRootAsFB_JuHunAttrContainer(_bb, new FB_JuHunAttrContainer()); }
  public static FB_JuHunAttrContainer GetRootAsFB_JuHunAttrContainer(ByteBuffer _bb, FB_JuHunAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JuHunAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JuHunAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JuHunAttr GetItems(int j) { return GetItems(new FB_JuHunAttr(), j); }
  public FB_JuHunAttr GetItems(FB_JuHunAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuHunAttrContainer> CreateFB_JuHunAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JuHunAttrContainer.AddItems(builder, items);
    return FB_JuHunAttrContainer.EndFB_JuHunAttrContainer(builder);
  }

  public static void StartFB_JuHunAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JuHunAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuHunAttrContainer> EndFB_JuHunAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuHunAttrContainer>(o);
  }
  public static void FinishFB_JuHunAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_JuHunAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
