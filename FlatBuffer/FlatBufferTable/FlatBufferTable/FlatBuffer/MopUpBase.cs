// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MopUpBase : Table {
  public static FB_MopUpBase GetRootAsFB_MopUpBase(ByteBuffer _bb) { return GetRootAsFB_MopUpBase(_bb, new FB_MopUpBase()); }
  public static FB_MopUpBase GetRootAsFB_MopUpBase(ByteBuffer _bb, FB_MopUpBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MopUpBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCountMaxList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CountMaxListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int CostType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitLvl { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MopUpBase> CreateFB_MopUpBase(FlatBufferBuilder builder,
      int ID = 0,
      int ItemID = -1,
      VectorOffset CountMaxList = default(VectorOffset),
      int CostType = -1,
      int LimitLvl = -1) {
    builder.StartObject(5);
    FB_MopUpBase.AddLimitLvl(builder, LimitLvl);
    FB_MopUpBase.AddCostType(builder, CostType);
    FB_MopUpBase.AddCountMaxList(builder, CountMaxList);
    FB_MopUpBase.AddItemID(builder, ItemID);
    FB_MopUpBase.AddID(builder, ID);
    return FB_MopUpBase.EndFB_MopUpBase(builder);
  }

  public static void StartFB_MopUpBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(1, ItemID, -1); }
  public static void AddCountMaxList(FlatBufferBuilder builder, VectorOffset CountMaxListOffset) { builder.AddOffset(2, CountMaxListOffset.Value, 0); }
  public static VectorOffset CreateCountMaxListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCountMaxListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(3, CostType, -1); }
  public static void AddLimitLvl(FlatBufferBuilder builder, int LimitLvl) { builder.AddInt(4, LimitLvl, -1); }
  public static Offset<FB_MopUpBase> EndFB_MopUpBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MopUpBase>(o);
  }
};

public sealed class FB_MopUpBaseContainer : Table {
  public static FB_MopUpBaseContainer GetRootAsFB_MopUpBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MopUpBaseContainer(_bb, new FB_MopUpBaseContainer()); }
  public static FB_MopUpBaseContainer GetRootAsFB_MopUpBaseContainer(ByteBuffer _bb, FB_MopUpBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MopUpBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MopUpBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MopUpBase GetItems(int j) { return GetItems(new FB_MopUpBase(), j); }
  public FB_MopUpBase GetItems(FB_MopUpBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MopUpBaseContainer> CreateFB_MopUpBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MopUpBaseContainer.AddItems(builder, items);
    return FB_MopUpBaseContainer.EndFB_MopUpBaseContainer(builder);
  }

  public static void StartFB_MopUpBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MopUpBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MopUpBaseContainer> EndFB_MopUpBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MopUpBaseContainer>(o);
  }
  public static void FinishFB_MopUpBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MopUpBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
