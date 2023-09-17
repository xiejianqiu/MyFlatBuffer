// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AutoBindBase : Table {
  public static FB_AutoBindBase GetRootAsFB_AutoBindBase(ByteBuffer _bb) { return GetRootAsFB_AutoBindBase(_bb, new FB_AutoBindBase()); }
  public static FB_AutoBindBase GetRootAsFB_AutoBindBase(ByteBuffer _bb, FB_AutoBindBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AutoBindBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TypeName { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Class { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ClassName { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_AutoBindBase> CreateFB_AutoBindBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      StringOffset TypeName = default(StringOffset),
      int Class = -1,
      StringOffset ClassName = default(StringOffset)) {
    builder.StartObject(6);
    FB_AutoBindBase.AddClassName(builder, ClassName);
    FB_AutoBindBase.AddClass(builder, Class);
    FB_AutoBindBase.AddTypeName(builder, TypeName);
    FB_AutoBindBase.AddType(builder, Type);
    FB_AutoBindBase.AddName(builder, Name);
    FB_AutoBindBase.AddId(builder, Id);
    return FB_AutoBindBase.EndFB_AutoBindBase(builder);
  }

  public static void StartFB_AutoBindBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddTypeName(FlatBufferBuilder builder, StringOffset TypeNameOffset) { builder.AddOffset(3, TypeNameOffset.Value, 0); }
  public static void AddClass(FlatBufferBuilder builder, int Class) { builder.AddInt(4, Class, -1); }
  public static void AddClassName(FlatBufferBuilder builder, StringOffset ClassNameOffset) { builder.AddOffset(5, ClassNameOffset.Value, 0); }
  public static Offset<FB_AutoBindBase> EndFB_AutoBindBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AutoBindBase>(o);
  }
};

public sealed class FB_AutoBindBaseContainer : Table {
  public static FB_AutoBindBaseContainer GetRootAsFB_AutoBindBaseContainer(ByteBuffer _bb) { return GetRootAsFB_AutoBindBaseContainer(_bb, new FB_AutoBindBaseContainer()); }
  public static FB_AutoBindBaseContainer GetRootAsFB_AutoBindBaseContainer(ByteBuffer _bb, FB_AutoBindBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AutoBindBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AutoBindBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AutoBindBase GetItems(int j) { return GetItems(new FB_AutoBindBase(), j); }
  public FB_AutoBindBase GetItems(FB_AutoBindBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AutoBindBaseContainer> CreateFB_AutoBindBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AutoBindBaseContainer.AddItems(builder, items);
    return FB_AutoBindBaseContainer.EndFB_AutoBindBaseContainer(builder);
  }

  public static void StartFB_AutoBindBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AutoBindBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AutoBindBaseContainer> EndFB_AutoBindBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AutoBindBaseContainer>(o);
  }
  public static void FinishFB_AutoBindBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_AutoBindBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
