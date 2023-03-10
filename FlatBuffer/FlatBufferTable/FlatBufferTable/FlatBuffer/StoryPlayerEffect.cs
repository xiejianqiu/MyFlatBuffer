// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StoryPlayerEffect : Table {
  public static FB_StoryPlayerEffect GetRootAsFB_StoryPlayerEffect(ByteBuffer _bb) { return GetRootAsFB_StoryPlayerEffect(_bb, new FB_StoryPlayerEffect()); }
  public static FB_StoryPlayerEffect GetRootAsFB_StoryPlayerEffect(ByteBuffer _bb, FB_StoryPlayerEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StoryPlayerEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetEffectIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EffectIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public string NameLabel { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_StoryPlayerEffect> CreateFB_StoryPlayerEffect(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset EffectIdList = default(VectorOffset),
      StringOffset NameLabel = default(StringOffset)) {
    builder.StartObject(3);
    FB_StoryPlayerEffect.AddNameLabel(builder, NameLabel);
    FB_StoryPlayerEffect.AddEffectIdList(builder, EffectIdList);
    FB_StoryPlayerEffect.AddId(builder, Id);
    return FB_StoryPlayerEffect.EndFB_StoryPlayerEffect(builder);
  }

  public static void StartFB_StoryPlayerEffect(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddEffectIdList(FlatBufferBuilder builder, VectorOffset EffectIdListOffset) { builder.AddOffset(1, EffectIdListOffset.Value, 0); }
  public static VectorOffset CreateEffectIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEffectIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNameLabel(FlatBufferBuilder builder, StringOffset NameLabelOffset) { builder.AddOffset(2, NameLabelOffset.Value, 0); }
  public static Offset<FB_StoryPlayerEffect> EndFB_StoryPlayerEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StoryPlayerEffect>(o);
  }
};

public sealed class FB_StoryPlayerEffectContainer : Table {
  public static FB_StoryPlayerEffectContainer GetRootAsFB_StoryPlayerEffectContainer(ByteBuffer _bb) { return GetRootAsFB_StoryPlayerEffectContainer(_bb, new FB_StoryPlayerEffectContainer()); }
  public static FB_StoryPlayerEffectContainer GetRootAsFB_StoryPlayerEffectContainer(ByteBuffer _bb, FB_StoryPlayerEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StoryPlayerEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StoryPlayerEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StoryPlayerEffect GetItems(int j) { return GetItems(new FB_StoryPlayerEffect(), j); }
  public FB_StoryPlayerEffect GetItems(FB_StoryPlayerEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StoryPlayerEffectContainer> CreateFB_StoryPlayerEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StoryPlayerEffectContainer.AddItems(builder, items);
    return FB_StoryPlayerEffectContainer.EndFB_StoryPlayerEffectContainer(builder);
  }

  public static void StartFB_StoryPlayerEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StoryPlayerEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StoryPlayerEffectContainer> EndFB_StoryPlayerEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StoryPlayerEffectContainer>(o);
  }
  public static void FinishFB_StoryPlayerEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_StoryPlayerEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
