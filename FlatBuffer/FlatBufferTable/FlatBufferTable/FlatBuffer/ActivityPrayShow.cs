// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityPrayShow : Table {
  public static FB_ActivityPrayShow GetRootAsFB_ActivityPrayShow(ByteBuffer _bb) { return GetRootAsFB_ActivityPrayShow(_bb, new FB_ActivityPrayShow()); }
  public static FB_ActivityPrayShow GetRootAsFB_ActivityPrayShow(ByteBuffer _bb, FB_ActivityPrayShow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityPrayShow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

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
  public int GetFourRowIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FourRowIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFourRowNumList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FourRowNumListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFiveRowIDList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FiveRowIDListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFiveRowNumList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FiveRowNumListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSixRowIDList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SixRowIDListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSixRowNumList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SixRowNumListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityPrayShow> CreateFB_ActivityPrayShow(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset FirstRowIDList = default(VectorOffset),
      VectorOffset FirstRowNumList = default(VectorOffset),
      VectorOffset SecondRowIDList = default(VectorOffset),
      VectorOffset SecondRowNumList = default(VectorOffset),
      VectorOffset ThirdRowIDList = default(VectorOffset),
      VectorOffset ThirdRowNumList = default(VectorOffset),
      VectorOffset FourRowIDList = default(VectorOffset),
      VectorOffset FourRowNumList = default(VectorOffset),
      VectorOffset FiveRowIDList = default(VectorOffset),
      VectorOffset FiveRowNumList = default(VectorOffset),
      VectorOffset SixRowIDList = default(VectorOffset),
      VectorOffset SixRowNumList = default(VectorOffset)) {
    builder.StartObject(13);
    FB_ActivityPrayShow.AddSixRowNumList(builder, SixRowNumList);
    FB_ActivityPrayShow.AddSixRowIDList(builder, SixRowIDList);
    FB_ActivityPrayShow.AddFiveRowNumList(builder, FiveRowNumList);
    FB_ActivityPrayShow.AddFiveRowIDList(builder, FiveRowIDList);
    FB_ActivityPrayShow.AddFourRowNumList(builder, FourRowNumList);
    FB_ActivityPrayShow.AddFourRowIDList(builder, FourRowIDList);
    FB_ActivityPrayShow.AddThirdRowNumList(builder, ThirdRowNumList);
    FB_ActivityPrayShow.AddThirdRowIDList(builder, ThirdRowIDList);
    FB_ActivityPrayShow.AddSecondRowNumList(builder, SecondRowNumList);
    FB_ActivityPrayShow.AddSecondRowIDList(builder, SecondRowIDList);
    FB_ActivityPrayShow.AddFirstRowNumList(builder, FirstRowNumList);
    FB_ActivityPrayShow.AddFirstRowIDList(builder, FirstRowIDList);
    FB_ActivityPrayShow.AddID(builder, ID);
    return FB_ActivityPrayShow.EndFB_ActivityPrayShow(builder);
  }

  public static void StartFB_ActivityPrayShow(FlatBufferBuilder builder) { builder.StartObject(13); }
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
  public static void AddFourRowIDList(FlatBufferBuilder builder, VectorOffset FourRowIDListOffset) { builder.AddOffset(7, FourRowIDListOffset.Value, 0); }
  public static VectorOffset CreateFourRowIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFourRowIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFourRowNumList(FlatBufferBuilder builder, VectorOffset FourRowNumListOffset) { builder.AddOffset(8, FourRowNumListOffset.Value, 0); }
  public static VectorOffset CreateFourRowNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFourRowNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFiveRowIDList(FlatBufferBuilder builder, VectorOffset FiveRowIDListOffset) { builder.AddOffset(9, FiveRowIDListOffset.Value, 0); }
  public static VectorOffset CreateFiveRowIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFiveRowIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFiveRowNumList(FlatBufferBuilder builder, VectorOffset FiveRowNumListOffset) { builder.AddOffset(10, FiveRowNumListOffset.Value, 0); }
  public static VectorOffset CreateFiveRowNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFiveRowNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSixRowIDList(FlatBufferBuilder builder, VectorOffset SixRowIDListOffset) { builder.AddOffset(11, SixRowIDListOffset.Value, 0); }
  public static VectorOffset CreateSixRowIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSixRowIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSixRowNumList(FlatBufferBuilder builder, VectorOffset SixRowNumListOffset) { builder.AddOffset(12, SixRowNumListOffset.Value, 0); }
  public static VectorOffset CreateSixRowNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSixRowNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityPrayShow> EndFB_ActivityPrayShow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPrayShow>(o);
  }
};

public sealed class FB_ActivityPrayShowContainer : Table {
  public static FB_ActivityPrayShowContainer GetRootAsFB_ActivityPrayShowContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityPrayShowContainer(_bb, new FB_ActivityPrayShowContainer()); }
  public static FB_ActivityPrayShowContainer GetRootAsFB_ActivityPrayShowContainer(ByteBuffer _bb, FB_ActivityPrayShowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityPrayShowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityPrayShowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityPrayShow GetItems(int j) { return GetItems(new FB_ActivityPrayShow(), j); }
  public FB_ActivityPrayShow GetItems(FB_ActivityPrayShow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityPrayShowContainer> CreateFB_ActivityPrayShowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityPrayShowContainer.AddItems(builder, items);
    return FB_ActivityPrayShowContainer.EndFB_ActivityPrayShowContainer(builder);
  }

  public static void StartFB_ActivityPrayShowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityPrayShow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityPrayShowContainer> EndFB_ActivityPrayShowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityPrayShowContainer>(o);
  }
  public static void FinishFB_ActivityPrayShowContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityPrayShowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
