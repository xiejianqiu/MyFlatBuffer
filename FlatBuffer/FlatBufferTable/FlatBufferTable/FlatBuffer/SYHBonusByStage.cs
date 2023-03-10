// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHBonusByStage : Table {
  public static FB_SYHBonusByStage GetRootAsFB_SYHBonusByStage(ByteBuffer _bb) { return GetRootAsFB_SYHBonusByStage(_bb, new FB_SYHBonusByStage()); }
  public static FB_SYHBonusByStage GetRootAsFB_SYHBonusByStage(ByteBuffer _bb, FB_SYHBonusByStage obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHBonusByStage __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetMenPaiAwardList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiAwardListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int MenPaiNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPaiReal { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHBonusByStage> CreateFB_SYHBonusByStage(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset MenPaiAwardList = default(VectorOffset),
      int MenPaiNum = 0,
      int MenPaiReal = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_SYHBonusByStage.AddItemNumList(builder, ItemNumList);
    FB_SYHBonusByStage.AddItemIDList(builder, ItemIDList);
    FB_SYHBonusByStage.AddMenPaiReal(builder, MenPaiReal);
    FB_SYHBonusByStage.AddMenPaiNum(builder, MenPaiNum);
    FB_SYHBonusByStage.AddMenPaiAwardList(builder, MenPaiAwardList);
    FB_SYHBonusByStage.AddID(builder, ID);
    return FB_SYHBonusByStage.EndFB_SYHBonusByStage(builder);
  }

  public static void StartFB_SYHBonusByStage(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMenPaiAwardList(FlatBufferBuilder builder, VectorOffset MenPaiAwardListOffset) { builder.AddOffset(1, MenPaiAwardListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiAwardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiAwardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiNum(FlatBufferBuilder builder, int MenPaiNum) { builder.AddInt(2, MenPaiNum, 0); }
  public static void AddMenPaiReal(FlatBufferBuilder builder, int MenPaiReal) { builder.AddInt(3, MenPaiReal, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(4, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(5, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHBonusByStage> EndFB_SYHBonusByStage(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHBonusByStage>(o);
  }
};

public sealed class FB_SYHBonusByStageContainer : Table {
  public static FB_SYHBonusByStageContainer GetRootAsFB_SYHBonusByStageContainer(ByteBuffer _bb) { return GetRootAsFB_SYHBonusByStageContainer(_bb, new FB_SYHBonusByStageContainer()); }
  public static FB_SYHBonusByStageContainer GetRootAsFB_SYHBonusByStageContainer(ByteBuffer _bb, FB_SYHBonusByStageContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHBonusByStageContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHBonusByStageContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHBonusByStage GetItems(int j) { return GetItems(new FB_SYHBonusByStage(), j); }
  public FB_SYHBonusByStage GetItems(FB_SYHBonusByStage obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHBonusByStageContainer> CreateFB_SYHBonusByStageContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHBonusByStageContainer.AddItems(builder, items);
    return FB_SYHBonusByStageContainer.EndFB_SYHBonusByStageContainer(builder);
  }

  public static void StartFB_SYHBonusByStageContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHBonusByStage>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHBonusByStageContainer> EndFB_SYHBonusByStageContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHBonusByStageContainer>(o);
  }
  public static void FinishFB_SYHBonusByStageContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHBonusByStageContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
