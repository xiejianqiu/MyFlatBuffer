// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunTeZhiPassiveSkill : Table {
  public static FB_XingHunTeZhiPassiveSkill GetRootAsFB_XingHunTeZhiPassiveSkill(ByteBuffer _bb) { return GetRootAsFB_XingHunTeZhiPassiveSkill(_bb, new FB_XingHunTeZhiPassiveSkill()); }
  public static FB_XingHunTeZhiPassiveSkill GetRootAsFB_XingHunTeZhiPassiveSkill(ByteBuffer _bb, FB_XingHunTeZhiPassiveSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunTeZhiPassiveSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_XingHunTeZhiPassiveSkill> CreateFB_XingHunTeZhiPassiveSkill(FlatBufferBuilder builder,
      int Id = 0,
      int UnLockLevel = 0,
      int PassiveSkillId = 0) {
    builder.StartObject(3);
    FB_XingHunTeZhiPassiveSkill.AddPassiveSkillId(builder, PassiveSkillId);
    FB_XingHunTeZhiPassiveSkill.AddUnLockLevel(builder, UnLockLevel);
    FB_XingHunTeZhiPassiveSkill.AddId(builder, Id);
    return FB_XingHunTeZhiPassiveSkill.EndFB_XingHunTeZhiPassiveSkill(builder);
  }

  public static void StartFB_XingHunTeZhiPassiveSkill(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(1, UnLockLevel, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(2, PassiveSkillId, 0); }
  public static Offset<FB_XingHunTeZhiPassiveSkill> EndFB_XingHunTeZhiPassiveSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunTeZhiPassiveSkill>(o);
  }
};

public sealed class FB_XingHunTeZhiPassiveSkillContainer : Table {
  public static FB_XingHunTeZhiPassiveSkillContainer GetRootAsFB_XingHunTeZhiPassiveSkillContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunTeZhiPassiveSkillContainer(_bb, new FB_XingHunTeZhiPassiveSkillContainer()); }
  public static FB_XingHunTeZhiPassiveSkillContainer GetRootAsFB_XingHunTeZhiPassiveSkillContainer(ByteBuffer _bb, FB_XingHunTeZhiPassiveSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunTeZhiPassiveSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunTeZhiPassiveSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunTeZhiPassiveSkill GetItems(int j) { return GetItems(new FB_XingHunTeZhiPassiveSkill(), j); }
  public FB_XingHunTeZhiPassiveSkill GetItems(FB_XingHunTeZhiPassiveSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunTeZhiPassiveSkillContainer> CreateFB_XingHunTeZhiPassiveSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunTeZhiPassiveSkillContainer.AddItems(builder, items);
    return FB_XingHunTeZhiPassiveSkillContainer.EndFB_XingHunTeZhiPassiveSkillContainer(builder);
  }

  public static void StartFB_XingHunTeZhiPassiveSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunTeZhiPassiveSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunTeZhiPassiveSkillContainer> EndFB_XingHunTeZhiPassiveSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunTeZhiPassiveSkillContainer>(o);
  }
  public static void FinishFB_XingHunTeZhiPassiveSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunTeZhiPassiveSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
