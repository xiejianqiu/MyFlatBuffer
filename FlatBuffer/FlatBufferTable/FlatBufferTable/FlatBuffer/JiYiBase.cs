// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiYiBase : Table {
  public static FB_JiYiBase GetRootAsFB_JiYiBase(ByteBuffer _bb) { return GetRootAsFB_JiYiBase(_bb, new FB_JiYiBase()); }
  public static FB_JiYiBase GetRootAsFB_JiYiBase(ByteBuffer _bb, FB_JiYiBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiYiBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Time { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int QuestCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitFinger { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Reward { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardNumber { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_JiYiBase> CreateFB_JiYiBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Time = -1,
      int QuestCount = -1,
      int LimitFinger = -1,
      int Reward = -1,
      int RewardNumber = -1) {
    builder.StartObject(7);
    FB_JiYiBase.AddRewardNumber(builder, RewardNumber);
    FB_JiYiBase.AddReward(builder, Reward);
    FB_JiYiBase.AddLimitFinger(builder, LimitFinger);
    FB_JiYiBase.AddQuestCount(builder, QuestCount);
    FB_JiYiBase.AddTime(builder, Time);
    FB_JiYiBase.AddName(builder, Name);
    FB_JiYiBase.AddID(builder, ID);
    return FB_JiYiBase.EndFB_JiYiBase(builder);
  }

  public static void StartFB_JiYiBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTime(FlatBufferBuilder builder, int Time) { builder.AddInt(2, Time, -1); }
  public static void AddQuestCount(FlatBufferBuilder builder, int QuestCount) { builder.AddInt(3, QuestCount, -1); }
  public static void AddLimitFinger(FlatBufferBuilder builder, int LimitFinger) { builder.AddInt(4, LimitFinger, -1); }
  public static void AddReward(FlatBufferBuilder builder, int Reward) { builder.AddInt(5, Reward, -1); }
  public static void AddRewardNumber(FlatBufferBuilder builder, int RewardNumber) { builder.AddInt(6, RewardNumber, -1); }
  public static Offset<FB_JiYiBase> EndFB_JiYiBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiYiBase>(o);
  }
};

public sealed class FB_JiYiBaseContainer : Table {
  public static FB_JiYiBaseContainer GetRootAsFB_JiYiBaseContainer(ByteBuffer _bb) { return GetRootAsFB_JiYiBaseContainer(_bb, new FB_JiYiBaseContainer()); }
  public static FB_JiYiBaseContainer GetRootAsFB_JiYiBaseContainer(ByteBuffer _bb, FB_JiYiBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiYiBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiYiBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiYiBase GetItems(int j) { return GetItems(new FB_JiYiBase(), j); }
  public FB_JiYiBase GetItems(FB_JiYiBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiYiBaseContainer> CreateFB_JiYiBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiYiBaseContainer.AddItems(builder, items);
    return FB_JiYiBaseContainer.EndFB_JiYiBaseContainer(builder);
  }

  public static void StartFB_JiYiBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiYiBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiYiBaseContainer> EndFB_JiYiBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiYiBaseContainer>(o);
  }
  public static void FinishFB_JiYiBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiYiBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
