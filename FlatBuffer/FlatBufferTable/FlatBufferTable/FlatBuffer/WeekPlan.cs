// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WeekPlan : Table {
  public static FB_WeekPlan GetRootAsFB_WeekPlan(ByteBuffer _bb) { return GetRootAsFB_WeekPlan(_bb, new FB_WeekPlan()); }
  public static FB_WeekPlan GetRootAsFB_WeekPlan(ByteBuffer _bb, FB_WeekPlan obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WeekPlan __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetTimeList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TimeListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WeekPlan> CreateFB_WeekPlan(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset TimeList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_WeekPlan.AddTimeList(builder, TimeList);
    FB_WeekPlan.AddId(builder, Id);
    return FB_WeekPlan.EndFB_WeekPlan(builder);
  }

  public static void StartFB_WeekPlan(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTimeList(FlatBufferBuilder builder, VectorOffset TimeListOffset) { builder.AddOffset(1, TimeListOffset.Value, 0); }
  public static VectorOffset CreateTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WeekPlan> EndFB_WeekPlan(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WeekPlan>(o);
  }
};

public sealed class FB_WeekPlanContainer : Table {
  public static FB_WeekPlanContainer GetRootAsFB_WeekPlanContainer(ByteBuffer _bb) { return GetRootAsFB_WeekPlanContainer(_bb, new FB_WeekPlanContainer()); }
  public static FB_WeekPlanContainer GetRootAsFB_WeekPlanContainer(ByteBuffer _bb, FB_WeekPlanContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WeekPlanContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WeekPlanContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WeekPlan GetItems(int j) { return GetItems(new FB_WeekPlan(), j); }
  public FB_WeekPlan GetItems(FB_WeekPlan obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WeekPlanContainer> CreateFB_WeekPlanContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WeekPlanContainer.AddItems(builder, items);
    return FB_WeekPlanContainer.EndFB_WeekPlanContainer(builder);
  }

  public static void StartFB_WeekPlanContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WeekPlan>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WeekPlanContainer> EndFB_WeekPlanContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WeekPlanContainer>(o);
  }
  public static void FinishFB_WeekPlanContainerBuffer(FlatBufferBuilder builder, Offset<FB_WeekPlanContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
