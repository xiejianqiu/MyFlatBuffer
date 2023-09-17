// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingGangBase : Table {
  public static FB_LingGangBase GetRootAsFB_LingGangBase(ByteBuffer _bb) { return GetRootAsFB_LingGangBase(_bb, new FB_LingGangBase()); }
  public static FB_LingGangBase GetRootAsFB_LingGangBase(ByteBuffer _bb, FB_LingGangBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingGangBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long Exp { get { int o = __offset(6); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int DamageDelPercent { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long MaxLingGangPoint { get { int o = __offset(14); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }

  public static Offset<FB_LingGangBase> CreateFB_LingGangBase(FlatBufferBuilder builder,
      int Id = 0,
      long Exp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      int DamageDelPercent = 0,
      long MaxLingGangPoint = 0) {
    builder.StartObject(6);
    FB_LingGangBase.AddMaxLingGangPoint(builder, MaxLingGangPoint);
    FB_LingGangBase.AddExp(builder, Exp);
    FB_LingGangBase.AddDamageDelPercent(builder, DamageDelPercent);
    FB_LingGangBase.AddAttrValueList(builder, AttrValueList);
    FB_LingGangBase.AddAttrIdList(builder, AttrIdList);
    FB_LingGangBase.AddId(builder, Id);
    return FB_LingGangBase.EndFB_LingGangBase(builder);
  }

  public static void StartFB_LingGangBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(1, Exp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDamageDelPercent(FlatBufferBuilder builder, int DamageDelPercent) { builder.AddInt(4, DamageDelPercent, 0); }
  public static void AddMaxLingGangPoint(FlatBufferBuilder builder, long MaxLingGangPoint) { builder.AddLong(5, MaxLingGangPoint, 0); }
  public static Offset<FB_LingGangBase> EndFB_LingGangBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangBase>(o);
  }
};

public sealed class FB_LingGangBaseContainer : Table {
  public static FB_LingGangBaseContainer GetRootAsFB_LingGangBaseContainer(ByteBuffer _bb) { return GetRootAsFB_LingGangBaseContainer(_bb, new FB_LingGangBaseContainer()); }
  public static FB_LingGangBaseContainer GetRootAsFB_LingGangBaseContainer(ByteBuffer _bb, FB_LingGangBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingGangBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingGangBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingGangBase GetItems(int j) { return GetItems(new FB_LingGangBase(), j); }
  public FB_LingGangBase GetItems(FB_LingGangBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingGangBaseContainer> CreateFB_LingGangBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingGangBaseContainer.AddItems(builder, items);
    return FB_LingGangBaseContainer.EndFB_LingGangBaseContainer(builder);
  }

  public static void StartFB_LingGangBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingGangBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingGangBaseContainer> EndFB_LingGangBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingGangBaseContainer>(o);
  }
  public static void FinishFB_LingGangBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingGangBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
