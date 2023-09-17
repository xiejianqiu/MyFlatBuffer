// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildFormationLevel : Table {
  public static FB_GuildFormationLevel GetRootAsFB_GuildFormationLevel(ByteBuffer _bb) { return GetRootAsFB_GuildFormationLevel(_bb, new FB_GuildFormationLevel()); }
  public static FB_GuildFormationLevel GetRootAsFB_GuildFormationLevel(ByteBuffer _bb, FB_GuildFormationLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildFormationLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostMoney { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UpgradeTime { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UpgradeExp { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelExp { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PersonLevel { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildFormationLevel> CreateFB_GuildFormationLevel(FlatBufferBuilder builder,
      int Id = 0,
      int CostMoney = -1,
      int UpgradeTime = -1,
      int UpgradeExp = -1,
      int LevelExp = -1,
      int PersonLevel = -1) {
    builder.StartObject(6);
    FB_GuildFormationLevel.AddPersonLevel(builder, PersonLevel);
    FB_GuildFormationLevel.AddLevelExp(builder, LevelExp);
    FB_GuildFormationLevel.AddUpgradeExp(builder, UpgradeExp);
    FB_GuildFormationLevel.AddUpgradeTime(builder, UpgradeTime);
    FB_GuildFormationLevel.AddCostMoney(builder, CostMoney);
    FB_GuildFormationLevel.AddId(builder, Id);
    return FB_GuildFormationLevel.EndFB_GuildFormationLevel(builder);
  }

  public static void StartFB_GuildFormationLevel(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostMoney(FlatBufferBuilder builder, int CostMoney) { builder.AddInt(1, CostMoney, -1); }
  public static void AddUpgradeTime(FlatBufferBuilder builder, int UpgradeTime) { builder.AddInt(2, UpgradeTime, -1); }
  public static void AddUpgradeExp(FlatBufferBuilder builder, int UpgradeExp) { builder.AddInt(3, UpgradeExp, -1); }
  public static void AddLevelExp(FlatBufferBuilder builder, int LevelExp) { builder.AddInt(4, LevelExp, -1); }
  public static void AddPersonLevel(FlatBufferBuilder builder, int PersonLevel) { builder.AddInt(5, PersonLevel, -1); }
  public static Offset<FB_GuildFormationLevel> EndFB_GuildFormationLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationLevel>(o);
  }
};

public sealed class FB_GuildFormationLevelContainer : Table {
  public static FB_GuildFormationLevelContainer GetRootAsFB_GuildFormationLevelContainer(ByteBuffer _bb) { return GetRootAsFB_GuildFormationLevelContainer(_bb, new FB_GuildFormationLevelContainer()); }
  public static FB_GuildFormationLevelContainer GetRootAsFB_GuildFormationLevelContainer(ByteBuffer _bb, FB_GuildFormationLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildFormationLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildFormationLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildFormationLevel GetItems(int j) { return GetItems(new FB_GuildFormationLevel(), j); }
  public FB_GuildFormationLevel GetItems(FB_GuildFormationLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildFormationLevelContainer> CreateFB_GuildFormationLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildFormationLevelContainer.AddItems(builder, items);
    return FB_GuildFormationLevelContainer.EndFB_GuildFormationLevelContainer(builder);
  }

  public static void StartFB_GuildFormationLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildFormationLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildFormationLevelContainer> EndFB_GuildFormationLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationLevelContainer>(o);
  }
  public static void FinishFB_GuildFormationLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildFormationLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
