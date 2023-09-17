// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHJuBaoPenReward : Table {
  public static FB_SYHJuBaoPenReward GetRootAsFB_SYHJuBaoPenReward(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPenReward(_bb, new FB_SYHJuBaoPenReward()); }
  public static FB_SYHJuBaoPenReward GetRootAsFB_SYHJuBaoPenReward(ByteBuffer _bb, FB_SYHJuBaoPenReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHJuBaoPenReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Tips { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetItemIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemRateList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemRateListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int RealValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHJuBaoPenReward> CreateFB_SYHJuBaoPenReward(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Tips = default(StringOffset),
      VectorOffset ItemID_List = default(VectorOffset),
      VectorOffset ItemRate_List = default(VectorOffset),
      int RealValue = -1) {
    builder.StartObject(5);
    FB_SYHJuBaoPenReward.AddRealValue(builder, RealValue);
    FB_SYHJuBaoPenReward.AddItemRateList(builder, ItemRate_List);
    FB_SYHJuBaoPenReward.AddItemIDList(builder, ItemID_List);
    FB_SYHJuBaoPenReward.AddTips(builder, Tips);
    FB_SYHJuBaoPenReward.AddID(builder, ID);
    return FB_SYHJuBaoPenReward.EndFB_SYHJuBaoPenReward(builder);
  }

  public static void StartFB_SYHJuBaoPenReward(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(1, TipsOffset.Value, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(2, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemRateList(FlatBufferBuilder builder, VectorOffset ItemRateListOffset) { builder.AddOffset(3, ItemRateListOffset.Value, 0); }
  public static VectorOffset CreateItemRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRealValue(FlatBufferBuilder builder, int RealValue) { builder.AddInt(4, RealValue, -1); }
  public static Offset<FB_SYHJuBaoPenReward> EndFB_SYHJuBaoPenReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPenReward>(o);
  }
};

public sealed class FB_SYHJuBaoPenRewardContainer : Table {
  public static FB_SYHJuBaoPenRewardContainer GetRootAsFB_SYHJuBaoPenRewardContainer(ByteBuffer _bb) { return GetRootAsFB_SYHJuBaoPenRewardContainer(_bb, new FB_SYHJuBaoPenRewardContainer()); }
  public static FB_SYHJuBaoPenRewardContainer GetRootAsFB_SYHJuBaoPenRewardContainer(ByteBuffer _bb, FB_SYHJuBaoPenRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHJuBaoPenRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHJuBaoPenRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHJuBaoPenReward GetItems(int j) { return GetItems(new FB_SYHJuBaoPenReward(), j); }
  public FB_SYHJuBaoPenReward GetItems(FB_SYHJuBaoPenReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHJuBaoPenRewardContainer> CreateFB_SYHJuBaoPenRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHJuBaoPenRewardContainer.AddItems(builder, items);
    return FB_SYHJuBaoPenRewardContainer.EndFB_SYHJuBaoPenRewardContainer(builder);
  }

  public static void StartFB_SYHJuBaoPenRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPenReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHJuBaoPenRewardContainer> EndFB_SYHJuBaoPenRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHJuBaoPenRewardContainer>(o);
  }
  public static void FinishFB_SYHJuBaoPenRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHJuBaoPenRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
