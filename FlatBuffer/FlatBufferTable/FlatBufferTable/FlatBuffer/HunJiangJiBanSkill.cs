// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangJiBanSkill : Table {
  public static FB_HunJiangJiBanSkill GetRootAsFB_HunJiangJiBanSkill(ByteBuffer _bb) { return GetRootAsFB_HunJiangJiBanSkill(_bb, new FB_HunJiangJiBanSkill()); }
  public static FB_HunJiangJiBanSkill GetRootAsFB_HunJiangJiBanSkill(ByteBuffer _bb, FB_HunJiangJiBanSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangJiBanSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int PassiveSkillID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_HunJiangJiBanSkill> CreateFB_HunJiangJiBanSkill(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int PassiveSkillID = -1) {
    builder.StartObject(3);
    FB_HunJiangJiBanSkill.AddPassiveSkillID(builder, PassiveSkillID);
    FB_HunJiangJiBanSkill.AddName(builder, Name);
    FB_HunJiangJiBanSkill.AddID(builder, ID);
    return FB_HunJiangJiBanSkill.EndFB_HunJiangJiBanSkill(builder);
  }

  public static void StartFB_HunJiangJiBanSkill(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPassiveSkillID(FlatBufferBuilder builder, int PassiveSkillID) { builder.AddInt(2, PassiveSkillID, -1); }
  public static Offset<FB_HunJiangJiBanSkill> EndFB_HunJiangJiBanSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJiBanSkill>(o);
  }
};

public sealed class FB_HunJiangJiBanSkillContainer : Table {
  public static FB_HunJiangJiBanSkillContainer GetRootAsFB_HunJiangJiBanSkillContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangJiBanSkillContainer(_bb, new FB_HunJiangJiBanSkillContainer()); }
  public static FB_HunJiangJiBanSkillContainer GetRootAsFB_HunJiangJiBanSkillContainer(ByteBuffer _bb, FB_HunJiangJiBanSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangJiBanSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangJiBanSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangJiBanSkill GetItems(int j) { return GetItems(new FB_HunJiangJiBanSkill(), j); }
  public FB_HunJiangJiBanSkill GetItems(FB_HunJiangJiBanSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangJiBanSkillContainer> CreateFB_HunJiangJiBanSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangJiBanSkillContainer.AddItems(builder, items);
    return FB_HunJiangJiBanSkillContainer.EndFB_HunJiangJiBanSkillContainer(builder);
  }

  public static void StartFB_HunJiangJiBanSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangJiBanSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangJiBanSkillContainer> EndFB_HunJiangJiBanSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJiBanSkillContainer>(o);
  }
  public static void FinishFB_HunJiangJiBanSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangJiBanSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
