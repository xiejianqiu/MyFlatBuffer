// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenWangZhanJiaCsBase : Table {
  public static FB_ShenWangZhanJiaCsBase GetRootAsFB_ShenWangZhanJiaCsBase(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCsBase(_bb, new FB_ShenWangZhanJiaCsBase()); }
  public static FB_ShenWangZhanJiaCsBase GetRootAsFB_ShenWangZhanJiaCsBase(ByteBuffer _bb, FB_ShenWangZhanJiaCsBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenWangZhanJiaCsBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Totaljifen { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MopUpLockId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TotalStage { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlushTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BossType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Probability { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShopId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long CombatPowerNum { get { int o = __offset(22); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int ZhanJiaAttack { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ZhanJiaDefence { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShenWangZhanJiaCsBase> CreateFB_ShenWangZhanJiaCsBase(FlatBufferBuilder builder,
      int ID = 0,
      int Totaljifen = -1,
      int MopUpLockId = -1,
      int TotalStage = -1,
      int FlushTime = -1,
      int CopySceneId = -1,
      int BossType = -1,
      int Probability = -1,
      int ShopId = -1,
      long CombatPowerNum = -1,
      int ZhanJiaAttack = -1,
      int ZhanJiaDefence = -1) {
    builder.StartObject(12);
    FB_ShenWangZhanJiaCsBase.AddCombatPowerNum(builder, CombatPowerNum);
    FB_ShenWangZhanJiaCsBase.AddZhanJiaDefence(builder, ZhanJiaDefence);
    FB_ShenWangZhanJiaCsBase.AddZhanJiaAttack(builder, ZhanJiaAttack);
    FB_ShenWangZhanJiaCsBase.AddShopId(builder, ShopId);
    FB_ShenWangZhanJiaCsBase.AddProbability(builder, Probability);
    FB_ShenWangZhanJiaCsBase.AddBossType(builder, BossType);
    FB_ShenWangZhanJiaCsBase.AddCopySceneId(builder, CopySceneId);
    FB_ShenWangZhanJiaCsBase.AddFlushTime(builder, FlushTime);
    FB_ShenWangZhanJiaCsBase.AddTotalStage(builder, TotalStage);
    FB_ShenWangZhanJiaCsBase.AddMopUpLockId(builder, MopUpLockId);
    FB_ShenWangZhanJiaCsBase.AddTotaljifen(builder, Totaljifen);
    FB_ShenWangZhanJiaCsBase.AddID(builder, ID);
    return FB_ShenWangZhanJiaCsBase.EndFB_ShenWangZhanJiaCsBase(builder);
  }

  public static void StartFB_ShenWangZhanJiaCsBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTotaljifen(FlatBufferBuilder builder, int Totaljifen) { builder.AddInt(1, Totaljifen, -1); }
  public static void AddMopUpLockId(FlatBufferBuilder builder, int MopUpLockId) { builder.AddInt(2, MopUpLockId, -1); }
  public static void AddTotalStage(FlatBufferBuilder builder, int TotalStage) { builder.AddInt(3, TotalStage, -1); }
  public static void AddFlushTime(FlatBufferBuilder builder, int FlushTime) { builder.AddInt(4, FlushTime, -1); }
  public static void AddCopySceneId(FlatBufferBuilder builder, int CopySceneId) { builder.AddInt(5, CopySceneId, -1); }
  public static void AddBossType(FlatBufferBuilder builder, int BossType) { builder.AddInt(6, BossType, -1); }
  public static void AddProbability(FlatBufferBuilder builder, int Probability) { builder.AddInt(7, Probability, -1); }
  public static void AddShopId(FlatBufferBuilder builder, int ShopId) { builder.AddInt(8, ShopId, -1); }
  public static void AddCombatPowerNum(FlatBufferBuilder builder, long CombatPowerNum) { builder.AddLong(9, CombatPowerNum, -1); }
  public static void AddZhanJiaAttack(FlatBufferBuilder builder, int ZhanJiaAttack) { builder.AddInt(10, ZhanJiaAttack, -1); }
  public static void AddZhanJiaDefence(FlatBufferBuilder builder, int ZhanJiaDefence) { builder.AddInt(11, ZhanJiaDefence, -1); }
  public static Offset<FB_ShenWangZhanJiaCsBase> EndFB_ShenWangZhanJiaCsBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCsBase>(o);
  }
};

public sealed class FB_ShenWangZhanJiaCsBaseContainer : Table {
  public static FB_ShenWangZhanJiaCsBaseContainer GetRootAsFB_ShenWangZhanJiaCsBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShenWangZhanJiaCsBaseContainer(_bb, new FB_ShenWangZhanJiaCsBaseContainer()); }
  public static FB_ShenWangZhanJiaCsBaseContainer GetRootAsFB_ShenWangZhanJiaCsBaseContainer(ByteBuffer _bb, FB_ShenWangZhanJiaCsBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenWangZhanJiaCsBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenWangZhanJiaCsBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenWangZhanJiaCsBase GetItems(int j) { return GetItems(new FB_ShenWangZhanJiaCsBase(), j); }
  public FB_ShenWangZhanJiaCsBase GetItems(FB_ShenWangZhanJiaCsBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenWangZhanJiaCsBaseContainer> CreateFB_ShenWangZhanJiaCsBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenWangZhanJiaCsBaseContainer.AddItems(builder, items);
    return FB_ShenWangZhanJiaCsBaseContainer.EndFB_ShenWangZhanJiaCsBaseContainer(builder);
  }

  public static void StartFB_ShenWangZhanJiaCsBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCsBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenWangZhanJiaCsBaseContainer> EndFB_ShenWangZhanJiaCsBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenWangZhanJiaCsBaseContainer>(o);
  }
  public static void FinishFB_ShenWangZhanJiaCsBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenWangZhanJiaCsBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
