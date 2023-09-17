// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CardShop : Table {
  public static FB_CardShop GetRootAsFB_CardShop(ByteBuffer _bb) { return GetRootAsFB_CardShop(_bb, new FB_CardShop()); }
  public static FB_CardShop GetRootAsFB_CardShop(ByteBuffer _bb, FB_CardShop obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CardShop __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DropboxID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayGold { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CardShop> CreateFB_CardShop(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int DropboxID = -1,
      int GoldType = -1,
      int PayGold = -1) {
    builder.StartObject(5);
    FB_CardShop.AddPayGold(builder, PayGold);
    FB_CardShop.AddGoldType(builder, GoldType);
    FB_CardShop.AddDropboxID(builder, DropboxID);
    FB_CardShop.AddName(builder, Name);
    FB_CardShop.AddID(builder, ID);
    return FB_CardShop.EndFB_CardShop(builder);
  }

  public static void StartFB_CardShop(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDropboxID(FlatBufferBuilder builder, int DropboxID) { builder.AddInt(2, DropboxID, -1); }
  public static void AddGoldType(FlatBufferBuilder builder, int GoldType) { builder.AddInt(3, GoldType, -1); }
  public static void AddPayGold(FlatBufferBuilder builder, int PayGold) { builder.AddInt(4, PayGold, -1); }
  public static Offset<FB_CardShop> EndFB_CardShop(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardShop>(o);
  }
};

public sealed class FB_CardShopContainer : Table {
  public static FB_CardShopContainer GetRootAsFB_CardShopContainer(ByteBuffer _bb) { return GetRootAsFB_CardShopContainer(_bb, new FB_CardShopContainer()); }
  public static FB_CardShopContainer GetRootAsFB_CardShopContainer(ByteBuffer _bb, FB_CardShopContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CardShopContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CardShopContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CardShop GetItems(int j) { return GetItems(new FB_CardShop(), j); }
  public FB_CardShop GetItems(FB_CardShop obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardShopContainer> CreateFB_CardShopContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CardShopContainer.AddItems(builder, items);
    return FB_CardShopContainer.EndFB_CardShopContainer(builder);
  }

  public static void StartFB_CardShopContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CardShop>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardShopContainer> EndFB_CardShopContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardShopContainer>(o);
  }
  public static void FinishFB_CardShopContainerBuffer(FlatBufferBuilder builder, Offset<FB_CardShopContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
