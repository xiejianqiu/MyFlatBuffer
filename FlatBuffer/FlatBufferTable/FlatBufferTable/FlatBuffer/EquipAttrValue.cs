// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipAttrValue : Table {
  public static FB_EquipAttrValue GetRootAsFB_EquipAttrValue(ByteBuffer _bb) { return GetRootAsFB_EquipAttrValue(_bb, new FB_EquipAttrValue()); }
  public static FB_EquipAttrValue GetRootAsFB_EquipAttrValue(ByteBuffer _bb, FB_EquipAttrValue obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipAttrValue __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMaxAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaxAttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipAttrValue> CreateFB_EquipAttrValue(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset MaxAttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_EquipAttrValue.AddMaxAttrValueList(builder, MaxAttrValueList);
    FB_EquipAttrValue.AddAttrValueList(builder, AttrValueList);
    FB_EquipAttrValue.AddAttrIdList(builder, AttrIdList);
    FB_EquipAttrValue.AddId(builder, Id);
    return FB_EquipAttrValue.EndFB_EquipAttrValue(builder);
  }

  public static void StartFB_EquipAttrValue(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(1, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(2, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxAttrValueList(FlatBufferBuilder builder, VectorOffset MaxAttrValueListOffset) { builder.AddOffset(3, MaxAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateMaxAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaxAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipAttrValue> EndFB_EquipAttrValue(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipAttrValue>(o);
  }
};

public sealed class FB_EquipAttrValueContainer : Table {
  public static FB_EquipAttrValueContainer GetRootAsFB_EquipAttrValueContainer(ByteBuffer _bb) { return GetRootAsFB_EquipAttrValueContainer(_bb, new FB_EquipAttrValueContainer()); }
  public static FB_EquipAttrValueContainer GetRootAsFB_EquipAttrValueContainer(ByteBuffer _bb, FB_EquipAttrValueContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipAttrValueContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipAttrValueContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipAttrValue GetItems(int j) { return GetItems(new FB_EquipAttrValue(), j); }
  public FB_EquipAttrValue GetItems(FB_EquipAttrValue obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipAttrValueContainer> CreateFB_EquipAttrValueContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipAttrValueContainer.AddItems(builder, items);
    return FB_EquipAttrValueContainer.EndFB_EquipAttrValueContainer(builder);
  }

  public static void StartFB_EquipAttrValueContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipAttrValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipAttrValueContainer> EndFB_EquipAttrValueContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipAttrValueContainer>(o);
  }
  public static void FinishFB_EquipAttrValueContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipAttrValueContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
