// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyTemperRate : Table {
  public static FB_DestinyTemperRate GetRootAsFB_DestinyTemperRate(ByteBuffer _bb) { return GetRootAsFB_DestinyTemperRate(_bb, new FB_DestinyTemperRate()); }
  public static FB_DestinyTemperRate GetRootAsFB_DestinyTemperRate(ByteBuffer _bb, FB_DestinyTemperRate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyTemperRate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRandomRateList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RandomRateListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetExtraRandomRateList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ExtraRandomRateListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetIncreaseRateList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int IncreaseRateListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMinAddValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MinAddValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMaxAddValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaxAddValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyTemperRate> CreateFB_DestinyTemperRate(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset RandomRateList = default(VectorOffset),
      VectorOffset ExtraRandomRateList = default(VectorOffset),
      VectorOffset IncreaseRateList = default(VectorOffset),
      VectorOffset MinAddValueList = default(VectorOffset),
      VectorOffset MaxAddValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_DestinyTemperRate.AddMaxAddValueList(builder, MaxAddValueList);
    FB_DestinyTemperRate.AddMinAddValueList(builder, MinAddValueList);
    FB_DestinyTemperRate.AddIncreaseRateList(builder, IncreaseRateList);
    FB_DestinyTemperRate.AddExtraRandomRateList(builder, ExtraRandomRateList);
    FB_DestinyTemperRate.AddRandomRateList(builder, RandomRateList);
    FB_DestinyTemperRate.AddId(builder, Id);
    return FB_DestinyTemperRate.EndFB_DestinyTemperRate(builder);
  }

  public static void StartFB_DestinyTemperRate(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRandomRateList(FlatBufferBuilder builder, VectorOffset RandomRateListOffset) { builder.AddOffset(1, RandomRateListOffset.Value, 0); }
  public static VectorOffset CreateRandomRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRandomRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtraRandomRateList(FlatBufferBuilder builder, VectorOffset ExtraRandomRateListOffset) { builder.AddOffset(2, ExtraRandomRateListOffset.Value, 0); }
  public static VectorOffset CreateExtraRandomRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartExtraRandomRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIncreaseRateList(FlatBufferBuilder builder, VectorOffset IncreaseRateListOffset) { builder.AddOffset(3, IncreaseRateListOffset.Value, 0); }
  public static VectorOffset CreateIncreaseRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartIncreaseRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMinAddValueList(FlatBufferBuilder builder, VectorOffset MinAddValueListOffset) { builder.AddOffset(4, MinAddValueListOffset.Value, 0); }
  public static VectorOffset CreateMinAddValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMinAddValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxAddValueList(FlatBufferBuilder builder, VectorOffset MaxAddValueListOffset) { builder.AddOffset(5, MaxAddValueListOffset.Value, 0); }
  public static VectorOffset CreateMaxAddValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaxAddValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyTemperRate> EndFB_DestinyTemperRate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyTemperRate>(o);
  }
};

public sealed class FB_DestinyTemperRateContainer : Table {
  public static FB_DestinyTemperRateContainer GetRootAsFB_DestinyTemperRateContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyTemperRateContainer(_bb, new FB_DestinyTemperRateContainer()); }
  public static FB_DestinyTemperRateContainer GetRootAsFB_DestinyTemperRateContainer(ByteBuffer _bb, FB_DestinyTemperRateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyTemperRateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyTemperRateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyTemperRate GetItems(int j) { return GetItems(new FB_DestinyTemperRate(), j); }
  public FB_DestinyTemperRate GetItems(FB_DestinyTemperRate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyTemperRateContainer> CreateFB_DestinyTemperRateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyTemperRateContainer.AddItems(builder, items);
    return FB_DestinyTemperRateContainer.EndFB_DestinyTemperRateContainer(builder);
  }

  public static void StartFB_DestinyTemperRateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyTemperRate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyTemperRateContainer> EndFB_DestinyTemperRateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyTemperRateContainer>(o);
  }
  public static void FinishFB_DestinyTemperRateContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyTemperRateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
