// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingBaoQiLing : Table {
  public static FB_LingBaoQiLing GetRootAsFB_LingBaoQiLing(ByteBuffer _bb) { return GetRootAsFB_LingBaoQiLing(_bb, new FB_LingBaoQiLing()); }
  public static FB_LingBaoQiLing GetRootAsFB_LingBaoQiLing(ByteBuffer _bb, FB_LingBaoQiLing obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingBaoQiLing __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrRateList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrRateListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMinAddValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MinAddValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMaxAddValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaxAddValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int DefaultAttrValue { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GuaranteeAddRate { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_LingBaoQiLing> CreateFB_LingBaoQiLing(FlatBufferBuilder builder,
      int Id = 0,
      int ItemId = -1,
      int ItemCount = -1,
      VectorOffset AttrRateList = default(VectorOffset),
      VectorOffset MinAddValueList = default(VectorOffset),
      VectorOffset MaxAddValueList = default(VectorOffset),
      int DefaultAttrValue = 0,
      int GuaranteeAddRate = 0) {
    builder.StartObject(8);
    FB_LingBaoQiLing.AddGuaranteeAddRate(builder, GuaranteeAddRate);
    FB_LingBaoQiLing.AddDefaultAttrValue(builder, DefaultAttrValue);
    FB_LingBaoQiLing.AddMaxAddValueList(builder, MaxAddValueList);
    FB_LingBaoQiLing.AddMinAddValueList(builder, MinAddValueList);
    FB_LingBaoQiLing.AddAttrRateList(builder, AttrRateList);
    FB_LingBaoQiLing.AddItemCount(builder, ItemCount);
    FB_LingBaoQiLing.AddItemId(builder, ItemId);
    FB_LingBaoQiLing.AddId(builder, Id);
    return FB_LingBaoQiLing.EndFB_LingBaoQiLing(builder);
  }

  public static void StartFB_LingBaoQiLing(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(1, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(2, ItemCount, -1); }
  public static void AddAttrRateList(FlatBufferBuilder builder, VectorOffset AttrRateListOffset) { builder.AddOffset(3, AttrRateListOffset.Value, 0); }
  public static VectorOffset CreateAttrRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMinAddValueList(FlatBufferBuilder builder, VectorOffset MinAddValueListOffset) { builder.AddOffset(4, MinAddValueListOffset.Value, 0); }
  public static VectorOffset CreateMinAddValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMinAddValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxAddValueList(FlatBufferBuilder builder, VectorOffset MaxAddValueListOffset) { builder.AddOffset(5, MaxAddValueListOffset.Value, 0); }
  public static VectorOffset CreateMaxAddValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaxAddValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDefaultAttrValue(FlatBufferBuilder builder, int DefaultAttrValue) { builder.AddInt(6, DefaultAttrValue, 0); }
  public static void AddGuaranteeAddRate(FlatBufferBuilder builder, int GuaranteeAddRate) { builder.AddInt(7, GuaranteeAddRate, 0); }
  public static Offset<FB_LingBaoQiLing> EndFB_LingBaoQiLing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoQiLing>(o);
  }
};

public sealed class FB_LingBaoQiLingContainer : Table {
  public static FB_LingBaoQiLingContainer GetRootAsFB_LingBaoQiLingContainer(ByteBuffer _bb) { return GetRootAsFB_LingBaoQiLingContainer(_bb, new FB_LingBaoQiLingContainer()); }
  public static FB_LingBaoQiLingContainer GetRootAsFB_LingBaoQiLingContainer(ByteBuffer _bb, FB_LingBaoQiLingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingBaoQiLingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingBaoQiLingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingBaoQiLing GetItems(int j) { return GetItems(new FB_LingBaoQiLing(), j); }
  public FB_LingBaoQiLing GetItems(FB_LingBaoQiLing obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingBaoQiLingContainer> CreateFB_LingBaoQiLingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingBaoQiLingContainer.AddItems(builder, items);
    return FB_LingBaoQiLingContainer.EndFB_LingBaoQiLingContainer(builder);
  }

  public static void StartFB_LingBaoQiLingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingBaoQiLing>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingBaoQiLingContainer> EndFB_LingBaoQiLingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoQiLingContainer>(o);
  }
  public static void FinishFB_LingBaoQiLingContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingBaoQiLingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
