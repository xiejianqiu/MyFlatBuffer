// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryTitleBase : Table {
  public static FB_MarryTitleBase GetRootAsFB_MarryTitleBase(ByteBuffer _bb) { return GetRootAsFB_MarryTitleBase(_bb, new FB_MarryTitleBase()); }
  public static FB_MarryTitleBase GetRootAsFB_MarryTitleBase(ByteBuffer _bb, FB_MarryTitleBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryTitleBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TargetStep { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MarryTitleBase> CreateFB_MarryTitleBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int TargetStep = -1) {
    builder.StartObject(3);
    FB_MarryTitleBase.AddTargetStep(builder, TargetStep);
    FB_MarryTitleBase.AddName(builder, Name);
    FB_MarryTitleBase.AddID(builder, ID);
    return FB_MarryTitleBase.EndFB_MarryTitleBase(builder);
  }

  public static void StartFB_MarryTitleBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTargetStep(FlatBufferBuilder builder, int TargetStep) { builder.AddInt(2, TargetStep, -1); }
  public static Offset<FB_MarryTitleBase> EndFB_MarryTitleBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryTitleBase>(o);
  }
};

public sealed class FB_MarryTitleBaseContainer : Table {
  public static FB_MarryTitleBaseContainer GetRootAsFB_MarryTitleBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MarryTitleBaseContainer(_bb, new FB_MarryTitleBaseContainer()); }
  public static FB_MarryTitleBaseContainer GetRootAsFB_MarryTitleBaseContainer(ByteBuffer _bb, FB_MarryTitleBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryTitleBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryTitleBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryTitleBase GetItems(int j) { return GetItems(new FB_MarryTitleBase(), j); }
  public FB_MarryTitleBase GetItems(FB_MarryTitleBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryTitleBaseContainer> CreateFB_MarryTitleBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryTitleBaseContainer.AddItems(builder, items);
    return FB_MarryTitleBaseContainer.EndFB_MarryTitleBaseContainer(builder);
  }

  public static void StartFB_MarryTitleBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryTitleBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryTitleBaseContainer> EndFB_MarryTitleBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryTitleBaseContainer>(o);
  }
  public static void FinishFB_MarryTitleBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryTitleBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
