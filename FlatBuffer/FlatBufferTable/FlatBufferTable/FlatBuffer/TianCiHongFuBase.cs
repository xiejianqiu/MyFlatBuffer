// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TianCiHongFuBase : Table {
  public static FB_TianCiHongFuBase GetRootAsFB_TianCiHongFuBase(ByteBuffer _bb) { return GetRootAsFB_TianCiHongFuBase(_bb, new FB_TianCiHongFuBase()); }
  public static FB_TianCiHongFuBase GetRootAsFB_TianCiHongFuBase(ByteBuffer _bb, FB_TianCiHongFuBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TianCiHongFuBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string BeiJing { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TitleDesc { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetShowTimeList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowTimeListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetContinueTimeList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ContinueTimeListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianCiHongFuBase> CreateFB_TianCiHongFuBase(FlatBufferBuilder builder,
      int ID = 0,
      int actType = 0,
      int MaxNum = 0,
      StringOffset BeiJing = default(StringOffset),
      StringOffset TitleDesc = default(StringOffset),
      VectorOffset ShowTimeList = default(VectorOffset),
      VectorOffset ContinueTimeList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_TianCiHongFuBase.AddContinueTimeList(builder, ContinueTimeList);
    FB_TianCiHongFuBase.AddShowTimeList(builder, ShowTimeList);
    FB_TianCiHongFuBase.AddTitleDesc(builder, TitleDesc);
    FB_TianCiHongFuBase.AddBeiJing(builder, BeiJing);
    FB_TianCiHongFuBase.AddMaxNum(builder, MaxNum);
    FB_TianCiHongFuBase.AddActType(builder, actType);
    FB_TianCiHongFuBase.AddID(builder, ID);
    return FB_TianCiHongFuBase.EndFB_TianCiHongFuBase(builder);
  }

  public static void StartFB_TianCiHongFuBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActType(FlatBufferBuilder builder, int actType) { builder.AddInt(1, actType, 0); }
  public static void AddMaxNum(FlatBufferBuilder builder, int MaxNum) { builder.AddInt(2, MaxNum, 0); }
  public static void AddBeiJing(FlatBufferBuilder builder, StringOffset BeiJingOffset) { builder.AddOffset(3, BeiJingOffset.Value, 0); }
  public static void AddTitleDesc(FlatBufferBuilder builder, StringOffset TitleDescOffset) { builder.AddOffset(4, TitleDescOffset.Value, 0); }
  public static void AddShowTimeList(FlatBufferBuilder builder, VectorOffset ShowTimeListOffset) { builder.AddOffset(5, ShowTimeListOffset.Value, 0); }
  public static VectorOffset CreateShowTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddContinueTimeList(FlatBufferBuilder builder, VectorOffset ContinueTimeListOffset) { builder.AddOffset(6, ContinueTimeListOffset.Value, 0); }
  public static VectorOffset CreateContinueTimeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartContinueTimeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianCiHongFuBase> EndFB_TianCiHongFuBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianCiHongFuBase>(o);
  }
};

public sealed class FB_TianCiHongFuBaseContainer : Table {
  public static FB_TianCiHongFuBaseContainer GetRootAsFB_TianCiHongFuBaseContainer(ByteBuffer _bb) { return GetRootAsFB_TianCiHongFuBaseContainer(_bb, new FB_TianCiHongFuBaseContainer()); }
  public static FB_TianCiHongFuBaseContainer GetRootAsFB_TianCiHongFuBaseContainer(ByteBuffer _bb, FB_TianCiHongFuBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TianCiHongFuBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TianCiHongFuBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TianCiHongFuBase GetItems(int j) { return GetItems(new FB_TianCiHongFuBase(), j); }
  public FB_TianCiHongFuBase GetItems(FB_TianCiHongFuBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianCiHongFuBaseContainer> CreateFB_TianCiHongFuBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TianCiHongFuBaseContainer.AddItems(builder, items);
    return FB_TianCiHongFuBaseContainer.EndFB_TianCiHongFuBaseContainer(builder);
  }

  public static void StartFB_TianCiHongFuBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TianCiHongFuBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianCiHongFuBaseContainer> EndFB_TianCiHongFuBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianCiHongFuBaseContainer>(o);
  }
  public static void FinishFB_TianCiHongFuBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_TianCiHongFuBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
