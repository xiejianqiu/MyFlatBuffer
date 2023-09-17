// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WishBase : Table {
  public static FB_WishBase GetRootAsFB_WishBase(ByteBuffer _bb) { return GetRootAsFB_WishBase(_bb, new FB_WishBase()); }
  public static FB_WishBase GetRootAsFB_WishBase(ByteBuffer _bb, FB_WishBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WishBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetConsumMoneyList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ConsumMoneyListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int AwardMoney { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GratisCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Addition { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int AdditionCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WishBase> CreateFB_WishBase(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset ConsumMoneyList = default(VectorOffset),
      int AwardMoney = -1,
      int GratisCount = -1,
      float Addition = 0,
      int AdditionCount = -1) {
    builder.StartObject(6);
    FB_WishBase.AddAdditionCount(builder, AdditionCount);
    FB_WishBase.AddAddition(builder, Addition);
    FB_WishBase.AddGratisCount(builder, GratisCount);
    FB_WishBase.AddAwardMoney(builder, AwardMoney);
    FB_WishBase.AddConsumMoneyList(builder, ConsumMoneyList);
    FB_WishBase.AddID(builder, ID);
    return FB_WishBase.EndFB_WishBase(builder);
  }

  public static void StartFB_WishBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddConsumMoneyList(FlatBufferBuilder builder, VectorOffset ConsumMoneyListOffset) { builder.AddOffset(1, ConsumMoneyListOffset.Value, 0); }
  public static VectorOffset CreateConsumMoneyListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartConsumMoneyListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAwardMoney(FlatBufferBuilder builder, int AwardMoney) { builder.AddInt(2, AwardMoney, -1); }
  public static void AddGratisCount(FlatBufferBuilder builder, int GratisCount) { builder.AddInt(3, GratisCount, -1); }
  public static void AddAddition(FlatBufferBuilder builder, float Addition) { builder.AddFloat(4, Addition, 0); }
  public static void AddAdditionCount(FlatBufferBuilder builder, int AdditionCount) { builder.AddInt(5, AdditionCount, -1); }
  public static Offset<FB_WishBase> EndFB_WishBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WishBase>(o);
  }
};

public sealed class FB_WishBaseContainer : Table {
  public static FB_WishBaseContainer GetRootAsFB_WishBaseContainer(ByteBuffer _bb) { return GetRootAsFB_WishBaseContainer(_bb, new FB_WishBaseContainer()); }
  public static FB_WishBaseContainer GetRootAsFB_WishBaseContainer(ByteBuffer _bb, FB_WishBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WishBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WishBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WishBase GetItems(int j) { return GetItems(new FB_WishBase(), j); }
  public FB_WishBase GetItems(FB_WishBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WishBaseContainer> CreateFB_WishBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WishBaseContainer.AddItems(builder, items);
    return FB_WishBaseContainer.EndFB_WishBaseContainer(builder);
  }

  public static void StartFB_WishBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WishBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WishBaseContainer> EndFB_WishBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WishBaseContainer>(o);
  }
  public static void FinishFB_WishBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_WishBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
