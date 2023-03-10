// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyCultureLevelUp : Table {
  public static FB_DestinyCultureLevelUp GetRootAsFB_DestinyCultureLevelUp(ByteBuffer _bb) { return GetRootAsFB_DestinyCultureLevelUp(_bb, new FB_DestinyCultureLevelUp()); }
  public static FB_DestinyCultureLevelUp GetRootAsFB_DestinyCultureLevelUp(ByteBuffer _bb, FB_DestinyCultureLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyCultureLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassiveSkillId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitTemperCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string SkillDesc { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LockSkillDesc { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_DestinyCultureLevelUp> CreateFB_DestinyCultureLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostItemId = -1,
      int CostItemCount = -1,
      int PassiveSkillId = -1,
      int LimitTemperCount = -1,
      StringOffset SkillDesc = default(StringOffset),
      StringOffset LockSkillDesc = default(StringOffset)) {
    builder.StartObject(7);
    FB_DestinyCultureLevelUp.AddLockSkillDesc(builder, LockSkillDesc);
    FB_DestinyCultureLevelUp.AddSkillDesc(builder, SkillDesc);
    FB_DestinyCultureLevelUp.AddLimitTemperCount(builder, LimitTemperCount);
    FB_DestinyCultureLevelUp.AddPassiveSkillId(builder, PassiveSkillId);
    FB_DestinyCultureLevelUp.AddCostItemCount(builder, CostItemCount);
    FB_DestinyCultureLevelUp.AddCostItemId(builder, CostItemId);
    FB_DestinyCultureLevelUp.AddId(builder, Id);
    return FB_DestinyCultureLevelUp.EndFB_DestinyCultureLevelUp(builder);
  }

  public static void StartFB_DestinyCultureLevelUp(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(1, CostItemId, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(2, CostItemCount, -1); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(3, PassiveSkillId, -1); }
  public static void AddLimitTemperCount(FlatBufferBuilder builder, int LimitTemperCount) { builder.AddInt(4, LimitTemperCount, -1); }
  public static void AddSkillDesc(FlatBufferBuilder builder, StringOffset SkillDescOffset) { builder.AddOffset(5, SkillDescOffset.Value, 0); }
  public static void AddLockSkillDesc(FlatBufferBuilder builder, StringOffset LockSkillDescOffset) { builder.AddOffset(6, LockSkillDescOffset.Value, 0); }
  public static Offset<FB_DestinyCultureLevelUp> EndFB_DestinyCultureLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyCultureLevelUp>(o);
  }
};

public sealed class FB_DestinyCultureLevelUpContainer : Table {
  public static FB_DestinyCultureLevelUpContainer GetRootAsFB_DestinyCultureLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyCultureLevelUpContainer(_bb, new FB_DestinyCultureLevelUpContainer()); }
  public static FB_DestinyCultureLevelUpContainer GetRootAsFB_DestinyCultureLevelUpContainer(ByteBuffer _bb, FB_DestinyCultureLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyCultureLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyCultureLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyCultureLevelUp GetItems(int j) { return GetItems(new FB_DestinyCultureLevelUp(), j); }
  public FB_DestinyCultureLevelUp GetItems(FB_DestinyCultureLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyCultureLevelUpContainer> CreateFB_DestinyCultureLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyCultureLevelUpContainer.AddItems(builder, items);
    return FB_DestinyCultureLevelUpContainer.EndFB_DestinyCultureLevelUpContainer(builder);
  }

  public static void StartFB_DestinyCultureLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyCultureLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyCultureLevelUpContainer> EndFB_DestinyCultureLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyCultureLevelUpContainer>(o);
  }
  public static void FinishFB_DestinyCultureLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyCultureLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
