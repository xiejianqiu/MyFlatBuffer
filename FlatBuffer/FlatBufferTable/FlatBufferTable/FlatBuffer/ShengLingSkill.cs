// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShengLingSkill : Table {
  public static FB_ShengLingSkill GetRootAsFB_ShengLingSkill(ByteBuffer _bb) { return GetRootAsFB_ShengLingSkill(_bb, new FB_ShengLingSkill()); }
  public static FB_ShengLingSkill GetRootAsFB_ShengLingSkill(ByteBuffer _bb, FB_ShengLingSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShengLingSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string LockDesc { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LevelUpDesc { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_ShengLingSkill> CreateFB_ShengLingSkill(FlatBufferBuilder builder,
      int ID = 0,
      int PassiveSkillId = -1,
      int SkillLevel = -1,
      StringOffset LockDesc = default(StringOffset),
      StringOffset LevelUpDesc = default(StringOffset)) {
    builder.StartObject(5);
    FB_ShengLingSkill.AddLevelUpDesc(builder, LevelUpDesc);
    FB_ShengLingSkill.AddLockDesc(builder, LockDesc);
    FB_ShengLingSkill.AddSkillLevel(builder, SkillLevel);
    FB_ShengLingSkill.AddPassiveSkillId(builder, PassiveSkillId);
    FB_ShengLingSkill.AddID(builder, ID);
    return FB_ShengLingSkill.EndFB_ShengLingSkill(builder);
  }

  public static void StartFB_ShengLingSkill(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(1, PassiveSkillId, -1); }
  public static void AddSkillLevel(FlatBufferBuilder builder, int SkillLevel) { builder.AddInt(2, SkillLevel, -1); }
  public static void AddLockDesc(FlatBufferBuilder builder, StringOffset LockDescOffset) { builder.AddOffset(3, LockDescOffset.Value, 0); }
  public static void AddLevelUpDesc(FlatBufferBuilder builder, StringOffset LevelUpDescOffset) { builder.AddOffset(4, LevelUpDescOffset.Value, 0); }
  public static Offset<FB_ShengLingSkill> EndFB_ShengLingSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingSkill>(o);
  }
};

public sealed class FB_ShengLingSkillContainer : Table {
  public static FB_ShengLingSkillContainer GetRootAsFB_ShengLingSkillContainer(ByteBuffer _bb) { return GetRootAsFB_ShengLingSkillContainer(_bb, new FB_ShengLingSkillContainer()); }
  public static FB_ShengLingSkillContainer GetRootAsFB_ShengLingSkillContainer(ByteBuffer _bb, FB_ShengLingSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShengLingSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShengLingSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShengLingSkill GetItems(int j) { return GetItems(new FB_ShengLingSkill(), j); }
  public FB_ShengLingSkill GetItems(FB_ShengLingSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingSkillContainer> CreateFB_ShengLingSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShengLingSkillContainer.AddItems(builder, items);
    return FB_ShengLingSkillContainer.EndFB_ShengLingSkillContainer(builder);
  }

  public static void StartFB_ShengLingSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShengLingSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingSkillContainer> EndFB_ShengLingSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingSkillContainer>(o);
  }
  public static void FinishFB_ShengLingSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShengLingSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
