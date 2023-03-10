// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetSkill : Table {
  public static FB_WarPetSkill GetRootAsFB_WarPetSkill(ByteBuffer _bb) { return GetRootAsFB_WarPetSkill(_bb, new FB_WarPetSkill()); }
  public static FB_WarPetSkill GetRootAsFB_WarPetSkill(ByteBuffer _bb, FB_WarPetSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SkillDesc { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WarPetSkill> CreateFB_WarPetSkill(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int SkillDesc = -1,
      int Type = -1,
      int SkillId = -1,
      int Quality = -1,
      int MaxLevel = -1) {
    builder.StartObject(8);
    FB_WarPetSkill.AddMaxLevel(builder, MaxLevel);
    FB_WarPetSkill.AddQuality(builder, Quality);
    FB_WarPetSkill.AddSkillId(builder, SkillId);
    FB_WarPetSkill.AddType(builder, Type);
    FB_WarPetSkill.AddSkillDesc(builder, SkillDesc);
    FB_WarPetSkill.AddIcon(builder, Icon);
    FB_WarPetSkill.AddName(builder, Name);
    FB_WarPetSkill.AddID(builder, ID);
    return FB_WarPetSkill.EndFB_WarPetSkill(builder);
  }

  public static void StartFB_WarPetSkill(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddSkillDesc(FlatBufferBuilder builder, int SkillDesc) { builder.AddInt(3, SkillDesc, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(4, Type, -1); }
  public static void AddSkillId(FlatBufferBuilder builder, int SkillId) { builder.AddInt(5, SkillId, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(6, Quality, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(7, MaxLevel, -1); }
  public static Offset<FB_WarPetSkill> EndFB_WarPetSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetSkill>(o);
  }
};

public sealed class FB_WarPetSkillContainer : Table {
  public static FB_WarPetSkillContainer GetRootAsFB_WarPetSkillContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetSkillContainer(_bb, new FB_WarPetSkillContainer()); }
  public static FB_WarPetSkillContainer GetRootAsFB_WarPetSkillContainer(ByteBuffer _bb, FB_WarPetSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetSkill GetItems(int j) { return GetItems(new FB_WarPetSkill(), j); }
  public FB_WarPetSkill GetItems(FB_WarPetSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetSkillContainer> CreateFB_WarPetSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetSkillContainer.AddItems(builder, items);
    return FB_WarPetSkillContainer.EndFB_WarPetSkillContainer(builder);
  }

  public static void StartFB_WarPetSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetSkillContainer> EndFB_WarPetSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetSkillContainer>(o);
  }
  public static void FinishFB_WarPetSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
