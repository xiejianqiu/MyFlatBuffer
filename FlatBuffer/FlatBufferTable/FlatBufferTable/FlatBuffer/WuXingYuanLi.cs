// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WuXingYuanLi : Table {
  public static FB_WuXingYuanLi GetRootAsFB_WuXingYuanLi(ByteBuffer _bb) { return GetRootAsFB_WuXingYuanLi(_bb, new FB_WuXingYuanLi()); }
  public static FB_WuXingYuanLi GetRootAsFB_WuXingYuanLi(ByteBuffer _bb, FB_WuXingYuanLi obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WuXingYuanLi __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int NeedItemId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedItemCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Price { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WuXingYuanLi> CreateFB_WuXingYuanLi(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int NeedItemId = -1,
      int NeedItemCount = -1,
      int Price = -1) {
    builder.StartObject(7);
    FB_WuXingYuanLi.AddPrice(builder, Price);
    FB_WuXingYuanLi.AddNeedItemCount(builder, NeedItemCount);
    FB_WuXingYuanLi.AddNeedItemId(builder, NeedItemId);
    FB_WuXingYuanLi.AddAttrValueList(builder, AttrValueList);
    FB_WuXingYuanLi.AddAttrIdList(builder, AttrIdList);
    FB_WuXingYuanLi.AddName(builder, Name);
    FB_WuXingYuanLi.AddID(builder, ID);
    return FB_WuXingYuanLi.EndFB_WuXingYuanLi(builder);
  }

  public static void StartFB_WuXingYuanLi(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNeedItemId(FlatBufferBuilder builder, int NeedItemId) { builder.AddInt(4, NeedItemId, -1); }
  public static void AddNeedItemCount(FlatBufferBuilder builder, int NeedItemCount) { builder.AddInt(5, NeedItemCount, -1); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(6, Price, -1); }
  public static Offset<FB_WuXingYuanLi> EndFB_WuXingYuanLi(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WuXingYuanLi>(o);
  }
};

public sealed class FB_WuXingYuanLiContainer : Table {
  public static FB_WuXingYuanLiContainer GetRootAsFB_WuXingYuanLiContainer(ByteBuffer _bb) { return GetRootAsFB_WuXingYuanLiContainer(_bb, new FB_WuXingYuanLiContainer()); }
  public static FB_WuXingYuanLiContainer GetRootAsFB_WuXingYuanLiContainer(ByteBuffer _bb, FB_WuXingYuanLiContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WuXingYuanLiContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WuXingYuanLiContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WuXingYuanLi GetItems(int j) { return GetItems(new FB_WuXingYuanLi(), j); }
  public FB_WuXingYuanLi GetItems(FB_WuXingYuanLi obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WuXingYuanLiContainer> CreateFB_WuXingYuanLiContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WuXingYuanLiContainer.AddItems(builder, items);
    return FB_WuXingYuanLiContainer.EndFB_WuXingYuanLiContainer(builder);
  }

  public static void StartFB_WuXingYuanLiContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WuXingYuanLi>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WuXingYuanLiContainer> EndFB_WuXingYuanLiContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WuXingYuanLiContainer>(o);
  }
  public static void FinishFB_WuXingYuanLiContainerBuffer(FlatBufferBuilder builder, Offset<FB_WuXingYuanLiContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
