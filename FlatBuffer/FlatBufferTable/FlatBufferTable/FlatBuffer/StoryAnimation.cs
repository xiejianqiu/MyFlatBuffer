// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StoryAnimation : Table {
  public static FB_StoryAnimation GetRootAsFB_StoryAnimation(ByteBuffer _bb) { return GetRootAsFB_StoryAnimation(_bb, new FB_StoryAnimation()); }
  public static FB_StoryAnimation GetRootAsFB_StoryAnimation(ByteBuffer _bb, FB_StoryAnimation obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StoryAnimation __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsCanSkip { get { int o = __offset(6); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public float Delay { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool IsReplay { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsOccupationDiff { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsEndBlood { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_StoryAnimation> CreateFB_StoryAnimation(FlatBufferBuilder builder,
      int Id = 0,
      bool IsCanSkip = true,
      float Delay = 0,
      bool IsReplay = true,
      bool IsOccupationDiff = false,
      bool IsEndBlood = false) {
    builder.StartObject(6);
    FB_StoryAnimation.AddDelay(builder, Delay);
    FB_StoryAnimation.AddId(builder, Id);
    FB_StoryAnimation.AddIsEndBlood(builder, IsEndBlood);
    FB_StoryAnimation.AddIsOccupationDiff(builder, IsOccupationDiff);
    FB_StoryAnimation.AddIsReplay(builder, IsReplay);
    FB_StoryAnimation.AddIsCanSkip(builder, IsCanSkip);
    return FB_StoryAnimation.EndFB_StoryAnimation(builder);
  }

  public static void StartFB_StoryAnimation(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddIsCanSkip(FlatBufferBuilder builder, bool IsCanSkip) { builder.AddBool(1, IsCanSkip, true); }
  public static void AddDelay(FlatBufferBuilder builder, float Delay) { builder.AddFloat(2, Delay, 0); }
  public static void AddIsReplay(FlatBufferBuilder builder, bool IsReplay) { builder.AddBool(3, IsReplay, true); }
  public static void AddIsOccupationDiff(FlatBufferBuilder builder, bool IsOccupationDiff) { builder.AddBool(4, IsOccupationDiff, false); }
  public static void AddIsEndBlood(FlatBufferBuilder builder, bool IsEndBlood) { builder.AddBool(5, IsEndBlood, false); }
  public static Offset<FB_StoryAnimation> EndFB_StoryAnimation(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StoryAnimation>(o);
  }
};

public sealed class FB_StoryAnimationContainer : Table {
  public static FB_StoryAnimationContainer GetRootAsFB_StoryAnimationContainer(ByteBuffer _bb) { return GetRootAsFB_StoryAnimationContainer(_bb, new FB_StoryAnimationContainer()); }
  public static FB_StoryAnimationContainer GetRootAsFB_StoryAnimationContainer(ByteBuffer _bb, FB_StoryAnimationContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StoryAnimationContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StoryAnimationContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StoryAnimation GetItems(int j) { return GetItems(new FB_StoryAnimation(), j); }
  public FB_StoryAnimation GetItems(FB_StoryAnimation obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StoryAnimationContainer> CreateFB_StoryAnimationContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StoryAnimationContainer.AddItems(builder, items);
    return FB_StoryAnimationContainer.EndFB_StoryAnimationContainer(builder);
  }

  public static void StartFB_StoryAnimationContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StoryAnimation>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StoryAnimationContainer> EndFB_StoryAnimationContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StoryAnimationContainer>(o);
  }
  public static void FinishFB_StoryAnimationContainerBuffer(FlatBufferBuilder builder, Offset<FB_StoryAnimationContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
