// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHXianYuShengHuiAward : Table {
  public static FB_SYHXianYuShengHuiAward GetRootAsFB_SYHXianYuShengHuiAward(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuShengHuiAward(_bb, new FB_SYHXianYuShengHuiAward()); }
  public static FB_SYHXianYuShengHuiAward GetRootAsFB_SYHXianYuShengHuiAward(ByteBuffer _bb, FB_SYHXianYuShengHuiAward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHXianYuShengHuiAward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AwardIdex { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Parm { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ParmSec { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int XianYuId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetShowItemList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int DicId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHXianYuShengHuiAward> CreateFB_SYHXianYuShengHuiAward(FlatBufferBuilder builder,
      int ID = 0,
      int AwardIdex = 0,
      int LevelLimit = 0,
      int Parm = -1,
      int ParmSec = -1,
      int XianYuId = -1,
      VectorOffset ShowItemList = default(VectorOffset),
      int DicId = -1) {
    builder.StartObject(8);
    FB_SYHXianYuShengHuiAward.AddDicId(builder, DicId);
    FB_SYHXianYuShengHuiAward.AddShowItemList(builder, ShowItemList);
    FB_SYHXianYuShengHuiAward.AddXianYuId(builder, XianYuId);
    FB_SYHXianYuShengHuiAward.AddParmSec(builder, ParmSec);
    FB_SYHXianYuShengHuiAward.AddParm(builder, Parm);
    FB_SYHXianYuShengHuiAward.AddLevelLimit(builder, LevelLimit);
    FB_SYHXianYuShengHuiAward.AddAwardIdex(builder, AwardIdex);
    FB_SYHXianYuShengHuiAward.AddID(builder, ID);
    return FB_SYHXianYuShengHuiAward.EndFB_SYHXianYuShengHuiAward(builder);
  }

  public static void StartFB_SYHXianYuShengHuiAward(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAwardIdex(FlatBufferBuilder builder, int AwardIdex) { builder.AddInt(1, AwardIdex, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(2, LevelLimit, 0); }
  public static void AddParm(FlatBufferBuilder builder, int Parm) { builder.AddInt(3, Parm, -1); }
  public static void AddParmSec(FlatBufferBuilder builder, int ParmSec) { builder.AddInt(4, ParmSec, -1); }
  public static void AddXianYuId(FlatBufferBuilder builder, int XianYuId) { builder.AddInt(5, XianYuId, -1); }
  public static void AddShowItemList(FlatBufferBuilder builder, VectorOffset ShowItemListOffset) { builder.AddOffset(6, ShowItemListOffset.Value, 0); }
  public static VectorOffset CreateShowItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(7, DicId, -1); }
  public static Offset<FB_SYHXianYuShengHuiAward> EndFB_SYHXianYuShengHuiAward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuShengHuiAward>(o);
  }
};

public sealed class FB_SYHXianYuShengHuiAwardContainer : Table {
  public static FB_SYHXianYuShengHuiAwardContainer GetRootAsFB_SYHXianYuShengHuiAwardContainer(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuShengHuiAwardContainer(_bb, new FB_SYHXianYuShengHuiAwardContainer()); }
  public static FB_SYHXianYuShengHuiAwardContainer GetRootAsFB_SYHXianYuShengHuiAwardContainer(ByteBuffer _bb, FB_SYHXianYuShengHuiAwardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHXianYuShengHuiAwardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHXianYuShengHuiAwardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHXianYuShengHuiAward GetItems(int j) { return GetItems(new FB_SYHXianYuShengHuiAward(), j); }
  public FB_SYHXianYuShengHuiAward GetItems(FB_SYHXianYuShengHuiAward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianYuShengHuiAwardContainer> CreateFB_SYHXianYuShengHuiAwardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHXianYuShengHuiAwardContainer.AddItems(builder, items);
    return FB_SYHXianYuShengHuiAwardContainer.EndFB_SYHXianYuShengHuiAwardContainer(builder);
  }

  public static void StartFB_SYHXianYuShengHuiAwardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHXianYuShengHuiAward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianYuShengHuiAwardContainer> EndFB_SYHXianYuShengHuiAwardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuShengHuiAwardContainer>(o);
  }
  public static void FinishFB_SYHXianYuShengHuiAwardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHXianYuShengHuiAwardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
