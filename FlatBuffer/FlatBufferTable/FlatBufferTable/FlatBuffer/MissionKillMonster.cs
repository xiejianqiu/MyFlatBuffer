// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionKillMonster : Table {
  public static FB_MissionKillMonster GetRootAsFB_MissionKillMonster(ByteBuffer _bb) { return GetRootAsFB_MissionKillMonster(_bb, new FB_MissionKillMonster()); }
  public static FB_MissionKillMonster GetRootAsFB_MissionKillMonster(ByteBuffer _bb, FB_MissionKillMonster obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionKillMonster __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Index { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MonsterName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetMonsterDataIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MonsterDataIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMonsterCountList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MonsterCountListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsTeamKill { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int HelpWeakReward { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HelpWeakRewardMax { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TargetFlag { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionKillMonster> CreateFB_MissionKillMonster(FlatBufferBuilder builder,
      int Index = 0,
      StringOffset MonsterName = default(StringOffset),
      VectorOffset MonsterDataIDList = default(VectorOffset),
      VectorOffset MonsterCountList = default(VectorOffset),
      bool IsTeamKill = false,
      int HelpWeakReward = -1,
      int HelpWeakRewardMax = -1,
      int TargetFlag = -1) {
    builder.StartObject(8);
    FB_MissionKillMonster.AddTargetFlag(builder, TargetFlag);
    FB_MissionKillMonster.AddHelpWeakRewardMax(builder, HelpWeakRewardMax);
    FB_MissionKillMonster.AddHelpWeakReward(builder, HelpWeakReward);
    FB_MissionKillMonster.AddMonsterCountList(builder, MonsterCountList);
    FB_MissionKillMonster.AddMonsterDataIDList(builder, MonsterDataIDList);
    FB_MissionKillMonster.AddMonsterName(builder, MonsterName);
    FB_MissionKillMonster.AddIndex(builder, Index);
    FB_MissionKillMonster.AddIsTeamKill(builder, IsTeamKill);
    return FB_MissionKillMonster.EndFB_MissionKillMonster(builder);
  }

  public static void StartFB_MissionKillMonster(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddIndex(FlatBufferBuilder builder, int Index) { builder.AddInt(0, Index, 0); }
  public static void AddMonsterName(FlatBufferBuilder builder, StringOffset MonsterNameOffset) { builder.AddOffset(1, MonsterNameOffset.Value, 0); }
  public static void AddMonsterDataIDList(FlatBufferBuilder builder, VectorOffset MonsterDataIDListOffset) { builder.AddOffset(2, MonsterDataIDListOffset.Value, 0); }
  public static VectorOffset CreateMonsterDataIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMonsterDataIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMonsterCountList(FlatBufferBuilder builder, VectorOffset MonsterCountListOffset) { builder.AddOffset(3, MonsterCountListOffset.Value, 0); }
  public static VectorOffset CreateMonsterCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMonsterCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsTeamKill(FlatBufferBuilder builder, bool IsTeamKill) { builder.AddBool(4, IsTeamKill, false); }
  public static void AddHelpWeakReward(FlatBufferBuilder builder, int HelpWeakReward) { builder.AddInt(5, HelpWeakReward, -1); }
  public static void AddHelpWeakRewardMax(FlatBufferBuilder builder, int HelpWeakRewardMax) { builder.AddInt(6, HelpWeakRewardMax, -1); }
  public static void AddTargetFlag(FlatBufferBuilder builder, int TargetFlag) { builder.AddInt(7, TargetFlag, -1); }
  public static Offset<FB_MissionKillMonster> EndFB_MissionKillMonster(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionKillMonster>(o);
  }
};

public sealed class FB_MissionKillMonsterContainer : Table {
  public static FB_MissionKillMonsterContainer GetRootAsFB_MissionKillMonsterContainer(ByteBuffer _bb) { return GetRootAsFB_MissionKillMonsterContainer(_bb, new FB_MissionKillMonsterContainer()); }
  public static FB_MissionKillMonsterContainer GetRootAsFB_MissionKillMonsterContainer(ByteBuffer _bb, FB_MissionKillMonsterContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionKillMonsterContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionKillMonsterContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionKillMonster GetItems(int j) { return GetItems(new FB_MissionKillMonster(), j); }
  public FB_MissionKillMonster GetItems(FB_MissionKillMonster obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionKillMonsterContainer> CreateFB_MissionKillMonsterContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionKillMonsterContainer.AddItems(builder, items);
    return FB_MissionKillMonsterContainer.EndFB_MissionKillMonsterContainer(builder);
  }

  public static void StartFB_MissionKillMonsterContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionKillMonster>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionKillMonsterContainer> EndFB_MissionKillMonsterContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionKillMonsterContainer>(o);
  }
  public static void FinishFB_MissionKillMonsterContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionKillMonsterContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
