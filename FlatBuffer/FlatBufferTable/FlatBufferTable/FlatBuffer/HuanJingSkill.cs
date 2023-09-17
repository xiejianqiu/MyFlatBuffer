// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingSkill : Table {
  public static FB_HuanJingSkill GetRootAsFB_HuanJingSkill(ByteBuffer _bb) { return GetRootAsFB_HuanJingSkill(_bb, new FB_HuanJingSkill()); }
  public static FB_HuanJingSkill GetRootAsFB_HuanJingSkill(ByteBuffer _bb, FB_HuanJingSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HuanJingBaseId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HuanJingSkillLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCostItemIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostItemCountList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostItemCountListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPassiveSkillIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public string SkillDes { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_HuanJingSkill> CreateFB_HuanJingSkill(FlatBufferBuilder builder,
      int ID = 0,
      int HuanJingBaseId = -1,
      int HuanJingSkillLevel = -1,
      VectorOffset CostItemIdList = default(VectorOffset),
      VectorOffset CostItemCountList = default(VectorOffset),
      VectorOffset PassiveSkillIdList = default(VectorOffset),
      StringOffset SkillDes = default(StringOffset)) {
    builder.StartObject(7);
    FB_HuanJingSkill.AddSkillDes(builder, SkillDes);
    FB_HuanJingSkill.AddPassiveSkillIdList(builder, PassiveSkillIdList);
    FB_HuanJingSkill.AddCostItemCountList(builder, CostItemCountList);
    FB_HuanJingSkill.AddCostItemIdList(builder, CostItemIdList);
    FB_HuanJingSkill.AddHuanJingSkillLevel(builder, HuanJingSkillLevel);
    FB_HuanJingSkill.AddHuanJingBaseId(builder, HuanJingBaseId);
    FB_HuanJingSkill.AddID(builder, ID);
    return FB_HuanJingSkill.EndFB_HuanJingSkill(builder);
  }

  public static void StartFB_HuanJingSkill(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddHuanJingBaseId(FlatBufferBuilder builder, int HuanJingBaseId) { builder.AddInt(1, HuanJingBaseId, -1); }
  public static void AddHuanJingSkillLevel(FlatBufferBuilder builder, int HuanJingSkillLevel) { builder.AddInt(2, HuanJingSkillLevel, -1); }
  public static void AddCostItemIdList(FlatBufferBuilder builder, VectorOffset CostItemIdListOffset) { builder.AddOffset(3, CostItemIdListOffset.Value, 0); }
  public static VectorOffset CreateCostItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostItemCountList(FlatBufferBuilder builder, VectorOffset CostItemCountListOffset) { builder.AddOffset(4, CostItemCountListOffset.Value, 0); }
  public static VectorOffset CreateCostItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveSkillIdList(FlatBufferBuilder builder, VectorOffset PassiveSkillIdListOffset) { builder.AddOffset(5, PassiveSkillIdListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillDes(FlatBufferBuilder builder, StringOffset SkillDesOffset) { builder.AddOffset(6, SkillDesOffset.Value, 0); }
  public static Offset<FB_HuanJingSkill> EndFB_HuanJingSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingSkill>(o);
  }
};

public sealed class FB_HuanJingSkillContainer : Table {
  public static FB_HuanJingSkillContainer GetRootAsFB_HuanJingSkillContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingSkillContainer(_bb, new FB_HuanJingSkillContainer()); }
  public static FB_HuanJingSkillContainer GetRootAsFB_HuanJingSkillContainer(ByteBuffer _bb, FB_HuanJingSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingSkill GetItems(int j) { return GetItems(new FB_HuanJingSkill(), j); }
  public FB_HuanJingSkill GetItems(FB_HuanJingSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingSkillContainer> CreateFB_HuanJingSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingSkillContainer.AddItems(builder, items);
    return FB_HuanJingSkillContainer.EndFB_HuanJingSkillContainer(builder);
  }

  public static void StartFB_HuanJingSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingSkillContainer> EndFB_HuanJingSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingSkillContainer>(o);
  }
  public static void FinishFB_HuanJingSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
