// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BossGongChengReward : Table {
  public static FB_BossGongChengReward GetRootAsFB_BossGongChengReward(ByteBuffer _bb) { return GetRootAsFB_BossGongChengReward(_bb, new FB_BossGongChengReward()); }
  public static FB_BossGongChengReward GetRootAsFB_BossGongChengReward(ByteBuffer _bb, FB_BossGongChengReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BossGongChengReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int DelHpDropBoxId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BigBossDieDropBoxId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NormalBossDieDropBoxId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SmallBossDieDropBoxId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BossGongChengReward> CreateFB_BossGongChengReward(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      int DelHpDropBoxId = -1,
      int BigBossDieDropBoxId = -1,
      int NormalBossDieDropBoxId = -1,
      int SmallBossDieDropBoxId = -1) {
    builder.StartObject(7);
    FB_BossGongChengReward.AddSmallBossDieDropBoxId(builder, SmallBossDieDropBoxId);
    FB_BossGongChengReward.AddNormalBossDieDropBoxId(builder, NormalBossDieDropBoxId);
    FB_BossGongChengReward.AddBigBossDieDropBoxId(builder, BigBossDieDropBoxId);
    FB_BossGongChengReward.AddDelHpDropBoxId(builder, DelHpDropBoxId);
    FB_BossGongChengReward.AddItemCountList(builder, ItemCountList);
    FB_BossGongChengReward.AddItemIdList(builder, ItemIdList);
    FB_BossGongChengReward.AddID(builder, ID);
    return FB_BossGongChengReward.EndFB_BossGongChengReward(builder);
  }

  public static void StartFB_BossGongChengReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(1, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(2, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDelHpDropBoxId(FlatBufferBuilder builder, int DelHpDropBoxId) { builder.AddInt(3, DelHpDropBoxId, -1); }
  public static void AddBigBossDieDropBoxId(FlatBufferBuilder builder, int BigBossDieDropBoxId) { builder.AddInt(4, BigBossDieDropBoxId, -1); }
  public static void AddNormalBossDieDropBoxId(FlatBufferBuilder builder, int NormalBossDieDropBoxId) { builder.AddInt(5, NormalBossDieDropBoxId, -1); }
  public static void AddSmallBossDieDropBoxId(FlatBufferBuilder builder, int SmallBossDieDropBoxId) { builder.AddInt(6, SmallBossDieDropBoxId, -1); }
  public static Offset<FB_BossGongChengReward> EndFB_BossGongChengReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BossGongChengReward>(o);
  }
};

public sealed class FB_BossGongChengRewardContainer : Table {
  public static FB_BossGongChengRewardContainer GetRootAsFB_BossGongChengRewardContainer(ByteBuffer _bb) { return GetRootAsFB_BossGongChengRewardContainer(_bb, new FB_BossGongChengRewardContainer()); }
  public static FB_BossGongChengRewardContainer GetRootAsFB_BossGongChengRewardContainer(ByteBuffer _bb, FB_BossGongChengRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BossGongChengRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BossGongChengRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BossGongChengReward GetItems(int j) { return GetItems(new FB_BossGongChengReward(), j); }
  public FB_BossGongChengReward GetItems(FB_BossGongChengReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BossGongChengRewardContainer> CreateFB_BossGongChengRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BossGongChengRewardContainer.AddItems(builder, items);
    return FB_BossGongChengRewardContainer.EndFB_BossGongChengRewardContainer(builder);
  }

  public static void StartFB_BossGongChengRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BossGongChengReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BossGongChengRewardContainer> EndFB_BossGongChengRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BossGongChengRewardContainer>(o);
  }
  public static void FinishFB_BossGongChengRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_BossGongChengRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
