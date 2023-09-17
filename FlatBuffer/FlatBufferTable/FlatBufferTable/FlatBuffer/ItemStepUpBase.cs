// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ItemStepUpBase : Table {
  public static FB_ItemStepUpBase GetRootAsFB_ItemStepUpBase(ByteBuffer _bb) { return GetRootAsFB_ItemStepUpBase(_bb, new FB_ItemStepUpBase()); }
  public static FB_ItemStepUpBase GetRootAsFB_ItemStepUpBase(ByteBuffer _bb, FB_ItemStepUpBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ItemStepUpBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetCompoundIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CompoundIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemStepUpBase> CreateFB_ItemStepUpBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset CompoundIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_ItemStepUpBase.AddCompoundIDList(builder, CompoundIDList);
    FB_ItemStepUpBase.AddName(builder, Name);
    FB_ItemStepUpBase.AddID(builder, ID);
    return FB_ItemStepUpBase.EndFB_ItemStepUpBase(builder);
  }

  public static void StartFB_ItemStepUpBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddCompoundIDList(FlatBufferBuilder builder, VectorOffset CompoundIDListOffset) { builder.AddOffset(2, CompoundIDListOffset.Value, 0); }
  public static VectorOffset CreateCompoundIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCompoundIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemStepUpBase> EndFB_ItemStepUpBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemStepUpBase>(o);
  }
};

public sealed class FB_ItemStepUpBaseContainer : Table {
  public static FB_ItemStepUpBaseContainer GetRootAsFB_ItemStepUpBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ItemStepUpBaseContainer(_bb, new FB_ItemStepUpBaseContainer()); }
  public static FB_ItemStepUpBaseContainer GetRootAsFB_ItemStepUpBaseContainer(ByteBuffer _bb, FB_ItemStepUpBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ItemStepUpBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ItemStepUpBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ItemStepUpBase GetItems(int j) { return GetItems(new FB_ItemStepUpBase(), j); }
  public FB_ItemStepUpBase GetItems(FB_ItemStepUpBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemStepUpBaseContainer> CreateFB_ItemStepUpBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ItemStepUpBaseContainer.AddItems(builder, items);
    return FB_ItemStepUpBaseContainer.EndFB_ItemStepUpBaseContainer(builder);
  }

  public static void StartFB_ItemStepUpBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ItemStepUpBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemStepUpBaseContainer> EndFB_ItemStepUpBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemStepUpBaseContainer>(o);
  }
  public static void FinishFB_ItemStepUpBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ItemStepUpBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
