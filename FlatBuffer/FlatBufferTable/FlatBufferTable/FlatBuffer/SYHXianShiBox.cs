// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHXianShiBox : Table {
  public static FB_SYHXianShiBox GetRootAsFB_SYHXianShiBox(ByteBuffer _bb) { return GetRootAsFB_SYHXianShiBox(_bb, new FB_SYHXianShiBox()); }
  public static FB_SYHXianShiBox GetRootAsFB_SYHXianShiBox(ByteBuffer _bb, FB_SYHXianShiBox obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHXianShiBox __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAwardIdexList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AwardIdexListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCostNumList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCostNumListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemWorthNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemWorthNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianShiBox> CreateFB_SYHXianShiBox(FlatBufferBuilder builder,
      int Id = 0,
      int LevelLimit = -1,
      VectorOffset AwardIdexList = default(VectorOffset),
      VectorOffset ItemCostNumList = default(VectorOffset),
      VectorOffset ItemWorthNumList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_SYHXianShiBox.AddItemWorthNumList(builder, ItemWorthNumList);
    FB_SYHXianShiBox.AddItemCostNumList(builder, ItemCostNumList);
    FB_SYHXianShiBox.AddAwardIdexList(builder, AwardIdexList);
    FB_SYHXianShiBox.AddLevelLimit(builder, LevelLimit);
    FB_SYHXianShiBox.AddId(builder, Id);
    return FB_SYHXianShiBox.EndFB_SYHXianShiBox(builder);
  }

  public static void StartFB_SYHXianShiBox(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(1, LevelLimit, -1); }
  public static void AddAwardIdexList(FlatBufferBuilder builder, VectorOffset AwardIdexListOffset) { builder.AddOffset(2, AwardIdexListOffset.Value, 0); }
  public static VectorOffset CreateAwardIdexListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAwardIdexListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCostNumList(FlatBufferBuilder builder, VectorOffset ItemCostNumListOffset) { builder.AddOffset(3, ItemCostNumListOffset.Value, 0); }
  public static VectorOffset CreateItemCostNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCostNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemWorthNumList(FlatBufferBuilder builder, VectorOffset ItemWorthNumListOffset) { builder.AddOffset(4, ItemWorthNumListOffset.Value, 0); }
  public static VectorOffset CreateItemWorthNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemWorthNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianShiBox> EndFB_SYHXianShiBox(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianShiBox>(o);
  }
};

public sealed class FB_SYHXianShiBoxContainer : Table {
  public static FB_SYHXianShiBoxContainer GetRootAsFB_SYHXianShiBoxContainer(ByteBuffer _bb) { return GetRootAsFB_SYHXianShiBoxContainer(_bb, new FB_SYHXianShiBoxContainer()); }
  public static FB_SYHXianShiBoxContainer GetRootAsFB_SYHXianShiBoxContainer(ByteBuffer _bb, FB_SYHXianShiBoxContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHXianShiBoxContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHXianShiBoxContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHXianShiBox GetItems(int j) { return GetItems(new FB_SYHXianShiBox(), j); }
  public FB_SYHXianShiBox GetItems(FB_SYHXianShiBox obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianShiBoxContainer> CreateFB_SYHXianShiBoxContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHXianShiBoxContainer.AddItems(builder, items);
    return FB_SYHXianShiBoxContainer.EndFB_SYHXianShiBoxContainer(builder);
  }

  public static void StartFB_SYHXianShiBoxContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHXianShiBox>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianShiBoxContainer> EndFB_SYHXianShiBoxContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianShiBoxContainer>(o);
  }
  public static void FinishFB_SYHXianShiBoxContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHXianShiBoxContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
