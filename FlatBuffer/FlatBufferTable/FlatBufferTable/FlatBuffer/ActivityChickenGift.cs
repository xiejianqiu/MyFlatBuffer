// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityChickenGift : Table {
  public static FB_ActivityChickenGift GetRootAsFB_ActivityChickenGift(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenGift(_bb, new FB_ActivityChickenGift()); }
  public static FB_ActivityChickenGift GetRootAsFB_ActivityChickenGift(ByteBuffer _bb, FB_ActivityChickenGift obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityChickenGift __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DicId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BonusIndex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Score { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityChickenGift> CreateFB_ActivityChickenGift(FlatBufferBuilder builder,
      int ID = 0,
      int DicId = -1,
      int BonusIndex = -1,
      int Score = -1) {
    builder.StartObject(4);
    FB_ActivityChickenGift.AddScore(builder, Score);
    FB_ActivityChickenGift.AddBonusIndex(builder, BonusIndex);
    FB_ActivityChickenGift.AddDicId(builder, DicId);
    FB_ActivityChickenGift.AddID(builder, ID);
    return FB_ActivityChickenGift.EndFB_ActivityChickenGift(builder);
  }

  public static void StartFB_ActivityChickenGift(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(1, DicId, -1); }
  public static void AddBonusIndex(FlatBufferBuilder builder, int BonusIndex) { builder.AddInt(2, BonusIndex, -1); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(3, Score, -1); }
  public static Offset<FB_ActivityChickenGift> EndFB_ActivityChickenGift(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenGift>(o);
  }
};

public sealed class FB_ActivityChickenGiftContainer : Table {
  public static FB_ActivityChickenGiftContainer GetRootAsFB_ActivityChickenGiftContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenGiftContainer(_bb, new FB_ActivityChickenGiftContainer()); }
  public static FB_ActivityChickenGiftContainer GetRootAsFB_ActivityChickenGiftContainer(ByteBuffer _bb, FB_ActivityChickenGiftContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityChickenGiftContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityChickenGiftContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityChickenGift GetItems(int j) { return GetItems(new FB_ActivityChickenGift(), j); }
  public FB_ActivityChickenGift GetItems(FB_ActivityChickenGift obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityChickenGiftContainer> CreateFB_ActivityChickenGiftContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityChickenGiftContainer.AddItems(builder, items);
    return FB_ActivityChickenGiftContainer.EndFB_ActivityChickenGiftContainer(builder);
  }

  public static void StartFB_ActivityChickenGiftContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityChickenGift>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityChickenGiftContainer> EndFB_ActivityChickenGiftContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenGiftContainer>(o);
  }
  public static void FinishFB_ActivityChickenGiftContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityChickenGiftContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
