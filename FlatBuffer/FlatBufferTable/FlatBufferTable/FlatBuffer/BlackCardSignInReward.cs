// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BlackCardSignInReward : Table {
  public static FB_BlackCardSignInReward GetRootAsFB_BlackCardSignInReward(ByteBuffer _bb) { return GetRootAsFB_BlackCardSignInReward(_bb, new FB_BlackCardSignInReward()); }
  public static FB_BlackCardSignInReward GetRootAsFB_BlackCardSignInReward(ByteBuffer _bb, FB_BlackCardSignInReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BlackCardSignInReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Days { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int TotalItemID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TotalItemNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BlackCardSignInReward> CreateFB_BlackCardSignInReward(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      int Days = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int TotalItemID = -1,
      int TotalItemNum = -1) {
    builder.StartObject(7);
    FB_BlackCardSignInReward.AddTotalItemNum(builder, TotalItemNum);
    FB_BlackCardSignInReward.AddTotalItemID(builder, TotalItemID);
    FB_BlackCardSignInReward.AddItemNumList(builder, ItemNumList);
    FB_BlackCardSignInReward.AddItemIDList(builder, ItemIDList);
    FB_BlackCardSignInReward.AddDays(builder, Days);
    FB_BlackCardSignInReward.AddType(builder, Type);
    FB_BlackCardSignInReward.AddID(builder, ID);
    return FB_BlackCardSignInReward.EndFB_BlackCardSignInReward(builder);
  }

  public static void StartFB_BlackCardSignInReward(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddDays(FlatBufferBuilder builder, int Days) { builder.AddInt(2, Days, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(3, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(4, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddTotalItemID(FlatBufferBuilder builder, int TotalItemID) { builder.AddInt(5, TotalItemID, -1); }
  public static void AddTotalItemNum(FlatBufferBuilder builder, int TotalItemNum) { builder.AddInt(6, TotalItemNum, -1); }
  public static Offset<FB_BlackCardSignInReward> EndFB_BlackCardSignInReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BlackCardSignInReward>(o);
  }
};

public sealed class FB_BlackCardSignInRewardContainer : Table {
  public static FB_BlackCardSignInRewardContainer GetRootAsFB_BlackCardSignInRewardContainer(ByteBuffer _bb) { return GetRootAsFB_BlackCardSignInRewardContainer(_bb, new FB_BlackCardSignInRewardContainer()); }
  public static FB_BlackCardSignInRewardContainer GetRootAsFB_BlackCardSignInRewardContainer(ByteBuffer _bb, FB_BlackCardSignInRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BlackCardSignInRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BlackCardSignInRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BlackCardSignInReward GetItems(int j) { return GetItems(new FB_BlackCardSignInReward(), j); }
  public FB_BlackCardSignInReward GetItems(FB_BlackCardSignInReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BlackCardSignInRewardContainer> CreateFB_BlackCardSignInRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BlackCardSignInRewardContainer.AddItems(builder, items);
    return FB_BlackCardSignInRewardContainer.EndFB_BlackCardSignInRewardContainer(builder);
  }

  public static void StartFB_BlackCardSignInRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BlackCardSignInReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BlackCardSignInRewardContainer> EndFB_BlackCardSignInRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BlackCardSignInRewardContainer>(o);
  }
  public static void FinishFB_BlackCardSignInRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_BlackCardSignInRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
