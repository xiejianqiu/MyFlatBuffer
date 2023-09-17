// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MondayLuckDrawItem : Table {
  public static FB_MondayLuckDrawItem GetRootAsFB_MondayLuckDrawItem(ByteBuffer _bb) { return GetRootAsFB_MondayLuckDrawItem(_bb, new FB_MondayLuckDrawItem()); }
  public static FB_MondayLuckDrawItem GetRootAsFB_MondayLuckDrawItem(ByteBuffer _bb, FB_MondayLuckDrawItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MondayLuckDrawItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Weight { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CountLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MDId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ShowNewMDId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_MondayLuckDrawItem> CreateFB_MondayLuckDrawItem(FlatBufferBuilder builder,
      int ID = 0,
      int ItemCount = 0,
      int RewardType = 0,
      int Weight = 0,
      int UnlockLevel = 0,
      int CountLimit = 0,
      int MDId = 0,
      int ShowNewMDId = 0) {
    builder.StartObject(8);
    FB_MondayLuckDrawItem.AddShowNewMDId(builder, ShowNewMDId);
    FB_MondayLuckDrawItem.AddMDId(builder, MDId);
    FB_MondayLuckDrawItem.AddCountLimit(builder, CountLimit);
    FB_MondayLuckDrawItem.AddUnlockLevel(builder, UnlockLevel);
    FB_MondayLuckDrawItem.AddWeight(builder, Weight);
    FB_MondayLuckDrawItem.AddRewardType(builder, RewardType);
    FB_MondayLuckDrawItem.AddItemCount(builder, ItemCount);
    FB_MondayLuckDrawItem.AddID(builder, ID);
    return FB_MondayLuckDrawItem.EndFB_MondayLuckDrawItem(builder);
  }

  public static void StartFB_MondayLuckDrawItem(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(1, ItemCount, 0); }
  public static void AddRewardType(FlatBufferBuilder builder, int RewardType) { builder.AddInt(2, RewardType, 0); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(3, Weight, 0); }
  public static void AddUnlockLevel(FlatBufferBuilder builder, int UnlockLevel) { builder.AddInt(4, UnlockLevel, 0); }
  public static void AddCountLimit(FlatBufferBuilder builder, int CountLimit) { builder.AddInt(5, CountLimit, 0); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(6, MDId, 0); }
  public static void AddShowNewMDId(FlatBufferBuilder builder, int ShowNewMDId) { builder.AddInt(7, ShowNewMDId, 0); }
  public static Offset<FB_MondayLuckDrawItem> EndFB_MondayLuckDrawItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MondayLuckDrawItem>(o);
  }
};

public sealed class FB_MondayLuckDrawItemContainer : Table {
  public static FB_MondayLuckDrawItemContainer GetRootAsFB_MondayLuckDrawItemContainer(ByteBuffer _bb) { return GetRootAsFB_MondayLuckDrawItemContainer(_bb, new FB_MondayLuckDrawItemContainer()); }
  public static FB_MondayLuckDrawItemContainer GetRootAsFB_MondayLuckDrawItemContainer(ByteBuffer _bb, FB_MondayLuckDrawItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MondayLuckDrawItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MondayLuckDrawItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MondayLuckDrawItem GetItems(int j) { return GetItems(new FB_MondayLuckDrawItem(), j); }
  public FB_MondayLuckDrawItem GetItems(FB_MondayLuckDrawItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MondayLuckDrawItemContainer> CreateFB_MondayLuckDrawItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MondayLuckDrawItemContainer.AddItems(builder, items);
    return FB_MondayLuckDrawItemContainer.EndFB_MondayLuckDrawItemContainer(builder);
  }

  public static void StartFB_MondayLuckDrawItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MondayLuckDrawItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MondayLuckDrawItemContainer> EndFB_MondayLuckDrawItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MondayLuckDrawItemContainer>(o);
  }
  public static void FinishFB_MondayLuckDrawItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_MondayLuckDrawItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
