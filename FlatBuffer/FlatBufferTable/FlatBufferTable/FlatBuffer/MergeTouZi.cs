// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MergeTouZi : Table {
  public static FB_MergeTouZi GetRootAsFB_MergeTouZi(ByteBuffer _bb) { return GetRootAsFB_MergeTouZi(_bb, new FB_MergeTouZi()); }
  public static FB_MergeTouZi GetRootAsFB_MergeTouZi(ByteBuffer _bb, FB_MergeTouZi obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MergeTouZi __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int RewardDay { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MergeTouZi> CreateFB_MergeTouZi(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int RewardDay = 0,
      int MoneyNum = 0,
      int StrId = -1) {
    builder.StartObject(5);
    FB_MergeTouZi.AddStrId(builder, StrId);
    FB_MergeTouZi.AddMoneyNum(builder, MoneyNum);
    FB_MergeTouZi.AddRewardDay(builder, RewardDay);
    FB_MergeTouZi.AddName(builder, Name);
    FB_MergeTouZi.AddID(builder, ID);
    return FB_MergeTouZi.EndFB_MergeTouZi(builder);
  }

  public static void StartFB_MergeTouZi(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddRewardDay(FlatBufferBuilder builder, int RewardDay) { builder.AddInt(2, RewardDay, 0); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(3, MoneyNum, 0); }
  public static void AddStrId(FlatBufferBuilder builder, int StrId) { builder.AddInt(4, StrId, -1); }
  public static Offset<FB_MergeTouZi> EndFB_MergeTouZi(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeTouZi>(o);
  }
};

public sealed class FB_MergeTouZiContainer : Table {
  public static FB_MergeTouZiContainer GetRootAsFB_MergeTouZiContainer(ByteBuffer _bb) { return GetRootAsFB_MergeTouZiContainer(_bb, new FB_MergeTouZiContainer()); }
  public static FB_MergeTouZiContainer GetRootAsFB_MergeTouZiContainer(ByteBuffer _bb, FB_MergeTouZiContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MergeTouZiContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MergeTouZiContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MergeTouZi GetItems(int j) { return GetItems(new FB_MergeTouZi(), j); }
  public FB_MergeTouZi GetItems(FB_MergeTouZi obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MergeTouZiContainer> CreateFB_MergeTouZiContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MergeTouZiContainer.AddItems(builder, items);
    return FB_MergeTouZiContainer.EndFB_MergeTouZiContainer(builder);
  }

  public static void StartFB_MergeTouZiContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MergeTouZi>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MergeTouZiContainer> EndFB_MergeTouZiContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeTouZiContainer>(o);
  }
  public static void FinishFB_MergeTouZiContainerBuffer(FlatBufferBuilder builder, Offset<FB_MergeTouZiContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
