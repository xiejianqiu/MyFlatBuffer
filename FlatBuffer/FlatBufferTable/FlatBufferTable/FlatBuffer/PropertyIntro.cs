// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PropertyIntro : Table {
  public static FB_PropertyIntro GetRootAsFB_PropertyIntro(ByteBuffer _bb) { return GetRootAsFB_PropertyIntro(_bb, new FB_PropertyIntro()); }
  public static FB_PropertyIntro GetRootAsFB_PropertyIntro(ByteBuffer _bb, FB_PropertyIntro obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PropertyIntro __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Intro { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_PropertyIntro> CreateFB_PropertyIntro(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      StringOffset Intro = default(StringOffset)) {
    builder.StartObject(3);
    FB_PropertyIntro.AddIntro(builder, Intro);
    FB_PropertyIntro.AddType(builder, Type);
    FB_PropertyIntro.AddID(builder, ID);
    return FB_PropertyIntro.EndFB_PropertyIntro(builder);
  }

  public static void StartFB_PropertyIntro(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddIntro(FlatBufferBuilder builder, StringOffset IntroOffset) { builder.AddOffset(2, IntroOffset.Value, 0); }
  public static Offset<FB_PropertyIntro> EndFB_PropertyIntro(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PropertyIntro>(o);
  }
};

public sealed class FB_PropertyIntroContainer : Table {
  public static FB_PropertyIntroContainer GetRootAsFB_PropertyIntroContainer(ByteBuffer _bb) { return GetRootAsFB_PropertyIntroContainer(_bb, new FB_PropertyIntroContainer()); }
  public static FB_PropertyIntroContainer GetRootAsFB_PropertyIntroContainer(ByteBuffer _bb, FB_PropertyIntroContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PropertyIntroContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PropertyIntroContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PropertyIntro GetItems(int j) { return GetItems(new FB_PropertyIntro(), j); }
  public FB_PropertyIntro GetItems(FB_PropertyIntro obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PropertyIntroContainer> CreateFB_PropertyIntroContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PropertyIntroContainer.AddItems(builder, items);
    return FB_PropertyIntroContainer.EndFB_PropertyIntroContainer(builder);
  }

  public static void StartFB_PropertyIntroContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PropertyIntro>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PropertyIntroContainer> EndFB_PropertyIntroContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PropertyIntroContainer>(o);
  }
  public static void FinishFB_PropertyIntroContainerBuffer(FlatBufferBuilder builder, Offset<FB_PropertyIntroContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
