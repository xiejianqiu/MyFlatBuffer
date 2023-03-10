// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WeaponAnimation : Table {
  public static FB_WeaponAnimation GetRootAsFB_WeaponAnimation(ByteBuffer _bb) { return GetRootAsFB_WeaponAnimation(_bb, new FB_WeaponAnimation()); }
  public static FB_WeaponAnimation GetRootAsFB_WeaponAnimation(ByteBuffer _bb, FB_WeaponAnimation obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WeaponAnimation __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int AnimID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AnimCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string GetAnimNameList(int j) { int o = __offset(8); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int AnimNameListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAnimTimeList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AnimTimeListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WeaponAnimation> CreateFB_WeaponAnimation(FlatBufferBuilder builder,
      int AnimID = 0,
      int AnimCount = 1,
      VectorOffset AnimNameList = default(VectorOffset),
      VectorOffset AnimTimeList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_WeaponAnimation.AddAnimTimeList(builder, AnimTimeList);
    FB_WeaponAnimation.AddAnimNameList(builder, AnimNameList);
    FB_WeaponAnimation.AddAnimCount(builder, AnimCount);
    FB_WeaponAnimation.AddAnimID(builder, AnimID);
    return FB_WeaponAnimation.EndFB_WeaponAnimation(builder);
  }

  public static void StartFB_WeaponAnimation(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddAnimID(FlatBufferBuilder builder, int AnimID) { builder.AddInt(0, AnimID, 0); }
  public static void AddAnimCount(FlatBufferBuilder builder, int AnimCount) { builder.AddInt(1, AnimCount, 1); }
  public static void AddAnimNameList(FlatBufferBuilder builder, VectorOffset AnimNameListOffset) { builder.AddOffset(2, AnimNameListOffset.Value, 0); }
  public static VectorOffset CreateAnimNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartAnimNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAnimTimeList(FlatBufferBuilder builder, VectorOffset AnimTimeListOffset) { builder.AddOffset(3, AnimTimeListOffset.Value, 0); }
  public static VectorOffset CreateAnimTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAnimTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WeaponAnimation> EndFB_WeaponAnimation(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WeaponAnimation>(o);
  }
};

public sealed class FB_WeaponAnimationContainer : Table {
  public static FB_WeaponAnimationContainer GetRootAsFB_WeaponAnimationContainer(ByteBuffer _bb) { return GetRootAsFB_WeaponAnimationContainer(_bb, new FB_WeaponAnimationContainer()); }
  public static FB_WeaponAnimationContainer GetRootAsFB_WeaponAnimationContainer(ByteBuffer _bb, FB_WeaponAnimationContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WeaponAnimationContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WeaponAnimationContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WeaponAnimation GetItems(int j) { return GetItems(new FB_WeaponAnimation(), j); }
  public FB_WeaponAnimation GetItems(FB_WeaponAnimation obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WeaponAnimationContainer> CreateFB_WeaponAnimationContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WeaponAnimationContainer.AddItems(builder, items);
    return FB_WeaponAnimationContainer.EndFB_WeaponAnimationContainer(builder);
  }

  public static void StartFB_WeaponAnimationContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WeaponAnimation>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WeaponAnimationContainer> EndFB_WeaponAnimationContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WeaponAnimationContainer>(o);
  }
  public static void FinishFB_WeaponAnimationContainerBuffer(FlatBufferBuilder builder, Offset<FB_WeaponAnimationContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
