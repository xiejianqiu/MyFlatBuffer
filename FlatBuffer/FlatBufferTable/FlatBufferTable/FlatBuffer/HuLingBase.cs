// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuLingBase : Table {
  public static FB_HuLingBase GetRootAsFB_HuLingBase(ByteBuffer _bb) { return GetRootAsFB_HuLingBase(_bb, new FB_HuLingBase()); }
  public static FB_HuLingBase GetRootAsFB_HuLingBase(ByteBuffer _bb, FB_HuLingBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuLingBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MoneyType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuLingBase> CreateFB_HuLingBase(FlatBufferBuilder builder,
      int ID = 0,
      int MoneyType = -1,
      int MoneyNum = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_HuLingBase.AddAttrValueList(builder, AttrValueList);
    FB_HuLingBase.AddAttrIdList(builder, AttrIdList);
    FB_HuLingBase.AddMoneyNum(builder, MoneyNum);
    FB_HuLingBase.AddMoneyType(builder, MoneyType);
    FB_HuLingBase.AddID(builder, ID);
    return FB_HuLingBase.EndFB_HuLingBase(builder);
  }

  public static void StartFB_HuLingBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(1, MoneyType, -1); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(2, MoneyNum, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(3, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuLingBase> EndFB_HuLingBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuLingBase>(o);
  }
};

public sealed class FB_HuLingBaseContainer : Table {
  public static FB_HuLingBaseContainer GetRootAsFB_HuLingBaseContainer(ByteBuffer _bb) { return GetRootAsFB_HuLingBaseContainer(_bb, new FB_HuLingBaseContainer()); }
  public static FB_HuLingBaseContainer GetRootAsFB_HuLingBaseContainer(ByteBuffer _bb, FB_HuLingBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuLingBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuLingBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuLingBase GetItems(int j) { return GetItems(new FB_HuLingBase(), j); }
  public FB_HuLingBase GetItems(FB_HuLingBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuLingBaseContainer> CreateFB_HuLingBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuLingBaseContainer.AddItems(builder, items);
    return FB_HuLingBaseContainer.EndFB_HuLingBaseContainer(builder);
  }

  public static void StartFB_HuLingBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuLingBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuLingBaseContainer> EndFB_HuLingBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuLingBaseContainer>(o);
  }
  public static void FinishFB_HuLingBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuLingBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
