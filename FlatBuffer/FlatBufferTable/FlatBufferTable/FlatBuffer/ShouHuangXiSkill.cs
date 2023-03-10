// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShouHuangXiSkill : Table {
  public static FB_ShouHuangXiSkill GetRootAsFB_ShouHuangXiSkill(ByteBuffer _bb) { return GetRootAsFB_ShouHuangXiSkill(_bb, new FB_ShouHuangXiSkill()); }
  public static FB_ShouHuangXiSkill GetRootAsFB_ShouHuangXiSkill(ByteBuffer _bb, FB_ShouHuangXiSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShouHuangXiSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockParam { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassiveSkillId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShouHuangXiSkill> CreateFB_ShouHuangXiSkill(FlatBufferBuilder builder,
      int Id = 0,
      int UnlockType = -1,
      int UnlockParam = -1,
      int PassiveSkillId = -1) {
    builder.StartObject(4);
    FB_ShouHuangXiSkill.AddPassiveSkillId(builder, PassiveSkillId);
    FB_ShouHuangXiSkill.AddUnlockParam(builder, UnlockParam);
    FB_ShouHuangXiSkill.AddUnlockType(builder, UnlockType);
    FB_ShouHuangXiSkill.AddId(builder, Id);
    return FB_ShouHuangXiSkill.EndFB_ShouHuangXiSkill(builder);
  }

  public static void StartFB_ShouHuangXiSkill(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(1, UnlockType, -1); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(2, UnlockParam, -1); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(3, PassiveSkillId, -1); }
  public static Offset<FB_ShouHuangXiSkill> EndFB_ShouHuangXiSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShouHuangXiSkill>(o);
  }
};

public sealed class FB_ShouHuangXiSkillContainer : Table {
  public static FB_ShouHuangXiSkillContainer GetRootAsFB_ShouHuangXiSkillContainer(ByteBuffer _bb) { return GetRootAsFB_ShouHuangXiSkillContainer(_bb, new FB_ShouHuangXiSkillContainer()); }
  public static FB_ShouHuangXiSkillContainer GetRootAsFB_ShouHuangXiSkillContainer(ByteBuffer _bb, FB_ShouHuangXiSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShouHuangXiSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShouHuangXiSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShouHuangXiSkill GetItems(int j) { return GetItems(new FB_ShouHuangXiSkill(), j); }
  public FB_ShouHuangXiSkill GetItems(FB_ShouHuangXiSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShouHuangXiSkillContainer> CreateFB_ShouHuangXiSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShouHuangXiSkillContainer.AddItems(builder, items);
    return FB_ShouHuangXiSkillContainer.EndFB_ShouHuangXiSkillContainer(builder);
  }

  public static void StartFB_ShouHuangXiSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShouHuangXiSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShouHuangXiSkillContainer> EndFB_ShouHuangXiSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShouHuangXiSkillContainer>(o);
  }
  public static void FinishFB_ShouHuangXiSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShouHuangXiSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}