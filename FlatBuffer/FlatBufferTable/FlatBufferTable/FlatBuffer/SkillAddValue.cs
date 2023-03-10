// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillAddValue : Table {
  public static FB_SkillAddValue GetRootAsFB_SkillAddValue(ByteBuffer _bb) { return GetRootAsFB_SkillAddValue(_bb, new FB_SkillAddValue()); }
  public static FB_SkillAddValue GetRootAsFB_SkillAddValue(ByteBuffer _bb, FB_SkillAddValue obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillAddValue __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TianFuId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TianFuLevelValue { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BloodId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BloodLevelValue { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ZhuanJingId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ZhuanJingLevelValue { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneLevelValue { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RuneJieValue { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LingGangId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LingGangLevelValue { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HunJiangJiBanId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HunJiangJiBanValue { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DestinySkillID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DestinyValue { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SevenStartSkillID { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SevenStartValue { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WarPetSkillTabId { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WarPetValue { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShenShiId { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShenShiValue { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShenShiSystemId { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int YuanShenLevelAddValue { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShenShiSystemValue { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int XuanJiTianFuId { get { int o = __offset(54); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int XuanJiTianFuValue { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CampId { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CampValue { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FengHaoValue { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SkillAddValue> CreateFB_SkillAddValue(FlatBufferBuilder builder,
      int ID = 0,
      int TianFuId = -1,
      int TianFuLevelValue = -1,
      int BloodId = -1,
      int BloodLevelValue = -1,
      int ZhuanJingId = -1,
      int ZhuanJingLevelValue = -1,
      int RuneId = -1,
      int RuneLevelValue = -1,
      int RuneJieValue = -1,
      int LingGangId = -1,
      int LingGangLevelValue = -1,
      int HunJiangJiBanId = -1,
      int HunJiangJiBanValue = -1,
      int DestinySkillID = -1,
      int DestinyValue = -1,
      int SevenStartSkillID = -1,
      int SevenStartValue = -1,
      int WarPetSkillTabId = -1,
      int WarPetValue = -1,
      int ShenShiId = -1,
      int ShenShiValue = -1,
      int ShenShiSystemId = -1,
      int YuanShenLevelAddValue = -1,
      int ShenShiSystemValue = -1,
      int XuanJiTianFuId = -1,
      int XuanJiTianFuValue = -1,
      int CampId = -1,
      int CampValue = -1,
      int FengHaoValue = -1) {
    builder.StartObject(30);
    FB_SkillAddValue.AddFengHaoValue(builder, FengHaoValue);
    FB_SkillAddValue.AddCampValue(builder, CampValue);
    FB_SkillAddValue.AddCampId(builder, CampId);
    FB_SkillAddValue.AddXuanJiTianFuValue(builder, XuanJiTianFuValue);
    FB_SkillAddValue.AddXuanJiTianFuId(builder, XuanJiTianFuId);
    FB_SkillAddValue.AddShenShiSystemValue(builder, ShenShiSystemValue);
    FB_SkillAddValue.AddYuanShenLevelAddValue(builder, YuanShenLevelAddValue);
    FB_SkillAddValue.AddShenShiSystemId(builder, ShenShiSystemId);
    FB_SkillAddValue.AddShenShiValue(builder, ShenShiValue);
    FB_SkillAddValue.AddShenShiId(builder, ShenShiId);
    FB_SkillAddValue.AddWarPetValue(builder, WarPetValue);
    FB_SkillAddValue.AddWarPetSkillTabId(builder, WarPetSkillTabId);
    FB_SkillAddValue.AddSevenStartValue(builder, SevenStartValue);
    FB_SkillAddValue.AddSevenStartSkillID(builder, SevenStartSkillID);
    FB_SkillAddValue.AddDestinyValue(builder, DestinyValue);
    FB_SkillAddValue.AddDestinySkillID(builder, DestinySkillID);
    FB_SkillAddValue.AddHunJiangJiBanValue(builder, HunJiangJiBanValue);
    FB_SkillAddValue.AddHunJiangJiBanId(builder, HunJiangJiBanId);
    FB_SkillAddValue.AddLingGangLevelValue(builder, LingGangLevelValue);
    FB_SkillAddValue.AddLingGangId(builder, LingGangId);
    FB_SkillAddValue.AddRuneJieValue(builder, RuneJieValue);
    FB_SkillAddValue.AddRuneLevelValue(builder, RuneLevelValue);
    FB_SkillAddValue.AddRuneId(builder, RuneId);
    FB_SkillAddValue.AddZhuanJingLevelValue(builder, ZhuanJingLevelValue);
    FB_SkillAddValue.AddZhuanJingId(builder, ZhuanJingId);
    FB_SkillAddValue.AddBloodLevelValue(builder, BloodLevelValue);
    FB_SkillAddValue.AddBloodId(builder, BloodId);
    FB_SkillAddValue.AddTianFuLevelValue(builder, TianFuLevelValue);
    FB_SkillAddValue.AddTianFuId(builder, TianFuId);
    FB_SkillAddValue.AddID(builder, ID);
    return FB_SkillAddValue.EndFB_SkillAddValue(builder);
  }

  public static void StartFB_SkillAddValue(FlatBufferBuilder builder) { builder.StartObject(30); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTianFuId(FlatBufferBuilder builder, int TianFuId) { builder.AddInt(1, TianFuId, -1); }
  public static void AddTianFuLevelValue(FlatBufferBuilder builder, int TianFuLevelValue) { builder.AddInt(2, TianFuLevelValue, -1); }
  public static void AddBloodId(FlatBufferBuilder builder, int BloodId) { builder.AddInt(3, BloodId, -1); }
  public static void AddBloodLevelValue(FlatBufferBuilder builder, int BloodLevelValue) { builder.AddInt(4, BloodLevelValue, -1); }
  public static void AddZhuanJingId(FlatBufferBuilder builder, int ZhuanJingId) { builder.AddInt(5, ZhuanJingId, -1); }
  public static void AddZhuanJingLevelValue(FlatBufferBuilder builder, int ZhuanJingLevelValue) { builder.AddInt(6, ZhuanJingLevelValue, -1); }
  public static void AddRuneId(FlatBufferBuilder builder, int RuneId) { builder.AddInt(7, RuneId, -1); }
  public static void AddRuneLevelValue(FlatBufferBuilder builder, int RuneLevelValue) { builder.AddInt(8, RuneLevelValue, -1); }
  public static void AddRuneJieValue(FlatBufferBuilder builder, int RuneJieValue) { builder.AddInt(9, RuneJieValue, -1); }
  public static void AddLingGangId(FlatBufferBuilder builder, int LingGangId) { builder.AddInt(10, LingGangId, -1); }
  public static void AddLingGangLevelValue(FlatBufferBuilder builder, int LingGangLevelValue) { builder.AddInt(11, LingGangLevelValue, -1); }
  public static void AddHunJiangJiBanId(FlatBufferBuilder builder, int HunJiangJiBanId) { builder.AddInt(12, HunJiangJiBanId, -1); }
  public static void AddHunJiangJiBanValue(FlatBufferBuilder builder, int HunJiangJiBanValue) { builder.AddInt(13, HunJiangJiBanValue, -1); }
  public static void AddDestinySkillID(FlatBufferBuilder builder, int DestinySkillID) { builder.AddInt(14, DestinySkillID, -1); }
  public static void AddDestinyValue(FlatBufferBuilder builder, int DestinyValue) { builder.AddInt(15, DestinyValue, -1); }
  public static void AddSevenStartSkillID(FlatBufferBuilder builder, int SevenStartSkillID) { builder.AddInt(16, SevenStartSkillID, -1); }
  public static void AddSevenStartValue(FlatBufferBuilder builder, int SevenStartValue) { builder.AddInt(17, SevenStartValue, -1); }
  public static void AddWarPetSkillTabId(FlatBufferBuilder builder, int WarPetSkillTabId) { builder.AddInt(18, WarPetSkillTabId, -1); }
  public static void AddWarPetValue(FlatBufferBuilder builder, int WarPetValue) { builder.AddInt(19, WarPetValue, -1); }
  public static void AddShenShiId(FlatBufferBuilder builder, int ShenShiId) { builder.AddInt(20, ShenShiId, -1); }
  public static void AddShenShiValue(FlatBufferBuilder builder, int ShenShiValue) { builder.AddInt(21, ShenShiValue, -1); }
  public static void AddShenShiSystemId(FlatBufferBuilder builder, int ShenShiSystemId) { builder.AddInt(22, ShenShiSystemId, -1); }
  public static void AddYuanShenLevelAddValue(FlatBufferBuilder builder, int YuanShenLevelAddValue) { builder.AddInt(23, YuanShenLevelAddValue, -1); }
  public static void AddShenShiSystemValue(FlatBufferBuilder builder, int ShenShiSystemValue) { builder.AddInt(24, ShenShiSystemValue, -1); }
  public static void AddXuanJiTianFuId(FlatBufferBuilder builder, int XuanJiTianFuId) { builder.AddInt(25, XuanJiTianFuId, -1); }
  public static void AddXuanJiTianFuValue(FlatBufferBuilder builder, int XuanJiTianFuValue) { builder.AddInt(26, XuanJiTianFuValue, -1); }
  public static void AddCampId(FlatBufferBuilder builder, int CampId) { builder.AddInt(27, CampId, -1); }
  public static void AddCampValue(FlatBufferBuilder builder, int CampValue) { builder.AddInt(28, CampValue, -1); }
  public static void AddFengHaoValue(FlatBufferBuilder builder, int FengHaoValue) { builder.AddInt(29, FengHaoValue, -1); }
  public static Offset<FB_SkillAddValue> EndFB_SkillAddValue(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillAddValue>(o);
  }
};

public sealed class FB_SkillAddValueContainer : Table {
  public static FB_SkillAddValueContainer GetRootAsFB_SkillAddValueContainer(ByteBuffer _bb) { return GetRootAsFB_SkillAddValueContainer(_bb, new FB_SkillAddValueContainer()); }
  public static FB_SkillAddValueContainer GetRootAsFB_SkillAddValueContainer(ByteBuffer _bb, FB_SkillAddValueContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillAddValueContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillAddValueContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillAddValue GetItems(int j) { return GetItems(new FB_SkillAddValue(), j); }
  public FB_SkillAddValue GetItems(FB_SkillAddValue obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillAddValueContainer> CreateFB_SkillAddValueContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillAddValueContainer.AddItems(builder, items);
    return FB_SkillAddValueContainer.EndFB_SkillAddValueContainer(builder);
  }

  public static void StartFB_SkillAddValueContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillAddValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillAddValueContainer> EndFB_SkillAddValueContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillAddValueContainer>(o);
  }
  public static void FinishFB_SkillAddValueContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillAddValueContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
