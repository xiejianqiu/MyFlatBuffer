// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingEquipStar : Table {
  public static FB_HuanJingEquipStar GetRootAsFB_HuanJingEquipStar(ByteBuffer _bb) { return GetRootAsFB_HuanJingEquipStar(_bb, new FB_HuanJingEquipStar()); }
  public static FB_HuanJingEquipStar GetRootAsFB_HuanJingEquipStar(ByteBuffer _bb, FB_HuanJingEquipStar obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingEquipStar __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HuanJingEquipLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HuanJingEquipStar { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCostItemIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostItemCountList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemCountListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingEquipStar> CreateFB_HuanJingEquipStar(FlatBufferBuilder builder,
      int ID = 0,
      int HuanJingEquipLevel = -1,
      int HuanJingEquipStar = -1,
      VectorOffset CostItemIdList = default(VectorOffset),
      VectorOffset CostItemCountList = default(VectorOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_HuanJingEquipStar.AddAttrValueList(builder, AttrValueList);
    FB_HuanJingEquipStar.AddAttrIdList(builder, AttrIdList);
    FB_HuanJingEquipStar.AddCostItemCountList(builder, CostItemCountList);
    FB_HuanJingEquipStar.AddCostItemIdList(builder, CostItemIdList);
    FB_HuanJingEquipStar.AddHuanJingEquipStar(builder, HuanJingEquipStar);
    FB_HuanJingEquipStar.AddHuanJingEquipLevel(builder, HuanJingEquipLevel);
    FB_HuanJingEquipStar.AddID(builder, ID);
    return FB_HuanJingEquipStar.EndFB_HuanJingEquipStar(builder);
  }

  public static void StartFB_HuanJingEquipStar(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHuanJingEquipLevel(FlatBufferBuilder builder, int HuanJingEquipLevel) { builder.AddInt(1, HuanJingEquipLevel, -1); }
  public static void AddHuanJingEquipStar(FlatBufferBuilder builder, int HuanJingEquipStar) { builder.AddInt(2, HuanJingEquipStar, -1); }
  public static void AddCostItemIdList(FlatBufferBuilder builder, VectorOffset CostItemIdListOffset) { builder.AddOffset(3, CostItemIdListOffset.Value, 0); }
  public static VectorOffset CreateCostItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostItemCountList(FlatBufferBuilder builder, VectorOffset CostItemCountListOffset) { builder.AddOffset(4, CostItemCountListOffset.Value, 0); }
  public static VectorOffset CreateCostItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(5, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingEquipStar> EndFB_HuanJingEquipStar(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingEquipStar>(o);
  }
};

public sealed class FB_HuanJingEquipStarContainer : Table {
  public static FB_HuanJingEquipStarContainer GetRootAsFB_HuanJingEquipStarContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingEquipStarContainer(_bb, new FB_HuanJingEquipStarContainer()); }
  public static FB_HuanJingEquipStarContainer GetRootAsFB_HuanJingEquipStarContainer(ByteBuffer _bb, FB_HuanJingEquipStarContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingEquipStarContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingEquipStarContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingEquipStar GetItems(int j) { return GetItems(new FB_HuanJingEquipStar(), j); }
  public FB_HuanJingEquipStar GetItems(FB_HuanJingEquipStar obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingEquipStarContainer> CreateFB_HuanJingEquipStarContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingEquipStarContainer.AddItems(builder, items);
    return FB_HuanJingEquipStarContainer.EndFB_HuanJingEquipStarContainer(builder);
  }

  public static void StartFB_HuanJingEquipStarContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingEquipStar>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingEquipStarContainer> EndFB_HuanJingEquipStarContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingEquipStarContainer>(o);
  }
  public static void FinishFB_HuanJingEquipStarContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingEquipStarContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
