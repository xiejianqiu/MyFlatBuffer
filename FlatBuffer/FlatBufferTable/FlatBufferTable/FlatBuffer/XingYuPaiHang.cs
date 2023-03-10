// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingYuPaiHang : Table {
  public static FB_XingYuPaiHang GetRootAsFB_XingYuPaiHang(ByteBuffer _bb) { return GetRootAsFB_XingYuPaiHang(_bb, new FB_XingYuPaiHang()); }
  public static FB_XingYuPaiHang GetRootAsFB_XingYuPaiHang(ByteBuffer _bb, FB_XingYuPaiHang obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingYuPaiHang __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetParamList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int Rate { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankMin { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RankMax { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MailId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_XingYuPaiHang> CreateFB_XingYuPaiHang(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      VectorOffset RewardList = default(VectorOffset),
      VectorOffset ParamList = default(VectorOffset),
      int Rate = -1,
      int RankMin = -1,
      int RankMax = -1,
      int MailId = -1) {
    builder.StartObject(8);
    FB_XingYuPaiHang.AddMailId(builder, MailId);
    FB_XingYuPaiHang.AddRankMax(builder, RankMax);
    FB_XingYuPaiHang.AddRankMin(builder, RankMin);
    FB_XingYuPaiHang.AddRate(builder, Rate);
    FB_XingYuPaiHang.AddParamList(builder, ParamList);
    FB_XingYuPaiHang.AddRewardList(builder, RewardList);
    FB_XingYuPaiHang.AddType(builder, Type);
    FB_XingYuPaiHang.AddID(builder, ID);
    return FB_XingYuPaiHang.EndFB_XingYuPaiHang(builder);
  }

  public static void StartFB_XingYuPaiHang(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset RewardListOffset) { builder.AddOffset(2, RewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(3, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRate(FlatBufferBuilder builder, int Rate) { builder.AddInt(4, Rate, -1); }
  public static void AddRankMin(FlatBufferBuilder builder, int RankMin) { builder.AddInt(5, RankMin, -1); }
  public static void AddRankMax(FlatBufferBuilder builder, int RankMax) { builder.AddInt(6, RankMax, -1); }
  public static void AddMailId(FlatBufferBuilder builder, int MailId) { builder.AddInt(7, MailId, -1); }
  public static Offset<FB_XingYuPaiHang> EndFB_XingYuPaiHang(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuPaiHang>(o);
  }
};

public sealed class FB_XingYuPaiHangContainer : Table {
  public static FB_XingYuPaiHangContainer GetRootAsFB_XingYuPaiHangContainer(ByteBuffer _bb) { return GetRootAsFB_XingYuPaiHangContainer(_bb, new FB_XingYuPaiHangContainer()); }
  public static FB_XingYuPaiHangContainer GetRootAsFB_XingYuPaiHangContainer(ByteBuffer _bb, FB_XingYuPaiHangContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingYuPaiHangContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingYuPaiHangContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingYuPaiHang GetItems(int j) { return GetItems(new FB_XingYuPaiHang(), j); }
  public FB_XingYuPaiHang GetItems(FB_XingYuPaiHang obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingYuPaiHangContainer> CreateFB_XingYuPaiHangContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingYuPaiHangContainer.AddItems(builder, items);
    return FB_XingYuPaiHangContainer.EndFB_XingYuPaiHangContainer(builder);
  }

  public static void StartFB_XingYuPaiHangContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingYuPaiHang>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingYuPaiHangContainer> EndFB_XingYuPaiHangContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingYuPaiHangContainer>(o);
  }
  public static void FinishFB_XingYuPaiHangContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingYuPaiHangContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
