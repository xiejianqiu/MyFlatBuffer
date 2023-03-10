// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PugongCut : Table {
  public static FB_PugongCut GetRootAsFB_PugongCut(ByteBuffer _bb) { return GetRootAsFB_PugongCut(_bb, new FB_PugongCut()); }
  public static FB_PugongCut GetRootAsFB_PugongCut(ByteBuffer _bb, FB_PugongCut obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PugongCut __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float GetStepTimeList(int j) { int o = __offset(6); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int StepTimeListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PugongCut> CreateFB_PugongCut(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset StepTimeList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_PugongCut.AddStepTimeList(builder, StepTimeList);
    FB_PugongCut.AddId(builder, Id);
    return FB_PugongCut.EndFB_PugongCut(builder);
  }

  public static void StartFB_PugongCut(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStepTimeList(FlatBufferBuilder builder, VectorOffset StepTimeListOffset) { builder.AddOffset(1, StepTimeListOffset.Value, 0); }
  public static VectorOffset CreateStepTimeListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartStepTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PugongCut> EndFB_PugongCut(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PugongCut>(o);
  }
};

public sealed class FB_PugongCutContainer : Table {
  public static FB_PugongCutContainer GetRootAsFB_PugongCutContainer(ByteBuffer _bb) { return GetRootAsFB_PugongCutContainer(_bb, new FB_PugongCutContainer()); }
  public static FB_PugongCutContainer GetRootAsFB_PugongCutContainer(ByteBuffer _bb, FB_PugongCutContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PugongCutContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PugongCutContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PugongCut GetItems(int j) { return GetItems(new FB_PugongCut(), j); }
  public FB_PugongCut GetItems(FB_PugongCut obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PugongCutContainer> CreateFB_PugongCutContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PugongCutContainer.AddItems(builder, items);
    return FB_PugongCutContainer.EndFB_PugongCutContainer(builder);
  }

  public static void StartFB_PugongCutContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PugongCut>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PugongCutContainer> EndFB_PugongCutContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PugongCutContainer>(o);
  }
  public static void FinishFB_PugongCutContainerBuffer(FlatBufferBuilder builder, Offset<FB_PugongCutContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
