// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Relation : Table {
  public static FB_Relation GetRootAsFB_Relation(ByteBuffer _bb) { return GetRootAsFB_Relation(_bb, new FB_Relation()); }
  public static FB_Relation GetRootAsFB_Relation(ByteBuffer _bb, FB_Relation obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Relation __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRelationList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RelationListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_Relation> CreateFB_Relation(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset Relation_List = default(VectorOffset)) {
    builder.StartObject(2);
    FB_Relation.AddRelationList(builder, Relation_List);
    FB_Relation.AddId(builder, Id);
    return FB_Relation.EndFB_Relation(builder);
  }

  public static void StartFB_Relation(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRelationList(FlatBufferBuilder builder, VectorOffset RelationListOffset) { builder.AddOffset(1, RelationListOffset.Value, 0); }
  public static VectorOffset CreateRelationListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRelationListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_Relation> EndFB_Relation(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Relation>(o);
  }
};

public sealed class FB_RelationContainer : Table {
  public static FB_RelationContainer GetRootAsFB_RelationContainer(ByteBuffer _bb) { return GetRootAsFB_RelationContainer(_bb, new FB_RelationContainer()); }
  public static FB_RelationContainer GetRootAsFB_RelationContainer(ByteBuffer _bb, FB_RelationContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RelationContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RelationContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Relation GetItems(int j) { return GetItems(new FB_Relation(), j); }
  public FB_Relation GetItems(FB_Relation obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RelationContainer> CreateFB_RelationContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RelationContainer.AddItems(builder, items);
    return FB_RelationContainer.EndFB_RelationContainer(builder);
  }

  public static void StartFB_RelationContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Relation>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RelationContainer> EndFB_RelationContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RelationContainer>(o);
  }
  public static void FinishFB_RelationContainerBuffer(FlatBufferBuilder builder, Offset<FB_RelationContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
