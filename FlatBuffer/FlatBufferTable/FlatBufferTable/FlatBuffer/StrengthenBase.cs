// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StrengthenBase : Table {
  public static FB_StrengthenBase GetRootAsFB_StrengthenBase(ByteBuffer _bb) { return GetRootAsFB_StrengthenBase(_bb, new FB_StrengthenBase()); }
  public static FB_StrengthenBase GetRootAsFB_StrengthenBase(ByteBuffer _bb, FB_StrengthenBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StrengthenBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrDictID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UseLogic { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoalNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int SortLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FunctionID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActiveID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrengthenBase> CreateFB_StrengthenBase(FlatBufferBuilder builder,
      int ID = 0,
      int StrDictID = -1,
      StringOffset Icon = default(StringOffset),
      int UseLogic = -1,
      int GoalNum = -1,
      VectorOffset ParamList = default(VectorOffset),
      int SortLevel = -1,
      int FunctionID = -1,
      int UIID = -1,
      int ActiveID = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(12);
    FB_StrengthenBase.AddAttrValueList(builder, AttrValueList);
    FB_StrengthenBase.AddAttrIdList(builder, AttrIdList);
    FB_StrengthenBase.AddActiveID(builder, ActiveID);
    FB_StrengthenBase.AddUIID(builder, UIID);
    FB_StrengthenBase.AddFunctionID(builder, FunctionID);
    FB_StrengthenBase.AddSortLevel(builder, SortLevel);
    FB_StrengthenBase.AddParamList(builder, ParamList);
    FB_StrengthenBase.AddGoalNum(builder, GoalNum);
    FB_StrengthenBase.AddUseLogic(builder, UseLogic);
    FB_StrengthenBase.AddIcon(builder, Icon);
    FB_StrengthenBase.AddStrDictID(builder, StrDictID);
    FB_StrengthenBase.AddID(builder, ID);
    return FB_StrengthenBase.EndFB_StrengthenBase(builder);
  }

  public static void StartFB_StrengthenBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStrDictID(FlatBufferBuilder builder, int StrDictID) { builder.AddInt(1, StrDictID, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddUseLogic(FlatBufferBuilder builder, int UseLogic) { builder.AddInt(3, UseLogic, -1); }
  public static void AddGoalNum(FlatBufferBuilder builder, int GoalNum) { builder.AddInt(4, GoalNum, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(5, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSortLevel(FlatBufferBuilder builder, int SortLevel) { builder.AddInt(6, SortLevel, -1); }
  public static void AddFunctionID(FlatBufferBuilder builder, int FunctionID) { builder.AddInt(7, FunctionID, -1); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(8, UIID, -1); }
  public static void AddActiveID(FlatBufferBuilder builder, int ActiveID) { builder.AddInt(9, ActiveID, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(10, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(11, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrengthenBase> EndFB_StrengthenBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenBase>(o);
  }
};

public sealed class FB_StrengthenBaseContainer : Table {
  public static FB_StrengthenBaseContainer GetRootAsFB_StrengthenBaseContainer(ByteBuffer _bb) { return GetRootAsFB_StrengthenBaseContainer(_bb, new FB_StrengthenBaseContainer()); }
  public static FB_StrengthenBaseContainer GetRootAsFB_StrengthenBaseContainer(ByteBuffer _bb, FB_StrengthenBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StrengthenBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StrengthenBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StrengthenBase GetItems(int j) { return GetItems(new FB_StrengthenBase(), j); }
  public FB_StrengthenBase GetItems(FB_StrengthenBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrengthenBaseContainer> CreateFB_StrengthenBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StrengthenBaseContainer.AddItems(builder, items);
    return FB_StrengthenBaseContainer.EndFB_StrengthenBaseContainer(builder);
  }

  public static void StartFB_StrengthenBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StrengthenBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrengthenBaseContainer> EndFB_StrengthenBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenBaseContainer>(o);
  }
  public static void FinishFB_StrengthenBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_StrengthenBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
