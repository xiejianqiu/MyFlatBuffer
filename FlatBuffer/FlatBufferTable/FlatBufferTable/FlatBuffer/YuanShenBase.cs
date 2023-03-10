// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_YuanShenBase : Table {
  public static FB_YuanShenBase GetRootAsFB_YuanShenBase(ByteBuffer _bb) { return GetRootAsFB_YuanShenBase(_bb, new FB_YuanShenBase()); }
  public static FB_YuanShenBase GetRootAsFB_YuanShenBase(ByteBuffer _bb, FB_YuanShenBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_YuanShenBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long Exp { get { int o = __offset(6); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int Jie { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NextJieLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YuanShenBase> CreateFB_YuanShenBase(FlatBufferBuilder builder,
      int ID = 0,
      long Exp = -1,
      int Jie = -1,
      int NextJieLevel = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_YuanShenBase.AddExp(builder, Exp);
    FB_YuanShenBase.AddAttrValueList(builder, AttrValueList);
    FB_YuanShenBase.AddAttrIdList(builder, AttrIdList);
    FB_YuanShenBase.AddNextJieLevel(builder, NextJieLevel);
    FB_YuanShenBase.AddJie(builder, Jie);
    FB_YuanShenBase.AddID(builder, ID);
    return FB_YuanShenBase.EndFB_YuanShenBase(builder);
  }

  public static void StartFB_YuanShenBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(1, Exp, -1); }
  public static void AddJie(FlatBufferBuilder builder, int Jie) { builder.AddInt(2, Jie, -1); }
  public static void AddNextJieLevel(FlatBufferBuilder builder, int NextJieLevel) { builder.AddInt(3, NextJieLevel, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_YuanShenBase> EndFB_YuanShenBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YuanShenBase>(o);
  }
};

public sealed class FB_YuanShenBaseContainer : Table {
  public static FB_YuanShenBaseContainer GetRootAsFB_YuanShenBaseContainer(ByteBuffer _bb) { return GetRootAsFB_YuanShenBaseContainer(_bb, new FB_YuanShenBaseContainer()); }
  public static FB_YuanShenBaseContainer GetRootAsFB_YuanShenBaseContainer(ByteBuffer _bb, FB_YuanShenBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_YuanShenBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_YuanShenBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_YuanShenBase GetItems(int j) { return GetItems(new FB_YuanShenBase(), j); }
  public FB_YuanShenBase GetItems(FB_YuanShenBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YuanShenBaseContainer> CreateFB_YuanShenBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_YuanShenBaseContainer.AddItems(builder, items);
    return FB_YuanShenBaseContainer.EndFB_YuanShenBaseContainer(builder);
  }

  public static void StartFB_YuanShenBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_YuanShenBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_YuanShenBaseContainer> EndFB_YuanShenBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YuanShenBaseContainer>(o);
  }
  public static void FinishFB_YuanShenBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_YuanShenBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
