// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CommonItemDataAboutSex : Table {
  public static FB_CommonItemDataAboutSex GetRootAsFB_CommonItemDataAboutSex(ByteBuffer _bb) { return GetRootAsFB_CommonItemDataAboutSex(_bb, new FB_CommonItemDataAboutSex()); }
  public static FB_CommonItemDataAboutSex GetRootAsFB_CommonItemDataAboutSex(ByteBuffer _bb, FB_CommonItemDataAboutSex obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CommonItemDataAboutSex __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenAtlasName { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string MenIcon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int WomenAtlasName { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string WomenIcon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_CommonItemDataAboutSex> CreateFB_CommonItemDataAboutSex(FlatBufferBuilder builder,
      int Id = 0,
      int MenAtlasName = -1,
      StringOffset MenIcon = default(StringOffset),
      int WomenAtlasName = -1,
      StringOffset WomenIcon = default(StringOffset)) {
    builder.StartObject(5);
    FB_CommonItemDataAboutSex.AddWomenIcon(builder, WomenIcon);
    FB_CommonItemDataAboutSex.AddWomenAtlasName(builder, WomenAtlasName);
    FB_CommonItemDataAboutSex.AddMenIcon(builder, MenIcon);
    FB_CommonItemDataAboutSex.AddMenAtlasName(builder, MenAtlasName);
    FB_CommonItemDataAboutSex.AddId(builder, Id);
    return FB_CommonItemDataAboutSex.EndFB_CommonItemDataAboutSex(builder);
  }

  public static void StartFB_CommonItemDataAboutSex(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenAtlasName(FlatBufferBuilder builder, int MenAtlasName) { builder.AddInt(1, MenAtlasName, -1); }
  public static void AddMenIcon(FlatBufferBuilder builder, StringOffset MenIconOffset) { builder.AddOffset(2, MenIconOffset.Value, 0); }
  public static void AddWomenAtlasName(FlatBufferBuilder builder, int WomenAtlasName) { builder.AddInt(3, WomenAtlasName, -1); }
  public static void AddWomenIcon(FlatBufferBuilder builder, StringOffset WomenIconOffset) { builder.AddOffset(4, WomenIconOffset.Value, 0); }
  public static Offset<FB_CommonItemDataAboutSex> EndFB_CommonItemDataAboutSex(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CommonItemDataAboutSex>(o);
  }
};

public sealed class FB_CommonItemDataAboutSexContainer : Table {
  public static FB_CommonItemDataAboutSexContainer GetRootAsFB_CommonItemDataAboutSexContainer(ByteBuffer _bb) { return GetRootAsFB_CommonItemDataAboutSexContainer(_bb, new FB_CommonItemDataAboutSexContainer()); }
  public static FB_CommonItemDataAboutSexContainer GetRootAsFB_CommonItemDataAboutSexContainer(ByteBuffer _bb, FB_CommonItemDataAboutSexContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CommonItemDataAboutSexContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CommonItemDataAboutSexContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CommonItemDataAboutSex GetItems(int j) { return GetItems(new FB_CommonItemDataAboutSex(), j); }
  public FB_CommonItemDataAboutSex GetItems(FB_CommonItemDataAboutSex obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CommonItemDataAboutSexContainer> CreateFB_CommonItemDataAboutSexContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CommonItemDataAboutSexContainer.AddItems(builder, items);
    return FB_CommonItemDataAboutSexContainer.EndFB_CommonItemDataAboutSexContainer(builder);
  }

  public static void StartFB_CommonItemDataAboutSexContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CommonItemDataAboutSex>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CommonItemDataAboutSexContainer> EndFB_CommonItemDataAboutSexContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CommonItemDataAboutSexContainer>(o);
  }
  public static void FinishFB_CommonItemDataAboutSexContainerBuffer(FlatBufferBuilder builder, Offset<FB_CommonItemDataAboutSexContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
