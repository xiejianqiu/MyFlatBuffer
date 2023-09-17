// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenShouBase : Table {
  public static FB_ShenShouBase GetRootAsFB_ShenShouBase(ByteBuffer _bb) { return GetRootAsFB_ShenShouBase(_bb, new FB_ShenShouBase()); }
  public static FB_ShenShouBase GetRootAsFB_ShenShouBase(ByteBuffer _bb, FB_ShenShouBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenShouBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetEquipQualityList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EquipQualityListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSkillList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkillListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShouBase> CreateFB_ShenShouBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset EquipQualityList = default(VectorOffset),
      VectorOffset SkillList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_ShenShouBase.AddSkillList(builder, SkillList);
    FB_ShenShouBase.AddEquipQualityList(builder, EquipQualityList);
    FB_ShenShouBase.AddAttrValueList(builder, AttrValueList);
    FB_ShenShouBase.AddAttrIdList(builder, AttrIdList);
    FB_ShenShouBase.AddIcon(builder, Icon);
    FB_ShenShouBase.AddName(builder, Name);
    FB_ShenShouBase.AddID(builder, ID);
    return FB_ShenShouBase.EndFB_ShenShouBase(builder);
  }

  public static void StartFB_ShenShouBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEquipQualityList(FlatBufferBuilder builder, VectorOffset EquipQualityListOffset) { builder.AddOffset(5, EquipQualityListOffset.Value, 0); }
  public static VectorOffset CreateEquipQualityListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEquipQualityListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillList(FlatBufferBuilder builder, VectorOffset SkillListOffset) { builder.AddOffset(6, SkillListOffset.Value, 0); }
  public static VectorOffset CreateSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShouBase> EndFB_ShenShouBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouBase>(o);
  }
};

public sealed class FB_ShenShouBaseContainer : Table {
  public static FB_ShenShouBaseContainer GetRootAsFB_ShenShouBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShenShouBaseContainer(_bb, new FB_ShenShouBaseContainer()); }
  public static FB_ShenShouBaseContainer GetRootAsFB_ShenShouBaseContainer(ByteBuffer _bb, FB_ShenShouBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenShouBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenShouBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenShouBase GetItems(int j) { return GetItems(new FB_ShenShouBase(), j); }
  public FB_ShenShouBase GetItems(FB_ShenShouBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShouBaseContainer> CreateFB_ShenShouBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenShouBaseContainer.AddItems(builder, items);
    return FB_ShenShouBaseContainer.EndFB_ShenShouBaseContainer(builder);
  }

  public static void StartFB_ShenShouBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenShouBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShouBaseContainer> EndFB_ShenShouBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouBaseContainer>(o);
  }
  public static void FinishFB_ShenShouBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenShouBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
