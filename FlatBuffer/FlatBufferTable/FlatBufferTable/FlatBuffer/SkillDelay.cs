// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillDelay : Table {
  public static FB_SkillDelay GetRootAsFB_SkillDelay(ByteBuffer _bb) { return GetRootAsFB_SkillDelay(_bb, new FB_SkillDelay()); }
  public static FB_SkillDelay GetRootAsFB_SkillDelay(ByteBuffer _bb, FB_SkillDelay obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillDelay __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetStartTimeList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StartTimeListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetEndTimeList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EndTimeListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillDelay> CreateFB_SkillDelay(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset StartTimeList = default(VectorOffset),
      VectorOffset EndTimeList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_SkillDelay.AddEndTimeList(builder, EndTimeList);
    FB_SkillDelay.AddStartTimeList(builder, StartTimeList);
    FB_SkillDelay.AddId(builder, Id);
    return FB_SkillDelay.EndFB_SkillDelay(builder);
  }

  public static void StartFB_SkillDelay(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStartTimeList(FlatBufferBuilder builder, VectorOffset StartTimeListOffset) { builder.AddOffset(1, StartTimeListOffset.Value, 0); }
  public static VectorOffset CreateStartTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStartTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEndTimeList(FlatBufferBuilder builder, VectorOffset EndTimeListOffset) { builder.AddOffset(2, EndTimeListOffset.Value, 0); }
  public static VectorOffset CreateEndTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEndTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillDelay> EndFB_SkillDelay(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillDelay>(o);
  }
};

public sealed class FB_SkillDelayContainer : Table {
  public static FB_SkillDelayContainer GetRootAsFB_SkillDelayContainer(ByteBuffer _bb) { return GetRootAsFB_SkillDelayContainer(_bb, new FB_SkillDelayContainer()); }
  public static FB_SkillDelayContainer GetRootAsFB_SkillDelayContainer(ByteBuffer _bb, FB_SkillDelayContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillDelayContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillDelayContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillDelay GetItems(int j) { return GetItems(new FB_SkillDelay(), j); }
  public FB_SkillDelay GetItems(FB_SkillDelay obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillDelayContainer> CreateFB_SkillDelayContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillDelayContainer.AddItems(builder, items);
    return FB_SkillDelayContainer.EndFB_SkillDelayContainer(builder);
  }

  public static void StartFB_SkillDelayContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillDelay>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillDelayContainer> EndFB_SkillDelayContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillDelayContainer>(o);
  }
  public static void FinishFB_SkillDelayContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillDelayContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
