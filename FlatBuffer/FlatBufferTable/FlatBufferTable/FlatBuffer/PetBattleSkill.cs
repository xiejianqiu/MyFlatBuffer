// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PetBattleSkill : Table {
  public static FB_PetBattleSkill GetRootAsFB_PetBattleSkill(ByteBuffer _bb) { return GetRootAsFB_PetBattleSkill(_bb, new FB_PetBattleSkill()); }
  public static FB_PetBattleSkill GetRootAsFB_PetBattleSkill(ByteBuffer _bb, FB_PetBattleSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PetBattleSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int PassiveSkillId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PetBattleSkill> CreateFB_PetBattleSkill(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int PassiveSkillId = -1,
      int ItemId = -1,
      int ItemCount = -1) {
    builder.StartObject(5);
    FB_PetBattleSkill.AddItemCount(builder, ItemCount);
    FB_PetBattleSkill.AddItemId(builder, ItemId);
    FB_PetBattleSkill.AddPassiveSkillId(builder, PassiveSkillId);
    FB_PetBattleSkill.AddName(builder, Name);
    FB_PetBattleSkill.AddId(builder, Id);
    return FB_PetBattleSkill.EndFB_PetBattleSkill(builder);
  }

  public static void StartFB_PetBattleSkill(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(2, PassiveSkillId, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(3, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(4, ItemCount, -1); }
  public static Offset<FB_PetBattleSkill> EndFB_PetBattleSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetBattleSkill>(o);
  }
};

public sealed class FB_PetBattleSkillContainer : Table {
  public static FB_PetBattleSkillContainer GetRootAsFB_PetBattleSkillContainer(ByteBuffer _bb) { return GetRootAsFB_PetBattleSkillContainer(_bb, new FB_PetBattleSkillContainer()); }
  public static FB_PetBattleSkillContainer GetRootAsFB_PetBattleSkillContainer(ByteBuffer _bb, FB_PetBattleSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PetBattleSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PetBattleSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PetBattleSkill GetItems(int j) { return GetItems(new FB_PetBattleSkill(), j); }
  public FB_PetBattleSkill GetItems(FB_PetBattleSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PetBattleSkillContainer> CreateFB_PetBattleSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PetBattleSkillContainer.AddItems(builder, items);
    return FB_PetBattleSkillContainer.EndFB_PetBattleSkillContainer(builder);
  }

  public static void StartFB_PetBattleSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PetBattleSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PetBattleSkillContainer> EndFB_PetBattleSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetBattleSkillContainer>(o);
  }
  public static void FinishFB_PetBattleSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_PetBattleSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
