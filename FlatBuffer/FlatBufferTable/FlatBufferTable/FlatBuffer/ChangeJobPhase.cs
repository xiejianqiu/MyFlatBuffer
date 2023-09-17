// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChangeJobPhase : Table {
  public static FB_ChangeJobPhase GetRootAsFB_ChangeJobPhase(ByteBuffer _bb) { return GetRootAsFB_ChangeJobPhase(_bb, new FB_ChangeJobPhase()); }
  public static FB_ChangeJobPhase GetRootAsFB_ChangeJobPhase(ByteBuffer _bb, FB_ChangeJobPhase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChangeJobPhase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DictID { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int EndMissionID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMissionList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MissionListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeJobPhase> CreateFB_ChangeJobPhase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset DictID = default(StringOffset),
      int EndMissionID = -1,
      int ItemID = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset MissionList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_ChangeJobPhase.AddMissionList(builder, MissionList);
    FB_ChangeJobPhase.AddAttrValueList(builder, AttrValueList);
    FB_ChangeJobPhase.AddAttrIDList(builder, AttrIDList);
    FB_ChangeJobPhase.AddItemID(builder, ItemID);
    FB_ChangeJobPhase.AddEndMissionID(builder, EndMissionID);
    FB_ChangeJobPhase.AddDictID(builder, DictID);
    FB_ChangeJobPhase.AddName(builder, Name);
    FB_ChangeJobPhase.AddID(builder, ID);
    return FB_ChangeJobPhase.EndFB_ChangeJobPhase(builder);
  }

  public static void StartFB_ChangeJobPhase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDictID(FlatBufferBuilder builder, StringOffset DictIDOffset) { builder.AddOffset(2, DictIDOffset.Value, 0); }
  public static void AddEndMissionID(FlatBufferBuilder builder, int EndMissionID) { builder.AddInt(3, EndMissionID, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(4, ItemID, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(5, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(6, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionList(FlatBufferBuilder builder, VectorOffset MissionListOffset) { builder.AddOffset(7, MissionListOffset.Value, 0); }
  public static VectorOffset CreateMissionListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMissionListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeJobPhase> EndFB_ChangeJobPhase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJobPhase>(o);
  }
};

public sealed class FB_ChangeJobPhaseContainer : Table {
  public static FB_ChangeJobPhaseContainer GetRootAsFB_ChangeJobPhaseContainer(ByteBuffer _bb) { return GetRootAsFB_ChangeJobPhaseContainer(_bb, new FB_ChangeJobPhaseContainer()); }
  public static FB_ChangeJobPhaseContainer GetRootAsFB_ChangeJobPhaseContainer(ByteBuffer _bb, FB_ChangeJobPhaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChangeJobPhaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChangeJobPhaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChangeJobPhase GetItems(int j) { return GetItems(new FB_ChangeJobPhase(), j); }
  public FB_ChangeJobPhase GetItems(FB_ChangeJobPhase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeJobPhaseContainer> CreateFB_ChangeJobPhaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChangeJobPhaseContainer.AddItems(builder, items);
    return FB_ChangeJobPhaseContainer.EndFB_ChangeJobPhaseContainer(builder);
  }

  public static void StartFB_ChangeJobPhaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChangeJobPhase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeJobPhaseContainer> EndFB_ChangeJobPhaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJobPhaseContainer>(o);
  }
  public static void FinishFB_ChangeJobPhaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChangeJobPhaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
