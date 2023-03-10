// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChangeJob8ComprehendUp : Table {
  public static FB_ChangeJob8ComprehendUp GetRootAsFB_ChangeJob8ComprehendUp(ByteBuffer _bb) { return GetRootAsFB_ChangeJob8ComprehendUp(_bb, new FB_ChangeJob8ComprehendUp()); }
  public static FB_ChangeJob8ComprehendUp GetRootAsFB_ChangeJob8ComprehendUp(ByteBuffer _bb, FB_ChangeJob8ComprehendUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChangeJob8ComprehendUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string PartName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ComprehendPos { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActiveProgressNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostItemNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeJob8ComprehendUp> CreateFB_ChangeJob8ComprehendUp(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset PartName = default(StringOffset),
      int ComprehendPos = -1,
      int ActiveProgressNum = -1,
      int CostItemId = -1,
      int CostItemNum = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_ChangeJob8ComprehendUp.AddAttrValueList(builder, AttrValueList);
    FB_ChangeJob8ComprehendUp.AddAttrIdList(builder, AttrIdList);
    FB_ChangeJob8ComprehendUp.AddCostItemNum(builder, CostItemNum);
    FB_ChangeJob8ComprehendUp.AddCostItemId(builder, CostItemId);
    FB_ChangeJob8ComprehendUp.AddActiveProgressNum(builder, ActiveProgressNum);
    FB_ChangeJob8ComprehendUp.AddComprehendPos(builder, ComprehendPos);
    FB_ChangeJob8ComprehendUp.AddPartName(builder, PartName);
    FB_ChangeJob8ComprehendUp.AddId(builder, Id);
    return FB_ChangeJob8ComprehendUp.EndFB_ChangeJob8ComprehendUp(builder);
  }

  public static void StartFB_ChangeJob8ComprehendUp(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPartName(FlatBufferBuilder builder, StringOffset PartNameOffset) { builder.AddOffset(1, PartNameOffset.Value, 0); }
  public static void AddComprehendPos(FlatBufferBuilder builder, int ComprehendPos) { builder.AddInt(2, ComprehendPos, -1); }
  public static void AddActiveProgressNum(FlatBufferBuilder builder, int ActiveProgressNum) { builder.AddInt(3, ActiveProgressNum, -1); }
  public static void AddCostItemId(FlatBufferBuilder builder, int CostItemId) { builder.AddInt(4, CostItemId, -1); }
  public static void AddCostItemNum(FlatBufferBuilder builder, int CostItemNum) { builder.AddInt(5, CostItemNum, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(6, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(7, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeJob8ComprehendUp> EndFB_ChangeJob8ComprehendUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJob8ComprehendUp>(o);
  }
};

public sealed class FB_ChangeJob8ComprehendUpContainer : Table {
  public static FB_ChangeJob8ComprehendUpContainer GetRootAsFB_ChangeJob8ComprehendUpContainer(ByteBuffer _bb) { return GetRootAsFB_ChangeJob8ComprehendUpContainer(_bb, new FB_ChangeJob8ComprehendUpContainer()); }
  public static FB_ChangeJob8ComprehendUpContainer GetRootAsFB_ChangeJob8ComprehendUpContainer(ByteBuffer _bb, FB_ChangeJob8ComprehendUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChangeJob8ComprehendUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChangeJob8ComprehendUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChangeJob8ComprehendUp GetItems(int j) { return GetItems(new FB_ChangeJob8ComprehendUp(), j); }
  public FB_ChangeJob8ComprehendUp GetItems(FB_ChangeJob8ComprehendUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeJob8ComprehendUpContainer> CreateFB_ChangeJob8ComprehendUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChangeJob8ComprehendUpContainer.AddItems(builder, items);
    return FB_ChangeJob8ComprehendUpContainer.EndFB_ChangeJob8ComprehendUpContainer(builder);
  }

  public static void StartFB_ChangeJob8ComprehendUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChangeJob8ComprehendUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeJob8ComprehendUpContainer> EndFB_ChangeJob8ComprehendUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJob8ComprehendUpContainer>(o);
  }
  public static void FinishFB_ChangeJob8ComprehendUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChangeJob8ComprehendUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
