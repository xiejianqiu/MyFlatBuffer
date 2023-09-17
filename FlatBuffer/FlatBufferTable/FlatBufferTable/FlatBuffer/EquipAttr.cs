// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipAttr : Table {
  public static FB_EquipAttr GetRootAsFB_EquipAttr(ByteBuffer _bb) { return GetRootAsFB_EquipAttr(_bb, new FB_EquipAttr()); }
  public static FB_EquipAttr GetRootAsFB_EquipAttr(ByteBuffer _bb, FB_EquipAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JieLvl { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ModelId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EffectId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Component { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Attribute0ID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute0Value { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1ID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute1Value { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2ID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute2Value { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute3ID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute3Value { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute4ID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute4Value { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute5ID { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attribute5Value { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RMBAttribute { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BroadcastRate { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelRequest { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StarCount { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShenDuanCount { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TipsStrId { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShenZhuang { get { int o = __offset(50); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int FenJieCount { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillIdList(int j) { int o = __offset(54); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillIdListLength { get { int o = __offset(54); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPassiveSkillDesList(int j) { int o = __offset(56); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillDesListLength { get { int o = __offset(56); return o != 0 ? __vector_len(o) : 0; } }
  public int BaseAttrPercent { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SpecialAttrPercent { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsXuanJiEquip { get { int o = __offset(62); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int XuanJiChangeJob { get { int o = __offset(64); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanRongLian { get { int o = __offset(66); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetXuanJiAttrIdList(int j) { int o = __offset(68); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int XuanJiAttrIdListLength { get { int o = __offset(68); return o != 0 ? __vector_len(o) : 0; } }
  public int GetXuanJiAttrValueList(int j) { int o = __offset(70); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int XuanJiAttrValueListLength { get { int o = __offset(70); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipAttr> CreateFB_EquipAttr(FlatBufferBuilder builder,
      int Id = 0,
      int JieLvl = 0,
      int ModelId = -1,
      int EffectId = -1,
      int Component = 0,
      int Attribute0ID = -1,
      int Attribute0Value = -1,
      int Attribute1ID = -1,
      int Attribute1Value = -1,
      int Attribute2ID = -1,
      int Attribute2Value = -1,
      int Attribute3ID = -1,
      int Attribute3Value = -1,
      int Attribute4ID = -1,
      int Attribute4Value = -1,
      int Attribute5ID = -1,
      int Attribute5Value = -1,
      int RMBAttribute = -1,
      int BroadcastRate = -1,
      int LevelRequest = -1,
      int StarCount = -1,
      int ShenDuanCount = -1,
      int TipsStrId = -1,
      bool IsShenZhuang = false,
      int FenJieCount = -1,
      VectorOffset PassiveSkillIdList = default(VectorOffset),
      VectorOffset PassiveSkillDesList = default(VectorOffset),
      int BaseAttrPercent = -1,
      int SpecialAttrPercent = -1,
      bool IsXuanJiEquip = false,
      int XuanJiChangeJob = -1,
      bool CanRongLian = false,
      VectorOffset XuanJiAttrIdList = default(VectorOffset),
      VectorOffset XuanJiAttrValueList = default(VectorOffset)) {
    builder.StartObject(34);
    FB_EquipAttr.AddXuanJiAttrValueList(builder, XuanJiAttrValueList);
    FB_EquipAttr.AddXuanJiAttrIdList(builder, XuanJiAttrIdList);
    FB_EquipAttr.AddXuanJiChangeJob(builder, XuanJiChangeJob);
    FB_EquipAttr.AddSpecialAttrPercent(builder, SpecialAttrPercent);
    FB_EquipAttr.AddBaseAttrPercent(builder, BaseAttrPercent);
    FB_EquipAttr.AddPassiveSkillDesList(builder, PassiveSkillDesList);
    FB_EquipAttr.AddPassiveSkillIdList(builder, PassiveSkillIdList);
    FB_EquipAttr.AddFenJieCount(builder, FenJieCount);
    FB_EquipAttr.AddTipsStrId(builder, TipsStrId);
    FB_EquipAttr.AddShenDuanCount(builder, ShenDuanCount);
    FB_EquipAttr.AddStarCount(builder, StarCount);
    FB_EquipAttr.AddLevelRequest(builder, LevelRequest);
    FB_EquipAttr.AddBroadcastRate(builder, BroadcastRate);
    FB_EquipAttr.AddRMBAttribute(builder, RMBAttribute);
    FB_EquipAttr.AddAttribute5Value(builder, Attribute5Value);
    FB_EquipAttr.AddAttribute5ID(builder, Attribute5ID);
    FB_EquipAttr.AddAttribute4Value(builder, Attribute4Value);
    FB_EquipAttr.AddAttribute4ID(builder, Attribute4ID);
    FB_EquipAttr.AddAttribute3Value(builder, Attribute3Value);
    FB_EquipAttr.AddAttribute3ID(builder, Attribute3ID);
    FB_EquipAttr.AddAttribute2Value(builder, Attribute2Value);
    FB_EquipAttr.AddAttribute2ID(builder, Attribute2ID);
    FB_EquipAttr.AddAttribute1Value(builder, Attribute1Value);
    FB_EquipAttr.AddAttribute1ID(builder, Attribute1ID);
    FB_EquipAttr.AddAttribute0Value(builder, Attribute0Value);
    FB_EquipAttr.AddAttribute0ID(builder, Attribute0ID);
    FB_EquipAttr.AddComponent(builder, Component);
    FB_EquipAttr.AddEffectId(builder, EffectId);
    FB_EquipAttr.AddModelId(builder, ModelId);
    FB_EquipAttr.AddJieLvl(builder, JieLvl);
    FB_EquipAttr.AddId(builder, Id);
    FB_EquipAttr.AddCanRongLian(builder, CanRongLian);
    FB_EquipAttr.AddIsXuanJiEquip(builder, IsXuanJiEquip);
    FB_EquipAttr.AddIsShenZhuang(builder, IsShenZhuang);
    return FB_EquipAttr.EndFB_EquipAttr(builder);
  }

  public static void StartFB_EquipAttr(FlatBufferBuilder builder) { builder.StartObject(34); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddJieLvl(FlatBufferBuilder builder, int JieLvl) { builder.AddInt(1, JieLvl, 0); }
  public static void AddModelId(FlatBufferBuilder builder, int ModelId) { builder.AddInt(2, ModelId, -1); }
  public static void AddEffectId(FlatBufferBuilder builder, int EffectId) { builder.AddInt(3, EffectId, -1); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(4, Component, 0); }
  public static void AddAttribute0ID(FlatBufferBuilder builder, int Attribute0ID) { builder.AddInt(5, Attribute0ID, -1); }
  public static void AddAttribute0Value(FlatBufferBuilder builder, int Attribute0Value) { builder.AddInt(6, Attribute0Value, -1); }
  public static void AddAttribute1ID(FlatBufferBuilder builder, int Attribute1ID) { builder.AddInt(7, Attribute1ID, -1); }
  public static void AddAttribute1Value(FlatBufferBuilder builder, int Attribute1Value) { builder.AddInt(8, Attribute1Value, -1); }
  public static void AddAttribute2ID(FlatBufferBuilder builder, int Attribute2ID) { builder.AddInt(9, Attribute2ID, -1); }
  public static void AddAttribute2Value(FlatBufferBuilder builder, int Attribute2Value) { builder.AddInt(10, Attribute2Value, -1); }
  public static void AddAttribute3ID(FlatBufferBuilder builder, int Attribute3ID) { builder.AddInt(11, Attribute3ID, -1); }
  public static void AddAttribute3Value(FlatBufferBuilder builder, int Attribute3Value) { builder.AddInt(12, Attribute3Value, -1); }
  public static void AddAttribute4ID(FlatBufferBuilder builder, int Attribute4ID) { builder.AddInt(13, Attribute4ID, -1); }
  public static void AddAttribute4Value(FlatBufferBuilder builder, int Attribute4Value) { builder.AddInt(14, Attribute4Value, -1); }
  public static void AddAttribute5ID(FlatBufferBuilder builder, int Attribute5ID) { builder.AddInt(15, Attribute5ID, -1); }
  public static void AddAttribute5Value(FlatBufferBuilder builder, int Attribute5Value) { builder.AddInt(16, Attribute5Value, -1); }
  public static void AddRMBAttribute(FlatBufferBuilder builder, int RMBAttribute) { builder.AddInt(17, RMBAttribute, -1); }
  public static void AddBroadcastRate(FlatBufferBuilder builder, int BroadcastRate) { builder.AddInt(18, BroadcastRate, -1); }
  public static void AddLevelRequest(FlatBufferBuilder builder, int LevelRequest) { builder.AddInt(19, LevelRequest, -1); }
  public static void AddStarCount(FlatBufferBuilder builder, int StarCount) { builder.AddInt(20, StarCount, -1); }
  public static void AddShenDuanCount(FlatBufferBuilder builder, int ShenDuanCount) { builder.AddInt(21, ShenDuanCount, -1); }
  public static void AddTipsStrId(FlatBufferBuilder builder, int TipsStrId) { builder.AddInt(22, TipsStrId, -1); }
  public static void AddIsShenZhuang(FlatBufferBuilder builder, bool IsShenZhuang) { builder.AddBool(23, IsShenZhuang, false); }
  public static void AddFenJieCount(FlatBufferBuilder builder, int FenJieCount) { builder.AddInt(24, FenJieCount, -1); }
  public static void AddPassiveSkillIdList(FlatBufferBuilder builder, VectorOffset PassiveSkillIdListOffset) { builder.AddOffset(25, PassiveSkillIdListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveSkillDesList(FlatBufferBuilder builder, VectorOffset PassiveSkillDesListOffset) { builder.AddOffset(26, PassiveSkillDesListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillDesListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillDesListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseAttrPercent(FlatBufferBuilder builder, int BaseAttrPercent) { builder.AddInt(27, BaseAttrPercent, -1); }
  public static void AddSpecialAttrPercent(FlatBufferBuilder builder, int SpecialAttrPercent) { builder.AddInt(28, SpecialAttrPercent, -1); }
  public static void AddIsXuanJiEquip(FlatBufferBuilder builder, bool IsXuanJiEquip) { builder.AddBool(29, IsXuanJiEquip, false); }
  public static void AddXuanJiChangeJob(FlatBufferBuilder builder, int XuanJiChangeJob) { builder.AddInt(30, XuanJiChangeJob, -1); }
  public static void AddCanRongLian(FlatBufferBuilder builder, bool CanRongLian) { builder.AddBool(31, CanRongLian, false); }
  public static void AddXuanJiAttrIdList(FlatBufferBuilder builder, VectorOffset XuanJiAttrIdListOffset) { builder.AddOffset(32, XuanJiAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateXuanJiAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartXuanJiAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddXuanJiAttrValueList(FlatBufferBuilder builder, VectorOffset XuanJiAttrValueListOffset) { builder.AddOffset(33, XuanJiAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateXuanJiAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartXuanJiAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipAttr> EndFB_EquipAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipAttr>(o);
  }
};

public sealed class FB_EquipAttrContainer : Table {
  public static FB_EquipAttrContainer GetRootAsFB_EquipAttrContainer(ByteBuffer _bb) { return GetRootAsFB_EquipAttrContainer(_bb, new FB_EquipAttrContainer()); }
  public static FB_EquipAttrContainer GetRootAsFB_EquipAttrContainer(ByteBuffer _bb, FB_EquipAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipAttr GetItems(int j) { return GetItems(new FB_EquipAttr(), j); }
  public FB_EquipAttr GetItems(FB_EquipAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipAttrContainer> CreateFB_EquipAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipAttrContainer.AddItems(builder, items);
    return FB_EquipAttrContainer.EndFB_EquipAttrContainer(builder);
  }

  public static void StartFB_EquipAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipAttrContainer> EndFB_EquipAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipAttrContainer>(o);
  }
  public static void FinishFB_EquipAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
