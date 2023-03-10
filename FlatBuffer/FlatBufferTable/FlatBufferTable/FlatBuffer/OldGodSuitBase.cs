// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OldGodSuitBase : Table {
  public static FB_OldGodSuitBase GetRootAsFB_OldGodSuitBase(ByteBuffer _bb) { return GetRootAsFB_OldGodSuitBase(_bb, new FB_OldGodSuitBase()); }
  public static FB_OldGodSuitBase GetRootAsFB_OldGodSuitBase(ByteBuffer _bb, FB_OldGodSuitBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OldGodSuitBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TagName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GodId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetSuitIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SuitIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodSuitBase> CreateFB_OldGodSuitBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset TagName = default(StringOffset),
      int GodId = 0,
      VectorOffset SuitIDList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_OldGodSuitBase.AddSuitIDList(builder, SuitIDList);
    FB_OldGodSuitBase.AddGodId(builder, GodId);
    FB_OldGodSuitBase.AddTagName(builder, TagName);
    FB_OldGodSuitBase.AddName(builder, Name);
    FB_OldGodSuitBase.AddID(builder, ID);
    return FB_OldGodSuitBase.EndFB_OldGodSuitBase(builder);
  }

  public static void StartFB_OldGodSuitBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTagName(FlatBufferBuilder builder, StringOffset TagNameOffset) { builder.AddOffset(2, TagNameOffset.Value, 0); }
  public static void AddGodId(FlatBufferBuilder builder, int GodId) { builder.AddInt(3, GodId, 0); }
  public static void AddSuitIDList(FlatBufferBuilder builder, VectorOffset SuitIDListOffset) { builder.AddOffset(4, SuitIDListOffset.Value, 0); }
  public static VectorOffset CreateSuitIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSuitIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodSuitBase> EndFB_OldGodSuitBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodSuitBase>(o);
  }
};

public sealed class FB_OldGodSuitBaseContainer : Table {
  public static FB_OldGodSuitBaseContainer GetRootAsFB_OldGodSuitBaseContainer(ByteBuffer _bb) { return GetRootAsFB_OldGodSuitBaseContainer(_bb, new FB_OldGodSuitBaseContainer()); }
  public static FB_OldGodSuitBaseContainer GetRootAsFB_OldGodSuitBaseContainer(ByteBuffer _bb, FB_OldGodSuitBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OldGodSuitBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OldGodSuitBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OldGodSuitBase GetItems(int j) { return GetItems(new FB_OldGodSuitBase(), j); }
  public FB_OldGodSuitBase GetItems(FB_OldGodSuitBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OldGodSuitBaseContainer> CreateFB_OldGodSuitBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OldGodSuitBaseContainer.AddItems(builder, items);
    return FB_OldGodSuitBaseContainer.EndFB_OldGodSuitBaseContainer(builder);
  }

  public static void StartFB_OldGodSuitBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OldGodSuitBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OldGodSuitBaseContainer> EndFB_OldGodSuitBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OldGodSuitBaseContainer>(o);
  }
  public static void FinishFB_OldGodSuitBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_OldGodSuitBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
