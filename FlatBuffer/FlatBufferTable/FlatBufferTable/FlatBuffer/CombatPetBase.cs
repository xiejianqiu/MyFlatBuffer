// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CombatPetBase : Table {
  public static FB_CombatPetBase GetRootAsFB_CombatPetBase(ByteBuffer _bb) { return GetRootAsFB_CombatPetBase(_bb, new FB_CombatPetBase()); }
  public static FB_CombatPetBase GetRootAsFB_CombatPetBase(ByteBuffer _bb, FB_CombatPetBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CombatPetBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Totaljifen { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MopUpLockId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TotalStage { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlushTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBox { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetLowItemIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowItemIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLowItemCountList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowItemCountListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHighItemIDList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighItemIDListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHighItemCountList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighItemCountListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int BossType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLvl { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CombatPetBase> CreateFB_CombatPetBase(FlatBufferBuilder builder,
      int ID = 0,
      int Totaljifen = -1,
      int MopUpLockId = -1,
      int TotalStage = -1,
      int FlushTime = -1,
      int CopySceneId = -1,
      int DropBox = -1,
      VectorOffset LowItemIDList = default(VectorOffset),
      VectorOffset LowItemCountList = default(VectorOffset),
      VectorOffset HighItemIDList = default(VectorOffset),
      VectorOffset HighItemCountList = default(VectorOffset),
      int BossType = -1,
      int MinLvl = -1) {
    builder.StartObject(13);
    FB_CombatPetBase.AddMinLvl(builder, MinLvl);
    FB_CombatPetBase.AddBossType(builder, BossType);
    FB_CombatPetBase.AddHighItemCountList(builder, HighItemCountList);
    FB_CombatPetBase.AddHighItemIDList(builder, HighItemIDList);
    FB_CombatPetBase.AddLowItemCountList(builder, LowItemCountList);
    FB_CombatPetBase.AddLowItemIDList(builder, LowItemIDList);
    FB_CombatPetBase.AddDropBox(builder, DropBox);
    FB_CombatPetBase.AddCopySceneId(builder, CopySceneId);
    FB_CombatPetBase.AddFlushTime(builder, FlushTime);
    FB_CombatPetBase.AddTotalStage(builder, TotalStage);
    FB_CombatPetBase.AddMopUpLockId(builder, MopUpLockId);
    FB_CombatPetBase.AddTotaljifen(builder, Totaljifen);
    FB_CombatPetBase.AddID(builder, ID);
    return FB_CombatPetBase.EndFB_CombatPetBase(builder);
  }

  public static void StartFB_CombatPetBase(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTotaljifen(FlatBufferBuilder builder, int Totaljifen) { builder.AddInt(1, Totaljifen, -1); }
  public static void AddMopUpLockId(FlatBufferBuilder builder, int MopUpLockId) { builder.AddInt(2, MopUpLockId, -1); }
  public static void AddTotalStage(FlatBufferBuilder builder, int TotalStage) { builder.AddInt(3, TotalStage, -1); }
  public static void AddFlushTime(FlatBufferBuilder builder, int FlushTime) { builder.AddInt(4, FlushTime, -1); }
  public static void AddCopySceneId(FlatBufferBuilder builder, int CopySceneId) { builder.AddInt(5, CopySceneId, -1); }
  public static void AddDropBox(FlatBufferBuilder builder, int DropBox) { builder.AddInt(6, DropBox, -1); }
  public static void AddLowItemIDList(FlatBufferBuilder builder, VectorOffset LowItemIDListOffset) { builder.AddOffset(7, LowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateLowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLowItemCountList(FlatBufferBuilder builder, VectorOffset LowItemCountListOffset) { builder.AddOffset(8, LowItemCountListOffset.Value, 0); }
  public static VectorOffset CreateLowItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighItemIDList(FlatBufferBuilder builder, VectorOffset HighItemIDListOffset) { builder.AddOffset(9, HighItemIDListOffset.Value, 0); }
  public static VectorOffset CreateHighItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighItemCountList(FlatBufferBuilder builder, VectorOffset HighItemCountListOffset) { builder.AddOffset(10, HighItemCountListOffset.Value, 0); }
  public static VectorOffset CreateHighItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBossType(FlatBufferBuilder builder, int BossType) { builder.AddInt(11, BossType, -1); }
  public static void AddMinLvl(FlatBufferBuilder builder, int MinLvl) { builder.AddInt(12, MinLvl, -1); }
  public static Offset<FB_CombatPetBase> EndFB_CombatPetBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CombatPetBase>(o);
  }
};

public sealed class FB_CombatPetBaseContainer : Table {
  public static FB_CombatPetBaseContainer GetRootAsFB_CombatPetBaseContainer(ByteBuffer _bb) { return GetRootAsFB_CombatPetBaseContainer(_bb, new FB_CombatPetBaseContainer()); }
  public static FB_CombatPetBaseContainer GetRootAsFB_CombatPetBaseContainer(ByteBuffer _bb, FB_CombatPetBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CombatPetBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CombatPetBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CombatPetBase GetItems(int j) { return GetItems(new FB_CombatPetBase(), j); }
  public FB_CombatPetBase GetItems(FB_CombatPetBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CombatPetBaseContainer> CreateFB_CombatPetBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CombatPetBaseContainer.AddItems(builder, items);
    return FB_CombatPetBaseContainer.EndFB_CombatPetBaseContainer(builder);
  }

  public static void StartFB_CombatPetBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CombatPetBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CombatPetBaseContainer> EndFB_CombatPetBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CombatPetBaseContainer>(o);
  }
  public static void FinishFB_CombatPetBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_CombatPetBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
