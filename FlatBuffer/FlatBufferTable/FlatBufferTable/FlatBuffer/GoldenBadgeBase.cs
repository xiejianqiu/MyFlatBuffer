// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GoldenBadgeBase : Table {
  public static FB_GoldenBadgeBase GetRootAsFB_GoldenBadgeBase(ByteBuffer _bb) { return GetRootAsFB_GoldenBadgeBase(_bb, new FB_GoldenBadgeBase()); }
  public static FB_GoldenBadgeBase GetRootAsFB_GoldenBadgeBase(ByteBuffer _bb, FB_GoldenBadgeBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GoldenBadgeBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string NameSprite { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ActivateBattlePower { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelBattlePower { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_GoldenBadgeBase> CreateFB_GoldenBadgeBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset NameSprite = default(StringOffset),
      int ActivateBattlePower = 0,
      int LevelBattlePower = 0) {
    builder.StartObject(5);
    FB_GoldenBadgeBase.AddLevelBattlePower(builder, LevelBattlePower);
    FB_GoldenBadgeBase.AddActivateBattlePower(builder, ActivateBattlePower);
    FB_GoldenBadgeBase.AddNameSprite(builder, NameSprite);
    FB_GoldenBadgeBase.AddName(builder, Name);
    FB_GoldenBadgeBase.AddId(builder, Id);
    return FB_GoldenBadgeBase.EndFB_GoldenBadgeBase(builder);
  }

  public static void StartFB_GoldenBadgeBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNameSprite(FlatBufferBuilder builder, StringOffset NameSpriteOffset) { builder.AddOffset(2, NameSpriteOffset.Value, 0); }
  public static void AddActivateBattlePower(FlatBufferBuilder builder, int ActivateBattlePower) { builder.AddInt(3, ActivateBattlePower, 0); }
  public static void AddLevelBattlePower(FlatBufferBuilder builder, int LevelBattlePower) { builder.AddInt(4, LevelBattlePower, 0); }
  public static Offset<FB_GoldenBadgeBase> EndFB_GoldenBadgeBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GoldenBadgeBase>(o);
  }
};

public sealed class FB_GoldenBadgeBaseContainer : Table {
  public static FB_GoldenBadgeBaseContainer GetRootAsFB_GoldenBadgeBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GoldenBadgeBaseContainer(_bb, new FB_GoldenBadgeBaseContainer()); }
  public static FB_GoldenBadgeBaseContainer GetRootAsFB_GoldenBadgeBaseContainer(ByteBuffer _bb, FB_GoldenBadgeBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GoldenBadgeBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GoldenBadgeBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GoldenBadgeBase GetItems(int j) { return GetItems(new FB_GoldenBadgeBase(), j); }
  public FB_GoldenBadgeBase GetItems(FB_GoldenBadgeBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GoldenBadgeBaseContainer> CreateFB_GoldenBadgeBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GoldenBadgeBaseContainer.AddItems(builder, items);
    return FB_GoldenBadgeBaseContainer.EndFB_GoldenBadgeBaseContainer(builder);
  }

  public static void StartFB_GoldenBadgeBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GoldenBadgeBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GoldenBadgeBaseContainer> EndFB_GoldenBadgeBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GoldenBadgeBaseContainer>(o);
  }
  public static void FinishFB_GoldenBadgeBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GoldenBadgeBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
