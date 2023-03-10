// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipPartZhuHun : Table {
  public static FB_EquipPartZhuHun GetRootAsFB_EquipPartZhuHun(ByteBuffer _bb) { return GetRootAsFB_EquipPartZhuHun(_bb, new FB_EquipPartZhuHun()); }
  public static FB_EquipPartZhuHun GetRootAsFB_EquipPartZhuHun(ByteBuffer _bb, FB_EquipPartZhuHun obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipPartZhuHun __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsStep { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int AttrId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrValue { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelUpRate { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ClientLevelUpRate { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FailLevel { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyCost { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarNeed { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_EquipPartZhuHun> CreateFB_EquipPartZhuHun(FlatBufferBuilder builder,
      int Id = 0,
      int ItemId = 0,
      int ItemCount = 0,
      bool IsStep = false,
      int AttrId = 0,
      int AttrValue = 0,
      int LevelUpRate = 0,
      int ClientLevelUpRate = 0,
      int FailLevel = 0,
      int MoneyType = 0,
      int MoneyCost = 0,
      int PassiveSkillId = 0,
      int StarNeed = 0) {
    builder.StartObject(13);
    FB_EquipPartZhuHun.AddStarNeed(builder, StarNeed);
    FB_EquipPartZhuHun.AddPassiveSkillId(builder, PassiveSkillId);
    FB_EquipPartZhuHun.AddMoneyCost(builder, MoneyCost);
    FB_EquipPartZhuHun.AddMoneyType(builder, MoneyType);
    FB_EquipPartZhuHun.AddFailLevel(builder, FailLevel);
    FB_EquipPartZhuHun.AddClientLevelUpRate(builder, ClientLevelUpRate);
    FB_EquipPartZhuHun.AddLevelUpRate(builder, LevelUpRate);
    FB_EquipPartZhuHun.AddAttrValue(builder, AttrValue);
    FB_EquipPartZhuHun.AddAttrId(builder, AttrId);
    FB_EquipPartZhuHun.AddItemCount(builder, ItemCount);
    FB_EquipPartZhuHun.AddItemId(builder, ItemId);
    FB_EquipPartZhuHun.AddId(builder, Id);
    FB_EquipPartZhuHun.AddIsStep(builder, IsStep);
    return FB_EquipPartZhuHun.EndFB_EquipPartZhuHun(builder);
  }

  public static void StartFB_EquipPartZhuHun(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(1, ItemId, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(2, ItemCount, 0); }
  public static void AddIsStep(FlatBufferBuilder builder, bool IsStep) { builder.AddBool(3, IsStep, false); }
  public static void AddAttrId(FlatBufferBuilder builder, int AttrId) { builder.AddInt(4, AttrId, 0); }
  public static void AddAttrValue(FlatBufferBuilder builder, int AttrValue) { builder.AddInt(5, AttrValue, 0); }
  public static void AddLevelUpRate(FlatBufferBuilder builder, int LevelUpRate) { builder.AddInt(6, LevelUpRate, 0); }
  public static void AddClientLevelUpRate(FlatBufferBuilder builder, int ClientLevelUpRate) { builder.AddInt(7, ClientLevelUpRate, 0); }
  public static void AddFailLevel(FlatBufferBuilder builder, int FailLevel) { builder.AddInt(8, FailLevel, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(9, MoneyType, 0); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(10, MoneyCost, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(11, PassiveSkillId, 0); }
  public static void AddStarNeed(FlatBufferBuilder builder, int StarNeed) { builder.AddInt(12, StarNeed, 0); }
  public static Offset<FB_EquipPartZhuHun> EndFB_EquipPartZhuHun(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipPartZhuHun>(o);
  }
};

public sealed class FB_EquipPartZhuHunContainer : Table {
  public static FB_EquipPartZhuHunContainer GetRootAsFB_EquipPartZhuHunContainer(ByteBuffer _bb) { return GetRootAsFB_EquipPartZhuHunContainer(_bb, new FB_EquipPartZhuHunContainer()); }
  public static FB_EquipPartZhuHunContainer GetRootAsFB_EquipPartZhuHunContainer(ByteBuffer _bb, FB_EquipPartZhuHunContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipPartZhuHunContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipPartZhuHunContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipPartZhuHun GetItems(int j) { return GetItems(new FB_EquipPartZhuHun(), j); }
  public FB_EquipPartZhuHun GetItems(FB_EquipPartZhuHun obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipPartZhuHunContainer> CreateFB_EquipPartZhuHunContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipPartZhuHunContainer.AddItems(builder, items);
    return FB_EquipPartZhuHunContainer.EndFB_EquipPartZhuHunContainer(builder);
  }

  public static void StartFB_EquipPartZhuHunContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipPartZhuHun>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipPartZhuHunContainer> EndFB_EquipPartZhuHunContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipPartZhuHunContainer>(o);
  }
  public static void FinishFB_EquipPartZhuHunContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipPartZhuHunContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
