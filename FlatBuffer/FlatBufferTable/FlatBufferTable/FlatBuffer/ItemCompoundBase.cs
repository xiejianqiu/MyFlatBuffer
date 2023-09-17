// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ItemCompoundBase : Table {
  public static FB_ItemCompoundBase GetRootAsFB_ItemCompoundBase(ByteBuffer _bb) { return GetRootAsFB_ItemCompoundBase(_bb, new FB_ItemCompoundBase()); }
  public static FB_ItemCompoundBase GetRootAsFB_ItemCompoundBase(ByteBuffer _bb, FB_ItemCompoundBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ItemCompoundBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRequireIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RequireIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRequireNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RequireNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int CompoundID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CompoundNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Rate { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostValue { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelVisible { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrIdManual { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WuHunCostType { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WuHunCostValue { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ItemCompoundBase> CreateFB_ItemCompoundBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      VectorOffset RequireIDList = default(VectorOffset),
      VectorOffset RequireNumList = default(VectorOffset),
      int CompoundID = -1,
      int CompoundNum = -1,
      int Rate = -1,
      int CostType = -1,
      int CostValue = -1,
      int LevelVisible = -1,
      int StrIdManual = -1,
      int WuHunCostType = -1,
      int WuHunCostValue = -1) {
    builder.StartObject(14);
    FB_ItemCompoundBase.AddWuHunCostValue(builder, WuHunCostValue);
    FB_ItemCompoundBase.AddWuHunCostType(builder, WuHunCostType);
    FB_ItemCompoundBase.AddStrIdManual(builder, StrIdManual);
    FB_ItemCompoundBase.AddLevelVisible(builder, LevelVisible);
    FB_ItemCompoundBase.AddCostValue(builder, CostValue);
    FB_ItemCompoundBase.AddCostType(builder, CostType);
    FB_ItemCompoundBase.AddRate(builder, Rate);
    FB_ItemCompoundBase.AddCompoundNum(builder, CompoundNum);
    FB_ItemCompoundBase.AddCompoundID(builder, CompoundID);
    FB_ItemCompoundBase.AddRequireNumList(builder, RequireNumList);
    FB_ItemCompoundBase.AddRequireIDList(builder, RequireIDList);
    FB_ItemCompoundBase.AddType(builder, Type);
    FB_ItemCompoundBase.AddName(builder, Name);
    FB_ItemCompoundBase.AddID(builder, ID);
    return FB_ItemCompoundBase.EndFB_ItemCompoundBase(builder);
  }

  public static void StartFB_ItemCompoundBase(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddRequireIDList(FlatBufferBuilder builder, VectorOffset RequireIDListOffset) { builder.AddOffset(3, RequireIDListOffset.Value, 0); }
  public static VectorOffset CreateRequireIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRequireIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRequireNumList(FlatBufferBuilder builder, VectorOffset RequireNumListOffset) { builder.AddOffset(4, RequireNumListOffset.Value, 0); }
  public static VectorOffset CreateRequireNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRequireNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCompoundID(FlatBufferBuilder builder, int CompoundID) { builder.AddInt(5, CompoundID, -1); }
  public static void AddCompoundNum(FlatBufferBuilder builder, int CompoundNum) { builder.AddInt(6, CompoundNum, -1); }
  public static void AddRate(FlatBufferBuilder builder, int Rate) { builder.AddInt(7, Rate, -1); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(8, CostType, -1); }
  public static void AddCostValue(FlatBufferBuilder builder, int CostValue) { builder.AddInt(9, CostValue, -1); }
  public static void AddLevelVisible(FlatBufferBuilder builder, int LevelVisible) { builder.AddInt(10, LevelVisible, -1); }
  public static void AddStrIdManual(FlatBufferBuilder builder, int StrIdManual) { builder.AddInt(11, StrIdManual, -1); }
  public static void AddWuHunCostType(FlatBufferBuilder builder, int WuHunCostType) { builder.AddInt(12, WuHunCostType, -1); }
  public static void AddWuHunCostValue(FlatBufferBuilder builder, int WuHunCostValue) { builder.AddInt(13, WuHunCostValue, -1); }
  public static Offset<FB_ItemCompoundBase> EndFB_ItemCompoundBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemCompoundBase>(o);
  }
};

public sealed class FB_ItemCompoundBaseContainer : Table {
  public static FB_ItemCompoundBaseContainer GetRootAsFB_ItemCompoundBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ItemCompoundBaseContainer(_bb, new FB_ItemCompoundBaseContainer()); }
  public static FB_ItemCompoundBaseContainer GetRootAsFB_ItemCompoundBaseContainer(ByteBuffer _bb, FB_ItemCompoundBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ItemCompoundBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ItemCompoundBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ItemCompoundBase GetItems(int j) { return GetItems(new FB_ItemCompoundBase(), j); }
  public FB_ItemCompoundBase GetItems(FB_ItemCompoundBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemCompoundBaseContainer> CreateFB_ItemCompoundBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ItemCompoundBaseContainer.AddItems(builder, items);
    return FB_ItemCompoundBaseContainer.EndFB_ItemCompoundBaseContainer(builder);
  }

  public static void StartFB_ItemCompoundBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ItemCompoundBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemCompoundBaseContainer> EndFB_ItemCompoundBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemCompoundBaseContainer>(o);
  }
  public static void FinishFB_ItemCompoundBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ItemCompoundBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
