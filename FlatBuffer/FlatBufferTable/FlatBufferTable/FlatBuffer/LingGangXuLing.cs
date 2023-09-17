// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingGangXuLing : Table {
  public static FB_LingGangXuLing GetRootAsFB_LingGangXuLing(ByteBuffer _bb) { return GetRootAsFB_LingGangXuLing(_bb, new FB_LingGangXuLing()); }
  public static FB_LingGangXuLing GetRootAsFB_LingGangXuLing(ByteBuffer _bb, FB_LingGangXuLing obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingGangXuLing __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitStep { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SureSucceedMoney { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Rate { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CriticalRate { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CriticalAddLv { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangXuLing> CreateFB_LingGangXuLing(FlatBufferBuilder builder,
      int Id = 0,
      int LimitStep = -1,
      int ItemId = -1,
      int ItemCount = -1,
      int SureSucceedMoney = -1,
      int Rate = -1,
      int CriticalRate = -1,
      int CriticalAddLv = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_LingGangXuLing.AddAttrValueList(builder, AttrValueList);
    FB_LingGangXuLing.AddAttrIdList(builder, AttrIdList);
    FB_LingGangXuLing.AddCriticalAddLv(builder, CriticalAddLv);
    FB_LingGangXuLing.AddCriticalRate(builder, CriticalRate);
    FB_LingGangXuLing.AddRate(builder, Rate);
    FB_LingGangXuLing.AddSureSucceedMoney(builder, SureSucceedMoney);
    FB_LingGangXuLing.AddItemCount(builder, ItemCount);
    FB_LingGangXuLing.AddItemId(builder, ItemId);
    FB_LingGangXuLing.AddLimitStep(builder, LimitStep);
    FB_LingGangXuLing.AddId(builder, Id);
    return FB_LingGangXuLing.EndFB_LingGangXuLing(builder);
  }

  public static void StartFB_LingGangXuLing(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLimitStep(FlatBufferBuilder builder, int LimitStep) { builder.AddInt(1, LimitStep, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(2, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(3, ItemCount, -1); }
  public static void AddSureSucceedMoney(FlatBufferBuilder builder, int SureSucceedMoney) { builder.AddInt(4, SureSucceedMoney, -1); }
  public static void AddRate(FlatBufferBuilder builder, int Rate) { builder.AddInt(5, Rate, -1); }
  public static void AddCriticalRate(FlatBufferBuilder builder, int CriticalRate) { builder.AddInt(6, CriticalRate, -1); }
  public static void AddCriticalAddLv(FlatBufferBuilder builder, int CriticalAddLv) { builder.AddInt(7, CriticalAddLv, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(8, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(9, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangXuLing> EndFB_LingGangXuLing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangXuLing>(o);
  }
};

public sealed class FB_LingGangXuLingContainer : Table {
  public static FB_LingGangXuLingContainer GetRootAsFB_LingGangXuLingContainer(ByteBuffer _bb) { return GetRootAsFB_LingGangXuLingContainer(_bb, new FB_LingGangXuLingContainer()); }
  public static FB_LingGangXuLingContainer GetRootAsFB_LingGangXuLingContainer(ByteBuffer _bb, FB_LingGangXuLingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingGangXuLingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingGangXuLingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingGangXuLing GetItems(int j) { return GetItems(new FB_LingGangXuLing(), j); }
  public FB_LingGangXuLing GetItems(FB_LingGangXuLing obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangXuLingContainer> CreateFB_LingGangXuLingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingGangXuLingContainer.AddItems(builder, items);
    return FB_LingGangXuLingContainer.EndFB_LingGangXuLingContainer(builder);
  }

  public static void StartFB_LingGangXuLingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingGangXuLing>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangXuLingContainer> EndFB_LingGangXuLingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangXuLingContainer>(o);
  }
  public static void FinishFB_LingGangXuLingContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingGangXuLingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
