// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingQiLingGongMing : Table {
  public static FB_JiLingQiLingGongMing GetRootAsFB_JiLingQiLingGongMing(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingGongMing(_bb, new FB_JiLingQiLingGongMing()); }
  public static FB_JiLingQiLingGongMing GetRootAsFB_JiLingQiLingGongMing(ByteBuffer _bb, FB_JiLingQiLingGongMing obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingQiLingGongMing __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Step { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int ItemID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RealityItemID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingQiLingGongMing> CreateFB_JiLingQiLingGongMing(FlatBufferBuilder builder,
      int Id = 0,
      int Step = 1,
      int ItemID = -1,
      int RealityItemID = -1,
      int ItemCount = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_JiLingQiLingGongMing.AddAttrValueList(builder, AttrValueList);
    FB_JiLingQiLingGongMing.AddAttrIDList(builder, AttrIDList);
    FB_JiLingQiLingGongMing.AddItemCount(builder, ItemCount);
    FB_JiLingQiLingGongMing.AddRealityItemID(builder, RealityItemID);
    FB_JiLingQiLingGongMing.AddItemID(builder, ItemID);
    FB_JiLingQiLingGongMing.AddStep(builder, Step);
    FB_JiLingQiLingGongMing.AddId(builder, Id);
    return FB_JiLingQiLingGongMing.EndFB_JiLingQiLingGongMing(builder);
  }

  public static void StartFB_JiLingQiLingGongMing(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(1, Step, 1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(2, ItemID, -1); }
  public static void AddRealityItemID(FlatBufferBuilder builder, int RealityItemID) { builder.AddInt(3, RealityItemID, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(4, ItemCount, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(5, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingQiLingGongMing> EndFB_JiLingQiLingGongMing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingGongMing>(o);
  }
};

public sealed class FB_JiLingQiLingGongMingContainer : Table {
  public static FB_JiLingQiLingGongMingContainer GetRootAsFB_JiLingQiLingGongMingContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingGongMingContainer(_bb, new FB_JiLingQiLingGongMingContainer()); }
  public static FB_JiLingQiLingGongMingContainer GetRootAsFB_JiLingQiLingGongMingContainer(ByteBuffer _bb, FB_JiLingQiLingGongMingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingQiLingGongMingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingQiLingGongMingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingQiLingGongMing GetItems(int j) { return GetItems(new FB_JiLingQiLingGongMing(), j); }
  public FB_JiLingQiLingGongMing GetItems(FB_JiLingQiLingGongMing obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingQiLingGongMingContainer> CreateFB_JiLingQiLingGongMingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingQiLingGongMingContainer.AddItems(builder, items);
    return FB_JiLingQiLingGongMingContainer.EndFB_JiLingQiLingGongMingContainer(builder);
  }

  public static void StartFB_JiLingQiLingGongMingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingQiLingGongMing>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingQiLingGongMingContainer> EndFB_JiLingQiLingGongMingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingGongMingContainer>(o);
  }
  public static void FinishFB_JiLingQiLingGongMingContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingQiLingGongMingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
