// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionRoundLevel : Table {
  public static FB_MissionRoundLevel GetRootAsFB_MissionRoundLevel(ByteBuffer _bb) { return GetRootAsFB_MissionRoundLevel(_bb, new FB_MissionRoundLevel()); }
  public static FB_MissionRoundLevel GetRootAsFB_MissionRoundLevel(ByteBuffer _bb, FB_MissionRoundLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionRoundLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long BindMoney { get { int o = __offset(6); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public long Exp { get { int o = __offset(8); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int BossItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShiliShopCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long YuanShenExp { get { int o = __offset(18); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int PlayerLv { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionRoundLevel> CreateFB_MissionRoundLevel(FlatBufferBuilder builder,
      int Id = 0,
      long BindMoney = -1,
      long Exp = -1,
      int BossItemCount = -1,
      int ItemId = -1,
      int ItemCount = -1,
      int ShiliShopCount = -1,
      long YuanShenExp = -1,
      int PlayerLv = -1) {
    builder.StartObject(9);
    FB_MissionRoundLevel.AddYuanShenExp(builder, YuanShenExp);
    FB_MissionRoundLevel.AddExp(builder, Exp);
    FB_MissionRoundLevel.AddBindMoney(builder, BindMoney);
    FB_MissionRoundLevel.AddPlayerLv(builder, PlayerLv);
    FB_MissionRoundLevel.AddShiliShopCount(builder, ShiliShopCount);
    FB_MissionRoundLevel.AddItemCount(builder, ItemCount);
    FB_MissionRoundLevel.AddItemId(builder, ItemId);
    FB_MissionRoundLevel.AddBossItemCount(builder, BossItemCount);
    FB_MissionRoundLevel.AddId(builder, Id);
    return FB_MissionRoundLevel.EndFB_MissionRoundLevel(builder);
  }

  public static void StartFB_MissionRoundLevel(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddBindMoney(FlatBufferBuilder builder, long BindMoney) { builder.AddLong(1, BindMoney, -1); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(2, Exp, -1); }
  public static void AddBossItemCount(FlatBufferBuilder builder, int BossItemCount) { builder.AddInt(3, BossItemCount, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(4, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(5, ItemCount, -1); }
  public static void AddShiliShopCount(FlatBufferBuilder builder, int ShiliShopCount) { builder.AddInt(6, ShiliShopCount, -1); }
  public static void AddYuanShenExp(FlatBufferBuilder builder, long YuanShenExp) { builder.AddLong(7, YuanShenExp, -1); }
  public static void AddPlayerLv(FlatBufferBuilder builder, int PlayerLv) { builder.AddInt(8, PlayerLv, -1); }
  public static Offset<FB_MissionRoundLevel> EndFB_MissionRoundLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundLevel>(o);
  }
};

public sealed class FB_MissionRoundLevelContainer : Table {
  public static FB_MissionRoundLevelContainer GetRootAsFB_MissionRoundLevelContainer(ByteBuffer _bb) { return GetRootAsFB_MissionRoundLevelContainer(_bb, new FB_MissionRoundLevelContainer()); }
  public static FB_MissionRoundLevelContainer GetRootAsFB_MissionRoundLevelContainer(ByteBuffer _bb, FB_MissionRoundLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionRoundLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionRoundLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionRoundLevel GetItems(int j) { return GetItems(new FB_MissionRoundLevel(), j); }
  public FB_MissionRoundLevel GetItems(FB_MissionRoundLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionRoundLevelContainer> CreateFB_MissionRoundLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionRoundLevelContainer.AddItems(builder, items);
    return FB_MissionRoundLevelContainer.EndFB_MissionRoundLevelContainer(builder);
  }

  public static void StartFB_MissionRoundLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionRoundLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionRoundLevelContainer> EndFB_MissionRoundLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundLevelContainer>(o);
  }
  public static void FinishFB_MissionRoundLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionRoundLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
