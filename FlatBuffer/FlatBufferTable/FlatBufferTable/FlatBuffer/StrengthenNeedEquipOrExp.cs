// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StrengthenNeedEquipOrExp : Table {
  public static FB_StrengthenNeedEquipOrExp GetRootAsFB_StrengthenNeedEquipOrExp(ByteBuffer _bb) { return GetRootAsFB_StrengthenNeedEquipOrExp(_bb, new FB_StrengthenNeedEquipOrExp()); }
  public static FB_StrengthenNeedEquipOrExp GetRootAsFB_StrengthenNeedEquipOrExp(ByteBuffer _bb, FB_StrengthenNeedEquipOrExp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StrengthenNeedEquipOrExp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Icon { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EventID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuncBaseID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StrengthenNeedEquipOrExp> CreateFB_StrengthenNeedEquipOrExp(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Icon = -1,
      int Type = -1,
      int StrID = -1,
      int UIID = -1,
      int ActivityID = -1,
      int Param = -1,
      int EventID = -1,
      int FuncBaseID = -1,
      int SortId = -1) {
    builder.StartObject(11);
    FB_StrengthenNeedEquipOrExp.AddSortId(builder, SortId);
    FB_StrengthenNeedEquipOrExp.AddFuncBaseID(builder, FuncBaseID);
    FB_StrengthenNeedEquipOrExp.AddEventID(builder, EventID);
    FB_StrengthenNeedEquipOrExp.AddParam(builder, Param);
    FB_StrengthenNeedEquipOrExp.AddActivityID(builder, ActivityID);
    FB_StrengthenNeedEquipOrExp.AddUIID(builder, UIID);
    FB_StrengthenNeedEquipOrExp.AddStrID(builder, StrID);
    FB_StrengthenNeedEquipOrExp.AddType(builder, Type);
    FB_StrengthenNeedEquipOrExp.AddIcon(builder, Icon);
    FB_StrengthenNeedEquipOrExp.AddName(builder, Name);
    FB_StrengthenNeedEquipOrExp.AddID(builder, ID);
    return FB_StrengthenNeedEquipOrExp.EndFB_StrengthenNeedEquipOrExp(builder);
  }

  public static void StartFB_StrengthenNeedEquipOrExp(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, int Icon) { builder.AddInt(2, Icon, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static void AddStrID(FlatBufferBuilder builder, int StrID) { builder.AddInt(4, StrID, -1); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(5, UIID, -1); }
  public static void AddActivityID(FlatBufferBuilder builder, int ActivityID) { builder.AddInt(6, ActivityID, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(7, Param, -1); }
  public static void AddEventID(FlatBufferBuilder builder, int EventID) { builder.AddInt(8, EventID, -1); }
  public static void AddFuncBaseID(FlatBufferBuilder builder, int FuncBaseID) { builder.AddInt(9, FuncBaseID, -1); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(10, SortId, -1); }
  public static Offset<FB_StrengthenNeedEquipOrExp> EndFB_StrengthenNeedEquipOrExp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenNeedEquipOrExp>(o);
  }
};

public sealed class FB_StrengthenNeedEquipOrExpContainer : Table {
  public static FB_StrengthenNeedEquipOrExpContainer GetRootAsFB_StrengthenNeedEquipOrExpContainer(ByteBuffer _bb) { return GetRootAsFB_StrengthenNeedEquipOrExpContainer(_bb, new FB_StrengthenNeedEquipOrExpContainer()); }
  public static FB_StrengthenNeedEquipOrExpContainer GetRootAsFB_StrengthenNeedEquipOrExpContainer(ByteBuffer _bb, FB_StrengthenNeedEquipOrExpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StrengthenNeedEquipOrExpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StrengthenNeedEquipOrExpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StrengthenNeedEquipOrExp GetItems(int j) { return GetItems(new FB_StrengthenNeedEquipOrExp(), j); }
  public FB_StrengthenNeedEquipOrExp GetItems(FB_StrengthenNeedEquipOrExp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrengthenNeedEquipOrExpContainer> CreateFB_StrengthenNeedEquipOrExpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StrengthenNeedEquipOrExpContainer.AddItems(builder, items);
    return FB_StrengthenNeedEquipOrExpContainer.EndFB_StrengthenNeedEquipOrExpContainer(builder);
  }

  public static void StartFB_StrengthenNeedEquipOrExpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StrengthenNeedEquipOrExp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrengthenNeedEquipOrExpContainer> EndFB_StrengthenNeedEquipOrExpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenNeedEquipOrExpContainer>(o);
  }
  public static void FinishFB_StrengthenNeedEquipOrExpContainerBuffer(FlatBufferBuilder builder, Offset<FB_StrengthenNeedEquipOrExpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
