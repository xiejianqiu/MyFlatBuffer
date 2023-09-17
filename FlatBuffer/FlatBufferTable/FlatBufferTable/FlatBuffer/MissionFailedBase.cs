// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionFailedBase : Table {
  public static FB_MissionFailedBase GetRootAsFB_MissionFailedBase(ByteBuffer _bb) { return GetRootAsFB_MissionFailedBase(_bb, new FB_MissionFailedBase()); }
  public static FB_MissionFailedBase GetRootAsFB_MissionFailedBase(ByteBuffer _bb, FB_MissionFailedBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionFailedBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FailedCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetFailedIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FailedIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionFailedBase> CreateFB_MissionFailedBase(FlatBufferBuilder builder,
      int Id = 0,
      int FailedCount = -1,
      VectorOffset FailedIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_MissionFailedBase.AddFailedIDList(builder, FailedIDList);
    FB_MissionFailedBase.AddFailedCount(builder, FailedCount);
    FB_MissionFailedBase.AddId(builder, Id);
    return FB_MissionFailedBase.EndFB_MissionFailedBase(builder);
  }

  public static void StartFB_MissionFailedBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddFailedCount(FlatBufferBuilder builder, int FailedCount) { builder.AddInt(1, FailedCount, -1); }
  public static void AddFailedIDList(FlatBufferBuilder builder, VectorOffset FailedIDListOffset) { builder.AddOffset(2, FailedIDListOffset.Value, 0); }
  public static VectorOffset CreateFailedIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFailedIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionFailedBase> EndFB_MissionFailedBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionFailedBase>(o);
  }
};

public sealed class FB_MissionFailedBaseContainer : Table {
  public static FB_MissionFailedBaseContainer GetRootAsFB_MissionFailedBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MissionFailedBaseContainer(_bb, new FB_MissionFailedBaseContainer()); }
  public static FB_MissionFailedBaseContainer GetRootAsFB_MissionFailedBaseContainer(ByteBuffer _bb, FB_MissionFailedBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionFailedBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionFailedBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionFailedBase GetItems(int j) { return GetItems(new FB_MissionFailedBase(), j); }
  public FB_MissionFailedBase GetItems(FB_MissionFailedBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionFailedBaseContainer> CreateFB_MissionFailedBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionFailedBaseContainer.AddItems(builder, items);
    return FB_MissionFailedBaseContainer.EndFB_MissionFailedBaseContainer(builder);
  }

  public static void StartFB_MissionFailedBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionFailedBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionFailedBaseContainer> EndFB_MissionFailedBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionFailedBaseContainer>(o);
  }
  public static void FinishFB_MissionFailedBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionFailedBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
