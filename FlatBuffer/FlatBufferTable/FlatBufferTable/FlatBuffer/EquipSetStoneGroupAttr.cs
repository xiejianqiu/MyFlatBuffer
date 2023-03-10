// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipSetStoneGroupAttr : Table {
  public static FB_EquipSetStoneGroupAttr GetRootAsFB_EquipSetStoneGroupAttr(ByteBuffer _bb) { return GetRootAsFB_EquipSetStoneGroupAttr(_bb, new FB_EquipSetStoneGroupAttr()); }
  public static FB_EquipSetStoneGroupAttr GetRootAsFB_EquipSetStoneGroupAttr(ByteBuffer _bb, FB_EquipSetStoneGroupAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipSetStoneGroupAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StoneType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EquipType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSetStoneGroupAttr> CreateFB_EquipSetStoneGroupAttr(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int StoneType = -1,
      int EquipType = -1,
      int Quality = 0,
      int Level = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_EquipSetStoneGroupAttr.AddAttrValueList(builder, AttrValueList);
    FB_EquipSetStoneGroupAttr.AddAttrIDList(builder, AttrIDList);
    FB_EquipSetStoneGroupAttr.AddLevel(builder, Level);
    FB_EquipSetStoneGroupAttr.AddQuality(builder, Quality);
    FB_EquipSetStoneGroupAttr.AddEquipType(builder, EquipType);
    FB_EquipSetStoneGroupAttr.AddStoneType(builder, StoneType);
    FB_EquipSetStoneGroupAttr.AddName(builder, Name);
    FB_EquipSetStoneGroupAttr.AddId(builder, Id);
    return FB_EquipSetStoneGroupAttr.EndFB_EquipSetStoneGroupAttr(builder);
  }

  public static void StartFB_EquipSetStoneGroupAttr(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddStoneType(FlatBufferBuilder builder, int StoneType) { builder.AddInt(2, StoneType, -1); }
  public static void AddEquipType(FlatBufferBuilder builder, int EquipType) { builder.AddInt(3, EquipType, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(4, Quality, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(5, Level, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(6, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(7, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSetStoneGroupAttr> EndFB_EquipSetStoneGroupAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSetStoneGroupAttr>(o);
  }
};

public sealed class FB_EquipSetStoneGroupAttrContainer : Table {
  public static FB_EquipSetStoneGroupAttrContainer GetRootAsFB_EquipSetStoneGroupAttrContainer(ByteBuffer _bb) { return GetRootAsFB_EquipSetStoneGroupAttrContainer(_bb, new FB_EquipSetStoneGroupAttrContainer()); }
  public static FB_EquipSetStoneGroupAttrContainer GetRootAsFB_EquipSetStoneGroupAttrContainer(ByteBuffer _bb, FB_EquipSetStoneGroupAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipSetStoneGroupAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipSetStoneGroupAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipSetStoneGroupAttr GetItems(int j) { return GetItems(new FB_EquipSetStoneGroupAttr(), j); }
  public FB_EquipSetStoneGroupAttr GetItems(FB_EquipSetStoneGroupAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSetStoneGroupAttrContainer> CreateFB_EquipSetStoneGroupAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipSetStoneGroupAttrContainer.AddItems(builder, items);
    return FB_EquipSetStoneGroupAttrContainer.EndFB_EquipSetStoneGroupAttrContainer(builder);
  }

  public static void StartFB_EquipSetStoneGroupAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipSetStoneGroupAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSetStoneGroupAttrContainer> EndFB_EquipSetStoneGroupAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSetStoneGroupAttrContainer>(o);
  }
  public static void FinishFB_EquipSetStoneGroupAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipSetStoneGroupAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
