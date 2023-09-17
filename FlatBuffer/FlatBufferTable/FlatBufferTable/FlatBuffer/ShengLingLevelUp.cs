// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShengLingLevelUp : Table {
  public static FB_ShengLingLevelUp GetRootAsFB_ShengLingLevelUp(ByteBuffer _bb) { return GetRootAsFB_ShengLingLevelUp(_bb, new FB_ShengLingLevelUp()); }
  public static FB_ShengLingLevelUp GetRootAsFB_ShengLingLevelUp(ByteBuffer _bb, FB_ShengLingLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShengLingLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EffectIndex { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPassiveSkillList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetIsActiveList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int IsActiveListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingLevelUp> CreateFB_ShengLingLevelUp(FlatBufferBuilder builder,
      int Id = 0,
      int ItemId = -1,
      int ItemCount = -1,
      int EffectIndex = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset PassiveSkillList = default(VectorOffset),
      VectorOffset IsActiveList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_ShengLingLevelUp.AddIsActiveList(builder, IsActiveList);
    FB_ShengLingLevelUp.AddPassiveSkillList(builder, PassiveSkillList);
    FB_ShengLingLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ShengLingLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_ShengLingLevelUp.AddEffectIndex(builder, EffectIndex);
    FB_ShengLingLevelUp.AddItemCount(builder, ItemCount);
    FB_ShengLingLevelUp.AddItemId(builder, ItemId);
    FB_ShengLingLevelUp.AddId(builder, Id);
    return FB_ShengLingLevelUp.EndFB_ShengLingLevelUp(builder);
  }

  public static void StartFB_ShengLingLevelUp(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(1, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(2, ItemCount, -1); }
  public static void AddEffectIndex(FlatBufferBuilder builder, int EffectIndex) { builder.AddInt(3, EffectIndex, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(6, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsActiveList(FlatBufferBuilder builder, VectorOffset IsActiveListOffset) { builder.AddOffset(7, IsActiveListOffset.Value, 0); }
  public static VectorOffset CreateIsActiveListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartIsActiveListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingLevelUp> EndFB_ShengLingLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingLevelUp>(o);
  }
};

public sealed class FB_ShengLingLevelUpContainer : Table {
  public static FB_ShengLingLevelUpContainer GetRootAsFB_ShengLingLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ShengLingLevelUpContainer(_bb, new FB_ShengLingLevelUpContainer()); }
  public static FB_ShengLingLevelUpContainer GetRootAsFB_ShengLingLevelUpContainer(ByteBuffer _bb, FB_ShengLingLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShengLingLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShengLingLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShengLingLevelUp GetItems(int j) { return GetItems(new FB_ShengLingLevelUp(), j); }
  public FB_ShengLingLevelUp GetItems(FB_ShengLingLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingLevelUpContainer> CreateFB_ShengLingLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShengLingLevelUpContainer.AddItems(builder, items);
    return FB_ShengLingLevelUpContainer.EndFB_ShengLingLevelUpContainer(builder);
  }

  public static void StartFB_ShengLingLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShengLingLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingLevelUpContainer> EndFB_ShengLingLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingLevelUpContainer>(o);
  }
  public static void FinishFB_ShengLingLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShengLingLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
