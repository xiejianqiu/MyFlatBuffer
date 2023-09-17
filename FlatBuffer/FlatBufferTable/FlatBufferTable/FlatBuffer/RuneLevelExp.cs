// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RuneLevelExp : Table {
  public static FB_RuneLevelExp GetRootAsFB_RuneLevelExp(ByteBuffer _bb) { return GetRootAsFB_RuneLevelExp(_bb, new FB_RuneLevelExp()); }
  public static FB_RuneLevelExp GetRootAsFB_RuneLevelExp(ByteBuffer _bb, FB_RuneLevelExp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RuneLevelExp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetQualityList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int QualityListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RuneLevelExp> CreateFB_RuneLevelExp(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset QualityList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_RuneLevelExp.AddQualityList(builder, QualityList);
    FB_RuneLevelExp.AddID(builder, ID);
    return FB_RuneLevelExp.EndFB_RuneLevelExp(builder);
  }

  public static void StartFB_RuneLevelExp(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddQualityList(FlatBufferBuilder builder, VectorOffset QualityListOffset) { builder.AddOffset(1, QualityListOffset.Value, 0); }
  public static VectorOffset CreateQualityListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartQualityListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RuneLevelExp> EndFB_RuneLevelExp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneLevelExp>(o);
  }
};

public sealed class FB_RuneLevelExpContainer : Table {
  public static FB_RuneLevelExpContainer GetRootAsFB_RuneLevelExpContainer(ByteBuffer _bb) { return GetRootAsFB_RuneLevelExpContainer(_bb, new FB_RuneLevelExpContainer()); }
  public static FB_RuneLevelExpContainer GetRootAsFB_RuneLevelExpContainer(ByteBuffer _bb, FB_RuneLevelExpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RuneLevelExpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RuneLevelExpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RuneLevelExp GetItems(int j) { return GetItems(new FB_RuneLevelExp(), j); }
  public FB_RuneLevelExp GetItems(FB_RuneLevelExp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RuneLevelExpContainer> CreateFB_RuneLevelExpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RuneLevelExpContainer.AddItems(builder, items);
    return FB_RuneLevelExpContainer.EndFB_RuneLevelExpContainer(builder);
  }

  public static void StartFB_RuneLevelExpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RuneLevelExp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RuneLevelExpContainer> EndFB_RuneLevelExpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RuneLevelExpContainer>(o);
  }
  public static void FinishFB_RuneLevelExpContainerBuffer(FlatBufferBuilder builder, Offset<FB_RuneLevelExpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
