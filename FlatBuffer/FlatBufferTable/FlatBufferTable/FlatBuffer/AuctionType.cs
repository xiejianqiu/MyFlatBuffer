// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AuctionType : Table {
  public static FB_AuctionType GetRootAsFB_AuctionType(ByteBuffer _bb) { return GetRootAsFB_AuctionType(_bb, new FB_AuctionType()); }
  public static FB_AuctionType GetRootAsFB_AuctionType(ByteBuffer _bb, FB_AuctionType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AuctionType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Icon { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowOrder { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int Menpai { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetOrderList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OrderListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AuctionType> CreateFB_AuctionType(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Icon = -1,
      bool IsShowOrder = false,
      int Menpai = -1,
      int Component = -1,
      VectorOffset OrderList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_AuctionType.AddOrderList(builder, OrderList);
    FB_AuctionType.AddComponent(builder, Component);
    FB_AuctionType.AddMenpai(builder, Menpai);
    FB_AuctionType.AddIcon(builder, Icon);
    FB_AuctionType.AddName(builder, Name);
    FB_AuctionType.AddID(builder, ID);
    FB_AuctionType.AddIsShowOrder(builder, IsShowOrder);
    return FB_AuctionType.EndFB_AuctionType(builder);
  }

  public static void StartFB_AuctionType(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, int Icon) { builder.AddInt(2, Icon, -1); }
  public static void AddIsShowOrder(FlatBufferBuilder builder, bool IsShowOrder) { builder.AddBool(3, IsShowOrder, false); }
  public static void AddMenpai(FlatBufferBuilder builder, int Menpai) { builder.AddInt(4, Menpai, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(5, Component, -1); }
  public static void AddOrderList(FlatBufferBuilder builder, VectorOffset OrderListOffset) { builder.AddOffset(6, OrderListOffset.Value, 0); }
  public static VectorOffset CreateOrderListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOrderListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AuctionType> EndFB_AuctionType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AuctionType>(o);
  }
};

public sealed class FB_AuctionTypeContainer : Table {
  public static FB_AuctionTypeContainer GetRootAsFB_AuctionTypeContainer(ByteBuffer _bb) { return GetRootAsFB_AuctionTypeContainer(_bb, new FB_AuctionTypeContainer()); }
  public static FB_AuctionTypeContainer GetRootAsFB_AuctionTypeContainer(ByteBuffer _bb, FB_AuctionTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AuctionTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AuctionTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AuctionType GetItems(int j) { return GetItems(new FB_AuctionType(), j); }
  public FB_AuctionType GetItems(FB_AuctionType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AuctionTypeContainer> CreateFB_AuctionTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AuctionTypeContainer.AddItems(builder, items);
    return FB_AuctionTypeContainer.EndFB_AuctionTypeContainer(builder);
  }

  public static void StartFB_AuctionTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AuctionType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AuctionTypeContainer> EndFB_AuctionTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AuctionTypeContainer>(o);
  }
  public static void FinishFB_AuctionTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_AuctionTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
