// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangJiBanLevelUp : Table {
  public static FB_HunJiangJiBanLevelUp GetRootAsFB_HunJiangJiBanLevelUp(ByteBuffer _bb) { return GetRootAsFB_HunJiangJiBanLevelUp(_bb, new FB_HunJiangJiBanLevelUp()); }
  public static FB_HunJiangJiBanLevelUp GetRootAsFB_HunJiangJiBanLevelUp(ByteBuffer _bb, FB_HunJiangJiBanLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangJiBanLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StarCount { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public string GetSkillDesList(int j) { int o = __offset(16); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int SkillDesListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangJiBanLevelUp> CreateFB_HunJiangJiBanLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int StarCount = -1,
      int ItemId = -1,
      int ItemCount = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset SkillDesList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_HunJiangJiBanLevelUp.AddSkillDesList(builder, SkillDesList);
    FB_HunJiangJiBanLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_HunJiangJiBanLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_HunJiangJiBanLevelUp.AddItemCount(builder, ItemCount);
    FB_HunJiangJiBanLevelUp.AddItemId(builder, ItemId);
    FB_HunJiangJiBanLevelUp.AddStarCount(builder, StarCount);
    FB_HunJiangJiBanLevelUp.AddID(builder, ID);
    return FB_HunJiangJiBanLevelUp.EndFB_HunJiangJiBanLevelUp(builder);
  }

  public static void StartFB_HunJiangJiBanLevelUp(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(1, StarCount, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(2, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(3, ItemCount, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillDesList(FlatBufferBuilder builder, VectorOffset SkillDesListOffset) { builder.AddOffset(6, SkillDesListOffset.Value, 0); }
  public static VectorOffset CreateSkillDesListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartSkillDesListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangJiBanLevelUp> EndFB_HunJiangJiBanLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJiBanLevelUp>(o);
  }
};

public sealed class FB_HunJiangJiBanLevelUpContainer : Table {
  public static FB_HunJiangJiBanLevelUpContainer GetRootAsFB_HunJiangJiBanLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangJiBanLevelUpContainer(_bb, new FB_HunJiangJiBanLevelUpContainer()); }
  public static FB_HunJiangJiBanLevelUpContainer GetRootAsFB_HunJiangJiBanLevelUpContainer(ByteBuffer _bb, FB_HunJiangJiBanLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangJiBanLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangJiBanLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangJiBanLevelUp GetItems(int j) { return GetItems(new FB_HunJiangJiBanLevelUp(), j); }
  public FB_HunJiangJiBanLevelUp GetItems(FB_HunJiangJiBanLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangJiBanLevelUpContainer> CreateFB_HunJiangJiBanLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangJiBanLevelUpContainer.AddItems(builder, items);
    return FB_HunJiangJiBanLevelUpContainer.EndFB_HunJiangJiBanLevelUpContainer(builder);
  }

  public static void StartFB_HunJiangJiBanLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangJiBanLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangJiBanLevelUpContainer> EndFB_HunJiangJiBanLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangJiBanLevelUpContainer>(o);
  }
  public static void FinishFB_HunJiangJiBanLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangJiBanLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
