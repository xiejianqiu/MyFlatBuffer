// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinySkill : Table {
  public static FB_DestinySkill GetRootAsFB_DestinySkill(ByteBuffer _bb) { return GetRootAsFB_DestinySkill(_bb, new FB_DestinySkill()); }
  public static FB_DestinySkill GetRootAsFB_DestinySkill(ByteBuffer _bb, FB_DestinySkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinySkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowOnUI { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int UnLockLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DestinySkill> CreateFB_DestinySkill(FlatBufferBuilder builder,
      int ID = 0,
      int PassiveSkillId = -1,
      bool IsShowOnUI = false,
      int UnLockLevel = -1) {
    builder.StartObject(4);
    FB_DestinySkill.AddUnLockLevel(builder, UnLockLevel);
    FB_DestinySkill.AddPassiveSkillId(builder, PassiveSkillId);
    FB_DestinySkill.AddID(builder, ID);
    FB_DestinySkill.AddIsShowOnUI(builder, IsShowOnUI);
    return FB_DestinySkill.EndFB_DestinySkill(builder);
  }

  public static void StartFB_DestinySkill(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(1, PassiveSkillId, -1); }
  public static void AddIsShowOnUI(FlatBufferBuilder builder, bool IsShowOnUI) { builder.AddBool(2, IsShowOnUI, false); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(3, UnLockLevel, -1); }
  public static Offset<FB_DestinySkill> EndFB_DestinySkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinySkill>(o);
  }
};

public sealed class FB_DestinySkillContainer : Table {
  public static FB_DestinySkillContainer GetRootAsFB_DestinySkillContainer(ByteBuffer _bb) { return GetRootAsFB_DestinySkillContainer(_bb, new FB_DestinySkillContainer()); }
  public static FB_DestinySkillContainer GetRootAsFB_DestinySkillContainer(ByteBuffer _bb, FB_DestinySkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinySkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinySkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinySkill GetItems(int j) { return GetItems(new FB_DestinySkill(), j); }
  public FB_DestinySkill GetItems(FB_DestinySkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinySkillContainer> CreateFB_DestinySkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinySkillContainer.AddItems(builder, items);
    return FB_DestinySkillContainer.EndFB_DestinySkillContainer(builder);
  }

  public static void StartFB_DestinySkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinySkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinySkillContainer> EndFB_DestinySkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinySkillContainer>(o);
  }
  public static void FinishFB_DestinySkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinySkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
