// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MingGeBase : Table {
  public static FB_MingGeBase GetRootAsFB_MingGeBase(ByteBuffer _bb) { return GetRootAsFB_MingGeBase(_bb, new FB_MingGeBase()); }
  public static FB_MingGeBase GetRootAsFB_MingGeBase(ByteBuffer _bb, FB_MingGeBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MingGeBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int NeedItemId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedItemCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedMoneyType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedMoneyCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MingGeBase> CreateFB_MingGeBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int NeedItemId = -1,
      int NeedItemCount = -1,
      int NeedMoneyType = -1,
      int NeedMoneyCount = -1) {
    builder.StartObject(8);
    FB_MingGeBase.AddNeedMoneyCount(builder, NeedMoneyCount);
    FB_MingGeBase.AddNeedMoneyType(builder, NeedMoneyType);
    FB_MingGeBase.AddNeedItemCount(builder, NeedItemCount);
    FB_MingGeBase.AddNeedItemId(builder, NeedItemId);
    FB_MingGeBase.AddAttrValueList(builder, AttrValueList);
    FB_MingGeBase.AddAttrIdList(builder, AttrIdList);
    FB_MingGeBase.AddName(builder, Name);
    FB_MingGeBase.AddID(builder, ID);
    return FB_MingGeBase.EndFB_MingGeBase(builder);
  }

  public static void StartFB_MingGeBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNeedItemId(FlatBufferBuilder builder, int NeedItemId) { builder.AddInt(4, NeedItemId, -1); }
  public static void AddNeedItemCount(FlatBufferBuilder builder, int NeedItemCount) { builder.AddInt(5, NeedItemCount, -1); }
  public static void AddNeedMoneyType(FlatBufferBuilder builder, int NeedMoneyType) { builder.AddInt(6, NeedMoneyType, -1); }
  public static void AddNeedMoneyCount(FlatBufferBuilder builder, int NeedMoneyCount) { builder.AddInt(7, NeedMoneyCount, -1); }
  public static Offset<FB_MingGeBase> EndFB_MingGeBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MingGeBase>(o);
  }
};

public sealed class FB_MingGeBaseContainer : Table {
  public static FB_MingGeBaseContainer GetRootAsFB_MingGeBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MingGeBaseContainer(_bb, new FB_MingGeBaseContainer()); }
  public static FB_MingGeBaseContainer GetRootAsFB_MingGeBaseContainer(ByteBuffer _bb, FB_MingGeBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MingGeBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MingGeBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MingGeBase GetItems(int j) { return GetItems(new FB_MingGeBase(), j); }
  public FB_MingGeBase GetItems(FB_MingGeBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MingGeBaseContainer> CreateFB_MingGeBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MingGeBaseContainer.AddItems(builder, items);
    return FB_MingGeBaseContainer.EndFB_MingGeBaseContainer(builder);
  }

  public static void StartFB_MingGeBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MingGeBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MingGeBaseContainer> EndFB_MingGeBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MingGeBaseContainer>(o);
  }
  public static void FinishFB_MingGeBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MingGeBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
