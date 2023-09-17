// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildFormationBase : Table {
  public static FB_GuildFormationBase GetRootAsFB_GuildFormationBase(ByteBuffer _bb) { return GetRootAsFB_GuildFormationBase(_bb, new FB_GuildFormationBase()); }
  public static FB_GuildFormationBase GetRootAsFB_GuildFormationBase(ByteBuffer _bb, FB_GuildFormationBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildFormationBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AttrType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PersonAttr { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TeamAttr { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildAttr { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TeamBuffID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuildBuffID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCostTypeList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostTypeListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostMoneyList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostMoneyListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int DictID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CurrID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NextDictID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildFormationBase> CreateFB_GuildFormationBase(FlatBufferBuilder builder,
      int Id = 0,
      int AttrType = -1,
      int PersonAttr = -1,
      int TeamAttr = -1,
      int GuildAttr = -1,
      int TeamBuffID = -1,
      int GuildBuffID = -1,
      VectorOffset CostTypeList = default(VectorOffset),
      VectorOffset CostMoneyList = default(VectorOffset),
      int DictID = -1,
      int CurrID = -1,
      int NextDictID = -1) {
    builder.StartObject(12);
    FB_GuildFormationBase.AddNextDictID(builder, NextDictID);
    FB_GuildFormationBase.AddCurrID(builder, CurrID);
    FB_GuildFormationBase.AddDictID(builder, DictID);
    FB_GuildFormationBase.AddCostMoneyList(builder, CostMoneyList);
    FB_GuildFormationBase.AddCostTypeList(builder, CostTypeList);
    FB_GuildFormationBase.AddGuildBuffID(builder, GuildBuffID);
    FB_GuildFormationBase.AddTeamBuffID(builder, TeamBuffID);
    FB_GuildFormationBase.AddGuildAttr(builder, GuildAttr);
    FB_GuildFormationBase.AddTeamAttr(builder, TeamAttr);
    FB_GuildFormationBase.AddPersonAttr(builder, PersonAttr);
    FB_GuildFormationBase.AddAttrType(builder, AttrType);
    FB_GuildFormationBase.AddId(builder, Id);
    return FB_GuildFormationBase.EndFB_GuildFormationBase(builder);
  }

  public static void StartFB_GuildFormationBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAttrType(FlatBufferBuilder builder, int AttrType) { builder.AddInt(1, AttrType, -1); }
  public static void AddPersonAttr(FlatBufferBuilder builder, int PersonAttr) { builder.AddInt(2, PersonAttr, -1); }
  public static void AddTeamAttr(FlatBufferBuilder builder, int TeamAttr) { builder.AddInt(3, TeamAttr, -1); }
  public static void AddGuildAttr(FlatBufferBuilder builder, int GuildAttr) { builder.AddInt(4, GuildAttr, -1); }
  public static void AddTeamBuffID(FlatBufferBuilder builder, int TeamBuffID) { builder.AddInt(5, TeamBuffID, -1); }
  public static void AddGuildBuffID(FlatBufferBuilder builder, int GuildBuffID) { builder.AddInt(6, GuildBuffID, -1); }
  public static void AddCostTypeList(FlatBufferBuilder builder, VectorOffset CostTypeListOffset) { builder.AddOffset(7, CostTypeListOffset.Value, 0); }
  public static VectorOffset CreateCostTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostMoneyList(FlatBufferBuilder builder, VectorOffset CostMoneyListOffset) { builder.AddOffset(8, CostMoneyListOffset.Value, 0); }
  public static VectorOffset CreateCostMoneyListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostMoneyListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDictID(FlatBufferBuilder builder, int DictID) { builder.AddInt(9, DictID, -1); }
  public static void AddCurrID(FlatBufferBuilder builder, int CurrID) { builder.AddInt(10, CurrID, -1); }
  public static void AddNextDictID(FlatBufferBuilder builder, int NextDictID) { builder.AddInt(11, NextDictID, -1); }
  public static Offset<FB_GuildFormationBase> EndFB_GuildFormationBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationBase>(o);
  }
};

public sealed class FB_GuildFormationBaseContainer : Table {
  public static FB_GuildFormationBaseContainer GetRootAsFB_GuildFormationBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GuildFormationBaseContainer(_bb, new FB_GuildFormationBaseContainer()); }
  public static FB_GuildFormationBaseContainer GetRootAsFB_GuildFormationBaseContainer(ByteBuffer _bb, FB_GuildFormationBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildFormationBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildFormationBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildFormationBase GetItems(int j) { return GetItems(new FB_GuildFormationBase(), j); }
  public FB_GuildFormationBase GetItems(FB_GuildFormationBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildFormationBaseContainer> CreateFB_GuildFormationBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildFormationBaseContainer.AddItems(builder, items);
    return FB_GuildFormationBaseContainer.EndFB_GuildFormationBaseContainer(builder);
  }

  public static void StartFB_GuildFormationBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildFormationBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildFormationBaseContainer> EndFB_GuildFormationBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFormationBaseContainer>(o);
  }
  public static void FinishFB_GuildFormationBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildFormationBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
