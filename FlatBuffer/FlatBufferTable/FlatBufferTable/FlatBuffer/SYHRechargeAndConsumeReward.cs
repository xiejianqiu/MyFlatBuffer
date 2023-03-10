// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHRechargeAndConsumeReward : Table {
  public static FB_SYHRechargeAndConsumeReward GetRootAsFB_SYHRechargeAndConsumeReward(ByteBuffer _bb) { return GetRootAsFB_SYHRechargeAndConsumeReward(_bb, new FB_SYHRechargeAndConsumeReward()); }
  public static FB_SYHRechargeAndConsumeReward GetRootAsFB_SYHRechargeAndConsumeReward(ByteBuffer _bb, FB_SYHRechargeAndConsumeReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHRechargeAndConsumeReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AwardIndex { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Param { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BaseId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Count { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetGoldList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GoldListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int NameStrId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DescStrId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldStrId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHRechargeAndConsumeReward> CreateFB_SYHRechargeAndConsumeReward(FlatBufferBuilder builder,
      int ID = 0,
      int AwardIndex = 0,
      int LevelLimit = 0,
      int Param = -1,
      int BaseId = -1,
      int Count = -1,
      VectorOffset GoldList = default(VectorOffset),
      int NameStrId = -1,
      int DescStrId = -1,
      int GoldStrId = -1) {
    builder.StartObject(10);
    FB_SYHRechargeAndConsumeReward.AddGoldStrId(builder, GoldStrId);
    FB_SYHRechargeAndConsumeReward.AddDescStrId(builder, DescStrId);
    FB_SYHRechargeAndConsumeReward.AddNameStrId(builder, NameStrId);
    FB_SYHRechargeAndConsumeReward.AddGoldList(builder, GoldList);
    FB_SYHRechargeAndConsumeReward.AddCount(builder, Count);
    FB_SYHRechargeAndConsumeReward.AddBaseId(builder, BaseId);
    FB_SYHRechargeAndConsumeReward.AddParam(builder, Param);
    FB_SYHRechargeAndConsumeReward.AddLevelLimit(builder, LevelLimit);
    FB_SYHRechargeAndConsumeReward.AddAwardIndex(builder, AwardIndex);
    FB_SYHRechargeAndConsumeReward.AddID(builder, ID);
    return FB_SYHRechargeAndConsumeReward.EndFB_SYHRechargeAndConsumeReward(builder);
  }

  public static void StartFB_SYHRechargeAndConsumeReward(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAwardIndex(FlatBufferBuilder builder, int AwardIndex) { builder.AddInt(1, AwardIndex, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(2, LevelLimit, 0); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(3, Param, -1); }
  public static void AddBaseId(FlatBufferBuilder builder, int BaseId) { builder.AddInt(4, BaseId, -1); }
  public static void AddCount(FlatBufferBuilder builder, int Count) { builder.AddInt(5, Count, -1); }
  public static void AddGoldList(FlatBufferBuilder builder, VectorOffset GoldListOffset) { builder.AddOffset(6, GoldListOffset.Value, 0); }
  public static VectorOffset CreateGoldListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGoldListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNameStrId(FlatBufferBuilder builder, int NameStrId) { builder.AddInt(7, NameStrId, -1); }
  public static void AddDescStrId(FlatBufferBuilder builder, int DescStrId) { builder.AddInt(8, DescStrId, -1); }
  public static void AddGoldStrId(FlatBufferBuilder builder, int GoldStrId) { builder.AddInt(9, GoldStrId, -1); }
  public static Offset<FB_SYHRechargeAndConsumeReward> EndFB_SYHRechargeAndConsumeReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHRechargeAndConsumeReward>(o);
  }
};

public sealed class FB_SYHRechargeAndConsumeRewardContainer : Table {
  public static FB_SYHRechargeAndConsumeRewardContainer GetRootAsFB_SYHRechargeAndConsumeRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SYHRechargeAndConsumeRewardContainer(_bb, new FB_SYHRechargeAndConsumeRewardContainer()); }
  public static FB_SYHRechargeAndConsumeRewardContainer GetRootAsFB_SYHRechargeAndConsumeRewardContainer(ByteBuffer _bb, FB_SYHRechargeAndConsumeRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHRechargeAndConsumeRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHRechargeAndConsumeRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHRechargeAndConsumeReward GetItems(int j) { return GetItems(new FB_SYHRechargeAndConsumeReward(), j); }
  public FB_SYHRechargeAndConsumeReward GetItems(FB_SYHRechargeAndConsumeReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHRechargeAndConsumeRewardContainer> CreateFB_SYHRechargeAndConsumeRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHRechargeAndConsumeRewardContainer.AddItems(builder, items);
    return FB_SYHRechargeAndConsumeRewardContainer.EndFB_SYHRechargeAndConsumeRewardContainer(builder);
  }

  public static void StartFB_SYHRechargeAndConsumeRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHRechargeAndConsumeReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHRechargeAndConsumeRewardContainer> EndFB_SYHRechargeAndConsumeRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHRechargeAndConsumeRewardContainer>(o);
  }
  public static void FinishFB_SYHRechargeAndConsumeRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHRechargeAndConsumeRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
