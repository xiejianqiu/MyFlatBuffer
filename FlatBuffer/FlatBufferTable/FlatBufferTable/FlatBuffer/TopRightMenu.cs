// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TopRightMenu : Table {
  public static FB_TopRightMenu GetRootAsFB_TopRightMenu(ByteBuffer _bb) { return GetRootAsFB_TopRightMenu(_bb, new FB_TopRightMenu()); }
  public static FB_TopRightMenu GetRootAsFB_TopRightMenu(ByteBuffer _bb, FB_TopRightMenu obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TopRightMenu __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string NameLabel { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsStillShow { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int RowNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FunctionBaseID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int UIInfo { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TopRightMenu> CreateFB_TopRightMenu(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset NameLabel = default(StringOffset),
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      bool IsStillShow = false,
      int RowNum = -1,
      int FunctionBaseID = -1,
      int SortId = -1,
      int Type = -1,
      VectorOffset ParamList = default(VectorOffset),
      int UIInfo = -1) {
    builder.StartObject(11);
    FB_TopRightMenu.AddUIInfo(builder, UIInfo);
    FB_TopRightMenu.AddParamList(builder, ParamList);
    FB_TopRightMenu.AddType(builder, Type);
    FB_TopRightMenu.AddSortId(builder, SortId);
    FB_TopRightMenu.AddFunctionBaseID(builder, FunctionBaseID);
    FB_TopRightMenu.AddRowNum(builder, RowNum);
    FB_TopRightMenu.AddIcon(builder, Icon);
    FB_TopRightMenu.AddName(builder, Name);
    FB_TopRightMenu.AddNameLabel(builder, NameLabel);
    FB_TopRightMenu.AddID(builder, ID);
    FB_TopRightMenu.AddIsStillShow(builder, IsStillShow);
    return FB_TopRightMenu.EndFB_TopRightMenu(builder);
  }

  public static void StartFB_TopRightMenu(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddNameLabel(FlatBufferBuilder builder, StringOffset NameLabelOffset) { builder.AddOffset(1, NameLabelOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddIsStillShow(FlatBufferBuilder builder, bool IsStillShow) { builder.AddBool(4, IsStillShow, false); }
  public static void AddRowNum(FlatBufferBuilder builder, int RowNum) { builder.AddInt(5, RowNum, -1); }
  public static void AddFunctionBaseID(FlatBufferBuilder builder, int FunctionBaseID) { builder.AddInt(6, FunctionBaseID, -1); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(7, SortId, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(8, Type, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(9, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUIInfo(FlatBufferBuilder builder, int UIInfo) { builder.AddInt(10, UIInfo, -1); }
  public static Offset<FB_TopRightMenu> EndFB_TopRightMenu(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TopRightMenu>(o);
  }
};

public sealed class FB_TopRightMenuContainer : Table {
  public static FB_TopRightMenuContainer GetRootAsFB_TopRightMenuContainer(ByteBuffer _bb) { return GetRootAsFB_TopRightMenuContainer(_bb, new FB_TopRightMenuContainer()); }
  public static FB_TopRightMenuContainer GetRootAsFB_TopRightMenuContainer(ByteBuffer _bb, FB_TopRightMenuContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TopRightMenuContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TopRightMenuContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TopRightMenu GetItems(int j) { return GetItems(new FB_TopRightMenu(), j); }
  public FB_TopRightMenu GetItems(FB_TopRightMenu obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TopRightMenuContainer> CreateFB_TopRightMenuContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TopRightMenuContainer.AddItems(builder, items);
    return FB_TopRightMenuContainer.EndFB_TopRightMenuContainer(builder);
  }

  public static void StartFB_TopRightMenuContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TopRightMenu>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TopRightMenuContainer> EndFB_TopRightMenuContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TopRightMenuContainer>(o);
  }
  public static void FinishFB_TopRightMenuContainerBuffer(FlatBufferBuilder builder, Offset<FB_TopRightMenuContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
