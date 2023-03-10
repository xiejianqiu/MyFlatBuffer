// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ItemButtonLogic : Table {
  public static FB_ItemButtonLogic GetRootAsFB_ItemButtonLogic(ByteBuffer _bb) { return GetRootAsFB_ItemButtonLogic(_bb, new FB_ItemButtonLogic()); }
  public static FB_ItemButtonLogic GetRootAsFB_ItemButtonLogic(ByteBuffer _bb, FB_ItemButtonLogic obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ItemButtonLogic __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetUseParamList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UseParamListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int FuntionOpenID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ItemButtonLogic> CreateFB_ItemButtonLogic(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset UseParamList = default(VectorOffset),
      int FuntionOpenID = -1) {
    builder.StartObject(3);
    FB_ItemButtonLogic.AddFuntionOpenID(builder, FuntionOpenID);
    FB_ItemButtonLogic.AddUseParamList(builder, UseParamList);
    FB_ItemButtonLogic.AddId(builder, Id);
    return FB_ItemButtonLogic.EndFB_ItemButtonLogic(builder);
  }

  public static void StartFB_ItemButtonLogic(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddUseParamList(FlatBufferBuilder builder, VectorOffset UseParamListOffset) { builder.AddOffset(1, UseParamListOffset.Value, 0); }
  public static VectorOffset CreateUseParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUseParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFuntionOpenID(FlatBufferBuilder builder, int FuntionOpenID) { builder.AddInt(2, FuntionOpenID, -1); }
  public static Offset<FB_ItemButtonLogic> EndFB_ItemButtonLogic(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemButtonLogic>(o);
  }
};

public sealed class FB_ItemButtonLogicContainer : Table {
  public static FB_ItemButtonLogicContainer GetRootAsFB_ItemButtonLogicContainer(ByteBuffer _bb) { return GetRootAsFB_ItemButtonLogicContainer(_bb, new FB_ItemButtonLogicContainer()); }
  public static FB_ItemButtonLogicContainer GetRootAsFB_ItemButtonLogicContainer(ByteBuffer _bb, FB_ItemButtonLogicContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ItemButtonLogicContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ItemButtonLogicContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ItemButtonLogic GetItems(int j) { return GetItems(new FB_ItemButtonLogic(), j); }
  public FB_ItemButtonLogic GetItems(FB_ItemButtonLogic obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemButtonLogicContainer> CreateFB_ItemButtonLogicContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ItemButtonLogicContainer.AddItems(builder, items);
    return FB_ItemButtonLogicContainer.EndFB_ItemButtonLogicContainer(builder);
  }

  public static void StartFB_ItemButtonLogicContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ItemButtonLogic>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemButtonLogicContainer> EndFB_ItemButtonLogicContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemButtonLogicContainer>(o);
  }
  public static void FinishFB_ItemButtonLogicContainerBuffer(FlatBufferBuilder builder, Offset<FB_ItemButtonLogicContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
