// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CharAnimEffect : Table {
  public static FB_CharAnimEffect GetRootAsFB_CharAnimEffect(ByteBuffer _bb) { return GetRootAsFB_CharAnimEffect(_bb, new FB_CharAnimEffect()); }
  public static FB_CharAnimEffect GetRootAsFB_CharAnimEffect(ByteBuffer _bb, FB_CharAnimEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CharAnimEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AnimiD { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetEffectIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EffectIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharAnimEffect> CreateFB_CharAnimEffect(FlatBufferBuilder builder,
      int Id = 0,
      int AnimiD = -1,
      VectorOffset EffectIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_CharAnimEffect.AddEffectIDList(builder, EffectIDList);
    FB_CharAnimEffect.AddAnimiD(builder, AnimiD);
    FB_CharAnimEffect.AddId(builder, Id);
    return FB_CharAnimEffect.EndFB_CharAnimEffect(builder);
  }

  public static void StartFB_CharAnimEffect(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAnimiD(FlatBufferBuilder builder, int AnimiD) { builder.AddInt(1, AnimiD, -1); }
  public static void AddEffectIDList(FlatBufferBuilder builder, VectorOffset EffectIDListOffset) { builder.AddOffset(2, EffectIDListOffset.Value, 0); }
  public static VectorOffset CreateEffectIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEffectIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharAnimEffect> EndFB_CharAnimEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharAnimEffect>(o);
  }
};

public sealed class FB_CharAnimEffectContainer : Table {
  public static FB_CharAnimEffectContainer GetRootAsFB_CharAnimEffectContainer(ByteBuffer _bb) { return GetRootAsFB_CharAnimEffectContainer(_bb, new FB_CharAnimEffectContainer()); }
  public static FB_CharAnimEffectContainer GetRootAsFB_CharAnimEffectContainer(ByteBuffer _bb, FB_CharAnimEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CharAnimEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CharAnimEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CharAnimEffect GetItems(int j) { return GetItems(new FB_CharAnimEffect(), j); }
  public FB_CharAnimEffect GetItems(FB_CharAnimEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharAnimEffectContainer> CreateFB_CharAnimEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CharAnimEffectContainer.AddItems(builder, items);
    return FB_CharAnimEffectContainer.EndFB_CharAnimEffectContainer(builder);
  }

  public static void StartFB_CharAnimEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CharAnimEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharAnimEffectContainer> EndFB_CharAnimEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharAnimEffectContainer>(o);
  }
  public static void FinishFB_CharAnimEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_CharAnimEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
