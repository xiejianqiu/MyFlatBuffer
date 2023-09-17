// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TiKuanJiAward : Table {
  public static FB_TiKuanJiAward GetRootAsFB_TiKuanJiAward(ByteBuffer _bb) { return GetRootAsFB_TiKuanJiAward(_bb, new FB_TiKuanJiAward()); }
  public static FB_TiKuanJiAward GetRootAsFB_TiKuanJiAward(ByteBuffer _bb, FB_TiKuanJiAward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TiKuanJiAward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Price { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Money { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExtraMoney { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TiKuanJiAward> CreateFB_TiKuanJiAward(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Price = -1,
      int Money = -1,
      int ExtraMoney = -1) {
    builder.StartObject(6);
    FB_TiKuanJiAward.AddExtraMoney(builder, ExtraMoney);
    FB_TiKuanJiAward.AddMoney(builder, Money);
    FB_TiKuanJiAward.AddPrice(builder, Price);
    FB_TiKuanJiAward.AddIcon(builder, Icon);
    FB_TiKuanJiAward.AddName(builder, Name);
    FB_TiKuanJiAward.AddID(builder, ID);
    return FB_TiKuanJiAward.EndFB_TiKuanJiAward(builder);
  }

  public static void StartFB_TiKuanJiAward(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(3, Price, -1); }
  public static void AddMoney(FlatBufferBuilder builder, int Money) { builder.AddInt(4, Money, -1); }
  public static void AddExtraMoney(FlatBufferBuilder builder, int ExtraMoney) { builder.AddInt(5, ExtraMoney, -1); }
  public static Offset<FB_TiKuanJiAward> EndFB_TiKuanJiAward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TiKuanJiAward>(o);
  }
};

public sealed class FB_TiKuanJiAwardContainer : Table {
  public static FB_TiKuanJiAwardContainer GetRootAsFB_TiKuanJiAwardContainer(ByteBuffer _bb) { return GetRootAsFB_TiKuanJiAwardContainer(_bb, new FB_TiKuanJiAwardContainer()); }
  public static FB_TiKuanJiAwardContainer GetRootAsFB_TiKuanJiAwardContainer(ByteBuffer _bb, FB_TiKuanJiAwardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TiKuanJiAwardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TiKuanJiAwardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TiKuanJiAward GetItems(int j) { return GetItems(new FB_TiKuanJiAward(), j); }
  public FB_TiKuanJiAward GetItems(FB_TiKuanJiAward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TiKuanJiAwardContainer> CreateFB_TiKuanJiAwardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TiKuanJiAwardContainer.AddItems(builder, items);
    return FB_TiKuanJiAwardContainer.EndFB_TiKuanJiAwardContainer(builder);
  }

  public static void StartFB_TiKuanJiAwardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TiKuanJiAward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TiKuanJiAwardContainer> EndFB_TiKuanJiAwardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TiKuanJiAwardContainer>(o);
  }
  public static void FinishFB_TiKuanJiAwardContainerBuffer(FlatBufferBuilder builder, Offset<FB_TiKuanJiAwardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
