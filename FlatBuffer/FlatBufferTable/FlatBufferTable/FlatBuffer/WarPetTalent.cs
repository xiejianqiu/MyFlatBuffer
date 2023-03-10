// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetTalent : Table {
  public static FB_WarPetTalent GetRootAsFB_WarPetTalent(ByteBuffer _bb) { return GetRootAsFB_WarPetTalent(_bb, new FB_WarPetTalent()); }
  public static FB_WarPetTalent GetRootAsFB_WarPetTalent(ByteBuffer _bb, FB_WarPetTalent obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetTalent __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SkillDesc { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int SkillId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddImpact { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WarPetTalent> CreateFB_WarPetTalent(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int SkillDesc = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValList = default(VectorOffset),
      int SkillId = -1,
      int AddImpact = -1,
      int Component = -1,
      int Level = -1,
      int CostItemId = -1) {
    builder.StartObject(11);
    FB_WarPetTalent.AddCostItemId(builder, CostItemId);
    FB_WarPetTalent.AddLevel(builder, Level);
    FB_WarPetTalent.AddComponent(builder, Component);
    FB_WarPetTalent.AddAddImpact(builder, AddImpact);
    FB_WarPetTalent.AddSkillId(builder, SkillId);
    FB_WarPetTalent.AddAttrValList(builder, AttrValList);
    FB_WarPetTalent.AddAttrIdList(builder, AttrIdList);
    FB_WarPetTalent.AddSkillDesc(builder, SkillDesc);
    FB_WarPetTalent.AddIcon(builder, Icon);
    FB_WarPetTalent.AddName(builder, Name);
    FB_WarPetTalent.AddID(builder, ID);
    return FB_WarPetTalent.EndFB_WarPetTalent(builder);
  }

  public static void StartFB_WarPetTalent(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddSkillDesc(FlatBufferBuilder builder, int SkillDesc) { builder.AddInt(3, SkillDesc, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValList(FlatBufferBuilder builder, VectorOffset AttrValListOffset) { builder.AddOffset(5, AttrValListOffset.Value, 0); }
  public static VectorOffset CreateAttrValListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillId(FlatBufferBuilder builder, int SkillId) { builder.AddInt(6, SkillId, -1); }
  public static void AddAddImpact(FlatBufferBuilder builder, int AddImpact) { builder.AddInt(7, AddImpact, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(8, Component, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(9, Level, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(10, CostItemId, -1); }
  public static Offset<FB_WarPetTalent> EndFB_WarPetTalent(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetTalent>(o);
  }
};

public sealed class FB_WarPetTalentContainer : Table {
  public static FB_WarPetTalentContainer GetRootAsFB_WarPetTalentContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetTalentContainer(_bb, new FB_WarPetTalentContainer()); }
  public static FB_WarPetTalentContainer GetRootAsFB_WarPetTalentContainer(ByteBuffer _bb, FB_WarPetTalentContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetTalentContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetTalentContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetTalent GetItems(int j) { return GetItems(new FB_WarPetTalent(), j); }
  public FB_WarPetTalent GetItems(FB_WarPetTalent obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetTalentContainer> CreateFB_WarPetTalentContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetTalentContainer.AddItems(builder, items);
    return FB_WarPetTalentContainer.EndFB_WarPetTalentContainer(builder);
  }

  public static void StartFB_WarPetTalentContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetTalent>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetTalentContainer> EndFB_WarPetTalentContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetTalentContainer>(o);
  }
  public static void FinishFB_WarPetTalentContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetTalentContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
