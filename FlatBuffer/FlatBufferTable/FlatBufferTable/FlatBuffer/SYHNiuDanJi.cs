// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHNiuDanJi : Table {
  public static FB_SYHNiuDanJi GetRootAsFB_SYHNiuDanJi(ByteBuffer _bb) { return GetRootAsFB_SYHNiuDanJi(_bb, new FB_SYHNiuDanJi()); }
  public static FB_SYHNiuDanJi GetRootAsFB_SYHNiuDanJi(ByteBuffer _bb, FB_SYHNiuDanJi obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHNiuDanJi __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HighDropBoxId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LowDropBoxId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ThreeDropBox { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MagicNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxTime { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Seq { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHNiuDanJi> CreateFB_SYHNiuDanJi(FlatBufferBuilder builder,
      int ID = 0,
      int HighDropBoxId = 0,
      int LowDropBoxId = 0,
      int ThreeDropBox = 0,
      int MagicNum = 0,
      int MaxTime = -1,
      int Param = -1,
      int Seq = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_SYHNiuDanJi.AddItemNumList(builder, ItemNumList);
    FB_SYHNiuDanJi.AddItemIdList(builder, ItemIdList);
    FB_SYHNiuDanJi.AddSeq(builder, Seq);
    FB_SYHNiuDanJi.AddParam(builder, Param);
    FB_SYHNiuDanJi.AddMaxTime(builder, MaxTime);
    FB_SYHNiuDanJi.AddMagicNum(builder, MagicNum);
    FB_SYHNiuDanJi.AddThreeDropBox(builder, ThreeDropBox);
    FB_SYHNiuDanJi.AddLowDropBoxId(builder, LowDropBoxId);
    FB_SYHNiuDanJi.AddHighDropBoxId(builder, HighDropBoxId);
    FB_SYHNiuDanJi.AddID(builder, ID);
    return FB_SYHNiuDanJi.EndFB_SYHNiuDanJi(builder);
  }

  public static void StartFB_SYHNiuDanJi(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHighDropBoxId(FlatBufferBuilder builder, int HighDropBoxId) { builder.AddInt(1, HighDropBoxId, 0); }
  public static void AddLowDropBoxId(FlatBufferBuilder builder, int LowDropBoxId) { builder.AddInt(2, LowDropBoxId, 0); }
  public static void AddThreeDropBox(FlatBufferBuilder builder, int ThreeDropBox) { builder.AddInt(3, ThreeDropBox, 0); }
  public static void AddMagicNum(FlatBufferBuilder builder, int MagicNum) { builder.AddInt(4, MagicNum, 0); }
  public static void AddMaxTime(FlatBufferBuilder builder, int MaxTime) { builder.AddInt(5, MaxTime, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(6, Param, -1); }
  public static void AddSeq(FlatBufferBuilder builder, int Seq) { builder.AddInt(7, Seq, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(8, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(9, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHNiuDanJi> EndFB_SYHNiuDanJi(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHNiuDanJi>(o);
  }
};

public sealed class FB_SYHNiuDanJiContainer : Table {
  public static FB_SYHNiuDanJiContainer GetRootAsFB_SYHNiuDanJiContainer(ByteBuffer _bb) { return GetRootAsFB_SYHNiuDanJiContainer(_bb, new FB_SYHNiuDanJiContainer()); }
  public static FB_SYHNiuDanJiContainer GetRootAsFB_SYHNiuDanJiContainer(ByteBuffer _bb, FB_SYHNiuDanJiContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHNiuDanJiContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHNiuDanJiContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHNiuDanJi GetItems(int j) { return GetItems(new FB_SYHNiuDanJi(), j); }
  public FB_SYHNiuDanJi GetItems(FB_SYHNiuDanJi obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHNiuDanJiContainer> CreateFB_SYHNiuDanJiContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHNiuDanJiContainer.AddItems(builder, items);
    return FB_SYHNiuDanJiContainer.EndFB_SYHNiuDanJiContainer(builder);
  }

  public static void StartFB_SYHNiuDanJiContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHNiuDanJi>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHNiuDanJiContainer> EndFB_SYHNiuDanJiContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHNiuDanJiContainer>(o);
  }
  public static void FinishFB_SYHNiuDanJiContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHNiuDanJiContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
