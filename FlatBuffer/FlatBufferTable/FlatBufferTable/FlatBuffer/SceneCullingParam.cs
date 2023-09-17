// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SceneCullingParam : Table {
  public static FB_SceneCullingParam GetRootAsFB_SceneCullingParam(ByteBuffer _bb) { return GetRootAsFB_SceneCullingParam(_bb, new FB_SceneCullingParam()); }
  public static FB_SceneCullingParam GetRootAsFB_SceneCullingParam(ByteBuffer _bb, FB_SceneCullingParam obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SceneCullingParam __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float LowestLOD { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int GetLowestRangeList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowestRangeListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLowestFogList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowestFogListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public float LowLOD { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int GetLowRangeList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowRangeListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLowFogList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowFogListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public float MidLOD { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int GetMidRangeList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MidRangeListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMidFogList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MidFogListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public float HighLOD { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int GetHighRangeList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighRangeListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHighFogList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighFogListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneCullingParam> CreateFB_SceneCullingParam(FlatBufferBuilder builder,
      int ID = 0,
      float LowestLOD = 0,
      VectorOffset LowestRangeList = default(VectorOffset),
      VectorOffset LowestFogList = default(VectorOffset),
      float LowLOD = 0,
      VectorOffset LowRangeList = default(VectorOffset),
      VectorOffset LowFogList = default(VectorOffset),
      float MidLOD = 0,
      VectorOffset MidRangeList = default(VectorOffset),
      VectorOffset MidFogList = default(VectorOffset),
      float HighLOD = 0,
      VectorOffset HighRangeList = default(VectorOffset),
      VectorOffset HighFogList = default(VectorOffset)) {
    builder.StartObject(13);
    FB_SceneCullingParam.AddHighFogList(builder, HighFogList);
    FB_SceneCullingParam.AddHighRangeList(builder, HighRangeList);
    FB_SceneCullingParam.AddHighLOD(builder, HighLOD);
    FB_SceneCullingParam.AddMidFogList(builder, MidFogList);
    FB_SceneCullingParam.AddMidRangeList(builder, MidRangeList);
    FB_SceneCullingParam.AddMidLOD(builder, MidLOD);
    FB_SceneCullingParam.AddLowFogList(builder, LowFogList);
    FB_SceneCullingParam.AddLowRangeList(builder, LowRangeList);
    FB_SceneCullingParam.AddLowLOD(builder, LowLOD);
    FB_SceneCullingParam.AddLowestFogList(builder, LowestFogList);
    FB_SceneCullingParam.AddLowestRangeList(builder, LowestRangeList);
    FB_SceneCullingParam.AddLowestLOD(builder, LowestLOD);
    FB_SceneCullingParam.AddID(builder, ID);
    return FB_SceneCullingParam.EndFB_SceneCullingParam(builder);
  }

  public static void StartFB_SceneCullingParam(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLowestLOD(FlatBufferBuilder builder, float LowestLOD) { builder.AddFloat(1, LowestLOD, 0); }
  public static void AddLowestRangeList(FlatBufferBuilder builder, VectorOffset LowestRangeListOffset) { builder.AddOffset(2, LowestRangeListOffset.Value, 0); }
  public static VectorOffset CreateLowestRangeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowestRangeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLowestFogList(FlatBufferBuilder builder, VectorOffset LowestFogListOffset) { builder.AddOffset(3, LowestFogListOffset.Value, 0); }
  public static VectorOffset CreateLowestFogListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowestFogListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLowLOD(FlatBufferBuilder builder, float LowLOD) { builder.AddFloat(4, LowLOD, 0); }
  public static void AddLowRangeList(FlatBufferBuilder builder, VectorOffset LowRangeListOffset) { builder.AddOffset(5, LowRangeListOffset.Value, 0); }
  public static VectorOffset CreateLowRangeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowRangeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLowFogList(FlatBufferBuilder builder, VectorOffset LowFogListOffset) { builder.AddOffset(6, LowFogListOffset.Value, 0); }
  public static VectorOffset CreateLowFogListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowFogListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMidLOD(FlatBufferBuilder builder, float MidLOD) { builder.AddFloat(7, MidLOD, 0); }
  public static void AddMidRangeList(FlatBufferBuilder builder, VectorOffset MidRangeListOffset) { builder.AddOffset(8, MidRangeListOffset.Value, 0); }
  public static VectorOffset CreateMidRangeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMidRangeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMidFogList(FlatBufferBuilder builder, VectorOffset MidFogListOffset) { builder.AddOffset(9, MidFogListOffset.Value, 0); }
  public static VectorOffset CreateMidFogListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMidFogListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighLOD(FlatBufferBuilder builder, float HighLOD) { builder.AddFloat(10, HighLOD, 0); }
  public static void AddHighRangeList(FlatBufferBuilder builder, VectorOffset HighRangeListOffset) { builder.AddOffset(11, HighRangeListOffset.Value, 0); }
  public static VectorOffset CreateHighRangeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighRangeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighFogList(FlatBufferBuilder builder, VectorOffset HighFogListOffset) { builder.AddOffset(12, HighFogListOffset.Value, 0); }
  public static VectorOffset CreateHighFogListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighFogListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneCullingParam> EndFB_SceneCullingParam(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneCullingParam>(o);
  }
};

public sealed class FB_SceneCullingParamContainer : Table {
  public static FB_SceneCullingParamContainer GetRootAsFB_SceneCullingParamContainer(ByteBuffer _bb) { return GetRootAsFB_SceneCullingParamContainer(_bb, new FB_SceneCullingParamContainer()); }
  public static FB_SceneCullingParamContainer GetRootAsFB_SceneCullingParamContainer(ByteBuffer _bb, FB_SceneCullingParamContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SceneCullingParamContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SceneCullingParamContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SceneCullingParam GetItems(int j) { return GetItems(new FB_SceneCullingParam(), j); }
  public FB_SceneCullingParam GetItems(FB_SceneCullingParam obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SceneCullingParamContainer> CreateFB_SceneCullingParamContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SceneCullingParamContainer.AddItems(builder, items);
    return FB_SceneCullingParamContainer.EndFB_SceneCullingParamContainer(builder);
  }

  public static void StartFB_SceneCullingParamContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SceneCullingParam>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SceneCullingParamContainer> EndFB_SceneCullingParamContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SceneCullingParamContainer>(o);
  }
  public static void FinishFB_SceneCullingParamContainerBuffer(FlatBufferBuilder builder, Offset<FB_SceneCullingParamContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
