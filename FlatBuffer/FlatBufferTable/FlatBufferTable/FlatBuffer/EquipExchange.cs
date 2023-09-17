// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipExchange : Table {
  public static FB_EquipExchange GetRootAsFB_EquipExchange(ByteBuffer _bb) { return GetRootAsFB_EquipExchange(_bb, new FB_EquipExchange()); }
  public static FB_EquipExchange GetRootAsFB_EquipExchange(ByteBuffer _bb, FB_EquipExchange obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipExchange __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JieLvl { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_EquipExchange> CreateFB_EquipExchange(FlatBufferBuilder builder,
      int Id = 0,
      int Type = 0,
      int JieLvl = 0,
      int Quality = 0,
      int StarCount = 0,
      int ItemId = 0,
      int ItemCount = 0) {
    builder.StartObject(7);
    FB_EquipExchange.AddItemCount(builder, ItemCount);
    FB_EquipExchange.AddItemId(builder, ItemId);
    FB_EquipExchange.AddStarCount(builder, StarCount);
    FB_EquipExchange.AddQuality(builder, Quality);
    FB_EquipExchange.AddJieLvl(builder, JieLvl);
    FB_EquipExchange.AddType(builder, Type);
    FB_EquipExchange.AddId(builder, Id);
    return FB_EquipExchange.EndFB_EquipExchange(builder);
  }

  public static void StartFB_EquipExchange(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, 0); }
  public static void AddJieLvl(FlatBufferBuilder builder, int JieLvl) { builder.AddInt(2, JieLvl, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, 0); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(4, StarCount, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(5, ItemId, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(6, ItemCount, 0); }
  public static Offset<FB_EquipExchange> EndFB_EquipExchange(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipExchange>(o);
  }
};

public sealed class FB_EquipExchangeContainer : Table {
  public static FB_EquipExchangeContainer GetRootAsFB_EquipExchangeContainer(ByteBuffer _bb) { return GetRootAsFB_EquipExchangeContainer(_bb, new FB_EquipExchangeContainer()); }
  public static FB_EquipExchangeContainer GetRootAsFB_EquipExchangeContainer(ByteBuffer _bb, FB_EquipExchangeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipExchangeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipExchangeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipExchange GetItems(int j) { return GetItems(new FB_EquipExchange(), j); }
  public FB_EquipExchange GetItems(FB_EquipExchange obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipExchangeContainer> CreateFB_EquipExchangeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipExchangeContainer.AddItems(builder, items);
    return FB_EquipExchangeContainer.EndFB_EquipExchangeContainer(builder);
  }

  public static void StartFB_EquipExchangeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipExchange>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipExchangeContainer> EndFB_EquipExchangeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipExchangeContainer>(o);
  }
  public static void FinishFB_EquipExchangeContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipExchangeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
