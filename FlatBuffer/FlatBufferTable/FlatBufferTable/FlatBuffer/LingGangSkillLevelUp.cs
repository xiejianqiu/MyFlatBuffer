// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingGangSkillLevelUp : Table {
  public static FB_LingGangSkillLevelUp GetRootAsFB_LingGangSkillLevelUp(ByteBuffer _bb) { return GetRootAsFB_LingGangSkillLevelUp(_bb, new FB_LingGangSkillLevelUp()); }
  public static FB_LingGangSkillLevelUp GetRootAsFB_LingGangSkillLevelUp(ByteBuffer _bb, FB_LingGangSkillLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingGangSkillLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int PassiveSkillId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LingGangSkillLevelUp> CreateFB_LingGangSkillLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int PassiveSkillId = -1,
      int ItemId = -1,
      int ItemCount = -1) {
    builder.StartObject(5);
    FB_LingGangSkillLevelUp.AddItemCount(builder, ItemCount);
    FB_LingGangSkillLevelUp.AddItemId(builder, ItemId);
    FB_LingGangSkillLevelUp.AddPassiveSkillId(builder, PassiveSkillId);
    FB_LingGangSkillLevelUp.AddName(builder, Name);
    FB_LingGangSkillLevelUp.AddId(builder, Id);
    return FB_LingGangSkillLevelUp.EndFB_LingGangSkillLevelUp(builder);
  }

  public static void StartFB_LingGangSkillLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(2, PassiveSkillId, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(3, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(4, ItemCount, -1); }
  public static Offset<FB_LingGangSkillLevelUp> EndFB_LingGangSkillLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangSkillLevelUp>(o);
  }
};

public sealed class FB_LingGangSkillLevelUpContainer : Table {
  public static FB_LingGangSkillLevelUpContainer GetRootAsFB_LingGangSkillLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_LingGangSkillLevelUpContainer(_bb, new FB_LingGangSkillLevelUpContainer()); }
  public static FB_LingGangSkillLevelUpContainer GetRootAsFB_LingGangSkillLevelUpContainer(ByteBuffer _bb, FB_LingGangSkillLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingGangSkillLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingGangSkillLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingGangSkillLevelUp GetItems(int j) { return GetItems(new FB_LingGangSkillLevelUp(), j); }
  public FB_LingGangSkillLevelUp GetItems(FB_LingGangSkillLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangSkillLevelUpContainer> CreateFB_LingGangSkillLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingGangSkillLevelUpContainer.AddItems(builder, items);
    return FB_LingGangSkillLevelUpContainer.EndFB_LingGangSkillLevelUpContainer(builder);
  }

  public static void StartFB_LingGangSkillLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingGangSkillLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangSkillLevelUpContainer> EndFB_LingGangSkillLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangSkillLevelUpContainer>(o);
  }
  public static void FinishFB_LingGangSkillLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingGangSkillLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
