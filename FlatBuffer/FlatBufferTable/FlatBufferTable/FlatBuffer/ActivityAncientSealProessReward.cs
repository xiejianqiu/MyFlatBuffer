// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityAncientSealProessReward : Table {
  public static FB_ActivityAncientSealProessReward GetRootAsFB_ActivityAncientSealProessReward(ByteBuffer _bb) { return GetRootAsFB_ActivityAncientSealProessReward(_bb, new FB_ActivityAncientSealProessReward()); }
  public static FB_ActivityAncientSealProessReward GetRootAsFB_ActivityAncientSealProessReward(ByteBuffer _bb, FB_ActivityAncientSealProessReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityAncientSealProessReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ScoreLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BonusIndex { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityAncientSealProessReward> CreateFB_ActivityAncientSealProessReward(FlatBufferBuilder builder,
      int ID = 0,
      int ScoreLimit = -1,
      int Level = -1,
      int DicId = -1,
      int BonusIndex = -1,
      int ShowLimit = -1,
      int Param = -1) {
    builder.StartObject(7);
    FB_ActivityAncientSealProessReward.AddParam(builder, Param);
    FB_ActivityAncientSealProessReward.AddShowLimit(builder, ShowLimit);
    FB_ActivityAncientSealProessReward.AddBonusIndex(builder, BonusIndex);
    FB_ActivityAncientSealProessReward.AddDicId(builder, DicId);
    FB_ActivityAncientSealProessReward.AddLevel(builder, Level);
    FB_ActivityAncientSealProessReward.AddScoreLimit(builder, ScoreLimit);
    FB_ActivityAncientSealProessReward.AddID(builder, ID);
    return FB_ActivityAncientSealProessReward.EndFB_ActivityAncientSealProessReward(builder);
  }

  public static void StartFB_ActivityAncientSealProessReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScoreLimit(FlatBufferBuilder builder, int ScoreLimit) { builder.AddInt(1, ScoreLimit, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(3, DicId, -1); }
  public static void AddBonusIndex(FlatBufferBuilder builder, int BonusIndex) { builder.AddInt(4, BonusIndex, -1); }
  public static void AddShowLimit(FlatBufferBuilder builder, int ShowLimit) { builder.AddInt(5, ShowLimit, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(6, Param, -1); }
  public static Offset<FB_ActivityAncientSealProessReward> EndFB_ActivityAncientSealProessReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityAncientSealProessReward>(o);
  }
};

public sealed class FB_ActivityAncientSealProessRewardContainer : Table {
  public static FB_ActivityAncientSealProessRewardContainer GetRootAsFB_ActivityAncientSealProessRewardContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityAncientSealProessRewardContainer(_bb, new FB_ActivityAncientSealProessRewardContainer()); }
  public static FB_ActivityAncientSealProessRewardContainer GetRootAsFB_ActivityAncientSealProessRewardContainer(ByteBuffer _bb, FB_ActivityAncientSealProessRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityAncientSealProessRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityAncientSealProessRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityAncientSealProessReward GetItems(int j) { return GetItems(new FB_ActivityAncientSealProessReward(), j); }
  public FB_ActivityAncientSealProessReward GetItems(FB_ActivityAncientSealProessReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityAncientSealProessRewardContainer> CreateFB_ActivityAncientSealProessRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityAncientSealProessRewardContainer.AddItems(builder, items);
    return FB_ActivityAncientSealProessRewardContainer.EndFB_ActivityAncientSealProessRewardContainer(builder);
  }

  public static void StartFB_ActivityAncientSealProessRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityAncientSealProessReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityAncientSealProessRewardContainer> EndFB_ActivityAncientSealProessRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityAncientSealProessRewardContainer>(o);
  }
  public static void FinishFB_ActivityAncientSealProessRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityAncientSealProessRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
