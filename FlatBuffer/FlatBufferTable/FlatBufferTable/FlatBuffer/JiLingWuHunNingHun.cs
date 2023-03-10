// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingWuHunNingHun : Table {
  public static FB_JiLingWuHunNingHun GetRootAsFB_JiLingWuHunNingHun(ByteBuffer _bb) { return GetRootAsFB_JiLingWuHunNingHun(_bb, new FB_JiLingWuHunNingHun()); }
  public static FB_JiLingWuHunNingHun GetRootAsFB_JiLingWuHunNingHun(ByteBuffer _bb, FB_JiLingWuHunNingHun obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingWuHunNingHun __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrValue { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DefaultVaule { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostValue { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RealityCostType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinUnLockRate { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxUnLockRate { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnLockRate { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetMinAddValueList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MinAddValueListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMaxAddValueList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaxAddValueListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingWuHunNingHun> CreateFB_JiLingWuHunNingHun(FlatBufferBuilder builder,
      int Id = 0,
      int AttrId = 0,
      int AttrValue = 0,
      int DefaultVaule = 0,
      int CostType = -1,
      int CostValue = -1,
      int RealityCostType = -1,
      int MinUnLockRate = 0,
      int MaxUnLockRate = 0,
      int UnLockRate = 0,
      VectorOffset MinAddValueList = default(VectorOffset),
      VectorOffset MaxAddValueList = default(VectorOffset)) {
    builder.StartObject(12);
    FB_JiLingWuHunNingHun.AddMaxAddValueList(builder, MaxAddValueList);
    FB_JiLingWuHunNingHun.AddMinAddValueList(builder, MinAddValueList);
    FB_JiLingWuHunNingHun.AddUnLockRate(builder, UnLockRate);
    FB_JiLingWuHunNingHun.AddMaxUnLockRate(builder, MaxUnLockRate);
    FB_JiLingWuHunNingHun.AddMinUnLockRate(builder, MinUnLockRate);
    FB_JiLingWuHunNingHun.AddRealityCostType(builder, RealityCostType);
    FB_JiLingWuHunNingHun.AddCostValue(builder, CostValue);
    FB_JiLingWuHunNingHun.AddCostType(builder, CostType);
    FB_JiLingWuHunNingHun.AddDefaultVaule(builder, DefaultVaule);
    FB_JiLingWuHunNingHun.AddAttrValue(builder, AttrValue);
    FB_JiLingWuHunNingHun.AddAttrId(builder, AttrId);
    FB_JiLingWuHunNingHun.AddId(builder, Id);
    return FB_JiLingWuHunNingHun.EndFB_JiLingWuHunNingHun(builder);
  }

  public static void StartFB_JiLingWuHunNingHun(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAttrId(FlatBufferBuilder builder, int AttrId) { builder.AddInt(1, AttrId, 0); }
  public static void AddAttrValue(FlatBufferBuilder builder, int AttrValue) { builder.AddInt(2, AttrValue, 0); }
  public static void AddDefaultVaule(FlatBufferBuilder builder, int DefaultVaule) { builder.AddInt(3, DefaultVaule, 0); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(4, CostType, -1); }
  public static void AddCostValue(FlatBufferBuilder builder, int CostValue) { builder.AddInt(5, CostValue, -1); }
  public static void AddRealityCostType(FlatBufferBuilder builder, int RealityCostType) { builder.AddInt(6, RealityCostType, -1); }
  public static void AddMinUnLockRate(FlatBufferBuilder builder, int MinUnLockRate) { builder.AddInt(7, MinUnLockRate, 0); }
  public static void AddMaxUnLockRate(FlatBufferBuilder builder, int MaxUnLockRate) { builder.AddInt(8, MaxUnLockRate, 0); }
  public static void AddUnLockRate(FlatBufferBuilder builder, int UnLockRate) { builder.AddInt(9, UnLockRate, 0); }
  public static void AddMinAddValueList(FlatBufferBuilder builder, VectorOffset MinAddValueListOffset) { builder.AddOffset(10, MinAddValueListOffset.Value, 0); }
  public static VectorOffset CreateMinAddValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMinAddValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxAddValueList(FlatBufferBuilder builder, VectorOffset MaxAddValueListOffset) { builder.AddOffset(11, MaxAddValueListOffset.Value, 0); }
  public static VectorOffset CreateMaxAddValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaxAddValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingWuHunNingHun> EndFB_JiLingWuHunNingHun(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingWuHunNingHun>(o);
  }
};

public sealed class FB_JiLingWuHunNingHunContainer : Table {
  public static FB_JiLingWuHunNingHunContainer GetRootAsFB_JiLingWuHunNingHunContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingWuHunNingHunContainer(_bb, new FB_JiLingWuHunNingHunContainer()); }
  public static FB_JiLingWuHunNingHunContainer GetRootAsFB_JiLingWuHunNingHunContainer(ByteBuffer _bb, FB_JiLingWuHunNingHunContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingWuHunNingHunContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingWuHunNingHunContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingWuHunNingHun GetItems(int j) { return GetItems(new FB_JiLingWuHunNingHun(), j); }
  public FB_JiLingWuHunNingHun GetItems(FB_JiLingWuHunNingHun obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingWuHunNingHunContainer> CreateFB_JiLingWuHunNingHunContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingWuHunNingHunContainer.AddItems(builder, items);
    return FB_JiLingWuHunNingHunContainer.EndFB_JiLingWuHunNingHunContainer(builder);
  }

  public static void StartFB_JiLingWuHunNingHunContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingWuHunNingHun>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingWuHunNingHunContainer> EndFB_JiLingWuHunNingHunContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingWuHunNingHunContainer>(o);
  }
  public static void FinishFB_JiLingWuHunNingHunContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingWuHunNingHunContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
