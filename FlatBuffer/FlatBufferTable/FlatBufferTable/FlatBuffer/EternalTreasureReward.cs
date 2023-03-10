// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EternalTreasureReward : Table {
  public static FB_EternalTreasureReward GetRootAsFB_EternalTreasureReward(ByteBuffer _bb) { return GetRootAsFB_EternalTreasureReward(_bb, new FB_EternalTreasureReward()); }
  public static FB_EternalTreasureReward GetRootAsFB_EternalTreasureReward(ByteBuffer _bb, FB_EternalTreasureReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EternalTreasureReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScoreLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetBonusIndexList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusIndexListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int FlagId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EternalTreasureReward> CreateFB_EternalTreasureReward(FlatBufferBuilder builder,
      int ID = 0,
      int ScoreLimit = -1,
      int Level = -1,
      int DicId = -1,
      VectorOffset BonusIndexList = default(VectorOffset),
      int FlagId = -1) {
    builder.StartObject(6);
    FB_EternalTreasureReward.AddFlagId(builder, FlagId);
    FB_EternalTreasureReward.AddBonusIndexList(builder, BonusIndexList);
    FB_EternalTreasureReward.AddDicId(builder, DicId);
    FB_EternalTreasureReward.AddLevel(builder, Level);
    FB_EternalTreasureReward.AddScoreLimit(builder, ScoreLimit);
    FB_EternalTreasureReward.AddID(builder, ID);
    return FB_EternalTreasureReward.EndFB_EternalTreasureReward(builder);
  }

  public static void StartFB_EternalTreasureReward(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScoreLimit(FlatBufferBuilder builder, int ScoreLimit) { builder.AddInt(1, ScoreLimit, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(3, DicId, -1); }
  public static void AddBonusIndexList(FlatBufferBuilder builder, VectorOffset BonusIndexListOffset) { builder.AddOffset(4, BonusIndexListOffset.Value, 0); }
  public static VectorOffset CreateBonusIndexListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusIndexListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFlagId(FlatBufferBuilder builder, int FlagId) { builder.AddInt(5, FlagId, -1); }
  public static Offset<FB_EternalTreasureReward> EndFB_EternalTreasureReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EternalTreasureReward>(o);
  }
};

public sealed class FB_EternalTreasureRewardContainer : Table {
  public static FB_EternalTreasureRewardContainer GetRootAsFB_EternalTreasureRewardContainer(ByteBuffer _bb) { return GetRootAsFB_EternalTreasureRewardContainer(_bb, new FB_EternalTreasureRewardContainer()); }
  public static FB_EternalTreasureRewardContainer GetRootAsFB_EternalTreasureRewardContainer(ByteBuffer _bb, FB_EternalTreasureRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EternalTreasureRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EternalTreasureRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EternalTreasureReward GetItems(int j) { return GetItems(new FB_EternalTreasureReward(), j); }
  public FB_EternalTreasureReward GetItems(FB_EternalTreasureReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EternalTreasureRewardContainer> CreateFB_EternalTreasureRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EternalTreasureRewardContainer.AddItems(builder, items);
    return FB_EternalTreasureRewardContainer.EndFB_EternalTreasureRewardContainer(builder);
  }

  public static void StartFB_EternalTreasureRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EternalTreasureReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EternalTreasureRewardContainer> EndFB_EternalTreasureRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EternalTreasureRewardContainer>(o);
  }
  public static void FinishFB_EternalTreasureRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_EternalTreasureRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
