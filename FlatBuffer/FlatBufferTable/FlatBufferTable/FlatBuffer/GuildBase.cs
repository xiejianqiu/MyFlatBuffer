// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildBase : Table {
  public static FB_GuildBase GetRootAsFB_GuildBase(ByteBuffer _bb) { return GetRootAsFB_GuildBase(_bb, new FB_GuildBase()); }
  public static FB_GuildBase GetRootAsFB_GuildBase(ByteBuffer _bb, FB_GuildBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GuildMoneyMax { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UpKeepMoney { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighUpKeepMoney { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighUpKeepLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Dividend { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRoleNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RoleNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int RoleMax { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TeamMax { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostType { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostMoney { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedMoney { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PaybackMoney { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RobberAwardMoney { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RobberAwardDividend { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RobberPunishment { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildBattleWinCapital { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildBattleLoseCapital { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildDefenceWinAward { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildDefenceLosePunishment { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildBossCapital { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildBossContribution { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildBase> CreateFB_GuildBase(FlatBufferBuilder builder,
      int Id = 0,
      int GuildMoneyMax = -1,
      int UpKeepMoney = -1,
      int HighUpKeepMoney = -1,
      int HighUpKeepLimit = -1,
      int Dividend = -1,
      VectorOffset RoleNumList = default(VectorOffset),
      int RoleMax = -1,
      int TeamMax = -1,
      int CostType = -1,
      int CostMoney = -1,
      int NeedMoney = -1,
      int PaybackMoney = -1,
      int RobberAwardMoney = -1,
      int RobberAwardDividend = -1,
      int RobberPunishment = -1,
      int GuildBattleWinCapital = -1,
      int GuildBattleLoseCapital = -1,
      int GuildDefenceWinAward = -1,
      int GuildDefenceLosePunishment = -1,
      int GuildBossCapital = -1,
      int GuildBossContribution = -1) {
    builder.StartObject(22);
    FB_GuildBase.AddGuildBossContribution(builder, GuildBossContribution);
    FB_GuildBase.AddGuildBossCapital(builder, GuildBossCapital);
    FB_GuildBase.AddGuildDefenceLosePunishment(builder, GuildDefenceLosePunishment);
    FB_GuildBase.AddGuildDefenceWinAward(builder, GuildDefenceWinAward);
    FB_GuildBase.AddGuildBattleLoseCapital(builder, GuildBattleLoseCapital);
    FB_GuildBase.AddGuildBattleWinCapital(builder, GuildBattleWinCapital);
    FB_GuildBase.AddRobberPunishment(builder, RobberPunishment);
    FB_GuildBase.AddRobberAwardDividend(builder, RobberAwardDividend);
    FB_GuildBase.AddRobberAwardMoney(builder, RobberAwardMoney);
    FB_GuildBase.AddPaybackMoney(builder, PaybackMoney);
    FB_GuildBase.AddNeedMoney(builder, NeedMoney);
    FB_GuildBase.AddCostMoney(builder, CostMoney);
    FB_GuildBase.AddCostType(builder, CostType);
    FB_GuildBase.AddTeamMax(builder, TeamMax);
    FB_GuildBase.AddRoleMax(builder, RoleMax);
    FB_GuildBase.AddRoleNumList(builder, RoleNumList);
    FB_GuildBase.AddDividend(builder, Dividend);
    FB_GuildBase.AddHighUpKeepLimit(builder, HighUpKeepLimit);
    FB_GuildBase.AddHighUpKeepMoney(builder, HighUpKeepMoney);
    FB_GuildBase.AddUpKeepMoney(builder, UpKeepMoney);
    FB_GuildBase.AddGuildMoneyMax(builder, GuildMoneyMax);
    FB_GuildBase.AddId(builder, Id);
    return FB_GuildBase.EndFB_GuildBase(builder);
  }

  public static void StartFB_GuildBase(FlatBufferBuilder builder) { builder.StartObject(22); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGuildMoneyMax(FlatBufferBuilder builder, int GuildMoneyMax) { builder.AddInt(1, GuildMoneyMax, -1); }
  public static void AddUpKeepMoney(FlatBufferBuilder builder, int UpKeepMoney) { builder.AddInt(2, UpKeepMoney, -1); }
  public static void AddHighUpKeepMoney(FlatBufferBuilder builder, int HighUpKeepMoney) { builder.AddInt(3, HighUpKeepMoney, -1); }
  public static void AddHighUpKeepLimit(FlatBufferBuilder builder, int HighUpKeepLimit) { builder.AddInt(4, HighUpKeepLimit, -1); }
  public static void AddDividend(FlatBufferBuilder builder, int Dividend) { builder.AddInt(5, Dividend, -1); }
  public static void AddRoleNumList(FlatBufferBuilder builder, VectorOffset RoleNumListOffset) { builder.AddOffset(6, RoleNumListOffset.Value, 0); }
  public static VectorOffset CreateRoleNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRoleNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRoleMax(FlatBufferBuilder builder, int RoleMax) { builder.AddInt(7, RoleMax, -1); }
  public static void AddTeamMax(FlatBufferBuilder builder, int TeamMax) { builder.AddInt(8, TeamMax, -1); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(9, CostType, -1); }
  public static void AddCostMoney(FlatBufferBuilder builder, int CostMoney) { builder.AddInt(10, CostMoney, -1); }
  public static void AddNeedMoney(FlatBufferBuilder builder, int NeedMoney) { builder.AddInt(11, NeedMoney, -1); }
  public static void AddPaybackMoney(FlatBufferBuilder builder, int PaybackMoney) { builder.AddInt(12, PaybackMoney, -1); }
  public static void AddRobberAwardMoney(FlatBufferBuilder builder, int RobberAwardMoney) { builder.AddInt(13, RobberAwardMoney, -1); }
  public static void AddRobberAwardDividend(FlatBufferBuilder builder, int RobberAwardDividend) { builder.AddInt(14, RobberAwardDividend, -1); }
  public static void AddRobberPunishment(FlatBufferBuilder builder, int RobberPunishment) { builder.AddInt(15, RobberPunishment, -1); }
  public static void AddGuildBattleWinCapital(FlatBufferBuilder builder, int GuildBattleWinCapital) { builder.AddInt(16, GuildBattleWinCapital, -1); }
  public static void AddGuildBattleLoseCapital(FlatBufferBuilder builder, int GuildBattleLoseCapital) { builder.AddInt(17, GuildBattleLoseCapital, -1); }
  public static void AddGuildDefenceWinAward(FlatBufferBuilder builder, int GuildDefenceWinAward) { builder.AddInt(18, GuildDefenceWinAward, -1); }
  public static void AddGuildDefenceLosePunishment(FlatBufferBuilder builder, int GuildDefenceLosePunishment) { builder.AddInt(19, GuildDefenceLosePunishment, -1); }
  public static void AddGuildBossCapital(FlatBufferBuilder builder, int GuildBossCapital) { builder.AddInt(20, GuildBossCapital, -1); }
  public static void AddGuildBossContribution(FlatBufferBuilder builder, int GuildBossContribution) { builder.AddInt(21, GuildBossContribution, -1); }
  public static Offset<FB_GuildBase> EndFB_GuildBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildBase>(o);
  }
};

public sealed class FB_GuildBaseContainer : Table {
  public static FB_GuildBaseContainer GetRootAsFB_GuildBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GuildBaseContainer(_bb, new FB_GuildBaseContainer()); }
  public static FB_GuildBaseContainer GetRootAsFB_GuildBaseContainer(ByteBuffer _bb, FB_GuildBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildBase GetItems(int j) { return GetItems(new FB_GuildBase(), j); }
  public FB_GuildBase GetItems(FB_GuildBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildBaseContainer> CreateFB_GuildBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildBaseContainer.AddItems(builder, items);
    return FB_GuildBaseContainer.EndFB_GuildBaseContainer(builder);
  }

  public static void StartFB_GuildBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildBaseContainer> EndFB_GuildBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildBaseContainer>(o);
  }
  public static void FinishFB_GuildBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
