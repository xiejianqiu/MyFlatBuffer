// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityObjectivesList : Table {
  public static FB_ActivityObjectivesList GetRootAsFB_ActivityObjectivesList(ByteBuffer _bb) { return GetRootAsFB_ActivityObjectivesList(_bb, new FB_ActivityObjectivesList()); }
  public static FB_ActivityObjectivesList GetRootAsFB_ActivityObjectivesList(ByteBuffer _bb, FB_ActivityObjectivesList obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityObjectivesList __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MaxObjectives { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetObjIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ObjIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityObjectivesList> CreateFB_ActivityObjectivesList(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int MaxObjectives = -1,
      VectorOffset ObjIDList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_ActivityObjectivesList.AddObjIDList(builder, ObjIDList);
    FB_ActivityObjectivesList.AddMaxObjectives(builder, MaxObjectives);
    FB_ActivityObjectivesList.AddName(builder, Name);
    FB_ActivityObjectivesList.AddID(builder, ID);
    return FB_ActivityObjectivesList.EndFB_ActivityObjectivesList(builder);
  }

  public static void StartFB_ActivityObjectivesList(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMaxObjectives(FlatBufferBuilder builder, int MaxObjectives) { builder.AddInt(2, MaxObjectives, -1); }
  public static void AddObjIDList(FlatBufferBuilder builder, VectorOffset ObjIDListOffset) { builder.AddOffset(3, ObjIDListOffset.Value, 0); }
  public static VectorOffset CreateObjIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartObjIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityObjectivesList> EndFB_ActivityObjectivesList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityObjectivesList>(o);
  }
};

public sealed class FB_ActivityObjectivesListContainer : Table {
  public static FB_ActivityObjectivesListContainer GetRootAsFB_ActivityObjectivesListContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityObjectivesListContainer(_bb, new FB_ActivityObjectivesListContainer()); }
  public static FB_ActivityObjectivesListContainer GetRootAsFB_ActivityObjectivesListContainer(ByteBuffer _bb, FB_ActivityObjectivesListContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityObjectivesListContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityObjectivesListContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityObjectivesList GetItems(int j) { return GetItems(new FB_ActivityObjectivesList(), j); }
  public FB_ActivityObjectivesList GetItems(FB_ActivityObjectivesList obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityObjectivesListContainer> CreateFB_ActivityObjectivesListContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityObjectivesListContainer.AddItems(builder, items);
    return FB_ActivityObjectivesListContainer.EndFB_ActivityObjectivesListContainer(builder);
  }

  public static void StartFB_ActivityObjectivesListContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityObjectivesList>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityObjectivesListContainer> EndFB_ActivityObjectivesListContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityObjectivesListContainer>(o);
  }
  public static void FinishFB_ActivityObjectivesListContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityObjectivesListContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
