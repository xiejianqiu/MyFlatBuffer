// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FuLiDaTing : Table {
  public static FB_FuLiDaTing GetRootAsFB_FuLiDaTing(ByteBuffer _bb) { return GetRootAsFB_FuLiDaTing(_bb, new FB_FuLiDaTing()); }
  public static FB_FuLiDaTing GetRootAsFB_FuLiDaTing(ByteBuffer _bb, FB_FuLiDaTing obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FuLiDaTing __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsAcitve { get { int o = __offset(8); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ActivityId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockParam { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpIndex { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanUseAddExpRate { get { int o = __offset(18); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int MoneyType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyCost { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float YBAddExpRate { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int GetYBItemIdList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int YBItemIdListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetYBItemCountList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int YBItemCountListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public int YBMoneyType { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long YBMoneyCost { get { int o = __offset(32); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int YBMoneyShow { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetNormalItemIdList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NormalItemIdListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public int GetNormalItemCountList(int j) { int o = __offset(38); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NormalItemCountListLength { get { int o = __offset(38); return o != 0 ? __vector_len(o) : 0; } }
  public int NormalMoneyType { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long NormalMoneyCost { get { int o = __offset(42); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int NormalMoneyShow { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MdId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Count { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MFId { get { int o = __offset(50); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAchievementTypeList(int j) { int o = __offset(52); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AchievementTypeListLength { get { int o = __offset(52); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAchievementPointList(int j) { int o = __offset(54); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AchievementPointListLength { get { int o = __offset(54); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FuLiDaTing> CreateFB_FuLiDaTing(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      bool IsAcitve = false,
      int ActivityId = -1,
      int UnlockType = -1,
      int UnlockParam = -1,
      int ExpIndex = -1,
      bool CanUseAddExpRate = false,
      int MoneyType = -1,
      int MoneyCost = -1,
      float YBAddExpRate = -1,
      VectorOffset YBItemIdList = default(VectorOffset),
      VectorOffset YBItemCountList = default(VectorOffset),
      int YBMoneyType = -1,
      long YBMoneyCost = -1,
      int YBMoneyShow = -1,
      VectorOffset NormalItemIdList = default(VectorOffset),
      VectorOffset NormalItemCountList = default(VectorOffset),
      int NormalMoneyType = -1,
      long NormalMoneyCost = -1,
      int NormalMoneyShow = -1,
      int MdId = -1,
      int Count = -1,
      int MFId = -1,
      VectorOffset AchievementTypeList = default(VectorOffset),
      VectorOffset AchievementPointList = default(VectorOffset)) {
    builder.StartObject(26);
    FB_FuLiDaTing.AddNormalMoneyCost(builder, NormalMoneyCost);
    FB_FuLiDaTing.AddYBMoneyCost(builder, YBMoneyCost);
    FB_FuLiDaTing.AddAchievementPointList(builder, AchievementPointList);
    FB_FuLiDaTing.AddAchievementTypeList(builder, AchievementTypeList);
    FB_FuLiDaTing.AddMFId(builder, MFId);
    FB_FuLiDaTing.AddCount(builder, Count);
    FB_FuLiDaTing.AddMdId(builder, MdId);
    FB_FuLiDaTing.AddNormalMoneyShow(builder, NormalMoneyShow);
    FB_FuLiDaTing.AddNormalMoneyType(builder, NormalMoneyType);
    FB_FuLiDaTing.AddNormalItemCountList(builder, NormalItemCountList);
    FB_FuLiDaTing.AddNormalItemIdList(builder, NormalItemIdList);
    FB_FuLiDaTing.AddYBMoneyShow(builder, YBMoneyShow);
    FB_FuLiDaTing.AddYBMoneyType(builder, YBMoneyType);
    FB_FuLiDaTing.AddYBItemCountList(builder, YBItemCountList);
    FB_FuLiDaTing.AddYBItemIdList(builder, YBItemIdList);
    FB_FuLiDaTing.AddYBAddExpRate(builder, YBAddExpRate);
    FB_FuLiDaTing.AddMoneyCost(builder, MoneyCost);
    FB_FuLiDaTing.AddMoneyType(builder, MoneyType);
    FB_FuLiDaTing.AddExpIndex(builder, ExpIndex);
    FB_FuLiDaTing.AddUnlockParam(builder, UnlockParam);
    FB_FuLiDaTing.AddUnlockType(builder, UnlockType);
    FB_FuLiDaTing.AddActivityId(builder, ActivityId);
    FB_FuLiDaTing.AddName(builder, Name);
    FB_FuLiDaTing.AddId(builder, Id);
    FB_FuLiDaTing.AddCanUseAddExpRate(builder, CanUseAddExpRate);
    FB_FuLiDaTing.AddIsAcitve(builder, IsAcitve);
    return FB_FuLiDaTing.EndFB_FuLiDaTing(builder);
  }

  public static void StartFB_FuLiDaTing(FlatBufferBuilder builder) { builder.StartObject(26); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIsAcitve(FlatBufferBuilder builder, bool IsAcitve) { builder.AddBool(2, IsAcitve, false); }
  public static void AddActivityId(FlatBufferBuilder builder, int ActivityId) { builder.AddInt(3, ActivityId, -1); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(4, UnlockType, -1); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(5, UnlockParam, -1); }
  public static void AddExpIndex(FlatBufferBuilder builder, int ExpIndex) { builder.AddInt(6, ExpIndex, -1); }
  public static void AddCanUseAddExpRate(FlatBufferBuilder builder, bool CanUseAddExpRate) { builder.AddBool(7, CanUseAddExpRate, false); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(8, MoneyType, -1); }
  public static void AddMoneyCost(FlatBufferBuilder builder, int MoneyCost) { builder.AddInt(9, MoneyCost, -1); }
  public static void AddYBAddExpRate(FlatBufferBuilder builder, float YBAddExpRate) { builder.AddFloat(10, YBAddExpRate, -1); }
  public static void AddYBItemIdList(FlatBufferBuilder builder, VectorOffset YBItemIdListOffset) { builder.AddOffset(11, YBItemIdListOffset.Value, 0); }
  public static VectorOffset CreateYBItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartYBItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddYBItemCountList(FlatBufferBuilder builder, VectorOffset YBItemCountListOffset) { builder.AddOffset(12, YBItemCountListOffset.Value, 0); }
  public static VectorOffset CreateYBItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartYBItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddYBMoneyType(FlatBufferBuilder builder, int YBMoneyType) { builder.AddInt(13, YBMoneyType, -1); }
  public static void AddYBMoneyCost(FlatBufferBuilder builder, long YBMoneyCost) { builder.AddLong(14, YBMoneyCost, -1); }
  public static void AddYBMoneyShow(FlatBufferBuilder builder, int YBMoneyShow) { builder.AddInt(15, YBMoneyShow, -1); }
  public static void AddNormalItemIdList(FlatBufferBuilder builder, VectorOffset NormalItemIdListOffset) { builder.AddOffset(16, NormalItemIdListOffset.Value, 0); }
  public static VectorOffset CreateNormalItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNormalItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNormalItemCountList(FlatBufferBuilder builder, VectorOffset NormalItemCountListOffset) { builder.AddOffset(17, NormalItemCountListOffset.Value, 0); }
  public static VectorOffset CreateNormalItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNormalItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNormalMoneyType(FlatBufferBuilder builder, int NormalMoneyType) { builder.AddInt(18, NormalMoneyType, -1); }
  public static void AddNormalMoneyCost(FlatBufferBuilder builder, long NormalMoneyCost) { builder.AddLong(19, NormalMoneyCost, -1); }
  public static void AddNormalMoneyShow(FlatBufferBuilder builder, int NormalMoneyShow) { builder.AddInt(20, NormalMoneyShow, -1); }
  public static void AddMdId(FlatBufferBuilder builder, int MdId) { builder.AddInt(21, MdId, -1); }
  public static void AddCount(FlatBufferBuilder builder, int Count) { builder.AddInt(22, Count, -1); }
  public static void AddMFId(FlatBufferBuilder builder, int MFId) { builder.AddInt(23, MFId, -1); }
  public static void AddAchievementTypeList(FlatBufferBuilder builder, VectorOffset AchievementTypeListOffset) { builder.AddOffset(24, AchievementTypeListOffset.Value, 0); }
  public static VectorOffset CreateAchievementTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAchievementTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAchievementPointList(FlatBufferBuilder builder, VectorOffset AchievementPointListOffset) { builder.AddOffset(25, AchievementPointListOffset.Value, 0); }
  public static VectorOffset CreateAchievementPointListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAchievementPointListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FuLiDaTing> EndFB_FuLiDaTing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FuLiDaTing>(o);
  }
};

public sealed class FB_FuLiDaTingContainer : Table {
  public static FB_FuLiDaTingContainer GetRootAsFB_FuLiDaTingContainer(ByteBuffer _bb) { return GetRootAsFB_FuLiDaTingContainer(_bb, new FB_FuLiDaTingContainer()); }
  public static FB_FuLiDaTingContainer GetRootAsFB_FuLiDaTingContainer(ByteBuffer _bb, FB_FuLiDaTingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FuLiDaTingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FuLiDaTingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FuLiDaTing GetItems(int j) { return GetItems(new FB_FuLiDaTing(), j); }
  public FB_FuLiDaTing GetItems(FB_FuLiDaTing obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FuLiDaTingContainer> CreateFB_FuLiDaTingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FuLiDaTingContainer.AddItems(builder, items);
    return FB_FuLiDaTingContainer.EndFB_FuLiDaTingContainer(builder);
  }

  public static void StartFB_FuLiDaTingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FuLiDaTing>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FuLiDaTingContainer> EndFB_FuLiDaTingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FuLiDaTingContainer>(o);
  }
  public static void FinishFB_FuLiDaTingContainerBuffer(FlatBufferBuilder builder, Offset<FB_FuLiDaTingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
