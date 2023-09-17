// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunZhuanJingEffect : Table {
  public static FB_XingHunZhuanJingEffect GetRootAsFB_XingHunZhuanJingEffect(ByteBuffer _bb) { return GetRootAsFB_XingHunZhuanJingEffect(_bb, new FB_XingHunZhuanJingEffect()); }
  public static FB_XingHunZhuanJingEffect GetRootAsFB_XingHunZhuanJingEffect(ByteBuffer _bb, FB_XingHunZhuanJingEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunZhuanJingEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DefaultEffectId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetEffectList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EffectListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunZhuanJingEffect> CreateFB_XingHunZhuanJingEffect(FlatBufferBuilder builder,
      int Id = 0,
      int DefaultEffectId = -1,
      VectorOffset EffectList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_XingHunZhuanJingEffect.AddEffectList(builder, EffectList);
    FB_XingHunZhuanJingEffect.AddDefaultEffectId(builder, DefaultEffectId);
    FB_XingHunZhuanJingEffect.AddId(builder, Id);
    return FB_XingHunZhuanJingEffect.EndFB_XingHunZhuanJingEffect(builder);
  }

  public static void StartFB_XingHunZhuanJingEffect(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddDefaultEffectId(FlatBufferBuilder builder, int DefaultEffectId) { builder.AddInt(1, DefaultEffectId, -1); }
  public static void AddEffectList(FlatBufferBuilder builder, VectorOffset EffectListOffset) { builder.AddOffset(2, EffectListOffset.Value, 0); }
  public static VectorOffset CreateEffectListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEffectListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunZhuanJingEffect> EndFB_XingHunZhuanJingEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunZhuanJingEffect>(o);
  }
};

public sealed class FB_XingHunZhuanJingEffectContainer : Table {
  public static FB_XingHunZhuanJingEffectContainer GetRootAsFB_XingHunZhuanJingEffectContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunZhuanJingEffectContainer(_bb, new FB_XingHunZhuanJingEffectContainer()); }
  public static FB_XingHunZhuanJingEffectContainer GetRootAsFB_XingHunZhuanJingEffectContainer(ByteBuffer _bb, FB_XingHunZhuanJingEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunZhuanJingEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunZhuanJingEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunZhuanJingEffect GetItems(int j) { return GetItems(new FB_XingHunZhuanJingEffect(), j); }
  public FB_XingHunZhuanJingEffect GetItems(FB_XingHunZhuanJingEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunZhuanJingEffectContainer> CreateFB_XingHunZhuanJingEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunZhuanJingEffectContainer.AddItems(builder, items);
    return FB_XingHunZhuanJingEffectContainer.EndFB_XingHunZhuanJingEffectContainer(builder);
  }

  public static void StartFB_XingHunZhuanJingEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunZhuanJingEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunZhuanJingEffectContainer> EndFB_XingHunZhuanJingEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunZhuanJingEffectContainer>(o);
  }
  public static void FinishFB_XingHunZhuanJingEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunZhuanJingEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
