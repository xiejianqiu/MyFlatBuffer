// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYuPingFen : Table {
  public static FB_XingYuPingFen GetRootAsFB_XingYuPingFen(ByteBuffer _bb) { return GetRootAsFB_XingYuPingFen(_bb, new FB_XingYuPingFen()); }
  public static FB_XingYuPingFen GetRootAsFB_XingYuPingFen(ByteBuffer _bb, FB_XingYuPingFen obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYuPingFen __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PingJi { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long MinDamage { get { int o = __offset(10); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public long MaxDamage { get { int o = __offset(12); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int Score { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardItemIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRandomItemIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RandomItemIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRandomItemNumList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RandomItemNumListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuPingFen> CreateFB_XingYuPingFen(FlatBufferBuilder builder,
      int Id = 0,
      int PingJi = -1,
      int SceneID = -1,
      long MinDamage = -1,
      long MaxDamage = -1,
      int Score = -1,
      VectorOffset RewardItemIdList = default(VectorOffset),
      VectorOffset RewardItemNumList = default(VectorOffset),
      VectorOffset RandomItemIdList = default(VectorOffset),
      VectorOffset RandomItemNumList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_XingYuPingFen.AddMaxDamage(builder, MaxDamage);
    FB_XingYuPingFen.AddMinDamage(builder, MinDamage);
    FB_XingYuPingFen.AddRandomItemNumList(builder, RandomItemNumList);
    FB_XingYuPingFen.AddRandomItemIdList(builder, RandomItemIdList);
    FB_XingYuPingFen.AddRewardItemNumList(builder, RewardItemNumList);
    FB_XingYuPingFen.AddRewardItemIdList(builder, RewardItemIdList);
    FB_XingYuPingFen.AddScore(builder, Score);
    FB_XingYuPingFen.AddSceneID(builder, SceneID);
    FB_XingYuPingFen.AddPingJi(builder, PingJi);
    FB_XingYuPingFen.AddId(builder, Id);
    return FB_XingYuPingFen.EndFB_XingYuPingFen(builder);
  }

  public static void StartFB_XingYuPingFen(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPingJi(FlatBufferBuilder builder, int PingJi) { builder.AddInt(1, PingJi, -1); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, -1); }
  public static void AddMinDamage(FlatBufferBuilder builder, long MinDamage) { builder.AddLong(3, MinDamage, -1); }
  public static void AddMaxDamage(FlatBufferBuilder builder, long MaxDamage) { builder.AddLong(4, MaxDamage, -1); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(5, Score, -1); }
  public static void AddRewardItemIdList(FlatBufferBuilder builder, VectorOffset RewardItemIdListOffset) { builder.AddOffset(6, RewardItemIdListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemNumList(FlatBufferBuilder builder, VectorOffset RewardItemNumListOffset) { builder.AddOffset(7, RewardItemNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRandomItemIdList(FlatBufferBuilder builder, VectorOffset RandomItemIdListOffset) { builder.AddOffset(8, RandomItemIdListOffset.Value, 0); }
  public static VectorOffset CreateRandomItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRandomItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRandomItemNumList(FlatBufferBuilder builder, VectorOffset RandomItemNumListOffset) { builder.AddOffset(9, RandomItemNumListOffset.Value, 0); }
  public static VectorOffset CreateRandomItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRandomItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuPingFen> EndFB_XingYuPingFen(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuPingFen>(o);
  }
};

public sealed class FB_XingYuPingFenContainer : Table {
  public static FB_XingYuPingFenContainer GetRootAsFB_XingYuPingFenContainer(ByteBuffer _bb) { return GetRootAsFB_XingYuPingFenContainer(_bb, new FB_XingYuPingFenContainer()); }
  public static FB_XingYuPingFenContainer GetRootAsFB_XingYuPingFenContainer(ByteBuffer _bb, FB_XingYuPingFenContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYuPingFenContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYuPingFenContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYuPingFen GetItems(int j) { return GetItems(new FB_XingYuPingFen(), j); }
  public FB_XingYuPingFen GetItems(FB_XingYuPingFen obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuPingFenContainer> CreateFB_XingYuPingFenContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYuPingFenContainer.AddItems(builder, items);
    return FB_XingYuPingFenContainer.EndFB_XingYuPingFenContainer(builder);
  }

  public static void StartFB_XingYuPingFenContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYuPingFen>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuPingFenContainer> EndFB_XingYuPingFenContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuPingFenContainer>(o);
  }
  public static void FinishFB_XingYuPingFenContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYuPingFenContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
