// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_YingYanItem : Table {
  public static FB_YingYanItem GetRootAsFB_YingYanItem(ByteBuffer _bb) { return GetRootAsFB_YingYanItem(_bb, new FB_YingYanItem()); }
  public static FB_YingYanItem GetRootAsFB_YingYanItem(ByteBuffer _bb, FB_YingYanItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_YingYanItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Width { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Height { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Icon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetKeyList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int KeyListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public float Scale { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }

  public static Offset<FB_YingYanItem> CreateFB_YingYanItem(FlatBufferBuilder builder,
      int Id = 0,
      int Type = 0,
      int Width = 0,
      int Height = 0,
      StringOffset Icon = default(StringOffset),
      VectorOffset KeyList = default(VectorOffset),
      float Scale = 1) {
    builder.StartObject(7);
    FB_YingYanItem.AddScale(builder, Scale);
    FB_YingYanItem.AddKeyList(builder, KeyList);
    FB_YingYanItem.AddIcon(builder, Icon);
    FB_YingYanItem.AddHeight(builder, Height);
    FB_YingYanItem.AddWidth(builder, Width);
    FB_YingYanItem.AddType(builder, Type);
    FB_YingYanItem.AddId(builder, Id);
    return FB_YingYanItem.EndFB_YingYanItem(builder);
  }

  public static void StartFB_YingYanItem(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, 0); }
  public static void AddWidth(FlatBufferBuilder builder, int Width) { builder.AddInt(2, Width, 0); }
  public static void AddHeight(FlatBufferBuilder builder, int Height) { builder.AddInt(3, Height, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(4, IconOffset.Value, 0); }
  public static void AddKeyList(FlatBufferBuilder builder, VectorOffset KeyListOffset) { builder.AddOffset(5, KeyListOffset.Value, 0); }
  public static VectorOffset CreateKeyListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartKeyListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(6, Scale, 1); }
  public static Offset<FB_YingYanItem> EndFB_YingYanItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YingYanItem>(o);
  }
};

public sealed class FB_YingYanItemContainer : Table {
  public static FB_YingYanItemContainer GetRootAsFB_YingYanItemContainer(ByteBuffer _bb) { return GetRootAsFB_YingYanItemContainer(_bb, new FB_YingYanItemContainer()); }
  public static FB_YingYanItemContainer GetRootAsFB_YingYanItemContainer(ByteBuffer _bb, FB_YingYanItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_YingYanItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_YingYanItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_YingYanItem GetItems(int j) { return GetItems(new FB_YingYanItem(), j); }
  public FB_YingYanItem GetItems(FB_YingYanItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YingYanItemContainer> CreateFB_YingYanItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_YingYanItemContainer.AddItems(builder, items);
    return FB_YingYanItemContainer.EndFB_YingYanItemContainer(builder);
  }

  public static void StartFB_YingYanItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_YingYanItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_YingYanItemContainer> EndFB_YingYanItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YingYanItemContainer>(o);
  }
  public static void FinishFB_YingYanItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_YingYanItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
