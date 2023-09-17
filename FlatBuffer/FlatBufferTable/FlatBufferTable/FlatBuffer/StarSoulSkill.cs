// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarSoulSkill : Table {
  public static FB_StarSoulSkill GetRootAsFB_StarSoulSkill(ByteBuffer _bb) { return GetRootAsFB_StarSoulSkill(_bb, new FB_StarSoulSkill()); }
  public static FB_StarSoulSkill GetRootAsFB_StarSoulSkill(ByteBuffer _bb, FB_StarSoulSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarSoulSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ReplacePassiveSkillId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InvalidPassiveSkillId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowOnUI { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int UnLockLevel { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StarSoulSkill> CreateFB_StarSoulSkill(FlatBufferBuilder builder,
      int ID = 0,
      int PassiveSkillId = -1,
      int ReplacePassiveSkillId = -1,
      int InvalidPassiveSkillId = -1,
      bool IsShowOnUI = false,
      int UnLockLevel = -1,
      int SkillLevel = -1) {
    builder.StartObject(7);
    FB_StarSoulSkill.AddSkillLevel(builder, SkillLevel);
    FB_StarSoulSkill.AddUnLockLevel(builder, UnLockLevel);
    FB_StarSoulSkill.AddInvalidPassiveSkillId(builder, InvalidPassiveSkillId);
    FB_StarSoulSkill.AddReplacePassiveSkillId(builder, ReplacePassiveSkillId);
    FB_StarSoulSkill.AddPassiveSkillId(builder, PassiveSkillId);
    FB_StarSoulSkill.AddID(builder, ID);
    FB_StarSoulSkill.AddIsShowOnUI(builder, IsShowOnUI);
    return FB_StarSoulSkill.EndFB_StarSoulSkill(builder);
  }

  public static void StartFB_StarSoulSkill(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(1, PassiveSkillId, -1); }
  public static void AddReplacePassiveSkillId(FlatBufferBuilder builder, int ReplacePassiveSkillId) { builder.AddInt(2, ReplacePassiveSkillId, -1); }
  public static void AddInvalidPassiveSkillId(FlatBufferBuilder builder, int InvalidPassiveSkillId) { builder.AddInt(3, InvalidPassiveSkillId, -1); }
  public static void AddIsShowOnUI(FlatBufferBuilder builder, bool IsShowOnUI) { builder.AddBool(4, IsShowOnUI, false); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(5, UnLockLevel, -1); }
  public static void AddSkillLevel(FlatBufferBuilder builder, int SkillLevel) { builder.AddInt(6, SkillLevel, -1); }
  public static Offset<FB_StarSoulSkill> EndFB_StarSoulSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulSkill>(o);
  }
};

public sealed class FB_StarSoulSkillContainer : Table {
  public static FB_StarSoulSkillContainer GetRootAsFB_StarSoulSkillContainer(ByteBuffer _bb) { return GetRootAsFB_StarSoulSkillContainer(_bb, new FB_StarSoulSkillContainer()); }
  public static FB_StarSoulSkillContainer GetRootAsFB_StarSoulSkillContainer(ByteBuffer _bb, FB_StarSoulSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarSoulSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarSoulSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarSoulSkill GetItems(int j) { return GetItems(new FB_StarSoulSkill(), j); }
  public FB_StarSoulSkill GetItems(FB_StarSoulSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarSoulSkillContainer> CreateFB_StarSoulSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarSoulSkillContainer.AddItems(builder, items);
    return FB_StarSoulSkillContainer.EndFB_StarSoulSkillContainer(builder);
  }

  public static void StartFB_StarSoulSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarSoulSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarSoulSkillContainer> EndFB_StarSoulSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulSkillContainer>(o);
  }
  public static void FinishFB_StarSoulSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarSoulSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
