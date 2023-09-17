// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHYuanBaoInvest : Table {
  public static FB_SYHYuanBaoInvest GetRootAsFB_SYHYuanBaoInvest(ByteBuffer _bb) { return GetRootAsFB_SYHYuanBaoInvest(_bb, new FB_SYHYuanBaoInvest()); }
  public static FB_SYHYuanBaoInvest GetRootAsFB_SYHYuanBaoInvest(ByteBuffer _bb, FB_SYHYuanBaoInvest obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHYuanBaoInvest __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrDic { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Dic { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExtraReward { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHYuanBaoInvest> CreateFB_SYHYuanBaoInvest(FlatBufferBuilder builder,
      int ID = 0,
      int StrDic = -1,
      int MoneyNum = -1,
      int Dic = -1,
      int LevelLimit = -1,
      int ExtraReward = -1) {
    builder.StartObject(6);
    FB_SYHYuanBaoInvest.AddExtraReward(builder, ExtraReward);
    FB_SYHYuanBaoInvest.AddLevelLimit(builder, LevelLimit);
    FB_SYHYuanBaoInvest.AddDic(builder, Dic);
    FB_SYHYuanBaoInvest.AddMoneyNum(builder, MoneyNum);
    FB_SYHYuanBaoInvest.AddStrDic(builder, StrDic);
    FB_SYHYuanBaoInvest.AddID(builder, ID);
    return FB_SYHYuanBaoInvest.EndFB_SYHYuanBaoInvest(builder);
  }

  public static void StartFB_SYHYuanBaoInvest(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStrDic(FlatBufferBuilder builder, int StrDic) { builder.AddInt(1, StrDic, -1); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(2, MoneyNum, -1); }
  public static void AddDic(FlatBufferBuilder builder, int Dic) { builder.AddInt(3, Dic, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(4, LevelLimit, -1); }
  public static void AddExtraReward(FlatBufferBuilder builder, int ExtraReward) { builder.AddInt(5, ExtraReward, -1); }
  public static Offset<FB_SYHYuanBaoInvest> EndFB_SYHYuanBaoInvest(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHYuanBaoInvest>(o);
  }
};

public sealed class FB_SYHYuanBaoInvestContainer : Table {
  public static FB_SYHYuanBaoInvestContainer GetRootAsFB_SYHYuanBaoInvestContainer(ByteBuffer _bb) { return GetRootAsFB_SYHYuanBaoInvestContainer(_bb, new FB_SYHYuanBaoInvestContainer()); }
  public static FB_SYHYuanBaoInvestContainer GetRootAsFB_SYHYuanBaoInvestContainer(ByteBuffer _bb, FB_SYHYuanBaoInvestContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHYuanBaoInvestContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHYuanBaoInvestContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHYuanBaoInvest GetItems(int j) { return GetItems(new FB_SYHYuanBaoInvest(), j); }
  public FB_SYHYuanBaoInvest GetItems(FB_SYHYuanBaoInvest obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHYuanBaoInvestContainer> CreateFB_SYHYuanBaoInvestContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHYuanBaoInvestContainer.AddItems(builder, items);
    return FB_SYHYuanBaoInvestContainer.EndFB_SYHYuanBaoInvestContainer(builder);
  }

  public static void StartFB_SYHYuanBaoInvestContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHYuanBaoInvest>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHYuanBaoInvestContainer> EndFB_SYHYuanBaoInvestContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHYuanBaoInvestContainer>(o);
  }
  public static void FinishFB_SYHYuanBaoInvestContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHYuanBaoInvestContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
