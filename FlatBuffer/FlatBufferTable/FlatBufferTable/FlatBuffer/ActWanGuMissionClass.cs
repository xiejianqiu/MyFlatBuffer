// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActWanGuMissionClass : Table {
  public static FB_ActWanGuMissionClass GetRootAsFB_ActWanGuMissionClass(ByteBuffer _bb) { return GetRootAsFB_ActWanGuMissionClass(_bb, new FB_ActWanGuMissionClass()); }
  public static FB_ActWanGuMissionClass GetRootAsFB_ActWanGuMissionClass(ByteBuffer _bb, FB_ActWanGuMissionClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActWanGuMissionClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetSubClassIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SubClassIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int ActWanGuId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitDay { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActWanGuMissionClass> CreateFB_ActWanGuMissionClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset SubClassIDList = default(VectorOffset),
      int ActWanGuId = -1,
      int LimitDay = -1) {
    builder.StartObject(5);
    FB_ActWanGuMissionClass.AddLimitDay(builder, LimitDay);
    FB_ActWanGuMissionClass.AddActWanGuId(builder, ActWanGuId);
    FB_ActWanGuMissionClass.AddSubClassIDList(builder, SubClassIDList);
    FB_ActWanGuMissionClass.AddName(builder, Name);
    FB_ActWanGuMissionClass.AddID(builder, ID);
    return FB_ActWanGuMissionClass.EndFB_ActWanGuMissionClass(builder);
  }

  public static void StartFB_ActWanGuMissionClass(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddSubClassIDList(FlatBufferBuilder builder, VectorOffset SubClassIDListOffset) { builder.AddOffset(2, SubClassIDListOffset.Value, 0); }
  public static VectorOffset CreateSubClassIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSubClassIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddActWanGuId(FlatBufferBuilder builder, int ActWanGuId) { builder.AddInt(3, ActWanGuId, -1); }
  public static void AddLimitDay(FlatBufferBuilder builder, int LimitDay) { builder.AddInt(4, LimitDay, -1); }
  public static Offset<FB_ActWanGuMissionClass> EndFB_ActWanGuMissionClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuMissionClass>(o);
  }
};

public sealed class FB_ActWanGuMissionClassContainer : Table {
  public static FB_ActWanGuMissionClassContainer GetRootAsFB_ActWanGuMissionClassContainer(ByteBuffer _bb) { return GetRootAsFB_ActWanGuMissionClassContainer(_bb, new FB_ActWanGuMissionClassContainer()); }
  public static FB_ActWanGuMissionClassContainer GetRootAsFB_ActWanGuMissionClassContainer(ByteBuffer _bb, FB_ActWanGuMissionClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActWanGuMissionClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActWanGuMissionClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActWanGuMissionClass GetItems(int j) { return GetItems(new FB_ActWanGuMissionClass(), j); }
  public FB_ActWanGuMissionClass GetItems(FB_ActWanGuMissionClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuMissionClassContainer> CreateFB_ActWanGuMissionClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActWanGuMissionClassContainer.AddItems(builder, items);
    return FB_ActWanGuMissionClassContainer.EndFB_ActWanGuMissionClassContainer(builder);
  }

  public static void StartFB_ActWanGuMissionClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActWanGuMissionClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuMissionClassContainer> EndFB_ActWanGuMissionClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuMissionClassContainer>(o);
  }
  public static void FinishFB_ActWanGuMissionClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActWanGuMissionClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
