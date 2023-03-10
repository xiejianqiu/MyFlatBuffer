// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenYuPointAddition : Table {
  public static FB_ShenYuPointAddition GetRootAsFB_ShenYuPointAddition(ByteBuffer _bb) { return GetRootAsFB_ShenYuPointAddition(_bb, new FB_ShenYuPointAddition()); }
  public static FB_ShenYuPointAddition GetRootAsFB_ShenYuPointAddition(ByteBuffer _bb, FB_ShenYuPointAddition obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenYuPointAddition __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Count { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ImpactID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttrAdd { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ShenYuPointAddition> CreateFB_ShenYuPointAddition(FlatBufferBuilder builder,
      int ID = 0,
      int Count = -1,
      int ImpactID = -1,
      int AttrAdd = 0) {
    builder.StartObject(4);
    FB_ShenYuPointAddition.AddAttrAdd(builder, AttrAdd);
    FB_ShenYuPointAddition.AddImpactID(builder, ImpactID);
    FB_ShenYuPointAddition.AddCount(builder, Count);
    FB_ShenYuPointAddition.AddID(builder, ID);
    return FB_ShenYuPointAddition.EndFB_ShenYuPointAddition(builder);
  }

  public static void StartFB_ShenYuPointAddition(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCount(FlatBufferBuilder builder, int Count) { builder.AddInt(1, Count, -1); }
  public static void AddImpactID(FlatBufferBuilder builder, int ImpactID) { builder.AddInt(2, ImpactID, -1); }
  public static void AddAttrAdd(FlatBufferBuilder builder, int AttrAdd) { builder.AddInt(3, AttrAdd, 0); }
  public static Offset<FB_ShenYuPointAddition> EndFB_ShenYuPointAddition(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenYuPointAddition>(o);
  }
};

public sealed class FB_ShenYuPointAdditionContainer : Table {
  public static FB_ShenYuPointAdditionContainer GetRootAsFB_ShenYuPointAdditionContainer(ByteBuffer _bb) { return GetRootAsFB_ShenYuPointAdditionContainer(_bb, new FB_ShenYuPointAdditionContainer()); }
  public static FB_ShenYuPointAdditionContainer GetRootAsFB_ShenYuPointAdditionContainer(ByteBuffer _bb, FB_ShenYuPointAdditionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenYuPointAdditionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenYuPointAdditionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenYuPointAddition GetItems(int j) { return GetItems(new FB_ShenYuPointAddition(), j); }
  public FB_ShenYuPointAddition GetItems(FB_ShenYuPointAddition obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenYuPointAdditionContainer> CreateFB_ShenYuPointAdditionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenYuPointAdditionContainer.AddItems(builder, items);
    return FB_ShenYuPointAdditionContainer.EndFB_ShenYuPointAdditionContainer(builder);
  }

  public static void StartFB_ShenYuPointAdditionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenYuPointAddition>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenYuPointAdditionContainer> EndFB_ShenYuPointAdditionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenYuPointAdditionContainer>(o);
  }
  public static void FinishFB_ShenYuPointAdditionContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenYuPointAdditionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
