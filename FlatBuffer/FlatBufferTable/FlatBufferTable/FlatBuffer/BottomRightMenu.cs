// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BottomRightMenu : Table {
  public static FB_BottomRightMenu GetRootAsFB_BottomRightMenu(ByteBuffer _bb) { return GetRootAsFB_BottomRightMenu(_bb, new FB_BottomRightMenu()); }
  public static FB_BottomRightMenu GetRootAsFB_BottomRightMenu(ByteBuffer _bb, FB_BottomRightMenu obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BottomRightMenu __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string NameLabel { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FunctionBaseID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIInfo { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BottomRightMenu> CreateFB_BottomRightMenu(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset NameLabel = default(StringOffset),
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int FunctionBaseID = -1,
      int SortId = -1,
      int UIInfo = -1) {
    builder.StartObject(7);
    FB_BottomRightMenu.AddUIInfo(builder, UIInfo);
    FB_BottomRightMenu.AddSortId(builder, SortId);
    FB_BottomRightMenu.AddFunctionBaseID(builder, FunctionBaseID);
    FB_BottomRightMenu.AddIcon(builder, Icon);
    FB_BottomRightMenu.AddName(builder, Name);
    FB_BottomRightMenu.AddNameLabel(builder, NameLabel);
    FB_BottomRightMenu.AddID(builder, ID);
    return FB_BottomRightMenu.EndFB_BottomRightMenu(builder);
  }

  public static void StartFB_BottomRightMenu(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddNameLabel(FlatBufferBuilder builder, StringOffset NameLabelOffset) { builder.AddOffset(1, NameLabelOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddFunctionBaseID(FlatBufferBuilder builder, int FunctionBaseID) { builder.AddInt(4, FunctionBaseID, -1); }
  public static void AddSortId(FlatBufferBuilder builder, int SortId) { builder.AddInt(5, SortId, -1); }
  public static void AddUIInfo(FlatBufferBuilder builder, int UIInfo) { builder.AddInt(6, UIInfo, -1); }
  public static Offset<FB_BottomRightMenu> EndFB_BottomRightMenu(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BottomRightMenu>(o);
  }
};

public sealed class FB_BottomRightMenuContainer : Table {
  public static FB_BottomRightMenuContainer GetRootAsFB_BottomRightMenuContainer(ByteBuffer _bb) { return GetRootAsFB_BottomRightMenuContainer(_bb, new FB_BottomRightMenuContainer()); }
  public static FB_BottomRightMenuContainer GetRootAsFB_BottomRightMenuContainer(ByteBuffer _bb, FB_BottomRightMenuContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BottomRightMenuContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BottomRightMenuContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BottomRightMenu GetItems(int j) { return GetItems(new FB_BottomRightMenu(), j); }
  public FB_BottomRightMenu GetItems(FB_BottomRightMenu obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BottomRightMenuContainer> CreateFB_BottomRightMenuContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BottomRightMenuContainer.AddItems(builder, items);
    return FB_BottomRightMenuContainer.EndFB_BottomRightMenuContainer(builder);
  }

  public static void StartFB_BottomRightMenuContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BottomRightMenu>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BottomRightMenuContainer> EndFB_BottomRightMenuContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BottomRightMenuContainer>(o);
  }
  public static void FinishFB_BottomRightMenuContainerBuffer(FlatBufferBuilder builder, Offset<FB_BottomRightMenuContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
