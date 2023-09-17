// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHXianShiQiangGou : Table {
  public static FB_SYHXianShiQiangGou GetRootAsFB_SYHXianShiQiangGou(ByteBuffer _bb) { return GetRootAsFB_SYHXianShiQiangGou(_bb, new FB_SYHXianShiQiangGou()); }
  public static FB_SYHXianShiQiangGou GetRootAsFB_SYHXianShiQiangGou(ByteBuffer _bb, FB_SYHXianShiQiangGou obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHXianShiQiangGou __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRMBList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RMBListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLimitNumList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LimitNumListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetYuanBaoNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int YuanBaoNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMailList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MailListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianShiQiangGou> CreateFB_SYHXianShiQiangGou(FlatBufferBuilder builder,
      int Id = 0,
      int LevelLimit = -1,
      int Param = -1,
      VectorOffset RMBList = default(VectorOffset),
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset LimitNumList = default(VectorOffset),
      VectorOffset YuanBaoNumList = default(VectorOffset),
      VectorOffset MailList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_SYHXianShiQiangGou.AddMailList(builder, MailList);
    FB_SYHXianShiQiangGou.AddYuanBaoNumList(builder, YuanBaoNumList);
    FB_SYHXianShiQiangGou.AddLimitNumList(builder, LimitNumList);
    FB_SYHXianShiQiangGou.AddItemIdList(builder, ItemIdList);
    FB_SYHXianShiQiangGou.AddRMBList(builder, RMBList);
    FB_SYHXianShiQiangGou.AddParam(builder, Param);
    FB_SYHXianShiQiangGou.AddLevelLimit(builder, LevelLimit);
    FB_SYHXianShiQiangGou.AddId(builder, Id);
    return FB_SYHXianShiQiangGou.EndFB_SYHXianShiQiangGou(builder);
  }

  public static void StartFB_SYHXianShiQiangGou(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(1, LevelLimit, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(2, Param, -1); }
  public static void AddRMBList(FlatBufferBuilder builder, VectorOffset RMBListOffset) { builder.AddOffset(3, RMBListOffset.Value, 0); }
  public static VectorOffset CreateRMBListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRMBListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(4, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLimitNumList(FlatBufferBuilder builder, VectorOffset LimitNumListOffset) { builder.AddOffset(5, LimitNumListOffset.Value, 0); }
  public static VectorOffset CreateLimitNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLimitNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddYuanBaoNumList(FlatBufferBuilder builder, VectorOffset YuanBaoNumListOffset) { builder.AddOffset(6, YuanBaoNumListOffset.Value, 0); }
  public static VectorOffset CreateYuanBaoNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartYuanBaoNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMailList(FlatBufferBuilder builder, VectorOffset MailListOffset) { builder.AddOffset(7, MailListOffset.Value, 0); }
  public static VectorOffset CreateMailListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMailListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianShiQiangGou> EndFB_SYHXianShiQiangGou(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianShiQiangGou>(o);
  }
};

public sealed class FB_SYHXianShiQiangGouContainer : Table {
  public static FB_SYHXianShiQiangGouContainer GetRootAsFB_SYHXianShiQiangGouContainer(ByteBuffer _bb) { return GetRootAsFB_SYHXianShiQiangGouContainer(_bb, new FB_SYHXianShiQiangGouContainer()); }
  public static FB_SYHXianShiQiangGouContainer GetRootAsFB_SYHXianShiQiangGouContainer(ByteBuffer _bb, FB_SYHXianShiQiangGouContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHXianShiQiangGouContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHXianShiQiangGouContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHXianShiQiangGou GetItems(int j) { return GetItems(new FB_SYHXianShiQiangGou(), j); }
  public FB_SYHXianShiQiangGou GetItems(FB_SYHXianShiQiangGou obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianShiQiangGouContainer> CreateFB_SYHXianShiQiangGouContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHXianShiQiangGouContainer.AddItems(builder, items);
    return FB_SYHXianShiQiangGouContainer.EndFB_SYHXianShiQiangGouContainer(builder);
  }

  public static void StartFB_SYHXianShiQiangGouContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHXianShiQiangGou>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianShiQiangGouContainer> EndFB_SYHXianShiQiangGouContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianShiQiangGouContainer>(o);
  }
  public static void FinishFB_SYHXianShiQiangGouContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHXianShiQiangGouContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
