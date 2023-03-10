// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunGeBase : Table {
  public static FB_HunGeBase GetRootAsFB_HunGeBase(ByteBuffer _bb) { return GetRootAsFB_HunGeBase(_bb, new FB_HunGeBase()); }
  public static FB_HunGeBase GetRootAsFB_HunGeBase(ByteBuffer _bb, FB_HunGeBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunGeBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public long NeedExp { get { int o = __offset(12); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int NeedItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedItemCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_HunGeBase> CreateFB_HunGeBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      long NeedExp = -1,
      int NeedItemId = -1,
      int NeedItemCount = -1) {
    builder.StartObject(7);
    FB_HunGeBase.AddNeedExp(builder, NeedExp);
    FB_HunGeBase.AddNeedItemCount(builder, NeedItemCount);
    FB_HunGeBase.AddNeedItemId(builder, NeedItemId);
    FB_HunGeBase.AddAttrValueList(builder, AttrValueList);
    FB_HunGeBase.AddAttrIdList(builder, AttrIdList);
    FB_HunGeBase.AddName(builder, Name);
    FB_HunGeBase.AddID(builder, ID);
    return FB_HunGeBase.EndFB_HunGeBase(builder);
  }

  public static void StartFB_HunGeBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNeedExp(FlatBufferBuilder builder, long NeedExp) { builder.AddLong(4, NeedExp, -1); }
  public static void AddNeedItemId(FlatBufferBuilder builder, int NeedItemId) { builder.AddInt(5, NeedItemId, -1); }
  public static void AddNeedItemCount(FlatBufferBuilder builder, int NeedItemCount) { builder.AddInt(6, NeedItemCount, -1); }
  public static Offset<FB_HunGeBase> EndFB_HunGeBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunGeBase>(o);
  }
};

public sealed class FB_HunGeBaseContainer : Table {
  public static FB_HunGeBaseContainer GetRootAsFB_HunGeBaseContainer(ByteBuffer _bb) { return GetRootAsFB_HunGeBaseContainer(_bb, new FB_HunGeBaseContainer()); }
  public static FB_HunGeBaseContainer GetRootAsFB_HunGeBaseContainer(ByteBuffer _bb, FB_HunGeBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunGeBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunGeBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunGeBase GetItems(int j) { return GetItems(new FB_HunGeBase(), j); }
  public FB_HunGeBase GetItems(FB_HunGeBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunGeBaseContainer> CreateFB_HunGeBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunGeBaseContainer.AddItems(builder, items);
    return FB_HunGeBaseContainer.EndFB_HunGeBaseContainer(builder);
  }

  public static void StartFB_HunGeBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunGeBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunGeBaseContainer> EndFB_HunGeBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunGeBaseContainer>(o);
  }
  public static void FinishFB_HunGeBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunGeBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
