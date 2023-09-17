// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJuBaoPenRanking : Table {
  public static FB_SYHJuBaoPenRanking GetRootAsFB_SYHJuBaoPenRanking(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPenRanking(_bb, new FB_SYHJuBaoPenRanking()); }
  public static FB_SYHJuBaoPenRanking GetRootAsFB_SYHJuBaoPenRanking(ByteBuffer _bb, FB_SYHJuBaoPenRanking obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJuBaoPenRanking __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRankingList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RankingListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int Percent { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHJuBaoPenRanking> CreateFB_SYHJuBaoPenRanking(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset RankingList = default(VectorOffset),
      int Percent = -1) {
    builder.StartObject(3);
    FB_SYHJuBaoPenRanking.AddPercent(builder, Percent);
    FB_SYHJuBaoPenRanking.AddRankingList(builder, RankingList);
    FB_SYHJuBaoPenRanking.AddID(builder, ID);
    return FB_SYHJuBaoPenRanking.EndFB_SYHJuBaoPenRanking(builder);
  }

  public static void StartFB_SYHJuBaoPenRanking(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRankingList(FlatBufferBuilder builder, VectorOffset RankingListOffset) { builder.AddOffset(1, RankingListOffset.Value, 0); }
  public static VectorOffset CreateRankingListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRankingListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPercent(FlatBufferBuilder builder, int Percent) { builder.AddInt(2, Percent, -1); }
  public static Offset<FB_SYHJuBaoPenRanking> EndFB_SYHJuBaoPenRanking(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPenRanking>(o);
  }
};

public sealed class FB_SYHJuBaoPenRankingContainer : Table {
  public static FB_SYHJuBaoPenRankingContainer GetRootAsFB_SYHJuBaoPenRankingContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPenRankingContainer(_bb, new FB_SYHJuBaoPenRankingContainer()); }
  public static FB_SYHJuBaoPenRankingContainer GetRootAsFB_SYHJuBaoPenRankingContainer(ByteBuffer _bb, FB_SYHJuBaoPenRankingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJuBaoPenRankingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJuBaoPenRankingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJuBaoPenRanking GetItems(int j) { return GetItems(new FB_SYHJuBaoPenRanking(), j); }
  public FB_SYHJuBaoPenRanking GetItems(FB_SYHJuBaoPenRanking obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoPenRankingContainer> CreateFB_SYHJuBaoPenRankingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJuBaoPenRankingContainer.AddItems(builder, items);
    return FB_SYHJuBaoPenRankingContainer.EndFB_SYHJuBaoPenRankingContainer(builder);
  }

  public static void StartFB_SYHJuBaoPenRankingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPenRanking>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoPenRankingContainer> EndFB_SYHJuBaoPenRankingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPenRankingContainer>(o);
  }
  public static void FinishFB_SYHJuBaoPenRankingContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPenRankingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
