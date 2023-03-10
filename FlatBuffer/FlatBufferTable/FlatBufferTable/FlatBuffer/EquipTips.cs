// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipTips : Table {
  public static FB_EquipTips GetRootAsFB_EquipTips(ByteBuffer _bb) { return GetRootAsFB_EquipTips(_bb, new FB_EquipTips()); }
  public static FB_EquipTips GetRootAsFB_EquipTips(ByteBuffer _bb, FB_EquipTips obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipTips __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrValueList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int DiamondSet { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DiamondVIPSet { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipTips> CreateFB_EquipTips(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset AttrValueList = default(VectorOffset),
      int DiamondSet = -1,
      int DiamondVIPSet = -1) {
    builder.StartObject(4);
    FB_EquipTips.AddDiamondVIPSet(builder, DiamondVIPSet);
    FB_EquipTips.AddDiamondSet(builder, DiamondSet);
    FB_EquipTips.AddAttrValueList(builder, AttrValueList);
    FB_EquipTips.AddId(builder, Id);
    return FB_EquipTips.EndFB_EquipTips(builder);
  }

  public static void StartFB_EquipTips(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(1, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDiamondSet(FlatBufferBuilder builder, int DiamondSet) { builder.AddInt(2, DiamondSet, -1); }
  public static void AddDiamondVIPSet(FlatBufferBuilder builder, int DiamondVIPSet) { builder.AddInt(3, DiamondVIPSet, -1); }
  public static Offset<FB_EquipTips> EndFB_EquipTips(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipTips>(o);
  }
};

public sealed class FB_EquipTipsContainer : Table {
  public static FB_EquipTipsContainer GetRootAsFB_EquipTipsContainer(ByteBuffer _bb) { return GetRootAsFB_EquipTipsContainer(_bb, new FB_EquipTipsContainer()); }
  public static FB_EquipTipsContainer GetRootAsFB_EquipTipsContainer(ByteBuffer _bb, FB_EquipTipsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipTipsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipTipsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipTips GetItems(int j) { return GetItems(new FB_EquipTips(), j); }
  public FB_EquipTips GetItems(FB_EquipTips obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipTipsContainer> CreateFB_EquipTipsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipTipsContainer.AddItems(builder, items);
    return FB_EquipTipsContainer.EndFB_EquipTipsContainer(builder);
  }

  public static void StartFB_EquipTipsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipTips>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipTipsContainer> EndFB_EquipTipsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipTipsContainer>(o);
  }
  public static void FinishFB_EquipTipsContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipTipsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
