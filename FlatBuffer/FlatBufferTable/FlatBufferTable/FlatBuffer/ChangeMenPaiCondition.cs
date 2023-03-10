// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChangeMenPaiCondition : Table {
  public static FB_ChangeMenPaiCondition GetRootAsFB_ChangeMenPaiCondition(ByteBuffer _bb) { return GetRootAsFB_ChangeMenPaiCondition(_bb, new FB_ChangeMenPaiCondition()); }
  public static FB_ChangeMenPaiCondition GetRootAsFB_ChangeMenPaiCondition(ByteBuffer _bb, FB_ChangeMenPaiCondition obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChangeMenPaiCondition __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChangeMenPaiCondition> CreateFB_ChangeMenPaiCondition(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      int Param = -1) {
    builder.StartObject(3);
    FB_ChangeMenPaiCondition.AddParam(builder, Param);
    FB_ChangeMenPaiCondition.AddType(builder, Type);
    FB_ChangeMenPaiCondition.AddID(builder, ID);
    return FB_ChangeMenPaiCondition.EndFB_ChangeMenPaiCondition(builder);
  }

  public static void StartFB_ChangeMenPaiCondition(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(2, Param, -1); }
  public static Offset<FB_ChangeMenPaiCondition> EndFB_ChangeMenPaiCondition(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeMenPaiCondition>(o);
  }
};

public sealed class FB_ChangeMenPaiConditionContainer : Table {
  public static FB_ChangeMenPaiConditionContainer GetRootAsFB_ChangeMenPaiConditionContainer(ByteBuffer _bb) { return GetRootAsFB_ChangeMenPaiConditionContainer(_bb, new FB_ChangeMenPaiConditionContainer()); }
  public static FB_ChangeMenPaiConditionContainer GetRootAsFB_ChangeMenPaiConditionContainer(ByteBuffer _bb, FB_ChangeMenPaiConditionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChangeMenPaiConditionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChangeMenPaiConditionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChangeMenPaiCondition GetItems(int j) { return GetItems(new FB_ChangeMenPaiCondition(), j); }
  public FB_ChangeMenPaiCondition GetItems(FB_ChangeMenPaiCondition obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeMenPaiConditionContainer> CreateFB_ChangeMenPaiConditionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChangeMenPaiConditionContainer.AddItems(builder, items);
    return FB_ChangeMenPaiConditionContainer.EndFB_ChangeMenPaiConditionContainer(builder);
  }

  public static void StartFB_ChangeMenPaiConditionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChangeMenPaiCondition>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeMenPaiConditionContainer> EndFB_ChangeMenPaiConditionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeMenPaiConditionContainer>(o);
  }
  public static void FinishFB_ChangeMenPaiConditionContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChangeMenPaiConditionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
