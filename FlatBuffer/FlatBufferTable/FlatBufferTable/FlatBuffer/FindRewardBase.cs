// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FindRewardBase : Table {
  public static FB_FindRewardBase GetRootAsFB_FindRewardBase(ByteBuffer _bb) { return GetRootAsFB_FindRewardBase(_bb, new FB_FindRewardBase()); }
  public static FB_FindRewardBase GetRootAsFB_FindRewardBase(ByteBuffer _bb, FB_FindRewardBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FindRewardBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetActicityBaseIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ActicityBaseIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsGuild { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int Time { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int VIPId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LowCost { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float LowRatio { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int HighCost { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float HighRatio { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int MDId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VipMDId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FindType { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int Ratio { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsVIP { get { int o = __offset(34); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int HighGoldItemId { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighGoldItemCount { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowGoldItemId { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowGoldItemCount { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddYuanShenExpIndex { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_FindRewardBase> CreateFB_FindRewardBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset ActicityBaseIDList = default(VectorOffset),
      bool IsGuild = false,
      int Time = 0,
      int VIPId = 0,
      int LowCost = -1,
      float LowRatio = 0,
      int HighCost = -1,
      float HighRatio = 0,
      int MDId = -1,
      int VipMDId = -1,
      int FindType = -1,
      VectorOffset ParamList = default(VectorOffset),
      int Ratio = -1,
      bool IsVIP = false,
      int HighGoldItemId = -1,
      int HighGoldItemCount = -1,
      int LowGoldItemId = -1,
      int LowGoldItemCount = -1,
      int AddYuanShenExpIndex = -1) {
    builder.StartObject(21);
    FB_FindRewardBase.AddAddYuanShenExpIndex(builder, AddYuanShenExpIndex);
    FB_FindRewardBase.AddLowGoldItemCount(builder, LowGoldItemCount);
    FB_FindRewardBase.AddLowGoldItemId(builder, LowGoldItemId);
    FB_FindRewardBase.AddHighGoldItemCount(builder, HighGoldItemCount);
    FB_FindRewardBase.AddHighGoldItemId(builder, HighGoldItemId);
    FB_FindRewardBase.AddRatio(builder, Ratio);
    FB_FindRewardBase.AddParamList(builder, ParamList);
    FB_FindRewardBase.AddFindType(builder, FindType);
    FB_FindRewardBase.AddVipMDId(builder, VipMDId);
    FB_FindRewardBase.AddMDId(builder, MDId);
    FB_FindRewardBase.AddHighRatio(builder, HighRatio);
    FB_FindRewardBase.AddHighCost(builder, HighCost);
    FB_FindRewardBase.AddLowRatio(builder, LowRatio);
    FB_FindRewardBase.AddLowCost(builder, LowCost);
    FB_FindRewardBase.AddVIPId(builder, VIPId);
    FB_FindRewardBase.AddTime(builder, Time);
    FB_FindRewardBase.AddActicityBaseIDList(builder, ActicityBaseIDList);
    FB_FindRewardBase.AddName(builder, Name);
    FB_FindRewardBase.AddID(builder, ID);
    FB_FindRewardBase.AddIsVIP(builder, IsVIP);
    FB_FindRewardBase.AddIsGuild(builder, IsGuild);
    return FB_FindRewardBase.EndFB_FindRewardBase(builder);
  }

  public static void StartFB_FindRewardBase(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddActicityBaseIDList(FlatBufferBuilder builder, VectorOffset ActicityBaseIDListOffset) { builder.AddOffset(2, ActicityBaseIDListOffset.Value, 0); }
  public static VectorOffset CreateActicityBaseIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartActicityBaseIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsGuild(FlatBufferBuilder builder, bool IsGuild) { builder.AddBool(3, IsGuild, false); }
  public static void AddTime(FlatBufferBuilder builder, int Time) { builder.AddInt(4, Time, 0); }
  public static void AddVIPId(FlatBufferBuilder builder, int VIPId) { builder.AddInt(5, VIPId, 0); }
  public static void AddLowCost(FlatBufferBuilder builder, int LowCost) { builder.AddInt(6, LowCost, -1); }
  public static void AddLowRatio(FlatBufferBuilder builder, float LowRatio) { builder.AddFloat(7, LowRatio, 0); }
  public static void AddHighCost(FlatBufferBuilder builder, int HighCost) { builder.AddInt(8, HighCost, -1); }
  public static void AddHighRatio(FlatBufferBuilder builder, float HighRatio) { builder.AddFloat(9, HighRatio, 0); }
  public static void AddMDId(FlatBufferBuilder builder, int MDId) { builder.AddInt(10, MDId, -1); }
  public static void AddVipMDId(FlatBufferBuilder builder, int VipMDId) { builder.AddInt(11, VipMDId, -1); }
  public static void AddFindType(FlatBufferBuilder builder, int FindType) { builder.AddInt(12, FindType, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(13, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRatio(FlatBufferBuilder builder, int Ratio) { builder.AddInt(14, Ratio, -1); }
  public static void AddIsVIP(FlatBufferBuilder builder, bool IsVIP) { builder.AddBool(15, IsVIP, false); }
  public static void AddHighGoldItemId(FlatBufferBuilder builder, int HighGoldItemId) { builder.AddInt(16, HighGoldItemId, -1); }
  public static void AddHighGoldItemCount(FlatBufferBuilder builder, int HighGoldItemCount) { builder.AddInt(17, HighGoldItemCount, -1); }
  public static void AddLowGoldItemId(FlatBufferBuilder builder, int LowGoldItemId) { builder.AddInt(18, LowGoldItemId, -1); }
  public static void AddLowGoldItemCount(FlatBufferBuilder builder, int LowGoldItemCount) { builder.AddInt(19, LowGoldItemCount, -1); }
  public static void AddAddYuanShenExpIndex(FlatBufferBuilder builder, int AddYuanShenExpIndex) { builder.AddInt(20, AddYuanShenExpIndex, -1); }
  public static Offset<FB_FindRewardBase> EndFB_FindRewardBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FindRewardBase>(o);
  }
};

public sealed class FB_FindRewardBaseContainer : Table {
  public static FB_FindRewardBaseContainer GetRootAsFB_FindRewardBaseContainer(ByteBuffer _bb) { return GetRootAsFB_FindRewardBaseContainer(_bb, new FB_FindRewardBaseContainer()); }
  public static FB_FindRewardBaseContainer GetRootAsFB_FindRewardBaseContainer(ByteBuffer _bb, FB_FindRewardBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FindRewardBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FindRewardBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FindRewardBase GetItems(int j) { return GetItems(new FB_FindRewardBase(), j); }
  public FB_FindRewardBase GetItems(FB_FindRewardBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FindRewardBaseContainer> CreateFB_FindRewardBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FindRewardBaseContainer.AddItems(builder, items);
    return FB_FindRewardBaseContainer.EndFB_FindRewardBaseContainer(builder);
  }

  public static void StartFB_FindRewardBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FindRewardBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FindRewardBaseContainer> EndFB_FindRewardBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FindRewardBaseContainer>(o);
  }
  public static void FinishFB_FindRewardBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_FindRewardBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
