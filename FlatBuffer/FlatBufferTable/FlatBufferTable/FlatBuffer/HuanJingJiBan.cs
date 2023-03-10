// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingJiBan : Table {
  public static FB_HuanJingJiBan GetRootAsFB_HuanJingJiBan(ByteBuffer _bb) { return GetRootAsFB_HuanJingJiBan(_bb, new FB_HuanJingJiBan()); }
  public static FB_HuanJingJiBan GetRootAsFB_HuanJingJiBan(ByteBuffer _bb, FB_HuanJingJiBan obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingJiBan __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Group { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HuanJingJiBanLv { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassiveSkillId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string SkillTitle { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SkillInfo { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RequireInfo { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetCostItemIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostItemCountList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemCountListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHuanJingBaseIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HuanJingBaseIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHuanJingLevelList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HuanJingLevelListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHuanJingSkillLevelList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HuanJingSkillLevelListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHuanJingEquipStarList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HuanJingEquipStarListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingJiBan> CreateFB_HuanJingJiBan(FlatBufferBuilder builder,
      int Id = 0,
      int Group = -1,
      int HuanJingJiBanLv = -1,
      int PassiveSkillId = -1,
      StringOffset SkillTitle = default(StringOffset),
      StringOffset SkillInfo = default(StringOffset),
      StringOffset RequireInfo = default(StringOffset),
      VectorOffset CostItemIdList = default(VectorOffset),
      VectorOffset CostItemCountList = default(VectorOffset),
      VectorOffset HuanJingBaseIdList = default(VectorOffset),
      VectorOffset HuanJingLevelList = default(VectorOffset),
      VectorOffset HuanJingSkillLevelList = default(VectorOffset),
      VectorOffset HuanJingEquipStarList = default(VectorOffset)) {
    builder.StartObject(13);
    FB_HuanJingJiBan.AddHuanJingEquipStarList(builder, HuanJingEquipStarList);
    FB_HuanJingJiBan.AddHuanJingSkillLevelList(builder, HuanJingSkillLevelList);
    FB_HuanJingJiBan.AddHuanJingLevelList(builder, HuanJingLevelList);
    FB_HuanJingJiBan.AddHuanJingBaseIdList(builder, HuanJingBaseIdList);
    FB_HuanJingJiBan.AddCostItemCountList(builder, CostItemCountList);
    FB_HuanJingJiBan.AddCostItemIdList(builder, CostItemIdList);
    FB_HuanJingJiBan.AddRequireInfo(builder, RequireInfo);
    FB_HuanJingJiBan.AddSkillInfo(builder, SkillInfo);
    FB_HuanJingJiBan.AddSkillTitle(builder, SkillTitle);
    FB_HuanJingJiBan.AddPassiveSkillId(builder, PassiveSkillId);
    FB_HuanJingJiBan.AddHuanJingJiBanLv(builder, HuanJingJiBanLv);
    FB_HuanJingJiBan.AddGroup(builder, Group);
    FB_HuanJingJiBan.AddId(builder, Id);
    return FB_HuanJingJiBan.EndFB_HuanJingJiBan(builder);
  }

  public static void StartFB_HuanJingJiBan(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGroup(FlatBufferBuilder builder, int Group) { builder.AddInt(1, Group, -1); }
  public static void AddHuanJingJiBanLv(FlatBufferBuilder builder, int HuanJingJiBanLv) { builder.AddInt(2, HuanJingJiBanLv, -1); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(3, PassiveSkillId, -1); }
  public static void AddSkillTitle(FlatBufferBuilder builder, StringOffset SkillTitleOffset) { builder.AddOffset(4, SkillTitleOffset.Value, 0); }
  public static void AddSkillInfo(FlatBufferBuilder builder, StringOffset SkillInfoOffset) { builder.AddOffset(5, SkillInfoOffset.Value, 0); }
  public static void AddRequireInfo(FlatBufferBuilder builder, StringOffset RequireInfoOffset) { builder.AddOffset(6, RequireInfoOffset.Value, 0); }
  public static void AddCostItemIdList(FlatBufferBuilder builder, VectorOffset CostItemIdListOffset) { builder.AddOffset(7, CostItemIdListOffset.Value, 0); }
  public static VectorOffset CreateCostItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostItemCountList(FlatBufferBuilder builder, VectorOffset CostItemCountListOffset) { builder.AddOffset(8, CostItemCountListOffset.Value, 0); }
  public static VectorOffset CreateCostItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHuanJingBaseIdList(FlatBufferBuilder builder, VectorOffset HuanJingBaseIdListOffset) { builder.AddOffset(9, HuanJingBaseIdListOffset.Value, 0); }
  public static VectorOffset CreateHuanJingBaseIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHuanJingBaseIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHuanJingLevelList(FlatBufferBuilder builder, VectorOffset HuanJingLevelListOffset) { builder.AddOffset(10, HuanJingLevelListOffset.Value, 0); }
  public static VectorOffset CreateHuanJingLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHuanJingLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHuanJingSkillLevelList(FlatBufferBuilder builder, VectorOffset HuanJingSkillLevelListOffset) { builder.AddOffset(11, HuanJingSkillLevelListOffset.Value, 0); }
  public static VectorOffset CreateHuanJingSkillLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHuanJingSkillLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHuanJingEquipStarList(FlatBufferBuilder builder, VectorOffset HuanJingEquipStarListOffset) { builder.AddOffset(12, HuanJingEquipStarListOffset.Value, 0); }
  public static VectorOffset CreateHuanJingEquipStarListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHuanJingEquipStarListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingJiBan> EndFB_HuanJingJiBan(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingJiBan>(o);
  }
};

public sealed class FB_HuanJingJiBanContainer : Table {
  public static FB_HuanJingJiBanContainer GetRootAsFB_HuanJingJiBanContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingJiBanContainer(_bb, new FB_HuanJingJiBanContainer()); }
  public static FB_HuanJingJiBanContainer GetRootAsFB_HuanJingJiBanContainer(ByteBuffer _bb, FB_HuanJingJiBanContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingJiBanContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingJiBanContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingJiBan GetItems(int j) { return GetItems(new FB_HuanJingJiBan(), j); }
  public FB_HuanJingJiBan GetItems(FB_HuanJingJiBan obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingJiBanContainer> CreateFB_HuanJingJiBanContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingJiBanContainer.AddItems(builder, items);
    return FB_HuanJingJiBanContainer.EndFB_HuanJingJiBanContainer(builder);
  }

  public static void StartFB_HuanJingJiBanContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingJiBan>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingJiBanContainer> EndFB_HuanJingJiBanContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingJiBanContainer>(o);
  }
  public static void FinishFB_HuanJingJiBanContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingJiBanContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
