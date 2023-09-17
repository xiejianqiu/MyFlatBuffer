// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipZhuHun : Table {
  public static FB_EquipZhuHun GetRootAsFB_EquipZhuHun(ByteBuffer _bb) { return GetRootAsFB_EquipZhuHun(_bb, new FB_EquipZhuHun()); }
  public static FB_EquipZhuHun GetRootAsFB_EquipZhuHun(ByteBuffer _bb, FB_EquipZhuHun obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipZhuHun __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelUpRate { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ClientLevelUpRate { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FailLevel { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyCost { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_EquipZhuHun> CreateFB_EquipZhuHun(FlatBufferBuilder builder,
      int Id = 0,
      int ItemId = 0,
      int ItemCount = 0,
      int AttrId = 0,
      int AttrValue = 0,
      int LevelUpRate = 0,
      int ClientLevelUpRate = 0,
      int FailLevel = 0,
      int MoneyType = 0,
      int MoneyCost = 0,
      int PassiveSkillId = 0) {
    builder.StartObject(11);
    FB_EquipZhuHun.AddPassiveSkillId(builder, PassiveSkillId);
    FB_EquipZhuHun.AddMoneyCost(builder, MoneyCost);
    FB_EquipZhuHun.AddMoneyType(builder, MoneyType);
    FB_EquipZhuHun.AddFailLevel(builder, FailLevel);
    FB_EquipZhuHun.AddClientLevelUpRate(builder, ClientLevelUpRate);
    FB_EquipZhuHun.AddLevelUpRate(builder, LevelUpRate);
    FB_EquipZhuHun.AddAttrValue(builder, AttrValue);
    FB_EquipZhuHun.AddAttrId(builder, AttrId);
    FB_EquipZhuHun.AddItemCount(builder, ItemCount);
    FB_EquipZhuHun.AddItemId(builder, ItemId);
    FB_EquipZhuHun.AddId(builder, Id);
    return FB_EquipZhuHun.EndFB_EquipZhuHun(builder);
  }

  public static void StartFB_EquipZhuHun(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(1, ItemId, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(2, ItemCount, 0); }
  public static void AddAttrId(FlatBufferBuilder builder, int AttrId) { builder.AddInt(3, AttrId, 0); }
  public static void AddAttrValue(FlatBufferBuilder builder, int AttrValue) { builder.AddInt(4, AttrValue, 0); }
  public static void AddLevelUpRate(FlatBufferBuilder builder, int LevelUpRate) { builder.AddInt(5, LevelUpRate, 0); }
  public static void AddClientLevelUpRate(FlatBufferBuilder builder, int ClientLevelUpRate) { builder.AddInt(6, ClientLevelUpRate, 0); }
  public static void AddFailLevel(FlatBufferBuilder builder, int FailLevel) { builder.AddInt(7, FailLevel, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(8, MoneyType, 0); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(9, MoneyCost, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(10, PassiveSkillId, 0); }
  public static Offset<FB_EquipZhuHun> EndFB_EquipZhuHun(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipZhuHun>(o);
  }
};

public sealed class FB_EquipZhuHunContainer : Table {
  public static FB_EquipZhuHunContainer GetRootAsFB_EquipZhuHunContainer(ByteBuffer _bb) { return GetRootAsFB_EquipZhuHunContainer(_bb, new FB_EquipZhuHunContainer()); }
  public static FB_EquipZhuHunContainer GetRootAsFB_EquipZhuHunContainer(ByteBuffer _bb, FB_EquipZhuHunContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipZhuHunContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipZhuHunContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipZhuHun GetItems(int j) { return GetItems(new FB_EquipZhuHun(), j); }
  public FB_EquipZhuHun GetItems(FB_EquipZhuHun obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipZhuHunContainer> CreateFB_EquipZhuHunContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipZhuHunContainer.AddItems(builder, items);
    return FB_EquipZhuHunContainer.EndFB_EquipZhuHunContainer(builder);
  }

  public static void StartFB_EquipZhuHunContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipZhuHun>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipZhuHunContainer> EndFB_EquipZhuHunContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipZhuHunContainer>(o);
  }
  public static void FinishFB_EquipZhuHunContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipZhuHunContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
