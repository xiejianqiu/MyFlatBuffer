// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JuLingCSbase : Table {
  public static FB_JuLingCSbase GetRootAsFB_JuLingCSbase(ByteBuffer _bb) { return GetRootAsFB_JuLingCSbase(_bb, new FB_JuLingCSbase()); }
  public static FB_JuLingCSbase GetRootAsFB_JuLingCSbase(ByteBuffer _bb, FB_JuLingCSbase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JuLingCSbase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string CSName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public long TotalExp { get { int o = __offset(8); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public int Totaljifen { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MopUpLockId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BossType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TotalStage { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlushTime { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TowerName { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FuLingId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string LimitDesc { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TimeLimit { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string RankDesc { get { int o = __offset(30); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UIModelId { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_JuLingCSbase> CreateFB_JuLingCSbase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset CSName = default(StringOffset),
      long TotalExp = 0,
      int Totaljifen = -1,
      int MopUpLockId = -1,
      int BossType = -1,
      int TotalStage = -1,
      int FlushTime = -1,
      int CopySceneId = -1,
      StringOffset TowerName = default(StringOffset),
      int FuLingId = -1,
      StringOffset LimitDesc = default(StringOffset),
      int TimeLimit = -1,
      StringOffset RankDesc = default(StringOffset),
      int UIModelId = -1) {
    builder.StartObject(15);
    FB_JuLingCSbase.AddTotalExp(builder, TotalExp);
    FB_JuLingCSbase.AddUIModelId(builder, UIModelId);
    FB_JuLingCSbase.AddRankDesc(builder, RankDesc);
    FB_JuLingCSbase.AddTimeLimit(builder, TimeLimit);
    FB_JuLingCSbase.AddLimitDesc(builder, LimitDesc);
    FB_JuLingCSbase.AddFuLingId(builder, FuLingId);
    FB_JuLingCSbase.AddTowerName(builder, TowerName);
    FB_JuLingCSbase.AddCopySceneId(builder, CopySceneId);
    FB_JuLingCSbase.AddFlushTime(builder, FlushTime);
    FB_JuLingCSbase.AddTotalStage(builder, TotalStage);
    FB_JuLingCSbase.AddBossType(builder, BossType);
    FB_JuLingCSbase.AddMopUpLockId(builder, MopUpLockId);
    FB_JuLingCSbase.AddTotaljifen(builder, Totaljifen);
    FB_JuLingCSbase.AddCSName(builder, CSName);
    FB_JuLingCSbase.AddID(builder, ID);
    return FB_JuLingCSbase.EndFB_JuLingCSbase(builder);
  }

  public static void StartFB_JuLingCSbase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCSName(FlatBufferBuilder builder, StringOffset CSNameOffset) { builder.AddOffset(1, CSNameOffset.Value, 0); }
  public static void AddTotalExp(FlatBufferBuilder builder, long TotalExp) { builder.AddLong(2, TotalExp, 0); }
  public static void AddTotaljifen(FlatBufferBuilder builder, int Totaljifen) { builder.AddInt(3, Totaljifen, -1); }
  public static void AddMopUpLockId(FlatBufferBuilder builder, int MopUpLockId) { builder.AddInt(4, MopUpLockId, -1); }
  public static void AddBossType(FlatBufferBuilder builder, int BossType) { builder.AddInt(5, BossType, -1); }
  public static void AddTotalStage(FlatBufferBuilder builder, int TotalStage) { builder.AddInt(6, TotalStage, -1); }
  public static void AddFlushTime(FlatBufferBuilder builder, int FlushTime) { builder.AddInt(7, FlushTime, -1); }
  public static void AddCopySceneId(FlatBufferBuilder builder, int CopySceneId) { builder.AddInt(8, CopySceneId, -1); }
  public static void AddTowerName(FlatBufferBuilder builder, StringOffset TowerNameOffset) { builder.AddOffset(9, TowerNameOffset.Value, 0); }
  public static void AddFuLingId(FlatBufferBuilder builder, int FuLingId) { builder.AddInt(10, FuLingId, -1); }
  public static void AddLimitDesc(FlatBufferBuilder builder, StringOffset LimitDescOffset) { builder.AddOffset(11, LimitDescOffset.Value, 0); }
  public static void AddTimeLimit(FlatBufferBuilder builder, int TimeLimit) { builder.AddInt(12, TimeLimit, -1); }
  public static void AddRankDesc(FlatBufferBuilder builder, StringOffset RankDescOffset) { builder.AddOffset(13, RankDescOffset.Value, 0); }
  public static void AddUIModelId(FlatBufferBuilder builder, int UIModelId) { builder.AddInt(14, UIModelId, -1); }
  public static Offset<FB_JuLingCSbase> EndFB_JuLingCSbase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuLingCSbase>(o);
  }
};

public sealed class FB_JuLingCSbaseContainer : Table {
  public static FB_JuLingCSbaseContainer GetRootAsFB_JuLingCSbaseContainer(ByteBuffer _bb) { return GetRootAsFB_JuLingCSbaseContainer(_bb, new FB_JuLingCSbaseContainer()); }
  public static FB_JuLingCSbaseContainer GetRootAsFB_JuLingCSbaseContainer(ByteBuffer _bb, FB_JuLingCSbaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JuLingCSbaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JuLingCSbaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JuLingCSbase GetItems(int j) { return GetItems(new FB_JuLingCSbase(), j); }
  public FB_JuLingCSbase GetItems(FB_JuLingCSbase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuLingCSbaseContainer> CreateFB_JuLingCSbaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JuLingCSbaseContainer.AddItems(builder, items);
    return FB_JuLingCSbaseContainer.EndFB_JuLingCSbaseContainer(builder);
  }

  public static void StartFB_JuLingCSbaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JuLingCSbase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuLingCSbaseContainer> EndFB_JuLingCSbaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuLingCSbaseContainer>(o);
  }
  public static void FinishFB_JuLingCSbaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_JuLingCSbaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
