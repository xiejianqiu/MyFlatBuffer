// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AuctionItem : Table {
  public static FB_AuctionItem GetRootAsFB_AuctionItem(ByteBuffer _bb) { return GetRootAsFB_AuctionItem(_bb, new FB_AuctionItem()); }
  public static FB_AuctionItem GetRootAsFB_AuctionItem(ByteBuffer _bb, FB_AuctionItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AuctionItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int BasePrice { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowPrice { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighPrice { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AuctionClass { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AuctionType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Cooldown { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_AuctionItem> CreateFB_AuctionItem(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int BasePrice = -1,
      int LowPrice = -1,
      int HighPrice = -1,
      int AuctionClass = -1,
      int AuctionType = -1,
      int Cooldown = -1) {
    builder.StartObject(8);
    FB_AuctionItem.AddCooldown(builder, Cooldown);
    FB_AuctionItem.AddAuctionType(builder, AuctionType);
    FB_AuctionItem.AddAuctionClass(builder, AuctionClass);
    FB_AuctionItem.AddHighPrice(builder, HighPrice);
    FB_AuctionItem.AddLowPrice(builder, LowPrice);
    FB_AuctionItem.AddBasePrice(builder, BasePrice);
    FB_AuctionItem.AddName(builder, Name);
    FB_AuctionItem.AddID(builder, ID);
    return FB_AuctionItem.EndFB_AuctionItem(builder);
  }

  public static void StartFB_AuctionItem(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddBasePrice(FlatBufferBuilder builder, int BasePrice) { builder.AddInt(2, BasePrice, -1); }
  public static void AddLowPrice(FlatBufferBuilder builder, int LowPrice) { builder.AddInt(3, LowPrice, -1); }
  public static void AddHighPrice(FlatBufferBuilder builder, int HighPrice) { builder.AddInt(4, HighPrice, -1); }
  public static void AddAuctionClass(FlatBufferBuilder builder, int AuctionClass) { builder.AddInt(5, AuctionClass, -1); }
  public static void AddAuctionType(FlatBufferBuilder builder, int AuctionType) { builder.AddInt(6, AuctionType, -1); }
  public static void AddCooldown(FlatBufferBuilder builder, int Cooldown) { builder.AddInt(7, Cooldown, -1); }
  public static Offset<FB_AuctionItem> EndFB_AuctionItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AuctionItem>(o);
  }
};

public sealed class FB_AuctionItemContainer : Table {
  public static FB_AuctionItemContainer GetRootAsFB_AuctionItemContainer(ByteBuffer _bb) { return GetRootAsFB_AuctionItemContainer(_bb, new FB_AuctionItemContainer()); }
  public static FB_AuctionItemContainer GetRootAsFB_AuctionItemContainer(ByteBuffer _bb, FB_AuctionItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AuctionItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AuctionItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AuctionItem GetItems(int j) { return GetItems(new FB_AuctionItem(), j); }
  public FB_AuctionItem GetItems(FB_AuctionItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AuctionItemContainer> CreateFB_AuctionItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AuctionItemContainer.AddItems(builder, items);
    return FB_AuctionItemContainer.EndFB_AuctionItemContainer(builder);
  }

  public static void StartFB_AuctionItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AuctionItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AuctionItemContainer> EndFB_AuctionItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AuctionItemContainer>(o);
  }
  public static void FinishFB_AuctionItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_AuctionItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
