// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActWanGuConfig : Table {
  public static FB_ActWanGuConfig GetRootAsFB_ActWanGuConfig(ByteBuffer _bb) { return GetRootAsFB_ActWanGuConfig(_bb, new FB_ActWanGuConfig()); }
  public static FB_ActWanGuConfig GetRootAsFB_ActWanGuConfig(ByteBuffer _bb, FB_ActWanGuConfig obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActWanGuConfig __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PropUnlockCost { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BaoXiangId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PropRewardId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PropRewardMaxId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PropLevelCostItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NameID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string SprTitle { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DesID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PropCostNum { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PropAddExp { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActWanGuConfig> CreateFB_ActWanGuConfig(FlatBufferBuilder builder,
      int ID = 0,
      int PropUnlockCost = -1,
      int BaoXiangId = -1,
      int PropRewardId = -1,
      int PropRewardMaxId = -1,
      int PropLevelCostItemId = -1,
      int NameID = -1,
      StringOffset SprTitle = default(StringOffset),
      int DesID = -1,
      int PropCostNum = -1,
      int PropAddExp = -1) {
    builder.StartObject(11);
    FB_ActWanGuConfig.AddPropAddExp(builder, PropAddExp);
    FB_ActWanGuConfig.AddPropCostNum(builder, PropCostNum);
    FB_ActWanGuConfig.AddDesID(builder, DesID);
    FB_ActWanGuConfig.AddSprTitle(builder, SprTitle);
    FB_ActWanGuConfig.AddNameID(builder, NameID);
    FB_ActWanGuConfig.AddPropLevelCostItemId(builder, PropLevelCostItemId);
    FB_ActWanGuConfig.AddPropRewardMaxId(builder, PropRewardMaxId);
    FB_ActWanGuConfig.AddPropRewardId(builder, PropRewardId);
    FB_ActWanGuConfig.AddBaoXiangId(builder, BaoXiangId);
    FB_ActWanGuConfig.AddPropUnlockCost(builder, PropUnlockCost);
    FB_ActWanGuConfig.AddID(builder, ID);
    return FB_ActWanGuConfig.EndFB_ActWanGuConfig(builder);
  }

  public static void StartFB_ActWanGuConfig(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPropUnlockCost(FlatBufferBuilder builder, int PropUnlockCost) { builder.AddInt(1, PropUnlockCost, -1); }
  public static void AddBaoXiangId(FlatBufferBuilder builder, int BaoXiangId) { builder.AddInt(2, BaoXiangId, -1); }
  public static void AddPropRewardId(FlatBufferBuilder builder, int PropRewardId) { builder.AddInt(3, PropRewardId, -1); }
  public static void AddPropRewardMaxId(FlatBufferBuilder builder, int PropRewardMaxId) { builder.AddInt(4, PropRewardMaxId, -1); }
  public static void AddPropLevelCostItemId(FlatBufferBuilder builder, int PropLevelCostItemId) { builder.AddInt(5, PropLevelCostItemId, -1); }
  public static void AddNameID(FlatBufferBuilder builder, int NameID) { builder.AddInt(6, NameID, -1); }
  public static void AddSprTitle(FlatBufferBuilder builder, StringOffset SprTitleOffset) { builder.AddOffset(7, SprTitleOffset.Value, 0); }
  public static void AddDesID(FlatBufferBuilder builder, int DesID) { builder.AddInt(8, DesID, -1); }
  public static void AddPropCostNum(FlatBufferBuilder builder, int PropCostNum) { builder.AddInt(9, PropCostNum, -1); }
  public static void AddPropAddExp(FlatBufferBuilder builder, int PropAddExp) { builder.AddInt(10, PropAddExp, -1); }
  public static Offset<FB_ActWanGuConfig> EndFB_ActWanGuConfig(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuConfig>(o);
  }
};

public sealed class FB_ActWanGuConfigContainer : Table {
  public static FB_ActWanGuConfigContainer GetRootAsFB_ActWanGuConfigContainer(ByteBuffer _bb) { return GetRootAsFB_ActWanGuConfigContainer(_bb, new FB_ActWanGuConfigContainer()); }
  public static FB_ActWanGuConfigContainer GetRootAsFB_ActWanGuConfigContainer(ByteBuffer _bb, FB_ActWanGuConfigContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActWanGuConfigContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActWanGuConfigContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActWanGuConfig GetItems(int j) { return GetItems(new FB_ActWanGuConfig(), j); }
  public FB_ActWanGuConfig GetItems(FB_ActWanGuConfig obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuConfigContainer> CreateFB_ActWanGuConfigContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActWanGuConfigContainer.AddItems(builder, items);
    return FB_ActWanGuConfigContainer.EndFB_ActWanGuConfigContainer(builder);
  }

  public static void StartFB_ActWanGuConfigContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActWanGuConfig>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuConfigContainer> EndFB_ActWanGuConfigContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuConfigContainer>(o);
  }
  public static void FinishFB_ActWanGuConfigContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActWanGuConfigContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
