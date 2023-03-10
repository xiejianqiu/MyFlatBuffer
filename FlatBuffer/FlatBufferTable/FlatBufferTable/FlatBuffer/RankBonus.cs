// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RankBonus : Table {
  public static FB_RankBonus GetRootAsFB_RankBonus(ByteBuffer _bb) { return GetRootAsFB_RankBonus(_bb, new FB_RankBonus()); }
  public static FB_RankBonus GetRootAsFB_RankBonus(ByteBuffer _bb, FB_RankBonus obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RankBonus __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRankList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RankListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RankBonus> CreateFB_RankBonus(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset RankList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_RankBonus.AddRankList(builder, RankList);
    FB_RankBonus.AddID(builder, ID);
    return FB_RankBonus.EndFB_RankBonus(builder);
  }

  public static void StartFB_RankBonus(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRankList(FlatBufferBuilder builder, VectorOffset RankListOffset) { builder.AddOffset(1, RankListOffset.Value, 0); }
  public static VectorOffset CreateRankListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRankListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RankBonus> EndFB_RankBonus(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RankBonus>(o);
  }
};

public sealed class FB_RankBonusContainer : Table {
  public static FB_RankBonusContainer GetRootAsFB_RankBonusContainer(ByteBuffer _bb) { return GetRootAsFB_RankBonusContainer(_bb, new FB_RankBonusContainer()); }
  public static FB_RankBonusContainer GetRootAsFB_RankBonusContainer(ByteBuffer _bb, FB_RankBonusContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RankBonusContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RankBonusContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RankBonus GetItems(int j) { return GetItems(new FB_RankBonus(), j); }
  public FB_RankBonus GetItems(FB_RankBonus obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RankBonusContainer> CreateFB_RankBonusContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RankBonusContainer.AddItems(builder, items);
    return FB_RankBonusContainer.EndFB_RankBonusContainer(builder);
  }

  public static void StartFB_RankBonusContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RankBonus>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RankBonusContainer> EndFB_RankBonusContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RankBonusContainer>(o);
  }
  public static void FinishFB_RankBonusContainerBuffer(FlatBufferBuilder builder, Offset<FB_RankBonusContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
