// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHFestivalDic : Table {
  public static FB_SYHFestivalDic GetRootAsFB_SYHFestivalDic(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalDic(_bb, new FB_SYHFestivalDic()); }
  public static FB_SYHFestivalDic GetRootAsFB_SYHFestivalDic(ByteBuffer _bb, FB_SYHFestivalDic obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHFestivalDic __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ActivityIcon { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ActivityDic { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_SYHFestivalDic> CreateFB_SYHFestivalDic(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ActivityIcon = default(StringOffset),
      StringOffset ActivityDic = default(StringOffset)) {
    builder.StartObject(3);
    FB_SYHFestivalDic.AddActivityDic(builder, ActivityDic);
    FB_SYHFestivalDic.AddActivityIcon(builder, ActivityIcon);
    FB_SYHFestivalDic.AddID(builder, ID);
    return FB_SYHFestivalDic.EndFB_SYHFestivalDic(builder);
  }

  public static void StartFB_SYHFestivalDic(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActivityIcon(FlatBufferBuilder builder, StringOffset ActivityIconOffset) { builder.AddOffset(1, ActivityIconOffset.Value, 0); }
  public static void AddActivityDic(FlatBufferBuilder builder, StringOffset ActivityDicOffset) { builder.AddOffset(2, ActivityDicOffset.Value, 0); }
  public static Offset<FB_SYHFestivalDic> EndFB_SYHFestivalDic(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalDic>(o);
  }
};

public sealed class FB_SYHFestivalDicContainer : Table {
  public static FB_SYHFestivalDicContainer GetRootAsFB_SYHFestivalDicContainer(ByteBuffer _bb) { return GetRootAsFB_SYHFestivalDicContainer(_bb, new FB_SYHFestivalDicContainer()); }
  public static FB_SYHFestivalDicContainer GetRootAsFB_SYHFestivalDicContainer(ByteBuffer _bb, FB_SYHFestivalDicContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHFestivalDicContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHFestivalDicContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHFestivalDic GetItems(int j) { return GetItems(new FB_SYHFestivalDic(), j); }
  public FB_SYHFestivalDic GetItems(FB_SYHFestivalDic obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHFestivalDicContainer> CreateFB_SYHFestivalDicContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHFestivalDicContainer.AddItems(builder, items);
    return FB_SYHFestivalDicContainer.EndFB_SYHFestivalDicContainer(builder);
  }

  public static void StartFB_SYHFestivalDicContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHFestivalDic>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHFestivalDicContainer> EndFB_SYHFestivalDicContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHFestivalDicContainer>(o);
  }
  public static void FinishFB_SYHFestivalDicContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHFestivalDicContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
