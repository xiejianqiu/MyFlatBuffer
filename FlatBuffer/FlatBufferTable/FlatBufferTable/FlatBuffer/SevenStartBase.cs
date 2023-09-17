// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SevenStartBase : Table {
  public static FB_SevenStartBase GetRootAsFB_SevenStartBase(ByteBuffer _bb) { return GetRootAsFB_SevenStartBase(_bb, new FB_SevenStartBase()); }
  public static FB_SevenStartBase GetRootAsFB_SevenStartBase(ByteBuffer _bb, FB_SevenStartBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SevenStartBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string NameSprite { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetPassiveSkillList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPassiveValueBaseList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveValueBaseListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPassiveValueAddList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveValueAddListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int ActivateBattlePower { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelBattlePower { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_SevenStartBase> CreateFB_SevenStartBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset NameSprite = default(StringOffset),
      VectorOffset PassiveSkillList = default(VectorOffset),
      VectorOffset PassiveValueBaseList = default(VectorOffset),
      VectorOffset PassiveValueAddList = default(VectorOffset),
      int ActivateBattlePower = 0,
      int LevelBattlePower = 0) {
    builder.StartObject(8);
    FB_SevenStartBase.AddLevelBattlePower(builder, LevelBattlePower);
    FB_SevenStartBase.AddActivateBattlePower(builder, ActivateBattlePower);
    FB_SevenStartBase.AddPassiveValueAddList(builder, PassiveValueAddList);
    FB_SevenStartBase.AddPassiveValueBaseList(builder, PassiveValueBaseList);
    FB_SevenStartBase.AddPassiveSkillList(builder, PassiveSkillList);
    FB_SevenStartBase.AddNameSprite(builder, NameSprite);
    FB_SevenStartBase.AddName(builder, Name);
    FB_SevenStartBase.AddId(builder, Id);
    return FB_SevenStartBase.EndFB_SevenStartBase(builder);
  }

  public static void StartFB_SevenStartBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNameSprite(FlatBufferBuilder builder, StringOffset NameSpriteOffset) { builder.AddOffset(2, NameSpriteOffset.Value, 0); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(3, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveValueBaseList(FlatBufferBuilder builder, VectorOffset PassiveValueBaseListOffset) { builder.AddOffset(4, PassiveValueBaseListOffset.Value, 0); }
  public static VectorOffset CreatePassiveValueBaseListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveValueBaseListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveValueAddList(FlatBufferBuilder builder, VectorOffset PassiveValueAddListOffset) { builder.AddOffset(5, PassiveValueAddListOffset.Value, 0); }
  public static VectorOffset CreatePassiveValueAddListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveValueAddListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddActivateBattlePower(FlatBufferBuilder builder, int ActivateBattlePower) { builder.AddInt(6, ActivateBattlePower, 0); }
  public static void AddLevelBattlePower(FlatBufferBuilder builder, int LevelBattlePower) { builder.AddInt(7, LevelBattlePower, 0); }
  public static Offset<FB_SevenStartBase> EndFB_SevenStartBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SevenStartBase>(o);
  }
};

public sealed class FB_SevenStartBaseContainer : Table {
  public static FB_SevenStartBaseContainer GetRootAsFB_SevenStartBaseContainer(ByteBuffer _bb) { return GetRootAsFB_SevenStartBaseContainer(_bb, new FB_SevenStartBaseContainer()); }
  public static FB_SevenStartBaseContainer GetRootAsFB_SevenStartBaseContainer(ByteBuffer _bb, FB_SevenStartBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SevenStartBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SevenStartBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SevenStartBase GetItems(int j) { return GetItems(new FB_SevenStartBase(), j); }
  public FB_SevenStartBase GetItems(FB_SevenStartBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SevenStartBaseContainer> CreateFB_SevenStartBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SevenStartBaseContainer.AddItems(builder, items);
    return FB_SevenStartBaseContainer.EndFB_SevenStartBaseContainer(builder);
  }

  public static void StartFB_SevenStartBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SevenStartBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SevenStartBaseContainer> EndFB_SevenStartBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SevenStartBaseContainer>(o);
  }
  public static void FinishFB_SevenStartBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_SevenStartBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
