// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityChickenProessReward : Table {
  public static FB_ActivityChickenProessReward GetRootAsFB_ActivityChickenProessReward(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenProessReward(_bb, new FB_ActivityChickenProessReward()); }
  public static FB_ActivityChickenProessReward GetRootAsFB_ActivityChickenProessReward(ByteBuffer _bb, FB_ActivityChickenProessReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityChickenProessReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BonusIndex { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Score { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityChickenProessReward> CreateFB_ActivityChickenProessReward(FlatBufferBuilder builder,
      int ID = 0,
      int Level = -1,
      int DicId = -1,
      int BonusIndex = -1,
      int Score = -1) {
    builder.StartObject(5);
    FB_ActivityChickenProessReward.AddScore(builder, Score);
    FB_ActivityChickenProessReward.AddBonusIndex(builder, BonusIndex);
    FB_ActivityChickenProessReward.AddDicId(builder, DicId);
    FB_ActivityChickenProessReward.AddLevel(builder, Level);
    FB_ActivityChickenProessReward.AddID(builder, ID);
    return FB_ActivityChickenProessReward.EndFB_ActivityChickenProessReward(builder);
  }

  public static void StartFB_ActivityChickenProessReward(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(2, DicId, -1); }
  public static void AddBonusIndex(FlatBufferBuilder builder, int BonusIndex) { builder.AddInt(3, BonusIndex, -1); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(4, Score, -1); }
  public static Offset<FB_ActivityChickenProessReward> EndFB_ActivityChickenProessReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenProessReward>(o);
  }
};

public sealed class FB_ActivityChickenProessRewardContainer : Table {
  public static FB_ActivityChickenProessRewardContainer GetRootAsFB_ActivityChickenProessRewardContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenProessRewardContainer(_bb, new FB_ActivityChickenProessRewardContainer()); }
  public static FB_ActivityChickenProessRewardContainer GetRootAsFB_ActivityChickenProessRewardContainer(ByteBuffer _bb, FB_ActivityChickenProessRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityChickenProessRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityChickenProessRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityChickenProessReward GetItems(int j) { return GetItems(new FB_ActivityChickenProessReward(), j); }
  public FB_ActivityChickenProessReward GetItems(FB_ActivityChickenProessReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityChickenProessRewardContainer> CreateFB_ActivityChickenProessRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityChickenProessRewardContainer.AddItems(builder, items);
    return FB_ActivityChickenProessRewardContainer.EndFB_ActivityChickenProessRewardContainer(builder);
  }

  public static void StartFB_ActivityChickenProessRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityChickenProessReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityChickenProessRewardContainer> EndFB_ActivityChickenProessRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenProessRewardContainer>(o);
  }
  public static void FinishFB_ActivityChickenProessRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityChickenProessRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
