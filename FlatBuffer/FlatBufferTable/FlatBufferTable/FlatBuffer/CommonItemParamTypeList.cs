// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CommonItemParamTypeList : Table {
  public static FB_CommonItemParamTypeList GetRootAsFB_CommonItemParamTypeList(ByteBuffer _bb) { return GetRootAsFB_CommonItemParamTypeList(_bb, new FB_CommonItemParamTypeList()); }
  public static FB_CommonItemParamTypeList GetRootAsFB_CommonItemParamTypeList(ByteBuffer _bb, FB_CommonItemParamTypeList obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CommonItemParamTypeList __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetParamTypeList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamTypeListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CommonItemParamTypeList> CreateFB_CommonItemParamTypeList(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset ParamTypeList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_CommonItemParamTypeList.AddParamTypeList(builder, ParamTypeList);
    FB_CommonItemParamTypeList.AddId(builder, Id);
    return FB_CommonItemParamTypeList.EndFB_CommonItemParamTypeList(builder);
  }

  public static void StartFB_CommonItemParamTypeList(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddParamTypeList(FlatBufferBuilder builder, VectorOffset ParamTypeListOffset) { builder.AddOffset(1, ParamTypeListOffset.Value, 0); }
  public static VectorOffset CreateParamTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CommonItemParamTypeList> EndFB_CommonItemParamTypeList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CommonItemParamTypeList>(o);
  }
};

public sealed class FB_CommonItemParamTypeListContainer : Table {
  public static FB_CommonItemParamTypeListContainer GetRootAsFB_CommonItemParamTypeListContainer(ByteBuffer _bb) { return GetRootAsFB_CommonItemParamTypeListContainer(_bb, new FB_CommonItemParamTypeListContainer()); }
  public static FB_CommonItemParamTypeListContainer GetRootAsFB_CommonItemParamTypeListContainer(ByteBuffer _bb, FB_CommonItemParamTypeListContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CommonItemParamTypeListContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CommonItemParamTypeListContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CommonItemParamTypeList GetItems(int j) { return GetItems(new FB_CommonItemParamTypeList(), j); }
  public FB_CommonItemParamTypeList GetItems(FB_CommonItemParamTypeList obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CommonItemParamTypeListContainer> CreateFB_CommonItemParamTypeListContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CommonItemParamTypeListContainer.AddItems(builder, items);
    return FB_CommonItemParamTypeListContainer.EndFB_CommonItemParamTypeListContainer(builder);
  }

  public static void StartFB_CommonItemParamTypeListContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CommonItemParamTypeList>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CommonItemParamTypeListContainer> EndFB_CommonItemParamTypeListContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CommonItemParamTypeListContainer>(o);
  }
  public static void FinishFB_CommonItemParamTypeListContainerBuffer(FlatBufferBuilder builder, Offset<FB_CommonItemParamTypeListContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
