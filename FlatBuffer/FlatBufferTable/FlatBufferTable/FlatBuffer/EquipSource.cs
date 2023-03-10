// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipSource : Table {
  public static FB_EquipSource GetRootAsFB_EquipSource(ByteBuffer _bb) { return GetRootAsFB_EquipSource(_bb, new FB_EquipSource()); }
  public static FB_EquipSource GetRootAsFB_EquipSource(ByteBuffer _bb, FB_EquipSource obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipSource __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Low { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int High { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetQualityPercentList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int QualityPercentListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetQualityLowList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int QualityLowListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetQualityHighList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int QualityHighListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSource> CreateFB_EquipSource(FlatBufferBuilder builder,
      int Id = 0,
      int Low = -1,
      int High = -1,
      VectorOffset QualityPercentList = default(VectorOffset),
      VectorOffset QualityLowList = default(VectorOffset),
      VectorOffset QualityHighList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_EquipSource.AddQualityHighList(builder, QualityHighList);
    FB_EquipSource.AddQualityLowList(builder, QualityLowList);
    FB_EquipSource.AddQualityPercentList(builder, QualityPercentList);
    FB_EquipSource.AddHigh(builder, High);
    FB_EquipSource.AddLow(builder, Low);
    FB_EquipSource.AddId(builder, Id);
    return FB_EquipSource.EndFB_EquipSource(builder);
  }

  public static void StartFB_EquipSource(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLow(FlatBufferBuilder builder, int Low) { builder.AddInt(1, Low, -1); }
  public static void AddHigh(FlatBufferBuilder builder, int High) { builder.AddInt(2, High, -1); }
  public static void AddQualityPercentList(FlatBufferBuilder builder, VectorOffset QualityPercentListOffset) { builder.AddOffset(3, QualityPercentListOffset.Value, 0); }
  public static VectorOffset CreateQualityPercentListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartQualityPercentListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddQualityLowList(FlatBufferBuilder builder, VectorOffset QualityLowListOffset) { builder.AddOffset(4, QualityLowListOffset.Value, 0); }
  public static VectorOffset CreateQualityLowListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartQualityLowListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddQualityHighList(FlatBufferBuilder builder, VectorOffset QualityHighListOffset) { builder.AddOffset(5, QualityHighListOffset.Value, 0); }
  public static VectorOffset CreateQualityHighListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartQualityHighListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSource> EndFB_EquipSource(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSource>(o);
  }
};

public sealed class FB_EquipSourceContainer : Table {
  public static FB_EquipSourceContainer GetRootAsFB_EquipSourceContainer(ByteBuffer _bb) { return GetRootAsFB_EquipSourceContainer(_bb, new FB_EquipSourceContainer()); }
  public static FB_EquipSourceContainer GetRootAsFB_EquipSourceContainer(ByteBuffer _bb, FB_EquipSourceContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipSourceContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipSourceContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipSource GetItems(int j) { return GetItems(new FB_EquipSource(), j); }
  public FB_EquipSource GetItems(FB_EquipSource obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipSourceContainer> CreateFB_EquipSourceContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipSourceContainer.AddItems(builder, items);
    return FB_EquipSourceContainer.EndFB_EquipSourceContainer(builder);
  }

  public static void StartFB_EquipSourceContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipSource>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipSourceContainer> EndFB_EquipSourceContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipSourceContainer>(o);
  }
  public static void FinishFB_EquipSourceContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipSourceContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
