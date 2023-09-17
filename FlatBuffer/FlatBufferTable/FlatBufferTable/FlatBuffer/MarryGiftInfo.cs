// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryGiftInfo : Table {
  public static FB_MarryGiftInfo GetRootAsFB_MarryGiftInfo(ByteBuffer _bb) { return GetRootAsFB_MarryGiftInfo(_bb, new FB_MarryGiftInfo()); }
  public static FB_MarryGiftInfo GetRootAsFB_MarryGiftInfo(ByteBuffer _bb, FB_MarryGiftInfo obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryGiftInfo __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GoldType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GoldNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemFastId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemFastNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemSignId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemSignNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EffectiveDays { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_MarryGiftInfo> CreateFB_MarryGiftInfo(FlatBufferBuilder builder,
      int ID = 0,
      int GoldType = 0,
      int GoldNum = 0,
      int ItemFastId = 0,
      int ItemFastNum = 0,
      int ItemSignId = 0,
      int ItemSignNum = 0,
      int EffectiveDays = 0) {
    builder.StartObject(8);
    FB_MarryGiftInfo.AddEffectiveDays(builder, EffectiveDays);
    FB_MarryGiftInfo.AddItemSignNum(builder, ItemSignNum);
    FB_MarryGiftInfo.AddItemSignId(builder, ItemSignId);
    FB_MarryGiftInfo.AddItemFastNum(builder, ItemFastNum);
    FB_MarryGiftInfo.AddItemFastId(builder, ItemFastId);
    FB_MarryGiftInfo.AddGoldNum(builder, GoldNum);
    FB_MarryGiftInfo.AddGoldType(builder, GoldType);
    FB_MarryGiftInfo.AddID(builder, ID);
    return FB_MarryGiftInfo.EndFB_MarryGiftInfo(builder);
  }

  public static void StartFB_MarryGiftInfo(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGoldType(FlatBufferBuilder builder, int GoldType) { builder.AddInt(1, GoldType, 0); }
  public static void AddGoldNum(FlatBufferBuilder builder, int GoldNum) { builder.AddInt(2, GoldNum, 0); }
  public static void AddItemFastId(FlatBufferBuilder builder, int ItemFastId) { builder.AddInt(3, ItemFastId, 0); }
  public static void AddItemFastNum(FlatBufferBuilder builder, int ItemFastNum) { builder.AddInt(4, ItemFastNum, 0); }
  public static void AddItemSignId(FlatBufferBuilder builder, int ItemSignId) { builder.AddInt(5, ItemSignId, 0); }
  public static void AddItemSignNum(FlatBufferBuilder builder, int ItemSignNum) { builder.AddInt(6, ItemSignNum, 0); }
  public static void AddEffectiveDays(FlatBufferBuilder builder, int EffectiveDays) { builder.AddInt(7, EffectiveDays, 0); }
  public static Offset<FB_MarryGiftInfo> EndFB_MarryGiftInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryGiftInfo>(o);
  }
};

public sealed class FB_MarryGiftInfoContainer : Table {
  public static FB_MarryGiftInfoContainer GetRootAsFB_MarryGiftInfoContainer(ByteBuffer _bb) { return GetRootAsFB_MarryGiftInfoContainer(_bb, new FB_MarryGiftInfoContainer()); }
  public static FB_MarryGiftInfoContainer GetRootAsFB_MarryGiftInfoContainer(ByteBuffer _bb, FB_MarryGiftInfoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryGiftInfoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryGiftInfoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryGiftInfo GetItems(int j) { return GetItems(new FB_MarryGiftInfo(), j); }
  public FB_MarryGiftInfo GetItems(FB_MarryGiftInfo obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryGiftInfoContainer> CreateFB_MarryGiftInfoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryGiftInfoContainer.AddItems(builder, items);
    return FB_MarryGiftInfoContainer.EndFB_MarryGiftInfoContainer(builder);
  }

  public static void StartFB_MarryGiftInfoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryGiftInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryGiftInfoContainer> EndFB_MarryGiftInfoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryGiftInfoContainer>(o);
  }
  public static void FinishFB_MarryGiftInfoContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryGiftInfoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
