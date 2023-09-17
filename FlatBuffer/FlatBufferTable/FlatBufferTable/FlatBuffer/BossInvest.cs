// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BossInvest : Table {
  public static FB_BossInvest GetRootAsFB_BossInvest(ByteBuffer _bb) { return GetRootAsFB_BossInvest(_bb, new FB_BossInvest()); }
  public static FB_BossInvest GetRootAsFB_BossInvest(ByteBuffer _bb, FB_BossInvest obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BossInvest __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MoneyNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AchievementBaseId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExtraReward { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BossInvest> CreateFB_BossInvest(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int MoneyNum = 0,
      int StrId = -1,
      int AchievementBaseId = -1,
      int ExtraReward = -1) {
    builder.StartObject(6);
    FB_BossInvest.AddExtraReward(builder, ExtraReward);
    FB_BossInvest.AddAchievementBaseId(builder, AchievementBaseId);
    FB_BossInvest.AddStrId(builder, StrId);
    FB_BossInvest.AddMoneyNum(builder, MoneyNum);
    FB_BossInvest.AddName(builder, Name);
    FB_BossInvest.AddID(builder, ID);
    return FB_BossInvest.EndFB_BossInvest(builder);
  }

  public static void StartFB_BossInvest(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(2, MoneyNum, 0); }
  public static void AddStrId(FlatBufferBuilder builder, int StrId) { builder.AddInt(3, StrId, -1); }
  public static void AddAchievementBaseId(FlatBufferBuilder builder, int AchievementBaseId) { builder.AddInt(4, AchievementBaseId, -1); }
  public static void AddExtraReward(FlatBufferBuilder builder, int ExtraReward) { builder.AddInt(5, ExtraReward, -1); }
  public static Offset<FB_BossInvest> EndFB_BossInvest(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BossInvest>(o);
  }
};

public sealed class FB_BossInvestContainer : Table {
  public static FB_BossInvestContainer GetRootAsFB_BossInvestContainer(ByteBuffer _bb) { return GetRootAsFB_BossInvestContainer(_bb, new FB_BossInvestContainer()); }
  public static FB_BossInvestContainer GetRootAsFB_BossInvestContainer(ByteBuffer _bb, FB_BossInvestContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BossInvestContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BossInvestContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BossInvest GetItems(int j) { return GetItems(new FB_BossInvest(), j); }
  public FB_BossInvest GetItems(FB_BossInvest obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BossInvestContainer> CreateFB_BossInvestContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BossInvestContainer.AddItems(builder, items);
    return FB_BossInvestContainer.EndFB_BossInvestContainer(builder);
  }

  public static void StartFB_BossInvestContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BossInvest>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BossInvestContainer> EndFB_BossInvestContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BossInvestContainer>(o);
  }
  public static void FinishFB_BossInvestContainerBuffer(FlatBufferBuilder builder, Offset<FB_BossInvestContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
