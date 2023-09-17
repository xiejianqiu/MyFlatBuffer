// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionFailedCondition : Table {
  public static FB_MissionFailedCondition GetRootAsFB_MissionFailedCondition(ByteBuffer _bb) { return GetRootAsFB_MissionFailedCondition(_bb, new FB_MissionFailedCondition()); }
  public static FB_MissionFailedCondition GetRootAsFB_MissionFailedCondition(ByteBuffer _bb, FB_MissionFailedCondition obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionFailedCondition __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionFailedCondition> CreateFB_MissionFailedCondition(FlatBufferBuilder builder,
      int Id = 0,
      int Type = -1,
      VectorOffset ParamList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_MissionFailedCondition.AddParamList(builder, ParamList);
    FB_MissionFailedCondition.AddType(builder, Type);
    FB_MissionFailedCondition.AddId(builder, Id);
    return FB_MissionFailedCondition.EndFB_MissionFailedCondition(builder);
  }

  public static void StartFB_MissionFailedCondition(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(2, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionFailedCondition> EndFB_MissionFailedCondition(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionFailedCondition>(o);
  }
};

public sealed class FB_MissionFailedConditionContainer : Table {
  public static FB_MissionFailedConditionContainer GetRootAsFB_MissionFailedConditionContainer(ByteBuffer _bb) { return GetRootAsFB_MissionFailedConditionContainer(_bb, new FB_MissionFailedConditionContainer()); }
  public static FB_MissionFailedConditionContainer GetRootAsFB_MissionFailedConditionContainer(ByteBuffer _bb, FB_MissionFailedConditionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionFailedConditionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionFailedConditionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionFailedCondition GetItems(int j) { return GetItems(new FB_MissionFailedCondition(), j); }
  public FB_MissionFailedCondition GetItems(FB_MissionFailedCondition obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionFailedConditionContainer> CreateFB_MissionFailedConditionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionFailedConditionContainer.AddItems(builder, items);
    return FB_MissionFailedConditionContainer.EndFB_MissionFailedConditionContainer(builder);
  }

  public static void StartFB_MissionFailedConditionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionFailedCondition>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionFailedConditionContainer> EndFB_MissionFailedConditionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionFailedConditionContainer>(o);
  }
  public static void FinishFB_MissionFailedConditionContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionFailedConditionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
