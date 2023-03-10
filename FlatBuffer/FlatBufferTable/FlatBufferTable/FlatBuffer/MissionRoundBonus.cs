// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionRoundBonus : Table {
  public static FB_MissionRoundBonus GetRootAsFB_MissionRoundBonus(ByteBuffer _bb) { return GetRootAsFB_MissionRoundBonus(_bb, new FB_MissionRoundBonus()); }
  public static FB_MissionRoundBonus GetRootAsFB_MissionRoundBonus(ByteBuffer _bb, FB_MissionRoundBonus obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionRoundBonus __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long GetExpRateList(int j) { int o = __offset(6); return o != 0 ? bb.GetLong(__vector(o) + j * 8) : (long)0; }
  public int ExpRateListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public long GetBindMoneyRateList(int j) { int o = __offset(8); return o != 0 ? bb.GetLong(__vector(o) + j * 8) : (long)0; }
  public int BindMoneyRateListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBossItemCountList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BossItemCountListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public long YuanShenExpRate { get { int o = __offset(14); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }

  public static Offset<FB_MissionRoundBonus> CreateFB_MissionRoundBonus(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset ExpRateList = default(VectorOffset),
      VectorOffset BindMoneyRateList = default(VectorOffset),
      VectorOffset BossItemCountList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      long YuanShenExpRate = -1) {
    builder.StartObject(6);
    FB_MissionRoundBonus.AddYuanShenExpRate(builder, YuanShenExpRate);
    FB_MissionRoundBonus.AddItemCountList(builder, ItemCountList);
    FB_MissionRoundBonus.AddBossItemCountList(builder, BossItemCountList);
    FB_MissionRoundBonus.AddBindMoneyRateList(builder, BindMoneyRateList);
    FB_MissionRoundBonus.AddExpRateList(builder, ExpRateList);
    FB_MissionRoundBonus.AddId(builder, Id);
    return FB_MissionRoundBonus.EndFB_MissionRoundBonus(builder);
  }

  public static void StartFB_MissionRoundBonus(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddExpRateList(FlatBufferBuilder builder, VectorOffset ExpRateListOffset) { builder.AddOffset(1, ExpRateListOffset.Value, 0); }
  public static VectorOffset CreateExpRateListVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartExpRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddBindMoneyRateList(FlatBufferBuilder builder, VectorOffset BindMoneyRateListOffset) { builder.AddOffset(2, BindMoneyRateListOffset.Value, 0); }
  public static VectorOffset CreateBindMoneyRateListVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static void StartBindMoneyRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddBossItemCountList(FlatBufferBuilder builder, VectorOffset BossItemCountListOffset) { builder.AddOffset(3, BossItemCountListOffset.Value, 0); }
  public static VectorOffset CreateBossItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBossItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(4, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddYuanShenExpRate(FlatBufferBuilder builder, long YuanShenExpRate) { builder.AddLong(5, YuanShenExpRate, -1); }
  public static Offset<FB_MissionRoundBonus> EndFB_MissionRoundBonus(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundBonus>(o);
  }
};

public sealed class FB_MissionRoundBonusContainer : Table {
  public static FB_MissionRoundBonusContainer GetRootAsFB_MissionRoundBonusContainer(ByteBuffer _bb) { return GetRootAsFB_MissionRoundBonusContainer(_bb, new FB_MissionRoundBonusContainer()); }
  public static FB_MissionRoundBonusContainer GetRootAsFB_MissionRoundBonusContainer(ByteBuffer _bb, FB_MissionRoundBonusContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionRoundBonusContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionRoundBonusContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionRoundBonus GetItems(int j) { return GetItems(new FB_MissionRoundBonus(), j); }
  public FB_MissionRoundBonus GetItems(FB_MissionRoundBonus obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionRoundBonusContainer> CreateFB_MissionRoundBonusContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionRoundBonusContainer.AddItems(builder, items);
    return FB_MissionRoundBonusContainer.EndFB_MissionRoundBonusContainer(builder);
  }

  public static void StartFB_MissionRoundBonusContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionRoundBonus>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionRoundBonusContainer> EndFB_MissionRoundBonusContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundBonusContainer>(o);
  }
  public static void FinishFB_MissionRoundBonusContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionRoundBonusContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
