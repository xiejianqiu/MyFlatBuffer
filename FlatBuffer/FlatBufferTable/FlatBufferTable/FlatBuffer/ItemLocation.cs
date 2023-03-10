// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ItemLocation : Table {
  public static FB_ItemLocation GetRootAsFB_ItemLocation(ByteBuffer _bb) { return GetRootAsFB_ItemLocation(_bb, new FB_ItemLocation()); }
  public static FB_ItemLocation GetRootAsFB_ItemLocation(ByteBuffer _bb, FB_ItemLocation obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ItemLocation __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UseTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ShowText { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PosX { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PosZ { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RoleID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Area { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ProgressBase { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ItemLocation> CreateFB_ItemLocation(FlatBufferBuilder builder,
      int Id = 0,
      int UseTime = -1,
      StringOffset ShowText = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int SceneID = -1,
      int PosX = -1,
      int PosZ = -1,
      int RoleID = -1,
      int Area = -1,
      int ProgressBase = -1) {
    builder.StartObject(10);
    FB_ItemLocation.AddProgressBase(builder, ProgressBase);
    FB_ItemLocation.AddArea(builder, Area);
    FB_ItemLocation.AddRoleID(builder, RoleID);
    FB_ItemLocation.AddPosZ(builder, PosZ);
    FB_ItemLocation.AddPosX(builder, PosX);
    FB_ItemLocation.AddSceneID(builder, SceneID);
    FB_ItemLocation.AddIcon(builder, Icon);
    FB_ItemLocation.AddShowText(builder, ShowText);
    FB_ItemLocation.AddUseTime(builder, UseTime);
    FB_ItemLocation.AddId(builder, Id);
    return FB_ItemLocation.EndFB_ItemLocation(builder);
  }

  public static void StartFB_ItemLocation(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddUseTime(FlatBufferBuilder builder, int UseTime) { builder.AddInt(1, UseTime, -1); }
  public static void AddShowText(FlatBufferBuilder builder, StringOffset ShowTextOffset) { builder.AddOffset(2, ShowTextOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(4, SceneID, -1); }
  public static void AddPosX(FlatBufferBuilder builder, int PosX) { builder.AddInt(5, PosX, -1); }
  public static void AddPosZ(FlatBufferBuilder builder, int PosZ) { builder.AddInt(6, PosZ, -1); }
  public static void AddRoleID(FlatBufferBuilder builder, int RoleID) { builder.AddInt(7, RoleID, -1); }
  public static void AddArea(FlatBufferBuilder builder, int Area) { builder.AddInt(8, Area, -1); }
  public static void AddProgressBase(FlatBufferBuilder builder, int ProgressBase) { builder.AddInt(9, ProgressBase, -1); }
  public static Offset<FB_ItemLocation> EndFB_ItemLocation(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemLocation>(o);
  }
};

public sealed class FB_ItemLocationContainer : Table {
  public static FB_ItemLocationContainer GetRootAsFB_ItemLocationContainer(ByteBuffer _bb) { return GetRootAsFB_ItemLocationContainer(_bb, new FB_ItemLocationContainer()); }
  public static FB_ItemLocationContainer GetRootAsFB_ItemLocationContainer(ByteBuffer _bb, FB_ItemLocationContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ItemLocationContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ItemLocationContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ItemLocation GetItems(int j) { return GetItems(new FB_ItemLocation(), j); }
  public FB_ItemLocation GetItems(FB_ItemLocation obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemLocationContainer> CreateFB_ItemLocationContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ItemLocationContainer.AddItems(builder, items);
    return FB_ItemLocationContainer.EndFB_ItemLocationContainer(builder);
  }

  public static void StartFB_ItemLocationContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ItemLocation>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemLocationContainer> EndFB_ItemLocationContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemLocationContainer>(o);
  }
  public static void FinishFB_ItemLocationContainerBuffer(FlatBufferBuilder builder, Offset<FB_ItemLocationContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
