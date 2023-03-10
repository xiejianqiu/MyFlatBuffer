// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Impact : Table {
  public static FB_Impact GetRootAsFB_Impact(ByteBuffer _bb) { return GetRootAsFB_Impact(_bb, new FB_Impact()); }
  public static FB_Impact GetRootAsFB_Impact(ByteBuffer _bb, FB_Impact obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Impact __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ImpactID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DescribeID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool InDatabase { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool ElapseOffline { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int Duration { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SortId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ShowType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxOverlayCount { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsNeedNoticeClient { get { int o = __offset(22); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public string BuffIcon { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public int BuffType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsLimitSkill { get { int o = __offset(28); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int Threat { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LogicID { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EffectId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool KeepEffect { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int MutexcollectionId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Mutexpriority { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetParamValueList(int j) { int o = __offset(42); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamValueListLength { get { int o = __offset(42); return o != 0 ? __vector_len(o) : 0; } }
  public bool CanSynchronization { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int RefreshID { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RemoveType { get { int o = __offset(48); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_Impact> CreateFB_Impact(FlatBufferBuilder builder,
      int ImpactID = 0,
      StringOffset Name = default(StringOffset),
      int DescribeID = 0,
      bool InDatabase = false,
      bool ElapseOffline = false,
      int Duration = 0,
      int SortId = 0,
      int ShowType = 0,
      int MaxOverlayCount = 0,
      bool IsNeedNoticeClient = false,
      StringOffset BuffIcon = default(StringOffset),
      int BuffType = 0,
      bool IsLimitSkill = false,
      int threat = 0,
      int LogicID = 0,
      int EffectId = 0,
      bool KeepEffect = false,
      int MutexcollectionId = 0,
      int Mutexpriority = 0,
      VectorOffset ParamValue_List = default(VectorOffset),
      bool CanSynchronization = false,
      int RefreshID = 0,
      int RemoveType = 0) {
    builder.StartObject(23);
    FB_Impact.AddRemoveType(builder, RemoveType);
    FB_Impact.AddRefreshID(builder, RefreshID);
    FB_Impact.AddParamValueList(builder, ParamValue_List);
    FB_Impact.AddMutexpriority(builder, Mutexpriority);
    FB_Impact.AddMutexcollectionId(builder, MutexcollectionId);
    FB_Impact.AddEffectId(builder, EffectId);
    FB_Impact.AddLogicID(builder, LogicID);
    FB_Impact.AddThreat(builder, threat);
    FB_Impact.AddBuffType(builder, BuffType);
    FB_Impact.AddBuffIcon(builder, BuffIcon);
    FB_Impact.AddMaxOverlayCount(builder, MaxOverlayCount);
    FB_Impact.AddShowType(builder, ShowType);
    FB_Impact.AddSortId(builder, SortId);
    FB_Impact.AddDuration(builder, Duration);
    FB_Impact.AddDescribeID(builder, DescribeID);
    FB_Impact.AddName(builder, Name);
    FB_Impact.AddImpactID(builder, ImpactID);
    FB_Impact.AddCanSynchronization(builder, CanSynchronization);
    FB_Impact.AddKeepEffect(builder, KeepEffect);
    FB_Impact.AddIsLimitSkill(builder, IsLimitSkill);
    FB_Impact.AddIsNeedNoticeClient(builder, IsNeedNoticeClient);
    FB_Impact.AddElapseOffline(builder, ElapseOffline);
    FB_Impact.AddInDatabase(builder, InDatabase);
    return FB_Impact.EndFB_Impact(builder);
  }

  public static void StartFB_Impact(FlatBufferBuilder builder) { builder.StartObject(23); }
  public static void AddImpactID(FlatBufferBuilder builder, int ImpactID) { builder.AddInt(0, ImpactID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDescribeID(FlatBufferBuilder builder, int DescribeID) { builder.AddInt(2, DescribeID, 0); }
  public static void AddInDatabase(FlatBufferBuilder builder, bool InDatabase) { builder.AddBool(3, InDatabase, false); }
  public static void AddElapseOffline(FlatBufferBuilder builder, bool ElapseOffline) { builder.AddBool(4, ElapseOffline, false); }
  public static void AddDuration(FlatBufferBuilder builder, int Duration) { builder.AddInt(5, Duration, 0); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(6, SortId, 0); }
  public static void AddShowType(FlatBufferBuilder builder, int ShowType) { builder.AddInt(7, ShowType, 0); }
  public static void AddMaxOverlayCount(FlatBufferBuilder builder, int MaxOverlayCount) { builder.AddInt(8, MaxOverlayCount, 0); }
  public static void AddIsNeedNoticeClient(FlatBufferBuilder builder, bool IsNeedNoticeClient) { builder.AddBool(9, IsNeedNoticeClient, false); }
  public static void AddBuffIcon(FlatBufferBuilder builder, StringOffset BuffIconOffset) { builder.AddOffset(10, BuffIconOffset.Value, 0); }
  public static void AddBuffType(FlatBufferBuilder builder, int BuffType) { builder.AddInt(11, BuffType, 0); }
  public static void AddIsLimitSkill(FlatBufferBuilder builder, bool IsLimitSkill) { builder.AddBool(12, IsLimitSkill, false); }
  public static void AddThreat(FlatBufferBuilder builder, int threat) { builder.AddInt(13, threat, 0); }
  public static void AddLogicID(FlatBufferBuilder builder, int LogicID) { builder.AddInt(14, LogicID, 0); }
  public static void AddEffectId(FlatBufferBuilder builder, int EffectId) { builder.AddInt(15, EffectId, 0); }
  public static void AddKeepEffect(FlatBufferBuilder builder, bool KeepEffect) { builder.AddBool(16, KeepEffect, false); }
  public static void AddMutexcollectionId(FlatBufferBuilder builder, int MutexcollectionId) { builder.AddInt(17, MutexcollectionId, 0); }
  public static void AddMutexpriority(FlatBufferBuilder builder, int Mutexpriority) { builder.AddInt(18, Mutexpriority, 0); }
  public static void AddParamValueList(FlatBufferBuilder builder, VectorOffset ParamValueListOffset) { builder.AddOffset(19, ParamValueListOffset.Value, 0); }
  public static VectorOffset CreateParamValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCanSynchronization(FlatBufferBuilder builder, bool CanSynchronization) { builder.AddBool(20, CanSynchronization, false); }
  public static void AddRefreshID(FlatBufferBuilder builder, int RefreshID) { builder.AddInt(21, RefreshID, 0); }
  public static void AddRemoveType(FlatBufferBuilder builder, int RemoveType) { builder.AddInt(22, RemoveType, 0); }
  public static Offset<FB_Impact> EndFB_Impact(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Impact>(o);
  }
};

public sealed class FB_ImpactContainer : Table {
  public static FB_ImpactContainer GetRootAsFB_ImpactContainer(ByteBuffer _bb) { return GetRootAsFB_ImpactContainer(_bb, new FB_ImpactContainer()); }
  public static FB_ImpactContainer GetRootAsFB_ImpactContainer(ByteBuffer _bb, FB_ImpactContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ImpactContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ImpactContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Impact GetItems(int j) { return GetItems(new FB_Impact(), j); }
  public FB_Impact GetItems(FB_Impact obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ImpactContainer> CreateFB_ImpactContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ImpactContainer.AddItems(builder, items);
    return FB_ImpactContainer.EndFB_ImpactContainer(builder);
  }

  public static void StartFB_ImpactContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Impact>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ImpactContainer> EndFB_ImpactContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ImpactContainer>(o);
  }
  public static void FinishFB_ImpactContainerBuffer(FlatBufferBuilder builder, Offset<FB_ImpactContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
