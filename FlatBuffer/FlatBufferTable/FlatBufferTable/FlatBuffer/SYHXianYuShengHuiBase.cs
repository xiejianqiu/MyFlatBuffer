// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHXianYuShengHuiBase : Table {
  public static FB_SYHXianYuShengHuiBase GetRootAsFB_SYHXianYuShengHuiBase(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuShengHuiBase(_bb, new FB_SYHXianYuShengHuiBase()); }
  public static FB_SYHXianYuShengHuiBase GetRootAsFB_SYHXianYuShengHuiBase(ByteBuffer _bb, FB_SYHXianYuShengHuiBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHXianYuShengHuiBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ActivityName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StartWordLevelMd { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StartIndexMD { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StartId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TimeInfo { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_SYHXianYuShengHuiBase> CreateFB_SYHXianYuShengHuiBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ActivityName = default(StringOffset),
      int StartWordLevelMd = -1,
      int StartIndexMD = -1,
      int StartId = -1,
      int EndId = -1,
      int DicId = -1,
      StringOffset TimeInfo = default(StringOffset)) {
    builder.StartObject(8);
    FB_SYHXianYuShengHuiBase.AddTimeInfo(builder, TimeInfo);
    FB_SYHXianYuShengHuiBase.AddDicId(builder, DicId);
    FB_SYHXianYuShengHuiBase.AddEndId(builder, EndId);
    FB_SYHXianYuShengHuiBase.AddStartId(builder, StartId);
    FB_SYHXianYuShengHuiBase.AddStartIndexMD(builder, StartIndexMD);
    FB_SYHXianYuShengHuiBase.AddStartWordLevelMd(builder, StartWordLevelMd);
    FB_SYHXianYuShengHuiBase.AddActivityName(builder, ActivityName);
    FB_SYHXianYuShengHuiBase.AddID(builder, ID);
    return FB_SYHXianYuShengHuiBase.EndFB_SYHXianYuShengHuiBase(builder);
  }

  public static void StartFB_SYHXianYuShengHuiBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActivityName(FlatBufferBuilder builder, StringOffset ActivityNameOffset) { builder.AddOffset(1, ActivityNameOffset.Value, 0); }
  public static void AddStartWordLevelMd(FlatBufferBuilder builder, int StartWordLevelMd) { builder.AddInt(2, StartWordLevelMd, -1); }
  public static void AddStartIndexMD(FlatBufferBuilder builder, int StartIndexMD) { builder.AddInt(3, StartIndexMD, -1); }
  public static void AddStartId(FlatBufferBuilder builder, int StartId) { builder.AddInt(4, StartId, -1); }
  public static void AddEndId(FlatBufferBuilder builder, int EndId) { builder.AddInt(5, EndId, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(6, DicId, -1); }
  public static void AddTimeInfo(FlatBufferBuilder builder, StringOffset TimeInfoOffset) { builder.AddOffset(7, TimeInfoOffset.Value, 0); }
  public static Offset<FB_SYHXianYuShengHuiBase> EndFB_SYHXianYuShengHuiBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuShengHuiBase>(o);
  }
};

public sealed class FB_SYHXianYuShengHuiBaseContainer : Table {
  public static FB_SYHXianYuShengHuiBaseContainer GetRootAsFB_SYHXianYuShengHuiBaseContainer(ByteBuffer _bb) { return GetRootAsFB_SYHXianYuShengHuiBaseContainer(_bb, new FB_SYHXianYuShengHuiBaseContainer()); }
  public static FB_SYHXianYuShengHuiBaseContainer GetRootAsFB_SYHXianYuShengHuiBaseContainer(ByteBuffer _bb, FB_SYHXianYuShengHuiBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHXianYuShengHuiBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHXianYuShengHuiBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHXianYuShengHuiBase GetItems(int j) { return GetItems(new FB_SYHXianYuShengHuiBase(), j); }
  public FB_SYHXianYuShengHuiBase GetItems(FB_SYHXianYuShengHuiBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHXianYuShengHuiBaseContainer> CreateFB_SYHXianYuShengHuiBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHXianYuShengHuiBaseContainer.AddItems(builder, items);
    return FB_SYHXianYuShengHuiBaseContainer.EndFB_SYHXianYuShengHuiBaseContainer(builder);
  }

  public static void StartFB_SYHXianYuShengHuiBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHXianYuShengHuiBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHXianYuShengHuiBaseContainer> EndFB_SYHXianYuShengHuiBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHXianYuShengHuiBaseContainer>(o);
  }
  public static void FinishFB_SYHXianYuShengHuiBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHXianYuShengHuiBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
