// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarSoulUnitLevel : Table {
  public static FB_StarSoulUnitLevel GetRootAsFB_StarSoulUnitLevel(ByteBuffer _bb) { return GetRootAsFB_StarSoulUnitLevel(_bb, new FB_StarSoulUnitLevel()); }
  public static FB_StarSoulUnitLevel GetRootAsFB_StarSoulUnitLevel(ByteBuffer _bb, FB_StarSoulUnitLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarSoulUnitLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Attack { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CombatPower { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarSoulUnitLevel> CreateFB_StarSoulUnitLevel(FlatBufferBuilder builder,
      int ID = 0,
      int Attack = -1,
      int CombatPower = -1,
      int CostItemId = -1,
      int CostItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_StarSoulUnitLevel.AddAttrValueList(builder, AttrValueList);
    FB_StarSoulUnitLevel.AddAttrIdList(builder, AttrIdList);
    FB_StarSoulUnitLevel.AddCostItemCount(builder, CostItemCount);
    FB_StarSoulUnitLevel.AddCostItemId(builder, CostItemId);
    FB_StarSoulUnitLevel.AddCombatPower(builder, CombatPower);
    FB_StarSoulUnitLevel.AddAttack(builder, Attack);
    FB_StarSoulUnitLevel.AddID(builder, ID);
    return FB_StarSoulUnitLevel.EndFB_StarSoulUnitLevel(builder);
  }

  public static void StartFB_StarSoulUnitLevel(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAttack(FlatBufferBuilder builder, int Attack) { builder.AddInt(1, Attack, -1); }
  public static void AddCombatPower(FlatBufferBuilder builder, int CombatPower) { builder.AddInt(2, CombatPower, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(3, CostItemId, -1); }
  public static void AddCostItemCount(FlatBufferBuilder builder, int CostItemCount) { builder.AddInt(4, CostItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(5, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarSoulUnitLevel> EndFB_StarSoulUnitLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulUnitLevel>(o);
  }
};

public sealed class FB_StarSoulUnitLevelContainer : Table {
  public static FB_StarSoulUnitLevelContainer GetRootAsFB_StarSoulUnitLevelContainer(ByteBuffer _bb) { return GetRootAsFB_StarSoulUnitLevelContainer(_bb, new FB_StarSoulUnitLevelContainer()); }
  public static FB_StarSoulUnitLevelContainer GetRootAsFB_StarSoulUnitLevelContainer(ByteBuffer _bb, FB_StarSoulUnitLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarSoulUnitLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarSoulUnitLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarSoulUnitLevel GetItems(int j) { return GetItems(new FB_StarSoulUnitLevel(), j); }
  public FB_StarSoulUnitLevel GetItems(FB_StarSoulUnitLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarSoulUnitLevelContainer> CreateFB_StarSoulUnitLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarSoulUnitLevelContainer.AddItems(builder, items);
    return FB_StarSoulUnitLevelContainer.EndFB_StarSoulUnitLevelContainer(builder);
  }

  public static void StartFB_StarSoulUnitLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarSoulUnitLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarSoulUnitLevelContainer> EndFB_StarSoulUnitLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulUnitLevelContainer>(o);
  }
  public static void FinishFB_StarSoulUnitLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarSoulUnitLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
