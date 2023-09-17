// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingGangLingWuLevelUp : Table {
  public static FB_LingGangLingWuLevelUp GetRootAsFB_LingGangLingWuLevelUp(ByteBuffer _bb) { return GetRootAsFB_LingGangLingWuLevelUp(_bb, new FB_LingGangLingWuLevelUp()); }
  public static FB_LingGangLingWuLevelUp GetRootAsFB_LingGangLingWuLevelUp(ByteBuffer _bb, FB_LingGangLingWuLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingGangLingWuLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CostPoint { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangLingWuLevelUp> CreateFB_LingGangLingWuLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int CostPoint = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_LingGangLingWuLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_LingGangLingWuLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_LingGangLingWuLevelUp.AddCostPoint(builder, CostPoint);
    FB_LingGangLingWuLevelUp.AddId(builder, Id);
    return FB_LingGangLingWuLevelUp.EndFB_LingGangLingWuLevelUp(builder);
  }

  public static void StartFB_LingGangLingWuLevelUp(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCostPoint(FlatBufferBuilder builder, int CostPoint) { builder.AddInt(1, CostPoint, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangLingWuLevelUp> EndFB_LingGangLingWuLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangLingWuLevelUp>(o);
  }
};

public sealed class FB_LingGangLingWuLevelUpContainer : Table {
  public static FB_LingGangLingWuLevelUpContainer GetRootAsFB_LingGangLingWuLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_LingGangLingWuLevelUpContainer(_bb, new FB_LingGangLingWuLevelUpContainer()); }
  public static FB_LingGangLingWuLevelUpContainer GetRootAsFB_LingGangLingWuLevelUpContainer(ByteBuffer _bb, FB_LingGangLingWuLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingGangLingWuLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingGangLingWuLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingGangLingWuLevelUp GetItems(int j) { return GetItems(new FB_LingGangLingWuLevelUp(), j); }
  public FB_LingGangLingWuLevelUp GetItems(FB_LingGangLingWuLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangLingWuLevelUpContainer> CreateFB_LingGangLingWuLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingGangLingWuLevelUpContainer.AddItems(builder, items);
    return FB_LingGangLingWuLevelUpContainer.EndFB_LingGangLingWuLevelUpContainer(builder);
  }

  public static void StartFB_LingGangLingWuLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingGangLingWuLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangLingWuLevelUpContainer> EndFB_LingGangLingWuLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangLingWuLevelUpContainer>(o);
  }
  public static void FinishFB_LingGangLingWuLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingGangLingWuLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
