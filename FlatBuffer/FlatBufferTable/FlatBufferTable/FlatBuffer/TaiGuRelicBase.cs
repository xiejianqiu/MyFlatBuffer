// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TaiGuRelicBase : Table {
  public static FB_TaiGuRelicBase GetRootAsFB_TaiGuRelicBase(ByteBuffer _bb) { return GetRootAsFB_TaiGuRelicBase(_bb, new FB_TaiGuRelicBase()); }
  public static FB_TaiGuRelicBase GetRootAsFB_TaiGuRelicBase(ByteBuffer _bb, FB_TaiGuRelicBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TaiGuRelicBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActStartTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefMaxNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefFreeNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWeekWeightList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeekWeightListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPushLevelList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PushLevelListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPushShopIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PushShopIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaiGuRelicBase> CreateFB_TaiGuRelicBase(FlatBufferBuilder builder,
      int ID = 0,
      int ActStartTime = -1,
      int RefMaxNum = -1,
      int RefFreeNum = -1,
      VectorOffset WeekWeightList = default(VectorOffset),
      VectorOffset PushLevelList = default(VectorOffset),
      VectorOffset PushShopIDList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_TaiGuRelicBase.AddPushShopIDList(builder, PushShopIDList);
    FB_TaiGuRelicBase.AddPushLevelList(builder, PushLevelList);
    FB_TaiGuRelicBase.AddWeekWeightList(builder, WeekWeightList);
    FB_TaiGuRelicBase.AddRefFreeNum(builder, RefFreeNum);
    FB_TaiGuRelicBase.AddRefMaxNum(builder, RefMaxNum);
    FB_TaiGuRelicBase.AddActStartTime(builder, ActStartTime);
    FB_TaiGuRelicBase.AddID(builder, ID);
    return FB_TaiGuRelicBase.EndFB_TaiGuRelicBase(builder);
  }

  public static void StartFB_TaiGuRelicBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActStartTime(FlatBufferBuilder builder, int ActStartTime) { builder.AddInt(1, ActStartTime, -1); }
  public static void AddRefMaxNum(FlatBufferBuilder builder, int RefMaxNum) { builder.AddInt(2, RefMaxNum, -1); }
  public static void AddRefFreeNum(FlatBufferBuilder builder, int RefFreeNum) { builder.AddInt(3, RefFreeNum, -1); }
  public static void AddWeekWeightList(FlatBufferBuilder builder, VectorOffset WeekWeightListOffset) { builder.AddOffset(4, WeekWeightListOffset.Value, 0); }
  public static VectorOffset CreateWeekWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeekWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPushLevelList(FlatBufferBuilder builder, VectorOffset PushLevelListOffset) { builder.AddOffset(5, PushLevelListOffset.Value, 0); }
  public static VectorOffset CreatePushLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPushLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPushShopIDList(FlatBufferBuilder builder, VectorOffset PushShopIDListOffset) { builder.AddOffset(6, PushShopIDListOffset.Value, 0); }
  public static VectorOffset CreatePushShopIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPushShopIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaiGuRelicBase> EndFB_TaiGuRelicBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaiGuRelicBase>(o);
  }
};

public sealed class FB_TaiGuRelicBaseContainer : Table {
  public static FB_TaiGuRelicBaseContainer GetRootAsFB_TaiGuRelicBaseContainer(ByteBuffer _bb) { return GetRootAsFB_TaiGuRelicBaseContainer(_bb, new FB_TaiGuRelicBaseContainer()); }
  public static FB_TaiGuRelicBaseContainer GetRootAsFB_TaiGuRelicBaseContainer(ByteBuffer _bb, FB_TaiGuRelicBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TaiGuRelicBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TaiGuRelicBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TaiGuRelicBase GetItems(int j) { return GetItems(new FB_TaiGuRelicBase(), j); }
  public FB_TaiGuRelicBase GetItems(FB_TaiGuRelicBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaiGuRelicBaseContainer> CreateFB_TaiGuRelicBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TaiGuRelicBaseContainer.AddItems(builder, items);
    return FB_TaiGuRelicBaseContainer.EndFB_TaiGuRelicBaseContainer(builder);
  }

  public static void StartFB_TaiGuRelicBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TaiGuRelicBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaiGuRelicBaseContainer> EndFB_TaiGuRelicBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaiGuRelicBaseContainer>(o);
  }
  public static void FinishFB_TaiGuRelicBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_TaiGuRelicBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
