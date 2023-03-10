// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_VipEnjoyGift : Table {
  public static FB_VipEnjoyGift GetRootAsFB_VipEnjoyGift(ByteBuffer _bb) { return GetRootAsFB_VipEnjoyGift(_bb, new FB_VipEnjoyGift()); }
  public static FB_VipEnjoyGift GetRootAsFB_VipEnjoyGift(ByteBuffer _bb, FB_VipEnjoyGift obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_VipEnjoyGift __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OriginalCost { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RealCost { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetEnjoyGiftIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EnjoyGiftIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetEnjoyGiftNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EnjoyGiftNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VipEnjoyGift> CreateFB_VipEnjoyGift(FlatBufferBuilder builder,
      int ID = 0,
      int OriginalCost = -1,
      int RealCost = -1,
      VectorOffset EnjoyGiftIDList = default(VectorOffset),
      VectorOffset EnjoyGiftNumList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_VipEnjoyGift.AddEnjoyGiftNumList(builder, EnjoyGiftNumList);
    FB_VipEnjoyGift.AddEnjoyGiftIDList(builder, EnjoyGiftIDList);
    FB_VipEnjoyGift.AddRealCost(builder, RealCost);
    FB_VipEnjoyGift.AddOriginalCost(builder, OriginalCost);
    FB_VipEnjoyGift.AddID(builder, ID);
    return FB_VipEnjoyGift.EndFB_VipEnjoyGift(builder);
  }

  public static void StartFB_VipEnjoyGift(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddOriginalCost(FlatBufferBuilder builder, int OriginalCost) { builder.AddInt(1, OriginalCost, -1); }
  public static void AddRealCost(FlatBufferBuilder builder, int RealCost) { builder.AddInt(2, RealCost, -1); }
  public static void AddEnjoyGiftIDList(FlatBufferBuilder builder, VectorOffset EnjoyGiftIDListOffset) { builder.AddOffset(3, EnjoyGiftIDListOffset.Value, 0); }
  public static VectorOffset CreateEnjoyGiftIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEnjoyGiftIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEnjoyGiftNumList(FlatBufferBuilder builder, VectorOffset EnjoyGiftNumListOffset) { builder.AddOffset(4, EnjoyGiftNumListOffset.Value, 0); }
  public static VectorOffset CreateEnjoyGiftNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEnjoyGiftNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VipEnjoyGift> EndFB_VipEnjoyGift(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VipEnjoyGift>(o);
  }
};

public sealed class FB_VipEnjoyGiftContainer : Table {
  public static FB_VipEnjoyGiftContainer GetRootAsFB_VipEnjoyGiftContainer(ByteBuffer _bb) { return GetRootAsFB_VipEnjoyGiftContainer(_bb, new FB_VipEnjoyGiftContainer()); }
  public static FB_VipEnjoyGiftContainer GetRootAsFB_VipEnjoyGiftContainer(ByteBuffer _bb, FB_VipEnjoyGiftContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_VipEnjoyGiftContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_VipEnjoyGiftContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_VipEnjoyGift GetItems(int j) { return GetItems(new FB_VipEnjoyGift(), j); }
  public FB_VipEnjoyGift GetItems(FB_VipEnjoyGift obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_VipEnjoyGiftContainer> CreateFB_VipEnjoyGiftContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_VipEnjoyGiftContainer.AddItems(builder, items);
    return FB_VipEnjoyGiftContainer.EndFB_VipEnjoyGiftContainer(builder);
  }

  public static void StartFB_VipEnjoyGiftContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_VipEnjoyGift>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_VipEnjoyGiftContainer> EndFB_VipEnjoyGiftContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_VipEnjoyGiftContainer>(o);
  }
  public static void FinishFB_VipEnjoyGiftContainerBuffer(FlatBufferBuilder builder, Offset<FB_VipEnjoyGiftContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
