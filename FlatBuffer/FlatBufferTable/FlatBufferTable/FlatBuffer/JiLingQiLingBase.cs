// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingQiLingBase : Table {
  public static FB_JiLingQiLingBase GetRootAsFB_JiLingQiLingBase(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingBase(_bb, new FB_JiLingQiLingBase()); }
  public static FB_JiLingQiLingBase GetRootAsFB_JiLingQiLingBase(ByteBuffer _bb, FB_JiLingQiLingBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingQiLingBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MaxStep { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }

  public static Offset<FB_JiLingQiLingBase> CreateFB_JiLingQiLingBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int MaxStep = 1) {
    builder.StartObject(3);
    FB_JiLingQiLingBase.AddMaxStep(builder, MaxStep);
    FB_JiLingQiLingBase.AddName(builder, Name);
    FB_JiLingQiLingBase.AddId(builder, Id);
    return FB_JiLingQiLingBase.EndFB_JiLingQiLingBase(builder);
  }

  public static void StartFB_JiLingQiLingBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMaxStep(FlatBufferBuilder builder, int MaxStep) { builder.AddInt(2, MaxStep, 1); }
  public static Offset<FB_JiLingQiLingBase> EndFB_JiLingQiLingBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingBase>(o);
  }
};

public sealed class FB_JiLingQiLingBaseContainer : Table {
  public static FB_JiLingQiLingBaseContainer GetRootAsFB_JiLingQiLingBaseContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingQiLingBaseContainer(_bb, new FB_JiLingQiLingBaseContainer()); }
  public static FB_JiLingQiLingBaseContainer GetRootAsFB_JiLingQiLingBaseContainer(ByteBuffer _bb, FB_JiLingQiLingBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingQiLingBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingQiLingBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingQiLingBase GetItems(int j) { return GetItems(new FB_JiLingQiLingBase(), j); }
  public FB_JiLingQiLingBase GetItems(FB_JiLingQiLingBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingQiLingBaseContainer> CreateFB_JiLingQiLingBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingQiLingBaseContainer.AddItems(builder, items);
    return FB_JiLingQiLingBaseContainer.EndFB_JiLingQiLingBaseContainer(builder);
  }

  public static void StartFB_JiLingQiLingBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingQiLingBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingQiLingBaseContainer> EndFB_JiLingQiLingBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingQiLingBaseContainer>(o);
  }
  public static void FinishFB_JiLingQiLingBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingQiLingBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
