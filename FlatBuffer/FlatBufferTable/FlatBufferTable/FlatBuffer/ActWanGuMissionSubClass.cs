// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActWanGuMissionSubClass : Table {
  public static FB_ActWanGuMissionSubClass GetRootAsFB_ActWanGuMissionSubClass(ByteBuffer _bb) { return GetRootAsFB_ActWanGuMissionSubClass(_bb, new FB_ActWanGuMissionSubClass()); }
  public static FB_ActWanGuMissionSubClass GetRootAsFB_ActWanGuMissionSubClass(ByteBuffer _bb, FB_ActWanGuMissionSubClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActWanGuMissionSubClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMissionIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MissionIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int ActWanGuId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActWanGuMissionSubClass> CreateFB_ActWanGuMissionSubClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      VectorOffset MissionIDList = default(VectorOffset),
      int ActWanGuId = -1) {
    builder.StartObject(5);
    FB_ActWanGuMissionSubClass.AddActWanGuId(builder, ActWanGuId);
    FB_ActWanGuMissionSubClass.AddMissionIDList(builder, MissionIDList);
    FB_ActWanGuMissionSubClass.AddType(builder, Type);
    FB_ActWanGuMissionSubClass.AddName(builder, Name);
    FB_ActWanGuMissionSubClass.AddID(builder, ID);
    return FB_ActWanGuMissionSubClass.EndFB_ActWanGuMissionSubClass(builder);
  }

  public static void StartFB_ActWanGuMissionSubClass(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddMissionIDList(FlatBufferBuilder builder, VectorOffset MissionIDListOffset) { builder.AddOffset(3, MissionIDListOffset.Value, 0); }
  public static VectorOffset CreateMissionIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMissionIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddActWanGuId(FlatBufferBuilder builder, int ActWanGuId) { builder.AddInt(4, ActWanGuId, -1); }
  public static Offset<FB_ActWanGuMissionSubClass> EndFB_ActWanGuMissionSubClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuMissionSubClass>(o);
  }
};

public sealed class FB_ActWanGuMissionSubClassContainer : Table {
  public static FB_ActWanGuMissionSubClassContainer GetRootAsFB_ActWanGuMissionSubClassContainer(ByteBuffer _bb) { return GetRootAsFB_ActWanGuMissionSubClassContainer(_bb, new FB_ActWanGuMissionSubClassContainer()); }
  public static FB_ActWanGuMissionSubClassContainer GetRootAsFB_ActWanGuMissionSubClassContainer(ByteBuffer _bb, FB_ActWanGuMissionSubClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActWanGuMissionSubClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActWanGuMissionSubClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActWanGuMissionSubClass GetItems(int j) { return GetItems(new FB_ActWanGuMissionSubClass(), j); }
  public FB_ActWanGuMissionSubClass GetItems(FB_ActWanGuMissionSubClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActWanGuMissionSubClassContainer> CreateFB_ActWanGuMissionSubClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActWanGuMissionSubClassContainer.AddItems(builder, items);
    return FB_ActWanGuMissionSubClassContainer.EndFB_ActWanGuMissionSubClassContainer(builder);
  }

  public static void StartFB_ActWanGuMissionSubClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActWanGuMissionSubClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActWanGuMissionSubClassContainer> EndFB_ActWanGuMissionSubClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActWanGuMissionSubClassContainer>(o);
  }
  public static void FinishFB_ActWanGuMissionSubClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActWanGuMissionSubClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
