// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_teQuanEnum : Table {
  public static FB_teQuanEnum GetRootAsFB_teQuanEnum(ByteBuffer _bb) { return GetRootAsFB_teQuanEnum(_bb, new FB_teQuanEnum()); }
  public static FB_teQuanEnum GetRootAsFB_teQuanEnum(ByteBuffer _bb, FB_teQuanEnum obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_teQuanEnum __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_teQuanEnum> CreateFB_teQuanEnum(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_teQuanEnum.AddAttrValueList(builder, AttrValueList);
    FB_teQuanEnum.AddAttrIdList(builder, AttrIdList);
    FB_teQuanEnum.AddName(builder, Name);
    FB_teQuanEnum.AddId(builder, Id);
    return FB_teQuanEnum.EndFB_teQuanEnum(builder);
  }

  public static void StartFB_teQuanEnum(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_teQuanEnum> EndFB_teQuanEnum(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_teQuanEnum>(o);
  }
};

public sealed class FB_teQuanEnumContainer : Table {
  public static FB_teQuanEnumContainer GetRootAsFB_teQuanEnumContainer(ByteBuffer _bb) { return GetRootAsFB_teQuanEnumContainer(_bb, new FB_teQuanEnumContainer()); }
  public static FB_teQuanEnumContainer GetRootAsFB_teQuanEnumContainer(ByteBuffer _bb, FB_teQuanEnumContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_teQuanEnumContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_teQuanEnumContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_teQuanEnum GetItems(int j) { return GetItems(new FB_teQuanEnum(), j); }
  public FB_teQuanEnum GetItems(FB_teQuanEnum obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_teQuanEnumContainer> CreateFB_teQuanEnumContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_teQuanEnumContainer.AddItems(builder, items);
    return FB_teQuanEnumContainer.EndFB_teQuanEnumContainer(builder);
  }

  public static void StartFB_teQuanEnumContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_teQuanEnum>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_teQuanEnumContainer> EndFB_teQuanEnumContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_teQuanEnumContainer>(o);
  }
  public static void FinishFB_teQuanEnumContainerBuffer(FlatBufferBuilder builder, Offset<FB_teQuanEnumContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
