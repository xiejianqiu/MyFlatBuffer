// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GetPathBase : Table {
  public static FB_GetPathBase GetRootAsFB_GetPathBase(ByteBuffer _bb) { return GetRootAsFB_GetPathBase(_bb, new FB_GetPathBase()); }
  public static FB_GetPathBase GetRootAsFB_GetPathBase(ByteBuffer _bb, FB_GetPathBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GetPathBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BtnDesc { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int FuncBaseID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GetPathBase> CreateFB_GetPathBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset BtnDesc = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int type = -1,
      VectorOffset ParamList = default(VectorOffset),
      int FuncBaseID = -1) {
    builder.StartObject(7);
    FB_GetPathBase.AddFuncBaseID(builder, FuncBaseID);
    FB_GetPathBase.AddParamList(builder, ParamList);
    FB_GetPathBase.AddType(builder, type);
    FB_GetPathBase.AddIcon(builder, Icon);
    FB_GetPathBase.AddBtnDesc(builder, BtnDesc);
    FB_GetPathBase.AddName(builder, Name);
    FB_GetPathBase.AddId(builder, Id);
    return FB_GetPathBase.EndFB_GetPathBase(builder);
  }

  public static void StartFB_GetPathBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddBtnDesc(FlatBufferBuilder builder, StringOffset BtnDescOffset) { builder.AddOffset(2, BtnDescOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int type) { builder.AddInt(4, type, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(5, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFuncBaseID(FlatBufferBuilder builder, int FuncBaseID) { builder.AddInt(6, FuncBaseID, -1); }
  public static Offset<FB_GetPathBase> EndFB_GetPathBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GetPathBase>(o);
  }
};

public sealed class FB_GetPathBaseContainer : Table {
  public static FB_GetPathBaseContainer GetRootAsFB_GetPathBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GetPathBaseContainer(_bb, new FB_GetPathBaseContainer()); }
  public static FB_GetPathBaseContainer GetRootAsFB_GetPathBaseContainer(ByteBuffer _bb, FB_GetPathBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GetPathBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GetPathBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GetPathBase GetItems(int j) { return GetItems(new FB_GetPathBase(), j); }
  public FB_GetPathBase GetItems(FB_GetPathBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GetPathBaseContainer> CreateFB_GetPathBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GetPathBaseContainer.AddItems(builder, items);
    return FB_GetPathBaseContainer.EndFB_GetPathBaseContainer(builder);
  }

  public static void StartFB_GetPathBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GetPathBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GetPathBaseContainer> EndFB_GetPathBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GetPathBaseContainer>(o);
  }
  public static void FinishFB_GetPathBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GetPathBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
