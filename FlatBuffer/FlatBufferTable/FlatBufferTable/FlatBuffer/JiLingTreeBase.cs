// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingTreeBase : Table {
  public static FB_JiLingTreeBase GetRootAsFB_JiLingTreeBase(ByteBuffer _bb) { return GetRootAsFB_JiLingTreeBase(_bb, new FB_JiLingTreeBase()); }
  public static FB_JiLingTreeBase GetRootAsFB_JiLingTreeBase(ByteBuffer _bb, FB_JiLingTreeBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingTreeBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsOpen { get { int o = __offset(6); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_JiLingTreeBase> CreateFB_JiLingTreeBase(FlatBufferBuilder builder,
      int ID = 0,
      bool IsOpen = false) {
    builder.StartObject(2);
    FB_JiLingTreeBase.AddID(builder, ID);
    FB_JiLingTreeBase.AddIsOpen(builder, IsOpen);
    return FB_JiLingTreeBase.EndFB_JiLingTreeBase(builder);
  }

  public static void StartFB_JiLingTreeBase(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddIsOpen(FlatBufferBuilder builder, bool IsOpen) { builder.AddBool(1, IsOpen, false); }
  public static Offset<FB_JiLingTreeBase> EndFB_JiLingTreeBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingTreeBase>(o);
  }
};

public sealed class FB_JiLingTreeBaseContainer : Table {
  public static FB_JiLingTreeBaseContainer GetRootAsFB_JiLingTreeBaseContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingTreeBaseContainer(_bb, new FB_JiLingTreeBaseContainer()); }
  public static FB_JiLingTreeBaseContainer GetRootAsFB_JiLingTreeBaseContainer(ByteBuffer _bb, FB_JiLingTreeBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingTreeBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingTreeBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingTreeBase GetItems(int j) { return GetItems(new FB_JiLingTreeBase(), j); }
  public FB_JiLingTreeBase GetItems(FB_JiLingTreeBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingTreeBaseContainer> CreateFB_JiLingTreeBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingTreeBaseContainer.AddItems(builder, items);
    return FB_JiLingTreeBaseContainer.EndFB_JiLingTreeBaseContainer(builder);
  }

  public static void StartFB_JiLingTreeBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingTreeBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingTreeBaseContainer> EndFB_JiLingTreeBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingTreeBaseContainer>(o);
  }
  public static void FinishFB_JiLingTreeBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingTreeBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
