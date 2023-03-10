// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenShouSkill : Table {
  public static FB_ShenShouSkill GetRootAsFB_ShenShouSkill(ByteBuffer _bb) { return GetRootAsFB_ShenShouSkill(_bb, new FB_ShenShouSkill()); }
  public static FB_ShenShouSkill GetRootAsFB_ShenShouSkill(ByteBuffer _bb, FB_ShenShouSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenShouSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillDescId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShenShouSkill> CreateFB_ShenShouSkill(FlatBufferBuilder builder,
      int ID = 0,
      int PassiveSkillId = -1,
      int Level = -1,
      int SkillDescId = -1) {
    builder.StartObject(4);
    FB_ShenShouSkill.AddSkillDescId(builder, SkillDescId);
    FB_ShenShouSkill.AddLevel(builder, Level);
    FB_ShenShouSkill.AddPassiveSkillId(builder, PassiveSkillId);
    FB_ShenShouSkill.AddID(builder, ID);
    return FB_ShenShouSkill.EndFB_ShenShouSkill(builder);
  }

  public static void StartFB_ShenShouSkill(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(1, PassiveSkillId, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, -1); }
  public static void AddSkillDescId(FlatBufferBuilder builder, int SkillDescId) { builder.AddInt(3, SkillDescId, -1); }
  public static Offset<FB_ShenShouSkill> EndFB_ShenShouSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouSkill>(o);
  }
};

public sealed class FB_ShenShouSkillContainer : Table {
  public static FB_ShenShouSkillContainer GetRootAsFB_ShenShouSkillContainer(ByteBuffer _bb) { return GetRootAsFB_ShenShouSkillContainer(_bb, new FB_ShenShouSkillContainer()); }
  public static FB_ShenShouSkillContainer GetRootAsFB_ShenShouSkillContainer(ByteBuffer _bb, FB_ShenShouSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenShouSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenShouSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenShouSkill GetItems(int j) { return GetItems(new FB_ShenShouSkill(), j); }
  public FB_ShenShouSkill GetItems(FB_ShenShouSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShouSkillContainer> CreateFB_ShenShouSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenShouSkillContainer.AddItems(builder, items);
    return FB_ShenShouSkillContainer.EndFB_ShenShouSkillContainer(builder);
  }

  public static void StartFB_ShenShouSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenShouSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShouSkillContainer> EndFB_ShenShouSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouSkillContainer>(o);
  }
  public static void FinishFB_ShenShouSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenShouSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
