// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_VipDayGift : Table {
  public static FB_VipDayGift GetRootAsFB_VipDayGift(ByteBuffer _bb) { return GetRootAsFB_VipDayGift(_bb, new FB_VipDayGift()); }
  public static FB_VipDayGift GetRootAsFB_VipDayGift(ByteBuffer _bb, FB_VipDayGift obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_VipDayGift __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Cost { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetDayGiftIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DayGiftIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDayGiftNumList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DayGiftNumListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VipDayGift> CreateFB_VipDayGift(FlatBufferBuilder builder,
      int ID = 0,
      int Cost = -1,
      VectorOffset DayGiftIDList = default(VectorOffset),
      VectorOffset DayGiftNumList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_VipDayGift.AddDayGiftNumList(builder, DayGiftNumList);
    FB_VipDayGift.AddDayGiftIDList(builder, DayGiftIDList);
    FB_VipDayGift.AddCost(builder, Cost);
    FB_VipDayGift.AddID(builder, ID);
    return FB_VipDayGift.EndFB_VipDayGift(builder);
  }

  public static void StartFB_VipDayGift(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCost(FlatBufferBuilder builder, int Cost) { builder.AddInt(1, Cost, -1); }
  public static void AddDayGiftIDList(FlatBufferBuilder builder, VectorOffset DayGiftIDListOffset) { builder.AddOffset(2, DayGiftIDListOffset.Value, 0); }
  public static VectorOffset CreateDayGiftIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDayGiftIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDayGiftNumList(FlatBufferBuilder builder, VectorOffset DayGiftNumListOffset) { builder.AddOffset(3, DayGiftNumListOffset.Value, 0); }
  public static VectorOffset CreateDayGiftNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDayGiftNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VipDayGift> EndFB_VipDayGift(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VipDayGift>(o);
  }
};

public sealed class FB_VipDayGiftContainer : Table {
  public static FB_VipDayGiftContainer GetRootAsFB_VipDayGiftContainer(ByteBuffer _bb) { return GetRootAsFB_VipDayGiftContainer(_bb, new FB_VipDayGiftContainer()); }
  public static FB_VipDayGiftContainer GetRootAsFB_VipDayGiftContainer(ByteBuffer _bb, FB_VipDayGiftContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_VipDayGiftContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_VipDayGiftContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_VipDayGift GetItems(int j) { return GetItems(new FB_VipDayGift(), j); }
  public FB_VipDayGift GetItems(FB_VipDayGift obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VipDayGiftContainer> CreateFB_VipDayGiftContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_VipDayGiftContainer.AddItems(builder, items);
    return FB_VipDayGiftContainer.EndFB_VipDayGiftContainer(builder);
  }

  public static void StartFB_VipDayGiftContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_VipDayGift>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VipDayGiftContainer> EndFB_VipDayGiftContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VipDayGiftContainer>(o);
  }
  public static void FinishFB_VipDayGiftContainerBuffer(FlatBufferBuilder builder, Offset<FB_VipDayGiftContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
