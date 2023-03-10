// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuideType : Table {
  public static FB_GuideType GetRootAsFB_GuideType(ByteBuffer _bb) { return GetRootAsFB_GuideType(_bb, new FB_GuideType()); }
  public static FB_GuideType GetRootAsFB_GuideType(ByteBuffer _bb, FB_GuideType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuideType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GuideID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GuideType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Param { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenDepUI { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuncId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuideType> CreateFB_GuideType(FlatBufferBuilder builder,
      int Id = 0,
      int GuideID = -1,
      int GuideType = -1,
      int Param = -1,
      int OpenDepUI = -1,
      int FuncId = -1) {
    builder.StartObject(6);
    FB_GuideType.AddFuncId(builder, FuncId);
    FB_GuideType.AddOpenDepUI(builder, OpenDepUI);
    FB_GuideType.AddParam(builder, Param);
    FB_GuideType.AddGuideType(builder, GuideType);
    FB_GuideType.AddGuideID(builder, GuideID);
    FB_GuideType.AddId(builder, Id);
    return FB_GuideType.EndFB_GuideType(builder);
  }

  public static void StartFB_GuideType(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGuideID(FlatBufferBuilder builder, int GuideID) { builder.AddInt(1, GuideID, -1); }
  public static void AddGuideType(FlatBufferBuilder builder, int GuideType) { builder.AddInt(2, GuideType, -1); }
  public static void AddParam(FlatBufferBuilder builder, int Param) { builder.AddInt(3, Param, -1); }
  public static void AddOpenDepUI(FlatBufferBuilder builder, int OpenDepUI) { builder.AddInt(4, OpenDepUI, -1); }
  public static void AddFuncId(FlatBufferBuilder builder, int FuncId) { builder.AddInt(5, FuncId, -1); }
  public static Offset<FB_GuideType> EndFB_GuideType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideType>(o);
  }
};

public sealed class FB_GuideTypeContainer : Table {
  public static FB_GuideTypeContainer GetRootAsFB_GuideTypeContainer(ByteBuffer _bb) { return GetRootAsFB_GuideTypeContainer(_bb, new FB_GuideTypeContainer()); }
  public static FB_GuideTypeContainer GetRootAsFB_GuideTypeContainer(ByteBuffer _bb, FB_GuideTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuideTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuideTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuideType GetItems(int j) { return GetItems(new FB_GuideType(), j); }
  public FB_GuideType GetItems(FB_GuideType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuideTypeContainer> CreateFB_GuideTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuideTypeContainer.AddItems(builder, items);
    return FB_GuideTypeContainer.EndFB_GuideTypeContainer(builder);
  }

  public static void StartFB_GuideTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuideType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuideTypeContainer> EndFB_GuideTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideTypeContainer>(o);
  }
  public static void FinishFB_GuideTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuideTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
