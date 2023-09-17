// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BloodPossessed : Table {
  public static FB_BloodPossessed GetRootAsFB_BloodPossessed(ByteBuffer _bb) { return GetRootAsFB_BloodPossessed(_bb, new FB_BloodPossessed()); }
  public static FB_BloodPossessed GetRootAsFB_BloodPossessed(ByteBuffer _bb, FB_BloodPossessed obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BloodPossessed __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CoolDownTimeID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DurationTime { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvancedLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrTypeList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrTypeListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetImpactIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ImpactIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetJobModelIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int JobModelIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BloodPossessed> CreateFB_BloodPossessed(FlatBufferBuilder builder,
      int ID = 0,
      int CoolDownTimeID = -1,
      int DurationTime = -1,
      int AdvancedLevel = -1,
      VectorOffset AttrTypeList = default(VectorOffset),
      VectorOffset AttrList = default(VectorOffset),
      VectorOffset ImpactIDList = default(VectorOffset),
      VectorOffset JobModelIDList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_BloodPossessed.AddJobModelIDList(builder, JobModelIDList);
    FB_BloodPossessed.AddImpactIDList(builder, ImpactIDList);
    FB_BloodPossessed.AddAttrList(builder, AttrList);
    FB_BloodPossessed.AddAttrTypeList(builder, AttrTypeList);
    FB_BloodPossessed.AddAdvancedLevel(builder, AdvancedLevel);
    FB_BloodPossessed.AddDurationTime(builder, DurationTime);
    FB_BloodPossessed.AddCoolDownTimeID(builder, CoolDownTimeID);
    FB_BloodPossessed.AddID(builder, ID);
    return FB_BloodPossessed.EndFB_BloodPossessed(builder);
  }

  public static void StartFB_BloodPossessed(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCoolDownTimeID(FlatBufferBuilder builder, int CoolDownTimeID) { builder.AddInt(1, CoolDownTimeID, -1); }
  public static void AddDurationTime(FlatBufferBuilder builder, int DurationTime) { builder.AddInt(2, DurationTime, -1); }
  public static void AddAdvancedLevel(FlatBufferBuilder builder, int AdvancedLevel) { builder.AddInt(3, AdvancedLevel, -1); }
  public static void AddAttrTypeList(FlatBufferBuilder builder, VectorOffset AttrTypeListOffset) { builder.AddOffset(4, AttrTypeListOffset.Value, 0); }
  public static VectorOffset CreateAttrTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrList(FlatBufferBuilder builder, VectorOffset AttrListOffset) { builder.AddOffset(5, AttrListOffset.Value, 0); }
  public static VectorOffset CreateAttrListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddImpactIDList(FlatBufferBuilder builder, VectorOffset ImpactIDListOffset) { builder.AddOffset(6, ImpactIDListOffset.Value, 0); }
  public static VectorOffset CreateImpactIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartImpactIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddJobModelIDList(FlatBufferBuilder builder, VectorOffset JobModelIDListOffset) { builder.AddOffset(7, JobModelIDListOffset.Value, 0); }
  public static VectorOffset CreateJobModelIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartJobModelIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BloodPossessed> EndFB_BloodPossessed(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodPossessed>(o);
  }
};

public sealed class FB_BloodPossessedContainer : Table {
  public static FB_BloodPossessedContainer GetRootAsFB_BloodPossessedContainer(ByteBuffer _bb) { return GetRootAsFB_BloodPossessedContainer(_bb, new FB_BloodPossessedContainer()); }
  public static FB_BloodPossessedContainer GetRootAsFB_BloodPossessedContainer(ByteBuffer _bb, FB_BloodPossessedContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BloodPossessedContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BloodPossessedContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BloodPossessed GetItems(int j) { return GetItems(new FB_BloodPossessed(), j); }
  public FB_BloodPossessed GetItems(FB_BloodPossessed obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BloodPossessedContainer> CreateFB_BloodPossessedContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BloodPossessedContainer.AddItems(builder, items);
    return FB_BloodPossessedContainer.EndFB_BloodPossessedContainer(builder);
  }

  public static void StartFB_BloodPossessedContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BloodPossessed>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BloodPossessedContainer> EndFB_BloodPossessedContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodPossessedContainer>(o);
  }
  public static void FinishFB_BloodPossessedContainerBuffer(FlatBufferBuilder builder, Offset<FB_BloodPossessedContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
