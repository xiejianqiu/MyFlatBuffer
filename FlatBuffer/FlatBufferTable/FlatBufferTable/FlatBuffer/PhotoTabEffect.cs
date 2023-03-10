// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PhotoTabEffect : Table {
  public static FB_PhotoTabEffect GetRootAsFB_PhotoTabEffect(ByteBuffer _bb) { return GetRootAsFB_PhotoTabEffect(_bb, new FB_PhotoTabEffect()); }
  public static FB_PhotoTabEffect GetRootAsFB_PhotoTabEffect(ByteBuffer _bb, FB_PhotoTabEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PhotoTabEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPhotoEffectIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PhotoEffectIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PhotoTabEffect> CreateFB_PhotoTabEffect(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      VectorOffset PhotoEffectIdList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_PhotoTabEffect.AddPhotoEffectIdList(builder, PhotoEffectIdList);
    FB_PhotoTabEffect.AddType(builder, Type);
    FB_PhotoTabEffect.AddName(builder, Name);
    FB_PhotoTabEffect.AddID(builder, ID);
    return FB_PhotoTabEffect.EndFB_PhotoTabEffect(builder);
  }

  public static void StartFB_PhotoTabEffect(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddPhotoEffectIdList(FlatBufferBuilder builder, VectorOffset PhotoEffectIdListOffset) { builder.AddOffset(3, PhotoEffectIdListOffset.Value, 0); }
  public static VectorOffset CreatePhotoEffectIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPhotoEffectIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PhotoTabEffect> EndFB_PhotoTabEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PhotoTabEffect>(o);
  }
};

public sealed class FB_PhotoTabEffectContainer : Table {
  public static FB_PhotoTabEffectContainer GetRootAsFB_PhotoTabEffectContainer(ByteBuffer _bb) { return GetRootAsFB_PhotoTabEffectContainer(_bb, new FB_PhotoTabEffectContainer()); }
  public static FB_PhotoTabEffectContainer GetRootAsFB_PhotoTabEffectContainer(ByteBuffer _bb, FB_PhotoTabEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PhotoTabEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PhotoTabEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PhotoTabEffect GetItems(int j) { return GetItems(new FB_PhotoTabEffect(), j); }
  public FB_PhotoTabEffect GetItems(FB_PhotoTabEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PhotoTabEffectContainer> CreateFB_PhotoTabEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PhotoTabEffectContainer.AddItems(builder, items);
    return FB_PhotoTabEffectContainer.EndFB_PhotoTabEffectContainer(builder);
  }

  public static void StartFB_PhotoTabEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PhotoTabEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PhotoTabEffectContainer> EndFB_PhotoTabEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PhotoTabEffectContainer>(o);
  }
  public static void FinishFB_PhotoTabEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_PhotoTabEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
