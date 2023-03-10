// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ZheKouShangDian : Table {
  public static FB_ZheKouShangDian GetRootAsFB_ZheKouShangDian(ByteBuffer _bb) { return GetRootAsFB_ZheKouShangDian(_bb, new FB_ZheKouShangDian()); }
  public static FB_ZheKouShangDian GetRootAsFB_ZheKouShangDian(ByteBuffer _bb, FB_ZheKouShangDian obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ZheKouShangDian __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int KaiFuPaiHangId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardItemIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemCountList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemCountListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int Price { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OriginPrice { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Discount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ZheKouShangDian> CreateFB_ZheKouShangDian(FlatBufferBuilder builder,
      int ID = 0,
      int KaiFuPaiHangId = -1,
      VectorOffset RewardItemIdList = default(VectorOffset),
      VectorOffset RewardItemCountList = default(VectorOffset),
      int Price = -1,
      int OriginPrice = -1,
      int Discount = -1,
      int MaxCount = -1,
      int RewardType = 0) {
    builder.StartObject(9);
    FB_ZheKouShangDian.AddRewardType(builder, RewardType);
    FB_ZheKouShangDian.AddMaxCount(builder, MaxCount);
    FB_ZheKouShangDian.AddDiscount(builder, Discount);
    FB_ZheKouShangDian.AddOriginPrice(builder, OriginPrice);
    FB_ZheKouShangDian.AddPrice(builder, Price);
    FB_ZheKouShangDian.AddRewardItemCountList(builder, RewardItemCountList);
    FB_ZheKouShangDian.AddRewardItemIdList(builder, RewardItemIdList);
    FB_ZheKouShangDian.AddKaiFuPaiHangId(builder, KaiFuPaiHangId);
    FB_ZheKouShangDian.AddID(builder, ID);
    return FB_ZheKouShangDian.EndFB_ZheKouShangDian(builder);
  }

  public static void StartFB_ZheKouShangDian(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddKaiFuPaiHangId(FlatBufferBuilder builder, int KaiFuPaiHangId) { builder.AddInt(1, KaiFuPaiHangId, -1); }
  public static void AddRewardItemIdList(FlatBufferBuilder builder, VectorOffset RewardItemIdListOffset) { builder.AddOffset(2, RewardItemIdListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemCountList(FlatBufferBuilder builder, VectorOffset RewardItemCountListOffset) { builder.AddOffset(3, RewardItemCountListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(4, Price, -1); }
  public static void AddOriginPrice(FlatBufferBuilder builder, int OriginPrice) { builder.AddInt(5, OriginPrice, -1); }
  public static void AddDiscount(FlatBufferBuilder builder, int Discount) { builder.AddInt(6, Discount, -1); }
  public static void AddMaxCount(FlatBufferBuilder builder, int MaxCount) { builder.AddInt(7, MaxCount, -1); }
  public static void AddRewardType(FlatBufferBuilder builder, int RewardType) { builder.AddInt(8, RewardType, 0); }
  public static Offset<FB_ZheKouShangDian> EndFB_ZheKouShangDian(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZheKouShangDian>(o);
  }
};

public sealed class FB_ZheKouShangDianContainer : Table {
  public static FB_ZheKouShangDianContainer GetRootAsFB_ZheKouShangDianContainer(ByteBuffer _bb) { return GetRootAsFB_ZheKouShangDianContainer(_bb, new FB_ZheKouShangDianContainer()); }
  public static FB_ZheKouShangDianContainer GetRootAsFB_ZheKouShangDianContainer(ByteBuffer _bb, FB_ZheKouShangDianContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ZheKouShangDianContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ZheKouShangDianContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ZheKouShangDian GetItems(int j) { return GetItems(new FB_ZheKouShangDian(), j); }
  public FB_ZheKouShangDian GetItems(FB_ZheKouShangDian obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ZheKouShangDianContainer> CreateFB_ZheKouShangDianContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ZheKouShangDianContainer.AddItems(builder, items);
    return FB_ZheKouShangDianContainer.EndFB_ZheKouShangDianContainer(builder);
  }

  public static void StartFB_ZheKouShangDianContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ZheKouShangDian>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ZheKouShangDianContainer> EndFB_ZheKouShangDianContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZheKouShangDianContainer>(o);
  }
  public static void FinishFB_ZheKouShangDianContainerBuffer(FlatBufferBuilder builder, Offset<FB_ZheKouShangDianContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
