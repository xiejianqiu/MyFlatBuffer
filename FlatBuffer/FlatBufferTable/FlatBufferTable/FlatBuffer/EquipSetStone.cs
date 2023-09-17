// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipSetStone : Table {
  public static FB_EquipSetStone GetRootAsFB_EquipSetStone(ByteBuffer _bb) { return GetRootAsFB_EquipSetStone(_bb, new FB_EquipSetStone()); }
  public static FB_EquipSetStone GetRootAsFB_EquipSetStone(ByteBuffer _bb, FB_EquipSetStone obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipSetStone __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StoneType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EquipType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StoneName { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetLevelUpItemIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelUpItemIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLevelUpItemCountList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LevelUpItemCountListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int AttrAdd { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSetStone> CreateFB_EquipSetStone(FlatBufferBuilder builder,
      int Id = 0,
      int StoneType = -1,
      int EquipType = -1,
      int Level = -1,
      int StoneName = -1,
      VectorOffset LevelUpItemIdList = default(VectorOffset),
      VectorOffset LevelUpItemCountList = default(VectorOffset),
      int AttrAdd = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_EquipSetStone.AddAttrValueList(builder, AttrValueList);
    FB_EquipSetStone.AddAttrIDList(builder, AttrIDList);
    FB_EquipSetStone.AddAttrAdd(builder, AttrAdd);
    FB_EquipSetStone.AddLevelUpItemCountList(builder, LevelUpItemCountList);
    FB_EquipSetStone.AddLevelUpItemIdList(builder, LevelUpItemIdList);
    FB_EquipSetStone.AddStoneName(builder, StoneName);
    FB_EquipSetStone.AddLevel(builder, Level);
    FB_EquipSetStone.AddEquipType(builder, EquipType);
    FB_EquipSetStone.AddStoneType(builder, StoneType);
    FB_EquipSetStone.AddId(builder, Id);
    return FB_EquipSetStone.EndFB_EquipSetStone(builder);
  }

  public static void StartFB_EquipSetStone(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStoneType(FlatBufferBuilder builder, int StoneType) { builder.AddInt(1, StoneType, -1); }
  public static void AddEquipType(FlatBufferBuilder builder, int EquipType) { builder.AddInt(2, EquipType, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(3, Level, -1); }
  public static void AddStoneName(FlatBufferBuilder builder, int StoneName) { builder.AddInt(4, StoneName, -1); }
  public static void AddLevelUpItemIdList(FlatBufferBuilder builder, VectorOffset LevelUpItemIdListOffset) { builder.AddOffset(5, LevelUpItemIdListOffset.Value, 0); }
  public static VectorOffset CreateLevelUpItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelUpItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelUpItemCountList(FlatBufferBuilder builder, VectorOffset LevelUpItemCountListOffset) { builder.AddOffset(6, LevelUpItemCountListOffset.Value, 0); }
  public static VectorOffset CreateLevelUpItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLevelUpItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrAdd(FlatBufferBuilder builder, int AttrAdd) { builder.AddInt(7, AttrAdd, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(8, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(9, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSetStone> EndFB_EquipSetStone(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSetStone>(o);
  }
};

public sealed class FB_EquipSetStoneContainer : Table {
  public static FB_EquipSetStoneContainer GetRootAsFB_EquipSetStoneContainer(ByteBuffer _bb) { return GetRootAsFB_EquipSetStoneContainer(_bb, new FB_EquipSetStoneContainer()); }
  public static FB_EquipSetStoneContainer GetRootAsFB_EquipSetStoneContainer(ByteBuffer _bb, FB_EquipSetStoneContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipSetStoneContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipSetStoneContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipSetStone GetItems(int j) { return GetItems(new FB_EquipSetStone(), j); }
  public FB_EquipSetStone GetItems(FB_EquipSetStone obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSetStoneContainer> CreateFB_EquipSetStoneContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipSetStoneContainer.AddItems(builder, items);
    return FB_EquipSetStoneContainer.EndFB_EquipSetStoneContainer(builder);
  }

  public static void StartFB_EquipSetStoneContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipSetStone>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSetStoneContainer> EndFB_EquipSetStoneContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSetStoneContainer>(o);
  }
  public static void FinishFB_EquipSetStoneContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipSetStoneContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
