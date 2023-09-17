// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipPartZhuHunBaoShi : Table {
  public static FB_EquipPartZhuHunBaoShi GetRootAsFB_EquipPartZhuHunBaoShi(ByteBuffer _bb) { return GetRootAsFB_EquipPartZhuHunBaoShi(_bb, new FB_EquipPartZhuHunBaoShi()); }
  public static FB_EquipPartZhuHunBaoShi GetRootAsFB_EquipPartZhuHunBaoShi(ByteBuffer _bb, FB_EquipPartZhuHunBaoShi obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipPartZhuHunBaoShi __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsStep { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int LevelUpRate { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ClientLevelUpRate { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FailLevel { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyCost { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int NextSkillStrId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockSkill { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillLevel { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarNeed { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_EquipPartZhuHunBaoShi> CreateFB_EquipPartZhuHunBaoShi(FlatBufferBuilder builder,
      int Id = 0,
      int ItemId = 0,
      int ItemCount = 0,
      bool IsStep = false,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int LevelUpRate = 0,
      int ClientLevelUpRate = 0,
      int FailLevel = 0,
      int MoneyType = 0,
      int MoneyCost = 0,
      int PassiveSkillId = 0,
      int NextSkillStrId = 0,
      int UnlockSkill = 0,
      int SkillLevel = 0,
      int StarNeed = 0) {
    builder.StartObject(16);
    FB_EquipPartZhuHunBaoShi.AddStarNeed(builder, StarNeed);
    FB_EquipPartZhuHunBaoShi.AddSkillLevel(builder, SkillLevel);
    FB_EquipPartZhuHunBaoShi.AddUnlockSkill(builder, UnlockSkill);
    FB_EquipPartZhuHunBaoShi.AddNextSkillStrId(builder, NextSkillStrId);
    FB_EquipPartZhuHunBaoShi.AddPassiveSkillId(builder, PassiveSkillId);
    FB_EquipPartZhuHunBaoShi.AddMoneyCost(builder, MoneyCost);
    FB_EquipPartZhuHunBaoShi.AddMoneyType(builder, MoneyType);
    FB_EquipPartZhuHunBaoShi.AddFailLevel(builder, FailLevel);
    FB_EquipPartZhuHunBaoShi.AddClientLevelUpRate(builder, ClientLevelUpRate);
    FB_EquipPartZhuHunBaoShi.AddLevelUpRate(builder, LevelUpRate);
    FB_EquipPartZhuHunBaoShi.AddAttrValueList(builder, AttrValueList);
    FB_EquipPartZhuHunBaoShi.AddAttrIdList(builder, AttrIdList);
    FB_EquipPartZhuHunBaoShi.AddItemCount(builder, ItemCount);
    FB_EquipPartZhuHunBaoShi.AddItemId(builder, ItemId);
    FB_EquipPartZhuHunBaoShi.AddId(builder, Id);
    FB_EquipPartZhuHunBaoShi.AddIsStep(builder, IsStep);
    return FB_EquipPartZhuHunBaoShi.EndFB_EquipPartZhuHunBaoShi(builder);
  }

  public static void StartFB_EquipPartZhuHunBaoShi(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(1, ItemId, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(2, ItemCount, 0); }
  public static void AddIsStep(FlatBufferBuilder builder, bool IsStep) { builder.AddBool(3, IsStep, false); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelUpRate(FlatBufferBuilder builder, int LevelUpRate) { builder.AddInt(6, LevelUpRate, 0); }
  public static void AddClientLevelUpRate(FlatBufferBuilder builder, int ClientLevelUpRate) { builder.AddInt(7, ClientLevelUpRate, 0); }
  public static void AddFailLevel(FlatBufferBuilder builder, int FailLevel) { builder.AddInt(8, FailLevel, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(9, MoneyType, 0); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(10, MoneyCost, 0); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(11, PassiveSkillId, 0); }
  public static void AddNextSkillStrId(FlatBufferBuilder builder, int NextSkillStrId) { builder.AddInt(12, NextSkillStrId, 0); }
  public static void AddUnlockSkill(FlatBufferBuilder builder, int UnlockSkill) { builder.AddInt(13, UnlockSkill, 0); }
  public static void AddSkillLevel(FlatBufferBuilder builder, int SkillLevel) { builder.AddInt(14, SkillLevel, 0); }
  public static void AddStarNeed(FlatBufferBuilder builder, int StarNeed) { builder.AddInt(15, StarNeed, 0); }
  public static Offset<FB_EquipPartZhuHunBaoShi> EndFB_EquipPartZhuHunBaoShi(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipPartZhuHunBaoShi>(o);
  }
};

public sealed class FB_EquipPartZhuHunBaoShiContainer : Table {
  public static FB_EquipPartZhuHunBaoShiContainer GetRootAsFB_EquipPartZhuHunBaoShiContainer(ByteBuffer _bb) { return GetRootAsFB_EquipPartZhuHunBaoShiContainer(_bb, new FB_EquipPartZhuHunBaoShiContainer()); }
  public static FB_EquipPartZhuHunBaoShiContainer GetRootAsFB_EquipPartZhuHunBaoShiContainer(ByteBuffer _bb, FB_EquipPartZhuHunBaoShiContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipPartZhuHunBaoShiContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipPartZhuHunBaoShiContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipPartZhuHunBaoShi GetItems(int j) { return GetItems(new FB_EquipPartZhuHunBaoShi(), j); }
  public FB_EquipPartZhuHunBaoShi GetItems(FB_EquipPartZhuHunBaoShi obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipPartZhuHunBaoShiContainer> CreateFB_EquipPartZhuHunBaoShiContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipPartZhuHunBaoShiContainer.AddItems(builder, items);
    return FB_EquipPartZhuHunBaoShiContainer.EndFB_EquipPartZhuHunBaoShiContainer(builder);
  }

  public static void StartFB_EquipPartZhuHunBaoShiContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipPartZhuHunBaoShi>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipPartZhuHunBaoShiContainer> EndFB_EquipPartZhuHunBaoShiContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipPartZhuHunBaoShiContainer>(o);
  }
  public static void FinishFB_EquipPartZhuHunBaoShiContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipPartZhuHunBaoShiContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
