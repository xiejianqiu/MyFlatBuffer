// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_YunGou : Table {
  public static FB_YunGou GetRootAsFB_YunGou(ByteBuffer _bb) { return GetRootAsFB_YunGou(_bb, new FB_YunGou()); }
  public static FB_YunGou GetRootAsFB_YunGou(ByteBuffer _bb, FB_YunGou obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_YunGou __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Price { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetRewardByJobList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardByJobListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardRateList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardRateListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int FirstBuyRewardId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FirstBuyRewardNum { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetFirstRewardByJobList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FirstRewardByJobListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSecRewardByJobList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SecRewardByJobListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public string FirstPrice { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SecPrice { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_YunGou> CreateFB_YunGou(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Price = default(StringOffset),
      VectorOffset RewardByJobList = default(VectorOffset),
      VectorOffset RewardList = default(VectorOffset),
      VectorOffset RewardNumList = default(VectorOffset),
      VectorOffset RewardRate_List = default(VectorOffset),
      int FirstBuyRewardId = -1,
      int FirstBuyRewardNum = -1,
      VectorOffset FirstRewardByJobList = default(VectorOffset),
      VectorOffset SecRewardByJobList = default(VectorOffset),
      StringOffset FirstPrice = default(StringOffset),
      StringOffset SecPrice = default(StringOffset)) {
    builder.StartObject(12);
    FB_YunGou.AddSecPrice(builder, SecPrice);
    FB_YunGou.AddFirstPrice(builder, FirstPrice);
    FB_YunGou.AddSecRewardByJobList(builder, SecRewardByJobList);
    FB_YunGou.AddFirstRewardByJobList(builder, FirstRewardByJobList);
    FB_YunGou.AddFirstBuyRewardNum(builder, FirstBuyRewardNum);
    FB_YunGou.AddFirstBuyRewardId(builder, FirstBuyRewardId);
    FB_YunGou.AddRewardRateList(builder, RewardRate_List);
    FB_YunGou.AddRewardNumList(builder, RewardNumList);
    FB_YunGou.AddRewardList(builder, RewardList);
    FB_YunGou.AddRewardByJobList(builder, RewardByJobList);
    FB_YunGou.AddPrice(builder, Price);
    FB_YunGou.AddID(builder, ID);
    return FB_YunGou.EndFB_YunGou(builder);
  }

  public static void StartFB_YunGou(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPrice(FlatBufferBuilder builder, StringOffset PriceOffset) { builder.AddOffset(1, PriceOffset.Value, 0); }
  public static void AddRewardByJobList(FlatBufferBuilder builder, VectorOffset RewardByJobListOffset) { builder.AddOffset(2, RewardByJobListOffset.Value, 0); }
  public static VectorOffset CreateRewardByJobListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardByJobListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset RewardListOffset) { builder.AddOffset(3, RewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardNumList(FlatBufferBuilder builder, VectorOffset RewardNumListOffset) { builder.AddOffset(4, RewardNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardRateList(FlatBufferBuilder builder, VectorOffset RewardRateListOffset) { builder.AddOffset(5, RewardRateListOffset.Value, 0); }
  public static VectorOffset CreateRewardRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFirstBuyRewardId(FlatBufferBuilder builder, int FirstBuyRewardId) { builder.AddInt(6, FirstBuyRewardId, -1); }
  public static void AddFirstBuyRewardNum(FlatBufferBuilder builder, int FirstBuyRewardNum) { builder.AddInt(7, FirstBuyRewardNum, -1); }
  public static void AddFirstRewardByJobList(FlatBufferBuilder builder, VectorOffset FirstRewardByJobListOffset) { builder.AddOffset(8, FirstRewardByJobListOffset.Value, 0); }
  public static VectorOffset CreateFirstRewardByJobListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFirstRewardByJobListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSecRewardByJobList(FlatBufferBuilder builder, VectorOffset SecRewardByJobListOffset) { builder.AddOffset(9, SecRewardByJobListOffset.Value, 0); }
  public static VectorOffset CreateSecRewardByJobListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSecRewardByJobListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFirstPrice(FlatBufferBuilder builder, StringOffset FirstPriceOffset) { builder.AddOffset(10, FirstPriceOffset.Value, 0); }
  public static void AddSecPrice(FlatBufferBuilder builder, StringOffset SecPriceOffset) { builder.AddOffset(11, SecPriceOffset.Value, 0); }
  public static Offset<FB_YunGou> EndFB_YunGou(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YunGou>(o);
  }
};

public sealed class FB_YunGouContainer : Table {
  public static FB_YunGouContainer GetRootAsFB_YunGouContainer(ByteBuffer _bb) { return GetRootAsFB_YunGouContainer(_bb, new FB_YunGouContainer()); }
  public static FB_YunGouContainer GetRootAsFB_YunGouContainer(ByteBuffer _bb, FB_YunGouContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_YunGouContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_YunGouContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_YunGou GetItems(int j) { return GetItems(new FB_YunGou(), j); }
  public FB_YunGou GetItems(FB_YunGou obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YunGouContainer> CreateFB_YunGouContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_YunGouContainer.AddItems(builder, items);
    return FB_YunGouContainer.EndFB_YunGouContainer(builder);
  }

  public static void StartFB_YunGouContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_YunGou>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_YunGouContainer> EndFB_YunGouContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YunGouContainer>(o);
  }
  public static void FinishFB_YunGouContainerBuffer(FlatBufferBuilder builder, Offset<FB_YunGouContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
