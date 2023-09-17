// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SignInReward : Table {
  public static FB_SignInReward GetRootAsFB_SignInReward(ByteBuffer _bb) { return GetRootAsFB_SignInReward(_bb, new FB_SignInReward()); }
  public static FB_SignInReward GetRootAsFB_SignInReward(ByteBuffer _bb, FB_SignInReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SignInReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VipLvl { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VipTime { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelPart { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SignInReward> CreateFB_SignInReward(FlatBufferBuilder builder,
      int ID = 0,
      int ItemType = -1,
      int ItemID = -1,
      int ItemNum = -1,
      int VipLvl = -1,
      int VipTime = -1,
      int LevelPart = -1) {
    builder.StartObject(7);
    FB_SignInReward.AddLevelPart(builder, LevelPart);
    FB_SignInReward.AddVipTime(builder, VipTime);
    FB_SignInReward.AddVipLvl(builder, VipLvl);
    FB_SignInReward.AddItemNum(builder, ItemNum);
    FB_SignInReward.AddItemID(builder, ItemID);
    FB_SignInReward.AddItemType(builder, ItemType);
    FB_SignInReward.AddID(builder, ID);
    return FB_SignInReward.EndFB_SignInReward(builder);
  }

  public static void StartFB_SignInReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemType(FlatBufferBuilder builder, int ItemType) { builder.AddInt(1, ItemType, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(2, ItemID, -1); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(3, ItemNum, -1); }
  public static void AddVipLvl(FlatBufferBuilder builder, int VipLvl) { builder.AddInt(4, VipLvl, -1); }
  public static void AddVipTime(FlatBufferBuilder builder, int VipTime) { builder.AddInt(5, VipTime, -1); }
  public static void AddLevelPart(FlatBufferBuilder builder, int LevelPart) { builder.AddInt(6, LevelPart, -1); }
  public static Offset<FB_SignInReward> EndFB_SignInReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SignInReward>(o);
  }
};

public sealed class FB_SignInRewardContainer : Table {
  public static FB_SignInRewardContainer GetRootAsFB_SignInRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SignInRewardContainer(_bb, new FB_SignInRewardContainer()); }
  public static FB_SignInRewardContainer GetRootAsFB_SignInRewardContainer(ByteBuffer _bb, FB_SignInRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SignInRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SignInRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SignInReward GetItems(int j) { return GetItems(new FB_SignInReward(), j); }
  public FB_SignInReward GetItems(FB_SignInReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SignInRewardContainer> CreateFB_SignInRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SignInRewardContainer.AddItems(builder, items);
    return FB_SignInRewardContainer.EndFB_SignInRewardContainer(builder);
  }

  public static void StartFB_SignInRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SignInReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SignInRewardContainer> EndFB_SignInRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SignInRewardContainer>(o);
  }
  public static void FinishFB_SignInRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SignInRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
