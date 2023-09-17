// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondGongZhenAll : Table {
  public static FB_DiamondGongZhenAll GetRootAsFB_DiamondGongZhenAll(ByteBuffer _bb) { return GetRootAsFB_DiamondGongZhenAll(_bb, new FB_DiamondGongZhenAll()); }
  public static FB_DiamondGongZhenAll GetRootAsFB_DiamondGongZhenAll(ByteBuffer _bb, FB_DiamondGongZhenAll obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondGongZhenAll __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LvSum { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondGongZhenAll> CreateFB_DiamondGongZhenAll(FlatBufferBuilder builder,
      int Id = 0,
      int LvSum = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_DiamondGongZhenAll.AddAttrValueList(builder, AttrValueList);
    FB_DiamondGongZhenAll.AddAttrIdList(builder, AttrIdList);
    FB_DiamondGongZhenAll.AddLvSum(builder, LvSum);
    FB_DiamondGongZhenAll.AddId(builder, Id);
    return FB_DiamondGongZhenAll.EndFB_DiamondGongZhenAll(builder);
  }

  public static void StartFB_DiamondGongZhenAll(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLvSum(FlatBufferBuilder builder, int LvSum) { builder.AddInt(1, LvSum, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondGongZhenAll> EndFB_DiamondGongZhenAll(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondGongZhenAll>(o);
  }
};

public sealed class FB_DiamondGongZhenAllContainer : Table {
  public static FB_DiamondGongZhenAllContainer GetRootAsFB_DiamondGongZhenAllContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondGongZhenAllContainer(_bb, new FB_DiamondGongZhenAllContainer()); }
  public static FB_DiamondGongZhenAllContainer GetRootAsFB_DiamondGongZhenAllContainer(ByteBuffer _bb, FB_DiamondGongZhenAllContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondGongZhenAllContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondGongZhenAllContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondGongZhenAll GetItems(int j) { return GetItems(new FB_DiamondGongZhenAll(), j); }
  public FB_DiamondGongZhenAll GetItems(FB_DiamondGongZhenAll obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondGongZhenAllContainer> CreateFB_DiamondGongZhenAllContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondGongZhenAllContainer.AddItems(builder, items);
    return FB_DiamondGongZhenAllContainer.EndFB_DiamondGongZhenAllContainer(builder);
  }

  public static void StartFB_DiamondGongZhenAllContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondGongZhenAll>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondGongZhenAllContainer> EndFB_DiamondGongZhenAllContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondGongZhenAllContainer>(o);
  }
  public static void FinishFB_DiamondGongZhenAllContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondGongZhenAllContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
