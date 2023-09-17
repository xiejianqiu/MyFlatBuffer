// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHZaDanPingGuoShow : Table {
  public static FB_SYHZaDanPingGuoShow GetRootAsFB_SYHZaDanPingGuoShow(ByteBuffer _bb) { return GetRootAsFB_SYHZaDanPingGuoShow(_bb, new FB_SYHZaDanPingGuoShow()); }
  public static FB_SYHZaDanPingGuoShow GetRootAsFB_SYHZaDanPingGuoShow(ByteBuffer _bb, FB_SYHZaDanPingGuoShow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHZaDanPingGuoShow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetFirstRowIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FirstRowIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFirstRowNumList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FirstRowNumListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSecondRowIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SecondRowIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSecondRowNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SecondRowNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetThirdRowIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ThirdRowIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetThirdRowNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ThirdRowNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHZaDanPingGuoShow> CreateFB_SYHZaDanPingGuoShow(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset FirstRowIDList = default(VectorOffset),
      VectorOffset FirstRowNumList = default(VectorOffset),
      VectorOffset SecondRowIDList = default(VectorOffset),
      VectorOffset SecondRowNumList = default(VectorOffset),
      VectorOffset ThirdRowIDList = default(VectorOffset),
      VectorOffset ThirdRowNumList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_SYHZaDanPingGuoShow.AddThirdRowNumList(builder, ThirdRowNumList);
    FB_SYHZaDanPingGuoShow.AddThirdRowIDList(builder, ThirdRowIDList);
    FB_SYHZaDanPingGuoShow.AddSecondRowNumList(builder, SecondRowNumList);
    FB_SYHZaDanPingGuoShow.AddSecondRowIDList(builder, SecondRowIDList);
    FB_SYHZaDanPingGuoShow.AddFirstRowNumList(builder, FirstRowNumList);
    FB_SYHZaDanPingGuoShow.AddFirstRowIDList(builder, FirstRowIDList);
    FB_SYHZaDanPingGuoShow.AddID(builder, ID);
    return FB_SYHZaDanPingGuoShow.EndFB_SYHZaDanPingGuoShow(builder);
  }

  public static void StartFB_SYHZaDanPingGuoShow(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddFirstRowIDList(FlatBufferBuilder builder, VectorOffset FirstRowIDListOffset) { builder.AddOffset(1, FirstRowIDListOffset.Value, 0); }
  public static VectorOffset CreateFirstRowIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFirstRowIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFirstRowNumList(FlatBufferBuilder builder, VectorOffset FirstRowNumListOffset) { builder.AddOffset(2, FirstRowNumListOffset.Value, 0); }
  public static VectorOffset CreateFirstRowNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFirstRowNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSecondRowIDList(FlatBufferBuilder builder, VectorOffset SecondRowIDListOffset) { builder.AddOffset(3, SecondRowIDListOffset.Value, 0); }
  public static VectorOffset CreateSecondRowIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSecondRowIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSecondRowNumList(FlatBufferBuilder builder, VectorOffset SecondRowNumListOffset) { builder.AddOffset(4, SecondRowNumListOffset.Value, 0); }
  public static VectorOffset CreateSecondRowNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSecondRowNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddThirdRowIDList(FlatBufferBuilder builder, VectorOffset ThirdRowIDListOffset) { builder.AddOffset(5, ThirdRowIDListOffset.Value, 0); }
  public static VectorOffset CreateThirdRowIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartThirdRowIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddThirdRowNumList(FlatBufferBuilder builder, VectorOffset ThirdRowNumListOffset) { builder.AddOffset(6, ThirdRowNumListOffset.Value, 0); }
  public static VectorOffset CreateThirdRowNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartThirdRowNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHZaDanPingGuoShow> EndFB_SYHZaDanPingGuoShow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHZaDanPingGuoShow>(o);
  }
};

public sealed class FB_SYHZaDanPingGuoShowContainer : Table {
  public static FB_SYHZaDanPingGuoShowContainer GetRootAsFB_SYHZaDanPingGuoShowContainer(ByteBuffer _bb) { return GetRootAsFB_SYHZaDanPingGuoShowContainer(_bb, new FB_SYHZaDanPingGuoShowContainer()); }
  public static FB_SYHZaDanPingGuoShowContainer GetRootAsFB_SYHZaDanPingGuoShowContainer(ByteBuffer _bb, FB_SYHZaDanPingGuoShowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHZaDanPingGuoShowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHZaDanPingGuoShowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHZaDanPingGuoShow GetItems(int j) { return GetItems(new FB_SYHZaDanPingGuoShow(), j); }
  public FB_SYHZaDanPingGuoShow GetItems(FB_SYHZaDanPingGuoShow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHZaDanPingGuoShowContainer> CreateFB_SYHZaDanPingGuoShowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHZaDanPingGuoShowContainer.AddItems(builder, items);
    return FB_SYHZaDanPingGuoShowContainer.EndFB_SYHZaDanPingGuoShowContainer(builder);
  }

  public static void StartFB_SYHZaDanPingGuoShowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHZaDanPingGuoShow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHZaDanPingGuoShowContainer> EndFB_SYHZaDanPingGuoShowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHZaDanPingGuoShowContainer>(o);
  }
  public static void FinishFB_SYHZaDanPingGuoShowContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHZaDanPingGuoShowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
