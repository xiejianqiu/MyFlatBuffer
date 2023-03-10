// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipExtraAttr : Table {
  public static FB_EquipExtraAttr GetRootAsFB_EquipExtraAttr(ByteBuffer _bb) { return GetRootAsFB_EquipExtraAttr(_bb, new FB_EquipExtraAttr()); }
  public static FB_EquipExtraAttr GetRootAsFB_EquipExtraAttr(ByteBuffer _bb, FB_EquipExtraAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipExtraAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipExtraAttr> CreateFB_EquipExtraAttr(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset AttrList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_EquipExtraAttr.AddAttrList(builder, AttrList);
    FB_EquipExtraAttr.AddId(builder, Id);
    return FB_EquipExtraAttr.EndFB_EquipExtraAttr(builder);
  }

  public static void StartFB_EquipExtraAttr(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAttrList(FlatBufferBuilder builder, VectorOffset AttrListOffset) { builder.AddOffset(1, AttrListOffset.Value, 0); }
  public static VectorOffset CreateAttrListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipExtraAttr> EndFB_EquipExtraAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipExtraAttr>(o);
  }
};

public sealed class FB_EquipExtraAttrContainer : Table {
  public static FB_EquipExtraAttrContainer GetRootAsFB_EquipExtraAttrContainer(ByteBuffer _bb) { return GetRootAsFB_EquipExtraAttrContainer(_bb, new FB_EquipExtraAttrContainer()); }
  public static FB_EquipExtraAttrContainer GetRootAsFB_EquipExtraAttrContainer(ByteBuffer _bb, FB_EquipExtraAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipExtraAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipExtraAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipExtraAttr GetItems(int j) { return GetItems(new FB_EquipExtraAttr(), j); }
  public FB_EquipExtraAttr GetItems(FB_EquipExtraAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipExtraAttrContainer> CreateFB_EquipExtraAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipExtraAttrContainer.AddItems(builder, items);
    return FB_EquipExtraAttrContainer.EndFB_EquipExtraAttrContainer(builder);
  }

  public static void StartFB_EquipExtraAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipExtraAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipExtraAttrContainer> EndFB_EquipExtraAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipExtraAttrContainer>(o);
  }
  public static void FinishFB_EquipExtraAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipExtraAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
