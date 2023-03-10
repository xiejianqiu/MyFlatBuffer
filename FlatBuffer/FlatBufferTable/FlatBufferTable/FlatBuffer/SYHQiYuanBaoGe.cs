// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHQiYuanBaoGe : Table {
  public static FB_SYHQiYuanBaoGe GetRootAsFB_SYHQiYuanBaoGe(ByteBuffer _bb) { return GetRootAsFB_SYHQiYuanBaoGe(_bb, new FB_SYHQiYuanBaoGe()); }
  public static FB_SYHQiYuanBaoGe GetRootAsFB_SYHQiYuanBaoGe(ByteBuffer _bb, FB_SYHQiYuanBaoGe obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHQiYuanBaoGe __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HighDropBoxId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LowDropBoxId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ThreeDropBox { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Param { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ShenPuName { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Model { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHQiYuanBaoGe> CreateFB_SYHQiYuanBaoGe(FlatBufferBuilder builder,
      int ID = 0,
      int HighDropBoxId = 0,
      int LowDropBoxId = 0,
      int ThreeDropBox = 0,
      int LevelLimit = 0,
      int Param = -1,
      StringOffset ShenPuName = default(StringOffset),
      int model = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_SYHQiYuanBaoGe.AddItemNumList(builder, ItemNumList);
    FB_SYHQiYuanBaoGe.AddItemIdList(builder, ItemIdList);
    FB_SYHQiYuanBaoGe.AddModel(builder, model);
    FB_SYHQiYuanBaoGe.AddShenPuName(builder, ShenPuName);
    FB_SYHQiYuanBaoGe.AddParam(builder, Param);
    FB_SYHQiYuanBaoGe.AddLevelLimit(builder, LevelLimit);
    FB_SYHQiYuanBaoGe.AddThreeDropBox(builder, ThreeDropBox);
    FB_SYHQiYuanBaoGe.AddLowDropBoxId(builder, LowDropBoxId);
    FB_SYHQiYuanBaoGe.AddHighDropBoxId(builder, HighDropBoxId);
    FB_SYHQiYuanBaoGe.AddID(builder, ID);
    return FB_SYHQiYuanBaoGe.EndFB_SYHQiYuanBaoGe(builder);
  }

  public static void StartFB_SYHQiYuanBaoGe(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHighDropBoxId(FlatBufferBuilder builder, int HighDropBoxId) { builder.AddInt(1, HighDropBoxId, 0); }
  public static void AddLowDropBoxId(FlatBufferBuilder builder, int LowDropBoxId) { builder.AddInt(2, LowDropBoxId, 0); }
  public static void AddThreeDropBox(FlatBufferBuilder builder, int ThreeDropBox) { builder.AddInt(3, ThreeDropBox, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(4, LevelLimit, 0); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(5, Param, -1); }
  public static void AddShenPuName(FlatBufferBuilder builder, StringOffset ShenPuNameOffset) { builder.AddOffset(6, ShenPuNameOffset.Value, 0); }
  public static void AddModel(FlatBufferBuilder builder, int model) { builder.AddInt(7, model, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(8, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(9, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHQiYuanBaoGe> EndFB_SYHQiYuanBaoGe(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHQiYuanBaoGe>(o);
  }
};

public sealed class FB_SYHQiYuanBaoGeContainer : Table {
  public static FB_SYHQiYuanBaoGeContainer GetRootAsFB_SYHQiYuanBaoGeContainer(ByteBuffer _bb) { return GetRootAsFB_SYHQiYuanBaoGeContainer(_bb, new FB_SYHQiYuanBaoGeContainer()); }
  public static FB_SYHQiYuanBaoGeContainer GetRootAsFB_SYHQiYuanBaoGeContainer(ByteBuffer _bb, FB_SYHQiYuanBaoGeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHQiYuanBaoGeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHQiYuanBaoGeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHQiYuanBaoGe GetItems(int j) { return GetItems(new FB_SYHQiYuanBaoGe(), j); }
  public FB_SYHQiYuanBaoGe GetItems(FB_SYHQiYuanBaoGe obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHQiYuanBaoGeContainer> CreateFB_SYHQiYuanBaoGeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHQiYuanBaoGeContainer.AddItems(builder, items);
    return FB_SYHQiYuanBaoGeContainer.EndFB_SYHQiYuanBaoGeContainer(builder);
  }

  public static void StartFB_SYHQiYuanBaoGeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHQiYuanBaoGe>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHQiYuanBaoGeContainer> EndFB_SYHQiYuanBaoGeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHQiYuanBaoGeContainer>(o);
  }
  public static void FinishFB_SYHQiYuanBaoGeContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHQiYuanBaoGeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
