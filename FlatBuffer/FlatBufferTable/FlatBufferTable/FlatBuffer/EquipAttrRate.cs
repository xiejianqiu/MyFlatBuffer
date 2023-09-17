// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipAttrRate : Table {
  public static FB_EquipAttrRate GetRootAsFB_EquipAttrRate(ByteBuffer _bb) { return GetRootAsFB_EquipAttrRate(_bb, new FB_EquipAttrRate()); }
  public static FB_EquipAttrRate GetRootAsFB_EquipAttrRate(ByteBuffer _bb, FB_EquipAttrRate obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipAttrRate __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GoldenAttrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetPurpleAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PurpleAttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetPurpleAttrRateList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PurpleAttrRateListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBlueAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BlueAttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBlueAttrRateList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BlueAttrRateListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetShenZhuangAttrIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShenZhuangAttrIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetShenZhuangAttrRateList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShenZhuangAttrRateListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipAttrRate> CreateFB_EquipAttrRate(FlatBufferBuilder builder,
      int Id = 0,
      int GoldenAttrId = 0,
      VectorOffset PurpleAttrIdList = default(VectorOffset),
      VectorOffset PurpleAttrRateList = default(VectorOffset),
      VectorOffset BlueAttrIdList = default(VectorOffset),
      VectorOffset BlueAttrRateList = default(VectorOffset),
      VectorOffset ShenZhuangAttrIdList = default(VectorOffset),
      VectorOffset ShenZhuangAttrRateList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_EquipAttrRate.AddShenZhuangAttrRateList(builder, ShenZhuangAttrRateList);
    FB_EquipAttrRate.AddShenZhuangAttrIdList(builder, ShenZhuangAttrIdList);
    FB_EquipAttrRate.AddBlueAttrRateList(builder, BlueAttrRateList);
    FB_EquipAttrRate.AddBlueAttrIdList(builder, BlueAttrIdList);
    FB_EquipAttrRate.AddPurpleAttrRateList(builder, PurpleAttrRateList);
    FB_EquipAttrRate.AddPurpleAttrIdList(builder, PurpleAttrIdList);
    FB_EquipAttrRate.AddGoldenAttrId(builder, GoldenAttrId);
    FB_EquipAttrRate.AddId(builder, Id);
    return FB_EquipAttrRate.EndFB_EquipAttrRate(builder);
  }

  public static void StartFB_EquipAttrRate(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGoldenAttrId(FlatBufferBuilder builder, int GoldenAttrId) { builder.AddInt(1, GoldenAttrId, 0); }
  public static void AddPurpleAttrIdList(FlatBufferBuilder builder, VectorOffset PurpleAttrIdListOffset) { builder.AddOffset(2, PurpleAttrIdListOffset.Value, 0); }
  public static VectorOffset CreatePurpleAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPurpleAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPurpleAttrRateList(FlatBufferBuilder builder, VectorOffset PurpleAttrRateListOffset) { builder.AddOffset(3, PurpleAttrRateListOffset.Value, 0); }
  public static VectorOffset CreatePurpleAttrRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPurpleAttrRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBlueAttrIdList(FlatBufferBuilder builder, VectorOffset BlueAttrIdListOffset) { builder.AddOffset(4, BlueAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateBlueAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBlueAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBlueAttrRateList(FlatBufferBuilder builder, VectorOffset BlueAttrRateListOffset) { builder.AddOffset(5, BlueAttrRateListOffset.Value, 0); }
  public static VectorOffset CreateBlueAttrRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBlueAttrRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShenZhuangAttrIdList(FlatBufferBuilder builder, VectorOffset ShenZhuangAttrIdListOffset) { builder.AddOffset(6, ShenZhuangAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateShenZhuangAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShenZhuangAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShenZhuangAttrRateList(FlatBufferBuilder builder, VectorOffset ShenZhuangAttrRateListOffset) { builder.AddOffset(7, ShenZhuangAttrRateListOffset.Value, 0); }
  public static VectorOffset CreateShenZhuangAttrRateListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShenZhuangAttrRateListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipAttrRate> EndFB_EquipAttrRate(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipAttrRate>(o);
  }
};

public sealed class FB_EquipAttrRateContainer : Table {
  public static FB_EquipAttrRateContainer GetRootAsFB_EquipAttrRateContainer(ByteBuffer _bb) { return GetRootAsFB_EquipAttrRateContainer(_bb, new FB_EquipAttrRateContainer()); }
  public static FB_EquipAttrRateContainer GetRootAsFB_EquipAttrRateContainer(ByteBuffer _bb, FB_EquipAttrRateContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipAttrRateContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipAttrRateContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipAttrRate GetItems(int j) { return GetItems(new FB_EquipAttrRate(), j); }
  public FB_EquipAttrRate GetItems(FB_EquipAttrRate obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipAttrRateContainer> CreateFB_EquipAttrRateContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipAttrRateContainer.AddItems(builder, items);
    return FB_EquipAttrRateContainer.EndFB_EquipAttrRateContainer(builder);
  }

  public static void StartFB_EquipAttrRateContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipAttrRate>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipAttrRateContainer> EndFB_EquipAttrRateContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipAttrRateContainer>(o);
  }
  public static void FinishFB_EquipAttrRateContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipAttrRateContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
